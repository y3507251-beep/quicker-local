using System;
using System.Runtime;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct PKEY
{
	private readonly Guid mTvESu7k81;

	private readonly uint YLJE2nl0vX;

	public static readonly PKEY Title;

	public static readonly PKEY AppUserModel_ID;

	public static readonly PKEY AppUserModel_IsDestListSeparator;

	public static readonly PKEY AppUserModel_RelaunchCommand;

	public static readonly PKEY AppUserModel_RelaunchDisplayNameResource;

	public static readonly PKEY AppUserModel_RelaunchIconResource;

	internal static object NMimkZBHK3stqQD1sNm;

	[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
	public PKEY(Guid fmtid, uint pid)
	{
		mTvESu7k81 = fmtid;
		YLJE2nl0vX = pid;
	}

	static PKEY()
	{
		Title = new PKEY(new Guid("F29F85E0-4FF9-1068-AB91-08002B27B3D9"), 2u);
		AppUserModel_ID = new PKEY(new Guid("9F4C2855-9F79-4B39-A8D0-E1D42DE1D5F3"), 5u);
		AppUserModel_IsDestListSeparator = new PKEY(new Guid("9F4C2855-9F79-4B39-A8D0-E1D42DE1D5F3"), 6u);
		AppUserModel_RelaunchCommand = new PKEY(new Guid("9F4C2855-9F79-4B39-A8D0-E1D42DE1D5F3"), 2u);
		AppUserModel_RelaunchDisplayNameResource = new PKEY(new Guid("9F4C2855-9F79-4B39-A8D0-E1D42DE1D5F3"), 4u);
		AppUserModel_RelaunchIconResource = new PKEY(new Guid("9F4C2855-9F79-4B39-A8D0-E1D42DE1D5F3"), 3u);
	}

	internal static bool feJ6XrBzI0hmwDW4k8Y()
	{
		return NMimkZBHK3stqQD1sNm == null;
	}
}
