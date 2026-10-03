using System.Collections.Generic;
using System.IO;
using HtmlAgilityPack;

namespace Quicker.Utilities.Ext;

public static class HtmlHelper
{
	internal static object qmpSnVFIqBUd9qEoWv74;

	public static string HtmlToPlainText(this string html)
	{
		if (!string.IsNullOrEmpty(html))
		{
			try
			{
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(html);
				StringWriter stringWriter = new StringWriter();
				qy7LiXUpjWQ(htmlDocument.DocumentNode, stringWriter);
				stringWriter.Flush();
				return stringWriter.ToString();
			}
			catch
			{
				return html;
			}
		}
		return string.Empty;
	}

	private static void qy7LiXUpjWQ(HtmlNode htmlNode_0, TextWriter textWriter_0)
	{
		switch (htmlNode_0.NodeType)
		{
		default:
			if (qmpSnVFIqBUd9qEoWv74 != null)
			{
				break;
			}
			switch (1)
			{
			case 1:
				return;
			}
			goto IL_0072;
		case HtmlNodeType.Document:
			g4SLim4T2WS(htmlNode_0, textWriter_0);
			break;
		case HtmlNodeType.Element:
		{
			string name2 = htmlNode_0.Name;
			if (name2 == "p")
			{
				goto IL_0072;
			}
			if (name2 == "br")
			{
				textWriter_0.Write("\r\n");
			}
			goto IL_007d;
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
			IL_007d:
			if (htmlNode_0.HasChildNodes)
			{
				g4SLim4T2WS(htmlNode_0, textWriter_0);
			}
			break;
			IL_0072:
			textWriter_0.Write("\r\n");
			goto IL_007d;
		}
	}

	private static void g4SLim4T2WS(HtmlNode htmlNode_0, TextWriter textWriter_0)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNode_0.ChildNodes)
		{
			qy7LiXUpjWQ(item, textWriter_0);
		}
	}

	internal static bool hJh9XNFIiqBdZ7tkAryq()
	{
		return qmpSnVFIqBUd9qEoWv74 == null;
	}
}
