using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class DocSearchResult
{
	public IList<DocSearchResultItem> Items { get; set; } = new List<DocSearchResultItem>();

	public int Count { get; set; }
}
