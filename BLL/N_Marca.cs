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
    public class N_Marca
    {
        private string sCadena;

        public N_Marca(string sCadena)
        {
            this.sCadena = sCadena;
        }


        public DataTable ConsultarMarca()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.ConsultarMarca();
            }
            catch (Exception)
            {

                return null;
            }

        }
        
        public void InsertarMarca(string NOMBRE, string ESTADO)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.InsertarMarca(NOMBRE, ESTADO);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Marca" + ex.Message);
            }

        }

        
        public void ActualizarMarca( int IDMAR, string NOM, string EST)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarMarca(IDMAR, NOM, EST);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar Marca" + ex.Message);
            }
        }
        
        public void EliminarMarca(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarMarca(codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar" + ex.Message);
            }
        }
        

    }
}
