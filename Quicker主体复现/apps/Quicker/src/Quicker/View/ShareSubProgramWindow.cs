using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.SubPrograms;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.Share;

namespace Quicker.View;

public class ShareSubProgramWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec aloSX8pi7Gu;

		public static Func<SharedSubProgramListItemDto, string> KokSXaLKySL;

		internal static _003C_003Ec XIqmq2WZcCoE34vrJgM0;

		static _003C_003Ec()
		{
			aloSX8pi7Gu = new _003C_003Ec();
		}

		internal string ItgSXyLUulB(SharedSubProgramListItemDto x)
		{
			return x.Title;
		}

		internal static bool cASijWWZWHCaLvHiApHs()
		{
			return XIqmq2WZcCoE34vrJgM0 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnOk_OnClick_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareSubProgramWindow _003C_003E4__this;

		private SharedActionVm _003Cvm_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__3;

		private static object gm2EUcWZpwaiITbDST14;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareSubProgramWindow shareSubProgramWindow = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (!rpXdxgWZXI9VDHKhGKIn())
					{
						goto IL_0075;
					}
					goto IL_0079;
				}
				goto IL_02ab;
				IL_0390:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter;
					if (num != 1)
					{
						if (num == 2)
						{
							goto IL_04d0;
						}
						awaiter = aFIptTXYsUoTUF4v33R.iuttbawCkyq(_003Cvm_003E5__2, true).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<SharedActionDto> result = awaiter.GetResult();
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
					if (result.IsSuccess)
					{
						shareSubProgramWindow.xt9gjTx6udR(result.Data);
						shareSubProgramWindow.NewSharedAction = result.Data;
						AppHelper.ShowSuccess("分享成功！");
						awaiter2 = AppHelper.tNBLTbaIvty("/member/AfterShareSp?id=" + result.Data.Id.ToString()).ConfigureAwait(true).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_04ee;
					}
					AppHelper.ShowWarning("分享失败。" + result.Message);
					int num3 = 0;
					if (gm2EUcWZpwaiITbDST14 != null)
					{
						goto IL_0506;
					}
					goto end_IL_0390;
					IL_0506:
					switch (num3)
					{
					case 1:
						break;
					default:
						goto end_IL_0390;
					case 2:
						shareSubProgramWindow.Close();
						goto end_IL_0390;
					case 0:
						goto end_IL_0390;
					}
					goto IL_04d0;
					IL_04d0:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_04ee;
					IL_04ee:
					awaiter2.GetResult();
					num3 = 2;
					if (gm2EUcWZpwaiITbDST14 != null)
					{
						int num4 = default(int);
						num3 = num4;
					}
					goto IL_0506;
					end_IL_0390:;
				}
				catch (Exception ex)
				{
					MessageBoxHelper.Show(shareSubProgramWindow, "分享失败。" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				}
				goto end_IL_0010;
				IL_0075:
				int num5 = default(int);
				num2 = num5;
				goto IL_0079;
				IL_0079:
				SharedSubProgramListItemDto sharedSubProgramListItemDto = default(SharedSubProgramListItemDto);
				while (true)
				{
					switch (num2)
					{
					case 1:
						goto IL_0099;
					}
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_0390;
					}
					if (!AppState.DataService.BV9tm7kpqII() && !AppState.DataService.JTftmqIPFYx())
					{
						sharedSubProgramListItemDto = shareSubProgramWindow.JWEgj30y6iR();
						if (shareSubProgramWindow.RbUpdate.IsChecked != true)
						{
							break;
						}
						num2 = 1;
						if (rpXdxgWZXI9VDHKhGKIn())
						{
							continue;
						}
						goto IL_0075;
					}
					AppHelper.ShowInformation("体验帐号不支持此功能。");
					goto end_IL_0010;
					IL_0099:
					if (sharedSubProgramListItemDto != null)
					{
						break;
					}
					AppHelper.ShowInformation("请选择要更新的子程序。", true);
					goto end_IL_0010;
				}
				if (shareSubProgramWindow.TxtName.EnsureNotEmpty("名称") && shareSubProgramWindow.TxtDescription.EnsureNotEmpty("说明"))
				{
					if (sharedSubProgramListItemDto == null || !string.IsNullOrWhiteSpace(shareSubProgramWindow.TxtChangeLog.Text))
					{
						_003Cvm_003E5__2 = new SharedActionVm
						{
							AsSubProgram = true,
							Id = sharedSubProgramListItemDto?.Id,
							ActionType = ActionType.XSubProgram,
							Children = null,
							Title = shareSubProgramWindow.TxtName.Text,
							Data = JsonConvert.SerializeObject(shareSubProgramWindow.SubProgram),
							Data2 = "",
							Data3 = "",
							Description = shareSubProgramWindow.TxtDescription.Text,
							InternalId = shareSubProgramWindow.SubProgram.Id,
							SourceSharedActionId = shareSubProgramWindow.SubProgram.TemplateId,
							SourceSharedActionRevision = shareSubProgramWindow.SubProgram.TemplateRevision,
							SourceProfileId = "",
							Language = Thread.CurrentThread.CurrentCulture.Name,
							Icon = shareSubProgramWindow.SubProgram.Icon,
							Tags = "",
							IsPublic = (shareSubProgramWindow.ChkPublishToLib.IsChecked == true),
							ChangeLog = ((sharedSubProgramListItemDto == null) ? "" : shareSubProgramWindow.TxtChangeLog.Text),
							SoftVersion = AppHelper.GetSoftVersion(),
							UserLimitation = ActionUserLimitation.None,
							ExeFile = "subprogram",
							ExeFullpath = "subprogram"
						};
						try
						{
							_003Cvm_003E5__2.Data = ShareActionHelper.EmbedGlobalSubPrograms(_003Cvm_003E5__2.Data);
						}
						catch (Exception exception)
						{
							AppHelper.ShowWarning("将公共子程序转换为内部子程序时出错。" + exception.GetMessageWithInner(), true);
							goto end_IL_0010;
						}
						goto IL_02ab;
					}
					AppHelper.ShowWarning("请输入更新内容。");
				}
				goto end_IL_0010;
				IL_02ab:
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter3;
					if (num != 0)
					{
						awaiter3 = aFIptTXYsUoTUF4v33R.fhitb8lgfRm(_003Cvm_003E5__2.Title, _003Cvm_003E5__2.Id).ConfigureAwait(true).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num6 = 0;
							if (!rpXdxgWZXI9VDHKhGKIn())
							{
								int num7 = default(int);
								num6 = num7;
							}
							switch (num6)
							{
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					if (!awaiter3.GetResult() || MessageBoxHelper.Show(shareSubProgramWindow, "子程序（" + _003Cvm_003E5__2.Title + "）已经存在，是否覆盖？", "分享子程序", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
					{
						goto end_IL_02ab;
					}
					goto end_IL_0010;
					end_IL_02ab:;
				}
				catch (Exception exception2)
				{
					AppHelper.ShowWarning(exception2.GetMessageWithInner(), true);
					goto end_IL_0010;
				}
				goto IL_0390;
				end_IL_0010:;
			}
			catch (Exception exception3)
			{
				_003C_003E1__state = -2;
				_003Cvm_003E5__2 = null;
				_003C_003Et__builder.SetException(exception3);
				return;
			}
			_003C_003E1__state = -2;
			_003Cvm_003E5__2 = null;
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

		internal static bool rpXdxgWZXI9VDHKhGKIn()
		{
			return gm2EUcWZpwaiITbDST14 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareSubProgramWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<SharedSubProgramListItemDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object oAGZMtWZndiIAipmiFb1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareSubProgramWindow shareSubProgramWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					shareSubProgramWindow.LblSubProgramName.Text = shareSubProgramWindow.SubProgram.Name;
					shareSubProgramWindow.LblSubProgramDesc.Text = shareSubProgramWindow.SubProgram.Description;
					shareSubProgramWindow.LblLastEdit.Text = AppHelper.GetLocalTimeString(shareSubProgramWindow.SubProgram.LastEditTimeUtc);
					if (!string.IsNullOrEmpty(shareSubProgramWindow.SubProgram.SharedId))
					{
						shareSubProgramWindow.LnkToSharedSubProgram.NavigateUri = new Uri(AppHelper.CreateSharedSubProgramLink(shareSubProgramWindow.SubProgram.SharedId));
						shareSubProgramWindow.LblShareTime.Text = AppHelper.GetLocalTimeString(shareSubProgramWindow.SubProgram.ShareTimeUtc);
					}
					else
					{
						shareSubProgramWindow.PnlShareInfo.Visibility = Visibility.Collapsed;
					}
					shareSubProgramWindow.TxtName.Text = shareSubProgramWindow.SubProgram.Name;
					shareSubProgramWindow.TxtDescription.Text = shareSubProgramWindow.SubProgram.Description;
					int num2 = 0;
					if (oAGZMtWZndiIAipmiFb1 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				try
				{
        SharedSubProgramListItemDto sharedSubProgramListItemDto = default;
					ConfiguredTaskAwaitable<ApiResult<IList<SharedSubProgramListItemDto>>>.ConfiguredTaskAwaiter awaiter;
					int num4;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.gAxtbc8K0Fo().ConfigureAwait(true).GetAwaiter();
						num4 = 0;
						if (!YtFwCKWZeiAHLnqtiXd7())
						{
							goto IL_01ff;
						}
						goto IL_0203;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<SharedSubProgramListItemDto>>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_021d;
					IL_021d:
					ApiResult<IList<SharedSubProgramListItemDto>> result = awaiter.GetResult();
					sharedSubProgramListItemDto = default(SharedSubProgramListItemDto);
					if (result.IsSuccess)
					{
						shareSubProgramWindow.MySharedSubPrograms.Reset(result.Data.OrderBy(_003C_003Ec.KokSXaLKySL ?? (_003C_003Ec.KokSXaLKySL = _003C_003Ec.aloSX8pi7Gu.ItgSXyLUulB)));
						sharedSubProgramListItemDto = null;
						if (shareSubProgramWindow.MySharedSubPrograms.Count > 0)
						{
							num4 = 1;
							if (!YtFwCKWZeiAHLnqtiXd7())
							{
								goto IL_01ff;
							}
							goto IL_0203;
						}
						goto IL_02a3;
					}
					AppHelper.ShowWarning(result.Message, true);
					goto end_IL_0110;
					IL_02a3:
					if (sharedSubProgramListItemDto != null)
					{
						shareSubProgramWindow.RbUpdate.IsChecked = true;
						shareSubProgramWindow.CbSharedSubPrograms.SelectedItem = sharedSubProgramListItemDto;
					}
					else
					{
						shareSubProgramWindow.RbUpdate.IsChecked = false;
						shareSubProgramWindow.RbShareNew.IsChecked = true;
					}
					goto end_IL_0110;
					IL_01ff:
					int num5 = default(int);
					num4 = num5;
					goto IL_0203;
					IL_0203:
					while (true)
					{
						switch (num4)
						{
						case 1:
							break;
						default:
							goto end_IL_0203;
						case 2:
							goto IL_0269;
						}
						if (!string.IsNullOrEmpty(shareSubProgramWindow.SubProgram.SharedId))
						{
							sharedSubProgramListItemDto = shareSubProgramWindow.MySharedSubPrograms.FirstOrDefault(shareSubProgramWindow.Vp5gjze0sfh);
						}
						if (sharedSubProgramListItemDto == null)
						{
							num4 = 2;
							if (oAGZMtWZndiIAipmiFb1 == null)
							{
								continue;
							}
							goto IL_01ff;
						}
						goto IL_02a3;
						IL_0269:
						sharedSubProgramListItemDto = shareSubProgramWindow.MySharedSubPrograms.FirstOrDefault(shareSubProgramWindow.Aa9gnw7K0W1);
						if (sharedSubProgramListItemDto == null)
						{
							sharedSubProgramListItemDto = shareSubProgramWindow.MySharedSubPrograms.FirstOrDefault(shareSubProgramWindow.MhcgntEE2W7);
						}
						goto IL_02a3;
						continue;
						end_IL_0203:
						break;
					}
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_021d;
					end_IL_0110:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("网络调用失败，请检查您的网络是否通畅。" + ex.Message, true);
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

		internal static bool YtFwCKWZeiAHLnqtiXd7()
		{
			return oAGZMtWZndiIAipmiFb1 == null;
		}
	}

	[CompilerGenerated]
	private SubProgram SjbgnguPXsD;

	[CompilerGenerated]
	private SharedActionDto bakgnLln4JX;

	[CompilerGenerated]
	private SharedActionDto P1ngnvwOTF9;

	[CompilerGenerated]
	private readonly SmartCollection<SharedSubProgramListItemDto> e6qgnS5muCN = new SmartCollection<SharedSubProgramListItemDto>();

	internal TextBlock LblSubProgramName;

	internal TextBlock LblSubProgramDesc;

	internal TextBlock LblLastEdit;

	internal StackPanel PnlShareInfo;

	internal TextBlock LblShareTime;

	internal Hyperlink LnkToSharedSubProgram;

	internal RadioButton RbShareNew;

	internal RadioButton RbUpdate;

	internal ComboBox CbSharedSubPrograms;

	internal CheckBox ChkPublishToLib;

	internal TextBox TxtName;

	internal TextBlock LblUpdateName;

	internal TextBox TxtDescription;

	internal TextBlock LblChangeLog;

	internal StackPanel PnlChangeLog;

	internal TextBoxWithToolsControl TxtChangeLog;

	internal Button BtnOk;

	internal Label BtnCopyLink;

	internal Label BtnOpenPage;

	internal Label LblTemplateInfo;

	internal Label LblSharedInfo;

	private bool Gc9gn2kC2e2;

	internal static ShareSubProgramWindow rmlcnHFVEM00iJM2vRA1;

	public SubProgram SubProgram
	{
		[CompilerGenerated]
		get
		{
			return SjbgnguPXsD;
		}
		[CompilerGenerated]
		set
		{
			SjbgnguPXsD = value;
		}
	}

	public SharedActionDto OldSharedAction
	{
		[CompilerGenerated]
		get
		{
			return bakgnLln4JX;
		}
		[CompilerGenerated]
		set
		{
			bakgnLln4JX = value;
		}
	}

	public SharedActionDto NewSharedAction
	{
		[CompilerGenerated]
		get
		{
			return P1ngnvwOTF9;
		}
		[CompilerGenerated]
		set
		{
			P1ngnvwOTF9 = value;
		}
	}

	public SmartCollection<SharedSubProgramListItemDto> MySharedSubPrograms
	{
		[CompilerGenerated]
		get
		{
			return e6qgnS5muCN;
		}
	}

	public ShareSubProgramWindow()
	{
		InitializeComponent();
		CbSharedSubPrograms.ItemsSource = MySharedSubPrograms;
		base.Loaded += it7gjoqwRjh;
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__16))]
	private void it7gjoqwRjh(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__16 stateMachine = default(_003COnLoaded_003Ed__16);
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

	private void xt9gjTx6udR(SharedActionDto sharedActionDto_2)
	{
		string tag = AppHelper.CreateSharedSubProgramLink(sharedActionDto_2);
		LblSharedInfo.Content = "子程序已成功分享。";
		LblSharedInfo.Tag = tag;
		BtnOk.Content = "更新";
		BtnCopyLink.Tag = tag;
		BtnOpenPage.Tag = tag;
		BtnCopyLink.Visibility = Visibility.Visible;
		BtnOpenPage.Visibility = Visibility.Visible;
	}

	[AsyncStateMachine(typeof(_003CBtnOk_OnClick_003Ed__19))]
	private void XFPgjMpRYkD(object sender, RoutedEventArgs e)
	{
		_003CBtnOk_OnClick_003Ed__19 stateMachine = default(_003CBtnOk_OnClick_003Ed__19);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void wllgjAHobhR(object sender, MouseButtonEventArgs e)
	{
		string text = (sender as Label).Tag as string;
		if (string.IsNullOrEmpty(text))
		{
			AppHelper.ShowWarning("URL为空！");
			return;
		}
		ClipboardHelper.SetData(DataFormats.Text, text);
		AppHelper.ShowInformation("已复制到剪贴板。");
	}

	private void dZfgjODkWOQ(object sender, MouseButtonEventArgs e)
	{
		string data = (sender as Label).Tag as string;
		ClipboardHelper.SetData(DataFormats.Text, data);
		AppHelper.ShowInformation("已复制到剪贴板。");
	}

	private void Sm0gjFgpJvA(object sender, MouseButtonEventArgs e)
	{
		string fileName = (sender as Label).Tag as string;
		try
		{
			Process.Start(fileName);
		}
		catch (Exception ex)
		{
			AppHelper.ShowInformation("无法打开链接。" + ex.Message);
		}
	}

	private void hwkgjUauK3o(object sender, SelectionChangedEventArgs e)
	{
		UgFgjf9RIBR();
	}

	private void SSKgjlO3P3R(object sender, RoutedEventArgs e)
	{
		UgFgjf9RIBR();
	}

	private void YwLgjihf3Z0(object sender, RoutedEventArgs e)
	{
		UgFgjf9RIBR();
	}

	private SharedSubProgramListItemDto JWEgj30y6iR()
	{
		if (!base.IsLoaded)
		{
			return null;
		}
		if (RbShareNew.IsChecked == true)
		{
			return null;
		}
		if (CbSharedSubPrograms.SelectedItem == null)
		{
			return null;
		}
		return CbSharedSubPrograms.SelectedItem as SharedSubProgramListItemDto;
	}

	private void UgFgjf9RIBR()
	{
		if (base.IsLoaded)
		{
			SharedSubProgramListItemDto sharedSubProgramListItemDto = JWEgj30y6iR();
			if (sharedSubProgramListItemDto == null)
			{
				TxtName.Text = SubProgram.Name;
				TxtDescription.Text = SubProgram.Description;
			}
			else
			{
				TxtName.Text = sharedSubProgramListItemDto.Title;
				TxtDescription.Text = sharedSubProgramListItemDto.Description;
				ChkPublishToLib.IsChecked = sharedSubProgramListItemDto.IsPublic;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Gc9gn2kC2e2)
		{
			Gc9gn2kC2e2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/share/sharesubprogramwindow.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			Gc9gn2kC2e2 = true;
			break;
		case 1:
			LblSubProgramName = (TextBlock)target;
			break;
		case 2:
			LblSubProgramDesc = (TextBlock)target;
			break;
		case 3:
			LblLastEdit = (TextBlock)target;
			break;
		case 4:
			PnlShareInfo = (StackPanel)target;
			break;
		case 5:
			LblShareTime = (TextBlock)target;
			break;
		case 6:
			LnkToSharedSubProgram = (Hyperlink)target;
			num = 0;
			if (vyTEiyFVG3yZsQJrPR9t())
			{
				break;
			}
			goto IL_0214;
		case 7:
			RbShareNew = (RadioButton)target;
			RbShareNew.Checked += SSKgjlO3P3R;
			break;
		case 8:
			RbUpdate = (RadioButton)target;
			RbUpdate.Checked += YwLgjihf3Z0;
			break;
		case 9:
			CbSharedSubPrograms = (ComboBox)target;
			CbSharedSubPrograms.SelectionChanged += hwkgjUauK3o;
			break;
		case 10:
			ChkPublishToLib = (CheckBox)target;
			break;
		case 11:
			TxtName = (TextBox)target;
			break;
		case 12:
			LblUpdateName = (TextBlock)target;
			break;
		case 13:
			TxtDescription = (TextBox)target;
			break;
		case 14:
			LblChangeLog = (TextBlock)target;
			break;
		case 15:
			PnlChangeLog = (StackPanel)target;
			break;
		case 16:
			TxtChangeLog = (TextBoxWithToolsControl)target;
			break;
		case 17:
			BtnOk = (Button)target;
			BtnOk.Click += XFPgjMpRYkD;
			break;
		case 18:
			BtnCopyLink = (Label)target;
			BtnCopyLink.PreviewMouseDown += dZfgjODkWOQ;
			break;
		case 19:
			BtnOpenPage = (Label)target;
			BtnOpenPage.PreviewMouseDown += Sm0gjFgpJvA;
			break;
		case 20:
			LblTemplateInfo = (Label)target;
			num = 1;
			if (!vyTEiyFVG3yZsQJrPR9t())
			{
				break;
			}
			goto IL_0214;
		case 21:
			{
				LblSharedInfo = (Label)target;
				LblSharedInfo.PreviewMouseDown += wllgjAHobhR;
				break;
			}
			IL_0214:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private bool Vp5gjze0sfh(SharedSubProgramListItemDto sharedSubProgramListItemDto_0)
	{
		return sharedSubProgramListItemDto_0.Id.ToString() == SubProgram.SharedId;
	}

	[CompilerGenerated]
	private bool Aa9gnw7K0W1(SharedSubProgramListItemDto sharedSubProgramListItemDto_0)
	{
		return sharedSubProgramListItemDto_0.Title == SubProgram.Name;
	}

	[CompilerGenerated]
	private bool MhcgntEE2W7(SharedSubProgramListItemDto sharedSubProgramListItemDto_0)
	{
		return string.Equals(sharedSubProgramListItemDto_0.Title, SubProgram.Name, StringComparison.OrdinalIgnoreCase);
	}

	internal static bool vyTEiyFVG3yZsQJrPR9t()
	{
		return rmlcnHFVEM00iJM2vRA1 == null;
	}
}
