using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class RepositorioClientes
    {
        string ruta = "Clientes.txt";// ruta donde se guarda el archivo
        public string Guardar(Entidades.Cliente cliente)
        {
            try
            {
                //FileStream archivo = new FileStream(ruta, FileMode.Append);
                //1. instanciar - abre en modo append -  adiciona datos
                StreamWriter escritor = new StreamWriter(ruta, true);

                // 2. operaciones
                escritor.WriteLine(cliente.ToString());
                
                //3.  guardar
                escritor.Close();
                                
                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }

        }
        public string Modificar(List<Entidades.Cliente> clientes)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in clientes)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "Se modificaron los datos los datos";

                //File.Delete(ruta);  // elimina
                //File.Move("tmp", ruta);// renombrar
            }
            catch (Exception)
            {

                return "No Se guardaron los datos";
            }

        }
        public string Modificar2(List<Entidades.Cliente> clientes)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt", true);// sobreescribe
                foreach (var item in clientes)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                File.Delete(ruta);  // elimina
                File.Move("tmp.txt", ruta);// renombrar

                return "Se modificaron los datos los datos";
                               
            }
            catch (Exception)
            {

                return "No Se guardaron los datos";
            }

        }
        public List<Entidades.Cliente> Consultar()
        {
            try
            {
               
                StreamReader lector = new StreamReader(ruta);
                List<Entidades.Cliente> clientes = new List<Entidades.Cliente>();   
                // 2. operaciones
                string linea= string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    Entidades.Cliente cliente = new Entidades.Cliente();
                    cliente.IdCliente= linea.Split(';')[0];
                    cliente.Nombre = linea.Split(';')[1];
                    clientes.Add(cliente);

                    //clientes.Add(new Entidades.Cliente(linea.Split(';')[0], linea.Split(';')[1]));
                }

                //3.  guardar
                lector.Close();

                return clientes;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Entidades.Cliente buscarId(string id)
        {
            foreach (var item in Consultar())
            {
                if (item.IdCliente== id)
                {
                    return item;
                }
            }
            return null;
        }
        public string eliminar(List<Entidades.Cliente> clientes)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in clientes)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();
                
                return "Se eliminó el cliente";

                //File.Delete(ruta);  // elimina
                //File.Move("tmp", ruta);// renombrar
            }
            catch (Exception)
            {

                return "No se pudo eliminar el cliente";
            }

        }
    }
}
