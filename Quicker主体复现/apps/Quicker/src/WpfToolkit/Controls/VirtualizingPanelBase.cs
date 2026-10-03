using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WpfToolkit.Controls;

public abstract class VirtualizingPanelBase : VirtualizingPanel, IScrollInfo
{
	[CompilerGenerated]
	private ScrollViewer P7OvYdbqXv;

	[CompilerGenerated]
	private bool j2kvIXmJmI;

	[CompilerGenerated]
	private bool hmxvW8gewt;

	[CompilerGenerated]
	private double fVtvkm1uEi = 16.0;

	[CompilerGenerated]
	private double wgdvGvtpye = 48.0;

	[CompilerGenerated]
	private int dPhvsZwFkE = 3;

	[CompilerGenerated]
	private ScrollDirection wMgvHcj66Q;

	[CompilerGenerated]
	private VirtualizationCacheLength eGLv1iTqZj;

	[CompilerGenerated]
	private VirtualizationCacheLengthUnit m50vbJOjC9;

	private DependencyObject TF4v6UqW41;

	private IRecyclingItemContainerGenerator wIjvXNkRUE;

	[CompilerGenerated]
	private Size o2qvmLIWdc = new Size(0.0, 0.0);

	[CompilerGenerated]
	private Size rqJvKwBatC = new Size(0.0, 0.0);

	[CompilerGenerated]
	private Point uFXvx7uAdB = new Point(0.0, 0.0);

	[CompilerGenerated]
	private ItemRange ANpvrnUj66;

	private static VirtualizingPanelBase qI4N1dXV56pYFchtKGM;

	public ScrollViewer ScrollOwner
	{
		[CompilerGenerated]
		get
		{
			return P7OvYdbqXv;
		}
		[CompilerGenerated]
		set
		{
			P7OvYdbqXv = value;
		}
	}

	public bool CanVerticallyScroll
	{
		[CompilerGenerated]
		get
		{
			return j2kvIXmJmI;
		}
		[CompilerGenerated]
		set
		{
			j2kvIXmJmI = value;
		}
	}

	public bool CanHorizontallyScroll
	{
		[CompilerGenerated]
		get
		{
			return hmxvW8gewt;
		}
		[CompilerGenerated]
		set
		{
			hmxvW8gewt = value;
		}
	}

	protected override bool CanHierarchicallyScrollAndVirtualizeCore => true;

	public double ScrollLineDelta
	{
		[CompilerGenerated]
		get
		{
			return fVtvkm1uEi;
		}
		[CompilerGenerated]
		set
		{
			fVtvkm1uEi = value;
		}
	}

	public double MouseWheelDelta
	{
		[CompilerGenerated]
		get
		{
			return wgdvGvtpye;
		}
		[CompilerGenerated]
		set
		{
			wgdvGvtpye = value;
		}
	}

	public int MouseWheelDeltaItem
	{
		[CompilerGenerated]
		get
		{
			return dPhvsZwFkE;
		}
		[CompilerGenerated]
		set
		{
			dPhvsZwFkE = value;
		}
	}

	protected ScrollUnit ScrollUnit => VirtualizingPanel.GetScrollUnit(ItemsControl);

	protected ScrollDirection MouseWheelScrollDirection
	{
		[CompilerGenerated]
		get
		{
			return wMgvHcj66Q;
		}
		[CompilerGenerated]
		set
		{
			wMgvHcj66Q = value;
		}
	}

	protected bool IsVirtualizing => VirtualizingPanel.GetIsVirtualizing(ItemsControl);

	protected VirtualizationMode VirtualizationMode => VirtualizingPanel.GetVirtualizationMode(ItemsControl);

	protected bool IsRecycling => VirtualizationMode == VirtualizationMode.Recycling;

	protected VirtualizationCacheLength CacheLength
	{
		[CompilerGenerated]
		get
		{
			return eGLv1iTqZj;
		}
		[CompilerGenerated]
		private set
		{
			eGLv1iTqZj = value;
		}
	}

	protected VirtualizationCacheLengthUnit CacheLengthUnit
	{
		[CompilerGenerated]
		get
		{
			return m50vbJOjC9;
		}
		[CompilerGenerated]
		private set
		{
			m50vbJOjC9 = value;
		}
	}

	protected ItemsControl ItemsControl => ItemsControl.GetItemsOwner(this);

