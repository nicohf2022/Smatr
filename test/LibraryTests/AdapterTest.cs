using AdapterExample;
using NUnit.Framework;
using System;

namespace AdapterTests
{   
    /// <summary>
    ///  Testea el adaptador.
    /// </summary>
   
   
    public class AdapterTest
    {   
        /// <summary>
        /// Testea plug encendido.
        /// </summary>

        
        [Test]
        public void TestEncendido()
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
        public void TestApagado()
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
       /// <summary>
       /// Testea plug encendido y apagado.
       /// </summary>
        public void TestONandOFF()
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
        /// <summary>
        ///  Testea encendido de bulb.
        /// </summary>
        
        [Test]
        public void TestEncendidoBulb()
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
       /// <summary>
       ///  Testea apagado de bulb.
       /// </summary>
       
        public void TestApagadoBulb()
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
       /// <summary>
       /// Testea encendido y apagado de bulb.
       /// </summary>
        public void TestONandOFBulb()
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
       /// <summary>
       /// Testea encendido de washing machine.
       /// </summary>
        public void TestEncendidowashinMachine()
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