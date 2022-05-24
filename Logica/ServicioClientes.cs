using System;
using System.Collections.Generic;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioClientes
    {
        RepositorioClientes repositorio = new RepositorioClientes(); // capa de datos
        List<Cliente> ListaClientes;
        public ServicioClientes()
        {
            ListaClientes = repositorio.Consultar();
        }
        List<Cliente> Actualizar()
        {
            return ListaClientes = repositorio.Consultar();
        }
        public string Guardar(Cliente cliente)
        {
            //validar
            return repositorio.Guardar(cliente);

        }
        public List<Cliente> Consultar()
        {
            Actualizar();
            return ListaClientes;
        }
        public Cliente BuscarId(string id)
        {
            foreach (var item in ListaClientes)
            {
                if (item.IdCliente==id)
                {
                    return item;
                }
            }
            return null;
        }
        public string modificarCliente(string nuevoNombre, string idCliente)
        {
            List<Cliente> listaClientes = Actualizar();
            foreach (var item in listaClientes)
            {
                if(idCliente == item.IdCliente)
                {
                    item.Nombre = nuevoNombre;
                   
                }
            }

           return repositorio.Modificar(listaClientes);
        }
        public string eliminarCliente(string idCliente)
        {
            List<Cliente> listaClientes = Actualizar();
            foreach (var item in listaClientes)
            {
                if(idCliente == item.IdCliente)
                {
                    listaClientes.Remove(item);
                }
            }
            return repositorio.Modificar(listaClientes);
        }
    }
}
