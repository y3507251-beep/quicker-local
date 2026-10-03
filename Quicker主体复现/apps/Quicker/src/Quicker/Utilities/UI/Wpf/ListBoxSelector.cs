using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using SWBMfZYGyc6L9yHIvKQ;

namespace Quicker.Utilities.UI.Wpf;

public sealed class ListBoxSelector
{
	private sealed class CWrRQRHDW7n9sxwi6I8
	{
		private readonly DispatcherTimer dPo2ysIbFeU = new DispatcherTimer();

		private readonly ItemsControl Obd2yHfcOQf;

		private readonly ScrollViewer SQe2y1bdL06;

		private readonly ScrollContentPresenter Jac2ybXytJX;

		private bool Ocm2y6qvmgy;

		private Point Ek42yX9vUNe;

		private Point i9U2ymhZLon;

		[CompilerGenerated]
		private EventHandler<JRUT36Hkv9ej6eyK7AQ> xE02yK4cE78;

		internal static CWrRQRHDW7n9sxwi6I8 aCYaqyykOEjfdbuASK7j;

		public bool IsEnabled
		{
			get
			{
				return Ocm2y6qvmgy;
			}
			set
			{
				if (Ocm2y6qvmgy != value)
				{
					Ocm2y6qvmgy = value;
					dPo2ysIbFeU.IsEnabled = false;
					Ek42yX9vUNe = default(Point);
				}
			}
		}

		public CWrRQRHDW7n9sxwi6I8(ItemsControl itemsControl_1)
		{
			if (itemsControl_1 == null)
			{
				throw new ArgumentNullException("itemsControl");
			}
			Obd2yHfcOQf = itemsControl_1;
			SQe2y1bdL06 = UIHelper.FindChild<ScrollViewer>(itemsControl_1);
			SQe2y1bdL06.ScrollChanged += U1Y2y9fRoM1;
			Jac2ybXytJX = UIHelper.FindChild<ScrollContentPresenter>(SQe2y1bdL06);
			dPo2ysIbFeU.Tick += q8V2yenJ0ZQ;
			dPo2ysIbFeU.Interval = TimeSpan.FromMilliseconds(l252yVHF2BW());
		}

