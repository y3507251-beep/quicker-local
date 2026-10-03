using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Ink;
using System.Windows.Input;
using Newtonsoft.Json;

namespace Quicker.Actions.XActions.BuildinRunners;

public static class Mathpix
{
	public class DataOptions
	{
		[CompilerGenerated]
		private bool AvsSkWpjL03;

		[CompilerGenerated]
		private bool nNbSkk5yiSi;

		[CompilerGenerated]
		private bool FQaSkGkdBc6;

		internal static DataOptions PTbX5rWfoeWVMbVwQLWc;

		public bool include_latex
		{
			[CompilerGenerated]
			get
			{
				return AvsSkWpjL03;
			}
			[CompilerGenerated]
			set
			{
				AvsSkWpjL03 = value;
			}
		}

		public bool include_mathml
		{
			[CompilerGenerated]
			get
			{
				return nNbSkk5yiSi;
			}
			[CompilerGenerated]
			set
			{
				nNbSkk5yiSi = value;
			}
		}

		public bool include_asciimath
		{
			[CompilerGenerated]
			get
			{
				return FQaSkGkdBc6;
			}
			[CompilerGenerated]
			set
			{
				FQaSkGkdBc6 = value;
			}
		}

		public DataOptions()
		{
			include_latex = true;
		}

		static DataOptions()
		{
		}

		internal static bool RtwkpVWffQNoW8AoK7ly()
		{
			return PTbX5rWfoeWVMbVwQLWc == null;
		}

		internal static void l8DTUxWfqhKeMykQWTDY()
		{
		}
	}

	public class RootObject
	{
		[CompilerGenerated]
		private string UdrSksk40jU;

		[CompilerGenerated]
		private List<string> CCcSkHJR3k8;

		[CompilerGenerated]
		private DataOptions WA2Sk1x20hi;

		internal static RootObject iFZvdBWfi7OQBDKi9t9q;

		public string src
		{
			[CompilerGenerated]
			get
			{
				return UdrSksk40jU;
			}
			[CompilerGenerated]
			set
			{
				UdrSksk40jU = value;
			}
		}

		public List<string> formats
		{
			[CompilerGenerated]
			get
			{
				return CCcSkHJR3k8;
			}
			[CompilerGenerated]
			set
			{
				CCcSkHJR3k8 = value;
			}
		}

		public DataOptions data_options
		{
			[CompilerGenerated]
			get
			{
				return WA2Sk1x20hi;
			}
			[CompilerGenerated]
			set
			{
				WA2Sk1x20hi = value;
			}
		}

		public RootObject()
		{
			src = "";
			formats = new List<string>();
			data_options = new DataOptions();
		}

		internal static bool ebfvxoWfl7QFNpjSUVA4()
		{
			return iFZvdBWfi7OQBDKi9t9q == null;
		}
	}

	public class DataItem
	{
		[CompilerGenerated]
		private string v3sSkb91Nsh;

		[CompilerGenerated]
		private string wDCSk625gxL;

		internal static DataItem im98bMWf51ovkNLYf5Wc;

		public string type
		{
			[CompilerGenerated]
			get
			{
				return v3sSkb91Nsh;
			}
			[CompilerGenerated]
			set
			{
				v3sSkb91Nsh = value;
			}
		}

		public string value
		{
			[CompilerGenerated]
			get
			{
				return wDCSk625gxL;
			}
			[CompilerGenerated]
			set
			{
				wDCSk625gxL = value;
			}
		}

		internal static bool XvtZrVWfYJ7C0AnelprS()
		{
			return im98bMWf51ovkNLYf5Wc == null;
		}

		internal static void D1nOruWfRbVwmLcRFDmq()
		{
		}
	}

	public class RespJson
	{
		public int code;

		public string message;

		public int uses;

		public double confidence;

		public double confidence_rate;

		public string text;

		public string error;

		[CompilerGenerated]
		private List<DataItem> oPnSkXPy655;

		internal static RespJson TDfHeyWfgNErEWixfgkl;

