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
            this.txtYpos = new System.Windows.Forms.TextBox();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSeafood = new System.Windows.Forms.Label();
            this.labelVege = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(294, 252);
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
            this.listBox1.Size = new System.Drawing.Size(459, 204);
            this.listBox1.TabIndex = 24;
            // 
            // txtYpos
            // 
            this.txtYpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYpos.Location = new System.Drawing.Point(216, 270);
            this.txtYpos.Name = "txtYpos";
            this.txtYpos.Size = new System.Drawing.Size(40, 26);
            this.txtYpos.TabIndex = 26;
            // 
            // txtXpos
            // 
            this.txtXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXpos.Location = new System.Drawing.Point(216, 238);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(40, 26);
            this.txtXpos.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelSeafood);
            this.panel1.Controls.Add(this.labelVege);
            this.panel1.Location = new System.Drawing.Point(98, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 64);
            this.panel1.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(225, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 24);
            this.label16.TabIndex = 8;
            this.label16.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(8, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 5;
            this.label13.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // labelSeafood
            // 
            this.labelSeafood.BackColor = System.Drawing.Color.Aqua;
            this.labelSeafood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeafood.Location = new System.Drawing.Point(225, 8);
            this.labelSeafood.Name = "labelSeafood";
            this.labelSeafood.Size = new System.Drawing.Size(46, 24);
            this.labelSeafood.TabIndex = 2;
            this.labelSeafood.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // labelVege
            // 
            this.labelVege.BackColor = System.Drawing.Color.Lime;
            this.labelVege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVege.Location = new System.Drawing.Point(8, 8);
            this.labelVege.Name = "labelVege";
            this.labelVege.Size = new System.Drawing.Size(48, 24);
            this.labelVege.TabIndex = 1;
            this.labelVege.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Lime;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(288, 392);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(24, 24);
            this.lblColor.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Flavor";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Beef";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Vegetable";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "BBQ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Seafood";
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYpos);
            this.Controls.Add(this.txtXpos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbPizza);
            this.Controls.Add(this.rbNoodle);
            this.Controls.Add(this.rbCake);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbNoodle;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtYpos;
        private System.Windows.Forms.TextBox txtXpos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSeafood;
        private System.Windows.Forms.Label labelVege;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}