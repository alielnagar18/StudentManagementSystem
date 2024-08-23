using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chour.Text == "" || textBox_description.Text == "")
            {

                MessageBox.Show("Please insert the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_Cname.Text;
                int hr = Convert.ToInt32(textBox_Chour.Text);
                string desc = textBox_description.Text;

                if (course.insertCourse(cName, hr, desc))
                {
                    button1.PerformClick();
                    showData();
                    MessageBox.Show("New course inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Course not insert", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Chour.Clear();
            textBox_Cname.Clear();
            textBox_description.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        //to show course list onm dataGridView
        private void showData()
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

       
    }
}
