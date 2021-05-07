using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ThePicturesOfChaos.Fractals;

namespace ThePicturesOfChaos
{
    public partial class FractalDrawingControl : UserControl
    {
        private Color backgroundColor;
        private Color lineColor;
        private int count;
        private bool isFractalFit;
        private CustomColorDialog customColorDialog;
        private Fractal fractal;
        private Graphics graphics;

        public FractalDrawingControl()
        {
            InitializeComponent();

            backgroundColor = pbFractalSpace.BackColor;
            lineColor = pnProperties.BackColor;
            customColorDialog = new CustomColorDialog();
            btnNextIteration.Click += DrawIterationButtonClicked;
            btnResetFractal.Click += ResetFractalButtonClicked;
            btnBackgroundColor.Click += BackgroundColorButtonCliked;
            btnLineColor.Click += LineColorButtonCliked;
            isFractalFit = cbFitFractal.Checked;
        }

        public void DrawChaos(IEnumerable<Fractal> fractals)
        {
            var random = new Random();
            btnNextIteration.Enabled = false;
            cbFitFractal.Enabled = false;

            SetBackgroundColor();

            Bitmap fractalImage = GetDrawingImage();
            foreach (Fractal fractal in fractals)
            {
                this.fractal = fractal;
                lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                for (int iterationIndex = 0; iterationIndex < 5; iterationIndex++)
                {
                    GenerateFractal(graphics);
                }
            }

            pbFractalSpace.Image = fractalImage;
        }

        public void SetCurrentFractal(Fractal fractal)
        {
            this.fractal = fractal;
            btnNextIteration.Text = "Draw";
            count = 0;
            pbFractalSpace.Image = new Bitmap(1, 1);

            if (fractal.GetType().Equals(typeof(Tree)))
            {
                Bitmap fractalImage = GetDrawingImage();

                for (int iterationIndex = 0; iterationIndex < 3; iterationIndex++)
                {
                    fractal.LineLength -= 10;
                    GenerateFractal(graphics);
                }

                pbFractalSpace.Image = fractalImage;
            }
        }

        private void BackgroundColorButtonCliked(object sender, EventArgs e)
        {
            SetBackgroundColor();
        }

        private void SetBackgroundColor()
        {
            customColorDialog.Title = "Choose background color";
            customColorDialog.ShowDialog(Form.ActiveForm);
            backgroundColor = customColorDialog.Color;
        }

        private void LineColorButtonCliked(object sender, EventArgs e)
        {
            customColorDialog.Title = "Choose line color";
            customColorDialog.ShowDialog();
            lineColor = customColorDialog.Color;
        }

        private void DrawIterationButtonClicked(object sender, EventArgs e)
        {
            if ((count <= fractal.MaximumNumberOfIterations && isFractalFit) || !isFractalFit)
            {
                btnNextIteration.Text = "Next iteration";
                Bitmap fractalImage = GetDrawingImage();
                graphics.Clear(backgroundColor);
                GenerateFractal(graphics);

                pbFractalSpace.Image = fractalImage;
                count++;
            }
            else
            {
                MessageBox.Show(
                    "Maximum iterations number was reached.",
                    "The fractal was drawn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private Bitmap GetDrawingImage()
        {
            var drawingPlace = new Bitmap(pbFractalSpace.Width, pbFractalSpace.Height);
            graphics = Graphics.FromImage(drawingPlace);

            return drawingPlace;
        }

        private void GenerateFractal(Graphics graphics)
        {
            fractal.X = fractal.InitialX;
            fractal.Y = fractal.InitialY;
            nUpDLineLength.Value = (int)fractal.LineLength;

            Cursor.Current = Cursors.WaitCursor;
            fractal.Axiom = fractal.SystemGenerator.Generate(fractal.Axiom);
            fractal.Generate(graphics, lineColor, (int)nUpDLineWidth.Value);
            Cursor.Current = Cursors.Default;
        }

        private void ResetFractalButtonClicked(object sender, EventArgs e)
        {
            fractal.Axiom = fractal.InitialAxiom;
            count = 0;
            fractal.LineLength = fractal.InitialLineLength;
            btnNextIteration.Text = "Draw";
            pbFractalSpace.Image = new Bitmap(1, 1);
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PNG File (*.png) | *.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFractalSpace.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        private void LineLengthValueChanged(object sender, EventArgs e)
        {
            fractal.LineLength = (int)nUpDLineLength.Value;
        }

        private void OnFitFractalMouseClicked(object sender, MouseEventArgs e)
        {
            isFractalFit = cbFitFractal.Checked;
        }
    }
}
