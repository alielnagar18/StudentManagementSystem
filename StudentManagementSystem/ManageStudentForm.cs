using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.Devices;

namespace StudentManagementSystem
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        //To show student list in DataGridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.GetStudentList(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        //display student data from student textbox
        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)DataGridView_student.CurrentRow.Cells[3].Value;
            if (DataGridView_student.CurrentRow.Cells[4].Value.ToString() == "Female")
                radioButton_female.Checked = true;
            else
                radioButton_male.Checked = true;

            textBox_phone.Text = DataGridView_student.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGridView_student.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(ms);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //browse photo from computer
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(ofd.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_student.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //update student record
            int id = Convert.ToInt32(textBox_id.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";


            //check if the student's age is between 10 and 100

            int bornYear = dateTimePicker1.Value.Year;
            int thisYear = DateTime.Now.Year;
            if ((thisYear - bornYear) < 10 || (thisYear - bornYear) > 100)
            {
                MessageBox.Show("The student age is must be between 10 and 100", "Invalid birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    //to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    Byte[] img = ms.ToArray();

                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show(" student data updated!", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {

                MessageBox.Show("Need the Course ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (student.deleteStudent(id))
                    {
                        button_clear.PerformClick();
                        showTable();
                        MessageBox.Show(" student deleted", "Removed student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
    }
}
