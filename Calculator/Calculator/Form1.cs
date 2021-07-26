using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string Action; 
        public string N1; //набранное число
        public bool N2;//ввод второго числа
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double defminus, result;
            defminus = Convert.ToDouble(VersionInfo.Text);
            result = -defminus;
            VersionInfo.Text = result.ToString();
        }

        private void VersionInfo_Click(object sender, EventArgs e)
        {

        }

        private void KeyOne_Click(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                VersionInfo.Text = "0";
            }
            Button B = (Button)sender;
            if(VersionInfo.Text =="0")
            VersionInfo.Text = B.Text;
            else
                VersionInfo.Text = VersionInfo.Text + B.Text;
        }

        private void KeyClear_Click(object sender, EventArgs e)
        {
            VersionInfo.Text = "0";
        }

        private void KeyDivide_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Action = B.Text;
            N1 = VersionInfo.Text;
            N2 = true;
        }

        private void KeyEqual_Click(object sender, EventArgs e)
        {
            double definition1, definition2, result; //хранение значений
            result = 0;
            definition1=Convert.ToDouble(N1);
            definition2 = Convert.ToDouble(VersionInfo.Text);

            if(Action=="+")
            {
                result = definition1 + definition2;
            }
            if (Action == "-")
            {
                result = definition1 - definition2;
            }
            if (Action == "×")
            {
                result = definition1 * definition2;
            }
            if (Action == "÷")
            {
                result = definition1 / definition2;
            }
            if (Action == "%")
            {
                result = definition1*definition2/100;
            }

            Action = "=";
            N2 = true;

            VersionInfo.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double rootdef, result;
            rootdef= Convert.ToDouble(VersionInfo.Text);
            result = Math.Sqrt(rootdef);
            VersionInfo.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double powerdef, result;
            powerdef = Convert.ToDouble(VersionInfo.Text);
            result = Math.Pow(powerdef,2);
            VersionInfo.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double def, result;
            def = Convert.ToDouble(VersionInfo.Text);
            result = 1/def;
            VersionInfo.Text = result.ToString();
        }

        private void KeyPoint_Click(object sender, EventArgs e)
        {
            if(!VersionInfo.Text.Contains(","))
            VersionInfo.Text = VersionInfo.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VersionInfo.Text = VersionInfo.Text.Substring(0, VersionInfo.Text.Length - 1);
            if (VersionInfo.Text == "")
                VersionInfo.Text = "0";
        }

        private void VersionInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Инженерный u = new Инженерный();
            u.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            info info1 = new info();
            info1.ShowDialog();
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
