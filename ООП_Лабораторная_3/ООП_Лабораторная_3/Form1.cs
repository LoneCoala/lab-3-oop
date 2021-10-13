using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_Лабораторная_3
{
    public partial class Сортировка : Form
    {
        public Сортировка()
        {
            InitializeComponent();
        }
        private void Сортировка_Load(object sender, EventArgs e)
        {

        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        double aNum = 0.0;
        double bNum = 0.0;
        double cNum = 0.0;

        private void Окно_Вывода_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out aNum) && Double.TryParse(textBox2.Text, out bNum) && Double.TryParse(textBox3.Text, out cNum))
            {
                if ((aNum >= bNum) && (aNum >= cNum))
                {
                    if (bNum >= cNum)
                        Окно_Вывода.Text = "A=" + aNum + " B=" + bNum + " C=" + cNum;
                    else
                        Окно_Вывода.Text = "A=" + aNum + " C=" + cNum + " B=" + bNum; ;
                }
                else if ((bNum >= aNum) && (bNum >= cNum))
                {
                    if (aNum >= cNum)
                        Окно_Вывода.Text = "B=" + bNum + " A=" + aNum + " C=" + cNum;
                    else
                        Окно_Вывода.Text = "B=" + bNum + " C=" + cNum + " A=" + aNum; ;
                }
                else if ((cNum >= aNum) && (cNum >= bNum))
                {
                    if (bNum >= aNum)
                        Окно_Вывода.Text = "C=" + cNum + " B=" + bNum + " A=" + aNum;
                    else
                        Окно_Вывода.Text = "C=" + cNum + " A=" + aNum + " B=" + bNum; ;
                }
            }
            else Окно_Вывода.Text = "Исходные данные не корректны или не полны";
        }
    }
}
