using MaterialSkin.Controls;

namespace track_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Height = trackBar1.Value;
            pictureBox1.Width = trackBar1.Value;
            displaylabel.Text = trackBar1.Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaylabel.Text = trackBar1.Value.ToString();
        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {
          
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            pictureBox1.Height = materialSlider1.Value;
            pictureBox1.Width = materialSlider1.Value;
        }
    }
}