using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Settings.Pages.Basic.AutoTriggers;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace Quicker.Settings.Pages.Basic;

public class AutoRunSettings : SettingPage, IComponentConnector, IStyleConnector
{
	private string hXNTBGApl8;

	private string mw5TQE8TMZ;

	private SmartCollection<AutoRunTask> C1iTjHS65P = new SmartCollection<AutoRunTask>();

	internal ListView LvActions;

	internal StackPanel PnlButtons;

	internal Button BtnNew;

	internal Button BtnNewStartTask;

	internal Button BtnCopyData;

	internal Button BtnPasteData;

	internal TextBlock LblVersionInfo;

	private bool GYVTnfiHqd;

	internal static AutoRunSettings dKSAxh4Qr8JrEXvpVAv;

	public AutoRunSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		int num = 1;
		while (true)
		{
			hXNTBGApl8 = settings.AutoRunTasks;
			int num2 = 0;
			if (dKSAxh4Qr8JrEXvpVAv != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (settings.AutoRunTaskList != null)
			{
				mw5TQE8TMZ = JsonConvert.SerializeObject(settings.AutoRunTaskList);
			}
			if (settings.AutoRunTaskList == null)
			{
				C1iTjHS65P.Reset(AutoRunService.TryParseOldData(hXNTBGApl8));
			}
			else
			{
				C1iTjHS65P.Reset(settings.AutoRunTaskList);
			}
			LvActions.ItemsSource = C1iTjHS65P;
			return;
		}
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.AutoRunTaskList = C1iTjHS65P.ToList();
		return true;
	}

	private void iqbTsg4Cgb(object sender, RoutedEventArgs e)
	{
	}

	private void dukTHy2OMh(object sender, RoutedEventArgs e)
	{
		AutoRunTask autoRunTask_ = (sender as FrameworkElement).Tag as AutoRunTask;
		p0vT1PAHI2(autoRunTask_);
	}

	private void p0vT1PAHI2(AutoRunTask autoRunTask_0)
	{
		while (autoRunTask_0 != null)
		{
			if (!uU1jBe4F3fEilKt0Iou())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			if (autoRunTask_0.TaskType == AutoRunTaskType.Timer)
			{
				AutoRunTaskEditorWindow autoRunTaskEditorWindow = new AutoRunTaskEditorWindow(autoRunTask_0)
				{
					Owner = Window.GetWindow(this)
				};
				if (autoRunTaskEditorWindow.ShowDialog() == true)
				{
					C1iTjHS65P.Replace(autoRunTask_0, autoRunTaskEditorWindow.ResultTask);
				}
			}
			else if (autoRunTask_0.TaskType == AutoRunTaskType.Start)
			{
				StartupTaskEditWindow startupTaskEditWindow = new StartupTaskEditWindow(autoRunTask_0)
				{
					Owner = Window.GetWindow(this)
				};
				if (startupTaskEditWindow.ShowDialog() == true)
				{
					C1iTjHS65P.Replace(autoRunTask_0, startupTaskEditWindow.ResultTask);
				}
			}
			else
			{
				AppHelper.ShowWarning("不支持的任务类型。");
			}
			break;
		}
	}

	private void QM3TbvoQBG(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要删除这个任务么？") && (sender as FrameworkElement).Tag is AutoRunTask item)
		{
			C1iTjHS65P.Remove(item);
		}
	}

	private void Cg0T6UKHY0(object sender, MouseButtonEventArgs e)
	{
		AutoRunTask autoRunTask_ = ((ListViewItem)sender).Content as AutoRunTask;
		p0vT1PAHI2(autoRunTask_);
	}

	private void swKTXnEHjV(object sender, RoutedEventArgs e)
	{
		AutoRunTaskEditorWindow autoRunTaskEditorWindow = new AutoRunTaskEditorWindow(null);
		autoRunTaskEditorWindow.Owner = Window.GetWindow(this);
		if (autoRunTaskEditorWindow.ShowDialog() == true)
		{
			C1iTjHS65P.Add(autoRunTaskEditorWindow.ResultTask);
		}
	}

	private void GcITmO9HTq(object sender, RoutedEventArgs e)
	{
		StartupTaskEditWindow startupTaskEditWindow = new StartupTaskEditWindow(null);
		startupTaskEditWindow.Owner = Window.GetWindow(this);
		if (startupTaskEditWindow.ShowDialog() == true)
		{
			C1iTjHS65P.Add(startupTaskEditWindow.ResultTask);
		}
	}

