using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLibreria
{
    [Serializable]
    public abstract class Items:IComparable<Items>
    {
        public int Codigo {  get; set; }

        public int CompareTo(Items other)
        {
            if (other != null)
            {
                return Codigo.CompareTo(other.Codigo);
            }
            return 1;
        }

        public abstract string Descripcion();


        public abstract double Precio();

    }
}
