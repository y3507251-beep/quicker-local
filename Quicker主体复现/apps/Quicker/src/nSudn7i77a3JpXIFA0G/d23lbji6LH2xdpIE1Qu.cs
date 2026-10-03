using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using gNDpGkYZYbhLdMnAyKv;
using log4net;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace nSudn7i77a3JpXIFA0G;

internal class d23lbji6LH2xdpIE1Qu
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ayB2JdfPlLg;

		public static Func<string, string> SXg2JocXbbQ;

		internal static _003C_003Ec dqY9Ifydpv7tITXttmtq;

		static _003C_003Ec()
		{
			ayB2JdfPlLg = new _003C_003Ec();
		}

		internal string FXO2JDSpeb0(string x)
		{
			return x.TrimEnd('\\');
		}

		internal static bool iLhHdrydXAq8wupQN88J()
		{
			return dqY9Ifydpv7tITXttmtq == null;
		}
	}

	private static readonly ILog u3Jvt7Sgt0A;

	private static string bEOvtRcxwhy;

	private static d23lbji6LH2xdpIE1Qu ppplu4FsbRGbuA88aGXa;

	public static string mB2vt0Xicgu(IntPtr? nullable_0 = null)
	{
		IntPtr windowHandleOrForegroundWindow = NativeMethods.GetWindowHandleOrForegroundWindow(nullable_0);
		if (string.Equals(NativeMethods.GetWindowClass(windowHandleOrForegroundWindow), bEOvtRcxwhy, StringComparison.OrdinalIgnoreCase))
		{
			NativeMethods.SendMessage(windowHandleOrForegroundWindow, 1075, (IntPtr)2029L, IntPtr.Zero);
			try
			{
				return ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText)?.TrimEnd('\\');
			}
			catch (Exception ex)
			{
				u3Jvt7Sgt0A.Warn("读取剪贴板文本失败。" + ex.Message, ex);
				return "";
			}
		}
		return string.Empty;
	}

	public static IList<string> Ii0vtCTbFZR(IntPtr intptr_0)
	{
		NativeMethods.SendMessage(intptr_0, 1075, (IntPtr)2018L, IntPtr.Zero);
		try
		{
			return kWsP1bYRVsfaicfjr67.n78L5HxDVZd().SplitToList().Select(_003C_003Ec.SXg2JocXbbQ ?? (_003C_003Ec.SXg2JocXbbQ = _003C_003Ec.ayB2JdfPlLg.FXO2JDSpeb0))
				.ToList();
		}
		catch (Exception)
		{
			return new List<string>();
		}
	}

	public static IList<string> VhcvtPyGMtT()
	{
		IntPtr intPtr = NativeMethods.FindWindow(bEOvtRcxwhy, null);
		IList<string> list = new List<string>();
		if (intPtr != IntPtr.Zero)
		{
			NativeMethods.SendMessage(intPtr, 1075, (IntPtr)2029L, IntPtr.Zero);
			try
			{
				string item = kWsP1bYRVsfaicfjr67.n78L5HxDVZd();
				list.Add(item);
			}
			catch (Exception)
			{
				list.Add(string.Empty);
			}
		}
		return list;
	}

	public static bool bMVvtEbDbyL(IntPtr intptr_0)
	{
		return string.Equals(NativeMethods.GetWindowClass(intptr_0), bEOvtRcxwhy);
	}

	public static bool GVRvtyjnHLf(string string_1)
	{
		return string.Equals(string_1, bEOvtRcxwhy);
	}

	public static string Byjvt8r01Aa()
	{
		int num = 1;
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("totalcmd64");
			int num2 = 0;
			if (ppplu4FsbRGbuA88aGXa != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (processesByName.Length != 0)
			{
				return processesByName.First().MainModule.FileName;
			}
			processesByName = Process.GetProcessesByName("totalcmd");
			if (processesByName.Length != 0)
			{
				return processesByName.First().MainModule.FileName;
			}
			string[] array = new string[2] { "C:\\Program Files\\totalcmd\\TOTALCMD64.EXE", "C:\\Program Files\\totalcmd\\TOTALCMD.EXE" };
			foreach (string text in array)
			{
				if (File.Exists(text))
				{
					return text;
				}
			}
			return "TOTALCMD64.exe";
		}
	}

	public static void swUvtalkhAk(string string_1, bool bool_0)
	{
		Process.Start(Byjvt8r01Aa(), (bool_0 ? "/O" : "/N") + " \"" + string_1 + "\"");
	}

	static d23lbji6LH2xdpIE1Qu()
	{
		u3Jvt7Sgt0A = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		bEOvtRcxwhy = "TTOTAL_CMD";
	}

	internal static bool AMZEa9FsqsXmcMfyPpe2()
	{
		return ppplu4FsbRGbuA88aGXa == null;
	}
}
