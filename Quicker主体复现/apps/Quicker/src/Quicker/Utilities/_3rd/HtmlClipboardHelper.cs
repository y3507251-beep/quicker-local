using System;
using System.Globalization;
using System.Text;
using System.Windows;
using gNDpGkYZYbhLdMnAyKv;

namespace Quicker.Utilities._3rd;

public static class HtmlClipboardHelper
{
	private const string Header = "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n";

	public const string StartFragment = "<!--StartFragment-->";

	public const string EndFragment = "<!--EndFragment-->";

	private static readonly char[] JQALzhf7Ipx;

	private static object Edn0PPFTLDZTphAug6HY;

	public static DataObject CreateDataObject(string html, string plainText)
	{
		html = html ?? string.Empty;
		string text = rcxLzZDg9Pr(html);
		if (Environment.Version.Major < 4 && html.Length != Encoding.UTF8.GetByteCount(html))
		{
			text = Encoding.Default.GetString(Encoding.UTF8.GetBytes(text));
		}
		DataObject dataObject = new DataObject();
		dataObject.SetData(DataFormats.Html, text);
		dataObject.SetData(DataFormats.Text, plainText);
		dataObject.SetData(DataFormats.UnicodeText, plainText);
		return dataObject;
	}

	public static void CopyToClipboard(string html, string plainText)
	{
		kWsP1bYRVsfaicfjr67.AoML5mTBA4V(CreateDataObject(html, plainText), true);
	}

	private static string rcxLzZDg9Pr(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n");
		int num = string_0.IndexOf("<!--StartFragment-->", StringComparison.OrdinalIgnoreCase);
		int num2 = string_0.LastIndexOf("<!--EndFragment-->", StringComparison.OrdinalIgnoreCase);
		int num3 = 0;
		if (!nK9WeuFTuSXlWfXfm9QX())
		{
			goto IL_013c;
		}
		goto IL_0310;
		IL_013c:
		int num4 = default(int);
		num3 = num4;
		goto IL_0310;
		IL_0310:
		int num8 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		int num15 = default(int);
		int num11 = default(int);
		do
		{
			IL_0310_2:
			int num13;
			int num12;
			int num14;
			switch (num3)
			{
			case 6:
				num13 = ((num8 > -1) ? num8 : 0);
				goto IL_004f;
			case 5:
			{
				int num16 = OJBLz9FVg9P(stringBuilder);
				stringBuilder.Append(string_0);
				num5 = num16 + OJBLz9FVg9P(stringBuilder, num16, num16 + num) + "<!--StartFragment-->".Length;
				num6 = num16 + OJBLz9FVg9P(stringBuilder, num16, num16 + num2);
				if (num9 < 0)
				{
					stringBuilder.Append("</html>");
				}
				break;
			}
			case 4:
				num15 = string_0.LastIndexOf("</body", StringComparison.OrdinalIgnoreCase);
				if (num8 < 0)
				{
					stringBuilder.Append("<html>");
				}
				else
				{
					stringBuilder.Append(string_0, 0, num8);
				}
				if (num11 > -1)
				{
					stringBuilder.Append(string_0, (num8 > -1) ? num8 : 0, num11 - ((num8 > -1) ? num8 : 0));
				}
				stringBuilder.Append("<!--StartFragment-->");
				goto case 3;
			case 3:
				num5 = OJBLz9FVg9P(stringBuilder);
				if (num11 <= -1)
				{
					goto case 6;
				}
				num13 = num11;
				goto IL_004f;
			case 2:
				if (num8 < 0)
				{
					stringBuilder.Append("<html>");
					num3 = 5;
					if (Edn0PPFTLDZTphAug6HY == null)
					{
						goto IL_0310_2;
					}
				}
				goto case 5;
			default:
			{
				int num7 = string_0.IndexOf("<html", StringComparison.OrdinalIgnoreCase);
				num8 = ((num7 > -1) ? (string_0.IndexOf('>', num7) + 1) : (-1));
				num9 = string_0.LastIndexOf("</html", StringComparison.OrdinalIgnoreCase);
				if (num < 0 && num2 < 0)
				{
					int num10 = string_0.IndexOf("<body", StringComparison.OrdinalIgnoreCase);
					num11 = ((num10 <= -1) ? (-1) : (string_0.IndexOf('>', num10) + 1));
					if (num8 < 0 && num11 < 0)
					{
						stringBuilder.Append("<html>\r\n<body>\r\n");
						stringBuilder.Append("<!--StartFragment-->");
						num5 = OJBLz9FVg9P(stringBuilder);
						stringBuilder.Append(string_0);
						num6 = OJBLz9FVg9P(stringBuilder);
						stringBuilder.Append("<!--EndFragment-->");
						stringBuilder.Append("\r\n</body>\r\n</html>");
						break;
					}
					goto case 4;
				}
				goto case 2;
			}
			case 1:
				{
					stringBuilder.Replace("<<<<<<<<3", num5.ToString("D9", CultureInfo.InvariantCulture), 0, "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n".Length);
					stringBuilder.Replace("<<<<<<<<4", num6.ToString("D9", CultureInfo.InvariantCulture), 0, "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n".Length);
					return stringBuilder.ToString();
				}
				IL_004f:
				num12 = num13;
				num14 = ((num15 > -1) ? num15 : ((num9 > -1) ? num9 : string_0.Length));
				stringBuilder.Append(string_0, num12, num14 - num12);
				num6 = OJBLz9FVg9P(stringBuilder);
				stringBuilder.Append("<!--EndFragment-->");
				if (num14 < string_0.Length)
				{
					stringBuilder.Append(string_0, num14, string_0.Length - num14);
				}
				if (num9 < 0)
				{
					stringBuilder.Append("</html>");
				}
				break;
			}
			stringBuilder.Replace("<<<<<<<<1", "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n".Length.ToString("D9", CultureInfo.InvariantCulture), 0, "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n".Length);
			stringBuilder.Replace("<<<<<<<<2", OJBLz9FVg9P(stringBuilder).ToString("D9", CultureInfo.InvariantCulture), 0, "Version:0.9\r\nStartHTML:<<<<<<<<1\r\nEndHTML:<<<<<<<<2\r\nStartFragment:<<<<<<<<3\r\nEndFragment:<<<<<<<<4\r\n".Length);
			num3 = 1;
		}
		while (nK9WeuFTuSXlWfXfm9QX());
		goto IL_013c;
	}

