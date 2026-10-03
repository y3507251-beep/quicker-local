using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Common.QuickActions;
using Quicker.Domain.QuickActions;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;
using Quicker.View.Hotkeys;
using Quicker.View.TextCommands;

namespace Quicker.View.Controls;

public class QuickActionEditor : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xPHS3tmyBpW;

		public static Func<QuickActionSelectItem, bool> UimS3gtaxeP;

		public static Func<QuickActionSelectItem, bool> vKQS3Ldejil;

		internal static _003C_003Ec QvomeIyprheMM2eHySDG;

		static _003C_003Ec()
		{
			xPHS3tmyBpW = new _003C_003Ec();
		}

		internal bool xoBSizSLOEQ(QuickActionSelectItem x)
		{
			return !x.RequireDrag;
		}

		internal bool jtiS3wy663A(QuickActionSelectItem x)
		{
			return !x.IsBasicOperation;
		}

		internal static bool NOJIQbypN3eMFsSgiia1()
		{
			return QvomeIyprheMM2eHySDG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public string[] v6YS3SCht3a;

		internal static _003C_003Ec__DisplayClass27_0 m7kdfvypL79xTWypxlDo;

		internal bool tvfS3vu6ZZY(QuickOperationItem x)
		{
			return v6YS3SCht3a.Contains(x.Key);
		}

		internal static bool kNVk3Yypu082pFEErKgB()
		{
			return m7kdfvypL79xTWypxlDo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public IEnumerable<QuickActionType> Ui6S3u6A8em;

		private static _003C_003Ec__DisplayClass28_0 AVEkqlypfyLElDVqLYC5;

		internal bool g9HS32Ai1Qh(QuickActionSelectItem x)
		{
			return Ui6S3u6A8em.Contains(x.ActionType);
		}

		static _003C_003Ec__DisplayClass28_0()
		{
		}

		internal static bool hgdb9JypbXJT7s4U3ILb()
		{
			return AVEkqlypfyLElDVqLYC5 == null;
		}

		internal static void Lk6BaAypidw9QkHSMxHx()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public IQuickActionItem LgcS30j7Dya;

		internal static _003C_003Ec__DisplayClass29_0 rcVbDwyplLFRl7bm217K;

		internal bool Pm3S3NWIrNp(QuickActionSelectItem x)
		{
			return x.ActionType == LgcS30j7Dya.ActionType;
		}

		internal bool aRQS3JERqVS(QuickOperationItem x)
		{
			return x.Key == LgcS30j7Dya.Data;
		}

		internal static bool wGLMfmypZiA3w6Q7lk7k()
		{
			return rcVbDwyplLFRl7bm217K == null;
		}
	}

	[CompilerGenerated]
	private EventHandler<ActionItem> m_ActionSelected;

	[CompilerGenerated]
	private bool ad5LQoM3T7Y;

	[CompilerGenerated]
	private bool N4tLQT1pc47;

	[CompilerGenerated]
	private bool TMnLQM6PAho;

	public SmartCollection<QuickActionSelectItem> _operations = new SmartCollection<QuickActionSelectItem>();

	public SmartCollection<QuickOperationItem> _quickOperationItems = new SmartCollection<QuickOperationItem>(QuickOperationItem.AllQuickerOperationItems);

	internal TextBlock TxtLabel;

	internal ComboBox CbOperationType;

	internal Label LblParam;

	internal StackPanel PnlParam;

	internal StackPanel PnlQuickerAction;

	internal ActionSelector ActionSelector;

	internal TextBox TxtActionParams;

	internal TextBlock TxtActionParamsHelp;

	internal StackPanel PnlQuickerOperation;

	internal ComboBox CbQuickerOperation;

	internal StackPanel PnlText;

	internal TextBox TxtData;

	internal StackPanel PnlRunOrOpen;

	internal TextBoxWithToolsControl TxtPath;

	internal TextBox TxtParams;

	internal StackPanel PnlKeyStroke;

	internal HotkeyEditorControl HotkeyEditor;

	internal StackPanel PnlKeyMouseData;

	internal TextBox TxtKeyMouseData;

	internal StackPanel PnlProfileExe;

	internal TextBoxWithToolsControl TxtProfileExe;

	internal Label LblParamForQuickOperation;

	internal StackPanel PnlParamForQuickOperation;

	internal TextBox TxtParamData;

	internal TextBlock TxtParamDataNote;

	internal TextBox TxtMessage;

	private bool jdhLQA2xUes;

	internal static QuickActionEditor SLY5DrFblVGMFkDWKajx;

	public bool AllowBasicOperation
	{
		[CompilerGenerated]
		get
		{
			return ad5LQoM3T7Y;
		}
		[CompilerGenerated]
		set
		{
			ad5LQoM3T7Y = value;
		}
	}

	public bool ShowDragOperation
	{
		[CompilerGenerated]
		get
		{
			return N4tLQT1pc47;
		}
		[CompilerGenerated]
		set
		{
			N4tLQT1pc47 = value;
		}
	}

	public bool ShowInherit
	{
		[CompilerGenerated]
		get
		{
			return TMnLQM6PAho;
		}
		[CompilerGenerated]
		set
		{
			TMnLQM6PAho = value;
		}
	}

	public string ActionParamsHelp
	{
		get
		{
			return TxtActionParamsHelp.Text;
		}
		set
		{
			TxtActionParamsHelp.Text = value;
		}
	}

	public string LabelText
	{
		get
		{
			return TxtLabel.Text;
		}
		set
		{
			TxtLabel.Text = value;
		}
	}

	public event EventHandler<ActionItem> ActionSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ActionItem> eventHandler = this.m_ActionSelected;
			EventHandler<ActionItem> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionItem> value2 = (EventHandler<ActionItem>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ActionItem> eventHandler = this.m_ActionSelected;
			EventHandler<ActionItem> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionItem> value2 = (EventHandler<ActionItem>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public QuickActionEditor()
	{
		InitializeComponent();
		base.Loaded += MxMLQBOwkc9;
		CbOperationType.ItemsSource = _operations;
		CbQuickerOperation.ItemsSource = _quickOperationItems;
	}

	private void MxMLQBOwkc9(object sender, RoutedEventArgs e)
	{
		sM4LQQ71Scy();
		TxtPath.SetupTools(new List<TextToolType>
		{
			TextToolType.SelectProcessPath,
			TextToolType.SelectSingleFile,
			TextToolType.SelectSingleFolder
		});
		TxtProfileExe.SetupTools(new List<TextToolType> { TextToolType.SelectProfileExe });
	}

	private void sM4LQQ71Scy()
	{
		if (_operations.HasData())
		{
			xkULQnwk66k();
			return;
		}
		UpdateOperationList();
		xkULQnwk66k();
	}

	public void UpdateOperationList()
	{
		if (AllowBasicOperation)
		{
			if (ShowDragOperation)
			{
				_operations.Reset(QuickActionSelectItem.AllQuickActionSelectItems);
				int num = 0;
				if (SLY5DrFblVGMFkDWKajx != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				_operations.Reset(QuickActionSelectItem.AllQuickActionSelectItems.Where(_003C_003Ec.UimS3gtaxeP ?? (_003C_003Ec.UimS3gtaxeP = _003C_003Ec.xPHS3tmyBpW.xoBSizSLOEQ)));
			}
		}
		else
		{
			_operations.Reset(QuickActionSelectItem.AllQuickActionSelectItems.Where(_003C_003Ec.vKQS3Ldejil ?? (_003C_003Ec.vKQS3Ldejil = _003C_003Ec.xPHS3tmyBpW.jtiS3wy663A)));
		}
		if (!ShowInherit)
		{
			_operations.Remove(_operations.Last());
		}
	}

	public void UpdateQuickOperationItems(params string[] keys)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.v6YS3SCht3a = keys;
		_quickOperationItems.Reset(QuickOperationItem.AllQuickerOperationItems.Where(_003C_003Ec__DisplayClass27_.tvfS3vu6ZZY));
	}

	public void UpdateOperationList(IEnumerable<QuickActionType> allowedQuickActionTypes)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.Ui6S3u6A8em = allowedQuickActionTypes;
		_operations.Reset(QuickActionSelectItem.AllQuickActionSelectItems.Where(_003C_003Ec__DisplayClass28_.g9HS32Ai1Qh));
	}

	public void SetData(IQuickActionItem quickAction)
	{
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
		_003C_003Ec__DisplayClass29_.LgcS30j7Dya = quickAction;
		int num = 0;
		if (SLY5DrFblVGMFkDWKajx != null)
		{
			goto IL_00ea;
		}
		goto IL_0158;
		IL_00ea:
		int num2 = default(int);
		num = num2;
		goto IL_0158;
		IL_0158:
		string[] array = default(string[]);
		do
		{
			switch (num)
			{
			case 2:
				switch (_003C_003Ec__DisplayClass29_.LgcS30j7Dya.ActionType)
				{
				case QuickActionType.RunOrOpen:
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data))
					{
						TxtPath.Text = "";
						TxtParams.Text = "";
						break;
					}
					goto IL_00b0;
				case QuickActionType.Keystroke:
					HotkeyEditor.SetData(_003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data);
					break;
				case QuickActionType.SendKeys:
				case QuickActionType.PasteText:
				case QuickActionType.PasteHtml:
				case QuickActionType.InputText:
				case QuickActionType.InputScript:
					TxtData.Text = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data;
					break;
				case QuickActionType.QuickerOperation:
					CbQuickerOperation.SelectedItem = QuickOperationItem.AllQuickerOperationItems.FirstOrDefault(_003C_003Ec__DisplayClass29_.aRQS3JERqVS);
					break;
				case QuickActionType.QuickerAction:
				{
					(string, string) actionIdAndParam = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data.GetActionIdAndParam();
					ActionSelector.ActionIdOrName = actionIdAndParam.Item1;
					TxtActionParams.Text = actionIdAndParam.Item2;
					break;
				}
				case QuickActionType.PlayKeyMouseData:
					TxtKeyMouseData.Text = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data;
					break;
				case QuickActionType.StartCircleMenu:
				case QuickActionType.StartMouseGesture:
					TxtProfileExe.Text = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data;
					break;
				}
				break;
			default:
			{
				sM4LQQ71Scy();
				QuickActionSelectItem selectedItem = QuickActionSelectItem.AllQuickActionSelectItems.FirstOrDefault(_003C_003Ec__DisplayClass29_.Pm3S3NWIrNp);
				CbOperationType.SelectedItem = selectedItem;
				TxtMessage.Text = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Message ?? "";
				TxtParamData.Text = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.ParamData;
				goto case 2;
			}
			case 1:
				TxtParams.Text = ((array.Length > 1) ? array[1] : "");
				break;
			}
			EghLQDBqYZY();
			return;
			IL_00b0:
			array = _003C_003Ec__DisplayClass29_.LgcS30j7Dya.Data.Split('\n');
			TxtPath.Text = array[0];
			num = 1;
		}
		while (hLlPd3FbZAND9lCy2RZ6());
		goto IL_00ea;
	}

	public (bool isValid, string message) IsDataValid()
	{
		if (CbOperationType.SelectedItem == null)
		{
			return (isValid: false, message: "请选择操作类型。");
		}
		if (PnlText.Visibility == Visibility.Visible && string.IsNullOrEmpty(TxtData.Text))
		{
			return (isValid: false, message: "请输入参数内容。");
		}
		return (isValid: true, message: "");
	}

	public bool IsValid()
	{
		return CbOperationType.SelectedItem != null;
	}

	public void SaveData(IQuickActionItem quickAction)
	{
		if (!(CbOperationType.SelectedItem is QuickActionSelectItem quickActionSelectItem))
		{
			quickAction.ActionType = QuickActionType.None;
			return;
		}
		quickAction.ActionType = quickActionSelectItem.ActionType;
		quickAction.Data = A3ILQjkvcje(quickActionSelectItem);
		quickAction.Message = (string.IsNullOrEmpty(TxtMessage.Text) ? null : TxtMessage.Text);
		quickAction.ParamData = ((PnlParamForQuickOperation.Visibility == Visibility.Visible) ? TxtParamData.Text : string.Empty);
	}

	private string A3ILQjkvcje(QuickActionSelectItem quickActionSelectItem_0)
	{
		switch (quickActionSelectItem_0.ActionType)
		{
		case QuickActionType.Keystroke:
			return HotkeyEditor.GetKeyData();
		case QuickActionType.RunOrOpen:
			return TxtPath.Text + "\n" + TxtParams.Text;
		case QuickActionType.SendKeys:
		case QuickActionType.PasteText:
		case QuickActionType.PasteHtml:
		case QuickActionType.InputText:
		case QuickActionType.InputScript:
			return TxtData.Text;
		case QuickActionType.QuickerOperation:
			return (CbQuickerOperation.SelectedItem as QuickOperationItem)?.Key;
		case QuickActionType.QuickerAction:
			if (!string.IsNullOrEmpty(TxtActionParams.Text))
			{
				return ActionSelector.ActionIdOrName + "\n" + TxtActionParams.Text;
			}
			return ActionSelector.ActionIdOrName;
		case QuickActionType.PlayKeyMouseData:
			return TxtKeyMouseData.Text;
		default:
			return "";
		case QuickActionType.StartCircleMenu:
		case QuickActionType.StartMouseGesture:
			return TxtProfileExe.Text;
		}
	}

	private void xkULQnwk66k()
	{
		PnlKeyStroke.Visibility = Visibility.Collapsed;
		PnlText.Visibility = Visibility.Collapsed;
		PnlQuickerAction.Visibility = Visibility.Collapsed;
		PnlQuickerOperation.Visibility = Visibility.Collapsed;
		int num = 0;
		if (SLY5DrFblVGMFkDWKajx != null)
		{
			goto IL_015b;
		}
		goto IL_017d;
		IL_015b:
		int num2 = default(int);
		num = num2;
		goto IL_017d;
		IL_017d:
		while (true)
		{
			switch (num)
			{
			default:
				PnlRunOrOpen.Visibility = Visibility.Collapsed;
				PnlKeyMouseData.Visibility = Visibility.Collapsed;
				PnlProfileExe.Visibility = Visibility.Collapsed;
				LblParamForQuickOperation.Visibility = Visibility.Collapsed;
				PnlParamForQuickOperation.Visibility = Visibility.Collapsed;
				if (CbOperationType.SelectedItem is QuickActionSelectItem quickActionSelectItem)
				{
					LblParam.Visibility = Visibility.Visible;
					switch (quickActionSelectItem.ActionType)
					{
					case QuickActionType.None:
						break;
					case QuickActionType.Keystroke:
						goto IL_0132;
					case QuickActionType.PasteHtml:
						goto IL_0161;
					case QuickActionType.PasteText:
						LblParam.Content = "文本内容";
						PnlText.Visibility = Visibility.Visible;
						return;
					case QuickActionType.RunOrOpen:
						LblParam.Content = "";
						PnlRunOrOpen.Visibility = Visibility.Visible;
						return;
					case QuickActionType.SendKeys:
					case QuickActionType.InputText:
						LblParam.Content = "内容";
						PnlText.Visibility = Visibility.Visible;
						return;
					case QuickActionType.InputScript:
						LblParam.Content = "步骤列表";
						PnlText.Visibility = Visibility.Visible;
						return;
					case QuickActionType.QuickerOperation:
						LblParam.Content = "功能(操作)";
						PnlQuickerOperation.Visibility = Visibility.Visible;
						EghLQDBqYZY();
						return;
					case QuickActionType.QuickerAction:
						LblParam.Content = "动作ID/名称";
						PnlQuickerAction.Visibility = Visibility.Visible;
						return;
					case QuickActionType.PlayKeyMouseData:
						LblParam.Content = "键鼠录制数据";
						PnlKeyMouseData.Visibility = Visibility.Visible;
						return;
					default:
						LblParam.Content = "";
						return;
					case QuickActionType.StartCircleMenu:
					case QuickActionType.StartMouseGesture:
						LblParam.Content = "场景标识";
						PnlProfileExe.Visibility = Visibility.Visible;
						return;
					}
					LblParam.Visibility = Visibility.Collapsed;
					num = 1;
					if (SLY5DrFblVGMFkDWKajx == null)
					{
						continue;
					}
					break;
				}
				return;
			case 1:
				return;
			case 2:
				return;
			case 3:
				{
					PnlText.Visibility = Visibility.Visible;
					return;
				}
				IL_0132:
				LblParam.Content = "按键组合";
				PnlKeyStroke.Visibility = Visibility.Visible;
				num = 2;
				if (SLY5DrFblVGMFkDWKajx == null)
				{
					continue;
				}
				break;
				IL_0161:
				LblParam.Content = "Html代码";
				num = 0;
				if (!hLlPd3FbZAND9lCy2RZ6())
				{
					continue;
				}
				goto case 3;
			}
			break;
		}
		goto IL_015b;
	}

	private void nB9LQ46d2pr(object sender, SelectionChangedEventArgs e)
	{
		xkULQnwk66k();
		base.Dispatcher.Invoke(z54LQd9nIoa);
	}

	private void ActionSelector_OnActionSelected(object sender, ActionItem e)
	{
		this.m_ActionSelected?.Invoke(this, e);
	}

	private void SwiLQ5b2TJv(object sender, SelectionChangedEventArgs e)
	{
		EghLQDBqYZY();
	}

	private void EghLQDBqYZY()
	{
		LblParamForQuickOperation.Visibility = Visibility.Collapsed;
		PnlParamForQuickOperation.Visibility = Visibility.Collapsed;
		if (!(CbOperationType.SelectedItem is QuickActionSelectItem { ActionType: QuickActionType.QuickerOperation }))
		{
			return;
		}
		if (!(CbQuickerOperation.SelectedItem is QuickOperationItem quickOperationItem))
		{
			if (!hLlPd3FbZAND9lCy2RZ6())
			{
				switch (0)
				{
				}
			}
		}
		else if (quickOperationItem.IsSupportParamData)
		{
			LblParamForQuickOperation.Content = quickOperationItem.ParamDataTitle;
			LblParamForQuickOperation.Visibility = Visibility.Visible;
			PnlParamForQuickOperation.Visibility = Visibility.Visible;
			TxtParamDataNote.Text = quickOperationItem.ParamDataNote;
		}
		else
		{
			LblParamForQuickOperation.Content = "";
			LblParamForQuickOperation.Visibility = Visibility.Collapsed;
			PnlParamForQuickOperation.Visibility = Visibility.Collapsed;
			TxtParamDataNote.Text = "";
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!jdhLQA2xUes)
		{
			jdhLQA2xUes = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/quickactioneditor.xaml", UriKind.Relative);
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
			jdhLQA2xUes = true;
			break;
		case 1:
			TxtLabel = (TextBlock)target;
			break;
		case 2:
			CbOperationType = (ComboBox)target;
			CbOperationType.SelectionChanged += nB9LQ46d2pr;
			num = 0;
			if (!hLlPd3FbZAND9lCy2RZ6())
			{
				break;
			}
			goto IL_0213;
		case 3:
			LblParam = (Label)target;
			break;
		case 4:
			PnlParam = (StackPanel)target;
			break;
		case 5:
			PnlQuickerAction = (StackPanel)target;
			break;
		case 6:
			ActionSelector = (ActionSelector)target;
			break;
		case 7:
			TxtActionParams = (TextBox)target;
			break;
		case 8:
			TxtActionParamsHelp = (TextBlock)target;
			break;
		case 9:
			PnlQuickerOperation = (StackPanel)target;
			break;
		case 10:
			CbQuickerOperation = (ComboBox)target;
			CbQuickerOperation.SelectionChanged += SwiLQ5b2TJv;
			break;
		case 11:
			PnlText = (StackPanel)target;
			break;
		case 12:
			TxtData = (TextBox)target;
			break;
		case 13:
			PnlRunOrOpen = (StackPanel)target;
			break;
		case 14:
			TxtPath = (TextBoxWithToolsControl)target;
			break;
		case 15:
			TxtParams = (TextBox)target;
			break;
		case 16:
			PnlKeyStroke = (StackPanel)target;
			break;
		case 17:
			HotkeyEditor = (HotkeyEditorControl)target;
			break;
		case 18:
			PnlKeyMouseData = (StackPanel)target;
			break;
		case 19:
			TxtKeyMouseData = (TextBox)target;
			break;
		case 20:
			PnlProfileExe = (StackPanel)target;
			break;
		case 21:
			TxtProfileExe = (TextBoxWithToolsControl)target;
			break;
		case 22:
			LblParamForQuickOperation = (Label)target;
			break;
		case 23:
			PnlParamForQuickOperation = (StackPanel)target;
			break;
		case 24:
			TxtParamData = (TextBox)target;
			break;
		case 25:
			TxtParamDataNote = (TextBlock)target;
			num = 1;
			if (SLY5DrFblVGMFkDWKajx != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0213;
		case 26:
			{
				TxtMessage = (TextBox)target;
				break;
			}
			IL_0213:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void z54LQd9nIoa()
	{
		TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next)
		{
			Wrapped = true
		};
		CbOperationType.MoveFocus(request);
	}

	static QuickActionEditor()
	{
	}

	internal static bool hLlPd3FbZAND9lCy2RZ6()
	{
		return SLY5DrFblVGMFkDWKajx == null;
	}

	internal static void UNBhy7FbPKjamkAVVJTV()
	{
	}
}
