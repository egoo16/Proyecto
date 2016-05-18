using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using DAL;


namespace BLL
{
   public  class N_Cliente
    {
        private string sCadena;

        public N_Cliente(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarCliente()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarCliente();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarCliente(string nombre, string apellido, string direccion, string telefono, string nit, DateTime fechaingreso, string mayorista, string idmayorista)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarCliente(nombre, apellido, direccion, telefono, nit, fechaingreso, mayorista, idmayorista);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarCliente(int idcliente, string nombre, string apellido, string direccion, string telefono, string nit, DateTime fechaingreso, string mayorista, string idmayorista)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarCliente(idcliente, nombre, apellido, direccion, telefono, nit, fechaingreso, mayorista, idmayorista);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarCliente(int idcliente)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarCliente(idcliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
