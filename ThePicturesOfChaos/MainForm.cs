using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ThePicturesOfChaos.Fractals;

namespace ThePicturesOfChaos
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, Fractal> fractals;

        public MainForm()
        {
            InitializeComponent();

            fractalDrawingControl.Visible = false;
            fractals = new Dictionary<string, Fractal>();
            fractals.Add("Quadratic Snowflake", new Snowflake(fractalDrawingControl.Height));
            fractals.Add("Reed Fractal", new Reed(fractalDrawingControl.Height));
            fractals.Add("Gosper's Curve", new GosperCurve(fractalDrawingControl.Width));
            fractals.Add("Levi's Curve", new LeviCurve(fractalDrawingControl.Width, fractalDrawingControl.Height));
            fractals.Add("Tree Fractal", new Tree(fractalDrawingControl.Width, fractalDrawingControl.Height));
            fractals.Add("Ancient Fractal", new Ancient(fractalDrawingControl.Width));
            fractals.Add("Bush Fractal", new Bush(fractalDrawingControl.Width, fractalDrawingControl.Height));
        }

        private void AncientFractalButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            bool isFractalAvaiable = fractals.TryGetValue(button.Text, out Fractal foundFractal);
            if (isFractalAvaiable)
            {
                fractalDrawingControl.SetCurrentFractal(foundFractal);
            }
            else
            {
                fractalDrawingControl.DrawChaos(fractals.Select(f => f.Value));
            }
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnTabButtonMouseDown(object sender, MouseEventArgs e)
        {
            fractalDrawingControl.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
        }
    }
}
