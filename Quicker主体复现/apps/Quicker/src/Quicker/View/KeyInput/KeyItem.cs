using System.Runtime.CompilerServices;
using Quicker.Utilities;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class KeyItem
{
	[CompilerGenerated]
	private VirtualKeyCode Au0Lgfkih1Y;

	private static KeyItem ATGbJAFApAoHckE9XdcU;

	public VirtualKeyCode KeyCode
	{
		[CompilerGenerated]
		get
		{
			return Au0Lgfkih1Y;
		}
		[CompilerGenerated]
		set
		{
			Au0Lgfkih1Y = value;
		}
	}

	public string KeyName => KeyboardHelper.GetKeyName(KeyCode);

	internal static bool GN1Lk0FAXS09y29Zd9a8()
	{
		return ATGbJAFApAoHckE9XdcU == null;
	}
}
