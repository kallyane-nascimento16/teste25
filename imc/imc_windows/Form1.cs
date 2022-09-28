using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imc i=new imc();
            i.altura=double.Parse(textBoxALTURA.Text);
            i.nome=textBoxNOME.Text;
            i.idade=int.Parse(textBoxIDADE.Text);
            i.peso=int.Parse(textBoxPESO.Text);
            i.result();

          
            listBox1.Items.Add("ola seja bem-vindo ");
            listBox1.Items.Add("dados do usuario ");
            listBox1.Items.Add("nome:"+i.nome);
            listBox1.Items.Add("altura:"+i.altura);
            listBox1.Items.Add("idade:"+i.idade);
            

            listBox1.Text = Convert.ToString(i.result());

            if (i.resultado < 18.5)
            {
                listBox1.Items.Add("seu imc é : " + i.resultado);
                listBox1.Items.Add("você esta a baixo do peso");
            }
            if (i.resultado >= 18.5 && i.resultado <= 24.9)
            {
                listBox1.Items.Add("seu imc é : " + i.resultado);
                listBox1.Items.Add("você esta com o peso normal ");
            }
            if (i.resultado >= 25.0 && i.resultado <= 29.9)
            {
                listBox1.Items.Add("seu imc é : " + i.resultado);
                listBox1.Items.Add("você esta a cima do peso");
            }
            if (i.resultado >= 30.0 && i.resultado <= 34.9)
            {
                listBox1.Items.Add("seu imc é : " + i.resultado);
                listBox1.Items.Add("você esta com obesidade classe I ");
            }
            if (i.resultado >= 35.0 && i.resultado <= 39.9)
            {
                listBox1.Items.Add("seu imc é : " + i.resultado);
                listBox1.Items.Add("você esta com obesidade classe II");
            }
            if (i.resultado >= 40.0)
            {
                listBox1.Items.Add("seu IMC é :" + i.resultado);
                listBox1.Items.Add("VOCE ESTA COM OBESIDADE CLASSE III");

            }



        }
    }
}
