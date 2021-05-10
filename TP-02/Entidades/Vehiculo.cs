using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()

    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>

    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        string chasis;
        EMarca marca;
        ConsoleColor color;



        /// <summary>
        /// inicializo un vehículo
        /// </summary>
        /// <param name="chasis">El chasis del vehículo</param>
        /// <param name="marca">La marca del vehículo</param>
        /// <param name="color">El color del vehículo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehículo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// sobrecarga explicita, que devuelve un string con los datos del Vehículo
        /// </summary>
        /// <param name="p">Un vehiculor</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">El primer vehículo</param>
        /// <param name="v2">El segundo vehículo</param>
        /// <returns>Un booleano indicando si ambos vehículos son iguales</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">El primer vehículo</param>
        /// <param name="v2">El segundo vehículo</param>
        /// <returns>Un booleano indicando si ambos vehículos son distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
