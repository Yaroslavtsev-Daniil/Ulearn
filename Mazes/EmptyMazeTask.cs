using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			Robot.Move(robot, height - 3, Direction.Down);
			Robot.Move(robot, width - 3, Direction.Right);
		}
	}
}