using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Modules.Gestures.Manage;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.CircleMenu;

public class CircleMenuActionEditWindow : System.Windows.Window, IComponentConnector
{
	private readonly DataService Vx4LZr6oMZc;

	private readonly CircleMenuAction JhGLZp9HeX1;

	[CompilerGenerated]
	private CircleMenuAction jODLZB9geN7;

	[CompilerGenerated]
	private ActionItem WmVLZQJlQUo = new ActionItem();

	internal ActionUIEditor ActionUiEditor;

	internal QuickActionEditor QuickActionEditor;

	internal NumericUpDown nudDelayMs;

	internal SubActionMangeControl SubActionMangeControl;

	internal Button BtnSave;

	private bool OoyLZjaRCor;

	internal static CircleMenuActionEditWindow TlBuEaFvUp0a07chEoo1;

	public CircleMenuAction Result
	{
		[CompilerGenerated]
		get
		{
			return jODLZB9geN7;
		}
		[CompilerGenerated]
		private set
		{
			jODLZB9geN7 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private ActionItem W8kLZmkY2RS()
	{
		return WmVLZQJlQUo;
	}

	[SpecialName]
	[CompilerGenerated]
	private void B5GLZK3pZuE(ActionItem value)
	{
		WmVLZQJlQUo = value;
	}

	public CircleMenuActionEditWindow(DataService dataService, CircleMenuAction editingAction)
	{
		Vx4LZr6oMZc = dataService;
		JhGLZp9HeX1 = editingAction;
		InitializeComponent();
		base.Loaded += pgTLZ1s8utO;
	}

	private void pgTLZ1s8utO(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (JhGLZp9HeX1 != null)
		{
			int num2 = 0;
			if (TlBuEaFvUp0a07chEoo1 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			W8kLZmkY2RS().Title = JhGLZp9HeX1.Title;
			W8kLZmkY2RS().Description = JhGLZp9HeX1.Description;
			W8kLZmkY2RS().Icon = JhGLZp9HeX1.Icon;
			QuickActionEditor.SetData(JhGLZp9HeX1);
			nudDelayMs.Value = JhGLZp9HeX1.DelayMs;
			SubActionMangeControl.SetData(JhGLZp9HeX1);
			break;
		}
		ActionUiEditor.SetUiData(W8kLZmkY2RS());
		base.Dispatcher.InvokeAsync(kGpLZ6P4pee);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void KhhLZb0d9fr(object sender, RoutedEventArgs e)
	{
		ActionUiEditor.SaveToAction(W8kLZmkY2RS());
		if (string.IsNullOrEmpty(W8kLZmkY2RS().Title))
		{
			AppHelper.ShowWarning("请输入标题。");
			return;
		}
		CircleMenuAction circleMenuAction = new CircleMenuAction
		{
			Title = W8kLZmkY2RS().Title,
			Description = W8kLZmkY2RS().Description,
			Icon = W8kLZmkY2RS().Icon,
			DelayMs = (int)nudDelayMs.Value,
			SubActions = SubActionMangeControl.GetData()
		};
		if (circleMenuAction.SubActions.Count > 0 && QuickActionEditor.CbOperationType.SelectedIndex < 0)
		{
			int num = 0;
			if (!aFAEEHFvxt2GGa33KoEw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			QuickActionEditor.CbOperationType.SelectedIndex = 0;
		}
		(bool, string) tuple = QuickActionEditor.IsDataValid();
		if (!tuple.Item1)
		{
			AppHelper.ShowWarning(tuple.Item2);
			return;
		}
		QuickActionEditor.SaveData(circleMenuAction);
		Result = circleMenuAction;
		base.DialogResult = true;
	}

	private void QuickActionEditor_OnActionSelected(object sender, ActionItem actionItem)
	{
		if (actionItem != null && string.IsNullOrEmpty(ActionUiEditor.ActionTitle))
		{
			ActionUiEditor.SetUiData(actionItem.Title, actionItem.Description, actionItem.Icon);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!OoyLZjaRCor)
		{
			OoyLZjaRCor = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/circlemenu/circlemenuactioneditwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			OoyLZjaRCor = true;
			break;
		case 1:
			ActionUiEditor = (ActionUIEditor)target;
			break;
		case 2:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 3:
		{
			nudDelayMs = (NumericUpDown)target;
			int num = 0;
			if (!aFAEEHFvxt2GGa33KoEw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 4:
			SubActionMangeControl = (SubActionMangeControl)target;
			break;
		case 5:
			BtnSave = (Button)target;
			BtnSave.Click += KhhLZb0d9fr;
			break;
		}
	}

	[CompilerGenerated]
	private void kGpLZ6P4pee()
	{
		ActionUiEditor.TxtActionTitle.Focus();
	}

	internal static bool aFAEEHFvxt2GGa33KoEw()
	{
		return TlBuEaFvUp0a07chEoo1 == null;
	}
}
