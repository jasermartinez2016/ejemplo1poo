using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1poo
{
    public partial class btnsumar : Form
    {
        Matematicas matematicas = new Matematicas();



        public btnsumar()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Text = "Resultado:" + matematicas.sumar().ToString();
            lblresultado.Visible = true;

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Text = "Resultado:" + matematicas.restar().ToString();
            lblresultado.Visible = true;

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Text = "Resultado:" + matematicas.multiplicar().ToString();
            lblresultado.Visible = true;

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            matematicas.setNumero1(double.Parse(txtnumero1.Text));
            matematicas.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Text = "Resultado:" +  matematicas.dividir().ToString();
            lblresultado.Visible = true;

        }
    }
}
