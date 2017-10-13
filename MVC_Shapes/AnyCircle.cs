using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace MVC_Shapes
{
	/// <summary>
	/// Summary description for AnyCircle.
	/// </summary>
	class AnyCircle : AnyShape
	{
		// constructor
		public AnyCircle(string shapeName, int x_at, int y_at, int shape_width, 
			int shape_height, Color bkColor)
			: base(shapeName, x_at, y_at, shape_width, shape_height, bkColor)
		{			
		}		

		// override method to display shape as text
		public override string ToString()
		{
			return "Circle: " + shape_width.ToString() + " cm diameter at " + this.Position();
		}

		// override method to display shape as graphics
		public override void Display(Graphics g)
		{
			if (g != null)
			{
				Brush br = new SolidBrush(backColor);
				g.FillEllipse(br,x,y,shape_width,shape_width);
			}
			
			// if shape needs border to be drawn
			if(Highlight) 
			{ 
				// make slightly smaller than shape to avoid shadow
				float borderDiameter = (float)(shape_width - 3);
				// draw border around circle
				Pen p = new Pen(Color.Black,3); 
				p.DashStyle=DashStyle.Solid; 
				// to avoid shadow position move position by 1.5
				float xFloat = (float)(x + 1.5); float yFloat = (float)(y + 1.5);
				
				g.DrawEllipse(p, xFloat, yFloat, borderDiameter, borderDiameter);				
				
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
		/// used to create ellipse the same size as the shape if selected
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		public override bool HitTest(Point p)
		{
			GraphicsPath pth = new GraphicsPath();
			pth.AddEllipse(x, y, shape_width, shape_width);
			bool retval = pth.IsVisible(p);
			pth.Dispose();
			return retval;
			
		}
	}
}
