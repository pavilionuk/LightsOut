using LightsOut.Extensions;
using LightsOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LightsOut.Controllers
{
    /// <summary>
    /// Represents the game 
    /// </summary>
    public class LightsOutController
    {
        /// <summary>
        /// The lights on the grid
        /// </summary>
        private List<Light> _grid;

        /// <summary>
        /// Random number generator
        /// </summary>
        private readonly Random _random;

        /// <summary>
        /// Initializes a new instance of the <see cref="LightsOutController"/> class
        /// </summary>
        public LightsOutController()
        {
            _grid = new List<Light>();
            _random = new Random();
        }

        /// <summary>
        /// Method for initialising the game
        /// </summary>
        public void InitialiseGame()
        {
            _grid.ForEach(g => g.SwitchOff());
            for (int i = 0; i < 15; i++)
            {
                var lightToTurnOn = _grid
                    .ElementAt(_random.Next(0, _grid.Count));
                if (lightToTurnOn.IsOn())
                {
                    i--;
                    continue;
                }
                lightToTurnOn.SwitchOn();
            }
        }

        /// <summary>
        /// Method for adding a <see cref="Light"/> to the grid
        /// </summary>
        /// <param name="light">The <see cref="Light"/> to add the to grid</param>
        public void AddLight(Light light)
        {
            light.EnsureNotNull(nameof(light));
            _grid.Add(light);
        }

        /// <summary>
        /// Method for toggling the light 
        /// </summary>
        /// <param name="x">The x coord of the <see cref="Light"/> that was clicked</param>
        /// <param name="y">The x coord of the <see cref="Light"/> that was clicked</param>
        public void LightClick(int x, int y)
        {
            var lightClicked = _grid.GetByCoord(x, y);
            if (lightClicked.IsOn())
            {
                var lightsToToggle = new List<Light>();
                lightsToToggle.Add(lightClicked);
                lightsToToggle.AddRange(_grid.GetAdjacent(lightClicked));

                foreach (var light in lightsToToggle)
                {
                    light.Toggle();
                }

                CheckGrid();
            }
        }

        /// <summary>
        /// Method for checking the grid for the 'win' state
        /// </summary>
        private void CheckGrid()
        {
            if (_grid.All(l => l.IsOn() == false))
            {
                Win();
            }
        }

        /// <summary>
        /// Starts the win process
        /// </summary>
        private void Win()
        {
            MessageBox.Show("You win 👉😉👉");
            InitialiseGame();
        }
    }
}