	protected DependencyObject ItemsOwner
	{
		get
		{
			if (TF4v6UqW41 == null)
			{
				TF4v6UqW41 = (DependencyObject)typeof(ItemsControl).GetMethod("GetItemsOwnerInternal", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[1] { typeof(DependencyObject) }, null).Invoke(null, new object[1] { this });
			}
			return TF4v6UqW41;
		}
	}

	protected ReadOnlyCollection<object> Items => ((ItemContainerGenerator)ItemContainerGenerator).Items;

	protected new IRecyclingItemContainerGenerator ItemContainerGenerator
	{
		get
		{
			if (wIjvXNkRUE == null)
			{
				UIElementCollection internalChild = base.InternalChildren;
				wIjvXNkRUE = (IRecyclingItemContainerGenerator)base.ItemContainerGenerator;
			}
			return wIjvXNkRUE;
		}
	}

	public double ExtentWidth => Extent.Width;

	public double ExtentHeight => Extent.Height;

	protected Size Extent
	{
		[CompilerGenerated]
		get
		{
			return o2qvmLIWdc;
		}
		[CompilerGenerated]
		private set
		{
			o2qvmLIWdc = value;
		}
	}

	public double HorizontalOffset => Offset.X;

	public double VerticalOffset => Offset.Y;

	protected Size Viewport
	{
		[CompilerGenerated]
		get
		{
			return rqJvKwBatC;
		}
		[CompilerGenerated]
		private set
		{
			rqJvKwBatC = value;
		}
	}

	public double ViewportWidth => Viewport.Width;

	public double ViewportHeight => Viewport.Height;

	protected Point Offset
	{
		[CompilerGenerated]
		get
		{
			return uFXvx7uAdB;
		}
		[CompilerGenerated]
		private set
		{
			uFXvx7uAdB = value;
		}
	}

	protected ItemRange ItemRange
	{
		[CompilerGenerated]
		get
		{
			return ANpvrnUj66;
		}
		[CompilerGenerated]
		set
		{
			ANpvrnUj66 = value;
		}
	}

	protected virtual void UpdateScrollInfo(Size availableSize, Size extent)
	{
		int num;
		if (ViewportHeight != 0.0 && VerticalOffset != 0.0 && VerticalOffset + ViewportHeight + 1.0 >= ExtentHeight)
		{
			Offset = new Point(Offset.X, extent.Height - availableSize.Height);
			ScrollViewer scrollOwner = ScrollOwner;
			if (scrollOwner != null)
			{
				scrollOwner.InvalidateScrollInfo();
				num = 1;
				if (qI4N1dXV56pYFchtKGM != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00d2;
			}
		}
		goto IL_0156;
		IL_0173:
		if (extent != Extent)
		{
			Extent = extent;
			ScrollOwner?.InvalidateScrollInfo();
		}
		return;
		IL_00d2:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0173;
		}
		goto IL_0156;
		IL_0156:
		if (ViewportWidth != 0.0 && HorizontalOffset != 0.0 && HorizontalOffset + ViewportWidth + 1.0 >= ExtentWidth)
		{
			Offset = new Point(extent.Width - availableSize.Width, Offset.Y);
			ScrollOwner?.InvalidateScrollInfo();
		}
		if (availableSize != Viewport)
		{
			Viewport = availableSize;
			ScrollViewer scrollOwner2 = ScrollOwner;
			if (scrollOwner2 != null)
			{
				scrollOwner2.InvalidateScrollInfo();
				num = 0;
				if (VFZkUwXQ33nVatk2vwk())
				{
					goto IL_00d2;
				}
			}
		}
		goto IL_0173;
	}

