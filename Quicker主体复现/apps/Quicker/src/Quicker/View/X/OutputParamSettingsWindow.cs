using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Actions.XActions.Storage;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.X;

public class OutputParamSettingsWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private OutputParamInfo u41LWOy0GS8;

	internal TextBoxWithToolsControl TxtVisibleExpression;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool hRkLWFpMcyZ;

	private static OutputParamSettingsWindow yHx9ktFJhRBIi8Kd9lkg;

	public OutputParamInfo OutputParamInfo
	{
		[CompilerGenerated]
		get
		{
			return u41LWOy0GS8;
		}
		[CompilerGenerated]
		set
		{
			u41LWOy0GS8 = value;
		}
	}

	public OutputParamSettingsWindow(OutputParamInfo outputParamInfo, IList<ActionVariable> variables)
	{
		OutputParamInfo = outputParamInfo;
		InitializeComponent();
		if (outputParamInfo != null)
		{
			TxtVisibleExpression.Text = outputParamInfo.VisibleExpression ?? "";
		}
		TxtVisibleExpression.SetVariables(variables);
	}

	private void L4oLWMkUXVy(object sender, RoutedEventArgs e)
	{
		Save();
		base.DialogResult = true;
	}

	private void Save()
	{
		OutputParamInfo = new OutputParamInfo
		{
			VisibleExpression = TxtVisibleExpression.Text
		};
	}

	private void wSBLWAOdFsK(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!hRkLWFpMcyZ)
		{
			hRkLWFpMcyZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/outputparamsettingswindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			hRkLWFpMcyZ = true;
			break;
		case 1:
			TxtVisibleExpression = (TextBoxWithToolsControl)target;
			break;
		case 2:
			BtnSave = (Button)target;
			BtnSave.Click += L4oLWMkUXVy;
			break;
		case 3:
			BtnCancel = (Button)target;
			BtnCancel.Click += wSBLWAOdFsK;
			break;
		}
	}

	internal static bool BBql3AFJH070350MOJCK()
	{
		return yHx9ktFJhRBIi8Kd9lkg == null;
	}
}
