using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.View.Controls;

namespace Quicker.Settings.Pages.Basic.DialogControls;

public class QuickRunItemEdit : UserControl, IComponentConnector
{
	internal TextBox TxtCmdText;

	internal ActionSelector ActionSelector;

	private bool lVAMCT88jm;

	internal static QuickRunItemEdit FNEIC14CeWht6ctiVJH;

	public string CmdText
	{
		get
		{
			return TxtCmdText.Text;
		}
		set
		{
			TxtCmdText.Text = value;
		}
	}

	public string ActionIdOrName
	{
		get
		{
			return ActionSelector.ActionIdOrName;
		}
		set
		{
			ActionSelector.ActionIdOrName = value;
		}
	}

	public QuickRunItemEdit()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!lVAMCT88jm)
		{
			lVAMCT88jm = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/dialogcontrols/quickrunitemedit.xaml", UriKind.Relative);
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
			lVAMCT88jm = true;
			break;
		case 2:
			ActionSelector = (ActionSelector)target;
			break;
		case 1:
			TxtCmdText = (TextBox)target;
			break;
		}
	}

	internal static void MVBmJh4hu1vxTaQlId7()
	{
	}

	internal static bool WZurnP47GrTtLEjQNPG()
	{
		return FNEIC14CeWht6ctiVJH == null;
	}
}
