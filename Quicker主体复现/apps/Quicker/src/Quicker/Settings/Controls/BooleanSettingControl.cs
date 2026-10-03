using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Controls;

public class BooleanSettingControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private RoutedEventHandler m_Changed;

	internal CheckBox ChkItem;

	private bool AaEjY7v4V7;

	private static BooleanSettingControl Q5HpmUSZBs32JMDyMlE;

	public string Title
	{
		get
		{
			return ChkItem.Content?.ToString();
		}
		set
		{
			ChkItem.Content = value;
		}
	}

	public string Help
	{
		get
		{
			return ChkItem.ToolTip?.ToString();
		}
		set
		{
			ChkItem.ToolTip = (string.IsNullOrWhiteSpace(value) ? null : value);
		}
	}

	public bool IsChecked
	{
		get
		{
			return ChkItem.IsChecked == true;
		}
		set
		{
			ChkItem.IsChecked = value;
		}
	}

	public event RoutedEventHandler Changed
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_Changed;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_Changed, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = this.m_Changed;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_Changed, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
	}

	public BooleanSettingControl()
	{
		InitializeComponent();
	}

	private void kJWjeL2KLj(object sender, RoutedEventArgs e)
	{
		this.m_Changed?.Invoke(this, e);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!AaEjY7v4V7)
		{
			AaEjY7v4V7 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/controls/booleansettingcontrol.xaml", UriKind.Relative);
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
			ChkItem = (CheckBox)target;
			ChkItem.Click += kJWjeL2KLj;
		}
		else
		{
			AaEjY7v4V7 = true;
		}
	}

	internal static bool MIZUW4S5Hkn3xy4CfVO()
	{
		return Q5HpmUSZBs32JMDyMlE == null;
	}
}
