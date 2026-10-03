using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfToolkit.Controls;

public class VirtualizingWrapPanelWithItemExpansion : VirtualizingWrapPanel
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec osnvPAMAYLm;

		internal static _003C_003Ec Jjiet7cnZLFFMei6ROYF;

		static _003C_003Ec()
		{
			osnvPAMAYLm = new _003C_003Ec();
		}

		internal void lMrvPMiIRnj(DependencyObject o, DependencyPropertyChangedEventArgs a)
		{
			((VirtualizingWrapPanelWithItemExpansion)o).N8LvnY5WrU(a);
		}

		internal static bool eiXoYxcn5MD8jyfGkli2()
		{
			return Jjiet7cnZLFFMei6ROYF == null;
		}
	}

	public static readonly DependencyProperty ExpandedItemTemplateProperty;

	public static readonly DependencyProperty ExpandedItemProperty;

	private FrameworkElement pdAvDmjWqH;

	private int U4kvdKtPnZ;

	internal static VirtualizingWrapPanelWithItemExpansion d0PebAXkFWacHlk3uBS;

	public DataTemplate ExpandedItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ExpandedItemTemplateProperty);
		}
		set
		{
			SetValue(ExpandedItemTemplateProperty, value);
		}
	}

	public object ExpandedItem
	{
		get
		{
			return GetValue(ExpandedItemProperty);
		}
		set
		{
			SetValue(ExpandedItemProperty, value);
		}
	}

	[SpecialName]
	private int ml9v4QBU03()
	{
		return base.Items.IndexOf(ExpandedItem);
	}

	private void N8LvnY5WrU(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyPropertyChangedEventArgs_0.OldValue != null)
		{
			int num = base.InternalChildren.IndexOf(pdAvDmjWqH);
			if (num != -1)
			{
				pdAvDmjWqH = null;
				RemoveInternalChildRange(num, 1);
			}
		}
	}

	protected override Size CalculateExtent(Size availableSize)
	{
		Size result = base.CalculateExtent(availableSize);
		if (pdAvDmjWqH != null)
		{
			if (base.Orientation == Orientation.Vertical)
			{
				result.Height += pdAvDmjWqH.DesiredSize.Height;
			}
			else
			{
				result.Width += pdAvDmjWqH.DesiredSize.Width;
			}
		}
		return result;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = 0.0;
		double num2 = GetWidth(finalSize) - GetWidth(childSize) * (double)itemsPerRowCount;
		double num3 = ((num2 > 0.0) ? (num2 / (double)(itemsPerRowCount + 1)) : 0.0);
		int num4 = 0;
		int num8 = default(int);
		double num9 = default(double);
		double height = default(double);
		while (num4 < base.InternalChildren.Count)
		{
			UIElement uIElement = base.InternalChildren[num4];
			if (uIElement == pdAvDmjWqH)
			{
				double num5 = (base.IsSpacingEnabled ? num3 : 0.0);
				double num6 = (double)(ml9v4QBU03() / itemsPerRowCount) * GetHeight(childSize) + GetHeight(childSize);
				int num7 = 1;
				if (d0PebAXkFWacHlk3uBS != null)
				{
					num7 = num8;
				}
				switch (num7)
				{
				case 1:
					num9 = (base.IsSpacingEnabled ? (GetWidth(finalSize) - 2.0 * num3) : GetWidth(finalSize));
					height = GetHeight(pdAvDmjWqH.DesiredSize);
					if (base.Orientation == Orientation.Vertical)
					{
						pdAvDmjWqH.Arrange(CreateRect(num5 - GetX(base.Offset), num6 - GetY(base.Offset), num9, height));
						break;
					}
					goto default;
				default:
					pdAvDmjWqH.Arrange(CreateRect(num5 - GetX(base.Offset), num6 - GetY(base.Offset), height, num9));
					break;
				case 2:
					continue;
				}
				num = height;
			}
			else
			{
				int itemIndexFromChildIndex = GetItemIndexFromChildIndex(num4);
				int num10 = itemIndexFromChildIndex % itemsPerRowCount;
				int num11 = itemIndexFromChildIndex / itemsPerRowCount;
				double num12 = (double)num10 * GetWidth(childSize);
				if (base.IsSpacingEnabled)
				{
					num12 += (double)(num10 + 1) * num3;
				}
				double num13 = (double)num11 * GetHeight(childSize) + num;
				uIElement.Arrange(CreateRect(num12 - GetX(base.Offset), num13 - GetY(base.Offset), childSize.Width, childSize.Height));
			}
			num4++;
		}
		return finalSize;
	}

	protected override void RealizeItems()
	{
		GeneratorPosition position = base.ItemContainerGenerator.GeneratorPositionFromIndex(base.ItemRange.StartIndex);
		int num = ((position.Offset == 0) ? position.Index : (position.Index + 1));
		int num2 = base.Items.IndexOf(ExpandedItem);
		int val = ((num2 != -1) ? ((num2 / itemsPerRowCount + 1) * itemsPerRowCount - 1) : (-1));
		int num3 = 0;
		if (!YavZxWXacvb0OgxMF2X())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
			val = Math.Min(val, base.Items.Count - 1);
			if (val != U4kvdKtPnZ && pdAvDmjWqH != null)
			{
				RemoveInternalChildRange(base.InternalChildren.IndexOf(pdAvDmjWqH), 1);
			}
			using (base.ItemContainerGenerator.StartAt(position, GeneratorDirection.Forward, true))
			{
				int num5 = base.ItemRange.StartIndex;
				int num7 = default(int);
				while (true)
				{
					if (num5 <= base.ItemRange.EndIndex)
					{
						bool isNewlyRealized;
						FrameworkElement frameworkElement = (FrameworkElement)base.ItemContainerGenerator.GenerateNext(out isNewlyRealized);
						if (isNewlyRealized || !base.InternalChildren.Contains(frameworkElement))
						{
							if (num >= base.InternalChildren.Count)
							{
								AddInternalChild(frameworkElement);
							}
							else
							{
								InsertInternalChild(num, frameworkElement);
							}
							base.ItemContainerGenerator.PrepareItemContainer(frameworkElement);
							if (base.ItemSize == Size.Empty)
							{
								frameworkElement.Measure(CreateSize(GetWidth(base.Viewport), double.MaxValue));
							}
							else
							{
								frameworkElement.Measure(base.ItemSize);
							}
						}
						goto IL_01e4;
					}
					U4kvdKtPnZ = val;
					int num6 = 1;
					if (d0PebAXkFWacHlk3uBS != null)
					{
						goto IL_01cd;
					}
					goto IL_01d1;
					IL_01fd:
					if (!base.InternalChildren.Contains(pdAvDmjWqH))
					{
						num++;
						if (num >= base.InternalChildren.Count)
						{
							AddInternalChild(pdAvDmjWqH);
						}
						else
						{
							InsertInternalChild(num, pdAvDmjWqH);
						}
					}
					goto IL_0241;
					IL_01d1:
					switch (num6)
					{
					case 2:
						break;
					default:
						goto IL_01ec;
					case 1:
						return;
					}
					goto IL_01e4;
					IL_01e4:
					if (num5 != val)
					{
						goto IL_0241;
					}
					if (pdAvDmjWqH == null)
					{
						pdAvDmjWqH = (FrameworkElement)ExpandedItemTemplate.LoadContent();
						pdAvDmjWqH.DataContext = base.Items[num2];
						num6 = 0;
						if (d0PebAXkFWacHlk3uBS != null)
						{
							goto IL_01cd;
						}
						goto IL_01d1;
					}
					goto IL_01fd;
					IL_01ec:
					pdAvDmjWqH.Measure(base.Viewport);
					goto IL_01fd;
					IL_0241:
					num5++;
					num++;
					continue;
					IL_01cd:
					num6 = num7;
					goto IL_01d1;
				}
			}
		}
	}

	protected override void OnClearChildren()
	{
		base.OnClearChildren();
		pdAvDmjWqH = null;
	}

	protected override GeneratorPosition GetGeneratorPositionFromChildIndex(int childIndex)
	{
		int num = base.InternalChildren.IndexOf(pdAvDmjWqH);
		if (num != -1 && childIndex > num)
		{
			return new GeneratorPosition(childIndex - 1, 0);
		}
		return new GeneratorPosition(childIndex, 0);
	}

	protected override void VirtualizeItems()
	{
		int itemIndex = default(int);
		int num3 = default(int);
		for (int num = base.InternalChildren.Count - 1; num >= 0; num--)
		{
			FrameworkElement frameworkElement = (FrameworkElement)base.InternalChildren[num];
			int num2 = 1;
			if (!YavZxWXacvb0OgxMF2X())
			{
				goto IL_0035;
			}
			goto IL_0069;
			IL_0035:
			if (frameworkElement != pdAvDmjWqH)
			{
				itemIndex = base.Items.IndexOf(frameworkElement.DataContext);
				num2 = 0;
				if (!YavZxWXacvb0OgxMF2X())
				{
					num2 = num3;
				}
				goto IL_0069;
			}
			if (!base.ItemRange.Contains(ml9v4QBU03()))
			{
				pdAvDmjWqH = null;
				RemoveInternalChildRange(num, 1);
			}
			continue;
			IL_0069:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_0076;
			}
			goto IL_0035;
			IL_0076:
			GeneratorPosition position = base.ItemContainerGenerator.GeneratorPositionFromIndex(itemIndex);
			if (!base.ItemRange.Contains(itemIndex))
			{
				if (base.IsRecycling)
				{
					base.ItemContainerGenerator.Recycle(position, 1);
				}
				else
				{
					base.ItemContainerGenerator.Remove(position, 1);
				}
				RemoveInternalChildRange(num, 1);
			}
		}
	}

	protected override void BringIndexIntoView(int index)
	{
		double num = (double)(index / itemsPerRowCount) * GetHeight(childSize);
		if (U4kvdKtPnZ != -1 && index > U4kvdKtPnZ)
		{
			num += GetHeight(pdAvDmjWqH.DesiredSize);
		}
		if (base.Orientation == Orientation.Horizontal)
		{
			SetHorizontalOffset(num);
		}
		else
		{
			SetVerticalOffset(num);
		}
	}

	static VirtualizingWrapPanelWithItemExpansion()
	{
		ExpandedItemTemplateProperty = DependencyProperty.Register("ExpandedItemTemplate", typeof(DataTemplate), typeof(VirtualizingWrapPanelWithItemExpansion), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure));
		ExpandedItemProperty = DependencyProperty.Register("ExpandedItem", typeof(object), typeof(VirtualizingWrapPanelWithItemExpansion), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure, _003C_003Ec.osnvPAMAYLm.lMrvPMiIRnj));
	}

	internal static bool YavZxWXacvb0OgxMF2X()
	{
		return d0PebAXkFWacHlk3uBS == null;
	}
}
