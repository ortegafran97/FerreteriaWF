using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaWF.Clases
{
    public class Proveedor
    {
        string cuit, nombre, direccion;
        public string CUIT
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre= value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}