	private static int OJBLz9FVg9P(StringBuilder stringBuilder_0, int int_0 = 0, int int_1 = -1)
	{
		int num = 0;
		int_1 = ((int_1 > -1) ? int_1 : stringBuilder_0.Length);
		int num2 = int_0;
		while (num2 < int_1)
		{
			JQALzhf7Ipx[0] = stringBuilder_0[num2];
			num += Encoding.UTF8.GetByteCount(JQALzhf7Ipx);
			num2++;
			if (Edn0PPFTLDZTphAug6HY == null)
			{
				switch (0)
				{
				}
			}
		}
		return num;
	}

	public static string GetCleanHtml(string clipboardHtml)
	{
		if (clipboardHtml == null)
		{
			return string.Empty;
		}
		if (!clipboardHtml.Contains("<!--StartFragment-->"))
		{
			return clipboardHtml;
		}
		int num = clipboardHtml.IndexOf("<!--StartFragment-->") + "<!--StartFragment-->".Length;
		int num2 = clipboardHtml.LastIndexOf("<!--EndFragment-->");
		return clipboardHtml.Substring(num, num2 - num);
	}

	public static string GetHtmlDoc(string clipboardHtml)
	{
		int num = clipboardHtml.IndexOf("<html", StringComparison.OrdinalIgnoreCase);
		if (num >= 0)
		{
			return clipboardHtml.Substring(num);
		}
		return "";
	}

	static HtmlClipboardHelper()
	{
		JQALzhf7Ipx = new char[1];
	}

	internal static bool nK9WeuFTuSXlWfXfm9QX()
	{
		return Edn0PPFTLDZTphAug6HY == null;
	}
}
