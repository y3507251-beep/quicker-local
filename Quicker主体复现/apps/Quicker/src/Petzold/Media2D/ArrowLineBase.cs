using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using t8SGKhhgLWTgeqjGcrq;

namespace Petzold.Media2D;

public abstract class ArrowLineBase : Shape
{
	protected PathGeometry pathgeo;

	protected PathFigure pathfigLine;

	protected PolyLineSegment polysegLine;

	private PathFigure tKESQn4c0S;

	private PolyLineSegment vBGSj6u9jy;

	private PathFigure uM8SnKqTVO;

	private PolyLineSegment Xw9S4cspve;

	public static readonly DependencyProperty ArrowAngleProperty;

	public static readonly DependencyProperty ArrowLengthProperty;

	public static readonly DependencyProperty ArrowEndsProperty;

	public static readonly DependencyProperty IsArrowClosedProperty;

	internal static ArrowLineBase EajQ1CnDqtZRVHOMHQF;

	public double ArrowAngle
	{
		get
		{
			return (double)GetValue(ArrowAngleProperty);
		}
		set
		{
			SetValue(ArrowAngleProperty, value);
		}
	}

	public double ArrowLength
	{
		get
		{
			return (double)GetValue(ArrowLengthProperty);
		}
		set
		{
			SetValue(ArrowLengthProperty, value);
		}
	}

	public ArrowEnds ArrowEnds
	{
		get
		{
			return (ArrowEnds)GetValue(ArrowEndsProperty);
		}
		set
		{
			SetValue(ArrowEndsProperty, value);
		}
	}

	public bool IsArrowClosed
	{
		get
		{
			return (bool)GetValue(IsArrowClosedProperty);
		}
		set
		{
			SetValue(IsArrowClosedProperty, value);
		}
	}

	protected override Geometry DefiningGeometry
	{
		get
		{
			int count;
			while (true)
			{
				count = polysegLine.Points.Count;
				if (EajQ1CnDqtZRVHOMHQF == null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			if (count > 0)
			{
				if ((ArrowEnds & ArrowEnds.Start) == ArrowEnds.Start)
				{
					Point startPoint = pathfigLine.StartPoint;
					Point point_ = polysegLine.Points[0];
					pathgeo.Figures.Add(vrOSB6pTgy(tKESQn4c0S, point_, startPoint));
				}
				if ((ArrowEnds & ArrowEnds.End) == ArrowEnds.End)
				{
					Point point_2 = ((count == 1) ? pathfigLine.StartPoint : polysegLine.Points[count - 2]);
					Point point_3 = polysegLine.Points[count - 1];
					pathgeo.Figures.Add(vrOSB6pTgy(uM8SnKqTVO, point_2, point_3));
				}
			}
			return pathgeo;
		}
	}

	public ArrowLineBase()
	{
		pathgeo = new PathGeometry();
		pathfigLine = new PathFigure();
		polysegLine = new PolyLineSegment();
		pathfigLine.Segments.Add(polysegLine);
		tKESQn4c0S = new PathFigure();
		vBGSj6u9jy = new PolyLineSegment();
		tKESQn4c0S.Segments.Add(vBGSj6u9jy);
		uM8SnKqTVO = new PathFigure();
		Xw9S4cspve = new PolyLineSegment();
		uM8SnKqTVO.Segments.Add(Xw9S4cspve);
	}

	private PathFigure vrOSB6pTgy(PathFigure pathFigure_2, Point point_0, Point point_1)
	{
		Matrix matrix = default(Matrix);
		Vector vector = point_0 - point_1;
		vector.Normalize();
		vector *= ArrowLength;
		PolyLineSegment obj = pathFigure_2.Segments[0] as PolyLineSegment;
		obj.Points.Clear();
		matrix.Rotate(ArrowAngle / 2.0);
		pathFigure_2.StartPoint = point_1 + vector * matrix;
		obj.Points.Add(point_1);
		matrix.Rotate(0.0 - ArrowAngle);
		obj.Points.Add(point_1 + vector * matrix);
		pathFigure_2.IsClosed = IsArrowClosed;
		return pathFigure_2;
	}

	static ArrowLineBase()
	{
		ArrowAngleProperty = DependencyProperty.Register("ArrowAngle", typeof(double), typeof(ArrowLineBase), new FrameworkPropertyMetadata(45.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		ArrowLengthProperty = DependencyProperty.Register("ArrowLength", typeof(double), typeof(ArrowLineBase), new FrameworkPropertyMetadata(12.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		ArrowEndsProperty = DependencyProperty.Register("ArrowEnds", typeof(global::Petzold.Media2D.ArrowEnds), typeof(ArrowLineBase), new FrameworkPropertyMetadata(ArrowEnds.End, FrameworkPropertyMetadataOptions.AffectsMeasure));
		IsArrowClosedProperty = DependencyProperty.Register("IsArrowClosed", typeof(bool), typeof(ArrowLineBase), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure));
	}

	internal static bool eUiSBJn37phe5338xHv()
	{
		return EajQ1CnDqtZRVHOMHQF == null;
	}

	internal static void FG1NwWnG3tl8YD275I6()
	{
	}
}
