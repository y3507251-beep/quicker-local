using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using log4net;
using Quicker.Common;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.ProfileManagement;

namespace Quicker.View.Controls;

public class ProfilePageControl : Canvas
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public int CCJSlz3gbEd;

		public int NTbSiw6DJkk;

		internal static _003C_003Ec__DisplayClass39_0 Y4bRAxyWYUCPUkjSQd5U;

		internal bool EXGSlfEwI5B(ActionItem x)
		{
			if (x.Row == CCJSlz3gbEd)
			{
				return x.Col == NTbSiw6DJkk;
			}
			return false;
		}

		internal static bool FY90AlyW8QrNvaEYfJDE()
		{
			return Y4bRAxyWYUCPUkjSQd5U == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public int jQVSituoNZK;

		private static _003C_003Ec__DisplayClass42_0 wftgRfyWg19PTCeEoaWK;

		internal static bool TQ9QuEyWP5akSyqbHQVR()
		{
			return wftgRfyWg19PTCeEoaWK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_1
	{
		public int OveSiLR5dxx;

		public _003C_003Ec__DisplayClass42_0 TvTSivsiXG8;

		private static _003C_003Ec__DisplayClass42_1 WZBhGwyWUlj7ETKMg9cW;

		internal bool U0GSigL4XCq(ActionItem x)
		{
			if (x.Row == TvTSivsiXG8.jQVSituoNZK)
			{
				return x.Col == OveSiLR5dxx;
			}
			return false;
		}

		internal static void A2NC4xyW6dELcVJ1G2y7()
		{
		}

		internal static bool mqQDfeyWx2FmwRPUvSPJ()
		{
			return WZBhGwyWUlj7ETKMg9cW == null;
		}
	}

	private double qF0Lxr4fTCv = 60.0;

	private double I9ALxprMaRa = 1.0;

	private int UybLxBFTU0B = 4;

	private int ViHLxQXSoVb = 4;

	[CompilerGenerated]
	private ActionDroppedEventHandler m_ActionDropped;

	[CompilerGenerated]
	private ButtonClickedEventHandler m_ActionButtonClicked;

	[CompilerGenerated]
	private ButtonWheelEventHandler M7CLxjQegKP;

	[CompilerGenerated]
	private EventHandler<ActionButtonEventArgs<MouseButtonEventArgs>> m_ActionDoubleClicked;

	[CompilerGenerated]
	private bool VM4LxnMQSVC = true;

	public static readonly DependencyProperty ActionProfileProperty;

	private readonly IDictionary<int, ActionButton> ttwLx4sauEL = new Dictionary<int, ActionButton>();

	private Point G62Lx5HjDSF;

	private ActionButton BWJLxDfdpDj;

	private bool KaRLxdDwUn8;

	private static readonly ILog qGhLxoPP88J;

	private static ProfilePageControl k9PwQIFuzrM69oFarhei;

	public bool EnableDragAction
	{
		[CompilerGenerated]
		get
		{
			return VM4LxnMQSVC;
		}
		[CompilerGenerated]
		set
		{
			VM4LxnMQSVC = value;
		}
	}

	public Brush GridBgColor
	{
		get
		{
			return base.Background;
		}
		set
		{
			base.Background = value;
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
			ButtonWheelEventHandler buttonWheelEventHandler = M7CLxjQegKP;
			ButtonWheelEventHandler buttonWheelEventHandler2;
			do
			{
				buttonWheelEventHandler2 = buttonWheelEventHandler;
				ButtonWheelEventHandler value2 = (ButtonWheelEventHandler)Delegate.Combine(buttonWheelEventHandler2, value);
				buttonWheelEventHandler = Interlocked.CompareExchange(ref M7CLxjQegKP, value2, buttonWheelEventHandler2);
			}
			while ((object)buttonWheelEventHandler != buttonWheelEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ButtonWheelEventHandler buttonWheelEventHandler = M7CLxjQegKP;
			ButtonWheelEventHandler buttonWheelEventHandler2;
			do
			{
				buttonWheelEventHandler2 = buttonWheelEventHandler;
				ButtonWheelEventHandler value2 = (ButtonWheelEventHandler)Delegate.Remove(buttonWheelEventHandler2, value);
				buttonWheelEventHandler = Interlocked.CompareExchange(ref M7CLxjQegKP, value2, buttonWheelEventHandler2);
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

	public ProfilePageControl()
		: this(60.0, 4)
	{
	}

	public ProfilePageControl(double buttonSize, int rowCount)
	{
		qF0Lxr4fTCv = buttonSize;
		UybLxBFTU0B = 4;
		o6jLx16yf2K();
	}

	public void UpdateButtonSize(double buttonSize, double space)
	{
		qF0Lxr4fTCv = buttonSize;
		I9ALxprMaRa = space;
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				int buttonIndex = AppHelper.GetButtonIndex(false, i, j);
				ActionButton actionButton = ttwLx4sauEL[buttonIndex];
				actionButton.Height = buttonSize;
				actionButton.Width = buttonSize;
				Canvas.SetLeft(actionButton, (double)j * (buttonSize + I9ALxprMaRa) + I9ALxprMaRa);
				Canvas.SetTop(actionButton, (double)i * (buttonSize + I9ALxprMaRa) + I9ALxprMaRa);
				if (muMCCUFoVauwnOH4weS7())
				{
					switch (0)
					{
					}
				}
			}
		}
	}

	private static void lxWLxHR6dGB(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is ProfilePageControl)
		{
			((ProfilePageControl)dependencyObject_0).RefreshUi();
		}
	}

	private void o6jLx16yf2K()
	{
		AppHelper.CreateButtonsOnCanvas(this, 4, 4, false, qF0Lxr4fTCv, I9ALxprMaRa, ttwLx4sauEL, 0.0, QEuLxx4PTKk);
	}

	private void EJHLxbcr3fs(object sender, MouseWheelEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		if (actionButton.ActionItem != null)
		{
			int buttonIndex = (int)actionButton.Tag;
			(bool isGlobal, int row, int column) buttonLocation = AppHelper.GetButtonLocation(buttonIndex);
			int item = buttonLocation.row;
			int item2 = buttonLocation.column;
			M7CLxjQegKP?.Invoke(sender, new ActionButtonEventArgs<MouseWheelEventArgs>
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

	private void Oe2Lx6ticXr(object sender, MouseButtonEventArgs e)
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
			BWJLxDfdpDj = sender as ActionButton;
			G62Lx5HjDSF = e.GetPosition(this);
			int num = 0;
			if (k9PwQIFuzrM69oFarhei != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void icBLxX98lEY(object sender, DragEventArgs e)
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

	private void RlFLxmJbfun(object sender, MouseEventArgs e)
	{
		ActionButton actionButton = (ActionButton)sender;
		if (actionButton != BWJLxDfdpDj || actionButton.IsSelected || !EnableDragAction || e.LeftButton != MouseButtonState.Pressed || KaRLxdDwUn8)
		{
			return;
		}
		try
		{
			KaRLxdDwUn8 = true;
			Point position = e.GetPosition(this);
			if (!(Math.Abs(position.X - G62Lx5HjDSF.X) > 14.0) && !(Math.Abs(position.Y - G62Lx5HjDSF.Y) > 14.0))
			{
				return;
			}
			_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
			int num = 0;
			if (!muMCCUFoVauwnOH4weS7())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			(bool, int, int) buttonLocation = AppHelper.GetButtonLocation((int)actionButton.Tag);
			_003C_003Ec__DisplayClass39_.CCJSlz3gbEd = buttonLocation.Item2;
			_003C_003Ec__DisplayClass39_.NTbSiw6DJkk = buttonLocation.Item3;
			ActionItem actionItem = ActionProfile.ActionItems.FirstOrDefault(_003C_003Ec__DisplayClass39_.EXGSlfEwI5B);
			if (actionItem != null)
			{
				DataObject data = new DataObject("quicker-action-drag-item", new ActionItemDragObject(ActionProfile.Id, actionItem, _003C_003Ec__DisplayClass39_.CCJSlz3gbEd, _003C_003Ec__DisplayClass39_.NTbSiw6DJkk));
				try
				{
					AppHelper.DoDragDropWrap(actionButton, data, DragDropEffects.Copy | DragDropEffects.Move);
					return;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法启动拖动：" + ex.Message);
					return;
				}
			}
		}
		finally
		{
			KaRLxdDwUn8 = false;
		}
	}

	private void IXZLxK7Gnx9(object sender, MouseButtonEventArgs e)
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
		foreach (ActionButton value in ttwLx4sauEL.Values)
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
		Height = isGlobal ? qF0Lxr4fTCv * 3 + 4 * I9ALxprMaRa : qF0Lxr4fTCv * 4 + 5 * I9ALxprMaRa;
		for (int row = 0; row < 4; row++)
		{
			for (int col = 0; col < 4; col++)
			{
				var button = ttwLx4sauEL[AppHelper.GetButtonIndex(false, row, col)];
				var action = profile?.ActionItems?.FirstOrDefault(item => item.Row == row && item.Col == col);
				button.Visibility = isGlobal && row == 3 ? Visibility.Collapsed : Visibility.Visible;
				button.ActionItem = action;
				button.ShowKeyTip = false;
				button.KeyTip = "";
			}
		}
	}

	protected override Size MeasureOverride(Size constraint)
	{
		base.MeasureOverride(constraint);
		double width = qF0Lxr4fTCv * (double)ViHLxQXSoVb + (double)(ViHLxQXSoVb + 1) * I9ALxprMaRa;
		double height = qF0Lxr4fTCv * (double)UybLxBFTU0B + (double)(UybLxBFTU0B + 1) * I9ALxprMaRa;
		return new Size(width, height);
	}

	static ProfilePageControl()
	{
		ActionProfileProperty = DependencyProperty.Register("ActionProfile", typeof(ActionProfile), typeof(ProfilePageControl), new PropertyMetadata(null, lxWLxHR6dGB));
		qGhLxoPP88J = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void QEuLxx4PTKk(ActionButton actionButton_1)
	{
		actionButton_1.PreviewMouseUp += IXZLxK7Gnx9;
		actionButton_1.PreviewMouseMove += RlFLxmJbfun;
		actionButton_1.Drop += icBLxX98lEY;
		actionButton_1.PreviewMouseWheel += EJHLxbcr3fs;
		actionButton_1.AllowDrop = true;
		actionButton_1.PreviewMouseDown += Oe2Lx6ticXr;
		if (actionButton_1.ActionItem != null)
		{
			actionButton_1.IsSelected = !actionButton_1.IsSelected;
		}
	}

	internal static bool muMCCUFoVauwnOH4weS7()
	{
		return k9PwQIFuzrM69oFarhei == null;
	}
}
