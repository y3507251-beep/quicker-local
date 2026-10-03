using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace whX2OqiF8ktmGdctWNN;

[DefaultMember("Item")]
internal class VWVOHCiULfdMMMUB3rX<YZfvIEigfVoT8jYukaZ, yYSWeRiVkU3OTFkZ5YK> where yYSWeRiVkU3OTFkZ5YK : class
{
	private IDictionary<YZfvIEigfVoT8jYukaZ, WeakReference<yYSWeRiVkU3OTFkZ5YK>> t9WvNYEQS8R = new ConcurrentDictionary<YZfvIEigfVoT8jYukaZ, WeakReference<yYSWeRiVkU3OTFkZ5YK>>();

	internal static object mknnl0cV8mt3wD6rTw7j;

	public bool o4AvN7xIN4x(YZfvIEigfVoT8jYukaZ xIyr5aivVkj8yMAucLj)
	{
		yYSWeRiVkU3OTFkZ5YK target;
		if (t9WvNYEQS8R.TryGetValue(xIyr5aivVkj8yMAucLj, out var value))
		{
			return value.TryGetTarget(out target);
		}
		return false;
	}

	public void LOMvNR37HZ7(YZfvIEigfVoT8jYukaZ aUv5XEiNDaOnu0sxvQS, yYSWeRiVkU3OTFkZ5YK z1KawuinbdGvbobdAc7)
	{
		t9WvNYEQS8R[aUv5XEiNDaOnu0sxvQS] = new WeakReference<yYSWeRiVkU3OTFkZ5YK>(z1KawuinbdGvbobdAc7);
	}

	[SpecialName]
	public yYSWeRiVkU3OTFkZ5YK nCwvN99a8pK(YZfvIEigfVoT8jYukaZ zUmu5HiO3pKp0RLnewe)
	{
		if (t9WvNYEQS8R.TryGetValue(zUmu5HiO3pKp0RLnewe, out var value) && value.TryGetTarget(out var target))
		{
			return target;
		}
		return null;
	}

	[SpecialName]
	public void aIXvNhlIIfs(YZfvIEigfVoT8jYukaZ ld7mIQisdUISu6pTHcp, yYSWeRiVkU3OTFkZ5YK IXY5s3i3oWRXIjIO3NS)
	{
		t9WvNYEQS8R[ld7mIQisdUISu6pTHcp] = new WeakReference<yYSWeRiVkU3OTFkZ5YK>(IXY5s3i3oWRXIjIO3NS);
	}

	public bool FfTvNqMKvXd(YZfvIEigfVoT8jYukaZ OAEArJiE94guZ5oePxr, out yYSWeRiVkU3OTFkZ5YK gparam_0)
	{
		if (t9WvNYEQS8R.TryGetValue(OAEArJiE94guZ5oePxr, out var value))
		{
			if (value.TryGetTarget(out gparam_0))
			{
				return true;
			}
			t9WvNYEQS8R.Remove(OAEArJiE94guZ5oePxr);
			return false;
		}
		gparam_0 = null;
		return false;
	}

	public bool jUnvNcskMnC(YZfvIEigfVoT8jYukaZ LowFlQi073fy5E0SiT7)
	{
		return t9WvNYEQS8R.Remove(LowFlQi073fy5E0SiT7);
	}

	public void PmEvNVH9fVl()
	{
		t9WvNYEQS8R.Clear();
	}

	public void KsTvNZpwh6w()
	{
		List<YZfvIEigfVoT8jYukaZ> list = new List<YZfvIEigfVoT8jYukaZ>();
		foreach (KeyValuePair<YZfvIEigfVoT8jYukaZ, WeakReference<yYSWeRiVkU3OTFkZ5YK>> item in t9WvNYEQS8R)
		{
			if (!item.Value.TryGetTarget(out var target))
			{
				list.Add(item.Key);
			}
		}
		foreach (YZfvIEigfVoT8jYukaZ item2 in list)
		{
			t9WvNYEQS8R.Remove(item2);
		}
	}

	internal static bool BtjyPycVRUBgiU6um7NB()
	{
		return mknnl0cV8mt3wD6rTw7j == null;
	}
}
