using System;
using System.Drawing;

namespace MVC2
{
	class AnySquare : AnyShape
	{
		protected int side;
		
		public AnySquare(int x_at, int y_at, Color bkColor, int aSide) : base(x_at, y_at, bkColor)
		{
			side = aSide;
		}

		public override string ToString()
		{
			return "Square: " + side.ToString() + " cm side at " + this.Position();
		}
	
		public override void Display(Graphics g)
		{
			if (g != null)
			{
				Brush br = new SolidBrush(backColor);
				g.FillRectangle(br, x,y,side,side);
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
