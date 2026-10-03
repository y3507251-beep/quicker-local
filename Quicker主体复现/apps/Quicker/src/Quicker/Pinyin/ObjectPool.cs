using System;
using System.Collections.Concurrent;

namespace Quicker.Pinyin;

public class ObjectPool<T>
{
	private readonly ConcurrentBag<T> kyAv0vgGHmE;

	private readonly Func<T> JrFv0Syt1WN;

	public ObjectPool(Func<T> objectGenerator)
	{
		JrFv0Syt1WN = objectGenerator ?? throw new ArgumentNullException("objectGenerator");
		kyAv0vgGHmE = new ConcurrentBag<T>();
	}

	public T Get()
	{
		if (!kyAv0vgGHmE.TryTake(out var result))
		{
			return JrFv0Syt1WN();
		}
		return result;
	}

	public void Return(T item)
	{
		kyAv0vgGHmE.Add(item);
	}
}
