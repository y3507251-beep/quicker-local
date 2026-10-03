using System.Windows.Forms;
using FindReplace;

namespace YB1wxVFjcl6cky5bGq;

internal class YNZiO2V5eB4IVaY69q : IEditor
{
	private TextBoxBase ShCvleyGOi;

	internal static YNZiO2V5eB4IVaY69q aJyb16X6k6Kido7Mjwh;

	public string Text => ShCvleyGOi.Text;

	public int SelectionStart => ShCvleyGOi.SelectionStart;

	public int SelectionLength => ShCvleyGOi.SelectionLength;

	public string SelectedText => ShCvleyGOi.SelectedText;

	public YNZiO2V5eB4IVaY69q(TextBoxBase textBoxBase_1)
	{
		ShCvleyGOi = textBoxBase_1;
	}

	public void BeginChange()
	{
	}

	public void EndChange()
	{
	}

	public void Select(int start, int length)
	{
		ShCvleyGOi.Select(start, length);
		ShCvleyGOi.ScrollToCaret();
	}

	public void Replace(int start, int length, string ReplaceWith)
	{
		ShCvleyGOi.Text = ShCvleyGOi.Text.Substring(0, start) + ReplaceWith + ShCvleyGOi.Text.Substring(start + length);
	}

	internal static bool DRU5ZtXtxH91S3mdu8v()
	{
		return aJyb16X6k6Kido7Mjwh == null;
	}
}
