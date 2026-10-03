using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.Settings.Pages.Basic.AutoTriggers;

public class AutoRunTaskEditorWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ku3vhTrZJKi;

		public static Func<string, bool> mF4vhMcws66;

		private static _003C_003Ec yKEMTMcbJ4dtq07EBHCJ;

		static _003C_003Ec()
		{
			Ku3vhTrZJKi = new _003C_003Ec();
		}

		internal bool HLSvhotDVbv(string x)
		{
			return string.Equals(x, Environment.MachineName, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool jTscJ6cbkeTnKA4p6iyY()
		{
			return yKEMTMcbJ4dtq07EBHCJ == null;
		}
	}

	[CompilerGenerated]
	private AutoRunTask RI9M6P2aa1;

	internal CronEditor CronEditor;

	internal ActionSelector ActionSelector;

	internal TextBox TxtActionParam;

	internal TextBox TxtBindingMachine;

	internal Button BtnAddCurrentMachine;

	internal TextBox TxtNote;

	internal CheckBox ChkEnable;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool D1DMXtEbMG;

	private static AutoRunTaskEditorWindow TvU5eAhdorxaJ1840Tt;

	public AutoRunTask ResultTask
	{
		[CompilerGenerated]
		get
		{
			return RI9M6P2aa1;
		}
		[CompilerGenerated]
		set
		{
			RI9M6P2aa1 = value;
		}
	}

	public AutoRunTaskEditorWindow(AutoRunTask task)
	{
		InitializeComponent();
		W0cMHSxDfI(task);
	}

	private void W0cMHSxDfI(AutoRunTask autoRunTask_1)
	{
		if (autoRunTask_1 == null)
		{
			CronEditor.SetExpression("0 * * * *");
			return;
		}
		CronEditor.SetExpression(autoRunTask_1.Data);
		ActionSelector.ActionIdOrName = autoRunTask_1.ActionIdOrName;
		TxtNote.Text = autoRunTask_1.Note;
		ChkEnable.IsChecked = autoRunTask_1.IsEnabled;
		TxtActionParam.Text = autoRunTask_1.ActionParam;
		TxtBindingMachine.Text = autoRunTask_1.ValidForMachines;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void xleM1Advp8(object sender, RoutedEventArgs e)
	{
		ResultTask = new AutoRunTask
		{
			TaskType = AutoRunTaskType.Timer,
			ActionIdOrName = ActionSelector.ActionIdOrName,
			Data = CronEditor.GetExpression(),
			IsEnabled = (ChkEnable.IsChecked == true),
			Note = TxtNote.Text,
			ActionParam = TxtActionParam.Text,
			ValidForMachines = TxtBindingMachine.Text
		};
		base.DialogResult = true;
	}

	private void N5yMbOtDSM(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtBindingMachine.Text))
		{
			TxtBindingMachine.Text = Environment.MachineName;
			return;
		}
		string[] array = TxtBindingMachine.Text.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Any(_003C_003Ec.mF4vhMcws66 ?? (_003C_003Ec.mF4vhMcws66 = _003C_003Ec.Ku3vhTrZJKi.HLSvhotDVbv)))
		{
			AppHelper.ShowInformation("您已添加当前主机。");
		}
		else
		{
			TxtBindingMachine.Text = string.Join(";", array) + ";" + Environment.MachineName;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!D1DMXtEbMG)
		{
			D1DMXtEbMG = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/autorun/autoruntaskeditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			D1DMXtEbMG = true;
			break;
		case 1:
			CronEditor = (CronEditor)target;
			break;
		case 2:
			ActionSelector = (ActionSelector)target;
			if (pP5rWphOS9cu2FBwh5i())
			{
				switch (0)
				{
				}
			}
			break;
		case 3:
			TxtActionParam = (TextBox)target;
			break;
		case 4:
			TxtBindingMachine = (TextBox)target;
			break;
		case 5:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += N5yMbOtDSM;
			break;
		case 6:
			TxtNote = (TextBox)target;
			break;
		case 7:
			ChkEnable = (CheckBox)target;
			break;
		case 8:
			BtnOk = (Button)target;
			BtnOk.Click += xleM1Advp8;
			break;
		case 9:
			BtnCancel = (Button)target;
			break;
		}
	}

	internal static bool pP5rWphOS9cu2FBwh5i()
	{
		return TvU5eAhdorxaJ1840Tt == null;
	}
}
