using System;

namespace OpOverload1
{
	/// <summary>
	/// Summary description for Location.
	/// </summary>
	public class Location
	{
		int x;
		int y;
	
		public Location(string xy)
		{
			string[] where = xy.Split(',');
			x = Convert.ToInt32(where[0]);
			y = Convert.ToInt32(where[1]);
		}

		public Location()
		{
			x = 0;
			y = 0;
		}

		public override string ToString()
		{
			return x.ToString() + "," + y.ToString();
		}

		public static Location operator +(Location l1, Location l2)
		{    
			Location result = new Location();
			result.x = l1.x + l2.x;
			result.y = l1.y + l2.y;
			return result;
		}

		public static bool operator ==(Location l1, Location l2)
		{    
			bool result = false;
			if ( (l1.x == l2.x) && (l1.y == l2.y))
			{
				result = true;
			}
			return result;
		}

		public static bool operator !=(Location l1, Location l2)
		{    
			bool result = false;
			if ( (l1.x != l2.x) || (l1.y != l2.y))
			{
				result = true;
			}
			return result;
		}


	}
}
