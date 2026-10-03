using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.View.PowerKeys;

public class SharePowerKeyWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec glLS4wVRqti;

		public static Func<SharedPowerKeyDto, string> ShvS4ttNFJe;

		public static Func<string, string> LuNS4gMoqjn;

		private static _003C_003Ec JqxA0LWtUPHZakHxTBkN;

		static _003C_003Ec()
		{
			glLS4wVRqti = new _003C_003Ec();
		}

		internal string vAkSnfNwA0Q(SharedPowerKeyDto x)
		{
			return x.Title;
		}

		internal string GbTSnz9Y4uF(string x)
		{
			return x;
		}

		internal static bool KjNTulWtxq8aieJ9UOU7()
		{
			return JqxA0LWtUPHZakHxTBkN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharePowerKeyWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object pdC8RcWttQoCvI6QZZQn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharePowerKeyWindow sharePowerKeyWindow = _003C_003E4__this;
			try
			{
        SharePowerKeyVm sharePowerKeyVm_ = default;
				if (num == 0)
				{
					goto IL_015f;
				}
				sharePowerKeyVm_ = default(SharePowerKeyVm);
				if (string.IsNullOrEmpty(sharePowerKeyWindow.CbTitle.Text))
				{
					AppHelper.ShowWarning("标题不能为空！");
					int num2 = 0;
					if (!aZol38WtSNP7yq6NEFGg())
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							goto end_IL_005c;
						}
						do
						{
							sharePowerKeyWindow.CbTitle.Focus();
							num2 = 1;
						}
						while (pdC8RcWttQoCvI6QZZQn != null);
						continue;
						end_IL_005c:
						break;
					}
				}
				else if (sharePowerKeyWindow.CbSharePublic.IsChecked == false && sharePowerKeyWindow.CbShareNonPublic.IsChecked == false)
				{
					AppHelper.ShowWarning("请选择是否公开分享扩展热键包。");
				}
				else if (sharePowerKeyWindow.TxtDescription.EnsureNotEmpty("说明"))
				{
					sharePowerKeyVm_ = new SharePowerKeyVm
					{
						Title = sharePowerKeyWindow.CbTitle.Text,
						Description = sharePowerKeyWindow.TxtDescription.Text,
						Key = sharePowerKeyWindow.G2PLJriyZf6.Key,
						KeepOriginKeyFunc = sharePowerKeyWindow.G2PLJriyZf6.KeepOriginKeyFunc,
						ItemCount = sharePowerKeyWindow.g4TLJppf6bA.Count,
						Data = JsonConvert.SerializeObject(sharePowerKeyWindow.g4TLJppf6bA),
						IsDisabled = (sharePowerKeyWindow.CbShareNonPublic.IsChecked == true)
					};
					goto IL_015f;
				}
				goto end_IL_000e;
				IL_015f:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter awaiter;
					int num4;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.IX2t1Btwolg(sharePowerKeyVm_).ConfigureAwait(true).GetAwaiter();
						num4 = 0;
						if (pdC8RcWttQoCvI6QZZQn != null)
						{
							goto IL_01b3;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						num4 = 1;
						if (!aZol38WtSNP7yq6NEFGg())
						{
							goto IL_01b3;
						}
					}
					goto IL_01b5;
					IL_01b5:
					switch (num4)
					{
					default:
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					case 1:
						break;
					}
					ApiResult<ShareObjectResult> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						AppHelper.TryOpenUrlOrFile(result.Data.Url);
						AppHelper.ShowSuccess("分享成功！\n已打开分享的配置包网页，您可以在网页中补充信息。");
						sharePowerKeyWindow.Close();
					}
					else
					{
						AppHelper.ShowWarning(result.Message, true);
					}
					goto end_IL_015f;
					IL_01b3:
					int num5 = default(int);
					num4 = num5;
					goto IL_01b5;
					end_IL_015f:;
				}
				catch (Exception ex)
				{
					kDoLJQvewJQ.Warn("分享扩展热键出错。" + ex.GetMessageWithInner(), ex);
					AppHelper.ShowWarning("分享出错：" + ex.Message);
				}
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

		internal static bool aZol38WtSNP7yq6NEFGg()
		{
			return pdC8RcWttQoCvI6QZZQn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SharePowerKeyWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<SharedPowerKeyDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object dyskNOWtmJReV6EhcDOp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SharePowerKeyWindow sharePowerKeyWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					sharePowerKeyWindow.LblInfo.Text = $"共 {sharePowerKeyWindow.g4TLJppf6bA.Count} 个按键操作。";
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<SharedPowerKeyDto>>>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<SharedPowerKeyDto>>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					else
					{
						awaiter = aFIptTXYsUoTUF4v33R.eGyt1jT4Onb().ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					ApiResult<IList<SharedPowerKeyDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						sharePowerKeyWindow.UplLJj7tgo9 = result.Data;
						IEnumerator<string> enumerator = result.Data.Select(_003C_003Ec.ShvS4ttNFJe ?? (_003C_003Ec.ShvS4ttNFJe = _003C_003Ec.glLS4wVRqti.vAkSnfNwA0Q)).OrderBy(_003C_003Ec.LuNS4gMoqjn ?? (_003C_003Ec.LuNS4gMoqjn = _003C_003Ec.glLS4wVRqti.GbTSnz9Y4uF)).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								sharePowerKeyWindow.CbTitle.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
					}
				}
				catch (Exception exception)
				{
					string message = "加载已分享的文本指令配置包出错。" + exception.GetMessageWithInner();
					kDoLJQvewJQ.Warn(message, exception);
					AppHelper.ShowWarning(message);
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

		internal static bool JayXouWtsNuh4Ohiuh2l()
		{
			return dyskNOWtmJReV6EhcDOp == null;
		}
	}

	private readonly PowerKey G2PLJriyZf6;

	private readonly IList<PowerKeyActionItem> g4TLJppf6bA;

	private readonly string hrSLJBPR2cE;

	private static readonly ILog kDoLJQvewJQ;

	private IList<SharedPowerKeyDto> UplLJj7tgo9;

	internal RadioButton CbShareNonPublic;

	internal RadioButton CbSharePublic;

	internal ComboBox CbTitle;

	internal TextBlock LblOldSharedInfo;

	internal TextBox TxtDescription;

	internal TextBlock LblInfo;

	internal Button BtnShare;

	private bool HUmLJngkutF;

	private static SharePowerKeyWindow ReTHc8FDxK6HGdGtr9kS;

	public SharePowerKeyWindow(PowerKey powerKey, IList<PowerKeyActionItem> selectedActionItems, string groupName)
	{
		G2PLJriyZf6 = powerKey;
		g4TLJppf6bA = selectedActionItems;
		hrSLJBPR2cE = groupName;
		InitializeComponent();
		base.Loaded += yS2LJX9RTl9;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__7))]
	private void yS2LJX9RTl9(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__7 stateMachine = default(_003COnLoaded_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__8))]
	private void A36LJmeAObI(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__8 stateMachine = default(_003CBtnShare_OnClick_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Vn2LJKiIGQO(object sender, TextChangedEventArgs e)
	{
		string text = CbTitle.Text;
		LblOldSharedInfo.Text = "将分享新的配置包。";
		LblOldSharedInfo.Tag = null;
		if (!UplLJj7tgo9.HasData())
		{
			return;
		}
		foreach (SharedPowerKeyDto item in UplLJj7tgo9)
		{
			if (string.Equals(item.Title, text))
			{
				TxtDescription.Text = item.Description;
				LblOldSharedInfo.Text = "更新已分享的配置包，点击查看详情。\n上次更新时间：" + (item.LastUpdateTimeUtc ?? item.CreateTimeUtc).ToLocalTime().ToString("yyyy-MM-dd HH:mm");
				LblOldSharedInfo.Tag = item.Id;
				break;
			}
		}
	}

	private void UOsLJxqQbNO(object sender, MouseButtonEventArgs e)
	{
		object tag = LblOldSharedInfo.Tag;
		if (tag != null)
		{
			AppHelper.TryOpenUrlOrFile("https://getquicker.net/share/powerkeys/package?id=" + tag.ToString());
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HUmLJngkutF)
		{
			HUmLJngkutF = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/powerkeys/sharepowerkeywindow.xaml", UriKind.Relative);
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
		case 1:
			CbShareNonPublic = (RadioButton)target;
			return;
		case 2:
			CbSharePublic = (RadioButton)target;
			return;
		case 3:
			CbTitle = (ComboBox)target;
			CbTitle.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(Vn2LJKiIGQO));
			return;
		case 4:
			LblOldSharedInfo = (TextBlock)target;
			LblOldSharedInfo.MouseDown += UOsLJxqQbNO;
			return;
		case 5:
			TxtDescription = (TextBox)target;
			return;
		case 6:
			LblInfo = (TextBlock)target;
			return;
		case 7:
			BtnShare = (Button)target;
			BtnShare.Click += A36LJmeAObI;
			return;
		}
		HUmLJngkutF = true;
		int num = 0;
		if (!qYyPudFDIssPyL5lsakK())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	static SharePowerKeyWindow()
	{
		kDoLJQvewJQ = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool qYyPudFDIssPyL5lsakK()
	{
		return ReTHc8FDxK6HGdGtr9kS == null;
	}

	internal static void oQZMwJFDwgFOA6IeOjTI()
	{
	}
}
