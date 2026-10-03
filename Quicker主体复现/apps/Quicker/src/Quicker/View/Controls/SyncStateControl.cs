using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using FontAwesome5;
using FontAwesome5.WPF;
using Quicker.Domain.Network;
using Quicker.Utilities.UI;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.Controls;

public class SyncStateControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty SyncStateProperty;

	internal SvgAwesome Icon;

	private bool fVFLjJoBci0;

	internal static SyncStateControl m7OPqCFqXtbGWo29QL1m;

	public QuickerSyncState SyncState
	{
		get
		{
			return (QuickerSyncState)GetValue(SyncStateProperty);
		}
		set
		{
			SetValue(SyncStateProperty, value);
		}
	}

	private static void CpqLjuMdLsn(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is SyncStateControl)
		{
			((SyncStateControl)dependencyObject_0).CEeLjNi3rYN();
		}
	}

	private void CEeLjNi3rYN()
	{
		SvgAwesome icon = Icon;
		SvgAwesome icon2 = Icon;
		double width = 16.0;
		icon2.Height = 16.0;
		icon.Width = width;
		int num;
		switch (SyncState)
		{
		default:
			Icon.Icon = EFontAwesomeIcon.None;
			Icon.Spin = false;
			Icon.Rotation = 0.0;
			base.ToolTip = "空闲";
			return;
		case QuickerSyncState.Pending:
		{
			Icon.Icon = EFontAwesomeIcon.Solid_Circle;
			SvgAwesome icon3 = Icon;
			SvgAwesome icon4 = Icon;
			width = 5.0;
			icon4.Height = 5.0;
			icon3.Width = width;
			Icon.Spin = false;
			Icon.Rotation = 0.0;
			Icon.Foreground = (TryFindResource("TextSuccessBrush") as Brush) ?? Brushes.DarkGreen;
			num = 0;
			if (!lR0NeQFq2KgfI1KPc0xW())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_01ce;
		}
		case QuickerSyncState.Syncing:
			Icon.Icon = EFontAwesomeIcon.Light_Sync;
			Icon.Spin = true;
			Icon.Rotation = 0.0;
			Icon.Foreground = Color.FromRgb(102, 102, 102).GetBrush();
			base.ToolTip = "正在同步";
			return;
		case QuickerSyncState.Warning:
			{
				Icon.Icon = EFontAwesomeIcon.Light_ExclamationCircle;
				Icon.Spin = false;
				Icon.Rotation = 0.0;
				Icon.Foreground = (FindResource("TextDangerBrush") as Brush) ?? Brushes.Red;
				num = 0;
				if (m7OPqCFqXtbGWo29QL1m == null)
				{
					break;
				}
				goto IL_01ce;
			}
			IL_01ce:
			switch (num)
			{
			default:
				base.ToolTip = "有需要同步的数据";
				return;
			case 1:
				break;
			}
			break;
		}
		base.ToolTip = "同步异常";
	}

	public SyncStateControl()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!fVFLjJoBci0)
		{
			fVFLjJoBci0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/syncstatecontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			Icon = (SvgAwesome)target;
		}
		else
		{
			fVFLjJoBci0 = true;
		}
	}

	static SyncStateControl()
	{
		SyncStateProperty = DependencyProperty.Register("SyncState", typeof(global::Quicker.Domain.Network.QuickerSyncState), typeof(SyncStateControl), new PropertyMetadata(QuickerSyncState.Idle, CpqLjuMdLsn));
	}

	internal static bool lR0NeQFq2KgfI1KPc0xW()
	{
		return m7OPqCFqXtbGWo29QL1m == null;
	}
}
