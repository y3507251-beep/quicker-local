using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class DeleteMultiItemsVm<T>
{
	public IList<T> Items { get; set; }
}
