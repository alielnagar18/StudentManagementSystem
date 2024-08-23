namespace StudentManagementSystem
{
    partial class ManageCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel3 = new Panel();
            textBox_description = new TextBox();
            textBox_Chour = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox_Cname = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            button_clear = new Button();
            button_update = new Button();
            button_delete = new Button();
            textBox_id = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            button_search = new Button();
            textBox_search = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(919, 10);
            panel3.TabIndex = 34;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(37, 155);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(475, 70);
            textBox_description.TabIndex = 27;
            // 
            // textBox_Chour
            // 
            textBox_Chour.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Chour.Location = new Point(35, 99);
            textBox_Chour.Name = "textBox_Chour";
            textBox_Chour.Size = new Size(187, 32);
            textBox_Chour.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(963, -21);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 20;
            label2.Text = "Hour :";
            // 
            // textBox_Cname
            // 
            textBox_Cname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Cname.Location = new Point(37, 39);
            textBox_Cname.Name = "textBox_Cname";
            textBox_Cname.Size = new Size(475, 32);
            textBox_Cname.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(37, 133);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 17;
            label6.Text = "Description :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 16;
            label1.Text = "Course Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(366, 12);
            label8.Name = "label8";
            label8.Size = new Size(233, 34);
            label8.TabIndex = 0;
            label8.Text = "Mangae Course";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(textBox_Chour);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(textBox_Cname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 240);
            panel2.TabIndex = 21;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(548, 190);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(114, 35);
            button_clear.TabIndex = 37;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(668, 190);
            button_update.Name = "button_update";
            button_update.Size = new Size(114, 35);
            button_update.TabIndex = 37;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(788, 190);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 35);
            button_delete.TabIndex = 36;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_id.Location = new Point(328, 99);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(184, 32);
            textBox_id.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(326, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 16;
            label3.Text = "Course ID :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 54);
            panel1.TabIndex = 20;
            // 
            // DataGridView_course
            // 
            DataGridView_course.AllowUserToAddRows = false;
            DataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_course.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_course.ColumnHeadersHeight = 24;
            DataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView_course.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.Location = new Point(3, 98);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowHeadersWidth = 51;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(920, 259);
            DataGridView_course.TabIndex = 19;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_course.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_course.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_course.ThemeStyle.ReadOnly = false;
            DataGridView_course.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_course.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.Click += DataGridView_course_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(808, 60);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 35);
            button_search.TabIndex = 39;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(633, 60);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(166, 32);
            textBox_search.TabIndex = 38;
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_course);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox textBox_description;
        private TextBox textBox_Chour;
        private Label label4;
        private Label label2;
        private TextBox textBox_Cname;
        private Label label6;
        private Label label1;
        private Label label8;
        private Panel panel2;
        private Button button_update;
        private Button button_delete;
        private TextBox textBox_id;
        private Label label3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
        private Button button_clear;
        private Button button_search;
        private TextBox textBox_search;
    }
}