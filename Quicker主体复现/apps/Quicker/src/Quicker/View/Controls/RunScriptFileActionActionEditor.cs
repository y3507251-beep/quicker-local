using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;

namespace Quicker.View.Controls;

public class RunScriptFileActionActionEditor : BaseActionParamEditor, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public RunScriptActionParam Bp9S3ERLRq1;

		private static _003C_003Ec__DisplayClass5_0 b7N4KQypYv5rYCYrQbq0;

		internal bool O0DS3CGSSWR(SelectionItem x)
		{
			return x.Value.Equals(Bp9S3ERLRq1.Type, StringComparison.OrdinalIgnoreCase);
		}

		internal bool EYnS3PIvTJq(SelectionItem x)
		{
			return x.Value.Equals(Bp9S3ERLRq1.Encoding, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool EfZvMLyp8gnSFO0NiuQ1()
		{
			return b7N4KQypYv5rYCYrQbq0 == null;
		}
	}

	private static readonly IList<SelectionItem> suULQFtaqjj;

	private static readonly IList<SelectionItem> b33LQU2Q2Bw;

	private ActionItem V4DLQlvNYSS;

	internal TextBoxWithToolsControl TxtScript;

	internal ComboBox CbType;

	internal TextBox TxtExt;

	internal ComboBox CbEncoding;

	internal TextBox TxtWorkingDir;

	internal CheckBox ChkRunAsAdmin;

	internal CheckBox ChkWaitForExit;

	private bool uagLQiDR691;

	internal static RunScriptFileActionActionEditor uRKubaFbME6SIxPAqfGa;

	public RunScriptFileActionActionEditor()
	{
		InitializeComponent();
		TxtExt.Text = ".bat";
		CbType.ItemsSource = suULQFtaqjj;
		CbEncoding.ItemsSource = b33LQU2Q2Bw;
	}

	private void Y1tLQOvbA1r(object sender, RoutedEventArgs e)
	{
		string text = (sender as MenuItem).Tag as string;
		TxtExt.Text = text;
	}

	public override void SetData(ActionItem actionItem)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		V4DLQlvNYSS = actionItem;
		if (string.IsNullOrEmpty(actionItem.Data))
		{
			return;
		}
		_003C_003Ec__DisplayClass5_.Bp9S3ERLRq1 = JsonConvert.DeserializeObject<RunScriptActionParam>(actionItem.Data);
		if (uRKubaFbME6SIxPAqfGa != null)
		{
			switch (0)
			{
			}
		}
		TxtScript.Text = _003C_003Ec__DisplayClass5_.Bp9S3ERLRq1.Script;
		TxtExt.Text = _003C_003Ec__DisplayClass5_.Bp9S3ERLRq1.Ext;
		ChkRunAsAdmin.IsChecked = _003C_003Ec__DisplayClass5_.Bp9S3ERLRq1.RunAsAdmin;
		CbType.SelectedItem = suULQFtaqjj.FirstOrDefault(_003C_003Ec__DisplayClass5_.O0DS3CGSSWR);
		CbEncoding.SelectedItem = b33LQU2Q2Bw.FirstOrDefault(_003C_003Ec__DisplayClass5_.EYnS3PIvTJq);
		TxtWorkingDir.Text = _003C_003Ec__DisplayClass5_.Bp9S3ERLRq1.WorkingDir;
	}

	public override void SaveData(ActionItem actionItem)
	{
		RunScriptActionParam value = new RunScriptActionParam
		{
			Script = TxtScript.Text,
			Type = (CbType.SelectedItem as SelectionItem)?.Value,
			Ext = TxtExt.Text,
			RunAsAdmin = (ChkRunAsAdmin.IsChecked == true),
			WaitForExit = false,
			Encoding = (CbEncoding.SelectedItem as SelectionItem)?.Value,
			WorkingDir = TxtWorkingDir.Text
		};
		actionItem.Data = JsonConvert.SerializeObject(value);
		actionItem.Data2 = "";
		actionItem.Data3 = "";
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (CbType.SelectedItem == null)
		{
			return (isSuccess: false, message: "请选择脚本类型");
		}
		if (!string.IsNullOrEmpty(TxtExt.Text) && TxtExt.Text.StartsWith(".", StringComparison.OrdinalIgnoreCase))
		{
			if (string.IsNullOrEmpty(TxtScript.Text))
			{
				return (isSuccess: false, message: "脚本内容为空。");
			}
			return (isSuccess: true, message: "");
		}
		return (isSuccess: false, message: "扩展名格式不合法。请参考示例：.bat");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!uagLQiDR691)
		{
			uagLQiDR691 = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/runscriptfileactionactioneditor.xaml", UriKind.Relative);
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
			uagLQiDR691 = true;
			break;
		case 1:
			TxtScript = (TextBoxWithToolsControl)target;
			break;
		case 2:
			CbType = (ComboBox)target;
			break;
		case 3:
			TxtExt = (TextBox)target;
			break;
		case 4:
			CbEncoding = (ComboBox)target;
			break;
		case 5:
		{
			TxtWorkingDir = (TextBox)target;
			int num = 0;
			if (uRKubaFbME6SIxPAqfGa != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 6:
			ChkRunAsAdmin = (CheckBox)target;
			break;
		case 7:
			ChkWaitForExit = (CheckBox)target;
			break;
		}
	}

	static RunScriptFileActionActionEditor()
	{
		suULQFtaqjj = new List<SelectionItem>
		{
			new SelectionItem("CMD_K", "CMD命令 (完成后保留窗口)"),
			new SelectionItem("CMD_C", "CMD命令 (完成后关闭窗口)"),
			new SelectionItem("CMD_H", "CMD命令 (隐藏命令行窗口)"),
			new SelectionItem("BAT", "BAT批处理脚本(.bat)"),
			new SelectionItem("CMD_F", "CMD批处理脚本(.cmd)"),
			new SelectionItem("PS", "PowerShell脚本(.ps1)"),
			new SelectionItem("AHK", "AutoHotKey脚本(.ahk)"),
			new SelectionItem("CUSTOM", "自定义脚本类型")
		};
		b33LQU2Q2Bw = new List<SelectionItem>
		{
			new SelectionItem(Encoding.UTF8.WebName, "UTF8 (有BOM)"),
			new SelectionItem("UTF8-NOBOM", "UTF8 (无BOM)"),
			new SelectionItem(Encoding.Unicode.WebName, "UTF-16 LE"),
			new SelectionItem(Encoding.BigEndianUnicode.WebName, "UTF-16 BE"),
			new SelectionItem(Encoding.ASCII.WebName, "ASCII"),
			new SelectionItem(Encoding.UTF7.WebName, "UTF7"),
			new SelectionItem(Encoding.UTF32.WebName, "UTF32"),
			new SelectionItem("default", "系统默认(" + Encoding.Default.WebName + ")")
		};
	}

	internal static void csCHfIFbILQFPJMJaO6c()
	{
	}

	internal static bool zTB6XGFbUKooP76RePlk()
	{
		return uRKubaFbME6SIxPAqfGa == null;
	}
}
