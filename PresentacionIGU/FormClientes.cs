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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void botonNuevoCliente_Click(object sender, EventArgs e)
        {
            agregarCliente();
            VaciarText();
        }
        void agregarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = textIdCliente.Text;
            cliente.Nombre = textNombreCliente.Text;
            ServicioClientes servicioCliente = new ServicioClientes();
            MessageBox.Show(servicioCliente.Guardar(cliente));
        }
        void VaciarText()
        {
            textIdCliente.Text = "";
            textNombreCliente.Text = "";
        }

        
        void BuscarCliente(string idCliente)
        {
            ServicioClientes servicio = new ServicioClientes();
            Cliente cliente;
            cliente = servicio.BuscarId(idCliente);
            if (cliente == null)
            {
                MessageBox.Show("Este cliente no se encuentra registrado");
            }
            VerCliente(cliente);

        }
        void VerCliente(Cliente cliente)
        {
            textIdCliente.Text = cliente.IdCliente;
            textNombreCliente.Text = cliente.Nombre;
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente(textIdCliente.Text);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
