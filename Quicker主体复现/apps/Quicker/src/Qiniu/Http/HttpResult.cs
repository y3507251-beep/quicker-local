using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Qiniu.Http;

public class HttpResult
{
	[CompilerGenerated]
	private int sQ4WTuqptf;

	[CompilerGenerated]
	private string d4YWMR9f9W;

	[CompilerGenerated]
	private byte[] f04WAXZNbw;

	[CompilerGenerated]
	private int eM4WOVmyjP;

	[CompilerGenerated]
	private string awWWFJYmi7;

	[CompilerGenerated]
	private Dictionary<string, string> g4VWUVhbHS;

	public static HttpResult InvalidToken;

	public static HttpResult InvalidFile;

	internal static HttpResult s0cGe1bY6Qbvf4VvcXi;

	public int Code
	{
		[CompilerGenerated]
		get
		{
			return sQ4WTuqptf;
		}
		[CompilerGenerated]
		set
		{
			sQ4WTuqptf = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return d4YWMR9f9W;
		}
		[CompilerGenerated]
		set
		{
			d4YWMR9f9W = value;
		}
	}

	public byte[] Data
	{
		[CompilerGenerated]
		get
		{
			return f04WAXZNbw;
		}
		[CompilerGenerated]
		set
		{
			f04WAXZNbw = value;
		}
	}

	public int RefCode
	{
		[CompilerGenerated]
		get
		{
			return eM4WOVmyjP;
		}
		[CompilerGenerated]
		set
		{
			eM4WOVmyjP = value;
		}
	}

	public string RefText
	{
		[CompilerGenerated]
		get
		{
			return awWWFJYmi7;
		}
		[CompilerGenerated]
		set
		{
			awWWFJYmi7 = value;
		}
	}

	public Dictionary<string, string> RefInfo
	{
		[CompilerGenerated]
		get
		{
			return g4VWUVhbHS;
		}
		[CompilerGenerated]
		set
		{
			g4VWUVhbHS = value;
		}
	}

	public HttpResult()
	{
		Code = 0;
		Text = null;
		Data = null;
		RefCode = 0;
		RefInfo = null;
	}

	public void Shadow(HttpResult hr)
	{
		Code = hr.Code;
		Text = hr.Text;
		Data = hr.Data;
		RefCode = hr.RefCode;
		RefText += hr.RefText;
		RefInfo = hr.RefInfo;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("code:{0}", Code);
		stringBuilder.AppendLine();
		if (!string.IsNullOrEmpty(Text))
		{
			stringBuilder.AppendLine("text:");
			stringBuilder.AppendLine(Text);
		}
		int num;
		if (Data != null)
		{
			stringBuilder.AppendLine("data:");
			int count = 1024;
			if (Data.Length <= 1024)
			{
				stringBuilder.AppendLine(Encoding.UTF8.GetString(Data));
			}
			else
			{
				stringBuilder.AppendLine(Encoding.UTF8.GetString(Data, 0, count));
				stringBuilder.AppendFormat("<--- TOO-LARGE-TO-DISPLAY --- TOTAL {0} BYTES --->", Data.Length);
				stringBuilder.AppendLine();
				num = 1;
				if (s0cGe1bY6Qbvf4VvcXi == null)
				{
					goto IL_00ef;
				}
			}
		}
		goto IL_00fe;
		IL_00fe:
		stringBuilder.AppendLine();
		stringBuilder.AppendFormat("ref-code:{0}", RefCode);
		stringBuilder.AppendLine();
		if (!string.IsNullOrEmpty(RefText))
		{
			stringBuilder.AppendLine("ref-text:");
			num = 0;
			if (s0cGe1bY6Qbvf4VvcXi == null)
			{
				goto IL_00ef;
			}
			goto IL_0133;
		}
		goto IL_0140;
		IL_00ef:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0133;
		}
		goto IL_00fe;
		IL_0140:
		if (RefInfo != null)
		{
			stringBuilder.AppendLine("ref-info:");
			foreach (KeyValuePair<string, string> item in RefInfo)
			{
				stringBuilder.AppendLine($"{item.Key}:{item.Value}");
			}
		}
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
		IL_0133:
		stringBuilder.AppendLine(RefText);
		goto IL_0140;
	}

	static HttpResult()
	{
		InvalidToken = new HttpResult
		{
			Code = -5,
			Text = "invalid uptoken"
		};
		InvalidFile = new HttpResult
		{
			Code = -3,
			Text = "invalid file"
		};
	}

	internal static bool zoH9dPb8bSuFtU7pSfU()
	{
		return s0cGe1bY6Qbvf4VvcXi == null;
	}
}
