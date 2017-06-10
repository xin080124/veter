package app;

import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import dao.Cassandra;
import model.Count;
import model.Dist;

/**
 *
 */
public class CassandraApp 
{

	static LocalDateTime initial;
	static LocalDateTime end;
	
	public static void main(String[] args) {

		int type = 1;		//0 - upload 	
							//1 - queries
							//2 - drop tables		
							//3 - create tables  run first
		
		switch (type) {
		case 0:
			printInitial("Upload file");
			Cassandra.uploadTxtToCassandra("50ROWS.txt");
			//Cassandra.uploadTxtToCassandra("dataset_TSMC2014_NYC.txt");
			printEnd();
			break;

		case 2:
			printInitial("Drop tables");
			Cassandra cs2 = new Cassandra();
			cs2.dropTables();
			printEnd();
			break;

		case 3:
			printInitial("Create tables");
			Cassandra cs3 = new Cassandra();
			cs3.createTables();
			printEnd();
			break;
			
			
		case 1:

			Cassandra cs = new Cassandra();
			
			printInitial("Q1     Most popular places?");
			List<Count> venues = cs.getMostPopularVenue(5, "", "");
			for (Count count : venues) {
				System.out.println(count.count +" "+ count.id);
			}
			printEnd();

			printInitial("Q2    Most Active Users?");
			List<Count> users = cs.getMostPopularUser(10, "", "");
			for (Count count : users) {
				System.out.println(count.count +" "+ count.id);
			}
			printEnd();
			
			
			printInitial("Q3    How many other venues of the same category are nearby?"); 
		    //  Map all venues of each category. For each venue, calculate distances apart,
		    //  Count all venues within proscribed radius
			List<Dist> distVenues = cs.getVenueSameCategoryNearby("4c955b3558d4b60c06d03129", 10);
			for (Dist dist : distVenues) {
				System.out.println(dist.id +" "+ dist.dist +" KM");
			}
			printEnd();

			printInitial("Q4    Most Popular places of the most active users of each category?");
			//	For Each Category Count Check Ins by each User
		    //	Display most Checked into venue for the MAU.
			//  ??????????????????
			printEnd();
			
			printInitial("Q5    Geo-spatial Distribution over Time?");
			//	Map Check Ins from the last hour to a grid
			//	Count check Ins for each Grid reference cell
			List<Map<String,String>> checkins = cs.getGeospatialDistributionOverTime("20121001000000", "20130110235959");
			
			
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
				else if(Double.parseDouble(checkin.get("latitude")) >= 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) < -73.9807470){
					topRight.add(checkin);
				}

				//Botton Left
				else if(Double.parseDouble(checkin.get("latitude")) < 40.7759585
					&& Double.parseDouble(checkin.get("longitude")) >= -73.9807470){
					botLeft.add(checkin);
				}

				//Botton Right
				else if(Double.parseDouble(checkin.get("latitude")) < 40.7759585
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
