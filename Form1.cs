using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            FileReader fileReader = new FileReader(filePath);
            string list = fileReader.ReadFileContent();
            this.list.Add(list);
            textBox2.Text = list;
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }
    }
}
