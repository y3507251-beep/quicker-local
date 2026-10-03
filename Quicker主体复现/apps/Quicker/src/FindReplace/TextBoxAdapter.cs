using System.Windows.Controls;

namespace FindReplace;

public class TextBoxAdapter : IEditor
{
	private TextBox hffvTqMtHE;

	private static TextBoxAdapter K4Z4DcXlCYXHDg0gvQn;

	public string Text => hffvTqMtHE.Text;

	public int SelectionStart => hffvTqMtHE.SelectionStart;

	public int SelectionLength => hffvTqMtHE.SelectionLength;

	public string SelectedText => hffvTqMtHE.SelectedText;

	public TextBoxAdapter(TextBox editor)
	{
		hffvTqMtHE = editor;
	}

	public void BeginChange()
	{
		hffvTqMtHE.BeginChange();
	}

	public void EndChange()
	{
		hffvTqMtHE.EndChange();
	}

	public void Select(int start, int length)
	{
		hffvTqMtHE.Select(start, length);
	}

	public void Replace(int start, int length, string ReplaceWith)
	{
		hffvTqMtHE.Text = hffvTqMtHE.Text.Substring(0, start) + ReplaceWith + hffvTqMtHE.Text.Substring(start + length);
	}

	internal static bool aKjixyXZmumybimL9LG()
	{
		return K4Z4DcXlCYXHDg0gvQn == null;
	}
}
