namespace assigment_1
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
            this.txtdept = new System.Windows.Forms.TextBox();
            this.lbldept = new System.Windows.Forms.Label();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdept
            // 
            this.txtdept.Location = new System.Drawing.Point(387, 242);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(221, 26);
            this.txtdept.TabIndex = 16;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(191, 235);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(109, 20);
            this.lbldept.TabIndex = 15;
            this.lbldept.Text = "enter the dept";
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(382, 184);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(226, 26);
            this.txtsemester.TabIndex = 14;
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(177, 190);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(147, 20);
            this.lblsemester.TabIndex = 13;
            this.lblsemester.Text = " enter the semester";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(373, 135);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(235, 26);
            this.txtstudentid.TabIndex = 12;
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(172, 135);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(147, 20);
            this.lblstudentid.TabIndex = 11;
            this.lblstudentid.Text = "enter the student id";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(375, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(235, 26);
            this.txtname.TabIndex = 10;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(183, 100);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(175, 20);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "enter the student name";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(177, 315);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(431, 53);
            this.lbloutput.TabIndex = 17;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(512, 412);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 57);
            this.btnexit.TabIndex = 39;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(343, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(135, 64);
            this.btnclear.TabIndex = 38;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(142, 405);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(175, 58);
            this.btnshowinfo.TabIndex = 37;
            this.btnshowinfo.Text = "SHOW information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Label label1;
    }
}

