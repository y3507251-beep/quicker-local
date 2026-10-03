using System.Windows;
using System.Windows.Media;

namespace Petzold.Media2D;

public class ArrowPolyline : ArrowLineBase
{
	public static readonly DependencyProperty PointsProperty;

	private static ArrowPolyline hvuur6n1oSLJeFrPUrl;

	public PointCollection Points
	{
		get
		{
			return (PointCollection)GetValue(PointsProperty);
		}
		set
		{
			SetValue(PointsProperty, value);
		}
	}

	protected override Geometry DefiningGeometry
	{
		get
		{
			pathgeo.Figures.Clear();
			if (Points != null && Points.Count > 0)
			{
				pathfigLine.StartPoint = Points[0];
				polysegLine.Points.Clear();
				int i = 1;
				if (!uDkqwmnKv2xlnEuKglu())
				{
					switch (0)
					{
					}
				}
				for (; i < Points.Count; i++)
				{
					polysegLine.Points.Add(Points[i]);
				}
				pathgeo.Figures.Add(pathfigLine);
			}
			return base.DefiningGeometry;
		}
	}

	public ArrowPolyline()
	{
		Points = new PointCollection();
	}

	static ArrowPolyline()
	{
		PointsProperty = DependencyProperty.Register("Points", typeof(PointCollection), typeof(ArrowPolyline), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure));
	}

	internal static bool uDkqwmnKv2xlnEuKglu()
	{
		return hvuur6n1oSLJeFrPUrl == null;
	}
}
