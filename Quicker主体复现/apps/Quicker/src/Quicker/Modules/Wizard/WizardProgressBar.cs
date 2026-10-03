using System.Windows;
using System.Windows.Controls;

namespace Quicker.Modules.Wizard;

public class WizardProgressBar : ItemsControl
{
	public static readonly DependencyProperty StepIndexProperty;

	internal static WizardProgressBar aBqY79HCcbPe5YQLLX3;

	public int StepIndex
	{
		get
		{
			return (int)GetValue(StepIndexProperty);
		}
		set
		{
			SetValue(StepIndexProperty, value);
		}
	}

	static WizardProgressBar()
	{
		StepIndexProperty = DependencyProperty.Register("StepIndex", typeof(int), typeof(WizardProgressBar), new PropertyMetadata(0));
	}

	internal static bool ecd9QVH7vdNNO0Zcjq2()
	{
		return aBqY79HCcbPe5YQLLX3 == null;
	}

	internal static void kyrlAdHhDASJCNeRoXL()
	{
	}
}
