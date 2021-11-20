using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			Move(robot, height - 2, Direction.Down);
			Move(robot, width - 2, Direction.Right);
		}
		private static void Move(Robot robot, int distance, Direction dir)
		{
			for (int i = 1; i < distance; i++) robot.MoveTo(dir);
		}
	}
}