using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Quicker.Utilities;

public static class CommandBindingsHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public ExecutedRoutedEventHandler MUJSzRPHh6B;

		internal static _003C_003Ec__DisplayClass0_0 PVZHImyATgSPpsemZjoL;

		internal void o2CSz70r2Yh(object sender, ExecutedRoutedEventArgs e)
		{
			MUJSzRPHh6B(sender, e);
		}

		internal static bool V1MoOHyAmGjve5Rnh9QJ()
		{
			return PVZHImyATgSPpsemZjoL == null;
		}
	}

	internal static object kl4a2QFZuJGs99Rl03iy;

	public static void AddKeyGesture(this CommandBindingCollection bindings, KeyGesture keyGesture, ExecutedRoutedEventHandler handler)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.MUJSzRPHh6B = handler;
		RoutedCommand routedCommand = new RoutedCommand();
		routedCommand.InputGestures.Add(keyGesture);
		bindings.Add(new CommandBinding(routedCommand, _003C_003Ec__DisplayClass0_.o2CSz70r2Yh));
	}

	internal static bool iHeA4RFZoDL10JtBDdvJ()
	{
		return kl4a2QFZuJGs99Rl03iy == null;
	}
}
