using System;
using System.Runtime.InteropServices;

public static class KnownFolders
{
	[Flags]
	private enum dyDHAGmfsnvcrboyDS7 : uint
	{

	}

	private static string[] K6SLMWVPA;

	private static object yvmDtxcnUqXBGkQX3d2;

	public static string GetPath(KnownFolder knownFolder)
	{
		return GetPath(knownFolder, false);
	}

	public static string GetPath(KnownFolder knownFolder, bool defaultUser)
	{
		return jg3tPdbOJ(knownFolder, (dyDHAGmfsnvcrboyDS7)16384u, defaultUser);
	}

	private static string jg3tPdbOJ(KnownFolder knownFolder_0, dyDHAGmfsnvcrboyDS7 dyDHAGmfsnvcrboyDS7_0, bool bool_0)
	{
		IntPtr intptr_;
		int num = ILKgc3Ywe(new Guid(K6SLMWVPA[(int)knownFolder_0]), (uint)dyDHAGmfsnvcrboyDS7_0, new IntPtr(bool_0 ? (-1) : 0), out intptr_);
		if (num < 0)
		{
			throw new ExternalException("Unable to retrieve the known folder path. It may not be available on this system.", num);
		}
		string result = Marshal.PtrToStringUni(intptr_);
		Marshal.FreeCoTaskMem(intptr_);
		return result;
	}

	[DllImport("Shell32.dll", EntryPoint = "SHGetKnownFolderPath")]
	private static extern int ILKgc3Ywe([MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, uint uint_0, IntPtr intptr_0, out IntPtr intptr_1);

	static KnownFolders()
	{
		K6SLMWVPA = new string[11]
		{
			"{56784854-C6CB-462B-8169-88E350ACB882}", "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}", "{374DE290-123F-4565-9164-39C4925E467B}", "{1777F761-68AD-4D8A-87BD-30B759FA33DD}", "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", "{4BD8D571-6D19-48D3-BE97-422220080E43}", "{33E28130-4E1E-4676-835A-98395C3BC3BB}", "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}",
			"{18989B1D-99B5-455B-841C-AB7C74E4DDFC}"
		};
	}

	internal static bool AQv6uUcer6wHLgrVpcE()
	{
		return yvmDtxcnUqXBGkQX3d2 == null;
	}

	internal static void KnPiNScDbPoiOmjyCS2()
	{
	}
}
