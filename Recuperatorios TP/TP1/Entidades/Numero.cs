using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// inicializa un numero
        /// </summary>
        Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecarga del constructor de Numero, inicializa un numero
        /// </summary>
        /// <param name="numero">Un numero que se quiere colocar en el atributo "numero"</param>
        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }
        /// <summary>
        /// Sobrecarga del constructor de Numero, incializa un numero
        /// </summary>
        /// <param name="strNumero">Un string del numero que se quiere colocar en el atributo "numero</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// verifica que el string que recibe por parametro sea un numero binario
        /// </summary>
        /// <param name="binario">El string a validar</param>
        /// <returns>Un booleano indicando si es un numero binario o no</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            int lenght = binario.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// sobrecarga del operador +, suma dos numeros
        /// </summary>
        /// <param name="n1">El primer numero</param>
        /// <param name="n2">El segundo numero</param>
        /// <returns>El resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecarga del opreador -,resta dos numeros
        /// </summary>
        /// <param name="n1">El primer numero</param>
        /// <param name="n2">El segundo numero</param>
        /// <returns>El resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecarga del operador *, multiplica dos numeros
        /// </summary>
        /// <param name="n1">El primer numero</param>
        /// <param name="n2">El segundo numero</param>
        /// <returns>El resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
        /// <summary>
        /// sobrecarga del operador /,divide dos numeros
        /// </summary>
        /// <param name="n1">El primer numero</param>
        /// <param name="n2">El segundo numero</param>
        /// <returns>El resultado de la division</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = double.MinValue;
            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }
        /// <summary>
        /// Convierte un numero binario en decimal
        /// </summary>
        /// <param name="binario">La cadena que representa al numero que se quiere pasar a decimal</param>
        /// <returns>El numero en decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            string valor = "valor invalido";
            if (EsBinario(binario))
            {
                valor = Convert.ToString(Convert.ToInt32(binario, 2));
            }
            return valor;
        }
        /// <summary>
        /// Convierte un numero decimal a un numero binario
        /// </summary>
        /// <param name="numero">El numero que se quiere pasar a binario</param>
        /// <returns>El numero en binario</returns>
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)Math.Abs(numero), 2);
        }
        /// <summary>
        /// Convierte un numero decimal a un numero binario
        /// </summary>
        /// <param name="numero">La cadena que representa al numero que se quiere pasar a binario</param>
        /// <returns>El numero en binario</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "valor invalido";
            if (double.TryParse(numero, out double auxNum))
            {
                retorno = DecimalBinario(auxNum);
            }
            return retorno;
        }
        /// <summary>
        /// Valida que el string que recibe por parametro sea un numero
        /// </summary>
        /// <param name="strNumero">La cadena que se desea validar</param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out double auxNum) == true)
            {
                retorno = auxNum;
            }

            return retorno;
        }
    }
}
