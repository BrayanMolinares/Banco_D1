using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionIGU
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
             FormClientes formCliente = new FormClientes();
             formCliente.Show();
        }

        private void botonCuentas_Click(object sender, EventArgs e)
        {
            FormCuentas formCuenta = new FormCuentas();
            formCuenta.Show();
        }
    }
}
