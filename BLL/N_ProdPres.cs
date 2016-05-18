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
    public class N_ProdPres
    {
        private string sCadena;

        public N_ProdPres(string sCadena)
        {
            this.sCadena = sCadena;
        }

        public DataTable ConsultarProdPres()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.ConsultarProdPres();
            }
            catch (Exception)
            {

                return null;
            }
         
        }

        public void insertarProdPres(int prod, int pres, decimal precioc, decimal preciov, decimal existencia, byte imagen, string barras)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.InsertarProdPres(prod, pres, precioc, preciov, existencia, imagen, barras);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar..."+ex.Message);
            }
        
        }


        public void ActualizarProdPres(int idprodpres, int prod, int pres, decimal precioc, decimal preciov, decimal existencia, byte imagen, string barras)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarProdPres(idprodpres,prod,pres,precioc,preciov,existencia,imagen,barras);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void EliminarProdPres(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarProdPres (codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
