using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EetOBeXoEKPaUQX04bS;

internal class BjxbsJXXKfq9q6nXgXg : IDisposable
{
	[CompilerGenerated]
	private static IDictionary<Guid, string> BtNt10AeV47;

	[CompilerGenerated]
	private Guid nIMt1CaRKmB;

	private static BjxbsJXXKfq9q6nXgXg cyZoeNQa7K1rAc9XxYnv;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return nIMt1CaRKmB;
		}
		[CompilerGenerated]
		set
		{
			nIMt1CaRKmB = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static void Entt123dCU1(IDictionary<Guid, string> idictionary_1)
	{
		BtNt10AeV47 = idictionary_1;
	}

	public static bool Tlst1LYYL1V()
	{
		return BtNt10AeV47.Count == 0;
	}

	public static BjxbsJXXKfq9q6nXgXg RPyt1vLAkLm(string string_0)
	{
		return new BjxbsJXXKfq9q6nXgXg(string_0);
	}

	public BjxbsJXXKfq9q6nXgXg(string string_0)
	{
		Id = Guid.NewGuid();
		BtNt10AeV47.Add(Id, string_0);
	}

	public void Dispose()
	{
		BtNt10AeV47.Remove(Id);
	}

	static BjxbsJXXKfq9q6nXgXg()
	{
		BtNt10AeV47 = new ConcurrentDictionary<Guid, string>();
	}

	internal static bool Vbp7EDQa4LYZNOZWSUS5()
	{
		return cyZoeNQa7K1rAc9XxYnv == null;
	}
}
