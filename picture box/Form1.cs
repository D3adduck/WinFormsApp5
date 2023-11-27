namespace picture_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void middelcenterLabel_Click(object sender, EventArgs e)
        {
            if (middelcenterlabel.Text == "")
            {
                middelcenterlabel.Text = "center ";
            }
            else
            {
                middelcenterlabel.Text = "";
            }
        }
    }
}