using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using dEptmnjuX91uT4B7PlH;
using mMlCOojYmdCcKxc2xbS;
using oD6aIXjX1joLOmPpZyU;
using OUPhcojbqgmr7E0YPqc;
using PInvoke;
using Qceu8FjhHJUKPpB3xRv;
using Quicker.Public.Extensions;
using Qx90CijH4CbVakG9AUU;
using uaENCmj2AT3VtCmFkep;
using XjXgVJjmX6isQ6scBxd;

namespace N3JZlujw68npkGqT5RD;

internal class nVGFy1jAXcXA9v3fxMY
{
	private static nVGFy1jAXcXA9v3fxMY PcjiylQOcvbeSPgErf46;

	internal static void yQQtYes02yS(string string_0, string string_1, string string_2)
	{
		string string_3 = ((string_0 == null || !string_0.Contains(" ")) ? (string_0 + " " + string_1) : ("\"" + string_0 + "\" " + string_1));
		string string_4 = null;
		if (File.Exists(string_0) && !string_2.IsNullOrWhiteSpace())
		{
			string_4 = string_2;
		}
		JFxtYIZWMqP(string_3, string_4);
	}

	private static string yPqtYYJksDd(string string_0, string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string_0.Trim();
		int num3;
		if (text.StartsWith("\"", StringComparison.Ordinal))
		{
			int num = 0;
			if (!TwjdqsQOWIDPuGckqpQd())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			num3 = (text.EndsWith("\"", StringComparison.Ordinal) ? 1 : 0);
			if (num3 != 0)
			{
				goto IL_005b;
			}
		}
		else
		{
			num3 = 0;
		}
		stringBuilder.Append("\"");
		goto IL_005b;
		IL_005b:
		stringBuilder.Append(text);
		if (num3 == 0)
		{
			stringBuilder.Append("\"");
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(string_1);
		}
		return stringBuilder.ToString();
	}

