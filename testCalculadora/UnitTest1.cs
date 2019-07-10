using NUnit.Framework;
using calculadora;
namespace Tests
{
    public class Test1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPares()
        { 
            int n = 2;
            bool resultado = matematicas.esPar(n);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void TestSumaBasica()
        {
            //arranque
            int a = 2;
            int b = 5;

            //act
            int suma= matematicas.sumar(a, b);

            Assert.AreEqual(a + b,suma);
        }
        [Test]
        public void TestPrimos()
        {
            int n = 7;
            bool resultado = matematicas.esPrimo(n);
            Assert.IsTrue(resultado);
        }


    }

}