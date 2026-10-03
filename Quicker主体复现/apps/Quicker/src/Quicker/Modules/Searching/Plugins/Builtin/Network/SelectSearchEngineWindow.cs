using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.Modules.Searching.Plugins.Builtin.Network;

public class SelectSearchEngineWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public SearchEngineCategoryDto fvGv67hJNId;

		private static _003C_003Ec__DisplayClass16_0 oCCggCcxpvo6YNOi93w0;

		internal bool aLNv6abXhiM(SearchEngineDto x)
		{
			return x.CategoryId == fvGv67hJNId.Id;
		}

		internal static bool THbYxBcxXk1hnfvcZ2yj()
		{
			return oCCggCcxpvo6YNOi93w0 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnOk_OnClick_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SelectSearchEngineWindow _003C_003E4__this;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		private static object XoL0srcxniywdePM9tD7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SelectSearchEngineWindow selectSearchEngineWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0047;
				}
				if (selectSearchEngineWindow.LvEngines.SelectedItem != null)
				{
					selectSearchEngineWindow.SelectedSearchEngine = selectSearchEngineWindow.LvEngines.SelectedItem as SearchEngineDto;
					goto IL_0047;
				}
				AppHelper.ShowWarning("请选择搜索引擎。");
				goto end_IL_000e;
				IL_0047:
				try
				{
					TaskAwaiter<ApiResult<string>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.vq7tbbfZDLn(selectSearchEngineWindow.SelectedSearchEngine.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							if (XoL0srcxniywdePM9tD7 != null)
							{
								switch (0)
								{
								}
							}
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
					AppHelper.ShowWarning("更新下载次数失败了。");
				}
				selectSearchEngineWindow.ThNvuM5Q9GQ(true);
				end_IL_000e:;
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

		internal static bool AamPDYcxer0jG76yEnDi()
		{
			return XoL0srcxniywdePM9tD7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectSearchEngineWindow_Loaded_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SelectSearchEngineWindow _003C_003E4__this;

		private TaskAwaiter<ApiResult<SearchEngineData>> _003C_003Eu__1;

		private static object fSYqM3cx3NiKcwpd1tYu;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SelectSearchEngineWindow selectSearchEngineWindow = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ApiResult<SearchEngineData>> awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.slotb1VEwjF().GetAwaiter();
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
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<SearchEngineData>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<SearchEngineData> result = awaiter.GetResult();
					int num2 = 0;
					if (fSYqM3cx3NiKcwpd1tYu != null)
					{
						goto IL_009b;
					}
					goto IL_009f;
					IL_009f:
					while (true)
					{
						switch (num2)
						{
						default:
							if (!result.IsSuccess)
							{
								AppHelper.ShowWarning("加载数据返回错误：" + result.Message);
								break;
							}
							goto IL_008e;
						case 1:
							selectSearchEngineWindow.nGvtE47UTwJ.Reset(result.Data.SearchEngineCategories);
							selectSearchEngineWindow.nGvtE47UTwJ.Insert(0, new SearchEngineCategoryDto
							{
								Id = Guid.Empty,
								Title = "*所有*"
							});
							selectSearchEngineWindow.CbCategory.ItemsSource = selectSearchEngineWindow.nGvtE47UTwJ;
							selectSearchEngineWindow.CbCategory.SelectedIndex = 0;
							selectSearchEngineWindow.ys6tE57EMtX = result.Data.SearchEngines;
							selectSearchEngineWindow.vAutED6eTXv.Reset(selectSearchEngineWindow.ys6tE57EMtX);
							break;
						}
						break;
						IL_008e:
						num2 = 1;
						if (fSYqM3cx3NiKcwpd1tYu == null)
						{
							continue;
						}
						goto IL_009b;
					}
					goto end_IL_0011;
					IL_009b:
					int num3 = default(int);
					num2 = num3;
					goto IL_009f;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("加载数据出错了！" + ex.Message);
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

		internal static bool v5rHTlcxEHpmK20EspR1()
		{
			return fSYqM3cx3NiKcwpd1tYu == null;
		}
	}

	private SmartCollection<SearchEngineCategoryDto> nGvtE47UTwJ = new SmartCollection<SearchEngineCategoryDto>();

	private IList<SearchEngineDto> ys6tE57EMtX = new List<SearchEngineDto>();

	private SmartCollection<SearchEngineDto> vAutED6eTXv = new SmartCollection<SearchEngineDto>();

	[CompilerGenerated]
	private SearchEngineDto rEitEdk3ELv;

	[CompilerGenerated]
	private bool? dJPtEo7JaOg;

	internal ComboBox CbCategory;

	internal ListView LvEngines;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool FDEtETVZImX;

	private static SelectSearchEngineWindow QmFUpRQDqOu7nBVh9X6x;

	public SearchEngineDto SelectedSearchEngine
	{
		[CompilerGenerated]
		get
		{
			return rEitEdk3ELv;
		}
		[CompilerGenerated]
		set
		{
			rEitEdk3ELv = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return dJPtEo7JaOg;
		}
		[CompilerGenerated]
		set
		{
			dJPtEo7JaOg = value;
		}
	}

	public SelectSearchEngineWindow()
	{
		InitializeComponent();
		base.Loaded += XiLtEBmJgYa;
		LvEngines.ItemsSource = vAutED6eTXv;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003CSelectSearchEngineWindow_Loaded_003Ed__9))]
	private void XiLtEBmJgYa(object sender, RoutedEventArgs e)
	{
		_003CSelectSearchEngineWindow_Loaded_003Ed__9 stateMachine = default(_003CSelectSearchEngineWindow_Loaded_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void YFntEQrlmST(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[AsyncStateMachine(typeof(_003CBtnOk_OnClick_003Ed__15))]
	private void QxltEjoeup1(object sender, RoutedEventArgs e)
	{
		_003CBtnOk_OnClick_003Ed__15 stateMachine = default(_003CBtnOk_OnClick_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void vQrtEnM9Z1p(object sender, SelectionChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.fvGv67hJNId = CbCategory.SelectedItem as SearchEngineCategoryDto;
		if (_003C_003Ec__DisplayClass16_.fvGv67hJNId == null || _003C_003Ec__DisplayClass16_.fvGv67hJNId.Id == Guid.Empty)
		{
			vAutED6eTXv.Reset(ys6tE57EMtX);
		}
		else
		{
			vAutED6eTXv.Reset(ys6tE57EMtX.Where(_003C_003Ec__DisplayClass16_.aLNv6abXhiM));
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!FDEtETVZImX)
		{
			FDEtETVZImX = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/network/selectsearchenginewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			FDEtETVZImX = true;
			break;
		case 1:
			CbCategory = (ComboBox)target;
			CbCategory.SelectionChanged += vQrtEnM9Z1p;
			break;
		case 2:
			LvEngines = (ListView)target;
			break;
		case 3:
			BtnOk = (Button)target;
			BtnOk.Click += QxltEjoeup1;
			if (pd7mKwQDivDhaG2AFsEp())
			{
				switch (0)
				{
				}
			}
			break;
		case 4:
			BtnCancel = (Button)target;
			BtnCancel.Click += YFntEQrlmST;
			break;
		}
	}

	internal static bool pd7mKwQDivDhaG2AFsEp()
	{
		return QmFUpRQDqOu7nBVh9X6x == null;
	}
}
