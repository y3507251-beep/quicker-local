using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace kwxiyoY0T672TddvOF5;

internal class VmTqQjYEDP3SgiEYnkB : Shape
{
	public static readonly DependencyProperty JlrLBrNn90r;

	public static readonly DependencyProperty zV3LBpMQuUJ;

	public static readonly DependencyProperty E7jLBBFE5Sc;

	public static readonly DependencyProperty KGTLBQMgUKf;

	public static readonly DependencyProperty xv8LBjgCTg9;

	public static readonly DependencyProperty NLcLBnUsTDN;

	public static readonly DependencyProperty t70LB4t4ElB;

	public static readonly DependencyProperty BLCLB55gNuN;

	private static VmTqQjYEDP3SgiEYnkB v8qfJOFftYWETHSSusMn;

	public double InnerRadius
	{
		get
		{
			return (double)GetValue(JlrLBrNn90r);
		}
		set
		{
			SetValue(JlrLBrNn90r, value);
		}
	}

	public double OuterRadius
	{
		get
		{
			return (double)GetValue(zV3LBpMQuUJ);
		}
		set
		{
			SetValue(zV3LBpMQuUJ, value);
		}
	}

	public double Padding
	{
		get
		{
			return (double)GetValue(E7jLBBFE5Sc);
		}
		set
		{
			SetValue(E7jLBBFE5Sc, value);
		}
	}

	public double PushOut
	{
		get
		{
			return (double)GetValue(KGTLBQMgUKf);
		}
		set
		{
			SetValue(KGTLBQMgUKf, value);
		}
	}

	public double AngleDelta
	{
		get
		{
			return (double)GetValue(xv8LBjgCTg9);
		}
		set
		{
			SetValue(xv8LBjgCTg9, value);
		}
	}

	public double StartAngle
	{
		get
		{
			return (double)GetValue(NLcLBnUsTDN);
		}
		set
		{
			SetValue(NLcLBnUsTDN, value);
		}
	}

	public double CenterX
	{
		get
		{
			return (double)GetValue(t70LB4t4ElB);
		}
		set
		{
			SetValue(t70LB4t4ElB, value);
		}
	}

	public double CenterY
	{
		get
		{
			return (double)GetValue(BLCLB55gNuN);
		}
		set
		{
			SetValue(BLCLB55gNuN, value);
		}
	}

	protected override Geometry DefiningGeometry
	{
		get
		{
			StreamGeometry streamGeometry = new StreamGeometry();
			streamGeometry.FillRule = FillRule.EvenOdd;
			using (StreamGeometryContext streamGeometryContext_ = streamGeometry.Open())
			{
				GpwLBZ00RGj(streamGeometryContext_);
			}
			streamGeometry.Freeze();
			return streamGeometry;
		}
	}

