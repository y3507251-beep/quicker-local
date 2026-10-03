using System;
using System.Runtime.InteropServices;
using System.Text;
using Linearstar.Windows.RawInput.Native;

namespace uDL5IgqaOLgOa1ojKgW;

internal static class EnuqjjqpaxFuoWX08Ny
{
	[Flags]
	public enum l5spsEdNJqVSnsuc0mk : uint
	{
		None = 0u
	}

	[Flags]
	public enum K7Hpfmdn5K3iD3SRAe4 : uint
	{
		None = 0u
	}

	public enum IUe16CdOnQDpuYThFec : uint
	{

	}

	internal static object cgplxGl05Jcj3iN80QJ;

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "CreateFile", SetLastError = true)]
	private static extern IntPtr ehWsJ8RvU6(string string_0, l5spsEdNJqVSnsuc0mk l5spsEdNJqVSnsuc0mk_0, K7Hpfmdn5K3iD3SRAe4 k7Hpfmdn5K3iD3SRAe4_0, IntPtr intptr_0, IUe16CdOnQDpuYThFec iue16CdOnQDpuYThFec_0, uint uint_0, IntPtr intptr_1);

	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool MYJs0y9yOe(IntPtr intptr_0);

	[DllImport("kernel32", EntryPoint = "GetModuleHandle", SetLastError = true)]
	private static extern IntPtr rPIsCXLeFl(string string_0);

	[DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
	private static extern IntPtr BwcsPta609(IntPtr intptr_0, string string_0);

	[DllImport("kernel32", EntryPoint = "IsWow64Process", SetLastError = true)]
	private static extern bool q2usEYyPr7(IntPtr intptr_0, out bool bool_0);

	[DllImport("kernel32", EntryPoint = "GetCurrentProcess")]
	public static extern IntPtr zaOsysPYcs();

	[DllImport("kernel32", EntryPoint = "FormatMessage", SetLastError = true)]
	private static extern uint m7es8DSZdp(uint uint_0, IntPtr intptr_0, uint uint_1, uint uint_2, StringBuilder stringBuilder_0, int int_0, IntPtr intptr_1);

	public static IntPtr eEjsar66mu(string string_0)
	{
		IntPtr intPtr = rPIsCXLeFl(string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32ErrorException();
		}
		return intPtr;
	}

	public static IntPtr gDbs71iRTx(IntPtr intptr_0, string string_0)
	{
		IntPtr intPtr = BwcsPta609(intptr_0, string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32ErrorException();
		}
		return intPtr;
	}

	public static bool IsWow64Process(IntPtr hProcess)
	{
		if (!q2usEYyPr7(hProcess, out var bool_))
		{
			throw new Win32ErrorException();
		}
		return bool_;
	}

	public static IntPtr J6LsRpApQv(string string_0, K7Hpfmdn5K3iD3SRAe4 k7Hpfmdn5K3iD3SRAe4_0, IUe16CdOnQDpuYThFec iue16CdOnQDpuYThFec_0, l5spsEdNJqVSnsuc0mk l5spsEdNJqVSnsuc0mk_0 = l5spsEdNJqVSnsuc0mk.None, IntPtr intptr_0 = default(IntPtr), uint uint_0 = 0u, IntPtr intptr_1 = default(IntPtr))
	{
		IntPtr intPtr = ehWsJ8RvU6(string_0, l5spsEdNJqVSnsuc0mk_0, k7Hpfmdn5K3iD3SRAe4_0, intptr_0, iue16CdOnQDpuYThFec_0, uint_0, intptr_1);
		if (intPtr == new IntPtr(-1))
		{
			throw new Win32ErrorException();
		}
		return intPtr;
	}

	public static bool D5Hsq3xFfD(string string_0, K7Hpfmdn5K3iD3SRAe4 k7Hpfmdn5K3iD3SRAe4_0, IUe16CdOnQDpuYThFec iue16CdOnQDpuYThFec_0, out IntPtr intptr_0, l5spsEdNJqVSnsuc0mk l5spsEdNJqVSnsuc0mk_0 = l5spsEdNJqVSnsuc0mk.None, IntPtr intptr_1 = default(IntPtr), uint uint_0 = 0u, IntPtr intptr_2 = default(IntPtr))
	{
		intptr_0 = ehWsJ8RvU6(string_0, l5spsEdNJqVSnsuc0mk_0, k7Hpfmdn5K3iD3SRAe4_0, intptr_1, iue16CdOnQDpuYThFec_0, uint_0, intptr_2);
		return intptr_0 != new IntPtr(-1);
	}

	public static string YGxsc88AFI(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		if (m7es8DSZdp(4096u, IntPtr.Zero, (uint)int_0, 0u, stringBuilder, stringBuilder.Capacity, IntPtr.Zero) == 0)
		{
			throw new Win32ErrorException();
		}
		return stringBuilder.ToString();
	}

	internal static bool mGDSYIl172JREQpU2RO()
	{
		return cgplxGl05Jcj3iN80QJ == null;
	}
}