		[SpecialName]
		[CompilerGenerated]
		public void F0Y2yWinXjJ(EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler_1)
		{
			EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler = xE02yK4cE78;
			EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<JRUT36Hkv9ej6eyK7AQ> value = (EventHandler<JRUT36Hkv9ej6eyK7AQ>)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange(ref xE02yK4cE78, value, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void Drk2ykP1wIo(EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler_1)
		{
			EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler = xE02yK4cE78;
			EventHandler<JRUT36Hkv9ej6eyK7AQ> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<JRUT36Hkv9ej6eyK7AQ> value = (EventHandler<JRUT36Hkv9ej6eyK7AQ>)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange(ref xE02yK4cE78, value, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}

		public Point zDK2yRRjW7X(Point point_2)
		{
			return new Point(point_2.X - Ek42yX9vUNe.X, point_2.Y - Ek42yX9vUNe.Y);
		}

		public void D3I2yqnCxIb()
		{
			SQe2y1bdL06.ScrollChanged -= U1Y2y9fRoM1;
		}

		public void j0l2yc9bPHk(Point point_2)
		{
			i9U2ymhZLon = point_2;
			if (!dPo2ysIbFeU.IsEnabled)
			{
				ccW2yhTwfq9();
			}
		}

		private static int l252yVHF2BW()
		{
			return 400 - (int)((double)SystemParameters.KeyboardSpeed * 11.838709677419354);
		}

		private double Kjn2yZ8mduH(int int_0, int int_1)
		{
			double num = 0.0;
			for (int i = int_0; i != int_1; i++)
			{
				if (Obd2yHfcOQf.ItemContainerGenerator.ContainerFromIndex(i) is FrameworkElement frameworkElement)
				{
					num += frameworkElement.ActualHeight;
					num += frameworkElement.Margin.Top + frameworkElement.Margin.Bottom;
				}
			}
			return num;
		}

		private void U1Y2y9fRoM1(object sender, ScrollChangedEventArgs e)
		{
			double horizontalChange = default(double);
			while (IsEnabled)
			{
				int num = 1;
				if (aCYaqyykOEjfdbuASK7j != null)
				{
					goto IL_0010;
				}
				goto IL_004b;
				IL_00b5:
				Ek42yX9vUNe.X += horizontalChange;
				double num2;
				Ek42yX9vUNe.Y += num2;
				xE02yK4cE78?.Invoke(this, new JRUT36Hkv9ej6eyK7AQ(horizontalChange, num2));
				break;
				IL_004b:
				switch (num)
				{
				case 1:
					break;
				case 2:
					continue;
				default:
					goto IL_006c;
				}
				goto IL_0010;
				IL_0010:
				horizontalChange = e.HorizontalChange;
				num2 = e.VerticalChange;
				if (SQe2y1bdL06.CanContentScroll)
				{
					if (e.VerticalChange < 0.0)
					{
						num = 0;
						if (!cRm12fykJd8KsOQfyjBb())
						{
							goto IL_004b;
						}
						goto IL_006c;
					}
					int int_ = (int)(e.VerticalOffset - e.VerticalChange);
					int int_2 = (int)e.VerticalOffset;
					num2 = Kjn2yZ8mduH(int_, int_2);
				}
				goto IL_00b5;
				IL_006c:
				int int_3 = (int)e.VerticalOffset;
				int int_4 = (int)(e.VerticalOffset - e.VerticalChange);
				num2 = 0.0 - Kjn2yZ8mduH(int_3, int_4);
				goto IL_00b5;
			}
		}

		private void ccW2yhTwfq9()
		{
			bool isEnabled = false;
			if (i9U2ymhZLon.X > Jac2ybXytJX.ActualWidth)
			{
				SQe2y1bdL06.LineRight();
				isEnabled = true;
			}
			else if (i9U2ymhZLon.X < 0.0)
			{
				SQe2y1bdL06.LineLeft();
				isEnabled = true;
			}
			if (i9U2ymhZLon.Y > Jac2ybXytJX.ActualHeight)
			{
				SQe2y1bdL06.LineDown();
				isEnabled = true;
			}
			else if (i9U2ymhZLon.Y < 0.0)
			{
				SQe2y1bdL06.LineUp();
				if (aCYaqyykOEjfdbuASK7j != null)
				{
					switch (0)
					{
					}
				}
				isEnabled = true;
			}
			dPo2ysIbFeU.IsEnabled = isEnabled;
		}

		[CompilerGenerated]
		private void q8V2yenJ0ZQ(object sender, EventArgs e)
		{
			ccW2yhTwfq9();
		}

		static CWrRQRHDW7n9sxwi6I8()
		{
		}

		internal static bool cRm12fykJd8KsOQfyjBb()
		{
			return aCYaqyykOEjfdbuASK7j == null;
		}

		internal static void s01lyXykNYv3Hb4qlckf()
		{
		}
	}

	private sealed class v1PIMHHH2e1sN45DNGX
	{
		private readonly ItemsControl Y7f2yQGIcRB;

		private Rect p1L2yj8MgGM;

		internal static v1PIMHHH2e1sN45DNGX HCcy7Ayk9EZ3iW96YYT4;

		public v1PIMHHH2e1sN45DNGX(ItemsControl itemsControl_1)
		{
			if (itemsControl_1 == null)
			{
				throw new ArgumentNullException("itemsControl");
			}
			Y7f2yQGIcRB = itemsControl_1;
		}

		public void Reset()
		{
			p1L2yj8MgGM = default(Rect);
		}

		public void c142yxKclrt(double double_0, double double_1)
		{
			p1L2yj8MgGM.Offset(0.0 - double_0, 0.0 - double_1);
		}

		public void Mi22yrE9wlH(Rect rect_1, bool bool_0)
		{
			int num = 1;
			while (true)
			{
				if (!(rect_1.Width > SystemParameters.MinimumHorizontalDragDistance))
				{
					int num2 = 0;
					if (!AlSybnykLLPFPnpmjM7o())
					{
						num2 = num;
					}
					switch (num2)
					{
					case 1:
						continue;
					}
					if (!(rect_1.Height > SystemParameters.MinimumVerticalDragDistance))
					{
						break;
					}
				}
				for (int i = 0; i < Y7f2yQGIcRB.Items.Count; i++)
				{
					if (Y7f2yQGIcRB.ItemContainerGenerator.ContainerFromIndex(i) is FrameworkElement frameworkElement)
					{
						Point point = frameworkElement.TranslatePoint(new Point(0.0, 0.0), Y7f2yQGIcRB);
						Rect rect = new Rect(point.X, point.Y, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
						if (rect.IntersectsWith(rect_1))
						{
							Selector.SetIsSelected(frameworkElement, bool_0);
						}
						else if (rect.IntersectsWith(p1L2yj8MgGM))
						{
							Selector.SetIsSelected(frameworkElement, !bool_0);
						}
					}
				}
				break;
			}
			p1L2yj8MgGM = rect_1;
		}

		public bool? did2ypjxNmI(Point point_0)
		{
			int num = 0;
			FrameworkElement frameworkElement;
			while (true)
			{
				if (num < Y7f2yQGIcRB.Items.Count)
				{
					frameworkElement = Y7f2yQGIcRB.ItemContainerGenerator.ContainerFromIndex(num) as FrameworkElement;
					if (frameworkElement != null)
					{
						Point point = frameworkElement.TranslatePoint(new Point(0.0, 0.0), Y7f2yQGIcRB);
						if (new Rect(point.X, point.Y, frameworkElement.ActualWidth, frameworkElement.ActualHeight).Contains(point_0))
						{
							break;
						}
					}
					num++;
					continue;
				}
				return null;
			}
			return Selector.GetIsSelected(frameworkElement);
		}

		public void p6M2yBVwvaN(Point point_0, bool bool_0)
		{
			int num2 = default(int);
			for (int i = 0; i < Y7f2yQGIcRB.Items.Count; i++)
			{
				if (!(Y7f2yQGIcRB.ItemContainerGenerator.ContainerFromIndex(i) is FrameworkElement frameworkElement))
				{
					continue;
				}
				Point point = frameworkElement.TranslatePoint(new Point(0.0, 0.0), Y7f2yQGIcRB);
				int num = 0;
				if (!AlSybnykLLPFPnpmjM7o())
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (new Rect(point.X, point.Y, frameworkElement.ActualWidth, frameworkElement.ActualHeight).Contains(point_0))
				{
					Selector.SetIsSelected(frameworkElement, bool_0);
					return;
				}
			}
		}

		internal static bool AlSybnykLLPFPnpmjM7o()
		{
			return HCcy7Ayk9EZ3iW96YYT4 == null;
		}
	}

	private sealed class JRUT36Hkv9ej6eyK7AQ : EventArgs
	{
		private readonly double gFv2ydOqcjs;

		private readonly double dHH2yoyf9t5;

		private static JRUT36Hkv9ej6eyK7AQ yrrQJhykfLa0Y4V3JdmZ;

		internal JRUT36Hkv9ej6eyK7AQ(double double_2, double double_3)
		{
			gFv2ydOqcjs = double_2;
			dHH2yoyf9t5 = double_3;
		}

		[SpecialName]
		public double b4g2yny47G5()
		{
			return gFv2ydOqcjs;
		}

		[SpecialName]
		public double tNJ2y5OBYrD()
		{
			return dHH2yoyf9t5;
		}

		internal static bool PcaYTUykb3qJsOEJM1fI()
		{
			return yrrQJhykfLa0Y4V3JdmZ == null;
		}
	}

	private sealed class bB68e0Hhbc4ZUv2u2VZ : Adorner
	{
		private Rect VO32yFsEvfJ;

		internal static bB68e0Hhbc4ZUv2u2VZ XvkuKTykinUEXZLbjTMA;

		public bB68e0Hhbc4ZUv2u2VZ(UIElement uielement_0)
			: base(uielement_0)
		{
			base.IsHitTestVisible = false;
			base.IsEnabledChanged += IOB2yTZjncY;
		}

		[SpecialName]
		public Rect OR02yM5H4xy()
		{
			return VO32yFsEvfJ;
		}

		[SpecialName]
		public void sYT2yAlNY8H(Rect rect_1)
		{
			VO32yFsEvfJ = rect_1;
			InvalidateVisual();
		}

		protected override void OnRender(DrawingContext dc)
		{
			base.OnRender(dc);
			if (base.IsEnabled)
			{
				double[] guidelinesX = new double[2]
				{
					OR02yM5H4xy().Left + 0.5,
					OR02yM5H4xy().Right + 0.5
				};
				double[] guidelinesY = new double[2]
				{
					OR02yM5H4xy().Top + 0.5,
					OR02yM5H4xy().Bottom + 0.5
				};
				dc.PushGuidelineSet(new GuidelineSet(guidelinesX, guidelinesY));
				Brush brush = SystemColors.HighlightBrush.Clone();
				brush.Opacity = 0.4;
				dc.DrawRectangle(brush, new Pen(SystemColors.HighlightBrush, 1.0), OR02yM5H4xy());
			}
		}

		[CompilerGenerated]
		private void IOB2yTZjncY(object sender, DependencyPropertyChangedEventArgs e)
		{
			InvalidateVisual();
		}

		static bB68e0Hhbc4ZUv2u2VZ()
		{
		}

		internal static bool H7KoCKyklPKa2wIZ8UTu()
		{
			return XvkuKTykinUEXZLbjTMA == null;
		}

		internal static void Y0J3Ymyk5Ke6y3Caco6m()
		{
		}
	}

	public static readonly DependencyProperty EnabledProperty;

	private static readonly Dictionary<ListBox, ListBoxSelector> HhfvusnSx6I;

	private readonly ListBox zxuvuHcUnay;

	private ScrollContentPresenter Iqjvu1BTYyx;

	private bB68e0Hhbc4ZUv2u2VZ phevublcy6Y;

	private CWrRQRHDW7n9sxwi6I8 Qpkvu6JxqMO;

	private v1PIMHHH2e1sN45DNGX foXvuX5aJVO;

	private bool DUJvumpgP6G;

	private Point bhyvuKFGDBQ;

	private Point nYUvuxaLyrp;

	private bool? JmcvurDrpgx;

	private Point xvZvupvVrcf;

	internal static ListBoxSelector giVddiFzs73JQ2OI2kYF;

	private ListBoxSelector(ListBox listBox)
	{
		zxuvuHcUnay = listBox;
		if (zxuvuHcUnay.IsLoaded)
		{
			SFmvuqNa75l();
		}
		else
		{
			zxuvuHcUnay.Loaded += mUGvuVBnhg2;
		}
	}

	public static bool GetEnabled(DependencyObject obj)
	{
		return (bool)obj.GetValue(EnabledProperty);
	}

	public static void SetEnabled(DependencyObject obj, bool value)
	{
		obj.SetValue(EnabledProperty, value);
	}

	private static void U1NvuRXcCJj(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (!(dependencyObject_0 is ListBox listBox))
		{
			return;
		}
		ListBoxSelector value;
		if ((bool)dependencyPropertyChangedEventArgs_0.NewValue)
		{
			if (listBox.SelectionMode == SelectionMode.Single)
			{
				listBox.SelectionMode = SelectionMode.Extended;
			}
			HhfvusnSx6I.Add(listBox, new ListBoxSelector(listBox));
		}
		else if (HhfvusnSx6I.TryGetValue(listBox, out value))
		{
			HhfvusnSx6I.Remove(listBox);
			value.DQ6vuc4p2Cs();
		}
	}

	private bool SFmvuqNa75l()
	{
		int num = 1;
		while (true)
		{
			Iqjvu1BTYyx = UIHelper.FindChild<ScrollContentPresenter>(zxuvuHcUnay);
			int num2 = 0;
			if (!Y8X48kFzCgeCB0YtwWXy())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (Iqjvu1BTYyx != null)
			{
				Qpkvu6JxqMO = new CWrRQRHDW7n9sxwi6I8(zxuvuHcUnay);
				Qpkvu6JxqMO.F0Y2yWinXjJ(jycvuZZgLTF);
				phevublcy6Y = new bB68e0Hhbc4ZUv2u2VZ(Iqjvu1BTYyx);
				Iqjvu1BTYyx.AdornerLayer.Add(phevublcy6Y);
				foXvuX5aJVO = new v1PIMHHH2e1sN45DNGX(zxuvuHcUnay);
				zxuvuHcUnay.PreviewMouseLeftButtonDown += VMsvue54qy4;
				zxuvuHcUnay.MouseLeftButtonUp += KcCvu93ftbn;
				zxuvuHcUnay.MouseMove += lbcvuh34XVS;
			}
			return Iqjvu1BTYyx != null;
		}
	}

	private void DQ6vuc4p2Cs()
	{
		LAfvuWevkgv();
		zxuvuHcUnay.PreviewMouseLeftButtonDown -= VMsvue54qy4;
		zxuvuHcUnay.MouseLeftButtonUp -= KcCvu93ftbn;
		zxuvuHcUnay.MouseMove -= lbcvuh34XVS;
		Qpkvu6JxqMO.D3I2yqnCxIb();
	}

	private void mUGvuVBnhg2(object sender, EventArgs e)
	{
		if (SFmvuqNa75l())
		{
			zxuvuHcUnay.Loaded -= mUGvuVBnhg2;
		}
	}

	private void jycvuZZgLTF(object object_0, JRUT36Hkv9ej6eyK7AQ jrut36Hkv9ej6eyK7AQ_0)
	{
		foXvuX5aJVO.c142yxKclrt(jrut36Hkv9ej6eyK7AQ_0.b4g2yny47G5(), jrut36Hkv9ej6eyK7AQ_0.tNJ2y5OBYrD());
		wbFvuGCQrHb();
	}

	private void KcCvu93ftbn(object sender, MouseButtonEventArgs e)
	{
		if (DUJvumpgP6G)
		{
			DUJvumpgP6G = false;
			Iqjvu1BTYyx.ReleaseMouseCapture();
			LAfvuWevkgv();
		}
	}

	private void lbcvuh34XVS(object sender, MouseEventArgs e)
	{
		if (DUJvumpgP6G)
		{
			nYUvuxaLyrp = e.GetPosition(Iqjvu1BTYyx);
			Qpkvu6JxqMO.j0l2yc9bPHk(nYUvuxaLyrp);
			wbFvuGCQrHb();
		}
	}

	private void VMsvue54qy4(object sender, MouseButtonEventArgs e)
	{
		Point position = e.GetPosition(Iqjvu1BTYyx);
		if (!(position.X >= 0.0) || !(position.X < Iqjvu1BTYyx.ActualWidth - 10.0) || !(position.Y >= 0.0) || !(position.Y < Iqjvu1BTYyx.ActualHeight))
		{
			return;
		}
		if (e.ClickCount >= 2)
		{
			NCWvuYWeCwN(position);
			e.Handled = true;
			if (!Y8X48kFzCgeCB0YtwWXy())
			{
				switch (0)
				{
				}
			}
			MouseButtonEventArgs e2 = new MouseButtonEventArgs(Mouse.PrimaryDevice, (int)DateTime.Now.Ticks, MouseButton.Left);
			e2.RoutedEvent = Control.MouseDoubleClickEvent;
			e2.Source = this;
			zxuvuHcUnay.RaiseEvent(e2);
		}
		else
		{
			DUJvumpgP6G = mqjvuIAsZqA(e);
			if (DUJvumpgP6G)
			{
				WcUvukd9pPo(position);
			}
		}
	}

	private void NCWvuYWeCwN(Point point_2)
	{
		foXvuX5aJVO.p6M2yBVwvaN(point_2, true);
	}

	private bool mqjvuIAsZqA(MouseButtonEventArgs mouseButtonEventArgs_0)
	{
		Point position = mouseButtonEventArgs_0.GetPosition(Iqjvu1BTYyx);
		if (Iqjvu1BTYyx.InputHitTest(position) is UIElement uIElement)
		{
			MouseButtonEventArgs e = new MouseButtonEventArgs(mouseButtonEventArgs_0.MouseDevice, mouseButtonEventArgs_0.Timestamp, MouseButton.Left, mouseButtonEventArgs_0.StylusDevice);
			e.RoutedEvent = Mouse.MouseDownEvent;
			e.Source = mouseButtonEventArgs_0.Source;
			if (Y8X48kFzCgeCB0YtwWXy())
			{
				switch (0)
				{
				}
			}
			uIElement.RaiseEvent(e);
			if (Mouse.Captured != zxuvuHcUnay)
			{
				return false;
			}
		}
		return Iqjvu1BTYyx.CaptureMouse();
	}

	private void LAfvuWevkgv()
	{
		phevublcy6Y.IsEnabled = false;
		Qpkvu6JxqMO.IsEnabled = false;
		if (bhyvuKFGDBQ == nYUvuxaLyrp && JmcvurDrpgx.HasValue)
		{
			foXvuX5aJVO.p6M2yBVwvaN(Qpkvu6JxqMO.zDK2yRRjW7X(bhyvuKFGDBQ), JmcvurDrpgx.Value);
		}
	}

	private void WcUvukd9pPo(Point point_2)
	{
		zxuvuHcUnay.Focus();
		bhyvuKFGDBQ = point_2;
		nYUvuxaLyrp = point_2;
		ModifierKeys modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
		if ((modifierKeys & ModifierKeys.Control) == 0 && (modifierKeys & ModifierKeys.Shift) == 0)
		{
			int num = 0;
			if (giVddiFzs73JQ2OI2kYF != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			JmcvurDrpgx = foXvuX5aJVO.did2ypjxNmI(Qpkvu6JxqMO.zDK2yRRjW7X(bhyvuKFGDBQ));
		}
		foXvuX5aJVO.Reset();
		wbFvuGCQrHb();
		phevublcy6Y.IsEnabled = true;
		Qpkvu6JxqMO.IsEnabled = true;
	}

	private void wbFvuGCQrHb()
	{
		Point point = (xvZvupvVrcf = Qpkvu6JxqMO.zDK2yRRjW7X(bhyvuKFGDBQ));
		double x = Math.Min(point.X, nYUvuxaLyrp.X);
		double y = Math.Min(point.Y, nYUvuxaLyrp.Y);
		double width = Math.Abs(nYUvuxaLyrp.X - point.X);
		double height = Math.Abs(nYUvuxaLyrp.Y - point.Y);
		int num = 0;
		if (!Y8X48kFzCgeCB0YtwWXy())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Rect rect_ = new Rect(x, y, width, height);
		phevublcy6Y.sYT2yAlNY8H(rect_);
		Point point2 = Iqjvu1BTYyx.TranslatePoint(rect_.TopLeft, zxuvuHcUnay);
		Point point3 = Iqjvu1BTYyx.TranslatePoint(rect_.BottomRight, zxuvuHcUnay);
		foXvuX5aJVO.Mi22yrE9wlH(new Rect(point2, point3), !JmcvurDrpgx.HasValue || JmcvurDrpgx.Value);
	}

	static ListBoxSelector()
	{
		EnabledProperty = DependencyProperty.RegisterAttached("Enabled", typeof(bool), typeof(ListBoxSelector), new UIPropertyMetadata(false, U1NvuRXcCJj));
		HhfvusnSx6I = new Dictionary<ListBox, ListBoxSelector>();
	}

	internal static bool Y8X48kFzCgeCB0YtwWXy()
	{
		return giVddiFzs73JQ2OI2kYF == null;
	}
}
