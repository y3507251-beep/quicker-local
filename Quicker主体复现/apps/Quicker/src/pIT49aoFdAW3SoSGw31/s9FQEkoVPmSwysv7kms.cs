using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Quicker.Common;
using Quicker.Domain;

namespace pIT49aoFdAW3SoSGw31;

internal class s9FQEkoVPmSwysv7kms
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public Window BXbSHZI1Dr2;

		internal static _003C_003Ec__DisplayClass0_0 YMMHayWq6Ba6l0eKPMYH;

		internal void GQ9SHVYNa8b(object sender, RoutedEventArgs e)
		{
			BXbSHZI1Dr2.Close();
		}

		internal static bool qBGKIhWqtswViYVScQaR()
		{
			return YMMHayWq6Ba6l0eKPMYH == null;
		}
	}

	internal static s9FQEkoVPmSwysv7kms csWbgkQ4bE192NSN0j7P;

	public static void BqxgxCG0Fav(ContextMenu contextMenu_0, bool bool_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2 = null;
		int num;
		if (bool_0)
		{
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2 = new Window();
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.WindowStyle = WindowStyle.None;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.AllowsTransparency = true;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Background = Brushes.Transparent;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Height = 1.0;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Width = 1.0;
			num = 0;
			if (csWbgkQ4bE192NSN0j7P != null)
			{
				goto IL_00d6;
			}
			goto IL_00da;
		}
		goto IL_0103;
		IL_0103:
		if (_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2 != null)
		{
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.ContextMenu = contextMenu_0;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Show();
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Activate();
			contextMenu_0.IsOpen = true;
			try
			{
				(contextMenu_0.Items[0] as MenuItem)?.Focus();
			}
			catch
			{
			}
			contextMenu_0.Closed += _003C_003Ec__DisplayClass0_.GQ9SHVYNa8b;
		}
		else
		{
			AppState.RegisterContextMenu(contextMenu_0);
			contextMenu_0.IsOpen = true;
		}
		return;
		IL_00d6:
		int num2 = default(int);
		num = num2;
		goto IL_00da;
		IL_00da:
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0085;
			case 1:
				break;
			}
			break;
			IL_0085:
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Left = 300.0;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.Top = 300.0;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.ShowInTaskbar = false;
			_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2.ShowActivated = true;
			num = 1;
			if (UHpefnQ4qDcS56D7Ip1l())
			{
				continue;
			}
			goto IL_00d6;
		}
		InputMethod.SetPreferredImeState(_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2, InputMethodState.Off);
		InputMethod.SetIsInputMethodEnabled(_003C_003Ec__DisplayClass0_.BXbSHZI1Dr2, false);
		goto IL_0103;
	}

	public static void sK6gxPI5I3G(IList<ActionItem> ilist_0)
	{
	}

	internal static bool UHpefnQ4qDcS56D7Ip1l()
	{
		return csWbgkQ4bE192NSN0j7P == null;
	}
}
