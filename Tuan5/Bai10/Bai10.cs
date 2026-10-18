namespace Bai10
{
    public partial class Form1 : Form
    {
        private int tongsogiay = 30 * 60;
        public Form1()
        {
            InitializeComponent();
            btnBatDau.Click += btnBatDau_Click;
            timer1.Tick += timer1_Tick;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick (object sender, EventArgs e)
        {

            if(tongsogiay>0)
            {
                tongsogiay--;
                int phut = tongsogiay / 60;
                int giay = tongsogiay % 60;
                lblThoiGian.Text = phut.ToString("00") + ":" + giay.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("thông báo: đã hết thời gian");
            }

        }
    }
}
