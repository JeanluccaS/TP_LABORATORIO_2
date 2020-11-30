using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {

        /// <summary>
        /// inicializo un suv con el constructor de un vehículo
        /// </summary>
        /// <param name="marca">La marca del suv</param>
        /// <param name="chasis">El chasis del suv</param>
        /// <param name="color">El color del suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

       
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override  ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// Muestra todas las caracteristicas del SUV
        /// </summary>
        /// <returns>Un string con los datos del Suv</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
