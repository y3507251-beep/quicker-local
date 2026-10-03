using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.View.X.StepEditor.ParamEditors;

public class VariableInfoControl : UserControl, IComponentConnector
{
	internal Image ImgVarIcon;

	internal TextBlock LblVarName;

	internal TextBlock LblVarDesc;

	private bool YBbLHHUrLMS;

	internal static VariableInfoControl zx13qbFrWfF2iqSmHP0g;

	public VariableInfoControl()
	{
		InitializeComponent();
	}

	public void SetVarInfo(string key, VarType type, string desc)
	{
		LblVarName.Text = key;
		LblVarDesc.Text = desc;
		ImgVarIcon.Source = AppHelper.GetVarTypeIcon(type);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YBbLHHUrLMS)
		{
			YBbLHHUrLMS = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/paramcontrols/variableinfocontrol.xaml", UriKind.Relative);
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
			YBbLHHUrLMS = true;
			break;
		case 1:
			ImgVarIcon = (Image)target;
			break;
		case 2:
			LblVarName = (TextBlock)target;
			break;
		case 3:
			LblVarDesc = (TextBlock)target;
			break;
		}
	}

	internal static bool hL336tFrymXVgCQ5pPgX()
	{
		return zx13qbFrWfF2iqSmHP0g == null;
	}
}
