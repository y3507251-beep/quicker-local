using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Xml.XPath;
using Quicker.Utilities.Win32;

namespace x6MHGwiYv06PXoBFlMe;

internal class cQCX97ioFnivYTCZNWb
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LY62J4fXshP;

		public static Func<XElement, string> GUe2J585nT1;

		private static _003C_003Ec MZGCEyydcTSmZLFUHW0Q;

		static _003C_003Ec()
		{
			LY62J4fXshP = new _003C_003Ec();
		}

		internal string q2Z2JnZbeJk(XElement x)
		{
			return x.Value;
		}

		internal static bool uvDrNxydWQQjwABB9a6u()
		{
			return MZGCEyydcTSmZLFUHW0Q == null;
		}
	}

	internal static cQCX97ioFnivYTCZNWb axKLh6Fsa0tWFme0dlyh;

	public static (string activeFolder, List<string> pathList) Oi3vtvYuFIC(IntPtr? nullable_0 = null)
	{
		Process process = null;
		string fileName = "";
		if (nullable_0.HasValue && nullable_0 != IntPtr.Zero)
		{
			process = Process.GetProcessById(NativeMethods.GetWindowProcessId(nullable_0.Value));
			fileName = SiWvtSpXyhu(process);
		}
		if (process == null)
		{
			Process[] processesByName = Process.GetProcessesByName("dopus");
			fileName = SiWvtSpXyhu(processesByName.FirstOrDefault());
			Process[] array = processesByName;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
		}
		string text = Path.Combine(Path.GetTempPath(), $"DOpusCurrentPathList{new Random().Next(1, 10000)}.xml");
		Process.Start(fileName, "/info \"" + text + "\",paths").WaitForExit();
		XDocument node = XDocument.Load(text);
		string item = node.XPathSelectElement("//path[@tab_state = \"1\" and @active_lister = \"1\"]")?.Value;
		List<string> item2 = node.XPathSelectElements("//path").Select(_003C_003Ec.GUe2J585nT1 ?? (_003C_003Ec.GUe2J585nT1 = _003C_003Ec.LY62J4fXshP.q2Z2JnZbeJk)).Distinct()
			.ToList();
		try
		{
			File.Delete(text);
		}
		catch
		{
		}
		return (activeFolder: item, pathList: item2);
	}

	public static string SiWvtSpXyhu(Process process_0)
	{
		string text = h48vt2UE3Qi(process_0);
		if (string.IsNullOrEmpty(text))
		{
			return "dopusrt.exe";
		}
		return Path.Combine(Path.GetDirectoryName(text), "dopusrt.exe");
	}

	public static string h48vt2UE3Qi(Process process_0)
	{
		string text = process_0?.MainModule?.FileName;
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		Process[] processesByName = Process.GetProcessesByName("dopus");
		if (processesByName.Length != 0)
		{
			return processesByName.First().MainModule.FileName;
		}
		string[] array = new string[2] { "C:\\Program Files\\GPSoftware\\Directory Opus\\dopus.exe", "C:\\Program Files\\GPSoftware\\Directory Opus\\x86\\dopus.exe" };
		int num = 0;
		if (!SsleRkFsr4vuNP4r4hQ9())
		{
			switch (0)
			{
			}
		}
		string text2;
		while (true)
		{
			if (num < array.Length)
			{
				text2 = array[num];
				if (File.Exists(text2))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return text2;
	}

	public static void RKnvtujdkvE(string string_0, bool bool_0)
	{
		string fileName = SiWvtSpXyhu(null);
		if (bool_0)
		{
			Process.Start(fileName, "/acmd Go OPENCONTAINER  PATH \"" + string_0 + "\"");
		}
		else
		{
			Process.Start(fileName, "/cmd Go NEW OPENCONTAINER  PATH \"" + string_0 + "\"");
		}
	}

	internal static bool SsleRkFsr4vuNP4r4hQ9()
	{
		return axKLh6Fsa0tWFme0dlyh == null;
	}

	internal static void ntDehlFs9iYWTV7pOC9O()
	{
	}
}
