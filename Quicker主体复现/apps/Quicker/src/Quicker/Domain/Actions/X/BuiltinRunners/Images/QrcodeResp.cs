using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class QrcodeResp
{
	public class Rect
	{
		[CompilerGenerated]
		private int AfcSc2frc4E;

		[CompilerGenerated]
		private int HweScugh0lV;

		[CompilerGenerated]
		private int kM1ScNLwCH7;

		[CompilerGenerated]
		private int NkHScJXUGlD;

		private static Rect WxOriiWrQXoMMwoDDLNg;

		public int Left
		{
			[CompilerGenerated]
			get
			{
				return AfcSc2frc4E;
			}
			[CompilerGenerated]
			set
			{
				AfcSc2frc4E = value;
			}
		}

		public int Top
		{
			[CompilerGenerated]
			get
			{
				return HweScugh0lV;
			}
			[CompilerGenerated]
			set
			{
				HweScugh0lV = value;
			}
		}

		public int Right
		{
			[CompilerGenerated]
			get
			{
				return kM1ScNLwCH7;
			}
			[CompilerGenerated]
			set
			{
				kM1ScNLwCH7 = value;
			}
		}

		public int Bottom
		{
			[CompilerGenerated]
			get
			{
				return NkHScJXUGlD;
			}
			[CompilerGenerated]
			set
			{
				NkHScJXUGlD = value;
			}
		}

		internal static bool LmjrQpWrFZrclFvd3uwg()
		{
			return WxOriiWrQXoMMwoDDLNg == null;
		}
	}

	public class ResultItem
	{
		[CompilerGenerated]
		private Rect rsMSc0iNeUb;

		[CompilerGenerated]
		private string g35ScCHK2AN;

		internal static ResultItem CJXi2VWrWosiSQqCxuZD;

		public Rect Rect
		{
			[CompilerGenerated]
			get
			{
				return rsMSc0iNeUb;
			}
			[CompilerGenerated]
			set
			{
				rsMSc0iNeUb = value;
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return g35ScCHK2AN;
			}
			[CompilerGenerated]
			set
			{
				g35ScCHK2AN = value;
			}
		}

		internal static bool LYUxO9WryH0Nsf82SUCt()
		{
			return CJXi2VWrWosiSQqCxuZD == null;
		}
	}

	[CompilerGenerated]
	private bool yFxgRCKpjmv = true;

	[CompilerGenerated]
	private string? dIFgRPs0WHF;

	[CompilerGenerated]
	private IList<ResultItem> O8rgREh43cf;

	internal static QrcodeResp BNwqNnQ6boBCes0uoHHx;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return yFxgRCKpjmv;
		}
		[CompilerGenerated]
		set
		{
			yFxgRCKpjmv = value;
		}
	}

	public string? Message
	{
		[CompilerGenerated]
		get
		{
			return dIFgRPs0WHF;
		}
		[CompilerGenerated]
		set
		{
			dIFgRPs0WHF = value;
		}
	}

	public IList<ResultItem> Items
	{
		[CompilerGenerated]
		get
		{
			return O8rgREh43cf;
		}
		[CompilerGenerated]
		set
		{
			O8rgREh43cf = value;
		}
	}

	internal static bool a0Vh6vQ6qlErRZeHXqbE()
	{
		return BNwqNnQ6boBCes0uoHHx == null;
	}
}
