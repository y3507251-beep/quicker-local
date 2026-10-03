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
using HandyControl.Controls;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.Settings.Pages.Basic.AutoTriggers;

public class StartupTaskEditWindow : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec eedvhDRFsPq;

		public static Func<string, bool> lrpvhd8fL0I;

		private static _003C_003Ec nRYUtkcbvKfRPxu7N3bd;

		static _003C_003Ec()
		{
			eedvhDRFsPq = new _003C_003Ec();
		}

		internal bool QYRvh5qBg16(string x)
		{
			return string.Equals(x, Environment.MachineName, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool SaWlAdcbdpptZ9XdWddO()
		{
			return nRYUtkcbvKfRPxu7N3bd == null;
		}
	}

	[CompilerGenerated]
	private AutoRunTask BxsMGoFeNN;

	internal ActionSelector ActionSelector;

	internal System.Windows.Controls.TextBox TxtActionParam;

	internal System.Windows.Controls.TextBox TxtBindingMachine;

	internal Button BtnAddCurrentMachine;

	internal NumericUpDown TxtDelay;

	internal System.Windows.Controls.TextBox TxtNote;

	internal CheckBox ChkEnable;

	internal CheckBox ChkOnlyAutoStartQuicker;

	internal CheckBox ChkOnlyFirstStartInSameDay;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool E7aMsJoQdc;

	internal static StartupTaskEditWindow DmHlI1hjVysX6OKmbZv;

	public AutoRunTask ResultTask
	{
		[CompilerGenerated]
		get
		{
			return BxsMGoFeNN;
		}
		[CompilerGenerated]
		set
		{
			BxsMGoFeNN = value;
		}
	}

	public StartupTaskEditWindow(AutoRunTask task)
	{
		InitializeComponent();
		gcUMI9Q80x(task);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void gcUMI9Q80x(AutoRunTask autoRunTask_1)
	{
		if (autoRunTask_1 != null)
		{
			ActionSelector.ActionIdOrName = autoRunTask_1.ActionIdOrName;
			TxtNote.Text = autoRunTask_1.Note;
			ChkEnable.IsChecked = autoRunTask_1.IsEnabled;
			TxtActionParam.Text = autoRunTask_1.ActionParam;
			int num = 0;
			if (DmHlI1hjVysX6OKmbZv != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TxtBindingMachine.Text = autoRunTask_1.ValidForMachines;
			TxtDelay.Value = autoRunTask_1.DelaySeconds;
			ChkOnlyFirstStartInSameDay.IsChecked = autoRunTask_1.OnlyFirstStartInSameDay;
			ChkOnlyAutoStartQuicker.IsChecked = autoRunTask_1.OnlyAutoRunQuicker;
		}
	}

	private void FkVMWnJ67Q(object sender, RoutedEventArgs e)
	{
		ResultTask = new AutoRunTask
		{
			TaskType = AutoRunTaskType.Start,
			ActionIdOrName = ActionSelector.ActionIdOrName,
			Data = "",
			IsEnabled = (ChkEnable.IsChecked == true),
			Note = TxtNote.Text,
			ActionParam = TxtActionParam.Text,
			ValidForMachines = TxtBindingMachine.Text,
			DelaySeconds = (int)TxtDelay.Value,
			OnlyFirstStartInSameDay = (ChkOnlyFirstStartInSameDay.IsChecked == true),
			OnlyAutoRunQuicker = (ChkOnlyAutoStartQuicker.IsChecked == true)
		};
		base.DialogResult = true;
	}

	private void DtGMkIqKYL(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(TxtBindingMachine.Text))
		{
			string[] array = TxtBindingMachine.Text.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Any(_003C_003Ec.lrpvhd8fL0I ?? (_003C_003Ec.lrpvhd8fL0I = _003C_003Ec.eedvhDRFsPq.QYRvh5qBg16)))
			{
				AppHelper.ShowInformation("您已添加当前主机。");
			}
			else
			{
				TxtBindingMachine.Text = string.Join(";", array) + ";" + Environment.MachineName;
			}
		}
		else
		{
			TxtBindingMachine.Text = Environment.MachineName;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!E7aMsJoQdc)
		{
			E7aMsJoQdc = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/autorun/startuptaskeditwindow.xaml", UriKind.Relative);
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
			E7aMsJoQdc = true;
			break;
		case 1:
			ActionSelector = (ActionSelector)target;
			break;
		case 2:
			TxtActionParam = (System.Windows.Controls.TextBox)target;
			break;
		case 3:
			TxtBindingMachine = (System.Windows.Controls.TextBox)target;
			break;
		case 4:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += DtGMkIqKYL;
			break;
		case 5:
			TxtDelay = (NumericUpDown)target;
			break;
		case 6:
			TxtNote = (System.Windows.Controls.TextBox)target;
			break;
		case 7:
			ChkEnable = (CheckBox)target;
			break;
		case 8:
			ChkOnlyAutoStartQuicker = (CheckBox)target;
			break;
		case 9:
		{
			ChkOnlyFirstStartInSameDay = (CheckBox)target;
			int num = 0;
			if (!APMrZ7hDUtNW5jZxA1K())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 10:
			BtnOk = (Button)target;
			BtnOk.Click += FkVMWnJ67Q;
			break;
		case 11:
			BtnCancel = (Button)target;
			break;
		}
	}

	static StartupTaskEditWindow()
	{
	}

	internal static bool APMrZ7hDUtNW5jZxA1K()
	{
		return DmHlI1hjVysX6OKmbZv == null;
	}

	internal static void sZsgKehvmJVRPnuL5kO()
	{
	}
}
