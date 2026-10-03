using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class CircleActionMenu : UserControl, IComponentConnector
{
	private int vNuLpfk6nuw = 8;

	private int JKxLpzkewXu = 8;

	private int Xo3LBwJfT0Q = 8;

	private IList<RadialMenuItem> OVwLBtlpcq6 = new List<RadialMenuItem>(8);

	private IList<RadialMenuItem> zEMLBgqdlxb = new List<RadialMenuItem>(8);

	private IList<RadialMenuItem> tNlLBLGXZhP = new List<RadialMenuItem>(8);

	public static readonly DependencyProperty ShowIndicatorLineProperty;

	public static readonly DependencyProperty AllowDragItemProperty;

	[CompilerGenerated]
	private EventHandler<CircleMenuEventArgs> m_ActionSelected;

	[CompilerGenerated]
	private EventHandler<CircleMenuItemDropEventArgs> m_DropOnItem;

	[CompilerGenerated]
	private EventHandler<CircleMenuEventArgs> m_ItemRightClick;

	[CompilerGenerated]
	private EventHandler<CircleMenuEventArgs> m_ItemLeftClick;

	[CompilerGenerated]
	private EventHandler<CircleMenuEventArgs> urOLBvlHDy0;

	private System.Windows.Point C8wLBSmh2fL;

	private bool w43LB2OvpyL;

	private bool? y1CLBuaJDgA;

	internal CircleActionMenu TheControl;

	internal Grid Canvas;

	internal Ellipse EllipseBg;

	internal Ellipse EllipseBgOverlay;

	internal Line TheLine;

	private bool zT5LBN1dpjW;

	internal static CircleActionMenu aLkmiVFfnG1FbkiLW7CG;

	public int Circle1ActionCount => OVwLBtlpcq6.Count;

	public int Circle2ActionCount => zEMLBgqdlxb.Count;

	public int Circle3ActionCount => tNlLBLGXZhP.Count;

	public bool ShowIndicatorLine
	{
		get
		{
			return (bool)GetValue(ShowIndicatorLineProperty);
		}
		set
		{
			SetValue(ShowIndicatorLineProperty, value);
		}
	}

	public bool AllowDragItem
	{
		get
		{
			return (bool)GetValue(AllowDragItemProperty);
		}
		set
		{
			SetValue(AllowDragItemProperty, value);
		}
	}

	public System.Windows.Media.Brush IndicateLineBrush
	{
		get
		{
			return TheLine.Stroke;
		}
		set
		{
			TheLine.Stroke = value;
		}
	}

	public double BgOpacity
	{
		get
		{
			return EllipseBg.Opacity;
		}
		set
		{
			EllipseBg.Opacity = value;
		}
	}

	public System.Windows.Media.Brush BgFill
	{
		get
		{
			return EllipseBg.Fill;
		}
		set
		{
			EllipseBg.Fill = value;
		}
	}

	public double BgOverlayOpacity
	{
		get
		{
			return EllipseBgOverlay.Opacity;
		}
		set
		{
			EllipseBgOverlay.Opacity = value;
		}
	}

	public System.Windows.Media.Brush BgOverlayFill
	{
		get
		{
			return EllipseBgOverlay.Fill;
		}
		set
		{
			EllipseBgOverlay.Fill = value;
		}
	}

	public event EventHandler<CircleMenuEventArgs> ActionSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ActionSelected;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ActionSelected;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CircleMenuItemDropEventArgs> DropOnItem
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CircleMenuItemDropEventArgs> eventHandler = this.m_DropOnItem;
			EventHandler<CircleMenuItemDropEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuItemDropEventArgs> value2 = (EventHandler<CircleMenuItemDropEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DropOnItem, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CircleMenuItemDropEventArgs> eventHandler = this.m_DropOnItem;
			EventHandler<CircleMenuItemDropEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuItemDropEventArgs> value2 = (EventHandler<CircleMenuItemDropEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DropOnItem, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CircleMenuEventArgs> ItemRightClick
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ItemRightClick;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemRightClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ItemRightClick;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemRightClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CircleMenuEventArgs> ItemLeftClick
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ItemLeftClick;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemLeftClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CircleMenuEventArgs> eventHandler = this.m_ItemLeftClick;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemLeftClick, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CircleMenuEventArgs> ItemDoubleClick
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CircleMenuEventArgs> eventHandler = urOLBvlHDy0;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref urOLBvlHDy0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CircleMenuEventArgs> eventHandler = urOLBvlHDy0;
			EventHandler<CircleMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CircleMenuEventArgs> value2 = (EventHandler<CircleMenuEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref urOLBvlHDy0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CircleActionMenu()
	{
		JKxLpzkewXu = AppState.HHxtaMaoqJr()?.CirclemMenuCircle2ActionCount ?? 8;
		InitializeComponent();
		SGCLpd1HKsg();
		xv0Lp5ao43s();
	}

	private void xv0Lp5ao43s()
	{
		SetValue(ActionButton.ButtonColorProperty, System.Windows.Media.Brushes.Transparent);
		SetValue(ActionButton.HoverColorProperty, System.Windows.Media.Brushes.Transparent);
		SetValue(ActionButton.InvalidButtonColorProperty, System.Windows.Media.Brushes.Transparent);
		SetValue(ActionButton.ShrinkTitleProperty, true);
	}

	private void XivLpD719pv(int int_3, bool bool_2, IList<RadialMenuItem> ilist_3, double double_0, double double_1, double double_2, int int_4, double double_3 = 1.0)
	{
		for (int i = 0; i < int_3; i++)
		{
			RadialMenuItem radialMenuItem = new RadialMenuItem
			{
				Index = i,
				Count = int_3,
				HalfShifted = bool_2,
				Content = new ActionButton(false)
				{
					Width = 64.0,
					Height = 64.0,
					FocusVisualStyle = null,
					Focusable = false
				},
				InnerRadius = double_0,
				OuterRadius = double_1,
				ContentRadius = double_2,
				Tag = i + int_4,
				Focusable = false,
				FocusVisualStyle = null,
				BorderThickness = new Thickness(double_3)
			};
			edTLpoSFR6W(radialMenuItem);
			ilist_3.Add(radialMenuItem);
			Canvas.Children.Add(radialMenuItem);
		}
	}

	private void SGCLpd1HKsg()
	{
		int count = OVwLBtlpcq6.Count;
		XivLpD719pv(vNuLpfk6nuw, true, OVwLBtlpcq6, 25.0, 120.0, 82.5, 0);
		XivLpD719pv(JKxLpzkewXu, JKxLpzkewXu == 8, zEMLBgqdlxb, 120.0, 210.0, 165.0, 100);
		XivLpD719pv(Xo3LBwJfT0Q, true, tNlLBLGXZhP, 210.0, 300.0, 260.0, 200, 0.3);
	}

	public void UpdateButtonCount(int circle2Count)
	{
		if (JKxLpzkewXu == circle2Count)
		{
			return;
		}
		foreach (RadialMenuItem item in zEMLBgqdlxb)
		{
			Canvas.Children.Remove(item);
		}
		zEMLBgqdlxb.Clear();
		JKxLpzkewXu = AppState.HHxtaMaoqJr()?.CirclemMenuCircle2ActionCount ?? 8;
		XivLpD719pv(JKxLpzkewXu, JKxLpzkewXu == 8, zEMLBgqdlxb, 120.0, 210.0, 165.0, 100);
	}

	private void edTLpoSFR6W(RadialMenuItem radialMenuItem_0)
	{
		radialMenuItem_0.PreviewMouseDown += uqHLpTH7i6E;
		radialMenuItem_0.PreviewMouseLeftButtonUp += Pe3LpFDg7hP;
		radialMenuItem_0.PreviewMouseRightButtonDown += Aj1LpAaMtje;
		radialMenuItem_0.AllowDrop = true;
		radialMenuItem_0.Drop += pcgLpOukZZg;
		radialMenuItem_0.PreviewMouseMove += BJmLpMdAw0k;
	}

	private void uqHLpTH7i6E(object sender, MouseButtonEventArgs e)
	{
		C8wLBSmh2fL = e.GetPosition(this);
	}

	private void BJmLpMdAw0k(object sender, MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (w43LB2OvpyL || !AllowDragItem)
		{
			return;
		}
		System.Windows.Point position = e.GetPosition(this);
		Vector vector = C8wLBSmh2fL - position;
		if (e.LeftButton != MouseButtonState.Pressed || (!(Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance) && !(Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance)))
		{
			return;
		}
		RadialMenuItem radialMenuItem = sender as RadialMenuItem;
		int num = 0;
		if (aLkmiVFfnG1FbkiLW7CG != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (radialMenuItem == null || (radialMenuItem.Content as ActionButton)?.ActionItem == null)
		{
			return;
		}
		DataObject dataObject = new DataObject();
		dataObject.SetData("circle_menu_drag_item", radialMenuItem);
		try
		{
			w43LB2OvpyL = true;
			AppHelper.DoDragDropWrap(this, dataObject, DragDropEffects.Copy | DragDropEffects.Move);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法开始拖动：" + ex.Message);
		}
		finally
		{
			w43LB2OvpyL = false;
		}
	}

	private void Aj1LpAaMtje(object sender, MouseButtonEventArgs e)
	{
		int position = (int)(sender as RadialMenuItem).Tag;
		this.m_ItemRightClick?.Invoke(sender, new CircleMenuEventArgs
		{
			Action = ((sender as RadialMenuItem).Content as ActionButton).ActionItem,
			Position = position
		});
	}

	private void pcgLpOukZZg(object sender, DragEventArgs e)
	{
		int position = (int)(sender as RadialMenuItem).Tag;
		this.m_DropOnItem?.Invoke(sender, new CircleMenuItemDropEventArgs
		{
			Position = position,
			OriginEventArgs = e
		});
	}

	private void Pe3LpFDg7hP(object sender, MouseButtonEventArgs e)
	{
		int position = (int)(sender as RadialMenuItem).Tag;
		this.m_ActionSelected?.Invoke(this, new CircleMenuEventArgs
		{
			Action = ((sender as RadialMenuItem).Content as ActionButton).ActionItem,
			Position = position
		});
		if (e.ChangedButton != MouseButton.Left)
		{
			return;
		}
		if (e.ClickCount == 2)
		{
			EventHandler<CircleMenuEventArgs> eventHandler = urOLBvlHDy0;
			if (eventHandler == null)
			{
				if (aLkmiVFfnG1FbkiLW7CG != null)
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				eventHandler(this, new CircleMenuEventArgs
				{
					Action = ((sender as RadialMenuItem).Content as ActionButton).ActionItem,
					Position = position
				});
			}
		}
		else
		{
			this.m_ItemLeftClick?.Invoke(this, new CircleMenuEventArgs
			{
				Action = ((sender as RadialMenuItem).Content as ActionButton).ActionItem,
				Position = position
			});
		}
	}

	public void SetPosition(int position, ActionItem action)
	{
		RadialMenuItem radialMenuItem = bofLpUAsjKB(position);
		if (radialMenuItem != null)
		{
			(radialMenuItem.Content as ActionButton).SetAction(action);
		}
	}

	public void SetPositionColor(int position, SolidColorBrush color)
	{
		RadialMenuItem radialMenuItem = bofLpUAsjKB(position);
		if (radialMenuItem != null)
		{
			if (color == null)
			{
				radialMenuItem.ClearValue(Control.BackgroundProperty);
			}
			else
			{
				radialMenuItem.Background = color;
			}
		}
	}

	private RadialMenuItem bofLpUAsjKB(int int_3)
	{
		if (int_3 < 100)
		{
			return thILp3FkOI4(OVwLBtlpcq6, int_3);
		}
		if (int_3 < 200)
		{
			return thILp3FkOI4(zEMLBgqdlxb, int_3 - 100);
		}
		return thILp3FkOI4(tNlLBLGXZhP, int_3 - 200);
	}

	public ActionItem GetItemAction(int position)
	{
		return (bofLpUAsjKB(position).Content as ActionButton).ActionItem;
	}

	public ActionItem GetItemAction(RadialMenuItem menuItem)
	{
		return (menuItem.Content as ActionButton).ActionItem;
	}

	public void SetPositionEnabled(int position, bool isEnabled)
	{
		bofLpUAsjKB(position).IsEnabled = isEnabled;
	}

	private void JYiLplDTrqX(object sender, MouseEventArgs e)
	{
	}

	public void OnMouseMoveAboveWindow(System.Windows.Point pt)
	{
		System.Windows.Point point_ = PointFromScreen(pt);
		DljLpiKcs1H(point_);
	}

	private void DljLpiKcs1H(System.Windows.Point point_1)
	{
		double num = base.Width / 2.0;
		double num2 = base.Height / 2.0;
		double num3 = Math.Sqrt((point_1.X - num) * (point_1.X - num) + (point_1.Y - num2) * (point_1.Y - num2));
		double num4 = Math.Abs((num3 < OVwLBtlpcq6[0].OuterRadius) ? (num3 - (OVwLBtlpcq6[0].OuterRadius + OVwLBtlpcq6[0].InnerRadius) / 2.0) : (num3 - (zEMLBgqdlxb[0].OuterRadius + zEMLBgqdlxb[0].InnerRadius) / 2.0));
		double num5 = Math.Abs(Math.Abs((Math.Atan2(point_1.Y - num2, point_1.X - num) / Math.PI * 180.0 - 22.5) % 45.0) - 22.5);
		int num6 = 1;
		double num7 = default(double);
		if (D2suhJFfe4AKfrUr2ttx())
		{
			int num8 = default(int);
			while (true)
			{
				switch (num6)
				{
				case 1:
					break;
				default:
					goto end_IL_01f5;
				}
				TheLine.Opacity = (1.0 - num5 / 22.5) * Math.Max(0.0, 1.0 - num4 / 40.0) + 0.1;
				if (AppState.HHxtaMaoqJr().CircleMenuHideLabelIfHaveIcon && AppState.HHxtaMaoqJr().CircleMenuShowLabelInCenterWhenHideLabel)
				{
					System.Windows.Point point = point_1;
					if (num3 >= OVwLBtlpcq6[0].InnerRadius)
					{
						num7 = Math.Atan2(point.Y - num2, point.X - num);
						num6 = 0;
						if (aLkmiVFfnG1FbkiLW7CG != null)
						{
							num6 = num8;
						}
						continue;
					}
					goto IL_0252;
				}
				goto IL_0268;
				continue;
				end_IL_01f5:
				break;
			}
		}
		TheLine.X1 = num + OVwLBtlpcq6[0].InnerRadius * Math.Cos(num7);
		TheLine.Y1 = num2 + OVwLBtlpcq6[0].InnerRadius * Math.Sin(num7);
		goto IL_0282;
		IL_0268:
		TheLine.X1 = num;
		TheLine.Y1 = num2;
		goto IL_0282;
		IL_0282:
		TheLine.X2 = point_1.X;
		TheLine.Y2 = point_1.Y;
		return;
		IL_0252:
		TheLine.Opacity = 0.0;
		goto IL_0282;
	}

	public void Clear()
	{
		foreach (RadialMenuItem item in OVwLBtlpcq6)
		{
			(item.Content as ActionButton).ActionItem = null;
		}
		foreach (RadialMenuItem item2 in zEMLBgqdlxb)
		{
			(item2.Content as ActionButton).ActionItem = null;
		}
		foreach (RadialMenuItem item3 in tNlLBLGXZhP)
		{
			(item3.Content as ActionButton).ActionItem = null;
		}
	}

	public void DisableExternItems()
	{
		foreach (RadialMenuItem item in tNlLBLGXZhP)
		{
			item.IsEnabled = false;
		}
	}

	public void DisableItem(int position)
	{
		RadialMenuItem radialMenuItem = bofLpUAsjKB(position);
		if (radialMenuItem != null)
		{
			radialMenuItem.IsEnabled = false;
		}
	}

	public void SetExternItemsVisibility(bool show)
	{
		if (show == y1CLBuaJDgA)
		{
			return;
		}
		y1CLBuaJDgA = show;
		if (show && tNlLBLGXZhP[0].Visibility == Visibility.Collapsed)
		{
			int num = 0;
			if (!D2suhJFfe4AKfrUr2ttx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			{
				foreach (RadialMenuItem item in tNlLBLGXZhP)
				{
					item.Visibility = Visibility.Visible;
				}
				return;
			}
		}
		if (show || tNlLBLGXZhP[0].Visibility != Visibility.Visible)
		{
			return;
		}
		foreach (RadialMenuItem item2 in tNlLBLGXZhP)
		{
			item2.Visibility = Visibility.Collapsed;
		}
	}

	public void SetExternCircleOpacity(double opacity)
	{
		foreach (RadialMenuItem item in tNlLBLGXZhP)
		{
			item.Opacity = opacity;
		}
	}

	public void OnMouseMoveOutsideWindow(double angle)
	{
		if (!base.IsVisible || base.IsMouseOver)
		{
			return;
		}
		double num = base.Width / 2.0;
		double num2 = base.Height / 2.0;
		double outerRadius = zEMLBgqdlxb[0].OuterRadius;
		double innerRadius = OVwLBtlpcq6[0].InnerRadius;
		TheLine.X2 = num + outerRadius * Math.Cos(angle);
		TheLine.Y2 = num2 + outerRadius * Math.Sin(angle);
		TheLine.X1 = num + innerRadius * Math.Cos(angle);
		if (!D2suhJFfe4AKfrUr2ttx())
		{
			switch (0)
			{
			}
		}
		TheLine.Y1 = num2 + innerRadius * Math.Sin(angle);
		TheLine.Opacity = 0.3;
	}

	public ActionItem GetMouseOverAction(System.Drawing.Point pt)
	{
		System.Windows.Point screenPoint = new System.Windows.Point(pt.X, pt.Y);
		foreach (RadialMenuItem item in OVwLBtlpcq6)
		{
			if (UIHelper.IsMouseOverElement(item, screenPoint))
			{
				return GetItemAction(item);
			}
		}
		foreach (RadialMenuItem item2 in zEMLBgqdlxb)
		{
			if (UIHelper.IsMouseOverElement(item2, screenPoint))
			{
				return GetItemAction(item2);
			}
		}
		return null;
	}

	public void ResetLine()
	{
		TheLine.X2 = TheLine.X1;
		TheLine.Y2 = TheLine.Y1;
		TheLine.Opacity = 0.0;
		TheLine.InvalidateVisual();
		TheLine.UpdateLayout();
		UpdateLayout();
		InvalidateVisual();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!zT5LBN1dpjW)
		{
			zT5LBN1dpjW = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/circlemenu/circleactionmenu.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			TheControl = (CircleActionMenu)target;
			TheControl.PreviewMouseMove += JYiLplDTrqX;
			return;
		case 2:
			Canvas = (Grid)target;
			return;
		case 3:
			EllipseBg = (Ellipse)target;
			return;
		case 4:
			EllipseBgOverlay = (Ellipse)target;
			return;
		case 5:
			TheLine = (Line)target;
			return;
		}
		zT5LBN1dpjW = true;
		if (!D2suhJFfe4AKfrUr2ttx())
		{
			switch (0)
			{
			}
		}
	}

	static CircleActionMenu()
	{
		ShowIndicatorLineProperty = DependencyProperty.Register("ShowIndicatorLine", typeof(bool), typeof(CircleActionMenu), new PropertyMetadata(true));
		AllowDragItemProperty = DependencyProperty.Register("AllowDragItem", typeof(bool), typeof(CircleActionMenu), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	internal static RadialMenuItem thILp3FkOI4(IList<RadialMenuItem> ilist_3, int int_3)
	{
		if (int_3 >= ilist_3.Count)
		{
			return null;
		}
		return ilist_3[int_3];
	}

	internal static bool D2suhJFfe4AKfrUr2ttx()
	{
		return aLkmiVFfnG1FbkiLW7CG == null;
	}

	internal static void u8UBqaFfrvWFBepgx1yU()
	{
	}
}
