using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;

namespace Quicker.Modules.Gesture;

internal class GestureVisualHost : FrameworkElement
{
	private VisualCollection soEO66urvf;

	private Point? xrKOX4s4KG;

	private DrawingVisual ksPOmLet7k = new DrawingVisual();

	private StylusPointCollection y9eOKNsJnt;

	private Stroke ayXOxT6nVC;

	private DrawingAttributes A6nOrLxdei;

	private string tS6OpIyg8i;

	private Brush AnWOBReYgP;

	private Typeface vbsOQWTeEB;

	private string einOjKuYsY;

	private FormattedText EvgOnOShXi;

	internal static GestureVisualHost We6J9nz3fxMB99cQagj;

	protected override int VisualChildrenCount => soEO66urvf.Count;

	public GestureVisualHost()
	{
		soEO66urvf = new VisualCollection(this);
		soEO66urvf.Add(ksPOmLet7k);
		RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.LowQuality);
		A6nOrLxdei = new DrawingAttributes
		{
			Color = ColorHelper.StringToColor(AppState.HHxtaMaoqJr().GestureInvalidColor),
			Width = AppState.HHxtaMaoqJr().GestureStrokeThickness,
			Height = AppState.HHxtaMaoqJr().GestureStrokeThickness,
			FitToCurve = false
		};
	}

	public void gyAOGICo7P(IList<Point> ilist_0)
	{
		if (!ilist_0.HasData())
		{
			return;
		}
		if (ilist_0.Count == 1)
		{
			using DrawingContext drawingContext = ksPOmLet7k.RenderOpen();
			drawingContext.DrawEllipse(Brushes.DodgerBlue, null, ilist_0[0], 5.0, 5.0);
		}
		xrKOX4s4KG = ilist_0.Last();
		y9eOKNsJnt = new StylusPointCollection();
		foreach (Point item in ilist_0)
		{
			y9eOKNsJnt.Add(new StylusPoint(item.X, item.Y));
		}
		ayXOxT6nVC = new Stroke(y9eOKNsJnt, A6nOrLxdei.Clone());
	}

	public void QNyOsjmGZK(Point point_0)
	{
		if (ayXOxT6nVC != null)
		{
			y9eOKNsJnt.Add(new StylusPoint(point_0.X, point_0.Y));
			Refresh();
			xrKOX4s4KG = point_0;
		}
	}

	public void i3VOHuBWyE(string string_1)
	{
		if (string.Equals(string_1, tS6OpIyg8i, StringComparison.Ordinal))
		{
			return;
		}
		tS6OpIyg8i = string_1;
		if (tS6OpIyg8i == null)
		{
			EvgOnOShXi = null;
			if (HMXMNgzEmQWJTBr77T5())
			{
				switch (0)
				{
				}
			}
			return;
		}
		if (AnWOBReYgP == null || !string.Equals(einOjKuYsY, AppState.HHxtaMaoqJr().GestureValidColor))
		{
			AnWOBReYgP = new SolidColorBrush(ColorHelper.StringToColor(AppState.HHxtaMaoqJr().GestureValidColor));
			einOjKuYsY = AppState.HHxtaMaoqJr().GestureValidColor;
		}
		if (vbsOQWTeEB == null)
		{
			vbsOQWTeEB = new Typeface("");
		}
		EvgOnOShXi = new FormattedText(tS6OpIyg8i, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, vbsOQWTeEB, 20.0, AnWOBReYgP, 1.0);
	}

	public void Refresh()
	{
		DrawingContext drawingContext = ksPOmLet7k.RenderOpen();
		if (ayXOxT6nVC != null)
		{
			ayXOxT6nVC.Draw(drawingContext);
			if (tS6OpIyg8i != null)
			{
				StylusPoint stylusPoint = ayXOxT6nVC.StylusPoints.Last();
				drawingContext.DrawText(EvgOnOShXi, new Point(stylusPoint.X + 30.0, stylusPoint.Y + 30.0));
			}
		}
		drawingContext.Close();
	}

	public void End()
	{
		xrKOX4s4KG = null;
		ayXOxT6nVC = null;
		tS6OpIyg8i = null;
	}

	private void nhvO1JtHaK(object sender, MouseButtonEventArgs e)
	{
	}

	protected override Visual GetVisualChild(int index)
	{
		if (index < 0 || index >= soEO66urvf.Count)
		{
			throw new ArgumentOutOfRangeException();
		}
		return soEO66urvf[index];
	}

	public void N6DObwTR7p(Color color_0)
	{
		if (ayXOxT6nVC != null)
		{
			ayXOxT6nVC.DrawingAttributes.Color = color_0;
			Refresh();
		}
	}

	public void UpdateSettings()
	{
		A6nOrLxdei.Color = ColorHelper.StringToColor(AppState.HHxtaMaoqJr().GestureInvalidColor);
		A6nOrLxdei.Width = AppState.HHxtaMaoqJr().GestureStrokeThickness;
		A6nOrLxdei.Height = AppState.HHxtaMaoqJr().GestureStrokeThickness;
		A6nOrLxdei.FitToCurve = false;
	}

	internal static bool HMXMNgzEmQWJTBr77T5()
	{
		return We6J9nz3fxMB99cQagj == null;
	}
}
