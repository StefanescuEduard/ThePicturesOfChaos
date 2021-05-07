using System;

namespace ThePicturesOfChaos.Fractals
{
    public class Ancient : Fractal
    {
        public Ancient(int controlWidth)
        {
            Axiom = "F";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("F", "FXF"),
                    new Rule("X", "[-F+F+F]+F-F-F+"),
                });
            LineLength = 10;
            InitialLineLength = LineLength;
            X = controlWidth - 50;
            InitialX = X;
            Y = 50;
            InitialY = Y;
            MaximumNumberOfIterations = 8;
            RotationAngle = 2 * (float)Math.PI / 3;
            Angle = 4 * (float)Math.PI / 4.85f;
            UseAutoLineLength = true;
        }
    }
}
