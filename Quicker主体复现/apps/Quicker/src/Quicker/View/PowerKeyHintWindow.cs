using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View;

public class PowerKeyHintWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public PowerKeyHintWindow PSgSXjVTNFO;

		public ShowWindowLocation frKSXnwl6JZ;

		internal static _003C_003Ec__DisplayClass5_0 H4D8i0WZ6Vtr2slBoYq6;

		internal void qTuSXQMw00Q(object sender, RoutedEventArgs e)
		{
			NativeMethods.SetWindowNoActivate(PSgSXjVTNFO);
			if (PSgSXjVTNFO.qNvg4XBP09t)
			{
				WindowHelper.SetWindowExTransparent(new WindowInteropHelper(PSgSXjVTNFO).Handle);
				PSgSXjVTNFO.BtnClose.Visibility = Visibility.Collapsed;
			}
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(PSgSXjVTNFO, frKSXnwl6JZ);
		}

		internal static bool L2w6QaWZtXkv1ygfNKTr()
		{
			return H4D8i0WZ6Vtr2slBoYq6 == null;
		}
	}

	private readonly bool qNvg4XBP09t;

	[CompilerGenerated]
	private bool dEZg4m2Zwai;

	private Point dD5g4KJaSKv;

	private bool KeGg4xUMHt6;

	internal Grid BodyGrid;

	internal TextBlock TxtTitle;

	internal ItemsControl ColumnList;

	internal Button BtnClose;

	private bool Bxfg4r3DdqX;

	internal static PowerKeyHintWindow nCheHUFQE1LI3gkrUAQQ;

	public bool CloseAfterDeactivated
	{
		[CompilerGenerated]
		get
		{
			return dEZg4m2Zwai;
		}
		[CompilerGenerated]
		set
		{
			dEZg4m2Zwai = value;
		}
	}

	public PowerKeyHintWindow(string title, IList<string> columns, ShowWindowLocation location = ShowWindowLocation.TopCenter, bool allowMouseThrough = false)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.frKSXnwl6JZ = location;
		
		_003C_003Ec__DisplayClass5_.PSgSXjVTNFO = this;
		qNvg4XBP09t = allowMouseThrough;
		InitializeComponent();
		TxtTitle.Text = title;
		ColumnList.ItemsSource = columns;
		base.Loaded += _003C_003Ec__DisplayClass5_.qTuSXQMw00Q;
		base.MaxHeight = SystemParameters.PrimaryScreenHeight * 0.8;
		base.Deactivated += dd5g4spv3Io;
		base.Closing += m28g4GRujBv;
		base.Closed += iHbg4k7G5yb;
	}

	private void iHbg4k7G5yb(object sender, EventArgs e)
	{
		KeGg4xUMHt6 = true;
	}

	private void m28g4GRujBv(object sender, CancelEventArgs e)
	{
		KeGg4xUMHt6 = true;
	}

	private void dd5g4spv3Io(object sender, EventArgs e)
	{
		if (CloseAfterDeactivated && base.IsLoaded && !KeGg4xUMHt6)
		{
			try
			{
				Close();
			}
			catch
			{
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void UCPg4HuD8s3(object sender, MouseButtonEventArgs e)
	{
		dD5g4KJaSKv = e.GetPosition(this);
	}

	private void gbog416VX1k(object sender, MouseEventArgs e)
	{
		Point position = e.GetPosition(this);
		if (e.LeftButton == MouseButtonState.Pressed && (Math.Abs(position.X - dD5g4KJaSKv.X) > SystemParameters.MinimumHorizontalDragDistance || Math.Abs(position.Y - dD5g4KJaSKv.Y) > SystemParameters.MinimumVerticalDragDistance))
		{
			DragMove();
		}
	}

	private void X2cg4bBP3EH(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void dFxg46a5XBp(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.Escape))
		{
			Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Bxfg4r3DdqX)
		{
			Bxfg4r3DdqX = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/powerkeyhintwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Bxfg4r3DdqX = true;
			break;
		case 1:
			((PowerKeyHintWindow)target).PreviewMouseLeftButtonDown += UCPg4HuD8s3;
			((PowerKeyHintWindow)target).PreviewMouseMove += gbog416VX1k;
			((PowerKeyHintWindow)target).KeyDown += dFxg46a5XBp;
			break;
		case 2:
		{
			BodyGrid = (Grid)target;
			int num = 0;
			if (nCheHUFQE1LI3gkrUAQQ != null)
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
			TxtTitle = (TextBlock)target;
			break;
		case 4:
			ColumnList = (ItemsControl)target;
			break;
		case 5:
			BtnClose = (Button)target;
			BtnClose.Click += X2cg4bBP3EH;
			break;
		}
	}

	internal static bool kRwRDeFQGeMkombl6Qv3()
	{
		return nCheHUFQE1LI3gkrUAQQ == null;
	}
}
