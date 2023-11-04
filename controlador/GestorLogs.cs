using modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace controlador
{
    internal class GestorLogs
    {
        string controlador;    //Se le asigna el nombre del usuario que se logeo

        // Método para registrar actividades del usuario
        public void RegistrarLog(string usuario, string accion)
        {
            if (!Directory.Exists("C:\\Users\\Luis\\Documents\\Logs"))
            {
                Directory.CreateDirectory("Logs");
            }

            try
            {
                // Crea un nuevo archivo o sobrescribe el archivo si ya existe
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Luis\\Documents\\Logs\\archivo.txt", true))
                {
                    // Escribe el texto en el archivo
                    writer.WriteLine($"Usuario: {controlador}, Acción: {accion}, Fecha: {DateTime.Now}");
                }

                Console.WriteLine("Texto almacenado en el archivo correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }

    }
}
