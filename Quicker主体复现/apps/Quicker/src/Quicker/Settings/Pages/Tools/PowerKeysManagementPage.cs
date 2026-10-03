using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Settings.Controls;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View;
using Quicker.View.PowerKeys;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Tools;

public class PowerKeysManagementPage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WI4vZ14Q3no;

		public static Func<int, KeyItem> XWXvZbCLiVw;

		public static Func<KeyItem, int> JhRvZ6J1QXT;

		public static Func<PowerKey, int> QkCvZXo06Ta;

		public static Func<PowerKey, bool> d1WvZm5oWvc;

		public static Func<PowerKeyActionItem, int?> xd2vZK2DFev;

		public static Func<PowerKeyActionItem, int?> D84vZxwvCsE;

		public static Func<PowerKeyActionItem, string> HgIvZrek5Ws;

		public static Func<PowerKeyActionItem, string> FKqvZpBnw7y;

		public static Func<string, bool> wsdvZB8yrfs;

		public static Func<string, string> wS9vZQCYdFx;

		public static Func<string, Quicker.View.PowerKeys.GroupItem> yRIvZjjYrnJ;

		internal static _003C_003Ec Y01WICcL40jENo9ihTQI;

		static _003C_003Ec()
		{
			WI4vZ14Q3no = new _003C_003Ec();
		}

		internal KeyItem WvsvZZV9Y27(int x)
		{
			return new KeyItem
			{
				Key = x,
				Name = KeyboardHelper.GetKeyName((VirtualKeyCode)x)
			};
		}

		internal int kDfvZ9132bq(KeyItem x)
		{
			return x.Key;
		}

		internal int y7WvZhWkdyj(PowerKey x)
		{
			return x.Key;
		}

		internal bool A3TvZeC5AvD(PowerKey x)
		{
			return x.IsEnabled;
		}

		internal int? YakvZYeE7cJ(PowerKeyActionItem x)
		{
			return x.AdornKey;
		}

		internal int? FSkvZIq2FCr(PowerKeyActionItem x)
		{
			return x.SecondaryKey;
		}

		internal string cG0vZWnAFfL(PowerKeyActionItem x)
		{
			return x.BindingProcessName;
		}

		internal string iugvZkevyZ9(PowerKeyActionItem x)
		{
			return x.Group;
		}

		internal bool NcbvZGdCNpO(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string bASvZslvt9h(string x)
		{
			return x;
		}

		internal Quicker.View.PowerKeys.GroupItem UcXvZHSwR27(string g)
		{
			return new Quicker.View.PowerKeys.GroupItem
			{
				Group = g,
				Title = g
			};
		}

		internal static bool hwLiYScLhY9blFVGwDT5()
		{
			return Y01WICcL40jENo9ihTQI == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass15_0
	{
		public IDictionary<int, PowerKey> mDOvZn59KCN;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public int? madvZ57VEbD;

		internal static _003C_003Ec__DisplayClass19_0 QUlGuVcuc78BTnVwcamU;

		internal bool EMbvZ45lbUk(KeyItem x)
		{
			return x.Key == madvZ57VEbD.Value;
		}

		internal static bool F5UF9BcuWq5Vg7t35Haa()
		{
			return QUlGuVcuc78BTnVwcamU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_1
	{
		public int? QBYvZdjOaql;

		private static _003C_003Ec__DisplayClass19_1 weEg4FcupEqNjovou0b1;

		internal bool qF9vZD13R6T(KeyItem x)
		{
			return x.Key == QBYvZdjOaql;
		}

		internal static bool qM5ucEcuXeZY2bUqla4x()
		{
			return weEg4FcupEqNjovou0b1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public Quicker.View.PowerKeys.GroupItem VOtvZTfXPL4;

		internal static _003C_003Ec__DisplayClass38_0 OSAUKpcunrIo0Z5ELbft;

		internal bool lbivZogWG6M(Quicker.View.PowerKeys.GroupItem x)
		{
			return x.Group == VOtvZTfXPL4.Group;
		}

		static _003C_003Ec__DisplayClass38_0()
		{
		}

		internal static bool gvnkKscueEm0K742Jrqg()
		{
			return OSAUKpcunrIo0Z5ELbft == null;
		}

		internal static void AEP0ohcuDCGXAEZjoFqH()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnInstallSharedPowerKey_OnClick_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PowerKeysManagementPage _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<SharedPowerKeyDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object PlT5rNcu3RhW9fjCBTw7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PowerKeysManagementPage powerKeysManagementPage = _003C_003E4__this;
			try
			{
				try
				{
        InstallPowerKeyWindow installPowerKeyWindow = default;
        Guid result = default;
        SharedPowerKeyDto data = default;
					if (num == 0)
					{
						goto IL_00c4;
					}
					string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
					string text2 = "https://getquicker.net/share/powerkeys/package?id=";
					int num2;
					if (string.IsNullOrEmpty(text) || !text.StartsWith(text2, StringComparison.OrdinalIgnoreCase))
					{
						MessageBoxHelper.Show(Window.GetWindow(powerKeysManagementPage), "剪贴板中没有扩展热键网址数据，请复制扩展热键网址后再点击此按钮。");
						AppHelper.TryOpenUrlOrFile("https://getquicker.net/share/powerkeys");
						num2 = 3;
						if (!BPMNwJcuEHnrxvMBnshW())
						{
							goto IL_0168;
						}
						goto IL_016c;
					}
					string text3 = text.Substring(text2.Length, "00000000-0000-0000-0000-000000000000".Length);
					result = default(Guid);
					if (Guid.TryParse(text3, out result))
					{
						num2 = 1;
						if (!BPMNwJcuEHnrxvMBnshW())
						{
							goto IL_0168;
						}
						goto IL_016c;
					}
					AppHelper.ShowWarning(text3 + " 不是合法的扩展热键分享包ID。", true);
					goto end_IL_0011;
					IL_00e2:
					ConfiguredTaskAwaitable<ApiResult<SharedPowerKeyDto>>.ConfiguredTaskAwaiter awaiter;
					ApiResult<SharedPowerKeyDto> result2 = awaiter.GetResult();
					data = default(SharedPowerKeyDto);
					installPowerKeyWindow = default(InstallPowerKeyWindow);
					if (result2.IsSuccess)
					{
						data = result2.Data;
						installPowerKeyWindow = new InstallPowerKeyWindow(powerKeysManagementPage.jYgDtjae2Y, data)
						{
							Owner = powerKeysManagementPage.ParentWindow
						};
						if (installPowerKeyWindow.ShowDialog() == true)
						{
							num2 = 2;
							if (PlT5rNcu3RhW9fjCBTw7 != null)
							{
								goto IL_0168;
							}
							goto IL_016c;
						}
					}
					else
					{
						AppHelper.ShowWarning(result2.Message, true);
					}
					goto end_IL_0011;
					IL_016c:
					switch (num2)
					{
					case 1:
						goto IL_0142;
					case 2:
						if (!powerKeysManagementPage.jYgDtjae2Y.ContainsKey(installPowerKeyWindow.Key))
						{
							PowerKey value = new PowerKey
							{
								Key = installPowerKeyWindow.Key,
								KeepOriginKeyFunc = (installPowerKeyWindow.Key != data.Key || data.KeepOriginKeyFunc),
								Id = Guid.NewGuid(),
								IsEnabled = true,
								KeyActions = installPowerKeyWindow.Actions
							};
							powerKeysManagementPage.jYgDtjae2Y.Add(installPowerKeyWindow.Key, value);
							powerKeysManagementPage.UpdateKeyList(installPowerKeyWindow.Key);
							powerKeysManagementPage.Save();
						}
						else
						{
							PowerKey powerKey = powerKeysManagementPage.jYgDtjae2Y[installPowerKeyWindow.Key];
							IEnumerator<PowerKeyActionItem> enumerator = installPowerKeyWindow.Actions.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									PowerKeyActionItem current = enumerator.Current;
									powerKey.KeyActions.Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
							powerKeysManagementPage.h1x56k6GOl();
							powerKeysManagementPage.Save();
							powerKeysManagementPage.ePd5o2lxjC();
						}
						AppHelper.ShowInformation($"共导入了 {installPowerKeyWindow.Actions.Count} 个按键组合。");
						goto end_IL_0011;
					case 3:
						goto end_IL_0011;
					}
					goto IL_00c4;
					IL_0168:
					int num3 = default(int);
					num2 = num3;
					goto IL_016c;
					IL_0142:
					awaiter = aFIptTXYsUoTUF4v33R.RZ5t1QF4Cjb(result).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00e2;
					IL_00c4:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedPowerKeyDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00e2;
					end_IL_0011:;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning(exception.GetMessageWithInner());
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool BPMNwJcuEHnrxvMBnshW()
		{
			return PlT5rNcu3RhW9fjCBTw7 == null;
		}
	}

	private readonly DataService xgZDwjeE05;

	private IDictionary<int, PowerKey> jYgDtjae2Y;

	[CompilerGenerated]
	private SmartCollection<Quicker.View.PowerKeys.GroupItem> M4fDgidk78 = new SmartCollection<Quicker.View.PowerKeys.GroupItem>();

	[CompilerGenerated]
	private int? zACDLQribv;

	internal ComboBox CbPowerKeys;

	internal Button BtnAddPowerKey;

	internal Button BtnDeletePowerKey;

	internal Button BtnChangePowerKey;

	internal Button BtnInstallSharedPowerKey;

	internal Button BtnImport;

	internal Grid GridContent;

	internal ToggleButton ChkEnable;

	internal CheckBox ChkEnableDefaultAction;

	internal ProcessSelectorControl BlackListEditor;

	internal Button BtnAddAction;

	internal ListView LvActions;

	internal MenuItem MenuAddToGroup;

	internal MenuItem MenuShare;

	internal MenuItem MenuExport;

	internal MenuItem MenuDelete;

	internal TabControl GroupTab;

	internal StackPanel PnlVersionTip;

	internal TextBlock LblVersionTip;

	private bool HSZDvIWpPH;

	private static PowerKeysManagementPage HZl9m5m9qhNx3QG49GT;

	public SmartCollection<Quicker.View.PowerKeys.GroupItem> Groups
	{
		[CompilerGenerated]
		get
		{
			return M4fDgidk78;
		}
		[CompilerGenerated]
		set
		{
			M4fDgidk78 = value;
		}
	}

	private int? SelectedKeyCode
	{
		[CompilerGenerated]
		get
		{
			return zACDLQribv;
		}
		[CompilerGenerated]
		set
		{
			zACDLQribv = value;
		}
	}

	public PowerKey CurrentPowerKey
	{
		get
		{
			if (SelectedKeyCode.HasValue)
			{
				return jYgDtjae2Y[SelectedKeyCode.Value];
			}
			return null;
		}
	}

	public PowerKeysManagementPage()
	{
		xgZDwjeE05 = AppState.DataService;
		InitializeComponent();
		jYgDtjae2Y = xgZDwjeE05.DyhtXJ0GcZv();
		if (jYgDtjae2Y == null)
		{
			jYgDtjae2Y = new Dictionary<int, PowerKey>();
		}
		x8f5sUg2Tw(jYgDtjae2Y);
		UpdateKeyList(AppState.DataService.UserPreference.LastEditingPowerKey);
		base.Loaded += rB85H90Ixf;
		{
			PnlVersionTip.Visibility = Visibility.Collapsed;
			LblVersionTip.Text = string.Empty;
		}
		GroupTab.ItemsSource = Groups;
	}

	private void x8f5sUg2Tw(IDictionary<int, PowerKey> idictionary_1)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_0_ = default(_003C_003Ec__DisplayClass15_0);
		_003C_003Ec__DisplayClass15_0_.mDOvZn59KCN = idictionary_1;
		PfG53HojWd(4, ref _003C_003Ec__DisplayClass15_0_);
		PfG53HojWd(2, ref _003C_003Ec__DisplayClass15_0_);
		PfG53HojWd(5, ref _003C_003Ec__DisplayClass15_0_);
		PfG53HojWd(6, ref _003C_003Ec__DisplayClass15_0_);
	}

	private void rB85H90Ixf(object sender, RoutedEventArgs e)
	{
		RcP5b40J7v();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		Save();
		return true;
	}

	public void UpdateKeyList(int? selectKey)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.madvZ57VEbD = selectKey;
		IList<KeyItem> list = jYgDtjae2Y.Keys.Select(_003C_003Ec.XWXvZbCLiVw ?? (_003C_003Ec.XWXvZbCLiVw = _003C_003Ec.WI4vZ14Q3no.WvsvZZV9Y27)).OrderBy(_003C_003Ec.JhRvZ6J1QXT ?? (_003C_003Ec.JhRvZ6J1QXT = _003C_003Ec.WI4vZ14Q3no.kDfvZ9132bq)).ToList();
		CbPowerKeys.ItemsSource = list;
		if (_003C_003Ec__DisplayClass19_.madvZ57VEbD.HasValue)
		{
			KeyItem selectedItem = list.FirstOrDefault(_003C_003Ec__DisplayClass19_.EMbvZ45lbUk);
			CbPowerKeys.SelectedItem = selectedItem;
			return;
		}
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_1();
		_003C_003Ec__DisplayClass19_2.QBYvZdjOaql = jYgDtjae2Y.Values.OrderBy(_003C_003Ec.QkCvZXo06Ta ?? (_003C_003Ec.QkCvZXo06Ta = _003C_003Ec.WI4vZ14Q3no.y7WvZhWkdyj)).FirstOrDefault(_003C_003Ec.d1WvZm5oWvc ?? (_003C_003Ec.d1WvZm5oWvc = _003C_003Ec.WI4vZ14Q3no.A3TvZeC5AvD))?.Key;
		if (_003C_003Ec__DisplayClass19_2.QBYvZdjOaql.HasValue)
		{
			KeyItem selectedItem2 = list.FirstOrDefault(_003C_003Ec__DisplayClass19_2.qF9vZD13R6T);
			CbPowerKeys.SelectedItem = selectedItem2;
		}
		else if (CbPowerKeys.Items.Count > 0)
		{
			CbPowerKeys.SelectedIndex = 0;
		}
	}

	private void urR51ilA5s(object sender, SelectionChangedEventArgs e)
	{
		SelectedKeyCode = (CbPowerKeys.SelectedItem as KeyItem)?.Key;
		RcP5b40J7v();
		AppState.DataService.UserPreference.LastEditingPowerKey = SelectedKeyCode;
		AppState.DataService.tbAtXR5TON1();
	}

	private void RcP5b40J7v()
	{
		if (CurrentPowerKey == null)
		{
			LvActions.ItemsSource = null;
			GridContent.IsEnabled = false;
			GridContent.Opacity = 0.5;
			return;
		}
		GridContent.IsEnabled = true;
		GridContent.Opacity = 1.0;
		ChkEnable.IsChecked = CurrentPowerKey.IsEnabled;
		ChkEnableDefaultAction.IsChecked = CurrentPowerKey.KeepOriginKeyFunc && CurrentPowerKey.Key > 6;
		if (D5QweEmLS3q13XefEbE())
		{
			switch (0)
			{
			}
		}
		BlackListEditor.ProcessList = CurrentPowerKey.BlackList;
		ePd5o2lxjC();
		LvActions.ItemsSource = CurrentPowerKey.KeyActions.OrderBy(_003C_003Ec.xd2vZK2DFev ?? (_003C_003Ec.xd2vZK2DFev = _003C_003Ec.WI4vZ14Q3no.YakvZYeE7cJ)).ThenBy(_003C_003Ec.D84vZxwvCsE ?? (_003C_003Ec.D84vZxwvCsE = _003C_003Ec.WI4vZ14Q3no.FSkvZIq2FCr)).ThenBy(_003C_003Ec.HgIvZrek5Ws ?? (_003C_003Ec.HgIvZrek5Ws = _003C_003Ec.WI4vZ14Q3no.cG0vZWnAFfL));
		((CollectionView)CollectionViewSource.GetDefaultView(LvActions.ItemsSource)).Filter = wJ25X5XFPv;
	}

	private void Save()
	{
		xgZDwjeE05.N78tX0QFb3C(jYgDtjae2Y);
	}

	private void h1x56k6GOl()
	{
		((CollectionView)CollectionViewSource.GetDefaultView(LvActions.ItemsSource))?.Refresh();
	}

	private bool wJ25X5XFPv(object object_0)
	{
		if (GroupTab.SelectedItem == null)
		{
			return true;
		}
		string text = (GroupTab.SelectedItem as Quicker.View.PowerKeys.GroupItem).Group;
		if (text == "__all_items")
		{
			return true;
		}
		PowerKeyActionItem powerKeyActionItem = object_0 as PowerKeyActionItem;
		if (text == "__not_grouped" && string.IsNullOrEmpty(powerKeyActionItem?.Group))
		{
			if (D5QweEmLS3q13XefEbE())
			{
				switch (0)
				{
				}
			}
			return true;
		}
		return string.Equals(powerKeyActionItem?.Group, text);
	}

	private void Nuu5mmvyD7(object sender, MouseButtonEventArgs e)
	{
		if (((ListViewItem)sender).Content is PowerKeyActionItem powerKeyActionItem_)
		{
			T6o5xl22jf(powerKeyActionItem_);
		}
	}

	private void PZU5K0k1BE(object sender, RoutedEventArgs e)
	{
		PowerKeyActionItem powerKeyActionItem_ = (sender as Button).Tag as PowerKeyActionItem;
		T6o5xl22jf(powerKeyActionItem_);
	}

	private void T6o5xl22jf(PowerKeyActionItem powerKeyActionItem_0)
	{
		PowerKeyActionEditWindow powerKeyActionEditWindow = new PowerKeyActionEditWindow(powerKeyActionItem_0, CurrentPowerKey, xgZDwjeE05, OXo5dtl6C5());
		powerKeyActionEditWindow.Owner = base.ParentWindow;
		if (powerKeyActionEditWindow.ShowDialog() == true)
		{
			CurrentPowerKey.KeyActions.Remove(powerKeyActionItem_0);
			CurrentPowerKey.KeyActions.Add(powerKeyActionEditWindow.Result);
			Save();
			RcP5b40J7v();
		}
	}

	private void sCk5rjcxMF(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要删除么？删除后将不可恢复！"))
		{
			PowerKeyActionItem item = (sender as Button).Tag as PowerKeyActionItem;
			CurrentPowerKey.KeyActions.Remove(item);
			RcP5b40J7v();
			Save();
		}
	}

	private void ojB5pOU3HJ(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count != 0 && CurrentPowerKey != null)
		{
			if (!AppHelper.Confirm($"您确认要删除 {LvActions.SelectedItems.Count} 个条目么？\n删除后将无法恢复。"))
			{
				return;
			}
			foreach (PowerKeyActionItem item in LvActions.SelectedItems.Cast<PowerKeyActionItem>())
			{
				CurrentPowerKey.KeyActions.Remove(item);
			}
			RcP5b40J7v();
			Save();
		}
		else
		{
			AppHelper.ShowWarning("请选择要操作的条目。");
		}
	}

	private void MuQ5BdRHJK(object sender, RoutedEventArgs e)
	{
		if (CurrentPowerKey == null)
		{
			AppHelper.ShowWarning("请先选择引导键。");
		}
		else
		{
			PowerKeyActionEditWindow powerKeyActionEditWindow = new PowerKeyActionEditWindow(null, CurrentPowerKey, xgZDwjeE05, OXo5dtl6C5());
			powerKeyActionEditWindow.Owner = base.ParentWindow;
			if (powerKeyActionEditWindow.ShowDialog() != true)
			{
				return;
			}
			PowerKeyActionItem result = powerKeyActionEditWindow.Result;
			CurrentPowerKey.KeyActions.Add(result);
			Save();
			if (D5QweEmLS3q13XefEbE())
			{
				switch (0)
				{
				}
			}
			RcP5b40J7v();
		}
	}

	private void lMV5QHotNO(object sender, RoutedEventArgs e)
	{
		AddNewPowerKeyWindow addNewPowerKeyWindow = new AddNewPowerKeyWindow();
		addNewPowerKeyWindow.Owner = base.ParentWindow;
		if (addNewPowerKeyWindow.ShowDialog() != true)
		{
			return;
		}
		VirtualKeyCode key = addNewPowerKeyWindow.Hotkey.Key;
		if (jYgDtjae2Y.ContainsKey((int)key))
		{
			int num = 0;
			if (!D5QweEmLS3q13XefEbE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.ShowWarning("已经添加了此键。", true);
		}
		else
		{
			PowerKey value = new PowerKey
			{
				Key = (int)key,
				KeepOriginKeyFunc = true,
				Id = Guid.NewGuid(),
				IsEnabled = true,
				KeyActions = new List<PowerKeyActionItem>()
			};
			jYgDtjae2Y.Add((int)key, value);
			UpdateKeyList((int)key);
			Save();
		}
	}

	private void cBx5j01OCn(object sender, RoutedEventArgs e)
	{
		h3154qF4Jb();
	}

	private void MDx5niYbN4(object sender, RoutedEventArgs e)
	{
		h3154qF4Jb();
	}

	private void h3154qF4Jb()
	{
		if (CurrentPowerKey == null)
		{
			AppHelper.ShowWarning("请选择引导键。");
			return;
		}
		CurrentPowerKey.IsEnabled = ChkEnable.IsChecked == true;
		CurrentPowerKey.KeepOriginKeyFunc = ChkEnableDefaultAction.IsChecked == true && CurrentPowerKey.Key > 6;
		CurrentPowerKey.BlackList = BlackListEditor.ProcessList;
		Save();
	}

	private void kkK55XtVhM(object sender, RoutedEventArgs e)
	{
		if (!SelectedKeyCode.HasValue)
		{
			AppHelper.ShowWarning("没有可以删除的引导键。");
		}
		else if (SelectedKeyCode <= 6)
		{
			AppHelper.ShowWarning("系统默认的鼠标按键不能删除，请禁用即可。", true);
		}
		else if (ChkEnable.IsChecked == true)
		{
			AppHelper.ShowWarning("为避免误操作，请先取消“启用此引导键”。", true);
			int num = 0;
			if (!D5QweEmLS3q13XefEbE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (AppHelper.Confirm("您确认要删除引导键及所有关联的操作按键设置么？删除后将无法恢复。"))
		{
			jYgDtjae2Y.Remove(SelectedKeyCode.Value);
			Save();
			UpdateKeyList(null);
		}
	}

	private void wEN5Di2cFt(object sender, RoutedEventArgs e)
	{
		if (CbPowerKeys.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择要更改的引导键。");
			return;
		}
		AddNewPowerKeyWindow addNewPowerKeyWindow = new AddNewPowerKeyWindow();
		addNewPowerKeyWindow.Owner = base.ParentWindow;
		if (addNewPowerKeyWindow.ShowDialog() != true)
		{
			return;
		}
		VirtualKeyCode key = addNewPowerKeyWindow.Hotkey.Key;
		if (jYgDtjae2Y.ContainsKey((int)key))
		{
			AppHelper.ShowWarning("已经添加了此键。", true);
			return;
		}
		KeyItem keyItem = (KeyItem)CbPowerKeys.SelectedItem;
		PowerKey powerKey = jYgDtjae2Y[keyItem.Key];
		jYgDtjae2Y.Remove(keyItem.Key);
		if (HZl9m5m9qhNx3QG49GT != null)
		{
			switch (0)
			{
			}
		}
		powerKey.Key = (int)key;
		jYgDtjae2Y.Add((int)key, powerKey);
		UpdateKeyList((int)key);
		Save();
	}

	private string OXo5dtl6C5()
	{
		if (GroupTab.SelectedItem != null && GroupTab.SelectedItem is Quicker.View.PowerKeys.GroupItem groupItem && groupItem.Group != "__all_items" && groupItem.Group != "__not_grouped")
		{
			return groupItem.Group;
		}
		return "";
	}

	private void ePd5o2lxjC()
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		IList<PowerKeyActionItem> list = CurrentPowerKey?.KeyActions;
		if (list == null)
		{
			Groups.Clear();
			return;
		}
		IList<Quicker.View.PowerKeys.GroupItem> list2 = list.Select(_003C_003Ec.FKqvZpBnw7y ?? (_003C_003Ec.FKqvZpBnw7y = _003C_003Ec.WI4vZ14Q3no.iugvZkevyZ9)).Distinct().Where(_003C_003Ec.wsdvZB8yrfs ?? (_003C_003Ec.wsdvZB8yrfs = _003C_003Ec.WI4vZ14Q3no.NcbvZGdCNpO))
			.OrderBy(_003C_003Ec.wS9vZQCYdFx ?? (_003C_003Ec.wS9vZQCYdFx = _003C_003Ec.WI4vZ14Q3no.bASvZslvt9h))
			.Select(_003C_003Ec.yRIvZjjYrnJ ?? (_003C_003Ec.yRIvZjjYrnJ = _003C_003Ec.WI4vZ14Q3no.UcXvZHSwR27))
			.ToList();
		list2.Insert(0, new Quicker.View.PowerKeys.GroupItem
		{
			Group = "__all_items",
			Title = "*所有*"
		});
		list2.Insert(1, new Quicker.View.PowerKeys.GroupItem
		{
			Group = "__not_grouped",
			Title = "*未分组*"
		});
		MenuAddToGroup.Items.Clear();
		foreach (Quicker.View.PowerKeys.GroupItem item in list2)
		{
			if (item.Group != "__all_items")
			{
				AppHelper.AddMenuItem(MenuAddToGroup.Items, item.Title, null, "", Ng85Ma7N7M).Tag = ((!(item.Group == "__not_grouped")) ? item.Group : string.Empty);
			}
		}
		AppHelper.AddMenuItem(MenuAddToGroup.Items, "新分组...", "添加到一个新的分组", "", oGm5Tcihgn);
		_003C_003Ec__DisplayClass38_.VOtvZTfXPL4 = GroupTab.SelectedItem as Quicker.View.PowerKeys.GroupItem;
		Groups.Reset(list2);
		Quicker.View.PowerKeys.GroupItem groupItem = default(Quicker.View.PowerKeys.GroupItem);
		if (_003C_003Ec__DisplayClass38_.VOtvZTfXPL4 != null)
		{
			groupItem = list2.FirstOrDefault(_003C_003Ec__DisplayClass38_.lbivZogWG6M);
			if (groupItem != null)
			{
				goto IL_023e;
			}
		}
		goto IL_0267;
		IL_023e:
		GroupTab.SelectedItem = groupItem;
		goto IL_0267;
		IL_0277:
		GroupTab.SelectedIndex = 0;
		return;
		IL_0267:
		if (GroupTab.SelectedItem != null)
		{
			return;
		}
		if (HZl9m5m9qhNx3QG49GT == null)
		{
			switch (0)
			{
			case 1:
				break;
			default:
				goto IL_0277;
			}
			goto IL_023e;
		}
		goto IL_0277;
	}

	private void oGm5Tcihgn(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选中要修改分组的条目。");
			return;
		}
		UserInputWindow userInputWindow = new UserInputWindow("text", "请输入分组名称", "", "");
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string textValue = userInputWindow.TextValue;
		foreach (object selectedItem in LvActions.SelectedItems)
		{
			(selectedItem as PowerKeyActionItem).Group = textValue;
		}
		h1x56k6GOl();
		Save();
		ePd5o2lxjC();
	}

	private void Ng85Ma7N7M(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选中要修改分组的条目。");
			return;
		}
		string text = (sender as MenuItem).Tag as string;
		foreach (object selectedItem in LvActions.SelectedItems)
		{
			(selectedItem as PowerKeyActionItem).Group = text;
		}
		h1x56k6GOl();
		Save();
	}

	private void pQH5Ayqwlg(object sender, SelectionChangedEventArgs e)
	{
		h1x56k6GOl();
	}

	private void bmo5OMHS4k(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count != 0 && CurrentPowerKey != null)
		{
			if (LvActions.SelectedItems.Count < 2)
			{
				AppHelper.ShowWarning("每个配置包需要至少包含2个组合按键操作。\n请使用Ctrl+点击的方式选择多个相关条目后再分享。", true);
				return;
			}
			List<PowerKeyActionItem> selectedActionItems = LvActions.SelectedItems.Cast<PowerKeyActionItem>().ToList();
			SharePowerKeyWindow sharePowerKeyWindow = new SharePowerKeyWindow(CurrentPowerKey, selectedActionItems, GroupTab.SelectedItem?.ToString());
			sharePowerKeyWindow.Owner = base.ParentWindow;
			sharePowerKeyWindow.ShowDialog();
		}
		else
		{
			AppHelper.ShowWarning("请选择要操作的条目。");
		}
	}

	[AsyncStateMachine(typeof(_003CBtnInstallSharedPowerKey_OnClick_003Ed__43))]
	private void Lm45FSAHFS(object sender, RoutedEventArgs e)
	{
		_003CBtnInstallSharedPowerKey_OnClick_003Ed__43 stateMachine = default(_003CBtnInstallSharedPowerKey_OnClick_003Ed__43);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void KWY5UqnREk(object sender, RoutedEventArgs e)
	{
		Save();
	}

	private void BlackListEditor_Changed(object sender, EventArgs e)
	{
		h3154qF4Jb();
	}

	private void xOq5lCAOhX(object sender, RoutedEventArgs e)
	{
		if (LvActions.SelectedItems.Count != 0 && CurrentPowerKey != null)
		{
			List<PowerKeyActionItem> list = LvActions.SelectedItems.Cast<PowerKeyActionItem>().ToList();
			SharedPowerKeyDto sharedPowerKeyDto = new SharedPowerKeyDto
			{
				Id = Guid.NewGuid(),
				Title = $"扩展热键_{(VirtualKeyCode)CurrentPowerKey.Key}_{DateTime.Now:yyyyMMdd_HHmmss}",
				Description = "",
				Key = CurrentPowerKey.Key,
				KeepOriginKeyFunc = CurrentPowerKey.KeepOriginKeyFunc,
				ItemCount = list.Count,
				Data = JsonConvert.SerializeObject(list)
			};
			(bool, string) tuple = AppHelper.ShowSaveFileDialog("Json文件|*.json|任意文件|*.*", ".json", sharedPowerKeyDto.Title + ".json", "", "导出扩展热键");
			if (tuple.Item1)
			{
				File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(sharedPowerKeyDto, Formatting.Indented));
				AppHelper.SelectFileInExplorer(tuple.Item2, false);
			}
		}
		else
		{
			AppHelper.ShowWarning("请选择要操作的条目。");
			int num = 0;
			if (HZl9m5m9qhNx3QG49GT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void LE95iDYrE8(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("Json文件|*.json|任意文件|*.*", ".json", "", "", "导入文本指令");
		if (!tuple.Item1)
		{
			return;
		}
		try
		{
			SharedPowerKeyDto sharedPowerKeyDto = JsonConvert.DeserializeObject<SharedPowerKeyDto>(File.ReadAllText(tuple.Item2));
			if (sharedPowerKeyDto != null && !string.IsNullOrEmpty(sharedPowerKeyDto.Data) && sharedPowerKeyDto.Key != 0)
			{
				InstallPowerKeyWindow installPowerKeyWindow = new InstallPowerKeyWindow(jYgDtjae2Y, sharedPowerKeyDto);
				installPowerKeyWindow.Owner = base.ParentWindow;
				if (installPowerKeyWindow.ShowDialog() != true)
				{
					return;
				}
				int num = 1;
				if (HZl9m5m9qhNx3QG49GT != null)
				{
					int num2 = default(int);
					num = num2;
				}
				do
				{
					PowerKey obj;
					bool keepOriginKeyFunc;
					switch (num)
					{
					case 1:
					{
						if (!jYgDtjae2Y.ContainsKey(installPowerKeyWindow.Key))
						{
							obj = new PowerKey
							{
								Key = installPowerKeyWindow.Key
							};
							keepOriginKeyFunc = installPowerKeyWindow.Key != sharedPowerKeyDto.Key || sharedPowerKeyDto.KeepOriginKeyFunc;
							goto IL_00f4;
						}
						PowerKey powerKey = jYgDtjae2Y[installPowerKeyWindow.Key];
						foreach (PowerKeyActionItem action in installPowerKeyWindow.Actions)
						{
							powerKey.KeyActions.Add(action);
						}
						h1x56k6GOl();
						Save();
						ePd5o2lxjC();
						break;
					}
					}
					break;
					IL_00f4:
					obj.KeepOriginKeyFunc = keepOriginKeyFunc;
					obj.Id = Guid.NewGuid();
					obj.IsEnabled = true;
					obj.KeyActions = installPowerKeyWindow.Actions;
					PowerKey value = obj;
					jYgDtjae2Y.Add(installPowerKeyWindow.Key, value);
					UpdateKeyList(installPowerKeyWindow.Key);
					Save();
					num = 0;
				}
				while (D5QweEmLS3q13XefEbE());
				AppHelper.ShowInformation($"共导入了 {installPowerKeyWindow.Actions.Count} 个按键组合。");
			}
			else
			{
				AppHelper.ShowWarning("文件内容不正确，可能不是扩展热键导出的数据。");
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("操作失败：" + ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HSZDvIWpPH)
		{
			HSZDvIWpPH = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/powerkeysmanagementpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			CbPowerKeys = (ComboBox)target;
			num = 0;
			if (HZl9m5m9qhNx3QG49GT != null)
			{
				goto IL_0158;
			}
			goto IL_0182;
		case 2:
			BtnAddPowerKey = (Button)target;
			BtnAddPowerKey.Click += lMV5QHotNO;
			break;
		case 3:
			BtnDeletePowerKey = (Button)target;
			num = 0;
			if (!D5QweEmLS3q13XefEbE())
			{
				goto IL_0154;
			}
			goto IL_0158;
		case 4:
			BtnChangePowerKey = (Button)target;
			BtnChangePowerKey.Click += wEN5Di2cFt;
			break;
		case 5:
			BtnInstallSharedPowerKey = (Button)target;
			BtnInstallSharedPowerKey.Click += Lm45FSAHFS;
			break;
		case 6:
			BtnImport = (Button)target;
			BtnImport.Click += LE95iDYrE8;
			break;
		case 7:
			GridContent = (Grid)target;
			num = 1;
			if (HZl9m5m9qhNx3QG49GT != null)
			{
				goto IL_0154;
			}
			goto IL_0158;
		case 8:
			ChkEnable = (ToggleButton)target;
			ChkEnable.Click += cBx5j01OCn;
			break;
		case 9:
			ChkEnableDefaultAction = (CheckBox)target;
			ChkEnableDefaultAction.Click += MDx5niYbN4;
			break;
		case 10:
			BlackListEditor = (ProcessSelectorControl)target;
			break;
		case 11:
			BtnAddAction = (Button)target;
			BtnAddAction.Click += MuQ5BdRHJK;
			break;
		case 12:
			LvActions = (ListView)target;
			break;
		case 13:
			MenuAddToGroup = (MenuItem)target;
			break;
		case 14:
			MenuShare = (MenuItem)target;
			MenuShare.Click += bmo5OMHS4k;
			break;
		case 15:
			MenuExport = (MenuItem)target;
			MenuExport.Click += xOq5lCAOhX;
			break;
		case 16:
			MenuDelete = (MenuItem)target;
			MenuDelete.Click += ojB5pOU3HJ;
			break;
		default:
			HSZDvIWpPH = true;
			break;
		case 21:
			GroupTab = (TabControl)target;
			GroupTab.SelectionChanged += pQH5Ayqwlg;
			break;
		case 22:
			PnlVersionTip = (StackPanel)target;
			break;
		case 23:
			{
				LblVersionTip = (TextBlock)target;
				break;
			}
			IL_0154:
			num = num2;
			goto IL_0158;
			IL_0158:
			switch (num)
			{
			default:
				BtnDeletePowerKey.Click += kkK55XtVhM;
				return;
			case 1:
				return;
			case 2:
				break;
			}
			goto IL_0182;
			IL_0182:
			CbPowerKeys.SelectionChanged += urR51ilA5s;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 17:
			((CheckBox)target).Click += KWY5UqnREk;
			break;
		case 18:
			((Button)target).Click += PZU5K0k1BE;
			break;
		case 19:
			((Button)target).Click += sCk5rjcxMF;
			break;
		case 20:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(Nuu5mmvyD7);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	[CompilerGenerated]
	internal static void PfG53HojWd(int int_0, ref _003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_0_0)
	{
		if (!_003C_003Ec__DisplayClass15_0_0.mDOvZn59KCN.ContainsKey(int_0))
		{
			_003C_003Ec__DisplayClass15_0_0.mDOvZn59KCN.Add(int_0, new PowerKey
			{
				IsEnabled = false,
				Key = int_0,
				KeepOriginKeyFunc = true,
				Id = Guid.NewGuid(),
				KeyActions = new List<PowerKeyActionItem>()
			});
		}
	}

	internal static bool D5QweEmLS3q13XefEbE()
	{
		return HZl9m5m9qhNx3QG49GT == null;
	}

	internal static void qyfSxamolqMxu0m9Tv4()
	{
	}
}
