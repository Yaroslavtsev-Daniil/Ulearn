using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int step = StepOnMainDirection(width, height);            
            int steps = ((Math.Max(width, height) - 1) / step) - 2;

            Move(robot, step, СhooseDirection(width, height));

            for (int i = 0; i < steps; i++)
            {
                Move(robot, 1, СhooseSecondDirection(width, height));
                Move(robot, step, СhooseDirection(width, height));
            }
        }
        private static int StepOnMainDirection(int width, int height)
        {
            return Math.Max(width, height) / (Math.Min(width, height) - 1);
            /*if ((Math.Max(width, height) / Math.Min(width, height)) > 1) return Math.Max(width, height) / (Math.Min(width, height) - 1);
            else return 2;*/
        }
        private static Direction СhooseDirection(int width, int height)
        {
            if (height > width) return Direction.Down;
            else return Direction.Right;
        }
        private static Direction СhooseSecondDirection(int width, int height)
        {
            if (height > width) return Direction.Right;
            else return Direction.Down;
        }
        private static void Move(Robot robot, int distance, Direction dir)
        {
            for (int i = 0; i < distance; i++) robot.MoveTo(dir);
        }
    }
}