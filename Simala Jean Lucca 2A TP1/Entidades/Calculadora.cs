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
        /// Realiza la operacion entre 2 Numeros
        /// </summary>
        /// <param name="num1">El primer numero</param>
        /// <param name="num2">El segundo numero</param>
        /// <param name="operador">La opreacion que se desea realizar</param>
        /// <returns>El resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            string rta;
            if(operador !="")
            {
                rta = ValidarOperador(Convert.ToChar(operador));

                switch (rta)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;

                }
            }
           
            return resultado;
        }
        /// <summary>
        /// Valida que el caracter que reciba por parametro sea un operador.
        /// </summary>
        /// <param name="operador">El caracter a validar</param>
        /// <returns>"+" por defecto, o en caso de que el operador no sea valido </returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            else
            {
                return "+";

            }

        }
    }
}
