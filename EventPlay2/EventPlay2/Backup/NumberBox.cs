using System;
using System.Windows.Forms;

namespace EventPlay2
{
	/// <summary>
	/// Summary description for NumberBox.
	/// </summary>
	class NumberBox : TextBox
	{
		public NumberBox()
		{
			this.KeyPress += new KeyPressEventHandler(NumberBox_KeyPress);
		} 

		private void NumberBox_KeyPress(object sender,KeyPressEventArgs kpe)
		{
			int KeyCode=(int)kpe.KeyChar; 

			if( !IsNumberInRange(KeyCode,48,57) && KeyCode!=8 && KeyCode!=46 )
			{
				kpe.Handled=true;
			}
			else
			{
				if(KeyCode==46)
				{
					kpe.Handled=(this.Text.IndexOf(".") > -1);
				}
			}
		} 

		private bool IsNumberInRange(int Val,int Min,int Max)
		{
			return (Val >= Min && Val <= Max);
		}
	}
}