	public virtual Rect MakeVisible(Visual visual, Rect rectangle)
	{
		Point point = visual.TransformToAncestor(this).Transform(Offset);
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		if (VFZkUwXQ33nVatk2vwk())
		{
			goto IL_003a;
		}
		goto IL_01a5;
		IL_003a:
		if (point.X < Offset.X)
		{
			num = 0.0 - (Offset.X - point.X);
		}
		else if (point.X + rectangle.Width > Offset.X + Viewport.Width)
		{
			num = point.X + rectangle.Width - (Offset.X + Viewport.Width);
		}
		if (point.Y < Offset.Y)
		{
			num2 = 0.0 - (Offset.Y - point.Y);
		}
		else if (point.Y + rectangle.Height > Offset.Y + Viewport.Height)
		{
			num2 = point.Y + rectangle.Height - (Offset.Y + Viewport.Height);
		}
		SetHorizontalOffset(Offset.X + num);
		SetVerticalOffset(Offset.Y + num2);
		num3 = 1;
		if (qI4N1dXV56pYFchtKGM != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		goto IL_01a5;
		IL_01a5:
		switch (num3)
		{
		case 1:
		{
			double width = Math.Min(rectangle.Width, Viewport.Width);
			double height = Math.Min(rectangle.Height, Viewport.Height);
			return new Rect(num, num2, width, height);
		}
		}
		goto IL_003a;
	}

	protected override void OnItemsChanged(object sender, ItemsChangedEventArgs e)
	{
		switch (e.Action)
		{
		case NotifyCollectionChangedAction.Move:
			RemoveInternalChildRange(e.OldPosition.Index, e.ItemUICount);
			break;
		case NotifyCollectionChangedAction.Remove:
		case NotifyCollectionChangedAction.Replace:
			RemoveInternalChildRange(e.Position.Index, e.ItemUICount);
			break;
		}
	}

	protected int GetItemIndexFromChildIndex(int childIndex)
	{
		GeneratorPosition generatorPositionFromChildIndex = GetGeneratorPositionFromChildIndex(childIndex);
		return ItemContainerGenerator.IndexFromGeneratorPosition(generatorPositionFromChildIndex);
	}

	protected virtual GeneratorPosition GetGeneratorPositionFromChildIndex(int childIndex)
	{
		return new GeneratorPosition(childIndex, 0);
	}

	private static WkrnJ7gJ82RHqGnUfy g3fvcd0Suk<WkrnJ7gJ82RHqGnUfy>(DependencyObject dependencyObject_1) where WkrnJ7gJ82RHqGnUfy : Visual
	{
		WkrnJ7gJ82RHqGnUfy val = null;
		int childrenCount = VisualTreeHelper.GetChildrenCount(dependencyObject_1);
		for (int i = 0; i < childrenCount; i++)
		{
			Visual visual = (Visual)VisualTreeHelper.GetChild(dependencyObject_1, i);
			val = visual as WkrnJ7gJ82RHqGnUfy;
			if (val == null)
			{
				val = g3fvcd0Suk<WkrnJ7gJ82RHqGnUfy>(visual);
			}
			if (val != null)
			{
				break;
			}
		}
		return val;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
        double width2 = default;
        double height2 = default;
		IHierarchicalVirtualizationAndScrollInfo hierarchicalVirtualizationAndScrollInfo = ItemsOwner as IHierarchicalVirtualizationAndScrollInfo;
		Size size;
		Size size2 = default(Size);
		if (hierarchicalVirtualizationAndScrollInfo == null)
		{
			size = CalculateExtent(availableSize);
			double width = Math.Min(availableSize.Width, size.Width);
			double height = Math.Min(availableSize.Height, size.Height);
			size2 = new Size(width, height);
			goto IL_0141;
		}
		Size size3 = hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Size;
		Size pixelSize = hierarchicalVirtualizationAndScrollInfo.HeaderDesiredSizes.PixelSize;
		width2 = Math.Max(size3.Width - 5.0, 0.0);
		height2 = Math.Max(size3.Height - pixelSize.Height, 0.0);
		int num = 0;
		if (!VFZkUwXQ33nVatk2vwk())
		{
			goto IL_01ae;
		}
		goto IL_01e5;
		IL_00ec:
		ItemRange = UpdateItemRange();
		RealizeItems();
		VirtualizeItems();
		num = 1;
		if (!VFZkUwXQ33nVatk2vwk())
		{
			goto IL_01e5;
		}
		goto IL_01fc;
		IL_01e5:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0118;
		case 2:
			goto IL_01fc;
		}
		CacheLengthUnit = hierarchicalVirtualizationAndScrollInfo.Constraints.CacheLengthUnit;
		goto IL_00ec;
		IL_0141:
		if (hierarchicalVirtualizationAndScrollInfo != null)
		{
			Extent = size;
			Offset = hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Location;
			Viewport = hierarchicalVirtualizationAndScrollInfo.Constraints.Viewport.Size;
			CacheLength = hierarchicalVirtualizationAndScrollInfo.Constraints.CacheLength;
			num = 1;
			if (!VFZkUwXQ33nVatk2vwk())
			{
				goto IL_01ae;
			}
			goto IL_01e5;
		}
		UpdateScrollInfo(size2, size);
		CacheLength = VirtualizingPanel.GetCacheLength(ItemsOwner);
		CacheLengthUnit = VirtualizingPanel.GetCacheLengthUnit(ItemsOwner);
		goto IL_00ec;
		IL_0118:
		availableSize = new Size(width2, height2);
		size = CalculateExtent(availableSize);
		size2 = new Size(size.Width, size.Height);
		goto IL_0141;
		IL_01fc:
		return size2;
		IL_01ae:
		int num2 = default(int);
		num = num2;
		goto IL_01e5;
	}

