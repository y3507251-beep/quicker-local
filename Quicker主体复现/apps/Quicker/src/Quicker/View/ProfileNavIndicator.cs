using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class ProfileNavIndicator : UserControl, IComponentConnector
{
	private double S6bgA0yeKvL = 10.0;

	private double F0VgACV5hy9 = 5.0;

	[CompilerGenerated]
	private int KH1gAPrm3d0;

	[CompilerGenerated]
	private int fFEgAEiogdh;

	public static readonly DependencyProperty ActiveColorProperty;

	public static readonly DependencyProperty DefaultColorProperty;

	[CompilerGenerated]
	private EventHandler<PointClickedEventArgs> m_PointClicked;

	internal Canvas TheCanvas;

	private bool MIvgAyv8vcx;

	private static ProfileNavIndicator cvuAhUFWVW0ixyc3qDy3;

	public int ActiveIndex
	{
		[CompilerGenerated]
		get
		{
			return KH1gAPrm3d0;
		}
		[CompilerGenerated]
		set
		{
			KH1gAPrm3d0 = value;
		}
	}

	public int ProfileCount
	{
		[CompilerGenerated]
		get
		{
			return fFEgAEiogdh;
		}
		[CompilerGenerated]
		set
		{
			fFEgAEiogdh = value;
		}
	}

	public Color ActiveColor
	{
		get
		{
			return (Color)GetValue(ActiveColorProperty);
		}
		set
		{
			SetValue(ActiveColorProperty, value);
		}
	}

	public Color DefaultColor
	{
		get
		{
			return (Color)GetValue(DefaultColorProperty);
		}
		set
		{
			SetValue(DefaultColorProperty, value);
		}
	}

	public event EventHandler<PointClickedEventArgs> PointClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler<PointClickedEventArgs> eventHandler = this.m_PointClicked;
			EventHandler<PointClickedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PointClickedEventArgs> value2 = (EventHandler<PointClickedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_PointClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<PointClickedEventArgs> eventHandler = this.m_PointClicked;
			EventHandler<PointClickedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PointClickedEventArgs> value2 = (EventHandler<PointClickedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_PointClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ProfileNavIndicator()
	{
		InitializeComponent();
	}

	public void Update(int profileCount, int activeIndex)
	{
		ProfileCount = profileCount;
		ActiveIndex = activeIndex;
		Refresh();
	}

	private void Refresh()
	{
		if (ProfileCount <= 10)
		{
			S6bgA0yeKvL = 10.0;
		}
		else
		{
			S6bgA0yeKvL = 95.0 / (double)(ProfileCount - 1);
		}
		TheCanvas.Width = (double)Math.Max(0, ProfileCount - 1) * S6bgA0yeKvL + 5.0;
		TheCanvas.Height = 5.0;
		foreach (object child in TheCanvas.Children)
		{
			if (child is Ellipse ellipse)
			{
				ellipse.PreviewMouseDown -= QDagANAen2q;
			}
		}
		TheCanvas.Children.Clear();
		if (ProfileCount < 2)
		{
			return;
		}
		int num = 0;
		Ellipse ellipse2 = default(Ellipse);
		while (true)
		{
			int num2;
			if (num < ProfileCount)
			{
				ellipse2 = new Ellipse();
				ellipse2.Height = F0VgACV5hy9;
				ellipse2.Width = F0VgACV5hy9;
				ellipse2.Fill = ((ActiveIndex == num) ? ActiveColor : DefaultColor).GetBrush();
				ellipse2.Tag = num;
				ellipse2.PreviewMouseDown += QDagANAen2q;
				Canvas.SetLeft(ellipse2, 0.0 + (double)num * S6bgA0yeKvL);
				Canvas.SetTop(ellipse2, 0.0);
				num2 = 0;
				if (MYjgwjFWQjgHWiR57YZI())
				{
					goto IL_018b;
				}
			}
			else
			{
				num2 = 0;
				if (!MYjgwjFWQjgHWiR57YZI())
				{
					break;
				}
			}
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			goto IL_018b;
			IL_018b:
			TheCanvas.Children.Add(ellipse2);
			num++;
		}
	}

	private void QDagANAen2q(object sender, MouseButtonEventArgs e)
	{
		this.m_PointClicked?.Invoke(this, new PointClickedEventArgs
		{
			Index = (int)(sender as Ellipse).Tag
		});
	}

	private static void slQgAJCTsaw(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is ProfileNavIndicator)
		{
			((ProfileNavIndicator)dependencyObject_0).Refresh();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!MIvgAyv8vcx)
		{
			MIvgAyv8vcx = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/profilenavindicator.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TheCanvas = (Canvas)target;
		}
		else
		{
			MIvgAyv8vcx = true;
		}
	}

	static ProfileNavIndicator()
	{
		ActiveColorProperty = DependencyProperty.RegisterAttached("ActiveColor", typeof(Color), typeof(ProfileNavIndicator), new FrameworkPropertyMetadata(Color.FromArgb(180, byte.MaxValue, byte.MaxValue, byte.MaxValue), FrameworkPropertyMetadataOptions.Inherits, slQgAJCTsaw));
		DefaultColorProperty = DependencyProperty.RegisterAttached("DefaultColor", typeof(Color), typeof(ProfileNavIndicator), new FrameworkPropertyMetadata(Color.FromArgb(60, 0, 0, 0), FrameworkPropertyMetadataOptions.Inherits, slQgAJCTsaw));
	}

	internal static bool MYjgwjFWQjgHWiR57YZI()
	{
		return cvuAhUFWVW0ixyc3qDy3 == null;
	}
}
