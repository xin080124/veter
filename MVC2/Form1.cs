using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MVC2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private MVC_Model theModel;
		private MVC_Controller theController;
		private IView View1, View2;
		private ViewForm1 myViewForm1;
		private ViewForm2 myViewForm2;
		private System.Windows.Forms.Button btnMakeController;
		private System.Windows.Forms.Button btnmakeModel;
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
			this.btnmakeModel = new System.Windows.Forms.Button();
			this.btnMakeViews = new System.Windows.Forms.Button();
			this.btnShowViews = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMakeController
			// 
			this.btnMakeController.Location = new System.Drawing.Point(8, 0);
			this.btnMakeController.Name = "btnMakeController";
			this.btnMakeController.Size = new System.Drawing.Size(168, 32);
			this.btnMakeController.TabIndex = 5;
			this.btnMakeController.Text = "Make Controller";
			this.btnMakeController.Click += new System.EventHandler(this.btnMakeController_Click);
			// 
			// btnmakeModel
			// 
			this.btnmakeModel.Location = new System.Drawing.Point(8, 40);
			this.btnmakeModel.Name = "btnmakeModel";
			this.btnmakeModel.Size = new System.Drawing.Size(168, 32);
			this.btnmakeModel.TabIndex = 6;
			this.btnmakeModel.Text = "Make Model";
			this.btnmakeModel.Click += new System.EventHandler(this.btnmakeModel_Click);
			// 
			// btnMakeViews
			// 
			this.btnMakeViews.Location = new System.Drawing.Point(8, 80);
			this.btnMakeViews.Name = "btnMakeViews";
			this.btnMakeViews.Size = new System.Drawing.Size(168, 32);
			this.btnMakeViews.TabIndex = 7;
			this.btnMakeViews.Text = "MakeViews";
			this.btnMakeViews.Click += new System.EventHandler(this.btnMakeViews_Click);
			// 
			// btnShowViews
			// 
			this.btnShowViews.Location = new System.Drawing.Point(8, 120);
			this.btnShowViews.Name = "btnShowViews";
			this.btnShowViews.Size = new System.Drawing.Size(168, 32);
			this.btnShowViews.TabIndex = 8;
			this.btnShowViews.Text = "Show Views";
			this.btnShowViews.Click += new System.EventHandler(this.btnShowViews_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(184, 162);
			this.Controls.Add(this.btnShowViews);
			this.Controls.Add(this.btnMakeViews);
			this.Controls.Add(this.btnmakeModel);
			this.Controls.Add(this.btnMakeController);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "MVC2";
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
	  	
		private void btnMakeController_Click(object sender, System.EventArgs e)
		{
			theController = new MVC_Controller();
		}

		private void btnmakeModel_Click(object sender, System.EventArgs e)
		{
			theModel = new MVC_Model(theController);
		}

		private void btnMakeViews_Click(object sender, System.EventArgs e)
		{
			myViewForm1 = new ViewForm1();
			myViewForm2 = new ViewForm2();
			myViewForm1.MyModel = theModel;
			myViewForm2.MyModel = theModel;
			theController.AddView(myViewForm1);
			theController.AddView(myViewForm2);
		}

		private void btnShowViews_Click(object sender, System.EventArgs e)
		{
			myViewForm1.Show();
			myViewForm2.Show();
		}

	}
}
