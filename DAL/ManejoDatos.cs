﻿using System;
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

    }
}