using System;
using System.Collections;

namespace MVC_Shapes
{
	public interface IShapeView
	{
		void RefreshView();
	}
	/// <summary>
	/// Summary description for ShapesController.
	/// </summary>
	public class ShapesController
	{
		private ArrayList ViewList;

		// constructor
		public ShapesController()
		{
			ViewList = new ArrayList();
		}
        
		/// <summary>method: AddView
		/// add view to viewlist
		/// </summary>
		/// <param name="aView"></param>
		public void AddView(IShapeView aView)
		{
			ViewList.Add(aView);
		}

		/// <summary>method: UpdateViews
		/// update each view 
		/// </summary>
		public void UpdateViews()
		{
			IShapeView[] theViews = (IShapeView[])ViewList.ToArray(typeof(IShapeView));
			foreach (IShapeView v in theViews)
			{
				v.RefreshView();
			}
		}
	}
}
