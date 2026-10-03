using System.Collections.Generic;
using System.IO;
using HtmlAgilityPack;

namespace c1g2QaYqqQIXXsN2NRs;

internal class gLHFbCYlOEuoKl12sik
{
	internal static gLHFbCYlOEuoKl12sik dQwV9vQz3UklfMuhvL1C;

	public static string ndHgQ1w05CP(string string_0)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(string_0);
		StringWriter stringWriter = new StringWriter();
		PEqgQXW74sW(htmlDocument.DocumentNode, stringWriter);
		stringWriter.Flush();
		return stringWriter.ToString();
	}

	public static int KyPgQbJwQtv(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			return string_0.Split(' ', '\n').Length;
		}
		return 0;
	}

	public static string Cut(string text, int length)
	{
		if (!string.IsNullOrEmpty(text) && text.Length > length)
		{
			text = text.Substring(0, length - 4) + " ...";
		}
		return text;
	}

	private static void LePgQ6hxAeh(HtmlNode htmlNode_0, TextWriter textWriter_0)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNode_0.ChildNodes)
		{
			PEqgQXW74sW(item, textWriter_0);
		}
	}

	private static void PEqgQXW74sW(HtmlNode htmlNode_0, TextWriter textWriter_0)
	{
		int num;
		switch (htmlNode_0.NodeType)
		{
		case HtmlNodeType.Document:
			LePgQ6hxAeh(htmlNode_0, textWriter_0);
			break;
		case HtmlNodeType.Element:
		{
			string name2 = htmlNode_0.Name;
			if (!(name2 == "p"))
			{
				if (name2 == "br")
				{
					textWriter_0.Write("\r\n");
					num = 1;
					if (dQwV9vQz3UklfMuhvL1C == null)
					{
						goto IL_007b;
					}
				}
			}
			else
			{
				textWriter_0.Write("\r\n");
				num = 0;
				if (pIM7FSQzECp4DdvYWSDW())
				{
					goto IL_007b;
				}
			}
			goto IL_0088;
		}
		case HtmlNodeType.Text:
		{
			string name = htmlNode_0.ParentNode.Name;
			if (!(name == "script") && !(name == "style"))
			{
				string text = ((HtmlTextNode)htmlNode_0).Text;
				if (!HtmlNode.IsOverlappedClosingElement(text) && text.Trim().Length > 0)
				{
					textWriter_0.Write(HtmlEntity.DeEntitize(text));
				}
			}
			break;
		}
		case HtmlNodeType.Comment:
			break;
			IL_007b:
			switch (num)
			{
			}
			goto IL_0088;
			IL_0088:
			if (htmlNode_0.HasChildNodes)
			{
				LePgQ6hxAeh(htmlNode_0, textWriter_0);
			}
			break;
		}
	}

	internal static bool pIM7FSQzECp4DdvYWSDW()
	{
		return dQwV9vQz3UklfMuhvL1C == null;
	}
}
