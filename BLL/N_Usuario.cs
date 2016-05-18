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
   public  class N_Usuario
    
        {
            private string sCadena;

            public N_Usuario(string sCadena)
            {
                this.sCadena = sCadena;
            }

            public DataTable consultarUsuario()
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                try
                {
                    return mdobj.consultarUsuario();
                }
                catch (Exception)
                {

                    return null;
                }

            }
            public void insertarUsuario(int idrol, string nombre, string apellido, string direccion, string telefono, string dpi, DateTime fechaingreso, string nomusuario, string clave)
            {
                try
                {
                    ManejoDatos mdobj = new ManejoDatos(sCadena);
                    mdobj.insertarUsuario(idrol, nombre, apellido, direccion, telefono, dpi, fechaingreso, nomusuario, clave);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error al insertar..." + ex.Message);
                }

            }


            public void ActualizarUsuario(int idusuario, int idrol, string nombre, string apellido, string direcion, string telefono, string dpi, DateTime fechaingreso, string nomusuario, string clave)
            {
                try
                {
                    ManejoDatos mdobj = new ManejoDatos(sCadena);
                    mdobj.ActualizarUsuario(idusuario, idrol, nombre, apellido, direcion, telefono, dpi, fechaingreso, nomusuario, clave);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error al Actualizar..." + ex.Message);
                }

            }

            public void eliminarUsario(int idusuario)
            {
                try
                {
                    ManejoDatos mdobj = new ManejoDatos(sCadena);
                    mdobj.EliminarUsuario(idusuario);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error al Eliminar..." + ex.Message);
                }
            }

        
    }
}
