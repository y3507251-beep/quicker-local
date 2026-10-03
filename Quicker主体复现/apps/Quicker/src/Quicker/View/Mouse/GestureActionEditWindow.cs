using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Modules.Gestures.Manage;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.Mouse;

public class GestureActionEditWindow : Window, IComponentConnector
{
	private readonly DataService bSCLLdSSSgs;

	private readonly Gesture PIsLLotBGBQ;

	private readonly GestureAction KwVLLTP5KlR;

	private readonly bool tJ1LLM7LjKb;

	[CompilerGenerated]
	private GestureAction EiOLLAMiLHv;

	internal GesturePreviewControl TheGesture;

	internal TextBox TxtDesc;

	internal QuickActionEditor QuickActionEditor;

	internal SubActionMangeControl SubActionMangeControl;

	internal Button BtnSave;

	private bool uaTLLOclRtG;

	internal static GestureActionEditWindow rgLO3NFAfQ6k7BBYmYtK;

	public GestureAction Result
	{
		[CompilerGenerated]
		get
		{
			return EiOLLAMiLHv;
		}
		[CompilerGenerated]
		set
		{
			EiOLLAMiLHv = value;
		}
	}

	public GestureActionEditWindow(DataService dataService, Gesture gesture, GestureAction editingItem, bool isGlobal)
	{
		bSCLLdSSSgs = dataService;
		PIsLLotBGBQ = gesture;
		KwVLLTP5KlR = editingItem;
		tJ1LLM7LjKb = isGlobal;
		InitializeComponent();
		base.Loaded += Qf7LL52A6p6;
		if (!tJ1LLM7LjKb)
		{
			QuickActionEditor.ShowInherit = true;
		}
	}

	private void Qf7LL52A6p6(object sender, RoutedEventArgs e)
	{
		TheGesture.Points = PIsLLotBGBQ.WindowsPoints;
		if (KwVLLTP5KlR != null)
		{
			TxtDesc.Text = KwVLLTP5KlR.Description;
			QuickActionEditor.SetData(KwVLLTP5KlR);
			SubActionMangeControl.SetData(KwVLLTP5KlR);
		}
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (!AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return new FakeWindowsPeer(this);
		}
		return base.OnCreateAutomationPeer();
	}

	private void MjHLLDgkaO5(object sender, RoutedEventArgs e)
	{
		GestureAction gestureAction = new GestureAction();
		GestureAction kwVLLTP5KlR = KwVLLTP5KlR;
		object obj;
		if (kwVLLTP5KlR == null)
		{
			obj = null;
		}
		else
		{
			obj = kwVLLTP5KlR.Id;
			if (obj != null)
			{
				goto IL_0030;
			}
		}
		obj = Guid.NewGuid().ToString();
		goto IL_0030;
		IL_0168:
		base.DialogResult = true;
		return;
		IL_0126:
		QuickActionType actionType = default(QuickActionType);
		switch (actionType)
		{
		default:
			Result.Description = Result.GetSummary();
			break;
		case QuickActionType.InheritGlobal:
			Result.Description = "-继承-";
			break;
		case QuickActionType.None:
			Result.Description = "-无-";
			break;
		}
		goto IL_0168;
		IL_0030:
		gestureAction.Id = (string)obj;
		gestureAction.GestureId = PIsLLotBGBQ.Id;
		gestureAction.Description = TxtDesc.Text;
		gestureAction.IsDisabled = false;
		gestureAction.SubActions = SubActionMangeControl.GetData();
		Result = gestureAction;
		if (Result.SubActions.Count > 0 && QuickActionEditor.CbOperationType.SelectedIndex < 0)
		{
			QuickActionEditor.CbOperationType.SelectedIndex = 0;
		}
		(bool, string) tuple = QuickActionEditor.IsDataValid();
		int num;
		if (!tuple.Item1)
		{
			AppHelper.ShowWarning(tuple.Item2, true);
			num = 0;
			if (rgLO3NFAfQ6k7BBYmYtK != null)
			{
				return;
			}
		}
		else
		{
			QuickActionEditor.SaveData(Result);
			if (!string.IsNullOrEmpty(Result.Description))
			{
				goto IL_0168;
			}
			actionType = Result.ActionType;
			num = 1;
			if (!HkaBcbFAbEsB2Y3Pgmxv())
			{
				goto IL_0126;
			}
		}
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		}
		goto IL_0126;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!uaTLLOclRtG)
		{
			uaTLLOclRtG = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/gestureactioneditwindow.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			uaTLLOclRtG = true;
			break;
		case 1:
			TheGesture = (GesturePreviewControl)target;
			break;
		case 2:
			TxtDesc = (TextBox)target;
			break;
		case 3:
			QuickActionEditor = (QuickActionEditor)target;
			if (!HkaBcbFAbEsB2Y3Pgmxv())
			{
				switch (0)
				{
				}
			}
			break;
		case 4:
			SubActionMangeControl = (SubActionMangeControl)target;
			break;
		case 5:
			BtnSave = (Button)target;
			BtnSave.Click += MjHLLDgkaO5;
			break;
		}
	}

	internal static bool HkaBcbFAbEsB2Y3Pgmxv()
	{
		return rgLO3NFAfQ6k7BBYmYtK == null;
	}
}
