using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Quicker.Utilities.Ext;

namespace Quicker.Utilities;

public static class BrowserExtensionHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public bool v6SSzxJ7e1O;

		private static _003C_003Ec__DisplayClass9_0 WIoVrtyn2UvYPiGaTbld;

		internal void blLSzKmGfIa()
		{
			D7KLoRONXix.Info("更新浏览器NativeMessageHost插件...");
			try
			{
				_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_1_ = default(_003C_003Ec__DisplayClass9_1);
				_003C_003Ec__DisplayClass9_1_.tkDSzr2avlX = Path.GetDirectoryName(AppHelper.GetAppExePath());
				_003C_003Ec__DisplayClass9_1_.j8ySzpgjjEQ = AppHelper.GetUserDataDir("bin\\\\NativeMessageHost");
				Process[] processesByName = Process.GetProcessesByName("chromeagent");
				int num = 0;
				int num3 = default(int);
				while (true)
				{
					if (num >= processesByName.Length)
					{
						int num2 = 1;
						if (!IVSxYDynAswY3Hjaw5II())
						{
							num2 = num3;
						}
						switch (num2)
						{
						case 1:
						{
							Thread.Sleep(500);
							Gi9Lo86IuNQ("ChromeAgent.exe", ref _003C_003Ec__DisplayClass9_1_);
							Gi9Lo86IuNQ("ChromeAgent.exe.config", ref _003C_003Ec__DisplayClass9_1_);
							Gi9Lo86IuNQ("NamedPipeWrapper.dll", ref _003C_003Ec__DisplayClass9_1_);
							Gi9Lo86IuNQ("Newtonsoft.Json.dll", ref _003C_003Ec__DisplayClass9_1_);
							Gi9Lo86IuNQ("ChromeAgent.log4net.config", ref _003C_003Ec__DisplayClass9_1_);
							Gi9Lo86IuNQ("log4net.dll", ref _003C_003Ec__DisplayClass9_1_);
							string text = Process.Start(new ProcessStartInfo(Path.Combine(_003C_003Ec__DisplayClass9_1_.j8ySzpgjjEQ, "chromeagent.exe"), "--register")
							{
								UseShellExecute = false,
								RedirectStandardOutput = true,
								RedirectStandardError = true,
								CreateNoWindow = true
							}).StandardOutput.ReadToEnd();
							if (v6SSzxJ7e1O || !text.Contains("Registered"))
							{
								MessageBoxHelper.Show(text, "注册Quicker浏览器消息代理");
							}
							return;
						}
						}
					}
					processesByName[num].Kill();
					num++;
				}
			}
			catch (Exception exception)
			{
				string message = "安装浏览器NativeMessage模块出错。" + exception.GetMessageWithInner();
				D7KLoRONXix.Error(message, exception);
				AppHelper.ShowWarning(message);
			}
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}

		internal static bool IVSxYDynAswY3Hjaw5II()
		{
			return WIoVrtyn2UvYPiGaTbld == null;
		}

		internal static void C5It9XynDkfGl66XAvID()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass9_1
	{
		public string tkDSzr2avlX;

		public string j8ySzpgjjEQ;
	}

	[CompilerGenerated]
	private static readonly BrowserExtensionInfo cwsLoaHcDut;

	[CompilerGenerated]
	private static readonly BrowserExtensionInfo nwULo7Hhb2u;

	private static readonly ILog D7KLoRONXix;

	internal static object StQ6VcF51GMsGv3hrAOn;

	public static BrowserExtensionInfo ChromeInfo
	{
		[CompilerGenerated]
		get
		{
			return cwsLoaHcDut;
		}
	}

	public static BrowserExtensionInfo EdgeInfo
	{
		[CompilerGenerated]
		get
		{
			return nwULo7Hhb2u;
		}
	}

	public static void InstallChromeMessageHost(bool showMessage = false)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.v6SSzxJ7e1O = showMessage;
		Task.Run((Action)_003C_003Ec__DisplayClass9_.blLSzKmGfIa);
	}

	static BrowserExtensionHelper()
	{
		cwsLoaHcDut = new BrowserExtensionInfo
		{
			Browser = "chrome",
			Description = "谷歌Chrome",
			ExtId = "klggbkjfmbonefdcfkiidhcmfjdfnepa",
			RegKey32 = "Software\\Google\\Chrome\\Extensions\\",
			RegKey64 = "Software\\Wow6432Node\\Google\\Chrome\\Extensions\\",
			Path = "%USERPROFILE%\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Extensions\\",
			UpdateUrl = "https://clients2.google.com/service/update2/crx"
		};
		nwULo7Hhb2u = new BrowserExtensionInfo
		{
			Browser = "msedge",
			ExtId = "hcnknmobjnlekfkbcllhcoldbppkgpda",
			Description = "微软Edge",
			RegKey32 = "Software\\Microsoft\\Edge\\Extensions\\",
			RegKey64 = "Software\\Wow6432Node\\Microsoft\\Edge\\Extensions\\",
			Path = "%USERPROFILE%\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Extensions\\",
			UpdateUrl = "https://edge.microsoft.com/extensionwebstorebase/v1/crx"
		};
		D7KLoRONXix = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static void Gi9Lo86IuNQ(string string_0, ref _003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_1_0)
	{
		File.Copy(Path.Combine(_003C_003Ec__DisplayClass9_1_0.tkDSzr2avlX, string_0), Path.Combine(_003C_003Ec__DisplayClass9_1_0.j8ySzpgjjEQ, string_0), true);
	}

	internal static bool YtblkuF5KBubO9WFXgZT()
	{
		return StQ6VcF51GMsGv3hrAOn == null;
	}
}
