using System;
using System.Collections;

namespace MVC2
{

	public interface IView
	{
		void RefreshView();
	}

	/// <summary>
	/// Summary description for MVC_Controller.
	/// </summary>
	public class MVC_Controller
	{
		private ArrayList ViewList;
		
		public MVC_Controller()
		{
			ViewList = new ArrayList(); 
		}

		public void AddView(IView aView)
		{
			ViewList.Add(aView);
		}

		public void UpdateViews()
		{
			IView[] theViews = (IView[])ViewList.ToArray(typeof(IView));
			foreach (IView v in theViews)
			{
				v.RefreshView();
			}
		}

	}
}
