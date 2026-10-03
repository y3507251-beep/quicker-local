using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using HandyControl.Controls;
using Quicker.Common;

namespace Quicker.View.X.Controls;

public class ActionAssociationControl : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnSetBrowserContextMenu_OnClick_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionAssociationControl _003C_003E4__this;

		private BrowserContextMenuBindingWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object wff0D5yFvB12450oQloQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionAssociationControl actionAssociationControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					BrowserContextMenuBinding binding = actionAssociationControl.BtnSetBrowserContextMenu.Tag as BrowserContextMenuBinding;
					_003Cdlg_003E5__2 = new BrowserContextMenuBindingWindow(binding)
					{
						Owner = System.Windows.Window.GetWindow(actionAssociationControl)
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					actionAssociationControl.BtnSetBrowserContextMenu.Tag = _003Cdlg_003E5__2.ResultBinding;
				}
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

		internal static bool A0YyGHyFdBB5n7yecLZB()
		{
			return wff0D5yFvB12450oQloQ == null;
		}
	}

	internal CheckBox ChkIsTextProcessor;

	internal CheckBox ChkReturnFromGetSelectedTextStep;

	internal NumericUpDown TxtTextMinLength;

	internal NumericUpDown TxtTextMaxLength;

	internal System.Windows.Controls.TextBox TxtTextMatchExpression;

	internal CheckBox ChkIsImageProcessor;

	internal CheckBox ChkReturnImageFromFirstScreenShotStep;

	internal CheckBox ChkIsFileProcessor;

	internal NumericUpDown TxtFileMinCount;

	internal NumericUpDown TxtFileMaxCount;

	internal System.Windows.Controls.TextBox TxtAllowedFileExtensions;

	internal CheckBox ChkRequireAllFileMatchExt;

	internal CheckBox ChkEnableRealtimeSearch;

	internal System.Windows.Controls.TextBox TxtSearchPlaceholder;

	internal Button BtnSetBrowserContextMenu;

	internal HandyControl.Controls.TextBox TxtUrlPattern;

	private bool LGHLbakb07f;

	private static ActionAssociationControl ILfEy2FNl6IWq8fxp3t3;

	public ActionAssociationControl()
	{
		InitializeComponent();
	}

	public void LoadActionAssociations(ActionItem editingActionItem)
	{
		ActionAssociation actionAssociation = editingActionItem.Association ?? new ActionAssociation();
		ChkIsTextProcessor.IsChecked = actionAssociation.IsTextProcessor;
		ChkReturnFromGetSelectedTextStep.IsChecked = actionAssociation.ReturnTextFromGetSelectedTextStep;
		TxtTextMinLength.Value = actionAssociation.TextMinLength;
		TxtTextMaxLength.Value = actionAssociation.TextMaxLength;
		TxtTextMatchExpression.Text = actionAssociation.TextMatchExpression;
		ChkEnableRealtimeSearch.IsChecked = actionAssociation.EnableRealtimeSearch;
		ChkIsImageProcessor.IsChecked = actionAssociation.IsImageProcessor;
		int num = 0;
		if (!jN1MSFFNZPTD6ucciQv8())
		{
			goto IL_00b2;
		}
		goto IL_00f1;
		IL_00f1:
		switch (num)
		{
		case 1:
			TxtFileMinCount.Value = actionAssociation.FileMinCount;
			TxtFileMaxCount.Value = actionAssociation.FileMaxCount;
			TxtAllowedFileExtensions.Text = actionAssociation.AllowedFileExtensions;
			ChkRequireAllFileMatchExt.IsChecked = actionAssociation.RequireAllFileMatchExt;
			TxtSearchPlaceholder.Text = actionAssociation.SearchBoxPlaceholder;
			BtnSetBrowserContextMenu.Tag = actionAssociation.BrowserContextMenu;
			TxtUrlPattern.Text = actionAssociation.UrlPattern;
			return;
		}
		goto IL_00b2;
		IL_00b2:
		ChkReturnImageFromFirstScreenShotStep.IsChecked = actionAssociation.ReturnImageFromFirstScreenShotStep;
		ChkIsFileProcessor.IsChecked = actionAssociation.IsFileProcessor;
		num = 1;
		if (ILfEy2FNl6IWq8fxp3t3 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00f1;
	}

	public void SaveActionAssociations(ActionItem resultActionItem)
	{
		resultActionItem.EnsureAssociation();
		ActionAssociation association = resultActionItem.Association;
		association.IsTextProcessor = ChkIsTextProcessor.IsChecked == true;
		association.ReturnTextFromGetSelectedTextStep = ChkReturnFromGetSelectedTextStep.IsChecked == true;
		association.TextMinLength = (int)TxtTextMinLength.Value;
		association.TextMaxLength = (int)TxtTextMaxLength.Value;
		association.TextMatchExpression = TxtTextMatchExpression.Text.Trim();
		association.EnableRealtimeSearch = ChkEnableRealtimeSearch.IsChecked == true;
		association.IsImageProcessor = ChkIsImageProcessor.IsChecked == true;
		association.ReturnImageFromFirstScreenShotStep = ChkReturnImageFromFirstScreenShotStep.IsChecked == true;
		association.IsFileProcessor = ChkIsFileProcessor.IsChecked == true;
		association.FileMinCount = (int)TxtFileMinCount.Value;
		association.FileMaxCount = (int)TxtFileMaxCount.Value;
		association.AllowedFileExtensions = TxtAllowedFileExtensions.Text.Trim();
		int num = 0;
		if (ILfEy2FNl6IWq8fxp3t3 == null)
		{
			goto IL_0137;
		}
		goto IL_0175;
		IL_0137:
		association.RequireAllFileMatchExt = ChkRequireAllFileMatchExt.IsChecked == true;
		association.SearchBoxPlaceholder = TxtSearchPlaceholder.Text;
		num = 0;
		if (ILfEy2FNl6IWq8fxp3t3 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0175;
		IL_0175:
		switch (num)
		{
		case 1:
			break;
		default:
			association.BrowserContextMenu = BtnSetBrowserContextMenu.Tag as BrowserContextMenuBinding;
			association.UrlPattern = TxtUrlPattern.Text;
			resultActionItem.Association = association;
			return;
		}
		goto IL_0137;
	}

	[AsyncStateMachine(typeof(_003CBtnSetBrowserContextMenu_OnClick_003Ed__3))]
	private void ao7Lb8MMjfe(object sender, RoutedEventArgs e)
	{
		_003CBtnSetBrowserContextMenu_OnClick_003Ed__3 stateMachine = default(_003CBtnSetBrowserContextMenu_OnClick_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!LGHLbakb07f)
		{
			LGHLbakb07f = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/actionassociationcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 2;
		while (true)
		{
			int num2;
			switch (connectionId)
			{
			case 11:
				TxtAllowedFileExtensions = (System.Windows.Controls.TextBox)target;
				num2 = 0;
				if (!jN1MSFFNZPTD6ucciQv8())
				{
					return;
				}
				goto IL_0026;
			default:
				num2 = 1;
				if (!jN1MSFFNZPTD6ucciQv8())
				{
					num2 = num;
				}
				goto IL_0026;
			case 1:
				ChkIsTextProcessor = (CheckBox)target;
				return;
			case 2:
				ChkReturnFromGetSelectedTextStep = (CheckBox)target;
				return;
			case 3:
				TxtTextMinLength = (NumericUpDown)target;
				return;
			case 4:
				TxtTextMaxLength = (NumericUpDown)target;
				return;
			case 5:
				TxtTextMatchExpression = (System.Windows.Controls.TextBox)target;
				return;
			case 6:
				ChkIsImageProcessor = (CheckBox)target;
				return;
			case 7:
				ChkReturnImageFromFirstScreenShotStep = (CheckBox)target;
				return;
			case 8:
				ChkIsFileProcessor = (CheckBox)target;
				return;
			case 9:
				TxtFileMinCount = (NumericUpDown)target;
				return;
			case 10:
				TxtFileMaxCount = (NumericUpDown)target;
				return;
			case 12:
				ChkRequireAllFileMatchExt = (CheckBox)target;
				return;
			case 13:
				ChkEnableRealtimeSearch = (CheckBox)target;
				return;
			case 14:
				TxtSearchPlaceholder = (System.Windows.Controls.TextBox)target;
				return;
			case 15:
				BtnSetBrowserContextMenu = (Button)target;
				BtnSetBrowserContextMenu.Click += ao7Lb8MMjfe;
				return;
			case 16:
				{
					TxtUrlPattern = (HandyControl.Controls.TextBox)target;
					return;
				}
				IL_0026:
				switch (num2)
				{
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				case 1:
					LGHLbakb07f = true;
					return;
				}
				break;
			}
		}
	}

	internal static bool jN1MSFFNZPTD6ucciQv8()
	{
		return ILfEy2FNl6IWq8fxp3t3 == null;
	}
}
