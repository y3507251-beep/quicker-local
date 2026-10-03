using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Public.Extensions;

namespace ryVWieApdfyCAmpsKH7;

internal class RD5TUqALOWDKBn8SE4W
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WVBvYTwksue;

		public static Func<string, string> AKUvYMJ14tt;

		internal static _003C_003Ec I90c5mclraRifp4K8V6e;

		static _003C_003Ec()
		{
			WVBvYTwksue = new _003C_003Ec();
		}

		internal string WvhvYo8VXWg(string x)
		{
			return x.ToUpper();
		}

		internal static bool attIDHclNvvu07MDkuek()
		{
			return I90c5mclraRifp4K8V6e == null;
		}
	}

	[CompilerGenerated]
	private string P1M3KvBQcs;

	[CompilerGenerated]
	private IList<string> Tbl3x7U43c;

	[CompilerGenerated]
	private string tNv3rP0pNK;

	internal static RD5TUqALOWDKBn8SE4W zi2MFQQQkwYO66S1pGAr;

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return P1M3KvBQcs;
		}
		[CompilerGenerated]
		set
		{
			P1M3KvBQcs = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public IList<string> qSG3H1RveP()
	{
		return Tbl3x7U43c;
	}

	[SpecialName]
	[CompilerGenerated]
	public void oqn31x0KRd(IList<string> ilist_1)
	{
		Tbl3x7U43c = ilist_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string l3236LwAe5()
	{
		return tNv3rP0pNK;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ouA3XiLc0F(string string_2)
	{
		tNv3rP0pNK = string_2;
	}

	public static RD5TUqALOWDKBn8SE4W p7j3kLC8Tu(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return null;
		}
		string[] array = string_2.SplitToList(':', '：');
		if (array.Length != 3)
		{
			throw new InvalidDataException("路由规则不合法。");
		}
		RD5TUqALOWDKBn8SE4W rD5TUqALOWDKBn8SE4W = new RD5TUqALOWDKBn8SE4W();
		rD5TUqALOWDKBn8SE4W.Path = array[0];
		rD5TUqALOWDKBn8SE4W.ouA3XiLc0F(array[2]);
		array[1].SplitToList(',', '，');
		rD5TUqALOWDKBn8SE4W.oqn31x0KRd(array[1].SplitToList(',', '，').Select(_003C_003Ec.AKUvYMJ14tt ?? (_003C_003Ec.AKUvYMJ14tt = _003C_003Ec.WVBvYTwksue.WvhvYo8VXWg)).ToList());
		return rD5TUqALOWDKBn8SE4W;
	}

	internal static bool VmKsuuQQasxP17xbck5L()
	{
		return zi2MFQQQkwYO66S1pGAr == null;
	}
}
