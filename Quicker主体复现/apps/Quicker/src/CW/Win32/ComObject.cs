using System;
using System.Runtime.InteropServices;

namespace CW.Win32;

public class ComObject<T> : IDisposable
{
	private T oTL0iO0pHA;

	private bool Dob037Lvsh;

	internal static object dCfrjjGBGXSx1YwpomL;

	public T Interface
	{
		get
		{
			ThrowIfDisposed();
			return oTL0iO0pHA;
		}
	}

	public ComObject(T obj)
	{
		obj.ThrowIfNull("obj");
		if (!obj.GetType().IsCOMObject)
		{
			throw new ArgumentException("obj is not a ComObject");
		}
		oTL0iO0pHA = obj;
	}

	~ComObject()
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
		if (!Dob037Lvsh)
		{
			Marshal.FinalReleaseComObject(Interface);
			Dob037Lvsh = true;
		}
	}

	protected void ThrowIfDisposed()
	{
		if (Dob037Lvsh)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
	}

	internal static bool SE8ZWxGvu4gVJHdXxrf()
	{
		return dCfrjjGBGXSx1YwpomL == null;
	}
}
