using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc_windows
{
    internal class imc
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;
        public double resultado;

        public double result()
        {
            resultado = peso / (altura * altura);
            return resultado;
        }

    }
}
