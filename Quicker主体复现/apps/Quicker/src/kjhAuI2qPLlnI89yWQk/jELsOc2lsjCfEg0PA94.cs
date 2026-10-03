using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;
using Quicker.Modules.Searching.History;
using Quicker.Public.Searching;
using Quicker.Utilities;

namespace kjhAuI2qPLlnI89yWQk;

internal class jELsOc2lsjCfEg0PA94 : ISearchHistoryStore
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec lPKvHrstMnD;

		public static Func<SearchHistoryItem, bool> db8vHpqCCCs;

		public static Func<SearchHistoryItem, long> bwHvHBmOKaA;

		public static Func<SearchHistoryItem, int> KMgvHQUcPYZ;

		public static Func<SearchHistoryItem, long> pkfvHjSD5Hm;

		public static Func<SearchHistoryItem, string> bONvHn6C1vu;

		public static Func<SearchHistoryItem, long> vh0vH4cfAUr;

		private static _003C_003Ec rltWLqcgCFI8WB2HGLhy;

		static _003C_003Ec()
		{
			lPKvHrstMnD = new _003C_003Ec();
		}

		internal bool IScvHbDVcMg(SearchHistoryItem x)
		{
			return x.LastSelectTime > DateTimeOffset.Now.ToUnixTimeMilliseconds() - 2592000000L;
		}

		internal long tQAvH6XCRrK(SearchHistoryItem x)
		{
			return x.LastSelectTime;
		}

		internal int unevHX44V4H(SearchHistoryItem x)
		{
			return x.UseCount;
		}

		internal long DTCvHmwg1Rt(SearchHistoryItem x)
		{
			return x.LastSelectTime;
		}

		internal string KRMvHKJaPx9(SearchHistoryItem x)
		{
			return x.PlugInId + "-" + x.Condition + "-" + x.HistoryData;
		}

		internal long cutvHx3KVY3(SearchHistoryItem x)
		{
			return x.LastSelectTime;
		}

		internal static bool LnRwBhcg7kOTBlB6fX5H()
		{
			return rltWLqcgCFI8WB2HGLhy == null;
		}

		internal static void JPTK7PcghBOmochoJgvX()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public SearchHistoryItem prlvHd02M4g;

		public jELsOc2lsjCfEg0PA94 uBavHoirHZc;

		internal static _003C_003Ec__DisplayClass3_0 EoDxBAcgHYUuwO1wP8gU;

		internal bool KfxvH5WhGCF(SearchHistoryItem x)
		{
			if (x.SearchText == prlvHd02M4g.SearchText && x.PlugInId == prlvHd02M4g.PlugInId && x.Condition == prlvHd02M4g.Condition)
			{
				return x.HistoryData == prlvHd02M4g.HistoryData;
			}
			return false;
		}

		internal void aEmvHDSVD6t()
		{
			uBavHoirHZc.JvttNQb6iIx();
		}

		internal static bool wD4F4NcgzXBAm4HkCjpb()
		{
			return EoDxBAcgHYUuwO1wP8gU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public string gQRvHMPXp1Y;

		public IList<SearchPluginItem> ss9vHAJcwht;

		private static _003C_003Ec__DisplayClass7_0 ayIyv8cPFT8lLGEmgQML;

		internal bool oYTvHTXjyEe(SearchHistoryItem x)
		{
			_003C_003Ec__DisplayClass7_1 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_1
			{
				x = x
			};
			if (_003C_003Ec__DisplayClass7_.x.SearchText.StartsWith(gQRvHMPXp1Y) && _003C_003Ec__DisplayClass7_.x.SearchText.Length <= gQRvHMPXp1Y.Length + 1)
			{
				return ss9vHAJcwht.Any(_003C_003Ec__DisplayClass7_.oJlvHOBFNbU);
			}
			return false;
		}

		internal static bool irEB11cPctWITjBM8KUi()
		{
			return ayIyv8cPFT8lLGEmgQML == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_1
	{
		public SearchHistoryItem x;

		internal static _003C_003Ec__DisplayClass7_1 iQFkvocPyWQT9Ts1Oh7d;

		internal bool oJlvHOBFNbU(SearchPluginItem p)
		{
			if (p.Plugin.Id == x.PlugInId)
			{
				return EBMtN5bRPCE(p.Condition, x.Condition);
			}
			return false;
		}

		internal static bool S7TLWicPpBrRp2V5DXdU()
		{
			return iQFkvocPyWQT9Ts1Oh7d == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public string vD2vHUgyhCv;

		internal static _003C_003Ec__DisplayClass8_0 xxhs3icPeBPyKiIRbmEF;

		internal bool E8rvHFHG76b(SearchHistoryItem x)
		{
			return x.PlugInId == vD2vHUgyhCv;
		}

		internal static bool C63vjPcPj2vFBvCxN99N()
		{
			return xxhs3icPeBPyKiIRbmEF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public IList<SearchPluginItem> iWevHiKXOCd;

		internal static _003C_003Ec__DisplayClass9_0 ETluhucP3xU34vhV16IH;

		internal bool l1wvHlFZZxe(SearchHistoryItem x)
		{
			_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1
			{
				x = x
			};
			return iWevHiKXOCd.Any(_003C_003Ec__DisplayClass9_.oU0vH3T7X1a);
		}

		internal static void AOMsv8cP0g3Hmhg7AV96()
		{
		}

		internal static bool x9NQfQcPE7D3X6ZT6t3s()
		{
			return ETluhucP3xU34vhV16IH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_1
	{
		public SearchHistoryItem x;

		internal static _003C_003Ec__DisplayClass9_1 VDHMaZcP1ym2k0MKnIl5;

		internal bool oU0vH3T7X1a(SearchPluginItem p)
		{
			if (p.Plugin.Id == x.PlugInId)
			{
				return EBMtN5bRPCE(p.Condition, x.Condition);
			}
			return false;
		}

		internal static bool tshwX3cPKdQw699reWoI()
		{
			return VDHMaZcP1ym2k0MKnIl5 == null;
		}
	}

	private static readonly ILog zIAtND4F67v;

	private IList<SearchHistoryItem> kputNdbcWLe;

	private static jELsOc2lsjCfEg0PA94 SHxKjnQAxEjrPrjbjfmA;

	public void Init()
	{
	}

	public void AddHistory(SearchHistoryItem searchHistoryItem_0)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.prlvHd02M4g = searchHistoryItem_0;
		_003C_003Ec__DisplayClass3_.uBavHoirHZc = this;
		SearchHistoryItem searchHistoryItem = kputNdbcWLe.FirstOrDefault(_003C_003Ec__DisplayClass3_.KfxvH5WhGCF);
		if (searchHistoryItem != null)
		{
			searchHistoryItem.LastSelectTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			searchHistoryItem.UseCount++;
			int num = 0;
			if (!jZmsBIQAID2SHcZLKxGf())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			kputNdbcWLe.Add(_003C_003Ec__DisplayClass3_.prlvHd02M4g);
		}
		Task.Run((Action)_003C_003Ec__DisplayClass3_.aEmvHDSVD6t);
	}

	private void JvttNQb6iIx()
	{
		try
		{
			List<SearchHistoryItem> value = kputNdbcWLe.Where(_003C_003Ec.db8vHpqCCCs ?? (_003C_003Ec.db8vHpqCCCs = _003C_003Ec.lPKvHrstMnD.IScvHbDVcMg)).ToList();
			File.WriteAllText(qMwtNjUfbnL(), JsonConvert.SerializeObject(value, Formatting.Indented));
		}
		catch (Exception ex)
		{
			zIAtND4F67v.Warn("保存搜索历史出错：" + ex.Message, ex);
		}
	}

	private string qMwtNjUfbnL()
	{
		return Path.Combine(AppHelper.GetUserDataDir("data"), "search_history.json");
	}

	private void QUGtNnaV3eg()
	{
		if (kputNdbcWLe != null)
		{
			return;
		}
		if (File.Exists(qMwtNjUfbnL()))
		{
			try
			{
				string value = File.ReadAllText(qMwtNjUfbnL());
				kputNdbcWLe = JsonConvert.DeserializeObject<IList<SearchHistoryItem>>(value);
				return;
			}
			catch (Exception ex)
			{
				zIAtND4F67v.Warn("搜索历史文件加载出错：" + ex.Message, ex);
				kputNdbcWLe = new List<SearchHistoryItem>();
				return;
			}
		}
		kputNdbcWLe = new List<SearchHistoryItem>();
	}

	public IList<SearchHistoryItem> GetSearchHistory(string string_0, IList<SearchPluginItem> ilist_1)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.gQRvHMPXp1Y = string_0;
		_003C_003Ec__DisplayClass7_.ss9vHAJcwht = ilist_1;
		QUGtNnaV3eg();
		return kputNdbcWLe.Where(_003C_003Ec__DisplayClass7_.oYTvHTXjyEe).OrderByDescending(_003C_003Ec.bwHvHBmOKaA ?? (_003C_003Ec.bwHvHBmOKaA = _003C_003Ec.lPKvHrstMnD.tQAvH6XCRrK)).ThenByDescending(_003C_003Ec.KMgvHQUcPYZ ?? (_003C_003Ec.KMgvHQUcPYZ = _003C_003Ec.lPKvHrstMnD.unevHX44V4H))
			.Take(7)
			.ToList();
	}

	public IList<SearchHistoryItem> nDDtN4QYiNA(string string_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.vD2vHUgyhCv = string_0;
		QUGtNnaV3eg();
		return kputNdbcWLe.Where(_003C_003Ec__DisplayClass8_.E8rvHFHG76b).OrderByDescending(_003C_003Ec.pkfvHjSD5Hm ?? (_003C_003Ec.pkfvHjSD5Hm = _003C_003Ec.lPKvHrstMnD.DTCvHmwg1Rt)).Take(20)
			.ToList();
	}

	public IList<SearchHistoryItem> GetRecentSearchHistory(IList<SearchPluginItem> ilist_1)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.iWevHiKXOCd = ilist_1;
		QUGtNnaV3eg();
		return kputNdbcWLe.Where(_003C_003Ec__DisplayClass9_.l1wvHlFZZxe).DistinctBy(_003C_003Ec.bONvHn6C1vu ?? (_003C_003Ec.bONvHn6C1vu = _003C_003Ec.lPKvHrstMnD.KRMvHKJaPx9)).OrderByDescending(_003C_003Ec.vh0vH4cfAUr ?? (_003C_003Ec.vh0vH4cfAUr = _003C_003Ec.lPKvHrstMnD.cutvHx3KVY3))
			.Take(20)
			.ToList();
	}

	private static bool EBMtN5bRPCE(string string_0, string string_1)
	{
		if (string_0 == string_1)
		{
			return true;
		}
		if (string.IsNullOrEmpty(string_0) && string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		return false;
	}

	static jELsOc2lsjCfEg0PA94()
	{
		zIAtND4F67v = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool jZmsBIQAID2SHcZLKxGf()
	{
		return SHxKjnQAxEjrPrjbjfmA == null;
	}
}
