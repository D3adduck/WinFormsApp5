namespace Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topleftLabel_Click(object sender, EventArgs e)
        {
            if (topleftLabel.Text == "")
            {
                topleftLabel.Text = "top left";
            }
            else
            {
                topleftLabel.Text = "";
            }


        }

        private void topcenterLabel_Click(object sender, EventArgs e)
        {


            if (topcenterLabel.Text == "")
            {
                topcenterLabel.Text = "top center";
            }
            else
            {
                topcenterLabel.Text = "";
            }
        }

        private void topightLabel_Click(object sender, EventArgs e)
        {

            if (toprightLabel.Text == "")
            {
                topcenterLabel.Text = "top right";
            }
            else
            {
                toprightLabel.Text = "";
            }
        }

        private void middelleftLabel_Click(object sender, EventArgs e)
        {

            if (middelleftLabel.Text == "")
            {
                middelleftLabel.Text = "middel left";
            }
            else
            {
                middelleftLabel.Text = "";
            }
        }

        private void middelcenterLabel_Click(object sender, EventArgs e)
        {


            if (middelcenterLabel.Text == "")
            {
                middelcenterLabel.Text = "center ";
            }
            else
            {
                middelcenterLabel.Text = "";
            }
        }

        private void middelrightLabel_Click(object sender, EventArgs e)
        {
            middelrightLabel.Text = "middel right";
            if (middelrightLabel.Text == "")
            {
                middelrightLabel.Text = "middel right ";
            }
            else
            {
                middelrightLabel.Text = "";
            }
        }

        private void downleftLabel_Click(object sender, EventArgs e)
        {

            downleftLabel.Text = "bottom left";
            if (downleftLabel.Text == "")
            {
                downleftLabel.Text = "bottom left ";
            }
            else
            {
                downleftLabel.Text = "";
            }
        }

        private void middelbottomLabel_Click(object sender, EventArgs e)
        {

            middelbottomLabel.Text = "bottom middel";
            if (middelbottomLabel.Text == "")
            {
                middelbottomLabel.Text = "bottom middel ";
            }
            else
            {
                middelbottomLabel.Text = "";
            }
        }

        private void lowerrightLabel_Click(object sender, EventArgs e)
        {

            lowerrightLabel.Text = "bottom right";
            if (lowerrightLabel.Text == "")
            {
                lowerrightLabel.Text = "bottom right ";
            }
            else
            {
                lowerrightLabel.Text = "";
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}