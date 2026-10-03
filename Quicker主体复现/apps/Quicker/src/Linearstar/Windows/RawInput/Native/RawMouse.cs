namespace Linearstar.Windows.RawInput.Native;

public struct RawMouse
{
	private readonly RawMouseFlags KcusidsMw6;

	private readonly ushort Bx9s3hE0OL;

	private readonly RawMouseButtonFlags AsfsfMh1m9;

	private readonly short lBbsz1l95G;

	private readonly uint zk5Hwx2fNH;

	private readonly int TiDHt2CHZr;

	private readonly int HvCHglViWj;

	private readonly uint oRKHLyBPQP;

	private static object dd0Pnylzr4OKDVygxu6;

	public RawMouseFlags Flags => KcusidsMw6;

	public RawMouseButtonFlags Buttons => AsfsfMh1m9;

	public int ButtonData => lBbsz1l95G;

	public uint RawButtons => zk5Hwx2fNH;

	public int LastX => TiDHt2CHZr;

	public int LastY => HvCHglViWj;

	public uint ExtraInformation => oRKHLyBPQP;

	public override string ToString()
	{
		return $"{{X: {LastX}, Y: {LastY}, Flags: {Flags}, Buttons: {Buttons}, Data: {ButtonData}}}";
	}

	static RawMouse()
	{
	}

	internal static bool Bmvm23ZVoaJmiI0i6tE()
	{
		return dd0Pnylzr4OKDVygxu6 == null;
	}

	internal static void YjhDv3ZFSaYBTHSTrrE()
	{
	}
}
