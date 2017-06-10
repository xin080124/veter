package dao;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import java.util.UUID;

import com.datastax.driver.core.Cluster;
import com.datastax.driver.core.ResultSet;
import com.datastax.driver.core.Row;
import com.datastax.driver.core.Session;

import model.Count;
import model.Dist;


public class Cassandra {

	Cluster cluster;
	Session session;
	
	//date format
	private static DateFormat df6 = new SimpleDateFormat("E MMM dd HH:mm:ss Z yyyy", Locale.US);
	private static DateFormat dfRedis = new SimpleDateFormat("yyyyMMddHHmmss", Locale.US);

	public Cassandra() {
		// Connect to the cluster and keyspace "demo"
		cluster = Cluster.builder().addContactPoint("127.0.0.1").build();

		//
		// cqlsh> CREATE KEYSPACE foursquare WITH replication = {'class':'SimpleStrategy', 'replication_factor' : 3};
		//

		session = cluster.connect("foursquare");
	}

	/**
	 * METHOD: uploadTxtToCassandra
	 * 
	 */
	public static void uploadTxtToCassandra(String FILE){	

		String UserID = "";
		String VenueID = "";
		String VenueCategoryID = "";
		String VenueCategoryName = "";
		float Latitude = 0;
		float Longitude = 0;
		//String Timezone = "";
		Date UTCtime = null;

		int count = 0; 
		
		Cassandra cs = new Cassandra();

		//read file if exits
		BufferedReader reader = null;
		try {
			System.out.println("#Start: " + LocalDateTime.now());
			reader = new BufferedReader(new FileReader(FILE));
			String line = reader.readLine();
			while (line!=null) {

				String s[] = line.split("\\t");
				for (int i = 0; i < s.length; i++) {

					switch (i) {
					case 0:
						UserID = s[i];
						break;
					case 1:
						VenueID = s[i];
						break;
					case 2:
						VenueCategoryID = s[i];
						break;
					case 3:
						VenueCategoryName = s[i];
						break;
					case 4:
						Latitude = Float.parseFloat(s[i]);
						break;
					case 5:
						Longitude = Float.parseFloat(s[i]);
						break;
					case 6:
						//Timezone = s[i];
						break;
					case 7:
						try 
						{
							UTCtime = df6.parse(s[i]);
						} catch (ParseException e) {
							e.printStackTrace();
						}
						break;
					default:
						break;
					}

				}

				count+=1;

				cs.addCheckin(UserID, VenueID, dfRedis.format(UTCtime), Longitude, Latitude, VenueCategoryID);

				cs.addCategory(VenueCategoryID, VenueCategoryName);

				cs.addVenue(VenueID, VenueCategoryID, Longitude, Latitude);
				
				cs.addUser(UserID, "xxxxxxxxxxx");

				//?????????????????
				//cs.addLatLon(VenueID, Longitude, Latitude);

				line = reader.readLine();

				if(count%500 == 0)
					System.out.println(LocalDateTime.now() + " uploaded "+count);
			}
			System.out.println(LocalDateTime.now() + " uploaded "+count);

		} 
		catch (IOException ex) {
			System.err.println(ex.getMessage());
		} finally {
			try { if (reader!=null) reader.close(); } catch (Exception e) {}
		}	
	}


	public boolean createTables(){

		String query; 

		query = "CREATE TABLE incr (now text PRIMARY KEY)";
		session.execute(query);

		query = "insert into incr (now) values ('dummy');";
		session.execute(query);

		query = "CREATE TABLE checkin(checkin_id UUID PRIMARY KEY, "
				+ "user_id text, "
				+ "venue_id text, "
				+ "longitude float, "
				+ "latitude float );";
		session.execute(query);

		query = "CREATE TABLE userCheckin(user_id text, "
				+ "time bigint, checkin_id UUID, "
				+ "PRIMARY KEY (user_id, time));";
		session.execute(query);

		query = "CREATE TABLE venueCheckin(venue_id text, "
				+ "time bigint, checkin_id UUID, "
				+ "PRIMARY KEY (venue_id, time));";
		session.execute(query);

		query = "CREATE TABLE categoryCheckin(category_id text, "
				+ "time bigint, checkin_id UUID, "
				+ "PRIMARY KEY (category_id, time));";
		session.execute(query);

		query = "CREATE TABLE checkinTime(city text, "
				+ "time bigint, checkin_id UUID, "
				+ "PRIMARY KEY (city, time));";
		session.execute(query);

		query = "CREATE TABLE category(category_id text PRIMARY KEY, "
				+ "name text);";
		session.execute(query);       

		query = "CREATE TABLE venue(venue_id text PRIMARY KEY, "
				+ "category_id text, "
				+ "longitude float, "
				+ "latitude float );";
		session.execute(query);
		
		query = "CREATE TABLE categoryvenue(category_id text PRIMARY KEY, "
				+ "venue_id text);";
		session.execute(query);

		query = "CREATE TABLE user(user_id text PRIMARY KEY, "
				+ "name text);";
		session.execute(query);
		
		return true;
	}

