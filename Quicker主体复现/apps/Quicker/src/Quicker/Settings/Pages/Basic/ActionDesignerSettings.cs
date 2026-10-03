using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Extensions;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.X;

namespace Quicker.Settings.Pages.Basic;

public class ActionDesignerSettings : SettingPage, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public UserSettings kZlvhyPJbe6;

		internal static _003C_003Ec__DisplayClass3_0 GkGiDscfZfYVDCDMlfEC;

		internal bool tebvhPddPtb(SelectionItem x)
		{
			return x.Value == kZlvhyPJbe6.ToolboxSearchImeState.Or("NO_CONTROL");
		}

		internal bool EeUvhEyVD2k(SelectionItem x)
		{
			return x.Value == kZlvhyPJbe6.AfterEditRunningAction.ToString();
		}

		internal static bool ebPQfKcf58UDosbJSUoi()
		{
			return GkGiDscfZfYVDCDMlfEC == null;
		}
	}

	private IList<SelectionItem> hwqT9c2p5t = new ObservableCollection<SelectionItem>
	{
		new SelectionItem("0", "不操作"),
		new SelectionItem("1", "停止该动作"),
		new SelectionItem("2", "重启该动作")
	};

	private IList<SelectionItem> cccThJWAJO = new ObservableCollection<SelectionItem>
	{
		new SelectionItem(ActionMenuLayout.Auto.ToValueString(), "自动：自己创建或修改过的动作，“编辑”菜单在前面"),
		new SelectionItem(ActionMenuLayout.CustomMenuFirst.ToValueString(), "总是动作自定义菜单在前"),
		new SelectionItem(ActionMenuLayout.EditFirst.ToValueString(), "总是“编辑”菜单在前"),
		new SelectionItem(ActionMenuLayout.EditFirstIfRecentEdited.ToValueString(), "自动：一周内修改过的，“编辑”菜单在前")
	};

	internal ComboBox CbActionMenuLayout;

	internal CheckBox ChkEnableTreeTools;

	internal CheckBox ChkAutoGenerateIcon;

	internal ComboBox CbSearchImeState;

	internal ComboBox CbOperationOfRunningAction;

	internal BooleanSettingControl ChkEnableExpressionCompletion;

	internal BooleanSettingControl ChkEnableExpressionValidation;

	internal BooleanSettingControl ChkShowParamDescAsTooltip;

	internal BooleanSettingControl ToggleAutoBackupAction;

	internal BooleanSettingControl ToggleAutoBackupActionWhenEditing;

	internal Button BtnOpenBackupLocation;

	internal BooleanSettingControl ToggleAutoBackupActionState;

	internal TextBox TxtSelfHostCodeCompletionServiceUrl;

	private bool ThsTemaYR0;

	private static ActionDesignerSettings o0tpNh7bEsCBRIS575i;

	public ActionDesignerSettings()
	{
		InitializeComponent();
		CbSearchImeState.ItemsSource = AppImeHelper.SelectionItems;
		CbActionMenuLayout.ItemsSource = cccThJWAJO;
		CbOperationOfRunningAction.ItemsSource = hwqT9c2p5t;
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			ToggleAutoBackupActionState.IsChecked = false;
			ToggleAutoBackupActionState.IsEnabled = false;
			ToggleAutoBackupAction.IsChecked = false;
			ToggleAutoBackupAction.IsEnabled = false;
		}
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.kZlvhyPJbe6 = settings;
		UIHelper.TrySelectItemBySelectionItemValue(CbActionMenuLayout, _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.ActionMenuLayout.ToValueString(), true);
		ChkEnableTreeTools.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableTreeTools;
		ChkShowParamDescAsTooltip.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.ShowParamDescAsToolTip;
		ChkAutoGenerateIcon.IsChecked = !_003C_003Ec__DisplayClass3_.kZlvhyPJbe6.NewActionDefaultIcon.IsNullOrEmpty();
		ChkEnableExpressionCompletion.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableExpressionCompletion;
		if (xQ8rrt7qikRoH4joVhX())
		{
			switch (0)
			{
			}
		}
		ChkEnableExpressionValidation.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableExpressionValidation;
		ToggleAutoBackupAction.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableAutoBackupActions;
		ToggleAutoBackupActionWhenEditing.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableAutoBackupActionsWhenEditing;
		SelectionItem item = AppImeHelper.SelectionItems.FirstOrDefault(_003C_003Ec__DisplayClass3_.tebvhPddPtb);
		UIHelper.TrySelectItem(CbSearchImeState, item, true);
		SelectionItem item2 = hwqT9c2p5t.FirstOrDefault(_003C_003Ec__DisplayClass3_.EeUvhEyVD2k);
		UIHelper.TrySelectItem(CbOperationOfRunningAction, item2, true);
		TxtSelfHostCodeCompletionServiceUrl.Text = AppState.DataService.LocalSettings.CodeCompletionServer;
		ToggleAutoBackupActionState.IsChecked = _003C_003Ec__DisplayClass3_.kZlvhyPJbe6.EnableActionStateBackup == true;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ActionMenuLayout = CbActionMenuLayout.SelectedItem?.ToString().ToEnum<ActionMenuLayout>() ?? ActionMenuLayout.Auto;
		settings.EnableTreeTools = ChkEnableTreeTools.IsChecked == true;
		settings.ShowParamDescAsToolTip = ChkShowParamDescAsTooltip.IsChecked;
		settings.NewActionDefaultIcon = ((ChkAutoGenerateIcon.IsChecked == true) ? "auto" : "");
		if (o0tpNh7bEsCBRIS575i == null)
		{
			switch (0)
			{
			}
		}
		settings.EnableExpressionCompletion = ChkEnableExpressionCompletion.IsChecked;
		settings.EnableExpressionValidation = ChkEnableExpressionValidation.IsChecked;
		settings.EnableAutoBackupActions = ToggleAutoBackupAction.IsChecked;
		settings.EnableAutoBackupActionsWhenEditing = ToggleAutoBackupActionWhenEditing.IsChecked;
		SelectionItem obj = CbSearchImeState.SelectedItem as SelectionItem;
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.Value;
			if (obj2 != null)
			{
				goto IL_00f5;
			}
		}
		obj2 = "NO_CONTROL";
		goto IL_00f5;
		IL_00f5:
		settings.ToolboxSearchImeState = (string)obj2;
		SelectionItem obj3 = CbOperationOfRunningAction.SelectedItem as SelectionItem;
		object obj4;
		if (obj3 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = obj3.Value;
			if (obj4 != null)
			{
				goto IL_0120;
			}
		}
		obj4 = "0";
		goto IL_0120;
		IL_0120:
		settings.AfterEditRunningAction = int.Parse((string)obj4);
		settings.EnableActionStateBackup = ToggleAutoBackupActionState.IsChecked;
		AppState.DataService.LocalSettings.CodeCompletionServer = TxtSelfHostCodeCompletionServiceUrl.Text.Trim();
		AppState.DataService.DtNtXKQWDel();
		return true;
	}

	private void MNJTZj58sv(object sender, RoutedEventArgs e)
	{
		try
		{
			string backupFolder = ActionAutoBackup.GetBackupFolder();
			if (Directory.Exists(backupFolder))
			{
				Process.Start(backupFolder);
			}
			else
			{
				AppHelper.ShowInformation("文件夹尚不存在。请开启并生成动作备份后再打开。");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("打开文件夹出错：" + ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ThsTemaYR0)
		{
			ThsTemaYR0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/actiondesignersettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			ThsTemaYR0 = true;
			break;
		case 1:
			CbActionMenuLayout = (ComboBox)target;
			break;
		case 2:
			ChkEnableTreeTools = (CheckBox)target;
			break;
		case 3:
			ChkAutoGenerateIcon = (CheckBox)target;
			break;
		case 4:
			CbSearchImeState = (ComboBox)target;
			break;
		case 5:
			CbOperationOfRunningAction = (ComboBox)target;
			break;
		case 6:
			ChkEnableExpressionCompletion = (BooleanSettingControl)target;
			break;
		case 7:
			ChkEnableExpressionValidation = (BooleanSettingControl)target;
			break;
		case 8:
			ChkShowParamDescAsTooltip = (BooleanSettingControl)target;
			break;
		case 9:
			ToggleAutoBackupAction = (BooleanSettingControl)target;
			if (xQ8rrt7qikRoH4joVhX())
			{
				switch (0)
				{
				}
			}
			break;
		case 10:
			ToggleAutoBackupActionWhenEditing = (BooleanSettingControl)target;
			break;
		case 11:
			BtnOpenBackupLocation = (Button)target;
			BtnOpenBackupLocation.Click += MNJTZj58sv;
			break;
		case 12:
			ToggleAutoBackupActionState = (BooleanSettingControl)target;
			break;
		case 13:
			TxtSelfHostCodeCompletionServiceUrl = (TextBox)target;
			break;
		}
	}

	internal static bool xQ8rrt7qikRoH4joVhX()
	{
		return o0tpNh7bEsCBRIS575i == null;
	}
}
