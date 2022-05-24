using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
namespace PresentacionIGU
{
    public partial class FormCuentas : Form
    {
        public FormCuentas()
        {
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            ServicioClientes servicioCliente = new ServicioClientes();
            cliente = servicioCliente.BuscarId(textIdCliente.Text);
            if (cliente!=null)
            {
                MessageBox.Show("Este Cliente no existe, deberia registrarlo");
            }
            ServicioCuentas servicioCuenta = new ServicioCuentas();
            Cuenta cuenta = servicioCuenta.buscarCuenta(double.Parse(textNumeroCuenta.Text));
            if (cuenta!=null)
            {
                cuenta = new Cuenta(double.Parse(textNumeroCuenta.Text), cliente, double.Parse(textSaldo.Text));
                MessageBox.Show(servicioCuenta.Guardar(cuenta));
            }
        }
    }
}
