namespace ConvolutionalCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void connect_Regs_Click(object sender, EventArgs e)
        {

        }

        private void encode_Click(object sender, EventArgs e)
        {

        }

        private void decode_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter valid number");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Focus();
                textBox2.SelectionStart = textBox2.Text.Length;
            }
            else
            {


                listBox1.Items.Clear();
                try
                {
                    for (int i = 1; i <= Convert.ToInt16(textBox2.Text); i++)
                    {

                        listBox1.Items.Add(i);
                    }
                }
                catch
                {
                }
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.textBox2.SelectAll();
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            this.textBox3.SelectAll();
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip Connected = new ToolTip();
            Connected.SetToolTip(textBox3, "Enter connected registers with space separator");
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();

        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            this.richTextBox2.SelectAll();

        }

        private void richTextBox3_Enter(object sender, EventArgs e)
        {
            this.richTextBox3.SelectAll();
        }

        private void richTextBox4_Enter(object sender, EventArgs e)
        {
            this.richTextBox4.SelectAll();
        }

    }
}