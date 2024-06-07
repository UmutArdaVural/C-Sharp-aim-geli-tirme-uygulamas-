using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace aim_geliştirme_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int süre = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label4.Text = Convert.ToString(süre);
        }
        int doğrutıklama;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

            doğrutıklama++;
            if (doğrutıklama == 1)
            {
                
            }
            else if (doğrutıklama>1)
            {
                
                doğrutıklama--;
                label2.Text = doğrutıklama.ToString();
                doğrutıklama++;
            }
            Random random = new Random();
            int nokta_X;
            nokta_X = random.Next(50, 700);
            pictureBox1.Location = new Point(nokta_X, pictureBox1.Location.Y);
            int nokta_Y;
            nokta_Y = random.Next(70, 400);
            pictureBox1.Location = new Point(pictureBox1.Location.X, nokta_Y);

        }
        int hatalıtıklama;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            hatalıtıklama++;
            label6.Text = hatalıtıklama.ToString();
            if (hatalıtıklama == 3)
            {
                timer1.Stop();
                if (doğrutıklama == 0)
                {

                }
                else
                {
                    doğrutıklama--;
                }
                MessageBox.Show($"Kaybettiniz , Skoronuz {doğrutıklama}");
                
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
