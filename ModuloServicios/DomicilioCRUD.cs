using DataBase_Manage;
using System.Data.SqlClient;
using System.Data;

namespace ModuloServicios
{
    public class DomicilioCRUD : IDomicilioCRUD
    {
        private readonly CD_Connection conn = new CD_Connection();

        public int AgregarDomicilio(string Idusuario, string Calle, string Estado, string Ciudad, string Pais, string CodigoPostal)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_InsertarDomicilio";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", Idusuario);
                    sqlCommand.Parameters.AddWithValue("@Calle", Calle);
                    sqlCommand.Parameters.AddWithValue("@Estado", Estado);
                    sqlCommand.Parameters.AddWithValue("@Ciudad", Ciudad);
                    sqlCommand.Parameters.AddWithValue("@Pais", Pais);
                    sqlCommand.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);

                    SqlParameter parameterIdDomicilio = new SqlParameter("@Id_Domicilio", SqlDbType.Int);
                    parameterIdDomicilio.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(parameterIdDomicilio);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();

                    // Obtener el valor de @Id_Domicilio después de ejecutar el procedimiento
                    int idDomicilio = (int)parameterIdDomicilio.Value;

                    Console.WriteLine("Domicilio agregado correctamente. Id_Domicilio: " + idDomicilio);

                    return idDomicilio;
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


    }
}
