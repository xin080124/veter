using System;
using System.Drawing;

namespace MVC2
{
	/// <summary>
	/// Summary description for AnyShape.
	/// </summary>
	public abstract class AnyShape
	{
		protected int x;
		protected int y;
		protected Color backColor;

		public AnyShape(int x_at, int y_at, Color bkColor)
		{
			x = x_at;
			y = y_at;
			backColor = bkColor;
		}
		

		public abstract void Display(Graphics g);

		public string Position()  //non abstract method
		{
			return "(" + x.ToString() + "," + y.ToString() + ")";
		}

		public abstract int x_pos //abstract property
		{
			get;
			set;
		}

		public abstract int y_pos //abstract property
		{
			get;
			set;
		}
	}
}
