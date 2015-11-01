namespace Project1CSharp
{
    partial class Admin___Course___Edit
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.multirecord = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.instructorID = new System.Windows.Forms.ComboBox();
            this.coursehours = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.TextBox();
            this.courseid = new System.Windows.Forms.TextBox();
            this.coursedescription = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursehours)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 49);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 44;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.editExistingUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Checked = true;
            this.addNewUserToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            // 
            // editExistingUserToolStripMenuItem
            // 
            this.editExistingUserToolStripMenuItem.Name = "editExistingUserToolStripMenuItem";
            this.editExistingUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editExistingUserToolStripMenuItem.Text = "Edit Existing User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.multirecord);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.category);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.searchbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 118);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(266, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Multi-Record:";
            // 
            // multirecord
            // 
            this.multirecord.Enabled = false;
            this.multirecord.FormattingEnabled = true;
            this.multirecord.Location = new System.Drawing.Point(141, 81);
            this.multirecord.Name = "multirecord";
            this.multirecord.Size = new System.Drawing.Size(200, 21);
            this.multirecord.TabIndex = 30;
            this.multirecord.SelectedIndexChanged += new System.EventHandler(this.multirecord_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Select Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Course ID",
            "Course Name",
            "Instructor ID"});
            this.category.Location = new System.Drawing.Point(141, 28);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(200, 21);
            this.category.TabIndex = 28;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Search:";
            // 
            // searchbox
            // 
            this.searchbox.Enabled = false;
            this.searchbox.Location = new System.Drawing.Point(141, 55);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(117, 20);
            this.searchbox.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.instructorID);
            this.groupBox1.Controls.Add(this.coursehours);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coursename);
            this.groupBox1.Controls.Add(this.courseid);
            this.groupBox1.Controls.Add(this.coursedescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 251);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // instructorID
            // 
            this.instructorID.Enabled = false;
            this.instructorID.FormattingEnabled = true;
            this.instructorID.Location = new System.Drawing.Point(143, 78);
            this.instructorID.Name = "instructorID";
            this.instructorID.Size = new System.Drawing.Size(200, 21);
            this.instructorID.TabIndex = 1;
            // 
            // coursehours
            // 
            this.coursehours.Enabled = false;
            this.coursehours.Location = new System.Drawing.Point(143, 105);
            this.coursehours.Name = "coursehours";
            this.coursehours.Size = new System.Drawing.Size(200, 20);
            this.coursehours.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Instructor ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Course Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course ID:";
            // 
            // coursename
            // 
            this.coursename.Enabled = false;
            this.coursename.Location = new System.Drawing.Point(143, 52);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(200, 20);
            this.coursename.TabIndex = 0;
            // 
            // courseid
            // 
            this.courseid.Enabled = false;
            this.courseid.Location = new System.Drawing.Point(143, 26);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(200, 20);
            this.courseid.TabIndex = 6;
            // 
            // coursedescription
            // 
            this.coursedescription.Enabled = false;
            this.coursedescription.Location = new System.Drawing.Point(143, 131);
            this.coursedescription.Multiline = true;
            this.coursedescription.Name = "coursedescription";
            this.coursedescription.Size = new System.Drawing.Size(200, 106);
            this.coursedescription.TabIndex = 3;
            // 
            // Admin___Course___Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Admin___Course___Edit";
            this.Text = "Admin___Course___Edit";
            this.Load += new System.EventHandler(this.Admin___Course___Edit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursehours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox multirecord;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox instructorID;
        private System.Windows.Forms.NumericUpDown coursehours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coursename;
        private System.Windows.Forms.TextBox courseid;
        private System.Windows.Forms.TextBox coursedescription;

    }
}