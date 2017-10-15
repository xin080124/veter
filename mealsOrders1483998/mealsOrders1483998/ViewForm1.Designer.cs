namespace mealsOrders1483998
{
    partial class ViewForm1
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbNoodle = new System.Windows.Forms.RadioButton();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(157, 254);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(136, 32);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // rbPizza
            // 
            this.rbPizza.Checked = true;
            this.rbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizza.Location = new System.Drawing.Point(13, 224);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(104, 24);
            this.rbPizza.TabIndex = 21;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.Click += new System.EventHandler(this.rbPizza_Click);
            // 
            // rbNoodle
            // 
            this.rbNoodle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoodle.Location = new System.Drawing.Point(12, 254);
            this.rbNoodle.Name = "rbNoodle";
            this.rbNoodle.Size = new System.Drawing.Size(104, 24);
            this.rbNoodle.TabIndex = 22;
            this.rbNoodle.Text = "Noodle";
            // 
            // rbCake
            // 
            this.rbCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCake.Location = new System.Drawing.Point(12, 284);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(104, 24);
            this.rbCake.TabIndex = 23;
            this.rbCake.Text = "Cake";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 204);
            this.listBox1.TabIndex = 24;
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbPizza);
            this.Controls.Add(this.rbNoodle);
            this.Controls.Add(this.rbCake);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbNoodle;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.ListBox listBox1;
    }
}