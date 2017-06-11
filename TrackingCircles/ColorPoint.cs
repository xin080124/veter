using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackingCircles
{
	/// <summary>
	/// Class to hold data for colored points.
	/// </summary>
	public class ColorPoint
	{
		private int X;
		private int Y;
		private Color DrawColor;

		/// <summary> method: 
		/// Constructor
		/// </summary>
		public ColorPoint(int ptX, int ptY, Color theDrawColor)
		{
			X = ptX;
			Y = ptY;
			DrawColor = theDrawColor;
		}

		/// <summary> method: 
		/// Overloaded Constructor
		/// create a ColorPoint object from 3 integers 
		/// held in string form split by commas
		/// giving X, Y positions and the color value
		/// </summary>
		public ColorPoint(string XYColor)
		{
			string[] parts = XYColor.Split(',');
			X = Convert.ToInt32(parts[0]);
			Y = Convert.ToInt32(parts[1]);
			DrawColor = (Color.FromArgb(Convert.ToInt32(parts[2])));
		}

		/// <summary> method: 
		/// return the ColorPoint object's data as a 
		/// comma seperated string ending with a # character
		/// </summary>
		public override string ToString()
		{
			return X.ToString() + "," + Y.ToString() + "," + DrawColor.ToArgb().ToString() + "#";
		}

		/// <summary> method: 
		/// Using the graphics object from the argument
		/// draw a circle matching the ColorPoint object
		/// </summary>
		public void Draw(Graphics g)
		{
			Pen pn = new Pen( DrawColor,3 );
			g.DrawEllipse(pn, X, Y, 25, 25);
		}
	



	}
}
