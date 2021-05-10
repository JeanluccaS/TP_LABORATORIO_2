using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }

        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">La marca del sedan</param>
        /// <param name="chasis">El chasis del sedan</param>
        /// <param name="color">El color del sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// inicializo un Sedan con el constructor de un vehículo
        /// </summary>
        /// <param name="marca">La marca del sedan</param>
        /// <param name="chasis">El chasis del sedan</param>
        /// <param name="color">El color del sedan</param>
        /// <param name="tipo">El tipo de sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra todas las caracteristicas del sedan
        /// </summary>
        /// <returns>Un string con los datos del sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : " + this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
