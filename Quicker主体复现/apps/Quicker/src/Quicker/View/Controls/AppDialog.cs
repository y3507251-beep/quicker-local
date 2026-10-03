using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using HandyControl.Interactivity;
using HandyControl.Tools;

namespace Quicker.View.Controls;

public class AppDialog : ContentControl
{
	private AdornerContainer lLJLjd3163o;

	private static readonly Dictionary<string, FrameworkElement> VHeLjomTC4P;

	public static readonly DependencyProperty IsClosedProperty;

	private Window hIQLjTafwPT;

	private Action j15LjMnXeRu;

	private IInputElement dQVLjATchOT;

	[CompilerGenerated]
	private bool hfSLjOuH52y;

	private static AppDialog sA5ukZFqq4KGmLFEo3YP;

	public bool IsClosed
	{
		get
		{
			return (bool)GetValue(IsClosedProperty);
		}
		internal set
		{
			SetValue(IsClosedProperty, value);
		}
	}

	public bool IsConfirmed
	{
		[CompilerGenerated]
		get
		{
			return hfSLjOuH52y;
		}
		[CompilerGenerated]
		set
		{
			hfSLjOuH52y = value;
		}
	}

	public AppDialog()
	{
		base.CommandBindings.Add(new CommandBinding(ControlCommands.Close, FD1Lj4bAbgE));
		base.CommandBindings.Add(new CommandBinding(ControlCommands.Confirm, AOjLj5RqUbk));
	}

	public static AppDialog Show(object content, Window window, Action confirmCallback)
	{
		AppDialog appDialog = new AppDialog
		{
			Content = content,
			hIQLjTafwPT = window,
			j15LjMnXeRu = confirmCallback,
			dQVLjATchOT = FocusManager.GetFocusedElement(window)
		};
		AdornerDecorator child = VisualHelper.GetChild<AdornerDecorator>(window);
		int num = 0;
		if (!kDJM5QFqiW3tO95IYfiV())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (child != null)
			{
				if (child.Child != null)
				{
					child.Child.IsEnabled = false;
				}
				AdornerLayer adornerLayer = child.AdornerLayer;
				if (adornerLayer != null)
				{
					AdornerContainer adorner = (appDialog.lLJLjd3163o = new AdornerContainer(adornerLayer)
					{
						Child = appDialog
					});
					appDialog.IsClosed = false;
					adornerLayer.Add(adorner);
				}
			}
			return appDialog;
		}
	}

	public void Close()
	{
		Window window = hIQLjTafwPT;
		if (window != null && lLJLjd3163o != null)
		{
			AdornerDecorator child = VisualHelper.GetChild<AdornerDecorator>(window);
			int num = 0;
			if (!kDJM5QFqiW3tO95IYfiV())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (child != null)
			{
				if (child.Child != null)
				{
					child.Child.IsEnabled = true;
				}
				child.AdornerLayer?.Remove(lLJLjd3163o);
				IsClosed = true;
			}
		}
		if (dQVLjATchOT != null)
		{
			try
			{
				dQVLjATchOT.Focus();
			}
			catch (Exception)
			{
			}
		}
	}

	public void Confirm()
	{
		IsConfirmed = true;
		Close();
		j15LjMnXeRu?.Invoke();
	}

	static AppDialog()
	{
		VHeLjomTC4P = new Dictionary<string, FrameworkElement>();
		IsClosedProperty = DependencyProperty.Register("IsClosed", typeof(bool), typeof(AppDialog), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	private void FD1Lj4bAbgE(object sender, ExecutedRoutedEventArgs e)
	{
		Close();
	}

	[CompilerGenerated]
	private void AOjLj5RqUbk(object sender, ExecutedRoutedEventArgs e)
	{
		Confirm();
	}

	internal static bool kDJM5QFqiW3tO95IYfiV()
	{
		return sA5ukZFqq4KGmLFEo3YP == null;
	}
}
