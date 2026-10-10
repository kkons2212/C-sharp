namespace Bai6
{
    partial class Bai6
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
            panel1 = new Panel();
            trvDanhBa = new TreeView();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(trvDanhBa);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 451);
            panel1.TabIndex = 0;
            // 
            // trvDanhBa
            // 
            trvDanhBa.Location = new Point(0, 0);
            trvDanhBa.Name = "trvDanhBa";
            trvDanhBa.Size = new Size(284, 451);
            trvDanhBa.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(311, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 215);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(167, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(167, 107);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(207, 27);
            txtLastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(358, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(669, 286);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 51);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Bai6";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TreeView trvDanhBa;
        private Panel panel2;
        private Button btnAdd;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
        private Button btnExit;
    }
}
