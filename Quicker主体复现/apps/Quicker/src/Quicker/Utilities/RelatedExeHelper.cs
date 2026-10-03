using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities;

public static class RelatedExeHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public string JlfSzWUJrVZ;

		public Func<string, bool> BrISzk9Q2TM;

		private static _003C_003Ec__DisplayClass1_0 SFn9E7yAhlEI7aNKWQOg;

		internal bool wAHSzIT3y0U(string x)
		{
			return !string.Equals(JlfSzWUJrVZ, x, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool o6Ve1MyAH5SwAmrR9a5i()
		{
			return SFn9E7yAhlEI7aNKWQOg == null;
		}
	}

	private static IList<string[]> s6vLdNqOCxD;

	internal static object pWGd4yFZ8FsQFSwTZnSZ;

	public static IList<string> GetRelatedExes(string exe, bool onlyOthers = false)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.JlfSzWUJrVZ = exe;
		foreach (string[] item in s6vLdNqOCxD)
		{
			string[] array = item;
			for (int i = 0; i < array.Length; i++)
			{
				if (string.Equals(array[i], _003C_003Ec__DisplayClass1_.JlfSzWUJrVZ, StringComparison.OrdinalIgnoreCase))
				{
					if (!onlyOthers)
					{
						return item;
					}
					return item.Where(_003C_003Ec__DisplayClass1_.BrISzk9Q2TM ?? (_003C_003Ec__DisplayClass1_.BrISzk9Q2TM = _003C_003Ec__DisplayClass1_.wAHSzIT3y0U)).ToList();
				}
			}
		}
		return null;
	}

	static RelatedExeHelper()
	{
		s6vLdNqOCxD = new List<string[]>
		{
			new string[2] { "vmplayer.exe", "vmware-vmx.exe" },
			new string[2] { "steam.exe", "steamwebhelper.exe" },
			new string[2] { "xshell.exe", "xshellcore.exe" },
			new string[3] { "aliworkbench.exe", "aliapp.exe", "alirender.exe" },
			new string[3] { "wechat.exe", "wechatappex.exe", "wechatbrowser.exe" },
			new string[3] { "d5_view.exe", "d5_immerse.exe", "d5_launcher.exe" }
		};
	}

	internal static bool oy6ft2FZRyTCe7jyY3bX()
	{
		return pWGd4yFZ8FsQFSwTZnSZ == null;
	}
}
