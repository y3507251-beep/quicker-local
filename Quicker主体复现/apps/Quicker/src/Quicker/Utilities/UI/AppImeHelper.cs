using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Quicker.Domain.Actions.X.StepRunners;

namespace Quicker.Utilities.UI;

public static class AppImeHelper
{
	public const string Ime_NoControl = "NO_CONTROL";

	public const string Ime_On = "ON";

	public const string Ime_Off = "OFF";

	[CompilerGenerated]
	private static readonly IList<SelectionItem> j93vSRPX6Pt;

	internal static object M6xFgYF4qmHfm5DK0chX;

	public static IList<SelectionItem> SelectionItems
	{
		[CompilerGenerated]
		get
		{
			return j93vSRPX6Pt;
		}
	}

	public static void SetImeState(DependencyObject dependencyObject, string imeState)
	{
		if (imeState != "NO_CONTROL" && !string.IsNullOrEmpty(imeState))
		{
			if (imeState == "ON")
			{
				InputMethod.SetPreferredImeState(dependencyObject, InputMethodState.On);
				InputMethod.SetPreferredImeConversionMode(dependencyObject, ImeConversionModeValues.Native);
			}
			else if (imeState == "OFF")
			{
				InputMethod.SetPreferredImeState(dependencyObject, InputMethodState.Off);
				InputMethod.SetPreferredImeConversionMode(dependencyObject, ImeConversionModeValues.CharCode);
			}
		}
	}

	static AppImeHelper()
	{
		j93vSRPX6Pt = new List<SelectionItem>
		{
			new SelectionItem("NO_CONTROL", "不控制"),
			new SelectionItem("ON", "开启"),
			new SelectionItem("OFF", "关闭")
		};
	}

	internal static bool bkFCn0F4iUK1ckp4ma7B()
	{
		return M6xFgYF4qmHfm5DK0chX == null;
	}
}
