using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Quicker.View.X.Nodes;

public class StepListBoxItem : ListBoxItem
{
	private bool IpgL1SdVXEI;

	internal static StepListBoxItem IpuZAbFr63EM1VGS7H42;

	public StepListBoxItem()
	{
		base.RequestBringIntoView += Sn7L1vcWxeC;
		base.PreviewMouseLeftButtonDown += m7iL1LhU7Dg;
		base.PreviewMouseLeftButtonUp += YNDL1gQFXcZ;
	}

	private void YNDL1gQFXcZ(object sender, MouseButtonEventArgs e)
	{
		if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && IpgL1SdVXEI)
		{
			base.IsSelected = !base.IsSelected;
		}
	}

	private void m7iL1LhU7Dg(object sender, MouseButtonEventArgs e)
	{
		if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
		{
			e.Handled = base.IsSelected;
			IpgL1SdVXEI = e.Handled;
		}
	}

	private void Sn7L1vcWxeC(object sender, RequestBringIntoViewEventArgs e)
	{
		e.Handled = true;
	}

	internal static bool QwWbAeFrtUMp7uBjphQM()
	{
		return IpuZAbFr63EM1VGS7H42 == null;
	}
}
