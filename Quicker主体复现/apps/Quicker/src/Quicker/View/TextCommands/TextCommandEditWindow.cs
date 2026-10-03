using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using IgQBbvXMVdsN7GVNUxX;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.View.TextCommands;

public class TextCommandEditWindow : Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec cg6SQX4shGA;

		public static Func<string, bool> EDMSQm3gDu7;

		public static Func<char, bool> SndSQK9CSFw;

		internal static _003C_003Ec dTA1roWIGtQk9uos5295;

		static _003C_003Ec()
		{
			cg6SQX4shGA = new _003C_003Ec();
		}

		internal bool caHSQbBfu3i(string x)
		{
			return !x.StartsWith("__");
		}

		internal bool fikSQ6BoqHl(char ch)
		{
			if (ch != ' ' && ch != '\n' && ch != '\t')
			{
				return false;
			}
			return true;
		}

		internal static bool eYI8UyWI0RdaeaI6bqft()
		{
			return dTA1roWIGtQk9uos5295 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public TextCommand lpeSQrKnkcq;

		internal static _003C_003Ec__DisplayClass11_0 JFKSmAWIKD4VCEdbO2vy;

		internal bool SbkSQxJ1Oj4(TextCommand x)
		{
			if (x.CmdText == lpeSQrKnkcq.CmdText && ProcessHelper.IsBindingSameProcess(x.BindingProcessName, lpeSQrKnkcq.BindingProcessName))
			{
				return x.TriggerKey == lpeSQrKnkcq.TriggerKey;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}

		internal static void hhbGPZWIdhqfLP3Uyx8F()
		{
		}

		internal static bool SYCaxYWIBVshisyHi8CD()
		{
			return JFKSmAWIKD4VCEdbO2vy == null;
		}

		internal static void RtHA0BWIOQGEfa0ghgIM()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSave_OnClick_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TextCommandEditWindow _003C_003E4__this;

		private TaskAwaiter<ApiResult<TextCommand>> _003C_003Eu__1;

		internal static object BiP51FWIJfgaEJVlSF3K;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextCommandEditWindow textCommandEditWindow = _003C_003E4__this;
			try
			{
        _003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default;
				if ((uint)num <= 1u)
				{
					goto IL_02bb;
				}
				_003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
				int num3 = default(int);
				while (true)
				{
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					int num2;
					if (textCommandEditWindow.q0mL2clpqQI())
					{
						if (textCommandEditWindow.ChkNoTrigger.IsChecked == true && textCommandEditWindow.ChkUseRegex.IsChecked == true)
						{
							AppHelper.ShowWarning("必须使用触发字符才能开启正则匹配。");
							break;
						}
						_003C_003Ec__DisplayClass11_.lpeSQrKnkcq = new TextCommand
						{
							CmdText = textCommandEditWindow.TxtCmdText.Text,
							IgnoreCase = (textCommandEditWindow.ChkIgnoreCase.IsChecked == true),
							UseRegex = (textCommandEditWindow.ChkUseRegex.IsChecked == true),
							BindingProcessName = textCommandEditWindow.TxtBindingProcessName.Text?.Trim(),
							Title = textCommandEditWindow.TxtTitle.Text,
							IsDisabled = (textCommandEditWindow.ChkIsEnabled.IsChecked == false),
							UseBackspaceWhenImeOpen = (textCommandEditWindow.ChkUseBackspaceWhenImeOpen.IsChecked == true),
							ExtractFirstMatchGroup = (textCommandEditWindow.ChkExtractFirstMatchGroup.IsChecked == true),
							Group = textCommandEditWindow.CbGroup.Text,
							TriggerKey = (int?)((textCommandEditWindow.ChkNoTrigger.IsChecked == true) ? ((ValueType)new int?(0)) : ((ValueType)(textCommandEditWindow.KeyEditor.Hotkey?.Key)))
						};
						(bool, string) tuple = textCommandEditWindow.QuickActionEditor.IsDataValid();
						if (!tuple.Item1)
						{
							AppHelper.ShowWarning(tuple.Item2);
							break;
						}
						textCommandEditWindow.QuickActionEditor.SaveData(_003C_003Ec__DisplayClass11_.lpeSQrKnkcq);
						if (textCommandEditWindow.TextCommand != null)
						{
							_003C_003Ec__DisplayClass11_.lpeSQrKnkcq.Id = textCommandEditWindow.TextCommand.Id;
						}
						TextCommand textCommand = textCommandEditWindow.e3lL2ZDC4Yg.neZtXfcGsie().FirstOrDefault(_003C_003Ec__DisplayClass11_.SbkSQxJ1Oj4);
						if (textCommand == null || !(textCommand.Id != _003C_003Ec__DisplayClass11_.lpeSQrKnkcq.Id))
						{
							goto IL_02bb;
						}
						AppHelper.ShowWarning("有重复的缩略词，请检查！");
						num2 = 0;
						if (BiP51FWIJfgaEJVlSF3K != null)
						{
							goto IL_0241;
						}
					}
					else
					{
						AppHelper.ShowWarning("缩写词不合法");
						textCommandEditWindow.TxtCmdText.Focus();
						num2 = 1;
						if (BiP51FWIJfgaEJVlSF3K != null)
						{
							goto IL_0241;
						}
					}
					goto IL_0242;
					IL_0241:
					num2 = num3;
					goto IL_0242;
					IL_0242:
					switch (num2)
					{
					case 2:
						continue;
					case 0:
						break;
					case 1:
						break;
					}
					break;
				}
				goto end_IL_000e;
				IL_02bb:
				try
				{
        ApiResult<TextCommand> apiResult = default;
					int num4;
					TaskAwaiter<ApiResult<TextCommand>> awaiter = default(TaskAwaiter<ApiResult<TextCommand>>);
					if (num != 0)
					{
						if (num != 1)
						{
							textCommandEditWindow.BtnSave.IsEnabled = false;
							num4 = 0;
							if (BiP51FWIJfgaEJVlSF3K == null)
							{
								goto IL_030c;
							}
							goto IL_0382;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0353;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResult<TextCommand>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_03a2;
					IL_0371:
					ApiResult<TextCommand> result;
					apiResult = result;
					num4 = 1;
					if (BiP51FWIJfgaEJVlSF3K == null)
					{
						goto IL_030c;
					}
					goto IL_0382;
					IL_0368:
					result = awaiter.GetResult();
					goto IL_0371;
					IL_03a2:
					result = awaiter.GetResult();
					goto IL_0371;
					IL_0353:
					_003C_003Eu__1 = default(TaskAwaiter<ApiResult<TextCommand>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0368;
					IL_0382:
					int num5 = default(int);
					num4 = num5;
					goto IL_030c;
					IL_030c:
					switch (num4)
					{
					case 2:
						goto IL_0353;
					case 1:
						goto IL_03f5;
					}
					if (!(_003C_003Ec__DisplayClass11_.lpeSQrKnkcq.Id == Guid.Empty))
					{
						awaiter = aFIptTXYsUoTUF4v33R.sHGtbpgWm2c(_003C_003Ec__DisplayClass11_.lpeSQrKnkcq).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0368;
					}
					awaiter = aFIptTXYsUoTUF4v33R.WWltbxr9jPf(_003C_003Ec__DisplayClass11_.lpeSQrKnkcq).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_03a2;
					IL_03f5:
					if (!apiResult.IsSuccess)
					{
						AppHelper.ShowWarning("保存失败！" + apiResult.Message);
					}
					else
					{
						textCommandEditWindow.TextCommand = apiResult.Data;
						textCommandEditWindow.ThNvuM5Q9GQ(true);
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存失败！" + ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						textCommandEditWindow.BtnSave.IsEnabled = true;
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

		internal static bool vKL7pvWIkQn0djdFlrGZ()
		{
			return BiP51FWIJfgaEJVlSF3K == null;
		}
	}

	private readonly DataService e3lL2ZDC4Yg;

	private readonly string p0fL29FPGdY;

	private SmartCollection<string> p61L2hbWn3A;

	[CompilerGenerated]
	private TextCommand zBgL2eXk8YW;

	[CompilerGenerated]
	private bool? NmoL2YlJonT;

	internal TextBox TxtCmdText;

	internal CheckBox ChkIsEnabled;

	internal CheckBox ChkIgnoreCase;

	internal CheckBox ChkUseRegex;

	internal CheckBox ChkExtractFirstMatchGroup;

	internal CheckBox ChkUseBackspaceWhenImeOpen;

	internal TextBox TxtTitle;

	internal ComboBox CbGroup;

	internal TextBox TxtBindingProcessName;

	internal HotkeyEditorControl KeyEditor;

	internal CheckBox ChkNoTrigger;

	internal QuickActionEditor QuickActionEditor;

	internal Button BtnSave;

	private bool fMPL2IcveJQ;

	internal static TextCommandEditWindow pftrGJFeIrYyICr0WfEE;

	public TextCommand TextCommand
	{
		[CompilerGenerated]
		get
		{
			return zBgL2eXk8YW;
		}
		[CompilerGenerated]
		set
		{
			zBgL2eXk8YW = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return NmoL2YlJonT;
		}
		[CompilerGenerated]
		set
		{
			NmoL2YlJonT = value;
		}
	}

	public TextCommandEditWindow(DataService dataService, string group, IList<string> groups)
	{
		e3lL2ZDC4Yg = dataService;
		p0fL29FPGdY = group;
		p61L2hbWn3A = new SmartCollection<string>(groups.Where(_003C_003Ec.EDMSQm3gDu7 ?? (_003C_003Ec.EDMSQm3gDu7 = _003C_003Ec.cg6SQX4shGA.caHSQbBfu3i)));
		InitializeComponent();
		base.Loaded += pGxL2RoPGfE;
		p61L2hbWn3A.Insert(0, "");
		CbGroup.ItemsSource = p61L2hbWn3A;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void pGxL2RoPGfE(object sender, RoutedEventArgs e)
	{
		ChkIsEnabled.IsChecked = true;
		if (TextCommand != null)
		{
			ChkIgnoreCase.IsChecked = TextCommand.IgnoreCase;
			TxtCmdText.Text = TextCommand.CmdText;
			TxtTitle.Text = TextCommand.Title;
			TxtBindingProcessName.Text = TextCommand.BindingProcessName;
			ChkIsEnabled.IsChecked = !TextCommand.IsDisabled;
			ChkUseRegex.IsChecked = TextCommand.UseRegex;
			if (pftrGJFeIrYyICr0WfEE != null)
			{
				switch (0)
				{
				}
			}
			ChkUseBackspaceWhenImeOpen.IsChecked = TextCommand.UseBackspaceWhenImeOpen;
			ChkExtractFirstMatchGroup.IsChecked = TextCommand.ExtractFirstMatchGroup;
			CbGroup.Text = TextCommand.Group;
			if (TextCommand.TriggerKey.HasValue)
			{
				KeyEditor.Hotkey = new Hotkey((VirtualKeyCode)TextCommand.TriggerKey.Value, ModifierKeys.None);
			}
			CheckBox chkNoTrigger = ChkNoTrigger;
			int? triggerKey = TextCommand.TriggerKey;
			chkNoTrigger.IsChecked = (triggerKey.GetValueOrDefault() == 0) & triggerKey.HasValue;
			QuickActionEditor.SetData(TextCommand);
		}
		else
		{
			CbGroup.Text = p0fL29FPGdY;
		}
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtBindingProcessName.Text))
		{
			TxtBindingProcessName.Text = e.ProcessName;
		}
		else
		{
			TxtBindingProcessName.Text = TxtBindingProcessName.Text.Trim() + ";" + e.ProcessName.ToLowerInvariant();
		}
	}

	[AsyncStateMachine(typeof(_003CBtnSave_OnClick_003Ed__11))]
	private void huAL2qZ3BGF(object sender, RoutedEventArgs e)
	{
		_003CBtnSave_OnClick_003Ed__11 stateMachine = default(_003CBtnSave_OnClick_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private bool q0mL2clpqQI()
	{
		if (string.IsNullOrEmpty(TxtCmdText.Text))
		{
			return false;
		}
		if (ChkUseRegex.IsChecked == true)
		{
			return true;
		}
		if (TxtCmdText.Text.Any(_003C_003Ec.SndSQK9CSFw ?? (_003C_003Ec.SndSQK9CSFw = _003C_003Ec.cg6SQX4shGA.fikSQ6BoqHl)))
		{
			return false;
		}
		return true;
	}

	private void Yl2L2VYHUPw(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!fMPL2IcveJQ)
		{
			fMPL2IcveJQ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/textcommands/textcommandeditwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			fMPL2IcveJQ = true;
			break;
		case 2:
			ChkIsEnabled = (CheckBox)target;
			break;
		case 3:
			ChkIgnoreCase = (CheckBox)target;
			break;
		case 4:
			ChkUseRegex = (CheckBox)target;
			break;
		case 5:
			ChkExtractFirstMatchGroup = (CheckBox)target;
			break;
		case 6:
			ChkUseBackspaceWhenImeOpen = (CheckBox)target;
			break;
		case 7:
			TxtTitle = (TextBox)target;
			break;
		case 8:
		{
			CbGroup = (ComboBox)target;
			int num = 0;
			if (!MsZLAuFe665NhdmWlWyT())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto case 1;
		}
		case 1:
			TxtCmdText = (TextBox)target;
			break;
		case 9:
			TxtBindingProcessName = (TextBox)target;
			break;
		case 10:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 11:
			ChkNoTrigger = (CheckBox)target;
			break;
		case 12:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 13:
			BtnSave = (Button)target;
			BtnSave.Click += huAL2qZ3BGF;
			break;
		case 14:
			((Button)target).Click += Yl2L2VYHUPw;
			break;
		}
	}

	static TextCommandEditWindow()
	{
	}

	internal static bool MsZLAuFe665NhdmWlWyT()
	{
		return pftrGJFeIrYyICr0WfEE == null;
	}

	internal static void QLtmOMFemeiAXhsCQBnY()
	{
	}
}
