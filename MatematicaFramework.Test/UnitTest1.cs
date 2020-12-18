using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatematicaFramework.Test
{
    [TestClass]
    public class CuandoPrueboCalculadora
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //[TestMethod]
        //[DataRow(1, 2, 3)]
        //[DataRow(2, -3,-1)]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //   "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
        // DeploymentItem("data.csv")]
        //}
        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //"|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
        //DeploymentItem("data.csv")]
        //public void AñadirEntero()
        //{

          //  var numeroEntero1 = Int32.Parse(TestContext.DataRow["numeroEntero1"].ToString());
           // var numeroEntero2 = Int32.Parse(TestContext.DataRow["numeroEntero2"].ToString());
            //var esperado = Int32.Parse(TestContext.DataRow["Esperado"].ToString());

            //var calculadora = new Calculadora();
            //int resultado = calculadora.AumentarEnteros(numeroEntero1, numeroEntero2);
            //Assert.AreEqual(esperado, resultado);
        //}
        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivoObtengoPositivo()
        {
            var numero1 = 25;
            var esperado = 5;
            var calculadora = new Calculadora();
            var resultado = calculadora.RaizCuadrada(numero1);
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegativoSeDisparaArgumentException()
        {
            var numero1 = -25;

            var calculadora = new Calculadora();

            Assert.ThrowsException<ArgumentException>(() => calculadora.RaizCuadrada(numero1));
        }

        [TestMethod]
        public void LongitudCorrecta()
        {
            //Arrange
            string nombre = "Nicolás";
            string apellidoPaterno = "Suárez";
            string apellidoMaterno = "Salgado";
            string result;
            string resultadoEsperado = "Admitido";
            //Act
            var calculadora = new Calculadora();
            result = calculadora.longNombres(nombre, apellidoPaterno, apellidoMaterno);
            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
