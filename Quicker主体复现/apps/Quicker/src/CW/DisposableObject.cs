using System;

namespace CW;

public abstract class DisposableObject : IDisposable
{
	private bool q6y0wEABRo;

	private static DisposableObject Pwn2ug3Pvps6MAOUEZH;

	protected bool IsDisposed => q6y0wEABRo;

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		q6y0wEABRo = true;
	}

	protected void ThrowIfDisposed()
	{
		throw new ObjectDisposedException("this");
	}

	~DisposableObject()
	{
		Dispose(false);
	}

	internal static bool tbF2EP3MOaait0whdtc()
	{
		return Pwn2ug3Pvps6MAOUEZH == null;
	}
}
