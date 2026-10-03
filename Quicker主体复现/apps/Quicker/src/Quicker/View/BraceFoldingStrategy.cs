using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;

namespace Quicker.View;

public class BraceFoldingStrategy
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec hGmSXpj4vBF;

		public static Comparison<NewFolding> JP8SXBDAB38;

		private static _003C_003Ec vKL2lhWZUJorRsD6uhxv;

		static _003C_003Ec()
		{
			hGmSXpj4vBF = new _003C_003Ec();
		}

		internal int moCSXrZyEji(NewFolding a, NewFolding b)
		{
			return a.StartOffset.CompareTo(b.StartOffset);
		}

		internal static bool EDBQVjWZxWh7Jo2Taevc()
		{
			return vKL2lhWZUJorRsD6uhxv == null;
		}
	}

	[CompilerGenerated]
	private char OSEg42HSLf1;

	[CompilerGenerated]
	private char BB5g4uysnPR;

	private static BraceFoldingStrategy R8IyNUFVCKoUX3xEH8y1;

	public char OpeningBrace
	{
		[CompilerGenerated]
		get
		{
			return OSEg42HSLf1;
		}
		[CompilerGenerated]
		set
		{
			OSEg42HSLf1 = value;
		}
	}

	public char ClosingBrace
	{
		[CompilerGenerated]
		get
		{
			return BB5g4uysnPR;
		}
		[CompilerGenerated]
		set
		{
			BB5g4uysnPR = value;
		}
	}

	public BraceFoldingStrategy()
	{
		OpeningBrace = '{';
		ClosingBrace = '}';
	}

	public void UpdateFoldings(FoldingManager manager, TextDocument document)
	{
		int firstErrorOffset;
		IEnumerable<NewFolding> newFoldings = CreateNewFoldings(document, out firstErrorOffset);
		manager.UpdateFoldings(newFoldings, firstErrorOffset);
	}

	public IEnumerable<NewFolding> CreateNewFoldings(TextDocument document, out int firstErrorOffset)
	{
		firstErrorOffset = -1;
		return CreateNewFoldings(document);
	}

	public IEnumerable<NewFolding> CreateNewFoldings(ITextSource document)
	{
		List<NewFolding> list = new List<NewFolding>();
		Stack<int> stack = new Stack<int>();
		int num = 0;
		char openingBrace = OpeningBrace;
		char closingBrace = ClosingBrace;
		for (int i = 0; i < document.TextLength; i++)
		{
			char charAt = document.GetCharAt(i);
			if (charAt == openingBrace)
			{
				stack.Push(i);
			}
			else if (charAt == closingBrace && stack.Count > 0)
			{
				int num2 = stack.Pop();
				if (num2 < num)
				{
					list.Add(new NewFolding(num2, i + 1));
				}
			}
			else if (charAt == '\n' || charAt == '\r')
			{
				num = i + 1;
			}
		}
		list.Sort(_003C_003Ec.JP8SXBDAB38 ?? (_003C_003Ec.JP8SXBDAB38 = _003C_003Ec.hGmSXpj4vBF.moCSXrZyEji));
		return list;
	}

	internal static bool C6qFE4FV7IAb9JLc7tl3()
	{
		return R8IyNUFVCKoUX3xEH8y1 == null;
	}

	internal static void fC58krFVhae6wupawl5y()
	{
	}
}
