using System;
using System.Collections;

namespace MVC_basics
{

	public interface IView
	{
		void UpdateView();
	}

	/// <summary>
	/// Summary description for ModelX.
	/// </summary>
	public class ModelX
	{
		private ControllerX theController;
		private ArrayList theData = new ArrayList();

		public ModelX(ControllerX aController) //constructor
		{
			theController = aController;
		}

		public void Add(int n)
		{
			//add a new number to the data and get the views to update their displays
			theData.Add(n);
			theController.UpdateAllViews();
		}

		public int[] Numbers
		{
			//this property gives a copy of the data so the views can display it
			get
			{
				return (int[])theData.ToArray(typeof(int));
			}
		}

	}
}