	protected virtual void RealizeItems()
	{
		GeneratorPosition position = ItemContainerGenerator.GeneratorPositionFromIndex(ItemRange.StartIndex);
		int num = ((position.Offset == 0) ? position.Index : (position.Index + 1));
		using (ItemContainerGenerator.StartAt(position, GeneratorDirection.Forward, true))
		{
			int num2 = ItemRange.StartIndex;
			int num4 = default(int);
			while (num2 <= ItemRange.EndIndex)
			{
				bool isNewlyRealized;
				UIElement uIElement = (UIElement)ItemContainerGenerator.GenerateNext(out isNewlyRealized);
				int num3 = 1;
				if (!VFZkUwXQ33nVatk2vwk())
				{
					goto IL_0094;
				}
				goto IL_0098;
				IL_0094:
				num3 = num4;
				goto IL_0098;
				IL_0098:
				while (true)
				{
					switch (num3)
					{
					case 1:
						if (!isNewlyRealized)
						{
							goto IL_0087;
						}
						goto IL_00b4;
					default:
						{
							if (base.InternalChildren.Contains(uIElement))
							{
								break;
							}
							goto IL_00b4;
						}
						IL_00b4:
						if (num >= base.InternalChildren.Count)
						{
							AddInternalChild(uIElement);
						}
						else
						{
							InsertInternalChild(num, uIElement);
						}
						ItemContainerGenerator.PrepareItemContainer(uIElement);
						uIElement.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
						break;
					}
					break;
					IL_0087:
					num3 = 0;
					if (qI4N1dXV56pYFchtKGM == null)
					{
						continue;
					}
					goto IL_0094;
				}
				if (uIElement is IHierarchicalVirtualizationAndScrollInfo hierarchicalVirtualizationAndScrollInfo)
				{
					hierarchicalVirtualizationAndScrollInfo.Constraints = new HierarchicalVirtualizationConstraints(new VirtualizationCacheLength(0.0), VirtualizationCacheLengthUnit.Item, new Rect(0.0, 0.0, ViewportWidth, ViewportHeight));
					uIElement.Measure(new Size(ViewportWidth, ViewportHeight));
				}
				num2++;
				num++;
			}
		}
	}

	protected virtual void VirtualizeItems()
	{
		for (int num = base.InternalChildren.Count - 1; num >= 0; num--)
		{
			GeneratorPosition generatorPositionFromChildIndex = GetGeneratorPositionFromChildIndex(num);
			int itemIndex = ItemContainerGenerator.IndexFromGeneratorPosition(generatorPositionFromChildIndex);
			if (!ItemRange.Contains(itemIndex))
			{
				if (VirtualizationMode == VirtualizationMode.Recycling)
				{
					ItemContainerGenerator.Recycle(generatorPositionFromChildIndex, 1);
					if (!VFZkUwXQ33nVatk2vwk())
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					ItemContainerGenerator.Remove(generatorPositionFromChildIndex, 1);
				}
				RemoveInternalChildRange(num, 1);
			}
		}
	}

	protected abstract Size CalculateExtent(Size availableSize);

	protected abstract ItemRange UpdateItemRange();

