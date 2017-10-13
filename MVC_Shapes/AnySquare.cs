using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace MVC_Shapes
{
	class AnySquare : AnyShape
	{
		// constructor	
		public AnySquare(string shapeName, int x_at, int y_at, int shape_width, int shape_height, Color bkColor) 
			: base(shapeName, x_at, y_at, shape_width, shape_height, bkColor)
		{

		}

		// override method to display shape as text
		public override string ToString()
		{
			return "Square: " + shape_width.ToString() + " cm side at " + this.Position();
		}
	
		// override method to display shape as graphics
		public override void Display(Graphics g)
		{
			if (g != null)
			{
				Brush br = new SolidBrush(backColor);				
				g.FillRectangle(br, x,y,shape_width,shape_width);
				br.Dispose();
			}

			if(Highlight) 
			{ 
				// add in border if shape selected
				// to define point and size
				Point pt = new Point(x + 1,y + 1); // to avoid shadow
			
				int borderSide = shape_width - 3; // make slightly smaller than shape to avoid shadow
				Size size = new Size(borderSide, borderSide);
				// draw border
				Pen p = new Pen(Color.Black,3); 
				p.DashStyle=DashStyle.Solid; 
				g.DrawRectangle(p,new Rectangle(pt, size));
				
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

		public override int shape_width //non abstract property
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

		public override string name //non abstract property
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
		/// used to create rectangle the same size as the shape if selected
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		public override bool HitTest(Point p)
		{
			GraphicsPath pth = new GraphicsPath();
			pth.AddRectangle(new Rectangle(x, y, shape_width, shape_width));
			bool retval = pth.IsVisible(p);
			pth.Dispose();
			return retval;
		}
	}
}
