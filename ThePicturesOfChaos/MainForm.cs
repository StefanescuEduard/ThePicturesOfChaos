using System;
using System.Windows.Forms;

namespace ThePicturesOfChaos
{
    public partial class MainForm : Form
    {
        // ReSharper disable once NotAccessedField.Local
        private FractalsFactory _fractalsFactory;

        public MainForm()
        {
            InitializeComponent();
            FractalsFactoryUc.Visible = false;
        }

        private void QSnowFlakeButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("F",
                new SystemGenerator(new[] { new SystemGenerator.Rule("F", "F-F+F+F-F") }), 11, 80,
                (float)FractalsFactoryUc.Height / 2 + 250, 3, (float)Math.PI / 2, false, 0);
        }

        private void ReedFractalButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("Y",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("X", "X[-FFF][+FFF]FX"),
                    new SystemGenerator.Rule("Y", "YFX[+Y][-Y]")
                }), 10,
                0, (float)FractalsFactoryUc.Height - 30, 6, (float)Math.PI / 7, true, 7 * (float)Math.PI / 3.75f);
        }

        private void GosperCurveButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("XF",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("X", "X+YF++YF-FX--FXFX-YF+"),
                    new SystemGenerator.Rule("Y", "-FX+YFYF++YF+FX--FX-Y")
                }), 3, (float)FractalsFactoryUc.Width / 2 + 110,
                150, 4, (float)Math.PI / 3, false, 0);
        }

        private void LeviCurveButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("F++F++F++F",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("F", "-F++F-")
                }), 10, (float)FractalsFactoryUc.Width / 2 - 100,
                (float)FractalsFactoryUc.Height / 2 - 125, 8, (float)Math.PI / 4, false, 0);
        }

        private void TreeFractalButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("F",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("F", "FF+[+F-F-F]-[-F+F+F]"),
                }), 9, (float)FractalsFactoryUc.Width / 2,
                (float)FractalsFactoryUc.Height - 30, 4, (float)Math.PI / 8, true, 3 * (float)Math.PI / 2);
        }

        private void AncientFractalButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("F",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("F", "FXF"),
                    new SystemGenerator.Rule("X", "[-F+F+F]+F-F-F+"),
                }), 10, FractalsFactoryUc.Width - 50,
                50, 8, 2 * (float)Math.PI / 3, true, 4 * (float)Math.PI / 4.85f);
        }

        private void BushFractalButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = false;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
            _fractalsFactory = new FractalsFactory("F",
                new SystemGenerator(new[]
                {
                    new SystemGenerator.Rule("F", "F[+FF][-FF]F[-F][+F]F")
                }), 3, (float)FractalsFactoryUc.Width / 2,
                (float)FractalsFactoryUc.Height - 30, 4, (float)Math.PI / 5, false, 3 * (float)Math.PI / 2);
        }

        private void ChaosPicturesButtonClicked(object sender, EventArgs e)
        {
            FractalsFactory.IsChaos = true;
            FractalsFactoryUc.ResetFractalFactory();
            FractalsFactoryUc.Visible = true;
            lbHallo.Visible = false;
            lbRequireMessage.Visible = false;
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
