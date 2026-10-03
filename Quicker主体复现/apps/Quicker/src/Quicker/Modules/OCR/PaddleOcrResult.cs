using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Quicker.Modules.OCR;

public class PaddleOcrResult
{
	public class Rect
	{
		[CompilerGenerated]
		private int p04v69M3MHV;

		[CompilerGenerated]
		private int DfYv6hhCywt;

		[CompilerGenerated]
		private int bLjv6e2K5uB;

		[CompilerGenerated]
		private int hoBv6YNi8UK;

		private static Rect dfOdqCcxIWxasT7gOdCD;

		public int Left
		{
			[CompilerGenerated]
			get
			{
				return p04v69M3MHV;
			}
			[CompilerGenerated]
			set
			{
				p04v69M3MHV = value;
			}
		}

		public int Top
		{
			[CompilerGenerated]
			get
			{
				return DfYv6hhCywt;
			}
			[CompilerGenerated]
			set
			{
				DfYv6hhCywt = value;
			}
		}

		public int Right
		{
			[CompilerGenerated]
			get
			{
				return bLjv6e2K5uB;
			}
			[CompilerGenerated]
			set
			{
				bLjv6e2K5uB = value;
			}
		}

		public int Bottom
		{
			[CompilerGenerated]
			get
			{
				return hoBv6YNi8UK;
			}
			[CompilerGenerated]
			set
			{
				hoBv6YNi8UK = value;
			}
		}

		public Rect()
		{
		}

		public Rect(Rectangle rectangle)
		{
			Left = rectangle.X;
			Top = rectangle.Y;
			Right = rectangle.Right;
			Bottom = rectangle.Bottom;
		}

		internal static bool tDHnBjcx63inOg29eBBo()
		{
			return dfOdqCcxIWxasT7gOdCD == null;
		}
	}

	public class Region
	{
		[CompilerGenerated]
		private string Qrqv6IVCS2a;

		[CompilerGenerated]
		private double rYxv6WgdHv0;

		[CompilerGenerated]
		private Rect sm8v6kqdNDB;

		private static Region tISyFTcxSG8uxBipskqj;

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return Qrqv6IVCS2a;
			}
			[CompilerGenerated]
			set
			{
				Qrqv6IVCS2a = value;
			}
		}

		public double Confidence
		{
			[CompilerGenerated]
			get
			{
				return rYxv6WgdHv0;
			}
			[CompilerGenerated]
			set
			{
				rYxv6WgdHv0 = value;
			}
		}

		public Rect Rect
		{
			[CompilerGenerated]
			get
			{
				return sm8v6kqdNDB;
			}
			[CompilerGenerated]
			set
			{
				sm8v6kqdNDB = value;
			}
		}

		internal static bool a5PKIVcxwEfIX8IZpaTW()
		{
			return tISyFTcxSG8uxBipskqj == null;
		}
	}

	public class ResultItem
	{
		[CompilerGenerated]
		private string u9iv6GaRYkM;

		[CompilerGenerated]
		private IList<Region> ctev6s5hhou;

		internal static ResultItem edvXfxcxmlMwdKlO5ADm;

		public string Lines
		{
			[CompilerGenerated]
			get
			{
				return u9iv6GaRYkM;
			}
			[CompilerGenerated]
			set
			{
				u9iv6GaRYkM = value;
			}
		}

		public IList<Region> Regions
		{
			[CompilerGenerated]
			get
			{
				return ctev6s5hhou;
			}
			[CompilerGenerated]
			set
			{
				ctev6s5hhou = value;
			}
		}

		internal static bool WG9AN7cxsY8g02ZUTZCK()
		{
			return edvXfxcxmlMwdKlO5ADm == null;
		}
	}

	public class Info
	{
		[CompilerGenerated]
		private double qHfv6HolfDp;

		[CompilerGenerated]
		private IDictionary<string, double> fKVv61sBCg2;

		internal static Info kejgcHcx7WXA6AjRQoHE;

		public double total_elapse
		{
			[CompilerGenerated]
			get
			{
				return qHfv6HolfDp;
			}
			[CompilerGenerated]
			set
			{
				qHfv6HolfDp = value;
			}
		}

		public IDictionary<string, double> elapse_part
		{
			[CompilerGenerated]
			get
			{
				return fKVv61sBCg2;
			}
			[CompilerGenerated]
			set
			{
				fKVv61sBCg2 = value;
			}
		}

		internal static bool bQWEtXcx4r3PAeO8a869()
		{
			return kejgcHcx7WXA6AjRQoHE == null;
		}
	}

	[CompilerGenerated]
	private bool mehtyuA2nCI = true;

	[CompilerGenerated]
	private string Ae8tyNyeg5i;

	[CompilerGenerated]
	private ResultItem aKctyJ19pfS;

	private static PaddleOcrResult hp7tqwQD4c6RtYE6tdWo;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return mehtyuA2nCI;
		}
		[CompilerGenerated]
		set
		{
			mehtyuA2nCI = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return Ae8tyNyeg5i;
		}
		[CompilerGenerated]
		set
		{
			Ae8tyNyeg5i = value;
		}
	}

	public ResultItem Result
	{
		[CompilerGenerated]
		get
		{
			return aKctyJ19pfS;
		}
		[CompilerGenerated]
		set
		{
			aKctyJ19pfS = value;
		}
	}

	internal static bool YkbeKKQDhNBB9RAqA8aF()
	{
		return hp7tqwQD4c6RtYE6tdWo == null;
	}
}
