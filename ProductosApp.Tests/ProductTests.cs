using NUnit.Framework;
using ProductosApp;

namespace ProductosApp.Tests;

public class ProductTests
{
    //Camino Feliz - Se prueba la creación de un producto con datos válidos.
    [Test]
    public void ValidaProductoCreadoCorrectamente()
    {
        int expectedId = 1;
        string expectedNombre = "Auriculares";
        double expectedPrecio = 5000.0;
        ProductCategory expectedCategoria = ProductCategory.Electronica;

        Product producto = new Product(expectedId, expectedNombre, expectedPrecio, expectedCategoria);

        Assert.That(producto.id, Is.EqualTo(expectedId));
        Assert.That(producto.name, Is.EqualTo(expectedNombre));
        Assert.That(producto.price, Is.EqualTo(expectedPrecio));
        Assert.That(producto.category, Is.EqualTo(expectedCategoria));
    }

    //Camino negativo - Se prueba que el contructor lance una excepción cuando se intenta crear un producto con precio negativo.
    [Test]
    public void ValidaProductoConPrecioNegativo()
    {
        int validId = 2;
        string validNombre = "Teclado";
        double invalidPrecio = -500.0;
        ProductCategory validCategoria = ProductCategory.Electronica;

       
        Assert.Throws<System.ArgumentException>(() =>
        {
            Product producto = new Product(validId, validNombre, invalidPrecio, validCategoria);
        });
    }
}