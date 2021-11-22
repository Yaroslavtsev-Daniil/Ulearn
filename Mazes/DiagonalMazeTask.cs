using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            width = width - 2;
            height = height - 2;

            Direction fDir = Robot.SetDirection(width, height);
            Direction sDir = Robot.SetSecondDirection(width, height);

            int fstep = Math.Max(width, height) / Math.Min(width, height);
            int steps = ((Math.Max(width, height) - 1) / fstep) - 1;

            for (int i = 0; i < steps; i++)
            {
                Robot.Move(robot, fstep, fDir);
                Robot.Move(robot, 1, sDir);
            }
            Robot.Move(robot, fstep, fDir);
        }
    }
}