using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions.X.BuiltinRunners.File;

namespace PptRB0i5EX0bZPrKAwn;

internal class xjkIv1iq3Kqe7V2pm2d
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cEH2J6Y1pi9;

		public static Func<string, string> uTN2JXdxDub;

		internal static _003C_003Ec PfhvleyvSRywJcWVMGtS;

		static _003C_003Ec()
		{
			cEH2J6Y1pi9 = new _003C_003Ec();
		}

		internal string GIW2JbKjdvy(string x)
		{
			return x;
		}

		internal static bool zgxNEhyvwwUkRaRLrtWH()
		{
			return PfhvleyvSRywJcWVMGtS == null;
		}
	}

	private static xjkIv1iq3Kqe7V2pm2d cSchaJFscB60r4eGFb7R;

	public static List<string> t80vwkbu1qR(IList<string> ilist_0, string string_0)
	{
		if (ilist_0 == null)
		{
			return new List<string>();
		}
		if (ilist_0.Count == 1)
		{
			return ilist_0.ToList();
		}
		switch (string_0)
		{
		case "Origin":
			return ilist_0.ToList();
		case "FileName":
			return ilist_0.OrderBy(_003C_003Ec.uTN2JXdxDub ?? (_003C_003Ec.uTN2JXdxDub = _003C_003Ec.cEH2J6Y1pi9.GIW2JbKjdvy)).ToList();
		case "FileSizeAsc":
			return ilist_0.OrderBy(iVWvw1vUrEC).ToList();
		case "FileSizeDesc":
			return ilist_0.OrderByDescending(iVWvw1vUrEC).ToList();
		case "CreationTimeAsc":
			return ilist_0.OrderBy(rtFvwGs43wl).ToList();
		case "LastWriteTimeAsc":
			return ilist_0.OrderBy(LV5vwHwIeMa).ToList();
		case "CreationTimeDesc":
			return ilist_0.OrderByDescending(rtFvwGs43wl).ToList();
		case "LastWriteTimeDesc":
			return ilist_0.OrderByDescending(LV5vwHwIeMa).ToList();
		case "LastAccessTimeAsc":
			return ilist_0.OrderBy(FidvwsDtB80).ToList();
		case "LastAccessTimeDesc":
			return ilist_0.OrderByDescending(FidvwsDtB80).ToList();
		default:
		{
			string[] array = ilist_0.ToArray();
			Array.Sort(array, new FileNameSort());
			return array.ToList();
		}
		}
	}

	[CompilerGenerated]
	internal static DateTime rtFvwGs43wl(string string_0)
	{
		if (File.Exists(string_0))
		{
			return new FileInfo(string_0).CreationTime;
		}
		return DateTime.MaxValue;
	}

	[CompilerGenerated]
	internal static DateTime FidvwsDtB80(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return DateTime.MaxValue;
		}
		return new FileInfo(string_0).LastAccessTime;
	}

	[CompilerGenerated]
	internal static DateTime LV5vwHwIeMa(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return DateTime.MaxValue;
		}
		return new FileInfo(string_0).LastWriteTime;
	}

	[CompilerGenerated]
	internal static long iVWvw1vUrEC(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return 2147483647L;
		}
		return new FileInfo(string_0).Length;
	}

	internal static bool huKllOFsWGHCIEw91joM()
	{
		return cSchaJFscB60r4eGFb7R == null;
	}
}
