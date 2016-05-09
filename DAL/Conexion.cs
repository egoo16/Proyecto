using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
namespace DAL
{
    internal class Conexion
    {
        //static string cadena = "Data Source=localhost;User Id=HR; Password=basedatos03";
        //public static OracleConnection cn = new OracleConnection(cadena);
        private OracleConnection cnConexion = null;

        public Conexion(string cnOConexion)
        {        
            this.cnConexion = new OracleConnection(cnOConexion);
        }

        public void conectar()
        {   
           
            try
            {
                cnConexion.Open();

            }
            catch (Exception ex)
            {

                throw new Exception("error al conectar a la base de datos, detalle del error: " + ex.Message);
            }
            
        }
        public void desconectar()
        {
            try
            {
                //desconectar de la database
                this.cnConexion.Close();
                //liberamos recursos
                this.cnConexion.Dispose();
                this.cnConexion = null;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al desconectarse de la base de datos, detalle del error: "+ ex.Message);
            }
        }

        public DataTable consultar(string OracleQuery)
        {
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand();
                da.SelectCommand.CommandText = OracleQuery;
                da.SelectCommand.Connection = cnConexion;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar datos, detalle de error:" + ex.Message);
            }
        }
        public DataTable consultar(string OracleQuery, object[] parametros)
        {
            try
            {
                OracleDataAdapter da = new OracleDataAdapter(OracleQuery, cnConexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                foreach (OracleParameter parametro in parametros)
                {
                    da.SelectCommand.Parameters.Add((OracleParameter)parametro);
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];

            }
            catch (Exception ex)
            {

                throw new Exception("Error al consular datos, detalle de error: " + ex.Message);
            }

        }

        public DataTable consultarOut(string OracleQuery)
        {
            try
            {
                OracleDataAdapter da = new OracleDataAdapter(OracleQuery, cnConexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(OracleQuery, OracleDbType.RefCursor).Direction=ParameterDirection.Output;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];

            }
            catch (Exception ex)
            {

                throw new Exception("Error al consular datos, detalle de error: " + ex.Message);
            }

        }

        public int ejecutarTransaccion(string OracleQuery)
        {
            try
            {
                OracleCommand cm = new OracleCommand(OracleQuery);
                cm.Connection = cnConexion;
                return cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la transacciòn, detalle del error" + ex.Message);
            }


        }
        public int ejecutarTransaccion(string OracleQuery, object[] parametros)
        {
            try
            {
                OracleCommand cm = new OracleCommand(OracleQuery, cnConexion);
                cm.CommandType = CommandType.StoredProcedure;
                foreach (OracleParameter parametro in parametros)
                {
                    cm.Parameters.Add((OracleParameter)parametro);
                }

                return cm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la transacciòn, detalle del error" + ex.Message);
            }
        }
    }
}
