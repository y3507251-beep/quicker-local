using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;

namespace FindReplace;

public class TextEditorAdapter : IEditor
{
	private TextEditor nuKvoeyOa5;

	private static TextEditorAdapter jCjE3XXfE7Fl23lIAHF;

	public string Text => nuKvoeyOa5.Text;

	public int SelectionStart => nuKvoeyOa5.SelectionStart;

	public int SelectionLength => nuKvoeyOa5.SelectionLength;

	public string SelectedText => nuKvoeyOa5.SelectedText;

	public TextEditorAdapter(TextEditor editor)
	{
		nuKvoeyOa5 = editor;
	}

	public void BeginChange()
	{
		nuKvoeyOa5.BeginChange();
	}

	public void EndChange()
	{
		nuKvoeyOa5.EndChange();
	}

	public void Select(int start, int length)
	{
		nuKvoeyOa5.Select(start, length);
		TextLocation location = nuKvoeyOa5.Document.GetLocation(start);
		nuKvoeyOa5.ScrollTo(location.Line, location.Column);
	}

	public void Replace(int start, int length, string ReplaceWith)
	{
		nuKvoeyOa5.Document.Replace(start, length, ReplaceWith);
	}

	internal static bool NCgQy7XbTLQ0alxfZrT()
	{
		return jCjE3XXfE7Fl23lIAHF == null;
	}
}
