using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
namespace Logica
{
    public class ServicioCuentas
    {
        Datos.RepositorioCuenta repositorio = new Datos.RepositorioCuenta();
        List<Cuenta> ListaCuentas;
        public ServicioCuentas()
        {
            ListaCuentas = repositorio.Consultar();
        }
       
        public string Guardar(Cuenta cuenta)
        {

            return repositorio.Guardar(cuenta);


        }
        public List<Cuenta> Consultar()
        {
            
            return ListaCuentas = repositorio.Consultar();
        }
        public Cuenta buscarCuenta(double idCuenta)
        {
            ListaCuentas = repositorio.Consultar();
            foreach (var cuenta in ListaCuentas)
            {
                if (idCuenta == cuenta.NumeroCuenta)
                {
                    return cuenta;
                }
            }
            return null;
        }
        public string modificarCuenta (string idCliente, double numeroCuenta)
        {
            List<Cuenta> listaCuentas = repositorio.Consultar();
            foreach (var item in listaCuentas)
            {
                if (idCliente == item.Cliente.IdCliente)
                {
                    listaCuentas.Remove(item);
                }
            }
            return repositorio.Modificar(listaCuentas);
        }
        public string Consignar(Cuenta cuenta, double saldoConsignado)
        {
            cuenta.setSaldo(cuenta.getSaldo()*saldoConsignado);
            
            return "El nuevo saldo es de: $"+cuenta.getSaldo();
        }
    }
}
