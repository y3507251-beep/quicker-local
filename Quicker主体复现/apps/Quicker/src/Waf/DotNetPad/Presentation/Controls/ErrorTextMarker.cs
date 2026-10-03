using System.Runtime.CompilerServices;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Document;

namespace Waf.DotNetPad.Presentation.Controls;

public class ErrorTextMarker : TextSegment
{
	[CompilerGenerated]
	private readonly string VrERN0y6YR;

	[CompilerGenerated]
	private readonly Color tY0RJQcjup;

	private static ErrorTextMarker mpE5u5Oh48fyEiM8TJ7;

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return VrERN0y6YR;
		}
	}

	public Color MarkerColor
	{
		[CompilerGenerated]
		get
		{
			return tY0RJQcjup;
		}
	}

	public ErrorTextMarker(int startOffset, int length, string message, Color markerColor)
	{
		base.StartOffset = startOffset;
		base.Length = length;
		VrERN0y6YR = message;
		tY0RJQcjup = markerColor;
	}

	internal static bool RH3HLvOHQqi8cnNr6t1()
	{
		return mpE5u5Oh48fyEiM8TJ7 == null;
	}
}