	public boolean dropTables(){

		String query; 

		query = "DROP TABLE incr;";
		session.execute(query);

		query = "DROP TABLE checkin;";
		session.execute(query);

		query = "DROP TABLE usercheckin;";
		session.execute(query);

		query = "DROP TABLE venuecheckin;";
		session.execute(query);

		query = "DROP TABLE categorycheckin;";
		session.execute(query);

		query = "DROP TABLE checkintime;";
		session.execute(query);

		query = "DROP TABLE category;";
		session.execute(query);

		query = "DROP TABLE venue;";
		session.execute(query);
		
		query = "DROP TABLE categoryvenue;";
		session.execute(query);

		query = "DROP TABLE user;";
		session.execute(query);

		return true;
	}


	@Override
	protected void finalize() throws Throwable {

		// Clean up the connection by closing it
		cluster.close();

		super.finalize();
	}

	public void addCheckin(String userID, String venueID, String format, float longitude, float latitude,
			String venueCategoryID) {

		ResultSet rs = session.execute("select now() from incr;");    // (3)
		Row row = rs.one();

		UUID checkinID = row.getUUID(0);

		String query1 = "INSERT INTO checkin (checkin_id, user_id, venue_id, longitude, latitude)"
				+ "VALUES( " + checkinID +", "
				+ "'"+ userID +"', "
				+ "'"+ venueID +"', "
				+ longitude +", "
				+ latitude + ");";

		//System.out.println(query1);

		session.execute(query1);

		query1 = "INSERT INTO userCheckin (user_id, time, checkin_id) "
				+ "VALUES( '" + userID +"', "
				+ format +", "
				+ checkinID + ");";

		//System.out.println(query1);

		session.execute(query1);


		query1 = "INSERT INTO venueCheckin (venue_id, time, checkin_id) "
				+ "VALUES( '" + venueID +"', "
				+ format +", "
				+ checkinID + ");";

		//System.out.println(query1);

		session.execute(query1);

		query1 = "INSERT INTO categoryCheckin (category_id, time, checkin_id) "
				+ "VALUES( '" + venueCategoryID +"', "
				+ format +", "
				+ checkinID + ");";

		//System.out.println(query1);

		session.execute(query1);

		query1 = "INSERT INTO checkinTime (city, time, checkin_id) "
				+ "VALUES( 'NYC', "
				+ format +", "
				+ checkinID + ");";

		//System.out.println(query1);

		session.execute(query1);


	}

	public void addCategory(String venueCategoryID, String venueCategoryName) {

		String query1;

		query1 = "INSERT INTO category (category_id, name) "
				+ "VALUES( '"+ venueCategoryID +"', "
				+ "'" + venueCategoryName + "');";

		//System.out.println(query1);

		session.execute(query1);

	}

	public void addVenue(String venueID, String venueCategoryID, float longitude, float latitude) {

		String query1;

		query1 = "INSERT INTO venue (venue_id, category_id, longitude, latitude)"
				+ "VALUES( '" + venueID +"', "
				+ "'"+ venueCategoryID +"', "
				+ longitude +", "
				+ latitude + ");";
		session.execute(query1);
		
		query1 = "INSERT INTO categoryvenue (category_id, venue_id)"
				+ "VALUES( '" + venueCategoryID +"', "
				+ "'"+ venueID +"');";
		session.execute(query1);

	}


	public void addUser(String userID, String name) {

		String query1;

		query1 = "INSERT INTO user (user_id, name)"
				+ "VALUES( '" + userID +"', "
				+ "'"+ name +"');";
		session.execute(query1);

	}
	
