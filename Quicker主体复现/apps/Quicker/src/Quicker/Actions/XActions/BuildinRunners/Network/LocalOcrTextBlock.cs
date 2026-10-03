using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Public.Extensions;

namespace Quicker.Actions.XActions.BuildinRunners.Network;

public class LocalOcrTextBlock
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec YmlSXgq2hGo;

		public static Func<LocalOCRPoint, int> s3NSXLVtJU0;

		public static Func<LocalOCRPoint, int> a9eSXvnO8m8;

		public static Func<LocalOCRPoint, string> irTSXSF3Gyn;

		private static _003C_003Ec KT8mBlWloIu6NCN9LU4c;

		static _003C_003Ec()
		{
			YmlSXgq2hGo = new _003C_003Ec();
		}

		internal int vUFS6zRxNKL(LocalOCRPoint x)
		{
			return x.X;
		}

		internal int ofiSXwvqAa2(LocalOCRPoint x)
		{
			return x.Y;
		}

		internal string WBSSXtmS2fS(LocalOCRPoint x)
		{
			return x.ToString();
		}

		internal static bool glbtiZWlfvpjLNdKxvTB()
		{
			return KT8mBlWloIu6NCN9LU4c == null;
		}
	}

	[CompilerGenerated]
	private List<LocalOCRPoint> LLWgQNMx1uh = new List<LocalOCRPoint>();

	[CompilerGenerated]
	private string KNJgQJPaBb9;

	[CompilerGenerated]
	private float mQEgQ0CRr1X;

	internal static LocalOcrTextBlock cjUhexQHCoI19OEC3jKo;

	public List<LocalOCRPoint> BoxPoints
	{
		[CompilerGenerated]
		get
		{
			return LLWgQNMx1uh;
		}
		[CompilerGenerated]
		set
		{
			LLWgQNMx1uh = value;
		}
	}

	[JsonIgnore]
	public LocalOCRPoint Core
	{
		get
		{
			if (!BoxPoints.HasData())
			{
				return new LocalOCRPoint(0, 0);
			}
			return new LocalOCRPoint((int)BoxPoints.Average(_003C_003Ec.s3NSXLVtJU0 ?? (_003C_003Ec.s3NSXLVtJU0 = _003C_003Ec.YmlSXgq2hGo.vUFS6zRxNKL)), (int)BoxPoints.Average(_003C_003Ec.a9eSXvnO8m8 ?? (_003C_003Ec.a9eSXvnO8m8 = _003C_003Ec.YmlSXgq2hGo.ofiSXwvqAa2)));
		}
	}

	[JsonIgnore]
	public Rectangle Rect => new Rectangle(BoxPoints[0].X, BoxPoints[0].Y, BoxPoints[1].X - BoxPoints[0].X, BoxPoints[3].Y - BoxPoints[0].Y);

	[JsonIgnore]
	public int Height => (BoxPoints[3].Y - BoxPoints[0].Y + (BoxPoints[2].Y - BoxPoints[1].Y)) / 2;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return KNJgQJPaBb9;
		}
		[CompilerGenerated]
		set
		{
			KNJgQJPaBb9 = value;
		}
	}

	public float Score
	{
		[CompilerGenerated]
		get
		{
			return mQEgQ0CRr1X;
		}
		[CompilerGenerated]
		set
		{
			mQEgQ0CRr1X = value;
		}
	}

	public int GetCharAvgWidth()
	{
		return (BoxPoints[1].X - BoxPoints[0].X + (BoxPoints[2].X - BoxPoints[3].X)) / 2 / Text.Length;
	}

	public override string ToString()
	{
		string arg = string.Join(",", BoxPoints.Select(_003C_003Ec.irTSXSF3Gyn ?? (_003C_003Ec.irTSXSF3Gyn = _003C_003Ec.YmlSXgq2hGo.WBSSXtmS2fS)).ToArray());
		return $"{Text},{Score},[{arg}]";
	}

	internal static bool kUnVlgQH72aGkwgRhs2Z()
	{
		return cjUhexQHCoI19OEC3jKo == null;
	}
}
