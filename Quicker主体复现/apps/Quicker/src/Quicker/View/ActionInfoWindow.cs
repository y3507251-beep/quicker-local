using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Extensions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View;

public class ActionInfoWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public ActionInfoWindow qwCSrwEjDxe;

		public ApiResult<SharedActionDto> WpXSrtVgjJg;

		internal static _003C_003Ec__DisplayClass3_0 rFlluYWgrmg9SRQdh5Gf;

		internal void AooSxz10G77()
		{
			qwCSrwEjDxe.LblAuthor.Text = WpXSrtVgjJg.Data.UserNickName;
			qwCSrwEjDxe.LnkAuthor.NavigateUri = new Uri(string.Format("{0}/User/Actions/{1}-{2}", "https://getquicker.net", WpXSrtVgjJg.Data.UserSerial, WpXSrtVgjJg.Data.UserNickName.UrlEncode()));
			qwCSrwEjDxe.LblLastVersion.Text = $"{WpXSrtVgjJg.Data.Revision} (更新时间：{AppHelper.GetLocalTimeString(WpXSrtVgjJg.Data.LastUpdateTimeUtc)})";
		}

		internal static void ACNgsXWgLKJHyL5dpctp()
		{
		}

		internal static bool WDRSsBWgNlqJko0pXXnx()
		{
			return rFlluYWgrmg9SRQdh5Gf == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionInfoWindow _003C_003E4__this;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object VcwAUCWgoteuBb0NuxOg;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionInfoWindow actionInfoWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass3_0();
					_003C_003E8__1.qwCSrwEjDxe = _003C_003E4__this;
					int num2 = 1;
					if (!BcMmUnWgfLwg3pc6NrUw())
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						default:
							goto end_IL_0187;
						case 2:
							goto end_IL_000e;
						}
						actionInfoWindow.LblId.Text = actionInfoWindow.dWOgl9TPQrA.Id;
						actionInfoWindow.LblLabel.Text = actionInfoWindow.dWOgl9TPQrA.Title;
						actionInfoWindow.LblDescription.Text = actionInfoWindow.dWOgl9TPQrA.Description;
						if (!string.IsNullOrEmpty(actionInfoWindow.dWOgl9TPQrA.Icon))
						{
							actionInfoWindow.TheIcon.Icon = actionInfoWindow.dWOgl9TPQrA.Icon;
						}
						actionInfoWindow.LblCreateTime.Text = AppHelper.GetLocalTimeString(actionInfoWindow.dWOgl9TPQrA.CreateTimeUtc);
						actionInfoWindow.LblLastEditTime.Text = AppHelper.GetLocalTimeString(actionInfoWindow.dWOgl9TPQrA.LastEditTimeUtc);
						if (!string.IsNullOrEmpty(actionInfoWindow.dWOgl9TPQrA.SharedActionId))
						{
							TextBlock lblShareInfo = actionInfoWindow.LblShareInfo;
							actionInfoWindow.PnlShareInfo.Visibility = Visibility.Visible;
							lblShareInfo.Visibility = Visibility.Visible;
							actionInfoWindow.LnkShare.NavigateUri = new Uri(AppHelper.CreateSharedActionLink(actionInfoWindow.dWOgl9TPQrA.SharedActionId));
							actionInfoWindow.LblShareTime.Text = AppHelper.GetLocalTimeString(actionInfoWindow.dWOgl9TPQrA.ShareTimeUtc);
						}
						else
						{
							TextBlock lblShareInfo2 = actionInfoWindow.LblShareInfo;
							actionInfoWindow.PnlShareInfo.Visibility = Visibility.Collapsed;
							lblShareInfo2.Visibility = Visibility.Collapsed;
						}
						if (!string.IsNullOrEmpty(actionInfoWindow.dWOgl9TPQrA.TemplateId))
						{
							num2 = 0;
							if (VcwAUCWgoteuBb0NuxOg == null)
							{
								break;
							}
							continue;
						}
						goto IL_0219;
						continue;
						end_IL_0187:
						break;
					}
					TextBlock lblSource = actionInfoWindow.LblSource;
					actionInfoWindow.PnlSource.Visibility = Visibility.Visible;
					lblSource.Visibility = Visibility.Visible;
					actionInfoWindow.LnkSource.NavigateUri = new Uri(AppHelper.CreateSharedActionLink(actionInfoWindow.dWOgl9TPQrA.TemplateId));
					actionInfoWindow.LblInstallVersion.Text = actionInfoWindow.dWOgl9TPQrA.TemplateRevision.ToString(CultureInfo.InvariantCulture);
					if (string.Equals(actionInfoWindow.dWOgl9TPQrA.TemplateId, actionInfoWindow.dWOgl9TPQrA.Id))
					{
						goto IL_0319;
					}
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.rh5t1oGDq2S(Guid.Parse(actionInfoWindow.dWOgl9TPQrA.TemplateId), actionInfoWindow.dWOgl9TPQrA.TemplateRevision).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<SharedActionDto> result = awaiter.GetResult();
					_003C_003E8__1.WpXSrtVgjJg = result;
					int num4 = 0;
					if (VcwAUCWgoteuBb0NuxOg != null)
					{
						int num5 = default(int);
						num4 = num5;
					}
					switch (num4)
					{
					default:
						if (_003C_003E8__1.WpXSrtVgjJg.IsSuccess)
						{
							actionInfoWindow.Dispatcher.Invoke(_003C_003E8__1.AooSxz10G77);
						}
						break;
					}
				}
				catch (Exception exception)
				{
					uRtglZKE50s.Warn("获取动作信息失败。", exception);
				}
				goto IL_0319;
				IL_0319:
				Dispatcher.FromThread(Thread.CurrentThread);
				actionInfoWindow.LblSize.Text = $"{AppHelper.GetActionSizeKb(actionInfoWindow.dWOgl9TPQrA)} KB";
				actionInfoWindow.LblAutoUpdate.Text = (actionInfoWindow.dWOgl9TPQrA.AutoUpdate ? "Y" : "N");
				goto end_IL_000e;
				IL_0219:
				TextBlock lblSource2 = actionInfoWindow.LblSource;
				actionInfoWindow.PnlSource.Visibility = Visibility.Collapsed;
				lblSource2.Visibility = Visibility.Collapsed;
				goto IL_0319;
				end_IL_000e:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool BcMmUnWgfLwg3pc6NrUw()
		{
			return VcwAUCWgoteuBb0NuxOg == null;
		}
	}

	private static readonly ILog uRtglZKE50s;

	private readonly ActionItem dWOgl9TPQrA;

	internal TextBlock LblId;

	internal TextBlock LblLabel;

	internal TextBlock LblDescription;

	internal IconControl TheIcon;

	internal TextBlock LblCreateTime;

	internal TextBlock LblLastEditTime;

	internal TextBlock LblShareInfo;

	internal StackPanel PnlShareInfo;

	internal Hyperlink LnkShare;

	internal TextBlock LblShareTime;

	internal TextBlock LblSource;

	internal StackPanel PnlSource;

	internal Hyperlink LnkSource;

	internal TextBlock LblInstallVersion;

	internal TextBlock LblLastVersion;

	internal Hyperlink LnkAuthor;

	internal TextBlock LblAuthor;

	internal TextBlock LblSize;

	internal TextBlock LblAutoUpdate;

	internal Button BtnCopy;

	private bool OkWglhLVWAG;

	internal static ActionInfoWindow Fc6xPOFyf7asVhDYMer1;

	public ActionInfoWindow(ActionItem action)
	{
		dWOgl9TPQrA = action;
		InitializeComponent();
		base.Loaded += mGLglRfQQUO;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__3))]
	private void mGLglRfQQUO(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__3 stateMachine = default(_003COnLoaded_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void XkXglqH8cJQ(object sender, MouseButtonEventArgs e)
	{
		ClipboardHelper.SetText(dWOgl9TPQrA.Id);
		AppHelper.ShowSuccess("动作ID已经写入剪贴板。");
	}

	private void wsuglcQr1GZ(object sender, RoutedEventArgs e)
	{
		ClipboardHelper.SetText("ID:" + dWOgl9TPQrA.Id + "\n标题:" + dWOgl9TPQrA.Title + "\n说明:" + dWOgl9TPQrA.Description + "\nURI:" + dWOgl9TPQrA.GetUri());
		AppHelper.ShowSuccess("已复制。");
	}

	private void wECglVpIiaZ(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Right)
		{
			ClipboardHelper.SetText(LblAuthor.Text);
			AppHelper.ShowSuccess("已复制用户昵称。");
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!OkWglhLVWAG)
		{
			OkWglhLVWAG = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actioninfowindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			OkWglhLVWAG = true;
			num = 1;
			if (!lQb6HEFybdCKKWfjef02())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00d8;
		case 1:
			LblId = (TextBlock)target;
			LblId.PreviewMouseDown += XkXglqH8cJQ;
			break;
		case 2:
			LblLabel = (TextBlock)target;
			break;
		case 3:
			LblDescription = (TextBlock)target;
			break;
		case 4:
			TheIcon = (IconControl)target;
			break;
		case 5:
			LblCreateTime = (TextBlock)target;
			num = 0;
			if (Fc6xPOFyf7asVhDYMer1 != null)
			{
				break;
			}
			goto IL_00d8;
		case 6:
			LblLastEditTime = (TextBlock)target;
			break;
		case 7:
			LblShareInfo = (TextBlock)target;
			break;
		case 8:
			PnlShareInfo = (StackPanel)target;
			break;
		case 9:
			LnkShare = (Hyperlink)target;
			break;
		case 10:
			LblShareTime = (TextBlock)target;
			break;
		case 11:
			LblSource = (TextBlock)target;
			break;
		case 12:
			PnlSource = (StackPanel)target;
			break;
		case 13:
			LnkSource = (Hyperlink)target;
			break;
		case 14:
			LblInstallVersion = (TextBlock)target;
			break;
		case 15:
			LblLastVersion = (TextBlock)target;
			break;
		case 16:
			LnkAuthor = (Hyperlink)target;
			break;
		case 17:
			LblAuthor = (TextBlock)target;
			LblAuthor.PreviewMouseDown += wECglVpIiaZ;
			break;
		case 18:
			LblSize = (TextBlock)target;
			break;
		case 19:
			LblAutoUpdate = (TextBlock)target;
			break;
		case 20:
			{
				BtnCopy = (Button)target;
				BtnCopy.Click += wsuglcQr1GZ;
				break;
			}
			IL_00d8:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	static ActionInfoWindow()
	{
		uRtglZKE50s = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool lQb6HEFybdCKKWfjef02()
	{
		return Fc6xPOFyf7asVhDYMer1 == null;
	}
}
