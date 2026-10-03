using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Search;

namespace jP9eLNYkQPso3EI6Xbd;

internal class HBo1sHYHV6mQfeeD9Mu : IBackgroundRenderer
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public int FNZS5MTZ065;

		public int s8XS5AkSsen;

		public Func<ISearchResult, bool> MtPS5OGmlHI;

		internal static _003C_003Ec__DisplayClass11_0 tpI22vWTeGq09FSa3CAS;

		internal bool mWhS5TU7ZPZ(ISearchResult r)
		{
			if (FNZS5MTZ065 <= r.Offset && r.Offset <= s8XS5AkSsen)
			{
				return true;
			}
			if (FNZS5MTZ065 <= r.EndOffset)
			{
				return r.EndOffset <= s8XS5AkSsen;
			}
			return false;
		}

		internal static bool g11N3yWTjLWRPJlrxQUJ()
		{
			return tpI22vWTeGq09FSa3CAS == null;
		}
	}

	private Brush R4RLyInYil0;

	private Pen PR8LyWtE9Z2;

	[CompilerGenerated]
	private readonly List<ISearchResult> FSxLykGlsS2 = new List<ISearchResult>();

	private static HBo1sHYHV6mQfeeD9Mu wrSTHMFGi8LYgI975dsd;

	public KnownLayer Layer => KnownLayer.Selection;

	public Brush MarkerBrush
	{
		get
		{
			return R4RLyInYil0;
		}
		set
		{
			R4RLyInYil0 = value;
			PR8LyWtE9Z2 = new Pen(R4RLyInYil0, 1.0);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ISearchResult> gCpLy947FEV()
	{
		return FSxLykGlsS2;
	}

	public HBo1sHYHV6mQfeeD9Mu()
	{
		R4RLyInYil0 = Brushes.LightGreen;
		PR8LyWtE9Z2 = new Pen(R4RLyInYil0, 1.0);
	}

	public void Draw(TextView textView_0, DrawingContext drawingContext_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		if (textView_0 == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (drawingContext_0 == null)
		{
			throw new ArgumentNullException("drawingContext");
		}
		if (gCpLy947FEV() == null || !textView_0.VisualLinesValid)
		{
			return;
		}
		ReadOnlyCollection<VisualLine> visualLines = textView_0.VisualLines;
		if (visualLines.Count == 0)
		{
			return;
		}
		_003C_003Ec__DisplayClass11_.FNZS5MTZ065 = visualLines.First().FirstDocumentLine.Offset;
		int num = 0;
		if (wrSTHMFGi8LYgI975dsd != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass11_.s8XS5AkSsen = visualLines.Last().LastDocumentLine.EndOffset;
		foreach (ISearchResult item in gCpLy947FEV().Where(_003C_003Ec__DisplayClass11_.MtPS5OGmlHI ?? (_003C_003Ec__DisplayClass11_.MtPS5OGmlHI = _003C_003Ec__DisplayClass11_.mWhS5TU7ZPZ)))
		{
			BackgroundGeometryBuilder backgroundGeometryBuilder = new BackgroundGeometryBuilder();
			backgroundGeometryBuilder.AlignToWholePixels = true;
			backgroundGeometryBuilder.CornerRadius = 3.0;
			backgroundGeometryBuilder.AddSegment(textView_0, item);
			Geometry geometry = backgroundGeometryBuilder.CreateGeometry();
			if (geometry != null)
			{
				drawingContext_0.DrawGeometry(R4RLyInYil0, PR8LyWtE9Z2, geometry);
			}
		}
	}

	internal static bool IOoM4DFGl01YOuNen2aj()
	{
		return wrSTHMFGi8LYgI975dsd == null;
	}
}
