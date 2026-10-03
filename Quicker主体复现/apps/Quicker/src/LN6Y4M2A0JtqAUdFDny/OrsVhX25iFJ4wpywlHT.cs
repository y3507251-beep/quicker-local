using Quicker.Public.Searching;

namespace LN6Y4M2A0JtqAUdFDny;

internal static class OrsVhX25iFJ4wpywlHT
{
	private static object oM3KWEQAmSpeSfaCHd6s;

	public static int P1btNok0GDU(this SearchResultItem searchResultItem_0)
	{
		if (!string.IsNullOrEmpty(searchResultItem_0.HistoryData))
		{
			return searchResultItem_0.HistoryData.GetHashCode();
		}
		if (!string.IsNullOrEmpty(searchResultItem_0.TextData))
		{
			return searchResultItem_0.TextData.GetHashCode();
		}
		if (!string.IsNullOrEmpty(searchResultItem_0.Title))
		{
			return searchResultItem_0.Title.GetHashCode();
		}
		return 0;
	}

	internal static bool fgKG43QAsaOOoaCEZ0E5()
	{
		return oM3KWEQAmSpeSfaCHd6s == null;
	}
}
