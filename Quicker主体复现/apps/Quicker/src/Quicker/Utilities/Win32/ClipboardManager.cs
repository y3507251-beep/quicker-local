using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using log4net;

namespace Quicker.Utilities.Win32;

public class ClipboardManager : NativeWindow
{
	[CompilerGenerated]
	private EventHandler mXeLOiKSkS1;

	private static readonly ILog FxOLO3x1JOB;

	private static ClipboardManager tQuLOfZ6Byt;

	private static readonly IntPtr fXCLOzwQQ5X;

	internal static ClipboardManager dh2oEeFP4cah2hdSBM4M;

	public static ClipboardManager Instance
	{
		get
		{
			if (tQuLOfZ6Byt == null)
			{
				tQuLOfZ6Byt = new ClipboardManager();
			}
			return tQuLOfZ6Byt;
		}
	}

	public event EventHandler ClipboardChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = mXeLOiKSkS1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mXeLOiKSkS1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = mXeLOiKSkS1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mXeLOiKSkS1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private ClipboardManager()
	{
		CreateHandle(new CreateParams());
	}

	public void Start()
	{
		if (!sAiLOU9Xwsx(base.Handle))
		{
			FxOLO3x1JOB.Warn("注册剪贴板监听失败");
		}
	}

	public void Stop()
	{
		SZwLOlWUp2c(base.Handle);
	}

	private void M4WLOFAPPmk()
	{
		mXeLOiKSkS1?.Invoke(this, EventArgs.Empty);
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		int msg = m.Msg;
		if (msg > 2)
		{
			if (!FJeOeiFPhCE70x89WtqS())
			{
				switch (0)
				{
				}
			}
			switch (msg)
			{
			case 797:
				M4WLOFAPPmk();
				break;
			case 16:
				Stop();
				break;
			}
		}
		else
		{
			switch (msg)
			{
			case 2:
				Stop();
				break;
			case 1:
				Start();
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "AddClipboardFormatListener")]
	private static extern bool sAiLOU9Xwsx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "RemoveClipboardFormatListener")]
	private static extern bool SZwLOlWUp2c(IntPtr intptr_1);

	static ClipboardManager()
	{
		FxOLO3x1JOB = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		fXCLOzwQQ5X = IntPtr.Zero;
	}

	internal static bool FJeOeiFPhCE70x89WtqS()
	{
		return dh2oEeFP4cah2hdSBM4M == null;
	}

	internal static void yb9rUeFPzdg2iejTyAIj()
	{
	}
}
