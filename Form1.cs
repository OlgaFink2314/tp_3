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
            chart1.ChartAreas[0].AxisX.Minimum = 2008; //Задаешь максимальные значения координат
            chart1.ChartAreas[0].AxisY.Maximum = 350;

            chart1.ChartAreas[0].AxisX.Interval = 1; // и можешь интервалы настроить по своему усмотрению

            chart1.ChartAreas[0].AxisX.Maximum = 2022; //Задаешь максимальные значения координат
            chart1.ChartAreas[0].AxisY.Maximum = 550;

            chart1.ChartAreas[0].AxisY.Interval = 50; // и можешь интервалы настроить по своему усмотрению
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

        private void button2_Click(object sender, EventArgs e)
        {
            Graphsdraw();
        }

        private void Graphsdraw()
        {

            string filePath = textBox1.Text;
            FileReader f = new FileReader(filePath);

            Data data = f.ReadIntoData();

            chart1.Series[0].Points.Clear();


            for (int i = 0; i < 15; i++)
            {
                chart1.Series[0].Points.AddXY(data.getYears()[i], data.getPeople()[i]);
            }
        }
        private void Graphsdraw_2()
        {
            string path = openFileDialog1.FileName;
            Reader r = new Reader(path);
            Data_2 data_2 = r.ReadData();
            chart1.Series[0].Points.Clear();


            for (int i = 0; i < 15; i++)
            {
                chart1.Series[0].Points.AddXY(data_2.getYears()[i], data_2.getPeople()[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            FileReader f = new FileReader(filePath);
            Data data = f.ReadIntoData();
            PercentCounter p = new PercentCounter();
            List<double> percentChange = p.GetPercentChange(data.getPeople());
            foreach (double i in percentChange)
            { richTextBox1.Text += i + " "; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string path = openFileDialog1.FileName;
                Reader add = new Reader(path);
                richTextBox2.Text += String.Format(add.ReadFile(openFileDialog1.FileName));
                Graphsdraw_2();
                Data_2 data_2 = add.ReadData();
                PercentCounter p = new PercentCounter();
                List<double> percentChange = p.GetPercentChange(data_2.getPeople());
                foreach (double i in percentChange)
                { richTextBox1.Text += i + " "; }
            }
        }
    }
}
