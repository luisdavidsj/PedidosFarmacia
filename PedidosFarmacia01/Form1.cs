using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosFarmacia01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Se crea la instancia con el Form2 y se comienzan a mandar los datos del Form1
            Form2 forma2 = new Form2();
            forma2.lblConfNombreMedic.Text = txtNombreMedic.Text;
            forma2.lblConfTipo.Text = cbTipoMedic.Text;
            forma2.lblConfCantidad.Text = txtCantidad.Text;

            if (rbCof.Checked)
                forma2.lblConfDist.Text = rbCof.Text;
            else
                if (rbEmp.Checked)
                forma2.lblConfDist.Text = rbEmp.Text;
            else
                if (rbCem.Checked)
                forma2.lblConfDist.Text = rbCem.Text;

            if (chkPrincipal.Checked)
                forma2.lblConfSuc.Text = "Calle de la Rosa n.28";
                var a = forma2.lblConfSuc.Text;
            if (chkSecundaria.Checked)
                forma2.lblConfSuc.Text = "Calle Alcazabilla n. 3";
                var b = forma2.lblConfSuc.Text;
            if (chkPrincipal.Checked && chkSecundaria.Checked)
                forma2.lblConfSuc.Text = "Calle de la Rosa n.28 y para la situada en Calle Alcazabilla n. 3";
                var c = forma2.lblConfSuc.Text;

            forma2.lblMedPedir.Text = txtCantidad.Text + " Unidades del " + cbTipoMedic.Text + " " + txtNombreMedic.Text;

            if (chkPrincipal.Checked)
                forma2.Text = "Pedido al distribuidor " + chkPrincipal.Text;
                forma2.lblSucEnviar.Text = "Para la farmacia situada en " + a;
            if (chkSecundaria.Checked)
                forma2.Text = "Pedido al distribuidor " + chkSecundaria.Text;
                forma2.lblSucEnviar.Text = "Para la farmacia situada en " + b;
            if (chkPrincipal.Checked && chkSecundaria.Checked)
                forma2.Text = "Pedido al distribuidor " + chkPrincipal.Text + " y " + chkSecundaria.Text;
                forma2.lblSucEnviar.Text = "Para la farmacia situada en " + c;

            //Condiciones para pasar al formulario 2
            bool verificacion = true;
            if (string.IsNullOrEmpty(txtNombreMedic.Text))
            {
                MessageBox.Show("El nombre del medicamento no puede estar vacío", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }
            if (String.IsNullOrEmpty(cbTipoMedic.Text))
            {
                MessageBox.Show("Tiene que haber un tipo de medicamento seleccionado", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("La cantidad del producto no puede estar vacía", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }
            if (txtCantidad.Text == "0" || txtCantidad.Text.Contains("-"))
            {
                MessageBox.Show("La cantidad del producto debe ser positiva", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }
            if (rbCof.Checked == false && rbEmp.Checked == false && rbCem.Checked == false) 
            {
                MessageBox.Show("Tienes que seleccionar un distribuidor", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }
            if (chkPrincipal.Checked == false && chkSecundaria.Checked == false)
            {
                MessageBox.Show("Tienes que seleccionar una sucursal", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verificacion = false;
            }

            if (verificacion == true)
            {
                forma2.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipoMedic.SelectedIndex = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreMedic.Text = "";
            cbTipoMedic.SelectedIndex = 0;
            txtCantidad.Text = "";
            rbCof.Checked = false;
            rbEmp.Checked = false;
            rbCem.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMedic_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
