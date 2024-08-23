using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comboBox wuth courses name
            comboBox_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_Course.DisplayMember = "CourseName";
            comboBox_Course.ValueMember = "CourseName";
            //to show data on score dataGridView
            showScoreData();

            //to display the student list on DataGridView
            DataGridView_student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_score.Text == "" || textBox_description.Text == "")
            {

                MessageBox.Show("Please insert the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_stdId.Text);
                string cName = comboBox_Course.Text;
                double scor = Convert.ToDouble(textBox_score.Text);
                string desc = textBox_description.Text;
                if (!score.checkScore(stdId, cName))
                {
                    if (score.insertScore(stdId, cName, scor, desc))
                    {
                        button_clear.PerformClick();
                        showScoreData();
                        MessageBox.Show("New score added", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Score not added", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("the score for this course are already exists", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //create a function to show data on dataGridView
        private void showScoreData()
        {
            DataGridView_student.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdId"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_score.Clear();
            textBox_description.Clear();
            comboBox_Course.SelectedIndex = 0;
        }

        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_stdId.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_sStudent_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));
        }

        private void button_sScore_Click(object sender, EventArgs e)
        {
            showScoreData();
        }
    }
}
