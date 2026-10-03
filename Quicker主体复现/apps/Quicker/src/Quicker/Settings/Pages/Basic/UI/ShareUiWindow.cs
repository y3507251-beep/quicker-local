using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using HandyControl.Controls;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Skin;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View;

namespace Quicker.Settings.Pages.Basic.UI;

public class ShareUiWindow : System.Windows.Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnShare_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareUiWindow _003C_003E4__this;

		private WaitWindow _003CwaitDialog_003E5__2;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		private TaskAwaiter<ApiResult<Guid>> _003C_003Eu__2;

		private static object AGYJPXcbMrZAWenHGdCC;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareUiWindow shareUiWindow = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_009a;
				}
				if (!File.Exists(shareUiWindow.I5sAugiJPK))
				{
					AppHelper.ShowWarning("请先给面板窗口截图。", true);
				}
				else
				{
					if (!string.IsNullOrWhiteSpace(shareUiWindow.TxtTitle.Text))
					{
						_003CwaitDialog_003E5__2 = new WaitWindow
						{
							Owner = System.Windows.Window.GetWindow(shareUiWindow),
							InfoText = "正在分享，请稍后..."
						};
						int num2 = 0;
						if (AGYJPXcbMrZAWenHGdCC != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003CwaitDialog_003E5__2.Show();
						goto IL_009a;
					}
					AppHelper.ShowWarning("请输入标题。", true);
				}
				goto end_IL_000e;
				IL_009a:
				try
				{
					if (num != 0)
					{
						goto IL_00da;
					}
					int num4 = 0;
					if (AGYJPXcbMrZAWenHGdCC != null)
					{
						int num5 = default(int);
						num4 = num5;
					}
					switch (num4)
					{
					case 1:
						goto IL_00da;
					case 2:
						goto IL_0201;
					}
					TaskAwaiter<ApiResult<string>> awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_011f;
					IL_021e:
					TaskAwaiter<ApiResult<Guid>> awaiter2;
					ApiResult<Guid> result = awaiter2.GetResult();
					if (result.IsSuccess)
					{
						AppHelper.ShowSuccess("分享成功！");
						AppHelper.TryOpenUrlOrFile("https://getquicker.net/Skins/myskins");
					}
					else
					{
						AppHelper.ShowWarning("分享失败！" + result.Message, true);
					}
					goto IL_025d;
					IL_011f:
					ApiResult<string> result2 = awaiter.GetResult();
					if (result2.IsSuccess)
					{
						awaiter2 = aFIptTXYsUoTUF4v33R.y7itb0LejF6(new ShareSkinVm
						{
							Name = shareUiWindow.TxtTitle.Text,
							PrevImageUrl = result2.Data,
							UiSettingsDataJson = JsonConvert.SerializeObject(shareUiWindow.helA2FqlAH),
							IsPrivate = (shareUiWindow.RbSharePublic.IsChecked == false),
							Description = shareUiWindow.TxtDescription.Text,
							Tags = shareUiWindow.TxtKeyWords.Text
						}).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_021e;
					}
					AppHelper.ShowWarning("上传预览图失败！" + result2.Message, true);
					goto IL_025d;
					IL_0201:
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<ApiResult<Guid>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_021e;
					IL_00da:
					if (num != 1)
					{
						awaiter = aFIptTXYsUoTUF4v33R.GlYtbJkn8Qq(shareUiWindow.I5sAugiJPK, UserFileType.SkinPreview).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_011f;
					}
					goto IL_0201;
					IL_025d:
					shareUiWindow.Close();
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("分享遇到异常！" + ex.Message, true);
				}
				finally
				{
					if (num < 0 && _003CwaitDialog_003E5__2.IsVisible)
					{
						_003CwaitDialog_003E5__2.Close();
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CwaitDialog_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CwaitDialog_003E5__2 = null;
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

		internal static bool XpCEn2cbUBIUiyA71kRY()
		{
			return AGYJPXcbMrZAWenHGdCC == null;
		}
	}

	private readonly UiSettings helA2FqlAH;

	private string I5sAugiJPK;

	internal Button BtnCapture;

	internal Image ImgPanelPreview;

	internal HandyControl.Controls.TextBox TxtTitle;

	internal HandyControl.Controls.TextBox TxtDescription;

	internal HandyControl.Controls.TextBox TxtKeyWords;

	internal RadioButton RbSharePublic;

	internal RadioButton RbSharePrivate;

	internal Button BtnShare;

	internal Button BtnCancel;

	private bool s5WANWNaIP;

	internal static ShareUiWindow QBGrYahmhrQhyjy42eT;

	public ShareUiWindow(UiSettings uiSettings)
	{
		helA2FqlAH = uiSettings;
		InitializeComponent();
	}

	private void eoEALjWxQC(object sender, RoutedEventArgs e)
	{
		if (!AppState.HS2taepcAbc().IsVisible)
		{
			AppHelper.ShowWarning("请先弹出面板窗口并钉住。", true);
			return;
		}
		I5sAugiJPK = AppState.HS2taepcAbc().CaptureToTempFile();
		if (!string.IsNullOrEmpty(I5sAugiJPK) && File.Exists(I5sAugiJPK))
		{
			ImgPanelPreview.Source = new BitmapImage(new Uri(I5sAugiJPK));
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void aboAvvBCOS(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[AsyncStateMachine(typeof(_003CBtnShare_OnClick_003Ed__6))]
	private void LwVASN3wvB(object sender, RoutedEventArgs e)
	{
		_003CBtnShare_OnClick_003Ed__6 stateMachine = default(_003CBtnShare_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!s5WANWNaIP)
		{
			s5WANWNaIP = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/ui/shareuiwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			s5WANWNaIP = true;
			break;
		case 1:
			BtnCapture = (Button)target;
			BtnCapture.Click += eoEALjWxQC;
			break;
		case 2:
			ImgPanelPreview = (Image)target;
			break;
		case 3:
		{
			TxtTitle = (HandyControl.Controls.TextBox)target;
			int num = 0;
			if (!zwdvX2hsZE6krc5XTkn())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 4:
			TxtDescription = (HandyControl.Controls.TextBox)target;
			break;
		case 5:
			TxtKeyWords = (HandyControl.Controls.TextBox)target;
			break;
		case 6:
			RbSharePublic = (RadioButton)target;
			break;
		case 7:
			RbSharePrivate = (RadioButton)target;
			break;
		case 8:
			BtnShare = (Button)target;
			BtnShare.Click += LwVASN3wvB;
			break;
		case 9:
			BtnCancel = (Button)target;
			BtnCancel.Click += aboAvvBCOS;
			break;
		}
	}

	internal static bool zwdvX2hsZE6krc5XTkn()
	{
		return QBGrYahmhrQhyjy42eT == null;
	}
}
