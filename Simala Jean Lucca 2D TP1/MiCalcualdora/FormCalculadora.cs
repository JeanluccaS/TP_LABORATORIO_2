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

namespace MiCalcualdora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.Text = string.Empty;
        }
        private static double Operar(string numero1,string numero2,string operador)
        {
            double resultado;
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            resultado = Calculadora.Operar(numeroUno, numeroDos, operador);
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.binarioDecimal(this.lblResultado.Text);
        }

        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }
    }
}
