using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Rendering;

namespace Quicker.View;

public class ColorizeAvalonEdit : DocumentColorizingTransformer
{
	private readonly TextEditor b1Vg4JT9guq;

	private Brush j8Mg40LXAh3;

	private static ColorizeAvalonEdit Knx6reFVHvcdY5NHjHBW;

	public ColorizeAvalonEdit(TextEditor editor, Brush brush)
	{
		b1Vg4JT9guq = editor;
		j8Mg40LXAh3 = brush;
	}

	protected override void ColorizeLine(DocumentLine line)
	{
		if (b1Vg4JT9guq.TextArea.Selection is RectangleSelection)
		{
			return;
		}
		string selectedText = b1Vg4JT9guq.SelectedText;
		if (string.IsNullOrEmpty(selectedText) || selectedText.Contains('\n'))
		{
			return;
		}
		int offset = line.Offset;
		string text = base.CurrentContext.Document.GetText(line);
		int startIndex = 0;
		try
		{
			int num;
			while ((num = text.IndexOf(selectedText, startIndex)) >= 0)
			{
				ChangeLinePart(offset + num, offset + num + selectedText.Length, gDeg4NSGp8Z);
				startIndex = num + 1;
			}
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void gDeg4NSGp8Z(VisualLineElement visualLineElement_0)
	{
		visualLineElement_0.BackgroundBrush = j8Mg40LXAh3;
	}

	internal static bool UiPKHAFVzHYD0JUHarys()
	{
		return Knx6reFVHvcdY5NHjHBW == null;
	}
}
