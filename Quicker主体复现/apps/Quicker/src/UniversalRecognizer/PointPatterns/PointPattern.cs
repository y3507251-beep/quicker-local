using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Newtonsoft.Json;

namespace UniversalRecognizer.PointPatterns;

public class PointPattern
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec vSrv897MYma;

		public static Func<Point, System.Windows.Point> f94v8h31La6;

		internal static _003C_003Ec xCinAYcGKR6kEdWoKGiL;

		static _003C_003Ec()
		{
			vSrv897MYma = new _003C_003Ec();
		}

		internal System.Windows.Point tU5v8Z5U36s(Point x)
		{
			return new System.Windows.Point(x.X, x.Y);
		}

		internal static bool hDdAPPcGBA6MrRitNSdo()
		{
			return xCinAYcGKR6kEdWoKGiL == null;
		}
	}

	[CompilerGenerated]
	private string z9raNjigDM;

	[CompilerGenerated]
	private string GSTaJxj6fo;

	private IList<System.Windows.Point> PX8a0h5Rvg;

	private IList<Point> S5KaCH9Jq7;

	private static PointPattern MZ9uUxdL8YeJ2lwnpqK;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return z9raNjigDM;
		}
		[CompilerGenerated]
		set
		{
			z9raNjigDM = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return GSTaJxj6fo;
		}
		[CompilerGenerated]
		set
		{
			GSTaJxj6fo = value;
		}
	}

	public IList<Point> Points
	{
		get
		{
			return S5KaCH9Jq7;
		}
		set
		{
			S5KaCH9Jq7 = value;
			ResetWindowsPoints();
		}
	}

	[JsonIgnore]
	public IList<System.Windows.Point> WindowsPoints
	{
		get
		{
			if (PX8a0h5Rvg == null)
			{
				PX8a0h5Rvg = Points.Select(_003C_003Ec.f94v8h31La6 ?? (_003C_003Ec.f94v8h31La6 = _003C_003Ec.vSrv897MYma.tU5v8Z5U36s)).ToList();
			}
			return PX8a0h5Rvg;
		}
	}

	public PointPattern()
	{
		Points = new Point[0];
	}

	public PointPattern(string id, string name, IList<Point> points)
	{
		Id = id;
		Name = name;
		Points = points;
	}

	public void ResetWindowsPoints()
	{
		PX8a0h5Rvg = null;
	}

	internal static bool P394oLduPjEsXEDpl8D()
	{
		return MZ9uUxdL8YeJ2lwnpqK == null;
	}
}
