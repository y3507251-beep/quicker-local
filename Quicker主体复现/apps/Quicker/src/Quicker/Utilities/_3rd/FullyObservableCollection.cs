using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quicker.Utilities._3rd;

public class FullyObservableCollection<T> : ObservableCollection<T> where T : INotifyPropertyChanged
{
	[CompilerGenerated]
	private EventHandler<ItemPropertyChangedEventArgs> DU4Lz88IKZO;

	private static object e9tHjDFTWFshbD5YqKXj;

	public event EventHandler<ItemPropertyChangedEventArgs> ItemPropertyChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ItemPropertyChangedEventArgs> eventHandler = DU4Lz88IKZO;
			EventHandler<ItemPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemPropertyChangedEventArgs> value2 = (EventHandler<ItemPropertyChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref DU4Lz88IKZO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ItemPropertyChangedEventArgs> eventHandler = DU4Lz88IKZO;
			EventHandler<ItemPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemPropertyChangedEventArgs> value2 = (EventHandler<ItemPropertyChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref DU4Lz88IKZO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public FullyObservableCollection()
	{
	}

	public FullyObservableCollection(List<T> list)
		: base(list)
	{
		URYLzE83rId();
	}

	public FullyObservableCollection(IEnumerable<T> enumerable)
		: base(enumerable)
	{
		URYLzE83rId();
	}

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
		T val2;
		if (e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace)
		{
			foreach (T oldItem in e.OldItems)
			{
				T val = oldItem;
				ref T reference = ref val;
				val2 = default(T);
				if (val2 == null)
				{
					val2 = reference;
					reference = ref val2;
				}
				PropertyChangedEventHandler value = E0ILzyH3x8u;
				reference.PropertyChanged -= value;
			}
		}
		if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Replace)
		{
			IEnumerator enumerator2 = e.NewItems.GetEnumerator();
			int num = 0;
			if (!rtT8DKFTygeCYgQM1GL2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					T val3 = (T)enumerator2.Current;
					ref T reference2 = ref val3;
					val2 = default(T);
					if (val2 == null)
					{
						val2 = reference2;
						reference2 = ref val2;
					}
					PropertyChangedEventHandler value2 = E0ILzyH3x8u;
					reference2.PropertyChanged += value2;
				}
			}
			finally
			{
				if (enumerator2 is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		base.OnCollectionChanged(e);
	}

	protected void OnItemPropertyChanged(ItemPropertyChangedEventArgs e)
	{
		DU4Lz88IKZO?.Invoke(this, e);
	}

	protected void OnItemPropertyChanged(int index, PropertyChangedEventArgs e)
	{
		OnItemPropertyChanged(new ItemPropertyChangedEventArgs(index, e));
	}

	protected override void ClearItems()
	{
		foreach (T item in base.Items)
		{
			T current = item;
			current.PropertyChanged -= E0ILzyH3x8u;
		}
		base.ClearItems();
	}

	private void URYLzE83rId()
	{
		foreach (T item in base.Items)
		{
			T current = item;
			current.PropertyChanged += E0ILzyH3x8u;
		}
	}

	private void E0ILzyH3x8u(object sender, PropertyChangedEventArgs e)
	{
		T item = (T)sender;
		int num = base.Items.IndexOf(item);
		if (num < 0)
		{
			throw new ArgumentException("Received property notification from item not in collection");
		}
		OnItemPropertyChanged(num, e);
	}

	public void Reset(IEnumerable<T> range)
	{
		foreach (T item in base.Items)
		{
			T current = item;
			current.PropertyChanged -= E0ILzyH3x8u;
		}
		base.Items.Clear();
		foreach (T item2 in range)
		{
			base.Items.Add(item2);
		}
		URYLzE83rId();
		OnPropertyChanged(new PropertyChangedEventArgs("Count"));
		OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	internal static bool rtT8DKFTygeCYgQM1GL2()
	{
		return e9tHjDFTWFshbD5YqKXj == null;
	}
}
