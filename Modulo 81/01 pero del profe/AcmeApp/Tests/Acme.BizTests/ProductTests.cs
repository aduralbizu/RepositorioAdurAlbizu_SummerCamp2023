using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {

        [TestMethod()] //Marcando este método con este atributo
        public void CalculateSuggestedPriceTest()
        {
            // Arrange: Crea nueva instancia del producto
            var currentProduct = new Product(1, "Saw", ""); //Hemos creado una cadena sierra
            currentProduct.Cost = 50m;
            var expected = 55m;

            // Act
            var actual = currentProduct.CalculateSuggestedPrice(10m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Product_Null()
        {
            //Arrange
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;

            string expected = null;

            //Act
            var actual = companyName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ProductName_Format()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "  Steel Hammer  ";

            var expected = "Steel Hammer";

            //Act
            var actual = currentProduct.ProductName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ProductName_TooShort()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "aw";

            string expected = null;
            string expectedMessage = "Product Name must be at least 3 characters";

            //Act
            var actual = currentProduct.ProductName;
            var actualMessage = currentProduct.ValidationMessage;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void ProductName_TooLong()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Steel Bladed Hand Saw";

            string expected = null;
            string expectedMessage = "Product Name cannot be more than 20 characters";

            //Act
            var actual = currentProduct.ProductName;
            var actualMessage = currentProduct.ValidationMessage;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void ProductName_JustRight() //falso! 3 dig
        {
            //Arrange
            var currentProduct = new Product();//Hemos creado una cadena sierra
            currentProduct.ProductName = "Saw1"; //falso! 3 dig. prueba con sa

            string expected = "Saw1"; //Lo que espero
            string expectedMessage = null;

            //Act
            var actual = currentProduct.ProductName; //devuelveme el producto
            var actualMessage = currentProduct.ValidationMessage; //devuelveme mensaje de validacion

            //Assert
            Assert.AreEqual(expected, actual); //comprobamos si es igual el resultado a lo que esppero
            Assert.AreEqual(expectedMessage, actualMessage);
        }
        //Si pongo null, menos de 3 o 20, error.
        //poniendo null se detecta la excepcion pero no se rompe nada
    }
}