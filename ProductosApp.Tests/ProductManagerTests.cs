using NUnit.Framework;
using ProductosApp;

namespace ProductosApp.Tests;

public class ProductManagerTests
{
    [Test]
    public void ValidarProductoAgregado()
    {
        // 1- Configuracion previa
        ProductManager manager = new ProductManager();
        Producto nuevoProducto = new Producto(1, "Mouse", 1500.0, ProductCategory.Electronica);

        // 2- Ejecucion del metodo a probar
        manager.AddProduct(nuevoProducto);

        // 3- Verificar la salida: Cuantos y cuales elementos se incorporaron a la lista de productos
        Assert.That(manager.Productos.Count, Is.EqualTo(1));
        Assert.That(manager.Productos, Contains.Item(nuevoProducto));
    }


    [Test]
    public void ValidaDescuentoElectronica()
    {
        // 1- Configuracion previa
        ProductManager manager = new ProductManager();
        double precioOriginal = 1000.0;
        Producto prodElectronica = new Producto(1, "Monitor", precioOriginal, ProductCategory.Electronica);

        // 2- Ejecucion del metodo a probar
        double resultado = manager.CalculateTotalPrice(prodElectronica);

         // 3- Verificar la salida: Verificar que el impuesto aplicado sea el correcto para la caterogia Electronica.
        double precioEsperado = 1100.0;
        Assert.That(resultado, Is.EqualTo(precioEsperado).Within(0.01));
    }

    [Test]
    public void ValidaDescuentoAlimentos()
    {
        // 1- Configuracion previa
        ProductManager manager = new ProductManager();
        double precioOriginal = 1000.0;
        Producto prodAlimento = new Producto(2, "Arroz", precioOriginal, ProductCategory.Alimentos);

        // 2- Ejecucion del metodo a probar
        double resultado = manager.CalculateTotalPrice(prodAlimento);

        // 3- Verificar la salida: Verificar que el impuesto aplicado sea el correcto para la caterogia Alimentos.
        double precioEsperado = 1050.0;
        Assert.That(resultado, Is.EqualTo(precioEsperado).Within(0.01));
    }


}