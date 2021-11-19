using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			MoveRight(robot, width);
			MoveDown(robot, height);
		}
        private static void MoveDown(Robot robot, int height)
        {
			for (int i = 1; i < height - 2; i++)
			{
				robot.MoveTo(Direction.Down);
			}
		}
        private static void MoveRight(Robot robot, int width)
        {
			for (int i = 1; i < width - 2; i++)
			{
				robot.MoveTo(Direction.Right);
			}
		}
    }
}