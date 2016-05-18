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
    public class N_CuentaPagar
    {
        private string sCadena;
       
        public N_CuentaPagar(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarCategoria()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.ConsultaCuentaP();
            }
            catch (Exception)
            {

                return null;
            }
         
        }
        public void InsertarCuentaP(int detalle, DateTime fechaC, DateTime FechaL, decimal monto, decimal saldo, string Liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.InsertarCuentaP(detalle, fechaC, FechaL, monto, saldo, Liquidado);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }

        public void eliminarCategoria(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarCuentaP (codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
