using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MVC_Shapes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ShapesModel theModel;
		private ShapesController theController;			
		private ViewForm1 myViewForm1;
		private ViewForm2 myViewForm2;
		private ViewForm3 myViewForm3;
		private System.Windows.Forms.Button btnMakeController;
		private System.Windows.Forms.Button btnMakeModel;
		private System.Windows.Forms.Button btnMakeViews;
		private System.Windows.Forms.Button btnShowViews;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMakeController = new System.Windows.Forms.Button();
			this.btnMakeModel = new System.Windows.Forms.Button();
			this.btnMakeViews = new System.Windows.Forms.Button();
			this.btnShowViews = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMakeController
			// 
			this.btnMakeController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMakeController.Location = new System.Drawing.Point(8, 8);
			this.btnMakeController.Name = "btnMakeController";
			this.btnMakeController.Size = new System.Drawing.Size(136, 32);
			this.btnMakeController.TabIndex = 0;
			this.btnMakeController.Text = "Make Controller";
			this.btnMakeController.Click += new System.EventHandler(this.btnMakeController_Click);
			// 
			// btnMakeModel
			// 
			this.btnMakeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMakeModel.Location = new System.Drawing.Point(8, 48);
			this.btnMakeModel.Name = "btnMakeModel";
			this.btnMakeModel.Size = new System.Drawing.Size(136, 32);
			this.btnMakeModel.TabIndex = 1;
			this.btnMakeModel.Text = "Make Model";
			this.btnMakeModel.Click += new System.EventHandler(this.btnMakeModel_Click);
			// 
			// btnMakeViews
			// 
			this.btnMakeViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMakeViews.Location = new System.Drawing.Point(8, 88);
			this.btnMakeViews.Name = "btnMakeViews";
			this.btnMakeViews.Size = new System.Drawing.Size(136, 32);
			this.btnMakeViews.TabIndex = 2;
			this.btnMakeViews.Text = "Make Views";
			this.btnMakeViews.Click += new System.EventHandler(this.btnMakeViews_Click);
			// 
			// btnShowViews
			// 
			this.btnShowViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnShowViews.Location = new System.Drawing.Point(8, 128);
			this.btnShowViews.Name = "btnShowViews";
			this.btnShowViews.Size = new System.Drawing.Size(136, 32);
			this.btnShowViews.TabIndex = 3;
			this.btnShowViews.Text = "Show Views";
			this.btnShowViews.Click += new System.EventHandler(this.btnShowViews_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(152, 174);
			this.Controls.Add(this.btnShowViews);
			this.Controls.Add(this.btnMakeViews);
			this.Controls.Add(this.btnMakeModel);
			this.Controls.Add(this.btnMakeController);
			this.Name = "Form1";
			this.Text = "Shapes";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#region Code for Button Clicks on Form now redundant

/// this block of code for button clicks is redundant as it is all included
/// in the completeSetUp method which runs when the form loads.

		private void btnMakeController_Click(object sender, System.EventArgs e)
		{
			theController = new ShapesController();
		}

		private void btnMakeModel_Click(object sender, System.EventArgs e)
		{
			theModel = new ShapesModel(theController);
		}

		private void btnMakeViews_Click(object sender, System.EventArgs e)
		{
			myViewForm1 = new ViewForm1();
			myViewForm2 = new ViewForm2();
			myViewForm3 = new ViewForm3();
			myViewForm1.MyModel = theModel;
			myViewForm2.MyModel = theModel;
			myViewForm3.MyModel = theModel;
			theController.AddView(myViewForm1);			
			theController.AddView(myViewForm2);			
			theController.AddView(myViewForm3);			
		}

		private void btnShowViews_Click(object sender, System.EventArgs e)
		{
			myViewForm1.Show();
			myViewForm2.Show();
			myViewForm3.Show();
		}

		#endregion


		/// <summary>method: completeSetUp
		/// make controller
		/// make model
		/// make views and 
		/// show views
		/// </summary>
		private void completeSetUp()
		{
			// make controller
			theController = new ShapesController();
			// make model
			theModel = new ShapesModel(theController);
			// make views
			myViewForm1 = new ViewForm1();
			myViewForm2 = new ViewForm2();
			myViewForm3 = new ViewForm3();
			myViewForm1.MyModel = theModel;
			myViewForm2.MyModel = theModel;
			myViewForm3.MyModel = theModel;

			theController.AddView(myViewForm1);			
			theController.AddView(myViewForm2);			
			theController.AddView(myViewForm3);	

			//show views
			myViewForm3.Show();
			myViewForm2.Show();
			myViewForm1.Show();
		}

		/// <summary> method: Form1_Load
		/// executes completeSetUp method when form loads to 
		/// make controller
		/// make model
		/// make views and 
		/// show views
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.completeSetUp();				
		}
	}
}
