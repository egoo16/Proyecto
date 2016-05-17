using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAL
{
    public class ManejoDatos
    {

        //declaracion de atributos
        private string oCadena = "";
        //declraciòn del constructor
        public ManejoDatos(string oCadena)
        {
            this.oCadena = oCadena;
        }

        #region Categoria
        public DataTable consultarCategoria()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listar_categoria");
        }

        public void insertarCategoria(string nombre, string
            descripcion)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_categoria",
             new object[] { new OracleParameter("nombre",nombre),
                 new OracleParameter("descripcion",descripcion),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarCategoria(int id, string nombre, string
            descripcion)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_categoria",
             new object[] { new OracleParameter("idCategoria",id),
                 new OracleParameter("NOMBRE",nombre),
                 new OracleParameter("DESCRIPCION",descripcion),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }


        public void EliminarCategoria(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_categoria",
             new object[] { new OracleParameter("IdCategoria",id)
                });
            obj.desconectar();
        }
        #endregion

        #region Proveedor
        public DataTable consultarProveedor()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listadoproveedor");
        }

        public void insertarProveedor(string nombre, string direccion, string
            telefono, string correo, string fechaIngreso)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_proveedor",
             new object[] { new OracleParameter("nombre",nombre),
                 new OracleParameter("direccion",direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("correo", correo),
                 new OracleParameter("fechaingreso", fechaIngreso),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

<<<<<<< HEAD
        public void ActualizarProveedor(int id, string nombre, string direccion, string
            telefono, string correo, string fechaIngreso)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_proveedor",
             new object[] { new OracleParameter("idproveedor",id),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("direccion",direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("correo", correo),
                 new OracleParameter("fechaingreso", fechaIngreso),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }


        public void EliminarProveedor(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_proveedor",
             new object[] { new OracleParameter("IdProveedor",id)
                });
            obj.desconectar();
        }
        #endregion

        #region Producto
=======
>>>>>>> origin/master

        public DataTable consultarProducto()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADOPRODUCTO");
        }

        public void insertarProducto(int IDCATEGORIA, int IDMARCA, string NOMBRE, string DESCRIPCION, string ESTADO)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_PRODUCTO",
             new object[] { new OracleParameter("IDCATEGORIA",IDCATEGORIA),
                 new OracleParameter("IDMARCA",IDMARCA),
                 new OracleParameter("NOMBRE",NOMBRE),
                 new OracleParameter("DESCRIPCION",DESCRIPCION),
                 new OracleParameter("ESTADO","1")
<<<<<<< HEAD
                 });
            obj.desconectar();
        }

=======

        public void ActualizarProveedor(int id, string nombre, string direccion, string
            telefono, string correo, DateTime fechaIngreso)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_proveedor",
             new object[] { new OracleParameter("idproveedor",id),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("direccion",direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("correo", correo),
                 new OracleParameter("fechaingreso", fechaIngreso),
                 new OracleParameter("estado","1")

                
                });
            obj.desconectar();
        }


>>>>>>> origin/master
        public void ActualizarProducto(int IdProducto, int IDCAT, int IDMAR, string NOM, string DES, string EST)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_PRODUCTO",
             new object[] { new OracleParameter("IdProducto",IdProducto),
                 new OracleParameter("IDCAT",IDCAT),
                 new OracleParameter("IDMAR",IDMAR),
                 new OracleParameter("NOM",NOM),
                 new OracleParameter("DES",DES),
                 new OracleParameter("EST","1")
                
                });
            obj.desconectar();
        }


        public void EliminarProducto(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_PRODUCTO",
             new object[] { new OracleParameter("IdProducto",id)
                });
            obj.desconectar();
        }
<<<<<<< HEAD
=======



        public void EliminarProveedor(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_proveedor",
             new object[] { new OracleParameter("IdProveedor",id)
                });
            obj.desconectar();
        }
>>>>>>> origin/master
        #endregion

    }
}
