using picture_box2.Properties;

namespace picture_box2
{

    public partial class Form1 : Form
    {
        static bool isitheads = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isitheads)
            {

                pictureBox1.Image = Resources.Tails;
                isitheads = false;
            }
            else
            {
                pictureBox1.Image = Resources.Heads;
                isitheads = true;
            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }
    }
}