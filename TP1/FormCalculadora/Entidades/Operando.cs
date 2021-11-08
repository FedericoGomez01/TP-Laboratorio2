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

        /// <summary>
        /// Asigna el valor 0 a la instancia numero
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Asigna el string pasado en una instancia de tipo double 
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Asigna el numero pasado por parametro a la instancia 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero):this(numero.ToString())
        {
        }

        /// <summary>
        /// Retorna el string pasado en un tipo double, de no ser posible retorna 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double aux;
            double.TryParse(strNumero, out aux);
            return aux;
        }

        /// <summary>
        /// Asigna el string como tipo double a la instancia, sino es posible, asigna 0 
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Valida que el string recibido como parametro sea un numero binario, de ser asi retorna true, sino false
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna un string decimal del numero binario pasado por parametro como tipo string.
        /// De no ser posible retorna "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna un string binario del numero decimal pasado por parametro como tipo double.
        /// De no ser posible retorna "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna un string binario del numero decimal pasado por parametro como tipo string.
        /// De no ser posible retorna "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Realiza la resta de los Operando pasdos por parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza la multiplicacion de los Operando pasdos por parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza la division de los Operando pasdos por parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Realiza la suma de los Operando pasdos por parametros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