	private void EhuTKbf7Xh(object sender, RoutedEventArgs e)
	{
		UserSettings userSettings = AppState.HHxtaMaoqJr();
		object obj;
		if (userSettings == null)
		{
			obj = null;
		}
		else
		{
			obj = userSettings.AutoRunTasks;
			if (obj != null)
			{
				goto IL_0029;
			}
		}
		obj = "";
		goto IL_0029;
		IL_0029:
		UserInputWindow userInputWindow = new UserInputWindow("multiline", "导入旧版数据", "", (string)obj);
		userInputWindow.IsRequired = true;
		userInputWindow.Owner = Window.GetWindow(this);
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string textValue = userInputWindow.TextValue;
		try
		{
			IList<AutoRunTask> list = AutoRunService.TryParseOldData(textValue);
			if (list.Count < 1)
			{
				AppHelper.ShowWarning("未成功解析出任务，请确保内容格式合法。");
				return;
			}
			C1iTjHS65P.AddRange(list);
			AppHelper.ShowSuccess($"共导入 {list.Count} 条任务。");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("导入出错：" + exception.GetMessageWithInner(), true);
		}
	}

	private void H0HTxlAMyY(object sender, RoutedEventArgs e)
	{
	}

	private void lwUTrVF5Ks(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要复制的条目。");
			return;
		}
		string text = LvActions.SelectedItems.Cast<AutoRunTask>().ToList().ToJson(true, true);
		try
		{
			ClipboardHelper.SetText(text);
			AppHelper.ShowInformation("已复制。");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("复制出错，请重试。" + exception.GetMessageWithInner());
		}
	}

	private void YtITpkmknW(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			if (string.IsNullOrWhiteSpace(text))
			{
				AppHelper.ShowWarning("剪贴板里没有文本数据。");
				return;
			}
			text = text.Trim();
			if (text.StartsWith("[") && text.EndsWith("]"))
			{
				IList<AutoRunTask> list = null;
				try
				{
					list = JsonConvert.DeserializeObject<IList<AutoRunTask>>(text);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("解析数据出错：" + exception.GetMessageWithInner());
					return;
				}
				if (list.Count == 0)
				{
					AppHelper.ShowWarning("数据格式不正确！");
					if (!uU1jBe4F3fEilKt0Iou())
					{
						return;
					}
					switch (0)
					{
					default:
						return;
					case 1:
						break;
					}
				}
				else
				{
					foreach (AutoRunTask item in list)
					{
						C1iTjHS65P.Add(item);
					}
				}
				AppHelper.ShowSuccess($"已成功粘贴 {list.Count} 项，请检查是否有重复的规则。");
			}
			else
			{
				AppHelper.ShowWarning("剪贴板中没有符合要求的内容。");
			}
		}
		catch (Exception exception2)
		{
			AppHelper.ShowWarning("粘贴出错：" + exception2.GetMessageWithInner());
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!GYVTnfiHqd)
		{
			GYVTnfiHqd = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/autorun/autorunsettings.xaml", UriKind.Relative);
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
		case 1:
			LvActions = (ListView)target;
			break;
		default:
			GYVTnfiHqd = true;
			break;
		case 6:
			PnlButtons = (StackPanel)target;
			break;
		case 7:
		{
			BtnNew = (Button)target;
			int num = 0;
			if (dKSAxh4Qr8JrEXvpVAv != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnNew.Click += swKTXnEHjV;
				break;
			}
			break;
		}
		case 8:
			BtnNewStartTask = (Button)target;
			BtnNewStartTask.Click += GcITmO9HTq;
			break;
		case 9:
			BtnCopyData = (Button)target;
			BtnCopyData.Click += lwUTrVF5Ks;
			break;
		case 10:
			BtnPasteData = (Button)target;
			BtnPasteData.Click += YtITpkmknW;
			break;
		case 11:
			LblVersionInfo = (TextBlock)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			((CheckBox)target).Click += H0HTxlAMyY;
			break;
		case 3:
			((Button)target).Click += dukTHy2OMh;
			break;
		case 4:
			((Button)target).Click += QM3TbvoQBG;
			break;
		case 5:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(Cg0T6UKHY0);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	internal static bool uU1jBe4F3fEilKt0Iou()
	{
		return dKSAxh4Qr8JrEXvpVAv == null;
	}
}
