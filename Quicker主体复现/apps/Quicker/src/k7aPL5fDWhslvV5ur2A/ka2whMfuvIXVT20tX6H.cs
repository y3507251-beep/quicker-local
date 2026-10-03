using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Folding;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace k7aPL5fDWhslvV5ur2A;

internal static class ka2whMfuvIXVT20tX6H
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<char, bool> Q5T2NPfpx0D;

		public static MouseWheelEventHandler aLq2NEjo1Qa;
	}

	internal static object BxsbbIFxTDEQlhpKaFeF;

	public static void dkOLiRNGFGf(this TextEditor textEditor_0, string string_0)
	{
		TextDocument document = textEditor_0.Document;
		using (document.RunUpdate())
		{
			if (textEditor_0.SelectionLength > 0)
			{
				document.Replace(textEditor_0.SelectionStart, textEditor_0.SelectionLength, string_0);
			}
			else
			{
				document.Insert(textEditor_0.CaretOffset, string_0);
			}
		}
	}

	public static int udRLiqMmXfF(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			return 0;
		}
		if (string_1 == "jiao")
		{
			bool flag = string_0 == "脚本";
		}
		return tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(string_0, string_1)?.Score ?? (-1);
	}

	private static bool gROLic4gscC(string string_0, string string_1)
	{
		IEnumerable<char> enumerable = string_0.Take(1).Concat(string_0.Skip(1).Where(_003C_003EO.Q5T2NPfpx0D ?? (_003C_003EO.Q5T2NPfpx0D = char.IsUpper)));
		int num = 0;
		bool result;
		foreach (char item in enumerable)
		{
			if (num <= string_1.Length - 1)
			{
				if (char.ToUpperInvariant(string_1[num]) == char.ToUpperInvariant(item))
				{
					num++;
					continue;
				}
				result = false;
			}
			else
			{
				result = true;
				if (BxsbbIFxTDEQlhpKaFeF == null)
				{
					switch (0)
					{
					}
				}
			}
			goto IL_00ab;
		}
		if (num >= string_1.Length)
		{
			return true;
		}
		return false;
		IL_00ab:
		return result;
	}

	public static void sFQLiVAd4ag(TextEditor textEditor_0)
	{
		textEditor_0.PreviewMouseWheel += _003C_003EO.aLq2NEjo1Qa ?? (_003C_003EO.aLq2NEjo1Qa = G90LiZaMlQd);
	}

	private static void G90LiZaMlQd(object uielement_0Input, MouseWheelEventArgs mouseWheelEventArgs_0)
	{
        UIElement uielement_0 = (UIElement)uielement_0Input;
		TextEditor textEditor = uielement_0 as TextEditor;
		if (!textEditor.IsKeyboardFocusWithin || textEditor.ExtentHeight <= textEditor.ActualHeight)
		{
			mouseWheelEventArgs_0.Handled = true;
			MouseWheelEventArgs e = new MouseWheelEventArgs(mouseWheelEventArgs_0.MouseDevice, mouseWheelEventArgs_0.Timestamp, mouseWheelEventArgs_0.Delta);
			e.RoutedEvent = UIElement.MouseWheelEvent;
			uielement_0.RaiseEvent(e);
		}
	}

	public static object yitLi90LyKV(this TextEditor textEditor_0)
	{
		object obj = null;
		string name = textEditor_0.SyntaxHighlighting.Name;
		if (name != null)
		{
			int num = 1;
			if (!Veh1NiFxmntvH1vP4k90())
			{
				int num2 = default(int);
				num = num2;
			}
			char c = default(char);
			while (true)
			{
				IL_006a:
				switch (num)
				{
				case 1:
					while (true)
					{
						switch (name.Length)
						{
						case 4:
							break;
						case 12:
							goto end_IL_004a;
						case 10:
							goto IL_00ab;
						case 2:
							goto IL_00c1;
						case 3:
							goto IL_00d7;
						default:
							goto end_IL_006a;
						}
						c = name[1];
						if (c != 'a')
						{
							num = 2;
							if (!Veh1NiFxmntvH1vP4k90())
							{
								continue;
							}
							goto IL_006a;
						}
						goto IL_012c;
						continue;
						end_IL_004a:
						break;
					}
					if (!(name == "QuickerParam"))
					{
						break;
					}
					goto IL_0152;
				case 2:
					{
						if (c != 's' || !(name == "Json"))
						{
							break;
						}
						goto IL_0152;
					}
					IL_0152:
					return new BraceFoldingStrategy();
					IL_00d7:
					c = name[0];
					if (c != 'C')
					{
						if (c != 'P')
						{
							if (c != 'X' || !(name == "XML"))
							{
								break;
							}
							return new XmlFoldingStrategy();
						}
						if (!(name == "PHP"))
						{
							break;
						}
					}
					else if (!(name == "C++"))
					{
						break;
					}
					goto IL_0152;
					IL_00c1:
					if (!(name == "C#"))
					{
						break;
					}
					goto IL_0152;
					IL_00ab:
					if (!(name == "JavaScript"))
					{
						break;
					}
					goto IL_0152;
					IL_012c:
					if (!(name == "Java"))
					{
						break;
					}
					goto IL_0152;
					end_IL_006a:
					break;
				}
				break;
			}
		}
		return null;
	}

	public static void b8XLihSEUh0(this TextEditor textEditor_0)
	{
		TextLocation location = textEditor_0.TextArea.Document.GetLocation(textEditor_0.CaretOffset);
		textEditor_0.ScrollTo(location.Line, location.Column);
		textEditor_0.TextArea.Caret.Show();
	}

	public static void H6CLie5sgR1(this TextEditor textEditor_0)
	{
		textEditor_0.Document.UndoStack.ClearAll();
	}

	public static void uLyLiY4NBYN(this TextEditor textEditor_0)
	{
		textEditor_0.TextArea.TextView.ElementGenerators.Add(new TruncateLongLines());
	}

	public static void GNBLiIGOd2f(this TextEditor textEditor_0)
	{
		TextDocument document = textEditor_0.Document;
		int caretOffset = textEditor_0.CaretOffset;
		DocumentLine lineByOffset = document.GetLineByOffset(caretOffset);
		int num = caretOffset - lineByOffset.Offset;
		int lineNumber = lineByOffset.LineNumber;
		int num2 = 0;
		if (!Veh1NiFxmntvH1vP4k90())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		bool flag = document.LineCount == lineNumber;
		if (lineByOffset.PreviousLine != null)
		{
			using (document.RunUpdate())
			{
				string text = document.GetText(lineByOffset);
				DocumentLine previousLine = lineByOffset.PreviousLine;
				string text2 = document.GetText(previousLine);
				document.Remove(lineByOffset.Offset, lineByOffset.TotalLength);
				document.Remove(previousLine.Offset, previousLine.TotalLength);
				document.Insert(previousLine.Offset, text + Environment.NewLine + text2 + (flag ? "" : Environment.NewLine));
				textEditor_0.CaretOffset = previousLine.Offset + num;
			}
			textEditor_0.ScrollToLine(lineNumber - 1);
		}
	}

	public static void BDsLiWpgApB(this TextEditor textEditor_0)
	{
		TextDocument document = textEditor_0.Document;
		int caretOffset = textEditor_0.CaretOffset;
		DocumentLine lineByOffset = document.GetLineByOffset(caretOffset);
		string text = document.GetText(lineByOffset);
		int num = caretOffset - lineByOffset.Offset;
		if (BxsbbIFxTDEQlhpKaFeF != null)
		{
			switch (0)
			{
			}
		}
		int lineNumber = lineByOffset.LineNumber;
		if (lineByOffset.NextLine != null)
		{
			DocumentLine nextLine = lineByOffset.NextLine;
			bool flag = nextLine.DelimiterLength == 0;
			int caretOffset2 = lineByOffset.Offset + (nextLine.Length + Environment.NewLine.Length) + num;
			using (document.RunUpdate())
			{
				string text2 = document.GetText(nextLine);
				document.Remove(nextLine.Offset, nextLine.TotalLength);
				document.Remove(lineByOffset.Offset, lineByOffset.TotalLength);
				document.Insert(lineByOffset.Offset, text2 + Environment.NewLine + text + (flag ? "" : Environment.NewLine));
				textEditor_0.CaretOffset = caretOffset2;
			}
			textEditor_0.ScrollToLine(lineNumber + 1);
		}
	}

	public static void qf8LikHsaLV(this TextEditor textEditor_0)
	{
		TextDocument document = textEditor_0.Document;
		TextArea textArea = textEditor_0.TextArea;
		Selection selection = textArea.Selection;
		using (document.RunUpdate())
		{
			if (selection.IsEmpty)
			{
				DocumentLine lineByOffset = document.GetLineByOffset(textArea.Caret.Offset);
				string text = document.GetText(lineByOffset);
				int num = 0;
				if (BxsbbIFxTDEQlhpKaFeF != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				document.Insert(lineByOffset.EndOffset, Environment.NewLine + text);
				textEditor_0.CaretOffset = lineByOffset.EndOffset + Environment.NewLine.Length + text.Length;
			}
			else
			{
				string text2 = selection.GetText();
				document.Insert(selection.SurroundingSegment.EndOffset, text2);
				textEditor_0.CaretOffset = selection.SurroundingSegment.EndOffset + text2.Length;
			}
		}
	}

	internal static bool Veh1NiFxmntvH1vP4k90()
	{
		return BxsbbIFxTDEQlhpKaFeF == null;
	}
}
