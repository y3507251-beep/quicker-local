using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Rendering;

namespace Waf.DotNetPad.Presentation.Controls;

public class ErrorTextMarkerService : IBackgroundRenderer, IVisualLineTransformer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yGBv81PLxLa;

		public static Func<ErrorTextMarker, bool> q8Kv8bjdsbY;

		internal static _003C_003Ec X6KfyOcGIyg5jaXqnhyw;

		static _003C_003Ec()
		{
			yGBv81PLxLa = new _003C_003Ec();
		}

		internal bool llxv8HRje2T(ErrorTextMarker m)
		{
			return !string.IsNullOrEmpty(m.Message);
		}

		internal static bool Q9yJiRcG6x5jnNkh4X6e()
		{
			return X6KfyOcGIyg5jaXqnhyw == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreatePoints_003Ed__13 : IDisposable, IEnumerable<Point>, IEnumerator<Point>, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private Point _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Point start;

		public Point _003C_003E3__start;

		private double offset;

		public double _003C_003E3__offset;

		private int count;

		public int _003C_003E3__count;

		private int _003Ci_003E5__2;

		internal static _003CCreatePoints_003Ed__13 oCH4PbcGS7Vrb7QWPP5g;

		Point IEnumerator<Point>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CCreatePoints_003Ed__13(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2++;
				break;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				break;
			}
			if (_003Ci_003E5__2 >= count)
			{
				return false;
			}
			_003C_003E2__current = new Point(start.X + (double)_003Ci_003E5__2 * offset, start.Y - (((_003Ci_003E5__2 + 1) % 2 == 0) ? offset : 0.0));
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<Point> IEnumerable<Point>.GetEnumerator()
		{
			_003CCreatePoints_003Ed__13 _003CCreatePoints_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CCreatePoints_003Ed__ = this;
			}
			else
			{
				_003CCreatePoints_003Ed__ = new _003CCreatePoints_003Ed__13(0);
			}
			_003CCreatePoints_003Ed__.start = _003C_003E3__start;
			_003CCreatePoints_003Ed__.offset = _003C_003E3__offset;
			_003CCreatePoints_003Ed__.count = _003C_003E3__count;
			return _003CCreatePoints_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Point>)this).GetEnumerator();
		}

		internal static bool fRlxF0cGwaUyRVjFeYaP()
		{
			return oCH4PbcGS7Vrb7QWPP5g == null;
		}
	}

	private readonly TextEditor textEditor;

	private readonly TextSegmentCollection<ErrorTextMarker> S64R86CUZI;

	private ToolTip? K09RaTkxh1;

	internal static ErrorTextMarkerService VmygDsJQVrbJjDQMPdt;

	public KnownLayer Layer => KnownLayer.Selection;

	public ErrorTextMarkerService(TextEditor textEditor)
	{
		this.textEditor = textEditor;
		S64R86CUZI = new TextSegmentCollection<ErrorTextMarker>(textEditor.Document);
		TextView textView = textEditor.TextArea.TextView;
		textView.BackgroundRenderers.Add(this);
		textView.LineTransformers.Add(this);
		textView.Services.AddService(typeof(ErrorTextMarkerService), this);
		textView.MouseHover += XFGR0pRhUx;
		textView.MouseHoverStopped += sbBRCtrFvH;
		textView.VisualLinesChanged += WeZRPXuWlR;
	}

	public void Create(int offset, int length, string message)
	{
		ErrorTextMarker errorTextMarker = new ErrorTextMarker(offset, length, message, Colors.Red);
		S64R86CUZI.Add(errorTextMarker);
		textEditor.TextArea.TextView.Redraw(errorTextMarker);
	}

	public void Clear()
	{
		ErrorTextMarker[] array = S64R86CUZI.ToArray();
		S64R86CUZI.Clear();
		ErrorTextMarker[] array2 = array;
		foreach (ErrorTextMarker segment in array2)
		{
			textEditor.TextArea.TextView.Redraw(segment);
		}
	}

	public void Draw(TextView textView, DrawingContext drawingContext)
	{
		if (!S64R86CUZI.Any() || !textView.VisualLinesValid)
		{
			return;
		}
		ReadOnlyCollection<VisualLine> visualLines = textView.VisualLines;
		if (visualLines.Count == 0)
		{
			return;
		}
		int offset = visualLines.First().FirstDocumentLine.Offset;
		int endOffset = visualLines.Last().LastDocumentLine.EndOffset;
		int num2 = default(int);
		foreach (ErrorTextMarker item in S64R86CUZI.FindOverlappingSegments(offset, endOffset - offset))
		{
			using IEnumerator<Rect> enumerator2 = BackgroundGeometryBuilder.GetRectsForSegment(textView, item).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				continue;
			}
			Rect current2 = enumerator2.Current;
			Point bottomLeft = current2.BottomLeft;
			Point bottomRight = current2.BottomRight;
			int num = 0;
			if (VmygDsJQVrbJjDQMPdt != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			Pen pen = new Pen(new SolidColorBrush(item.MarkerColor), 1.0);
			pen.Freeze();
			int int_ = Math.Max((int)((bottomRight.X - bottomLeft.X) / 2.5) + 1, 4);
			StreamGeometry streamGeometry = new StreamGeometry();
			using (StreamGeometryContext streamGeometryContext = streamGeometry.Open())
			{
				streamGeometryContext.BeginFigure(bottomLeft, false, false);
				streamGeometryContext.PolyLineTo(nBhREWLFG7(bottomLeft, 2.5, int_).ToArray(), true, false);
			}
			streamGeometry.Freeze();
			drawingContext.DrawGeometry(Brushes.Transparent, pen, streamGeometry);
		}
	}

	public void Transform(ITextRunConstructionContext context, IList<VisualLineElement> elements)
	{
	}

	private void XFGR0pRhUx(object sender, MouseEventArgs e)
	{
		if (!S64R86CUZI.Any())
		{
			return;
		}
		TextViewPosition? positionFloor = textEditor.TextArea.TextView.GetPositionFloor(e.GetPosition(textEditor.TextArea.TextView) + textEditor.TextArea.TextView.ScrollOffset);
		if (!positionFloor.HasValue)
		{
			return;
		}
		TextLocation location = positionFloor.Value.Location;
		int offset = textEditor.Document.GetOffset(location);
		ErrorTextMarker errorTextMarker = S64R86CUZI.FindSegmentsContaining(offset).LastOrDefault(_003C_003Ec.q8Kv8bjdsbY ?? (_003C_003Ec.q8Kv8bjdsbY = _003C_003Ec.yGBv81PLxLa.llxv8HRje2T));
		if (errorTextMarker != null && K09RaTkxh1 == null)
		{
			K09RaTkxh1 = new ToolTip();
			K09RaTkxh1.Closed += btURyUaUOl;
			K09RaTkxh1.PlacementTarget = textEditor;
			K09RaTkxh1.Content = new TextBlock
			{
				Text = errorTextMarker.Message,
				TextWrapping = TextWrapping.Wrap
			};
			int num = 0;
			if (!WoiZH2JFAB31xqB2j3e())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			K09RaTkxh1.IsOpen = true;
			e.Handled = true;
		}
	}

	private void sbBRCtrFvH(object sender, MouseEventArgs e)
	{
		if (K09RaTkxh1 != null)
		{
			K09RaTkxh1.IsOpen = false;
			e.Handled = true;
		}
	}

	private void WeZRPXuWlR(object? sender, EventArgs e)
	{
		if (K09RaTkxh1 != null)
		{
			K09RaTkxh1.IsOpen = false;
		}
	}

	[IteratorStateMachine(typeof(_003CCreatePoints_003Ed__13))]
	private static IEnumerable<Point> nBhREWLFG7(Point point_0, double double_0, int int_0)
	{
		return new _003CCreatePoints_003Ed__13(-2)
		{
			_003C_003E3__start = point_0,
			_003C_003E3__offset = double_0,
			_003C_003E3__count = int_0
		};
	}

	[CompilerGenerated]
	private void btURyUaUOl(object sender, RoutedEventArgs e)
	{
		K09RaTkxh1 = null;
	}

	internal static bool WoiZH2JFAB31xqB2j3e()
	{
		return VmygDsJQVrbJjDQMPdt == null;
	}
}
