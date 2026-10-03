using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Settings.Pages.Basic.AutoTriggers;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.Settings.Pages.Basic;

public class EventTriggersSettingPage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GCwvhusvYwu;

		public static Func<CommonTriggerTask, ObservableCommonTriggerTask> RAAvhNjHRjt;

		public static Func<ObservableCommonTriggerTask, CommonTriggerTask> zrxvhJBNA4N;

		public static Func<ObservableCommonTriggerTask, CommonTriggerTask> fW6vh0rLFx0;

		public static Func<ObservableCommonTriggerTask, string> MDvvhCOfIsn;

		internal static _003C_003Ec fkH2oCcfot0JcHuhatVZ;

		static _003C_003Ec()
		{
			GCwvhusvYwu = new _003C_003Ec();
		}

		internal ObservableCommonTriggerTask WvJvhLpCSdh(CommonTriggerTask x)
		{
			return new ObservableCommonTriggerTask(x);
		}

		internal CommonTriggerTask LGHvhvIB5oo(ObservableCommonTriggerTask x)
		{
			return x.Value;
		}

		internal CommonTriggerTask H7NvhSKvdIj(ObservableCommonTriggerTask x)
		{
			return x.Value;
		}

		internal string KeOvh2BFOek(ObservableCommonTriggerTask x)
		{
			return x.EventTypeDesc;
		}

		internal static bool jnsffucffyN4ywUdF42f()
		{
			return fkH2oCcfot0JcHuhatVZ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNewTask_OnClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EventTriggersSettingPage _003C_003E4__this;

		private EventTriggerTaskEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object WQWsBQcfqxaEpfCTvuK9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EventTriggersSettingPage eventTriggersSettingPage = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00ee;
				}
				{
					_003Cdlg_003E5__2 = new EventTriggerTaskEditorWindow(null);
					_003Cdlg_003E5__2.Owner = Window.GetWindow(eventTriggersSettingPage);
					int num2 = 1;
					if (WQWsBQcfqxaEpfCTvuK9 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					do
					{
						switch (num2)
						{
						case 1:
							goto IL_0073;
						}
						break;
						IL_0073:
						awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
						num2 = 0;
					}
					while (kBxAalcfiqHSqwnMsU25());
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00ee;
				}
				goto end_IL_0010;
				IL_00ee:
				if (awaiter.GetResult() == true)
				{
					eventTriggersSettingPage.g4sTqBiDpP.Add(new ObservableCommonTriggerTask(_003Cdlg_003E5__2.ResultTask));
				}
				eventTriggersSettingPage.uTZTN08imV();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool kBxAalcfiqHSqwnMsU25()
		{
			return WQWsBQcfqxaEpfCTvuK9 == null;
		}
	}

	private string CrrTRHZjZq;

	private SmartCollection<ObservableCommonTriggerTask> g4sTqBiDpP = new SmartCollection<ObservableCommonTriggerTask>();

	internal ListView LvActions;

	internal StackPanel PnlButtons;

	internal Button BtnNew;

	internal Button BtnCopyData;

	internal Button BtnPasteData;

	internal Button BtnSortByEventType;

	internal TextBlock LblVersionInfo;

	private bool i6MTcMWKKO;

	private static EventTriggersSettingPage gbRuQK7vNcJPdjNChKl;

	public EventTriggersSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		if (settings.TriggerTasks != null)
		{
			CrrTRHZjZq = JsonConvert.SerializeObject(settings.TriggerTasks);
			g4sTqBiDpP.Reset(settings.TriggerTasks.Select(_003C_003Ec.RAAvhNjHRjt ?? (_003C_003Ec.RAAvhNjHRjt = _003C_003Ec.GCwvhusvYwu.WvJvhLpCSdh)));
		}
		LvActions.ItemsSource = g4sTqBiDpP;
	}

	private void uTZTN08imV()
	{
		{
			PnlButtons.IsEnabled = true;
			BtnPasteData.IsEnabled = true;
		}
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.TriggerTasks = g4sTqBiDpP.Select(_003C_003Ec.zrxvhJBNA4N ?? (_003C_003Ec.zrxvhJBNA4N = _003C_003Ec.GCwvhusvYwu.LGHvhvIB5oo)).ToList();
		return true;
	}

	private void tjETJNQIle(object sender, RoutedEventArgs e)
	{
	}

	private void P2RT07mCxM(object sender, RoutedEventArgs e)
	{
		ObservableCommonTriggerTask observableCommonTriggerTask_ = (sender as FrameworkElement).Tag as ObservableCommonTriggerTask;
		VRjTCWa3ER(observableCommonTriggerTask_);
	}

	private void VRjTCWa3ER(ObservableCommonTriggerTask observableCommonTriggerTask_0)
	{
		if (observableCommonTriggerTask_0 != null)
		{
			if (AppState.uICt7cXc7Qs().QS1f3oYkWA(observableCommonTriggerTask_0.EventType) == null)
			{
				AppHelper.ShowWarning("您的Windows或Quicker版本不支持此事件。");
				return;
			}
			EventTriggerTaskEditorWindow eventTriggerTaskEditorWindow = new EventTriggerTaskEditorWindow(observableCommonTriggerTask_0.Value);
			eventTriggerTaskEditorWindow.Owner = Window.GetWindow(this);
			if (eventTriggerTaskEditorWindow.ShowDialog() == true)
			{
				CommonTriggerTask resultTask = eventTriggerTaskEditorWindow.ResultTask;
				resultTask.Id = observableCommonTriggerTask_0.Value.Id;
				resultTask.LastEditTimeUtc = DateTime.UtcNow;
				int num = 0;
				if (gbRuQK7vNcJPdjNChKl != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				g4sTqBiDpP.Replace(observableCommonTriggerTask_0, new ObservableCommonTriggerTask(resultTask));
			}
		}
		else
		{
			AppHelper.ShowWarning("请选择要编辑的条目。");
		}
	}

	private void r0bTPawMTy(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要删除这个任务么？") && (sender as FrameworkElement).Tag is ObservableCommonTriggerTask item)
		{
			g4sTqBiDpP.Remove(item);
			uTZTN08imV();
		}
	}

	private void ShbTECl7Id(object sender, MouseButtonEventArgs e)
	{
		ObservableCommonTriggerTask observableCommonTriggerTask_ = ((ListViewItem)sender).Content as ObservableCommonTriggerTask;
		VRjTCWa3ER(observableCommonTriggerTask_);
	}

	[AsyncStateMachine(typeof(_003CBtnNewTask_OnClick_003Ed__11))]
	private void s87Tyo1SJ9(object sender, RoutedEventArgs e)
	{
		_003CBtnNewTask_OnClick_003Ed__11 stateMachine = default(_003CBtnNewTask_OnClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void uEtT8xPUE8(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要复制的条目。");
			return;
		}
		string text = LvActions.SelectedItems.Cast<ObservableCommonTriggerTask>().Select(_003C_003Ec.fW6vh0rLFx0 ?? (_003C_003Ec.fW6vh0rLFx0 = _003C_003Ec.GCwvhusvYwu.H7NvhSKvdIj)).ToList()
			.ToJson(true, true);
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

	private void dOYTapmCWh(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			if (!string.IsNullOrWhiteSpace(text))
			{
				text = text.Trim();
				if (text.StartsWith("["))
				{
					IList<CommonTriggerTask> list = default(IList<CommonTriggerTask>);
					if (!text.EndsWith("]"))
					{
						int num = 0;
						if (!HZYxEE7do3YtJMlgB8d())
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						case 1:
							break;
						default:
							goto IL_013e;
						}
					}
					else
					{
						list = null;
						try
						{
							list = JsonConvert.DeserializeObject<IList<CommonTriggerTask>>(text);
						}
						catch (Exception exception)
						{
							AppHelper.ShowWarning("解析数据出错：" + exception.GetMessageWithInner());
							return;
						}
						if (list.Count == 0)
						{
							AppHelper.ShowWarning("数据格式不正确！");
							return;
						}
					}
					foreach (CommonTriggerTask item in list)
					{
						item.Id = Guid.NewGuid();
						g4sTqBiDpP.Add(new ObservableCommonTriggerTask(item));
					}
					AppHelper.ShowSuccess($"已成功粘贴 {list.Count} 项，请检查是否有重复的规则。");
					return;
				}
				goto IL_013e;
			}
			AppHelper.ShowWarning("剪贴板里没有文本数据。");
			return;
			IL_013e:
			AppHelper.ShowWarning("剪贴板中没有符合要求的内容。");
		}
		catch (Exception exception2)
		{
			AppHelper.ShowWarning("粘贴出错：" + exception2.GetMessageWithInner());
		}
	}

	private void zPQT7DYItg(object sender, RoutedEventArgs e)
	{
		g4sTqBiDpP.Reset(g4sTqBiDpP.OrderBy(_003C_003Ec.MDvvhCOfIsn ?? (_003C_003Ec.MDvvhCOfIsn = _003C_003Ec.GCwvhusvYwu.KeOvh2BFOek)).ToList());
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!i6MTcMWKKO)
		{
			i6MTcMWKKO = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/events/eventtriggerssettingpage.xaml", UriKind.Relative);
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
			i6MTcMWKKO = true;
			break;
		case 5:
			PnlButtons = (StackPanel)target;
			break;
		case 6:
			BtnNew = (Button)target;
			BtnNew.Click += s87Tyo1SJ9;
			break;
		case 7:
			BtnCopyData = (Button)target;
			BtnCopyData.Click += uEtT8xPUE8;
			break;
		case 8:
		{
			BtnPasteData = (Button)target;
			BtnPasteData.Click += dOYTapmCWh;
			int num = 0;
			if (!HZYxEE7do3YtJMlgB8d())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 9:
			BtnSortByEventType = (Button)target;
			BtnSortByEventType.Click += zPQT7DYItg;
			break;
		case 10:
			LblVersionInfo = (TextBlock)target;
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			((Button)target).Click += P2RT07mCxM;
			break;
		case 3:
			((Button)target).Click += r0bTPawMTy;
			break;
		case 4:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(ShbTECl7Id);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	internal static bool HZYxEE7do3YtJMlgB8d()
	{
		return gbRuQK7vNcJPdjNChKl == null;
	}
}
