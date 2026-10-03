using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Utilities.Hooks;
using rWLkMnX3Bc6H4OlaITp;

namespace K9HvgYjZL3faEPQWoqU;

internal class ObkG8JjRVxQq4TEiAhL
{
	[CompilerGenerated]
	private static OjxmG1XsQxaJxHk41nk uCxtkOVOkna;

	internal static IList<OjxmG1XsQxaJxHk41nk> t6vtkFtBHU8;

	private static object cHTtkUwYXMv;

	private static ObkG8JjRVxQq4TEiAhL MpOvbcQkJPWMK7ZfxAZf;

	[SpecialName]
	[CompilerGenerated]
	internal static void VuxtkME2xkN(OjxmG1XsQxaJxHk41nk ojxmG1XsQxaJxHk41nk_1)
	{
		uCxtkOVOkna = ojxmG1XsQxaJxHk41nk_1;
	}

	public static void rdOtk5sdP6o(OjxmG1XsQxaJxHk41nk ojxmG1XsQxaJxHk41nk_1)
	{
		lock (cHTtkUwYXMv)
		{
			t6vtkFtBHU8.Insert(0, ojxmG1XsQxaJxHk41nk_1);
		}
	}

	public static bool FjltkDTmR89(HookKeyEventArgs hookKeyEventArgs_0)
	{
		lock (cHTtkUwYXMv)
		{
			OjxmG1XsQxaJxHk41nk ojxmG1XsQxaJxHk41nk = null;
			bool bool_ = false;
			foreach (OjxmG1XsQxaJxHk41nk item in t6vtkFtBHU8)
			{
				if (item.DYOg9hf59KT(hookKeyEventArgs_0, out bool_))
				{
					ojxmG1XsQxaJxHk41nk = item;
					break;
				}
			}
			if (ojxmG1XsQxaJxHk41nk != null)
			{
				if (bool_)
				{
					fcEtkdSunDE(ojxmG1XsQxaJxHk41nk);
					if (KW5AnkQkktVsBBDlURPb())
					{
						switch (0)
						{
						}
					}
				}
				return true;
			}
		}
		return false;
	}

	public static void fcEtkdSunDE(OjxmG1XsQxaJxHk41nk ojxmG1XsQxaJxHk41nk_1)
	{
		lock (cHTtkUwYXMv)
		{
			if (t6vtkFtBHU8.Contains(ojxmG1XsQxaJxHk41nk_1))
			{
				t6vtkFtBHU8.Remove(ojxmG1XsQxaJxHk41nk_1);
			}
		}
	}

	internal static bool uWqtkoPnKgl(HookKeyEventArgs hookKeyEventArgs_0)
	{
		lock (cHTtkUwYXMv)
		{
			OjxmG1XsQxaJxHk41nk ojxmG1XsQxaJxHk41nk = null;
			foreach (OjxmG1XsQxaJxHk41nk item in t6vtkFtBHU8)
			{
				if (item.Uyhg9eMqVRU(hookKeyEventArgs_0))
				{
					ojxmG1XsQxaJxHk41nk = item;
					break;
				}
			}
			if (ojxmG1XsQxaJxHk41nk != null)
			{
				fcEtkdSunDE(ojxmG1XsQxaJxHk41nk);
				return true;
			}
		}
		return false;
	}

	static ObkG8JjRVxQq4TEiAhL()
	{
		t6vtkFtBHU8 = new List<OjxmG1XsQxaJxHk41nk>();
		cHTtkUwYXMv = new object();
	}

	internal static bool KW5AnkQkktVsBBDlURPb()
	{
		return MpOvbcQkJPWMK7ZfxAZf == null;
	}
}