		public List<DataItem> data
		{
			[CompilerGenerated]
			get
			{
				return oPnSkXPy655;
			}
			[CompilerGenerated]
			set
			{
				oPnSkXPy655 = value;
			}
		}

		public RespJson()
		{
			confidence = 0.0;
			confidence_rate = 0.0;
			text = "";
			data = new List<DataItem>();
		}

		internal static bool uIQjWSWfPwg8DabD00IM()
		{
			return TDfHeyWfgNErEWixfgkl == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LIvSkpunKKM;

		public static Func<StylusPoint, int> r5wSkBIkc2L;

		public static Func<Stroke, int[]> LEXSkQIFUZd;

		public static Func<StylusPoint, int> jDZSkjdZFeR;

		public static Func<Stroke, int[]> ykTSknJsvL8;

		internal static _003C_003Ec FEcvn1WfUA0bHfBR4js6;

		static _003C_003Ec()
		{
			LIvSkpunKKM = new _003C_003Ec();
		}

		internal int[] D4ZSkma7Wmt(Stroke stroke)
		{
			return stroke.StylusPoints.Select(r5wSkBIkc2L ?? (r5wSkBIkc2L = LIvSkpunKKM.HbISkK4VufC)).ToArray();
		}

		internal int HbISkK4VufC(StylusPoint p)
		{
			return (int)p.X;
		}

		internal int[] TQuSkxlaK4B(Stroke stroke)
		{
			return stroke.StylusPoints.Select(jDZSkjdZFeR ?? (jDZSkjdZFeR = LIvSkpunKKM.kh4SkrLT3Ih)).ToArray();
		}

		internal int kh4SkrLT3Ih(StylusPoint p)
		{
			return (int)p.Y;
		}

		internal static bool rX9KYQWfxkxtExKIZlo8()
		{
			return FEcvn1WfUA0bHfBR4js6 == null;
		}
	}

	private static object iUfY7yQCLacdihgVsCKZ;

	public static string CreateRequestContent(Image image)
	{
		using MemoryStream memoryStream = new MemoryStream();
		image.Save(memoryStream, ImageFormat.Jpeg);
		return oNRgblkYbt8(memoryStream.ToArray());
	}

	private static string oNRgblkYbt8(byte[] byte_0)
	{
		return CreateRequestContentFromSrc("data:image/jpeg;base64," + Convert.ToBase64String(byte_0));
	}

	public static string CreateRequestContentFromSrc(string src)
	{
		return JsonConvert.SerializeObject(new RootObject
		{
			formats = { "data", "text" },
			data_options = 
			{
				include_latex = true,
				include_mathml = true,
				include_asciimath = true
			},
			src = src
		});
	}

	public static string GetStrokesData(StrokeCollection strokes)
	{
		int[][] x = strokes.Select(_003C_003Ec.LEXSkQIFUZd ?? (_003C_003Ec.LEXSkQIFUZd = _003C_003Ec.LIvSkpunKKM.D4ZSkma7Wmt)).ToArray();
		int[][] y = strokes.Select(_003C_003Ec.ykTSknJsvL8 ?? (_003C_003Ec.ykTSknJsvL8 = _003C_003Ec.LIvSkpunKKM.TQuSkxlaK4B)).ToArray();
		return JsonConvert.SerializeObject(new _003C_003Ef__AnonymousType6<_003C_003Ef__AnonymousType7<_003C_003Ef__AnonymousType8<int[][], int[][]>>, string[], _003C_003Ef__AnonymousType9<bool, bool, bool>>(new _003C_003Ef__AnonymousType7<_003C_003Ef__AnonymousType8<int[][], int[][]>>(new _003C_003Ef__AnonymousType8<int[][], int[][]>(x, y)), new string[2] { "text", "data" }, new _003C_003Ef__AnonymousType9<bool, bool, bool>(true, true, true)));
	}

	internal static bool deUhO6QCuLwdu7qviURJ()
	{
		return iUfY7yQCLacdihgVsCKZ == null;
	}
}
