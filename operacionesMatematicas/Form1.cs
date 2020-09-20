using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacionesMatematicas
{
    public partial class Form1 : Form
    {
        Operaciones operaciones = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operaciones.setNumero1(double.Parse(txtnumero1.Text));
            operaciones.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Visible = true;
            label4.Visible = true;
            lblresultado.Text = Convert.ToString( String.Format("{0:n0}", operaciones.calcularSuma()));
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            
            operaciones.setNumero1(double.Parse(txtnumero1.Text));
            operaciones.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Visible = true;
            label4.Visible = true;
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", operaciones.calcularResta()));
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operaciones.setNumero1(double.Parse(txtnumero1.Text));
            operaciones.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Visible = true;
            label4.Visible = true;
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", operaciones.calcularMultiplicacion()));
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operaciones.setNumero1(double.Parse(txtnumero1.Text));
            operaciones.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Visible = true;
            label4.Visible = true;
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", operaciones.calcularDivision()));
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = String.Empty;
            txtnumero2.Text = String.Empty;
            txtnumero1.Focus();
            lblresultado.Visible = false;
            label4.Visible = false;

        }
    }
}
