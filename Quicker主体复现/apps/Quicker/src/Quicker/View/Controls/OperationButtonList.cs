using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.View.Controls;

public class OperationButtonList : UserControl, IComponentConnector
{
	public static readonly DependencyProperty OperationListStrProperty;

	public static readonly DependencyProperty ButtonMarginProperty;

	public static readonly DependencyProperty IconSizeProperty;

	[CompilerGenerated]
	private SmartCollection<SimpleOperationItem> HodLxIWecJB = new SmartCollection<SimpleOperationItem>();

	internal OperationButtonList TheControl;

	internal ItemsControl ItemsControl;

	private bool AECLxWVBHRM;

	internal static OperationButtonList Qjb3VDFuSZUN9fNDkAjs;

	public string OperationListStr
	{
		get
		{
			return (string)GetValue(OperationListStrProperty);
		}
		set
		{
			SetValue(OperationListStrProperty, value);
		}
	}

	public Thickness ButtonMargin
	{
		get
		{
			return (Thickness)GetValue(ButtonMarginProperty);
		}
		set
		{
			SetValue(ButtonMarginProperty, value);
		}
	}

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

	public SmartCollection<SimpleOperationItem> OperationItems
	{
		[CompilerGenerated]
		get
		{
			return HodLxIWecJB;
		}
		[CompilerGenerated]
		set
		{
			HodLxIWecJB = value;
		}
	}

	private static void fQ1LxePlaxv(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		(dependencyObject_0 as OperationButtonList).SkoLxYsiYGw();
	}

	public OperationButtonList()
	{
		InitializeComponent();
		ItemsControl.ItemsSource = OperationItems;
	}

	private void SkoLxYsiYGw()
	{
		if (string.IsNullOrEmpty(OperationListStr))
		{
			OperationItems.Clear();
			return;
		}
		List<SimpleOperationItem> range = AppHelper.StringToOperationItems(OperationListStr, true);
		OperationItems.Reset(range);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!AECLxWVBHRM)
		{
			AECLxWVBHRM = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/operationbuttonlist.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			AECLxWVBHRM = true;
			break;
		case 2:
			ItemsControl = (ItemsControl)target;
			break;
		case 1:
			TheControl = (OperationButtonList)target;
			break;
		}
	}

	static OperationButtonList()
	{
		OperationListStrProperty = DependencyProperty.Register("OperationListStr", typeof(string), typeof(OperationButtonList), new PropertyMetadata(null, fQ1LxePlaxv));
		ButtonMarginProperty = DependencyProperty.Register("ButtonMargin", typeof(Thickness), typeof(OperationButtonList), new PropertyMetadata(default(Thickness)));
		IconSizeProperty = DependencyProperty.Register("IconSize", typeof(double), typeof(OperationButtonList), new PropertyMetadata(16.0));
	}

	internal static bool rBoKXSFuw8VhfGKEGSxA()
	{
		return Qjb3VDFuSZUN9fNDkAjs == null;
	}
}
