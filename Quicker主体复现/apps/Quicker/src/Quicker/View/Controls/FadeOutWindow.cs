using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Quicker.View.Controls;

public class FadeOutWindow : Window
{
	public static readonly DependencyProperty FadeOutTimeProperty;

	public static readonly DependencyProperty FadeInTimeProperty;

	private bool hfaLKzWf3Cx;

	private bool fKrLxwHAiu9;

	internal static FadeOutWindow LEjnerFurLv9kqemqx7q;

	public double FadeOutTime
	{
		get
		{
			return (double)GetValue(FadeOutTimeProperty);
		}
		set
		{
			SetValue(FadeOutTimeProperty, value);
		}
	}

	public double FadeInTime
	{
		get
		{
			return (double)GetValue(FadeInTimeProperty);
		}
		set
		{
			SetValue(FadeInTimeProperty, value);
		}
	}

	public FadeOutWindow()
	{
		base.Loaded += YssLKlrgU2m;
		base.Closing += iaqLKiWswbs;
		base.Closed += NetLKFHKdAH;
		base.MouseDoubleClick += doALKU808To;
	}

	private void NetLKFHKdAH(object sender, EventArgs e)
	{
		hfaLKzWf3Cx = true;
	}

	private void doALKU808To(object sender, MouseButtonEventArgs e)
	{
		Lt9LKfgogDO();
	}

	private void YssLKlrgU2m(object sender, RoutedEventArgs e)
	{
		fKrLxwHAiu9 = false;
		if (FadeInTime > 0.0001)
		{
			DoubleAnimation animation = new DoubleAnimation(0.0, 1.0, TimeSpan.FromSeconds(FadeInTime));
			BeginAnimation(UIElement.OpacityProperty, animation);
		}
	}

	private void iaqLKiWswbs(object sender, CancelEventArgs e)
	{
		if (FadeOutTime > 0.0001 && !fKrLxwHAiu9)
		{
			fKrLxwHAiu9 = true;
			e.Cancel = true;
			DoubleAnimation doubleAnimation = new DoubleAnimation(0.0, TimeSpan.FromSeconds(FadeOutTime));
			doubleAnimation.Completed += j1yLK3VY4bk;
			BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
		}
	}

	private void j1yLK3VY4bk(object sender, EventArgs e)
	{
		Lt9LKfgogDO();
	}

	private void Lt9LKfgogDO()
	{
		if (!hfaLKzWf3Cx)
		{
			try
			{
				Close();
			}
			catch
			{
			}
		}
	}

	static FadeOutWindow()
	{
		FadeOutTimeProperty = DependencyProperty.Register("FadeOutTime", typeof(double), typeof(FadeOutWindow), new PropertyMetadata(0.4));
		FadeInTimeProperty = DependencyProperty.Register("FadeInTime", typeof(double), typeof(FadeOutWindow), new PropertyMetadata(0.4));
	}

	internal static bool G4KUoYFuNbMh2M1w1rrS()
	{
		return LEjnerFurLv9kqemqx7q == null;
	}
}
