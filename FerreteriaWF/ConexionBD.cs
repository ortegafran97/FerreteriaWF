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
         * 1. Username (si usan otro que no sea 'postgres'), 
         * 2. Password (con la que hayan asignado ustedes a su cuenta)
         * y DataBase (si no se llama igual)
        */
        public string stringConnection = "Username= postgres; Password = 123; Host= localhost;Port =5432 ; Database = Ferreteria";
        public NpgsqlConnection conection;

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

        public Producto Producto(string s)
        {
            string consulta = "SELECT * FROM producto " +
                                "where nombreproducto = '" + s + "'" +
                                "limit 1;";
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
                DataTable tabla = new DataTable();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd);
                adp.Fill(tabla);
                DataRow dr = tabla.Rows[0];
                Producto x = new Producto(dr);
                return x;
            }
            catch(Exception e)
            {
                Console.WriteLine("No se pudo crear Producto");
                return null;
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
            string consulta = "Select * from compra natural join proveedor order by fecha desc limit 20;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            try
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                Console.WriteLine("Consulta realizada: ultimas compras");
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de consulta: " + e.Message);
                return new DataTable();
            }
        }

        public void NuevaCompra(Compra compra)
        {           
            try
            {
                string consultaid = "select count(*) from compra";
                NpgsqlCommand cmdID = new NpgsqlCommand(consultaid, conection);
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmdID);
                DataTable id = new DataTable();
                adp.Fill(id);
                int idCompra = int.Parse(id.Rows[0]["count"].ToString())+1;                
                string insert = "INSERT INTO compra VALUES ("+idCompra+",'"+compra.CUIT+"','"+ NpgsqlTypes.NpgsqlDateTime.Now.ToDateTime().ToShortDateString() + "',"+compra.Total+");";
                NpgsqlCommand cmdCompra = new NpgsqlCommand(insert, conection);
                if (cmdCompra.ExecuteNonQuery() > 0)
                {
                    foreach (DetalleCompra detalle in compra.Items)
                    {
                        string insertDetalle = "INSERT INTO detallecompra values (" + idCompra + "," + detalle.Idproducto + "," + detalle.Cantidad + "," + detalle.Precio + ");";
                        NpgsqlCommand cmdDet = new NpgsqlCommand(insertDetalle, conection);
                        cmdDet.ExecuteNonQuery();

                        string updateString = "UPDATE producto " +
                                            "set cantidad = cantidad + "+detalle.Cantidad +
                                            " where idprod = "+detalle.Idproducto+";";
                        NpgsqlCommand cmdUp = new NpgsqlCommand(updateString, conection);
                        cmdUp.ExecuteNonQuery();

                    }
                    Console.WriteLine("Insertada Compra y DetalleCompra's");
                }
                else
                {
                    Console.WriteLine("No se inserto la compra");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo al registrar nueva compra: {0}", e.Message);
                return;
            }

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
        public int InsertRubro(string nombre)
        {
            string consulta = "INSERT into Rubro VALUES ('" + nombre + "');";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            cmd.ExecuteNonQuery();
            return 1;
        }

        public string CUIT(string proveedor)
        {
            string consulta = "select * from proveedor where nombre ='" + proveedor + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta,conection);
            try
            {
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt.Rows[0]["cuit"].ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine("Fallo al encontrar CUIT: {0}", e.Message);
                return "";
            }
        }

        public DataTable CompraDetalle()
        {
            DataTable dt = new DataTable();
            string consulta = "select nombreproducto,d.cantidad,d.precio from detallecompra as d full outer join producto as p on p.idprod = d.idproducto;";
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine("Fallo al obtener Compras join DetalleCompra: {0}",e.Message);
                return dt;
            }
        }


    }
}
