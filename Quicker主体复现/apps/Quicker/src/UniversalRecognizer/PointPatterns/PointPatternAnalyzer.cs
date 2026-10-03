using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Quicker.Public.Extensions;

namespace UniversalRecognizer.PointPatterns;

public class PointPatternAnalyzer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fOxv8Y1731o;

		public static Func<PointPatternMatchResult, double> oU6v8IAot0k;

		internal static _003C_003Ec lwhoqIcGdMXYU9rmtPmv;

		static _003C_003Ec()
		{
			fOxv8Y1731o = new _003C_003Ec();
		}

		internal double vsYv8eouqel(PointPatternMatchResult ppmr)
		{
			return ppmr.Probability;
		}

		internal static bool b0BE6McGOeLOpItAVUNx()
		{
			return lwhoqIcGdMXYU9rmtPmv == null;
		}

		internal static void ldaQTKcGkYIVE7iuxZQ1()
		{
		}
	}

	private double[] clpayoT6P6 = new double[100];

	[CompilerGenerated]
	private int GqCa8XAY0r;

	[CompilerGenerated]
	private List<PointPattern> sk8aap9SR8;

	private IDictionary<PointPattern, double[]> ipia7WrYLd = new Dictionary<PointPattern, double[]>();

	private static PointPatternAnalyzer n9QMmPdfOsBJNBs3wVT;

	public int Precision
	{
		[CompilerGenerated]
		get
		{
			return GqCa8XAY0r;
		}
		[CompilerGenerated]
		set
		{
			GqCa8XAY0r = value;
		}
	}

	public List<PointPattern> PointPatternSet
	{
		[CompilerGenerated]
		get
		{
			return sk8aap9SR8;
		}
		[CompilerGenerated]
		set
		{
			sk8aap9SR8 = value;
		}
	}

	public PointPatternAnalyzer()
		: this(new PointPattern[0], 100)
	{
	}

	public PointPatternAnalyzer(IEnumerable<PointPattern> pointPatternSet)
		: this(pointPatternSet, 100)
	{
	}

	public PointPatternAnalyzer(IEnumerable<PointPattern> pointPatternSet, int precision)
	{
		PointPatternSet = pointPatternSet.ToList();
		Precision = precision;
	}

	public PointPatternMatchResult[] GetPointPatternMatchResults(IList<System.Windows.Point> points)
	{
		if (!points.HasData())
		{
			return new PointPatternMatchResult[0];
		}
		if (points.Count < 2)
		{
			return new PointPatternMatchResult[0];
		}
		List<PointPatternMatchResult> list = new List<PointPatternMatchResult>();
		new List<PointPatternMatchResult>();
		double[] pointArrayAngles = PointPatternMath.GetPointArrayAngles(PointPatternMath.GetInterpolatedPointArray(points, Precision));
		foreach (PointPattern item in PointPatternSet)
		{
			PointPatternMatchResult pointPatternMatchResult = Jn7aPMgE30(item, pointArrayAngles);
			list.Add(new PointPatternMatchResult(item.Id, pointPatternMatchResult.Probability, pointPatternMatchResult.PointPatternSetCount));
		}
		return list.OrderByDescending(_003C_003Ec.oU6v8IAot0k ?? (_003C_003Ec.oU6v8IAot0k = _003C_003Ec.fOxv8Y1731o.vsYv8eouqel)).ToArray();
	}

	private PointPatternMatchResult Jn7aPMgE30(PointPattern pointPattern_0, double[] double_1)
	{
		double[] array = clpayoT6P6;
		double[] array2 = Yu4aEd0vry(pointPattern_0);
		for (int i = 0; i <= array2.Length - 1; i++)
		{
			array[i] = PointPatternMath.GetDotProduct(array2[i], double_1[i]);
		}
		double probabilityFromDotProduct = PointPatternMath.GetProbabilityFromDotProduct(array.Average());
		return new PointPatternMatchResult(pointPattern_0.Id, probabilityFromDotProduct, 1);
	}

	private double[] Yu4aEd0vry(PointPattern pointPattern_0)
	{
		if (ipia7WrYLd.TryGetValue(pointPattern_0, out var value))
		{
			return value;
		}
		double[] pointArrayAngles = PointPatternMath.GetPointArrayAngles(PointPatternMath.GetInterpolatedPointArray(pointPattern_0.WindowsPoints, Precision));
		ipia7WrYLd[pointPattern_0] = pointArrayAngles;
		return pointArrayAngles;
	}

	public void ResetCache()
	{
		ipia7WrYLd.Clear();
	}

	internal static bool B1DRpydbRELxxBJ62GL()
	{
		return n9QMmPdfOsBJNBs3wVT == null;
	}
}
