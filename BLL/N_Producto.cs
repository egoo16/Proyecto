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
    public class N_Producto
    {
         private string sCadena;
       
        public N_Producto(string sCadena)
        {
            this.sCadena = sCadena;
        }


        public DataTable consultarProducto()
        {
            ManejoDatos mdobj = new ManejoDatos(sCadena);
            try
            {
                return mdobj.consultarProducto();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void insertarProducto(int IDCATEGORIA, int IDMARCA, string NOMBRE, string DESCRIPCION, string ESTADO)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.insertarProducto(IDCATEGORIA, IDMARCA, NOMBRE, DESCRIPCION, ESTADO);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar Producto" + ex.Message);
            }

        }


        public void ActualizarProducto(int IdProducto, int IDCAT, int IDMAR, string NOM, string DES, string EST)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.ActualizarProducto(IdProducto, IDCAT, IDMAR, NOM, DES, EST);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Actualizar..." + ex.Message);
            }

        }

        public void EliminarProducto(int codigo)
        {
            try
            {
                ManejoDatos mdobj = new ManejoDatos(sCadena);
                mdobj.EliminarProducto(codigo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Eliminar..." + ex.Message);
            }
        }
    }
}
