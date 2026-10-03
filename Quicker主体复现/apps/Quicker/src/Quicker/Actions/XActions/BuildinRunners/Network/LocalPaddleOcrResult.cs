using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Quicker.Actions.XActions.BuildinRunners.Network;

public class LocalPaddleOcrResult
{
	public class TextBlock
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec Dfs2V8KJypZ;

			public static Func<OCRPoint, string> S4I2VaA5aWT;

			private static _003C_003Ec jlTWxAybYC6akDF7WEhG;

			static _003C_003Ec()
			{
				Dfs2V8KJypZ = new _003C_003Ec();
			}

			internal string KLo2VyCp3JR(OCRPoint x)
			{
				return x.ToString();
			}

			internal static bool w31BjMyb8FA2pBoq3onm()
			{
				return jlTWxAybYC6akDF7WEhG == null;
			}
		}

		[CompilerGenerated]
		private List<OCRPoint> S8ZSX2yQBZ7 = new List<OCRPoint>();

		[CompilerGenerated]
		private string Q6vSXu57LY3;

		[CompilerGenerated]
		private float ST4SXNu5i4N;

		internal static TextBlock zUKtZcWlq4ndjUBnsTSE;

		public List<OCRPoint> BoxPoints
		{
			[CompilerGenerated]
			get
			{
				return S8ZSX2yQBZ7;
			}
			[CompilerGenerated]
			set
			{
				S8ZSX2yQBZ7 = value;
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return Q6vSXu57LY3;
			}
			[CompilerGenerated]
			set
			{
				Q6vSXu57LY3 = value;
			}
		}

		public float Score
		{
			[CompilerGenerated]
			get
			{
				return ST4SXNu5i4N;
			}
			[CompilerGenerated]
			set
			{
				ST4SXNu5i4N = value;
			}
		}

		public override string ToString()
		{
			string arg = string.Join(",", BoxPoints.Select(_003C_003Ec.S4I2VaA5aWT ?? (_003C_003Ec.S4I2VaA5aWT = _003C_003Ec.Dfs2V8KJypZ.KLo2VyCp3JR)).ToArray());
			return $"{Text},{Score},[{arg}]";
		}

		internal static bool tvAKldWli4xv1Bvg4myB()
		{
			return zUKtZcWlq4ndjUBnsTSE == null;
		}
	}

	public class OCRPoint
	{
		public int X;

		public int Y;

		internal static OCRPoint tBfswbWlZkRy4W1LpIYP;

		public OCRPoint()
		{
		}

		public OCRPoint(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override string ToString()
		{
			return $"({X},{Y})";
		}

		internal static bool Hmdk7iWl5MPAMQDpxj53()
		{
			return tBfswbWlZkRy4W1LpIYP == null;
		}
	}

	[CompilerGenerated]
	private List<TextBlock> jNngQCLn61U = new List<TextBlock>();

	internal static LocalPaddleOcrResult lvfkWqQHh4w8uPy0Ug1T;

	public List<TextBlock> TextBlocks
	{
		[CompilerGenerated]
		get
		{
			return jNngQCLn61U;
		}
		[CompilerGenerated]
		set
		{
			jNngQCLn61U = value;
		}
	}

	internal static void LqisEuQzVRJ1ELJkxHtZ()
	{
	}

	internal static bool NqSSdBQHHeicJCTFbMxu()
	{
		return lvfkWqQHh4w8uPy0Ug1T == null;
	}
}
