using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SnipInsight.Util;

public static class AnimationUtilities
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIElement VWnvCD45lcY;

		internal static _003C_003Ec__DisplayClass40_0 pyEoG6cX4pGilyAwZMbh;

		internal void jhwvC50dHax(object sender, EventArgs e)
		{
			wjjostZFp(VWnvCD45lcY);
		}

		internal static bool B3k8R5cXhI2ccZk5Zxq9()
		{
			return pyEoG6cX4pGilyAwZMbh == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public UIElement Ut2vCoPWh2c;

		internal static _003C_003Ec__DisplayClass41_0 O3KtRjcXzGFqxErorJxy;

		internal void DisvCdVT7Ga(object sender, EventArgs e)
		{
			wjjostZFp(Ut2vCoPWh2c);
			HuLTXUlQN(Ut2vCoPWh2c);
		}

		internal static void GDG195c2FColbNvX1x0E()
		{
		}

		internal static bool Ojg01Kc2VamMBRITV52d()
		{
			return O3KtRjcXzGFqxErorJxy == null;
		}
	}

	public static PropertyPath CanvasLeftPropertyPath;

	public static PropertyPath CanvasTopPropertyPath;

	public static PropertyPath GradientStopColorPropertyPath;

	public static PropertyPath HeightPropertyPath;

	public static PropertyPath WidthPropertyPath;

	public static PropertyPath OpacityPropertyPath;

	public static PropertyPath SolidColorBrushColorPropertyPath;

	public static PropertyPath ScaleXPropertyPath;

	public static PropertyPath ScaleYPropertyPath;

	public static PropertyPath TranslateTransformXPropertyPath;

	public static PropertyPath TranslateTransformYPropertyPath;

	public static PropertyPath VisibilityPropertyPath;

	internal static object EbGuHvWjiS9PPcGpyD0;

	public static ColorAnimation CreateColorAnimation(Color? from, Color? to)
	{
		return new ColorAnimation
		{
			From = from,
			To = to
		};
	}

	public static ColorAnimation CreateColorAnimation(int durationInMilliseconds, Color? from, Color? to)
	{
		ColorAnimation colorAnimation = CreateColorAnimation(from, to);
		colorAnimation.Duration = CreateDuration(durationInMilliseconds);
		return colorAnimation;
	}

	public static ColorAnimation CreateColorAnimation(PropertyPath path, int durationInMilliseconds, Color? from, Color? to)
	{
		ColorAnimation colorAnimation = CreateColorAnimation(durationInMilliseconds, from, to);
		SetTargetProperty(colorAnimation, path);
		return colorAnimation;
	}

	public static ColorAnimation CreateColorAnimation(DependencyObject element, PropertyPath path, int durationInMilliseconds, Color? from, Color? to)
	{
		ColorAnimation colorAnimation = CreateColorAnimation(durationInMilliseconds, from, to);
		SetTargetProperty(colorAnimation, element, path);
		return colorAnimation;
	}

	public static DoubleAnimation CreateDoubleAnimation(double? from, double? to)
	{
		return new DoubleAnimation
		{
			From = from,
			To = to
		};
	}

	public static DoubleAnimation CreateDoubleAnimation(int durationInMilliseconds, double? from, double? to)
	{
		DoubleAnimation doubleAnimation = CreateDoubleAnimation(from, to);
		doubleAnimation.Duration = CreateDuration(durationInMilliseconds);
		return doubleAnimation;
	}

	public static DoubleAnimation CreateDoubleAnimation(PropertyPath path, int durationInMilliseconds, double? from, double? to)
	{
		DoubleAnimation doubleAnimation = CreateDoubleAnimation(durationInMilliseconds, from, to);
		SetTargetProperty(doubleAnimation, path);
		return doubleAnimation;
	}

	public static DoubleAnimation CreateDoubleAnimation(DependencyObject element, PropertyPath path, int durationInMilliseconds, double? from, double? to)
	{
		DoubleAnimation doubleAnimation = CreateDoubleAnimation(durationInMilliseconds, from, to);
		SetTargetProperty(doubleAnimation, element, path);
		return doubleAnimation;
	}

	public static DoubleAnimation CreateOpacityAnimation(int durationInMilliseconds, double? from, double? to)
	{
		return CreateDoubleAnimation(OpacityPropertyPath, durationInMilliseconds, from, to);
	}

	public static DoubleAnimation CreateOpacityAnimation(DependencyObject element, int durationInMilliseconds, double? from, double? to)
	{
		return CreateDoubleAnimation(element, OpacityPropertyPath, durationInMilliseconds, from, to);
	}

	public static DoubleAnimation CreateFadeInAnimation(int durationInMilliseconds)
	{
		return CreateOpacityAnimation(durationInMilliseconds, null, 1.0);
	}

	public static DoubleAnimation CreateFadeInAnimation(DependencyObject element, int durationInMilliseconds)
	{
		return CreateOpacityAnimation(element, durationInMilliseconds, null, 1.0);
	}

	public static Storyboard CreateFadeInStoryboard(DependencyObject element, int durationInMilliseconds)
	{
		return CreateStoryboard(CreateFadeInAnimation(element, durationInMilliseconds));
	}

	public static DoubleAnimation CreateFadeOutAnimation(int durationInMilliseconds)
	{
		return CreateOpacityAnimation(durationInMilliseconds, null, 0.0);
	}

	public static DoubleAnimation CreateFadeOutAnimation(DependencyObject element, int durationInMilliseconds)
	{
		return CreateOpacityAnimation(element, durationInMilliseconds, null, 0.0);
	}

	private static Storyboard jFEnOJyeO(UIElement uielement_0, int int_0)
	{
		return MktDDcAAC(uielement_0, int_0, false, false);
	}

	private static Storyboard wVR4ae9td(UIElement uielement_0, int int_0)
	{
		return MktDDcAAC(uielement_0, int_0, true, false);
	}

	private static Storyboard jdE5pV6Qy(UIElement uielement_0, int int_0)
	{
		return MktDDcAAC(uielement_0, int_0, false, true);
	}

	private static Storyboard MktDDcAAC(UIElement uielement_0, int int_0, bool bool_0, bool bool_1)
	{
		Storyboard storyboard = CreateStoryboard(CreateFadeOutAnimation(uielement_0, int_0));
		if (bool_1)
		{
			AddRemoveOnComplete(storyboard, uielement_0);
		}
		else if (bool_0)
		{
			AddHideOnComplete(storyboard, uielement_0);
		}
		return storyboard;
	}

	public static Storyboard FadeIn(this UIElement element, int durationInMilliseconds)
	{
		Storyboard storyboard = CreateStoryboard(CreateFadeInAnimation(element, durationInMilliseconds));
		element.Visibility = Visibility.Visible;
		storyboard.Begin();
		return storyboard;
	}

	public static Storyboard FadeOut(this UIElement element, int durationInMilliseconds)
	{
		return aLad2Oq7v(element, durationInMilliseconds, false, false);
	}

	public static Storyboard FadeOutAndHide(this UIElement element, int durationInMilliseconds)
	{
		return aLad2Oq7v(element, durationInMilliseconds, true, false);
	}

	public static Storyboard FadeOutAndRemove(this UIElement element, int durationInMilliseconds)
	{
		return aLad2Oq7v(element, durationInMilliseconds, false, true);
	}

	private static Storyboard aLad2Oq7v(UIElement uielement_0, int int_0, bool bool_0, bool bool_1)
	{
		Storyboard storyboard = MktDDcAAC(uielement_0, int_0, bool_0, bool_1);
		storyboard.Begin();
		return storyboard;
	}

	public static Storyboard CreateStoryboard(AnimationTimeline timeline)
	{
		return new Storyboard
		{
			Children = { (Timeline)timeline }
		};
	}

	public static void SetTargetProperty(AnimationTimeline timeline, PropertyPath path)
	{
		Storyboard.SetTargetProperty(timeline, path);
	}

	public static void SetTarget(AnimationTimeline timeline, DependencyObject element)
	{
		Storyboard.SetTarget(timeline, element);
	}

	public static void SetTargetProperty(AnimationTimeline timeline, DependencyObject element, PropertyPath path)
	{
		SetTarget(timeline, element);
		SetTargetProperty(timeline, path);
	}

	public static void AddHideOnComplete(Storyboard storyboard, UIElement element)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.VWnvCD45lcY = element;
		storyboard.Completed += _003C_003Ec__DisplayClass40_.jhwvC50dHax;
	}

	public static void AddRemoveOnComplete(Storyboard storyboard, UIElement element)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.Ut2vCoPWh2c = element;
		storyboard.Completed += _003C_003Ec__DisplayClass41_.DisvCdVT7Ga;
	}

	private static void wjjostZFp(UIElement uielement_0)
	{
		uielement_0.Visibility = Visibility.Collapsed;
	}

	private static void HuLTXUlQN(UIElement uielement_0)
	{
		if (uielement_0 is FrameworkElement { Parent: not null } frameworkElement && frameworkElement.Parent is Panel)
		{
			((Panel)frameworkElement.Parent).Children.Remove(uielement_0);
		}
	}

	public static Duration CreateDuration(int milliseconds)
	{
		return new Duration(TimeSpan.FromMilliseconds(milliseconds));
	}

	public static KeyTime CreateKeyTime(int milliseconds)
	{
		return KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(milliseconds));
	}

	static AnimationUtilities()
	{
		CanvasLeftPropertyPath = new PropertyPath(Canvas.LeftProperty);
		CanvasTopPropertyPath = new PropertyPath(Canvas.TopProperty);
		GradientStopColorPropertyPath = new PropertyPath(GradientStop.ColorProperty);
		HeightPropertyPath = new PropertyPath(FrameworkElement.HeightProperty);
		WidthPropertyPath = new PropertyPath(FrameworkElement.WidthProperty);
		OpacityPropertyPath = new PropertyPath(UIElement.OpacityProperty);
		SolidColorBrushColorPropertyPath = new PropertyPath(SolidColorBrush.ColorProperty);
		ScaleXPropertyPath = new PropertyPath(ScaleTransform.ScaleXProperty);
		ScaleYPropertyPath = new PropertyPath(ScaleTransform.ScaleYProperty);
		TranslateTransformXPropertyPath = new PropertyPath(TranslateTransform.XProperty);
		TranslateTransformYPropertyPath = new PropertyPath(TranslateTransform.YProperty);
		VisibilityPropertyPath = new PropertyPath(UIElement.VisibilityProperty);
	}

	internal static bool wnC4pfWD9iRmreNMl7Q()
	{
		return EbGuHvWjiS9PPcGpyD0 == null;
	}
}