	static VmTqQjYEDP3SgiEYnkB()
	{
		JlrLBrNn90r = DependencyProperty.Register("InnerRadius", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		zV3LBpMQuUJ = DependencyProperty.Register("OuterRadius", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		E7jLBBFE5Sc = DependencyProperty.Register("Padding", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		KGTLBQMgUKf = DependencyProperty.Register("PushOut", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		xv8LBjgCTg9 = DependencyProperty.Register("AngleDelta", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		NLcLBnUsTDN = DependencyProperty.Register("StartAngle", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		t70LB4t4ElB = DependencyProperty.Register("CenterX", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		BLCLB55gNuN = DependencyProperty.Register("CenterY", typeof(double), typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(VmTqQjYEDP3SgiEYnkB), new FrameworkPropertyMetadata(typeof(VmTqQjYEDP3SgiEYnkB)));
	}

	private void GpwLBZ00RGj(StreamGeometryContext streamGeometryContext_0)
	{
		if (AngleDelta <= 0.0)
		{
			return;
		}
		double num = StartAngle;
		double num2 = AngleDelta;
		double num3 = StartAngle;
		double num4 = AngleDelta;
		Point point_ = new Point(CenterX, CenterY);
		Size size = new Size(OuterRadius, OuterRadius);
		Size size2 = new Size(InnerRadius, InnerRadius);
		Point point = default(Point);
		Point point2 = default(Point);
		if (AngleDelta >= 360.0 && Padding <= 0.0)
		{
			point = VdcLB9KmYd0(point_, num, OuterRadius + PushOut);
			point2 = VdcLB9KmYd0(point_, num + 180.0, OuterRadius + PushOut);
			goto IL_026e;
		}
		if (!(Padding > 0.0))
		{
			goto IL_0182;
		}
		double num5 = 180.0 * (Padding / OuterRadius) / Math.PI;
		double num6 = 180.0 * (Padding / InnerRadius) / Math.PI;
		num += num5;
		num2 -= num5 * 2.0;
		num3 += num6;
		num4 -= num6 * 2.0;
		int num7 = 1;
		if (v8qfJOFftYWETHSSusMn == null)
		{
			goto IL_0168;
		}
		goto IL_0220;
		IL_0168:
		Point point3 = default(Point);
		Point point4 = default(Point);
		bool isLargeArc = default(bool);
		Point point5 = default(Point);
		Point point6 = default(Point);
		bool isLargeArc2 = default(bool);
		switch (num7)
		{
		case 1:
			break;
		default:
			streamGeometryContext_0.LineTo(point3, true, true);
			streamGeometryContext_0.ArcTo(point4, size, 0.0, isLargeArc, SweepDirection.Clockwise, true, true);
			streamGeometryContext_0.LineTo(point5, true, true);
			streamGeometryContext_0.ArcTo(point6, size2, 0.0, isLargeArc2, SweepDirection.Counterclockwise, true, true);
			return;
		case 2:
			goto IL_026e;
		case 3:
			goto IL_02bc;
		}
		goto IL_0182;
		IL_02bc:
		streamGeometryContext_0.ArcTo(point2, size, 0.0, false, SweepDirection.Clockwise, true, true);
		streamGeometryContext_0.ArcTo(point, size, 0.0, false, SweepDirection.Clockwise, true, true);
		Point point7 = default(Point);
		streamGeometryContext_0.LineTo(point7, true, true);
		Point point8 = default(Point);
		streamGeometryContext_0.ArcTo(point8, size2, 0.0, false, SweepDirection.Counterclockwise, true, true);
		streamGeometryContext_0.ArcTo(point7, size2, 0.0, false, SweepDirection.Counterclockwise, true, true);
		return;
		IL_0182:
		point3 = VdcLB9KmYd0(point_, num, OuterRadius + PushOut);
		point4 = VdcLB9KmYd0(point_, num + num2, OuterRadius + PushOut);
		point6 = VdcLB9KmYd0(point_, num3, InnerRadius + PushOut);
		point5 = VdcLB9KmYd0(point_, num3 + num4, InnerRadius + PushOut);
		isLargeArc = num2 > 180.0;
		isLargeArc2 = num4 > 180.0;
		streamGeometryContext_0.BeginFigure(point6, true, true);
		num7 = 0;
		if (v8qfJOFftYWETHSSusMn == null)
		{
			goto IL_0168;
		}
		goto IL_0220;
		IL_026e:
		point7 = VdcLB9KmYd0(point_, num3, InnerRadius + PushOut);
		point8 = VdcLB9KmYd0(point_, num3 + 180.0, InnerRadius + PushOut);
		streamGeometryContext_0.BeginFigure(point7, true, true);
		streamGeometryContext_0.LineTo(point, true, true);
		goto IL_02bc;
		IL_0220:
		int num8 = default(int);
		num7 = num8;
		goto IL_0168;
	}

	private static Point VdcLB9KmYd0(Point point_0, double double_0, double double_1)
	{
		double num = Math.PI / 180.0 * (double_0 - 90.0);
		double num2 = double_1 * Math.Cos(num);
		double num3 = double_1 * Math.Sin(num);
		return new Point(num2 + point_0.X, num3 + point_0.Y);
	}

	internal static bool lsdT24FfSWjtO4RL8Ulh()
	{
		return v8qfJOFftYWETHSSusMn == null;
	}

	internal static void UnPD4TFfmGANtdWGQK5t()
	{
	}
}
