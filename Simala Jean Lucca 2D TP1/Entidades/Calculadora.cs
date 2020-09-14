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
        /// valida que el operador que recibe por parametro sea +,-,*,/
        /// </summary>
        /// <param name="operador">el operador que se va a verificar</param>
        /// <returns>retorna el operador que recibio por parametro, o + si no es 
        /// ninguno de  los permitiddos
        /// </returns>
        private static string ValidarOperador(char operador)
        {
            if(operador!='+'&&operador!='-'&&operador!='*'&&operador!='/')
            {
                operador = '+';
            }
            return Convert.ToString(operador);
        }
        /// <summary>
        /// se encarga de realizar la operacion entre 2 numeros
        /// </summary>
        /// <param name="num1">el primer numero</param>
        /// <param name="num2">el segundo numero</param>
        /// <param name="operador">la operacion que se va a realizar</param>
        /// <returns>el resultado de la operacion</returns>
        public static double  Operar(Numero num1,Numero num2,string operador)
        {
            double resultado=0;
            operador = ValidarOperador(Convert.ToChar( operador));
            switch (operador)
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
            return resultado;
        }
    }
}
