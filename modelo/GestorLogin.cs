using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using DataBase_Manage;

namespace ModuloSeguridad
{
    public class GestorLogin : IGestorLogin
    {
        private readonly CD_Connection conn = new CD_Connection();
        private Encriptador ed = new Encriptador();

        public Usuario Login(string usuario, string contraseña)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        // Asignar la conexión
                        sqlCommand.Connection = conn.OpenConnection();
                        sqlCommand.CommandText = "ObtenerUsuario";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@UsuarioIngresado", usuario);

                        // Llamamos al constructor del data adapter
                        dataAdapter.SelectCommand = sqlCommand;

                        // Verificar que la conexión esté abierta antes de llamar a Fill
                        if (conn.OpenConnection().State == ConnectionState.Open)
                        {
                            // Asignar el dataAdapter al DataTable
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }

                // Verificar si se encontró un usuario
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string idUsuario = row["Id_Usuario"].ToString();
                    string rol = row["Rol"].ToString();

                    // Aquí puedes comparar la contraseña (deberías usar lógica segura para comparar contraseñas)
                    if (row["Contraseña"].ToString() == ed.Encriptar(contraseña))
                    {
                        // Autenticación exitosa, devuelve el usuario autenticado
                        return new Usuario { id = idUsuario, Rol = rol };
                    }
                }

                // Autenticación fallida
                return null;
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

