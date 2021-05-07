using System;

namespace ThePicturesOfChaos.Fractals
{
    public class Tree : Fractal
    {
        public Tree(float controlWidth, float controlHeight)
        {
            Axiom = "F";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("F", "FF+[+F-F-F]-[-F+F+F]")
                });
            LineLength = 50;
            InitialLineLength = LineLength;
            X = (float)controlWidth / 2;
            InitialX = X;
            Y = (float)controlHeight - 30;
            InitialY = Y;
            MaximumNumberOfIterations = 4;
            RotationAngle = (float)Math.PI / 8;
            Angle = 3 * (float)Math.PI / 2;
            UseAutoLineLength = true;
        }
    }
}
