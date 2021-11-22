using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            width = width - 2;
            height = height - 2;

            Direction fDir = SetDirection(width, height);
            Direction sDir = SetSecondDirection(width, height);

            int fstep = Math.Max(width, height) / Math.Min(width, height);
            int steps = ((Math.Max(width, height) - 1) / fstep) - 1;

            for (int i = 0; i < steps; i++)
            {
                Move(robot, fstep, fDir);
                Move(robot, 1, sDir);
            }
            Move(robot, fstep, fDir);
        }
        private static Direction SetDirection(int width, int height)
        {
            if (height > width) return Direction.Down;
            else return Direction.Right;
        }
        private static Direction SetSecondDirection(int width, int height)
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