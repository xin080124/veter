using System;
using System.Drawing;

namespace MVC2
{
	/// <summary>
	/// Summary description for MyCircle.
	/// </summary>
	class AnyCircle : AnyShape
	{
		protected int diameter;

		public AnyCircle(int x_at, int y_at, Color bkColor, int theDiameter) : base(x_at, y_at, bkColor)
		{
			diameter = theDiameter;
		}

		
		public override string ToString()
		{
			return "Circle: " + diameter.ToString() + " cm diameter at " + this.Position();
		}
	

		public override void Display(Graphics g)
		{
			if (g != null)
			{
				Brush br = new SolidBrush(backColor);
				g.FillEllipse(br,x,y,diameter,diameter);
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
	}
}
