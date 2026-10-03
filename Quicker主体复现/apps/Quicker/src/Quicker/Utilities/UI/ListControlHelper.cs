using System.Windows.Controls;
using System.Windows.Input;

namespace Quicker.Utilities.UI;

public static class ListControlHelper
{
	private static object nWEH32F4nGmaFT70sWsC;

	public static bool NavigateByKey(ListBox list, KeyEventArgs e)
	{
		int num;
		if (e.Key == Key.Down)
		{
			if (list.SelectedIndex >= list.Items.Count - 1)
			{
				list.SelectedIndex = ((list.Items.Count <= 0) ? (-1) : 0);
			}
			else
			{
				list.SelectedIndex++;
			}
			dJovSNPdwBd(list);
			num = 0;
			if (fTPPlrF4eS9kEIcXaoK7())
			{
				goto IL_0100;
			}
			goto IL_010d;
		}
		if (e.Key == Key.Up)
		{
			if (list.SelectedIndex > 0)
			{
				list.SelectedIndex--;
			}
			else if (list.SelectedIndex == 0)
			{
				list.SelectedIndex = list.Items.Count - 1;
			}
			dJovSNPdwBd(list);
			return true;
		}
		if (e.Key == Key.Home)
		{
			if (list.Items.Count > 0)
			{
				list.SelectedIndex = 0;
				dJovSNPdwBd(list);
				return true;
			}
		}
		else if (e.Key == Key.End && list.Items.Count > 0)
		{
			num = 1;
			if (nWEH32F4nGmaFT70sWsC != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0100;
		}
		return false;
		IL_0100:
		switch (num)
		{
		case 1:
			list.SelectedIndex = list.Items.Count - 1;
			dJovSNPdwBd(list);
			return true;
		}
		goto IL_010d;
		IL_010d:
		return true;
	}

	private static void dJovSNPdwBd(ListBox listBox_0)
	{
		if (listBox_0.SelectedIndex >= 0)
		{
			listBox_0.ScrollIntoView(listBox_0.SelectedItem);
		}
	}

	internal static bool fTPPlrF4eS9kEIcXaoK7()
	{
		return nWEH32F4nGmaFT70sWsC == null;
	}
}
