using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosFarmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 instancia = new Form2();
            //Colocar if aqui
            instancia.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solución provisional para formatear a solo texto:
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMedic.Text = "";
            cbTipoMedic.SelectedIndex = -1;
            txtCantidad.Text = "";
            rbCof.Checked = false;
            rbEmp.Checked = false;
            rbCem.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
