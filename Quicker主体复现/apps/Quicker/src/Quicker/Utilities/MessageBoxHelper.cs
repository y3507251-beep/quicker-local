using System;
using System.Runtime.CompilerServices;
using System.Windows;
using HandyControl.Controls;

namespace Quicker.Utilities;

public static class MessageBoxHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public System.Windows.Window xg8SzcC4B21;

		public string rGYSzVvoHwf;

		public string usvSzZdkncK;

		public MessageBoxButton OddSz9s0rTc;

		public MessageBoxImage UK8SzhTA99p;

		public MessageBoxResult pJGSzemtAGp;

		public MessageBoxResult v3qSzYhWePX;

		internal static _003C_003Ec__DisplayClass0_0 evdbHVyACw3HIiFs9Exp;

		internal void a36SzqJ7W9Q()
		{
			try
			{
				v3qSzYhWePX = HandyControl.Controls.MessageBox.Show(xg8SzcC4B21, rGYSzVvoHwf, usvSzZdkncK, OddSz9s0rTc, UK8SzhTA99p, pJGSzemtAGp);
			}
			catch (Exception)
			{
			}
		}

		internal static bool vnFaGVyA7fN4VeBk0mV7()
		{
			return evdbHVyACw3HIiFs9Exp == null;
		}
	}

	internal static object dM1pL6FZl3CSIpu6bq72;

	public static MessageBoxResult Show(System.Windows.Window owner, string messageBoxText, string caption = null, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.Asterisk, MessageBoxResult defaultResult = MessageBoxResult.OK, bool useSystem = false)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.xg8SzcC4B21 = owner;
		_003C_003Ec__DisplayClass0_.rGYSzVvoHwf = messageBoxText;
		_003C_003Ec__DisplayClass0_.usvSzZdkncK = caption;
		_003C_003Ec__DisplayClass0_.OddSz9s0rTc = button;
		_003C_003Ec__DisplayClass0_.UK8SzhTA99p = icon;
		_003C_003Ec__DisplayClass0_.pJGSzemtAGp = defaultResult;
		if (_003C_003Ec__DisplayClass0_.usvSzZdkncK == null)
		{
			_003C_003Ec__DisplayClass0_.usvSzZdkncK = "Quicker";
		}
		if (useSystem)
		{
			return System.Windows.MessageBox.Show(_003C_003Ec__DisplayClass0_.xg8SzcC4B21, _003C_003Ec__DisplayClass0_.rGYSzVvoHwf, _003C_003Ec__DisplayClass0_.usvSzZdkncK, _003C_003Ec__DisplayClass0_.OddSz9s0rTc, _003C_003Ec__DisplayClass0_.UK8SzhTA99p, _003C_003Ec__DisplayClass0_.pJGSzemtAGp, MessageBoxOptions.ServiceNotification);
		}
		_003C_003Ec__DisplayClass0_.v3qSzYhWePX = MessageBoxResult.No;
		try
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass0_.a36SzqJ7W9Q);
		}
		catch (Exception)
		{
			_003C_003Ec__DisplayClass0_.v3qSzYhWePX = System.Windows.MessageBox.Show(_003C_003Ec__DisplayClass0_.rGYSzVvoHwf, _003C_003Ec__DisplayClass0_.usvSzZdkncK, _003C_003Ec__DisplayClass0_.OddSz9s0rTc, _003C_003Ec__DisplayClass0_.UK8SzhTA99p, _003C_003Ec__DisplayClass0_.pJGSzemtAGp, MessageBoxOptions.ServiceNotification);
		}
		return _003C_003Ec__DisplayClass0_.v3qSzYhWePX;
	}

	public static MessageBoxResult Show(string messageBoxText, string caption = null, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.Asterisk, MessageBoxResult defaultResult = MessageBoxResult.OK, bool useSystem = false, MessageBoxOptions options = MessageBoxOptions.None)
	{
		return Show(null, messageBoxText, caption, button, icon, defaultResult);
	}

	static MessageBoxHelper()
	{
	}

	internal static bool POVy3MFZZnwtPCoftO3H()
	{
		return dM1pL6FZl3CSIpu6bq72 == null;
	}

	internal static void XV24NCFZYTZXi26lshU2()
	{
	}
}
