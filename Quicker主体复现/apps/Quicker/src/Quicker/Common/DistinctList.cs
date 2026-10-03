using System.Collections;
using System.Collections.Generic;

namespace Quicker.Common;

public class DistinctList<T> : IEnumerable<T>, IEnumerable, IList<T>, ICollection<T>
{
	private readonly IList<T> FbVt8SaKMV8 = new List<T>();

	internal static object TMVIstQ3hVF6V59qtO8M;

	public int Count => FbVt8SaKMV8.Count;

	public bool IsReadOnly => FbVt8SaKMV8.IsReadOnly;

	public T this[int index]
	{
		get
		{
			return FbVt8SaKMV8[index];
		}
		set
		{
			FbVt8SaKMV8[index] = value;
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		return FbVt8SaKMV8.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		if (!FbVt8SaKMV8.Contains(item))
		{
			FbVt8SaKMV8.Add(item);
		}
	}

	public void Clear()
	{
		FbVt8SaKMV8.Clear();
	}

	public bool Contains(T item)
	{
		return FbVt8SaKMV8.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		FbVt8SaKMV8.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return FbVt8SaKMV8.Remove(item);
	}

	public int IndexOf(T item)
	{
		return FbVt8SaKMV8.IndexOf(item);
	}

	public void Insert(int index, T item)
	{
		if (!FbVt8SaKMV8.Contains(item))
		{
			FbVt8SaKMV8.Insert(index, item);
		}
	}

	public void RemoveAt(int index)
	{
		FbVt8SaKMV8.RemoveAt(index);
	}

	internal static bool Mt79SlQ3Ha1DIOMSFTpD()
	{
		return TMVIstQ3hVF6V59qtO8M == null;
	}
}
