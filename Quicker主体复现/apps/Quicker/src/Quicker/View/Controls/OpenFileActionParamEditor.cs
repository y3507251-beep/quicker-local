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
using Microsoft.Win32;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class OpenFileActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnChoose_OnClick_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OpenFileActionParamEditor _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object f3HgBayXeWpFjnqxGDGr;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OpenFileActionParamEditor openFileActionParamEditor = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = openFileActionParamEditor.flLLnBE2M3B().ConfigureAwait(true).GetAwaiter();
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

		internal static bool LN0gfryXjaAbk86EKYPI()
		{
			return f3HgBayXeWpFjnqxGDGr == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectFileAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public OpenFileActionParamEditor _003C_003E4__this;

		private ActionItem _003C_003E7__wrap1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object Uu57n3yX3U9sIOkltehJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OpenFileActionParamEditor openFileActionParamEditor = _003C_003E4__this;
			bool result;
			try
			{
        string text = default;
				if (num == 0)
				{
					goto IL_011c;
				}
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					DereferenceLinks = false,
					ValidateNames = false,
					CheckFileExists = false,
					CheckPathExists = true,
					FileName = "",
					Filter = "任意文件 (*.*)|*.*"
				};
				if (!string.IsNullOrEmpty(openFileActionParamEditor.TxtFilePath.Text) && Directory.Exists(Path.GetDirectoryName(openFileActionParamEditor.TxtFilePath.Text)))
				{
					try
					{
						openFileDialog.InitialDirectory = Path.GetDirectoryName(openFileActionParamEditor.TxtFilePath.Text);
					}
					catch
					{
					}
				}
				text = default(string);
				int num2;
				if (openFileDialog.ShowDialog() == true)
				{
					text = openFileDialog.FileName;
					num2 = 0;
					if (Uu57n3yX3U9sIOkltehJ == null)
					{
						goto IL_00b7;
					}
					goto IL_00d7;
				}
				result = false;
				goto end_IL_000e;
				IL_00d7:
				switch (num2)
				{
				case 1:
					goto IL_00e6;
				}
				goto IL_00b7;
				IL_01e5:
				result = true;
				goto end_IL_000e;
				IL_011c:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003E7__wrap1 = openFileActionParamEditor.fjDLnjPVGUo;
						awaiter = openFileActionParamEditor.IconManager.GetFileOrFolderIconAsync(text).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							if (!pBdjsZyXEa9grOHvgg2j())
							{
								switch (0)
								{
								}
							}
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
					_003C_003E7__wrap1.Icon = result2;
					_003C_003E7__wrap1 = null;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存图标失败！" + ex.Message);
				}
				goto IL_01e5;
				IL_00b7:
				if (!File.Exists(text))
				{
					text = Path.GetDirectoryName(text);
					num2 = 1;
					if (!pBdjsZyXEa9grOHvgg2j())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_00d7;
				}
				goto IL_00e6;
				IL_00e6:
				openFileActionParamEditor.TxtFilePath.Text = text;
				if (File.Exists(text))
				{
					openFileActionParamEditor.fjDLnjPVGUo.Title = Path.GetFileNameWithoutExtension(text);
					goto IL_011c;
				}
				goto IL_01e5;
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

		internal static bool pBdjsZyXEa9grOHvgg2j()
		{
			return Uu57n3yX3U9sIOkltehJ == null;
		}
	}

	private ActionItem fjDLnjPVGUo;

	[CompilerGenerated]
	private IconManager athLnnfHLKC;

	internal TextBox TxtFilePath;

	internal Button BtnChoose;

	private bool jVRLn4cno5h;

	private static OpenFileActionParamEditor l9txJOFi3lHd18JnNbGs;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return athLnnfHLKC;
		}
		[CompilerGenerated]
		private set
		{
			athLnnfHLKC = value;
		}
	}

	public OpenFileActionParamEditor()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
	}

	[AsyncStateMachine(typeof(_003CBtnChoose_OnClick_003Ed__6))]
	private void RH9LnpRMSXM(object sender, RoutedEventArgs e)
	{
		_003CBtnChoose_OnClick_003Ed__6 stateMachine = default(_003CBtnChoose_OnClick_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CSelectFileAsync_003Ed__7))]
	private Task<bool> flLLnBE2M3B()
	{
		_003CSelectFileAsync_003Ed__7 stateMachine = default(_003CSelectFileAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public override void SetData(ActionItem actionItem)
	{
		fjDLnjPVGUo = actionItem;
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
		return flLLnBE2M3B();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!jVRLn4cno5h)
		{
			jVRLn4cno5h = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/openfileactionparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			jVRLn4cno5h = true;
			break;
		case 2:
			BtnChoose = (Button)target;
			BtnChoose.Click += RH9LnpRMSXM;
			break;
		case 1:
			TxtFilePath = (TextBox)target;
			break;
		}
	}

	internal static bool rly5bKFiEn4347gfdewN()
	{
		return l9txJOFi3lHd18JnNbGs == null;
	}
}
