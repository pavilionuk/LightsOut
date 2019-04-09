using Microsoft.VisualStudio.TestTools.UnitTesting;
using LightsOut.Models;

namespace LightsOutTests.ModelsTests
{
    /// <summary>
    /// Tests for <see cref="Light"/>
    /// </summary>
    [TestClass]
    public class LightTests
    {
        /// <summary>
        /// Ensures that when calling <see cref="Light.SwitchOn()"/>, it switches the <see cref="Light"/> on
        /// </summary>
        [TestMethod]
        public void SwitchOn_SwitchesLightOn()
        {
            var lightToTest = new Light(0, 0);

            lightToTest.SwitchOn();

            Assert.IsTrue(lightToTest.IsOn());
        }

        /// <summary>
        /// Ensures that when calling <see cref="Light.SwitchOff"/>, it switched the <see cref="Light"/> off
        /// </summary>
        [TestMethod]
        public void SwitchOff_SwitchedLightOff()
        {
            var lightToTest = new Light(0, 0);

            lightToTest.SwitchOff();

            Assert.IsFalse(lightToTest.IsOn());
        }

        /// <summary>
        /// Ensures that when calling <see cref="Light.Toggle()"/> given a <see cref="Light"/> that is switched on, it switches off the <see cref="Light"/>
        /// </summary>
        [TestMethod]
        public void Toggle_GivenSwitchedOnLight_SwitchesLightOff()
        {
            var lightToTest = new Light(0, 0);

            lightToTest.SwitchOn();
            lightToTest.Toggle();

            Assert.IsFalse(lightToTest.IsOn());
        }

        /// <summary>
        /// Ensures that when calling <see cref="Light.Toggle()"/> given a <see cref="Light"/> that is switched off, it switches on the <see cref="Light"/>
        /// </summary>
        [TestMethod]
        public void Toggle_GivenSwitchedOffLight_SwitchesLightOn()
        {
            var lightToTest = new Light(0, 0);

            lightToTest.SwitchOff();
            lightToTest.Toggle();

            Assert.IsTrue(lightToTest.IsOn());
        }
    }
}
