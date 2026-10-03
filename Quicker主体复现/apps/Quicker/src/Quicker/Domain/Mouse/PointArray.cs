using System;
using System.Threading;
using System.Windows;

namespace Quicker.Domain.Mouse;

public class PointArray
{
	private readonly Point[] G6lt9rG7gIn;

	private int mnbt9peQNyj;

	private static PointArray f4jQTfQByyZAnxA6J2Bv;

	public int Count => mnbt9peQNyj;

	public PointArray(int maxCount)
	{
		G6lt9rG7gIn = new Point[maxCount];
	}

	public void Reset()
	{
		mnbt9peQNyj = 0;
	}

	public bool Add(Point point)
	{
		if (mnbt9peQNyj < G6lt9rG7gIn.Length)
		{
			G6lt9rG7gIn[mnbt9peQNyj] = point;
			Interlocked.Increment(ref mnbt9peQNyj);
			return true;
		}
		return false;
	}

	public Point Last()
	{
		try
		{
			if (mnbt9peQNyj > 0)
			{
				return G6lt9rG7gIn[mnbt9peQNyj - 1];
			}
			return new Point(0.0, 0.0);
		}
		catch (Exception)
		{
			return new Point(0.0, 0.0);
		}
	}

	public ArraySegment<Point> GetCurrent()
	{
		return new ArraySegment<Point>(G6lt9rG7gIn, 0, mnbt9peQNyj);
	}

	internal static bool j6L2OqQBpQw0HRDCAuhG()
	{
		return f4jQTfQByyZAnxA6J2Bv == null;
	}
}
