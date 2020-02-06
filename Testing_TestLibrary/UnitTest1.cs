using NUnit.Framework;
using TestLibrary;
using System.Collections.Generic;
using System.Linq;

namespace Testing_TestLibrary
{
    public class Tests
    {
        TestCase Testing;


        [SetUp]
        public void Setup()
        {
            Testing = new TestCase();
        }

       

        [Test]
        public void Test_1()
        {
            int Y = Testing.JumKar("nama");
            Assert.AreEqual(4, Y);

            //Assert.Pass();
        }
        [Test]
        public void Test_2()
        {
            char Y = Testing.Grade(89);
            Assert.AreEqual('B', Y);

            //Assert.Pass();
        }
        [Test]
        public void Test_3()
        {
            string Y = Testing.GanjilGenap(10);
            Assert.AreEqual("genap", Y);

            //Assert.Pass();
        }
        [Test]
        public void Test_4()
        {
            string Y = Testing.kabisat(1996);
            Assert.AreEqual("kabisat", Y);

            //Assert.Pass();
        }
        [Test]
        public void Test_5()
        {
            string Y = Testing.RatingFilm(30);
            Assert.AreEqual("dewasa", Y);

            //Assert.Pass();
        }
        [Test]
        public void Test_6()
        {
            int[] Y = Testing.LoopRange(4, 8);
            int[] x = new int[] { 4, 5, 6, 7, 8 };
            Assert.AreEqual(x, Y);

            //Assert.Pass();
        }
        //[Test]
        public void Test_7()
        {
            System.Collections.Generic.List<int> Y = Testing.BilGanjil();
            List<int> x = new List<int> { 1, 3, 5, 7, 9 };
            var y = Y.Take(5);
            Assert.AreEqual(x, y);

            //Assert.Pass();
        }
        [Test]
        public void Test_8()
        {

            string[] Y = Testing.OddEvenMul();
            string y = Y[1];
            string x = "2. Genap";
            Assert.AreEqual(x, y);

            //Assert.Pass();
        }

        [Test]
        public void Test_9()
        {
            string Y = Testing.BalikKata("Ayam Bakar Bandung");
            string x = "Bandung Bakar Ayam";
            Assert.AreEqual(x, Y);

            //Assert.Pass();
        }

        [Test]
        public void Test_10()
        {
            string[] soal = new string[] { "Meja", "Buku", "Topi", "baju", "Kayu" };
            string[] Y = Testing.AddArray(soal, "Handuk", "Celana");
            string[] x = new string[] { "Handuk", "Meja", "Buku", "Topi", "baju", "Kayu", "Celana" };
            //string[]
            Assert.AreEqual(x, Y);

            //Assert.Pass();
        }
    }
}