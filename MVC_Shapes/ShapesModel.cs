using System;
using System.Collections;
using System.Drawing;

namespace MVC_Shapes
{
	/// <summary>
	/// Summary description for ShapesModel.
	/// </summary>
	public class ShapesModel
	{
		private ArrayList shapeList;
		private ShapesController theController;

		public ShapesModel(ShapesController aController)
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

		/// <summary>method: AddShape
		/// add shape to the model and update views
		/// </summary>
		/// <param name="aShape"></param>
		public void AddShape(AnyShape aShape)
		{
			shapeList.Add(aShape);
			UpdateViews();
		}

		/// <summary>method: UpdateShape
		/// update views
		/// </summary>
		/// <param name="aShape"></param>
		public void UpdateShape(AnyShape aShape)
		{
			UpdateViews();			
		}

		/// <summary>method: DeleteShape
		/// delete shape and update views
		/// </summary>
		/// <param name="aShape"></param>
		public void DeleteShape(AnyShape aShape)
		{
			shapeList.Remove(aShape);
			UpdateViews();
		}

		/// <summary>method: SendToBack
		/// method to resequence arrayList so selected shape is 
		/// drawn first
		/// </summary>
		/// <param name="aShape"></param>
		public void SendToBack(AnyShape aShape)
		{
			// first shape drawn is at the back			
			// temp arrayList to resort shapes so selected shape is drawn first
			ArrayList sortList = new ArrayList();
			// find index of shape to be drawn first
			int max = shapeList.IndexOf(aShape);
			// first shape i.e. shape to send to back
			sortList.Add(aShape); 
			// copy to sortList in correct sequence
			for (int i = 0; i < max; i++)
			{
				sortList.Add(shapeList[i]);
			}

			// copy sortList back to shapeList
			for (int i = 0; i < sortList.Count; i++)
			{
				shapeList[i] = sortList[i];
			}
			UpdateViews();
		}

		/// <summary>method: BringToFront
		/// method to resequence arrayList so selected shape is 
		/// drawn last
		/// </summary>
		/// <param name="aShape"></param>
		public void BringToFront(AnyShape aShape)
		{
			// last shape drawn is at the front			
			// temp arrayList to resort shapes so selected shape is drawn last
			ArrayList sortList = new ArrayList(shapeList);
			// find index of shape to be drawn last
			int max = shapeList.IndexOf(aShape);
			// find length of shapeList array
			int length = shapeList.Count;
			// copy shapeList to sortList excluding selected shape
			for (int i = max + 1; i < length; i++)
			{
				sortList[i-1] = shapeList[i];
			}
			// last shape i.e. shape to bring to front
			sortList[length -1] = shapeList[max]; 
			// copy sortList back to shapeList
			for (int i = 0; i < sortList.Count; i++)
			{
				shapeList[i] = sortList[i];
			}
			UpdateViews();			
		}

		/// <summary>method: UpdateViews
		/// refresh all views
		/// </summary>
		public void UpdateViews()
		{
			theController.UpdateViews();
		}
	}
}
