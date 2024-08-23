namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void panel_slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        //create a function to display srudent count
        private void studentCount()
        {
            //display the values
            label_totalstd.Text = "Total Student :" + student.totalStudent();
            label_malestd.Text = "Male :" + student.maleStudent();
            label_femalestd.Text = "Female :" + student.femaleStudent();
        }

        private void CustomizeDesign()
        {
            panel_StdSubMenu.Visible = false;
            panel_CourseSubMenu.Visible = false;
            panel_ScoreSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_StdSubMenu.Visible)
                panel_StdSubMenu.Visible = false;
            if (panel_CourseSubMenu.Visible)
                panel_CourseSubMenu.Visible = false;
            if (panel_ScoreSubMenu.Visible)
                panel_ScoreSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_StdSubMenu);
        }

        #region StdSubMenu
        private void button_Registration_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }

        private void button_ManageStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageStudentForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }


        private void button_StdPrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintStudent());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }
        #endregion StdSubMenu
        private void button_Course_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_CourseSubMenu);
        }
        #region CourseSubMenu
        private void button_NewCourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CourseForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }

        private void button_ManageCourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageCourseForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }

        private void button_CoursePrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintCourseForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }
        #endregion CourseSubMenu
        private void button_Score_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_ScoreSubMenu);
        }
        #region ScoreSubMenu
        private void button_NewScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScoreForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }

        private void button_ManageScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageScoreForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }

        private void button_ScorePrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PrintScoreForm());
            // ....
            //.... Your Code
            //....
            HideSubMenu();
        }
        #endregion ScoreSubMenu


        //to show register from mainform
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_Main.Controls.Add(panel_cover);
            studentCount();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
