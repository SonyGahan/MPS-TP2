using System.Collections.Generic;

namespace ProductosApp;

public class ProductManager
{
    public List<Product> Productos { get; private set; }

    // Constructor vacio para inicializar la lista de produtos
    public ProductManager()
    {
        Productos = new List<Product>();
    }

    // Método para agregar un producto a la lista
    public void addProduct(Product product)
    {
        Productos.Add(product);
    }

    //Método para buscar un producto de la lista
    public Product? findProductByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre del producto no puede estar vacío", nameof(name));

        return Productos.Find(p => p.name == name);
    }

    // Método para calcular el precio total con impuestos
    public double calculateTotalPrice(Product producto)
    {
        if (producto.category == ProductCategory.Electronica)
        {
            return producto.price * 1.10;
        }
        else if (producto.category == ProductCategory.Alimentos)
        {
            return producto.price * 1.05;
        }
        else
        {
            throw new ArgumentException("Categoría no válida", nameof(producto));
        }
    }

}