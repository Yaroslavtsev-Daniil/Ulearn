using System;

namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			Move(robot, width - 2, Direction.Right);
			for (int i = 1; i < ((height - 1) / 2); i++)
            {
				Move(robot, 3, Direction.Down);
				if (i%2 == 1) Move(robot, width - 2, Direction.Left);
				if (i % 2 == 0) Move(robot, width - 2, Direction.Right);
			}
		}
		private static void Move(Robot robot, int distance, Direction dir)
		{
			for (int i = 1; i < distance; i++) robot.MoveTo(dir);
		}
	}
}