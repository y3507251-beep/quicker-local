using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Utilities.UI;

namespace Quicker.View.UI;

public class QuickerTriggerButton : UserControl, IComponentConnector
{
	private DispatcherTimer MoSLEuVoGVD;

	internal Image LogoImage;

	internal MenuItem MenuClose;

	internal MenuItem MenuCloseAll;

	private bool ULELEND55n2;

	internal static QuickerTriggerButton Kc4TOeFEPOFTPVhOje9U;

	public QuickerTriggerButton()
	{
		InitializeComponent();
		base.MouseEnter += boBLELlKrQP;
		base.MouseLeave += eybLEgWjrOx;
		base.MouseDown += QkjLEtpHixW;
	}

	private void QkjLEtpHixW(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Middle)
		{
			System.Windows.Window.GetWindow(this).Close();
		}
	}

	private void eybLEgWjrOx(object sender, MouseEventArgs e)
	{
		MoSLEuVoGVD?.Stop();
	}

	private void boBLELlKrQP(object sender, MouseEventArgs e)
	{
		int num = 1;
		while (true)
		{
			DispatcherTimer moSLEuVoGVD = MoSLEuVoGVD;
			if (moSLEuVoGVD == null)
			{
				int num2 = 0;
				if (Kc4TOeFEPOFTPVhOje9U != null)
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
			}
			else
			{
				moSLEuVoGVD.Stop();
			}
			break;
		}
		if (!AppState.HS2taepcAbc().IsVisible && !Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			if (MoSLEuVoGVD == null)
			{
				MoSLEuVoGVD = new DispatcherTimer(TimeSpan.FromMilliseconds(400.0), DispatcherPriority.Input, O26LEvBKM9i, Dispatcher.CurrentDispatcher);
			}
			MoSLEuVoGVD.Start();
		}
	}

	private void O26LEvBKM9i(object sender, EventArgs e)
	{
		MoSLEuVoGVD.Stop();
		System.Windows.Window window = System.Windows.Window.GetWindow(this);
		if (window == null || !window.IsLoaded || System.Windows.Input.Mouse.LeftButton == MouseButtonState.Pressed)
		{
			return;
		}
		int num = 0;
		if (!sn00U5FEMZk29G0Iy2Rf())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (System.Windows.Input.Mouse.MiddleButton != MouseButtonState.Pressed && System.Windows.Input.Mouse.RightButton != MouseButtonState.Pressed)
		{
			AppState.HS2taepcAbc().TogglePopupWindow(PopupSource.TriggerFloatButton, null);
			FloatTriggerButtonHelper.LogLastTriggerButtonId(System.Windows.Window.GetWindow(this).Tag as string);
		}
	}

	private void vTULES4ywuE(object sender, RoutedEventArgs e)
	{
		System.Windows.Window.GetWindow(this).Close();
	}

	private void fGrLE2rfhFZ(object sender, RoutedEventArgs e)
	{
		IList<System.Windows.Window> list = new List<System.Windows.Window>();
		foreach (object window in Application.Current.Windows)
		{
			if (window is Sprite item)
			{
				list.Add(item);
			}
		}
		foreach (System.Windows.Window item2 in list)
		{
			item2.Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ULELEND55n2)
		{
			ULELEND55n2 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/quickertriggerbutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			ULELEND55n2 = true;
			break;
		case 1:
			LogoImage = (Image)target;
			break;
		case 2:
			MenuClose = (MenuItem)target;
			MenuClose.Click += vTULES4ywuE;
			break;
		case 3:
			MenuCloseAll = (MenuItem)target;
			MenuCloseAll.Click += fGrLE2rfhFZ;
			break;
		}
	}

	internal static bool sn00U5FEMZk29G0Iy2Rf()
	{
		return Kc4TOeFEPOFTPVhOje9U == null;
	}
}
