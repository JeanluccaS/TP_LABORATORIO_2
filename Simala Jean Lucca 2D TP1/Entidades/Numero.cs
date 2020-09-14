using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public string setNumero
        {
            set { numero = validarNumero(value); }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.setNumero = Convert.ToString(numero);
        }

        public Numero(string strNumero)
        {
            this.setNumero = strNumero;
        }

        /// <summary>
        /// Verifica que el valor que se le pasa por parametro sea solamente un numero binario
        /// </summary>
        /// <param name="binario">el numero a evaluar</param>
        /// <returns>verdadero si el numero es binario, o falso si no lo es</returns>
        private static bool esBinaro(string binario)
        {
            bool esBinario = false;
            for (int i = 0; i <= binario.Length; i++)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    esBinario = true;
                } else
                {
                    esBinario = false;
                    break;
                }
            }

            return esBinario;
        }
        /// <summary>
        /// convierte un numero binario a un numero decimal
        /// </summary>
        /// <param name="binario">el numero a convertir</param>
        /// <returns>el numero convertido en decimal</returns>
        public static string binarioDecimal(string binario)
        {
            string valor = "valor invalido";
            if (esBinaro(binario))
            {
                valor = Convert.ToString(Convert.ToInt32(binario, 2));
                return valor;
            }
            return valor;
        }
        /// <summary>
        /// convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">el numero a convertir</param>
        /// <returns>el numero convertido en binario</returns>
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)Math.Abs(numero), 2);
        }
        /// <summary>
        /// convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">el numero a convertir</param>
        /// <returns>el numero convertido en binario</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            if (double.TryParse(numero, out double numParseado))
            {
                retorno = DecimalBinario(numParseado);
            }
            return retorno;
        }

        public static double operator +(Numero n1,Numero n2)
        {
            double resultado;
            resultado = n1.numero + n2.numero;
            return resultado;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero - n2.numero;
            return resultado;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero * n2.numero;
            return resultado;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            if(n2.numero==0)
            {
                resultado = double.MinValue;
            }else
            {
                resultado = n1.numero / n2.numero;
            }
           
            
            return resultado;
        }







        private double validarNumero(string strNumero)
        {
            double sePudo=0;

            if(double.TryParse(strNumero,out double validNum)==true)
            {
                sePudo =validNum;
            }

            return sePudo;
        }
    }
}
