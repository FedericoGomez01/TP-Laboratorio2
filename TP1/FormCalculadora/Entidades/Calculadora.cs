using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public static class Calculadora
    {
        /// <summary>
        /// Recibe un operador de tipo char y lo devuelve, de ser un operando vacio devuelve '+'
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {

            char returnAux = ' ';
            switch (operador)
            {
                case '+':
                case '-':
                case '/':
                case '*':
                    {
                        returnAux = operador;
                        break;
                    }
                default:
                    {
                        returnAux = '+';
                        break;
                    }
            }
            return returnAux;
        }

        /// <summary>
        /// Realiza la operacion de los Operando pasados por valor y su respectivo operador,
        /// de estar vacio el operador realizara la suma y sera retornada como double.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double aux;
            char auxOperador = operador;
            switch (ValidarOperador(auxOperador))
            {
                case '+':
                    aux = num1 + num2;
                    break;
                case '*':
                    aux = num1 * num2;
                    break;
                case '/':
                    aux = num1 / num2;
                    break;
                case '-':
                    aux = num1 - num2;
                    break;
                default:
                    aux = num1 + num2;
                    break;
            }
            return aux;
        }

    }

}
