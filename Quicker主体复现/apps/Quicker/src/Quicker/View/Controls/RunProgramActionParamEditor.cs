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
using System.Windows.Markup;
using log4net;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Entities;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class RunProgramActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public ProcessActionParams JhDS3GX4SFt;

		internal static _003C_003Ec__DisplayClass8_0 nHjddJyXi9XcRfoy5HS3;

		internal bool ofiS3kM2LXg(SelectionItem x)
		{
			return x.Value == JhDS3GX4SFt.WindowStyle;
		}

		internal static void ssgA1vyX5LI5OZOFBsNs()
		{
		}

		internal static bool fGHHM6yXlVSmOI5QJLyt()
		{
			return nHjddJyXi9XcRfoy5HS3 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSelectApp_OnClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object vspVyHyXYhEVd9WU0kd9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = runProgramActionParamEditor.tKNL4N6W2Vi().ConfigureAwait(true).GetAwaiter();
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
					if (HNFIFQyX8lb7sD07ShYc())
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult())
				{
					runProgramActionParamEditor.r8kL4RexQIP();
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

		internal static bool HNFIFQyX8lb7sD07ShYc()
		{
			return vspVyHyXYhEVd9WU0kd9 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuSelectFile_OnClick_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object EVIcaEyXgcbtroxYb19C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = runProgramActionParamEditor.oWqL4EsRMXk().ConfigureAwait(true).GetAwaiter();
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
						if (qtiVFuyXPpKCrjtof7sm())
						{
							switch (0)
							{
							}
						}
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					string message = "选择文件出错：" + ex.Message;
					bxOL49eUnfW.Warn(message, ex);
					AppHelper.ShowWarning(message);
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

		internal static bool qtiVFuyXPpKCrjtof7sm()
		{
			return EVIcaEyXgcbtroxYb19C == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuSelectFolder_OnClick_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object U11dXVyXUT3lHH5yb9vj;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					ConfiguredTaskAwaitable configuredTaskAwaitable = runProgramActionParamEditor.E7RL48pBHR2().ConfigureAwait(true);
					if (ErMfIoyXxxEPZ7oav0yJ())
					{
						switch (0)
						{
						}
					}
					awaiter = configuredTaskAwaitable.GetAwaiter();
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

		internal static bool ErMfIoyXxxEPZ7oav0yJ()
		{
			return U11dXVyXUT3lHH5yb9vj == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectAppAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private WinAppItem _003CSelectedFileItem_003E5__2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object lUs8KcyX6qENupkUm9lE;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			bool result;
			try
			{
        string text = default;
				if (num == 0)
				{
					goto IL_0086;
				}
				AppSelectorWindow appSelectorWindow = new AppSelectorWindow(true)
				{
					Owner = Window.GetWindow(runProgramActionParamEditor)
				};
				text = default(string);
				if (appSelectorWindow.ShowDialog() == true)
				{
					int num2 = 0;
					if (!bnol8ByXtgyENc39myqO())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003CSelectedFileItem_003E5__2 = appSelectorWindow.SelectedFile;
					runProgramActionParamEditor.TxtFilePath.Text = _003CSelectedFileItem_003E5__2.FullPath;
					text = runProgramActionParamEditor.TxtFilePath.Text;
					goto IL_0086;
				}
				result = false;
				goto end_IL_000e;
				IL_0086:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						if (lUs8KcyX6qENupkUm9lE != null)
						{
							switch (0)
							{
							}
						}
						awaiter = runProgramActionParamEditor.IconManager.GetFileOrFolderIconAsync(text).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result2 = awaiter.GetResult();
					if (result2 != null)
					{
						runProgramActionParamEditor.Y18L4VgR0u8.Icon = result2;
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存图标失败！" + ex.Message);
				}
				runProgramActionParamEditor.Y18L4VgR0u8.Title = _003CSelectedFileItem_003E5__2.DisplayName;
				runProgramActionParamEditor.r8kL4RexQIP();
				result = true;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
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

		internal static bool bnol8ByXtgyENc39myqO()
		{
			return lUs8KcyX6qENupkUm9lE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFile_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private ActionItem _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object hSeaZnyXwnEI6oy4Dxue;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			try
			{
        string text = default;
				if (num == 0)
				{
					goto IL_00d1;
				}
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					DereferenceLinks = false,
					Filter = "可执行程序|*.exe|任意文件|*.*",
					FilterIndex = 2
				};
				if (!string.IsNullOrEmpty(runProgramActionParamEditor.TxtFilePath.Text))
				{
					try
					{
						if (Directory.Exists(Path.GetDirectoryName(runProgramActionParamEditor.TxtFilePath.Text)))
						{
							openFileDialog.InitialDirectory = Path.GetDirectoryName(runProgramActionParamEditor.TxtFilePath.Text);
						}
					}
					catch
					{
					}
				}
				text = default(string);
				if (openFileDialog.ShowDialog() == true)
				{
					text = openFileDialog.FileName;
					if (!File.Exists(text))
					{
						text = Path.GetDirectoryName(text);
					}
					runProgramActionParamEditor.TxtFilePath.Text = text;
					if (File.Exists(text))
					{
						runProgramActionParamEditor.Y18L4VgR0u8.Title = Path.GetFileNameWithoutExtension(text);
						goto IL_00d1;
					}
				}
				goto end_IL_000e;
				IL_00d1:
				int num2 = 0;
				if (!Nvd4bHyXTysvt2ulLFNs())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				default:
					try
					{
						ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							_003C_003E7__wrap1 = runProgramActionParamEditor.Y18L4VgR0u8;
							awaiter = runProgramActionParamEditor.IconManager.GetFileOrFolderIconAsync(text).ConfigureAwait(true).GetAwaiter();
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
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						string result = awaiter.GetResult();
						_003C_003E7__wrap1.Icon = result;
						_003C_003E7__wrap1 = null;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("保存图标失败！" + ex.Message);
					}
					break;
				case 1:
					break;
				}
				runProgramActionParamEditor.r8kL4RexQIP();
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

		internal static bool Nvd4bHyXTysvt2ulLFNs()
		{
			return hSeaZnyXwnEI6oy4Dxue == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFolder_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RunProgramActionParamEditor _003C_003E4__this;

		private ActionItem _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object MLT5JQyXCGdsn5dcNPq8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			RunProgramActionParamEditor runProgramActionParamEditor = _003C_003E4__this;
			try
			{
        string text = default;
				if (num == 0)
				{
					goto IL_00c5;
				}
				CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
				{
					IsFolderPicker = true
				};
				if (!string.IsNullOrEmpty(runProgramActionParamEditor.TxtFilePath.Text))
				{
					try
					{
						if (Directory.Exists(Path.GetDirectoryName(runProgramActionParamEditor.TxtFilePath.Text)))
						{
							commonOpenFileDialog.InitialDirectory = Path.GetDirectoryName(runProgramActionParamEditor.TxtFilePath.Text);
						}
					}
					catch
					{
					}
				}
				text = default(string);
				if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
				{
					text = commonOpenFileDialog.FileName + "\\";
					runProgramActionParamEditor.TxtFilePath.Text = text;
					if (Directory.Exists(text))
					{
						runProgramActionParamEditor.Y18L4VgR0u8.Title = Path.GetFileName(text.TrimEnd('\\', '/'));
						goto IL_00c5;
					}
					goto IL_018d;
				}
				goto end_IL_000e;
				IL_00c5:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E7__wrap1 = runProgramActionParamEditor.Y18L4VgR0u8;
						awaiter = runProgramActionParamEditor.IconManager.GetFileOrFolderIconAsync(text).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					string result = awaiter.GetResult();
					_003C_003E7__wrap1.Icon = result;
					_003C_003E7__wrap1 = null;
					int num2 = 0;
					if (!GJ2QFeyX7xdlbGmjTuyY())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存图标失败！" + ex.Message);
				}
				goto IL_018d;
				IL_018d:
				runProgramActionParamEditor.r8kL4RexQIP();
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

		internal static bool GJ2QFeyX7xdlbGmjTuyY()
		{
			return MLT5JQyXCGdsn5dcNPq8 == null;
		}
	}

	[CompilerGenerated]
	private IconManager Vj2L4cBqHEF;

	private ActionItem Y18L4VgR0u8;

	private readonly IList<SelectionItem> Er2L4ZTSD0X = new List<SelectionItem>
	{
		new SelectionItem("0", "普通(Normal)"),
		new SelectionItem("2", "最小化(Minimized)"),
		new SelectionItem("3", "最大化(Maximized)")
	};

	private static readonly ILog bxOL49eUnfW;

	internal TextBox TxtFilePath;

	internal DropDownButton BtnMenuForFileName;

	internal ContextMenu MainContextMenu0;

	internal MenuItem MenuSelectStartMenuApps;

	internal MenuItem MenuSelectFile;

	internal MenuItem MenuSelectFolder;

	internal MenuItem MenuAddClipboardTextForFilePath;

	internal MenuItem MenuAddSubprogramOutputForFilePath;

	internal Button BtnConvertToOpenTarget;

	internal TextBox TxtExtraParam;

	internal DropDownButton BtnMenu;

	internal ContextMenu MainContextMenu1;

	internal MenuItem MenuAddClipboardText;

	internal MenuItem MenuAddSubprogramOutput;

	internal TextBox TxtWorkingDir;

	internal ComboBox CbWindowStyle;

	internal CheckBox ChkRunAsAdmin;

	internal CheckBox ChkWaitForExit;

	internal CheckBox ChkActivateWindowIfRunning;

	internal TextBoxWithToolsControl TxtHotkey;

	internal TextBoxWithToolsControl TxtAlternativePaths;

	private bool IaqL4hpwrqy;

	private static RunProgramActionParamEditor BcsEqpFiiLbMaeHC7jmv;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return Vj2L4cBqHEF;
		}
		[CompilerGenerated]
		private set
		{
			Vj2L4cBqHEF = value;
		}
	}

	public RunProgramActionParamEditor()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
		base.Loaded += uJfL42BBfKW;
		CbWindowStyle.ItemsSource = Er2L4ZTSD0X;
	}

	private void uJfL42BBfKW(object sender, RoutedEventArgs e)
	{
		if (!(Window.GetWindow(this) is ActionEditorWindow actionEditorWindow))
		{
			AppHelper.ShowWarning("内部错误 b80b2f30-a594-4f66-8677-cbc634512442, 请反馈。");
			return;
		}
		if (!actionEditorWindow.IsEditingSubAction)
		{
			MenuAddSubprogramOutputForFilePath.Visibility = Visibility.Collapsed;
			MenuAddSubprogramOutput.Visibility = Visibility.Collapsed;
			ChkWaitForExit.Visibility = Visibility.Collapsed;
		}
		TxtHotkey.SetupTools(new List<TextToolType> { TextToolType.SelectSendKeysData });
	}

	public override void SetData(ActionItem actionItem)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		Y18L4VgR0u8 = actionItem;
		_003C_003Ec__DisplayClass8_.JhDS3GX4SFt = ProcessActionParams.FromActionItem(Y18L4VgR0u8);
		TxtFilePath.Text = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.FileName;
		TxtExtraParam.Text = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.Arguments;
		ChkRunAsAdmin.IsChecked = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.RunAsAdmin;
		ChkWaitForExit.IsChecked = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.WaitForExit;
		if (_003C_003Ec__DisplayClass8_.JhDS3GX4SFt.WorkingDir == null)
		{
			_003C_003Ec__DisplayClass8_.JhDS3GX4SFt.WorkingDir = (_003C_003Ec__DisplayClass8_.JhDS3GX4SFt.SetWorkingDir ? "1" : "");
		}
		TxtWorkingDir.Text = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.WorkingDir;
		TxtAlternativePaths.Text = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.AlternativePaths;
		if (BcsEqpFiiLbMaeHC7jmv == null)
		{
			switch (0)
			{
			}
		}
		ChkActivateWindowIfRunning.IsChecked = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.ActivateWindowIfRunning;
		TxtHotkey.Text = _003C_003Ec__DisplayClass8_.JhDS3GX4SFt.ActivateWindowHotkey;
		CbWindowStyle.SelectedItem = ((!string.IsNullOrEmpty(_003C_003Ec__DisplayClass8_.JhDS3GX4SFt.WindowStyle)) ? Er2L4ZTSD0X.FirstOrDefault(_003C_003Ec__DisplayClass8_.ofiS3kM2LXg) : null);
	}

	public override (bool isSuccess, string message) Validate()
	{
		bool valueOrDefault = ChkActivateWindowIfRunning.IsChecked == true;
		return (isSuccess: true, message: "");
	}

	public override void SaveData(ActionItem actionItem)
	{
		ProcessActionParams processActionParams = new ProcessActionParams
		{
			FileName = TxtFilePath.Text,
			Arguments = TxtExtraParam.Text,
			RunAsAdmin = (ChkRunAsAdmin.IsChecked == true),
			WaitForExit = (ChkWaitForExit.IsChecked == true),
			WorkingDir = TxtWorkingDir.Text,
			WindowStyle = (CbWindowStyle.SelectedItem as SelectionItem)?.Value,
			AlternativePaths = TxtAlternativePaths.Text,
			ActivateWindowIfRunning = (ChkActivateWindowIfRunning.IsChecked == true),
			ActivateWindowHotkey = TxtHotkey.Text
		};
		actionItem.Data = processActionParams.ToDataString();
		actionItem.Data2 = "";
		actionItem.Data3 = "";
	}

	[AsyncStateMachine(typeof(_003CBtnSelectApp_OnClick_003Ed__11))]
	private void s44L4u9Mas1(object sender, RoutedEventArgs e)
	{
		_003CBtnSelectApp_OnClick_003Ed__11 stateMachine = default(_003CBtnSelectApp_OnClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelectAppAsync_003Ed__12))]
	private Task<bool> tKNL4N6W2Vi()
	{
		_003CSelectAppAsync_003Ed__12 stateMachine = default(_003CSelectAppAsync_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public override Task StartInputAsync(ActionType? newActionType)
	{
		if (newActionType == ActionType.TempRunSoftware)
		{
			return tKNL4N6W2Vi();
		}
		if (newActionType == ActionType.OpenFile)
		{
			return oWqL4EsRMXk();
		}
		if (newActionType == ActionType.OpenFolder)
		{
			return E7RL48pBHR2();
		}
		return base.StartInputAsync(newActionType);
	}

	private void VqJL4J39uKK(object sender, RoutedEventArgs e)
	{
		TextBox textBox_ = (((sender as MenuItem).Tag as string == "TxtFilePath") ? TxtFilePath : TxtExtraParam);
		x2mL40T0L53("{cliptext}", textBox_);
	}

	private void x2mL40T0L53(string string_0, TextBox textBox_0)
	{
		if (textBox_0.SelectedText.Length > 0)
		{
			textBox_0.Text = textBox_0.Text.Replace(textBox_0.Text.Substring(textBox_0.SelectionStart, textBox_0.SelectionLength), string_0);
		}
		else
		{
			textBox_0.Text = textBox_0.Text.Insert(textBox_0.CaretIndex, string_0);
		}
	}

	private void oWYL4CGHQfn(object sender, RoutedEventArgs e)
	{
		TextBox textBox_ = (((sender as MenuItem).Tag as string == "TxtFilePath") ? TxtFilePath : TxtExtraParam);
		x2mL40T0L53("{context}", textBox_);
	}

	[AsyncStateMachine(typeof(_003CMenuSelectFile_OnClick_003Ed__18))]
	private void N58L4PVh7WI(object sender, RoutedEventArgs e)
	{
		_003CMenuSelectFile_OnClick_003Ed__18 stateMachine = default(_003CMenuSelectFile_OnClick_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelectFile_003Ed__19))]
	private Task oWqL4EsRMXk()
	{
		_003CSelectFile_003Ed__19 stateMachine = default(_003CSelectFile_003Ed__19);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CMenuSelectFolder_OnClick_003Ed__20))]
	private void AJaL4yTT5BS(object sender, RoutedEventArgs e)
	{
		_003CMenuSelectFolder_OnClick_003Ed__20 stateMachine = default(_003CMenuSelectFolder_OnClick_003Ed__20);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelectFolder_003Ed__21))]
	private Task E7RL48pBHR2()
	{
		_003CSelectFolder_003Ed__21 stateMachine = default(_003CSelectFolder_003Ed__21);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void HA8L4aEuUMx(object sender, TextChangedEventArgs e)
	{
		BtnConvertToOpenTarget.Visibility = Visibility.Collapsed;
		try
		{
			string text = TxtFilePath.Text.Trim();
			if (text.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase) && File.Exists(text))
			{
				BtnConvertToOpenTarget.Visibility = Visibility.Visible;
			}
		}
		catch
		{
		}
	}

	private void er2L47WcHA9(object sender, RoutedEventArgs e)
	{
		try
		{
			string text = TxtFilePath.Text.Trim();
			if (!File.Exists(text) || !text.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			using ShellObject shellObject = ShellObject.FromParsingName(text);
			ShellProperty<string> targetParsingPath = shellObject.Properties.System.Link.TargetParsingPath;
			object obj;
			if (targetParsingPath == null)
			{
				obj = null;
			}
			else
			{
				obj = targetParsingPath.Value;
				if (obj != null)
				{
					goto IL_005f;
				}
			}
			obj = "";
			goto IL_005f;
			IL_008a:
			object obj2;
			string text2 = (string)obj2;
			string text3;
			TxtFilePath.Text = text3;
			if (IjCKhuFilcRIEMjYNqXl())
			{
				switch (0)
				{
				}
			}
			TxtExtraParam.Text = text2;
			TxtWorkingDir.Text = Path.GetDirectoryName(text3);
			return;
			IL_005f:
			text3 = (string)obj;
			ShellProperty<string> arguments = shellObject.Properties.System.Link.Arguments;
			if (arguments == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = arguments.Value;
				if (obj2 != null)
				{
					goto IL_008a;
				}
			}
			obj2 = "";
			goto IL_008a;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("解析快捷方式失败！" + ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!IaqL4hpwrqy)
		{
			IaqL4hpwrqy = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/runprogramactionparameditor.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			IaqL4hpwrqy = true;
			break;
		case 1:
			TxtFilePath = (TextBox)target;
			TxtFilePath.TextChanged += HA8L4aEuUMx;
			break;
		case 2:
			BtnMenuForFileName = (DropDownButton)target;
			break;
		case 3:
			MainContextMenu0 = (ContextMenu)target;
			break;
		case 4:
			MenuSelectStartMenuApps = (MenuItem)target;
			MenuSelectStartMenuApps.Click += s44L4u9Mas1;
			break;
		case 5:
			MenuSelectFile = (MenuItem)target;
			num = 0;
			if (BcsEqpFiiLbMaeHC7jmv != null)
			{
				goto IL_0159;
			}
			goto IL_016b;
		case 6:
			MenuSelectFolder = (MenuItem)target;
			num = 2;
			if (BcsEqpFiiLbMaeHC7jmv != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0159;
		case 7:
			MenuAddClipboardTextForFilePath = (MenuItem)target;
			MenuAddClipboardTextForFilePath.Click += VqJL4J39uKK;
			break;
		case 8:
			MenuAddSubprogramOutputForFilePath = (MenuItem)target;
			MenuAddSubprogramOutputForFilePath.Click += oWYL4CGHQfn;
			num = 0;
			if (!IjCKhuFilcRIEMjYNqXl())
			{
				break;
			}
			goto IL_0159;
		case 9:
			BtnConvertToOpenTarget = (Button)target;
			BtnConvertToOpenTarget.Click += er2L47WcHA9;
			break;
		case 10:
			TxtExtraParam = (TextBox)target;
			break;
		case 11:
			BtnMenu = (DropDownButton)target;
			break;
		case 12:
			MainContextMenu1 = (ContextMenu)target;
			break;
		case 13:
			MenuAddClipboardText = (MenuItem)target;
			MenuAddClipboardText.Click += VqJL4J39uKK;
			break;
		case 14:
			MenuAddSubprogramOutput = (MenuItem)target;
			MenuAddSubprogramOutput.Click += oWYL4CGHQfn;
			break;
		case 15:
			TxtWorkingDir = (TextBox)target;
			break;
		case 16:
			CbWindowStyle = (ComboBox)target;
			break;
		case 17:
			ChkRunAsAdmin = (CheckBox)target;
			break;
		case 18:
			ChkWaitForExit = (CheckBox)target;
			break;
		case 19:
			ChkActivateWindowIfRunning = (CheckBox)target;
			break;
		case 20:
			TxtHotkey = (TextBoxWithToolsControl)target;
			break;
		case 21:
			{
				TxtAlternativePaths = (TextBoxWithToolsControl)target;
				break;
			}
			IL_0159:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 2:
				MenuSelectFolder.Click += AJaL4yTT5BS;
				return;
			}
			goto IL_016b;
			IL_016b:
			MenuSelectFile.Click += N58L4PVh7WI;
			break;
		}
	}

	static RunProgramActionParamEditor()
	{
		bxOL49eUnfW = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void r8kL4RexQIP()
	{
		base.OnDataChanged();
	}

	internal static bool IjCKhuFilcRIEMjYNqXl()
	{
		return BcsEqpFiiLbMaeHC7jmv == null;
	}
}
