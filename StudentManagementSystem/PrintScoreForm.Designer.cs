namespace StudentManagementSystem
{
    partial class PrintScoreForm
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
            textBox_search = new TextBox();
            button_search = new Button();
            button_print = new Button();
            DataGridView_score = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(5, 551);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 8);
            panel2.TabIndex = 81;
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
            panel1.TabIndex = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(338, 9);
            label8.Name = "label8";
            label8.Size = new Size(249, 34);
            label8.TabIndex = 0;
            label8.Text = "Student Score List";
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(622, 74);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(166, 32);
            textBox_search.TabIndex = 82;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(794, 71);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 35);
            button_search.TabIndex = 78;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(794, 565);
            button_print.Name = "button_print";
            button_print.Size = new Size(114, 35);
            button_print.TabIndex = 79;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
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
            DataGridView_score.Location = new Point(5, 112);
            DataGridView_score.Name = "DataGridView_score";
            DataGridView_score.RowHeadersVisible = false;
            DataGridView_score.RowHeadersWidth = 51;
            DataGridView_score.RowTemplate.Height = 80;
            DataGridView_score.Size = new Size(903, 433);
            DataGridView_score.TabIndex = 77;
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
            // 
            // PrintScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_print);
            Controls.Add(DataGridView_score);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PrintScoreForm";
            Text = "PrintScoreForm";
            Load += PrintScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label8;
        private TextBox textBox_search;
        private Button button_search;
        private Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_score;
    }
}