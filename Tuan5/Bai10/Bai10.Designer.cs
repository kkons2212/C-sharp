namespace Bai10
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
            components = new System.ComponentModel.Container();
            lblThoiGian = new Label();
            btnBatDau = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblThoiGian.Location = new Point(333, 53);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(89, 38);
            lblThoiGian.TabIndex = 0;
            lblThoiGian.Text = "30:00";
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(317, 130);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(126, 59);
            btnBatDau.TabIndex = 1;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
           
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatDau);
            Controls.Add(lblThoiGian);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThoiGian;
        private Button btnBatDau;
        private System.Windows.Forms.Timer timer1;
    }
}
