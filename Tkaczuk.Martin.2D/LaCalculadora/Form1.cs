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

namespace LaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        } 
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite ingresar numeros 
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //Permite presionar tecla retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite ingresar numeros 
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //Permite presionar tecla retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
            {
                if (txtNumero2.Text != "0")
                {
                    double rdoAux;
                    Numero numero1 = new Numero(txtNumero1.Text);
                    Numero numero2 = new Numero(txtNumero2.Text);
                    rdoAux = Calculadora.Operar(numero1, numero2, cmbOperador.Text);
                    lblResultado.Text = rdoAux.ToString();
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = true;
                }
                else
                    MessageBox.Show("¡No se puede dividir por cero!", "Error", MessageBoxButtons.OK);                
            }
            else
            {
                MessageBox.Show("¡No puede operar si no se ingresaron números!", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            lblResultado.Text = "";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numbin;
            Numero AuxResultado = new Numero();
            numbin = AuxResultado.DecimalBinario(lblResultado.Text);
            lblResultado.Text = numbin;
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numdec;            
            Numero AuxResultado = new Numero();
            numdec = AuxResultado.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = numdec;            
        }
        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = false;
            }
        }  
    }
}
