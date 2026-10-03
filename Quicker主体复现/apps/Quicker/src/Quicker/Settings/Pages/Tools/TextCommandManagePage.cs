using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using HandyControl.Controls;
using HandyControl.Data;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Settings.Pages.Triggers.TextCommand;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View;
using Quicker.View.Hotkeys;
using Quicker.View.PowerKeys;
using Quicker.View.TextCommands;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Settings.Pages.Tools;

public class TextCommandManagePage : SettingPage, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BOmvZCSdnVh;

		public static Func<Quicker.View.PowerKeys.GroupItem, string> j3cvZPwxLFj;

		public static Func<Quicker.View.PowerKeys.GroupItem, string> XACvZEOMO9V;

		public static Func<TextCommand, string> SyDvZyjEn6j;

		public static Func<string, bool> SRevZ8oPDys;

		public static Func<string, string> O4bvZaZcZxc;

		public static Func<string, Quicker.View.PowerKeys.GroupItem> f5ivZ7b7can;

		public static Func<TextCommand, Guid> tUFvZRD1qvt;

		public static Func<TextCommand, Guid> IcHvZqE5UHV;

		internal static _003C_003Ec QleSl7cLjLWGeRVA9X7e;

		static _003C_003Ec()
		{
			BOmvZCSdnVh = new _003C_003Ec();
		}

		internal string dJ2vZLvstkn(Quicker.View.PowerKeys.GroupItem x)
		{
			return x.Group;
		}

		internal string pk9vZv16JvP(Quicker.View.PowerKeys.GroupItem x)
		{
			return x.Group;
		}

		internal string NIUvZSjyKqQ(TextCommand x)
		{
			return x.Group;
		}

		internal bool JFRvZ22Pdic(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string Yo2vZuBFAYO(string x)
		{
			return x;
		}

		internal Quicker.View.PowerKeys.GroupItem UjnvZNZgFp7(string g)
		{
			return new Quicker.View.PowerKeys.GroupItem
			{
				Group = g,
				Title = g
			};
		}

		internal Guid IG1vZJYqKK9(TextCommand x)
		{
			return x.Id;
		}

		internal Guid jbnvZ0C71Ur(TextCommand x)
		{
			return x.Id;
		}

		internal static bool LckwDccLDTkMi0lDNJMX()
		{
			return QleSl7cLjLWGeRVA9X7e == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public Quicker.View.PowerKeys.GroupItem nWavZVRe8uD;

		private static _003C_003Ec__DisplayClass30_0 vgi9kScLGuUW4w9YNqoH;

		internal bool zHjvZctGAJa(Quicker.View.PowerKeys.GroupItem x)
		{
			return x.Group == nWavZVRe8uD.Group;
		}

		internal static bool YQvs6XcL0erC19tr2Hwt()
		{
			return vgi9kScLGuUW4w9YNqoH == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBatchUpdateToServerAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public BatchUpdateTextCommandsVm vm;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object h8xwlPcLKYx65ZSVWZ9Z;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			bool result2;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.vDdtbnc4qHv(vm).ConfigureAwait(true).GetAwaiter();
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
					if (!result.IsSuccess)
					{
						AppHelper.ShowWarning("更新信息到服务器出错！" + result.Message);
						if (h8xwlPcLKYx65ZSVWZ9Z == null)
						{
							switch (0)
							{
							}
						}
						goto end_IL_0008;
					}
					result2 = true;
					goto end_IL_0007;
					end_IL_0008:;
				}
				catch (Exception exception)
				{
					string message = "更新信息到服务器出错！" + exception.GetMessageWithInner();
					rBx5IqDFvX.Warn(message, exception);
					AppHelper.ShowWarning(message);
					result2 = true;
					goto end_IL_0007;
				}
				result2 = false;
				end_IL_0007:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
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

		internal static bool VGqbrmcLBvSbEm8WVRUV()
		{
			return h8xwlPcLKYx65ZSVWZ9Z == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnDelete_OnClick_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TextCommandManagePage _003C_003E4__this;

		private TextCommand _003CtextCommand_003E5__2;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		internal static object ArklYIcLdiiZYwAW7SFa;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0043;
				}
				if (AppHelper.Confirm("您确认要删除么？删除后将不可恢复！"))
				{
					_003CtextCommand_003E5__2 = (sender as Button).Tag as TextCommand;
					goto IL_0043;
				}
				goto end_IL_0010;
				IL_0043:
				try
				{
					TaskAwaiter<ApiResult<string>> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
						num = -1;
						_003C_003E1__state = -1;
						int num2 = 0;
						if (ArklYIcLdiiZYwAW7SFa != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
					}
					else
					{
						awaiter = aFIptTXYsUoTUF4v33R.Bd5tbBqtBKI(_003CtextCommand_003E5__2.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
					textCommandManagePage.eSA5Y8ErNF.Remove(_003CtextCommand_003E5__2);
					textCommandManagePage.sTZ5hJPqhu.neZtXfcGsie().Remove(_003CtextCommand_003E5__2);
					textCommandManagePage.sGx5LCLOET();
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("删除失败(可能是网络原因)！" + exception.GetMessageWithInner());
				}
				_003CtextCommand_003E5__2 = null;
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

		internal static bool CFpcI9cLOlAGRAHVaQXY()
		{
			return ArklYIcLdiiZYwAW7SFa == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnImport_OnClick_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object vZbNJKcLkewB7YqVS1PJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
        (bool, string) tuple = default;
				if (num == 0)
				{
					goto IL_003e;
				}
				tuple = AppHelper.ShowSelectFileDialog("Json文件|*.json|任意文件|*.*", ".json", "", "", "导入文本指令");
				if (tuple.Item1)
				{
					goto IL_003e;
				}
				goto end_IL_000e;
				IL_003e:
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00e9;
					}
					string text = File.ReadAllText(tuple.Item2);
					if (JsonConvert.DeserializeObject<IList<TextCommand>>(text).HasData())
					{
						SharedTextCommandPackageDto sharedTextCommandPackageDto_ = new SharedTextCommandPackageDto
						{
							Data = text
						};
						awaiter = textCommandManagePage.MGC5RYAUF5(sharedTextCommandPackageDto_).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (vZbNJKcLkewB7YqVS1PJ != null)
							{
								switch (0)
								{
								}
							}
							return;
						}
						goto IL_00e9;
					}
					AppHelper.ShowWarning("未能成功解析数据。请确保文件内容格式合法。");
					goto end_IL_003e;
					IL_00e9:
					awaiter.GetResult();
					end_IL_003e:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("操作失败：" + ex.Message);
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

		internal static bool kgo9fEcLaNDEPRZ8LRwn()
		{
			return vZbNJKcLkewB7YqVS1PJ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnInstall_OnClick_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<SharedTextCommandPackageDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object gnxP5OcLNQHFw2g9TXoP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
				try
				{
        ConfiguredTaskAwaitable<ApiResult<SharedTextCommandPackageDto>>.ConfiguredTaskAwaiter awaiter2 = default;
        ApiResult<SharedTextCommandPackageDto> result = default;
					int num2;
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							num2 = 2;
							if (!EZt62TcL96PGXgigxhp0())
							{
								return;
							}
							goto IL_00c7;
						}
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_01c9;
					}
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<SharedTextCommandPackageDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0151;
					IL_01c9:
					awaiter.GetResult();
					goto end_IL_0011;
					IL_0151:
					result = awaiter2.GetResult();
					if (result.IsSuccess)
					{
						awaiter = textCommandManagePage.MGC5RYAUF5(result.Data).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = 1;
							if (!EZt62TcL96PGXgigxhp0())
							{
								int num3 = default(int);
								num2 = num3;
							}
							goto IL_00c7;
						}
						goto IL_01c9;
					}
					goto IL_01d2;
					IL_01d2:
					AppHelper.ShowWarning(result.Message, true);
					goto end_IL_0011;
					IL_01b1:
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
					IL_00c7:
					switch (num2)
					{
					case 2:
						break;
					case 1:
						return;
					case 3:
						goto IL_01b1;
					default:
						goto IL_01d2;
					}
					string text = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
					string text2 = "https://getquicker.net/share/textcommands/package?id=";
					if (!string.IsNullOrEmpty(text) && text.StartsWith(text2, StringComparison.OrdinalIgnoreCase))
					{
						string text3 = text.Substring(text2.Length, "00000000-0000-0000-0000-000000000000".Length);
						if (Guid.TryParse(text3, out var result2))
						{
							awaiter2 = aFIptTXYsUoTUF4v33R.G5rt149qpF2(result2).ConfigureAwait(true).GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto IL_0151;
							}
							num = 0;
							_003C_003E1__state = 0;
							goto IL_01b1;
						}
						AppHelper.ShowWarning(text3 + " 不是合法的文本指令分享包ID。", true);
					}
					else
					{
						MessageBoxHelper.Show(System.Windows.Window.GetWindow(textCommandManagePage), "剪贴板中没有文本指令包网址，请复制文本指令包网址后再点击此按钮。");
						AppHelper.TryOpenUrlOrFile("https://getquicker.net/share/textcommands");
					}
					end_IL_0011:;
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning(exception.GetMessageWithInner());
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

		internal static bool EZt62TcL96PGXgigxhp0()
		{
			return gnxP5OcLNQHFw2g9TXoP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnReload_OnClick_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Q1xNaKcLoQVfYLXwS3GF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = textCommandManagePage.sTZ5hJPqhu.sAXtXN0S6sN(true).ConfigureAwait(true).GetAwaiter();
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
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
					textCommandManagePage.mRq4fUERJt();
					AppHelper.ShowSuccess("更新成功！");
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("加载失败！" + exception.GetMessageWithInner());
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

		internal static bool rrNnftcLfJ5OcY4HPPRn()
		{
			return Q1xNaKcLoQVfYLXwS3GF == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInstallTextCommandsAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SharedTextCommandPackageDto dto;

		public TextCommandManagePage _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<TextCommand>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object cofmPpcLigv6FFymcCI1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
        IList<TextCommand> selectedTextCommands = default;
				if (num == 0)
				{
					goto IL_00ae;
				}
				InstallTextCommandWindow installTextCommandWindow = new InstallTextCommandWindow(dto, textCommandManagePage.eSA5Y8ErNF)
				{
					Owner = textCommandManagePage.ParentWindow
				};
				if (!RC7NvdcLla0NOw05GyZg())
				{
					switch (0)
					{
					}
				}
				selectedTextCommands = default(IList<TextCommand>);
				if (installTextCommandWindow.ShowDialog() == true)
				{
					bool num2 = installTextCommandWindow.GroupName == installTextCommandWindow.UseCurrentGroupStr;
					selectedTextCommands = installTextCommandWindow.SelectedTextCommands;
					if (!num2)
					{
						IEnumerator<TextCommand> enumerator = selectedTextCommands.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Group = installTextCommandWindow.GroupName;
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
					goto IL_00ae;
				}
				goto end_IL_000e;
				IL_00ae:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<TextCommand>>>.ConfiguredTaskAwaiter awaiter;
					int num3;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.wsitbr0iDiN(selectedTextCommands).ConfigureAwait(true).GetAwaiter();
						num3 = 0;
						if (cofmPpcLigv6FFymcCI1 != null)
						{
							goto IL_0173;
						}
						goto IL_0175;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<TextCommand>>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_018b;
					IL_018b:
					ApiResult<IList<TextCommand>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						textCommandManagePage.eSA5Y8ErNF.AddRange(result.Data);
						IEnumerator<TextCommand> enumerator = result.Data.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TextCommand current = enumerator.Current;
								textCommandManagePage.sTZ5hJPqhu.neZtXfcGsie().Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
						textCommandManagePage.sGx5LCLOET();
						AppHelper.ShowInformation("导入成功！");
						num3 = 1;
						if (!RC7NvdcLla0NOw05GyZg())
						{
							goto IL_0173;
						}
						goto IL_0175;
					}
					AppHelper.ShowWarning("导入失败！" + result.Message, true);
					goto end_IL_00ae;
					IL_0175:
					switch (num3)
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
						goto end_IL_00ae;
					}
					goto IL_018b;
					IL_0173:
					int num4 = default(int);
					num3 = num4;
					goto IL_0175;
					end_IL_00ae:;
				}
				catch (Exception exception)
				{
					string message = "导入文本指令出错。" + exception.GetMessageWithInner();
					rBx5IqDFvX.Warn(message, exception);
					AppHelper.ShowWarning(message, true);
				}
				end_IL_000e:;
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

		internal static bool RC7NvdcLla0NOw05GyZg()
		{
			return cofmPpcLigv6FFymcCI1 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuAddToGroup_OnClick_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object jr0RSUcL8QoWKCZn7eKM;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
        IEnumerator<TextCommand> enumerator = default;
        UpdateTextCommandGroupVm updateTextCommandGroupVm = default;
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_017f;
				}
				string textValue;
				int num2;
				if (textCommandManagePage.LvTextCommands.SelectedItems.Count == 0)
				{
					AppHelper.ShowWarning("请选中要修改分组的条目。");
				}
				else
				{
					UserInputWindow userInputWindow = new UserInputWindow("text", "请输入分组名称", "", "");
					if (userInputWindow.ShowDialog() == true)
					{
						textValue = userInputWindow.TextValue;
						num2 = 0;
						if (rdW1micLROhjovALOXte())
						{
							goto IL_0080;
						}
						goto IL_00c3;
					}
				}
				goto end_IL_0010;
				IL_00c3:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_00d1;
				}
				goto IL_0080;
				IL_0080:
				updateTextCommandGroupVm = new UpdateTextCommandGroupVm
				{
					Group = textValue,
					IdList = new List<Guid>()
				};
				enumerator = textCommandManagePage.LvTextCommands.SelectedItems.Cast<TextCommand>().GetEnumerator();
				num2 = 0;
				if (!rdW1micLROhjovALOXte())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00c3;
				IL_00d1:
				try
				{
					while (enumerator.MoveNext())
					{
						TextCommand current = enumerator.Current;
						current.Group = textValue;
						updateTextCommandGroupVm.IdList.Add(current.Id);
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
				textCommandManagePage.iLL5kBxuIW.Refresh();
				textCommandManagePage.sGx5LCLOET();
				awaiter = xpV5E5prbu(updateTextCommandGroupVm).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_017f;
				IL_017f:
				awaiter.GetResult();
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

		internal static bool rdW1micLROhjovALOXte()
		{
			return jr0RSUcL8QoWKCZn7eKM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuBatchEdit_Click_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private List<TextCommand> _003Citems_003E5__2;

		private TextCommandBatchEditWindow _003Cdlg_003E5__3;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private static object w1hrWDcLMm0cSMX2ABmE;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
        int num2 = default;
				TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00f9;
				}
				TaskAwaiter<bool> awaiter2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01ff;
				}
				num2 = default(int);
				if (textCommandManagePage.LvTextCommands.SelectedItems.Count != 0)
				{
					_003Citems_003E5__2 = textCommandManagePage.LvTextCommands.SelectedItems.Cast<TextCommand>().ToList();
					_003Cdlg_003E5__3 = new TextCommandBatchEditWindow(_003Citems_003E5__2)
					{
						Owner = System.Windows.Window.GetWindow(textCommandManagePage)
					};
					awaiter = _003Cdlg_003E5__3.MjdLOXIjD10(true).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_00f9;
					}
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					num2 = 2;
					goto IL_0221;
				}
				AppHelper.ShowWarning("请选中要修改的条目。");
				goto end_IL_0010;
				IL_0240:
				int num3;
				switch (num3)
				{
				case 2:
					break;
				default:
					return;
				case 1:
					goto end_IL_0010;
				}
				goto IL_0221;
				IL_00f9:
				if (awaiter.GetResult() == true)
				{
					BatchUpdateTextCommandsVm batchUpdateTextCommandsVm_ = new BatchUpdateTextCommandsVm
					{
						UpdateIgnoreCase = (_003Cdlg_003E5__3.ChkChangeIgnoreCase.IsChecked == true),
						IgnoreCase = _003Citems_003E5__2.First().IgnoreCase,
						UpdateTriggerKey = (_003Cdlg_003E5__3.ChkChangeTriggerKey.IsChecked == true),
						TriggerKey = _003Citems_003E5__2.First().TriggerKey,
						IdList = _003Citems_003E5__2.Select(_003C_003Ec.IcHvZqE5UHV ?? (_003C_003Ec.IcHvZqE5UHV = _003C_003Ec.BOmvZCSdnVh.jbnvZ0C71Ur)).ToList()
					};
					textCommandManagePage.iLL5kBxuIW.Refresh();
					textCommandManagePage.sGx5LCLOET();
					awaiter2 = ObD5ykqPlm(batchUpdateTextCommandsVm_).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01ff;
				}
				goto end_IL_0010;
				IL_0221:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				num3 = 0;
				if (!FhN8HgcLUuGvHZox8cpm())
				{
					goto IL_023c;
				}
				goto IL_0240;
				IL_023c:
				num3 = num2;
				goto IL_0240;
				IL_01ff:
				if (awaiter2.GetResult())
				{
					AppHelper.ShowSuccess("保存成功。");
					num3 = 1;
					if (w1hrWDcLMm0cSMX2ABmE != null)
					{
						goto IL_023c;
					}
					goto IL_0240;
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Citems_003E5__2 = null;
				_003Cdlg_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Citems_003E5__2 = null;
			_003Cdlg_003E5__3 = null;
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

		internal static bool FhN8HgcLUuGvHZox8cpm()
		{
			return w1hrWDcLMm0cSMX2ABmE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuChangeToGroup_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		public object sender;

		private TaskAwaiter _003C_003Eu__1;

		internal static object lZRLsbcL6G9GcQkuvhKl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					int num2 = 0;
					if (lZRLsbcL6G9GcQkuvhKl != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_0078;
					}
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0151;
				}
				if (textCommandManagePage.LvTextCommands.SelectedItems.Count != 0)
				{
					goto IL_0078;
				}
				AppHelper.ShowWarning("请选中要修改分组的条目。");
				goto end_IL_0010;
				IL_0151:
				awaiter.GetResult();
				goto end_IL_0010;
				IL_0078:
				string text = (sender as MenuItem).Tag as string;
				UpdateTextCommandGroupVm updateTextCommandGroupVm = new UpdateTextCommandGroupVm
				{
					Group = text,
					IdList = new List<Guid>()
				};
				IEnumerator<TextCommand> enumerator = textCommandManagePage.LvTextCommands.SelectedItems.Cast<TextCommand>().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						TextCommand current = enumerator.Current;
						current.Group = text;
						updateTextCommandGroupVm.IdList.Add(current.Id);
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
				textCommandManagePage.iLL5kBxuIW.Refresh();
				textCommandManagePage.sGx5LCLOET();
				awaiter = xpV5E5prbu(updateTextCommandGroupVm).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0151;
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

		internal static bool s4rypmcLtCGkdZbyxp0L()
		{
			return lZRLsbcL6G9GcQkuvhKl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuDelete_OnClick_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandManagePage _003C_003E4__this;

		private List<TextCommand> _003Citems_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object OZoQuscLwisNFDTkQPr9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandManagePage textCommandManagePage = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_007c;
				}
				if (textCommandManagePage.LvTextCommands.SelectedItems.Count == 0)
				{
					AppHelper.ShowWarning("请选择要操作的条目。");
				}
				else if (AppHelper.Confirm($"您确认要删除 {textCommandManagePage.LvTextCommands.SelectedItems.Count} 个条目么？\n删除后将无法恢复。"))
				{
					_003Citems_003E5__2 = textCommandManagePage.LvTextCommands.SelectedItems.Cast<TextCommand>().ToList();
					goto IL_007c;
				}
				goto end_IL_000e;
				IL_007c:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.eoPtbQoPtRc(_003Citems_003E5__2.Select(_003C_003Ec.tUFvZRD1qvt ?? (_003C_003Ec.tUFvZRD1qvt = _003C_003Ec.BOmvZCSdnVh.IG1vZJYqKK9))).ConfigureAwait(true).GetAwaiter();
						int num2 = 0;
						if (OZoQuscLwisNFDTkQPr9 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
					awaiter.GetResult();
					List<TextCommand>.Enumerator enumerator = _003Citems_003E5__2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							TextCommand current = enumerator.Current;
							textCommandManagePage.eSA5Y8ErNF.Remove(current);
							textCommandManagePage.sTZ5hJPqhu.neZtXfcGsie().Remove(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					textCommandManagePage.sGx5LCLOET();
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("删除失败(可能是网络原因)！" + exception.GetMessageWithInner());
				}
				_003Citems_003E5__2 = null;
				end_IL_000e:;
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

		internal static bool edxsUqcLTYpbNciHwY62()
		{
			return OZoQuscLwisNFDTkQPr9 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateGroupToServerAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UpdateTextCommandGroupVm vm;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object oOAfR9cLsgHwg2e21nrO;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						if (gI8reMcLCYgUu0bgDfo1())
						{
							switch (0)
							{
							}
						}
						awaiter = aFIptTXYsUoTUF4v33R.DbjtbjdQ3jY(vm).ConfigureAwait(true).GetAwaiter();
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
					if (!result.IsSuccess)
					{
						AppHelper.ShowWarning("更新分组到服务器出错！" + result.Message);
					}
				}
				catch (Exception exception)
				{
					string message = "更新分组到服务器异常！" + exception.GetMessageWithInner();
					rBx5IqDFvX.Warn(message, exception);
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

		internal static bool gI8reMcLCYgUu0bgDfo1()
		{
			return oOAfR9cLsgHwg2e21nrO == null;
		}
	}

	private readonly DataService sTZ5hJPqhu;

	private readonly ITinyMessengerHub gSg5eLMQtR;

	private SmartCollection<TextCommand> eSA5Y8ErNF = new SmartCollection<TextCommand>();

	private static readonly ILog rBx5IqDFvX;

	[CompilerGenerated]
	private SmartCollection<Quicker.View.PowerKeys.GroupItem> zih5WNhyWU = new SmartCollection<Quicker.View.PowerKeys.GroupItem>();

	private CollectionView iLL5kBxuIW;

	internal ToggleButton ChkEnableTextCommands;

	internal SearchBar TxtFilter;

	internal ToggleButton ChkHideSummary;

	internal Button BtnAddCommand;

	internal Button BtnInstall;

	internal Button BtnImport;

	internal Button BtnReload;

	internal ListView LvTextCommands;

	internal MenuItem MenuAddToGroup;

	internal MenuItem MenuBatchEdit;

	internal MenuItem MenuExport;

	internal MenuItem MenuShare;

	internal MenuItem MenuDelete;

	internal System.Windows.Controls.TabControl GroupTab;

	internal TextBlock LblVersionTip;

	private bool rNM5Gf9Npm;

	internal static TextCommandManagePage rI5gkEmGlTXJkXZwfj8;

	public SmartCollection<Quicker.View.PowerKeys.GroupItem> Groups
	{
		[CompilerGenerated]
		get
		{
			return zih5WNhyWU;
		}
		[CompilerGenerated]
		set
		{
			zih5WNhyWU = value;
		}
	}

	public TextCommandManagePage()
	{
		sTZ5hJPqhu = AppState.DataService;
		gSg5eLMQtR = AppState.Y2RtaqSv0AQ();
		InitializeComponent();
		base.Loaded += xuH43HYxR7;
		LblVersionTip.Visibility = (Visibility.Collapsed);
		GroupTab.ItemsSource = Groups;
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		dDh7g7Xw7JyQPUTbYwJ.HideTextCommandSummary = ChkHideSummary.IsChecked == true;
		return true;
	}

	private void cIt4iJN3c0()
	{
		sTZ5hJPqhu.CpItmVISR7P().EnableTextCommand = ChkEnableTextCommands.IsChecked == true;
		sTZ5hJPqhu.ydot6rVZAkW();
		gSg5eLMQtR.NotifyUserSettingsChange(this);
	}

	private void xuH43HYxR7(object sender, RoutedEventArgs e)
	{
		while (true)
		{
			mRq4fUERJt();
			if (rI5gkEmGlTXJkXZwfj8 != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		iLL5kBxuIW = (CollectionView)CollectionViewSource.GetDefaultView(eSA5Y8ErNF);
		PropertyGroupDescription item = new PropertyGroupDescription("BindingProcessName");
		iLL5kBxuIW.GroupDescriptions.Add(item);
		iLL5kBxuIW.Filter = Filter;
		iLL5kBxuIW.SortDescriptions.Add(new SortDescription("BindingProcessName", ListSortDirection.Ascending));
		iLL5kBxuIW.SortDescriptions.Add(new SortDescription("CmdText", ListSortDirection.Ascending));
		LvTextCommands.ItemsSource = iLL5kBxuIW;
		ChkEnableTextCommands.IsChecked = sTZ5hJPqhu.CpItmVISR7P().EnableTextCommand;
		ChkHideSummary.IsChecked = dDh7g7Xw7JyQPUTbYwJ.HideTextCommandSummary;
	}

	private void mRq4fUERJt()
	{
		eSA5Y8ErNF.Reset(sTZ5hJPqhu.neZtXfcGsie());
		lNq5C5xLNo();
	}

	private bool Filter(object obj)
	{
		bool flag = false;
		int num;
		TextCommand textCommand = default(TextCommand);
		int num2;
		if (string.IsNullOrEmpty(TxtFilter.Text))
		{
			num = 0;
			if (KxaihNm0HN2KIMnhspJ())
			{
				goto IL_004e;
			}
		}
		else
		{
			textCommand = obj as TextCommand;
			if (textCommand == null)
			{
				num2 = 0;
				goto IL_0094;
			}
			num = 1;
			if (rI5gkEmGlTXJkXZwfj8 != null)
			{
				int num3 = default(int);
				num = num3;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_0053;
		}
		goto IL_004e;
		IL_0053:
		num2 = (TxtFilter.Text.ContainedInAny(textCommand.CmdText, textCommand.BindingProcessName, textCommand.Title, textCommand.GetSummary()) ? 1 : 0);
		goto IL_0094;
		IL_004e:
		flag = true;
		goto IL_0096;
		IL_0094:
		flag = (byte)num2 != 0;
		goto IL_0096;
		IL_0096:
		if (!flag)
		{
			return false;
		}
		if (GroupTab.SelectedItem == null)
		{
			return true;
		}
		string text = (GroupTab.SelectedItem as Quicker.View.PowerKeys.GroupItem).Group;
		if (text == "__all_items")
		{
			return true;
		}
		TextCommand textCommand2 = obj as TextCommand;
		if (text == "__not_grouped" && string.IsNullOrEmpty(textCommand2?.Group))
		{
			return true;
		}
		return string.Equals(textCommand2?.Group, text);
	}

	private void akk4zLau8d(object sender, RoutedEventArgs e)
	{
		{
			TextCommandEditWindow textCommandEditWindow = new TextCommandEditWindow(sTZ5hJPqhu, VMW5tSauPM(), Groups.Select(_003C_003Ec.j3cvZPwxLFj ?? (_003C_003Ec.j3cvZPwxLFj = _003C_003Ec.BOmvZCSdnVh.dJ2vZLvstkn)).ToList());
			textCommandEditWindow.Owner = base.ParentWindow;
			if (textCommandEditWindow.ShowDialog() == true)
			{
				eSA5Y8ErNF.Add(textCommandEditWindow.TextCommand);
				sTZ5hJPqhu.neZtXfcGsie().Add(textCommandEditWindow.TextCommand);
				sGx5LCLOET();
			}
		}
	}

	private void B8R5wOfHBh(object sender, RoutedEventArgs e)
	{
		TextCommand textCommand_ = (sender as Button).Tag as TextCommand;
		yWF5guovZU(textCommand_);
	}

	private string VMW5tSauPM()
	{
		if (GroupTab.SelectedItem != null && GroupTab.SelectedItem is Quicker.View.PowerKeys.GroupItem groupItem && groupItem.Group != "__all_items" && groupItem.Group != "__not_grouped")
		{
			return groupItem.Group;
		}
		return "";
	}

	private void yWF5guovZU(TextCommand textCommand_0)
	{
		TextCommandEditWindow textCommandEditWindow = new TextCommandEditWindow(sTZ5hJPqhu, VMW5tSauPM(), Groups.Select(_003C_003Ec.XACvZEOMO9V ?? (_003C_003Ec.XACvZEOMO9V = _003C_003Ec.BOmvZCSdnVh.pk9vZv16JvP)).ToList())
		{
			TextCommand = textCommand_0
		};
		textCommandEditWindow.Owner = base.ParentWindow;
		if (textCommandEditWindow.ShowDialog() == true)
		{
			eSA5Y8ErNF.Remove(textCommand_0);
			int num = 0;
			if (rI5gkEmGlTXJkXZwfj8 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			eSA5Y8ErNF.Add(textCommandEditWindow.TextCommand);
			sTZ5hJPqhu.neZtXfcGsie().Remove(textCommand_0);
			sTZ5hJPqhu.neZtXfcGsie().Add(textCommandEditWindow.TextCommand);
			sGx5LCLOET();
		}
	}

	private void sGx5LCLOET()
	{
		sTZ5hJPqhu.il2tXPiARoC();
		lNq5C5xLNo();
	}

	[AsyncStateMachine(typeof(_003CBtnDelete_OnClick_003Ed__23))]
	private void KpW5vNmG0r(object sender, RoutedEventArgs e)
	{
		_003CBtnDelete_OnClick_003Ed__23 stateMachine = default(_003CBtnDelete_OnClick_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void kpR5Su4GFU(object sender, MouseButtonEventArgs e)
	{
		if (((ListViewItem)sender).Content is TextCommand textCommand_)
		{
			yWF5guovZU(textCommand_);
		}
	}

	private void mlA52jK6Ji(object sender, TextChangedEventArgs e)
	{
		iLL5kBxuIW.Refresh();
	}

	[AsyncStateMachine(typeof(_003CBtnReload_OnClick_003Ed__26))]
	private void eq75ucGTyV(object sender, RoutedEventArgs e)
	{
		_003CBtnReload_OnClick_003Ed__26 stateMachine = default(_003CBtnReload_OnClick_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void PDY5N7j0Qq(object sender, RoutedEventArgs e)
	{
		cIt4iJN3c0();
	}

	private void s8E5JIYTeD(object sender, RoutedEventArgs e)
	{
		cIt4iJN3c0();
	}

	private void bQ450fpghl(object sender, SelectionChangedEventArgs e)
	{
		iLL5kBxuIW?.Refresh();
	}

	private void lNq5C5xLNo()
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		int num;
		if (!eSA5Y8ErNF.HasData())
		{
			Groups.Clear();
			num = 1;
			if (rI5gkEmGlTXJkXZwfj8 == null)
			{
				goto IL_0275;
			}
		}
		else
		{
			IList<Quicker.View.PowerKeys.GroupItem> list = eSA5Y8ErNF.Select(_003C_003Ec.SyDvZyjEn6j ?? (_003C_003Ec.SyDvZyjEn6j = _003C_003Ec.BOmvZCSdnVh.NIUvZSjyKqQ)).Distinct().Where(_003C_003Ec.SRevZ8oPDys ?? (_003C_003Ec.SRevZ8oPDys = _003C_003Ec.BOmvZCSdnVh.JFRvZ22Pdic))
				.OrderBy(_003C_003Ec.O4bvZaZcZxc ?? (_003C_003Ec.O4bvZaZcZxc = _003C_003Ec.BOmvZCSdnVh.Yo2vZuBFAYO))
				.Select(_003C_003Ec.f5ivZ7b7can ?? (_003C_003Ec.f5ivZ7b7can = _003C_003Ec.BOmvZCSdnVh.UjnvZNZgFp7))
				.ToList();
			list.Insert(0, new Quicker.View.PowerKeys.GroupItem
			{
				Group = "__all_items",
				Title = "*所有*"
			});
			list.Insert(1, new Quicker.View.PowerKeys.GroupItem
			{
				Group = "__not_grouped",
				Title = "*未分组*"
			});
			MenuAddToGroup.Items.Clear();
			foreach (Quicker.View.PowerKeys.GroupItem item in list)
			{
				if (item.Group != "__all_items")
				{
					AppHelper.AddMenuItem(MenuAddToGroup.Items, item.Title, null, "", Xtk5Pbx3T8).Tag = ((item.Group == "__not_grouped") ? string.Empty : item.Group);
				}
			}
			AppHelper.AddMenuItem(MenuAddToGroup.Items, "新分组...", "添加到一个新的分组", "", I1s589X36R);
			_003C_003Ec__DisplayClass30_.nWavZVRe8uD = GroupTab.SelectedItem as Quicker.View.PowerKeys.GroupItem;
			Groups.Reset(list);
			if (_003C_003Ec__DisplayClass30_.nWavZVRe8uD != null)
			{
				Quicker.View.PowerKeys.GroupItem groupItem = list.FirstOrDefault(_003C_003Ec__DisplayClass30_.zHjvZctGAJa);
				if (groupItem != null)
				{
					GroupTab.SelectedItem = groupItem;
				}
			}
			if (GroupTab.SelectedItem != null)
			{
				return;
			}
			num = 0;
			if (KxaihNm0HN2KIMnhspJ())
			{
				goto IL_0275;
			}
		}
		goto IL_0282;
		IL_0275:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0282;
		IL_0282:
		GroupTab.SelectedIndex = 0;
	}

	[AsyncStateMachine(typeof(_003CMenuChangeToGroup_003Ed__31))]
	private void Xtk5Pbx3T8(object sender, RoutedEventArgs e)
	{
		_003CMenuChangeToGroup_003Ed__31 stateMachine = default(_003CMenuChangeToGroup_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CUpdateGroupToServerAsync_003Ed__32))]
	private static Task xpV5E5prbu(UpdateTextCommandGroupVm updateTextCommandGroupVm_0)
	{
		_003CUpdateGroupToServerAsync_003Ed__32 stateMachine = default(_003CUpdateGroupToServerAsync_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.vm = updateTextCommandGroupVm_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBatchUpdateToServerAsync_003Ed__33))]
	private static Task<bool> ObD5ykqPlm(BatchUpdateTextCommandsVm batchUpdateTextCommandsVm_0)
	{
		_003CBatchUpdateToServerAsync_003Ed__33 stateMachine = default(_003CBatchUpdateToServerAsync_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.vm = batchUpdateTextCommandsVm_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CMenuAddToGroup_OnClick_003Ed__34))]
	private void I1s589X36R(object sender, RoutedEventArgs e)
	{
		_003CMenuAddToGroup_OnClick_003Ed__34 stateMachine = default(_003CMenuAddToGroup_OnClick_003Ed__34);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void shw5aAXu9o(object sender, RoutedEventArgs e)
	{
		if (LvTextCommands.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要操作的条目。");
		}
		else if (LvTextCommands.SelectedItems.Count >= 2 || AppHelper.Confirm("每个配置包可以包含多个文本指令。您确认只分享这一个文本指令么？"))
		{
			ShareTextCommandWindow shareTextCommandWindow = new ShareTextCommandWindow(LvTextCommands.SelectedItems.Cast<TextCommand>().ToList());
			shareTextCommandWindow.Owner = base.ParentWindow;
			shareTextCommandWindow.ShowDialog();
		}
	}

	[AsyncStateMachine(typeof(_003CBtnInstall_OnClick_003Ed__36))]
	private void MHb57scniw(object sender, RoutedEventArgs e)
	{
		_003CBtnInstall_OnClick_003Ed__36 stateMachine = default(_003CBtnInstall_OnClick_003Ed__36);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CInstallTextCommandsAsync_003Ed__37))]
	private Task MGC5RYAUF5(SharedTextCommandPackageDto sharedTextCommandPackageDto_0)
	{
		_003CInstallTextCommandsAsync_003Ed__37 stateMachine = default(_003CInstallTextCommandsAsync_003Ed__37);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.dto = sharedTextCommandPackageDto_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CMenuDelete_OnClick_003Ed__38))]
	private void sCT5qpRgvt(object sender, RoutedEventArgs e)
	{
		_003CMenuDelete_OnClick_003Ed__38 stateMachine = default(_003CMenuDelete_OnClick_003Ed__38);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		cIt4iJN3c0();
	}

	private void oSC5cx6fbV(object sender, FunctionEventArgs<string> e)
	{
		iLL5kBxuIW.Refresh();
	}

	private void oUI5VniFDS(object sender, RoutedEventArgs e)
	{
		if (LvTextCommands.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选择要操作的条目。");
			return;
		}
		if (LvTextCommands.SelectedItems.Count < 2 && !AppHelper.Confirm("每个配置包可以包含多个文本指令。您确认只分享这一个文本指令么？"))
		{
			if (rI5gkEmGlTXJkXZwfj8 != null)
			{
				switch (0)
				{
				}
			}
			return;
		}
		List<TextCommand> value = LvTextCommands.SelectedItems.Cast<TextCommand>().ToList();
		(bool, string) tuple = AppHelper.ShowSaveFileDialog("Json文件|*.json|任意文件|*.*", ".json", "文本指令导出" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json", "", "导出文本指令");
		if (tuple.Item1)
		{
			File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(value, Formatting.Indented));
			AppHelper.SelectFileInExplorer(tuple.Item2, false);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnImport_OnClick_003Ed__42))]
	private void y375ZZyZng(object sender, RoutedEventArgs e)
	{
		_003CBtnImport_OnClick_003Ed__42 stateMachine = default(_003CBtnImport_OnClick_003Ed__42);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CMenuBatchEdit_Click_003Ed__43))]
	private void xa959MLkMQ(object sender, RoutedEventArgs e)
	{
		_003CMenuBatchEdit_Click_003Ed__43 stateMachine = default(_003CMenuBatchEdit_Click_003Ed__43);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!rNM5Gf9Npm)
		{
			rNM5Gf9Npm = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/triggers/textcommand/textcommandmanagepage.xaml", UriKind.Relative);
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
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			ChkEnableTextCommands = (ToggleButton)target;
			ChkEnableTextCommands.Click += PDY5N7j0Qq;
			num = 2;
			if (rI5gkEmGlTXJkXZwfj8 != null)
			{
				return;
			}
			break;
		case 2:
			TxtFilter = (SearchBar)target;
			TxtFilter.SearchStarted += oSC5cx6fbV;
			return;
		case 3:
			ChkHideSummary = (ToggleButton)target;
			return;
		case 4:
			BtnAddCommand = (Button)target;
			BtnAddCommand.Click += akk4zLau8d;
			return;
		case 5:
			BtnInstall = (Button)target;
			BtnInstall.Click += MHb57scniw;
			return;
		case 6:
			BtnImport = (Button)target;
			BtnImport.Click += y375ZZyZng;
			return;
		case 7:
			BtnReload = (Button)target;
			BtnReload.Click += eq75ucGTyV;
			return;
		case 8:
			LvTextCommands = (ListView)target;
			return;
		case 9:
			MenuAddToGroup = (MenuItem)target;
			return;
		case 10:
			MenuBatchEdit = (MenuItem)target;
			MenuBatchEdit.Click += xa959MLkMQ;
			return;
		case 11:
			MenuExport = (MenuItem)target;
			MenuExport.Click += oUI5VniFDS;
			return;
		case 12:
			MenuShare = (MenuItem)target;
			MenuShare.Click += shw5aAXu9o;
			return;
		case 13:
			MenuDelete = (MenuItem)target;
			MenuDelete.Click += sCT5qpRgvt;
			return;
		default:
			rNM5Gf9Npm = true;
			return;
		case 17:
			GroupTab = (System.Windows.Controls.TabControl)target;
			GroupTab.SelectionChanged += bQ450fpghl;
			num = 1;
			if (rI5gkEmGlTXJkXZwfj8 == null)
			{
				break;
			}
			goto IL_024b;
		case 18:
			{
				LblVersionTip = (TextBlock)target;
				num = 0;
				if (rI5gkEmGlTXJkXZwfj8 == null)
				{
					break;
				}
				goto IL_024b;
			}
			IL_024b:
			num = num2;
			break;
		}
		switch (num)
		{
		case 1:
			break;
		case 2:
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 14:
			((Button)target).Click += B8R5wOfHBh;
			break;
		case 15:
			((Button)target).Click += KpW5vNmG0r;
			break;
		case 16:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(kpR5Su4GFU);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	static TextCommandManagePage()
	{
		rBx5IqDFvX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool KxaihNm0HN2KIMnhspJ()
	{
		return rI5gkEmGlTXJkXZwfj8 == null;
	}

	internal static void NrAtilmrGCj1IaDdwGj()
	{
	}

	internal static void h858aUmNaYQiRxMZK4B()
	{
	}
}
