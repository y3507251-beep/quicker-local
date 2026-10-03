using System;
using System.Runtime.CompilerServices;

namespace Quicker.View.Controls;

public class TextSelectedEventArgs : EventArgs
{
	[CompilerGenerated]
	private string SbwLjH9PKG0;

	[CompilerGenerated]
	private bool XwlLj1aCqEo;

	private static TextSelectedEventArgs thNImMFqJxqKQs5EjvFZ;

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return SbwLjH9PKG0;
		}
		[CompilerGenerated]
		set
		{
			SbwLjH9PKG0 = value;
		}
	}

	public bool IsFullContent
	{
		[CompilerGenerated]
		get
		{
			return XwlLj1aCqEo;
		}
		[CompilerGenerated]
		set
		{
			XwlLj1aCqEo = value;
		}
	}

	public TextSelectedEventArgs(string value, bool isFullContent = false)
	{
		Value = value;
		IsFullContent = isFullContent;
	}

	internal static bool g6K0d2Fqk3cYRqVd5mnN()
	{
		return thNImMFqJxqKQs5EjvFZ == null;
	}
}
