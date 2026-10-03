using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace Quicker.Actions.XActions.BuildinRunners.Text;

public class HtmlToTextConverter
{
	private readonly StringBuilder bD0gxbtnJPp = new StringBuilder();

	private bool nmegx6N2fv5 = true;

	private bool jb3gxX4hffQ;

	private bool UjwgxmWp6Cq;

	private static HtmlToTextConverter MHGeA3Q4CtTqONK6YPoa;

	public static string Convert(string html)
	{
		HtmlToTextConverter htmlToTextConverter = new HtmlToTextConverter();
		htmlToTextConverter.ParseAndVisit(html);
		return htmlToTextConverter.ToString();
	}

	public override string ToString()
	{
		return bD0gxbtnJPp.ToString();
	}

	public void ParseAndVisit(string html)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(html);
		Visit(htmlDocument);
	}

	public void Visit(HtmlDocument doc)
	{
		Visit(doc.DocumentNode);
	}

	public void Visit(HtmlNode node)
	{
		string name;
		int num;
		switch (node.NodeType)
		{
		case HtmlNodeType.Document:
			vw0gx1peiGw(node);
			break;
		case HtmlNodeType.Element:
			name = node.Name;
			num = 0;
			if (MHGeA3Q4CtTqONK6YPoa == null)
			{
				goto IL_003d;
			}
			goto IL_009d;
		case HtmlNodeType.Comment:
			break;
		case HtmlNodeType.Text:
			{
				FGAgxHaS38e((node as HtmlTextNode).Text);
				break;
			}
			IL_009d:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00aa;
			}
			goto IL_003d;
			IL_00aa:
			if (!(name == "div"))
			{
				vw0gx1peiGw(node);
				break;
			}
			goto IL_00c1;
			IL_003d:
			switch (name)
			{
			case "p":
				goto IL_00c1;
			case "br":
				bD0gxbtnJPp.AppendLine();
				nmegx6N2fv5 = true;
				jb3gxX4hffQ = false;
				UjwgxmWp6Cq = false;
				return;
			case "style":
				return;
			case "head":
				return;
			}
			num = 0;
			if (!Hwui3SQ47C9bGCNv1IAy())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_009d;
			IL_00c1:
			LCRgxGXLBv8();
			vw0gx1peiGw(node);
			x4egxsMaxSc();
			break;
		}
	}

	private void LCRgxGXLBv8()
	{
		jb3gxX4hffQ = false;
		UjwgxmWp6Cq = false;
		if (!nmegx6N2fv5)
		{
			bD0gxbtnJPp.AppendLine();
			nmegx6N2fv5 = true;
		}
	}

	private void x4egxsMaxSc()
	{
		jb3gxX4hffQ = true;
		UjwgxmWp6Cq = false;
		nmegx6N2fv5 = false;
	}

	private void FGAgxHaS38e(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return;
		}
		if (!nmegx6N2fv5)
		{
			int num = 0;
			if (!Hwui3SQ47C9bGCNv1IAy())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!jb3gxX4hffQ)
			{
				goto IL_0042;
			}
		}
		string_0 = string_0.TrimStart();
		goto IL_0042;
		IL_0042:
		if (jb3gxX4hffQ)
		{
			bD0gxbtnJPp.AppendLine();
		}
		if (UjwgxmWp6Cq)
		{
			bD0gxbtnJPp.Append(" ");
		}
		string text = string_0.TrimEnd();
		if (text != string_0)
		{
			UjwgxmWp6Cq = true;
		}
		else
		{
			UjwgxmWp6Cq = false;
		}
		bD0gxbtnJPp.Append(text);
		nmegx6N2fv5 = false;
		jb3gxX4hffQ = false;
	}

	private void vw0gx1peiGw(HtmlNode htmlNode_0)
	{
		if (htmlNode_0.ChildNodes == null)
		{
			return;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNode_0.ChildNodes)
		{
			Visit(item);
		}
	}

	internal static bool Hwui3SQ47C9bGCNv1IAy()
	{
		return MHGeA3Q4CtTqONK6YPoa == null;
	}
}
