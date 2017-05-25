package app;

import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import dao.Foursquare;
import model.Count;
import model.Dist;
import redis.clients.jedis.GeoUnit;

public class RedisApp {

	static LocalDateTime initial;
	static LocalDateTime end;
	
	public static void main(String[] args) {

		int type = 1;		//0 - upload 	
							//1 - queries
							//2 - drop tables		
							
		
		switch (type) {
		case 0:
			printInitial("Upload file");
			//Foursquare.uploadTxtToRedis("50ROWS.txt");
			Foursquare.uploadTxtToRedis("dataset_TSMC2014_NYC.txt");
			printEnd();
			break;
			
		case 2:
			printInitial("Initialize Redis");
			Foursquare fs1 = new Foursquare();
			fs1.initializeRedis();
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
*/			
			printInitial("Q5    Geo-spatial Distribution over Time?");
			//	Map Check Ins from the last hour to a grid
			//	Count check Ins for each Grid reference cell
			List<Map<String,String>> checkins = fs.getGeospatialDistributionOverTime("20130110000000", "20130110235959");
			
			
			List<Map<String,String>> topLeft = new ArrayList<Map<String,String>>();
			List<Map<String,String>> topRight = new ArrayList<Map<String,String>>();
			List<Map<String,String>> botLeft = new ArrayList<Map<String,String>>();
			List<Map<String,String>> botRight = new ArrayList<Map<String,String>>();
					
			
/*									Latitude / Longitude
			
			40.9744600 -74.26947				40.9744600 -73.9807470				40.9744600 -73.692024
			|
			|					Top Left								Top Right
			|
			40.7759585 -74.26947				40.7759585 -73.9807470				40.7759585 -73.692024
			|
			|				Botton Left								Botton Right
			|
			40.9744600 -74.26947				40.5774570 -73.9807470				40.5774570 -73.692024
*/			
		
			for (Map<String,String> checkin : checkins) {
				
				//Top Left
				if(Double.parseDouble(checkin.get("latitude")) >= 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) >= -73.9807470){
					topLeft.add(checkin);
				}

				//Top Right
				if(Double.parseDouble(checkin.get("latitude")) >= 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) < -73.9807470){
					topRight.add(checkin);
				}

				//Botton Left
				if(Double.parseDouble(checkin.get("latitude")) < 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) >= -73.9807470){
					botLeft.add(checkin);
				}

				//Botton Right
				if(Double.parseDouble(checkin.get("latitude")) < 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) < -73.9807470){
					botRight.add(checkin);
				}
			}
			
			System.out.println("Top Left");
			for (Map<String,String> checkin : topLeft) {
				System.out.println("Venue: "+ checkin.get("venue") + " User: " + checkin.get("user"));
			}
			
			System.out.println("Top Right");
			for (Map<String,String> checkin : topRight) {
				System.out.println("Venue: "+ checkin.get("venue") + " User: " + checkin.get("user"));
			}

			System.out.println("Botton Left");
			for (Map<String,String> checkin : botLeft) {
				System.out.println("Venue: "+ checkin.get("venue") + " User: " + checkin.get("user"));
			}

			System.out.println("Botton Right");
			for (Map<String,String> checkin : botRight) {
				System.out.println("Venue: "+ checkin.get("venue") + " User: " + checkin.get("user"));
			}
			printEnd();

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
		System.out.println(end + " " 
							+ ChronoUnit.SECONDS.between(initial, end) + " seconds or "
							+ ChronoUnit.MILLIS.between(initial, end) + " milliseconds");
		System.out.println("");
	}

}
