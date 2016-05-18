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
    public class N_AbonoC
    {
        private string sCadena;
       
        public N_AbonoC(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable ConsultarAbono()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.ConsultarAbonoC();
            }
            catch (Exception)
            {

                return null;
            }
         
        }
        public void InsertarAbono(DateTime fecha, Decimal monto)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.InsertarAbonoC(fecha,monto);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarAbonoC(int IdAbono, int cuenta, DateTime fecha, Decimal monto)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarAbonoC(IdAbono,cuenta,fecha,monto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void EliminarAbonoC(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarAbonoC (codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
