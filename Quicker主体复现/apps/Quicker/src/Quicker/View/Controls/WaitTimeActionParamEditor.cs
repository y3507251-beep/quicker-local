using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common;

namespace Quicker.View.Controls;

public class WaitTimeActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	private ActionItem yAwLnZ8DNY8;

	internal TextBox TxtWaitTime;

	private bool RmGLn9TbEuO;

	internal static WaitTimeActionParamEditor lSha9fFq7B6ncwPUE2KN;

	public WaitTimeActionParamEditor()
	{
		InitializeComponent();
	}

	public override void SetData(ActionItem actionItem)
	{
		yAwLnZ8DNY8 = actionItem;
		if (actionItem != null)
		{
			TxtWaitTime.Text = actionItem.Data;
		}
		else
		{
			TxtWaitTime.Text = "100";
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = TxtWaitTime.Text;
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (!Regex.IsMatch(TxtWaitTime.Text, "^\\d+$"))
		{
			return (isSuccess: false, message: "请输入一个数字。");
		}
		return (isSuccess: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!RmGLn9TbEuO)
		{
			RmGLn9TbEuO = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/waittimeactionparameditor.xaml", UriKind.Relative);
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
			TxtWaitTime = (TextBox)target;
		}
		else
		{
			RmGLn9TbEuO = true;
		}
	}

	internal static bool PJlgTsFq449PbW0Pon7b()
	{
		return lSha9fFq7B6ncwPUE2KN == null;
	}
}
