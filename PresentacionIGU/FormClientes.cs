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
        }
        void agregarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = textIdCliente.Text;
            cliente.Nombre = textNombreCliente.Text;
            ServicioClientes servicioCliente = new ServicioClientes();
            MessageBox.Show(servicioCliente.Guardar(cliente));
        }
    }
}
