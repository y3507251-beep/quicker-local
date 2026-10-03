using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using PbBP6kiXxxQP7h8tKVK;
using Quicker.Utilities.Win32;

namespace lGFWOcimK6GZKnFIeLT;

internal class moAa3ciiBWM25Wu8vZH
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec iV52JApN3Cq;

		public static Func<Process, int> P5r2JOQSZT0;

		public static Func<string, string> H1M2JFKxAyr;

		internal static _003C_003Ec HyyLMNydAS1TtHjNfDMw;

		static _003C_003Ec()
		{
			iV52JApN3Cq = new _003C_003Ec();
		}

		internal int ml82JTMEUwR(Process x)
		{
			return x.Id;
		}

		internal string DrW2JMLbsXH(string x)
		{
			return x.Trim('"');
		}

		internal static bool bxqTanydnr4Iu4NeAuUU()
		{
			return HyyLMNydAS1TtHjNfDMw == null;
		}
	}

	private static moAa3ciiBWM25Wu8vZH NVaYiiFsl1vY5IkKb0hF;

	public static string jHKvtqwpORl(IntPtr intptr_0)
	{
		return IJbvt9oNVcD(intptr_0, "<curpath>", true);
	}

	public static string rELvtcvrD4D()
	{
		IntPtr intPtr = NativeMethods.FindWindow("ThunderRT6FormDC", null);
		if (!(intPtr != IntPtr.Zero))
		{
			return "";
		}
		return jHKvtqwpORl(intPtr);
	}

	public static IList<string> YWxvtVWhd1u()
	{
		IList<string> list = new List<string>();
		List<int> list2 = Process.GetProcessesByName("xyplorer").Select(_003C_003Ec.P5r2JOQSZT0 ?? (_003C_003Ec.P5r2JOQSZT0 = _003C_003Ec.iV52JApN3Cq.ml82JTMEUwR)).ToList();
		foreach (IntPtr item in OpenWindowGetter.FindAllWindowsWithClassName("ThunderRT6FormDC", StringComparison.Ordinal).Distinct().ToList())
		{
			if (NativeMethods.IsWindowVisible(item))
			{
				int windowProcessId = NativeMethods.GetWindowProcessId(item);
				if (list2.Contains(windowProcessId) && !string.Equals(NativeMethods.GetWindowText(item), "XYplorer", StringComparison.OrdinalIgnoreCase))
				{
					list.Add(jHKvtqwpORl(item));
				}
			}
		}
		return list;
	}

	public static IList<string> GPjvtZ95Zgk(IntPtr intptr_0)
	{
		string text = IJbvt9oNVcD(intptr_0, "<selitems>", true);
		if (text.Length < 5)
		{
			return new List<string>();
		}
		return text.Split(new string[1] { "\" \"" }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.H1M2JFKxAyr ?? (_003C_003Ec.H1M2JFKxAyr = _003C_003Ec.iV52JApN3Cq.DrW2JMLbsXH)).ToList();
	}

	private static string IJbvt9oNVcD(IntPtr intptr_0, string string_0, bool bool_0)
	{
		a0N27uijcmAHZSB2kQT a0N27uijcmAHZSB2kQT = (bool_0 ? new a0N27uijcmAHZSB2kQT() : null);
		try
		{
			string text;
			if (!bool_0)
			{
				if (!rl1qbfFsZic1adVGE9Qx())
				{
					switch (0)
					{
					}
				}
				text = string_0;
			}
			else
			{
				text = $"::copydata {a0N27uijcmAHZSB2kQT.Handle}, {string_0},0";
			}
			string value = text;
			CopyData.Send(intptr_0, 4194305, value, 1000u, true);
			if (bool_0 && a0N27uijcmAHZSB2kQT.pYVvwfSBmVx().WaitOne(1000))
			{
				return a0N27uijcmAHZSB2kQT.P2cvwlrxQPG();
			}
			return "";
		}
		finally
		{
			a0N27uijcmAHZSB2kQT?.Dispose();
		}
	}

	public static string ypNvthnlMBB()
	{
		Process[] processesByName = Process.GetProcessesByName("xyplorer");
		if (processesByName.Length != 0)
		{
			return processesByName.First().MainModule.FileName;
		}
		string[] array = new string[2] { "C:\\Program Files\\XYplorer\\XYplorer.exe", "C:\\Program Files (x86)\\XYplorer\\XYplorer.exe" };
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = array[num];
				if (File.Exists(text))
				{
					break;
				}
				num++;
				continue;
			}
			return "XYplorer.exe";
		}
		return text;
	}

	public static void BsUvtetS1KR(string string_0, bool bool_0)
	{
		Process.Start(ypNvthnlMBB(), "/select=\"" + string_0 + "\" " + (bool_0 ? "" : " /new"));
	}

	internal static bool rl1qbfFsZic1adVGE9Qx()
	{
		return NVaYiiFsl1vY5IkKb0hF == null;
	}
}
