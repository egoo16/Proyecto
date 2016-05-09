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
    public class N_Proveedor
    {
        private string sCadena;
       
        public N_Proveedor(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarProveedor()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarProveedor();
            }
            catch (Exception)
            {

                return null;
            }
         
        }
        public void insertarProveedor(string nombre, string direccion, string telefono,
            string correo, DateTime fechaIngreso
           )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarProveedor(nombre, direccion, telefono, correo, fechaIngreso);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarProveedor(int codigo, string nombre, string direccion, string telefono,
            string correo, DateTime fechaIngreso
           )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarProveedor(codigo, nombre, direccion, telefono, correo, fechaIngreso);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarCategoria(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarProveedor (codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
