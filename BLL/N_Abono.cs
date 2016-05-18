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
  public   class N_Abono
    {
         private string sCadena;
       
        public N_Abono(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarAbono()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarAbono();
            }
            catch (Exception)
            {

                return null;
            }
         
        }
        public void insertarAbono(int idcuentac, DateTime fecha, decimal monto )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarAbono(idcuentac, fecha, monto);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarAbono(int idabono, int idcuentac, DateTime fecha, decimal monto  )
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarAbono(idabono, idcuentac, fecha, monto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarAbono(int idabono)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarAbono ( idabono);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
