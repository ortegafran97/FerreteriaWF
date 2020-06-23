using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using FerreteriaWF.Clases;


namespace FerreteriaWF
{
    public class ConexionBD
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
        public List<string> RubrosProveedor(string nombre) // Devuelve todas los rubros que el proveedor {Nombre} trabaje
        {
            string consulta = "select nombrerubro from vende natural join proveedor natural join rubro where nombre = '" + nombre + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                DataTable rubros = new DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                adap.Fill(rubros);

                List<string> lista = new List<string>();
                for(int i=0;i<rubros.Rows.Count;i++)
                {
                    lista.Add(rubros.Rows[i]["nombrerubro"].ToString());
                }
                return lista;
            }
            catch(Exception e)
            {
                return null;
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

        public Producto Producto(int id) //BUSCA POR ID
        {
            string consulta = "Select * from Producto where idprod = " + id+";";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    /*El elemento ya existe*/
                    DataRow prod = dt.Rows[0];
                    return new Producto(prod);
                }
                else
                {
                    /*El elemento NO existe*/
                    return null;
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public DataTable Productos() // LISTADO DE PRODUCTOS
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

        public DataTable UltimasCompras(int cantidad)
        {
            string consulta = "Select * from compras natural join proveedor order  by fecha desc limit " + cantidad + ";";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error de consulta: " + e.Message);
                return new DataTable();
            }
        }
        public DataTable UltimasCompras()
        {
            string consulta = "Select * from compra natural join proveedor order  by fecha desc limit 20;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de consulta: " + e.Message);
                return new DataTable();
            }
        }

        public void NuevaCompra(Clases.Producto p)
        {
            /**
             * Compramos X cantidad de un producto -> si no teniamos el producto crear nuevo,
             * si ya lo teniamos sumar el nuevo stock
             */  
        }

        public DataTable VendedoresDeProducto(string nombreProd)
        {
            string consulta = "select nombre,precio from producto natural join rubro natural join vende natural join proveedor where nombreproducto='" + nombreProd + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd);
                DataTable proveedoresPrecio = new DataTable();
                adp.Fill(proveedoresPrecio);
                return proveedoresPrecio;                
            }
            catch(Exception e)
            {
                Console.WriteLine("Fallo en consulta -> VendedoresDeProducto: {0}", e.Message);
                return null;
            }
        }


    }
}
