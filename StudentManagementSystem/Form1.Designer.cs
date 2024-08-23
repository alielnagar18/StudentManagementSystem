namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_slide = new Panel();
            button_Exit = new Button();
            button_Dashboard = new Button();
            panel_ScoreSubMenu = new Panel();
            button_ScorePrint = new Button();
            button_ManageScore = new Button();
            button_NewScore = new Button();
            button_Score = new Button();
            panel_CourseSubMenu = new Panel();
            button_CoursePrint = new Button();
            button_ManageCourse = new Button();
            button_NewCourse = new Button();
            button_Course = new Button();
            panel_StdSubMenu = new Panel();
            button_StdPrint = new Button();
            button_ManageStudent = new Button();
            button_Registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel_Main = new Panel();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label_femalestd = new Label();
            label_malestd = new Label();
            label_totalstd = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label_Role = new Label();
            label_User = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            panel_slide.SuspendLayout();
            panel_ScoreSubMenu.SuspendLayout();
            panel_CourseSubMenu.SuspendLayout();
            panel_StdSubMenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_Main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
            panel_slide.Controls.Add(button_Exit);
            panel_slide.Controls.Add(button_Dashboard);
            panel_slide.Controls.Add(panel_ScoreSubMenu);
            panel_slide.Controls.Add(button_Score);
            panel_slide.Controls.Add(panel_CourseSubMenu);
            panel_slide.Controls.Add(button_Course);
            panel_slide.Controls.Add(panel_StdSubMenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(216, 603);
            panel_slide.TabIndex = 0;
            panel_slide.Paint += panel_slide_Paint;
            // 
            // button_Exit
            // 
            button_Exit.Dock = DockStyle.Top;
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(0, 756);
            button_Exit.Name = "button_Exit";
            button_Exit.Padding = new Padding(10, 0, 0, 0);
            button_Exit.Size = new Size(195, 42);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "Exit";
            button_Exit.TextAlign = ContentAlignment.MiddleLeft;
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Dashboard
            // 
            button_Dashboard.Dock = DockStyle.Top;
            button_Dashboard.FlatAppearance.BorderSize = 0;
            button_Dashboard.FlatStyle = FlatStyle.Flat;
            button_Dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Dashboard.ForeColor = Color.White;
            button_Dashboard.Location = new Point(0, 714);
            button_Dashboard.Name = "button_Dashboard";
            button_Dashboard.Padding = new Padding(10, 0, 0, 0);
            button_Dashboard.Size = new Size(195, 42);
            button_Dashboard.TabIndex = 6;
            button_Dashboard.Text = "Dashboard";
            button_Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_Dashboard.UseVisualStyleBackColor = true;
            button_Dashboard.Click += button_Dashboard_Click;
            // 
            // panel_ScoreSubMenu
            // 
            panel_ScoreSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_ScoreSubMenu.Controls.Add(button_ScorePrint);
            panel_ScoreSubMenu.Controls.Add(button_ManageScore);
            panel_ScoreSubMenu.Controls.Add(button_NewScore);
            panel_ScoreSubMenu.Dock = DockStyle.Top;
            panel_ScoreSubMenu.Location = new Point(0, 563);
            panel_ScoreSubMenu.Name = "panel_ScoreSubMenu";
            panel_ScoreSubMenu.Size = new Size(195, 151);
            panel_ScoreSubMenu.TabIndex = 5;
            // 
            // button_ScorePrint
            // 
            button_ScorePrint.Dock = DockStyle.Top;
            button_ScorePrint.FlatAppearance.BorderSize = 0;
            button_ScorePrint.FlatStyle = FlatStyle.Flat;
            button_ScorePrint.ForeColor = Color.White;
            button_ScorePrint.Location = new Point(0, 100);
            button_ScorePrint.Name = "button_ScorePrint";
            button_ScorePrint.Padding = new Padding(35, 0, 0, 0);
            button_ScorePrint.Size = new Size(195, 50);
            button_ScorePrint.TabIndex = 3;
            button_ScorePrint.Text = "Print";
            button_ScorePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_ScorePrint.UseVisualStyleBackColor = true;
            button_ScorePrint.Click += button_ScorePrint_Click;
            // 
            // button_ManageScore
            // 
            button_ManageScore.Dock = DockStyle.Top;
            button_ManageScore.FlatAppearance.BorderSize = 0;
            button_ManageScore.FlatStyle = FlatStyle.Flat;
            button_ManageScore.ForeColor = Color.White;
            button_ManageScore.Location = new Point(0, 50);
            button_ManageScore.Name = "button_ManageScore";
            button_ManageScore.Padding = new Padding(35, 0, 0, 0);
            button_ManageScore.Size = new Size(195, 50);
            button_ManageScore.TabIndex = 1;
            button_ManageScore.Text = "Manage Score";
            button_ManageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_ManageScore.UseVisualStyleBackColor = true;
            button_ManageScore.Click += button_ManageScore_Click;
            // 
            // button_NewScore
            // 
            button_NewScore.Dock = DockStyle.Top;
            button_NewScore.FlatAppearance.BorderSize = 0;
            button_NewScore.FlatStyle = FlatStyle.Flat;
            button_NewScore.ForeColor = Color.White;
            button_NewScore.Location = new Point(0, 0);
            button_NewScore.Name = "button_NewScore";
            button_NewScore.Padding = new Padding(35, 0, 0, 0);
            button_NewScore.Size = new Size(195, 50);
            button_NewScore.TabIndex = 0;
            button_NewScore.Text = "New Score";
            button_NewScore.TextAlign = ContentAlignment.MiddleLeft;
            button_NewScore.UseVisualStyleBackColor = true;
            button_NewScore.Click += button_NewScore_Click;
            // 
            // button_Score
            // 
            button_Score.Dock = DockStyle.Top;
            button_Score.FlatAppearance.BorderSize = 0;
            button_Score.FlatStyle = FlatStyle.Flat;
            button_Score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Score.ForeColor = Color.White;
            button_Score.Location = new Point(0, 522);
            button_Score.Name = "button_Score";
            button_Score.Padding = new Padding(10, 0, 0, 0);
            button_Score.Size = new Size(195, 41);
            button_Score.TabIndex = 4;
            button_Score.Text = "Score";
            button_Score.TextAlign = ContentAlignment.MiddleLeft;
            button_Score.UseVisualStyleBackColor = true;
            button_Score.Click += button_Score_Click;
            // 
            // panel_CourseSubMenu
            // 
            panel_CourseSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_CourseSubMenu.Controls.Add(button_CoursePrint);
            panel_CourseSubMenu.Controls.Add(button_ManageCourse);
            panel_CourseSubMenu.Controls.Add(button_NewCourse);
            panel_CourseSubMenu.Dock = DockStyle.Top;
            panel_CourseSubMenu.Location = new Point(0, 368);
            panel_CourseSubMenu.Name = "panel_CourseSubMenu";
            panel_CourseSubMenu.Size = new Size(195, 154);
            panel_CourseSubMenu.TabIndex = 3;
            // 
            // button_CoursePrint
            // 
            button_CoursePrint.Dock = DockStyle.Top;
            button_CoursePrint.FlatAppearance.BorderSize = 0;
            button_CoursePrint.FlatStyle = FlatStyle.Flat;
            button_CoursePrint.ForeColor = Color.White;
            button_CoursePrint.Location = new Point(0, 100);
            button_CoursePrint.Name = "button_CoursePrint";
            button_CoursePrint.Padding = new Padding(35, 0, 0, 0);
            button_CoursePrint.Size = new Size(195, 48);
            button_CoursePrint.TabIndex = 3;
            button_CoursePrint.Text = "Print";
            button_CoursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_CoursePrint.UseVisualStyleBackColor = true;
            button_CoursePrint.Click += button_CoursePrint_Click;
            // 
            // button_ManageCourse
            // 
            button_ManageCourse.Dock = DockStyle.Top;
            button_ManageCourse.FlatAppearance.BorderSize = 0;
            button_ManageCourse.FlatStyle = FlatStyle.Flat;
            button_ManageCourse.ForeColor = Color.White;
            button_ManageCourse.Location = new Point(0, 50);
            button_ManageCourse.Name = "button_ManageCourse";
            button_ManageCourse.Padding = new Padding(35, 0, 0, 0);
            button_ManageCourse.Size = new Size(195, 50);
            button_ManageCourse.TabIndex = 1;
            button_ManageCourse.Text = "Manage Course";
            button_ManageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_ManageCourse.UseVisualStyleBackColor = true;
            button_ManageCourse.Click += button_ManageCourse_Click;
            // 
            // button_NewCourse
            // 
            button_NewCourse.Dock = DockStyle.Top;
            button_NewCourse.FlatAppearance.BorderSize = 0;
            button_NewCourse.FlatStyle = FlatStyle.Flat;
            button_NewCourse.ForeColor = Color.White;
            button_NewCourse.Location = new Point(0, 0);
            button_NewCourse.Name = "button_NewCourse";
            button_NewCourse.Padding = new Padding(35, 0, 0, 0);
            button_NewCourse.Size = new Size(195, 50);
            button_NewCourse.TabIndex = 0;
            button_NewCourse.Text = "New Course";
            button_NewCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_NewCourse.UseVisualStyleBackColor = true;
            button_NewCourse.Click += button_NewCourse_Click;
            // 
            // button_Course
            // 
            button_Course.Dock = DockStyle.Top;
            button_Course.FlatAppearance.BorderSize = 0;
            button_Course.FlatStyle = FlatStyle.Flat;
            button_Course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Course.ForeColor = Color.White;
            button_Course.Location = new Point(0, 326);
            button_Course.Name = "button_Course";
            button_Course.Padding = new Padding(10, 0, 0, 0);
            button_Course.Size = new Size(195, 42);
            button_Course.TabIndex = 2;
            button_Course.Text = "Course";
            button_Course.TextAlign = ContentAlignment.MiddleLeft;
            button_Course.UseVisualStyleBackColor = true;
            button_Course.Click += button_Course_Click;
            // 
            // panel_StdSubMenu
            // 
            panel_StdSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_StdSubMenu.Controls.Add(button_StdPrint);
            panel_StdSubMenu.Controls.Add(button_ManageStudent);
            panel_StdSubMenu.Controls.Add(button_Registration);
            panel_StdSubMenu.Dock = DockStyle.Top;
            panel_StdSubMenu.Location = new Point(0, 175);
            panel_StdSubMenu.Name = "panel_StdSubMenu";
            panel_StdSubMenu.Size = new Size(195, 151);
            panel_StdSubMenu.TabIndex = 1;
            // 
            // button_StdPrint
            // 
            button_StdPrint.Dock = DockStyle.Top;
            button_StdPrint.FlatAppearance.BorderSize = 0;
            button_StdPrint.FlatStyle = FlatStyle.Flat;
            button_StdPrint.ForeColor = Color.White;
            button_StdPrint.Location = new Point(0, 100);
            button_StdPrint.Name = "button_StdPrint";
            button_StdPrint.Padding = new Padding(35, 0, 0, 0);
            button_StdPrint.Size = new Size(195, 50);
            button_StdPrint.TabIndex = 3;
            button_StdPrint.Text = "Print";
            button_StdPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_StdPrint.UseVisualStyleBackColor = true;
            button_StdPrint.Click += button_StdPrint_Click;
            // 
            // button_ManageStudent
            // 
            button_ManageStudent.Dock = DockStyle.Top;
            button_ManageStudent.FlatAppearance.BorderSize = 0;
            button_ManageStudent.FlatStyle = FlatStyle.Flat;
            button_ManageStudent.ForeColor = Color.White;
            button_ManageStudent.Location = new Point(0, 50);
            button_ManageStudent.Name = "button_ManageStudent";
            button_ManageStudent.Padding = new Padding(35, 0, 0, 0);
            button_ManageStudent.Size = new Size(195, 50);
            button_ManageStudent.TabIndex = 1;
            button_ManageStudent.Text = "Manage Student";
            button_ManageStudent.TextAlign = ContentAlignment.MiddleLeft;
            button_ManageStudent.UseVisualStyleBackColor = true;
            button_ManageStudent.Click += button_ManageStudent_Click;
            // 
            // button_Registration
            // 
            button_Registration.Dock = DockStyle.Top;
            button_Registration.FlatAppearance.BorderSize = 0;
            button_Registration.FlatStyle = FlatStyle.Flat;
            button_Registration.ForeColor = Color.White;
            button_Registration.Location = new Point(0, 0);
            button_Registration.Name = "button_Registration";
            button_Registration.Padding = new Padding(35, 0, 0, 0);
            button_Registration.Size = new Size(195, 50);
            button_Registration.TabIndex = 0;
            button_Registration.Text = "Registration";
            button_Registration.TextAlign = ContentAlignment.MiddleLeft;
            button_Registration.UseVisualStyleBackColor = true;
            button_Registration.Click += button_Registration_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 133);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(195, 42);
            button_std.TabIndex = 0;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label1);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(195, 133);
            panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 99);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 0;
            label3.Text = "Modern School";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 21);
            label2.Name = "label2";
            label2.Size = new Size(59, 46);
            label2.TabIndex = 0;
            label2.Text = "M";
            // 
            // panel_Main
            // 
            panel_Main.Controls.Add(panel_cover);
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.Location = new Point(216, 0);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(916, 603);
            panel_Main.TabIndex = 3;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(916, 603);
            panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.study2;
            pictureBox2.Location = new Point(0, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(916, 367);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label_femalestd);
            panel3.Controls.Add(label_malestd);
            panel3.Controls.Add(label_totalstd);
            panel3.Location = new Point(0, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(916, 103);
            panel3.TabIndex = 2;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(464, 31);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 7;
            label11.Text = "Select Class :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(737, 66);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 6;
            label9.Text = "Female :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(617, 66);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 5;
            label10.Text = "Male :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(608, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 4;
            // 
            // label_femalestd
            // 
            label_femalestd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_femalestd.AutoSize = true;
            label_femalestd.Font = new Font("Segoe UI", 12F);
            label_femalestd.ForeColor = Color.White;
            label_femalestd.Location = new Point(148, 54);
            label_femalestd.Name = "label_femalestd";
            label_femalestd.Size = new Size(83, 28);
            label_femalestd.TabIndex = 3;
            label_femalestd.Text = "Female :";
            // 
            // label_malestd
            // 
            label_malestd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_malestd.AutoSize = true;
            label_malestd.Font = new Font("Segoe UI", 12F);
            label_malestd.ForeColor = Color.White;
            label_malestd.Location = new Point(28, 54);
            label_malestd.Name = "label_malestd";
            label_malestd.Size = new Size(64, 28);
            label_malestd.TabIndex = 2;
            label_malestd.Text = "Male :";
            // 
            // label_totalstd
            // 
            label_totalstd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalstd.AutoSize = true;
            label_totalstd.Font = new Font("Segoe UI", 12F);
            label_totalstd.ForeColor = Color.White;
            label_totalstd.Location = new Point(24, 13);
            label_totalstd.Name = "label_totalstd";
            label_totalstd.Size = new Size(136, 28);
            label_totalstd.TabIndex = 1;
            label_totalstd.Text = "Total Student :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label_Role);
            panel2.Controls.Add(label_User);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 72);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.graduateIcon;
            pictureBox1.Location = new Point(825, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 30);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 0;
            label5.Text = "Role :";
            // 
            // label_Role
            // 
            label_Role.AutoSize = true;
            label_Role.Font = new Font("Segoe UI", 12F);
            label_Role.ForeColor = Color.White;
            label_Role.Location = new Point(128, 29);
            label_Role.Name = "label_Role";
            label_Role.Size = new Size(70, 28);
            label_Role.TabIndex = 0;
            label_Role.Text = "Admin";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Font = new Font("Segoe UI", 12F);
            label_User.ForeColor = Color.White;
            label_User.Location = new Point(128, 3);
            label_User.Name = "label_User";
            label_User.Size = new Size(82, 28);
            label_User.TabIndex = 0;
            label_User.Text = "Modern";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 5);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 0;
            label4.Text = "Welcome :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 61);
            panel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 71, 200);
            label12.Location = new Point(0, 20);
            label12.Name = "label12";
            label12.Size = new Size(157, 23);
            label12.TabIndex = 0;
            label12.Text = "Modern School";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 603);
            Controls.Add(panel_Main);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_ScoreSubMenu.ResumeLayout(false);
            panel_CourseSubMenu.ResumeLayout(false);
            panel_StdSubMenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_Main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_StdSubMenu;
        private Button button_StdPrint;
        private Button button_ManageStudent;
        private Button button_Registration;
        private Button button_Course;
        private Button button_Dashboard;
        private Panel panel_ScoreSubMenu;
        private Button button_ScorePrint;
        private Button button_ManageScore;
        private Button button_NewScore;
        private Button button_Score;
        private Panel panel_CourseSubMenu;
        private Button button_CoursePrint;
        private Button button_ManageCourse;
        private Button button_NewCourse;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel_Main;
        private Panel panel_cover;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label label_User;
        private Label label_Role;
        private Label label_femalestd;
        private Label label_malestd;
        private Label label_totalstd;
        private ComboBox comboBox1;
        private Label label11;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label12;
        private Button button_Exit;
    }
}
