namespace hotel
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtNight = new System.Windows.Forms.TextBox();
            this.txtpriceNight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter ROOMType";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter number of night";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter price per night";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(298, 35);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(203, 26);
            this.txtGuestName.TabIndex = 4;
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtguestnumber_TextChanged);
            // 
            // txtNight
            // 
            this.txtNight.Location = new System.Drawing.Point(298, 127);
            this.txtNight.Name = "txtNight";
            this.txtNight.Size = new System.Drawing.Size(218, 26);
            this.txtNight.TabIndex = 6;
            this.txtNight.TextChanged += new System.EventHandler(this.txtNight_TextChanged);
            // 
            // txtpriceNight
            // 
            this.txtpriceNight.Location = new System.Drawing.Point(298, 176);
            this.txtpriceNight.Name = "txtpriceNight";
            this.txtpriceNight.Size = new System.Drawing.Size(198, 26);
            this.txtpriceNight.TabIndex = 7;
            this.txtpriceNight.TextChanged += new System.EventHandler(this.txtpriceNight_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Deluxe",
            "Standrad",
            "Suit"});
            this.comboBox1.Location = new System.Drawing.Point(298, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ServiceTax";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "DiscountAmount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "TotalAmount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Guest Name";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalAmount.Location = new System.Drawing.Point(209, 528);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.lblTotalAmount.TabIndex = 19;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiscount.Location = new System.Drawing.Point(209, 450);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(128, 20);
            this.lblDiscount.TabIndex = 18;
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblServiceTax.Location = new System.Drawing.Point(209, 369);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(86, 20);
            this.lblServiceTax.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 644);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpriceNight);
            this.Controls.Add(this.txtNight);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtNight;
        private System.Windows.Forms.TextBox txtpriceNight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblServiceTax;
    }
}

