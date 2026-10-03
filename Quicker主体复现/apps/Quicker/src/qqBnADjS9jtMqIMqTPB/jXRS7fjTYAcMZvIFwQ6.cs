using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dapper;
using log4net;
using Quicker.Domain;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace qqBnADjS9jtMqIMqTPB;

internal class jXRS7fjTYAcMZvIFwQ6 : ISearchHistoryStore
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LjavQVWswaU;

		public static Func<SearchPluginItem, string> CHevQZ3uhKD;

		public static Func<SearchPluginItem, string> Y7jvQ9xNWcP;

		public static Func<SearchPluginItem, string> J0BvQhp4MuH;

		private static _003C_003Ec pSqZ4VcsQ2r04IgrKI4R;

		static _003C_003Ec()
		{
			LjavQVWswaU = new _003C_003Ec();
		}

		internal string PuDvQRPgD82(SearchPluginItem x)
		{
			return x.PluginIdWithCondition;
		}

		internal string s63vQqaZaI1(SearchPluginItem x)
		{
			return x.PluginIdWithCondition;
		}

		internal string cvnvQc4pVLJ(SearchPluginItem x)
		{
			return x.PluginIdWithCondition;
		}

		internal static bool agZf11csF0eQy1X8ZjSZ()
		{
			return pSqZ4VcsQ2r04IgrKI4R == null;
		}

		internal static void cN0OnvcsWEOmyR1uAwGW()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public int ze5vQYY5aI2;

		internal static _003C_003Ec__DisplayClass8_0 cBaBibcsyYIEQ3IMaxNe;

		internal string r2qvQeIGfAi(string pwc)
		{
			return $"\r\nSELECT * FROM\r\n(SELECT PluginId,Condition,HistoryData,MAX(LastSelectTime) as LastSelectTime,SUM(UseCount) as UseCount\r\nFROM search_history \r\nWHERE  PluginWithCondition ='{pwc}' AND LastSelectTime>@LastSelectTime\r\nGROUP BY HistoryData,PluginWithCondition,PluginId,Condition\r\nORDER BY LastSelectTime DESC\r\nLIMIT {ze5vQYY5aI2})\r\n";
		}

		internal static bool Qopwqjcsp7v0QdQ9DCi5()
		{
			return cBaBibcsyYIEQ3IMaxNe == null;
		}
	}

	private static readonly ILog S1Otk6rPhC5;

	internal static jXRS7fjTYAcMZvIFwQ6 hslEaQQk3FKrICuk4MyS;

	public string hNptksQZ4Bx()
	{
		return Path.Combine(AppHelper.GetUserDataDir("data"), AppState.DataService.PZTtmCY0ah7() + "_searchhistory.db");
	}

	public void FHytkHbIqyJ()
	{
		string text = hNptksQZ4Bx();
		try
		{
			if (!File.Exists(text))
			{
				PGGtk1UV89C(text);
				return;
			}
			try
			{
				using SQLiteConnection sQLiteConnection = AUWtkbe3bHD();
				sQLiteConnection.Query("SELECT * FROM search_history LIMIT 1;");
				sQLiteConnection.Close();
			}
			catch (Exception ex)
			{
				S1Otk6rPhC5.Warn("搜索历史数据库文件错误。" + ex.Message + ", 将重建数据文件。", ex);
				File.Move(text, text + "." + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak");
				File.Delete(text);
				PGGtk1UV89C(text);
				AppHelper.ShowWarning("搜索历史文件");
			}
		}
		catch (Exception ex2)
		{
			S1Otk6rPhC5.Warn("创建数据库文件出错：" + ex2.Message, ex2);
		}
	}

	private static void PGGtk1UV89C(string string_0)
	{
		try
		{
			FileSystemHelper.EnsureFileFolderExists(string_0);
			SQLiteConnection.CreateFile(string_0);
			using SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + string_0 + ";Version=3;");
			sQLiteConnection.Open();
			using SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);
			sQLiteCommand.CommandText = "CREATE TABLE IF NOT EXISTS search_history (\r\n    Id INTEGER PRIMARY KEY AUTOINCREMENT, \r\n    SearchText TEXT,\r\n    LastSelectTime NOT NULL DEFAULT 0,\r\n    UseCount INTEGER NOT NULL DEFAULT 0,\r\n    HistoryData TEXT,\r\n    PluginId TEXT NOT NULL,\r\n    Condition TEXT NOT NULL DEFAULT '',\r\n    PluginWithCondition TEXT NOT NULL,\r\n    CurrentProcess TEXT,\r\n    ScoreDelta INT NOT NULL DEFAULT 0,\r\n    ExtraData TEXT\r\n);\r\nCREATE INDEX IF NOT EXISTS search_history_searchtext_idx ON search_history (SearchText);\r\nCREATE INDEX IF NOT EXISTS search_history_lastselecttime_idx ON search_history (LastSelectTime);\r\nCREATE INDEX IF NOT EXISTS search_history_pluginwithcondition_idx ON search_history (PluginWithCondition);\r\nCREATE UNIQUE INDEX IF NOT EXISTS search_full_condition_idx \r\n    ON search_history (SearchText,PluginWithCondition,HistoryData,CurrentProcess);\r\n\r\n";
			sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			S1Otk6rPhC5.Error("创建本地文件数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("创建本地数据文件出错：" + ex.Message);
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
		}
	}

	public void Init()
	{
		FHytkHbIqyJ();
	}

	private SQLiteConnection AUWtkbe3bHD()
	{
		return new SQLiteConnection("Data Source=" + hNptksQZ4Bx() + ";Version=3;");
	}

	public void AddHistory(SearchHistoryItem searchHistoryItem_0)
	{
		try
		{
			using SQLiteConnection cnn = AUWtkbe3bHD();
			string sql = "\r\nINSERT INTO search_history (SearchText,LastSelectTime,UseCount,HistoryData,PluginId,Condition,PluginWithCondition,CurrentProcess,ScoreDelta,ExtraData)\r\n    VALUES (@SearchText,@LastSelectTime,@UseCount,@HistoryData,@PluginId,@Condition,@PluginWithCondition,@CurrentProcess,@ScoreDelta,@ExtraData)\r\n    ON CONFLICT (SearchText,PluginWithCondition,HistoryData,CurrentProcess) DO\r\n    UPDATE SET UseCount=UseCount+1,LastSelectTime=excluded.LastSelectTime; \r\n\r\nDELETE FROM search_history WHERE ScoreDelta=0 AND LastSelectTime<@LastSelectTime-2592000000;\r\n";
			cnn.Execute(sql, searchHistoryItem_0);
		}
		catch (Exception ex)
		{
			S1Otk6rPhC5.Warn("保存历史搜索记录出错：" + ex.Message, ex);
		}
	}

	public IList<SearchHistoryItem> GetSearchHistory(string string_0, IList<SearchPluginItem> ilist_0)
	{
		if (ilist_0.Count == 0)
		{
			return Array.Empty<SearchHistoryItem>();
		}
		try
		{
			using SQLiteConnection cnn = AUWtkbe3bHD();
			string sql = "SELECT * FROM search_history \r\nWHERE (SearchText = @SearchText OR SearchText LIKE @SearchTextLike)\r\n    AND LastSelectTime>@LastSelectTime \r\n    AND PluginWithCondition IN @PluginWithConditions \r\nORDER BY LastSelectTime DESC LIMIT 30;";
			return cnn.Query<SearchHistoryItem>(sql, new _003C_003Ef__AnonymousType1<string, string, long, List<string>>(string_0, string_0 + "%", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - 2592000000L, ilist_0.Select(_003C_003Ec.CHevQZ3uhKD ?? (_003C_003Ec.CHevQZ3uhKD = _003C_003Ec.LjavQVWswaU.PuDvQRPgD82)).ToList())).ToList();
		}
		catch (Exception ex)
		{
			S1Otk6rPhC5.Warn("GetSearchHistory出错：" + ex.Message, ex);
			return new List<SearchHistoryItem>();
		}
	}

	public IList<SearchHistoryItem> GetRecentSearchHistory(IList<SearchPluginItem> ilist_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		if (ilist_0.Count == 0)
		{
			return Array.Empty<SearchHistoryItem>();
		}
		_003C_003Ec__DisplayClass8_.ze5vQYY5aI2 = 15;
		string text = string.Empty;
		try
		{
			using SQLiteConnection cnn = AUWtkbe3bHD();
			text = string.Join("\r\n UNION ALL \r\n", ilist_0.Select(_003C_003Ec.Y7jvQ9xNWcP ?? (_003C_003Ec.Y7jvQ9xNWcP = _003C_003Ec.LjavQVWswaU.s63vQqaZaI1)).Select(_003C_003Ec__DisplayClass8_.r2qvQeIGfAi));
			text += " ORDER BY LastSelectTime DESC";
			return cnn.Query<SearchHistoryItem>(text, new _003C_003Ef__AnonymousType2<string, long, List<string>>(text, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - 2592000000L, ilist_0.Select(_003C_003Ec.J0BvQhp4MuH ?? (_003C_003Ec.J0BvQhp4MuH = _003C_003Ec.LjavQVWswaU.cvnvQc4pVLJ)).ToList())).ToList();
		}
		catch (Exception ex)
		{
			S1Otk6rPhC5.Warn("GetSearchHistory出错：" + ex.Message + " sql:" + text, ex);
			return new List<SearchHistoryItem>();
		}
	}

	static jXRS7fjTYAcMZvIFwQ6()
	{
		S1Otk6rPhC5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool uTaI63QkEvvSmj9uOyJB()
	{
		return hslEaQQk3FKrICuk4MyS == null;
	}
}
