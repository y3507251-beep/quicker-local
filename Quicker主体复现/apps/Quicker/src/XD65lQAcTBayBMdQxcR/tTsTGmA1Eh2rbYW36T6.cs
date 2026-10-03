using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Highlighting;
using Quicker;

namespace XD65lQAcTBayBMdQxcR;

internal static class tTsTGmA1Eh2rbYW36T6
{
	private sealed class OOmAgdu46wuFJYZTsb9 : HighlightingColor
	{
		[CompilerGenerated]
		private readonly Color I7RvY2vpNeA;

		private static OOmAgdu46wuFJYZTsb9 gAyBH9cioC9C6G5qt1AE;

		public Color Color
		{
			[CompilerGenerated]
			get
			{
				return I7RvY2vpNeA;
			}
		}

		public OOmAgdu46wuFJYZTsb9(Color color_1)
		{
			I7RvY2vpNeA = color_1;
			base.Foreground = new SimpleHighlightingBrush(color_1);
			Freeze();
		}

		internal static bool cg8qBRcifv1Rb1IBtMcJ()
		{
			return gAyBH9cioC9C6G5qt1AE == null;
		}
	}

	private static readonly OOmAgdu46wuFJYZTsb9 wewlyHniTD;

	private static readonly OOmAgdu46wuFJYZTsb9 e1Ml85duG6;

	private static readonly OOmAgdu46wuFJYZTsb9 QGOlaenkbG;

	private static readonly OOmAgdu46wuFJYZTsb9 xK8l7tb3oi;

	private static readonly OOmAgdu46wuFJYZTsb9 cr9lRrRhx5;

	private static readonly OOmAgdu46wuFJYZTsb9 ERLlqUF919;

	private static readonly OOmAgdu46wuFJYZTsb9 m7Ilcfv85E;

	private static readonly Dictionary<string, OOmAgdu46wuFJYZTsb9> oe0lV9khAP;

	private static readonly OOmAgdu46wuFJYZTsb9 sbGlZ5SFAR;

	private static readonly OOmAgdu46wuFJYZTsb9 FLLl9tVv69;

	private static readonly OOmAgdu46wuFJYZTsb9 J3clh2f2PS;

	private static readonly OOmAgdu46wuFJYZTsb9 i3UlePOgvV;

	private static readonly OOmAgdu46wuFJYZTsb9 tuslYox3I4;

	private static readonly OOmAgdu46wuFJYZTsb9 JYBlIa3WoI;

	private static readonly OOmAgdu46wuFJYZTsb9 DvVlWBdLSS;

	private static readonly Dictionary<string, OOmAgdu46wuFJYZTsb9> jUwlkfcZo0;

	internal static object xuoE8CQVdGH4KXYLUgEU;

	[SpecialName]
	public static HighlightingColor Lxvl0x7coc()
	{
		return wewlyHniTD;
	}

	[SpecialName]
	public static HighlightingColor bWIlPOo8w3()
	{
		return sbGlZ5SFAR;
	}

	public static Color UJUlugLI0M(string string_0)
	{
		return kBklJBVN2E(string_0).Color;
	}

	public static HighlightingColor YOPlNjbPWi(string string_0)
	{
		return kBklJBVN2E(string_0);
	}

	private static OOmAgdu46wuFJYZTsb9 kBklJBVN2E(string string_0)
	{
		if (App.Current.n991yfUy4r())
		{
			jUwlkfcZo0.TryGetValue(string_0, out var value);
			return value ?? sbGlZ5SFAR;
		}
		oe0lV9khAP.TryGetValue(string_0, out var value2);
		return value2 ?? wewlyHniTD;
	}

