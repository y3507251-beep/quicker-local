using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Petzold.Media2D;

namespace Quicker.View.Mouse;

public class GesturePreviewControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec sWTSpoOEeur;

		public static Func<Point, double> LPUSpT0349B;

		public static Func<Point, double> erMSpMFAM33;

		public static Func<Point, double> FaVSpAaYwJh;

		public static Func<Point, double> O6ZSpOq4qlJ;

		private static _003C_003Ec BVLBUtWUtnGJ4c3sVAMx;

		static _003C_003Ec()
		{
			sWTSpoOEeur = new _003C_003Ec();
		}

		internal double L6pSp4jlwmn(Point x)
		{
			return x.X;
		}

		internal double x30Sp5xKbOU(Point x)
		{
			return x.X;
		}

		internal double cfoSpDBKjFT(Point x)
		{
			return x.Y;
		}

		internal double PBrSpdCJ5Fk(Point x)
		{
			return x.Y;
		}

		internal static bool ClwjnoWUSLjqMGegCSfw()
		{
			return BVLBUtWUtnGJ4c3sVAMx == null;
		}
	}

	public static readonly DependencyProperty PointsProperty;

	public static readonly DependencyProperty LineColorProperty;

	internal GesturePreviewControl TheControl;

	internal ArrowPolyline ThePath;

	private bool k3ALLlaAEJK;

	internal static GesturePreviewControl xZhJTBFAlEMNXLNeorjw;

	public IList<Point> Points
	{
		get
		{
			return (IList<Point>)GetValue(PointsProperty);
		}
		set
		{
			SetValue(PointsProperty, value);
		}
	}

	public Brush LineColor
	{
		get
		{
			return (Brush)GetValue(LineColorProperty);
		}
		set
		{
			SetValue(LineColorProperty, value);
		}
	}

	public GesturePreviewControl()
	{
		InitializeComponent();
	}

	private static void oJpLLFTLffk(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		(dependencyObject_0 as GesturePreviewControl).vcXLLU5vnQq();
	}

	private void vcXLLU5vnQq()
	{
		if (Points != null && Points.Count >= 2)
		{
			ThePath.Visibility = Visibility.Visible;
			double num = Points.Min(_003C_003Ec.LPUSpT0349B ?? (_003C_003Ec.LPUSpT0349B = _003C_003Ec.sWTSpoOEeur.L6pSp4jlwmn));
			double num2 = Points.Max(_003C_003Ec.erMSpMFAM33 ?? (_003C_003Ec.erMSpMFAM33 = _003C_003Ec.sWTSpoOEeur.x30Sp5xKbOU));
			double num3 = Points.Min(_003C_003Ec.FaVSpAaYwJh ?? (_003C_003Ec.FaVSpAaYwJh = _003C_003Ec.sWTSpoOEeur.cfoSpDBKjFT));
			if (xZhJTBFAlEMNXLNeorjw == null)
			{
				switch (0)
				{
				}
			}
			double num4 = Points.Max(_003C_003Ec.O6ZSpOq4qlJ ?? (_003C_003Ec.O6ZSpOq4qlJ = _003C_003Ec.sWTSpoOEeur.PBrSpdCJ5Fk));
			PointCollection pointCollection = new PointCollection();
			int num5 = 100;
			double num6 = (num2 - num) / 90.0;
			double num7 = (num4 - num3) / 90.0;
			double num8 = ((num6 > num7) ? num6 : num7);
			double num9 = (num2 + num) / num8 / 2.0 - (double)(num5 / 2);
			double num10 = (num4 + num3) / num8 / 2.0 - (double)(num5 / 2);
			for (int i = 0; i < Points.Count; i++)
			{
				pointCollection.Add(new Point(Points[i].X / num8 - num9, Points[i].Y / num8 - num10));
			}
			ThePath.Points = pointCollection;
		}
		else
		{
			ThePath.Points = null;
			ThePath.Visibility = Visibility.Collapsed;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!k3ALLlaAEJK)
		{
			k3ALLlaAEJK = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/gesturepreviewcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			k3ALLlaAEJK = true;
			break;
		case 2:
			ThePath = (ArrowPolyline)target;
			break;
		case 1:
			TheControl = (GesturePreviewControl)target;
			break;
		}
	}

	static GesturePreviewControl()
	{
		PointsProperty = DependencyProperty.Register("Points", typeof(IList<Point>), typeof(GesturePreviewControl), new PropertyMetadata(null, oJpLLFTLffk));
		LineColorProperty = DependencyProperty.Register("LineColor", typeof(Brush), typeof(GesturePreviewControl), new PropertyMetadata(Brushes.DodgerBlue));
	}

	internal static bool In2XwfFAZqDUWH2KrIIY()
	{
		return xZhJTBFAlEMNXLNeorjw == null;
	}
}
