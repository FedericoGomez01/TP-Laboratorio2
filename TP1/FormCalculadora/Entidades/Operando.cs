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
            foreach (char numero in binario)
            {
                if(numero != '1' && numero != '0')
                {
                    aux++;
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
            string retorno = string.Empty;
            double aux=0;
            int auxIndice = binario.Length - 1;
            if (EsBinario(binario))
            {
                foreach (char valor in binario)
                {

                    if (valor == '1')
                    {
                        aux += Math.Pow(2, auxIndice);
                    }
                    auxIndice--;
                }
                retorno = aux.ToString();
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }

        public string DecimalBinario(double numero)
        {
            int resto;
            int resultadoDiv = (int)numero;
            string retorno = string.Empty;
            if(numero< 65536 )
            {
                if (numero >= 0 && !(EsBinario(numero.ToString())))
                {
                    while (resultadoDiv > 0)
                    {
                        resto = (resultadoDiv % 2);
                        resultadoDiv = resultadoDiv / 2;
                        retorno = resto.ToString() + retorno;
                    }

                }
                else
                {
                    retorno = "Valor invalido";
                }
            }
            else
            {
                retorno = "Exceso Bits";
            }
            return retorno;
        }
        public string DecimalBinario(string numero)
        {
            double numeroAuxiliar;
            double.TryParse(numero,out  numeroAuxiliar);
            string retorno = "Valor invalido";
            if(DecimalBinario(numeroAuxiliar) != retorno)
            {
                retorno = DecimalBinario(numeroAuxiliar);
            }

            return retorno;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno;
            if(n2.numero==0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
