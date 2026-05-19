using System.Collections.Generic;

namespace ProductosApp;

public class ProductManager
{
    public List<Producto> Productos { get; private set; }

    // Constructor vacio para inicializar la lista de produtos
    public ProductManager()
    {
        Productos = new List<Producto>();
    }

    // Método para agregar un producto a la lista
    public void AddProduct(Producto producto)
    {
        Productos.Add(producto);
    }

    //Método para buscar un producto de la lista
    public Producto? FindProductByName(string nombreBuscado)
    {
        if (string.IsNullOrWhiteSpace(nombreBuscado))
            throw new ArgumentException("El nombre del producto no puede estar vacío", nameof(nombreBuscado));

        return Productos.Find(p => p.Nombre == nombreBuscado);
    }

    // Método para calcular el precio total con impuestos
    public double CalculateTotalPrice(Producto producto)
    {
        if (producto.Categoria == ProductCategory.Electronica)
        {
            return producto.Precio * 1.10;
        }
        else if (producto.Categoria == ProductCategory.Alimentos)
        {
            return producto.Precio * 1.05;
        }
        else
        {
            throw new ArgumentException("Categoría no válida", nameof(producto));
        }
    }

}