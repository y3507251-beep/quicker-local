using System;
using cXuiZ7i2m2sRaR7QhhS;
using lGFWOcimK6GZKnFIeLT;
using nSudn7i77a3JpXIFA0G;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities.Win32;
using x6MHGwiYv06PXoBFlMe;

namespace l9W6KWifMfNKrInJR4l;

internal class ytnqhyiMNhGmytDmEj7
{
	internal static ytnqhyiMNhGmytDmEj7 ArjTXTFsLKSkg3E2C6Gl;

	public static (ExplorerSoftware explorer, IntPtr hWnd, string processName, bool isExplorerWindow) zwDvtNYUZmk(IntPtr? nullable_0 = null)
	{
		IntPtr windowHandleOrForegroundWindow = NativeMethods.GetWindowHandleOrForegroundWindow(nullable_0);
		string text = NativeMethods.GetProcessName(NativeMethods.GetWindowProcessId(windowHandleOrForegroundWindow)).ToLower();
		switch (text)
		{
		default:
			return (explorer: AppState.HHxtaMaoqJr().DefaultExplorerSoftware, hWnd: IntPtr.Zero, processName: text, isExplorerWindow: false);
		case "xyplorer":
			return (explorer: ExplorerSoftware.XYplorer, hWnd: windowHandleOrForegroundWindow, processName: text, isExplorerWindow: true);
		case "totalcmd64":
		case "totalcmd":
			return (explorer: ExplorerSoftware.TotalCommander, hWnd: windowHandleOrForegroundWindow, processName: text, isExplorerWindow: true);
		case "dopus":
			return (explorer: ExplorerSoftware.DirectoryOpus, hWnd: windowHandleOrForegroundWindow, processName: text, isExplorerWindow: true);
		case "explorer":
			return (explorer: ExplorerSoftware.WindowsExplorer, hWnd: windowHandleOrForegroundWindow, processName: text, isExplorerWindow: true);
		case "onecommander":
			return (explorer: ExplorerSoftware.OneCommander, hWnd: windowHandleOrForegroundWindow, processName: text, isExplorerWindow: true);
		}
	}

	public static string GvXvtJLyniF(IntPtr intptr_0)
	{
		(ExplorerSoftware, IntPtr, string, bool) tuple = zwDvtNYUZmk(intptr_0);
		switch (tuple.Item1)
		{
		default:
			if (ProcessHelper.IsDesktopSoftware(tuple.Item3))
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			return string.Empty;
		case ExplorerSoftware.WindowsExplorer:
			return NativeMethods.GetCurrentFolder(intptr_0);
		case ExplorerSoftware.DirectoryOpus:
			return cQCX97ioFnivYTCZNWb.Oi3vtvYuFIC(intptr_0).activeFolder;
		case ExplorerSoftware.TotalCommander:
			return d23lbji6LH2xdpIE1Qu.mB2vt0Xicgu(intptr_0);
		case ExplorerSoftware.XYplorer:
			return moAa3ciiBWM25Wu8vZH.jHKvtqwpORl(tuple.Item2);
		case ExplorerSoftware.OneCommander:
			if (!string.Equals(tuple.Item3, "onecommander", StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException("当前窗口不是OneCommander窗口（" + tuple.Item3 + "）。");
			}
			return sDvXVkiWVWu4wUdiwlQ.oJFvwd4TOJW(tuple.Item2);
		}
	}

	internal static bool kZOTnGFsuduX5323OULH()
	{
		return ArjTXTFsLKSkg3E2C6Gl == null;
	}
}
