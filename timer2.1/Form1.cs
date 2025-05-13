namespace timer2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Timer Ayarlarý
            timer1.Interval = 1000;
            timer1.Start();

            //MaskedTextBox & TextBox Ayarlari
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox2.Enabled = false;
            maskedTextBox2.Mask = "00/00/0000";
            textBox1.Enabled = false;

            //Baþlangýç Deðerleri
            currentDate = DateTime.Now;
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        int oclock = 0, min = 0 ,sec = 0;
        DateTime currentDate;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sistem gerçek zamaný
            DateTime now = DateTime.Now;
            textBox1.Text = now.ToString("HH:mm:ss");

            //Kullanýcý Zamaný
            sec++;
            label3.Text = sec.ToString();

            // Saniye, dakika ve saat hesaplamalarý
            if (sec == 59)
            {
                min++;
                label2.Text = min.ToString();
                sec = 0;

                if (min == 59)
                {
                    oclock = oclock + 1;
                    label1.Text = oclock.ToString();
                    min = 0;

                    if (oclock == 24)
                    {
                        currentDate = currentDate.AddDays(1);
                        maskedTextBox1.Text = currentDate.ToString("dd/MM/yyyy");
                        oclock = 0;
                    }
                }
            }
            // Gerçek zamaný MaskedTextBox'a yazdýrma
            maskedTextBox2.Text= now.ToString("dd/MM/yyyy");
        }
    }
}
