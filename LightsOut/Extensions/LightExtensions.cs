using LightsOut.Models;
using System.Collections.Generic;
using System.Linq;

namespace LightsOut.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Light"/>
    /// </summary>
    public static class LightExtensions
    {
        /// <summary>
        /// Method for getting and returning the <see cref="Light"/>s adjacent to the given
        /// </summary>
        /// <param name="light">The <see cref="Light"/> to get the adjacent from</param>
        /// <returns>A <see cref="List{Light}"/> adjacent to this</returns>
        public static List<Light> GetAdjacent(this List<Light> lights, Light light)
        {
            light.EnsureNotNull(nameof(light));
            var returnValue = new List<Light>();

            if (light.X > 0)
            {
                returnValue.Add(lights.Single(l => l.X == light.X - 1 && l.Y == light.Y));
            }

            if (light.Y > 0)
            {
                returnValue.Add(lights.Single(l => l.X == light.X && l.Y == light.Y - 1));
            }

            if (light.X < 4)
            {
                returnValue.Add(lights.Single(l => l.X == light.X + 1 && l.Y == light.Y));
            }

            if (light.Y < 4)
            {
                returnValue.Add(lights.Single(l => l.X == light.X && l.Y == light.Y + 1));
            }

            return returnValue;
        }

        /// <summary>
        /// Method for getting a <see cref="Light"/> by the coords
        /// </summary>
        /// <param name="lights">The <see cref="List{Light}"/> the search</param>
        /// <param name="x">The x coord of the <see cref="Light"/> to get</param>
        /// <param name="y">The x coord of the <see cref="Light"/> to get</param>
        /// <returns>The <see cref="Light"/> matching the given coord</returns>
        public static Light GetByCoord(this List<Light> lights, int x, int y)
        {
            lights.EnsureNotNull(nameof(lights));

            return lights.Single(l => l.X == x && l.Y == y);
        }
    }
}
