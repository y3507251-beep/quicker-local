using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View;

public class ToolboxWindow2 : Window, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNextPage_OnClick_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Swbgi9W8MA5SbCVHDgPd;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(toolboxWindow.CurrPage + 1).ConfigureAwait(true).GetAwaiter();
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

		internal static bool Y5dVlpW8ULWsKCeSuVYe()
		{
			return Swbgi9W8MA5SbCVHDgPd == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnPrevPage_OnClick_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object mN7UW4W8ItabrEnuVkAb;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(toolboxWindow.CurrPage - 1).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!UJ2OMpW864UPJuOPdnSr())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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

		internal static bool UJ2OMpW864UPJuOPdnSr()
		{
			return mN7UW4W8ItabrEnuVkAb == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSearch_OnClick_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Gn5gTxW8SPenind3JxDT;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!eEC50CW8wcsg3abnsXFf())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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

		internal static bool eEC50CW8wcsg3abnsXFf()
		{
			return Gn5gTxW8SPenind3JxDT == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCbOrder_OnDropDownClosed_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object dsBv3OW8mkqsk6IA2xTW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
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
					if (yqtyrfW8s7fv6lo1Yjam())
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool yqtyrfW8s7fv6lo1Yjam()
		{
			return dsBv3OW8mkqsk6IA2xTW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCbTag_OnDropDownClosed_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object siaCc7W87WsLhkEEL6BA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
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

		internal static bool BOOB1JW84PKcVFUry4wS()
		{
			return siaCc7W87WsLhkEEL6BA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadDataAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		public int page;

		private ConfiguredTaskAwaitable<ApiResult<IList<SharedActionListDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Jr04R3W8HDWQMfUudFqg;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					toolboxWindow.CurrPage = page;
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<SharedActionListDto>>>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<SharedActionListDto>>>.ConfiguredTaskAwaiter);
						goto IL_0156;
					}
					goto IL_0188;
					IL_0188:
					string string_ = (toolboxWindow.TabExe.IsSelected ? toolboxWindow.ExeFile : ((!toolboxWindow.TabCommon.IsSelected) ? "" : "common"));
					awaiter = aFIptTXYsUoTUF4v33R.A9pt1fnPsSY(string_, toolboxWindow.TxtFilter.Text.Trim(), (toolboxWindow.CbTag.SelectedItem as SelectionItem)?.Value, (toolboxWindow.CbOrder.SelectedItem as SelectionItem)?.Value, toolboxWindow.PageSize, page).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0160;
					IL_0156:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0160;
					IL_0160:
					ApiResult<IList<SharedActionListDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						toolboxWindow.Items.Clear();
						int num2 = 0;
						int num4 = default(int);
						while (true)
						{
							if (num2 < toolboxWindow.PageSize)
							{
								int num3 = 1;
								if (Jr04R3W8HDWQMfUudFqg != null)
								{
									num3 = num4;
								}
								switch (num3)
								{
								case 1:
									break;
								case 2:
									goto end_IL_0149;
								default:
									goto IL_0188;
								}
								if (num2 < result.Data.Count)
								{
									toolboxWindow.Items.Add(result.Data[num2]);
									num2++;
									continue;
								}
							}
							toolboxWindow.BtnNextPage.IsEnabled = result.Data.Count > toolboxWindow.PageSize;
							toolboxWindow.BtnPrevPage.IsEnabled = toolboxWindow.CurrPage > 1;
							toolboxWindow.TxtPage.Text = toolboxWindow.CurrPage.ToString(CultureInfo.InvariantCulture);
							goto end_IL_0022;
							continue;
							end_IL_0149:
							break;
						}
						goto IL_0156;
					}
					AppHelper.ShowWarning("查询动作列表失败：" + result.Message);
					end_IL_0022:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("查询动作列表异常：" + ex.Message);
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

		static _003CLoadDataAsync_003Ed__23()
		{
		}

		internal static bool hJqi2TW8zdWNGDLvQQqp()
		{
			return Jr04R3W8HDWQMfUudFqg == null;
		}

		internal static void lnvMnBWRWC7puCFvkgy8()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelector_OnSelectionChanged_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object GlNb1jWRy82AQbED2QYG;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
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
				int num2 = 0;
				if (GlNb1jWRy82AQbED2QYG != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
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

		internal static bool lXRrK1WRpxW9sIKCCtC6()
		{
			return GlNb1jWRy82AQbED2QYG == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSwitchExeAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolboxWindow2 _003C_003E4__this;

		public string exeFile;

		public string iconStr;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Rgb6WiWR2cG3ENu05qKU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c0;
				}
				if (!string.Equals(toolboxWindow.ExeFile, exeFile, StringComparison.OrdinalIgnoreCase))
				{
					toolboxWindow.ExeFile = exeFile;
					toolboxWindow.UaZgFFK4CNY = iconStr;
					if (!toolboxWindow.aPXgFbVpJjh())
					{
						awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							if (Rgb6WiWR2cG3ENu05qKU != null)
							{
								switch (0)
								{
								}
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00c0;
					}
				}
				goto end_IL_000e;
				IL_00c0:
				awaiter.GetResult();
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

		internal static bool d1exJLWRAvch4CvIPdpE()
		{
			return Rgb6WiWR2cG3ENu05qKU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTxtFilter_OnKeyDown_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public ToolboxWindow2 _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object hDr22pWReAVvTl6siR7r;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ToolboxWindow2 toolboxWindow = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_007a;
				}
				if (e.Key == Key.Return)
				{
					awaiter = toolboxWindow.LoadDataAsync(1).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_007a;
				}
				goto end_IL_000e;
				IL_007a:
				awaiter.GetResult();
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

		internal static bool pUN2fPWRjpFI4qKf1Uby()
		{
			return hDr22pWReAVvTl6siR7r == null;
		}
	}

	[CompilerGenerated]
	private string jINgFdmcilJ;

	private readonly ObservableCollection<SharedActionListDto> Items = new ObservableCollection<SharedActionListDto>();

	private Point oYegFoHnSZp;

	private StackPanel i2ngFTU4AGE;

	[CompilerGenerated]
	private int UQwgFMTsbAY = 20;

	[CompilerGenerated]
	private int d0fgFAAwvP1 = 1;

	private IList<SelectionItem> RyvgFOc83t6;

	private string UaZgFFK4CNY;

	internal TabControl TabSelector;

	internal TabItem TabExe;

	internal IconControl IconExe;

	internal TextBlock LblExe;

	internal TabItem TabCommon;

	internal TabItem TabAll;

	internal TextBox TxtFilter;

	internal Button BtnSearch;

	internal ComboBox CbTag;

	internal ComboBox CbOrder;

	internal ListView LvActions;

	internal Button BtnPrevPage;

	internal Button BtnNextPage;

	internal TextBlock TxtPage;

	private bool iHFgFU8n3YX;

	private static ToolboxWindow2 IlLXwXFW4q0VHOTmqEWI;

	public string ExeFile
	{
		[CompilerGenerated]
		get
		{
			return jINgFdmcilJ;
		}
		[CompilerGenerated]
		set
		{
			jINgFdmcilJ = value;
		}
	}

	public int PageSize
	{
		[CompilerGenerated]
		get
		{
			return UQwgFMTsbAY;
		}
		[CompilerGenerated]
		set
		{
			UQwgFMTsbAY = value;
		}
	}

	public int CurrPage
	{
		[CompilerGenerated]
		get
		{
			return d0fgFAAwvP1;
		}
		[CompilerGenerated]
		set
		{
			d0fgFAAwvP1 = value;
		}
	}

	[SpecialName]
	private static IList<SelectionItem> fIJgF5Z0HHI()
	{
		return new List<SelectionItem>
		{
			new SelectionItem("", "-排序-"),
			new SelectionItem("useCount", "最多安装"),
			new SelectionItem("voteCount", "最多点赞"),
			new SelectionItem("createTime", "最新提交"),
			new SelectionItem("verifySuccessCount", "最多成功验证"),
			new SelectionItem("title", "标题文字")
		};
	}

	public ToolboxWindow2(string exe, string iconStr)
	{
		InitializeComponent();
		LvActions.ItemsSource = Items;
		ExeFile = exe;
		UaZgFFK4CNY = iconStr;
		base.Loaded += DojgF1sMFqn;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void DojgF1sMFqn(object sender, RoutedEventArgs e)
	{
		RyvgFOc83t6 = new List<SelectionItem>();
		RyvgFOc83t6.Add(new SelectionItem("", "-分类-"));
		foreach (string actionTag in AppState.ActionTags)
		{
			RyvgFOc83t6.Add(new SelectionItem(actionTag));
		}
		CbTag.ItemsSource = RyvgFOc83t6;
		CbOrder.ItemsSource = fIJgF5Z0HHI();
		CbTag.SelectedIndex = 0;
		if (IlLXwXFW4q0VHOTmqEWI != null)
		{
			switch (0)
			{
			}
		}
		CbOrder.SelectedIndex = 0;
		aPXgFbVpJjh();
	}

	private bool aPXgFbVpJjh()
	{
		int selectedIndex = TabSelector.SelectedIndex;
		if (!string.IsNullOrEmpty(ExeFile) && !ExeFile.Equals("common", StringComparison.OrdinalIgnoreCase))
		{
			LblExe.Text = ExeFile;
			TabExe.Visibility = Visibility.Visible;
			if (UaZgFFK4CNY.IsNullOrEmpty())
			{
				IconExe.Visibility = Visibility.Collapsed;
			}
			else
			{
				IconExe.Icon = UaZgFFK4CNY;
				IconExe.Visibility = Visibility.Visible;
			}
			if (!TabAll.IsSelected)
			{
				TabExe.IsSelected = true;
			}
		}
		else
		{
			TabExe.Visibility = Visibility.Collapsed;
			if (!TabAll.IsSelected)
			{
				TabCommon.IsSelected = true;
			}
		}
		return selectedIndex != TabSelector.SelectedIndex;
	}

	[AsyncStateMachine(typeof(_003CLoadDataAsync_003Ed__23))]
	public Task LoadDataAsync(int page)
	{
		_003CLoadDataAsync_003Ed__23 stateMachine = default(_003CLoadDataAsync_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.page = page;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CSwitchExeAsync_003Ed__24))]
	public Task SwitchExeAsync(string exeFile, string iconStr)
	{
		_003CSwitchExeAsync_003Ed__24 stateMachine = default(_003CSwitchExeAsync_003Ed__24);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.exeFile = exeFile;
		stateMachine.iconStr = iconStr;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void BHYgF6driA5(object sender, MouseButtonEventArgs e)
	{
		i2ngFTU4AGE = sender as StackPanel;
		oYegFoHnSZp = e.GetPosition(null);
	}

	private void cfrgFXUYdXs(object sender, MouseEventArgs e)
	{
		StackPanel stackPanel = sender as StackPanel;
		if (stackPanel != i2ngFTU4AGE)
		{
			return;
		}
		Point position = e.GetPosition(null);
		Vector vector = oYegFoHnSZp - position;
		if ((e.LeftButton != MouseButtonState.Pressed || !(Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance)) && !(Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance))
		{
			return;
		}
		SharedActionListDto data = stackPanel.Tag as SharedActionListDto;
		try
		{
			AppHelper.DoDragDropWrap(stackPanel, data, DragDropEffects.Copy);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("拖动异常：" + ex.Message);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnSearch_OnClick_003Ed__27))]
	private void DdMgFmJMlI0(object sender, RoutedEventArgs e)
	{
		_003CBtnSearch_OnClick_003Ed__27 stateMachine = default(_003CBtnSearch_OnClick_003Ed__27);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelector_OnSelectionChanged_003Ed__28))]
	private void JVHgFKkNYVR(object sender, SelectionChangedEventArgs e)
	{
		_003CSelector_OnSelectionChanged_003Ed__28 stateMachine = default(_003CSelector_OnSelectionChanged_003Ed__28);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CCbOrder_OnDropDownClosed_003Ed__29))]
	private void dAugFxaeIeZ(object sender, EventArgs e)
	{
		_003CCbOrder_OnDropDownClosed_003Ed__29 stateMachine = default(_003CCbOrder_OnDropDownClosed_003Ed__29);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CCbTag_OnDropDownClosed_003Ed__30))]
	private void E7dgFrkcSP5(object sender, EventArgs e)
	{
		_003CCbTag_OnDropDownClosed_003Ed__30 stateMachine = default(_003CCbTag_OnDropDownClosed_003Ed__30);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void zJHgFpC4umj(object sender, RoutedEventArgs e)
	{
		TxtFilter.SelectAll();
	}

	[AsyncStateMachine(typeof(_003CBtnPrevPage_OnClick_003Ed__32))]
	private void NBygFBN92JV(object sender, RoutedEventArgs e)
	{
		_003CBtnPrevPage_OnClick_003Ed__32 stateMachine = default(_003CBtnPrevPage_OnClick_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnNextPage_OnClick_003Ed__33))]
	private void MaTgFQGeyyK(object sender, RoutedEventArgs e)
	{
		_003CBtnNextPage_OnClick_003Ed__33 stateMachine = default(_003CBtnNextPage_OnClick_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void NdogFjX3glk(object sender, MouseButtonEventArgs e)
	{
		object selectedItem = LvActions.SelectedItem;
		if (selectedItem != null)
		{
			AppHelper.TryOpenUrlOrFile(AppHelper.CreateSharedActionLink((selectedItem as SharedActionListDto).Id.ToString()));
		}
	}

	[AsyncStateMachine(typeof(_003CTxtFilter_OnKeyDown_003Ed__35))]
	private void ugfgFnZEZqM(object sender, KeyEventArgs e)
	{
		_003CTxtFilter_OnKeyDown_003Ed__35 stateMachine = default(_003CTxtFilter_OnKeyDown_003Ed__35);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void GJAgF4LVqVW(object sender, RoutedEventArgs e)
	{
		AppSelectorWindow appSelectorWindow = new AppSelectorWindow(true);
		appSelectorWindow.Top = base.Top;
		appSelectorWindow.Height = base.Height;
		appSelectorWindow.Owner = this;
		appSelectorWindow.Show();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!iHFgFU8n3YX)
		{
			iHFgFU8n3YX = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/toolboxwindow2.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 1:
			TabSelector = (TabControl)target;
			TabSelector.SelectionChanged += JVHgFKkNYVR;
			break;
		case 2:
			TabExe = (TabItem)target;
			break;
		case 3:
			IconExe = (IconControl)target;
			break;
		case 4:
			LblExe = (TextBlock)target;
			break;
		case 5:
			TabCommon = (TabItem)target;
			break;
		case 6:
			TabAll = (TabItem)target;
			num = 0;
			if (UI136FFWhWARyRK8R5eY())
			{
				break;
			}
			goto IL_0129;
		case 7:
			TxtFilter = (TextBox)target;
			TxtFilter.GotFocus += zJHgFpC4umj;
			TxtFilter.KeyDown += ugfgFnZEZqM;
			break;
		case 8:
			BtnSearch = (Button)target;
			BtnSearch.Click += DdMgFmJMlI0;
			num = 0;
			if (UI136FFWhWARyRK8R5eY())
			{
				break;
			}
			goto IL_0129;
		case 9:
			CbTag = (ComboBox)target;
			CbTag.DropDownClosed += E7dgFrkcSP5;
			break;
		case 10:
			CbOrder = (ComboBox)target;
			CbOrder.DropDownClosed += dAugFxaeIeZ;
			break;
		case 11:
			LvActions = (ListView)target;
			LvActions.MouseDoubleClick += NdogFjX3glk;
			break;
		default:
			iHFgFU8n3YX = true;
			break;
		case 13:
			BtnPrevPage = (Button)target;
			BtnPrevPage.Click += NBygFBN92JV;
			break;
		case 14:
			BtnNextPage = (Button)target;
			BtnNextPage.Click += MaTgFQGeyyK;
			break;
		case 15:
			{
				TxtPage = (TextBlock)target;
				break;
			}
			IL_0129:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 12)
		{
			((StackPanel)target).PreviewMouseDown += BHYgF6driA5;
			((StackPanel)target).PreviewMouseMove += cfrgFXUYdXs;
		}
	}

	internal static bool UI136FFWhWARyRK8R5eY()
	{
		return IlLXwXFW4q0VHOTmqEWI == null;
	}
}
