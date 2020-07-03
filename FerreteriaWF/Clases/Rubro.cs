using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaWF.Clases
{
    public class Rubro
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Rubro() { }
        public Rubro(string s)
        {
            nombre = s;
        }
    }
}
