package app;

import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;
import java.util.List;
import java.util.Map;
import java.util.Set;

import model.Count;
import model.Dist;
import model.Foursquare;
import redis.clients.jedis.GeoUnit;

public class Tester {

	static LocalDateTime initial;
	static LocalDateTime end;
	
	public static void main(String[] args) {

		int type = 1;		//0 - upload 	1 - queries
		
		switch (type) {
		case 0:
			printInitial("Upload file");
			Foursquare.uploadTxtToRedis("dataset_TSMC2014_NYC.txt");
			printEnd();
			break;

		case 1:

			Foursquare fs = new Foursquare();
			
			printInitial("Q1     Most popular places?");
			List<Count> venues = fs.getMostPopularVenue(5, "", "");
			for (Count count : venues) {
				System.out.println(count.count +" "+ count.id);
			}
			printEnd();

			printInitial("Q2    Most Active Users?");
			List<Count> users = fs.getMostPopularUser(10, "", "");
			for (Count count : users) {
				System.out.println(count.count +" "+ count.id);
			}
			printEnd();
			
			
			printInitial("Q3    How many other venues of the same category are nearby?"); 
		    //  Map all venues of each category. For each venue, calculate distances apart,
		    //  Count all venues within proscribed radius
			GeoUnit gu = GeoUnit.KM; 
			List<Dist> distVenues = fs.getVenueSameCategoryNearby("40afe980f964a5203bf31ee3", 10, gu);
			for (Dist dist : distVenues) {
				System.out.println(dist.id +" "+ dist.dist +" "+gu.name());
			}
			printEnd();

/*			printInitial("Q4    Most Popular places of the most active users of each category?");
			//	For Each Category Count Check Ins by each User
		    //	Display most Checked into venue for the MAU.
			//  ??????????????????
			List<Count> categories = fs.getMostPopularCategory(1, "", "");
			for (Count count : categories) {
				//System.out.println(count.count +" "+ count.id);
			}
			printEnd();
			
			printInitial("Q5    Geo-spatial Distribution over Time?");
			//	Map Check Ins from the last hour to a grid
			//	Count check Ins for each Grid reference cell
			List<Map<String,String>> checkins = fs.getGeospatialDistributionOverTime("20130110000000", "20130110235959");
			
			float s1maxLat, s1minLat, s1maxLon, s1minLon;
			
			s1maxLat, 
			s1minLat, 
			s1maxLon, 
			s1minLon
			
			for (Map<String,String> checkin : checkins) {
				
				Set<String> keys = checkin.keySet();
				System.out.println("------------");
				
				if(Float.parseFloat(checkin.get("latitude") > s1minLat);
				
				if(maxLat < Float.parseFloat(checkin.get("latitude")))
					maxLat = Float.parseFloat(checkin.get("latitude"));
				
				if(minLat == 0)
					minLat = Float.parseFloat(checkin.get("latitude"));
				
				if(minLat  > Float.parseFloat(checkin.get("latitude")))
					minLat = Float.parseFloat(checkin.get("latitude"));
				
				
				if(maxLon == 0)
					maxLon = Float.parseFloat(checkin.get("longitude"));
				
				if(maxLon < Float.parseFloat(checkin.get("longitude")))
					maxLon = Float.parseFloat(checkin.get("longitude"));
				
				if(minLon == 0)
					minLon = Float.parseFloat(checkin.get("longitude"));
				
				if(minLon  > Float.parseFloat(checkin.get("longitude")))
					minLon = Float.parseFloat(checkin.get("longitude"));
				
				for(String key: keys){
				    System.out.println("\t"+ key + ": " + checkin.get(key));
				}
			}
			
			System.out.println("Latitude: "+  minLat + " " + maxLat);
			System.out.println("Longitude: "+  minLon + " " + maxLon);
			printEnd();*/

			break;

		default:
			break;
		}
	}
	
	private static void printInitial(String title){
		initial = LocalDateTime.now();
		System.out.println(title);
		System.out.println(initial);
	}

	private static void printEnd(){
		end = LocalDateTime.now();
		System.out.println(end + " " + ChronoUnit.MILLIS.between(initial, end) + "millis\n");
	}

}
