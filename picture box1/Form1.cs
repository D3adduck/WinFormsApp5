namespace picture_box1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (speechbox.Visible)
            {

                speechbox.Visible = false;
            }
            else
            {

                speechbox.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}