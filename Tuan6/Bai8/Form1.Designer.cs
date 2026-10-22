namespace Bai8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxMH = new ComboBox();
            buttonLoc = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            textTongDiem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn Học";
            // 
            // comboBoxMH
            // 
            comboBoxMH.FormattingEnabled = true;
            comboBoxMH.Location = new Point(136, 36);
            comboBoxMH.Name = "comboBoxMH";
            comboBoxMH.Size = new Size(262, 28);
            comboBoxMH.TabIndex = 1;
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(547, 30);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(116, 38);
            buttonLoc.TabIndex = 2;
            buttonLoc.Text = "Lọc Dữ Liệu";
            buttonLoc.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(52, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 283);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên SV";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Sinh";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên Môn Học";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 455);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Tổng Điểm";
            // 
            // textTongDiem
            // 
            textTongDiem.Location = new Point(526, 448);
            textTongDiem.Name = "textTongDiem";
            textTongDiem.Size = new Size(125, 27);
            textTongDiem.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(textTongDiem);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(buttonLoc);
            Controls.Add(comboBoxMH);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Danh Sách Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxMH;
        private Button buttonLoc;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private TextBox textTongDiem;
    }
}
