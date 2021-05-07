using System;

namespace ThePicturesOfChaos.Fractals
{
    public class LeviCurve : Fractal
    {
        public LeviCurve(float controlWidth, float controlHeight)
        {
            Axiom = "F++F++F++F";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("F", "-F++F-")
                });
            LineLength = 10;
            InitialLineLength = LineLength;
            X = (float)controlWidth / 2 - 100;
            InitialX = X;
            Y = (float)controlHeight / 2 - 125;
            InitialY = Y;
            MaximumNumberOfIterations = 8;
            RotationAngle = (float)Math.PI / 4;
            Angle = 0;
            UseAutoLineLength = false;
        }
    }
}
