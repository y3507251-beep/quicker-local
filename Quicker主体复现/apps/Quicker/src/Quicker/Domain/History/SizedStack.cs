using System.Collections.Generic;

namespace Quicker.Domain.History;

public class SizedStack<T>
{
	private readonly int QqWtcXoabWh;

	private readonly List<T> K5ktcmfKvHK = new List<T>();

	private static object wqsr8MQ1V5l5FoqvAI47;

	public int Count => K5ktcmfKvHK.Count;

	public SizedStack(int size)
	{
		QqWtcXoabWh = size;
	}

	public void Push(T item)
	{
		K5ktcmfKvHK.Add(item);
		if (QqWtcXoabWh > 0 && K5ktcmfKvHK.Count > QqWtcXoabWh)
		{
			K5ktcmfKvHK.RemoveAt(0);
		}
	}

	public T Pop()
	{
		if (K5ktcmfKvHK.Count > 0)
		{
			T result = K5ktcmfKvHK[K5ktcmfKvHK.Count - 1];
			K5ktcmfKvHK.RemoveAt(K5ktcmfKvHK.Count - 1);
			return result;
		}
		return default(T);
	}

	public void Remove(int itemAtPosition)
	{
		K5ktcmfKvHK.RemoveAt(itemAtPosition);
	}

	public void Clear()
	{
		K5ktcmfKvHK.Clear();
	}

	public T Peek()
	{
		return K5ktcmfKvHK[K5ktcmfKvHK.Count - 1];
	}

	internal static bool fXxyvWQ1QO2iJRrfFhc6()
	{
		return wqsr8MQ1V5l5FoqvAI47 == null;
	}
}
