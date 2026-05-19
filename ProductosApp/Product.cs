namespace ProductosApp;

// Se define el enumerador para restringir las categorías válidas
public enum ProductCategory
{
    Electronica,
    Alimentos
}

public class Product
{
    // Se encapsula con 'private set' para proteger los datos del producto
    public int id { get; private set; }
    public string name { get; private set; }
    public double price { get; private set; }
    public ProductCategory category { get; private set; }

    // Constructor
    public Product(int id, string name, double price, ProductCategory category)
    {
        // El precio base no puede ser negativo
        if (price < 0)
        {
            throw new System.ArgumentException("El precio base de un producto no puede ser negativo.");
        }

       this.id = id;
       this.name = name;
       this.price = price;
       this.category = category;
    }
}