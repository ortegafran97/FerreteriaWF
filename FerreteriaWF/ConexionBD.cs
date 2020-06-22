using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace FerreteriaWF
{
    class ConexionBD
    {
        /**TODO: Para que funcione deben cambiar 
         * 1. Username (si usan otro que sea 'postgres'), 
         * 2. Password (con la que hayan asignado ustedes a su cuenta)
         * y DataBase (si no se llama igual)
        */
        private string stringConnection = "Username= postgres; Password = Burro.2909; Host= localhost;Port =5432 ; Database = Ferreteria";
        private NpgsqlConnection conection;

        public ConexionBD()
        {
            try
            {
                conection = new NpgsqlConnection(stringConnection);
                conection.Open();
                Console.WriteLine("Conectado a BD: "+ conection.Database + "\nUsuario: "+ conection.UserName);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error de conexion: "+ e.Message);
            }
        }

        public bool Estado() //Retorna true si la db esta conectada
        {
            
            return (conection.State == System.Data.ConnectionState.Open);
        } 
        public void Cerrar() // Cierra la conexion con la BD
        {
            if(conection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string nom = conection.Database;
                    conection.Close();
                    Console.WriteLine("Desconectado de la BD: "+ nom);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error de desconexion: " + e.Message);
                }
            }
        }     
        
        public DataTable Rubros()
        {
            //Retorna todos los rubros
            DataTable rubros = new DataTable();
            string consulta = "SELECT * FROM Rubro;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {   
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(rubros);
                return rubros;
            }
            catch(Exception e)
            {
                //En caso de error devuelve una tabla vacia
                Console.WriteLine("Error de consulta: "+e.Message );
                return new DataTable();
            }            
        }

        public DataTable Proveedores()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Proveedor;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                //En caso de error devuelve una tabla vacia
                Console.WriteLine("Error de consulta: " + e.Message);
                return new DataTable();
            }
        }

        public DataTable Productos()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Producto;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                //En caso de error devuelve una tabla vacia
                Console.WriteLine("Error de consulta: " + e.Message);
                return new DataTable();
            }
        }

    }
}