	public List<Count> getMostPopularVenue(int number, String fromTime, String toTime) {

		List<Count> count = new ArrayList<Count>();

		ResultSet rs = session.execute("select venue_id from venue;");

		for (Row row : rs) {
			// process the row
			String query = "select count(*) from venuecheckin where venue_id='"+row.getString(0)+"'";

			if(!fromTime.isEmpty())
				query += " and time >= "+fromTime;
			if(!toTime.isEmpty())
				query += " and time <= "+toTime;

			query += ";";

			ResultSet subrs = session.execute(query);
			Row subrow = subrs.one(); 
			count.add(new Count(subrow.getLong(0), row.getString(0)));
		}

		Collections.sort(count);

		count = count.subList(0, number > count.size() ? count.size() : number);

		return count;

	}

	public List<Count> getMostPopularUser(int number, String fromTime, String toTime) {

		List<Count> count = new ArrayList<Count>();

		ResultSet rs = session.execute("select user_id from user;");

		for (Row row : rs) {
			// process the row
			String query = "select count(*) from usercheckin where user_id='"+row.getString(0)+"'";

			if(!fromTime.isEmpty())
				query += " and time >= "+fromTime;
			if(!toTime.isEmpty())
				query += " and time <= "+toTime;

			query += ";";

			ResultSet subrs = session.execute(query);
			Row subrow = subrs.one(); 
			count.add(new Count(subrow.getLong(0), row.getString(0)));
		}

		Collections.sort(count);

		count = count.subList(0, number > count.size() ? count.size() : number);

		return count;
	}
	
	public List<Map<String,String>> getGeospatialDistributionOverTime(String fromTime, String toTime) {
		List<Map<String,String>> checkinReturn = new ArrayList<Map<String,String>>();
		
		String query = "select checkin_id from checkintime where city ='NYC'";

		if(!fromTime.isEmpty())
			query += " and time >= "+fromTime;
		if(!toTime.isEmpty())
			query += " and time <= "+toTime;

		query += ";";
		
		ResultSet rs = session.execute(query);

		for (Row row : rs) {
			// process the row
			String subquery = "select latitude, longitude, user_id, venue_id from checkin where checkin_id="+row.getUUID(0)+";";

			ResultSet subrs = session.execute(subquery);
			Row subrow = subrs.one();
			Map<String,String> map = new HashMap<>();
			map.put("latitude", Float.toString(subrow.getFloat("latitude")));
			map.put("longitude", Float.toString(subrow.getFloat("longitude")));
			map.put("user", subrow.getString("user_id"));
			map.put("venue", subrow.getString("venue_id"));
			checkinReturn.add(map);
		}
		
		
		return checkinReturn;
		
	}
	
	public List<Dist> getVenueSameCategoryNearby(String venueId, int value) {
		
		List<Dist> distReturn = new ArrayList<Dist>();
		
		String query = "select category_id, latitude, longitude from venue where venue_id ='"+venueId+"'";

		ResultSet rs = session.execute(query);

		Row r = rs.one();

		String categoryId = r.getString("category_id");
		float latitude = r.getFloat("latitude");
		float longitude = r.getFloat("longitude");
		
		query = "select venue_id from categoryvenue where category_id ='"+categoryId+"'";
		
		rs = session.execute(query);
		
		for (Row row : rs) {
			// process the row
			String subquery = "select latitude, longitude from venue where venue_id='"+row.getString(0)+"';";

			ResultSet subrs = session.execute(subquery);
			Row subrow = subrs.one();
			
			Double dist = distFrom(latitude, longitude, subrow.getFloat("latitude"), subrow.getFloat("longitude"));
			
			if(dist <= value){
				distReturn.add(new Dist(dist, row.getString(0)));	
			}			
			
		}

		Collections.sort(distReturn);
		
		return distReturn;
	}
	

	 private static double distFrom(float lat1, float lng1, float lat2, float lng2) {
		    double earthRadius = 6371; //KM
		    double dLat = Math.toRadians(lat2-lat1);
		    double dLng = Math.toRadians(lng2-lng1);
		    double a = Math.sin(dLat/2) * Math.sin(dLat/2) +
		               Math.cos(Math.toRadians(lat1)) * Math.cos(Math.toRadians(lat2)) *
		               Math.sin(dLng/2) * Math.sin(dLng/2);
		    double c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1-a));
		    float dist = (float) (earthRadius * c);

		    return dist;
		    }
	
	
}
