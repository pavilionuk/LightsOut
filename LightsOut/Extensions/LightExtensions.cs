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

        /// <summary>
        /// Method for clearing the screen (i.e switching all the <see cref="Light"/>s off)
        /// </summary>
        /// <param name="lights">The grid containing the <see cref="Light"/>s</param>
        /// <returns>The grid</returns>
        public static void ClearScreen(this List<Light> lights)
        {
            lights.EnsureNotNull(nameof(lights));

            lights.ForEach(l => l.SwitchOff());
        }

        public static void DisplayWinScreen(this List<Light> lights)
        {
            lights.ClearScreen();

            lights.GetByCoord(0, 0).SwitchOn();
            lights.GetByCoord(2, 0).SwitchOn();
            lights.GetByCoord(4, 0).SwitchOn();
            lights.GetByCoord(0, 2).SwitchOn();
            lights.GetByCoord(4, 2).SwitchOn();
            lights.GetByCoord(0, 4).SwitchOn();
            lights.GetByCoord(2, 4).SwitchOn();
            lights.GetByCoord(4, 4).SwitchOn();

            lights.GetByCoord(1, 3).UpdateText("Y");
            lights.GetByCoord(2, 3).UpdateText("O");
            lights.GetByCoord(3, 3).UpdateText("U");
            lights.GetByCoord(1, 1).UpdateText("W");
            lights.GetByCoord(2, 1).UpdateText("I");
            lights.GetByCoord(3, 1).UpdateText("N");
        }
    }
}
