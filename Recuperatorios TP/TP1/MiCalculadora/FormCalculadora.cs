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
        /// Evento de carga del form, llama al metodo limpiar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// evento de cierre del form, realiza una verificacion de si el usuario quiere cerrar el form o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = new DialogResult();

            respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {

                e.Cancel = true;
            }
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
            char operando;
            double resultado = 0;
            if (char.TryParse(operador, out char c) == true)
            {
                operando = c;
                Numero num1 = new Numero(numero1);
                Numero num2 = new Numero(numero2);

                resultado = Calculadora.Operar(num1, num2, operando);


            }

            return resultado;
        }
        /// <summary>
        /// Evento que convierte el resultado (si lo hay, y es binario) en un numero decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            if (lblResultado.Text != "" && lblResultado.Text != "valor invalido")
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);

            }

        }
        /// <summary>
        /// Evento que convierte un numero decimal en binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "" && lblResultado.Text != "valor invalido")
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);

            }
        }
        /// <summary>
        /// Vacia los campos de todos los componentes del form
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = string.Empty;
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();

        }
        /// <summary>
        /// Evento que llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Evento que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
