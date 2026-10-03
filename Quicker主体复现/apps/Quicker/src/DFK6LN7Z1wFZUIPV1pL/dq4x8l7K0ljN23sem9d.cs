using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Utilities.DataStructure;

namespace DFK6LN7Z1wFZUIPV1pL;

internal class dq4x8l7K0ljN23sem9d<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> : INotifyPropertyChanged, IEnumerable, IDictionary<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>, ICollection<KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>>, IEnumerable<KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>>, IObservableMap<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>
{
	private class RvgW9FHq9W1OxUW5ssU : IMapChangedEventArgs<C3VF107JEUAqCB3tqnA>
	{
		[CompilerGenerated]
		private CollectionChange RcR2NZKZWQ0;

		[CompilerGenerated]
		private C3VF107JEUAqCB3tqnA tHM2N9OQGr3;

		internal static object jncRnqyB327Wgi0fOsWJ;

		public CollectionChange CollectionChange
		{
			[CompilerGenerated]
			get
			{
				return RcR2NZKZWQ0;
			}
			[CompilerGenerated]
			private set
			{
				RcR2NZKZWQ0 = value;
			}
		}

		public C3VF107JEUAqCB3tqnA Key
		{
			[CompilerGenerated]
			get
			{
				return tHM2N9OQGr3;
			}
			[CompilerGenerated]
			private set
			{
				tHM2N9OQGr3 = value;
			}
		}

		public RvgW9FHq9W1OxUW5ssU(CollectionChange collectionChange_1, C3VF107JEUAqCB3tqnA hmRFMWHWYudeBK1kXiS)
		{
			CollectionChange = collectionChange_1;
			Key = hmRFMWHWYudeBK1kXiS;
		}

		internal static bool pWdeuFyBEv2wmjBqbhet()
		{
			return jncRnqyB327Wgi0fOsWJ == null;
		}
	}

	private Dictionary<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> CTOLzCTeGZs = new Dictionary<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>();

	[CompilerGenerated]
	private MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> fkwLzPqamd9;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static object PrpR5HFTQ7PPlKBQXsWB;

	public FOi1XN7RYtwisr67bC3 this[C3VF107JEUAqCB3tqnA kG20Nu7tUeSNOJPJJVS]
	{
		get
		{
			return CTOLzCTeGZs[kG20Nu7tUeSNOJPJJVS];
		}
		set
		{
			CTOLzCTeGZs[kG20Nu7tUeSNOJPJJVS] = value;
			VvKLz0galJp(CollectionChange.ItemChanged, kG20Nu7tUeSNOJPJJVS);
			OnPropertyChanged("Item[]");
		}
	}

	public ICollection<C3VF107JEUAqCB3tqnA> Keys => CTOLzCTeGZs.Keys;

	public ICollection<FOi1XN7RYtwisr67bC3> Values => CTOLzCTeGZs.Values;

	public int Count => CTOLzCTeGZs.Count;

	public bool IsReadOnly => false;

	public event MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> MapChanged
	{
		[CompilerGenerated]
		add
		{
			MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> mapChangedEventHandler = fkwLzPqamd9;
			MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> mapChangedEventHandler2;
			do
			{
				mapChangedEventHandler2 = mapChangedEventHandler;
				MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> value2 = (MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>)Delegate.Combine(mapChangedEventHandler2, value);
				mapChangedEventHandler = Interlocked.CompareExchange(ref fkwLzPqamd9, value2, mapChangedEventHandler2);
			}
			while ((object)mapChangedEventHandler != mapChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> mapChangedEventHandler = fkwLzPqamd9;
			MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> mapChangedEventHandler2;
			do
			{
				mapChangedEventHandler2 = mapChangedEventHandler;
				MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> value2 = (MapChangedEventHandler<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>)Delegate.Remove(mapChangedEventHandler2, value);
				mapChangedEventHandler = Interlocked.CompareExchange(ref fkwLzPqamd9, value2, mapChangedEventHandler2);
			}
			while ((object)mapChangedEventHandler != mapChangedEventHandler2);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	private void VvKLz0galJp(CollectionChange collectionChange_0, C3VF107JEUAqCB3tqnA bhfiuw7BPdSSCaX6Cfv)
	{
		fkwLzPqamd9?.Invoke(this, new RvgW9FHq9W1OxUW5ssU(collectionChange_0, bhfiuw7BPdSSCaX6Cfv));
	}

	public void Add(C3VF107JEUAqCB3tqnA key, FOi1XN7RYtwisr67bC3 value)
	{
		CTOLzCTeGZs.Add(key, value);
		VvKLz0galJp(CollectionChange.ItemInserted, key);
	}

	public void Add(KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> item)
	{
		Add(item.Key, item.Value);
	}

	public bool Remove(C3VF107JEUAqCB3tqnA EWWk9u7QOuUFlJVPe6V)
	{
		if (CTOLzCTeGZs.Remove(EWWk9u7QOuUFlJVPe6V))
		{
			VvKLz0galJp(CollectionChange.ItemRemoved, EWWk9u7QOuUFlJVPe6V);
			return true;
		}
		return false;
	}

	public bool Remove(KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> item)
	{
		if (CTOLzCTeGZs.TryGetValue(item.Key, out var value) && object.Equals(item.Value, value) && CTOLzCTeGZs.Remove(item.Key))
		{
			VvKLz0galJp(CollectionChange.ItemRemoved, item.Key);
			return true;
		}
		return false;
	}

	public void Clear()
	{
		C3VF107JEUAqCB3tqnA[] array = CTOLzCTeGZs.Keys.ToArray();
		CTOLzCTeGZs.Clear();
		C3VF107JEUAqCB3tqnA[] array2 = array;
		foreach (C3VF107JEUAqCB3tqnA bhfiuw7BPdSSCaX6Cfv in array2)
		{
			VvKLz0galJp(CollectionChange.ItemRemoved, bhfiuw7BPdSSCaX6Cfv);
		}
	}

	public bool ContainsKey(C3VF107JEUAqCB3tqnA bIKSAd7rNT1SeG1TvK0)
	{
		return CTOLzCTeGZs.ContainsKey(bIKSAd7rNT1SeG1TvK0);
	}

	public bool TryGetValue(C3VF107JEUAqCB3tqnA HDrJan7IgGPDjevvvgp, out FOi1XN7RYtwisr67bC3 value)
	{
		return CTOLzCTeGZs.TryGetValue(HDrJan7IgGPDjevvvgp, out value);
	}

	public bool Contains(KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> item)
	{
		return CTOLzCTeGZs.Contains(item);
	}

	public IEnumerator<KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>> GetEnumerator()
	{
		return CTOLzCTeGZs.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return CTOLzCTeGZs.GetEnumerator();
	}

	public void CopyTo(KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3>[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int num = array.Length;
		foreach (KeyValuePair<C3VF107JEUAqCB3tqnA, FOi1XN7RYtwisr67bC3> cTOLzCTeGZ in CTOLzCTeGZs)
		{
			if (arrayIndex < num)
			{
				array[arrayIndex++] = cTOLzCTeGZ;
				continue;
			}
			break;
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool cL54KRFTFpAX0K4HIOkN()
	{
		return PrpR5HFTQ7PPlKBQXsWB == null;
	}
}
