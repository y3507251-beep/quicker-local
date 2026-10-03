using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class LinkActionParameter : BaseActionParamEditor, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnPasteAction_OnClick_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LinkActionParameter _003C_003E4__this;

		internal static object ztXMDUycMrk8rGPAoJvW;

		private void MoveNext()
		{
			LinkActionParameter linkActionParameter = _003C_003E4__this;
			try
			{
				if (ClipboardHelper.ContainsData("quicker-action-item"))
				{
					ActionItem actionItem = (ActionItem)ClipboardHelper.GetData("quicker-action-item");
					if (actionItem == null)
					{
						AppHelper.ShowWarning("无法粘贴，内容位空。");
					}
					else if (actionItem.ActionType == ActionType.LinkAction)
					{
						AppHelper.ShowWarning("不能为链接动作再创建链接动作。");
					}
					else
					{
						linkActionParameter.TxtActionId.Text = actionItem.Id;
						((ActionEditorWindow)Window.GetWindow(linkActionParameter)).UpdateTitleAndIcon("*" + actionItem.Title, actionItem.Icon);
						int num = 0;
						if (!dm96nAycUNTwfbn5QvGD())
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						case 0:
							break;
						}
					}
				}
				else
				{
					AppHelper.ShowWarning("剪贴板中没有数据。");
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

		internal static bool dm96nAycUNTwfbn5QvGD()
		{
			return ztXMDUycMrk8rGPAoJvW == null;
		}
	}

	[CompilerGenerated]
	private IconManager DoHLmiUqoF2;

	private ActionItem IfjLm3E8FnX;

	[CompilerGenerated]
	private string TopLmfGlyVB;

	[CompilerGenerated]
	private IList<SelectionItem> k6wLmzTOCuq;

	internal TextBox TxtActionId;

	internal Button BtnPasteAction;

	private bool R3ZLKwbB7Jd;

	internal static LinkActionParameter k1hspsFLftC4tPAp1TZ1;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return DoHLmiUqoF2;
		}
		[CompilerGenerated]
		private set
		{
			DoHLmiUqoF2 = value;
		}
	}

	private string IconImage
	{
		[CompilerGenerated]
		get
		{
			return TopLmfGlyVB;
		}
		[CompilerGenerated]
		set
		{
			TopLmfGlyVB = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IList<SelectionItem> v9PLmFBI7F5()
	{
		return k6wLmzTOCuq;
	}

	[SpecialName]
	[CompilerGenerated]
	private void qSFLmUSVP7M(IList<SelectionItem> value)
	{
		k6wLmzTOCuq = value;
	}

	public LinkActionParameter()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
		base.Loaded += WWSLmDXg0m4;
	}

	private void WWSLmDXg0m4(object sender, RoutedEventArgs e)
	{
		Window.GetWindow(this);
	}

	public override void SetData(ActionItem actionItem)
	{
		IfjLm3E8FnX = actionItem;
		TxtActionId.Text = actionItem.Data;
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = TxtActionId.Text.Trim();
		if (!string.IsNullOrEmpty(IconImage))
		{
			actionItem.Icon = IconImage;
		}
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (string.IsNullOrEmpty(TxtActionId.Text))
		{
			return (isSuccess: false, message: "请输入动作ID或。");
		}
		if (AppState.DataService.GetActionById(TxtActionId.Text).action == null)
		{
			return (isSuccess: false, message: "未找到动作。");
		}
		return (isSuccess: true, message: string.Empty);
	}

	[AsyncStateMachine(typeof(_003CBtnPasteAction_OnClick_003Ed__18))]
	private void WORLmdSwoc1(object sender, RoutedEventArgs e)
	{
		_003CBtnPasteAction_OnClick_003Ed__18 stateMachine = default(_003CBtnPasteAction_OnClick_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void T37LmoxdESb(string string_0)
	{
		if (TxtActionId.SelectedText.Length > 0)
		{
			TxtActionId.Text = TxtActionId.Text.Replace(TxtActionId.Text.Substring(TxtActionId.SelectionStart, TxtActionId.SelectionLength), string_0);
		}
		else
		{
			TxtActionId.Text = TxtActionId.Text.Insert(TxtActionId.CaretIndex, string_0);
		}
	}

	private void uXDLmTSmtcv(object sender, RoutedEventArgs e)
	{
		T37LmoxdESb("{context}");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!R3ZLKwbB7Jd)
		{
			R3ZLKwbB7Jd = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/linkactionparameter.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			R3ZLKwbB7Jd = true;
			break;
		case 2:
			BtnPasteAction = (Button)target;
			BtnPasteAction.Click += WORLmdSwoc1;
			break;
		case 1:
			TxtActionId = (TextBox)target;
			break;
		}
	}

	internal static bool BDqV6CFLbWZ8QGiVBYxV()
	{
		return k1hspsFLftC4tPAp1TZ1 == null;
	}
}
