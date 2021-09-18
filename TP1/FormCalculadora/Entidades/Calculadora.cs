using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public static class Calculadora
    {
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
