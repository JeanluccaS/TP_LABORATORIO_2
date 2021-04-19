using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que llama al metodo operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Realiza la operacion entre dos numeros
        /// </summary>
        /// <param name="numero1">El primer numero</param>
        /// <param name="numero2">El segundo numero</param>
        /// <param name="operador">La operacion que se desea realizar</param>
        /// <returns>El resultado de la operacion realizada</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
       
            double resultado = 0;
            
                
                Numero num1 = new Numero(numero1);
                Numero num2 = new Numero(numero2);

                resultado = Calculadora.Operar(num1, num2, operador);


           

            return resultado;
        }
        private void Limpiar()
        {
            this.lblResultado.Text = string.Empty;
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "" && lblResultado.Text != "valor invalido")
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);

            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "" && lblResultado.Text != "valor invalido")
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);

            }
        }
    }
}
