using System;
using System.Collections;

namespace MVC_basics
{
	/// <summary>
	/// Summary description for ControllerX.
	/// </summary>
	public class ControllerX
	{
		private ArrayList theViews = new ArrayList();

		public ControllerX()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void AddView(IView aView)
		{
			//add a view to the list of views
			theViews.Add(aView);
		}

		public void UpdateAllViews()
		{
			//loop through the views asking each one to update its display
			IView thisView;
			foreach (object ob in theViews)
			{
				thisView = (IView)ob;
				thisView.UpdateView();
			}
		}
	}
	
}
