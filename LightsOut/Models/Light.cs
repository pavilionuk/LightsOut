using System.Windows.Forms;

namespace LightsOut.Models
{
    /// <summary>
    /// Represents a light on the grid
    /// </summary>
    public class Light
    {
        /// <summary>
        /// The button GUI component
        /// </summary>
        private readonly Button _btnLight;

        /// <summary>
        /// Gets the state of the light
        /// </summary>
        private bool _isOn;

        /// <summary>
        /// Initializes a new instance of the <see cref="Light"/> class
        /// </summary>
        /// <param name="x">The x coord position of the light</param>
        /// <param name="y">The y coord position of the light</param>
        public Light(int x, int y)
        {
            _isOn = false;
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Light"/> class
        /// </summary>
        /// <param name="btnLight">The button GUI component</param>
        /// <param name="x">The x coord position of the light</param>
        /// <param name="y">The y coord position of the light</param>
        public Light(Button btnLight, int x, int y)
        {
            _isOn = false;
            _btnLight = btnLight;
            X = x;
            Y = y;
        }

        /// <summary>
        /// Method for returning the state of the <see cref="Light"/>
        /// </summary>
        /// <returns>The state of the <see cref="Light"/></returns>
        public bool IsOn()
        {
            return _isOn;
        }

        /// <summary>
        /// Method for making the <see cref="Light"/> lit bruv 😎👌🔥
        /// </summary>
        public void SwitchOn()
        {
            _btnLight.Text = "@";
            _isOn = true;
        }

        /// <summary>
        /// Method for turning the <see cref="Light"/>'s state to off
        /// </summary>
        public void SwitchOff()
        {
            _btnLight.Text = string.Empty;
            _isOn = false;
        }

        /// <summary>
        /// Method for toggling the <see cref="Light"/>'s state
        /// </summary>
        public void Toggle()
        {
            if (_isOn)
            {
                _btnLight.Text = string.Empty;
                _isOn = !_isOn;
            }
            else
            {
                _btnLight.Text = "@";
                _isOn = !_isOn;
            }
        }

        /// <summary>
        /// Gets the x coord position of the light
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Gets the y coord position of the light
        /// </summary>
        public int Y { get; private set; }
    }
}
