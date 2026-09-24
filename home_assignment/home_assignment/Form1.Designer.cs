namespace home_assignment
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayweek = new System.Windows.Forms.TextBox();
            this.txtnumeric = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblytear = new System.Windows.Forms.Label();
            this.lblnumeric = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lbldayweek = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(479, 356);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(114, 57);
            this.btnclose.TabIndex = 36;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(310, 349);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(135, 64);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(109, 349);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(175, 58);
            this.btnshow.TabIndex = 34;
            this.btnshow.Text = "Show Date";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(299, 82);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(188, 26);
            this.txtmonth.TabIndex = 33;
            // 
            // txtdayweek
            // 
            this.txtdayweek.Location = new System.Drawing.Point(310, 45);
            this.txtdayweek.Name = "txtdayweek";
            this.txtdayweek.Size = new System.Drawing.Size(186, 26);
            this.txtdayweek.TabIndex = 32;
            // 
            // txtnumeric
            // 
            this.txtnumeric.Location = new System.Drawing.Point(299, 138);
            this.txtnumeric.Name = "txtnumeric";
            this.txtnumeric.Size = new System.Drawing.Size(197, 26);
            this.txtnumeric.TabIndex = 31;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(295, 194);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(201, 26);
            this.txtyear.TabIndex = 30;
            this.txtyear.TextChanged += new System.EventHandler(this.txttear_TextChanged);
            // 
            // lblytear
            // 
            this.lblytear.AutoSize = true;
            this.lblytear.Location = new System.Drawing.Point(114, 190);
            this.lblytear.Name = "lblytear";
            this.lblytear.Size = new System.Drawing.Size(116, 20);
            this.lblytear.TabIndex = 29;
            this.lblytear.Text = "enter the yeAR";
            // 
            // lblnumeric
            // 
            this.lblnumeric.AutoSize = true;
            this.lblnumeric.Location = new System.Drawing.Point(100, 143);
            this.lblnumeric.Name = "lblnumeric";
            this.lblnumeric.Size = new System.Drawing.Size(184, 20);
            this.lblnumeric.TabIndex = 28;
            this.lblnumeric.Text = "enter the name of month";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Location = new System.Drawing.Point(146, 81);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(54, 20);
            this.lblmonth.TabIndex = 27;
            this.lblmonth.Text = "month";
            // 
            // lbldayweek
            // 
            this.lbldayweek.AutoSize = true;
            this.lbldayweek.Location = new System.Drawing.Point(132, 49);
            this.lbldayweek.Name = "lbldayweek";
            this.lbldayweek.Size = new System.Drawing.Size(85, 20);
            this.lbldayweek.TabIndex = 26;
            this.lbldayweek.Text = "dayofweek";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(114, 273);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(382, 45);
            this.lbloutput.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayweek);
            this.Controls.Add(this.txtnumeric);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lblytear);
            this.Controls.Add(this.lblnumeric);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lbldayweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayweek;
        private System.Windows.Forms.TextBox txtnumeric;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblytear;
        private System.Windows.Forms.Label lblnumeric;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lbldayweek;
        private System.Windows.Forms.Label lbloutput;
    }
}

