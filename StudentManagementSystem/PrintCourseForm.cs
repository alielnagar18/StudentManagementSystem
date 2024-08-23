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
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintCourseForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //to search course and show on datagridview
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`) LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //we need a DGVprinter helper for print pdf file
            printer.Title = "Modern Course List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Modern";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_course);

        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }
    }
}
