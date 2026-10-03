using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Interop;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View.Main;

public class DirectCaptureWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private IntPtr pONL7WI1UwM;

	[CompilerGenerated]
	private System.Drawing.Point SHQL7kFkW6J;

	[CompilerGenerated]
	private System.Drawing.Point lnEL7G2rIEP;

	[CompilerGenerated]
	private bool gasL7sMeW0D;

	private bool dy3L7HYH7fU;

	private static DirectCaptureWindow uRZKCMF0RY2JxSxwnIBh;

	public IntPtr HWnd
	{
		[CompilerGenerated]
		get
		{
			return pONL7WI1UwM;
		}
		[CompilerGenerated]
		private set
		{
			pONL7WI1UwM = value;
		}
	}

	public System.Drawing.Point StartPoint
	{
		[CompilerGenerated]
		get
		{
			return SHQL7kFkW6J;
		}
		[CompilerGenerated]
		set
		{
			SHQL7kFkW6J = value;
		}
	}

	public System.Drawing.Point EndPoint
	{
		[CompilerGenerated]
		get
		{
			return lnEL7G2rIEP;
		}
		[CompilerGenerated]
		set
		{
			lnEL7G2rIEP = value;
		}
	}

	public bool IsCanceled
	{
		[CompilerGenerated]
		get
		{
			return gasL7sMeW0D;
		}
		[CompilerGenerated]
		set
		{
			gasL7sMeW0D = value;
		}
	}

	public DirectCaptureWindow()
	{
		InitializeComponent();
		base.SourceInitialized += HZIL7eVrxsR;
	}

	private void HZIL7eVrxsR(object sender, EventArgs e)
	{
		HWnd = new WindowInteropHelper(this).Handle;
		int windowLong = NativeMethods.GetWindowLong(HWnd, -20);
		NativeMethods.SetWindowLong(HWnd, -20, (int)(windowLong | 0x80L | 0x8000000L));
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	public void OnMouseMoveFromHook(System.Drawing.Point pt)
	{
		IHNRIiikxBwJdYmHpM3.oYxvviDauVj(HWnd, Math.Min(StartPoint.X, pt.X), Math.Min(StartPoint.Y, pt.Y), Math.Abs(pt.X - StartPoint.X) + 1, Math.Abs(pt.Y - StartPoint.Y) + 1);
		EndPoint = pt;
	}

	public void Cancel()
	{
		AppHelper.RunOnUiThread(false, PgXL7YBCMUK);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!dy3L7HYH7fU)
		{
			dy3L7HYH7fU = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/main/directcapturewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		dy3L7HYH7fU = true;
	}

	[CompilerGenerated]
	private void PgXL7YBCMUK()
	{
		try
		{
			IsCanceled = true;
			if (base.IsLoaded)
			{
				Close();
			}
		}
		catch (Exception)
		{
		}
	}

	internal static bool ebqq6AF0gP4r2JoharsI()
	{
		return uRZKCMF0RY2JxSxwnIBh == null;
	}
}
