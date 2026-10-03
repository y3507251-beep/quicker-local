using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.View.Controls;

namespace Quicker.View.X.StepEditor.ParamEditors.ParamControls;

public class EnumParamValueControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string scKLHKVZHok;

	internal IconControl IconControl;

	internal TextBlock LblValueDesc;

	internal TextBlock LblValue;

	private bool gCoLHxTEbUT;

	internal static EnumParamValueControl yQJ8GwFr1WyAKuKDDO0c;

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return scKLHKVZHok;
		}
		[CompilerGenerated]
		set
		{
			scKLHKVZHok = value;
		}
	}

	public EnumParamValueControl()
	{
		InitializeComponent();
	}

	public void SetValueInfo(string value, string desc, string icon)
	{
		LblValueDesc.Text = desc;
		LblValue.Text = (string.Equals(value, desc) ? "" : value);
		Value = value;
		if (!string.IsNullOrEmpty(icon))
		{
			IconControl iconControl = IconControl;
			IconControl iconControl2 = IconControl;
			double width = 16.0;
			iconControl2.Height = 16.0;
			iconControl.Width = width;
			IconControl.Icon = icon;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!gCoLHxTEbUT)
		{
			gCoLHxTEbUT = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/paramcontrols/enumparamvaluecontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			gCoLHxTEbUT = true;
			break;
		case 1:
			IconControl = (IconControl)target;
			break;
		case 2:
			LblValueDesc = (TextBlock)target;
			break;
		case 3:
			LblValue = (TextBlock)target;
			break;
		}
	}

	internal static bool xYm7RMFrKWG0LSV1jnOm()
	{
		return yQJ8GwFr1WyAKuKDDO0c == null;
	}
}
