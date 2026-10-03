using System.Collections.Generic;

namespace CodeCompletionServer.Entities;

public class CompletionItemComparer : EqualityComparer<CompletionItem>
{
	private static CompletionItemComparer bKYLC0cc8KCVTJI0DvVC;

	public override bool Equals(CompletionItem b1, CompletionItem b2)
	{
		if (b2 == null && b1 == null)
		{
			return true;
		}
		if (b1 != null && b2 != null)
		{
			if (string.Equals(b1.Text, b2.Text))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode(CompletionItem bx)
	{
		return bx.Text.GetHashCode();
	}

	internal static bool f8Vb63ccRgJVEqx0AiIh()
	{
		return bKYLC0cc8KCVTJI0DvVC == null;
	}

	internal static void lUdpjrccPmU1FYORRlp1()
	{
	}
}
