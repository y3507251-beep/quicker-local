using System;
using System.Collections;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class ListCollectionViewEx : ListCollectionView, IWeakEventListener
{
	private static ListCollectionViewEx f2mUGIF4XaBLnK1smUio;

	public ListCollectionViewEx(IList list)
		: base(list)
	{
		if (list is INotifyCollectionChanged notifyCollectionChanged)
		{
			notifyCollectionChanged.CollectionChanged -= base.OnCollectionChanged;
			CollectionChangedEventManager.AddListener(notifyCollectionChanged, this);
		}
	}

	public bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
	{
		if (!(e is NotifyCollectionChangedEventArgs))
		{
			return false;
		}
		OnCollectionChanged(sender, e as NotifyCollectionChangedEventArgs);
		return true;
	}

	internal static bool Tj59OHF42aVZrFcx695K()
	{
		return f2mUGIF4XaBLnK1smUio == null;
	}
}
