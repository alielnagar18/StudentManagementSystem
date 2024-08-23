namespace StudentManagementSystem
{
    partial class PrintStudent
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
            panel2 = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            button_print = new Button();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            radioButton_all = new RadioButton();
            comboBox_class = new ComboBox();
            label1 = new Label();
            button_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(5, 544);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 8);
            panel2.TabIndex = 61;
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
            panel1.Size = new Size(932, 58);
            panel1.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(403, 9);
            label8.Name = "label8";
            label8.Size = new Size(110, 34);
            label8.TabIndex = 0;
            label8.Text = "To Print";
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(794, 558);
            button_print.Name = "button_print";
            button_print.Size = new Size(114, 35);
            button_print.TabIndex = 54;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(313, 566);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(103, 27);
            radioButton_female.TabIndex = 49;
            radioButton_female.Text = "FeMale";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(227, 566);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 48;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(51, 564);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 45;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(117, 560);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 44;
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
            DataGridView_student.Location = new Point(5, 105);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(903, 433);
            DataGridView_student.TabIndex = 42;
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
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.Checked = true;
            radioButton_all.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_all.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_all.Location = new Point(153, 566);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(56, 27);
            radioButton_all.TabIndex = 49;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            // 
            // comboBox_class
            // 
            comboBox_class.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_class.FormattingEnabled = true;
            comboBox_class.Location = new Point(602, 67);
            comboBox_class.Name = "comboBox_class";
            comboBox_class.Size = new Size(186, 28);
            comboBox_class.TabIndex = 64;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(448, 68);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 45;
            label1.Text = "Select Class :";
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(794, 64);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 35);
            button_search.TabIndex = 54;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(comboBox_class);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_search);
            Controls.Add(button_print);
            Controls.Add(radioButton_all);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DataGridView_student);
            Name = "PrintStudent";
            Text = "/";
            Load += PrintStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label label8;
        private Button button_print;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private RadioButton radioButton_all;
        private ComboBox comboBox_class;
        private Label label1;
        private Button button_search;
    }
}