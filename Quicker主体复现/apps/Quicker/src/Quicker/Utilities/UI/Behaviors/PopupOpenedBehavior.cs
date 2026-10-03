using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using HandyControl.Interactivity;

namespace Quicker.Utilities.UI.Behaviors;

public class PopupOpenedBehavior : Behavior<Popup>
{
	private static PopupOpenedBehavior DJ9eEbcVKjyyYkjXO4gP;

	protected override void OnAttached()
	{
		base.OnAttached();
		base.AssociatedObject.Opened += HjcvNwZM0QD;
	}

	[DllImport("user32.dll", EntryPoint = "SetFocus")]
	private static extern IntPtr T0Pvuz6Qq3R(IntPtr intptr_0);

	private void HjcvNwZM0QD(object sender, EventArgs e)
	{
		Popup associatedObject = base.AssociatedObject;
		if (associatedObject != null)
		{
			HwndSource hwndSource = (HwndSource)PresentationSource.FromVisual(associatedObject.Child);
			if (hwndSource != null)
			{
				T0Pvuz6Qq3R(hwndSource.Handle);
			}
		}
	}

	protected override void OnDetaching()
	{
		base.AssociatedObject.Opened -= HjcvNwZM0QD;
		base.OnDetaching();
	}

	internal static bool nVnXZacVBUJyufehxGKE()
	{
		return DJ9eEbcVKjyyYkjXO4gP == null;
	}
}
