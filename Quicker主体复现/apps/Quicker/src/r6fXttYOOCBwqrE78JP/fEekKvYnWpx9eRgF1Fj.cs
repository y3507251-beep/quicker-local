using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using QesCGrYNOZkMdaTfjcS;

namespace r6fXttYOOCBwqrE78JP;

internal class fEekKvYnWpx9eRgF1Fj : TextBlock
{
	private readonly TextRange V8bLrk7WDLf;

	private TextPointer YqULrG1GlUR;

	private TextPointer I7HLrshbhsv;

	private Point fXlLrHjiZOb;

	private bool N6GLr1r8IFo;

	[CompilerGenerated]
	private double lq3LrbLc5WS;

	[CompilerGenerated]
	private Brush nnwLr6tEMfC = SystemColors.HighlightBrush;

	[CompilerGenerated]
	private Brush sJmLrXfLWVW = SystemColors.HighlightTextBrush;

	[CompilerGenerated]
	private EventHandler? TD2LrmWH6Ud;

	[CompilerGenerated]
	private EventHandler? m_SelectionChanged;

	internal static fEekKvYnWpx9eRgF1Fj ehQ1Q6Fo98ttQgTBaIdR;

	public event EventHandler? OJxLrYdwsqP
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = TD2LrmWH6Ud;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TD2LrmWH6Ud, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = TD2LrmWH6Ud;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TD2LrmWH6Ud, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler? SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public fEekKvYnWpx9eRgF1Fj()
	{
		YqULrG1GlUR = base.ContentStart;
		I7HLrshbhsv = base.ContentStart;
		V8bLrk7WDLf = new TextRange(base.ContentStart, base.ContentStart);
	}

	[SpecialName]
	public string UeWLrvSJ831()
	{
		return V8bLrk7WDLf.Text;
	}

	[SpecialName]
	public void V5xLrSL6BMR(string string_0)
	{
		V8bLrk7WDLf.Text = string_0;
		YqULrG1GlUR = V8bLrk7WDLf.Start;
		I7HLrshbhsv = V8bLrk7WDLf.End;
		rQkLrtC3RXl(V8bLrk7WDLf);
	}

	[SpecialName]
	public TextRange ngfLruCPq8o()
	{
		return V8bLrk7WDLf;
	}

	[SpecialName]
	public int QtNLrJxpNbw()
	{
		return new TextRange(base.ContentStart, V8bLrk7WDLf.Start).Text.Length;
	}

	[SpecialName]
	public void B7rLr0QQkcI(int int_0)
	{
		int num = SAoLrPk1vUO();
		CC5LrgUjksS(V8bLrk7WDLf);
		YqULrG1GlUR = this.xwJLxzir4D2(int_0);
		I7HLrshbhsv = this.xwJLxzir4D2(int_0 + num);
		V8bLrk7WDLf.Select(YqULrG1GlUR, I7HLrshbhsv);
		rQkLrtC3RXl(V8bLrk7WDLf);
	}

	[SpecialName]
	public int SAoLrPk1vUO()
	{
		return V8bLrk7WDLf.Text.Length;
	}

	[SpecialName]
	public void Gk2LrE7f7BU(int int_0)
	{
		int num = QtNLrJxpNbw();
		CC5LrgUjksS(V8bLrk7WDLf);
		I7HLrshbhsv = this.xwJLxzir4D2(int_0 + num);
		YqULrG1GlUR = V8bLrk7WDLf.Start;
		V8bLrk7WDLf.Select(YqULrG1GlUR, I7HLrshbhsv);
		rQkLrtC3RXl(V8bLrk7WDLf);
	}

	[SpecialName]
	[CompilerGenerated]
	public double jaPLr8QdH9s()
	{
		return lq3LrbLc5WS;
	}

	[SpecialName]
	[CompilerGenerated]
	public void IKKLral3QwQ(double double_1)
	{
		lq3LrbLc5WS = double_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Brush jr7LrRrU3Gu()
	{
		return nnwLr6tEMfC;
	}

	[SpecialName]
	[CompilerGenerated]
	public void JpMLrq0ySnn(Brush brush_2)
	{
		nnwLr6tEMfC = brush_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Brush GrsLrVsTW6d()
	{
		return sJmLrXfLWVW;
	}

	[SpecialName]
	[CompilerGenerated]
	public void Bg2LrZIqGu8(Brush brush_2)
	{
		sJmLrXfLWVW = brush_2;
	}

	private void rQkLrtC3RXl(TextRange textRange_1)
	{
		textRange_1.ApplyPropertyValue(TextBlock.ForegroundProperty, GrsLrVsTW6d());
		textRange_1.ApplyPropertyValue(TextBlock.BackgroundProperty, jr7LrRrU3Gu());
	}

	private void CC5LrgUjksS(TextRange textRange_1)
	{
		textRange_1.ApplyPropertyValue(TextBlock.ForegroundProperty, base.Foreground);
		textRange_1.ApplyPropertyValue(TextBlock.BackgroundProperty, base.Background);
	}

	private void lluLrLRbxse()
	{
		if (N6GLr1r8IFo)
		{
			N6GLr1r8IFo = false;
			this.m_SelectionChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		base.OnMouseLeftButtonDown(e);
		CC5LrgUjksS(V8bLrk7WDLf);
		N6GLr1r8IFo = true;
		fXlLrHjiZOb = e.GetPosition(this);
		YqULrG1GlUR = GetPositionFromPoint(fXlLrHjiZOb, true);
		int num = 0;
		if (ehQ1Q6Fo98ttQgTBaIdR != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		I7HLrshbhsv = YqULrG1GlUR;
		V8bLrk7WDLf.Select(YqULrG1GlUR, I7HLrshbhsv);
		TD2LrmWH6Ud?.Invoke(this, EventArgs.Empty);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (!N6GLr1r8IFo)
		{
			return;
		}
		if (e.LeftButton != MouseButtonState.Pressed)
		{
			lluLrLRbxse();
			return;
		}
		TextPointer positionFromPoint = GetPositionFromPoint(e.GetPosition(this), true);
		Point point = default(Point);
		if (I7HLrshbhsv.CompareTo(positionFromPoint) == 0)
		{
			int num = 1;
			if (!vdUDxDFoLpCKmkOXdvPN())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				return;
			}
		}
		else
		{
			CC5LrgUjksS(V8bLrk7WDLf);
			point = fXlLrHjiZOb;
			if (YqULrG1GlUR.CompareTo(positionFromPoint) > 0)
			{
				point.X += jaPLr8QdH9s();
				goto IL_00ae;
			}
		}
		point.X -= jaPLr8QdH9s();
		goto IL_00ae;
		IL_00ae:
		YqULrG1GlUR = GetPositionFromPoint(point, true);
		I7HLrshbhsv = positionFromPoint;
		V8bLrk7WDLf.Select(YqULrG1GlUR, I7HLrshbhsv);
		rQkLrtC3RXl(V8bLrk7WDLf);
		TD2LrmWH6Ud?.Invoke(this, EventArgs.Empty);
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
	{
		base.OnMouseLeftButtonUp(e);
		lluLrLRbxse();
	}

	protected override void OnMouseLeave(MouseEventArgs e)
	{
		base.OnMouseLeave(e);
		lluLrLRbxse();
	}

	internal static bool vdUDxDFoLpCKmkOXdvPN()
	{
		return ehQ1Q6Fo98ttQgTBaIdR == null;
	}
}
