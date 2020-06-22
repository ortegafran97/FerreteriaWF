using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace FerreteriaWF
{
    class ConexionBD
    {
        /**TODO: Para que funcione deben cambiar 
         * Username (si usan otro que sea 'postgres'), 
         * Password (con la que hayan asignado ustedes a su cuenta)
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
                Console.WriteLine("Conectado a BD: "+ conection.Database + " como usuario "+ conection.UserName);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error de conexion: "+ e.Message);
            }
        }

        public bool Estado()
        {
            //Retorna true si la db esta conectada
            return (conection.State == System.Data.ConnectionState.Open);
        }
        public void Cerrar()
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

    }
}
