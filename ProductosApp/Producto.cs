namespace ProductosApp;

// Se define el enumerador para restringir las categorías válidas
public enum ProductCategory
{
    Electronica,
    Alimentos
}

public class Producto
{
    // Se encapsula con 'private set' para proteger los datos del producto
    public int IdProducto { get; private set; }
    public string Nombre { get; private set; }
    public double Precio { get; private set; }
    public ProductCategory Categoria { get; private set; }

    // Constructor
    public Producto(int idProducto, string nombre, double precio, ProductCategory categoria)
    {
        // El precio base no puede ser negativo
        if (precio < 0)
        {
            throw new System.ArgumentException("El precio base de un producto no puede ser negativo.");
        }

        IdProducto = idProducto;
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }
}