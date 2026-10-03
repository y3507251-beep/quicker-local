using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using l9W6KWifMfNKrInJR4l;
using log4net;
using N3JZlujw68npkGqT5RD;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using Quicker.View;
using UIAutoHelper;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Domain;

public static class ActionHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BdvvXL2T2Ej;

		public static Func<string, string> jUUvXvtrPKK;

		public static Func<Process, bool> bGxvXSsMU4B;

		public static Func<Process, bool> u01vX2bDIfO;

		public static Func<string, string> OVGvXuKMWlC;

		public static Func<char, bool> cHPvXNgq3SV;

		internal static _003C_003Ec znx9wHcIPHX2mBS0bTYv;

		static _003C_003Ec()
		{
			BdvvXL2T2Ej = new _003C_003Ec();
		}

		internal string Mhov6fTBxNM(string x)
		{
			return x.Trim(' ', '"');
		}

		internal bool gviv6zSLaw1(Process x)
		{
			return !x.HasExited;
		}

		internal bool YnYvXwic44R(Process x)
		{
			if (x.MainWindowHandle == IntPtr.Zero)
			{
				return false;
			}
			NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(x.MainWindowHandle);
			if (windowRect.Left == windowRect.Right)
			{
				return false;
			}
			return true;
		}

		internal string agKvXtLVstx(string x)
		{
			string text = x.Trim();
			if (text.StartsWith("\"") && text.EndsWith("\""))
			{
				text = text.Substring(1, text.Length - 2);
			}
			return text;
		}

		internal bool sWlvXgy2mg2(char x)
		{
			return x == '"';
		}

		internal static bool EOrdSTcIMCx3lj1fgKBJ()
		{
			return znx9wHcIPHX2mBS0bTYv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public string url;

		internal static _003C_003Ec__DisplayClass6_0 t49kQlcIxNiE9CY9bbRJ;

		internal void ayJvXJH2rcx()
		{
			LocalBrowserWindow localBrowserWindow = new LocalBrowserWindow(url);
			localBrowserWindow.Show();
			localBrowserWindow.Activate();
		}

		internal static bool Geetu2cIIk03CD4ldofY()
		{
			return t49kQlcIxNiE9CY9bbRJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public string LrwvXCJBG2p;

		public bool? HV5vXPvXUbP;

		internal static _003C_003Ec__DisplayClass8_0 vNqGkxcIt3XQSpsYusYt;

		internal void iqxvX03rmgr()
		{
			ClipboardHelper.SetText(LrwvXCJBG2p, HV5vXPvXUbP);
		}

		internal static bool PtNMj0cIS9p1s8JxZVdF()
		{
			return vNqGkxcIt3XQSpsYusYt == null;
		}
	}

	private static readonly ILog UWgt81MpvwO;

	internal static object FVpXjSQEXy0ACIT00LBb;

	public static Process StartProcess(string fileName, string arguments, string windowStyleStr, string setWorkingDir, bool runas, bool waitExit, string alternativePaths, bool waitInputIdle = false, bool redirectOutput = false, string username = null, string password = null, bool activateWindowIfRunning = false, string activateWindowHotkey = null, string outputEncoding = "", string envVariables = "")
	{
		fileName = fileName.Trim();
		fileName = PathHelper.RemoveZeroWidthChar(fileName);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text = default(string);
		int num2 = default(int);
		int num4 = default(int);
		Process process = default(Process);
		Process process2 = default(Process);
		string value = default(string);
		string text4 = default(string);
		ProcessWindowStyle windowStyle = default(ProcessWindowStyle);
		int num6 = default(int);
		while (true)
		{
			int num;
			if (fileName != null && fileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
			{
				num = 10;
				if (FVpXjSQEXy0ACIT00LBb != null)
				{
					goto IL_00b3;
				}
				goto IL_049b;
			}
			goto IL_0517;
			IL_06b7:
			if (string.IsNullOrEmpty(processStartInfo.WorkingDirectory) && File.Exists(fileName))
			{
				processStartInfo.WorkingDirectory = Path.GetDirectoryName(fileName);
			}
			if (redirectOutput)
			{
				if (!string.IsNullOrEmpty(outputEncoding))
				{
					Encoding encoding = Encoding.UTF8;
					if (!(outputEncoding == "oem"))
					{
						if (!(outputEncoding == "utf8"))
						{
							AppHelper.ShowWarning("不支持的编码格式，可能您使用的Quicker版本过旧：" + outputEncoding);
						}
						else
						{
							encoding = Encoding.UTF8;
						}
					}
					else
					{
						encoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
					}
					processStartInfo.StandardOutputEncoding = encoding;
					processStartInfo.StandardErrorEncoding = encoding;
				}
				processStartInfo.UseShellExecute = false;
				processStartInfo.RedirectStandardError = true;
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.CreateNoWindow = true;
			}
			else
			{
				processStartInfo.UseShellExecute = true;
			}
			if (!string.IsNullOrWhiteSpace(username))
			{
				processStartInfo.UserName = username;
				processStartInfo.PasswordInClearText = password;
				processStartInfo.UseShellExecute = false;
			}
			if (runas)
			{
				processStartInfo.Verb = "runas";
			}
			if (!string.IsNullOrEmpty(envVariables))
			{
				goto IL_07c3;
			}
			goto IL_0853;
			IL_0589:
			arguments = text.Substring(num2 + 1);
			goto IL_05c1;
			IL_0517:
			if (!Directory.Exists(fileName) || string.IsNullOrEmpty(AppState.HHxtaMaoqJr().CustomOpenFolderCommand))
			{
				if (!activateWindowIfRunning)
				{
					goto IL_00bc;
				}
				if (!File.Exists(fileName) && !string.IsNullOrEmpty(alternativePaths))
				{
					foreach (string item in alternativePaths.SplitToList().Select(_003C_003Ec.jUUvXvtrPKK ?? (_003C_003Ec.jUUvXvtrPKK = _003C_003Ec.BdvvXL2T2Ej.Mhov6fTBxNM)).ToList())
					{
						if (File.Exists(item))
						{
							fileName = item;
							break;
						}
					}
				}
				num = 7;
				if (FVpXjSQEXy0ACIT00LBb != null)
				{
					goto IL_00b3;
				}
			}
			else
			{
				num = 2;
				if (BNZooUQE25tleQxxTAe1())
				{
					goto IL_057c;
				}
			}
			goto IL_049b;
			IL_029c:
			try
			{
				string text2 = "";
				int num3 = 2;
				if (!BNZooUQE25tleQxxTAe1())
				{
					goto IL_03c4;
				}
				goto IL_03d7;
				IL_03c4:
				num3 = num4;
				goto IL_03d7;
				IL_03d7:
				while (true)
				{
					IntPtr foregroundWindow;
					switch (num3)
					{
					case 2:
						if (fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
						{
							num3 = 0;
							if (BNZooUQE25tleQxxTAe1())
							{
								continue;
							}
							break;
						}
						if (fileName.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase) && File.Exists(fileName))
						{
							text2 = Path.GetFileNameWithoutExtension(CheckFileExistsStep.GetLnkTarget(fileName).targetPath);
						}
						goto IL_0303;
					default:
						text2 = Path.GetFileNameWithoutExtension(fileName);
						goto IL_0303;
					case 1:
						{
							NativeMethods.BringProcessMainWindowToFront(process.MainWindowHandle);
							return null;
						}
						IL_0303:
						if (string.IsNullOrEmpty(text2))
						{
							goto end_IL_03d7;
						}
						foregroundWindow = NativeMethods.GetForegroundWindow();
						if (!(foregroundWindow != IntPtr.Zero) || !NativeMethods.IsWindowVisible(foregroundWindow) || !string.Equals(NativeMethods.GetWindowProcessName(foregroundWindow), text2, StringComparison.OrdinalIgnoreCase))
						{
							List<Process> list = Process.GetProcessesByName(text2).Where(_003C_003Ec.bGxvXSsMU4B ?? (_003C_003Ec.bGxvXSsMU4B = _003C_003Ec.BdvvXL2T2Ej.gviv6zSLaw1)).ToList();
							if (!list.HasData())
							{
								goto end_IL_03d7;
							}
							if (string.IsNullOrWhiteSpace(activateWindowHotkey))
							{
								process = list.FirstOrDefault(_003C_003Ec.u01vX2bDIfO ?? (_003C_003Ec.u01vX2bDIfO = _003C_003Ec.BdvvXL2T2Ej.YnYvXwic44R));
								if (process != null)
								{
									num3 = 1;
									if (FVpXjSQEXy0ACIT00LBb == null)
									{
										continue;
									}
									break;
								}
								foreach (Process item2 in list)
								{
									IntPtr intPtr = AutomationHelper.FindProcessWindow(item2.Id);
									if (intPtr != IntPtr.Zero)
									{
										NativeMethods.BringProcessMainWindowToFront(intPtr);
										return null;
									}
								}
								goto end_IL_03d7;
							}
							SendKeys.SendWait(activateWindowHotkey);
							return null;
						}
						CGet8Hmdsfk(text2);
						return null;
					}
					goto IL_03c4;
					continue;
					end_IL_03d7:
					break;
				}
			}
			catch (Exception message)
			{
				UWgt81MpvwO.Error(message);
			}
			goto IL_00bc;
			IL_01f2:
			List<string> list2 = alternativePaths.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.OVGvXuKMWlC ?? (_003C_003Ec.OVGvXuKMWlC = _003C_003Ec.BdvvXL2T2Ej.agKvXtLVstx)).ToList();
			if (list2.HasData())
			{
				foreach (string item3 in list2)
				{
					if (IsPathExists(item3))
					{
						fileName = item3;
						break;
					}
				}
			}
			goto IL_027b;
			IL_027b:
			text = fileName;
			if (string.IsNullOrEmpty(arguments) && !string.IsNullOrEmpty(text) && text.Contains(" ") && !text.StartsWith("quicker:") && !IsPathExists(text))
			{
				if (text.StartsWith("\"", StringComparison.Ordinal))
				{
					if (text.Count(_003C_003Ec.cHPvXNgq3SV ?? (_003C_003Ec.cHPvXNgq3SV = _003C_003Ec.BdvvXL2T2Ej.sWlvXgy2mg2)) >= 2)
					{
						num2 = text.IndexOf('"', 1);
						fileName = text.Substring(1, num2 - 1);
						if (text.Length > num2 + 1)
						{
							num = 9;
							if (BNZooUQE25tleQxxTAe1())
							{
								goto IL_049b;
							}
							goto IL_061e;
						}
					}
				}
				else
				{
					int num5 = text.IndexOf(' ');
					fileName = text.Substring(0, num5);
					arguments = text.Substring(num5);
				}
			}
			goto IL_05c1;
			IL_07c3:
			processStartInfo.UseShellExecute = false;
			string[] array = envVariables.SplitToList();
			foreach (string text3 in array)
			{
				if (!string.IsNullOrEmpty(text3) && !text3.Trim().StartsWith("//"))
				{
					string[] array2 = text3.Split(new char[1] { '=' }, 2);
					if (array2.Length != 2)
					{
						throw new InvalidOperationException("环境变量设置错误：" + text3);
					}
					processStartInfo.EnvironmentVariables[array2[0]] = array2[1];
				}
			}
			goto IL_0853;
			IL_0853:
			process2 = null;
			try
			{
				if (processStartInfo.UseShellExecute && !runas && NativeMethods.IsOnWindows11() && VGNt8sDRTy7(processStartInfo.FileName))
				{
					nVGFy1jAXcXA9v3fxMY.yQQtYes02yS(processStartInfo.FileName, processStartInfo.Arguments, processStartInfo.WorkingDirectory);
				}
				else
				{
					process2 = Process.Start(processStartInfo);
				}
			}
			catch (Exception ex)
			{
				UWgt81MpvwO.Warn("启动进程(" + fileName + ")出错，将尝试RunHelper方式。错误：" + ex.Message, ex);
				if (!string.IsNullOrWhiteSpace(value) || !string.IsNullOrEmpty(username))
				{
					throw;
				}
				if (!RunHelper.Run(text, out var pi))
				{
					throw;
				}
				process2 = Process.GetProcessById((int)pi.dwProcessId);
			}
			if (process2 != null)
			{
				num6 = 8;
				goto IL_0902;
			}
			if (!(waitInputIdle || waitExit))
			{
				break;
			}
			throw new InvalidOperationException("没有获得进程对象（可能不是exe程序），所以无法进行等待。");
			IL_00d8:
			if (arguments.Contains("%"))
			{
				arguments = Environment.ExpandEnvironmentVariables(arguments);
			}
			goto IL_00e8;
			IL_0647:
			if (!string.IsNullOrEmpty(text4))
			{
				if (Directory.Exists(text4))
				{
					num6 = 2;
					goto IL_0663;
				}
				processStartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			goto IL_06b7;
			IL_05c1:
			processStartInfo = new ProcessStartInfo(fileName, arguments)
			{
				WindowStyle = windowStyle
			};
			if (!string.IsNullOrEmpty(setWorkingDir))
			{
				text4 = "";
				if (!(setWorkingDir == "0") && !setWorkingDir.Equals("false", StringComparison.OrdinalIgnoreCase))
				{
					if (setWorkingDir == "1" || setWorkingDir == "true")
					{
						goto IL_061e;
					}
					text4 = setWorkingDir;
				}
				else
				{
					try
					{
						text4 = ytnqhyiMNhGmytDmEj7.GvXvtJLyniF(AppState.r4itaWBnyVQ().ForegroundWindowHwnd);
					}
					catch
					{
					}
				}
				goto IL_0647;
			}
			goto IL_06b7;
			IL_061e:
			if (File.Exists(fileName))
			{
				text4 = Path.GetDirectoryName(fileName);
			}
			goto IL_0647;
			IL_00b3:
			num = num6;
			goto IL_049b;
			IL_00bc:
			value = arguments;
			windowStyle = ProcessWindowStyle.Normal;
			if (!string.IsNullOrEmpty(windowStyleStr))
			{
				windowStyle = (ProcessWindowStyle)Convert.ToInt32(windowStyleStr, CultureInfo.InvariantCulture);
			}
			fileName = Environment.ExpandEnvironmentVariables(fileName);
			if (arguments != null)
			{
				goto IL_00d8;
			}
			goto IL_00e8;
			IL_0663:
			try
			{
				processStartInfo.WorkingDirectory = text4;
			}
			catch (Exception ex2)
			{
				AppHelper.ShowWarning("设置的工作目录(" + text4 + ")异常，" + ex2.Message + "。");
			}
			goto IL_06b7;
			IL_0902:
			if (waitInputIdle)
			{
				try
				{
					process2.WaitForInputIdle();
				}
				catch (Exception ex3)
				{
					throw new InvalidOperationException("等待启动完成出错，该进程可能不支持此操作。" + ex3.Message);
				}
			}
			if (waitExit)
			{
				process2.WaitForExit();
			}
			break;
			IL_00e8:
			if (!fileName.StartsWith("StoreApp:", StringComparison.OrdinalIgnoreCase))
			{
				if (!fileName.EndsWith("!App", StringComparison.OrdinalIgnoreCase) || fileName.Contains("shell:appsFolder"))
				{
					if (!IsPathExists(fileName) && !string.IsNullOrEmpty(alternativePaths))
					{
						num6 = 11;
						goto IL_01f2;
					}
					goto IL_027b;
				}
				UWPHelper2.LaunchApp(fileName, arguments);
				return null;
			}
			UWPHelper2.LaunchApp(fileName.Substring("StoreApp:".Length), arguments);
			num6 = 6;
			goto IL_0584;
			IL_049b:
			switch (num)
			{
			case 12:
				break;
			case 1:
				goto IL_00d8;
			case 11:
				goto IL_01f2;
			default:
				goto IL_027b;
			case 7:
				goto IL_029c;
			case 10:
				goto IL_04d9;
			case 3:
				goto IL_057c;
			case 6:
				goto IL_0584;
			case 9:
				goto IL_0589;
			case 4:
				goto IL_061e;
			case 2:
				goto IL_0663;
			case 5:
				goto IL_07c3;
			case 8:
				goto IL_0902;
			}
			continue;
			IL_04d9:
			if (NativeMethods.IsOnWindows11() && Path.IsPathRooted(fileName) && File.Exists(fileName))
			{
				return AppHelper.OpenTxtFile(fileName);
			}
			goto IL_0517;
			IL_0584:
			return null;
			IL_057c:
			AppHelper.OpenFolderWithCustomCommand(fileName);
			return null;
		}
		return process2;
	}

	private static bool VGNt8sDRTy7(string string_0)
	{
		try
		{
			string text = Path.GetFileName(string_0.Trim('"', ' ')).ToLower();
			return text == "notepad.exe" || text == "notepad";
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void CGet8Hmdsfk(string string_0)
	{
		int[] int_ = GetWindowInfoStep.GTqggaHUWCj(string_0);
		IList<IntPtr> list = new List<IntPtr>();
		foreach (KeyValuePair<IntPtr, string> openWindow in OpenWindowGetter.GetOpenWindows(true))
		{
			if (WindowHelper.HP9LFBj7trn(openWindow.Key, null, null, int_, false))
			{
				list.Add(openWindow.Key);
			}
		}
		IntPtr foregroundWindowHwnd = AppState.r4itaWBnyVQ().ForegroundWindowHwnd;
		if (list.Count > 0 && list.Last() != foregroundWindowHwnd)
		{
			NativeMethods.SetForegroundWindow(list.Last());
		}
	}

	public static bool IsPathExists(string path)
	{
		return path.IsPathExists();
	}

	public static IList<SelectionItem> GetWebBrowsers()
	{
		return new List<SelectionItem>
		{
			new SelectionItem("default", "(系统默认浏览器)"),
			new SelectionItem("iexplore.exe", "IE浏览器"),
			new SelectionItem("microsoft-edge:", "Edge"),
			new SelectionItem("msedgeApp", "Edge App模式"),
			new SelectionItem("msedgeIncognito", "Edge InPrivate窗口"),
			new SelectionItem("chrome", "Chrome"),
			new SelectionItem("chromeApp", "Chrome App模式"),
			new SelectionItem("chromeIncognito", "Chrome 无痕窗口"),
			new SelectionItem("local", "本地浏览器窗口"),
			new SelectionItem("custom", "*自定义浏览器程序*"),
			new SelectionItem("current", "*前台浏览器程序*")
		};
	}

	public static void OpenUrl(string url, string browserType, string customBrowerExePath)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.url = url;
		_003C_003Ec__DisplayClass6_.url = _003C_003Ec__DisplayClass6_.url?.Trim();
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass6_.url))
		{
			AppHelper.ShowWarning("要打开的网址为空。");
			return;
		}
		_003C_003Ec__DisplayClass6_.url = AppHelper.PathToUri(_003C_003Ec__DisplayClass6_.url);
		bool flag = default(bool);
		int num;
		if (!string.IsNullOrEmpty(browserType) && !browserType.Equals("default", StringComparison.OrdinalIgnoreCase))
		{
			if (browserType.Equals("chrome", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("chrome.exe", _003C_003Ec__DisplayClass6_.url);
					return;
				}
				catch (Exception ex)
				{
					throw new InvalidOperationException("用Chrome浏览器打开网址失败，请确保已安装chrome并加入到PATH环境变量中。" + ex.Message);
				}
			}
			if (browserType.Equals("chromeApp", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("chrome.exe", "--app=\"" + _003C_003Ec__DisplayClass6_.url + "\"");
					return;
				}
				catch (Exception ex2)
				{
					throw new InvalidOperationException("用ChromeApp模式打开网址失败，请确保已安装chrome并加入到PATH环境变量中。" + ex2.Message);
				}
			}
			if (browserType.Equals("chromeIncognito", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("chrome.exe", _003C_003Ec__DisplayClass6_.url + "  -incognito");
					return;
				}
				catch (Exception ex3)
				{
					throw new InvalidOperationException("用ChromeApp模式打开网址失败，请确保已安装chrome并加入到PATH环境变量中。" + ex3.Message);
				}
			}
			if (browserType.Equals("msedgeApp", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("msedge.exe", "--app=\"" + _003C_003Ec__DisplayClass6_.url + "\"");
					return;
				}
				catch (Exception ex4)
				{
					throw new InvalidOperationException("用Edge的App模式打开网址失败，请确保已安装Chromium版本Edge浏览器。" + ex4.Message);
				}
			}
			if (browserType.Equals("msedgeIncognito", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("msedge.exe", _003C_003Ec__DisplayClass6_.url + "  -inprivate");
					return;
				}
				catch (Exception ex5)
				{
					throw new InvalidOperationException("用ChromeApp模式打开网址失败，请确保已安装chrome并加入到PATH环境变量中。" + ex5.Message);
				}
			}
			if (browserType.Equals("microsoft-edge:", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("microsoft-edge:" + _003C_003Ec__DisplayClass6_.url);
					return;
				}
				catch (Exception ex6)
				{
					throw new InvalidOperationException("用Edge打开网址失败。" + ex6.Message);
				}
			}
			if (browserType.Equals("local", StringComparison.OrdinalIgnoreCase))
			{
				System.Windows.Application.Current.Dispatcher?.Invoke(_003C_003Ec__DisplayClass6_.ayJvXJH2rcx);
				return;
			}
			if (browserType.Equals("iexplore.exe", StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					Process.Start("iexplore.exe", _003C_003Ec__DisplayClass6_.url);
					return;
				}
				catch (Exception ex7)
				{
					throw new InvalidOperationException("用IE打开网址失败。" + ex7.Message);
				}
			}
			if (browserType.Equals("current"))
			{
				flag = true;
				num = 0;
				if (FVpXjSQEXy0ACIT00LBb == null)
				{
					goto IL_03ad;
				}
			}
			else
			{
				if (!(browserType == "custom"))
				{
					return;
				}
				if (string.IsNullOrEmpty(customBrowerExePath))
				{
					throw new InvalidDataException("未指定浏览器程序路径");
				}
				if (customBrowerExePath.Contains("%URL%"))
				{
					AppHelper.ExecuteText(customBrowerExePath.Replace("%URL%", _003C_003Ec__DisplayClass6_.url));
					return;
				}
				Process.Start(Environment.ExpandEnvironmentVariables(customBrowerExePath), _003C_003Ec__DisplayClass6_.url);
				num = 0;
				if (!BNZooUQE25tleQxxTAe1())
				{
					goto IL_038e;
				}
			}
			goto IL_0392;
		}
		if (!_003C_003Ec__DisplayClass6_.url.Contains("://"))
		{
			if (!IPAddress.TryParse(_003C_003Ec__DisplayClass6_.url, out var address))
			{
				_003C_003Ec__DisplayClass6_.url = "https://" + _003C_003Ec__DisplayClass6_.url;
				num = 2;
				if (!BNZooUQE25tleQxxTAe1())
				{
					goto IL_038e;
				}
				goto IL_0392;
			}
			_003C_003Ec__DisplayClass6_.url = "http://" + _003C_003Ec__DisplayClass6_.url;
		}
		goto IL_0419;
		IL_0392:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 3:
			return;
		case 2:
			goto IL_0419;
		case 0:
			return;
		}
		goto IL_03ad;
		IL_038e:
		int num2 = default(int);
		num = num2;
		goto IL_0392;
		IL_0419:
		try
		{
			Process.Start(_003C_003Ec__DisplayClass6_.url);
			return;
		}
		catch (Exception ex8)
		{
			throw new InvalidOperationException("用默认浏览器打开网址失败。" + ex8.Message);
		}
		IL_03ad:
		try
		{
			using Process process = NativeMethods.GetForegroundProcess();
			if (AppHelper.x8HLToI6dNE(process.ProcessName))
			{
				string text = process.MainModule?.FileName;
				if (!string.IsNullOrEmpty(text))
				{
					Process.Start(text, _003C_003Ec__DisplayClass6_.url);
					flag = false;
				}
			}
		}
		catch (Exception)
		{
		}
		if (flag)
		{
			Process.Start(_003C_003Ec__DisplayClass6_.url);
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool CloseClipboard();

	public static void SendTextToWindow(string content, bool useCopyPaste, bool sendReturn, int delayMsBeforePaste = 100, int delayMsAfterPaste = 100, int delayBetweenChar = 0, bool? hideInHistory = null, CancellationToken? cancellationToken = null)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.LrwvXCJBG2p = content;
		_003C_003Ec__DisplayClass8_.HV5vXPvXUbP = hideInHistory;
		if (useCopyPaste)
		{
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass8_.LrwvXCJBG2p))
			{
				return;
			}
			AppState.LogQuickerPaste();
			int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			DebugHelper.LogExecuteTime(_003C_003Ec__DisplayClass8_.iqxvX03rmgr, "写入剪贴板");
			for (int i = 0; i < 40; i++)
			{
				if (clipboardSequenceNumber != AppState.ClipboardSequenceNumber)
				{
					break;
				}
				Thread.Sleep(5);
			}
			if (delayMsBeforePaste > 0)
			{
				Thread.Sleep(delayMsBeforePaste);
			}
			SendKeys.SendWait("^v");
			SendKeys.Flush();
			if (delayMsAfterPaste > 0)
			{
				Thread.Sleep(delayMsAfterPaste);
			}
		}
		else
		{
			_003C_003Ec__DisplayClass8_.LrwvXCJBG2p = _003C_003Ec__DisplayClass8_.LrwvXCJBG2p.Replace("\r\n", "\n");
			if (delayBetweenChar <= 0)
			{
				InputSimulator.Instance.Keyboard.TextEntry(_003C_003Ec__DisplayClass8_.LrwvXCJBG2p);
			}
			else
			{
				InputSimulator.Instance.Keyboard.TextEntryWithDelay(_003C_003Ec__DisplayClass8_.LrwvXCJBG2p, delayBetweenChar, cancellationToken);
			}
		}
		if (sendReturn)
		{
			InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.RETURN);
		}
	}

	public static void DoEvents()
	{
		DispatcherFrame dispatcherFrame = new DispatcherFrame();
		Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, new DispatcherOperationCallback(ExitFrame), dispatcherFrame);
		Dispatcher.PushFrame(dispatcherFrame);
	}

	public static object ExitFrame(object fInput)
	{
        DispatcherFrame f = (DispatcherFrame)fInput;
		f.Continue = false;
		return null;
	}

	public static void CopyOrPaste(bool showHint)
	{
		try
		{
			int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			AppHelper.SendCopyKeys();
			int num = 0;
			if (!BNZooUQE25tleQxxTAe1())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			long num3 = AppHelper.fLiLTj0x4QY() + 350L;
			while (num3 > AppHelper.fLiLTj0x4QY() && clipboardSequenceNumber == AppState.ClipboardSequenceNumber)
			{
				Thread.Sleep(20);
			}
			if (clipboardSequenceNumber == AppState.ClipboardSequenceNumber)
			{
				AppHelper.SendPasteKeys();
				if (showHint)
				{
					AppHelper.ShowSuccess("已粘贴。");
				}
			}
			else if (showHint)
			{
				AppHelper.ShowInformation("已复制。");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("操作失败了。" + ex.Message);
		}
	}

	public static void Paste()
	{
		AppHelper.SendPasteKeys();
	}

	public static string GetScrollActionParam(int delta)
	{
		return "_scroll_" + delta;
	}

	static ActionHelper()
	{
		UWgt81MpvwO = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool BNZooUQE25tleQxxTAe1()
	{
		return FVpXjSQEXy0ACIT00LBb == null;
	}
}
