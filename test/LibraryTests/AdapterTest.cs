using AdapterExample;
using NUnit.Framework;
using System;

namespace AdapterTests
{
    public class AdapterTest
    {   
        /// <summary>
        /// Testa plug encendido.
        /// </summary>

        
        [Test]
        public void Test1()
        {
            // Arrange
            var plug = new Plug("1");
            var adapter = new Adapter(plug);
            var expected = "on";

            // Act
            adapter.On();
            var actual = adapter.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testa plug apagado.
        /// </summary>
        [Test]
        public void Test2()
        {
            // Arrange
            var plug = new Plug("1");
            var adapter = new Adapter(plug);
            var expected = "off";

            // Act
            adapter.Off();
            var actual = adapter.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var plug = new Plug("1");
            var adapter = new Adapter(plug);
            var expected = "on";

            // Act
            adapter.On();
            adapter.Off();
            adapter.On();
            var actual = adapter.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var bulb = new Bulb("1");
            var expected = "on";

            // Act
            bulb.On();
            var actual = bulb.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var bulb = new Bulb("1");
            var expected = "off";

            // Act
            bulb.Off();
            var actual = bulb.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6()
        {
            // Arrange
            var bulb = new Bulb("1");
            var expected = "on";

            // Act
            bulb.On();
            bulb.Off();
            bulb.On();
            var actual = bulb.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test7()
        {
            // Arrange
            var washingMachine = new WashingMachine("1");
            var expected = "on";

            // Act
            washingMachine.On();
            var actual = washingMachine.GetStatus();

            // Assert
            Assert.AreEqual(expected,actual);
        }
    }
}