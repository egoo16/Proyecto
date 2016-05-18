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

=======
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
                 });
            obj.desconectar();
        }


>>>>>>> origin/master
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

<<<<<<< HEAD

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
                  });
            obj.desconectar();
        }

=======
>>>>>>> origin/master
        public void ActualizarProducto(int IdProducto, int IDCAT, int IDMAR, string NOM, string DES, string EST)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_PRODUCTO",
             new object[] { new OracleParameter("IdPro",IdProducto),
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

        #endregion

        #region Marca
        public DataTable ConsultarMarca()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADOMARCA");
        }

        public void InsertarMarca(string NOMBRE, string ESTADO)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_MARCA",
             new object[] { 
                 new OracleParameter("NOMBRE",NOMBRE),
                 new OracleParameter("ESTADO","1")
                  });
            obj.desconectar();
        }
        
        public void ActualizarMarca(int IDMAR, string NOM, string EST)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_MARCA",
             new object[] { 
                 new OracleParameter("IdMarca",IDMAR),
                 new OracleParameter("NOMBRE",NOM),
                 new OracleParameter("EST","1")
                
                });
            obj.desconectar();
        }

        
        public void EliminarMarca(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_MARCA",
             new object[] { new OracleParameter("IdMarca",id)
                });
            obj.desconectar();
        }
        
        #endregion

        #region Presentacion
        public DataTable Consultarpresentacion()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_PRES");
        }

        public void InsertarPres(string NOMBRE, string Descripcion)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_PRES",
             new object[] { 
                 new OracleParameter("NOMBRE",NOMBRE),
                 new OracleParameter("DESCRIPCION",Descripcion),
                 new OracleParameter("ESTADO","1")
                  });
            obj.desconectar();
        }

        public void ActualizarPres(int IdPres, string Nombre, string Descripcion)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_PRES",
             new object[] { 
                 new OracleParameter("IdPres",IdPres),
                 new OracleParameter("NOMBRE",Nombre),
                 new OracleParameter("DESCRIPCION",Descripcion),
                 new OracleParameter("ESTADO","1")
                
                });
            obj.desconectar();
        }


        public void EliminarPres(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_PRES",
             new object[] { new OracleParameter("IdPres",id)
                });
            obj.desconectar();
        }

        #endregion

        #region CuentaPagar
        public DataTable ConsultaCuentaP()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_CUENTAPAGAR");
        }
        //IDDETALLEC IN INTEGER, FECHACOMPRA IN DATE, FECHALIMITE IN DATE, MONTO IN DECIMAL, SALDO IN DECIMAL, LIQUIDADO IN VARCHAR2, ESTADO IN VARCHAR2)
        public void InsertarCuentaP(int detalle, DateTime fechaC, DateTime FechaL, Decimal monto, Decimal saldo, string Liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_CUENTAPAGAR",
             new object[] { new OracleParameter("IDDETALLEC",detalle),
                 new OracleParameter("FECHACOMPRA",fechaC),
                 new OracleParameter("FECHALIMITE",FechaL),
                 new OracleParameter("MONTO",monto),
                 new OracleParameter("SALDO",saldo),
                 new OracleParameter("LIQUIDADO",Liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarCuentaP(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_CUENTAPAGAR",
             new object[] { new OracleParameter("IdCuentaP",id)
                });
            obj.desconectar();
        }
        #endregion

        #region AbonoC
        public DataTable ConsultarAbonoC()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_ABONOC");
        }
        //FECHA IN DATE, MONTO IN DECIMAL, ESTADO IN VARCHAR2
        public void InsertarAbonoC(DateTime fecha, Decimal monto)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_ABONOC",
             new object[] { new OracleParameter("FECHA",fecha),
                 new OracleParameter("MONTO",monto),
                 new OracleParameter("ESTADO","1")
                
                });
            obj.desconectar();
        }
        //IdAbonoC IN INTEGER,IDCUENTAP IN INTEGER, FECHA IN DATE, MONTO IN DECIMAL, ESTADO IN VARCHAR2
        public void ActualizarAbonoC(int IdAbono, int cuenta, DateTime fecha, Decimal monto)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_ABONOC",
             new object[] { new OracleParameter("IdAbonoC",IdAbono),
                 new OracleParameter("IDCUENTAP",cuenta),
                 new OracleParameter("FECHA",fecha),
                 new OracleParameter("MONTO",monto),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }


        public void EliminarAbonoC(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_ABONOC",
             new object[] { new OracleParameter("IdAbonoC",id)
                });
            obj.desconectar();
        }
        #endregion

        #region DetalleC
        public DataTable ConsultarDetalleC()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_DETALLEC");
        }
        //IDCOMPRA IN INTEGER, IDPRODPRES IN INTEGER, CANTIDAD IN DECIMAL, DESCUENTO IN DECIMAL, PRECIO IN DECIMAL, TOTAL IN DECIMAL)
        public void insertarDetalleC(int compra, int prod, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_DETALLEC",
             new object[] { new OracleParameter("IDCOMPRA",compra),
                 new OracleParameter("IDPRODPRES",prod),
                 new OracleParameter("CANTIDAD",cantidad),
                 new OracleParameter("DESCUENTO",descuento),
                 new OracleParameter("PRECIO",precio),
                 new OracleParameter("TOTAL",total)
                
                });
            obj.desconectar();
        }

        public void ActualizarDetalleC(int iddetalle,int compra, int prod, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_DETALLEC",
             new object[] { new OracleParameter("IdDetalleC",iddetalle),
                 new OracleParameter("IDCOMPRA",compra),
                 new OracleParameter("IDPRODPRES",prod),
                 new OracleParameter("CANTIDAD",cantidad),
                 new OracleParameter("DESCUENTO",descuento),
                 new OracleParameter("PRECIO",precio),
                 new OracleParameter("TOTAL",total)
                
                });
            obj.desconectar();
        }

        #endregion

        #region ProdPres
        public DataTable ConsultarProdPres()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_PRODPRES");
        }
        //IDPRODUCTO IN INTEGER, IDPRES IN INTEGER, PRECIOCOMPRA IN DECIMAL, PRECIOVENTA IN DECIMAL, CANTIDADEXISTENCIA IN DECIMAL, IMAGEN IN BLOB, IDBARRAS IN VARCHAR2, ESTADO IN VARCHAR2)
        public void InsertarProdPres(int prod, int pres, decimal precioc, decimal preciov, decimal existencia, byte imagen, string barras)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_PRODPRES",
             new object[] { new OracleParameter("IDPRODUCTO",prod),
                 new OracleParameter("IDPRES",pres),
                 new OracleParameter("PRECIOCOMPRA",precioc),
                 new OracleParameter("PRECIOVENTA",preciov),
                 new OracleParameter("CANTIDADEXISTENCIA",existencia),
                 new OracleParameter("IMAGEN",imagen),
                 new OracleParameter("IDBARRAS",barras),
                 new OracleParameter("ESTADO","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarProdPres(int idprodpres, int prod, int pres, decimal precioc, decimal preciov, decimal existencia, byte imagen, string barras)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ACTUALIZAR_PRODPRES",
             new object[] { new OracleParameter("IdProdPres",idprodpres),
                 new OracleParameter("IDPRODUCTO",prod),
                 new OracleParameter("IDPRES",pres),
                 new OracleParameter("PRECIOCOMPRA",precioc),
                 new OracleParameter("PRECIOVENTA",preciov),
                 new OracleParameter("CANTIDADEXISTENCIA",existencia),
                 new OracleParameter("IMAGEN",imagen),
                 new OracleParameter("IDBARRAS",barras),
                 new OracleParameter("ESTADO","1")
                
                });
            obj.desconectar();
        }


        public void EliminarProdPres(int id)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("ELIMINAR_PRODPRES",
             new object[] { new OracleParameter("IdProdPres",id)
                });
            obj.desconectar();
        }
        #endregion

        //Chalio

        #region Caja
        public DataTable consultarCaja()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_caja");
        }

        public void insertarCaja(int idusuario, string descripcion, decimal cantidadinicial, decimal cantidadfinal, DateTime fecha)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_caja",
             new object[] { new OracleParameter("idusario",idusuario),
                 new OracleParameter("descripcion",descripcion),
                 new OracleParameter("cantidadinicial", cantidadinicial),
                 new OracleParameter("cantidadfinal", cantidadfinal),
                 new OracleParameter("fecha", fecha),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarCaja(int idcaja, int idusuario, string descripcion, decimal cantidadinicial, decimal cantidadfinal, DateTime fecha)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_caja",
             new object[] { new OracleParameter("idcaja",idcaja),
                 new OracleParameter("idusuario",idusuario),
                 new OracleParameter("descripcion",descripcion),
                 new OracleParameter("cantidadinicial", cantidadinicial),
                 new OracleParameter("cantidadfinal", cantidadfinal),
                 new OracleParameter("fechaingreso", fecha),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarCaja(int idcaja)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_caja",
             new object[] { new OracleParameter("IdCaja",idcaja)
                });
            obj.desconectar();
        }
        #endregion

        #region Rol
        public DataTable consultarRol()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("LISTADO_ROL");
        }

        public void insertarRol(string nombre)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("INSERTAR_ROL",
             new object[] { new OracleParameter("nombre",nombre),
                new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarRol(int idrol, string nombre)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_rol",
             new object[] { new OracleParameter("idrol",idrol),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarRol(int idrol)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_rol",
             new object[] { new OracleParameter("IdRol",idrol)
                });
            obj.desconectar();
        }
        #endregion

        #region Compra
        public DataTable consultarCompra()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_compra");
        }

        public void insertarCompra(int idusuario, int idproveedor, int idpago, DateTime fechacompra, decimal total, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_compra",
             new object[] { new OracleParameter("idusuario", idusuario),
                 new OracleParameter("idproveedor",idproveedor),
                 new OracleParameter("idpago", idpago),
                 new OracleParameter("fechacompra", fechacompra),
                 new OracleParameter("total", total),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarCompra(int idcompra, int idusuario, int idproveedor, int idpago, DateTime fechacompra, decimal total, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_compra",
             new object[] { new OracleParameter("idcompra",idcompra),
                 new OracleParameter("idusuario",idusuario),
                 new OracleParameter("idproveedor",idproveedor),
                 new OracleParameter("idpago", idpago),
                 new OracleParameter("fechacompra", fechacompra),
                 new OracleParameter("total", total),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarCompra(int idcompra)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_compra",
             new object[] { new OracleParameter("IdCompra",idcompra)
                });
            obj.desconectar();
        }
        #endregion

        #region Usuario
        public DataTable consultarUsuario()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_usuario");
        }

        public void insertarUsuario(int idrol, string nombre, string apellido, string direccion, string telefono, string dpi, DateTime fechaingreso, string nomusuario, string clave)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_rol",
             new object[] { new OracleParameter("idrol",idrol),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("apellido", apellido),
                 new OracleParameter("direccion", direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("dpi", dpi),
                 new OracleParameter("fechaingreso", fechaingreso),
                 new OracleParameter("nomusuario", nomusuario),
                 new OracleParameter("clave", clave),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarUsuario(int idusuario, int idrol, string nombre, string apellido, string direccion, string telefono, string dpi, DateTime fechaingreso, string nomusuario, string clave)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_usuario",
             new object[] { new OracleParameter("idusuario",idusuario),
                 new OracleParameter("idrol", idrol),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("apellido", apellido),
                 new OracleParameter("direccion", direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("dpi", dpi),
                 new OracleParameter("fechaingreso", fechaingreso),
                 new OracleParameter("nomusuario", nomusuario),
                 new OracleParameter("clave", clave),
                 new OracleParameter("estado","1")              
                });
            obj.desconectar();
        }

        public void EliminarUsuario(int idusuario)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_usuario",
             new object[] { new OracleParameter("IdUsuario",idusuario)
                });
            obj.desconectar();
        }
        #endregion

        #region Cliente
        public DataTable consultarCliente()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_cliente");
        }

        public void insertarCliente(string nombre, string apellido, string direccion, string telefono, string nit, DateTime fechaingreso, string mayorista, string idmayorista)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_cliente",
             new object[] { new OracleParameter("nombre",nombre),
                 new OracleParameter("apellido",apellido),
                 new OracleParameter("direccon", direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("nit",nit),
                 new OracleParameter("fechaingreso", fechaingreso),
                 new OracleParameter("mayorista", mayorista),
                 new OracleParameter("idmayorista", idmayorista),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarCliente(int idcliente, string nombre, string apellido, string direccion, string telefono, string nit, DateTime fechaingreso, string mayorista, string idmayorista)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_cliente",
             new object[] { new OracleParameter("idcliente",idcliente),
                 new OracleParameter("nombre",nombre),
                 new OracleParameter("apellido",apellido),
                 new OracleParameter("direccion", direccion),
                 new OracleParameter("telefono", telefono),
                 new OracleParameter("nit", nit),
                 new OracleParameter("fechaingreso", fechaingreso),
                 new OracleParameter("mayorista", mayorista),
                 new OracleParameter("idmayorista", idmayorista),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarCliente(int idcliente)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_cliente",
             new object[] { new OracleParameter("IdCliente",idcliente)
                });
            obj.desconectar();
        }
        #endregion

        #region DetalleV
        public DataTable consultarDetalleV()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_detallev");
        }

        public void insertarDetalleV(int idfactura, int idprodpres, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_detallev",
             new object[] { new OracleParameter("idfactura",idfactura),
                 new OracleParameter("idprodpres",idprodpres),
                 new OracleParameter("cantidad", cantidad),
                 new OracleParameter("descuento", descuento),
                 new OracleParameter("precio", precio),
                 new OracleParameter("total",total),
                  });
            obj.desconectar();
        }

        public void ActualizarDetalleV(int iddetallev, int idfactura, int idprodpres, decimal cantidad, decimal descuento, decimal precio, decimal total)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_detalled",
             new object[] { new OracleParameter("iddetallev", iddetallev),
                 new OracleParameter("idfactura",idfactura),
                 new OracleParameter("idprodpres",idprodpres),
                 new OracleParameter("cantidad", cantidad),
                 new OracleParameter("descuento", descuento),
                 new OracleParameter("precio", precio),
                 new OracleParameter("total", total)
                
                });
            obj.desconectar();
        }

        public void EliminarDetalleV(int iddetallev)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_detallev",
             new object[] { new OracleParameter("Iddetallev",iddetallev)
                });
            obj.desconectar();
        }
        #endregion

        #region Factura
        public DataTable consultarFactura()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_factura");
        }

        public void insertarFactura(int idusuario, int idcliente, int idpago, string serie, string correlativo, DateTime fechafactura, decimal total, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_factura",
             new object[] { new OracleParameter("idusuario",idusuario),
                 new OracleParameter("icliente",idcliente),
                 new OracleParameter("idpago", idpago),
                 new OracleParameter("serie", serie),
                 new OracleParameter("correlativo", correlativo),
                 new OracleParameter("fechafactura", fechafactura),
                 new OracleParameter("total", total),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarFactura(int idfactura, int idusuario, int idcliente, int idpago, string serie, string correlativo, DateTime fechafactura, decimal total, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_factura",
             new object[] { new OracleParameter("idfactura",idfactura),
                 new OracleParameter("idusuario",idusuario),
                 new OracleParameter("idcliente",idcliente),
                 new OracleParameter("idpago", idpago),
                 new OracleParameter("serie", serie),
                 new OracleParameter("fechafactura", fechafactura),
                 new OracleParameter("total", total),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarFactura(int idfactura)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_factura",
             new object[] { new OracleParameter("IdFactura",idfactura)
                });
            obj.desconectar();
        }
        #endregion

        #region CuentaCobrar
        public DataTable consultarCuentaCobrar()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_cuentacobrar");
        }

        public void insertarCuentaCobrar(int iddetallev, DateTime fechainicio, DateTime fechalimite, decimal monto, decimal saldo, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_cuentacobrar",
             new object[] { new OracleParameter("iddetallev", iddetallev),
                 new OracleParameter("fechainicio", fechainicio),
                 new OracleParameter("fechalimite", fechalimite),
                 new OracleParameter("monto", monto),
                 new OracleParameter("saldo", saldo),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarCuentaCobrar(int idcuentac, int iddetallev, DateTime fechainicio, DateTime fechalimite, decimal monto, decimal saldo, string liquidado)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_cuentacobrar",
             new object[] { new OracleParameter("idcuentac",idcuentac),
                 new OracleParameter("iddetallev",iddetallev),
                 new OracleParameter("fechainicio",fechainicio),
                 new OracleParameter("fechalimite", fechalimite),
                 new OracleParameter("monto", monto),
                 new OracleParameter("saldo", saldo),
                 new OracleParameter("liquidado", liquidado),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarCuentaCobrar(int idcuentac)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_cuentacobrar",
             new object[] { new OracleParameter("Idcuentacobrar",idcuentac)
                });
            obj.desconectar();
        }
        #endregion

        #region Abono
        public DataTable consultarAbono()
        {
            Conexion obj = new Conexion(this.oCadena);
            return obj.consultarOut("listado_abono");
        }

        public void insertarAbono(int idcuentac, DateTime fecha, decimal monto)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("insertar_cuentacobrar",
             new object[] { new OracleParameter("idcuentac", idcuentac),
                 new OracleParameter("fecha", fecha),
                 new OracleParameter("decimal", fecha),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void ActualizarAbono(int idabono, int idcuentac, DateTime fecha, decimal monto)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("actualizar_abono",
             new object[] { new OracleParameter("idabono",idcuentac),
                 new OracleParameter("idcuentac",idcuentac),
                 new OracleParameter("fecha",fecha),
                 new OracleParameter("monto", monto),
                 new OracleParameter("estado","1")
                
                });
            obj.desconectar();
        }

        public void EliminarAbono(int idabono)
        {
            Conexion obj = new Conexion(this.oCadena);
            obj.conectar();
            obj.ejecutarTransaccion("eliminar_abono",
             new object[] { new OracleParameter("Idabono",idabono)
                });
            obj.desconectar();
        }
        #endregion



=======
        #endregion

>>>>>>> origin/master
    }
}
