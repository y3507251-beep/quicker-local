using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace EArdHIY3OLGgDCfPPoJ;

internal class omCJXwYsOy13Lxm40vR
{
	private readonly List<Inline> dS9LrnvtReN = new List<Inline>();

	private readonly StringBuilder SecLr4aoKQK = new StringBuilder();

	internal static omCJXwYsOy13Lxm40vR yNDRZ4FoqjwZ290DNHgc;

	public void qrHLrKXK3fT(string string_0)
	{
		SecLr4aoKQK.Append(string_0);
	}

	public void HpILrxjfhhl(char char_0)
	{
		SecLr4aoKQK.Append(char_0);
	}

	public void JQ8LrrpaosZ(char char_0, int int_0)
	{
		SecLr4aoKQK.Append(char_0, int_0);
	}

	public void ploLrpxBSIB()
	{
		SecLr4aoKQK.AppendLine();
	}

	public void AtyLrBI46hS(char char_0, Brush brush_0, Brush? background = null)
	{
		ptyLrQXDe7S(char_0.ToString(), brush_0, background);
	}

	public void ptyLrQXDe7S(string string_0, Brush brush_0, Brush? background = null)
	{
		if (SecLr4aoKQK.Length > 0)
		{
			dS9LrnvtReN.Add(new Run(SecLr4aoKQK.ToString()));
			SecLr4aoKQK.Clear();
		}
		Run run = new Run(string_0);
		run.Foreground = brush_0;
		if (background != null)
		{
			run.Background = background;
		}
		dS9LrnvtReN.Add(run);
	}

	public void WifLrj9gCxJ(TextBlock textBlock_0)
	{
		if (SecLr4aoKQK.Length > 0)
		{
			dS9LrnvtReN.Add(new Run(SecLr4aoKQK.ToString()));
			SecLr4aoKQK.Clear();
		}
		textBlock_0.Inlines.Clear();
		textBlock_0.Inlines.AddRange(dS9LrnvtReN);
		dS9LrnvtReN.Clear();
	}

	internal static bool TmZyEeFoiuhNaqCCBMde()
	{
		return yNDRZ4FoqjwZ290DNHgc == null;
	}
}
