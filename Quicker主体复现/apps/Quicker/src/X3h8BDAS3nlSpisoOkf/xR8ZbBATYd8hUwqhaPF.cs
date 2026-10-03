using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using log4net;
using Microsoft.WindowsAPICodePack.Shell;
using Quicker.Modules.Shell;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;

namespace X3h8BDAS3nlSpisoOkf;

internal class xR8ZbBATYd8hUwqhaPF
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<string, bool> VmvvYyI5us3;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xVcvYRYgnYh;

		public static Predicate<string> gEdvYqPdFSc;

		public static Func<string, string> KLpvYcgqW2O;

		public static Func<string, string> nnavYVxqc8G;

		internal static _003C_003Ec HsVaYIciT49JRtG7wFKa;

		static _003C_003Ec()
		{
			xVcvYRYgnYh = new _003C_003Ec();
		}

		internal bool e8qvY8yukp0(string x)
		{
			return x == Environment.SystemDirectory.ToLower();
		}

		internal string gB3vYaJyw5O(string x)
		{
			return x.ToLower();
		}

		internal string gSivY75abm4(string x)
		{
			return Environment.ExpandEnvironmentVariables(x).ToLower();
		}

		internal static bool Su2g6scimRW81e2uPOmy()
		{
			return HsVaYIciT49JRtG7wFKa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public ConcurrentBag<AppInfo> VuFvY90RkDI;

		public Action<string> OfGvYhTl4CK;

		internal static _003C_003Ec__DisplayClass10_0 Iw47Ooci48k65ivaNeGB;

		internal void RwEvYZW0NFE(string lnkFile)
		{
			try
			{
				AppInfo appInfo = new AppInfo
				{
					Name = Path.GetFileNameWithoutExtension(lnkFile),
					FilePath = lnkFile,
					AppType = WindowsAppType.Shortcut,
					Icon = null,
					TargetParsingPath = "",
					TargetArguments = "",
					PackageInstallPath = ""
				};
				string lnkFileDisplayName = NativeMethods.GetLnkFileDisplayName(lnkFile);
				if (!string.IsNullOrEmpty(lnkFileDisplayName))
				{
					appInfo.Name = lnkFileDisplayName;
				}
				VuFvY90RkDI.Add(appInfo);
			}
			catch (Exception ex)
			{
				kD6iQTgJVy.Warn("获取快捷方式信息失败：" + lnkFile + " " + ex.Message, ex);
			}
		}

		internal static bool F6uMiQcihv95GxQ4yo6G()
		{
			return Iw47Ooci48k65ivaNeGB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public IKnownFolder QpWvYYBtbyb;

		public string aLSvYIZW565;

		internal static _003C_003Ec__DisplayClass1_0 FPxGw0cizqP4SbcBZ95h;

		internal bool SVmvYehKZYa(AppInfo x)
		{
			if (x.Name == aLSvYIZW565)
			{
				return x.FilePath == QpWvYYBtbyb.ParsingName;
			}
			return false;
		}

		internal static bool tsXdOEclVt5JVh2IMxxn()
		{
			return FPxGw0cizqP4SbcBZ95h == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public ConcurrentBag<AppInfo> sH4vYkAKF5H;

		internal static _003C_003Ec__DisplayClass7_0 D3eXvSclF8nqraLYpR0m;

		internal void uxWvYW0nkQX(string path)
		{
			kZIi6MtrFa(path, sH4vYkAKF5H, 0, null, -150);
		}

		internal static bool VSty0fclcNEh3nylScv1()
		{
			return D3eXvSclF8nqraLYpR0m == null;
		}
	}

	public static string[] z8liBAPyE3;

	private static readonly ILog kD6iQTgJVy;

	private static xR8ZbBATYd8hUwqhaPF C4kpa1QQXiul5G4fHtRv;

	[HandleProcessCorruptedStateExceptions]
	[SecurityCritical]
	public static IList<AppInfo> jkaiH66qNp(bool bool_0, IList<string> ilist_0, bool bool_1, bool bool_2)
	{
		ConcurrentBag<AppInfo> concurrentBag = new ConcurrentBag<AppInfo>();
		Stopwatch stopwatch = Stopwatch.StartNew();
		StringBuilder stringBuilder = new StringBuilder(1024);
		bool flag;
		if (flag = NativeMethods.IsOnWindows10OrLater())
		{
			using IKnownFolder knownFolder = KnownFolderHelper.FromKnownFolderId(new Guid("{1e87508d-89c2-42f0-8a7e-645a0f50ca58}"));
			foreach (ShellObject item in knownFolder)
			{
				try
				{
					concurrentBag.Add(new AppInfo
					{
						Name = item.Name,
						AppUserModelID = item.ParsingName,
						FilePath = "shell:appsFolder\\" + item.ParsingName,
						AppType = WindowsAppType.AppsFolderApp,
						Icon = (bool_0 ? item.Thumbnail.MediumBitmapSource : null),
						TargetParsingPath = item.Properties.System.Link.TargetParsingPath?.Value,
						TargetArguments = item.Properties.System.Link.Arguments?.Value
					});
					item.Dispose();
				}
				catch (Exception ex)
				{
					kD6iQTgJVy.Warn("获取程序快捷方式(" + item.ParsingName + ")信息出错：" + ex.Message, ex);
				}
			}
			stringBuilder.AppendLine($"AppsFolder：{stopwatch.ElapsedMilliseconds}ms");
			stopwatch.Restart();
		}
		if (!flag || concurrentBag.Count == 0)
		{
			ETHirJYgpR(concurrentBag);
			stringBuilder.AppendLine($"StartMenu：{stopwatch.ElapsedMilliseconds}ms");
			stopwatch.Restart();
		}
		try
		{
			muEi1WQpE9(bool_0, concurrentBag);
			stringBuilder.AppendLine($"KnownFolders：{stopwatch.ElapsedMilliseconds}ms");
			stopwatch.Restart();
		}
		catch (Exception ex2)
		{
			kD6iQTgJVy.Warn("获取系统KnownFolders路径出错：" + ex2.Message, ex2);
		}
		if (bool_2 || bool_1)
		{
			OZMimSmygv(bool_2, bool_1, concurrentBag);
			stringBuilder.AppendLine($"系统程序：{stopwatch.ElapsedMilliseconds}ms");
			stopwatch.Restart();
		}
		if (ilist_0.HasData())
		{
			TxbiK1ScfN(ilist_0, concurrentBag);
			stringBuilder.AppendLine($"自定义目录：{stopwatch.ElapsedMilliseconds}ms");
			stopwatch.Restart();
		}
		stringBuilder.Length -= 2;
		kD6iQTgJVy.Info(stringBuilder.ToString());
		return concurrentBag.ToList();
	}

	[HandleProcessCorruptedStateExceptions]
	[SecurityCritical]
	private static void muEi1WQpE9(bool bool_0, ConcurrentBag<AppInfo> concurrentBag_0)
	{
		ICollection<IKnownFolder> all = Microsoft.WindowsAPICodePack.Shell.KnownFolders.All;
		Guid guid = Guid.Parse("190337d1-b8ca-4121-a639-6d472d16972a");
		using (IEnumerator<IKnownFolder> enumerator = all.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				_003C_003Ec__DisplayClass1_.QpWvYYBtbyb = enumerator.Current;
				if (_003C_003Ec__DisplayClass1_.QpWvYYBtbyb.FolderId == guid)
				{
					continue;
				}
				_003C_003Ec__DisplayClass1_.aLSvYIZW565 = _003C_003Ec__DisplayClass1_.QpWvYYBtbyb.LocalizedName;
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass1_.aLSvYIZW565))
				{
					_003C_003Ec__DisplayClass1_.aLSvYIZW565 = (_003C_003Ec__DisplayClass1_.QpWvYYBtbyb as ShellObject)?.Name;
				}
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass1_.aLSvYIZW565))
				{
					string parsingName = _003C_003Ec__DisplayClass1_.QpWvYYBtbyb.ParsingName;
					if (!concurrentBag_0.Any(_003C_003Ec__DisplayClass1_.SVmvYehKZYa))
					{
						concurrentBag_0.Add(new AppInfo
						{
							AppType = WindowsAppType.KnownFolder,
							Name = _003C_003Ec__DisplayClass1_.aLSvYIZW565,
							FilePath = parsingName,
							Icon = (bool_0 ? ((ShellObject)_003C_003Ec__DisplayClass1_.QpWvYYBtbyb).Thumbnail.SmallBitmapSource : null),
							TargetParsingPath = parsingName,
							TargetArguments = "",
							PackageInstallPath = "",
							Description = _003C_003Ec__DisplayClass1_.aLSvYIZW565
						});
					}
				}
			}
		}
		foreach (IKnownFolder item in all)
		{
			item.Dispose();
		}
	}

	private static IList<AppInfo> Vs0ibZZC6O(bool bool_0)
	{
		IList<AppInfo> list = new List<AppInfo>();
		foreach (ShellObject item in Microsoft.WindowsAPICodePack.Shell.KnownFolders.ControlPanel)
		{
			try
			{
				bool flag = item.Name == "字体";
				list.Add(new AppInfo
				{
					Name = item.Name,
					AppUserModelID = item.ParsingName,
					FilePath = (item.ParsingName ?? ""),
					AppType = WindowsAppType.ControlPanel,
					Icon = (bool_0 ? item.Thumbnail.MediumBitmapSource : null)
				});
				item.Dispose();
			}
			catch (Exception ex)
			{
				kD6iQTgJVy.Warn("获取程序快捷方式(" + item.ParsingName + ")信息出错：" + ex.Message, ex);
			}
		}
		return list;
	}

	private static bool kZIi6MtrFa(string string_1, ConcurrentBag<AppInfo> concurrentBag_0, int int_0, IDictionary<string, string> idictionary_0, int int_1)
	{
		if (!Directory.Exists(string_1))
		{
			kD6iQTgJVy.Warn("程序搜索，文件夹不存在：" + string_1);
			return false;
		}
		try
		{
			foreach (string item in Directory.EnumerateFiles(string_1, "*.*", SearchOption.TopDirectoryOnly))
			{
				bool flag = false;
				for (int i = 0; i < z8liBAPyE3.Length; i++)
				{
					if (item.EndsWith(z8liBAPyE3[i], StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				try
				{
					FileInfo fileInfo = new FileInfo(item);
					AppInfo appInfo = new AppInfo
					{
						Name = fileInfo.Name,
						FilePath = fileInfo.FullName,
						AppType = WindowsAppType.Executable,
						Icon = null,
						TargetParsingPath = fileInfo.FullName,
						TargetArguments = "",
						PackageInstallPath = "",
						ScoreDelta = int_1
					};
					try
					{
						if (idictionary_0 != null && idictionary_0.ContainsKey(fileInfo.Name))
						{
							appInfo.Name = idictionary_0[fileInfo.Name];
						}
						else
						{
							FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(item);
							if (!string.IsNullOrEmpty(versionInfo.FileDescription))
							{
								appInfo.Name = xRgiX1V6T6(appInfo.Name, versionInfo.FileDescription);
							}
						}
					}
					catch (Exception ex)
					{
						kD6iQTgJVy.Warn("无法获取文件信息：" + item + " " + ex.Message, ex);
					}
					concurrentBag_0.Add(appInfo);
				}
				catch (Exception ex2)
				{
					kD6iQTgJVy.Warn("无法索引文件：" + item + " " + ex2.Message, ex2);
				}
			}
			if (int_0 > 0)
			{
				string[] directories = Directory.GetDirectories(string_1, "*", SearchOption.TopDirectoryOnly);
				for (int j = 0; j < directories.Length; j++)
				{
					kZIi6MtrFa(directories[j], concurrentBag_0, int_0 - 1, null, int_1 - 10);
				}
			}
		}
		catch (Exception ex3)
		{
			kD6iQTgJVy.Warn("无法索引文件夹：" + string_1 + " " + ex3.Message, ex3);
		}
		return true;
	}

	private static string xRgiX1V6T6(string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			return string_1;
		}
		if (string_2.IndexOf(Path.GetFileNameWithoutExtension(string_1), StringComparison.OrdinalIgnoreCase) >= 0)
		{
			return string_2;
		}
		return string_1 + ": " + string_2.ToShortString(50);
	}

	private static void OZMimSmygv(bool bool_0, bool bool_1, ConcurrentBag<AppInfo> concurrentBag_0)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.sH4vYkAKF5H = concurrentBag_0;
		IDictionary<string, string> idictionary_ = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{ "certlm.msc", "计算机证书管理" },
			{ "certmgr.msc", "用户证书管理" },
			{ "comexp.msc", "组件服务" },
			{ "compmgmt.msc", "计算机管理" },
			{ "cttune.exe", "ClearType 文本调谐器" },
			{ "dccw.exe", "显示颜色校准" },
			{ "DevicePairingWizard.exe", "添加设备" },
			{ "devmgmt.msc", "设备管理器" },
			{ "dfrgui.exe", "优化驱动器" },
			{ "diskmgmt.msc", "磁盘管理" },
			{ "eventvwr.msc", "事件查看器" },
			{ "fsmgmt.msc", "共享文件夹" },
			{ "gpedit.msc", "本地组策略编辑器" },
			{ "iscsicpl.exe", "创建iSCSI Initiator" },
			{ "lusrmgr.msc", "本地用户和组管理器" },
			{ "mblctr.exe", "Windows移动中心" },
			{ "netplwiz.exe", "用户账户" },
			{ "OptionalFeatures.exe", "启用或关闭 Windows 功能" },
			{ "perfmon.exe", "性能监视器" },
			{ "perfmon.msc", "性能监视器" },
			{ "presentationsettings.exe", "演示设置" },
			{ "printmanagement.msc", "打印管理" },
			{ "rekeywiz.exe", "管理文件加密证书" },
			{ "secpol.msc", "本地安全策略" },
			{ "services.msc", "服务" },
			{ "sndvol.exe", "音量合成器" },
			{ "SystemPropertiesAdvanced.exe", "系统属性(高级)" },
			{ "SystemPropertiesComputerName.exe", "计算机名" },
			{ "SystemPropertiesPerformance.exe", "性能选项" },
			{ "SystemPropertiesProtection.exe", "系统保护" },
			{ "SystemPropertiesRemote.exe", "远程设置" },
			{ "taskschd.msc", "任务计划程序" },
			{ "tpm.msc", "受信任的平台模块(TPM)管理" },
			{ "UserAccountControlSettings.exe", "用户账户控制设置(UAC)" },
			{ "virtmgmt.msc", "Hyper-V 管理器" },
			{ "WF.msc", "高级安全 Windows Defender 防火墙" },
			{ "wfs.exe", "Windows传真和扫描\t工具程序" }
		};
		if (bool_0)
		{
			kZIi6MtrFa(Environment.SystemDirectory.ToLower(), _003C_003Ec__DisplayClass7_.sH4vYkAKF5H, 0, idictionary_, -100);
		}
		List<string> list = new List<string>();
		if (bool_0)
		{
			list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Windows).ToLower());
		}
		if (bool_1)
		{
			list.AddRange(FCNipayXVY());
		}
		if (list.Contains(Environment.SystemDirectory.ToLower()))
		{
			list.RemoveAll(_003C_003Ec.gEdvYqPdFSc ?? (_003C_003Ec.gEdvYqPdFSc = _003C_003Ec.xVcvYRYgnYh.e8qvY8yukp0));
		}
		list.Select(_003C_003Ec.KLpvYcgqW2O ?? (_003C_003Ec.KLpvYcgqW2O = _003C_003Ec.xVcvYRYgnYh.gB3vYaJyw5O)).Distinct().Where(_003C_003EO.VmvvYyI5us3 ?? (_003C_003EO.VmvvYyI5us3 = Directory.Exists))
			.AsParallel()
			.ForAll(_003C_003Ec__DisplayClass7_.uxWvYW0nkQX);
	}

	private static void TxbiK1ScfN(IList<string> ilist_0, ConcurrentBag<AppInfo> concurrentBag_0)
	{
		foreach (string item in ilist_0)
		{
			var (text, num) = p70ixwBlhq(item);
			if (!string.IsNullOrEmpty(text))
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				if (kZIi6MtrFa(text, concurrentBag_0, num, null, -30))
				{
					kD6iQTgJVy.Info($"索引文件夹{text} 深度:{num} 耗时：{stopwatch.ElapsedMilliseconds}ms");
				}
			}
		}
	}

	internal static (string path, int depth) p70ixwBlhq(string string_1)
	{
		string_1 = string_1.Trim();
		if (string.IsNullOrEmpty(string_1))
		{
			return (path: "", depth: 0);
		}
		int item = 0;
		int num = string_1.LastIndexOf('|');
		string text = string_1;
		if (num > 0)
		{
			text = string_1.Substring(0, num);
			item = Convert.ToInt32(string_1.Substring(num + 1).Trim());
		}
		if (text.Contains("%"))
		{
			text = Environment.ExpandEnvironmentVariables(text);
		}
		return (path: text, depth: item);
	}

	private static void ETHirJYgpR(ConcurrentBag<AppInfo> concurrentBag_0)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.VuFvY90RkDI = concurrentBag_0;
		foreach (string item in new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Programs),
			Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms)
		})
		{
			try
			{
				Directory.EnumerateFiles(item, "*.lnk", SearchOption.AllDirectories).AsParallel().ForAll(_003C_003Ec__DisplayClass10_.OfGvYhTl4CK ?? (_003C_003Ec__DisplayClass10_.OfGvYhTl4CK = _003C_003Ec__DisplayClass10_.RwEvYZW0NFE));
			}
			catch (Exception ex)
			{
				kD6iQTgJVy.Warn("枚举开始菜单出错：" + ex.Message, ex);
			}
		}
	}

	private static IList<string> FCNipayXVY()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("PATH");
		if (environmentVariable != null)
		{
			return environmentVariable.Split(Path.PathSeparator).Select(_003C_003Ec.nnavYVxqc8G ?? (_003C_003Ec.nnavYVxqc8G = _003C_003Ec.xVcvYRYgnYh.gSivY75abm4)).ToList();
		}
		return Array.Empty<string>();
	}

	static xR8ZbBATYd8hUwqhaPF()
	{
		z8liBAPyE3 = new string[8] { ".exe", ".lnk", ".cmd", ".cpl", ".bat", ".com", ".ps1", ".msc" };
		kD6iQTgJVy = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool j58hitQQ2NbXg4q5yQDk()
	{
		return C4kpa1QQXiul5G4fHtRv == null;
	}

	internal static void mLcpDQQQnoVvukt455sn()
	{
	}
}
