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
    public class N_Compra
    {
        private string sCadena;

        public N_Compra(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarCompra()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarCompra();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarCompra(int idusario, int idproveedor, int idpago, DateTime fechacompra, decimal total, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarCompra(idusario, idproveedor, idpago, fechacompra, total, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarCompra(int idcompra, int idusuario, int idproveedor, int idpago, DateTime fechacompra, decimal total, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarCompra(idcompra, idusuario, idproveedor, idpago, fechacompra, total, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarCompra(int idcompra)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarCompra(idcompra);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
