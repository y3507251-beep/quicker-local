using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using jeaU1l2eVVj4W2gaVc;

namespace aBIHsFfYHZ0bZbXoos;

internal class ll4OrYMvB3SS5pvn6i
{
	internal static ll4OrYMvB3SS5pvn6i dkLvsfyyGjhfSAaQagp;

	internal static TimeSpan tNOg2XOdxr()
	{
		OO77uFW4jgnwuPwqBc.q5e3eEmUhgORbHuEg7c q5e3eEmUhgORbHuEg7c_ = default(OO77uFW4jgnwuPwqBc.q5e3eEmUhgORbHuEg7c);
		q5e3eEmUhgORbHuEg7c_.qlEvPytUtII = (uint)Marshal.SizeOf(q5e3eEmUhgORbHuEg7c_);
		OO77uFW4jgnwuPwqBc.zqitYFTh8i(ref q5e3eEmUhgORbHuEg7c_);
		return TimeSpan.FromMilliseconds(OO77uFW4jgnwuPwqBc.KtAtHaVmNe() - q5e3eEmUhgORbHuEg7c_.N6lvP8EGQ9R);
	}

	internal static bool miJgunkRCM(Process process_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			try
			{
				if (!OO77uFW4jgnwuPwqBc.EOrt6UnZGB(process_0.Handle, OO77uFW4jgnwuPwqBc.RZ6gSlyTTK, out intptr_))
				{
					throw new ApplicationException("OpenProcessToken() failed", Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error()));
				}
			}
			catch (Exception ex)
			{
				if (ex is Win32Exception && ex.HResult == -2147467259)
				{
					Process currentProcess = Process.GetCurrentProcess();
					if (process_0 != currentProcess && !miJgunkRCM(currentProcess))
					{
						return true;
					}
				}
				throw;
			}
			uint uint_ = (uint)Marshal.SizeOf(typeof(OO77uFW4jgnwuPwqBc.KkUs8lmFfBi5OUKvEsA));
			intPtr = Marshal.AllocHGlobal((int)uint_);
			if (!OO77uFW4jgnwuPwqBc.cTUtbJUilr(intptr_, (OO77uFW4jgnwuPwqBc.RMVQc5mVJPHjmjvGhwN)20, intPtr, uint_, out uint_))
			{
				throw new InvalidOperationException("GetTokenInformation() failed", Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error()));
			}
			return ((OO77uFW4jgnwuPwqBc.KkUs8lmFfBi5OUKvEsA)Marshal.PtrToStructure(intPtr, typeof(OO77uFW4jgnwuPwqBc.KkUs8lmFfBi5OUKvEsA))).ck3vPaY1rJg != 0;
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				OO77uFW4jgnwuPwqBc.aP4t18eMbV(intptr_);
			}
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	internal static bool dtOIkoypYEWCi0fQMva()
	{
		return dkLvsfyyGjhfSAaQagp == null;
	}
}
