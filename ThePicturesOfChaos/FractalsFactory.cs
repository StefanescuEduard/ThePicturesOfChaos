using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ThePicturesOfChaos
{
    public partial class FractalsFactory : UserControl
    {
        private static SystemGenerator _systemGenerator;
        private static string _axiom;
        private static string _initialAxiom;
        private static float _lineLength;
        private static float _initialLineLength;
        private static float _angle;
        private static float _x;
        private static float _initialX;
        private static float _y;
        private static float _initialY;
        private static int _numberOfIterations;
        private static Color _backgroundColor;
        private static Color _lineColor;
        private int _count;
        private Graphics _graphics;
        private static float _rotationAngle;
        private static bool _isLineChangeable;
        private bool _isFractalFit;
        private readonly Stack<LastInformation> _stack;
        private static CustomColorDialog _customColorDialog;
        private static bool _isChaos;

        public FractalsFactory()
        {
            InitializeComponent();
            _backgroundColor = pbFractalSpace.BackColor;
            _lineColor = pnProperties.BackColor;
            _stack = new Stack<LastInformation>();
            _customColorDialog = new CustomColorDialog();
            btnNextIteration.Click += DrawIterationButtonClicked;
            btnResetFractal.Click += ResetFractalButtonClicked;
            btnBackgroundColor.Click += BackgroundColorButtonCliked;
            btnLineColor.Click += LineColorButtonCliked;
            _isFractalFit = cbFitFractal.Checked;
        }

        public FractalsFactory(string axiom, SystemGenerator systemGenerator, float lineLength, float x,
            float y, int numberOfIterations, float rotationAngle, bool isLineChangeable, float angle) : this()
        {
            _axiom = axiom;
            _initialAxiom = _axiom;
            _systemGenerator = systemGenerator;
            _lineLength = lineLength;
            _initialLineLength = _lineLength;
            nUpDLineLength.Value = (int)_lineLength;
            _x = x;
            _y = y;
            _initialX = x;
            _initialY = y;
            _numberOfIterations = numberOfIterations;
            _rotationAngle = rotationAngle;
            _angle = 0;
            _isLineChangeable = isLineChangeable;
            _angle = angle;
        }

        private void SetColors()
        {
            _customColorDialog.Title = "Choose background color";
            _customColorDialog.ShowDialog(Form.ActiveForm);
            _backgroundColor = _customColorDialog.Color;
        }

        private void DrawChaos()
        {
            var random = new Random();
            SetColors();
            _graphics = pbFractalSpace.CreateGraphics();
            _graphics.Clear(_backgroundColor);
            cbFitFractal.Enabled = false;

            DrawQuadraticSnowflake(random);

            DrawAncientFractal(random);

            DrawReedFractal(random);

            DrawGosperCurve(random);

            DrawLeviCurve(random);

            DrawThreeFractal(random);

            DrawBushFractal(random);
        }

        private void BackgroundColorButtonCliked(object sender, EventArgs e)
        {
            _customColorDialog.Title = "Choose background color";
            _customColorDialog.ShowDialog();
            _backgroundColor = _customColorDialog.Color;
        }

        private void LineColorButtonCliked(object sender, EventArgs e)
        {
            _customColorDialog.Title = "Choose line color";
            _customColorDialog.ShowDialog();
            _lineColor = _customColorDialog.Color;
        }

        private void DrawIterationButtonClicked(object sender, EventArgs e)
        {
            if (_isChaos)
            {
                btnNextIteration.Enabled = false;
                DrawChaos();
            }
            else
            {
                _x = _initialX;
                _y = _initialY;
                nUpDLineLength.Value = (int)_lineLength;
                if ((_count <= _numberOfIterations && _isFractalFit) || !_isFractalFit)
                {
                    _axiom = _systemGenerator.Generate(_axiom);
                    btnNextIteration.Text = @"Next iteration";
                    DrawFractal();
                }
                else
                {
                    MessageBox.Show(@"The number of iterations arrived to maximum possible for this window.",
                        @"The fractal was drawn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ResetFractalButtonClicked(object sender, EventArgs e)
        {
            if (_graphics == null) return;
            if (_isChaos)
            {
                btnNextIteration.Enabled = true;
                _graphics.Clear(pbFractalSpace.BackColor);
                cbFitFractal.Enabled = true;
            }
            else
            {
                _axiom = _initialAxiom;
                _count = 0;
                _lineLength = _initialLineLength;
                btnNextIteration.Text = @"Draw";
                _graphics.Clear(pbFractalSpace.BackColor);
            }
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"PNG File (*.png) | *.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var bitmap = new Bitmap(Width - 30, Height - 30))
                {
                    var graphics = Graphics.FromImage(bitmap);
                    var rectangle = RectangleToScreen(ClientRectangle);
                    graphics.CopyFromScreen(rectangle.Location, Point.Empty, Size);
                    bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void DrawFractal()
        {
            if (!_isChaos)
            {
                _graphics = pbFractalSpace.CreateGraphics();
                _graphics.Clear(_backgroundColor);
            }

            foreach (var currentChar in _axiom)
            {
                if (currentChar == 'F')
                {
                    var newX = _x + (float)(Math.Cos(_angle) * _lineLength);
                    var newY = _y + (float)(Math.Sin(_angle) * _lineLength);
                    _graphics.DrawLine(new Pen(_lineColor, (int)nUpDLineWidth.Value), _x, _y, newX, newY);
                    _x = newX;
                    _y = newY;
                }
                else if (currentChar == '+')
                    _angle += _rotationAngle;
                else if (currentChar == '-')
                    _angle -= _rotationAngle;
                else if (currentChar == '[')
                    _stack.Push(new LastInformation(_x, _y, _angle));
                else if (currentChar == ']')
                {
                    var lastInformation = _stack.Pop();
                    _x = lastInformation.X;
                    _y = lastInformation.Y;
                    _angle = lastInformation.Angle;
                }
            }

            if (_lineLength > 1 && _isLineChangeable)
                _lineLength -= 1;
            if (!_isChaos)
                _count++;
        }

        private void DrawQuadraticSnowflake(Random random)
        {
            _axiom = "F";
            _systemGenerator = new SystemGenerator(new[] { new SystemGenerator.Rule("F", "F-F+F+F-F") });
            _lineLength = 11;
            _x = 80;
            _y = (float)pbFractalSpace.Height / 2 + 250;
            _rotationAngle = (float)Math.PI / 2;
            _numberOfIterations = 4;
            _angle = 0;
            _isLineChangeable = false;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawReedFractal(Random random)
        {
            _axiom = "Y";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("X", "X[-FFF][+FFF]FX"),
                new SystemGenerator.Rule("Y", "YFX[+Y][-Y]")
            });
            _lineLength = 3;
            _x = 10;
            _y = pbFractalSpace.Height;
            _rotationAngle = (float)Math.PI / 7;
            _numberOfIterations = 6;
            _angle = 7 * (float)Math.PI / 3.75f;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawGosperCurve(Random random)
        {
            _axiom = "XF";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("X", "X+YF++YF-FX--FXFX-YF+"),
                new SystemGenerator.Rule("Y", "-FX+YFYF++YF+FX--FX-Y")
            });
            _lineLength = 3;
            _x = (float)pbFractalSpace.Width / 2 + 200;
            _y = 150;
            _rotationAngle = (float)Math.PI / 3;
            _numberOfIterations = 4;
            _angle = 0;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawLeviCurve(Random random)
        {
            _axiom = "F++F++F++F";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("F", "-F++F-")
            });
            _lineLength = 10;
            _x = (float)pbFractalSpace.Width / 2 - 100;
            _y = (float)pbFractalSpace.Height / 2 - 125;
            _rotationAngle = (float)Math.PI / 4;
            _numberOfIterations = 6;
            _angle = 0;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawThreeFractal(Random random)
        {
            _axiom = "F";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("F", "FF+[+F-F-F]-[-F+F+F]"),
            });
            _lineLength = 9;
            _x = 200;
            _y = 0;
            _rotationAngle = (float)Math.PI / 8;
            _numberOfIterations = 4;
            _angle = (float)Math.PI / 2;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawAncientFractal(Random random)
        {
            _axiom = "F";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("F", "FXF"),
                new SystemGenerator.Rule("X", "[-F+F+F]+F-F-F+"),
            });
            _lineLength = 4;
            _x = pbFractalSpace.Width - 50;
            _y = 50;
            _rotationAngle = 2 * (float)Math.PI / 3;
            _numberOfIterations = 8;
            _angle = 4 * (float)Math.PI / 4.85f;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        private void DrawBushFractal(Random random)
        {
            _axiom = "F";
            _systemGenerator = new SystemGenerator(new[]
            {
                new SystemGenerator.Rule("F", "F[+FF][-FF]F[-F][+F]F")
            });
            _lineLength = 3;
            _x = (float)pbFractalSpace.Width - 150;
            _y = pbFractalSpace.Height;
            _rotationAngle = (float)Math.PI / 5;
            _numberOfIterations = 4;
            _angle = 3 * (float)Math.PI / 2;
            _lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            for (var iteration = 0; iteration < _numberOfIterations; iteration++)
                _axiom = _systemGenerator.Generate(_axiom);
            DrawFractal();
        }

        public static bool IsChaos
        {
            set => _isChaos = value;
        }

        public void ResetFractalFactory()
        {
            btnNextIteration.Text = @"Draw";
            _count = 0;
            _graphics?.Clear(pbFractalSpace.BackColor);
            cbFitFractal.Enabled = !_isChaos;
        }

        private void nUpDLineLength_ValueChanged(object sender, EventArgs e)
        {
            _lineLength = (int)nUpDLineLength.Value;
        }

        private void cbFitFractal_MouseClick(object sender, MouseEventArgs e)
        {
            _isFractalFit = cbFitFractal.Checked;
        }
    }
}
