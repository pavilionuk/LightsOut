using LightsOut.Extensions;
using LightsOut.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOutTests.ExtensionsTests
{
    /// <summary>
    /// Tests for <see cref="Light"/> extension methods
    /// </summary>
    [TestClass]
    public class LightExtensionsTests
    {
        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetAdjacent()"/>, given a null grid, it throws an <see cref="ArgumentNullException"/>
        /// </summary>
        [TestMethod]
        public void GetAdjacent_GivenNullGrid_ThrowsArgumentNullException()
        {
            var light = new Light(0, 0);
            var mockGrid = default(List<Light>);

            try
            {
                mockGrid.GetAdjacent(light);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("lights", ex.ParamName);
            }
        }

        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetAdjacent()"/>, given a null <see cref="Light"/>, it throws an <see cref="ArgumentNullException"/>
        /// </summary>
        [TestMethod]
        public void GetAdjacent_GivenNullLight_ThrowsArgumentNullException()
        {
            var light = default(Light);
            var mockGrid = GetMockGrid();

            try
            {
                mockGrid.GetAdjacent(light);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("light", ex.ParamName);
            }
        }

        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetAdjacent()"/> when the <see cref="Light"/> is next to a wall,
        /// It returns 3 <see cref="Light"/>'s, This is intentional as it is does not return <see cref="Light"/>s
        /// that are out of bounds
        /// </summary>
        [TestMethod]
        public void GetAdjacent_GivenLightNextToWall_ReturnsThreeLights()
        {
            var mockGrid = GetMockGrid();
            
            // This is the left most light in the middle row
            var light = new Light(0, 2);

            var adjacentLights = mockGrid.GetAdjacent(light);

            Assert.AreEqual(3, adjacentLights.Count);
        }

        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetAdjacent()"/>, it returns the adjacent <see cref="Light"/>s
        /// </summary>
        [TestMethod]
        public void GetAdjacent_GetsAdjacentLights()
        {
            var mockGrid = GetMockGrid();

            // This is the middle light
            var light = new Light(2, 2);

            var adjacentLights = mockGrid.GetAdjacent(light);

            // Ensures that the light on the left, is in the list
            Assert.IsNotNull(adjacentLights.GetByCoord(1, 2));

            // Ensures that the light on the bottom, is in the list
            Assert.IsNotNull(adjacentLights.GetByCoord(2, 1));

            // Ensures that the light on the right, is in the list
            Assert.IsNotNull(adjacentLights.GetByCoord(3, 2));

            // Ensures that the light on the top, is in the list
            Assert.IsNotNull(adjacentLights.GetByCoord(2, 3));
        }

        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetByCoord()"/> given a null grid, it throws an <see cref="ArgumentNullException"/>
        /// </summary>
        [TestMethod]
        public void GetByCoord_GivenNullGrid_ThrowsArgumentNullException()
        {
            var mockGrid = default(List<Light>);
            
            try
            {
                mockGrid.GetByCoord(0, 0);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("lights", ex.ParamName);
            }
        }

        /// <summary>
        /// Ensures that when calling <see cref="List{Light}.GetByCoord()"/>, it returns the <see cref="Light"/> matching the coord
        /// </summary>
        [TestMethod]
        public void GetByCoord_GetsLightMatchingGivenCoord()
        {
            var mockGrid = GetMockGrid();

            var light = mockGrid.GetByCoord(2, 4);

            Assert.AreEqual(2, light.X);
            Assert.AreEqual(4, light.Y);
        }

        /// <summary>
        /// Builds and returns a mock grid for use in tests
        /// </summary>
        /// <returns>A mock grid</returns>
        private List<Light> GetMockGrid()
        {
            return new List<Light>()
            {
                new Light(0, 0),
                new Light(1, 0),
                new Light(2, 0),
                new Light(3, 0),
                new Light(4, 0),

                new Light(0, 1),
                new Light(1, 1),
                new Light(2, 1),
                new Light(3, 1),
                new Light(4, 1),

                new Light(0, 2),
                new Light(1, 2),
                new Light(2, 2),
                new Light(3, 2),
                new Light(4, 2),

                new Light(0, 3),
                new Light(1, 3),
                new Light(2, 3),
                new Light(3, 3),
                new Light(4, 3),

                new Light(0, 4),
                new Light(1, 4),
                new Light(2, 4),
                new Light(3, 4),
                new Light(4, 4),
            };
        }
    }
}
