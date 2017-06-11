using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackingCircles
{
	/// <summary>
	/// Summary description for ColorPoint.
	/// </summary>
	public class ColorPoint
	{
		private int X;
		private int Y;
		private Color DrawColor;

		public ColorPoint(int ptX, int ptY, Color theDrawColor)
		{
			X = ptX;
			Y = ptY;
			DrawColor = theDrawColor;
		}

		public ColorPoint(string XYColor)
		//create a ColorPoint object from a string of 3 integers in string form split by commas
		//giving X, Y positions and the color value
		{
			string[] parts = XYColor.Split(',');
			X = Convert.ToInt32(parts[0]);
			Y = Convert.ToInt32(parts[1]);
			DrawColor = (Color.FromArgb(Convert.ToInt32(parts[2])));
		}

		public override string ToString()
		{
			return X.ToString() + "," + Y.ToString() + "," + DrawColor.ToArgb().ToString() + "#";
		}

		public void Draw(Graphics g)
		{
			Pen pn = new Pen( DrawColor,2 );
			g.DrawEllipse(pn, X, Y, 12, 12);
		}
	



	}
}
