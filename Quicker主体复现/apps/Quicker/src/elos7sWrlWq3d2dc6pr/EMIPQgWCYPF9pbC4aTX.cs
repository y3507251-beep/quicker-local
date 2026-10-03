using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Public.Searching;
using Quicker.Utilities._3rd;
using XVYgmtWxau9GCu4LbWf;

namespace elos7sWrlWq3d2dc6pr;

internal class EMIPQgWCYPF9pbC4aTX : SmartCollection<bs268GWtdlAMtSyu6IQ>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yVRvsi22kPc;

		public static Func<SearchResultItem, bs268GWtdlAMtSyu6IQ> FtXvs3OZpDA;

		private static _003C_003Ec EKD11KcgOeyFPg5p9Z8c;

		static _003C_003Ec()
		{
			yVRvsi22kPc = new _003C_003Ec();
		}

		internal bs268GWtdlAMtSyu6IQ aqyvslPJWUp(SearchResultItem x)
		{
			return new bs268GWtdlAMtSyu6IQ(x);
		}

		internal static void hgtZmgcgalnCd70JNhxc()
		{
		}

		internal static bool pvYoL8cgJV0CuKO55nS1()
		{
			return EKD11KcgOeyFPg5p9Z8c == null;
		}
	}

	private readonly List<bs268GWtdlAMtSyu6IQ> xH3tN9PodE0 = new List<bs268GWtdlAMtSyu6IQ>();

	private SearchPluginItem JaetNhsHSWJ;

	private object YqXtNe08N2B = new object();

	private static EMIPQgWCYPF9pbC4aTX aelwsWQAdcDx9QhFyFws;

	public EMIPQgWCYPF9pbC4aTX()
	{
	}

	public EMIPQgWCYPF9pbC4aTX(IEnumerable<bs268GWtdlAMtSyu6IQ> ienumerable_0)
		: base(ienumerable_0)
	{
	}

	[SpecialName]
	public List<bs268GWtdlAMtSyu6IQ> oK2tNVvFqBS()
	{
		return xH3tN9PodE0;
	}

	public void NWytNa29b4n(IList<SearchResultItem> ilist_0)
	{
		IEnumerable<bs268GWtdlAMtSyu6IQ> collection = ilist_0.Select(_003C_003Ec.FtXvs3OZpDA ?? (_003C_003Ec.FtXvs3OZpDA = _003C_003Ec.yVRvsi22kPc.aqyvslPJWUp));
		xH3tN9PodE0.Clear();
		xH3tN9PodE0.AddRange(collection);
		eoRtNRhxuxa();
	}

	public void gS0tN7rS4T5(SearchPluginItem searchPluginItem_1)
	{
		JaetNhsHSWJ = searchPluginItem_1;
		eoRtNRhxuxa();
	}

	private void eoRtNRhxuxa()
	{
		lock (YqXtNe08N2B)
		{
			if (JaetNhsHSWJ == null)
			{
				Reset(xH3tN9PodE0);
			}
			else
			{
				Reset(xH3tN9PodE0.Where(QpKtNcLavFP));
			}
		}
	}

	public void eootNqWdvcf()
	{
		lock (YqXtNe08N2B)
		{
			xH3tN9PodE0.Clear();
			JaetNhsHSWJ = null;
			Clear();
		}
	}

	[CompilerGenerated]
	private bool QpKtNcLavFP(bs268GWtdlAMtSyu6IQ bs268GWtdlAMtSyu6IQ_0)
	{
		return JaetNhsHSWJ == bs268GWtdlAMtSyu6IQ_0.Result.QueryContext?.PluginItem;
	}

	internal static bool QQZoXoQAOLB1cuEkwpch()
	{
		return aelwsWQAdcDx9QhFyFws == null;
	}
}
