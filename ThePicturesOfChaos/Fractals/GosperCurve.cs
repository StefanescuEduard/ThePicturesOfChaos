using System;

namespace ThePicturesOfChaos.Fractals
{
    public class GosperCurve : Fractal
    {
        public GosperCurve(float controlWidth)
        {
            Axiom = "XF";
            InitialAxiom = Axiom;
            SystemGenerator = new SystemGenerator(new[]
                {
                    new Rule("X", "X+YF++YF-FX--FXFX-YF+"),
                    new Rule("Y", "-FX+YFYF++YF+FX--FX-Y")
                });
            LineLength = 3;
            InitialLineLength = LineLength;
            X = (float)controlWidth / 2 + 110;
            InitialX = X;
            Y = 150;
            InitialY = Y;
            MaximumNumberOfIterations = 4;
            RotationAngle = (float)Math.PI / 3;
            Angle = 0;
            UseAutoLineLength = false;
        }
    }
}
