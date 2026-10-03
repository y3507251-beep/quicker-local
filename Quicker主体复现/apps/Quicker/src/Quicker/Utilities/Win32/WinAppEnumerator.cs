using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Entities;

namespace Quicker.Utilities.Win32;

public static class WinAppEnumerator
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public IList<WinAppItem> hdk2Soo0U0N;

		private static _003C_003Ec__DisplayClass4_0 bbDHVnyET7IOJ9Ic1XQm;

		internal static bool LVACsPyEmi75P0jn5KE0()
		{
			return bbDHVnyET7IOJ9Ic1XQm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_1
	{
		public string xNg2SMNqA0A;

		public _003C_003Ec__DisplayClass4_0 LhF2SAAcv6K;

		private static _003C_003Ec__DisplayClass4_1 CNppcLyECfMtxycdrt5V;

		internal WinAppItem aQt2ST7Gkvb(string file)
		{
			_003C_003Ec__DisplayClass4_2 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_2
			{
				tQF2SUoeJ3t = file
			};
			if (LhF2SAAcv6K.hdk2Soo0U0N != null && LhF2SAAcv6K.hdk2Soo0U0N.Any(_003C_003Ec__DisplayClass4_.YTF2SOyfdga))
			{
				return LhF2SAAcv6K.hdk2Soo0U0N.First(_003C_003Ec__DisplayClass4_.UU52SFcw6kZ);
			}
			string text = _003C_003Ec__DisplayClass4_.tQF2SUoeJ3t.ToUpperInvariant();
			if (!text.Contains("卸载") && !text.Contains("UNINSTALL"))
			{
				string text2 = NativeMethods.GetLnkFileDisplayName(_003C_003Ec__DisplayClass4_.tQF2SUoeJ3t);
				if (text2 == _003C_003Ec__DisplayClass4_.tQF2SUoeJ3t || string.IsNullOrEmpty(text2))
				{
					text2 = Path.GetFileNameWithoutExtension(_003C_003Ec__DisplayClass4_.tQF2SUoeJ3t);
					int num = 0;
					if (!xLSdm6yE7Iq7CmE7SARh())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				return new WinAppItem
				{
					FullPath = _003C_003Ec__DisplayClass4_.tQF2SUoeJ3t,
					ShortPath = _003C_003Ec__DisplayClass4_.tQF2SUoeJ3t.Substring(xNg2SMNqA0A.Length),
					DisplayName = text2,
					Name = Path.GetFileNameWithoutExtension(_003C_003Ec__DisplayClass4_.tQF2SUoeJ3t)
				};
			}
			return null;
		}

		internal static bool xLSdm6yE7Iq7CmE7SARh()
		{
			return CNppcLyECfMtxycdrt5V == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_2
	{
		public string tQF2SUoeJ3t;

		private static _003C_003Ec__DisplayClass4_2 Y8ZEXTyEHZiVQqwvaPMw;

		internal bool YTF2SOyfdga(WinAppItem x)
		{
			return x.FullPath == tQF2SUoeJ3t;
		}

		internal bool UU52SFcw6kZ(WinAppItem x)
		{
			return x.FullPath == tQF2SUoeJ3t;
		}

		internal static bool SOfUoCyEzFnnkd8yvHCq()
		{
			return Y8ZEXTyEHZiVQqwvaPMw == null;
		}
	}

	[CompilerGenerated]
	private static IList<WinAppItem> XJSLFIptMF4;

	[SpecialName]
	[CompilerGenerated]
	private static void XyfLFeOHvOp(IList<WinAppItem> value)
	{
		XJSLFIptMF4 = value;
	}

	public static IList<WinAppItem> GetLnkFileItems(IList<WinAppItem> oldItems)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.hdk2Soo0U0N = oldItems;
		string[] obj = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\Programs",
			Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\Programs"
		};
		IList<WinAppItem> list = new List<WinAppItem>();
		string[] array = obj;
		for (int i = 0; i < array.Length; i++)
		{
			_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_1();
			_003C_003Ec__DisplayClass4_2.LhF2SAAcv6K = _003C_003Ec__DisplayClass4_;
			_003C_003Ec__DisplayClass4_2.xNg2SMNqA0A = array[i];
			new Stopwatch().Start();
			try
			{
				foreach (WinAppItem item in Directory.GetFiles(_003C_003Ec__DisplayClass4_2.xNg2SMNqA0A, "*.lnk", SearchOption.AllDirectories).AsParallel().Select(_003C_003Ec__DisplayClass4_2.aQt2ST7Gkvb))
				{
					if (item != null)
					{
						list.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("读取开始菜单出错：" + ex.Message);
			}
		}
		try
		{
			foreach (UWPHelper2.AppModuleItem appModuel in UWPHelper2.GetAppModuels())
			{
				list.Add(new WinAppItem
				{
					DisplayName = appModuel.Name,
					FullPath = "StoreApp:" + appModuel.ApplicationUserModelId,
					Name = appModuel.Name,
					ShortPath = "[Windows商店应用]"
				});
			}
		}
		catch (Exception)
		{
		}
		return list;
	}
}
