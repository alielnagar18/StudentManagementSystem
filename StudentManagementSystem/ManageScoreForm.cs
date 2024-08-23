using Microsoft.VisualBasic.Devices;
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
    public partial class ManageScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        CourseClass course = new CourseClass();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comboBox wuth courses name
            comboBox_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_Course.DisplayMember = "CourseName";
            comboBox_Course.ValueMember = "CourseName";
            showScoreData();
        }
        private void showScoreData()
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdId"));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_score.Text == "")
            {

                MessageBox.Show("Please insert the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_stdId.Text);
                double scor = Convert.ToDouble(textBox_score.Text);
                string desc = textBox_description.Text;

                if (score.updateScore(stdId, scor, desc))
                {
                    button_clear.PerformClick();
                    showScoreData();
                    MessageBox.Show("score updated", "update score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Score not updated", "Add update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text.Equals(""))
            {

                MessageBox.Show("Need the Student ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_stdId.Text);
                    if (score.deleteScore(id))
                    {
                        button_clear.PerformClick();
                        showScoreData();
                        MessageBox.Show("score deleted", "Removed score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed score", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_score.Clear();
            textBox_description.Clear();
            comboBox_Course.SelectedIndex = 0;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //to search course and show on datagridview
            DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdId WHERE CONCAT(student.StdFirstName,student.StdLastName, Score.CourseName) LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }
        
        private void DataGridView_score_Click(object sender, EventArgs e)
        {
            textBox_stdId.Text = DataGridView_score.CurrentRow.Cells[0].Value.ToString();
            comboBox_Course.Text = DataGridView_score.CurrentRow.Cells[3].Value.ToString();
            textBox_score.Text = DataGridView_score.CurrentRow.Cells[4].Value.ToString();
            textBox_description.Text = DataGridView_score.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
