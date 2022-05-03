using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Configuration;

namespace ReglasNegocio
{
  public class RNPersonal
  {
    // ingles: MM/dd/yyyy: 10/25/2020, 01/15/2020
    // español: dd/MM/yyyy: 25/10/2020, 15/01/2020
    // estándar: yyyyMMdd: 20201025, 20200115

    public void Registrar(Personal personal)
    {
      string sql = $@"INSERT INTO Personal( Nombres, ApellidoPaterno, ApellidoMaterno, DNI, 
                FechaNacimiento, Celular, Correo, Vigente)
            VALUES('{personal.Nombres}', '{personal.ApellidoPaterno}', '{personal.ApellidoMaterno}',
                '{personal.DNI}', '{personal.FechaNacimiento:yyyyMMdd}', '{personal.Celular}', 
                '{personal.Correo}', 1)";

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

    public void Actualizar(Personal personal)
    {
      
      string sql = $@"UPDATE Personal SET Nombres = '{personal.Nombres}', ApellidoPaterno = 
          '{ personal.ApellidoPaterno }', ApellidoMaterno = '{personal.ApellidoMaterno }', DNI =
          '{personal.DNI }', Celular = '{ personal.Celular }', Correo = '{personal.Correo}'
           , Vigente = '{(personal.Vigente == true ? 1 : 0) }' WHERE Codigo = '{personal.Codigo}'";

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

    public List<Personal> Listar()
    {
      List<Personal> trabajadores;
      string sql =
          @"SELECT P.Codigo, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.Celular, P.Correo
              FROM Personal P
              ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

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
              trabajadores = new List<Personal>();
              while (dr.Read() == true)
              {
                trabajadores.Add(
                    new Personal()
                    {
                      Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                      Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                      ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                      ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                      Correo = dr.GetString(dr.GetOrdinal("Correo")),
                      Celular = dr.GetString(dr.GetOrdinal("Celular"))
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

      return trabajadores;
    }

    public Personal Leer(int codigo)
    {
            Personal per=null;
            string sql = $@"SELECT P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.DNI, P.FechaNacimiento, P.Celular, P.Correo, P.Vigente
                FROM Personal P
                WHERE P.Codigo = '{codigo}'";
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

                                per = new Personal
                                {
                                    Codigo = codigo,
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                    FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
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
       return per;
    }

    public List<Personal> ListarVigentes()
    {
      List<Personal> trabajadores;
      string sql =
          @"SELECT P.Codigo, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres
              FROM Personal P
              WHERE P.Vigente = 1
              ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

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
              trabajadores = new List<Personal>();
              while (dr.Read() == true)
              {
                trabajadores.Add(
                    new Personal()
                    {
                      Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                      Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                      ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                      ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                      Vigente = true
                    }
                ) ;
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      return trabajadores;
    }


  }
}
