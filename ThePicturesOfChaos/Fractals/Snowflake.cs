using System;

namespace ThePicturesOfChaos.Fractals
{
    public class Snowflake : Fractal
    {
        public Snowflake(float controlHeight)
        {
            Axiom = "F";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("F", "F-F+F+F-F")
                });
            LineLength = 11;
            InitialLineLength = LineLength;
            X = 80;
            InitialX = X;
            Y = controlHeight / 2 + 250;
            InitialY = Y;
            MaximumNumberOfIterations = 3;
            RotationAngle = (float)Math.PI / 2;
            Angle = 0;
            UseAutoLineLength = false;
        }
    }
}
