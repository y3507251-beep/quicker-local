using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using CodeCompletionServer.Entities;

namespace CbrphLANyKZlutR0O9C;

internal static class RprbKLAvQJex2av9Fkj
{
	internal static object O4dMj0QVlVkAU4NpuesG;

	public static string manlAmZsEs(this TaggedText taggedText_0, bool bool_0)
	{
		string text = taggedText_0.ToString();
		if (bool_0 && (taggedText_0.Tag == "Punctuation" || taggedText_0.Tag == "Space" || taggedText_0.Tag == "LineBreak"))
		{
			text = "\u200e" + text;
		}
		return text;
	}

	public static Run iAolOLw21D(this TaggedText taggedText_0, bool bool_0 = false)
	{
		Run run = new Run(taggedText_0.manlAmZsEs(true));
		if (bool_0)
		{
			run.FontWeight = FontWeights.Bold;
		}
		string tag = taggedText_0.Tag;
		if (tag != null)
		{
			switch (tag.Length)
			{
			case 4:
				if (!(tag == "Enum"))
				{
					break;
				}
				goto IL_00f8;
			case 5:
				if (!(tag == "Class"))
				{
					break;
				}
				goto IL_00f8;
			case 7:
				if (!(tag == "Keyword"))
				{
					if (C6Fl5UQVZymx83wxwWjS())
					{
						break;
					}
					switch (1)
					{
					case 1:
						goto end_IL_0032;
					}
					goto case 6;
				}
				run.Foreground = Brushes.DodgerBlue;
				break;
			case 6:
				if (!(tag == "Struct"))
				{
					break;
				}
				goto IL_00f8;
			case 8:
				if (!(tag == "Delegate"))
				{
					break;
				}
				goto IL_00f8;
			case 9:
				if (!(tag == "Interface"))
				{
					break;
				}
				goto IL_00f8;
			case 13:
				{
					if (!(tag == "TypeParameter"))
					{
						break;
					}
					goto IL_00f8;
				}
				IL_00f8:
				run.Foreground = Brushes.Teal;
				break;
				end_IL_0032:
				break;
			}
		}
		return run;
	}

	public static TextBlock YqJlF3u8fw(this IEnumerable<TaggedText> ienumerable_0, bool bool_0 = false)
	{
		TextBlock textBlock = new TextBlock
		{
			TextWrapping = TextWrapping.Wrap
		};
		foreach (TaggedText item in ienumerable_0)
		{
			textBlock.Inlines.Add(item.iAolOLw21D(bool_0));
		}
		return textBlock;
	}

	internal static bool C6Fl5UQVZymx83wxwWjS()
	{
		return O4dMj0QVlVkAU4NpuesG == null;
	}
}
