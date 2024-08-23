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
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinter printer = new DGVPrinter();

        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //to search course and show on datagridview
            DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdId WHERE CONCAT(student.StdFirstName,student.StdLastName, Score.CourseName) LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //we need a DGVprinter helper for print pdf file
            printer.Title = "Modern Student Score List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Modern";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_score);
        }

        

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScoreData();
        }
        
        private void showScoreData()
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdId"));
        }
    }
}
