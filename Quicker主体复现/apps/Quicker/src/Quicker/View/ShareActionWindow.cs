using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Modules.VersionUpdate;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.Share;
using Quicker.View.UI;

namespace Quicker.View;

public class ShareActionWindow : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec u9USrUrZLNx;

		public static Func<ExeInfo, string> bH4SrlQPjdT;

		private static _003C_003Ec jjEZjdWPI60CycyoxpAI;

		static _003C_003Ec()
		{
			u9USrUrZLNx = new _003C_003Ec();
		}

		internal string bmCSrFUs7NC(ExeInfo x)
		{
			return x.Exe;
		}

		internal static void r0YQNmWPSZPX9iWLT8AH()
		{
		}

		internal static bool Apk4MuWP6psKwpl34k87()
		{
			return jjEZjdWPI60CycyoxpAI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public string bSBSr3Ef96B;

		internal static _003C_003Ec__DisplayClass19_0 zfSHUeWPw3janFmhiPrv;

		internal bool s33SriCbe5U(ExeInfo x)
		{
			return x.Exe.Equals(bSBSr3Ef96B, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool kdoIl6WPTDpTH1RpOXt1()
		{
			return zfSHUeWPw3janFmhiPrv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public ShareActionWindow fybSrzZqJPh;

		public string vrESpwHI107;

		internal static _003C_003Ec__DisplayClass21_0 znV2JfWPskd21qWessEf;

		internal void lhVSrfsaCPR()
		{
			_003C_003Ec__DisplayClass21_1 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_1
			{
				JUDSpLWP4RV = this
			};
			IList<Process> processesWithWindow = NativeMethods.GetProcessesWithWindow();
			_003C_003Ec__DisplayClass21_.WufSpgIZL7I = new List<ExeInfo>();
			foreach (Process item in processesWithWindow)
			{
				if (item == null || item.Id < 10)
				{
					continue;
				}
				try
				{
					_003C_003Ec__DisplayClass21_2 _003C_003Ec__DisplayClass21_2 = new _003C_003Ec__DisplayClass21_2
					{
						dZfSpSMXytE = Path.GetFileName(item.MainModule.FileName)
					};
					if (!_003C_003Ec__DisplayClass21_.WufSpgIZL7I.Any(_003C_003Ec__DisplayClass21_2.ueTSpvxnbv7))
					{
						_003C_003Ec__DisplayClass21_.WufSpgIZL7I.Add(new ExeInfo
						{
							Exe = _003C_003Ec__DisplayClass21_2.dZfSpSMXytE,
							Path = item.MainModule.FileName,
							Name = _003C_003Ec__DisplayClass21_2.dZfSpSMXytE,
							Description = item.MainModule.FileVersionInfo.FileDescription,
							IconStr = "icon:" + item.MainModule.FileName
						});
					}
				}
				catch
				{
				}
			}
			fybSrzZqJPh.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass21_.NrVSptjPOI9);
		}

		internal static bool k1oslpWPCyRqKgixn5hb()
		{
			return znV2JfWPskd21qWessEf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_1
	{
		public List<ExeInfo> WufSpgIZL7I;

		public _003C_003Ec__DisplayClass21_0 JUDSpLWP4RV;

		private static _003C_003Ec__DisplayClass21_1 bnMSn9WPHZ2ALhx3VJ98;

		internal void NrVSptjPOI9()
		{
			JUDSpLWP4RV.fybSrzZqJPh.bV5gfA3XJaj = new ObservableCollection<ExeInfo>(WufSpgIZL7I.OrderBy(_003C_003Ec.bH4SrlQPjdT ?? (_003C_003Ec.bH4SrlQPjdT = _003C_003Ec.u9USrUrZLNx.bmCSrFUs7NC)));
			JUDSpLWP4RV.fybSrzZqJPh.bV5gfA3XJaj.Insert(0, new ExeInfo
			{
				Exe = "common",
				Name = "通用/全局可用"
			});
			JUDSpLWP4RV.fybSrzZqJPh.bV5gfA3XJaj.Insert(1, new ExeInfo
			{
				Exe = "explorer.exe",
				Name = "资源管理器/桌面"
			});
			JUDSpLWP4RV.fybSrzZqJPh.CbValidFor.ItemsSource = JUDSpLWP4RV.fybSrzZqJPh.bV5gfA3XJaj;
			JUDSpLWP4RV.fybSrzZqJPh.qF0gf65rTuj(JUDSpLWP4RV.vrESpwHI107);
		}

		internal static bool rdbSjdWPzTnEP42HmXYX()
		{
			return bnMSn9WPHZ2ALhx3VJ98 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_2
	{
		public string dZfSpSMXytE;

		internal static _003C_003Ec__DisplayClass21_2 RxOsaGWMF8MjKd6wCh1Q;

		internal bool ueTSpvxnbv7(ExeInfo m)
		{
			return m.Exe.Equals(dZfSpSMXytE, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool vfK5VoWMcpWBGWBV4iVg()
		{
			return RxOsaGWMF8MjKd6wCh1Q == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnOk_OnClick_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareActionWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object lpcsPUWMyEQMXfxnA2gM;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareActionWindow shareActionWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_02b0;
				}
				{
					bool? isChecked = shareActionWindow.RbSharePublic.IsChecked;
					int num3 = default(int);
					while (true)
					{
						IL_0145:
						if (isChecked == true || shareActionWindow.RbShareNoPublic.IsChecked == true)
						{
							if (!shareActionWindow.TxtName.EnsureNotEmpty("动作名称") || !shareActionWindow.TxtDescription.EnsureNotEmpty("说明"))
							{
								break;
							}
							isChecked = shareActionWindow.RbSharePublic.IsChecked;
							while (true)
							{
								int num2;
								if (isChecked != true || (!string.IsNullOrWhiteSpace(shareActionWindow.Action.Icon) && !shareActionWindow.Action.Icon.Contains("_system")))
								{
									if (shareActionWindow.LblChangeLog.Visibility == Visibility.Visible)
									{
										num2 = 0;
										if (lpcsPUWMyEQMXfxnA2gM != null)
										{
											goto IL_00d3;
										}
										goto IL_00d4;
									}
									goto IL_018a;
								}
								MessageBoxHelper.Show(shareActionWindow, "公开分享需要您为动作设置一个合适的图标，不能使用默认图标。");
								break;
								IL_00d3:
								num2 = num3;
								goto IL_00d4;
								IL_00d4:
								while (true)
								{
									switch (num2)
									{
									case 2:
										goto end_IL_00d4;
									case 4:
										goto IL_0145;
									case 1:
										goto end_IL_011d;
									case 3:
										goto end_IL_011d;
									}
									if (shareActionWindow.TxtChangeLog.Text.IsNullOrEmpty())
									{
										MessageBoxHelper.Show(shareActionWindow, "请输入更新说明。");
										num2 = 1;
										if (lpcsPUWMyEQMXfxnA2gM == null)
										{
											continue;
										}
										goto IL_00d3;
									}
									goto IL_018a;
									continue;
									end_IL_00d4:
									break;
								}
								continue;
								end_IL_011d:
								break;
							}
						}
						else
						{
							MessageBoxHelper.Show(shareActionWindow, "请选择分享方式。", "Quicker");
						}
						break;
						IL_018a:
						if (shareActionWindow.CbUserLimit.SelectedItem as ActionUserLimitation? == ActionUserLimitation.ReadOnly)
						{
							if (string.IsNullOrEmpty(shareActionWindow.Action.MinQuickerVersion))
							{
								shareActionWindow.Action.MinQuickerVersion = "1.38.15";
							}
							else if (SoftVersionHelper.IsVersionNewer("1.38.15", shareActionWindow.Action.MinQuickerVersion))
							{
								AppHelper.ShowWarning("只读动作的最低Quicker版本要求不应该低于1.38.15版本。");
								break;
							}
							if (!AppHelper.Confirm("1) 只读限制将禁止使用者编辑、复制或分享动作。\r\n2) 只在1.38.15+以上的Quicker版本上生效，旧版Quicker上无效。\r\n3) 可能存在其它绕过此限制的方式。\r\n4) 建议使用非公开方式分享只读动作。\r\n\r\n\r\n您确认要以只读方式分享么？"))
							{
								break;
							}
						}
						else if ((shareActionWindow.Action.Data.Length + shareActionWindow.Action.ContextMenuData?.Length).GetValueOrDefault() > 500000)
						{
							AppHelper.ShowWarning("动作超过500K，仅支持以只读方式分享。", true);
							break;
						}
						shareActionWindow.BtnOk.IsEnabled = false;
						goto IL_02b0;
					}
				}
				goto end_IL_000e;
				IL_02b0:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = shareActionWindow.mgbgfxCy8Lh().GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter);
						if (TEqgsCWMp7i07YPQNrTF())
						{
							switch (0)
							{
							}
						}
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning(ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						shareActionWindow.BtnOk.IsEnabled = true;
					}
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

		internal static bool TEqgsCWMp7i07YPQNrTF()
		{
			return lpcsPUWMyEQMXfxnA2gM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoShare_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ShareActionWindow _003C_003E4__this;

		private ApiResult<SharedActionDto> _003Cresult_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private string _003Clink_003E5__3;

		private TaskAwaiter<(bool isSuccess, string button)> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		internal static object tGXYRBWMAD1rRbd15ZfA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareActionWindow shareActionWindow = _003C_003E4__this;
			try
			{
        SharedActionVm sharedActionVm = default;
				if ((uint)num <= 2u)
				{
					goto IL_0355;
				}
				SharedActionDto oldSharedAction = shareActionWindow.OldSharedAction;
				if (oldSharedAction != null)
				{
					Guid id = oldSharedAction.Id;
					if (0 == 0)
					{
						goto IL_0060;
					}
				}
				if (string.IsNullOrEmpty(shareActionWindow.Action.TemplateId) || MessageBoxHelper.Show(shareActionWindow, "此动作是从动作库安装的，再次分享可能会受到限制或造成重复。您确定要分享么？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
				{
					goto IL_0060;
				}
				goto end_IL_0010;
				IL_0060:
				ActionUserLimitation valueOrDefault = (shareActionWindow.CbUserLimit.SelectedItem as ActionUserLimitation?).GetValueOrDefault();
				sharedActionVm = new SharedActionVm
				{
					Id = shareActionWindow.OldSharedAction?.Id,
					ActionType = shareActionWindow.Action.ActionType,
					Children = shareActionWindow.Action.Children,
					Title = shareActionWindow.TxtName.Text,
					Data = shareActionWindow.Action.Data,
					Data2 = shareActionWindow.Action.Data2,
					Data3 = shareActionWindow.Action.Data3,
					Description = shareActionWindow.TxtDescription.Text,
					InternalId = shareActionWindow.Action.Id,
					SourceSharedActionId = shareActionWindow.Action.TemplateId,
					SourceSharedActionRevision = shareActionWindow.Action.TemplateRevision,
					SourceProfileId = shareActionWindow.Profile.Id,
					Language = Thread.CurrentThread.CurrentCulture.Name,
					Icon = shareActionWindow.Action.Icon,
					Tags = string.Join(",", shareActionWindow.cbTags.SelectedItems.Cast<string>()),
					Keywords = shareActionWindow.TxtKeywords.Text,
					IsPublic = (shareActionWindow.RbSharePublic.IsChecked == true),
					ChangeLog = shareActionWindow.TxtChangeLog.Text,
					SoftVersion = AppHelper.GetSoftVersion(),
					MinQuickerVersion = shareActionWindow.Action.MinQuickerVersion,
					UserLimitation = valueOrDefault,
					ContextMenuData = shareActionWindow.Action.ContextMenuData,
					EnableEvaluateVariable = shareActionWindow.Action.EnableEvaluateVariable,
					DoNotClosePanel = (shareActionWindow.Action.DoNotClosePanel == true),
					AllowScrollTrigger = shareActionWindow.Action.AllowScrollTrigger,
					Association = shareActionWindow.Action.Association
				};
				if (shareActionWindow.Action.ActionType == ActionType.XAction)
				{
					try
					{
						sharedActionVm.Data = ShareActionHelper.EmbedGlobalSubPrograms(shareActionWindow.Action.Data);
					}
					catch (Exception exception)
					{
						AppHelper.ShowWarning("将公共子程序转换为内部子程序时出错。" + exception.GetMessageWithInner(), true);
						goto end_IL_0010;
					}
				}
				ExeInfo exeInfo;
				int num2;
				if (shareActionWindow.CbValidFor.SelectedItem != null)
				{
					exeInfo = shareActionWindow.CbValidFor.SelectedItem as ExeInfo;
					sharedActionVm.ExeFile = exeInfo.Exe;
					num2 = 0;
					if (tGXYRBWMAD1rRbd15ZfA == null)
					{
						goto IL_030e;
					}
					goto IL_032d;
				}
				sharedActionVm.ExeFile = "common";
				sharedActionVm.ExeFullpath = "";
				goto IL_0355;
				IL_0355:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter3 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
					TaskAwaiter<(bool, string)> awaiter2 = default(TaskAwaiter<(bool, string)>);
					int num3;
					TaskAwaiter awaiter;
					ApiResult<SharedActionDto> result;
					(bool, string) result2;
					int num4 = default(int);
					switch (num)
					{
					default:
						awaiter3 = aFIptTXYsUoTUF4v33R.vnvt1pYyGU6(sharedActionVm).ConfigureAwait(true).GetAwaiter();
						if (awaiter3.IsCompleted)
						{
							goto IL_03ac;
						}
						goto IL_0690;
					case 0:
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_03ac;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<(bool, string)>);
						num3 = 1;
						if (tGXYRBWMAD1rRbd15ZfA != null)
						{
							goto IL_055c;
						}
						goto IL_05d6;
					case 2:
						{
							awaiter = _003C_003Eu__3;
							_003C_003Eu__3 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_06d3;
						}
						IL_03ac:
						result = awaiter3.GetResult();
						_003Cresult_003E5__2 = result;
						if (_003Cresult_003E5__2.IsSuccess)
						{
							shareActionWindow.IZNgfmeKA4A(_003Cresult_003E5__2.Data, true);
							shareActionWindow.NewSharedAction = _003Cresult_003E5__2.Data;
							int revision = shareActionWindow.NewSharedAction.Revision;
							bool isPublic = shareActionWindow.NewSharedAction.IsPublic;
							ActionReviewState reviewState = shareActionWindow.NewSharedAction.ReviewState;
							_003Clink_003E5__3 = AppHelper.CreateSharedActionLink(shareActionWindow.NewSharedAction.Id.ToString());
							if (isPublic && reviewState == ActionReviewState.NotSubmitted)
							{
								awaiter2 = ConfirmDialog.jQyL0Wq9wU6(shareActionWindow, "动作分享成功", shareActionWindow.Action?.Icon, "动作【" + shareActionWindow.Action.Title + "】已经分享成功，请在网页中完善动作说明和演示信息后提交到动作库。", "success", "完善动作信息(_N)|Yes\r\n关闭(_C)", "Yes").GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 1;
									_003C_003E1__state = 1;
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0562;
							}
							if (_003Cresult_003E5__2.Data.Revision < 1)
							{
								num3 = 4;
								if (tGXYRBWMAD1rRbd15ZfA != null)
								{
									goto IL_055c;
								}
								goto IL_05d6;
							}
							goto IL_0667;
						}
						AppHelper.ShowWarning("分享失败。" + _003Cresult_003E5__2.Message);
						break;
						IL_05d6:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_05d6;
							case 2:
								shareActionWindow.Close();
								goto IL_06e1;
							case 4:
								goto IL_065c;
							case 5:
								goto IL_0690;
							case 3:
								goto IL_06e1;
							}
							num = -1;
							_003C_003E1__state = -1;
							num3 = 0;
							if (TkMbtdWMnTNiPySMqhwP())
							{
								continue;
							}
							goto IL_055c;
							continue;
							end_IL_05d6:
							break;
						}
						goto IL_0562;
						IL_065c:
						AppHelper.TryOpenUrlOrFile(_003Clink_003E5__3);
						goto IL_0667;
						IL_0562:
						result2 = awaiter2.GetResult();
						if (!result2.Item1 || !(result2.Item2 == "Yes"))
						{
							AppHelper.ShowInformation("网址已写入剪贴板。");
							if (_003Cresult_003E5__2.Data.Revision < 1)
							{
								AppHelper.TryOpenUrlOrFile(_003Clink_003E5__3);
							}
							ClipboardHelper.SetText(_003Clink_003E5__3);
							num3 = 2;
							if (tGXYRBWMAD1rRbd15ZfA != null)
							{
								goto IL_055c;
							}
							goto IL_05d6;
						}
						awaiter = AppHelper.tNBLTbaIvty($"/Member/AfterShareAction?id={shareActionWindow.NewSharedAction.Id}").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_06d3;
						IL_055c:
						num3 = num4;
						goto IL_05d6;
						IL_0667:
						ClipboardHelper.SetText(_003Clink_003E5__3);
						AppHelper.ShowSuccess("分享成功！网址已写入剪贴板。");
						shareActionWindow.Close();
						goto IL_06e1;
						IL_06e1:
						_003Clink_003E5__3 = null;
						break;
						IL_06d3:
						awaiter.GetResult();
						shareActionWindow.Close();
						goto IL_06e1;
						IL_0690:
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter3;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					_003Cresult_003E5__2 = null;
				}
				catch (Exception ex)
				{
					MessageBoxHelper.Show(shareActionWindow, "分享出错。" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				}
				goto end_IL_0010;
				IL_032d:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0355;
				}
				goto IL_030e;
				IL_030e:
				sharedActionVm.ExeFullpath = exeInfo.Path;
				num2 = 0;
				if (!TkMbtdWMnTNiPySMqhwP())
				{
					int num5 = default(int);
					num2 = num5;
				}
				goto IL_032d;
				end_IL_0010:;
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

		internal static bool TkMbtdWMnTNiPySMqhwP()
		{
			return tGXYRBWMAD1rRbd15ZfA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ShareActionWindow _003C_003E4__this;

		private string _003Cexe_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object YwCnrEWMJgouxQ2Ishrf;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ShareActionWindow shareActionWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003Cexe_003E5__2 = "common";
					if (!string.IsNullOrEmpty(shareActionWindow.Profile.ExeFile))
					{
						_003Cexe_003E5__2 = shareActionWindow.Profile.ExeFile;
						if (string.Equals(_003Cexe_003E5__2, "taskbar", StringComparison.OrdinalIgnoreCase) || string.Equals(_003Cexe_003E5__2, "desktop", StringComparison.OrdinalIgnoreCase) || string.Equals(_003Cexe_003E5__2, "_global", StringComparison.OrdinalIgnoreCase) || _003Cexe_003E5__2.StartsWith("#_"))
						{
							_003Cexe_003E5__2 = "common";
						}
					}
					shareActionWindow.cbTags.ItemsSource = AppState.ActionTags;
					shareActionWindow.CbUserLimit.ItemsSource = new List<ActionUserLimitation>
					{
						ActionUserLimitation.None,
						ActionUserLimitation.NoShareToActionStore,
						ActionUserLimitation.ReadOnly
					};
					shareActionWindow.CbUserLimit.SelectedIndex = 0;
					int num2 = 0;
					if (YwCnrEWMJgouxQ2Ishrf != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_049a;
					}
					shareActionWindow.BtnAction.SetAction(shareActionWindow.Action);
					shareActionWindow.TxtName.Text = shareActionWindow.Action.Title;
					shareActionWindow.TxtDescription.Text = shareActionWindow.Action.Description;
				}
				try
				{
        ApiResult<SharedActionDto> result = default;
					ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter awaiter;
					int num4;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.nGpt1D5WKDf(shareActionWindow.Action).ConfigureAwait(true).GetAwaiter();
						num4 = 4;
						if (YwCnrEWMJgouxQ2Ishrf == null)
						{
							goto IL_035e;
						}
						goto IL_0379;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedActionDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0197;
					IL_03e5:
					result = default(ApiResult<SharedActionDto>);
					if (!string.IsNullOrEmpty(result.Data.ExeFile))
					{
						_003Cexe_003E5__2 = result.Data.ExeFile;
					}
					if (result.Data.IsPublic)
					{
						shareActionWindow.RbSharePublic.IsChecked = true;
					}
					shareActionWindow.CbUserLimit.SelectedItem = result.Data.UserLimitation;
					shareActionWindow.LblChangeLog.Visibility = Visibility.Visible;
					shareActionWindow.PnlChangeLog.Visibility = Visibility.Visible;
					goto end_IL_0143;
					IL_0463:
					shareActionWindow.LblChangeLog.Visibility = Visibility.Collapsed;
					shareActionWindow.PnlChangeLog.Visibility = Visibility.Collapsed;
					goto end_IL_0143;
					IL_0379:
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0197;
					IL_0197:
					result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						shareActionWindow.OldSharedAction = result.Data;
						shareActionWindow.IZNgfmeKA4A(result.Data, false);
						shareActionWindow.TxtName.Text = result.Data.Title;
						shareActionWindow.TxtKeywords.Text = result.Data.Keywords;
						shareActionWindow.RbSharePublic.IsChecked = result.Data.IsPublic;
						shareActionWindow.RbShareNoPublic.IsChecked = !result.Data.IsPublic;
						if (!(result.Data.Title != shareActionWindow.Action.Title))
						{
							goto IL_0295;
						}
						shareActionWindow.LblUpdateName.Text = "更新名称为“" + shareActionWindow.Action.Title + "”?";
						num4 = 0;
						if (YwCnrEWMJgouxQ2Ishrf != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						goto IL_035e;
					}
					goto IL_0463;
					IL_0295:
					string tags = result.Data.Tags;
					object obj;
					if (tags != null)
					{
						obj = tags.Replace(" ", ",").Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
						if (obj != null)
						{
							goto IL_02d1;
						}
					}
					else
					{
						obj = null;
					}
					obj = new string[0];
					goto IL_02d1;
					IL_0393:
					if (!string.IsNullOrEmpty(shareActionWindow.OldSharedAction.Description))
					{
						shareActionWindow.TxtDescription.Text = shareActionWindow.OldSharedAction.Description;
					}
					goto IL_03e5;
					IL_02d1:
					string[] array = (string[])obj;
					foreach (string value in array)
					{
						try
						{
							shareActionWindow.cbTags.SelectedItems.Add(value);
						}
						catch (Exception)
						{
						}
					}
					if (string.IsNullOrEmpty(shareActionWindow.TxtDescription.Text))
					{
						num4 = 1;
						if (l1yOV2WMksDFSxFJauFf())
						{
							goto IL_035e;
						}
						goto IL_0393;
					}
					goto IL_03e5;
					IL_035e:
					switch (num4)
					{
					case 4:
						goto IL_0379;
					case 1:
						goto IL_0393;
					case 2:
						goto IL_0463;
					case 3:
						goto end_IL_0143;
					}
					shareActionWindow.LblUpdateName.ToolTip = "点击将已分享的动作名称更新成和当前动作名称相同。";
					shareActionWindow.LblUpdateName.MouseDown += shareActionWindow.gWAgf5WT3VH;
					goto IL_0295;
					end_IL_0143:;
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("网络调用失败，请检查您的网络是否通畅。" + ex2.Message);
				}
				goto IL_049a;
				IL_049a:
				if (!string.IsNullOrEmpty(shareActionWindow.Action.TemplateId))
				{
					shareActionWindow.LblTemplateInfo.Visibility = Visibility.Visible;
					shareActionWindow.LblTemplateInfo.Content = "此动作从已分享的动作创建，点击查看来源信息。";
					shareActionWindow.LblTemplateInfo.PreviewMouseDown += shareActionWindow.q0pgfDRyUwd;
				}
				shareActionWindow.FkogfXw4HHJ(_003Cexe_003E5__2);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cexe_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cexe_003E5__2 = null;
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

		internal static bool l1yOV2WMksDFSxFJauFf()
		{
			return YwCnrEWMJgouxQ2Ishrf == null;
		}
	}

	[CompilerGenerated]
	private ActionProfile L8ZgfdAccxj;

	[CompilerGenerated]
	private ActionItem etNgfoSLeVO;

	[CompilerGenerated]
	private SharedActionDto c4xgfT9AIqC;

	[CompilerGenerated]
	private SharedActionDto bA1gfMbXalY;

	private ObservableCollection<ExeInfo> bV5gfA3XJaj;

	internal ActionButton BtnAction;

	internal RadioButton RbShareNoPublic;

	internal RadioButton RbSharePublic;

	internal System.Windows.Controls.TextBox TxtName;

	internal TextBlock LblUpdateName;

	internal System.Windows.Controls.TextBox TxtDescription;

	internal TextBlock LblValidFor;

	internal Border PnlValidFor;

	internal System.Windows.Controls.ComboBox CbValidFor;

	internal System.Windows.Controls.TextBox TxtKeywords;

	internal CheckComboBox cbTags;

	internal TextBlock LblChangeLog;

	internal StackPanel PnlChangeLog;

	internal TextBoxWithToolsControl TxtChangeLog;

	internal TextBlock LblUserLimitation;

	internal StackPanel PnlUserLimitation;

	internal System.Windows.Controls.ComboBox CbUserLimit;

	internal Button BtnOk;

	internal Label BtnCopyLink;

	internal Label BtnOpenPage;

	internal Label LblTemplateInfo;

	internal Label LblSharedInfo;

	private bool jXMgfOHenIK;

	internal static ShareActionWindow X59TURFpSMMoIEWicbcE;

	public ActionProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return L8ZgfdAccxj;
		}
		[CompilerGenerated]
		set
		{
			L8ZgfdAccxj = value;
		}
	}

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return etNgfoSLeVO;
		}
		[CompilerGenerated]
		set
		{
			etNgfoSLeVO = value;
		}
	}

	public SharedActionDto OldSharedAction
	{
		[CompilerGenerated]
		get
		{
			return c4xgfT9AIqC;
		}
		[CompilerGenerated]
		set
		{
			c4xgfT9AIqC = value;
		}
	}

	public SharedActionDto NewSharedAction
	{
		[CompilerGenerated]
		get
		{
			return bA1gfMbXalY;
		}
		[CompilerGenerated]
		set
		{
			bA1gfMbXalY = value;
		}
	}

	public ShareActionWindow()
	{
		InitializeComponent();
		base.Loaded += w9Kgfb1cObv;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__18))]
	private void w9Kgfb1cObv(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__18 stateMachine = default(_003COnLoaded_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void qF0gf65rTuj(string string_0)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.bSBSr3Ef96B = string_0;
		ExeInfo exeInfo = bV5gfA3XJaj.FirstOrDefault(_003C_003Ec__DisplayClass19_.s33SriCbe5U);
		if (exeInfo == null)
		{
			exeInfo = new ExeInfo
			{
				Exe = _003C_003Ec__DisplayClass19_.bSBSr3Ef96B,
				Name = _003C_003Ec__DisplayClass19_.bSBSr3Ef96B
			};
			bV5gfA3XJaj.Add(exeInfo);
		}
		CbValidFor.SelectedItem = exeInfo;
	}

	private void FkogfXw4HHJ(string string_0)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.fybSrzZqJPh = this;
		_003C_003Ec__DisplayClass21_.vrESpwHI107 = string_0;
		Task.Run((Action)_003C_003Ec__DisplayClass21_.lhVSrfsaCPR);
	}

	private void IZNgfmeKA4A(SharedActionDto sharedActionDto_2, bool bool_1)
	{
		string tag = AppHelper.CreateSharedActionLink(sharedActionDto_2);
		if (bool_1)
		{
			LblSharedInfo.Content = "动作已成功分享。";
		}
		LblSharedInfo.Tag = tag;
		int num = 0;
		if (!xKcSlZFpw7JNT0MTfJRu())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		BtnOk.Content = "更新(_S)";
		BtnCopyLink.Tag = tag;
		BtnOpenPage.Tag = tag;
		BtnCopyLink.Visibility = Visibility.Visible;
		BtnOpenPage.Visibility = Visibility.Visible;
	}

	[AsyncStateMachine(typeof(_003CBtnOk_OnClick_003Ed__23))]
	private void kWkgfKtgoGV(object sender, RoutedEventArgs e)
	{
		_003CBtnOk_OnClick_003Ed__23 stateMachine = default(_003CBtnOk_OnClick_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoShare_003Ed__24))]
	private Task mgbgfxCy8Lh()
	{
		_003CDoShare_003Ed__24 stateMachine = default(_003CDoShare_003Ed__24);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void dH1gfrpq6tJ(object sender, MouseButtonEventArgs e)
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

	private void thtgfpACrwf(object sender, MouseButtonEventArgs e)
	{
		string data = (sender as Label).Tag as string;
		ClipboardHelper.SetData(DataFormats.Text, data);
		AppHelper.ShowInformation("已复制到剪贴板。");
	}

	private void J9bgfB2slFn(object sender, MouseButtonEventArgs e)
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

	private void kTygfQEnTTe(object sender, MouseButtonEventArgs e)
	{
	}

	private void Dqegfjm5JpZ(object sender, RoutedEventArgs e)
	{
		if (RbSharePublic.IsChecked == true && (string.IsNullOrWhiteSpace(Action.Icon) || Action.Icon.Contains("_system")))
		{
			MessageBoxHelper.Show(this, "公开分享需要您为动作设置一个合适的图标，不能使用默认图标。");
		}
	}

	private void F9RgfnGd8hv(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void A7Wgf4Dov7L(object sender, RoutedEventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!jXMgfOHenIK)
		{
			jXMgfOHenIK = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/share/shareactionwindow.xaml", UriKind.Relative);
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
		int num = 2;
		while (true)
		{
			switch (connectionId)
			{
			default:
			{
				int num2 = 1;
				if (!xKcSlZFpw7JNT0MTfJRu())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 2:
					goto end_IL_0036;
				case 1:
					jXMgfOHenIK = true;
					return;
				case 3:
					return;
				}
				goto case 1;
			}
			case 1:
				BtnAction = (ActionButton)target;
				return;
			case 2:
				RbShareNoPublic = (RadioButton)target;
				return;
			case 3:
				RbSharePublic = (RadioButton)target;
				RbSharePublic.Checked += A7Wgf4Dov7L;
				return;
			case 4:
				TxtName = (System.Windows.Controls.TextBox)target;
				return;
			case 5:
				LblUpdateName = (TextBlock)target;
				return;
			case 6:
				TxtDescription = (System.Windows.Controls.TextBox)target;
				return;
			case 7:
				LblValidFor = (TextBlock)target;
				return;
			case 8:
				PnlValidFor = (Border)target;
				return;
			case 9:
				CbValidFor = (System.Windows.Controls.ComboBox)target;
				return;
			case 10:
				TxtKeywords = (System.Windows.Controls.TextBox)target;
				return;
			case 11:
				cbTags = (CheckComboBox)target;
				return;
			case 12:
				LblChangeLog = (TextBlock)target;
				return;
			case 13:
				PnlChangeLog = (StackPanel)target;
				return;
			case 14:
				TxtChangeLog = (TextBoxWithToolsControl)target;
				return;
			case 15:
				LblUserLimitation = (TextBlock)target;
				return;
			case 16:
				PnlUserLimitation = (StackPanel)target;
				return;
			case 17:
				CbUserLimit = (System.Windows.Controls.ComboBox)target;
				return;
			case 18:
				BtnOk = (Button)target;
				BtnOk.Click += kWkgfKtgoGV;
				return;
			case 19:
				((Button)target).Click += F9RgfnGd8hv;
				return;
			case 20:
				BtnCopyLink = (Label)target;
				BtnCopyLink.PreviewMouseDown += thtgfpACrwf;
				return;
			case 21:
				BtnOpenPage = (Label)target;
				BtnOpenPage.PreviewMouseDown += J9bgfB2slFn;
				return;
			case 22:
				LblTemplateInfo = (Label)target;
				return;
			case 23:
				{
					LblSharedInfo = (Label)target;
					LblSharedInfo.PreviewMouseDown += dH1gfrpq6tJ;
					return;
				}
				end_IL_0036:
				break;
			}
		}
	}

	[CompilerGenerated]
	private void gWAgf5WT3VH(object sender, MouseButtonEventArgs e)
	{
		TxtName.Text = Action.Title;
		LblUpdateName.Visibility = Visibility.Collapsed;
	}

	[CompilerGenerated]
	private void q0pgfDRyUwd(object sender, MouseButtonEventArgs e)
	{
		if (!string.IsNullOrEmpty(Action.TemplateId))
		{
			string fileName = AppHelper.CreateSharedActionLink(Action.TemplateId);
			try
			{
				Process.Start(fileName);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法打开网址。" + ex.Message);
			}
		}
	}

	internal static bool xKcSlZFpw7JNT0MTfJRu()
	{
		return X59TURFpSMMoIEWicbcE == null;
	}
}
