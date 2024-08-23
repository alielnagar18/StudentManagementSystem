namespace StudentManagementSystem
{
    partial class ManageScoreForm
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
            textBox_search = new TextBox();
            button_clear = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_search = new Button();
            label8 = new Label();
            panel2 = new Panel();
            comboBox_Course = new ComboBox();
            textBox_description = new TextBox();
            textBox_score = new TextBox();
            label2 = new Label();
            textBox_stdId = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            DataGridView_score = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(633, 60);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(166, 32);
            textBox_search.TabIndex = 43;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(565, 189);
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
            button_update.Location = new Point(685, 189);
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
            button_delete.Location = new Point(805, 189);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 35);
            button_delete.TabIndex = 36;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
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
            button_search.TabIndex = 44;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(366, 12);
            label8.Name = "label8";
            label8.Size = new Size(215, 34);
            label8.TabIndex = 0;
            label8.Text = "Mangae Score";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_Course);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(textBox_score);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_stdId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 240);
            panel2.TabIndex = 42;
            // 
            // comboBox_Course
            // 
            comboBox_Course.FormattingEnabled = true;
            comboBox_Course.Location = new Point(182, 55);
            comboBox_Course.Name = "comboBox_Course";
            comboBox_Course.Size = new Size(358, 31);
            comboBox_Course.TabIndex = 46;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(182, 133);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(358, 89);
            textBox_description.TabIndex = 45;
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(182, 92);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(152, 32);
            textBox_score.TabIndex = 44;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(86, 101);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 43;
            label2.Text = "Score :";
            // 
            // textBox_stdId
            // 
            textBox_stdId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_stdId.Location = new Point(182, 13);
            textBox_stdId.Name = "textBox_stdId";
            textBox_stdId.Size = new Size(152, 32);
            textBox_stdId.TabIndex = 42;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(32, 133);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 41;
            label6.Text = "Description :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 39;
            label3.Text = "Select Course :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(43, 16);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 40;
            label1.Text = "Student ID :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(3, -3);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 10);
            panel3.TabIndex = 34;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(1329, -90);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 21;
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
            panel1.TabIndex = 41;
            // 
            // DataGridView_score
            // 
            DataGridView_score.AllowUserToAddRows = false;
            DataGridView_score.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_score.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_score.ColumnHeadersHeight = 24;
            DataGridView_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_score.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_score.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.Location = new Point(3, 98);
            DataGridView_score.Name = "DataGridView_score";
            DataGridView_score.RowHeadersVisible = false;
            DataGridView_score.RowHeadersWidth = 51;
            DataGridView_score.RowTemplate.Height = 80;
            DataGridView_score.Size = new Size(920, 259);
            DataGridView_score.TabIndex = 40;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_score.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_score.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_score.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_score.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_score.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_score.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_score.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_score.ThemeStyle.ReadOnly = false;
            DataGridView_score.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_score.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_score.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_score.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_score.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_score.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_score.Click += DataGridView_score_Click;
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_score);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageScoreForm";
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Button button_clear;
        private Button button_update;
        private Button button_delete;
        private Button button_search;
        private Label label8;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_score;
        private ComboBox comboBox_Course;
        private TextBox textBox_description;
        private TextBox textBox_score;
        private Label label2;
        private TextBox textBox_stdId;
        private Label label6;
        private Label label3;
        private Label label1;
    }
}