	static tTsTGmA1Eh2rbYW36T6()
	{
		wewlyHniTD = new OOmAgdu46wuFJYZTsb9(Colors.Black);
		e1Ml85duG6 = new OOmAgdu46wuFJYZTsb9(Colors.Teal);
		QGOlaenkbG = new OOmAgdu46wuFJYZTsb9(Colors.Green);
		xK8l7tb3oi = new OOmAgdu46wuFJYZTsb9(Colors.Gray);
		cr9lRrRhx5 = new OOmAgdu46wuFJYZTsb9(Colors.Blue);
		ERLlqUF919 = new OOmAgdu46wuFJYZTsb9(Colors.Gray);
		m7Ilcfv85E = new OOmAgdu46wuFJYZTsb9(Colors.Maroon);
		oe0lV9khAP = new Dictionary<string, OOmAgdu46wuFJYZTsb9>
		{
			["class name"] = e1Ml85duG6,
			["struct name"] = e1Ml85duG6,
			["interface name"] = e1Ml85duG6,
			["delegate name"] = e1Ml85duG6,
			["enum name"] = e1Ml85duG6,
			["module name"] = e1Ml85duG6,
			["type parameter name"] = e1Ml85duG6,
			["comment"] = QGOlaenkbG,
			["xml doc comment - attribute name"] = xK8l7tb3oi,
			["xml doc comment - attribute quotes"] = xK8l7tb3oi,
			["xml doc comment - attribute value"] = xK8l7tb3oi,
			["xml doc comment - cdata section"] = xK8l7tb3oi,
			["xml doc comment - comment"] = xK8l7tb3oi,
			["xml doc comment - delimiter"] = xK8l7tb3oi,
			["xml doc comment - entity reference"] = xK8l7tb3oi,
			["xml doc comment - name"] = xK8l7tb3oi,
			["xml doc comment - processing instruction"] = xK8l7tb3oi,
			["xml doc comment - text"] = QGOlaenkbG,
			["keyword"] = cr9lRrRhx5,
			["preprocessor keyword"] = ERLlqUF919,
			["string"] = m7Ilcfv85E,
			["string - verbatim"] = m7Ilcfv85E
		};
		sbGlZ5SFAR = new OOmAgdu46wuFJYZTsb9(Color.FromArgb(byte.MaxValue, 220, 220, 220));
		FLLl9tVv69 = new OOmAgdu46wuFJYZTsb9(Color.FromRgb(3, 194, 194));
		J3clh2f2PS = new OOmAgdu46wuFJYZTsb9(Color.FromRgb(0, 193, 0));
		i3UlePOgvV = new OOmAgdu46wuFJYZTsb9(Colors.Gray);
		tuslYox3I4 = new OOmAgdu46wuFJYZTsb9(Color.FromRgb(126, 193, 248));
		JYBlIa3WoI = new OOmAgdu46wuFJYZTsb9(Colors.Gray);
		DvVlWBdLSS = new OOmAgdu46wuFJYZTsb9(Color.FromRgb(205, 1, 1));
		jUwlkfcZo0 = new Dictionary<string, OOmAgdu46wuFJYZTsb9>
		{
			["class name"] = FLLl9tVv69,
			["struct name"] = FLLl9tVv69,
			["interface name"] = FLLl9tVv69,
			["delegate name"] = FLLl9tVv69,
			["enum name"] = FLLl9tVv69,
			["module name"] = FLLl9tVv69,
			["type parameter name"] = FLLl9tVv69,
			["comment"] = J3clh2f2PS,
			["xml doc comment - attribute name"] = i3UlePOgvV,
			["xml doc comment - attribute quotes"] = i3UlePOgvV,
			["xml doc comment - attribute value"] = i3UlePOgvV,
			["xml doc comment - cdata section"] = i3UlePOgvV,
			["xml doc comment - comment"] = i3UlePOgvV,
			["xml doc comment - delimiter"] = i3UlePOgvV,
			["xml doc comment - entity reference"] = i3UlePOgvV,
			["xml doc comment - name"] = i3UlePOgvV,
			["xml doc comment - processing instruction"] = i3UlePOgvV,
			["xml doc comment - text"] = J3clh2f2PS,
			["keyword"] = tuslYox3I4,
			["preprocessor keyword"] = JYBlIa3WoI,
			["string"] = DvVlWBdLSS,
			["string - verbatim"] = DvVlWBdLSS
		};
	}

	internal static bool UR13whQVOWJ5000sLJgp()
	{
		return xuoE8CQVdGH4KXYLUgEU == null;
	}
}
