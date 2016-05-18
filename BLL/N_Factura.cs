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
   public class N_Factura
    {
        private string sCadena;

        public N_Factura(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarFactura()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarFactura();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarFactura(int idusuario, int idcliente, int idpago, string serie, string correlativo, DateTime fechafactura, decimal total, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarFactura(idusuario, idcliente, idpago, serie, correlativo, fechafactura, total, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarFactura(int idfactura, int idusuario, int idcliente, int idpago, string serie, string correlativo, DateTime fechafactura, decimal total, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarFactura(idfactura, idusuario, idcliente, idpago, serie, correlativo, fechafactura, total, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarFactura(int idfactura)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarFactura(idfactura);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
