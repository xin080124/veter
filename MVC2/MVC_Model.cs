using System;
using System.Collections;

namespace MVC2
{
	/// <summary>
	/// Summary description for MVC_Model.
	/// </summary>
	public class MVC_Model
	{
		private ArrayList shapeList;
		private MVC_Controller theController;

		public MVC_Model(MVC_Controller aController)
		{
			shapeList = new ArrayList();
			theController = aController;
		}

		public ArrayList ShapeList
		{
			get
			{
				return shapeList;
			}
		}

		public void AddShape(AnyShape aShape)
		{
			shapeList.Add(aShape);
			UpdateViews();
		}

		public void UpdateViews()
		{
			theController.UpdateViews();
		}
	}
}
