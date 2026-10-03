using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Threading;
using Quicker.Utilities;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Settings.Pages.Tools;

public class KeyboardStateResetter : System.Windows.Controls.UserControl, IComponentConnector
{
	private DispatcherTimer Niv4UDn3Vg;

	internal TextBlock LblState;

	internal System.Windows.Controls.Button BtnReset;

	private bool em34lsCBuq;

	private static KeyboardStateResetter LAMG2pmDOIOaptsFoOA;

	public KeyboardStateResetter()
	{
		InitializeComponent();
		Niv4UDn3Vg = new DispatcherTimer();
		Niv4UDn3Vg.Interval = TimeSpan.FromMilliseconds(100.0);
		Niv4UDn3Vg.Tick += wkX4OhWPWi;
		Niv4UDn3Vg.Start();
		base.Unloaded += MEv4MQeLaB;
	}

	private void MEv4MQeLaB(object sender, RoutedEventArgs e)
	{
		Niv4UDn3Vg?.Stop();
		Niv4UDn3Vg = null;
	}

	private void h4w4AaPy4c(object sender, RoutedEventArgs e)
	{
		try
		{
			Keys[] array = (Keys[])Enum.GetValues(typeof(Keys));
			foreach (Keys keys in array)
			{
				if (KeyboardHelper.IsKeyDown((VirtualKeyCode)keys))
				{
					InputSimulator.Instance.Keyboard.KeyUp((VirtualKeyCode)keys);
				}
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void wkX4OhWPWi(object sender, EventArgs e)
	{
		cWT4FahZ73();
	}

	private void cWT4FahZ73()
	{
		if (!KeyboardHelper.IsAnyKeyDown())
		{
			LblState.Text = "没有按下的按键";
			BtnReset.IsEnabled = false;
			return;
		}
		BtnReset.IsEnabled = true;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("按下的键：");
		Keys[] array = (Keys[])Enum.GetValues(typeof(Keys));
		for (int i = 0; i < array.Length; i++)
		{
			Keys key = array[i];
			if (KeyboardHelper.IsKeyDown((VirtualKeyCode)key))
			{
				stringBuilder.AppendLine(key.ToString());
			}
		}
		int num = 0;
		if (LAMG2pmDOIOaptsFoOA != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		LblState.Text = stringBuilder.ToString();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!em34lsCBuq)
		{
			em34lsCBuq = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/tools/keyboardstateresetter.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
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
			em34lsCBuq = true;
			break;
		case 2:
			BtnReset = (System.Windows.Controls.Button)target;
			BtnReset.Click += h4w4AaPy4c;
			break;
		case 1:
			LblState = (TextBlock)target;
			break;
		}
	}

	internal static bool rXOWwSm3wWSqv8mm8Hl()
	{
		return LAMG2pmDOIOaptsFoOA == null;
	}
}
