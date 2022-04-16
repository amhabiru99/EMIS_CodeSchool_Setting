namespace ChangeSchoolCode
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
            this.cmdChangeSchoolCode = new System.Windows.Forms.Button();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.cmdChangeStaffId = new System.Windows.Forms.Button();
            this.txtStartStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAnytable_Start = new System.Windows.Forms.TextBox();
            this.txt_Any_Table = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdEnrolmentSchools = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdminCode = new System.Windows.Forms.TextBox();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdChangeSchoolCode
            // 
            this.cmdChangeSchoolCode.Location = new System.Drawing.Point(50, 253);
            this.cmdChangeSchoolCode.Name = "cmdChangeSchoolCode";
            this.cmdChangeSchoolCode.Size = new System.Drawing.Size(147, 39);
            this.cmdChangeSchoolCode.TabIndex = 0;
            this.cmdChangeSchoolCode.Text = "ChangeSchoolCode";
            this.cmdChangeSchoolCode.UseVisualStyleBackColor = true;
            this.cmdChangeSchoolCode.Click += new System.EventHandler(this.cmdChangeSchoolCode_Click);
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(71, 206);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(100, 20);
            this.txtstart.TabIndex = 1;
            // 
            // cmdChangeStaffId
            // 
            this.cmdChangeStaffId.Location = new System.Drawing.Point(427, 253);
            this.cmdChangeStaffId.Name = "cmdChangeStaffId";
            this.cmdChangeStaffId.Size = new System.Drawing.Size(146, 39);
            this.cmdChangeStaffId.TabIndex = 2;
            this.cmdChangeStaffId.Text = "ChangeStaffID";
            this.cmdChangeStaffId.UseVisualStyleBackColor = true;
            this.cmdChangeStaffId.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStartStaffID
            // 
            this.txtStartStaffID.Location = new System.Drawing.Point(436, 206);
            this.txtStartStaffID.Name = "txtStartStaffID";
            this.txtStartStaffID.Size = new System.Drawing.Size(137, 20);
            this.txtStartStaffID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "School Code(DatabaseCode)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(432, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Staff Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(762, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Tag = "ble";
            this.label3.Text = "Other_table";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "ChangeID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAnytable_Start
            // 
            this.txtAnytable_Start.Location = new System.Drawing.Point(733, 206);
            this.txtAnytable_Start.Name = "txtAnytable_Start";
            this.txtAnytable_Start.Size = new System.Drawing.Size(173, 20);
            this.txtAnytable_Start.TabIndex = 9;
            this.txtAnytable_Start.Visible = false;
            // 
            // txt_Any_Table
            // 
            this.txt_Any_Table.FormattingEnabled = true;
            this.txt_Any_Table.Items.AddRange(new object[] {
            "SCHOOL",
            "SCHOOL_GENERAL_DATA",
            "SCHOOL_HIV_AIDS_DATA",
            "SCHOOL_WASH_DATA",
            "ANNUAL_EXPENDITURES",
            "ANNUAL_EXPENDITURES_NON_GOV",
            "ANNUAL_REVENUES",
            "ANNUAL_REVENUES_NON_GOV",
            "BUILDINGS",
            "ENROLMENT_CHILD_T0_CHILD",
            "ENROLMENT_GRADE",
            "ENROLMENT_GRADE_AGE",
            "ENROLMENT_GRADE_DISABILITY",
            "ENROLMENT_ZERO_CLASS",
            "FAL_GRADUATES",
            "FAL_GRADUATES_CONTINUE",
            "FAL_MATERIAL",
            "LABORATORIES",
            "MATERIALS_EQUIPMENT",
            "NEW_ENT_G1",
            "NEW_ENT_G1_PRE_PRIMARY",
            "NEW_ENT_G5_ABE",
            "PUPILS_BOOKS",
            "PUPILS_BOOKS_AVAILABLE",
            "SEATS",
            "STAFF",
            "STAFF_SCHOOL",
            "TEACHERS_ATTRITION",
            "TEACHERS_GUIDES",
            "TEACHING_MATERIALS"});
            this.txt_Any_Table.Location = new System.Drawing.Point(733, 179);
            this.txt_Any_Table.Name = "txt_Any_Table";
            this.txt_Any_Table.Size = new System.Drawing.Size(173, 21);
            this.txt_Any_Table.TabIndex = 10;
            this.txt_Any_Table.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start.No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(379, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start.No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(676, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start.No";
            this.label6.Visible = false;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(50, 69);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(532, 20);
            this.txtDatabase.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Database";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(588, 66);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 14;
            this.cmdBrowse.Text = "...browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdEnrolmentSchools
            // 
            this.cmdEnrolmentSchools.Location = new System.Drawing.Point(741, 381);
            this.cmdEnrolmentSchools.Name = "cmdEnrolmentSchools";
            this.cmdEnrolmentSchools.Size = new System.Drawing.Size(115, 42);
            this.cmdEnrolmentSchools.TabIndex = 15;
            this.cmdEnrolmentSchools.Text = "EnrolmentSchools";
            this.cmdEnrolmentSchools.UseVisualStyleBackColor = true;
            this.cmdEnrolmentSchools.Visible = false;
            this.cmdEnrolmentSchools.Click += new System.EventHandler(this.cmdEnrolmentSchools_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Check School Code Avail and NotAvail";
            // 
            // txtAdminCode
            // 
            this.txtAdminCode.Location = new System.Drawing.Point(299, 393);
            this.txtAdminCode.Name = "txtAdminCode";
            this.txtAdminCode.Size = new System.Drawing.Size(189, 20);
            this.txtAdminCode.TabIndex = 17;
            // 
            // cmdCheck
            // 
            this.cmdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheck.ForeColor = System.Drawing.Color.Red;
            this.cmdCheck.Location = new System.Drawing.Point(330, 419);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(109, 36);
            this.cmdCheck.TabIndex = 18;
            this.cmdCheck.Text = "Check!";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 470);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.txtAdminCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdEnrolmentSchools);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Any_Table);
            this.Controls.Add(this.txtAnytable_Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartStaffID);
            this.Controls.Add(this.cmdChangeStaffId);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.cmdChangeSchoolCode);
            this.Name = "Form1";
            this.Text = "SchoolCode Setter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdChangeSchoolCode;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.Button cmdChangeStaffId;
        private System.Windows.Forms.TextBox txtStartStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAnytable_Start;
        private System.Windows.Forms.ComboBox txt_Any_Table;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdEnrolmentSchools;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdminCode;
        private System.Windows.Forms.Button cmdCheck;
    }
}

