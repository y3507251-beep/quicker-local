using System;
using System.Collections.Generic;
using System.Windows;

namespace UniversalRecognizer.PointPatterns;

public static class PointPatternMath
{
	private static object vJLEP4d8MevoP3fADU7;

	public static System.Windows.Point[] GetInterpolatedPointArray(IList<System.Windows.Point> points, int segments)
	{
		List<System.Windows.Point> list = new List<System.Windows.Point>(segments);
		double num = GetPointArrayLength(points) / (double)segments;
		double num2 = 0.0;
		System.Windows.Point point = points[0];
		list.Add(point);
		for (int i = 1; i < points.Count; i++)
		{
			System.Windows.Point point2 = points[i];
			double distance = GetDistance(point, point2);
			double num3 = num2 + distance;
			if (num3 < num)
			{
				num2 = num3;
				point = point2;
				continue;
			}
			double interpolatePosition = (num - num2) * (1.0 / distance);
			System.Windows.Point interpolatedPoint = GetInterpolatedPoint(point, point2, interpolatePosition);
			list.Add(interpolatedPoint);
			if (list.Count == segments)
			{
				break;
			}
			point = interpolatedPoint;
			num2 = 0.0;
			i--;
		}
		return list.ToArray();
	}

	public static System.Windows.Point GetInterpolatedPoint(System.Windows.Point lineStartPoint, System.Windows.Point lineEndPoint, double interpolatePosition)
	{
		return new System.Windows.Point
		{
			X = (1.0 - interpolatePosition) * lineStartPoint.X + interpolatePosition * lineEndPoint.X,
			Y = (1.0 - interpolatePosition) * lineStartPoint.Y + interpolatePosition * lineEndPoint.Y
		};
	}

	public static double[] GetPointArrayAngles(System.Windows.Point[] pointArray)
	{
		List<double> list = new List<double>();
		for (int i = 1; i < pointArray.Length; i++)
		{
			list.Add(GetAngle(pointArray[i - 1], pointArray[i]));
		}
		return list.ToArray();
	}

	public static double GetAngle(System.Windows.Point lineStartPoint, System.Windows.Point lineEndPoint)
	{
		return Math.Atan2(lineEndPoint.Y - lineStartPoint.Y, lineEndPoint.X - lineStartPoint.X);
	}

	public static double GetDotProduct(double angle1, double angle2)
	{
		double num = ((angle1 > angle2) ? (angle1 - angle2) : (angle2 - angle1));
		if (num > Math.PI)
		{
			num = Math.PI - (num - Math.PI);
		}
		return num;
	}

	public static double GetProbabilityFromDotProduct(double dotProduct)
	{
		return Math.Abs(dotProduct * (100.0 / Math.PI) - 100.0);
	}

	public static double GetDegreeFromRadian(double angle)
	{
		return angle * (180.0 / Math.PI);
	}

	public static double GetDistance(System.Windows.Point lineStartPoint, System.Windows.Point lineEndPoint)
	{
		return GetDistance(lineStartPoint.X, lineStartPoint.Y, lineEndPoint.X, lineEndPoint.Y);
	}

	public static double GetDistance(double x1, double y1, double x2, double y2)
	{
		double num = x2 - x1;
		double num2 = y2 - y1;
		return Math.Sqrt(num * num + num2 * num2);
	}

	public static double GetPointArrayLength(IList<System.Windows.Point> points)
	{
		double num = 0.0;
		for (int i = 1; i < points.Count; i++)
		{
			num += GetDistance(points[i - 1], points[i]);
		}
		return num;
	}

	internal static bool l9XxtmdRSdBgWn9Uiqa()
	{
		return vJLEP4d8MevoP3fADU7 == null;
	}
}
