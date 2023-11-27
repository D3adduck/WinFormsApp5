namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click1(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            label1.Text = word.ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToLower();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("hello and welcome!\n\n       continue?", "welcome home",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);
            if (yesno == DialogResult.No) { Close(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult yesno = MessageBox.Show("its not over , its never over\n\n            leave?", "dont go",
            MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);
            if (yesno == DialogResult.No) { e.Cancel = true; }//dialog result will read the users input from messageboxbuttons
        }//the e in e .cancel is and event so e.cancel cancels said event which in this case is the form closing

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}