using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.WindowsAPICodePack.Dialogs;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class OpenFolderActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnChoose_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OpenFolderActionParamEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object efqZ3myXKqjgYb31s1bh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OpenFolderActionParamEditor openFolderActionParamEditor = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (efqZ3myXKqjgYb31s1bh != null)
					{
						switch (0)
						{
						}
					}
					awaiter = openFolderActionParamEditor.A7CLnDBsb8e().ConfigureAwait(true).GetAwaiter();
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
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

		internal static bool tXfuepyXB9gCdPBsMP7y()
		{
			return efqZ3myXKqjgYb31s1bh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFolderAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public OpenFolderActionParamEditor _003C_003E4__this;

		private ActionItem _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object g96FpCyXdytTAtEYV4bu;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OpenFolderActionParamEditor openFolderActionParamEditor = _003C_003E4__this;
			bool result;
			try
			{
        string fileName = default;
				if (num == 0)
				{
					goto IL_0091;
				}
				CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
				if (g96FpCyXdytTAtEYV4bu != null)
				{
					switch (0)
					{
					}
				}
				commonOpenFileDialog.IsFolderPicker = true;
				fileName = default(string);
				if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
				{
					fileName = commonOpenFileDialog.FileName;
					openFolderActionParamEditor.TxtFilePath.Text = fileName;
					if (Directory.Exists(fileName))
					{
						openFolderActionParamEditor.BufLno9tHDa.Title = Path.GetFileName(fileName.TrimEnd('\\', '/'));
						goto IL_0091;
					}
					goto IL_015a;
				}
				result = false;
				goto end_IL_000e;
				IL_0091:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003E7__wrap1 = openFolderActionParamEditor.BufLno9tHDa;
						awaiter = openFolderActionParamEditor.IconManager.GetFileOrFolderIconAsync(fileName).ConfigureAwait(true).GetAwaiter();
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
						if (!pCLRTlyXOZUxuHrTwLXE())
						{
							switch (0)
							{
							}
						}
					}
					string result2 = awaiter.GetResult();
					_003C_003E7__wrap1.Icon = result2;
					_003C_003E7__wrap1 = null;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存图标失败！" + ex.Message);
				}
				goto IL_015a;
				IL_015a:
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

		static _003CSelectFolderAsync_003Ed__7()
		{
		}

		internal static bool pCLRTlyXOZUxuHrTwLXE()
		{
			return g96FpCyXdytTAtEYV4bu == null;
		}

		internal static void EHFiY2yXNQor562JKKOq()
		{
		}
	}

	private ActionItem BufLno9tHDa;

	[CompilerGenerated]
	private IconManager oQvLnTyO6E2;

	internal TextBox TxtFilePath;

	internal Button BtnChoose;

	private bool NgCLnMiiMsU;

	internal static OpenFolderActionParamEditor WiXSkmFi0EgeZ6k2CHGk;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return oQvLnTyO6E2;
		}
		[CompilerGenerated]
		private set
		{
			oQvLnTyO6E2 = value;
		}
	}

	public OpenFolderActionParamEditor()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
	}

	[AsyncStateMachine(typeof(_003CBtnChoose_OnClick_003Ed__6))]
	private void SJ5Ln5MiWvj(object sender, RoutedEventArgs e)
	{
		_003CBtnChoose_OnClick_003Ed__6 stateMachine = default(_003CBtnChoose_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelectFolderAsync_003Ed__7))]
	private Task<bool> A7CLnDBsb8e()
	{
		_003CSelectFolderAsync_003Ed__7 stateMachine = default(_003CSelectFolderAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public override void SetData(ActionItem actionItem)
	{
		BufLno9tHDa = actionItem;
		if (actionItem != null)
		{
			TxtFilePath.Text = actionItem.Data;
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = TxtFilePath.Text;
	}

	public override Task StartInputAsync(ActionType? newActionType)
	{
		return A7CLnDBsb8e();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!NgCLnMiiMsU)
		{
			NgCLnMiiMsU = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/openfolderactionparameditor.xaml", UriKind.Relative);
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
			NgCLnMiiMsU = true;
			break;
		case 2:
			BtnChoose = (Button)target;
			BtnChoose.Click += SJ5Ln5MiWvj;
			break;
		case 1:
			TxtFilePath = (TextBox)target;
			break;
		}
	}

	internal static bool uwsdYQFi170KRFN34m4G()
	{
		return WiXSkmFi0EgeZ6k2CHGk == null;
	}
}