	public void SetVerticalOffset(double offset)
	{
		if (!(offset < 0.0) && Viewport.Height < Extent.Height)
		{
			if (offset + Viewport.Height >= Extent.Height)
			{
				offset = Extent.Height - Viewport.Height;
			}
		}
		else
		{
			offset = 0.0;
		}
		Offset = new Point(Offset.X, offset);
		ScrollViewer scrollOwner = ScrollOwner;
		if (scrollOwner != null)
		{
			scrollOwner.InvalidateScrollInfo();
			if (qI4N1dXV56pYFchtKGM == null)
			{
				switch (0)
				{
				}
			}
		}
		InvalidateMeasure();
	}

	public void SetHorizontalOffset(double offset)
	{
		if (!(offset < 0.0) && Viewport.Width < Extent.Width)
		{
			if (offset + Viewport.Width >= Extent.Width)
			{
				Size extent = Extent;
				int num = 0;
				if (qI4N1dXV56pYFchtKGM != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				offset = extent.Width - Viewport.Width;
			}
		}
		else
		{
			offset = 0.0;
		}
		Offset = new Point(offset, Offset.Y);
		ScrollOwner?.InvalidateScrollInfo();
		InvalidateMeasure();
	}

	protected void ScrollVertical(double amount)
	{
		SetVerticalOffset(VerticalOffset + amount);
	}

	protected void ScrollHorizontal(double amount)
	{
		SetHorizontalOffset(HorizontalOffset + amount);
	}

	public void LineUp()
	{
		ScrollVertical((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - ScrollLineDelta) : GetLineUpScrollAmount());
	}

	public void LineDown()
	{
		ScrollVertical((ScrollUnit == ScrollUnit.Pixel) ? ScrollLineDelta : GetLineDownScrollAmount());
	}

	public void LineLeft()
	{
		ScrollHorizontal((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - ScrollLineDelta) : GetLineLeftScrollAmount());
	}

	public void LineRight()
	{
		ScrollHorizontal((ScrollUnit == ScrollUnit.Pixel) ? ScrollLineDelta : GetLineRightScrollAmount());
	}

	public void MouseWheelUp()
	{
		if (MouseWheelScrollDirection == ScrollDirection.Vertical)
		{
			ScrollVertical((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - MouseWheelDelta) : GetMouseWheelUpScrollAmount());
		}
		else
		{
			MouseWheelLeft();
		}
	}

	public void MouseWheelDown()
	{
		if (MouseWheelScrollDirection == ScrollDirection.Vertical)
		{
			ScrollVertical((ScrollUnit == ScrollUnit.Pixel) ? MouseWheelDelta : GetMouseWheelDownScrollAmount());
		}
		else
		{
			MouseWheelRight();
		}
	}

	public void MouseWheelLeft()
	{
		ScrollHorizontal((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - MouseWheelDelta) : GetMouseWheelLeftScrollAmount());
	}

	public void MouseWheelRight()
	{
		ScrollHorizontal((ScrollUnit == ScrollUnit.Pixel) ? MouseWheelDelta : GetMouseWheelRightScrollAmount());
	}

	public void PageUp()
	{
		ScrollVertical((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - ViewportHeight) : GetPageUpScrollAmount());
	}

	public void PageDown()
	{
		ScrollVertical((ScrollUnit != ScrollUnit.Pixel) ? GetPageDownScrollAmount() : ViewportHeight);
	}

	public void PageLeft()
	{
		ScrollHorizontal((ScrollUnit == ScrollUnit.Pixel) ? (0.0 - ViewportHeight) : GetPageLeftScrollAmount());
	}

	public void PageRight()
	{
		ScrollHorizontal((ScrollUnit != ScrollUnit.Pixel) ? GetPageRightScrollAmount() : ViewportHeight);
	}

	protected abstract double GetLineUpScrollAmount();

	protected abstract double GetLineDownScrollAmount();

	protected abstract double GetLineLeftScrollAmount();

	protected abstract double GetLineRightScrollAmount();

	protected abstract double GetMouseWheelUpScrollAmount();

	protected abstract double GetMouseWheelDownScrollAmount();

	protected abstract double GetMouseWheelLeftScrollAmount();

	protected abstract double GetMouseWheelRightScrollAmount();

	protected abstract double GetPageUpScrollAmount();

	protected abstract double GetPageDownScrollAmount();

	protected abstract double GetPageLeftScrollAmount();

	protected abstract double GetPageRightScrollAmount();

	internal static bool VFZkUwXQ33nVatk2vwk()
	{
		return qI4N1dXV56pYFchtKGM == null;
	}
}
