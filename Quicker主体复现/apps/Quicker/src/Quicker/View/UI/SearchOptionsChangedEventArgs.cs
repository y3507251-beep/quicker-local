using System;
using System.Runtime.CompilerServices;

namespace Quicker.View.UI;

public class SearchOptionsChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private string cDpLyRZK8Ky;

	[CompilerGenerated]
	private bool k6eLyqbSOTD;

	[CompilerGenerated]
	private bool cDVLyc93DOx;

	[CompilerGenerated]
	private bool Q8ELyVbRqbm;

	private static SearchOptionsChangedEventArgs l4ttDbFGLLpTYnIHPYfY;

	public string SearchPattern
	{
		[CompilerGenerated]
		get
		{
			return cDpLyRZK8Ky;
		}
		[CompilerGenerated]
		private set
		{
			cDpLyRZK8Ky = value;
		}
	}

	public bool MatchCase
	{
		[CompilerGenerated]
		get
		{
			return k6eLyqbSOTD;
		}
		[CompilerGenerated]
		private set
		{
			k6eLyqbSOTD = value;
		}
	}

	public bool UseRegex
	{
		[CompilerGenerated]
		get
		{
			return cDVLyc93DOx;
		}
		[CompilerGenerated]
		private set
		{
			cDVLyc93DOx = value;
		}
	}

	public bool WholeWords
	{
		[CompilerGenerated]
		get
		{
			return Q8ELyVbRqbm;
		}
		[CompilerGenerated]
		private set
		{
			Q8ELyVbRqbm = value;
		}
	}

	public SearchOptionsChangedEventArgs(string searchPattern, bool matchCase, bool useRegex, bool wholeWords)
	{
		SearchPattern = searchPattern;
		MatchCase = matchCase;
		UseRegex = useRegex;
		WholeWords = wholeWords;
	}

	internal static bool GwAPDrFGu2fufLNrXZD8()
	{
		return l4ttDbFGLLpTYnIHPYfY == null;
	}
}
