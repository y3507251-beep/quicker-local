using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common;

namespace Quicker.View.Controls;

public class SendTextActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	internal TextBoxWithToolsControl TxtText;

	internal CheckBox ChkUseClipboard;

	internal CheckBox ChkAppendReturn;

	private bool zawL46JDUxf;

	internal static SendTextActionParamEditor uZaORrFimWvBscJ7lyi8;

	public SendTextActionParamEditor()
	{
		InitializeComponent();
	}

	public override void SetData(ActionItem actionItem)
	{
		if (actionItem != null)
		{
			TxtText.Text = actionItem.Data;
			ChkAppendReturn.IsChecked = actionItem.Data2 == "true";
			ChkUseClipboard.IsChecked = actionItem.Data3 == "true";
			base.Dispatcher.InvokeAsync(V1vL4bcQi11);
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = TxtText.Text;
		actionItem.Data2 = ((ChkAppendReturn.IsChecked != true) ? "false" : "true");
		actionItem.Data3 = ((ChkUseClipboard.IsChecked == true) ? "true" : "false");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zawL46JDUxf)
		{
			zawL46JDUxf = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/sendtextactionparameditor.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			zawL46JDUxf = true;
			break;
		case 1:
			TxtText = (TextBoxWithToolsControl)target;
			break;
		case 2:
			ChkUseClipboard = (CheckBox)target;
			break;
		case 3:
			ChkAppendReturn = (CheckBox)target;
			break;
		}
	}

	[CompilerGenerated]
	private void V1vL4bcQi11()
	{
		TxtText.Focus();
	}

	internal static bool Np92CRFisAGIqGdJf7cY()
	{
		return uZaORrFimWvBscJ7lyi8 == null;
	}
}
