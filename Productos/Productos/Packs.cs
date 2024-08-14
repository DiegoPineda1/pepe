using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Packs : Producto
    {
        public Packs()
        {
        }

        public Packs(int codigo, string nombre, double precio,int ccantidad) : base(codigo, nombre, precio)
        {
            this.Cantidad = ccantidad;
        }

        public int Cantidad {  get; set; }


        public override double CalcularPrecio()
        {
            double total = Precio * Cantidad;
            return total;
        }

        





    }
}
