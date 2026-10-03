using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Quicker.Utilities;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View;

public class HelpLinkControl : Control
{
	public static readonly DependencyProperty TextProperty;

	[CompilerGenerated]
	private int uwSgQxOgC9W;

	[CompilerGenerated]
	private string nnBgQrnyWXH;

	[CompilerGenerated]
	private string SIEgQpU5OMh;

	private static HelpLinkControl LqqSkjQzrVry8X5A0nYQ;

	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public int RedirectId
	{
		[CompilerGenerated]
		get
		{
			return uwSgQxOgC9W;
		}
		[CompilerGenerated]
		set
		{
			uwSgQxOgC9W = value;
		}
	}

	public string PageTitle
	{
		[CompilerGenerated]
		get
		{
			return nnBgQrnyWXH;
		}
		[CompilerGenerated]
		set
		{
			nnBgQrnyWXH = value;
		}
	}

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return SIEgQpU5OMh;
		}
		[CompilerGenerated]
		set
		{
			SIEgQpU5OMh = value;
		}
	}

	static HelpLinkControl()
	{
		TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(global::Quicker.View.HelpLinkControl), new PropertyMetadata("查看帮助"));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HelpLinkControl), new FrameworkPropertyMetadata(typeof(HelpLinkControl)));
	}

	public HelpLinkControl()
	{
		base.Focusable = false;
		base.IsTabStop = false;
		base.MouseLeftButtonDown += qZTgQKwwTLi;
	}

	private void qZTgQKwwTLi(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			if (!string.IsNullOrEmpty(Url))
			{
				AppHelper.TryOpenUrlOrFile(Url);
			}
			else
			{
				AppHelper.TryOpenUrlOrFile(AppHelper.CreateHelpLink(RedirectId, PageTitle));
			}
		}
		else if (e.ChangedButton == MouseButton.Right)
		{
			if (!string.IsNullOrEmpty(Url))
			{
				AppHelper.TryCopy(Url, true);
			}
			else
			{
				AppHelper.TryCopy(AppHelper.CreateHelpLink(RedirectId, PageTitle), true);
			}
		}
	}

	internal static bool WgFAWHQzNOKWJL5URoW9()
	{
		return LqqSkjQzrVry8X5A0nYQ == null;
	}
}
