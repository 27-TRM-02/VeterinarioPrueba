using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario_TRM
{
    class Conexion
    {
        //variable que se encarga de conectarnos al servidor MySql
        public MySqlConnection bbdd;

        public Conexion()
        {
            // Conexión con la base de datos MySql
            bbdd = new MySqlConnection("Server = 127.0.0.1; Database = test; Uid = root; Pwd =; Port = 3306");
        }

        public Boolean loginVeterinario(String _DNI, String _password)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE DNI = @_DNI ", bbdd);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);

                //guardo el resultado de la query
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    String passConHash = resultado.GetString("password");
                    if (BCrypt.Net.BCrypt.Verify(_password, passConHash))
                    {
                        bbdd.Close();
                        return true;
                    }
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean altaUsuario(String _DNI, String _Nombre, String _Apellido, String _password, String _email)
        {
            try
            {
                bbdd.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuario (DNI, Nombre, Apellido, password, email, perfil) VALUES (@_DNI, @_Nombre, @_Apellido, @_password, @_email, 0) ", bbdd);

                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_Apellido", _Apellido);
                consulta.Parameters.AddWithValue("@_password", _password);
                consulta.Parameters.AddWithValue("@_email", _email);

                // Devuelve el numero de filas que se han añadido
                int resultado = consulta.ExecuteNonQuery();

                if (resultado > 0)
                {
                    // se ha realizado bien el alta
                    bbdd.Close();
                    return true;
                }

                bbdd.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }
        }

    }
}
