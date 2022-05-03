using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
  public class RNUsuario
  {
    public void Registrar(Usuario usuario)
    {
      string sql = $@"INSERT INTO Usuario( CodigoPersonal, Nombre, Clave, Tipo, Vigente)
            VALUES({usuario.Personal.Codigo}, '{usuario.Nombre}', '{usuario.Clave}', 
            '{usuario.Tipo}', 1)";

      try
      {
        using (SqlConnection cn = new SqlConnection(
          ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
        {
          cn.Open();
          using (SqlCommand cmd = new SqlCommand(sql, cn))
          {
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

        public void Actualizar(Usuario usuario)
        {

            string sql = $@"UPDATE Usuario SET Nombre = '{ usuario.Nombre}', CodigoPersonal =
                '{usuario.Personal.Codigo}', Clave= '{ usuario.Clave }', Tipo = 
                '{usuario.Tipo}', Vigente = '{ (usuario.Vigente == true ? 1 : 0) }' WHERE Codigo ='{ usuario.Codigo}'";

            try
            {
                using (SqlConnection cn = new SqlConnection(
                  ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    public List<Usuario> Listar()
    {
      List<Usuario> usuarios = null;
      string sql = $@"SELECT U.Codigo, P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno, U.Nombre
            	FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
            	ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

      try
      {
        using(SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
        {
          cn.Open();
          using( SqlCommand cmd = new SqlCommand(sql, cn))
          {
            using( SqlDataReader dr = cmd.ExecuteReader())
            {
              usuarios = new List<Usuario>();
              while( dr.Read() == true)
              {
                usuarios.Add(
                  new Usuario { 
                    Codigo = dr.GetInt16( dr.GetOrdinal("Codigo")),
                    Nombre = dr.GetString( dr.GetOrdinal("Nombre")),
                    Personal = new Personal { 
                      Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                      ApellidoPaterno = dr.GetString( dr.GetOrdinal("ApellidoPaterno")),
                      ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))
                    }
                  }
                  );
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      return usuarios;
    }
       public Usuario Leer(int codigo)
       {
            Usuario usu = null;
            string sql = $@"SELECT U.Codigo,U.Nombre,U.Clave,U.Tipo,U.Vigente,P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno 
                FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
                WHERE U.Codigo ='{codigo}'";
            try
            {
                using (SqlConnection cn = new SqlConnection(
                   ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString
                  ))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read() == true)
                            {

                                usu = new Usuario
                                {
                                    Personal = new Personal
                                    {
                                        Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))
                                    },
                                    Codigo = codigo,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))

                                };

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usu;
        }
     }
}
