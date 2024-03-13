using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest
    {
        private int product_type = 3;
        private int material_type = 1;
        private int count = 15;
        private int width = 20;
        private int lenght = 45;

        private int calculation_result = 114147; //ожидаемый результат

        private int non_existing_type = 10; //несуществующий тип
        private int negative_type = -1; //отрицательное число
        private int calculation_error = -1; //ошибка вычислений
        private int NULL = 0;

        [TestMethod]
        public void GetQuantityForProduct_CorrectData() //Расчет количества сырья с корректными данными
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_result, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullProductType() //Ввод нуля вместо типа продукции
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(NULL, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullMaterialType() //Ввод нуля вместо типа материалов
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, NULL, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullCount() //Ввод нуля вместо количества
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, NULL, width, lenght);
            //Assert
            Assert.AreEqual(NULL, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeProductType() //Ввод негативного значения типа продукции
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(negative_type, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeMaterialType() //Ввод негативного значения типа материалов
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, negative_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_IncorrectCount() //Ввод отрицательного количества
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, negative_type, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_IncorrectWidth() //Ввод некорректной ширины
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, negative_type, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_IncorrectLenght() //Ввод некорректной длины
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, width, negative_type);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistingProductType() //Ввод несуществующего типа продукции
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(non_existing_type, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }
    }
}
