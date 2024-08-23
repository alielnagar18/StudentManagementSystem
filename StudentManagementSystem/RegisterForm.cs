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

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        //create function to verify
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

        //To show student list in DataGridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.GetStudentList(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //add new student
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

                    if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New student Added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //browse photo from computer
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(ofd.FileName);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }
    }
}
