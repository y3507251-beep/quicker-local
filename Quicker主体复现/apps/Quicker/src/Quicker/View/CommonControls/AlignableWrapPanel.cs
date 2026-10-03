using System;
using System.Windows;
using System.Windows.Controls;

namespace Quicker.View.CommonControls;

public class AlignableWrapPanel : Panel
{
	public static readonly DependencyProperty HorizontalContentAlignmentProperty;

	internal static AlignableWrapPanel OOhoQtFn8pDkFFw0Agah;

	public HorizontalAlignment HorizontalContentAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(HorizontalContentAlignmentProperty);
		}
		set
		{
			SetValue(HorizontalContentAlignmentProperty, value);
		}
	}

	protected override Size MeasureOverride(Size constraint)
	{
		Size size = default(Size);
		Size result = default(Size);
		UIElementCollection internalChildren = base.InternalChildren;
		int num2 = default(int);
		for (int i = 0; i < internalChildren.Count; i++)
		{
			UIElement uIElement = internalChildren[i];
			uIElement.Measure(constraint);
			Size desiredSize = uIElement.DesiredSize;
			int num = 0;
			if (!aqTepUFnRGytSYHTaMlF())
			{
				goto IL_0047;
			}
			goto IL_00d3;
			IL_00d3:
			switch (num)
			{
			case 1:
				goto IL_0116;
			}
			goto IL_0047;
			IL_0116:
			result.Height += desiredSize.Height;
			size = default(Size);
			continue;
			IL_0047:
			if (size.Width + desiredSize.Width > constraint.Width)
			{
				result.Width = Math.Max(size.Width, result.Width);
				result.Height += size.Height;
				size = desiredSize;
				if (!(desiredSize.Width > constraint.Width))
				{
					continue;
				}
				result.Width = Math.Max(desiredSize.Width, result.Width);
				num = 1;
				if (OOhoQtFn8pDkFFw0Agah != null)
				{
					num = num2;
				}
				goto IL_00d3;
			}
			size.Width += desiredSize.Width;
			size.Height = Math.Max(desiredSize.Height, size.Height);
		}
		result.Width = Math.Max(size.Width, result.Width);
		result.Height += size.Height;
		return result;
	}

	protected override Size ArrangeOverride(Size arrangeBounds)
	{
		int num = 0;
		Size size_ = default(Size);
		double num2 = 0.0;
		UIElementCollection internalChildren = base.InternalChildren;
		int num3 = 0;
		int num5 = default(int);
		while (num3 < internalChildren.Count)
		{
			Size desiredSize = internalChildren[num3].DesiredSize;
			int num4 = 0;
			if (!aqTepUFnRGytSYHTaMlF())
			{
				goto IL_0099;
			}
			goto IL_009d;
			IL_0099:
			num4 = num5;
			goto IL_009d;
			IL_009d:
			while (true)
			{
				switch (num4)
				{
				case 1:
					goto IL_0113;
				}
				if (size_.Width + desiredSize.Width <= arrangeBounds.Width)
				{
					size_.Width += desiredSize.Width;
					size_.Height = Math.Max(desiredSize.Height, size_.Height);
					num4 = 1;
					if (OOhoQtFn8pDkFFw0Agah != null)
					{
						break;
					}
					continue;
				}
				pL1Lvz51kOX(num2, size_, arrangeBounds.Width, num, num3);
				num2 += size_.Height;
				size_ = desiredSize;
				if (desiredSize.Width > arrangeBounds.Width)
				{
					pL1Lvz51kOX(num2, desiredSize, arrangeBounds.Width, num3, ++num3);
					num2 += desiredSize.Height;
					size_ = default(Size);
				}
				num = num3;
				goto IL_0113;
				IL_0113:
				num3++;
				goto IL_0119;
			}
			goto IL_0099;
			IL_0119:;
		}
		if (num < internalChildren.Count)
		{
			pL1Lvz51kOX(num2, size_, arrangeBounds.Width, num, internalChildren.Count);
		}
		return arrangeBounds;
	}

	private void pL1Lvz51kOX(double double_0, Size size_0, double double_1, int int_0, int int_1)
	{
		double num = 0.0;
		if (HorizontalContentAlignment == HorizontalAlignment.Center)
		{
			num = (double_1 - size_0.Width) / 2.0;
		}
		else if (HorizontalContentAlignment == HorizontalAlignment.Right)
		{
			num = double_1 - size_0.Width;
			if (aqTepUFnRGytSYHTaMlF())
			{
				switch (0)
				{
				}
			}
		}
		UIElementCollection internalChildren = base.InternalChildren;
		for (int i = int_0; i < int_1; i++)
		{
			UIElement uIElement = internalChildren[i];
			uIElement.Arrange(new Rect(num, double_0, uIElement.DesiredSize.Width, size_0.Height));
			num += uIElement.DesiredSize.Width;
		}
	}

	static AlignableWrapPanel()
	{
		HorizontalContentAlignmentProperty = DependencyProperty.Register("HorizontalContentAlignment", typeof(HorizontalAlignment), typeof(AlignableWrapPanel), new FrameworkPropertyMetadata(HorizontalAlignment.Left, FrameworkPropertyMetadataOptions.AffectsArrange));
	}

	internal static bool aqTepUFnRGytSYHTaMlF()
	{
		return OOhoQtFn8pDkFFw0Agah == null;
	}
}
