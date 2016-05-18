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
   public  class N_Caja
    {
        private string sCadena;

        public N_Caja(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarCaja()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarCategoria();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarCaja(int idusuario, string descripcion, decimal cantidadinicial, decimal cantidadfinal, DateTime fecha)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarCaja(idusuario, descripcion, cantidadinicial, cantidadinicial, fecha);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarCaja(int idcaja, int idusuario, string descripcion, decimal cantidadinicial, decimal cantidadfinal, DateTime fecha)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarCaja(idcaja, idusuario, descripcion, cantidadinicial, cantidadfinal, fecha);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarCaja(int idcaja)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarCaja(idcaja);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
