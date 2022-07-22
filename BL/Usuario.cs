﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {





        public static ML.Result GetByEmail(string email)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "GetByEmail";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[0].Value = email;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        DataTable tablaUsuario = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tablaUsuario);

                        if (tablaUsuario.Rows.Count > 0)
                        {
                            DataRow row = tablaUsuario.Rows[0];

                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Email = row[0].ToString();
                            usuario.Password = row[1].ToString();
                            usuario.IdUsuario = int.Parse(row[2].ToString());


                            result.Object = usuario;
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
