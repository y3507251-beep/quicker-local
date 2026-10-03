using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Entities;
using Quicker.Utilities;

namespace Quicker.Actions.XActions.BuildinRunners.UI.CustomPanel;

public class OperationListControl : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private EventHandler<ItemEventArgs> f0Agx8RI9Ph;

	public static readonly DependencyProperty IconSizeProperty;

	public static readonly DependencyProperty OperationListProperty;

	public static readonly DependencyProperty SpacingProperty;

	internal OperationListControl TheControl;

	internal ItemsControl TheList;

	private bool v5ygxax5PyC;

	internal static OperationListControl NPbhQFQ48EkYT2wIBcbb;

	public double IconSize
	{
		get
		{
			return (double)GetValue(IconSizeProperty);
		}
		set
		{
			SetValue(IconSizeProperty, value);
		}
	}

	public IList<CommonOperationItem> OperationList
	{
		get
		{
			return (IList<CommonOperationItem>)GetValue(OperationListProperty);
		}
		set
		{
			SetValue(OperationListProperty, value);
		}
	}

	public double Spacing
	{
		get
		{
			return (double)GetValue(SpacingProperty);
		}
		set
		{
			SetValue(SpacingProperty, value);
		}
	}

	public event EventHandler<ItemEventArgs> ItemClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ItemEventArgs> eventHandler = f0Agx8RI9Ph;
			EventHandler<ItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemEventArgs> value2 = (EventHandler<ItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref f0Agx8RI9Ph, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ItemEventArgs> eventHandler = f0Agx8RI9Ph;
			EventHandler<ItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemEventArgs> value2 = (EventHandler<ItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref f0Agx8RI9Ph, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public OperationListControl()
	{
		InitializeComponent();
	}

	private void pipgxyWJ9Go(object sender, RoutedEventArgs e)
	{
		if ((sender as Button)?.DataContext is CommonOperationItem item)
		{
			f0Agx8RI9Ph?.Invoke(this, new ItemEventArgs
			{
				Item = item
			});
		}
		else
		{
			AppHelper.ShowWarning("数据为空！");
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!v5ygxax5PyC)
		{
			v5ygxax5PyC = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/xactions/buildinrunners/ui/custompanel/operationlistcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			v5ygxax5PyC = true;
			break;
		case 2:
			TheList = (ItemsControl)target;
			break;
		case 1:
			TheControl = (OperationListControl)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 3)
		{
			((Button)target).Click += pipgxyWJ9Go;
		}
	}

	static OperationListControl()
	{
		IconSizeProperty = DependencyProperty.Register("IconSize", typeof(double), typeof(OperationListControl), new PropertyMetadata(16.0));
		OperationListProperty = DependencyProperty.Register("OperationList", typeof(IList<CommonOperationItem>), typeof(OperationListControl), new PropertyMetadata((object)null));
		SpacingProperty = DependencyProperty.Register("Spacing", typeof(double), typeof(OperationListControl), new PropertyMetadata(5.0));
	}

	internal static bool MnwnHaQ4Ra6SINtib1mb()
	{
		return NPbhQFQ48EkYT2wIBcbb == null;
	}
}