	internal static void JFxtYIZWMqP(string string_0, string string_1)
	{
		J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_ = null;
		J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_2 = null;
		IntPtr intptr_ = IntPtr.Zero;
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		CGoqaXjdYgVg5n9jhSc cgoqaXjdYgVg5n9jhSc_ = default(CGoqaXjdYgVg5n9jhSc);
		OrIZqRjDg8vDDFJltBG orIZqRjDg8vDDFJltBG_ = default(OrIZqRjDg8vDDFJltBG);
		try
		{
			if (!zEptxhj8yXAZ9Jur4si.NZwtYArKS6m(Process.GetCurrentProcess().Handle, 139u, out j5OsNbjkeHWh8x6vKyY_))
			{
				throw new Win32Exception();
			}
			if (!zEptxhj8yXAZ9Jur4si.TuctYOjQOXg(j5OsNbjkeHWh8x6vKyY_, 0u, IntPtr.Zero, (YyBrECjjOJnG5xQU07Y)2, (zBAWFWjoJSEKjwL4pjg)1, out j5OsNbjkeHWh8x6vKyY_2))
			{
				throw new Win32Exception();
			}
			if (zEptxhj8yXAZ9Jur4si.s06tYiL9Iy1(ref zEptxhj8yXAZ9Jur4si.aqEtItoMjkb, 1, 8192, 0, 0, 0, 0, 0, 0, 0, out intptr_))
			{
				JqrcYxjis72dtvEyDUy structure = default(JqrcYxjis72dtvEyDUy);
				structure.Label.YhvtYGAUMue = 32u;
				structure.Label.BtZtYkTv9sV = intptr_;
				num = Marshal.SizeOf(structure);
				int num2 = 0;
				if (!TwjdqsQOWIDPuGckqpQd())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				intPtr = Marshal.AllocHGlobal(num);
				Marshal.StructureToPtr(structure, intPtr, false);
				if (!zEptxhj8yXAZ9Jur4si.PadtYU05du1(j5OsNbjkeHWh8x6vKyY_2, (qAuJHTjWew9FAQSDppK)25, intPtr, num + zEptxhj8yXAZ9Jur4si.GJhtYfA580h(intptr_)))
				{
					throw new Win32Exception();
				}
				cgoqaXjdYgVg5n9jhSc_.UTLtYsodAZQ = Marshal.SizeOf(cgoqaXjdYgVg5n9jhSc_);
				if (!zEptxhj8yXAZ9Jur4si.WU8tYzG8M5P(j5OsNbjkeHWh8x6vKyY_2, null, string_0, IntPtr.Zero, IntPtr.Zero, false, 0u, IntPtr.Zero, string_1, ref cgoqaXjdYgVg5n9jhSc_, out orIZqRjDg8vDDFJltBG_))
				{
					throw new Win32Exception();
				}
				return;
			}
			throw new Win32Exception();
		}
		finally
		{
			if (j5OsNbjkeHWh8x6vKyY_ != null)
			{
				j5OsNbjkeHWh8x6vKyY_.Close();
				j5OsNbjkeHWh8x6vKyY_ = null;
			}
			int num4;
			if (j5OsNbjkeHWh8x6vKyY_2 != null)
			{
				j5OsNbjkeHWh8x6vKyY_2.Close();
				j5OsNbjkeHWh8x6vKyY_2 = null;
				num4 = 1;
				if (!TwjdqsQOWIDPuGckqpQd())
				{
					goto IL_0172;
				}
				goto IL_0176;
			}
			goto IL_0185;
			IL_0185:
			if (intptr_ != IntPtr.Zero)
			{
				zEptxhj8yXAZ9Jur4si.zqdtY3jLjS4(intptr_);
				intptr_ = IntPtr.Zero;
				num4 = 0;
				if (!TwjdqsQOWIDPuGckqpQd())
				{
					goto IL_0172;
				}
				goto IL_0176;
			}
			goto IL_0193;
			IL_0176:
			switch (num4)
			{
			case 1:
				break;
			default:
				goto IL_0193;
			}
			goto IL_0185;
			IL_0193:
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
				num = 0;
			}
			if (orIZqRjDg8vDDFJltBG_.ycdtYdoF2de != IntPtr.Zero)
			{
				zEptxhj8yXAZ9Jur4si.C4atIwklcP8(orIZqRjDg8vDDFJltBG_.ycdtYdoF2de);
				orIZqRjDg8vDDFJltBG_.ycdtYdoF2de = IntPtr.Zero;
			}
			if (orIZqRjDg8vDDFJltBG_.QgAtYo8YDWZ != IntPtr.Zero)
			{
				zEptxhj8yXAZ9Jur4si.C4atIwklcP8(orIZqRjDg8vDDFJltBG_.QgAtYo8YDWZ);
				orIZqRjDg8vDDFJltBG_.QgAtYo8YDWZ = IntPtr.Zero;
			}
			goto end_IL_012b;
			IL_0172:
			int num5 = default(int);
			num4 = num5;
			goto IL_0176;
			end_IL_012b:;
		}
	}

	internal static int RdStYWIvLZA()
	{
		int num = -1;
		J5OsNbjkeHWh8x6vKyY j5OsNbjkeHWh8x6vKyY_ = null;
		int int_ = 0;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			if (!zEptxhj8yXAZ9Jur4si.NZwtYArKS6m(Process.GetCurrentProcess().Handle, 8u, out j5OsNbjkeHWh8x6vKyY_))
			{
				throw new Win32Exception();
			}
			if (!zEptxhj8yXAZ9Jur4si.LV2tYFUsRgd(j5OsNbjkeHWh8x6vKyY_, (qAuJHTjWew9FAQSDppK)25, IntPtr.Zero, 0, out int_))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 122)
				{
					throw new Win32Exception(lastWin32Error);
				}
			}
			intPtr = Marshal.AllocHGlobal(int_);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception();
			}
			if (!zEptxhj8yXAZ9Jur4si.LV2tYFUsRgd(j5OsNbjkeHWh8x6vKyY_, (qAuJHTjWew9FAQSDppK)25, intPtr, int_, out int_))
			{
				throw new Win32Exception();
			}
			return Marshal.ReadInt32(zEptxhj8yXAZ9Jur4si.JPMtYlLF5j0(((JqrcYxjis72dtvEyDUy)Marshal.PtrToStructure(intPtr, typeof(JqrcYxjis72dtvEyDUy))).Label.BtZtYkTv9sV, 0u));
		}
		finally
		{
			if (j5OsNbjkeHWh8x6vKyY_ != null)
			{
				j5OsNbjkeHWh8x6vKyY_.Close();
				j5OsNbjkeHWh8x6vKyY_ = null;
			}
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
				int_ = 0;
			}
		}
	}

	internal static bool TwjdqsQOWIDPuGckqpQd()
	{
		return PcjiylQOcvbeSPgErf46 == null;
	}
}
