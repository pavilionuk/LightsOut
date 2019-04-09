using LightsOut.Controllers;
using LightsOut.Models;
using System;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class frmLightsOut : Form
    {
        /// <summary>
        /// The game controller
        /// </summary>
        private readonly LightsOutController _controller;

        public frmLightsOut()
        {
            _controller = new LightsOutController(tmrWinScreen);
            InitializeComponent();
            InitialiseGrid();
            _controller.InitialiseGame();
        }

        private void InitialiseGrid()
        {
            _controller.AddLight(new Light(btnLight21, 0, 0));
            _controller.AddLight(new Light(btnLight22, 1, 0));
            _controller.AddLight(new Light(btnLight23, 2, 0));
            _controller.AddLight(new Light(btnLight24, 3, 0));
            _controller.AddLight(new Light(btnLight25, 4, 0));

            _controller.AddLight(new Light(btnLight16, 0, 1));
            _controller.AddLight(new Light(btnLight17, 1, 1));
            _controller.AddLight(new Light(btnLight18, 2, 1));
            _controller.AddLight(new Light(btnLight19, 3, 1));
            _controller.AddLight(new Light(btnLight20, 4, 1));

            _controller.AddLight(new Light(btnLight11, 0, 2));
            _controller.AddLight(new Light(btnLight12, 1, 2));
            _controller.AddLight(new Light(btnLight13, 2, 2));
            _controller.AddLight(new Light(btnLight14, 3, 2));
            _controller.AddLight(new Light(btnLight15, 4, 2));

            _controller.AddLight(new Light(btnLight6, 0, 3));
            _controller.AddLight(new Light(btnLight7, 1, 3));
            _controller.AddLight(new Light(btnLight8, 2, 3));
            _controller.AddLight(new Light(btnLight9, 3, 3));
            _controller.AddLight(new Light(btnLight10, 4, 3));

            _controller.AddLight(new Light(btnLight1, 0, 4));
            _controller.AddLight(new Light(btnLight2, 1, 4));
            _controller.AddLight(new Light(btnLight3, 2, 4));
            _controller.AddLight(new Light(btnLight4, 3, 4));
            _controller.AddLight(new Light(btnLight5, 4, 4));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _controller.InitialiseGame();
        }

        private void btnLight21_Click(object sender, EventArgs e)
        {
            _controller.LightClick(0, 0);
        }

        private void btnLight22_Click(object sender, EventArgs e)
        {
            _controller.LightClick(1, 0);
        }

        private void btnLight23_Click(object sender, EventArgs e)
        {
            _controller.LightClick(2, 0);
        }

        private void btnLight24_Click(object sender, EventArgs e)
        {
            _controller.LightClick(3, 0);
        }

        private void btnLight25_Click(object sender, EventArgs e)
        {
            _controller.LightClick(4, 0);
        }

        private void btnLight16_Click(object sender, EventArgs e)
        {
            _controller.LightClick(0, 1);
        }

        private void btnLight17_Click(object sender, EventArgs e)
        {
            _controller.LightClick(1, 1);
        }

        private void btnLight18_Click(object sender, EventArgs e)
        {
            _controller.LightClick(2, 1);
        }

        private void btnLight19_Click(object sender, EventArgs e)
        {
            _controller.LightClick(3, 1);
        }

        private void btnLight20_Click(object sender, EventArgs e)
        {
            _controller.LightClick(4, 1);
        }

        private void btnLight11_Click(object sender, EventArgs e)
        {
            _controller.LightClick(0, 2);
        }

        private void btnLight12_Click(object sender, EventArgs e)
        {
            _controller.LightClick(1, 2);
        }

        private void btnLight13_Click(object sender, EventArgs e)
        {
            _controller.LightClick(2, 2);
        }

        private void btnLight14_Click(object sender, EventArgs e)
        {
            _controller.LightClick(3, 2);
        }

        private void btnLight15_Click(object sender, EventArgs e)
        {
            _controller.LightClick(4, 2);
        }

        private void btnLight6_Click(object sender, EventArgs e)
        {
            _controller.LightClick(0, 3);
        }

        private void btnLight7_Click(object sender, EventArgs e)
        {
            _controller.LightClick(1, 3);
        }

        private void btnLight8_Click(object sender, EventArgs e)
        {
            _controller.LightClick(2, 3);
        }

        private void btnLight9_Click(object sender, EventArgs e)
        {
            _controller.LightClick(3, 3);
        }

        private void btnLight10_Click(object sender, EventArgs e)
        {
            _controller.LightClick(4, 3);
        }

        private void btnLight1_Click(object sender, EventArgs e)
        {
            _controller.LightClick(0, 4);
        }

        private void btnLight2_Click(object sender, EventArgs e)
        {
            _controller.LightClick(1, 4);
        }

        private void btnLight3_Click(object sender, EventArgs e)
        {
            _controller.LightClick(2, 4);
        }

        private void btnLight4_Click(object sender, EventArgs e)
        {
            _controller.LightClick(3, 4);
        }

        private void btnLight5_Click(object sender, EventArgs e)
        {
            _controller.LightClick(4, 4);
        }
    }
}
