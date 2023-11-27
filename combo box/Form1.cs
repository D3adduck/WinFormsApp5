namespace combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string value = comboBox1.Text;
            MessageBox.Show(value);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {



        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            materialComboBox1.Text = "selected index";
            materialComboBox1.Text += materialComboBox1.SelectedIndex;

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            MessageBox.Show(value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {



        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(materialMaskedTextBox1.Text);

            if (delete = 0 || delete > carbox.Items.Count-1)
            {



            }
            else
            {

          


            }





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}