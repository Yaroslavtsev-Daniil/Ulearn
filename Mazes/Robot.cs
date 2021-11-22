using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mazes
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public class Robot
    {
        private readonly Maze maze;
        private readonly List<Point> path = new List<Point>();

        public Robot(Maze maze)
        {
            this.maze = maze;
            path.Add(maze.Robot);
        }

        public Point[] Path => path.ToArray();

        public int X => path[path.Count - 1].X;

        public int Y => path[path.Count - 1].Y;

        public bool Finished => maze.Exit.Equals(path[path.Count - 1]);

        public void MoveTo(Direction dir)
        {
            int[] dxs = {0, 0, -1, 1};
            int[] dys = {-1, 1, 0, 0};
            TryMoveTo(new Point(
                X + dxs[(int) dir],
                Y + dys[(int) dir]));
        }

        private void TryMoveTo(Point destination)
        {
            if (path.Count > 1000 || maze.IsWall(destination))
                throw new Exception("Robot is broken!");
            path.Add(destination);
        }

        public static Direction SetDirection(int width, int height)
        {
            if (height > width) return Direction.Down;
            else return Direction.Right;
        }

        public static Direction SetSecondDirection(int width, int height)
        {
            if (height > width) return Direction.Right;
            else return Direction.Down;
        }

        public static void Move(Robot robot, int distance, Direction dir)
        {
            for (int i = 0; i < distance; i++) robot.MoveTo(dir);
        }
    }
}