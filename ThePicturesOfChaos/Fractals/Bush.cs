using System;

namespace ThePicturesOfChaos.Fractals
{
    public class Bush : Fractal
    {
        public Bush(float controlWidth, float controlHeight)
        {
            Axiom = "F";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("F", "F[+FF][-FF]F[-F][+F]F")
                });
            LineLength = 8;
            InitialLineLength = LineLength;
            X = (float)controlWidth / 2;
            InitialX = X;
            Y = (float)controlHeight - 30;
            InitialY = Y;
            MaximumNumberOfIterations = 3;
            RotationAngle = (float)Math.PI / 5;
            Angle = 3 * (float)Math.PI / 2;
            UseAutoLineLength = false;
        }
    }
}
