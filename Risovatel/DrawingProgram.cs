using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Painter
    {
        static float x, y;
        static Graphics impossibleSquare;

        public static void InitializeNewPicture(Graphics newPicture)
        {
            impossibleSquare = newPicture;
            impossibleSquare.SmoothingMode = SmoothingMode.None;
            impossibleSquare.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void DrawPath(Pen pen, double length, double angle)
        {
            //Делает шаг длиной length в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            impossibleSquare.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ChangePosition(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle));
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        private static readonly float bigLineMultiplier = 0.375f;
        private static readonly float smallLineMultiplier = 0.04f;
        public static void Draw(int width, int height, double turningAngle, Graphics picture)
        {
            // turningAngle пока не используется, но будет использоваться в будущем
            Painter.InitializeNewPicture(picture);

            var lineLength = Math.Min(width, height);

            var diagonalLength = Math.Sqrt(2) * (lineLength * bigLineMultiplier + lineLength * smallLineMultiplier) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Painter.SetPosition(x0, y0);

            DrawLine1(lineLength);
            DrawLine2(lineLength);
            DrawLine3(lineLength);
            DrawLine4(lineLength);
        }

        private static void DrawLine4(int lineLength)
        {
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, Math.PI / 2);
            Painter.DrawPath(Pens.Yellow, lineLength * smallLineMultiplier * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, Math.PI / 2 + Math.PI);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier - lineLength * smallLineMultiplier, Math.PI / 2 + Math.PI / 2);

            Painter.ChangePosition(lineLength * smallLineMultiplier, Math.PI / 2 - Math.PI);
            Painter.ChangePosition(lineLength * smallLineMultiplier * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }

        private static void DrawLine3(int lineLength)
        {
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, Math.PI);
            Painter.DrawPath(Pens.Yellow, lineLength * smallLineMultiplier * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, Math.PI + Math.PI);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier - lineLength * smallLineMultiplier, Math.PI + Math.PI / 2);

            Painter.ChangePosition(lineLength * smallLineMultiplier, Math.PI - Math.PI);
            Painter.ChangePosition(lineLength * smallLineMultiplier * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
        }

        private static void DrawLine2(int lineLength)
        {
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, -Math.PI / 2);
            Painter.DrawPath(Pens.Yellow, lineLength * smallLineMultiplier * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, -Math.PI / 2 + Math.PI);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier - lineLength * smallLineMultiplier, -Math.PI / 2 + Math.PI / 2);

            Painter.ChangePosition(lineLength * smallLineMultiplier, -Math.PI / 2 - Math.PI);
            Painter.ChangePosition(lineLength * smallLineMultiplier * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
        }

        private static void DrawLine1(int lineLength)
        {
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, 0);
            Painter.DrawPath(Pens.Yellow, lineLength * smallLineMultiplier * Math.Sqrt(2), Math.PI / 4);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier, Math.PI);
            Painter.DrawPath(Pens.Yellow, lineLength * bigLineMultiplier - lineLength * smallLineMultiplier, Math.PI / 2);

            Painter.ChangePosition(lineLength * smallLineMultiplier, -Math.PI);
            Painter.ChangePosition(lineLength * smallLineMultiplier * Math.Sqrt(2), 3 * Math.PI / 4);
        }
    }
}