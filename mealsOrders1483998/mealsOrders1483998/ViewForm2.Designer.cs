namespace mealsOrders1483998
{
    partial class ViewForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbNoodle = new System.Windows.Forms.RadioButton();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.Color.White;
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(38, 12);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(500, 261);
            this.pnlDrawOn.TabIndex = 1;
            // 
            // rbPizza
            // 
            this.rbPizza.Checked = true;
            this.rbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizza.Location = new System.Drawing.Point(50, 279);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(104, 24);
            this.rbPizza.TabIndex = 25;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            // 
            // rbNoodle
            // 
            this.rbNoodle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoodle.Location = new System.Drawing.Point(50, 309);
            this.rbNoodle.Name = "rbNoodle";
            this.rbNoodle.Size = new System.Drawing.Size(104, 24);
            this.rbNoodle.TabIndex = 26;
            this.rbNoodle.Text = "Noodle";
            // 
            // rbCake
            // 
            this.rbCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCake.Location = new System.Drawing.Point(50, 339);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(104, 24);
            this.rbCake.TabIndex = 27;
            this.rbCake.Text = "Cake";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(402, 301);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(136, 32);
            this.btnAddOrder.TabIndex = 24;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // ViewForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.rbPizza);
            this.Controls.Add(this.rbNoodle);
            this.Controls.Add(this.rbCake);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.pnlDrawOn);
            this.Name = "ViewForm2";
            this.Text = "ViewForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbNoodle;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.Button btnAddOrder;
    }
}