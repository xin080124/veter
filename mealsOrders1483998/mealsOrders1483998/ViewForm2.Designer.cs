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
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkBoxIfSpicy = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSelectTime = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxTakeAway = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBBQ = new System.Windows.Forms.Label();
            this.labelBeef = new System.Windows.Forms.Label();
            this.labelSeafood = new System.Windows.Forms.Label();
            this.labelVege = new System.Windows.Forms.Label();
            this.txtYpos = new System.Windows.Forms.TextBox();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.Color.White;
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(38, 12);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(500, 184);
            this.pnlDrawOn.TabIndex = 1;
            this.pnlDrawOn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseClick);
            this.pnlDrawOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseDown);
            this.pnlDrawOn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseMove);
            this.pnlDrawOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseUp);
            // 
            // rbPizza
            // 
            this.rbPizza.Checked = true;
            this.rbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizza.Location = new System.Drawing.Point(12, 287);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(104, 24);
            this.rbPizza.TabIndex = 25;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.Click += new System.EventHandler(this.rbPizza_Click);
            // 
            // rbNoodle
            // 
            this.rbNoodle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoodle.Location = new System.Drawing.Point(12, 225);
            this.rbNoodle.Name = "rbNoodle";
            this.rbNoodle.Size = new System.Drawing.Size(104, 24);
            this.rbNoodle.TabIndex = 26;
            this.rbNoodle.Text = "Noodle";
            this.rbNoodle.Click += new System.EventHandler(this.rbNoodle_Click);
            // 
            // rbCake
            // 
            this.rbCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCake.Location = new System.Drawing.Point(12, 255);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(104, 24);
            this.rbCake.TabIndex = 27;
            this.rbCake.Text = "Cake";
            this.rbCake.Click += new System.EventHandler(this.rbCake_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(416, 206);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(136, 32);
            this.btnAddOrder.TabIndex = 24;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Location = new System.Drawing.Point(416, 249);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(136, 32);
            this.btnDelOrder.TabIndex = 28;
            this.btnDelOrder.Text = "Delete Order";
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // labelSize
            // 
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(90, 256);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(50, 24);
            this.labelSize.TabIndex = 43;
            this.labelSize.Text = "Size";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSize.Items.AddRange(new object[] {
            "Select size.....",
            "6",
            "8",
            "12 "});
            this.comboBoxSize.Location = new System.Drawing.Point(138, 253);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(76, 28);
            this.comboBoxSize.TabIndex = 42;
            // 
            // checkBoxIfSpicy
            // 
            this.checkBoxIfSpicy.AutoSize = true;
            this.checkBoxIfSpicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIfSpicy.Location = new System.Drawing.Point(122, 223);
            this.checkBoxIfSpicy.Name = "checkBoxIfSpicy";
            this.checkBoxIfSpicy.Size = new System.Drawing.Size(95, 29);
            this.checkBoxIfSpicy.TabIndex = 41;
            this.checkBoxIfSpicy.Tag = "";
            this.checkBoxIfSpicy.Text = "ifSpicy";
            this.checkBoxIfSpicy.UseVisualStyleBackColor = true;
            this.checkBoxIfSpicy.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Time";
            // 
            // cmbSelectTime
            // 
            this.cmbSelectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTime.Items.AddRange(new object[] {
            "Select display.....",
            "0 min (right now)",
            "30 min after",
            "60 min after",
            "120 min after"});
            this.cmbSelectTime.Location = new System.Drawing.Point(274, 253);
            this.cmbSelectTime.Name = "cmbSelectTime";
            this.cmbSelectTime.Size = new System.Drawing.Size(127, 28);
            this.cmbSelectTime.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(296, 226);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 26);
            this.txtPrice.TabIndex = 45;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(240, 228);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 24);
            this.labelPrice.TabIndex = 46;
            this.labelPrice.Text = "Price";
            // 
            // checkBoxTakeAway
            // 
            this.checkBoxTakeAway.AutoSize = true;
            this.checkBoxTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTakeAway.Location = new System.Drawing.Point(275, 199);
            this.checkBoxTakeAway.Name = "checkBoxTakeAway";
            this.checkBoxTakeAway.Size = new System.Drawing.Size(135, 29);
            this.checkBoxTakeAway.TabIndex = 44;
            this.checkBoxTakeAway.Tag = "";
            this.checkBoxTakeAway.Text = "Take away";
            this.checkBoxTakeAway.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelBBQ);
            this.panel1.Controls.Add(this.labelBeef);
            this.panel1.Controls.Add(this.labelSeafood);
            this.panel1.Controls.Add(this.labelVege);
            this.panel1.Location = new System.Drawing.Point(112, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 99);
            this.panel1.TabIndex = 49;
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
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Lime;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(177, 70);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(24, 24);
            this.lblColor.TabIndex = 30;
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
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Flavor";
            // 
            // labelBBQ
            // 
            this.labelBBQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBBQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBBQ.Location = new System.Drawing.Point(225, 32);
            this.labelBBQ.Name = "labelBBQ";
            this.labelBBQ.Size = new System.Drawing.Size(46, 24);
            this.labelBBQ.TabIndex = 8;
            this.labelBBQ.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // labelBeef
            // 
            this.labelBeef.BackColor = System.Drawing.Color.Red;
            this.labelBeef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBeef.Location = new System.Drawing.Point(8, 31);
            this.labelBeef.Name = "labelBeef";
            this.labelBeef.Size = new System.Drawing.Size(48, 24);
            this.labelBeef.TabIndex = 5;
            this.labelBeef.Click += new System.EventHandler(this.lblSelectFlavor_Click);
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
            this.labelVege.Location = new System.Drawing.Point(8, 7);
            this.labelVege.Name = "labelVege";
            this.labelVege.Size = new System.Drawing.Size(48, 24);
            this.labelVege.TabIndex = 1;
            this.labelVege.Click += new System.EventHandler(this.lblSelectFlavor_Click);
            // 
            // txtYpos
            // 
            this.txtYpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYpos.Location = new System.Drawing.Point(53, 354);
            this.txtYpos.Name = "txtYpos";
            this.txtYpos.Size = new System.Drawing.Size(40, 26);
            this.txtYpos.TabIndex = 51;
            // 
            // txtXpos
            // 
            this.txtXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXpos.Location = new System.Drawing.Point(53, 314);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(40, 26);
            this.txtXpos.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "X";
            // 
            // ViewForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.txtYpos);
            this.Controls.Add(this.txtXpos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSelectTime);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.checkBoxTakeAway);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.checkBoxIfSpicy);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.rbPizza);
            this.Controls.Add(this.rbNoodle);
            this.Controls.Add(this.rbCake);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.pnlDrawOn);
            this.Name = "ViewForm2";
            this.Text = "ViewForm2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbNoodle;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxIfSpicy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSelectTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxTakeAway;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBBQ;
        private System.Windows.Forms.Label labelBeef;
        private System.Windows.Forms.Label labelSeafood;
        private System.Windows.Forms.Label labelVege;
        private System.Windows.Forms.TextBox txtYpos;
        private System.Windows.Forms.TextBox txtXpos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}