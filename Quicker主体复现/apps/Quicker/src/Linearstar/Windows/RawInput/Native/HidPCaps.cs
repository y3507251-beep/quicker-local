using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

public struct HidPCaps
{
	private readonly ushort QyHstdM6gb;

	private readonly ushort lyysgkSuEG;

	public ushort InputReportByteLength;

	public ushort OutputReportByteLength;

	public ushort FeatureReportByteLength;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
	private readonly ushort[] UtVsL0ZF25;

	public ushort NumberLinkCollectionNodes;

	public ushort NumberInputButtonCaps;

	public ushort NumberInputValueCaps;

	public ushort NumberInputDataIndices;

	public ushort NumberOutputButtonCaps;

	public ushort NumberOutputValueCaps;

	public ushort NumberOutputDataIndices;

	public ushort NumberFeatureButtonCaps;

	public ushort NumberFeatureValueCaps;

	public ushort NumberFeatureDateIndices;

	internal static object BZTkRKizVBLj7SJC2R6;

	public HidUsageAndPage UsageAndPage => new HidUsageAndPage(lyysgkSuEG, QyHstdM6gb);

	internal static bool JyFlhLlVObI4ok6RBd0()
	{
		return BZTkRKizVBLj7SJC2R6 == null;
	}
}
