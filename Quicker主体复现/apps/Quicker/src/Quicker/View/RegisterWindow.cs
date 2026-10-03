using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.Vm;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class RegisterWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec mkWSphvH8Mk;

		public static Func<char, bool> SSpSpeMuWMh;

		public static Func<char, bool> ORmSpYOu64T;

		internal static _003C_003Ec js187TWMC8sRNwGMBB60;

		static _003C_003Ec()
		{
			mkWSphvH8Mk = new _003C_003Ec();
		}

		internal bool PX4SpZLAs6o(char x)
		{
			return char.IsDigit(x);
		}

		internal bool facSp99kJMs(char x)
		{
			return char.IsLetter(x);
		}

		internal static void QvthQeWMhEvn5MC266l3()
		{
		}

		internal static bool j3IqhmWM7bxBXw9iBwJk()
		{
			return js187TWMC8sRNwGMBB60 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnRegister_OnClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RegisterWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object N6kA61WMH9Q6e2hNs7P1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RegisterWindow registerWindow = _003C_003E4__this;
			try
			{
        RegisterVm registerVm = default;
				if (num == 0)
				{
					goto IL_02a6;
				}
				if (string.IsNullOrEmpty(registerWindow.TxtEmail.Text) || string.IsNullOrEmpty(registerWindow.TxtPassword.Password))
				{
					goto IL_03db;
				}
				int num2 = 3;
				int num3 = default(int);
				if (!iWqrp8WMzx0bsTyc8TQ0())
				{
					num2 = num3;
				}
				switch (num2)
				{
				case 3:
					break;
				default:
					goto IL_016e;
				case 1:
					goto IL_01d6;
				case 2:
					goto IL_0226;
				}
				if (string.IsNullOrEmpty(registerWindow.TxtPasswordConfirm.Password) || string.IsNullOrEmpty(registerWindow.TxtNickName.Text))
				{
					goto IL_03db;
				}
				if (!AppHelper.IsValidEmail(registerWindow.TxtEmail.Text))
				{
					MessageBoxHelper.Show(registerWindow, "Email不合法，请核对。");
				}
				else if (registerWindow.TxtVerifyCode.EnsureNotEmpty("验证码"))
				{
					if (!string.Equals(registerWindow.TxtPassword.Password, registerWindow.TxtPasswordConfirm.Password, StringComparison.Ordinal))
					{
						MessageBoxHelper.Show(registerWindow, "密码不匹配");
					}
					else if (registerWindow.TxtPassword.Password.Length < 6)
					{
						MessageBoxHelper.Show(registerWindow, "密码长度不够。");
					}
					else
					{
						if (registerWindow.TxtNickName.Text.Length >= 3)
						{
							goto IL_016e;
						}
						MessageBoxHelper.Show(registerWindow, "昵称最少3个字符。");
					}
				}
				goto end_IL_0010;
				IL_01fe:
				MessageBoxHelper.Show(registerWindow, "密码需要包含至少一个字母和一个数字。");
				goto end_IL_0010;
				IL_03db:
				MessageBoxHelper.Show(registerWindow, "请填写必要的内容。");
				goto end_IL_0010;
				IL_01d6:
				char[] source = default(char[]);
				if (!source.Any(_003C_003Ec.ORmSpYOu64T ?? (_003C_003Ec.ORmSpYOu64T = _003C_003Ec.mkWSphvH8Mk.facSp99kJMs)))
				{
					goto IL_01fe;
				}
				registerVm = new RegisterVm();
				num3 = 2;
				goto IL_0226;
				IL_0226:
				registerVm.Email = registerWindow.TxtEmail.Text.Trim();
				registerVm.Password = registerWindow.TxtPassword.Password;
				registerVm.NickName = registerWindow.TxtNickName.Text.Trim();
				registerVm.RecommendCode = registerWindow.TxtRecommendCode.Text.Trim();
				registerVm.VerifyCode = registerWindow.TxtVerifyCode.Text.Trim();
				registerVm.Channel = "";
				goto IL_02a6;
				IL_016e:
				if (!int.TryParse(registerWindow.TxtNickName.Text, out var result))
				{
					source = registerWindow.TxtPassword.Password.ToCharArray();
					if (source.Any(_003C_003Ec.SSpSpeMuWMh ?? (_003C_003Ec.SSpSpeMuWMh = _003C_003Ec.mkWSphvH8Mk.PX4SpZLAs6o)))
					{
						goto IL_01d6;
					}
					goto IL_01fe;
				}
				MessageBoxHelper.Show(registerWindow, "昵称不能是纯数字。");
				goto end_IL_0010;
				IL_02a6:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.hEMt1AjK12W(registerVm).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<string> result2 = awaiter.GetResult();
					int num4 = 0;
					if (N6kA61WMH9Q6e2hNs7P1 != null)
					{
						int num5 = default(int);
						num4 = num5;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (!result2.IsSuccess)
							{
								MessageBoxHelper.Show(registerWindow, "注册失败！" + result2.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
								goto end_IL_033f;
							}
							goto IL_0333;
						case 1:
							break;
						}
						goto IL_0376;
						IL_0333:
						num4 = 1;
						if (!iWqrp8WMzx0bsTyc8TQ0())
						{
							continue;
						}
						goto IL_0376;
						IL_0376:
						registerWindow.Email = registerWindow.TxtEmail.Text;
						registerWindow.Password = registerWindow.TxtPassword.Password;
						registerWindow.DialogResult = true;
						break;
						continue;
						end_IL_033f:
						break;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					MessageBoxHelper.Show(registerWindow, "注册出错！" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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

		internal static bool iWqrp8WMzx0bsTyc8TQ0()
		{
			return N6kA61WMH9Q6e2hNs7P1 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSendVerifyCode_OnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RegisterWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object R7LdnMWUcB5PbkRZqT1C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RegisterWindow registerWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00ac;
				}
				if (!AppHelper.IsValidEmail(registerWindow.TxtEmail.Text))
				{
					MessageBoxHelper.Show(registerWindow, "Email不合法，请核对。");
					if (MJ9fDqWUWHPgg4scvvdV())
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					if (!NeILtcFnliH.HasValue || !(NeILtcFnliH.Value > DateTime.Now.AddSeconds(-30.0)))
					{
						registerWindow.BtnSendVerifyCode.IsEnabled = false;
						goto IL_00ac;
					}
					MessageBoxHelper.Show(registerWindow, "请稍等一下再重新发送。");
				}
				goto end_IL_000e;
				IL_00ac:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						NeILtcFnliH = DateTime.Now;
						awaiter = aFIptTXYsUoTUF4v33R.oSvt133fSEu(registerWindow.TxtEmail.Text).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<string> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						if (R7LdnMWUcB5PbkRZqT1C != null)
						{
							switch (0)
							{
							}
						}
						MessageBoxHelper.Show(registerWindow, "验证码发送成功，请查看您的邮箱。\n如果一分钟后仍未收到，请检查是否在垃圾邮件目录中。", "Quicker");
					}
					else
					{
						AppHelper.ShowWarning("验证码发送失败。" + result.Message, true);
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("验证码发送失败。" + ex.Message, true);
				}
				registerWindow.BtnSendVerifyCode.IsEnabled = true;
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

		internal static bool MJ9fDqWUWHPgg4scvvdV()
		{
			return R7LdnMWUcB5PbkRZqT1C == null;
		}
	}

	[CompilerGenerated]
	private string hRELtRRtvSZ;

	[CompilerGenerated]
	private string O3PLtqKV8kL;

	private static DateTime? NeILtcFnliH;

	internal TextBox TxtEmail;

	internal TextBox TxtVerifyCode;

	internal Button BtnSendVerifyCode;

	internal PasswordBox TxtPassword;

	internal PasswordBox TxtPasswordConfirm;

	internal TextBox TxtNickName;

	internal TextBox TxtRecommendCode;

	internal Button BtnRegister;

	private bool n4FLtVyXakn;

	internal static RegisterWindow V8VjUCFXhF5CoUyThKc2;

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return hRELtRRtvSZ;
		}
		[CompilerGenerated]
		set
		{
			hRELtRRtvSZ = value;
		}
	}

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return O3PLtqKV8kL;
		}
		[CompilerGenerated]
		set
		{
			O3PLtqKV8kL = value;
		}
	}

	public RegisterWindow()
	{
		InitializeComponent();
		base.Loaded += yoYLt8KxgF6;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new FakeWindowsPeer(this);
	}

	private void yoYLt8KxgF6(object sender, RoutedEventArgs e)
	{
		TxtEmail.Focus();
	}

	[AsyncStateMachine(typeof(_003CBtnRegister_OnClick_003Ed__11))]
	private void TxILtavnWNa(object sender, RoutedEventArgs e)
	{
		_003CBtnRegister_OnClick_003Ed__11 stateMachine = default(_003CBtnRegister_OnClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnSendVerifyCode_OnClick_003Ed__13))]
	private void kpCLt7A3kHe(object sender, RoutedEventArgs e)
	{
		_003CBtnSendVerifyCode_OnClick_003Ed__13 stateMachine = default(_003CBtnSendVerifyCode_OnClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!n4FLtVyXakn)
		{
			n4FLtVyXakn = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/registerwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			n4FLtVyXakn = true;
			break;
		case 1:
			TxtEmail = (TextBox)target;
			break;
		case 2:
			TxtVerifyCode = (TextBox)target;
			break;
		case 3:
			BtnSendVerifyCode = (Button)target;
			BtnSendVerifyCode.Click += kpCLt7A3kHe;
			break;
		case 4:
			TxtPassword = (PasswordBox)target;
			break;
		case 5:
			TxtPasswordConfirm = (PasswordBox)target;
			break;
		case 6:
			TxtNickName = (TextBox)target;
			if (V8VjUCFXhF5CoUyThKc2 != null)
			{
				switch (0)
				{
				}
			}
			break;
		case 7:
			TxtRecommendCode = (TextBox)target;
			break;
		case 8:
			BtnRegister = (Button)target;
			BtnRegister.Click += TxILtavnWNa;
			break;
		}
	}

	static RegisterWindow()
	{
	}

	internal static bool gr5RhbFXH2OaZcZj6BHh()
	{
		return V8VjUCFXhF5CoUyThKc2 == null;
	}

	internal static void qpONfGF2VODqwQt4EaQP()
	{
	}
}
