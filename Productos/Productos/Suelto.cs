using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Suelto:Producto
    {
        public Suelto()
        {
        }

        public Suelto(int codigo, string nombre, double precio,double medida) : base(codigo, nombre, precio)
        {
            this.Medida = medida;
        }

        public double Medida {  get; set; }


        public override double CalcularPrecio()
        {
            double total = Precio * Medida;
            return total;
        }
    }
}
