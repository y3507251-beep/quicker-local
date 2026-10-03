using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Quicker.Utilities.UI;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.Controls;

public class RadialMenuItem : Button
{
	public static readonly DependencyProperty IndexProperty;

	public static readonly DependencyProperty CountProperty;

	public static readonly DependencyProperty HalfShiftedProperty;

	public static readonly DependencyProperty CenterXProperty;

	public static readonly DependencyProperty CenterYProperty;

	public static readonly DependencyProperty OuterRadiusProperty;

	public static readonly DependencyProperty InnerRadiusProperty;

	public new static readonly DependencyProperty PaddingProperty;

	public static readonly DependencyProperty ContentRadiusProperty;

	private static readonly Brush ilxLBdK05Dq;

	public static readonly DependencyProperty HoverColorProperty;

	private static readonly Brush fGtLBoe84to;

	public static readonly DependencyProperty ButtonBgProperty;

	private static readonly Brush iPQLBTbdAuj;

	public static readonly DependencyProperty SpaceColorProperty;

	protected static readonly DependencyPropertyKey AngleDeltaPropertyKey;

	public static readonly DependencyProperty AngleDeltaProperty;

	protected static readonly DependencyPropertyKey StartAnglePropertyKey;

	public static readonly DependencyProperty StartAngleProperty;

	protected static readonly DependencyPropertyKey RotationPropertyKey;

	public static readonly DependencyProperty RotationProperty;

	internal static RadialMenuItem r3ibPvFf4qoeHeXecO2B;

	public int Index
	{
		get
		{
			return (int)GetValue(IndexProperty);
		}
		set
		{
			SetValue(IndexProperty, value);
		}
	}

	public int Count
	{
		get
		{
			return (int)GetValue(CountProperty);
		}
		set
		{
			SetValue(CountProperty, value);
		}
	}

	public bool HalfShifted
	{
		get
		{
			return (bool)GetValue(HalfShiftedProperty);
		}
		set
		{
			SetValue(HalfShiftedProperty, value);
		}
	}

	public double CenterX
	{
		get
		{
			return (double)GetValue(CenterXProperty);
		}
		set
		{
			SetValue(CenterXProperty, value);
		}
	}

	public double CenterY
	{
		get
		{
			return (double)GetValue(CenterYProperty);
		}
		set
		{
			SetValue(CenterYProperty, value);
		}
	}

	public double OuterRadius
	{
		get
		{
			return (double)GetValue(OuterRadiusProperty);
		}
		set
		{
			SetValue(OuterRadiusProperty, value);
		}
	}

	public double InnerRadius
	{
		get
		{
			return (double)GetValue(InnerRadiusProperty);
		}
		set
		{
			SetValue(InnerRadiusProperty, value);
		}
	}

	public new double Padding
	{
		get
		{
			return (double)GetValue(PaddingProperty);
		}
		set
		{
			SetValue(PaddingProperty, value);
		}
	}

	public double ContentRadius
	{
		get
		{
			return (double)GetValue(ContentRadiusProperty);
		}
		set
		{
			SetValue(ContentRadiusProperty, value);
		}
	}

	public Brush HoverColor
	{
		get
		{
			return (Brush)GetValue(HoverColorProperty);
		}
		set
		{
			SetValue(HoverColorProperty, value);
		}
	}

	public Brush ButtonBg
	{
		get
		{
			return (Brush)GetValue(ButtonBgProperty);
		}
		set
		{
			SetValue(ButtonBgProperty, value);
		}
	}

	public Brush SpaceColor
	{
		get
		{
			return (Brush)GetValue(SpaceColorProperty);
		}
		set
		{
			SetValue(SpaceColorProperty, value);
		}
	}

	public double AngleDelta
	{
		get
		{
			return (double)GetValue(AngleDeltaProperty);
		}
		protected set
		{
			SetValue(AngleDeltaPropertyKey, value);
		}
	}

