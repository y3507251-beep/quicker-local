using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Quicker.Utilities._3rd;

public class SmartCollection<T> : ObservableCollection<T>
{
	internal static object LhUKOxFTdRFuuXBmRqlR;

	public SmartCollection()
	{
	}

	public SmartCollection(IEnumerable<T> collection)
		: base(collection)
	{
	}

	public SmartCollection(List<T> list)
		: base(list)
	{
	}

	public void AddRange(IEnumerable<T> range)
	{
		foreach (T item in range)
		{
			base.Items.Add(item);
		}
		F6XLzVMYTRD();
	}

	private void F6XLzVMYTRD()
	{
		OnPropertyChanged(new PropertyChangedEventArgs("Count"));
		OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	public void Reset(IEnumerable<T> range)
	{
		base.Items.Clear();
		if (range != null)
		{
			AddRange(range);
		}
		else
		{
			F6XLzVMYTRD();
		}
	}

	public void Replace(T oldItem, T newItem)
	{
		int num = IndexOf(oldItem);
		if (num >= 0)
		{
			SetItem(num, newItem);
		}
	}

	internal static bool pFpR6CFTOdUrMJ1o3jg4()
	{
		return LhUKOxFTdRFuuXBmRqlR == null;
	}
}
