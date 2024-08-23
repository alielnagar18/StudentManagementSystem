namespace StudentManagementSystem
{
    partial class ManageStudentForm
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
            textBox_phone = new TextBox();
            label7 = new Label();
            button_delete = new Button();
            button_update = new Button();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            textBox_address = new TextBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox_Lname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_Fname = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            button_clear = new Button();
            button_search = new Button();
            textBox_search = new TextBox();
            label9 = new Label();
            textBox_id = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(2, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 8);
            panel2.TabIndex = 36;
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
            panel1.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(329, 9);
            label8.Name = "label8";
            label8.Size = new Size(238, 34);
            label8.TabIndex = 0;
            label8.Text = "Manage Student";
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Bottom;
            textBox_phone.Location = new Point(645, 372);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(134, 32);
            textBox_phone.TabIndex = 34;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 71, 160);
            label7.Location = new Point(564, 375);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 33;
            label7.Text = "Phone :";
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(785, 547);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 35);
            button_delete.TabIndex = 32;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(665, 547);
            button_update.Name = "button_update";
            button_update.Size = new Size(114, 35);
            button_update.TabIndex = 31;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom;
            button_upload.BackColor = Color.Green;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(782, 490);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(114, 35);
            button_upload.TabIndex = 30;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(782, 372);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(114, 112);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 29;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Bottom;
            textBox_address.Location = new Point(155, 478);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(420, 55);
            textBox_address.TabIndex = 28;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(675, 424);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(103, 27);
            radioButton_female.TabIndex = 27;
            radioButton_female.Text = "FeMale";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom;
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(597, 424);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 26;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom;
            dateTimePicker1.Location = new Point(143, 423);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(345, 32);
            dateTimePicker1.TabIndex = 25;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Anchor = AnchorStyles.Bottom;
            textBox_Lname.Location = new Point(404, 372);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(151, 32);
            textBox_Lname.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(495, 424);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 23;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(561, 420);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(278, 375);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 21;
            label2.Text = "Last Name :";
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
            DataGridView_student.Location = new Point(2, 110);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(920, 243);
            DataGridView_student.TabIndex = 20;
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
            // textBox_Fname
            // 
            textBox_Fname.Anchor = AnchorStyles.Bottom;
            textBox_Fname.Location = new Point(129, 369);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(140, 32);
            textBox_Fname.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(45, 478);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            label6.Text = "Address :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(1, 424);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 18;
            label3.Text = "Date Of Birth :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(1, 372);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 16;
            label1.Text = "First Name :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(545, 547);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(114, 35);
            button_clear.TabIndex = 37;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(795, 64);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 35);
            button_search.TabIndex = 37;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(620, 64);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(166, 32);
            textBox_search.TabIndex = 34;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 71, 160);
            label9.Location = new Point(584, 496);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 33;
            label9.Text = "ID no :";
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.Bottom;
            textBox_id.Location = new Point(665, 493);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(99, 32);
            textBox_id.TabIndex = 34;
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox_search);
            Controls.Add(textBox_id);
            Controls.Add(label9);
            Controls.Add(textBox_phone);
            Controls.Add(label7);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_student);
            Controls.Add(textBox_address);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_Lname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(DataGridView_student);
            Controls.Add(textBox_Fname);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label8;
        private TextBox textBox_phone;
        private Label label7;
        private Button button_delete;
        private Button button_update;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private TextBox textBox_address;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_Lname;
        private Label label5;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private TextBox textBox_Fname;
        private Label label6;
        private Label label3;
        private Label label1;
        private Button button_clear;
        private Button button_search;
        private TextBox textBox_search;
        private Label label9;
        private TextBox textBox_id;
    }
}