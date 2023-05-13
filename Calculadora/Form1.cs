using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double numero1 = 0, numero2 = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarnumero(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            if (txt_res.Text == "0")
                
            txt_res.Text = "";
            txt_res.Text += boton.Text;
            

        }

        private void cmd_igual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txt_res.Text);

            if (op=='+')
            {
                txt_res.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txt_res.Text);
            }else if(op == '-')
            {
                txt_res.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txt_res.Text);
            }
            else if (op == '*')
            {
                txt_res.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txt_res.Text);
            }
            else if (op == '/')
            {
                txt_res.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txt_res.Text);
              
            }
        }

        private void cmd_ernum_Click(object sender, EventArgs e)
        {
            if(txt_res.Text.Length>1)
            {
                txt_res.Text = txt_res.Text.Substring(0, txt_res.Text.Length - 1);
            }
            else
            {
                txt_res.Text = "0";
            }
        }

        private void cmd_erlast_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            op = '\0';
            txt_res.Text = "0";
        }

        private void cmd_erall_Click(object sender, EventArgs e)
        {
            txt_res.Text = "0";
        }

        private void cmd_dot_Click(object sender, EventArgs e)
        {
            if (!txt_res.Text.Contains("."))
                txt_res.Text += "."; 
        }

        private void clickop(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(txt_res.Text);
            op = Convert.ToChar(boton.Text);
            txt_res.Text = "0";
            
        }
       
    }
}
