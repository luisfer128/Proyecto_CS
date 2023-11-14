using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using DataBase_Manage;
using ModuloSeguridad;

namespace ModuloRegistro
{
    public class OperacionesCRUD: IOperacionesCRUD
    {
        private readonly CD_Connection conn = new CD_Connection();
        private Encriptador encriptar = new Encriptador();

        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "InsertarUsuario";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", nuevoUsuario.id);
                    sqlCommand.Parameters.AddWithValue("@Nombre", nuevoUsuario.nombre);
                    sqlCommand.Parameters.AddWithValue("@Apellido", nuevoUsuario.apellido);
                    sqlCommand.Parameters.AddWithValue("@User", nuevoUsuario.usuario);
                    sqlCommand.Parameters.AddWithValue("@Contraseña", encriptar.Encriptar(nuevoUsuario.contraseña));
                    sqlCommand.Parameters.AddWithValue("@Rol", nuevoUsuario.rol);
                    sqlCommand.Parameters.AddWithValue("@Direccion", nuevoUsuario.direccion);
                    sqlCommand.Parameters.AddWithValue("@Telefono", nuevoUsuario.telefono);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Usuario agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, puedes agregar lógica para registrar el error o mostrar un mensaje al usuario
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
                
        public void ActualizarUsuario(string id_usuario,string nombre, string apellido, string contraseña, string rol, string direccion,char estado, string telefono)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "ActualizarUsuario";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdUsuario", id_usuario);
                    sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
                    sqlCommand.Parameters.AddWithValue("@Apellido", apellido);
                    sqlCommand.Parameters.AddWithValue("@Contraseña", encriptar.Encriptar(contraseña));
                    sqlCommand.Parameters.AddWithValue("@Rol", rol);
                    sqlCommand.Parameters.AddWithValue("@Direccion", direccion);
                    sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
                    sqlCommand.Parameters.AddWithValue("@Estado", estado);

                    // Ejecutar el Stored Procedure
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public void EliminarUsuario(string idUsuario)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "EliminarUsuario";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    // Ejecutar el Stored Procedure
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public List<Usuario> SelectUsuarios()
        {
            DataTable dataTable = new DataTable();
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "SelectUsuarios";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        // Llenar el DataTable con los resultados del Stored Procedure
                        dataAdapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario us = new Usuario()
                    {
                        id = row["Id_Usuario"].ToString(),
                        usuario = row["User"].ToString(),
                        nombre = row["Nombre"].ToString(),
                        apellido = row["Apellido"].ToString(),
                        contraseña = row["Contraseña"].ToString(),
                        rol = row["Rol"].ToString(),
                        direccion = row["Direccion"].ToString(),
                        telefono = row["Telefono"].ToString(),
                        estado = Convert.ToChar(row["Estado"])
                    };
                    usuarios.Add(us);       
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                // Manejo de errores, puedes agregar lógica para registrar el error o mostrar un mensaje al usuario
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
