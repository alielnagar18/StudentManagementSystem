namespace StudentManagementSystem
{
    partial class RegisterForm
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
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox_phone = new TextBox();
            label7 = new Label();
            button_add = new Button();
            button_clear = new Button();
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
            textBox_Fname = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
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
            DataGridView_student.Location = new Point(2, 60);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(920, 257);
            DataGridView_student.TabIndex = 3;
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
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(405, 12);
            label8.Name = "label8";
            label8.Size = new Size(171, 34);
            label8.TabIndex = 0;
            label8.Text = "Registration";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_student);
            panel2.Controls.Add(textBox_address);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox_Lname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_Fname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 286);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 8);
            panel3.TabIndex = 34;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Bottom;
            textBox_phone.Location = new Point(653, 23);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(134, 32);
            textBox_phone.TabIndex = 33;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 71, 160);
            label7.Location = new Point(572, 26);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 32;
            label7.Text = "Phone :";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(802, 215);
            button_add.Name = "button_add";
            button_add.Size = new Size(114, 35);
            button_add.TabIndex = 31;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(682, 215);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(114, 35);
            button_clear.TabIndex = 30;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom;
            button_upload.BackColor = Color.Green;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(799, 147);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(114, 35);
            button_upload.TabIndex = 29;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(799, 23);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(114, 117);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 28;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Bottom;
            textBox_address.Location = new Point(173, 135);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(614, 47);
            textBox_address.TabIndex = 27;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(684, 81);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(103, 27);
            radioButton_female.TabIndex = 26;
            radioButton_female.Text = "FeMale";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(606, 81);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 25;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom;
            dateTimePicker1.Location = new Point(152, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(345, 32);
            dateTimePicker1.TabIndex = 24;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Anchor = AnchorStyles.Bottom;
            textBox_Lname.Location = new Point(412, 23);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(151, 32);
            textBox_Lname.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(504, 81);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 22;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(570, 62);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(286, 26);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 20;
            label2.Text = "Last Name :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Anchor = AnchorStyles.Bottom;
            textBox_Fname.Location = new Point(137, 20);
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
            label6.Location = new Point(54, 135);
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
            label3.Location = new Point(10, 81);
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
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 16;
            label1.Text = "First Name :";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox_phone;
        private Label label7;
        private Button button_add;
        private Button button_clear;
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
        private TextBox textBox_Fname;
        private Label label6;
        private Label label3;
        private Label label1;
    }
}