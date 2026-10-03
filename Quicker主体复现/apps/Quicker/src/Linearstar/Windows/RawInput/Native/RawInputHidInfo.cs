namespace Linearstar.Windows.RawInput.Native;

public struct RawInputHidInfo
{
	private readonly int rvssmypaDc;

	private readonly int GvjsKm7cVi;

	private readonly int rpLsxkUQ7G;

	private readonly ushort FyTsrxg4RF;

	private readonly ushort vxWsp7xu1p;

	private static object kkO5phlUKJPTLnqkaxM;

	public int VendorId => rvssmypaDc;

	public int ProductId => GvjsKm7cVi;

	public int VersionNumber => rpLsxkUQ7G;

	public HidUsageAndPage UsageAndPage => new HidUsageAndPage(FyTsrxg4RF, vxWsp7xu1p);

	internal static bool u2RcZQlxyWRB6NRwWf6()
	{
		return kkO5phlUKJPTLnqkaxM == null;
	}
}