	public double StartAngle
	{
		get
		{
			return (double)GetValue(StartAngleProperty);
		}
		protected set
		{
			SetValue(StartAnglePropertyKey, value);
		}
	}

	public double Rotation
	{
		get
		{
			return (double)GetValue(RotationProperty);
		}
		protected set
		{
			SetValue(RotationPropertyKey, value);
		}
	}

	static RadialMenuItem()
	{
		IndexProperty = DependencyProperty.Register("Index", typeof(int), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender, lUTLBDuLoU8));
		CountProperty = DependencyProperty.Register("Count", typeof(int), typeof(RadialMenuItem), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender, lUTLBDuLoU8));
		HalfShiftedProperty = DependencyProperty.Register("HalfShifted", typeof(bool), typeof(RadialMenuItem), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender, lUTLBDuLoU8));
		CenterXProperty = DependencyProperty.Register("CenterX", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		CenterYProperty = DependencyProperty.Register("CenterY", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		OuterRadiusProperty = DependencyProperty.Register("OuterRadius", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		InnerRadiusProperty = DependencyProperty.Register("InnerRadius", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		PaddingProperty = DependencyProperty.Register("Padding", typeof(double), typeof(global::Quicker.View.Controls.RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		ContentRadiusProperty = DependencyProperty.Register("ContentRadius", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		ilxLBdK05Dq = Color.FromArgb(byte.MaxValue, 224, 224, 224).GetBrush();
		HoverColorProperty = DependencyProperty.RegisterAttached("HoverColor", typeof(Brush), typeof(RadialMenuItem), new FrameworkPropertyMetadata(ilxLBdK05Dq, FrameworkPropertyMetadataOptions.Inherits));
		fGtLBoe84to = Brushes.Transparent;
		ButtonBgProperty = DependencyProperty.RegisterAttached("ButtonBg", typeof(Brush), typeof(RadialMenuItem), new FrameworkPropertyMetadata(fGtLBoe84to, FrameworkPropertyMetadataOptions.Inherits));
		iPQLBTbdAuj = Color.FromArgb(byte.MaxValue, 224, 224, 224).GetBrush();
		SpaceColorProperty = DependencyProperty.RegisterAttached("SpaceColor", typeof(Brush), typeof(RadialMenuItem), new FrameworkPropertyMetadata(iPQLBTbdAuj, FrameworkPropertyMetadataOptions.Inherits));
		AngleDeltaPropertyKey = DependencyProperty.RegisterReadOnly("AngleDelta", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(200.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		AngleDeltaProperty = AngleDeltaPropertyKey.DependencyProperty;
		StartAnglePropertyKey = DependencyProperty.RegisterReadOnly("StartAngle", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		StartAngleProperty = StartAnglePropertyKey.DependencyProperty;
		RotationPropertyKey = DependencyProperty.RegisterReadOnly("Rotation", typeof(double), typeof(RadialMenuItem), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		RotationProperty = RotationPropertyKey.DependencyProperty;
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenuItem), new FrameworkPropertyMetadata(typeof(RadialMenuItem)));
	}

	private static void lUTLBDuLoU8(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is RadialMenuItem radialMenuItem)
		{
			double num = 360.0 / (double)radialMenuItem.Count;
			double num2 = (radialMenuItem.HalfShifted ? ((0.0 - num) / 2.0) : 0.0);
			double num3 = num * (double)radialMenuItem.Index + num2;
			double rotation = num3 + num / 2.0;
			int num4 = 0;
			if (!kb7Lv9Ffhhf2xwayh2g8())
			{
				int num5 = default(int);
				num4 = num5;
			}
			switch (num4)
			{
			}
			radialMenuItem.AngleDelta = num;
			radialMenuItem.StartAngle = num3;
			radialMenuItem.Rotation = rotation;
		}
	}

	internal static bool kb7Lv9Ffhhf2xwayh2g8()
	{
		return r3ibPvFf4qoeHeXecO2B == null;
	}
}
