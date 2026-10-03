using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using Quicker.Common;
using Quicker.Domain.Actions.X;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.View.UI;

namespace Quicker.View.X.Controls;

public class ActionOptionsControl : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuEditInDesigner_OnClick_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionOptionsControl _003C_003E4__this;

		private OperationEditorWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object eVLobnyFlJ3ge83CABfh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionOptionsControl actionOptionsControl = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					IList<CommonOperationItem> items = new List<CommonOperationItem>();
					if (!actionOptionsControl.TxtContextMenuData.Text.IsNullOrEmpty())
					{
						try
						{
							items = CommonOperationItem.ParseLinesWithSubItems(actionOptionsControl.TxtContextMenuData.Text, true);
						}
						catch (Exception ex)
						{
							AppHelper.ShowError("无法解析右键菜单数据。" + ex.Message);
							goto end_IL_0010;
						}
					}
					_003Cdlg_003E5__2 = new OperationEditorWindow(true, items);
					_003Cdlg_003E5__2.Owner = Window.GetWindow(actionOptionsControl);
					num2 = 1;
					if (eVLobnyFlJ3ge83CABfh == null)
					{
						goto IL_00c3;
					}
					goto IL_0102;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00ee;
				IL_00c3:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0102;
				}
				awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00ee;
				IL_00ee:
				if (awaiter.GetResult() == true)
				{
					num2 = 0;
					if (!EKqtSqyFZYungy1Klhfw())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_00c3;
				}
				goto end_IL_0010;
				IL_0102:
				actionOptionsControl.TxtContextMenuData.Text = _003Cdlg_003E5__2.GetIndentTextData();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool EKqtSqyFZYungy1Klhfw()
		{
			return eVLobnyFlJ3ge83CABfh == null;
		}
	}

	internal CheckBox ChkSkipWhenStopRunningActions;

	internal CheckBox ChkKeepInfoWhenUpdate;

	internal CheckBox ChkSkipCheckUpdate;

	internal CheckBox ChkAutoUpdate;

	internal CheckBox ChkAllowMultipleInstance;

	internal CheckBox ChkEnableEvaluateVariable;

	internal CheckBox ChkAllowScrollTrigger;

	internal CheckBox ChkDoNotClosePanel;

	internal TextBox TxtContextMenuData;

	internal MenuItem MenuEditInDesigner;

	internal MenuItem MenuHelp;

	internal TextBox TxtMinVersion;

	internal MenuItem MenuSetCurrentVersion;

	private bool fryL6pTygFp;

	internal static ActionOptionsControl BataFfF92seR2EIm5x2I;

	public bool CurrentOptionEnableEvaluateVariable => ChkEnableEvaluateVariable.IsChecked == true;

	public ActionOptionsControl()
	{
		InitializeComponent();
	}

	public void LoadActionOptions(XAction xAction, ActionItem action)
	{
		ChkAllowMultipleInstance.IsChecked = !xAction.LimitSingleInstance;
		TxtMinVersion.Text = action.MinQuickerVersion;
		TxtContextMenuData.Text = action.ContextMenuData;
		int num = 0;
		if (!jv0ovEF9AKsttdYA3C6o())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ChkSkipWhenStopRunningActions.IsChecked = action.SkipWhenStopRunningActions;
		ChkSkipCheckUpdate.IsChecked = action.SkipCheckUpdate;
		ChkAutoUpdate.IsChecked = action.AutoUpdate;
		ChkKeepInfoWhenUpdate.IsChecked = action.KeepInfoWhenUpdate;
		ChkAllowScrollTrigger.IsChecked = action.AllowScrollTrigger;
		ChkEnableEvaluateVariable.IsChecked = action.EnableEvaluateVariable;
		ChkDoNotClosePanel.IsChecked = action.DoNotClosePanel == true;
	}

	public void SaveXActionOptions(XAction xAction)
	{
		xAction.LimitSingleInstance = ChkAllowMultipleInstance.IsChecked == false;
	}

	public void SaveActionOptions(ActionItem action)
	{
		action.SkipWhenStopRunningActions = ChkSkipWhenStopRunningActions.IsChecked == true;
		action.SkipCheckUpdate = ChkSkipCheckUpdate.IsChecked == true;
		action.AutoUpdate = ChkAutoUpdate.IsChecked == true;
		if (!jv0ovEF9AKsttdYA3C6o())
		{
			switch (0)
			{
			}
		}
		action.KeepInfoWhenUpdate = ChkKeepInfoWhenUpdate.IsChecked == true;
		action.MinQuickerVersion = TxtMinVersion.Text;
		action.ContextMenuData = TxtContextMenuData.Text;
		action.AllowScrollTrigger = ChkAllowScrollTrigger.IsChecked == true;
		action.EnableEvaluateVariable = ChkEnableEvaluateVariable.IsChecked == true;
		action.DoNotClosePanel = ChkDoNotClosePanel.IsChecked == true;
	}

	private void GOhL66CbvY2(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(TxtMinVersion.Text) && !Regex.IsMatch(TxtMinVersion.Text, "^(\\d+).(\\d+).(\\d+)$"))
		{
			AppHelper.ShowWarning("版本号不合法。请输入类似于 1.5.18 格式的版本号。", true);
			TxtMinVersion.Text = "";
			TxtMinVersion.Focus();
		}
	}

	private void QW2L6XTD0l9(object sender, RoutedEventArgs e)
	{
		AppHelper.EditInCodeEditor(TxtContextMenuData);
	}

	private void pW5L6msgKU6(object sender, RoutedEventArgs e)
	{
		TxtMinVersion.Text = AppHelper.GetCurrAppShortVersion();
	}

	[AsyncStateMachine(typeof(_003CMenuEditInDesigner_OnClick_003Ed__9))]
	private void ur4L6KsPlIl(object sender, RoutedEventArgs e)
	{
		_003CMenuEditInDesigner_OnClick_003Ed__9 stateMachine = default(_003CMenuEditInDesigner_OnClick_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void DgQL6xUVHgy(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(29, "为动作设计自定义右键菜单"));
	}

	private void EUUL6rqESeV(object sender, RoutedEventArgs e)
	{
		if ((sender as MenuItem)?.Tag is string text)
		{
			TxtContextMenuData.Text = (string.IsNullOrEmpty(TxtContextMenuData.Text) ? text : (text + "\r\n" + TxtContextMenuData.Text));
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!fryL6pTygFp)
		{
			fryL6pTygFp = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/actionoptionscontrol.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			fryL6pTygFp = true;
			num = 0;
			if (!jv0ovEF9AKsttdYA3C6o())
			{
				break;
			}
			goto IL_00fb;
		case 1:
			ChkSkipWhenStopRunningActions = (CheckBox)target;
			break;
		case 2:
			ChkKeepInfoWhenUpdate = (CheckBox)target;
			break;
		case 3:
			ChkSkipCheckUpdate = (CheckBox)target;
			break;
		case 4:
			ChkAutoUpdate = (CheckBox)target;
			break;
		case 5:
			ChkAllowMultipleInstance = (CheckBox)target;
			break;
		case 6:
			ChkEnableEvaluateVariable = (CheckBox)target;
			break;
		case 7:
			ChkAllowScrollTrigger = (CheckBox)target;
			break;
		case 8:
			ChkDoNotClosePanel = (CheckBox)target;
			break;
		case 9:
			TxtContextMenuData = (TextBox)target;
			break;
		case 10:
			((MenuItem)target).Click += QW2L6XTD0l9;
			num = 1;
			if (BataFfF92seR2EIm5x2I == null)
			{
				break;
			}
			goto IL_00fb;
		case 11:
			MenuEditInDesigner = (MenuItem)target;
			MenuEditInDesigner.Click += ur4L6KsPlIl;
			break;
		case 12:
			MenuHelp = (MenuItem)target;
			MenuHelp.Click += DgQL6xUVHgy;
			break;
		case 13:
			((MenuItem)target).Click += EUUL6rqESeV;
			break;
		case 14:
			TxtMinVersion = (TextBox)target;
			TxtMinVersion.LostFocus += GOhL66CbvY2;
			break;
		case 15:
			{
				MenuSetCurrentVersion = (MenuItem)target;
				MenuSetCurrentVersion.Click += pW5L6msgKU6;
				break;
			}
			IL_00fb:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool jv0ovEF9AKsttdYA3C6o()
	{
		return BataFfF92seR2EIm5x2I == null;
	}
}
