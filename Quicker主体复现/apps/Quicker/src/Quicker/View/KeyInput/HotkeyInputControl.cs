using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using HandyControl.Controls;
using Quicker.Utilities.Hooks;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class HotkeyInputControl : UserControl, IComponentConnector
{
	internal class eui5DfuGF9WWP7Css2k : EventArgs
	{
		[CompilerGenerated]
		private IList<VirtualKeyCode> zZ4SpmNaMY8;

		[CompilerGenerated]
		private IList<VirtualKeyCode> vwpSpKXM5Sb;

		internal static eui5DfuGF9WWP7Css2k dSoL7kWUu103qtoiKa3q;

		public IList<VirtualKeyCode> Modifiers
		{
			[CompilerGenerated]
			get
			{
				return zZ4SpmNaMY8;
			}
			[CompilerGenerated]
			set
			{
				zZ4SpmNaMY8 = value;
			}
		}

		public IList<VirtualKeyCode> Keys
		{
			[CompilerGenerated]
			get
			{
				return vwpSpKXM5Sb;
			}
			[CompilerGenerated]
			set
			{
				vwpSpKXM5Sb = value;
			}
		}

		static eui5DfuGF9WWP7Css2k()
		{
		}

		internal static bool EZX7EgWUoH453xksXGy3()
		{
			return dSoL7kWUu103qtoiKa3q == null;
		}

		internal static void Nsq2VBWUbBX7odWPRQpn()
		{
		}
	}

	[CompilerGenerated]
	private bool NPfLLevliHO;

	private readonly KeyboardHook o3fLLYFrofZ = new KeyboardHook();

	private bool IVELLIrNf2d;

	[CompilerGenerated]
	private EventHandler m_KeySelected;

	private static readonly VirtualKeyCode[] FELLLWZS59k;

	private readonly IList<VirtualKeyCode> wYdLLkV72WS = new List<VirtualKeyCode>();

	private readonly IList<VirtualKeyCode> Tm1LLGOhmta = new List<VirtualKeyCode>();

	private readonly HashSet<VirtualKeyCode> drqLLsvqasg = new HashSet<VirtualKeyCode>();

	private int J35LLHwt2sE = -1;

	private Brush HC0LL18PFO5;

	private object MDoLLbWpAme;

	internal Button BtnRecord;

	private bool CFqLL60JMD3;

	internal static HotkeyInputControl gyf5CgFAKZWx2XiOAWO0;

	public CornerRadius CornerRadius
	{
		get
		{
			return BorderElement.GetCornerRadius(BtnRecord);
		}
		set
		{
			BorderElement.SetCornerRadius(BtnRecord, value);
		}
	}

	public bool ShowKeyNames
	{
		[CompilerGenerated]
		get
		{
			return NPfLLevliHO;
		}
		[CompilerGenerated]
		set
		{
			NPfLLevliHO = value;
		}
	}

	public event EventHandler KeySelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_KeySelected;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_KeySelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_KeySelected;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_KeySelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public HotkeyInputControl()
	{
		InitializeComponent();
		o3fLLYFrofZ.KeyDown += qHhLLZ7f3Tc;
		o3fLLYFrofZ.KeyUp += FSuLLVjuCN5;
		base.Unloaded += Fg6LLcoB8ly;
		base.Dispatcher.ShutdownStarted += BlLLLqWV4F1;
	}

	private void BlLLLqWV4F1(object sender, EventArgs e)
	{
		o3fLLYFrofZ.Stop();
	}

	private void Fg6LLcoB8ly(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.ShutdownStarted -= BlLLLqWV4F1;
		o3fLLYFrofZ.Stop();
	}

	private void FSuLLVjuCN5(object sender, HookKeyEventArgs e)
	{
		while (true)
		{
			e.Handled = true;
			if (gyf5CgFAKZWx2XiOAWO0 == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (e.KeyValue == J35LLHwt2sE)
		{
			J35LLHwt2sE = -1;
		}
		if (Enum.IsDefined(typeof(VirtualKeyCode), e.KeyValue))
		{
			VirtualKeyCode keyValue = (VirtualKeyCode)e.KeyValue;
			keyValue = hoOLL9vPrv0(e, keyValue);
			if (Tm1LLGOhmta.Contains(keyValue) || wYdLLkV72WS.Contains(keyValue))
			{
				drqLLsvqasg.Remove(keyValue);
			}
		}
		if (drqLLsvqasg.Count == 0)
		{
			StopRecord();
		}
	}

	private void qHhLLZ7f3Tc(object sender, HookKeyEventArgs e)
	{
		e.Handled = true;
		if (!Enum.IsDefined(typeof(VirtualKeyCode), e.KeyValue))
		{
			return;
		}
		VirtualKeyCode keyValue = (VirtualKeyCode)e.KeyValue;
		keyValue = hoOLL9vPrv0(e, keyValue);
		if (!drqLLsvqasg.Add(keyValue))
		{
			int num = 0;
			if (!iZmJFyFABJCXIBGCP4OY())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (FELLLWZS59k.Contains(keyValue) && !Tm1LLGOhmta.Contains(keyValue))
		{
			Tm1LLGOhmta.Add(keyValue);
		}
		else if (!wYdLLkV72WS.Contains(keyValue))
		{
			wYdLLkV72WS.Add(keyValue);
		}
	}

	private static VirtualKeyCode hoOLL9vPrv0(HookKeyEventArgs hookKeyEventArgs_0, VirtualKeyCode virtualKeyCode_1)
	{
		if (virtualKeyCode_1 == VirtualKeyCode.RETURN && hookKeyEventArgs_0.IsExtended)
		{
			virtualKeyCode_1 = VirtualKeyCode.NumpadEnter;
		}
		return virtualKeyCode_1;
	}

	private void eX1LLhuroqZ(object sender, RoutedEventArgs e)
	{
		if (IVELLIrNf2d)
		{
			StopRecord();
		}
		else
		{
			StartRecord();
		}
	}

	public void StartRecord()
	{
		IVELLIrNf2d = true;
		J35LLHwt2sE = -1;
		drqLLsvqasg.Clear();
		Tm1LLGOhmta.Clear();
		wYdLLkV72WS.Clear();
		HC0LL18PFO5 = BtnRecord.Background;
		int num = 0;
		if (!iZmJFyFABJCXIBGCP4OY())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		MDoLLbWpAme = BtnRecord.Content;
		BtnRecord.Background = Brushes.Coral;
		BtnRecord.Content = "记录中...";
		o3fLLYFrofZ.Start();
	}

	public void StopRecord()
	{
		if (!IVELLIrNf2d)
		{
			return;
		}
		o3fLLYFrofZ.Stop();
		if (iZmJFyFABJCXIBGCP4OY())
		{
			switch (0)
			{
			}
		}
		IVELLIrNf2d = false;
		BtnRecord.ClearValue(Control.BackgroundProperty);
		BtnRecord.Content = MDoLLbWpAme;
		if (Tm1LLGOhmta.Count > 0 || wYdLLkV72WS.Count > 0)
		{
			this.m_KeySelected?.Invoke(this, new eui5DfuGF9WWP7Css2k
			{
				Keys = wYdLLkV72WS.ToList(),
				Modifiers = Tm1LLGOhmta.ToList()
			});
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!CFqLL60JMD3)
		{
			CFqLL60JMD3 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/keyinput/hotkeyinputcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			BtnRecord = (Button)target;
			BtnRecord.Click += eX1LLhuroqZ;
		}
		else
		{
			CFqLL60JMD3 = true;
		}
	}

	static HotkeyInputControl()
	{
		FELLLWZS59k = new VirtualKeyCode[11]
		{
			VirtualKeyCode.CONTROL,
			VirtualKeyCode.LCONTROL,
			VirtualKeyCode.RCONTROL,
			VirtualKeyCode.MENU,
			VirtualKeyCode.LMENU,
			VirtualKeyCode.RMENU,
			VirtualKeyCode.SHIFT,
			VirtualKeyCode.LSHIFT,
			VirtualKeyCode.RSHIFT,
			VirtualKeyCode.RWIN,
			VirtualKeyCode.LWIN
		};
	}

	internal static bool iZmJFyFABJCXIBGCP4OY()
	{
		return gyf5CgFAKZWx2XiOAWO0 == null;
	}
}
