using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        public Operando(double numero):this(numero.ToString())
        {
        }

        private double ValidarOperando(string strNumero)
        {
            double aux;
            if (double.TryParse(strNumero, out aux))
            { }
            else
            {
                aux = 0;
            }

            return aux;
        }
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        private bool EsBinario(string binario)
        {
            int aux =0;
            bool rtn;
            foreach (char i in binario)
            {
                switch (binario)
                {
                    case "1":
                    case "0":
                        break;
                    default:
                        aux++;
                        break;
                }

            }
            if (aux >0)
            {
                rtn = false;
            }
            else
            {
                rtn = true;
            }
            return rtn;
        }

        public string BinarioDecimal(string binario)
        {
            int aux =0;
            if (EsBinario(binario))
            {
                foreach (char valor in binario)
                {
                    int auxIndice = binario.Length;
                    if (valor == 1)
                    {
                        aux = aux + (valor * (int)Math.Pow(2, auxIndice));
                    }
                    auxIndice--;
                }
            }
            return aux.ToString();
        }

        public string BinarioDecimal(double numero)
        {
            int aux = 0;

            while(numero > 1)
            {
                if (numero % 2 == 0 || numero % 2 == 1)
                {
                    aux = aux + ((int)numero % 2);
                    numero = numero / 2;
                }
            }
        }
        public string BinarioDecimal(string numero)
        {

        }
    }
}
