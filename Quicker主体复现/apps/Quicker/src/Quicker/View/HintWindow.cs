using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View;

public class HintWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public HintWindow rvXSX5nSvl2;

		public string wd1SXDKVNG5;

		public ShowWindowLocation sqPSXdaL5qx;

		internal static _003C_003Ec__DisplayClass5_0 msRWalWZTimjhgJBfaoN;

		internal void P47SX4Z9IHB(object sender, RoutedEventArgs e)
		{
			NativeMethods.SetWindowNoActivate(rvXSX5nSvl2);
			if (rvXSX5nSvl2.M98g44NfySv)
			{
				WindowHelper.SetWindowExTransparent(new WindowInteropHelper(rvXSX5nSvl2).Handle);
				rvXSX5nSvl2.BtnClose.Visibility = Visibility.Collapsed;
			}
			if (string.IsNullOrEmpty(wd1SXDKVNG5))
			{
				rvXSX5nSvl2.BodyGrid.Margin = new Thickness(5.0);
				int num = 0;
				if (!MXa4XgWZmEST8PA9XG9A())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				rvXSX5nSvl2.BtnClose.Margin = new Thickness(0.0);
				rvXSX5nSvl2.UpdateLayout();
			}
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(rvXSX5nSvl2, sqPSXdaL5qx);
		}

		internal static bool MXa4XgWZmEST8PA9XG9A()
		{
			return msRWalWZTimjhgJBfaoN == null;
		}
	}

	private readonly bool M98g44NfySv;

	[CompilerGenerated]
	private bool B97g451tvJb;

	private Point eSng4Div5QR;

	internal Grid BodyGrid;

	internal TextBlock TheText;

	internal Button BtnClose;

	private bool v3Tg4dXUE2v;

	internal static HintWindow PqHtoWFQBQhMoipHI1He;

	public bool ClosedByUser
	{
		[CompilerGenerated]
		get
		{
			return B97g451tvJb;
		}
		[CompilerGenerated]
		private set
		{
			B97g451tvJb = value;
		}
	}

	public string Message
	{
		get
		{
			return TheText.Text;
		}
		set
		{
			TheText.Text = value;
		}
	}

	public HintWindow(string message, ShowWindowLocation location = ShowWindowLocation.TopCenter, bool allowMouseThrough = false)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.wd1SXDKVNG5 = message;
		_003C_003Ec__DisplayClass5_.sqPSXdaL5qx = location;
		
		_003C_003Ec__DisplayClass5_.rvXSX5nSvl2 = this;
		M98g44NfySv = allowMouseThrough;
		InitializeComponent();
		TheText.Text = _003C_003Ec__DisplayClass5_.wd1SXDKVNG5;
		base.Loaded += _003C_003Ec__DisplayClass5_.P47SX4Z9IHB;
		base.MaxHeight = SystemParameters.PrimaryScreenHeight * 0.8;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	internal void gCCg4pXgp7r(string string_0)
	{
		try
		{
			TheText.FontFamily = new FontFamily(string_0);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置字体名称(" + string_0 + ")失败：" + ex.Message);
		}
	}

	private void C4eg4BTr9rl(object sender, MouseButtonEventArgs e)
	{
		eSng4Div5QR = e.GetPosition(this);
	}

	private void oTSg4QtvJ4L(object sender, MouseEventArgs e)
	{
		Point position = e.GetPosition(this);
		if (e.LeftButton == MouseButtonState.Pressed && (Math.Abs(position.X - eSng4Div5QR.X) > SystemParameters.MinimumHorizontalDragDistance || Math.Abs(position.Y - eSng4Div5QR.Y) > SystemParameters.MinimumVerticalDragDistance))
		{
			DragMove();
		}
	}

	private void z9ng4jvNHxS(object sender, RoutedEventArgs e)
	{
		ClosedByUser = true;
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!v3Tg4dXUE2v)
		{
			v3Tg4dXUE2v = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/hintwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			v3Tg4dXUE2v = true;
			break;
		case 1:
			((HintWindow)target).PreviewMouseLeftButtonDown += C4eg4BTr9rl;
			((HintWindow)target).PreviewMouseMove += oTSg4QtvJ4L;
			break;
		case 2:
		{
			BodyGrid = (Grid)target;
			int num = 0;
			if (!RbUOUEFQv2YrWYojio2W())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 3:
			TheText = (TextBlock)target;
			break;
		case 4:
			BtnClose = (Button)target;
			BtnClose.Click += z9ng4jvNHxS;
			break;
		}
	}

	internal static bool RbUOUEFQv2YrWYojio2W()
	{
		return PqHtoWFQBQhMoipHI1He == null;
	}
}
