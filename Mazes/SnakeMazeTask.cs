using System;

namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
		Robot.Move(robot, width - 3, Direction.Right);
			for (int i = 1; i < ((height - 1) / 2); i++)
            {
				Robot.Move(robot, 2, Direction.Down);
				if (i%2 == 1) Robot.Move(robot, width - 3, Direction.Left);
				if (i % 2 == 0) Robot.Move(robot, width - 3, Direction.Right);
			}
		}
	}
}