using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CW.Win32;

public class InteropObject : IDisposable
{
	[CompilerGenerated]
	private IntPtr jP4C5daUl4;

	private bool h9uCDIAHTV;

	private static InteropObject LapwHw12KYQtapKJy9l;

	protected IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return jP4C5daUl4;
		}
		[CompilerGenerated]
		private set
		{
			jP4C5daUl4 = value;
		}
	}

	public InteropObject(string dllName)
		: this(Kernel32.LoadLibrary(dllName))
	{
	}

	public InteropObject(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("handle");
		}
		Handle = handle;
	}

	protected void ThrowIfDisposed()
	{
		if (h9uCDIAHTV)
		{
			throw new ObjectDisposedException("Handle");
		}
	}

	~InteropObject()
	{
		Dispose(false);
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!h9uCDIAHTV)
		{
			Kernel32.FreeLibrary(Handle);
			h9uCDIAHTV = true;
		}
	}

	public virtual T LoadMethod<T>(string name) where T : class
	{
		return o46Cnx8ZIS<T>(name, Handle);
	}

	private static A8ebsVqWOMwF7M97Pgh o46Cnx8ZIS<A8ebsVqWOMwF7M97Pgh>(string string_0, IntPtr intptr_1) where A8ebsVqWOMwF7M97Pgh : class
	{
		return Marshal.GetDelegateForFunctionPointer(Kernel32.GetProcAddress(intptr_1, string_0), typeof(A8ebsVqWOMwF7M97Pgh)) as A8ebsVqWOMwF7M97Pgh;
	}

	internal static bool xnRK621AmV0k1dQ0pmC()
	{
		return LapwHw12KYQtapKJy9l == null;
	}

	internal static void SGE63n1eb5QPaittrpY()
	{
	}
}
