using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Quicker.Utilities.Ext;

public static class CollectionExt
{
	public static bool ContainedIn<T>(this T obj, params T[] collection)
	{
		return collection.Contains(obj);
	}

	public static void Sort<T>(this ObservableCollection<T> collection, Comparison<T> comparison)
	{
		List<T> list = new List<T>(collection);
		list.Sort(comparison);
		for (int i = 0; i < list.Count; i++)
		{
			collection.Move(collection.IndexOf(list[i]), i);
		}
	}
}
