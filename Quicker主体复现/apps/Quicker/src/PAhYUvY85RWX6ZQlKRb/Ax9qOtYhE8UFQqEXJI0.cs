using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using log4net;
using Quicker.Domain;
using Quicker.Utilities.Win32;

namespace PAhYUvY85RWX6ZQlKRb;

internal class Ax9qOtYhE8UFQqEXJI0
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct zhHVZpD2eI3PFOH2Zgm
	{
		public Guid CN9Sdc4j4CG;

		public uint bwDSdVCfRey;

		public byte Data;
	}

	private static readonly ILog D9NLRYIoirW;

	[CompilerGenerated]
	private static readonly Guid ScELRI2VSBi;

	private static IntPtr YGSLRWOgYKg;

	internal static Ax9qOtYhE8UFQqEXJI0 eBoLUmF04QJcXuqp0rN6;

	[SpecialName]
	[CompilerGenerated]
	public static Guid Q5eLRhcX8yo()
	{
		return ScELRI2VSBi;
	}

	[DllImport("user32.dll", EntryPoint = "RegisterPowerSettingNotification", SetLastError = true)]
	private static extern IntPtr xccLRqqnUSc(IntPtr intptr_1, [In] Guid guid_1, uint uint_0);

	[DllImport("user32.dll", EntryPoint = "UnregisterPowerSettingNotification", SetLastError = true)]
	private static extern bool rabLRcH5kgV(IntPtr intptr_1);

	internal static void YH9LRVwBjhw(IntPtr intptr_1)
	{
		if (NativeMethods.IsOnWindows10OrLater())
		{
			Guid scELRI2VSBi = ScELRI2VSBi;
			YGSLRWOgYKg = xccLRqqnUSc(intptr_1, scELRI2VSBi, 0u);
		}
	}

	internal static void GFNLRZ3jPo2()
	{
		if (YGSLRWOgYKg != IntPtr.Zero)
		{
			rabLRcH5kgV(YGSLRWOgYKg);
			YGSLRWOgYKg = IntPtr.Zero;
		}
	}

	internal static void Jr2LR9tI1hH(IntPtr intptr_1, IntPtr intptr_2)
	{
		if (intptr_1.ToInt32() != 32787)
		{
			return;
		}
		zhHVZpD2eI3PFOH2Zgm zhHVZpD2eI3PFOH2Zgm = (zhHVZpD2eI3PFOH2Zgm)Marshal.PtrToStructure(intptr_2, typeof(zhHVZpD2eI3PFOH2Zgm));
		if (zhHVZpD2eI3PFOH2Zgm.CN9Sdc4j4CG == ScELRI2VSBi)
		{
			D9NLRYIoirW.Warn($"显示器电源状态改变了：{zhHVZpD2eI3PFOH2Zgm.Data}");
			switch (zhHVZpD2eI3PFOH2Zgm.Data)
			{
			case 0:
				AppState.v5FtaQ4hQfg()?.R8Fvtoeu87h();
				break;
			case 1:
			case 2:
				break;
			}
		}
	}

	static Ax9qOtYhE8UFQqEXJI0()
	{
		D9NLRYIoirW = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ScELRI2VSBi = new Guid("6fe69556-704a-47a0-8f24-c28d936fda47");
	}

	internal static bool VikSmjF0hCfSii6u6XLe()
	{
		return eBoLUmF04QJcXuqp0rN6 == null;
	}
}
