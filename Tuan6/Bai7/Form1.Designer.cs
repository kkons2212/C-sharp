namespace Bai7
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
            buttonHienThi = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // buttonHienThi
            // 
            buttonHienThi.Location = new Point(55, 47);
            buttonHienThi.Name = "buttonHienThi";
            buttonHienThi.Size = new Size(94, 37);
            buttonHienThi.TabIndex = 0;
            buttonHienThi.Text = "Hiển Thị";
            buttonHienThi.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(55, 112);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 289);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã Lớp";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên Lớp";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã Khoa";
            columnHeader4.Width = 100;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(612, 432);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(111, 60);
            buttonThoat.TabIndex = 2;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 504);
            Controls.Add(buttonThoat);
            Controls.Add(listView1);
            Controls.Add(buttonHienThi);
            Name = "Form1";
            Text = "Danh Sách Lớp";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHienThi;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonThoat;
    }
}
