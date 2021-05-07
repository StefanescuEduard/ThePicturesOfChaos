using System;
using System.Collections.Generic;
using System.Drawing;

namespace ThePicturesOfChaos.Fractals
{
    public abstract class Fractal
    {
        public string Axiom { get; set; }

        public string InitialAxiom { get; set; }

        public SystemGenerator SystemGenerator { get; protected set; }

        public float LineLength { get; set; }

        public float InitialLineLength { get; set; }

        public float X { get; set; }

        public float InitialX { get; set; }

        public float Y { get; set; }

        public float InitialY { get; set; }

        public int MaximumNumberOfIterations { get; protected set; }

        public float RotationAngle { get; protected set; }

        public float Angle { get; set; }

        public bool UseAutoLineLength { get; protected set; }

        public virtual void Generate(Graphics graphics, Color lineColor, int lineWidth)
        {
            var stack = new Stack<LastInformation>();

            foreach (var currentChar in Axiom)
            {
                if (currentChar == 'F')
                {
                    var newX = X + (float)(Math.Cos(Angle) * LineLength);
                    var newY = Y + (float)(Math.Sin(Angle) * LineLength);

                    using (var pen = new Pen(lineColor, lineWidth))
                    {
                        graphics.DrawLine(pen, X, Y, newX, newY);
                    }

                    X = newX;
                    Y = newY;
                }
                else if (currentChar == '+')
                {
                    Angle += RotationAngle;
                }
                else if (currentChar == '-')
                {
                    Angle -= RotationAngle;
                }
                else if (currentChar == '[')
                {
                    stack.Push(new LastInformation(X, Y, Angle));
                }
                else if (currentChar == ']')
                {
                    LastInformation lastInformation = stack.Pop();
                    X = lastInformation.X;
                    Y = lastInformation.Y;
                    Angle = lastInformation.Angle;
                }
            }

            if (LineLength > 1 && UseAutoLineLength)
            {
                LineLength -= 1;
            }
        }
    }
}
