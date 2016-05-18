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
   public  class N_CuentaCobrar
    {
        private string sCadena;

        public N_CuentaCobrar(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable consultarCuentaCobrar()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarCuentaCobrar();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarCuentaCobrar(int iddetallev, DateTime fechainicio, DateTime fechalimite, decimal monto, decimal saldo, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarCuentaCobrar(iddetallev, fechainicio, fechalimite, monto, saldo, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar..." + ex.Message);
            }

        }


        public void ActualizarCuentaCobrar(int idcuentac, int iddetallev, DateTime fechainicio, DateTime fechalimite, decimal monto, decimal saldo, string liquidado)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarCuentaCobrar(idcuentac, iddetallev, fechainicio, fechalimite, monto, saldo, liquidado);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void eliminarCuentaCobrar(int idcuentac)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarCuentaCobrar(idcuentac);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
