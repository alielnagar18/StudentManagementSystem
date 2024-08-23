namespace StudentManagementSystem
{
    partial class ScoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            textBox_description = new TextBox();
            textBox_score = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox_stdId = new TextBox();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            comboBox_Course = new ComboBox();
            button_clear = new Button();
            button_add = new Button();
            label3 = new Label();
            panel1 = new Panel();
            button_sScore = new Button();
            button_sStudent = new Button();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(2, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(921, 10);
            panel3.TabIndex = 34;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(183, 150);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(475, 89);
            textBox_description.TabIndex = 27;
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(183, 109);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(152, 32);
            textBox_score.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(963, -9);
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
            label2.Location = new Point(87, 118);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 20;
            label2.Text = "Score :";
            // 
            // textBox_stdId
            // 
            textBox_stdId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_stdId.Location = new Point(183, 30);
            textBox_stdId.Name = "textBox_stdId";
            textBox_stdId.Size = new Size(152, 32);
            textBox_stdId.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(33, 150);
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
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 16;
            label1.Text = "Student ID :";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_Course);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(textBox_score);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_stdId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 266);
            panel2.TabIndex = 21;
            // 
            // comboBox_Course
            // 
            comboBox_Course.FormattingEnabled = true;
            comboBox_Course.Location = new Point(183, 72);
            comboBox_Course.Name = "comboBox_Course";
            comboBox_Course.Size = new Size(475, 31);
            comboBox_Course.TabIndex = 38;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(686, 209);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(114, 35);
            button_clear.TabIndex = 37;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(806, 209);
            button_add.Name = "button_add";
            button_add.Size = new Size(114, 35);
            button_add.TabIndex = 36;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(7, 80);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 16;
            label3.Text = "Select Course :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(button_sScore);
            panel1.Controls.Add(button_sStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 54);
            panel1.TabIndex = 20;
            // 
            // button_sScore
            // 
            button_sScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_sScore.BackColor = Color.White;
            button_sScore.FlatStyle = FlatStyle.Flat;
            button_sScore.ForeColor = Color.FromArgb(0, 71, 160);
            button_sScore.Location = new Point(768, 8);
            button_sScore.Name = "button_sScore";
            button_sScore.Size = new Size(152, 39);
            button_sScore.TabIndex = 0;
            button_sScore.Text = "Show Score";
            button_sScore.UseVisualStyleBackColor = false;
            button_sScore.Click += button_sScore_Click;
            // 
            // button_sStudent
            // 
            button_sStudent.BackColor = Color.White;
            button_sStudent.FlatStyle = FlatStyle.Flat;
            button_sStudent.ForeColor = Color.FromArgb(0, 71, 160);
            button_sStudent.Location = new Point(12, 8);
            button_sStudent.Name = "button_sStudent";
            button_sStudent.Size = new Size(152, 39);
            button_sStudent.TabIndex = 0;
            button_sStudent.Text = "Show Student";
            button_sStudent.UseVisualStyleBackColor = false;
            button_sStudent.Click += button_sStudent_Click;
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_student.ColumnHeadersHeight = 24;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(0, 58);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(923, 278);
            DataGridView_student.TabIndex = 19;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_student.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_student.ThemeStyle.ReadOnly = false;
            DataGridView_student.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_student.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_student.Click += DataGridView_student_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox textBox_description;
        private TextBox textBox_score;
        private Label label4;
        private Label label2;
        private TextBox textBox_stdId;
        private Label label6;
        private Label label1;
        private Panel panel2;
        private Button button_clear;
        private Button button_add;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private ComboBox comboBox_Course;
        private Label label3;
        private Button button_sScore;
        private Button button_sStudent;
    }
}