package model;
import redis.clients.jedis.GeoUnit;
import redis.clients.jedis.Jedis;
import redis.clients.jedis.JedisPool;
import redis.clients.jedis.exceptions.JedisException;

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
import java.util.Set;


public class Foursquare {

	//address of your redis server
	private static final String redisHost = "localhost";
	private static final Integer redisPort = 6379;
	//the jedis connection pool..
	private static JedisPool pool = null;
	Jedis jedis;
	//date format
	private static DateFormat df6 = new SimpleDateFormat("E MMM dd HH:mm:ss Z yyyy", Locale.US);
	private static DateFormat dfRedis = new SimpleDateFormat("yyyyMMddHHmmss", Locale.US);

	public Foursquare() {
		//configure our pool connection
		pool = new JedisPool(redisHost, redisPort);
		jedis = pool.getResource();

	}

	/**
	 * METHOD: uploadTxtToRedis
	 * 
	 */
	public static void uploadTxtToRedis(String FILE){
		
		String UserID = "";
		String VenueID = "";
		String VenueCategoryID = "";
		String VenueCategoryName = "";
		float Latitude = 0;
		float Longitude = 0;
		//String Timezone = "";
		Date UTCtime = null;
		
		int count = 0; 

		Foursquare fs = new Foursquare();

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

				fs.addCheckin(UserID, VenueID, dfRedis.format(UTCtime), Longitude, Latitude, VenueCategoryID);
				
				fs.addCategory(VenueCategoryID, VenueCategoryName);
				
				fs.addVenue(VenueID, VenueCategoryID, Longitude, Latitude);
				
				fs.addLatLon(VenueID, Longitude, Latitude);
				
				line = reader.readLine();
				
				if(count%500 == 0)
				 System.out.println(LocalDateTime.now() + " inserted "+count);
			}
			 System.out.println(LocalDateTime.now() + " inserted "+count);

		} 
		catch (IOException ex) {
			System.err.println(ex.getMessage());
		} finally {
			try { if (reader!=null) reader.close(); } catch (Exception e) {}
		}	

	}
	

	/**
	 * METHOD: addCheckin
	 * @param userId
	 * @param venueId
	 * @param time
	 * @param longitude
	 * @param latitude
	 * 
	 * 		HMSET key field value
	 * 		key		--> checkin:<next checkin>
	 * 		field	--> user	value	--> <userId>
	 * 		field	--> venue	value	--> <venueId>
	 * 		field	--> longitude	value	--> <longitude>
	 * 		field	--> latitude	value	--> <latitude>
	 * 
	 * 		ZADD key score member
	 * 		key		--> usercheckin:<userId>
	 * 		score	--> <time>
	 * 	 	member	--> <checkin>
	 * 
	 * 		ZADD key score member
	 * 		key		--> venuecheckin:<venueId>
	 * 		score	--> <time>
	 * 	 	member	--> <checkin>
	 * 
	 * 		ZADD key score member
	 * 		key		--> checkintime:nyc
	 * 		score	--> <time>
	 * 	 	member	--> <checkin>
	 * 
	 * 		ZADD key score member
	 * 		key		--> checkincategory:<categoryId>
	 * 		score	--> <time>
	 * 	 	member	--> <checkin>
	 * 
	 */
	private void addCheckin(String userId, String venueId, String time, float longitude, float latitude, String categoryId) {
		//add some values in Redis HASH

     //debug approved by xin		
		System.out.println(" enter addCheckin "+userId +" "+ userId);
		
		Map<String, String> map = new HashMap<>();
		map.put("user", userId);
		map.put("venue", venueId);
		map.put("time", time);
		map.put("longitude", Float.toString(longitude));
		map.put("latitude", Float.toString(latitude));

		//Jedis jedis = pool.getResource();
		try {
			
			Long next = jedis.incr("checkin");
			
			String keyChecking = "checkin:"+next;
			String keyUserCheckin = "usercheckin:"+userId;
			String keyVenueCheckin  = "venuecheckin:"+venueId;
			String keyCategoryCheckin  = "categorycheckin:"+categoryId;
			String keyCheckinTime  = "checkintime:nyc";
			
			//save to redis,use more than 1 structure
      jedis.hmset(keyChecking, map);

			//structure1, key name is keyChecking
			jedis.hmset(keyChecking, map);
			//structure2, key name is keyUserCheckin
      jedis.zadd(keyUserCheckin, Double.parseDouble(time), next.toString());
			jedis.zadd(keyVenueCheckin, Double.parseDouble(time), next.toString());
			jedis.zadd(keyCategoryCheckin, Double.parseDouble(time), next.toString());
			jedis.zadd(keyCheckinTime, Double.parseDouble(time), next.toString());

		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}
	}
	
	/**
	 * METHOD: addLatLon
	 * @param venueID
	 * @param longitude
	 * @param latitude
	 * 
	 * 		GEOADD key longitude latitude member
	 * 		key			--> nyc
	 * 		longitude	--> <longitude>
 	 * 		latitude	--> <latitude>
 	 * 		member		--> <veneuID>
	 * 
	 */
	private void addLatLon(String venueID, float longitude, float latitude) {
		//add some values in Redis GEO
		//Jedis jedis = pool.getResource();
		try {
			
			String keyGeo = "nyc";
			
			//save to redis
			jedis.geoadd(keyGeo, longitude, latitude, venueID);

		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
	}

	/**
	 * METHOD: addVenue
	 * @param venueID
	 * @param venueCategoryID
	 * 
	 * 		HMSET key field value
	 * 		key		--> venue:<venueID>
	 * 		field	--> category	value	--> <venueCategoryID>
	 * 		key 	--> longitude	value	--> <longitude>
 	 * 		key 	--> latitude	value	--> <latitude>
	 * 
	 * 		ZADD key score member
	 * 		key		--> categoryvenue:<venueCategoryID>
	 * 		score	--> 0
	 * 	 	member	--> <veneuID>
	 * 
	 */
	private void addVenue(String venueID, String venueCategoryID, float longitude, float latitude) {
		//add some values in Redis HASH
		Map<String, String> map = new HashMap<>();
		map.put("category", venueCategoryID);
		map.put("longitude", Float.toString(longitude));
		map.put("latitude", Float.toString(latitude));

		//Jedis jedis = pool.getResource();
		try {
			
			String keyVenue = "venue:"+venueID;
			
			//save to redis
			jedis.hmset(keyVenue, map);

			String keyVenueCheckin  = "categoryvenue:"+venueCategoryID;
			
			//save to redis
			jedis.zadd(keyVenueCheckin, Double.parseDouble("0"), venueID);

			
		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
	}

	/**
	 * METHOD: addCategory
	 * @param venueCategoryID
	 * @param venueCategoryName
	 * 
	 * 		HMSET key field value
	 * 		key		--> category:<venueCategoryID>
	 * 		field	--> name	value	--> <venueCategoryName>
	 * 
	 */
	private void addCategory(String venueCategoryID, String venueCategoryName) {
		//add some values in Redis HASH
		Map<String, String> map = new HashMap<>();
		map.put("name", venueCategoryName);

		//Jedis jedis = pool.getResource();
		try {
			
			String keyCategory = "category:"+venueCategoryID;
			
			//save to redis
			jedis.hmset(keyCategory, map);

		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
	}
	
	/**
	 * METHOD: getMostPopularVenue
	 * @param number
	 * @param fromTime
	 * @param toTime
	 * 
	 * 		KEYS venuecheckin:*
	 * 		
	 * 
	 * 		ZCOUNT  key min max
	 * 		key		--> venuecheckin:*
	 * 		min		--> fromTime	
	 * 		max		--> toTime 
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Count>
	 * 
	 */
	public List<Count> getMostPopularVenue(int number, String fromTime, String toTime) {
		return getMostPopular("venuecheckin:*", number, fromTime, toTime);
	}

	/**
	 * METHOD: getMostPopularUser
	 * @param number
	 * @param fromTime
	 * @param toTime
	 * 
	 * 		KEYS usercheckin:*
	 * 		
	 * 
	 * 		ZCOUNT  key min max
	 * 		key		--> usercheckin:*	
	 * 		min		--> <fromTime>	
	 * 		max		--> <toTime> 
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Count>
	 * 
	 */
	public List<Count> getMostPopularUser(int number, String fromTime, String toTime) {
		return getMostPopular("usercheckin:*", number, fromTime, toTime);
	}	
	/**
	 * METHOD: getMostPopularCategory
	 * @param number
	 * @param fromTime
	 * @param toTime
	 * 
	 * 		KEYS usercheckin:*
	 * 		
	 * 
	 * 		ZCOUNT  key min max
	 * 		key		--> usercheckin:*	
	 * 		min		--> <fromTime>	
	 * 		max		--> <toTime> 
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Count>
	 * 
	 */
	public List<Count> getMostPopularCategory(int number, String fromTime, String toTime) {
		
		List<Count> count = new ArrayList<Count>();
		List<Count> countReturn = new ArrayList<Count>();
		
		
		if(number < 1){
			number = 1;
		}
		if(fromTime.isEmpty())
			fromTime = "-inf";
		if(toTime.isEmpty())
			toTime = "+inf";
		
		Jedis jedis = pool.getResource();
		
		try {
			

			Set<String> dataset = jedis.keys("categorycheckin:*");
			
			for (String id : dataset) {
				count.add(new Count(jedis.zcount(id, fromTime, toTime), id.split(":")[1]));
			}
			
			Collections.sort(count);
			
			countReturn = count.subList(0, number > count.size() ? count.size() : number);
			
			for (Count c : countReturn){
				Set<String> checkinbycategory = jedis.zrangeByScore("categorycheckin:"+c.id, fromTime, toTime);
				System.out.println("categorycheckin:"+c.id);
				for (String id : checkinbycategory) {
					Map<String,String> checkin = jedis.hgetAll("checkin:"+id);
					System.out.println("checkin:"+id + " user: " +checkin.get("user") + " venue: " +checkin.get("venue"));
				}
			}
			
		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
		return countReturn;
	}	
	
	/**
	 * METHOD: getMostPopular
	 * @param key
	 * @param number
	 * @param fromTime
	 * @param toTime
	 * 
	 * 		KEYS <key>
	 * 
	 * 		ZCOUNT  key min max
	 * 		key		--> <key>
	 * 		min		--> <fromTime>	
	 * 		max		--> <toTime> 
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Count>
	 */
	private List<Count> getMostPopular(String key, int number, String fromTime, String toTime) {
		
		List<Count> count = new ArrayList<Count>();
		List<Count> countReturn = new ArrayList<Count>();
		
		if(number < 1){
			number = 1;
		}
		if(fromTime.isEmpty())
			fromTime = "-inf";
		if(toTime.isEmpty())
			toTime = "+inf";
		
		Jedis jedis = pool.getResource();
		
		try {
			

			Set<String> dataset = jedis.keys(key);
			
			for (String id : dataset) {
				count.add(new Count(jedis.zcount(id, fromTime, toTime), id.split(":")[1]));
			}
			
			Collections.sort(count);
			
			countReturn = count.subList(0, number > count.size() ? count.size() : number);
			
		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
		return countReturn;
	}

	/**
	 * METHOD: getVenueSameCategoryNearby
	 * @param venueId
	 * @param value
	 * @param gu
	 * 
	 * 		HGET key field 
	 * 		key		--> venue:<venueId>
	 * 		field	--> category 
	 * 		<categoryId>
	 * 
	 * 		ZRANGE  key min max
	 * 		key		--> categoryvenue:<categoryId>
	 * 		min		--> 0	
	 * 		max		--> -1 
	 * 		<id>		
	 * 
	 * 		GEODIST  key member1 member2 unit
	 * 		key		--> nyc
	 * 		member1	--> <id>
	 *  	member2	--> <venueId>
	 * 		unit	--> gu
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Dist>
	 * 
	 */
	public List<Dist> getVenueSameCategoryNearby(String venueId, int value, GeoUnit gu) {
		
		List<Dist> distReturn = new ArrayList<Dist>();
		
		Jedis jedis = pool.getResource();
		
		try {
			
			String categoryId = jedis.hget("venue:"+venueId, "category");
			
			Set<String> dataset = jedis.zrange("categoryvenue:"+categoryId, 0, -1);
			
			for (String id : dataset) {
				
				Double dist = jedis.geodist("nyc", venueId, id, gu);
				
				if(dist <= value){
					distReturn.add(new Dist(dist, id));	
				}
				
				
			}
			
			Collections.sort(distReturn);
			
			
		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
		return distReturn;
	}

	/**
	 * METHOD: getGeospatialDistributionOverTime
	 * @param fromTime
	 * @param toTime
	 * 
	 * 		ZRANGEBYSCORE key min max 
	 * 		key		--> checkintime:nyc
	 * 		min 	--> fromTime 
	 * 		max 	--> toTime 
	 * 		<id>
	 * 
	 * 		HGETALL  key
	 * 		key		--> checkin:<id>
	 * 
	 * Time use date format = yyyyMMddHHmmss
	 * 
	 * @return List<Map<String,String>>
	 * 
	 */
	public List<Map<String,String>> getGeospatialDistributionOverTime(String fromTime, String toTime) {
		List<Map<String,String>> checkinReturn = new ArrayList<Map<String,String>>();
		
		if(fromTime.isEmpty())
			fromTime = "0";
		if(toTime.isEmpty())
			toTime = "-1";
		
		Jedis jedis = pool.getResource();
		
		try {
			

			Set<String> dataset = jedis.zrangeByScore("checkintime:nyc", Long.parseLong(fromTime), Long.parseLong(toTime));
			
			for (String id : dataset) {
				Map<String,String> checkin = jedis.hgetAll("checkin:"+id);
				checkinReturn.add(checkin);
			}
			
		} catch (JedisException e) {
			//if something wrong happen, return it back to the pool
			if (null != jedis) {
				jedis = null;
			}
		}		
		return checkinReturn;

		
	}

	
}