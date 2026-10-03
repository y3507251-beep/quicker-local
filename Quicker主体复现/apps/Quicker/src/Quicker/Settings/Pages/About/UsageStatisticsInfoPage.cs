using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Settings.Pages.About;

public class UsageStatisticsInfoPage : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BkNvVAFBMaO;

		public static Func<KeyValuePair<Guid, int>, int> uivvVOeZiRG;

		public static Func<KeyValuePair<Guid, int>, bool> RHpvVFIKmJ6;

		public static Func<KeyValuePair<Guid, int>, int> jqKvVU5uaV8;

		public static Func<ActionCountItem, int> QTHvVl3clie;

		internal static _003C_003Ec b2Z5Kmc9qGFnGJFp93g1;

		static _003C_003Ec()
		{
			BkNvVAFBMaO = new _003C_003Ec();
		}

		internal int YaovVd3DqYL(KeyValuePair<Guid, int> x)
		{
			return x.Value;
		}

		internal bool AxEvVoKZQnT(KeyValuePair<Guid, int> x)
		{
			return !x.Key.ToString().ContainedIn("0bbac09b-0638-42cc-a1fc-89e54d46d2f1", "be1ec1a6-bd93-4ba4-a9cd-d633147b24c9", "a8653108-7119-4d22-af4a-b2011d8c1c34", "37d319ff-2556-43d7-ad8b-308b022daae8", "c7afdc90-849f-45d9-9695-080c0c89c670", "05dc2fad-9ae0-4191-bdd7-700e60e161a8", "69c1f6a5-5f18-49ec-8763-01fc39217307", "8a79062f-b845-47be-b129-b6295e0127f4", "56f7fc59-caaa-4deb-8c3a-2531b326808c", "49745cc1-52dc-46fd-ad2a-ba5a7f588368", "0c0a7ed2-eeeb-4d8e-8a43-1cc068dc5cb0", "ec9e8cd1-ffb5-4dd2-8709-112178ec7a95", "f37a4b55-8e9f-43a6-8a4e-2b067cda9e13", "8b8ba8cd-9dc1-46b8-9923-48a82e152df6", "b6235217-b17f-4d25-9206-73657977d01a", "f1ff1e30-86f7-4e9d-8336-5d0ba8af2524", "fb8cec84-b07c-4852-92f6-4bdcbc1860ba", "f2c0f712-2966-46fe-be7b-e00850e79e99");
		}

		internal int SNpvVTlHpKT(KeyValuePair<Guid, int> x)
		{
			return x.Value;
		}

		internal int X83vVMjSmWx(ActionCountItem x)
		{
			return x.Count;
		}

		internal static void SBugh4c9ZNoiMbIEqRyg()
		{
		}

		internal static bool d0E3Wxc9inEhgDgkEbsU()
		{
			return b2Z5Kmc9qGFnGJFp93g1 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CButtonQuery_Click_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UsageStatisticsInfoPage _003C_003E4__this;

		public object sender;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object rR6sqMc95NPNBZXRV3Iy;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UsageStatisticsInfoPage usageStatisticsInfoPage = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00cb;
					}
					usageStatisticsInfoPage.PnlButtons.IsEnabled = false;
					object obj = (sender as Button)?.Tag;
					if (obj != null)
					{
						int int_ = Convert.ToInt32(obj);
						awaiter = usageStatisticsInfoPage.hUg4GxqHCW(int_).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							int num2 = 0;
							if (rR6sqMc95NPNBZXRV3Iy != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00cb;
					}
					goto end_IL_0011;
					IL_00cb:
					awaiter.GetResult();
					end_IL_0011:;
				}
				finally
				{
					if (num < 0)
					{
						usageStatisticsInfoPage.PnlButtons.IsEnabled = true;
					}
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

		internal static bool fcI2EUc9Yomu413ydRqq()
		{
			return rR6sqMc95NPNBZXRV3Iy == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoQueryAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UsageStatisticsInfoPage _003C_003E4__this;

		public int days;

		private ConfiguredTaskAwaitable<ApiResult<IDictionary<Guid, int>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object PMuZN8c9RfDwtp9r0bSU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UsageStatisticsInfoPage usageStatisticsInfoPage = _003C_003E4__this;
			try
			{
				try
				{
        ConfiguredTaskAwaitable<ApiResult<IDictionary<Guid, int>>> configuredTaskAwaitable = default;
					if (num != 0)
					{
						usageStatisticsInfoPage.HeaderGroup.Header = ((days > 0) ? $"近 {days} 天使用" : "总使用");
						goto IL_0095;
					}
					ConfiguredTaskAwaitable<ApiResult<IDictionary<Guid, int>>>.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IDictionary<Guid, int>>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0120;
					IL_0136:
					IDictionary<Guid, int> value;
					int num2 = value.Sum(_003C_003Ec.uivvVOeZiRG ?? (_003C_003Ec.uivvVOeZiRG = _003C_003Ec.BkNvVAFBMaO.YaovVd3DqYL));
					int num3 = value.Where(_003C_003Ec.RHpvVFIKmJ6 ?? (_003C_003Ec.RHpvVFIKmJ6 = _003C_003Ec.BkNvVAFBMaO.AxEvVoKZQnT)).Select(_003C_003Ec.jqKvVU5uaV8 ?? (_003C_003Ec.jqKvVU5uaV8 = _003C_003Ec.BkNvVAFBMaO.SNpvVTlHpKT)).Sum();
					usageStatisticsInfoPage.TxtActionCount.Text = "动作：" + num3;
					usageStatisticsInfoPage.TxtOperationCount.Text = "操作(触发方式)：" + (num2 - num3);
					List<ActionCountItem> list = new List<ActionCountItem>();
					int num4 = 0;
					IEnumerator<KeyValuePair<Guid, int>> enumerator = value.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<Guid, int> current = enumerator.Current;
							string text = current.Key.ToString();
							(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(text);
							ActionCountItem obj = new ActionCountItem
							{
								Count = current.Value,
								Id = text
							};
							var (actionItem, _) = actionById;
							object obj2;
							if (actionItem == null)
							{
								obj2 = null;
							}
							else
							{
								obj2 = actionItem.Title;
								if (obj2 != null)
								{
									goto IL_0270;
								}
							}
							obj2 = usageStatisticsInfoPage.s0H4W4lK9L(text);
							goto IL_0270;
							IL_0292:
							object obj3;
							obj.Icon = (string)obj3;
							obj.Profile = actionById.Item2?.Name;
							ActionCountItem actionCountItem = obj;
							if (string.IsNullOrEmpty(actionCountItem.Title))
							{
								num4 += current.Value;
							}
							else
							{
								list.Add(actionCountItem);
							}
							continue;
							IL_0270:
							obj.Title = (string)obj2;
							var (actionItem2, _) = actionById;
							if (actionItem2 == null)
							{
								obj3 = null;
							}
							else
							{
								obj3 = actionItem2.Icon;
								if (obj3 != null)
								{
									goto IL_0292;
								}
							}
							obj3 = "";
							goto IL_0292;
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
					list = list.OrderByDescending(_003C_003Ec.QTHvVl3clie ?? (_003C_003Ec.QTHvVl3clie = _003C_003Ec.BkNvVAFBMaO.X83vVMjSmWx)).Take(250).ToList();
					ObservableCollection<ActionCountItem> itemsSource = new ObservableCollection<ActionCountItem>(list);
					usageStatisticsInfoPage.LvActions.ItemsSource = itemsSource;
					goto end_IL_000f;
					IL_0095:
					dDh7g7Xw7JyQPUTbYwJ.ViewStaticDays = days;
					value = null;
					configuredTaskAwaitable = default(ConfiguredTaskAwaitable<ApiResult<IDictionary<Guid, int>>>);
					int num5;
					if (!usageStatisticsInfoPage.twu41mmKRb.TryGetValue(days, out value) || value == null)
					{
						configuredTaskAwaitable = aFIptTXYsUoTUF4v33R.QNCtbECIxo5(days).ConfigureAwait(true);
						num5 = 0;
						if (PMuZN8c9RfDwtp9r0bSU != null)
						{
							goto IL_00db;
						}
						goto IL_00ef;
					}
					goto IL_0136;
					IL_00ef:
					awaiter = configuredTaskAwaitable.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0120;
					IL_00db:
					switch (num5)
					{
					case 2:
						break;
					default:
						goto IL_00ef;
					case 1:
						goto IL_0136;
					}
					goto IL_0095;
					IL_0120:
					ApiResult<IDictionary<Guid, int>> result = awaiter.GetResult();
					if (!result.IsSuccess)
					{
						AppHelper.ShowWarning("获取数据出错：" + result.Message);
					}
					usageStatisticsInfoPage.twu41mmKRb[days] = result.Data;
					value = result.Data;
					num5 = 1;
					if (!u0Q6VAc9g86qloQBwyjl())
					{
						goto IL_00db;
					}
					goto IL_0136;
					end_IL_000f:;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("加载数据失败！" + exception.GetMessageWithInner());
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

		internal static bool u0Q6VAc9g86qloQBwyjl()
		{
			return PMuZN8c9RfDwtp9r0bSU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UsageStatisticsInfoPage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object Y0JDGNc9IvPrxXLLJ7Pf;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UsageStatisticsInfoPage usageStatisticsInfoPage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = usageStatisticsInfoPage.hUg4GxqHCW(dDh7g7Xw7JyQPUTbYwJ.ViewStaticDays).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (!cVnkrWc96Wsx6nDQYix3())
						{
							switch (0)
							{
							}
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool cVnkrWc96Wsx6nDQYix3()
		{
			return Y0JDGNc9IvPrxXLLJ7Pf == null;
		}
	}

	private IDictionary<int, IDictionary<Guid, int>> twu41mmKRb = new Dictionary<int, IDictionary<Guid, int>>();

	internal GroupBox HeaderGroup;

	internal TextBlock TxtActionCount;

	internal TextBlock TxtOperationCount;

	internal ListView LvActions;

	internal TextBlock TxtInfo;

	internal StackPanel PnlButtons;

	private bool Ew24bei9GF;

	private static UsageStatisticsInfoPage XNUScNT7CrJC1MgL5TA;

	public UsageStatisticsInfoPage()
	{
		InitializeComponent();
		base.Loaded += Nw04kuvAxZ;
	}

	private string s0H4W4lK9L(string string_0)
	{
		return string_0 switch
		{
			"56f7fc59-caaa-4deb-8c3a-2531b326808c" => "操作：搜索框", 
			"8b8ba8cd-9dc1-46b8-9923-48a82e152df6" => "操作：外部启动", 
			"49745cc1-52dc-46fd-ad2a-ba5a7f588368" => "操作：按键双击", 
			"0c0a7ed2-eeeb-4d8e-8a43-1cc068dc5cb0" => "操作：热键联动", 
			"05dc2fad-9ae0-4191-bdd7-700e60e161a8" => "操作：悬浮动作页", 
			"f1ff1e30-86f7-4e9d-8336-5d0ba8af2524" => "操作：事件触发", 
			"00000000-0000-0000-0000-000000000000" => "*临时动作*", 
			"a8653108-7119-4d22-af4a-b2011d8c1c34" => "操作：文本指令", 
			"69c1f6a5-5f18-49ec-8763-01fc39217307" => "操作：文本悬浮窗", 
			"ec9e8cd1-ffb5-4dd2-8709-112178ec7a95" => "操作：上下文菜单", 
			"0bbac09b-0638-42cc-a1fc-89e54d46d2f1" => "操作：扩展热键", 
			"8a79062f-b845-47be-b129-b6295e0127f4" => "操作：滚轮触发", 
			"37d319ff-2556-43d7-ad8b-308b022daae8" => "操作：左键辅助", 
			"f2c0f712-2966-46fe-be7b-e00850e79e99" => "操作：快捷键", 
			"fb8cec84-b07c-4852-92f6-4bdcbc1860ba" => "操作：高级鼠标触发", 
			"b6235217-b17f-4d25-9206-73657977d01a" => "操作：自动运行", 
			"f37a4b55-8e9f-43a6-8a4e-2b067cda9e13" => "操作：推送服务", 
			"c7afdc90-849f-45d9-9695-080c0c89c670" => "操作：悬浮按钮", 
			"dc2b8c82-1d9a-4992-a31b-4dc59d60e758" => "操作：鼠标手势", 
			"be1ec1a6-bd93-4ba4-a9cd-d633147b24c9" => "操作：轮盘菜单", 
			_ => "", 
		};
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__2))]
	private void Nw04kuvAxZ(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__2 stateMachine = default(_003COnLoaded_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoQueryAsync_003Ed__4))]
	private Task hUg4GxqHCW(int int_0)
	{
		_003CDoQueryAsync_003Ed__4 stateMachine = default(_003CDoQueryAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.days = int_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void bqi4sjZEds(object sender, MouseButtonEventArgs e)
	{
		if (LvActions.SelectedItem != null && LvActions.SelectedItem is ActionCountItem actionCountItem)
		{
			ClipboardHelper.SetText(actionCountItem.Id);
			AppHelper.ShowInformation("已复制ID：" + actionCountItem.Id);
		}
	}

	[AsyncStateMachine(typeof(_003CButtonQuery_Click_003Ed__6))]
	private void isV4H7yLfm(object sender, RoutedEventArgs e)
	{
		_003CButtonQuery_Click_003Ed__6 stateMachine = default(_003CButtonQuery_Click_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Ew24bei9GF)
		{
			Ew24bei9GF = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/about/usagestatisticsinfopage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				HeaderGroup = (GroupBox)target;
				return;
			case 2:
				TxtActionCount = (TextBlock)target;
				return;
			case 3:
				TxtOperationCount = (TextBlock)target;
				return;
			case 4:
				LvActions = (ListView)target;
				LvActions.MouseDoubleClick += bqi4sjZEds;
				return;
			case 5:
				TxtInfo = (TextBlock)target;
				return;
			case 6:
				PnlButtons = (StackPanel)target;
				return;
			case 7:
				((Button)target).Click += isV4H7yLfm;
				return;
			case 8:
				((Button)target).Click += isV4H7yLfm;
				return;
			case 9:
				((Button)target).Click += isV4H7yLfm;
				return;
			case 10:
				((Button)target).Click += isV4H7yLfm;
				return;
			case 11:
				((Button)target).Click += isV4H7yLfm;
				return;
			}
			int num2 = 0;
			if (XNUScNT7CrJC1MgL5TA != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			Ew24bei9GF = true;
			return;
		}
	}

	internal static void P30vCnTHSCULP5EVcyN()
	{
	}

	internal static bool PfYtXAT4ioqMEChe5AR()
	{
		return XNUScNT7CrJC1MgL5TA == null;
	}
}
