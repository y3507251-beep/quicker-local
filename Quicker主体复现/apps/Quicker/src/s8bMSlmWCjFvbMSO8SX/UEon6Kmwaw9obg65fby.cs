using System;
using System.Collections;
using System.Collections.Generic;
using Quicker.Pinyin;

namespace s8bMSlmWCjFvbMSO8SX;

internal class UEon6Kmwaw9obg65fby : IEnumerator<int>, IDisposable, IEnumerator
{
	private readonly BitVector64 j7GvJTt8jqy;

	private int ubyvJMAUHUA = -1;

	private static UEon6Kmwaw9obg65fby UmeeLWcFJouPhVFW48mx;

	public int Current => ubyvJMAUHUA;

	object IEnumerator.Current => Current;

	public UEon6Kmwaw9obg65fby(BitVector64 bitVector64_1)
	{
		j7GvJTt8jqy = bitVector64_1;
	}

	public bool MoveNext()
	{
		ubyvJMAUHUA++;
		while (ubyvJMAUHUA < 64 && !j7GvJTt8jqy.Get(ubyvJMAUHUA))
		{
			ubyvJMAUHUA++;
		}
		if (ubyvJMAUHUA == 64)
		{
			return false;
		}
		return true;
	}

	public void Reset()
	{
		ubyvJMAUHUA = -1;
	}

	public void Dispose()
	{
	}

	internal static bool XibOEHcFkPtvW6qkDtYM()
	{
		return UmeeLWcFJouPhVFW48mx == null;
	}
}
