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
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using HandyControl.Controls;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Settings.Pages.Features;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.View.ConfigWindowControls;
using WcdJQYXW9E2moeWW9Np;
using Yf8A0Tj55ce1jngb1h3;

namespace Quicker.Settings.Pages.Basic;

public class SearchSettingsPage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec B5Ivhk9RVEC;

		public static Func<QuickRunItem, string> wDPvhGlBdZC;

		public static Func<PluginSettingListItem, string> ubqvhsRDwbd;

		public static Func<PluginSettingListItem, SearchPluginSettings> yt5vhHDXERc;

		public static Func<SearchPlugin, SearchPluginSettings> OfBvh1I7jnd;

		private static _003C_003Ec oWPRJ9cfTU9yR69FF4IW;

		static _003C_003Ec()
		{
			B5Ivhk9RVEC = new _003C_003Ec();
		}

		internal string QUjvheSqIJb(QuickRunItem x)
		{
			return x.CmdText;
		}

		internal string IM4vhYDcjwW(PluginSettingListItem x)
		{
			return x.PluginName;
		}

		internal SearchPluginSettings PSGvhImKhum(PluginSettingListItem x)
		{
			return x.Settings;
		}

		internal SearchPluginSettings TeTvhWppMOV(SearchPlugin x)
		{
			return x.DefaultSettings;
		}

		internal static bool vLDuRTcfmT4NRD1AZjXQ()
		{
			return oWPRJ9cfTU9yR69FF4IW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public UserSettings NfFvhX28i1H;

		internal static _003C_003Ec__DisplayClass10_0 LGiANFcfC3Amb1crIJvL;

		internal bool xQxvhbsrL2e(SelectionItem x)
		{
			return x.Value == NfFvhX28i1H.SearchSettings.ImeControl.Or("NO_CONTROL");
		}

		internal bool nWivh6KO2uA(SelectionItem x)
		{
			return x.Value == NfFvhX28i1H.SearchSettings.HintTriggerKey.ToString();
		}

		internal static bool m4IwFJcf7pJ0E7lwXqet()
		{
			return LGiANFcfC3Amb1crIJvL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public SearchPlugin vyPvhKqOh57;

		internal static _003C_003Ec__DisplayClass11_0 qS635Rcfh1nkygrtljgE;

		internal bool XKrvhmAT16w(SearchPluginSettings x)
		{
			return x.PluginId == vyPvhKqOh57.Id;
		}

		internal static bool cDJOnscfHItB15QnOy5K()
		{
			return qS635Rcfh1nkygrtljgE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnConfigPlugin_OnClick_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public SearchSettingsPage _003C_003E4__this;

		private PluginSettingListItem _003CpluginSetting_003E5__2;

		private SearchPluginSettingsWindow _003Cdlg_003E5__3;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object Xv0GFocbQZZvuiAOtm7M;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SearchSettingsPage searchSettingsPage = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003CpluginSetting_003E5__2 = (sender as Button).Tag as PluginSettingListItem;
					_003Cdlg_003E5__3 = new SearchPluginSettingsWindow(_003CpluginSetting_003E5__2.Settings, _003CpluginSetting_003E5__2.Plugin);
					_003Cdlg_003E5__3.Owner = System.Windows.Window.GetWindow(searchSettingsPage);
					awaiter = _003Cdlg_003E5__3.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					while (true)
					{
						awaiter = _003C_003Eu__1;
						if (Xv0GFocbQZZvuiAOtm7M == null)
						{
							switch (1)
							{
							default:
								continue;
							case 1:
								break;
							}
						}
						break;
					}
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					searchSettingsPage.PluginItems.Replace(_003CpluginSetting_003E5__2, new PluginSettingListItem(_003CpluginSetting_003E5__2.Plugin, _003Cdlg_003E5__3.ResultSettings));
					if (!searchSettingsPage.EKiM2jcRph.Contains(_003CpluginSetting_003E5__2.Plugin))
					{
						searchSettingsPage.EKiM2jcRph.Add(_003CpluginSetting_003E5__2.Plugin);
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CpluginSetting_003E5__2 = null;
				_003Cdlg_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CpluginSetting_003E5__2 = null;
			_003Cdlg_003E5__3 = null;
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

		internal static bool IsSwsLcbFB5yQa0IYKCV()
		{
			return Xv0GFocbQZZvuiAOtm7M == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNewCmd_OnClick_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SearchSettingsPage _003C_003E4__this;

		internal static object DD9d8ccbyqFbX6buQAX4;

		private void MoveNext()
		{
			SearchSettingsPage searchSettingsPage = _003C_003E4__this;
			try
			{
				QuickRunItemEditWindow quickRunItemEditWindow = new QuickRunItemEditWindow
				{
					Owner = System.Windows.Window.GetWindow(searchSettingsPage)
				};
				if (quickRunItemEditWindow.ShowDialog() == true)
				{
					searchSettingsPage.Items.Add(new QuickRunItem
					{
						ActionType = QuickActionType.QuickerAction,
						CmdText = quickRunItemEditWindow.CmdText,
						Data = quickRunItemEditWindow.ActionIdOrName
					});
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
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

		internal static bool KM8gAKcbp2Zogj0AFxie()
		{
			return DD9d8ccbyqFbX6buQAX4 == null;
		}
	}

	[CompilerGenerated]
	private SmartCollection<QuickRunItem> sCbMvBhJUC = new SmartCollection<QuickRunItem>();

	[CompilerGenerated]
	private readonly SmartCollection<PluginSettingListItem> u7WMSriIDF = new SmartCollection<PluginSettingListItem>();

	public List<SelectionItem> ImeStateTypes = new List<SelectionItem>
	{
		new SelectionItem("NO_CONTROL", "不控制(系统自动)"),
		new SelectionItem("ON", "开启(中文)"),
		new SelectionItem("OFF", "关闭(英文)")
	};

	public List<SelectionItem> HintKeys = new List<SelectionItem>
	{
		new SelectionItem(112.ToString(), "F1"),
		new SelectionItem(113.ToString(), "F2"),
		new SelectionItem(114.ToString(), "F3"),
		new SelectionItem(115.ToString(), "F4")
	};

	private IList<SearchPlugin> EKiM2jcRph = new List<SearchPlugin>();

	internal ItemsControl PluginListCtrl;

	internal Button BtnReset;

	internal ListView LvCmdList;

	internal Button BtnNewCmd;

	internal System.Windows.Controls.TextBox TxtDefaultCommand;

	internal System.Windows.Controls.ComboBox CbImeState;

	internal NumericUpDown TxtMaxLines;

	internal System.Windows.Controls.ComboBox CbHintTriggerKey;

	internal NumericUpDown TxtAutoFillClipTextSeconds;

	internal CheckBox ChkEnableCacheWords;

	internal CheckBox ChkShowFileThumbnail;

	internal CheckBox ChkLoadPrevQueryText;

	internal Button BtnResetPosition;

	private bool aq7MuZM3kf;

	internal static SearchSettingsPage RUnrmQ4YTi0wHRKHnON;

	public SmartCollection<QuickRunItem> Items
	{
		[CompilerGenerated]
		get
		{
			return sCbMvBhJUC;
		}
		[CompilerGenerated]
		private set
		{
			sCbMvBhJUC = value;
		}
	}

	public SmartCollection<PluginSettingListItem> PluginItems
	{
		[CompilerGenerated]
		get
		{
			return u7WMSriIDF;
		}
	}

	public SearchSettingsPage()
	{
		InitializeComponent();
		LvCmdList.ItemsSource = Items;
		CbImeState.ItemsSource = ImeStateTypes;
		PluginListCtrl.ItemsSource = PluginItems;
		CbHintTriggerKey.ItemsSource = HintKeys;
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.NfFvhX28i1H = settings;
		if (_003C_003Ec__DisplayClass10_.NfFvhX28i1H.QuickRunItems.HasData())
		{
			Items.Reset(_003C_003Ec__DisplayClass10_.NfFvhX28i1H.QuickRunItems.OrderBy(_003C_003Ec.wDPvhGlBdZC ?? (_003C_003Ec.wDPvhGlBdZC = _003C_003Ec.B5Ivhk9RVEC.QUjvheSqIJb)));
		}
		TxtDefaultCommand.Text = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.DefaultSearchProcessor;
		SelectionItem item = ImeStateTypes.FirstOrDefault(_003C_003Ec__DisplayClass10_.xQxvhbsrL2e);
		UIHelper.TrySelectItem(CbImeState, item, true);
		UIHelper.TrySelectItem(CbHintTriggerKey, HintKeys.FirstOrDefault(_003C_003Ec__DisplayClass10_.nWivh6KO2uA), true);
		int num = 0;
		if (!q15TyI48EvG7KphwrBX())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TxtMaxLines.Value = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.MaxVisibleItemCount;
		TxtAutoFillClipTextSeconds.Value = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.AutoFillClipTextSeconds;
		ChkEnableCacheWords.IsChecked = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.EnableCacheWords;
		ChkShowFileThumbnail.IsChecked = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.ShowFileThumbnail;
		ChkLoadPrevQueryText.IsChecked = _003C_003Ec__DisplayClass10_.NfFvhX28i1H.SearchSettings.LoadPrevSearchText;
		yDnTiVOfmT();
	}

	private void yDnTiVOfmT()
	{
		IList<SearchPluginSettings> pluginSettings = AppState.HHxtaMaoqJr().SearchSettings.PluginSettings;
		PluginItems.Clear();
		List<PluginSettingListItem> list = new List<PluginSettingListItem>();
		using (IEnumerator<SearchPlugin> enumerator = gIh8AyjqAySmmxFMtv4.UOeterPKajP().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				_003C_003Ec__DisplayClass11_.vyPvhKqOh57 = enumerator.Current;
				List<SearchPluginSettings> list2 = pluginSettings.Where(_003C_003Ec__DisplayClass11_.XKrvhmAT16w).ToList();
				if (!list2.Any())
				{
					list.Add(new PluginSettingListItem(_003C_003Ec__DisplayClass11_.vyPvhKqOh57, AppHelper.Clone(_003C_003Ec__DisplayClass11_.vyPvhKqOh57.DefaultSettings)));
					continue;
				}
				foreach (SearchPluginSettings item in list2)
				{
					list.Add(new PluginSettingListItem(_003C_003Ec__DisplayClass11_.vyPvhKqOh57, item));
				}
			}
			int num = 0;
			if (RUnrmQ4YTi0wHRKHnON != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		PluginItems.Reset(list.OrderBy(_003C_003Ec.ubqvhsRDwbd ?? (_003C_003Ec.ubqvhsRDwbd = _003C_003Ec.B5Ivhk9RVEC.IM4vhYDcjwW)));
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.QuickRunItems = Items.ToList();
		SearchSettings searchSettings = settings.SearchSettings;
		SelectionItem obj = CbImeState.SelectedItem as SelectionItem;
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
				goto IL_003c;
			}
		}
		obj2 = "NO_CONTROL";
		goto IL_003c;
		IL_003c:
		searchSettings.ImeControl = (string)obj2;
		settings.SearchSettings.HintTriggerKey = (CbHintTriggerKey.SelectedItem as SelectionItem)?.Value.TryConvertToInt() ?? 112;
		settings.SearchSettings.DefaultSearchProcessor = TxtDefaultCommand.Text;
		settings.SearchSettings.MaxVisibleItemCount = (int)TxtMaxLines.Value;
		settings.SearchSettings.AutoFillClipTextSeconds = TxtAutoFillClipTextSeconds.Value;
		settings.SearchSettings.PluginSettings = PluginItems.Select(_003C_003Ec.yt5vhHDXERc ?? (_003C_003Ec.yt5vhHDXERc = _003C_003Ec.B5Ivhk9RVEC.PSGvhImKhum)).ToList();
		settings.SearchSettings.EnableCacheWords = ChkEnableCacheWords.IsChecked == true;
		settings.SearchSettings.ShowFileThumbnail = ChkShowFileThumbnail.IsChecked == true;
		settings.SearchSettings.LoadPrevSearchText = ChkLoadPrevQueryText.IsChecked == true;
		if (q15TyI48EvG7KphwrBX())
		{
			switch (0)
			{
			}
		}
		gIh8AyjqAySmmxFMtv4.GdNteY7DhPE();
		gIh8AyjqAySmmxFMtv4.ktatemHmAHQ(EKiM2jcRph);
		return true;
	}

	[AsyncStateMachine(typeof(_003CBtnNewCmd_OnClick_003Ed__14))]
	private void YhUT3dXbVE(object sender, RoutedEventArgs e)
	{
		_003CBtnNewCmd_OnClick_003Ed__14 stateMachine = default(_003CBtnNewCmd_OnClick_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void GvGTf9iMsk(object sender, RoutedEventArgs e)
	{
		QuickRunItem quickRunItem = (sender as Button).Tag as QuickRunItem;
		QuickRunItemEditWindow quickRunItemEditWindow = new QuickRunItemEditWindow();
		quickRunItemEditWindow.Owner = System.Windows.Window.GetWindow(this);
		quickRunItemEditWindow.ActionIdOrName = quickRunItem.Data;
		quickRunItemEditWindow.CmdText = quickRunItem.CmdText;
		if (quickRunItemEditWindow.ShowDialog() != true)
		{
			return;
		}
		Items.Remove(quickRunItem);
		Items.Add(new QuickRunItem
		{
			ActionType = QuickActionType.QuickerAction,
			CmdText = quickRunItemEditWindow.CmdText,
			Data = quickRunItemEditWindow.ActionIdOrName
		});
		if (RUnrmQ4YTi0wHRKHnON != null)
		{
			switch (0)
			{
			}
		}
	}

	private void fPqTz4fUdD(object sender, RoutedEventArgs e)
	{
		QuickRunItem item = (sender as Button).Tag as QuickRunItem;
		Items.Remove(item);
	}

	private void wNnMw4t2Zv(object sender, RoutedEventArgs e)
	{
		if (!AppHelper.Confirm("您确认要还原系统默认设置么？"))
		{
			return;
		}
		AppState.HHxtaMaoqJr().SearchSettings.PluginSettings = gIh8AyjqAySmmxFMtv4.UOeterPKajP().Select(_003C_003Ec.OfBvh1I7jnd ?? (_003C_003Ec.OfBvh1I7jnd = _003C_003Ec.B5Ivhk9RVEC.TeTvhWppMOV)).ToList();
		yDnTiVOfmT();
		foreach (SearchPlugin item in gIh8AyjqAySmmxFMtv4.UOeterPKajP())
		{
			EKiM2jcRph.AddIfDistinct(item);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnConfigPlugin_OnClick_003Ed__18))]
	private void dByMt8FuNb(object sender, RoutedEventArgs e)
	{
		_003CBtnConfigPlugin_OnClick_003Ed__18 stateMachine = default(_003CBtnConfigPlugin_OnClick_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void LLRMgvMkOu(object sender, RoutedEventArgs e)
	{
		dDh7g7Xw7JyQPUTbYwJ.SearchWindowLocation = null;
		dDh7g7Xw7JyQPUTbYwJ.SearchWindowWidth = null;
		AppHelper.ShowSuccess("已恢复搜索框默认位置和宽度。");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!aq7MuZM3kf)
		{
			aq7MuZM3kf = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/features/searchsettingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			PluginListCtrl = (ItemsControl)target;
			break;
		case 3:
			BtnReset = (Button)target;
			BtnReset.Click += wNnMw4t2Zv;
			break;
		case 4:
			LvCmdList = (ListView)target;
			num = 0;
			if (!q15TyI48EvG7KphwrBX())
			{
				goto IL_012f;
			}
			goto IL_0133;
		default:
			aq7MuZM3kf = true;
			break;
		case 7:
			BtnNewCmd = (Button)target;
			BtnNewCmd.Click += YhUT3dXbVE;
			break;
		case 8:
			TxtDefaultCommand = (System.Windows.Controls.TextBox)target;
			break;
		case 9:
			CbImeState = (System.Windows.Controls.ComboBox)target;
			break;
		case 10:
			TxtMaxLines = (NumericUpDown)target;
			break;
		case 11:
			CbHintTriggerKey = (System.Windows.Controls.ComboBox)target;
			break;
		case 12:
			TxtAutoFillClipTextSeconds = (NumericUpDown)target;
			break;
		case 13:
			ChkEnableCacheWords = (CheckBox)target;
			break;
		case 14:
			ChkShowFileThumbnail = (CheckBox)target;
			num = 1;
			if (!q15TyI48EvG7KphwrBX())
			{
				goto IL_012f;
			}
			goto IL_0133;
		case 15:
			ChkLoadPrevQueryText = (CheckBox)target;
			break;
		case 16:
			{
				BtnResetPosition = (Button)target;
				BtnResetPosition.Click += LLRMgvMkOu;
				break;
			}
			IL_012f:
			num = num2;
			goto IL_0133;
			IL_0133:
			switch (num)
			{
			case 1:
				break;
			}
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
			((Button)target).Click += dByMt8FuNb;
			break;
		case 5:
			((Button)target).Click += GvGTf9iMsk;
			break;
		case 6:
			((Button)target).Click += fPqTz4fUdD;
			break;
		case 3:
		case 4:
			break;
		}
	}

	internal static bool q15TyI48EvG7KphwrBX()
	{
		return RUnrmQ4YTi0wHRKHnON == null;
	}
}
