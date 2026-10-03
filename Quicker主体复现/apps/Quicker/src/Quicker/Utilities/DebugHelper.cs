using System;
using System.Reflection;
using System.Text;
using System.Threading;
using log4net;
using Quicker.Domain;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public static class DebugHelper
{
	private static readonly ILog o4gLo6pcvM4;

	private static object dKEdyBF5lbbxKxFJ4pOo;

	public static void LogExecuteTime(Action action, string message, int minMs = 0)
	{
		action();
	}

	public static void EnsureNotOnUiThread()
	{
	}

	public static void LogMouseCaptureWindow()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			stringBuilder.Append(NativeMethods.GetForegroundProcess().ProcessName);
			NativeMethods.GUITHREADINFO? guiThreadInfo = NativeMethods.GetGuiThreadInfo(IntPtr.Zero);
			if (guiThreadInfo.HasValue)
			{
				stringBuilder.Append($"\thwndCapture: {guiThreadInfo.Value.hwndCapture}{guiThreadInfo.Value.hwndCapture.GetWindowTitle()}, " + $"\thwndCaret: {guiThreadInfo.Value.hwndCaret}{guiThreadInfo.Value.hwndCaret.GetWindowTitle()}, " + $"\thwndActive: {guiThreadInfo.Value.hwndActive}{guiThreadInfo.Value.hwndActive.GetWindowTitle()},, " + $"\thwndMenuOwner: {guiThreadInfo.Value.hwndMenuOwner}{guiThreadInfo.Value.hwndMenuOwner.GetWindowTitle()}, " + $"\thwndFocus: {guiThreadInfo.Value.hwndFocus}{guiThreadInfo.Value.hwndFocus.GetWindowTitle()},");
			}
			else
			{
				stringBuilder.Append("ERROR: GetGuiThreadInfo return null");
			}
			o4gLo6pcvM4.Info(stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			o4gLo6pcvM4.Warn("记录捕获鼠标的窗口出错：" + ex.Message, ex);
		}
	}

	public static bool IsOnUiThread()
	{
		return Thread.CurrentThread.ManagedThreadId == AppState.UiThreadId;
	}

	internal static void bOILobnRRKR(string string_0)
	{
	}

	static DebugHelper()
	{
		o4gLo6pcvM4 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ooqWgFF5ZVp8Pe8DZHWd()
	{
		return dKEdyBF5lbbxKxFJ4pOo == null;
	}
}
