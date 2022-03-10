namespace ConvolutionalCoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encode = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.connect_Regs = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(415, 7);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(75, 23);
            this.encode.TabIndex = 5;
            this.encode.Text = "Encode";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(212, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(52, 60);
            this.listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(212, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Enter number of adders";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(270, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 16);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Connected Registers";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.MouseHover += new System.EventHandler(this.textBox3_MouseHover);
            // 
            // connect_Regs
            // 
            this.connect_Regs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connect_Regs.Location = new System.Drawing.Point(270, 83);
            this.connect_Regs.Name = "connect_Regs";
            this.connect_Regs.Size = new System.Drawing.Size(75, 23);
            this.connect_Regs.TabIndex = 4;
            this.connect_Regs.Text = "Apply";
            this.connect_Regs.UseVisualStyleBackColor = true;
            this.connect_Regs.Click += new System.EventHandler(this.connect_Regs_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Enter message to encode";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(351, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(194, 67);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "Encoded Message";
            this.richTextBox2.Enter += new System.EventHandler(this.richTextBox2_Enter);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(12, 128);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(194, 96);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "Enter text to decode";
            this.richTextBox3.Enter += new System.EventHandler(this.richTextBox3_Enter);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(351, 128);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(194, 96);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "Decoded message";
            this.richTextBox4.Enter += new System.EventHandler(this.richTextBox4_Enter);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(241, 164);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(75, 23);
            this.decode.TabIndex = 8;
            this.decode.Text = "Decode";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 230);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.connect_Regs);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.encode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convolutional Codec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button encode;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button connect_Regs;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Button decode;
    }
}