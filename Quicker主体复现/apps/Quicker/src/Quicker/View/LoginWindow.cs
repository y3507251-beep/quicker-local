using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using dkbgyyMixGueocCf9RC;
using HandyControl.Controls;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Settings.Pages.Basic;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Account;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View;

public class LoginWindow : System.Windows.Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnLoginWithWeixin_OnClick_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LoginWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object XrxdmMWUe2ggpWBbXTXx;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LoginWindow loginWindow = _003C_003E4__this;
			try
			{
				try
				{
        ExternalLoginWindow externalLoginWindow = default;
					if (num == 0)
					{
						goto IL_0043;
					}
					externalLoginWindow = new ExternalLoginWindow
					{
						Owner = loginWindow
					};
					if (externalLoginWindow.ShowDialog() == true && !string.IsNullOrEmpty(externalLoginWindow.Token))
					{
						goto IL_0043;
					}
					goto end_IL_000f;
					IL_0043:
					try
					{
						ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.o6jt1sruPwZ(null, null, externalLoginWindow.Token).ConfigureAwait(true).GetAwaiter();
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
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<AuthenticateResult2> result = awaiter.GetResult();
						if (!loginWindow.IsSuccess(result))
						{
							loginWindow.Jy2Lg9Oq1vx(result);
						}
						else
						{
							loginWindow.AuthenticateResult = result.Data;
							loginWindow.Dispatcher.Invoke(loginWindow.nISLgHlj6sZ);
						}
					}
					catch (Exception ex)
					{
						Yk9LgbO8IRo.Warn("无法登录！" + ex.Message, ex);
						MessageBoxHelper.Show(loginWindow, "无法登录！" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
					}
					end_IL_000f:;
				}
				catch (Exception)
				{
					AppHelper.ShowWarning("打开微信登录窗口遇到了问题。");
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

		internal static bool LvRDK2WUjqNEyMZL4Vn0()
		{
			return XrxdmMWUe2ggpWBbXTXx == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnLogin_Click_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LoginWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object D5SVM0WU3XAPUtQW6RMY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LoginWindow loginWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					loginWindow.BtnLogin.IsEnabled = false;
					loginWindow.BtnLogin.Content = "登录中...";
					awaiter = loginWindow.DoLoginAsync().ConfigureAwait(true).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					if (r7pQhjWUEM69g61hF28b())
					{
						switch (0)
						{
						}
					}
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				loginWindow.BtnLogin.IsEnabled = true;
				loginWindow.BtnLogin.Content = "登录";
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

		internal static bool r7pQhjWUEM69g61hF28b()
		{
			return D5SVM0WU3XAPUtQW6RMY == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoLoginAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LoginWindow _003C_003E4__this;

		private bool _003CisDemoUser_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Vgk2qlWU1xSFQHfawMMR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LoginWindow loginWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00ba;
				}
				_003CisDemoUser_003E5__2 = "demo@getquicker.net".Equals(loginWindow.TxtEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase);
				if (!_003CisDemoUser_003E5__2)
				{
					try
					{
						AO7eLUM7kJyEdiOQu2O.ARbLM2BwuxL(loginWindow.TxtEmail.Text);
					}
					catch (Exception ex)
					{
						Yk9LgbO8IRo.Warn("保存配置到本地出错：" + ex.Message, ex);
						AppHelper.ShowWarning("保存配置到本地出错：" + ex.Message, true);
					}
				}
				if (!string.IsNullOrEmpty(loginWindow.TxtEmail.Text) && !string.IsNullOrEmpty(loginWindow.TxtPassword.Password))
				{
					goto IL_00ba;
				}
				goto end_IL_0010;
				IL_00ba:
				try
				{
					int num2;
					if (num != 0)
					{
						num2 = 0;
						if (Vgk2qlWU1xSFQHfawMMR != null)
						{
							goto IL_0108;
						}
						goto IL_010c;
					}
					ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<AuthenticateResult2>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0151;
					IL_0151:
					ApiResult<AuthenticateResult2> result = awaiter.GetResult();
					if (loginWindow.IsSuccess(result))
					{
						loginWindow.AuthenticateResult = result.Data;
						num2 = 1;
						if (Vgk2qlWU1xSFQHfawMMR != null)
						{
							goto IL_0108;
						}
						goto IL_010c;
					}
					loginWindow.Jy2Lg9Oq1vx(result);
					goto end_IL_00ba;
					IL_010c:
					switch (num2)
					{
					default:
						awaiter = aFIptTXYsUoTUF4v33R.o6jt1sruPwZ(loginWindow.TxtEmail.Text, loginWindow.TxtPassword.Password, null).ConfigureAwait(true).GetAwaiter();
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
						if (_003CisDemoUser_003E5__2)
						{
							MessageBoxHelper.Show(loginWindow, "您正在使用体验帐号，任何的设置更改将不会保存。\n\n操作提示：\n 弹出快捷面板：点击中键或单击Ctrl。\n 轮盘菜单：按右键移动鼠标。\n\n现在将为您打开体验指南网页，请您参考。", "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
							AppHelper.TryOpenUrlOrFile("https://getquicker.net/KC/Help/Doc/quick-demo");
						}
						loginWindow.Dispatcher.Invoke(loginWindow.r2FLgsB7cl6);
						goto end_IL_00ba;
					}
					goto IL_0151;
					IL_0108:
					int num3 = default(int);
					num2 = num3;
					goto IL_010c;
					end_IL_00ba:;
				}
				catch (Exception ex2)
				{
					Yk9LgbO8IRo.Warn("无法登录！" + ex2.Message, ex2);
					MessageBoxHelper.Show(loginWindow, "无法登录！" + ex2.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				}
				end_IL_0010:;
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

		internal static bool u4gE3yWUKbYtxuNhso0C()
		{
			return Vgk2qlWU1xSFQHfawMMR == null;
		}
	}

	private static readonly ILog Yk9LgbO8IRo;

	[CompilerGenerated]
	private AuthenticateResult2 Td4Lg6bbfIY;

	[CompilerGenerated]
	private bool p92LgXljqlj;

	internal HandyControl.Controls.TextBox TxtEmail;

	internal HandyControl.Controls.PasswordBox TxtPassword;

	internal TextBlock LngForgetPass;

	internal TextBlock LnkHelp;

	internal ProxySettingsControl ProxySettingsControl;

	internal Button BtnLogin;

	internal Button BtnRegister;

	internal Button LnkUseDemoUser;

	internal Button BtnLoginWithWeixin;

	private bool BM9LgmbvjPa;

	internal static LoginWindow g9eiLZF2ZKeCKLLDevuY;

	public string UserName => TxtEmail.Text;

	public AuthenticateResult2 AuthenticateResult
	{
		[CompilerGenerated]
		get
		{
			return Td4Lg6bbfIY;
		}
		[CompilerGenerated]
		private set
		{
			Td4Lg6bbfIY = value;
		}
	}

	public bool AnonymousUse
	{
		[CompilerGenerated]
		get
		{
			return p92LgXljqlj;
		}
		[CompilerGenerated]
		set
		{
			p92LgXljqlj = value;
		}
	}

	public LoginWindow()
	{
		InitializeComponent();
		base.Loaded += UEsLgV2fs9a;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new FakeWindowsPeer(this);
	}

	private void UEsLgV2fs9a(object sender, RoutedEventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.uoJLMS39E28(out var string_);
		TxtEmail.Text = string_;
		TxtPassword.Password = "";
		try
		{
			Activate();
			TxtEmail.Focus();
		}
		catch (Exception ex)
		{
			Yk9LgbO8IRo.Warn(ex.Message ?? "", ex);
		}
		ProxySettingsControl.SetData(AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT());
	}

	[AsyncStateMachine(typeof(_003CBtnLogin_Click_003Ed__14))]
	private void DY7LgZZdK1b(object sender, RoutedEventArgs e)
	{
		_003CBtnLogin_Click_003Ed__14 stateMachine = default(_003CBtnLogin_Click_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoLoginAsync_003Ed__15))]
	public Task DoLoginAsync()
	{
		_003CDoLoginAsync_003Ed__15 stateMachine = default(_003CDoLoginAsync_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private bool IsSuccess(ApiResult<AuthenticateResult2> result)
	{
		return result?.IsSuccess ?? false;
	}

	private void Jy2Lg9Oq1vx(ApiResult<AuthenticateResult2> apiResult_0)
	{
		if (apiResult_0 == null)
		{
			AppHelper.ShowWarning("无法登录！请核对用户名和密码。", true);
		}
		else if (!string.IsNullOrEmpty(apiResult_0?.Data?.GuideLink))
		{
			string message = apiResult_0.Message;
			string link = apiResult_0.Data?.GuideLink;
			LoginErrorWindow loginErrorWindow = new LoginErrorWindow(message, link);
			loginErrorWindow.Owner = this;
			loginErrorWindow.ShowDialog();
		}
		else
		{
			AppHelper.ShowWarning("无法登录！" + apiResult_0.Message, true);
		}
	}

	private void ATqLghdt9Sf(object sender, RoutedEventArgs e)
	{
		try
		{
			RegisterWindow registerWindow = new RegisterWindow();
			registerWindow.Owner = this;
			if (registerWindow.ShowDialog() == true)
			{
				TxtEmail.Text = registerWindow.Email;
				TxtPassword.Password = registerWindow.Password;
				FollowWeiXin followWeiXin = new FollowWeiXin();
				followWeiXin.Owner = this;
				followWeiXin.ShowDialog();
				AppHelper.TriggerButtonClick(BtnLogin);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("显示注册窗口出现了问题：" + ex.Message);
		}
	}

	private void wv4LgeMqgmJ(object sender, MouseButtonEventArgs e)
	{
		string fileName = "https://getquicker.net".TrimEnd('/') + "/Identity/Account/ForgotPassword";
		try
		{
			Process.Start(fileName);
		}
		catch
		{
			AppHelper.ShowWarning("您的电脑没有设置默认浏览器，所以无法打开找回密码网页。请先设置好默认浏览器。", true);
		}
	}

	private void homLgY0kdVN(object sender, RoutedEventArgs e)
	{
		TxtEmail.Text = "demo@getquicker.net";
		TxtPassword.Password = "demo4321";
		BtnLogin.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
	}

	private void KiVLgIJXTod(object sender, RoutedEventArgs e)
	{
		AnonymousUse = true;
		base.DialogResult = true;
	}

	private void pS1LgWAWfcN(object sender, MouseButtonEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(5, "登录页帮助"));
	}

	[AsyncStateMachine(typeof(_003CBtnLoginWithWeixin_OnClick_003Ed__23))]
	private void GcqLgkjXhDY(object sender, RoutedEventArgs e)
	{
		_003CBtnLoginWithWeixin_OnClick_003Ed__23 stateMachine = default(_003CBtnLoginWithWeixin_OnClick_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void RYULgGdwjje(object sender, MouseButtonEventArgs e)
	{
		AppHelper.OpenMainSite();
	}

	private void ProxySettingsControl_OnProxySettingsChanged(object sender, EventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.I4ULM7Vyvra(ProxySettingsControl.ProxySettings);
		try
		{
			AppHelper.UpdateProxySettings();
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("更新设置失败！" + exception.GetMessageWithInner());
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!BM9LgmbvjPa)
		{
			BM9LgmbvjPa = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/loginwindow.xaml", UriKind.Relative);
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
		int num = 2;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtEmail = (HandyControl.Controls.TextBox)target;
				return;
			case 2:
				TxtPassword = (HandyControl.Controls.PasswordBox)target;
				return;
			case 3:
				LngForgetPass = (TextBlock)target;
				LngForgetPass.MouseDown += wv4LgeMqgmJ;
				return;
			case 4:
				LnkHelp = (TextBlock)target;
				LnkHelp.MouseDown += pS1LgWAWfcN;
				return;
			case 5:
				ProxySettingsControl = (ProxySettingsControl)target;
				return;
			case 6:
				BtnLogin = (Button)target;
				BtnLogin.Click += DY7LgZZdK1b;
				return;
			case 7:
				BtnRegister = (Button)target;
				BtnRegister.Click += ATqLghdt9Sf;
				return;
			case 8:
				LnkUseDemoUser = (Button)target;
				LnkUseDemoUser.Click += homLgY0kdVN;
				return;
			case 9:
				BtnLoginWithWeixin = (Button)target;
				BtnLoginWithWeixin.Click += GcqLgkjXhDY;
				return;
			}
			int num2 = 1;
			if (!FliVR1F25exkWpORLg9I())
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto IL_001e;
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				}
				break;
				IL_001e:
				BM9LgmbvjPa = true;
				num2 = 0;
				if (FliVR1F25exkWpORLg9I())
				{
					return;
				}
			}
		}
	}

	static LoginWindow()
	{
		Yk9LgbO8IRo = LogManager.GetLogger(typeof(global::Quicker.View.LoginWindow));
	}

	[CompilerGenerated]
	private void r2FLgsB7cl6()
	{
		base.DialogResult = true;
	}

	[CompilerGenerated]
	private void nISLgHlj6sZ()
	{
		base.DialogResult = true;
	}

	internal static bool FliVR1F25exkWpORLg9I()
	{
		return g9eiLZF2ZKeCKLLDevuY == null;
	}

	internal static void fPp5nsF28m1bhHbca6mU()
	{
	}

	internal static void xbD8peF2MEBt59cA4qab()
	{
	}
}
