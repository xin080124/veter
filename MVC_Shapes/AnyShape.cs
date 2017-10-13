using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace MVC_Shapes
{
	/// <summary>
	/// Summary description for AnyShape.
	/// </summary>
	public abstract class AnyShape
	{
		protected string shapeName;
		protected int x;
		protected int y;
		protected int width;
		protected int height;
		protected Color backColor;
		// added for hittest and highlight
		bool highlight;

		// constructor
		public AnyShape(string shape, int x_at, int y_at, int shapeWidth, 
			int shapeHeight, Color bkColor)
		{
			shapeName = shape;
			x = x_at;
			y = y_at;
			width = shapeWidth;
			height = shapeHeight;
			backColor = bkColor;			
		}		

		public abstract void Display(Graphics g); // abstract method

		public bool Highlight 
		{
			get
			{
				return highlight;
			}
			set
			{
				highlight = value;
			}
		}

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

		public abstract int shape_width //abstract property
		{
			get;
			set;
		}

		public abstract int shape_height //abstract property
		{
			get;
			set;
		}

		public abstract Color shapeColor //abstract property
		{
			get;
			set;
		}

		public abstract string name //abstract property
		{
			get;
			set;
		}

		// virtual method
		public virtual bool HitTest(Point p)
		{
			Point pt = new Point(x, y);
			Size size = new Size(100,100);
			//default behaviour
			return new Rectangle(pt, size).Contains(p);
		}
	}
}
