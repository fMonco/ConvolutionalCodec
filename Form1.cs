using System;
using System.Text;
namespace ConvolutionalCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            public static byte[] ConvertToByteArray(string str, Encoding encoding)
            {
                return encoding.GetBytes(str);
            }

            public static String ToBinary(Byte[] data)
            {
                return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
            }

           

        string[] adders;
        int i = 0;
        private void connect_Regs_Click(object sender, EventArgs e)
        {
            
            //string[] adders = new string[];

            int size = int.Parse(textBox2.Text);

            if (int.Parse(label1.Text) == size)
            {
                connect_Regs.Enabled = false;
                textBox3.Enabled = false;
            }
            if (adders == null || adders.Length != size)
            {
                adders = new string[size];
                i = 0;

            }
            if (i < adders.Length)
            {
                adders[i] = textBox3.Text;
                i++;
                label1.Text = i.ToString();
            }

            else
            {
                connect_Regs.Enabled = false;
                textBox3.Enabled = false;
            }

            richTextBox1.Lines = adders;
        }

        private void encode_Click(object sender, EventArgs e)
        {
            var binaryString = ToBinary(ConvertToByteArray(richTextBox1.Text, Encoding.ASCII));
            richTextBox2.Text = binaryString;
            

        }

        private void decode_Click(object sender, EventArgs e)
        {

        }



        public void textBox2_TextChanged(object sender, EventArgs e)
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
                //label1.Text = "0";
                connect_Regs.Enabled = true;
                textBox3.Enabled = true;

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