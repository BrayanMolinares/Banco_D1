using System;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace PresentacionIGU
{
    public partial class FormularioConsignacion : Form
    {
        public FormularioConsignacion()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void textNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                BuscarCuenta(double.Parse(textNumeroCuenta.Text));
            }
        }
        Cuenta BuscarCuenta(double numeroCuenta) 
        {
            ServicioCuentas servicio = new ServicioCuentas();
            Cuenta cuenta = servicio.buscarCuenta(numeroCuenta);
            if(cuenta == null)
            {
                MessageBox.Show("Esta cuenta no está registrada");
                return null;
            }
            else
            {
                VerCuenta(cuenta);
                return cuenta;
            }
                       

        }
        void VerCuenta(Cuenta cuenta)
        {
            textNumeroCuenta.Text = cuenta.NumeroCuenta.ToString();
            textidCliente.Text = cuenta.Cliente.IdCliente;
            textNombreCliente.Text = cuenta.Cliente.Nombre;
        }

        private void botonConsignar_Click(object sender, EventArgs e)
        {
            Consignar();
        }
        void Consignar()
        {
         Cuenta cuenta = BuscarCuenta(double.Parse(textNumeroCuenta.Text));
         MessageBox.Show(cuenta.Consignar(double.Parse(textSaldo.Text)));
        }
    }
}
