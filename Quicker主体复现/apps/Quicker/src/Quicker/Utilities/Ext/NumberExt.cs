namespace Quicker.Utilities.Ext;

public static class NumberExt
{
	private static object VD8guIFI86FxMUSJl5l9;

	public static string GetBytesReadable(this long fileLength)
	{
		if (fileLength < 0L)
		{
			return string.Empty;
		}
		long num = ((fileLength < 0L) ? (-fileLength) : fileLength);
		string text = default(string);
		int num2;
		if (num >= 1152921504606846976L)
		{
			text = "EB";
			num2 = 0;
			if (VD8guIFI86FxMUSJl5l9 != null)
			{
				goto IL_00bc;
			}
			goto IL_00c0;
		}
		double num3;
		if (num >= 1125899906842624L)
		{
			text = "PB";
			num3 = fileLength >> 40;
		}
		else if (num >= 1099511627776L)
		{
			text = "TB";
			num3 = fileLength >> 30;
		}
		else
		{
			if (num < 1073741824L)
			{
				if (num >= 1048576L)
				{
					num2 = 1;
					if (!W1y6m0FIR8cNVUGHr075())
					{
						goto IL_00bc;
					}
					goto IL_00c0;
				}
				goto IL_00ea;
			}
			text = "GB";
			num3 = fileLength >> 20;
		}
		goto IL_0102;
		IL_00da:
		text = "MB";
		num3 = fileLength >> 10;
		goto IL_0102;
		IL_00ea:
		if (num >= 1024L)
		{
			text = "KB";
			num3 = fileLength;
			goto IL_0102;
		}
		return fileLength.ToString("0 B");
		IL_0102:
		return (num3 / 1024.0).ToString("0.### ") + text;
		IL_00bc:
		int num4 = default(int);
		num2 = num4;
		goto IL_00c0;
		IL_00c0:
		switch (num2)
		{
		case 1:
			goto IL_00da;
		case 2:
			goto IL_00ea;
		}
		num3 = fileLength >> 50;
		goto IL_0102;
	}

	internal static bool W1y6m0FIR8cNVUGHr075()
	{
		return VD8guIFI86FxMUSJl5l9 == null;
	}
}
