using System.Windows.Controls;
using System.Windows.Documents;

namespace QesCGrYNOZkMdaTfjcS;

internal static class Uw9ig0YvbXf7MyRe7BO
{
	internal static object g9IXyKFoJ2ZRWHlu0J2G;

	public static TextPointer xwJLxzir4D2(this TextBlock textBlock_0, int int_0)
	{
		int num = 0;
		TextPointer textPointer = textBlock_0.ContentStart;
		while (num < int_0 && textPointer.CompareTo(textBlock_0.ContentEnd) < 0)
		{
			switch (textPointer.GetPointerContext(LogicalDirection.Forward))
			{
			case TextPointerContext.ElementStart:
				if (textPointer.GetAdjacentElement(LogicalDirection.Forward) is LineBreak)
				{
					num += 2;
				}
				break;
			case TextPointerContext.Text:
			{
				int textRunLength = textPointer.GetTextRunLength(LogicalDirection.Forward);
				if (g9IXyKFoJ2ZRWHlu0J2G == null)
				{
					switch (0)
					{
					}
				}
				if (textRunLength + num <= int_0)
				{
					num += textRunLength;
					break;
				}
				return textPointer.GetPositionAtOffset(int_0 - num);
			}
			}
			textPointer = textPointer.GetNextContextPosition(LogicalDirection.Forward);
		}
		return textPointer;
	}

	public static int JiuLrw0sEAs(this TextBlock textBlock_0, TextPointer textPointer_0)
	{
		return new TextRange(textBlock_0.ContentStart, textPointer_0).Text.Length;
	}

	internal static bool OU6x4RFokJI2XFJA7iev()
	{
		return g9IXyKFoJ2ZRWHlu0J2G == null;
	}
}
