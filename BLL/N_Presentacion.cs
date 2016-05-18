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
    public class N_Presentacion
    {
        private string sCadena;
       
        public N_Presentacion(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable ConsultarPresentacion()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.Consultarpresentacion();
            }
            catch (Exception)
            {

                return null;
            }
         
        }

        public void InsertarPres(string nombre,
            string descripcion )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.InsertarPres(nombre, descripcion);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarPres(int codigo, string nombre,
           string descripcion )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarPres(codigo, nombre, descripcion);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void EliminarPres(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarPres (codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    



    }
}
