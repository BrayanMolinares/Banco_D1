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

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCuenta();
            VaciarText();
        }
        void AgregarCuenta()
        {
            Cliente cliente;
            ServicioClientes servicioCliente = new ServicioClientes();
            cliente = servicioCliente.BuscarId(textIdCliente.Text);
            if (cliente == null)
            {
                MessageBox.Show("Este Cliente no existe, deberia registrarlo");
            }
            ServicioCuentas servicioCuenta = new ServicioCuentas();
            Cuenta cuenta = servicioCuenta.buscarCuenta(double.Parse(textNumeroCuenta.Text));
            if (cuenta == null)
            {
                cuenta = new Cuenta(double.Parse(textNumeroCuenta.Text), cliente, double.Parse(textSaldo.Text));
                MessageBox.Show(servicioCuenta.Guardar(cuenta));
            }
            else
            {
                MessageBox.Show("Esta cuenta ya está registrada");
            }
        }
        private void TextIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarCliente(textIdCliente.Text);
                textNumeroCuenta.Focus();
            }
            
        }
        void BuscarCliente(string idCliente)
        {
            ServicioClientes servicioClientes= new ServicioClientes();
            Cliente cliente;
            cliente = servicioClientes.BuscarId(idCliente);
            VerCliente(cliente);
        }
        void VerCliente(Cliente cliente)
        {
            textIdCliente.Text = cliente.IdCliente;
            textNombreCliente.Text = cliente.Nombre;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void VaciarText()
        {
            textIdCliente.Text = "";
            textNombreCliente.Text = "";
            textNumeroCuenta.Text = "";
            textSaldo.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioConsignacion formularioConsignacion = new FormularioConsignacion();
            formularioConsignacion.Show();
        }
    }
}
