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
    public class N_DetalleV
    {
        private string sCadena;

        public N_DetalleV(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarDetalleV()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarDetalleV();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarDetalleV(int idfactura, int idprodpres, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarDetalleV(idfactura, idprodpres, cantidad, descuento, precio, total);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarDetalleV(int iddetallev, int idfactura, int idprodpres, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarDetalleV(iddetallev, idfactura, idprodpres, cantidad, descuento, precio, total);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarDetalleV(int iddetallev)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarDetalleV(iddetallev);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
