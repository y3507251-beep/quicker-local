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
using System.Windows.Media;
using Quicker.Common;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.ProfileManagement;

namespace Quicker.View.Controls;

public class ProfilePanelControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public int pbkSiFlVTuB;

		public int oDQSiUBL3Ja;

		internal static _003C_003Ec__DisplayClass39_0 nPxZLkyp03swrgDYJbTQ;

		internal bool WPgSiOckWL4(ActionItem x)
		{
			if (x.Row == pbkSiFlVTuB)
			{
				return x.Col == oDQSiUBL3Ja;
			}
			return false;
		}

		internal static bool ogpNKhyp1W89eys3nvvY()
		{
			return nPxZLkyp03swrgDYJbTQ == null;
		}
	}



	private double ihhLQY7nyJo = 60.0;

	private double t1ALQI4EEeR = 1.0;

	private int uKnLQW1xvLl = 4;

	[CompilerGenerated]
	private ActionDroppedEventHandler m_ActionDropped;

	[CompilerGenerated]
	private ButtonClickedEventHandler m_ActionButtonClicked;

	[CompilerGenerated]
	private ButtonWheelEventHandler klLLQkAkZMv;

	[CompilerGenerated]
	private EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> m_ActionDoubleClicked;

	[CompilerGenerated]
	private bool bIbLQG4plXS = true;

	public static readonly DependencyProperty ActionProfileProperty;

	private readonly IDictionary<int, ActionButton> kghLQs8nUWx = new Dictionary<int, ActionButton>();

	private Point TxDLQHoSWxB;

	private ActionButton jVILQ1OwjV7;

	internal Canvas BtnCanvas;

	private bool g7MLQbnwI1u;

	internal static ProfilePanelControl C1CboRFbKNrGptvUfXeg;

	public bool EnableDragAction
	{
		[CompilerGenerated]
		get
		{
			return bIbLQG4plXS;
		}
		[CompilerGenerated]
		set
		{
			bIbLQG4plXS = value;
		}
	}

	public Brush GridBgColor
	{
		get
		{
			return BtnCanvas.Background;
		}
		set
		{
			BtnCanvas.Background = value;
		}
	}

	public ActionProfile ActionProfile
	{
		get
		{
			return (ActionProfile)GetValue(ActionProfileProperty);
		}
		set
		{
			SetValue(ActionProfileProperty, value);
		}
	}

	public IList<ActionButton> AllButtons => kghLQs8nUWx.Values.ToList();

	public event ActionDroppedEventHandler ActionDropped
	{
		[CompilerGenerated]
		add
		{
			ActionDroppedEventHandler actionDroppedEventHandler = this.m_ActionDropped;
			ActionDroppedEventHandler actionDroppedEventHandler2;
			do
			{
				actionDroppedEventHandler2 = actionDroppedEventHandler;
				ActionDroppedEventHandler value2 = (ActionDroppedEventHandler)Delegate.Combine(actionDroppedEventHandler2, value);
				actionDroppedEventHandler = Interlocked.CompareExchange(ref this.m_ActionDropped, value2, actionDroppedEventHandler2);
			}
			while ((object)actionDroppedEventHandler != actionDroppedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ActionDroppedEventHandler actionDroppedEventHandler = this.m_ActionDropped;
			ActionDroppedEventHandler actionDroppedEventHandler2;
			do
			{
				actionDroppedEventHandler2 = actionDroppedEventHandler;
				ActionDroppedEventHandler value2 = (ActionDroppedEventHandler)Delegate.Remove(actionDroppedEventHandler2, value);
				actionDroppedEventHandler = Interlocked.CompareExchange(ref this.m_ActionDropped, value2, actionDroppedEventHandler2);
			}
			while ((object)actionDroppedEventHandler != actionDroppedEventHandler2);
		}
	}

	public event ButtonClickedEventHandler ActionButtonClicked
	{
		[CompilerGenerated]
		add
		{
			ButtonClickedEventHandler buttonClickedEventHandler = this.m_ActionButtonClicked;
			ButtonClickedEventHandler buttonClickedEventHandler2;
			do
			{
				buttonClickedEventHandler2 = buttonClickedEventHandler;
				ButtonClickedEventHandler value2 = (ButtonClickedEventHandler)Delegate.Combine(buttonClickedEventHandler2, value);
				buttonClickedEventHandler = Interlocked.CompareExchange(ref this.m_ActionButtonClicked, value2, buttonClickedEventHandler2);
			}
			while ((object)buttonClickedEventHandler != buttonClickedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ButtonClickedEventHandler buttonClickedEventHandler = this.m_ActionButtonClicked;
			ButtonClickedEventHandler buttonClickedEventHandler2;
			do
			{
				buttonClickedEventHandler2 = buttonClickedEventHandler;
				ButtonClickedEventHandler value2 = (ButtonClickedEventHandler)Delegate.Remove(buttonClickedEventHandler2, value);
				buttonClickedEventHandler = Interlocked.CompareExchange(ref this.m_ActionButtonClicked, value2, buttonClickedEventHandler2);
			}
			while ((object)buttonClickedEventHandler != buttonClickedEventHandler2);
		}
	}

	public event ButtonWheelEventHandler ActionButtonWheeled
	{
		[CompilerGenerated]
		add
		{
			ButtonWheelEventHandler buttonWheelEventHandler = klLLQkAkZMv;
			ButtonWheelEventHandler buttonWheelEventHandler2;
			do
			{
				buttonWheelEventHandler2 = buttonWheelEventHandler;
				ButtonWheelEventHandler value2 = (ButtonWheelEventHandler)Delegate.Combine(buttonWheelEventHandler2, value);
				buttonWheelEventHandler = Interlocked.CompareExchange(ref klLLQkAkZMv, value2, buttonWheelEventHandler2);
			}
			while ((object)buttonWheelEventHandler != buttonWheelEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ButtonWheelEventHandler buttonWheelEventHandler = klLLQkAkZMv;
			ButtonWheelEventHandler buttonWheelEventHandler2;
			do
			{
				buttonWheelEventHandler2 = buttonWheelEventHandler;
				ButtonWheelEventHandler value2 = (ButtonWheelEventHandler)Delegate.Remove(buttonWheelEventHandler2, value);
				buttonWheelEventHandler = Interlocked.CompareExchange(ref klLLQkAkZMv, value2, buttonWheelEventHandler2);
			}
			while ((object)buttonWheelEventHandler != buttonWheelEventHandler2);
		}
	}

	public event EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> ActionDoubleClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> eventHandler = this.m_ActionDoubleClicked;
			EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> value2 = (EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> eventHandler = this.m_ActionDoubleClicked;
			EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> value2 = (EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ProfilePanelControl()
		: this(60.0)
	{
	}

	public ProfilePanelControl(double buttonSize)
	{
		ihhLQY7nyJo = buttonSize;
		InitializeComponent();
		BtnCanvas.Width = ihhLQY7nyJo * 4.0 + 5.0 * t1ALQI4EEeR;
		BtnCanvas.Height = ihhLQY7nyJo * 4.0 + 5.0 * t1ALQI4EEeR;
		WjjLQqrlxUm();
	}

	public void UpdateButtonSize(double buttonSize, double space)
	{
		ihhLQY7nyJo = buttonSize;
		t1ALQI4EEeR = space;
		BtnCanvas.Width = buttonSize * 4.0 + 5.0 * t1ALQI4EEeR;
		BtnCanvas.Height = buttonSize * 4.0 + 5.0 * t1ALQI4EEeR;
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				int buttonIndex = AppHelper.GetButtonIndex(false, i, j);
				ActionButton actionButton = kghLQs8nUWx[buttonIndex];
				actionButton.Height = buttonSize;
				actionButton.Width = buttonSize;
				Canvas.SetLeft(actionButton, (double)j * (buttonSize + t1ALQI4EEeR) + t1ALQI4EEeR);
				Canvas.SetTop(actionButton, (double)i * (buttonSize + t1ALQI4EEeR) + t1ALQI4EEeR);
			}
		}
	}

	private static void wisLQRM9bY6(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is ProfilePanelControl)
		{
			((ProfilePanelControl)dependencyObject_0).RefreshUi();
		}
	}

	private void WjjLQqrlxUm()
	{
		AppHelper.CreateButtonsOnCanvas(BtnCanvas, 4, 4, false, ihhLQY7nyJo, t1ALQI4EEeR, kghLQs8nUWx, 0.0, IWnLQeUmIke);
	}

	private void CZMLQcd8C7B(object sender, MouseWheelEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		if (actionButton.ActionItem != null)
		{
			int buttonIndex = (int)actionButton.Tag;
			(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(buttonIndex);
			int item = buttonLocation.row;
			int item2 = buttonLocation.column;
			klLLQkAkZMv?.Invoke(sender, new ActionButtonEventArgs<MouseWheelEventArgs>
			{
				ButtonIndex = buttonIndex,
				Row = item,
				Col = item2,
				Button = actionButton,
				Profile = ActionProfile,
				OriginAction = ActionProfile.FindActionByLocation(item, item2),
				OriginArgs = e
			});
		}
	}

	private void HldLQVGw0Q2(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			ActionButton actionButton = (ActionButton)sender;
			int buttonIndex = (int)actionButton.Tag;
			(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(buttonIndex);
			int item = buttonLocation.row;
			int item2 = buttonLocation.column;
			e.Handled = true;
			this.m_ActionDoubleClicked?.Invoke(sender, new ActionButtonEventArgs<MouseButtonEventArgs>
			{
				ButtonIndex = buttonIndex,
				Row = item,
				Col = item2,
				Button = actionButton,
				Profile = ActionProfile,
				OriginAction = ActionProfile.FindActionByLocation(item, item2),
				OriginArgs = e
			});
		}
		else
		{
			jVILQ1OwjV7 = sender as ActionButton;
			int num = 0;
			if (C1CboRFbKNrGptvUfXeg != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TxDLQHoSWxB = e.GetPosition(this);
		}
	}

	private void PfZLQZy8vGw(object sender, DragEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		int buttonIndex = (int)actionButton.Tag;
		(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(buttonIndex);
		int item = buttonLocation.row;
		int item2 = buttonLocation.column;
		this.m_ActionDropped?.Invoke(sender, new ActionButtonEventArgs<DragEventArgs>
		{
			ButtonIndex = buttonIndex,
			Row = item,
			Col = item2,
			Button = actionButton,
			Profile = ActionProfile,
			OriginAction = ActionProfile.FindActionByLocation(item, item2),
			OriginArgs = e
		});
	}

	private void LvKLQ9p1M40(object sender, MouseEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		if (actionButton != jVILQ1OwjV7 || actionButton.IsSelected)
		{
			return;
		}
		if (!EnableDragAction)
		{
			int num = 0;
			if (C1CboRFbKNrGptvUfXeg != null)
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
			if (e.LeftButton != MouseButtonState.Pressed)
			{
				return;
			}
			Point position = e.GetPosition(this);
			if (!(Math.Abs(position.X - TxDLQHoSWxB.X) > 14.0) && !(Math.Abs(position.Y - TxDLQHoSWxB.Y) > 14.0))
			{
				return;
			}
			_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
			(bool, int, int) buttonLocation = AppHelper.GetButtonLocation((int)actionButton.Tag);
			_003C_003Ec__DisplayClass39_.pbkSiFlVTuB = buttonLocation.Item2;
			_003C_003Ec__DisplayClass39_.oDQSiUBL3Ja = buttonLocation.Item3;
			ActionItem actionItem = ActionProfile.ActionItems.FirstOrDefault(_003C_003Ec__DisplayClass39_.WPgSiOckWL4);
			if (actionItem != null)
			{
				DataObject data = new DataObject("quicker-action-drag-item", new ActionItemDragObject(ActionProfile.Id, actionItem, _003C_003Ec__DisplayClass39_.pbkSiFlVTuB, _003C_003Ec__DisplayClass39_.oDQSiUBL3Ja));
				try
				{
					AppHelper.DoDragDropWrap(actionButton, data, DragDropEffects.Copy | DragDropEffects.Move);
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法启动拖动：" + ex.Message);
				}
			}
		}
	}

	private void Lf8LQhQWcMg(object sender, MouseButtonEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		int buttonIndex = (int)actionButton.Tag;
		(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(buttonIndex);
		int item = buttonLocation.row;
		int item2 = buttonLocation.column;
		this.m_ActionButtonClicked?.Invoke(sender, new ActionButtonEventArgs<MouseButtonEventArgs>
		{
			ButtonIndex = buttonIndex,
			Row = item,
			Col = item2,
			Button = actionButton,
			Profile = ActionProfile,
			OriginAction = ActionProfile.FindActionByLocation(item, item2),
			OriginArgs = e
		});
	}

	public void RefreshAction(string actionId)
	{
		foreach (ActionButton value in kghLQs8nUWx.Values)
		{
			if (value.ActionItem != null && value.ActionItem.Id == actionId)
			{
				value.RefreshAction();
			}
		}
	}

	public void RefreshUi()
	{
		var profile = ActionProfile;
		bool isGlobal = profile != null && profile.IsGlobalProfile();
		BtnCanvas.Height = isGlobal ? ihhLQY7nyJo * 3.0 + 4.0 * t1ALQI4EEeR : ihhLQY7nyJo * 4.0 + 5.0 * t1ALQI4EEeR;
		Height = BtnCanvas.Height;
		for (int row = 0; row < 4; row++)
		{
			for (int col = 0; col < 4; col++)
			{
				var button = kghLQs8nUWx[AppHelper.GetButtonIndex(false, row, col)];
				button.Visibility = isGlobal && row == 3 ? Visibility.Collapsed : Visibility.Visible;
				button.ActionItem = profile?.ActionItems?.FirstOrDefault(item => item.Row == row && item.Col == col);
				button.ShowKeyTip = false;
				button.KeyTip = "";
			}
		}
		UpdateLayout();
	}

	protected override Size MeasureOverride(Size constraint)
	{
		return new Size(BtnCanvas.Width, BtnCanvas.Height);
	}

	protected override Size ArrangeOverride(Size arrangeBounds)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Size result = base.ArrangeOverride(arrangeBounds);
		stopwatch.Stop();
		return result;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!g7MLQbnwI1u)
		{
			g7MLQbnwI1u = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/profilepanelcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			BtnCanvas = (Canvas)target;
		}
		else
		{
			g7MLQbnwI1u = true;
		}
	}

	static ProfilePanelControl()
	{
		ActionProfileProperty = DependencyProperty.Register("ActionProfile", typeof(ActionProfile), typeof(ProfilePanelControl), new PropertyMetadata(null, wisLQRM9bY6));
	}

	[CompilerGenerated]
	private void IWnLQeUmIke(ActionButton actionButton_1)
	{
		actionButton_1.PreviewMouseUp += Lf8LQhQWcMg;
		actionButton_1.PreviewMouseMove += LvKLQ9p1M40;
		actionButton_1.Drop += PfZLQZy8vGw;
		actionButton_1.PreviewMouseWheel += CZMLQcd8C7B;
		actionButton_1.AllowDrop = true;
		actionButton_1.PreviewMouseDown += HldLQVGw0Q2;
		if (actionButton_1.ActionItem != null)
		{
			actionButton_1.IsSelected = !actionButton_1.IsSelected;
		}
	}

	internal static bool INjuJ1FbB2nLWdPMZowR()
	{
		return C1CboRFbKNrGptvUfXeg == null;
	}

	internal static void Q7pEFaFbO2FkNGF2d5Ed()
	{
	}
}
