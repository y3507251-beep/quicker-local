using System;
using System.Runtime.InteropServices;
using dEptmnjuX91uT4B7PlH;
using mMlCOojYmdCcKxc2xbS;
using oD6aIXjX1joLOmPpZyU;
using Qceu8FjhHJUKPpB3xRv;
using Qx90CijH4CbVakG9AUU;
using uaENCmj2AT3VtCmFkep;
using xEdk6pj7e8rXUW6CTtX;

namespace OUPhcojbqgmr7E0YPqc;

internal class zEptxhj8yXAZ9Jur4si
{
	public static G8otmGj6TaPBeyVE5LF aqEtItoMjkb;

	internal static zEptxhj8yXAZ9Jur4si efgsj8QOb2ymDfAVXqAV;

	[DllImport("advapi32", CharSet = CharSet.Auto, EntryPoint = "OpenProcessToken", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool NZwtYArKS6m(IntPtr intptr_0, uint uint_0, out J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_0);

	[DllImport("advapi32", CharSet = CharSet.Auto, EntryPoint = "DuplicateTokenEx", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool TuctYOjQOXg(J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_0, uint uint_0, IntPtr intptr_0, YyBrECjjOJnG5xQU07Y yyBrECjjOJnG5xQU07Y_0, zBAWFWjoJSEKjwL4pjg zBAWFWjoJSEKjwL4pjg_0, out J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTokenInformation", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool LV2tYFUsRgd(J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_0, qAuJHTjWew9FAQSDppK qAuJHTjWew9FAQSDppK_0, IntPtr intptr_0, int int_0, out int int_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetTokenInformation", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PadtYU05du1(J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_0, qAuJHTjWew9FAQSDppK qAuJHTjWew9FAQSDppK_0, IntPtr intptr_0, int int_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetSidSubAuthority", SetLastError = true)]
	public static extern IntPtr JPMtYlLF5j0(IntPtr intptr_0, uint uint_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "AllocateAndInitializeSid", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool s06tYiL9Iy1(ref G8otmGj6TaPBeyVE5LF g8otmGj6TaPBeyVE5LF_0, byte byte_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, out IntPtr intptr_0);

	[DllImport("advapi32.dll", EntryPoint = "FreeSid")]
	public static extern IntPtr zqdtY3jLjS4(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetLengthSid", SetLastError = true)]
	public static extern int GJhtYfA580h(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateProcessAsUser", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WU8tYzG8M5P(J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_0, string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref CGoqaXjdYgVg5n9jhSc cgoqaXjdYgVg5n9jhSc_0, out OrIZqRjDg8vDDFJltBG orIZqRjDg8vDDFJltBG_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool C4atIwklcP8(IntPtr intptr_0);

	static zEptxhj8yXAZ9Jur4si()
	{
		aqEtItoMjkb = new G8otmGj6TaPBeyVE5LF(new byte[6] { 0, 0, 0, 0, 0, 16 });
	}

	internal static bool mVINXjQOq71hF54FnZLY()
	{
		return efgsj8QOb2ymDfAVXqAV == null;
	}
}
