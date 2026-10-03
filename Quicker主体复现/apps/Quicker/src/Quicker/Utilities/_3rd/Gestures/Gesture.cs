using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using UniversalRecognizer.PointPatterns;

namespace Quicker.Utilities._3rd.Gestures;

public class Gesture : PointPattern
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec k9A2JJVGV17;

		public static Func<System.Windows.Point, UniversalRecognizer.PointPatterns.Point> G0o2J0eURwb;

		internal static _003C_003Ec Wj8HeUyva9lJWK23L2m4;

		static _003C_003Ec()
		{
			k9A2JJVGV17 = new _003C_003Ec();
		}

		internal UniversalRecognizer.PointPatterns.Point cnX2JNreINT(System.Windows.Point p)
		{
			return new UniversalRecognizer.PointPatterns.Point
			{
				X = p.X,
				Y = p.Y
			};
		}

		internal static bool AdfDlcyvrjMpco63cKha()
		{
			return Wj8HeUyva9lJWK23L2m4 == null;
		}
	}

	[CompilerGenerated]
	private DateTime ddRLzxahcV1;

	[CompilerGenerated]
	private DateTime UBxLzrKutUi;

	[CompilerGenerated]
	private bool nlcLzp2OqAo;

	internal static Gesture MrXXgcFmLpSoADMKxOcR;

	public DateTime CreateTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return ddRLzxahcV1;
		}
		[CompilerGenerated]
		set
		{
			ddRLzxahcV1 = value;
		}
	}

	public DateTime LastUpdateTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return UBxLzrKutUi;
		}
		[CompilerGenerated]
		set
		{
			UBxLzrKutUi = value;
		}
	}

	public bool IsDeleted
	{
		[CompilerGenerated]
		get
		{
			return nlcLzp2OqAo;
		}
		[CompilerGenerated]
		set
		{
			nlcLzp2OqAo = value;
		}
	}

	public Gesture()
	{
		base.Id = Guid.NewGuid().ToString();
	}

	public Gesture(string id, string name, IList<System.Windows.Point> points)
		: base(id, name, points.Select(_003C_003Ec.G0o2J0eURwb ?? (_003C_003Ec.G0o2J0eURwb = _003C_003Ec.k9A2JJVGV17.cnX2JNreINT)).ToArray())
	{
	}

	internal static bool IaVb13Fmu99MnhK2UonX()
	{
		return MrXXgcFmLpSoADMKxOcR == null;
	}
}
