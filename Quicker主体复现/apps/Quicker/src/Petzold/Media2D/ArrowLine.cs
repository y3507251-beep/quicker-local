using System.Windows;
using System.Windows.Media;

namespace Petzold.Media2D;

public class ArrowLine : ArrowLineBase
{
	public static readonly DependencyProperty X1Property;

	public static readonly DependencyProperty Y1Property;

	public static readonly DependencyProperty X2Property;

	public static readonly DependencyProperty Y2Property;

	private static ArrowLine WFCSf0nXcNyhjbV5l3l;

	public double X1
	{
		get
		{
			return (double)GetValue(X1Property);
		}
		set
		{
			SetValue(X1Property, value);
		}
	}

	public double Y1
	{
		get
		{
			return (double)GetValue(Y1Property);
		}
		set
		{
			SetValue(Y1Property, value);
		}
	}

	public double X2
	{
		get
		{
			return (double)GetValue(X2Property);
		}
		set
		{
			SetValue(X2Property, value);
		}
	}

	public double Y2
	{
		get
		{
			return (double)GetValue(Y2Property);
		}
		set
		{
			SetValue(Y2Property, value);
		}
	}

	protected override Geometry DefiningGeometry
	{
		get
		{
			pathgeo.Figures.Clear();
			pathfigLine.StartPoint = new Point(X1, Y1);
			polysegLine.Points.Clear();
			polysegLine.Points.Add(new Point(X2, Y2));
			pathgeo.Figures.Add(pathfigLine);
			return base.DefiningGeometry;
		}
	}

	static ArrowLine()
	{
		X1Property = DependencyProperty.Register("X1", typeof(double), typeof(ArrowLine), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		Y1Property = DependencyProperty.Register("Y1", typeof(double), typeof(ArrowLine), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		X2Property = DependencyProperty.Register("X2", typeof(double), typeof(ArrowLine), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		Y2Property = DependencyProperty.Register("Y2", typeof(double), typeof(ArrowLine), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
	}

	internal static bool L4MEnUn2uUrvikZuYVk()
	{
		return WFCSf0nXcNyhjbV5l3l == null;
	}

	internal static void y67YngnehPhn8M3xBFs()
	{
	}
}
