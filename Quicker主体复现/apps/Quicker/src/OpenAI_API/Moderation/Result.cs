using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace OpenAI_API.Moderation;

public class Result
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fEMvaNjbu0J;

		public static Func<KeyValuePair<string, bool>, bool> PF1vaJ5raQA;

		public static Func<KeyValuePair<string, bool>, string> MuBva0YsvJc;

		public static Func<KeyValuePair<string, double>, double> TbtvaCDpSAD;

		internal static _003C_003Ec omMoEPc1yZKrOcnhq1mW;

		static _003C_003Ec()
		{
			fEMvaNjbu0J = new _003C_003Ec();
		}

		internal bool c5dvaSgUA4W(KeyValuePair<string, bool> kv)
		{
			return kv.Value;
		}

		internal string mRova23bFVo(KeyValuePair<string, bool> kv)
		{
			return kv.Key;
		}

		internal double v0SvauDQXb9(KeyValuePair<string, double> kv)
		{
			return kv.Value;
		}

		internal static bool BssW2Dc1pp7VTfdt6k5L()
		{
			return omMoEPc1yZKrOcnhq1mW == null;
		}

		internal static void Y8xNxUc12v29JJ458Hv5()
		{
		}
	}

	[CompilerGenerated]
	private IDictionary<string, bool> hZhqsd8TUY;

	[CompilerGenerated]
	private IDictionary<string, double> BW6qHT3tbH;

	[CompilerGenerated]
	private bool Svcq1vmrlp;

	private static Result tOKxLFkjPyC4auDMrhb;

	[JsonProperty("categories")]
	public IDictionary<string, bool> Categories
	{
		[CompilerGenerated]
		get
		{
			return hZhqsd8TUY;
		}
		[CompilerGenerated]
		set
		{
			hZhqsd8TUY = value;
		}
	}

	[JsonProperty("category_scores")]
	public IDictionary<string, double> CategoryScores
	{
		[CompilerGenerated]
		get
		{
			return BW6qHT3tbH;
		}
		[CompilerGenerated]
		set
		{
			BW6qHT3tbH = value;
		}
	}

	[JsonProperty("flagged")]
	public bool Flagged
	{
		[CompilerGenerated]
		get
		{
			return Svcq1vmrlp;
		}
		[CompilerGenerated]
		set
		{
			Svcq1vmrlp = value;
		}
	}

	public IList<string> FlaggedCategories => Categories.Where(_003C_003Ec.PF1vaJ5raQA ?? (_003C_003Ec.PF1vaJ5raQA = _003C_003Ec.fEMvaNjbu0J.c5dvaSgUA4W)).OrderByDescending(CVWqGp2efC).Select(_003C_003Ec.MuBva0YsvJc ?? (_003C_003Ec.MuBva0YsvJc = _003C_003Ec.fEMvaNjbu0J.mRova23bFVo))
		.ToList();

	public string MainContentFlag => FlaggedCategories.FirstOrDefault();

	public double HighestFlagScore => CategoryScores.OrderByDescending(_003C_003Ec.TbtvaCDpSAD ?? (_003C_003Ec.TbtvaCDpSAD = _003C_003Ec.fEMvaNjbu0J.v0SvauDQXb9)).First().Value;

	[CompilerGenerated]
	private double? CVWqGp2efC(KeyValuePair<string, bool> ueGMIyqFTeLSr6Zm6vw)
	{
		return CategoryScores?[ueGMIyqFTeLSr6Zm6vw.Key];
	}

	internal static bool rJOKEakDRVOV10BPROG()
	{
		return tOKxLFkjPyC4auDMrhb == null;
	}

	internal static void hUOWUXkED180MGbsC41()
	{
	}
}
