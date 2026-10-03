using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace FindReplace;

public class RichTextBoxAdapter : IEditor
{
	private RichTextBox eqpvFqcOwO;

	private TextRange mmNvUHa9lm;

	internal static RichTextBoxAdapter jcPhJDXYoItOMlkkax0;

	public string Text => new TextRange(eqpvFqcOwO.Document.ContentStart, eqpvFqcOwO.Document.ContentEnd).Text;

	public int SelectionStart => Y6OvOCFC0x(eqpvFqcOwO.Document.ContentStart, eqpvFqcOwO.Selection.Start);

	public int SelectionLength => eqpvFqcOwO.Selection.Text.Length;

	public string SelectedText => eqpvFqcOwO.Selection.Text;

	public RichTextBoxAdapter(RichTextBox editor)
	{
		eqpvFqcOwO = editor;
	}

	public void BeginChange()
	{
		eqpvFqcOwO.BeginChange();
	}

	public void EndChange()
	{
		eqpvFqcOwO.EndChange();
	}

	public void Select(int start, int length)
	{
		TextPointer contentStart = eqpvFqcOwO.Document.ContentStart;
		eqpvFqcOwO.Selection.Select(FEKvA46Nyp(contentStart, start), FEKvA46Nyp(contentStart, start + length));
		eqpvFqcOwO.ScrollToVerticalOffset(eqpvFqcOwO.Selection.Start.GetCharacterRect(LogicalDirection.Forward).Top);
		eqpvFqcOwO.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Yellow);
		mmNvUHa9lm = new TextRange(eqpvFqcOwO.Selection.Start, eqpvFqcOwO.Selection.End);
		eqpvFqcOwO.SelectionChanged += mKvvM1PNVQ;
	}

	private void mKvvM1PNVQ(object sender, RoutedEventArgs e)
	{
		mmNvUHa9lm.ApplyPropertyValue(TextElement.BackgroundProperty, null);
		eqpvFqcOwO.SelectionChanged -= mKvvM1PNVQ;
	}

	public void Replace(int start, int length, string ReplaceWith)
	{
		TextPointer contentStart = eqpvFqcOwO.Document.ContentStart;
		new TextRange(FEKvA46Nyp(contentStart, start), FEKvA46Nyp(contentStart, start + length)).Text = ReplaceWith;
	}

	private static TextPointer FEKvA46Nyp(TextPointer textPointer_0, int int_0)
	{
		TextPointer positionAtOffset = textPointer_0.GetPositionAtOffset(int_0);
		while (new TextRange(textPointer_0, positionAtOffset).Text.Length < int_0)
		{
			if (positionAtOffset.GetPositionAtOffset(1, LogicalDirection.Forward) != null)
			{
				positionAtOffset = positionAtOffset.GetPositionAtOffset(1, LogicalDirection.Forward);
				continue;
			}
			return positionAtOffset;
		}
		return positionAtOffset;
	}

	private static int Y6OvOCFC0x(TextPointer textPointer_0, TextPointer textPointer_1)
	{
		return new TextRange(textPointer_0, textPointer_1).Text.Length;
	}

	internal static bool NJKkUUX8CDVSLb2qI7T()
	{
		return jcPhJDXYoItOMlkkax0 == null;
	}
}
