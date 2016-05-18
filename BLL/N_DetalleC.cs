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
    public class N_DetalleC
    {
        private string sCadena;

        public N_DetalleC(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable ConsultarDetalleC()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.ConsultarDetalleC();
            }
            catch (Exception)
            {

                return null;
            }
         
        }
        public void InsertarDetalleC(int compra, int prod, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarDetalleC(compra,prod,cantidad,descuento,precio,total);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarDetalleC(int iddetalle, int compra, int prod, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarDetalleC(iddetalle,compra, prod, cantidad, descuento, precio, total);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

       
    }
}
