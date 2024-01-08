using System.Data.SqlClient;
using System.Data;
using DataBase_Manage;

namespace ModuloServicios
{
    public class CarritoCRUD : ICarritoCRUD
    {
        private readonly CD_Connection conn = new CD_Connection();

        public void AgregarServicio(string Idusuario, int IdProducto, int Cantidad)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_AgregarProductoAlCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", Idusuario);
                    sqlCommand.Parameters.AddWithValue("@Id_Producto", IdProducto);
                    sqlCommand.Parameters.AddWithValue("@Cantidad", Cantidad);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Servicio agregado correctamente.");
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

        public void EliminarServicio(string IdUsuario, int IdProducto)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_EliminarProductoDelCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);
                    sqlCommand.Parameters.AddWithValue("@Id_Producto", IdProducto);

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

        public void VaciarCarrito(string IdUsuario)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_EliminarTodoDelCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);

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

        public DataTable ObtenerProductosDelCarrito(string IdUsuario)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_ObtenerProductosDelCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);

                    // Crear un SqlDataAdapter para obtener los resultados del procedimiento almacenado
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        // Llenar un DataTable con los resultados
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
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

        public int ObtenerCantidadProductoEnCarrito(string IdUsuario, int IdProducto)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_CantidadProductoEnCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);
                    sqlCommand.Parameters.AddWithValue("@Id_Producto", IdProducto);

                    // Ejecutar el procedimiento almacenado y obtener el resultado
                    int cantidadEnCarrito = (int)sqlCommand.ExecuteScalar();
                    return cantidadEnCarrito;
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

        public decimal ObtenerValorTotalCarrito(string IdUsuario)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_SumarValorTotalCarrito";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);

                    // Ejecutar el procedimiento almacenado y obtener el resultado
                    decimal valorTotalCarrito = (decimal)sqlCommand.ExecuteScalar();
                    return valorTotalCarrito;
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

        public int InsertarOrdenPago(string IdUsuario, int IdDomicilio, int IdPago, decimal Total)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_InsertarOrdenPago";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_Usuario", IdUsuario);
                    sqlCommand.Parameters.AddWithValue("@Id_Domicilio", IdDomicilio);
                    sqlCommand.Parameters.AddWithValue("@Id_Pago", IdPago);
                    sqlCommand.Parameters.AddWithValue("@Total", Total);
                    
                    // Parámetro de salida para obtener el Id_OrdenPago
                    SqlParameter parameterIdOrdenPago = new SqlParameter("@Id_OrdenPago", SqlDbType.Int);
                    parameterIdOrdenPago.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(parameterIdOrdenPago);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();

                    // Obtener el valor de @Id_OrdenPago después de ejecutar el procedimiento
                    int idOrdenPago = (int)parameterIdOrdenPago.Value;

                    Console.WriteLine("Orden de pago agregada correctamente. Id_OrdenPago: " + idOrdenPago);

                    return idOrdenPago;
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


        public int InsertarDetalleOrdenPago(int IdOrdenPago, int IdProducto, int Cantidad)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_InsertarDetalleOrdenPago";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_OrdenPago", IdOrdenPago);
                    sqlCommand.Parameters.AddWithValue("@Id_Producto", IdProducto);
                    sqlCommand.Parameters.AddWithValue("@Cantidad", Cantidad);

                    // Parámetro de salida para obtener el Id_DetalleOrdenPago
                    SqlParameter parameterIdDetalleOrdenPago = new SqlParameter("@Id_DetalleOrdenPago", SqlDbType.Int);
                    parameterIdDetalleOrdenPago.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(parameterIdDetalleOrdenPago);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();

                    // Obtener el valor de @Id_DetalleOrdenPago después de ejecutar el procedimiento
                    int idDetalleOrdenPago = (int)parameterIdDetalleOrdenPago.Value;

                    Console.WriteLine("Detalle de orden de pago agregado correctamente. Id_DetalleOrdenPago: " + idDetalleOrdenPago);

                    return idDetalleOrdenPago;
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

        public void InsertarFactura(int IdDetalleOrdenPago, DateTime FechaEmision, string EstadoPago)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    // Asignar la conexión
                    sqlCommand.Connection = conn.OpenConnection();
                    sqlCommand.CommandText = "sp_InsertarFactura";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    sqlCommand.Parameters.AddWithValue("@Id_DetalleOrdenPago", IdDetalleOrdenPago);
                    sqlCommand.Parameters.AddWithValue("@FechaEmision", FechaEmision);
                    sqlCommand.Parameters.AddWithValue("@EstadoPago", EstadoPago);

                    // Ejecutar el procedimiento almacenado
                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine("Factura agregada correctamente.");
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

