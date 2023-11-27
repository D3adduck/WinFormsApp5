using System.Runtime.Intrinsics.X86;

namespace flag_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "finland";

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "france";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "germany";
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}