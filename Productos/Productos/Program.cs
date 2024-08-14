using Productos;

class Program
{
    static void Main(string[] args)
    {
        List<Producto> lst = new List<Producto>();
        

        lst.Add(new Packs(1, "Coca", 100, 6));
        lst.Add(new Packs(2, "pepsi", 200, 6));
        lst.Add(new Suelto(3, "banana", 3, 2));

        double preciototal = 0;
        foreach (Producto producto in lst)
        {
            double precio = producto.CalcularPrecio();
            preciototal += precio;
            Console.WriteLine("Nombre: " + producto.Nombre + " Codigo: " + producto.Codigo);

        }

        Console.WriteLine("El precio total es de: " + preciototal);

    }
}