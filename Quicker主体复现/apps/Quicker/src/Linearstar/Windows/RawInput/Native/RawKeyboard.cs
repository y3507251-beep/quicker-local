namespace Linearstar.Windows.RawInput.Native;

public struct RawKeyboard
{
	private readonly ushort eqxsMswo76;

	private readonly RawKeyboardFlags qZjsAy9Eq1;

	private readonly ushort vk3sObfR94;

	private readonly ushort JUAsFcLQUa;

	private readonly uint viosUYxRFF;

	private readonly uint ePDslnN1hh;

	internal static object ejUIMylswRCsN7HXUoR;

	public int ScanCode => eqxsMswo76;

	public RawKeyboardFlags Flags => qZjsAy9Eq1;

	public int VirutalKey => JUAsFcLQUa;

	public uint WindowMessage => viosUYxRFF;

	public uint ExtraInformation => ePDslnN1hh;

	public override string ToString()
	{
		return $"{{Key: {VirutalKey}, ScanCode: {ScanCode}, Flags: {Flags}}}";
	}

	internal static bool efJngnlCnimSSG0cW1C()
	{
		return ejUIMylswRCsN7HXUoR == null;
	}
}
