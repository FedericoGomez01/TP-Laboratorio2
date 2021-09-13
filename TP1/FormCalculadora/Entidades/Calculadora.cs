using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char aux;
            switch (operador)
            {
                case '+':
                case '*':
                case '/':
                case '-':
                    aux = operador;
                    break;

                default:
                    aux = '+';
                    break;
            }

            return aux;
            if(operador.ToString() != "-" || operador.ToString() != "+" || 
                operador.ToString() != "/" || operador.ToString() != "*")
            {
                return '+';
            }

            return operador;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double aux;
            switch (operador)
            {
                case '+':
                    aux = num1 + num2;
                    break;
                case '*':
                    aux = num1 *num2;
                    break;
                case '/':
                    if(ValidarOperando(num2) == 0)
                    {
                        aux = num2;
                    }
                    else
                    {
                        aux = num1 / num2;
                    }
                    
                        break;
                case '-':
                    aux = operador;
                    break;

                default:
                    aux = '+';
                    break;
            }
            return aux;
        }

    }

}
