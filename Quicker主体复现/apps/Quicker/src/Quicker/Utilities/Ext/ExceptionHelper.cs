using System;
using System.Text;

namespace Quicker.Utilities.Ext;

public static class ExceptionHelper
{
	private static object iCoTLDFIJfYDRrJj4nX0;

	public static string GetMessageWithInner(this Exception exception)
	{
		StringBuilder stringBuilder = new StringBuilder(100);
		for (Exception ex = exception; ex != null; ex = ex.InnerException)
		{
			stringBuilder.Append(ex.Message);
		}
		return stringBuilder.ToString();
	}

	internal static bool udjU96FIkehieHQ09T2P()
	{
		return iCoTLDFIJfYDRrJj4nX0 == null;
	}
}
