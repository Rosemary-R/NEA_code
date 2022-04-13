namespace Programmer_s_Best_Friend
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 py_to_c = new Form2();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 c_to_py = new Form3;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent()
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }


    }
}