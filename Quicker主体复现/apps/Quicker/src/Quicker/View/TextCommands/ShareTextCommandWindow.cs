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

namespace Quicker.View.TextCommands;

public class ShareTextCommandWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec XgkSQsUKiMv;

		public static Func<SharedTextCommandPackageDto, string> IuHSQH5pHU9;

		public static Func<string, string> EuZSQ1380ko;

		private static _003C_003Ec CwOVAOWIWFlKYGm9hSI7;

		static _003C_003Ec()
		{
			XgkSQsUKiMv = new _003C_003Ec();
		}

		internal string a8pSQkIFO8X(SharedTextCommandPackageDto x)
		{
			return x.Title;
		}

		internal string EpISQGCMOpS(string x)
		{
			return x;
		}

		internal static void BAWMjoWIX0v08T7FWNpa()
		{
		}

		internal static bool SSLu9fWIyjeDhTLuAXW8()
		{
			return CwOVAOWIWFlKYGm9hSI7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareTextCommandWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object GhXhLpWI2w2uXR63y5Go;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareTextCommandWindow shareTextCommandWindow = _003C_003E4__this;
			try
			{
        ShareTextCommandsVm shareTextCommandsVm_ = default;
				if (num == 0)
				{
					goto IL_0180;
				}
				int num2;
				if (!string.IsNullOrEmpty(shareTextCommandWindow.CbTitle.Text))
				{
					if (shareTextCommandWindow.CbSharePublic.IsChecked == false)
					{
						num2 = 1;
						if (GhXhLpWI2w2uXR63y5Go != null)
						{
							goto IL_0070;
						}
						goto IL_00a0;
					}
					goto IL_00bd;
				}
				AppHelper.ShowWarning("标题不能为空！");
				shareTextCommandWindow.CbTitle.Focus();
				goto end_IL_000e;
				IL_00bd:
				shareTextCommandsVm_ = default(ShareTextCommandsVm);
				if (shareTextCommandWindow.TxtDescription.EnsureNotEmpty("说明"))
				{
					IList<TextCommand> list = JsonConvert.DeserializeObject<IList<TextCommand>>(JsonConvert.SerializeObject(shareTextCommandWindow.FGnL2yDmeVO));
					IEnumerator<TextCommand> enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Id = Guid.Empty;
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
					shareTextCommandsVm_ = new ShareTextCommandsVm
					{
						Title = shareTextCommandWindow.CbTitle.Text,
						Description = shareTextCommandWindow.TxtDescription.Text,
						ItemCount = shareTextCommandWindow.FGnL2yDmeVO.Count,
						Data = JsonConvert.SerializeObject(list),
						IsDisabled = (shareTextCommandWindow.CbShareNonPublic.IsChecked == true)
					};
					goto IL_0180;
				}
				goto end_IL_000e;
				IL_00a0:
				switch (num2)
				{
				case 1:
					break;
				default:
					AppHelper.ShowWarning("请选择是否公开分享。");
					goto end_IL_000e;
				}
				goto IL_0070;
				IL_0180:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.BI2t1nSVmQC(shareTextCommandsVm_).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01f2;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<ShareObjectResult>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num3 = 1;
					if (GhXhLpWI2w2uXR63y5Go == null)
					{
						goto IL_0224;
					}
					goto IL_0231;
					IL_0224:
					switch (num3)
					{
					case 1:
						break;
					default:
						goto IL_0231;
					}
					goto IL_01f2;
					IL_0231:
					AppHelper.ShowSuccess("分享成功！\n已打开分享的配置包网页，您可以在网页中补充信息。");
					shareTextCommandWindow.Close();
					goto end_IL_0180;
					IL_01f2:
					ApiResult<ShareObjectResult> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						AppHelper.TryOpenUrlOrFile(result.Data.Url);
						num3 = 0;
						if (GhXhLpWI2w2uXR63y5Go != null)
						{
							int num4 = default(int);
							num3 = num4;
						}
						goto IL_0224;
					}
					AppHelper.ShowWarning(result.Message, true);
					end_IL_0180:;
				}
				catch (Exception ex)
				{
					iaIL28F43Mf.Warn("分享文本指令出错。" + ex.GetMessageWithInner(), ex);
					AppHelper.ShowWarning("分享出错：" + ex.Message);
				}
				goto end_IL_000e;
				IL_0070:
				if (shareTextCommandWindow.CbShareNonPublic.IsChecked == false)
				{
					num2 = 0;
					if (GhXhLpWI2w2uXR63y5Go != null)
					{
						int num5 = default(int);
						num2 = num5;
					}
					goto IL_00a0;
				}
				goto IL_00bd;
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

		internal static bool V6cNIyWIAvpZqm5Y2Ge0()
		{
			return GhXhLpWI2w2uXR63y5Go == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareTextCommandWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<SharedTextCommandPackageDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object np1SlQWIj3CJq9OsDCIh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareTextCommandWindow shareTextCommandWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					shareTextCommandWindow.LblInfo.Text = $"共 {shareTextCommandWindow.FGnL2yDmeVO.Count} 个文本指令。";
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<SharedTextCommandPackageDto>>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.wVLt15c7QDV().ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<SharedTextCommandPackageDto>>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<IList<SharedTextCommandPackageDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						shareTextCommandWindow.wy4L2aDsqP3 = result.Data;
						IEnumerator<string> enumerator = result.Data.Select(_003C_003Ec.IuHSQH5pHU9 ?? (_003C_003Ec.IuHSQH5pHU9 = _003C_003Ec.XgkSQsUKiMv.a8pSQkIFO8X)).OrderBy(_003C_003Ec.EuZSQ1380ko ?? (_003C_003Ec.EuZSQ1380ko = _003C_003Ec.XgkSQsUKiMv.EpISQGCMOpS)).GetEnumerator();
						int num2 = 0;
						if (!rumicpWID8DT2jMsPwgx())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						default:
							try
							{
								while (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									shareTextCommandWindow.CbTitle.Items.Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
							break;
						}
					}
				}
				catch (Exception exception)
				{
					string message = "加载已分享的文本指令配置包出错。" + exception.GetMessageWithInner();
					iaIL28F43Mf.Warn(message, exception);
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

		internal static bool rumicpWID8DT2jMsPwgx()
		{
			return np1SlQWIj3CJq9OsDCIh == null;
		}
	}

	private readonly IList<TextCommand> FGnL2yDmeVO;

	private static readonly ILog iaIL28F43Mf;

	private IList<SharedTextCommandPackageDto> wy4L2aDsqP3;

	internal RadioButton CbShareNonPublic;

	internal RadioButton CbSharePublic;

	internal ComboBox CbTitle;

	internal TextBlock LblOldSharedInfo;

	internal TextBox TxtDescription;

	internal TextBlock LblInfo;

	internal Button BtnShare;

	private bool GH3L27yel1h;

	private static ShareTextCommandWindow SwDaj7FeRGpgIqgAYhJ8;

	public ShareTextCommandWindow(IList<TextCommand> items)
	{
		FGnL2yDmeVO = items;
		InitializeComponent();
		base.Loaded += OMXL20wwDUe;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__5))]
	private void OMXL20wwDUe(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__5 stateMachine = default(_003COnLoaded_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__6))]
	private void QobL2C2MC45(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__6 stateMachine = default(_003CBtnShare_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void clBL2PRNyJG(object sender, TextChangedEventArgs e)
	{
		LblOldSharedInfo.Text = "将分享新的配置包。";
		LblOldSharedInfo.Tag = null;
		if (!wy4L2aDsqP3.HasData())
		{
			return;
		}
		string text = CbTitle.Text;
		foreach (SharedTextCommandPackageDto item in wy4L2aDsqP3)
		{
			if (string.Equals(item.Title, text, StringComparison.OrdinalIgnoreCase))
			{
				TxtDescription.Text = item.Description;
				LblOldSharedInfo.Text = "更新已分享的配置包，点击查看详情。\n上次更新时间：" + (item.LastUpdateTimeUtc ?? item.CreateTimeUtc).ToLocalTime().ToString("yyyy-MM-dd HH:mm");
				LblOldSharedInfo.Tag = item.Id;
				break;
			}
		}
	}

	private void TV2L2Ex0cxF(object sender, MouseButtonEventArgs e)
	{
		object tag = LblOldSharedInfo.Tag;
		if (tag != null)
		{
			AppHelper.TryOpenUrlOrFile("https://getquicker.net/share/textcommands/package?id=" + tag.ToString());
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!GH3L27yel1h)
		{
			GH3L27yel1h = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/textcommands/sharetextcommandwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			GH3L27yel1h = true;
			break;
		case 1:
			CbShareNonPublic = (RadioButton)target;
			break;
		case 2:
			CbSharePublic = (RadioButton)target;
			break;
		case 3:
			CbTitle = (ComboBox)target;
			CbTitle.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(clBL2PRNyJG));
			break;
		case 4:
			LblOldSharedInfo = (TextBlock)target;
			LblOldSharedInfo.MouseDown += TV2L2Ex0cxF;
			break;
		case 5:
			TxtDescription = (TextBox)target;
			break;
		case 6:
			LblInfo = (TextBlock)target;
			break;
		case 7:
			BtnShare = (Button)target;
			if (gy6CSWFeg4PWAaVBCuq3())
			{
				switch (0)
				{
				}
			}
			BtnShare.Click += QobL2C2MC45;
			break;
		}
	}

	static ShareTextCommandWindow()
	{
		iaIL28F43Mf = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool gy6CSWFeg4PWAaVBCuq3()
	{
		return SwDaj7FeRGpgIqgAYhJ8 == null;
	}
}
