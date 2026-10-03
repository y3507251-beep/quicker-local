using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Threading;
using Ci16jh2IrdW1EGWcrNE;
using f5fV1EMjxQYCEGaKlWD;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Domain.PowerKeys;
using Quicker.Utilities;
using WindowsInput.Native;

namespace Quicker.View.Tools;

public class KeyboardStateWindow : HandyControl.Controls.Window, IComponentConnector
{
	private DispatcherTimer ps3LSVHoZa0;

	private readonly Keys[] bUILSZNwH0B = (Keys[])Enum.GetValues(typeof(Keys));

	private readonly MouseButtons[] sPxLS9b6yjj = (MouseButtons[])Enum.GetValues(typeof(MouseButtons));

	internal TextBlock LblProcess;

	internal TextBlock LblState;

	internal System.Windows.Controls.Button BtnReset;

	internal System.Windows.Controls.Button BtnClose;

	private bool RZaLSh87fcb;

	internal static KeyboardStateWindow z50TnlFeWtAPEYbJtCSa;

	public KeyboardStateWindow()
	{
		InitializeComponent();
		ps3LSVHoZa0 = new DispatcherTimer();
		ps3LSVHoZa0.Interval = TimeSpan.FromMilliseconds(100.0);
		ps3LSVHoZa0.Tick += oV8LSqRYDpE;
		ps3LSVHoZa0.Start();
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		ps3LSVHoZa0.Stop();
		ps3LSVHoZa0.Tick -= oV8LSqRYDpE;
		ps3LSVHoZa0 = null;
	}

	private void K5iLS7T6ffE(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void cgxLSRxgt5C(object sender, RoutedEventArgs e)
	{
		AppHelper.HP0LT5LCDOi();
	}

	private void oV8LSqRYDpE(object sender, EventArgs e)
	{
		EqSLScicoPS();
	}

	private void EqSLScicoPS()
	{
		LblProcess.Text = AppState.CurrentProcessName;
		BtnReset.IsEnabled = true;
		StringBuilder stringBuilder = new StringBuilder(256);
		stringBuilder.AppendLine("----系统按键状态-----");
		for (int i = 1; i < 255; i++)
		{
			if (KeyboardHelper.IsKeyDown((VirtualKeyCode)i))
			{
				Keys keys = (Keys)i;
				stringBuilder.AppendLine(keys.ToString());
			}
		}
		VirtualKeyCode[] w1ILd8bNW7n = CiNTbyM2WDubHspat0P.w1ILd8bNW7n;
		int num = 0;
		int num3 = default(int);
		oweR8e2rZD7t5GSlLo4 oweR8e2rZD7t5GSlLo = default(oweR8e2rZD7t5GSlLo4);
		while (true)
		{
			int num2;
			if (num < w1ILd8bNW7n.Length)
			{
				VirtualKeyCode virtualKeyCode = w1ILd8bNW7n[num];
				if (CiNTbyM2WDubHspat0P.iBBLdEolQUM().k1DLdPoqbpG(virtualKeyCode))
				{
					stringBuilder.AppendLine(KeyboardHelper.GetKeyName(virtualKeyCode));
				}
				num++;
				num2 = 3;
				if (!xAxvE2FeyJfDcmMrPMdc())
				{
					goto IL_011d;
				}
			}
			else
			{
				stringBuilder.AppendLine();
				num2 = 0;
				if (z50TnlFeWtAPEYbJtCSa != null)
				{
					goto IL_011d;
				}
			}
			goto IL_0142;
			IL_011d:
			num2 = num3;
			goto IL_0142;
			IL_0142:
			while (true)
			{
				KeyboardState realKeyState;
				int j;
				switch (num2)
				{
				case 1:
					realKeyState = AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState;
					j = 1;
					goto IL_00f6;
				default:
					stringBuilder.AppendLine("----键盘挂钩内部状态-----");
					num2 = 1;
					if (z50TnlFeWtAPEYbJtCSa != null)
					{
						continue;
					}
					goto case 1;
				case 3:
					break;
				case 2:
					if (oweR8e2rZD7t5GSlLo != null)
					{
						stringBuilder.AppendLine();
						stringBuilder.AppendLine("----鼠标挂钩内部状态-----");
						MouseButtons[] array = sPxLS9b6yjj;
						for (num = 0; num < array.Length; num++)
						{
							MouseButtons mouseButtons_ = array[num];
							if (oweR8e2rZD7t5GSlLo.Kcpt9nPM6AT(mouseButtons_))
							{
								stringBuilder.AppendLine(mouseButtons_.ToString());
							}
						}
					}
					LblState.Text = stringBuilder.ToString();
					return;
				}
				break;
				IL_00f6:
				for (; j < 255; j++)
				{
					if (realKeyState.IsKeyDown(j))
					{
						Keys keys = (Keys)j;
						stringBuilder.AppendLine(keys.ToString());
					}
				}
				oweR8e2rZD7t5GSlLo = AppState.v5FtaQ4hQfg().zYwvLopdTEn().RealState;
				num2 = 2;
				if (xAxvE2FeyJfDcmMrPMdc())
				{
					continue;
				}
				goto IL_011d;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!RZaLSh87fcb)
		{
			RZaLSh87fcb = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/tools/keyboardstatewindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			RZaLSh87fcb = true;
			break;
		case 1:
			LblProcess = (TextBlock)target;
			break;
		case 2:
			LblState = (TextBlock)target;
			break;
		case 3:
		{
			BtnReset = (System.Windows.Controls.Button)target;
			int num = 0;
			if (!xAxvE2FeyJfDcmMrPMdc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnReset.Click += cgxLSRxgt5C;
				break;
			}
			break;
		}
		case 4:
			BtnClose = (System.Windows.Controls.Button)target;
			BtnClose.Click += K5iLS7T6ffE;
			break;
		}
	}

	static KeyboardStateWindow()
	{
	}

	internal static bool xAxvE2FeyJfDcmMrPMdc()
	{
		return z50TnlFeWtAPEYbJtCSa == null;
	}

	internal static void w8Wgn8Fen1OGs6jyF4kT()
	{
	}
}
