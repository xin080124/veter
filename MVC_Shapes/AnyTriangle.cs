using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MVC_Shapes
{
	class AnyTriangle : AnyShape
	{		
		// constructor
		public AnyTriangle(string shapeName, int x_at, int y_at, int shape_width, int shape_height, Color bkColor) 
			: base(shapeName, x_at, y_at, shape_width, shape_height, bkColor)
		{

		}

		// override method to display shape as text
		public override string ToString()
		{
			return "Triangle: " + 
				shape_width.ToString() + " cm width, " +
				shape_height.ToString() + " cm height at " +
				this.Position();
		}
	
		// override method to display shape as graphic
		public override void Display(Graphics g)
		{
			if (g != null)
			{
				// set points of triangle
				Point pt1 = new Point(x, y);
				Point pt2 = new Point(x, shape_height + y);
				Point pt3 = new Point(shape_width + x, y);
				
				Point[] points =  {pt1, pt2, pt3};
				
				Brush br = new SolidBrush(backColor);
				// create triangle (polygon with three points)
				g.FillPolygon(br,points);
			}

			if(Highlight) 
			{
				// add in border if shape selected
				// to define point and size
				int x2 = x+1;
				int y2 = y+1;
				int height2 = shape_height - 3;
				int width2 = shape_width - 4;

				Point pt1a = new Point(x2, y2);
				Point pt2a = new Point(x2, height2 + y2);
				Point pt3a = new Point(width2 + x2, y2);
				
				Point[] points2 =  {pt1a, pt2a, pt3a};
				// draw border
				Pen p = new Pen(Color.Black,3); 
				p.DashStyle=DashStyle.Solid; 
				g.DrawPolygon(p, points2);
								
				p.Dispose(); 
			}
		}

		public override int x_pos //non abstract property
		{
			get 
			{
				return x;
			}
			set
			{
				x = value;
			}
		}

		public override int y_pos //non abstract property
		{
			get 
			{
				return y;
			}
			set
			{
				y = value;
			}
		}

		public override int shape_width  //non abstract property
		{
			get
			{
				return width;
			}
			set
			{
				width = value;
			}
		}

		public override int shape_height //non abstract property
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
			}
		}

		public override Color shapeColor //non abstract property
		{
			get 
			{
				return backColor;
			}
			set
			{
				backColor = value;
			}
		}

		public override string name
		{
			get
			{
				return shapeName;
			}
			set
			{
				shapeName = value;
			}
		}

		/// <summary>method: HitTest
		/// used to create polygon the same size as the shape if selected
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		public override bool HitTest(Point p)
		{
			GraphicsPath pth = new GraphicsPath();

			Point pt1 = new Point(x, y);
			Point pt2 = new Point(x, height+y);
			Point pt3 = new Point(width+x, y);
				
			Point[] points =  {pt1, pt2, pt3};
				
			pth.AddPolygon(points);
			
			bool retval = pth.IsVisible(p);
			pth.Dispose();
			return retval;
		}
	}
}
