using System;

namespace ThePicturesOfChaos.Fractals
{
    public class Reed : Fractal
    {
        public Reed(float controlHeight)
        {
            Axiom = "Y";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("X", "X[-FFF][+FFF]FX"),
                    new Rule("Y", "YFX[+Y][-Y]")
                });
            LineLength = 10;
            InitialLineLength = LineLength;
            X = 0;
            InitialX = X;
            Y = controlHeight - 30;
            InitialY = Y;
            MaximumNumberOfIterations = 6;
            RotationAngle = (float)Math.PI / 7;
            Angle = 7 * (float)Math.PI / 3.75f;
            UseAutoLineLength = true;
        }
    }
}
