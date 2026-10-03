using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfToolkit.Controls;

public class VirtualizingWrapPanel : VirtualizingPanelBase
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec If7vPTE2pbY;

		internal static _003C_003Ec QRey8gcnqhxyOkfkMcJp;

		static _003C_003Ec()
		{
			If7vPTE2pbY = new _003C_003Ec();
		}

		internal void We5vPoTwObQ(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			((VirtualizingWrapPanel)obj).ihEvp1v2qT();
		}

		internal static bool Rt7DEYcni38FDOWpSwFX()
		{
			return QRey8gcnqhxyOkfkMcJp == null;
		}
	}

	[Obsolete("Use ItemSizeProperty")]
	public static readonly DependencyProperty ChildrenSizeProperty;

	[Obsolete("Use IsSpacingEnabledProperty")]
	public static readonly DependencyProperty SpacingEnabledProperty;

	public static readonly DependencyProperty IsSpacingEnabledProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty ItemSizeProperty;

	protected Size childSize;

	protected int rowCount;

	protected int itemsPerRowCount;

	internal static VirtualizingWrapPanel gFc5wIXEFh00b8uVZBM;

	[Obsolete("Use IsSpacingEnabled")]
	public bool SpacingEnabled
	{
		get
		{
			return IsSpacingEnabled;
		}
		set
		{
			IsSpacingEnabled = value;
		}
	}

	[Obsolete("Use ItemSize")]
	public Size ChildrenSize
	{
		get
		{
			return ItemSize;
		}
		set
		{
			ItemSize = value;
		}
	}

	public bool IsSpacingEnabled
	{
		get
		{
			return (bool)GetValue(IsSpacingEnabledProperty);
		}
		set
		{
			SetValue(IsSpacingEnabledProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public Size ItemSize
	{
		get
		{
			return (Size)GetValue(ItemSizeProperty);
		}
		set
		{
			SetValue(ItemSizeProperty, value);
		}
	}

	private void ihEvp1v2qT()
	{
		base.MouseWheelScrollDirection = ((Orientation != Orientation.Vertical) ? ScrollDirection.Horizontal : ScrollDirection.Vertical);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		xyqvBg6C1L(availableSize);
		return base.MeasureOverride(availableSize);
	}

	private void xyqvBg6C1L(Size size_2)
	{
		IHierarchicalVirtualizationAndScrollInfo hierarchicalVirtualizationAndScrollInfo = base.ItemsOwner as IHierarchicalVirtualizationAndScrollInfo;
		int num;
		if (hierarchicalVirtualizationAndScrollInfo != null && VirtualizingPanel.GetIsVirtualizingWhenGrouping(base.ItemsControl))
		{
			num = 1;
			if (gFc5wIXEFh00b8uVZBM != null)
			{
				goto IL_00aa;
			}
			goto IL_00ae;
		}
		goto IL_01a8;
		IL_01a8:
		if (!(ItemSize != Size.Empty))
		{
			if (base.InternalChildren.Count != 0)
			{
				childSize = base.InternalChildren[0].DesiredSize;
			}
			else
			{
				childSize = mBJvQuZpCw(size_2);
			}
		}
		else
		{
			childSize = ItemSize;
		}
		if (!double.IsInfinity(GetWidth(size_2)))
		{
			itemsPerRowCount = Math.Max(1, (int)Math.Floor(GetWidth(size_2) / GetWidth(childSize)));
			num = 0;
			if (!oZPnVNXGTRtabAC8fw1())
			{
				goto IL_00aa;
			}
			goto IL_00ae;
		}
		itemsPerRowCount = base.Items.Count;
		goto IL_01d0;
		IL_01d0:
		rowCount = (int)Math.Ceiling((double)base.Items.Count / (double)itemsPerRowCount);
		return;
		IL_00aa:
		int num2 = default(int);
		num = num2;
		goto IL_00ae;
		IL_00ae:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_01d0;
		}
		if (Orientation == Orientation.Vertical)
		{
			size_2.Width = hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Size.Width;
			size_2.Width = Math.Max(size_2.Width - (base.Margin.Left + base.Margin.Right), 0.0);
		}
		else
		{
			size_2.Height = hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Size.Height;
			size_2.Height = Math.Max(size_2.Height - (base.Margin.Top + base.Margin.Bottom), 0.0);
		}
		goto IL_01a8;
	}

	private Size mBJvQuZpCw(Size size_2)
	{
		if (base.Items.Count == 0)
		{
			return new Size(0.0, 0.0);
		}
		GeneratorPosition position = base.ItemContainerGenerator.GeneratorPositionFromIndex(0);
		using (base.ItemContainerGenerator.StartAt(position, GeneratorDirection.Forward, true))
		{
			UIElement uIElement = (UIElement)base.ItemContainerGenerator.GenerateNext();
			AddInternalChild(uIElement);
			base.ItemContainerGenerator.PrepareItemContainer(uIElement);
			uIElement.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			return uIElement.DesiredSize;
		}
	}

	protected override Size CalculateExtent(Size availableSize)
	{
		double num = ((!IsSpacingEnabled || double.IsInfinity(GetWidth(availableSize))) ? (GetWidth(childSize) * (double)itemsPerRowCount) : GetWidth(availableSize));
		if (base.ItemsOwner is IHierarchicalVirtualizationAndScrollInfo)
		{
			int num2 = 0;
			if (gFc5wIXEFh00b8uVZBM != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			num = ((Orientation != Orientation.Vertical) ? Math.Max(num - (base.Margin.Top + base.Margin.Bottom), 0.0) : Math.Max(num - (base.Margin.Left + base.Margin.Right), 0.0));
		}
		double height = GetHeight(childSize) * (double)rowCount;
		return CreateSize(num, height);
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double x = GetX(base.Offset);
		double num = GetY(base.Offset);
		if (base.ItemsOwner is IHierarchicalVirtualizationAndScrollInfo)
		{
			num = 0.0;
		}
		double num2 = GetWidth(finalSize) - GetWidth(childSize) * (double)itemsPerRowCount;
		int num3 = 1;
		if (gFc5wIXEFh00b8uVZBM != null)
		{
			goto IL_0111;
		}
		goto IL_0193;
		IL_0193:
		double num7 = default(double);
		int num6 = default(int);
		UIElement uIElement = default(UIElement);
		double num4 = default(double);
		double num5 = default(double);
		do
		{
			switch (num3)
			{
			case 1:
				num7 = ((num2 > 0.0) ? (num2 / (double)(itemsPerRowCount + 1)) : 0.0);
				num6 = 0;
				break;
			default:
				if (GetHeight(finalSize) == 0.0)
				{
					uIElement.Arrange(new Rect(0.0, 0.0, 0.0, 0.0));
				}
				else
				{
					uIElement.Arrange(CreateRect(num4 - x, num5 - num, childSize.Width, childSize.Height));
				}
				num6++;
				break;
			}
			if (num6 < base.InternalChildren.Count)
			{
				uIElement = base.InternalChildren[num6];
				int itemIndexFromChildIndex = GetItemIndexFromChildIndex(num6);
				int num8 = itemIndexFromChildIndex % itemsPerRowCount;
				int num9 = itemIndexFromChildIndex / itemsPerRowCount;
				num4 = (double)num8 * GetWidth(childSize);
				if (IsSpacingEnabled)
				{
					num4 += (double)(num8 + 1) * num7;
				}
				num5 = (double)num9 * GetHeight(childSize);
				num3 = 0;
				continue;
			}
			return finalSize;
		}
		while (gFc5wIXEFh00b8uVZBM == null);
		goto IL_0111;
		IL_0111:
		int num10 = default(int);
		num3 = num10;
		goto IL_0193;
	}

	protected override ItemRange UpdateItemRange()
	{
		if (!base.IsVirtualizing)
		{
			return new ItemRange(0, base.Items.Count - 1);
		}
		int num3 = default(int);
		double num4 = default(double);
		double num5 = default(double);
		int num6 = default(int);
		int num7;
		double num8 = default(double);
		if (base.ItemsOwner is IHierarchicalVirtualizationAndScrollInfo hierarchicalVirtualizationAndScrollInfo)
		{
			if (!VirtualizingPanel.GetIsVirtualizingWhenGrouping(base.ItemsControl))
			{
				return new ItemRange(0, base.Items.Count - 1);
			}
			Point point = new Point(base.Offset.X, hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Location.Y);
			int num = 0;
			int num2 = 0;
			if (base.ScrollUnit == ScrollUnit.Item)
			{
				num3 = ((GetY(point) >= 1.0) ? ((int)GetY(point) - 1) : 0);
				num4 = (double)num3 * GetHeight(childSize);
			}
			else
			{
				num4 = Math.Min(Math.Max(GetY(point) - GetHeight(hierarchicalVirtualizationAndScrollInfo.HeaderDesiredSizes.PixelSize), 0.0), GetHeight(base.Extent));
				num3 = JLwvjnFUqA(num4);
			}
			num5 = Math.Min(GetHeight(base.Viewport), Math.Max(GetHeight(base.Extent) - num4, 0.0));
			num6 = (int)Math.Ceiling((num4 + num5) / GetHeight(childSize)) - (int)Math.Floor(num4 / GetHeight(childSize));
			num7 = 0;
			if (!oZPnVNXGTRtabAC8fw1())
			{
				goto IL_02e5;
			}
		}
		else
		{
			num8 = GetY(base.Offset);
			num7 = 1;
			if (gFc5wIXEFh00b8uVZBM != null)
			{
				goto IL_01c6;
			}
		}
		goto IL_0328;
		IL_0328:
		VirtualizationCacheLength cacheLength = default(VirtualizationCacheLength);
		int num11 = default(int);
		int num12 = default(int);
		while (true)
		{
			switch (num7)
			{
			case 2:
				break;
			case 1:
				goto IL_01cf;
			default:
				goto IL_02e5;
			case 3:
			{
				double num9 = Math.Min(cacheLength.CacheBeforeViewport, num4);
				double num10 = Math.Min(base.CacheLength.CacheAfterViewport, GetHeight(base.Extent) - num5 - num4);
				int num = (int)(num9 / GetHeight(childSize));
				int num2 = (int)Math.Ceiling((num4 + num5 + num10) / GetHeight(childSize)) - (int)Math.Ceiling((num4 + num5) / GetHeight(childSize));
				num11 = Math.Max(num11 - num * itemsPerRowCount, 0);
				num12 = Math.Min(num12 + num2 * itemsPerRowCount, base.Items.Count - 1);
				goto IL_04d7;
			}
			case 4:
				goto IL_04d7;
			}
			break;
			IL_01cf:
			double num13 = GetY(base.Offset) + GetHeight(base.Viewport);
			if (base.CacheLengthUnit == VirtualizationCacheLengthUnit.Pixel)
			{
				num8 = Math.Max(num8 - base.CacheLength.CacheBeforeViewport, 0.0);
				num13 = Math.Min(num13 + base.CacheLength.CacheAfterViewport, GetHeight(base.Extent));
			}
			num11 = JLwvjnFUqA(num8) * itemsPerRowCount;
			num12 = Math.Min(JLwvjnFUqA(num13) * itemsPerRowCount + (itemsPerRowCount - 1), base.Items.Count - 1);
			if (base.CacheLengthUnit == VirtualizationCacheLengthUnit.Page)
			{
				int num14 = num12 - num11 + 1;
				num11 = Math.Max(num11 - (int)base.CacheLength.CacheBeforeViewport * num14, 0);
				int num15 = num12;
				cacheLength = base.CacheLength;
				num12 = Math.Min(num15 + (int)cacheLength.CacheAfterViewport * num14, base.Items.Count - 1);
				num7 = 4;
				if (oZPnVNXGTRtabAC8fw1())
				{
					continue;
				}
				goto IL_01c6;
			}
			if (base.CacheLengthUnit == VirtualizationCacheLengthUnit.Item)
			{
				num11 = Math.Max(num11 - (int)base.CacheLength.CacheBeforeViewport, 0);
				num12 = Math.Min(num12 + (int)base.CacheLength.CacheAfterViewport, base.Items.Count - 1);
			}
			goto IL_04d7;
		}
		goto IL_01ae;
		IL_01c6:
		int num16 = default(int);
		num7 = num16;
		goto IL_0328;
		IL_01ae:
		cacheLength = base.CacheLength;
		num7 = 3;
		if (!oZPnVNXGTRtabAC8fw1())
		{
			goto IL_01c6;
		}
		goto IL_0328;
		IL_02e5:
		num11 = num3 * itemsPerRowCount;
		num12 = Math.Min((num3 + num6) * itemsPerRowCount - 1, base.Items.Count - 1);
		if (base.CacheLengthUnit == VirtualizationCacheLengthUnit.Pixel)
		{
			num16 = 2;
			goto IL_01ae;
		}
		if (base.CacheLengthUnit == VirtualizationCacheLengthUnit.Item)
		{
			int num = (int)Math.Ceiling(base.CacheLength.CacheBeforeViewport / (double)itemsPerRowCount);
			int num2 = (int)Math.Ceiling(base.CacheLength.CacheAfterViewport / (double)itemsPerRowCount);
			num11 = Math.Max(num11 - (int)base.CacheLength.CacheBeforeViewport, 0);
			num12 = Math.Min(num12 + (int)base.CacheLength.CacheAfterViewport, base.Items.Count - 1);
		}
		goto IL_04d7;
		IL_04d7:
		return new ItemRange(num11, num12);
	}

	private int JLwvjnFUqA(double double_1)
	{
		int val = (int)Math.Floor(double_1 / GetHeight(childSize));
		int val2 = (int)Math.Ceiling((double)base.Items.Count / (double)itemsPerRowCount);
		return Math.Max(Math.Min(val, val2), 0);
	}

	protected override void BringIndexIntoView(int index)
	{
		double num = (double)(index / itemsPerRowCount) * GetHeight(childSize);
		if (Orientation == Orientation.Horizontal)
		{
			SetHorizontalOffset(num);
		}
		else
		{
			SetVerticalOffset(num);
		}
	}

	protected override double GetLineUpScrollAmount()
	{
		return 0.0 - childSize.Height;
	}

	protected override double GetLineDownScrollAmount()
	{
		return childSize.Height;
	}

	protected override double GetLineLeftScrollAmount()
	{
		return 0.0 - childSize.Width;
	}

	protected override double GetLineRightScrollAmount()
	{
		return childSize.Width;
	}

	protected override double GetMouseWheelUpScrollAmount()
	{
		return 0.0 - Math.Min(childSize.Height * (double)base.MouseWheelDeltaItem, base.Viewport.Height);
	}

	protected override double GetMouseWheelDownScrollAmount()
	{
		return Math.Min(childSize.Height * (double)base.MouseWheelDeltaItem, base.Viewport.Height);
	}

	protected override double GetMouseWheelLeftScrollAmount()
	{
		return 0.0 - Math.Min(childSize.Width * (double)base.MouseWheelDeltaItem, base.Viewport.Width);
	}

	protected override double GetMouseWheelRightScrollAmount()
	{
		return Math.Min(childSize.Width * (double)base.MouseWheelDeltaItem, base.Viewport.Width);
	}

	protected override double GetPageUpScrollAmount()
	{
		return 0.0 - base.Viewport.Height;
	}

	protected override double GetPageDownScrollAmount()
	{
		return base.Viewport.Height;
	}

	protected override double GetPageLeftScrollAmount()
	{
		return 0.0 - base.Viewport.Width;
	}

	protected override double GetPageRightScrollAmount()
	{
		return base.Viewport.Width;
	}

	protected double GetX(Point point)
	{
		if (Orientation != Orientation.Vertical)
		{
			return point.Y;
		}
		return point.X;
	}

	protected double GetY(Point point)
	{
		if (Orientation != Orientation.Vertical)
		{
			return point.X;
		}
		return point.Y;
	}

	protected double GetWidth(Size size)
	{
		if (Orientation != Orientation.Vertical)
		{
			return size.Height;
		}
		return size.Width;
	}

	protected double GetHeight(Size size)
	{
		if (Orientation != Orientation.Vertical)
		{
			return size.Width;
		}
		return size.Height;
	}

	protected Size CreateSize(double width, double height)
	{
		if (Orientation != Orientation.Vertical)
		{
			return new Size(height, width);
		}
		return new Size(width, height);
	}

	protected Rect CreateRect(double x, double y, double width, double height)
	{
		if (Orientation != Orientation.Vertical)
		{
			return new Rect(y, x, width, height);
		}
		return new Rect(x, y, width, height);
	}

	static VirtualizingWrapPanel()
	{
		ChildrenSizeProperty = ItemSizeProperty;
		SpacingEnabledProperty = IsSpacingEnabledProperty;
		IsSpacingEnabledProperty = DependencyProperty.Register("IsSpacingEnabled", typeof(bool), typeof(VirtualizingWrapPanel), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsMeasure));
		OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(VirtualizingWrapPanel), new FrameworkPropertyMetadata(Orientation.Vertical, FrameworkPropertyMetadataOptions.AffectsMeasure, _003C_003Ec.If7vPTE2pbY.We5vPoTwObQ));
		ItemSizeProperty = DependencyProperty.Register("ItemSize", typeof(Size), typeof(VirtualizingWrapPanel), new FrameworkPropertyMetadata(Size.Empty, FrameworkPropertyMetadataOptions.AffectsMeasure));
	}

	internal static bool oZPnVNXGTRtabAC8fw1()
	{
		return gFc5wIXEFh00b8uVZBM == null;
	}
}
