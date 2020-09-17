using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Res_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calc_b_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int a = Convert.ToInt32(A_TB.Text); //Получение числа А
                int b = Convert.ToInt32(B_TB.Text); //Получение числа B
                int res = a + b;                    //Расчёт ультата
                Res_TB.Text = res.ToString();       //Вывод результата
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Res_L_Click(object sender, EventArgs e)
        {

        }
    }
}
//BY TUSTUGASHEV