using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Buax0Q2tBANN3iv8TIl;
using Dapper;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Sync.V3;
using Quicker.Common.Vm.Sync.V4;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Entities;
using Quicker.Domain.Interfaces;
using Quicker.Domain.Local;
using Quicker.Domain.Network;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.SQL.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Services;

public class SQLDataMgr
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec unYv5IXYNaS;

		public static Func<ProfileDataEntity, ActionProfile> Kpiv5Wd1HfO;

		private static _003C_003Ec l4KL4XWFNYH4y1tSiKKi;

		static _003C_003Ec()
		{
			unYv5IXYNaS = new _003C_003Ec();
		}

		internal ActionProfile Hmav5YZET42(ProfileDataEntity x)
		{
			return JsonConvert.DeserializeObject<ActionProfile>(x.Data);
		}

		internal static bool y554WDWF9DLf2Bsx2lKu()
		{
			return l4KL4XWFNYH4y1tSiKKi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public SQLDataMgr Qrpv5G2Gqtj;

		public CommonDataEntity a32v5ssADww;

		private static _003C_003Ec__DisplayClass34_0 KrQSHOWFuBdneMsMTAD9;

		internal void MvKv5kqUdXH()
		{
			using SQLiteConnection cnn = Qrpv5G2Gqtj.uqDtxMWNJPB();
			cnn.Execute("INSERT INTO CommonData (Id, Data, LastUpdateTimeUtc, SyncState, SyncErrorMessage, LocalOnly, IsDeleted, DeleteTimeUtc) \r\n                            VALUES(@Id, @Data, @LastUpdateTimeUtc, @SyncState, @SyncErrorMessage, @LocalOnly, @IsDeleted, @DeleteTimeUtc)\r\n                            ON CONFLICT(Id) DO UPDATE SET Data=excluded.Data,LastUpdateTimeUtc=excluded.LastUpdateTimeUtc,SyncState=excluded.SyncState,LocalOnly=excluded.LocalOnly,IsDeleted=excluded.IsDeleted,DeleteTimeUtc=excluded.DeleteTimeUtc ;\r\n\r\n", a32v5ssADww);
		}

		internal static bool nyklyaWForlNqinO6vV0()
		{
			return KrQSHOWFuBdneMsMTAD9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0<T> where T : class
	{
		public string id;

		private static object Y4KWCsWFbX16Gmac3Utr;

		internal bool go3v5HnSsMG(CommonDataEntity x)
		{
			return x.Id == id;
		}

		internal static bool lwEA1qWFqBdDwQyi860w()
		{
			return Y4KWCsWFbX16Gmac3Utr == null;
		}
	}

	private readonly IAppPathProvider rgstrXjG26W;

	private static readonly ILog pIytrmrRhkp;

	[CompilerGenerated]
	private bool gJotrKPfB5x;

	private string JGFtrxUBtxC;

	private string cvmtrrvtyT4;

	internal static SQLDataMgr mO2qlFQNkCTaGoZ50ts5;

	public bool IsReadonly
	{
		[CompilerGenerated]
		get
		{
			return gJotrKPfB5x;
		}
		[CompilerGenerated]
		private set
		{
			gJotrKPfB5x = value;
		}
	}

	public void SetReadonly(bool isReadonly)
	{
		IsReadonly = isReadonly;
	}

	public SQLDataMgr(IAppPathProvider pathProvider)
	{
		SqlMapper.AddTypeHandler(new DateTimeHandler());
		rgstrXjG26W = pathProvider;
		AppState.SQLDataMgr = this;
	}

	public string GetDbFilePath()
	{
		string path = "quicker.db";
		if (JGFtrxUBtxC == null)
		{
			JGFtrxUBtxC = Path.Combine(rgstrXjG26W.GetDataSubFolder(), path);
		}
		return JGFtrxUBtxC;
	}

	public void PrepareDb()
	{
		if (!File.Exists(GetDbFilePath())) { AXAtxQ3qKbU(); return; }
		if (new FileInfo(GetDbFilePath()).Length < 10) throw new InvalidDataException("本地数据库文件异常，已保留原文件，请从本地备份恢复。");
		using var connection = uqDtxMWNJPB();
		connection.Open();
		rI6txpMNrRo(connection);
	}

	private static void rI6txpMNrRo(SQLiteConnection sqliteConnection_0)
	{
		GCHtxj40cEe(nmWtxBZmG7t(sqliteConnection_0), sqliteConnection_0);
	}

	private static int nmWtxBZmG7t(SQLiteConnection sqliteConnection_0)
	{
		string commandText = "SELECT Data FROM CommonData WHERE Id=@Id";
		using SQLiteCommand sQLiteCommand = sqliteConnection_0.CreateCommand();
		sQLiteCommand.CommandText = commandText;
		sQLiteCommand.Parameters.Add(new SQLiteParameter("@Id", "db_version"));
		object obj = sQLiteCommand.ExecuteScalar();
		if (obj != DBNull.Value && obj != null)
		{
			return Convert.ToInt32(obj, CultureInfo.InvariantCulture);
		}
		return 0;
	}

	private void AXAtxQ3qKbU()
	{
		string dbFilePath = GetDbFilePath();
		FileSystemHelper.EnsureFileFolderExists(dbFilePath);
		SQLiteConnection.CreateFile(dbFilePath);
		using SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=" + dbFilePath + ";Version=3;DateTimeKind=Local");
		sQLiteConnection.SetPassword(Tu7txokRl8J());
		sQLiteConnection.Open();
		GCHtxj40cEe(0, sQLiteConnection);
	}

	private static void GCHtxj40cEe(int int_0, SQLiteConnection sqliteConnection_0)
	{
		List<KeyValuePair<int, IList<string>>> list = new List<KeyValuePair<int, IList<string>>>();
		Mwjtx4BXhVm(list);
		vtetxnQaxH6(list);
		TFntx5lQsxA(list);
		PqUtxDIcv9l(list);
		int num = int_0;
		foreach (KeyValuePair<int, IList<string>> item in (IEnumerable<KeyValuePair<int, IList<string>>>)list)
		{
			if (int_0 < item.Key)
			{
				if (item.Key <= num)
				{
					throw new InvalidOperationException("SQL语句版本顺序不正确！");
				}
				Q8jtxA5n0Wr(item.Value, sqliteConnection_0);
				num = item.Key;
			}
		}
		string commandText = "REPLACE INTO CommonData(Id, Data, LastUpdateTimeUtc, LocalOnly) VALUES(@Id, @Data, @LastUpdateTimeUtc, @LocalOnly)";
		using SQLiteCommand sQLiteCommand = sqliteConnection_0.CreateCommand();
		sQLiteCommand.CommandText = commandText;
		sQLiteCommand.Parameters.Add(new SQLiteParameter("@Id", "db_version"));
		sQLiteCommand.Parameters.Add(new SQLiteParameter("@Data", num));
		sQLiteCommand.Parameters.Add(new SQLiteParameter("@LastUpdateTimeUtc", AppHelper.GetUtcNowForDb()));
		sQLiteCommand.Parameters.Add(new SQLiteParameter("@LocalOnly", true));
		sQLiteCommand.ExecuteNonQuery();
		iPytxdmduxg(sqliteConnection_0);
	}

	private static void vtetxnQaxH6(IList<KeyValuePair<int, IList<string>>> ilist_0)
	{
		IList<string> value = new List<string> { "\r\nDROP TABLE if exists  LocalSharedAction;\r\n\r\nCREATE TABLE \"LocalSharedAction\" (\r\n\t\"SharedActionId\"\tTEXT NOT NULL,\r\n\t\"Revision\"\tNUMERIC NOT NULL,\r\n\t\"Data\"\tTEXT,\r\n\t\"InstallTimeUtc\"\tTEXT,\r\n\tPRIMARY KEY(\"SharedActionId\",\"Revision\")\r\n);\r\n            " };
		ilist_0.Add(new KeyValuePair<int, IList<string>>(2, value));
	}

	private static void Mwjtx4BXhVm(IList<KeyValuePair<int, IList<string>>> ilist_0)
	{
		IList<string> value = new List<string> { "\r\nCREATE TABLE \"Profiles\" (\r\n\t\"Id\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Data\"\tTEXT NOT NULL,\r\n\t\"LastUpdateTimeUtc\"\tTEXT,\r\n\t\"IsDeleted\"\tINTEGER NOT NULL DEFAULT 0,\r\n\t\"DeleteTimeUtc\"\tTEXT,\r\n\t\"SyncState\"\tINTEGER NOT NULL DEFAULT 0,\r\n    \"SyncErrorMessage\"\tTEXT,\r\n\tPRIMARY KEY(\"Id\")\r\n)", "CREATE UNIQUE INDEX \"idx_profiles_id\" ON \"Profiles\" (\r\n\t\"Id\"\r\n)\r\n", "CREATE TABLE \"CommonData\" (\r\n\t\"Id\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Data\"\tTEXT,\r\n\t\"LastUpdateTimeUtc\"\tTEXT,\r\n\t\"SyncState\"\tINTEGER NOT NULL DEFAULT 0,\r\n    \"SyncErrorMessage\"\tTEXT,\r\n    \"LocalOnly\"\tINTEGER NOT NULL DEFAULT 0,\r\n\tPRIMARY KEY(\"Id\")\r\n)", "CREATE UNIQUE INDEX \"idx_commondata_id\" ON \"CommonData\" (\r\n\t\"Id\"\tASC\r\n)", "CREATE TABLE \"SyncLog\" (\r\n\t\"SyncTimeUtc\"\tText ,\r\n\t\"IsSuccess\"\tINTEGER NOT NULL DEFAULT 0,\r\n\t\"Message\"\tTEXT,\r\n\t\"Vm\"\tTEXT,\r\n    \"Result\"\tTEXT\r\n)", "CREATE TABLE \"ActionHistory\" (\r\n    \"ActionId\"\tTEXT,\r\n\t\"BackupTimeUtc\"\tTEXT NOT NULL,\r\n\t\"ExpireTimeUtc\"\tTEXT,\r\n\t\"BackupType\"\tINTEGER NOT NULL DEFAULT 0,\r\n\t\"Note\"\tTEXT,\r\n\t\"Data\"\tTEXT\r\n);", "CREATE INDEX \"idx_ActionHistory_ActionId\" ON \"ActionHistory\" (\r\n\t\"ActionId\"\tASC\r\n);", "CREATE TABLE \"LocalActionInfo\" (\r\n\t\"ActionId\"\tTEXT NOT NULL UNIQUE,\r\n\t\"ClickCount\"\tINTEGER NOT NULL DEFAULT 0,\r\n\t\"LastClickTimeUtc\"\tTEXT,\r\n\t\"SyncState\"\tINTEGER NOT NULL DEFAULT 0,\r\n\tPRIMARY KEY(\"ActionId\")\r\n);", "CREATE TABLE \"LocalSharedAction\" (\r\n\t\"SharedActionId\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Revision\"\tNUMERIC NOT NULL,\r\n\t\"Data\"\tTEXT,\r\n\t\"InstallTimeUtc\"\tTEXT,\r\n\tPRIMARY KEY(\"SharedActionId\")\r\n);" };
		ilist_0.Add(new KeyValuePair<int, IList<string>>(1, value));
	}

	private static void TFntx5lQsxA(IList<KeyValuePair<int, IList<string>>> ilist_0)
	{
		IList<string> value = new List<string> { "DELETE FROM SyncLog", "CREATE TABLE \"ProfileBackupItems\" (\r\n\t\"Id\"\tTEXT NOT NULL,\r\n\t\"ProfileId\"\tTEXT NOT NULL,\r\n\t\"BackupTimeUtc\"\tTEXT NOT NULL,\r\n\t\"Data\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"Id\")\r\n)", "\r\nALTER TABLE CommonData ADD COLUMN \"IsDeleted\" INT  NOT NULL DEFAULT 0 ;\r\nALTER TABLE CommonData ADD COLUMN \"DeleteTimeUtc\" TEXT;\r\nALTER TABLE CommonData ADD COLUMN \"Revision\" INT NOT NULL DEFAULT 0;\r\n\r\nALTER TABLE Profiles ADD COLUMN \"Revision\" INT NOT NULL DEFAULT 0;\r\n\r\n            " };
		ilist_0.Add(new KeyValuePair<int, IList<string>>(3, value));
	}

	private static void PqUtxDIcv9l(IList<KeyValuePair<int, IList<string>>> ilist_0)
	{
		IList<string> value = new List<string> { "\r\nALTER TABLE CommonData ADD COLUMN \"DisplayName\" TEXT;\r\nALTER TABLE CommonData ADD COLUMN \"SubType\" TEXT;\r\n            " };
		ilist_0.Add(new KeyValuePair<int, IList<string>>(4, value));
	}

	private static void iPytxdmduxg(SQLiteConnection sqliteConnection_0)
	{
		sqliteConnection_0.Execute("DELETE FROM Profiles WHERE IsDeleted=@IsDeleted AND SyncState=@SyncState AND DeleteTimeUtc < @DeleteTimeUtc", new _003C_003Ef__AnonymousType26<bool, ItemSyncState, DateTime>(true, ItemSyncState.None, AppHelper.GetUtcNowForDb().AddDays(-30.0)));
		sqliteConnection_0.Execute("DELETE FROM SyncLog WHERE SyncTimeUtc < @SyncTimeUtc;", new _003C_003Ef__AnonymousType27<DateTime>(AppHelper.GetUtcNowForDb().AddDays(-3.0)));
		sqliteConnection_0.Execute("DELETE FROM ActionHistory WHERE ExpireTimeUtc < @Now", new _003C_003Ef__AnonymousType28<DateTime>(AppHelper.GetUtcNowForDb()));
		sqliteConnection_0.Execute("DELETE FROM ProfileBackupItems WHERE BackupTimeUtc < @ExpireTime;", new _003C_003Ef__AnonymousType29<DateTime>(AppHelper.GetUtcNowForDb().AddDays(-3.0)));
		sqliteConnection_0.Execute("PRAGMA auto_vacuum = 1;");
	}

	public (bool isSuccess, long oringinFileSize, long newFileSize) ShrinkFileAsync()
	{
		string dbFilePath = GetDbFilePath();
		long length = new FileInfo(dbFilePath).Length;
		using (SQLiteConnection cnn = uqDtxMWNJPB())
		{
			cnn.Execute("vacuum;");
		}
		long length2 = new FileInfo(dbFilePath).Length;
		return (isSuccess: true, oringinFileSize: length, newFileSize: length2);
	}

	public int ClearActionVersions()
	{
		string dbFilePath = GetDbFilePath();
		long length = new FileInfo(dbFilePath).Length;
		int result = 0;
		using (SQLiteConnection cnn = uqDtxMWNJPB())
		{
			result = cnn.Execute("DELETE FROM ActionHistory WHERE BackupType=1 AND BackupTimeUtc < @Now", new _003C_003Ef__AnonymousType28<DateTime>(AppHelper.GetUtcNowForDb().AddDays(-30.0)));
		}
		long length2 = new FileInfo(dbFilePath).Length;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static string Tu7txokRl8J()
	{
		return "quicker_2019@" + 418 + new DateTime(2020, 3, 5, 6, 7, 8).ToString("yyMMddHHmmss", CultureInfo.InvariantCulture);
	}

	private string tEUtxTThx1m()
	{
		if (cvmtrrvtyT4 == null)
		{
			cvmtrrvtyT4 = "Data Source=" + GetDbFilePath() + ";Version=3;Password=" + Tu7txokRl8J() + ";DateTimeKind=Local;Pooling=true";
		}
		return cvmtrrvtyT4;
	}

	private SQLiteConnection uqDtxMWNJPB()
	{
		return new SQLiteConnection(tEUtxTThx1m());
	}

	private static void Q8jtxA5n0Wr(IList<string> ilist_0, SQLiteConnection sqliteConnection_0)
	{
		using SQLiteCommand sQLiteCommand = sqliteConnection_0.CreateCommand();
		foreach (string item in ilist_0)
		{
			sQLiteCommand.CommandText = item;
			sQLiteCommand.ExecuteNonQuery();
		}
	}


	internal void JoytxFfaSyO()
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute("DELETE FROM CommonData WHERE rowid NOT IN (SELECT max(rowid) FROM CommonData GROUP BY Id);");
	}

	internal void fcGtxUEHcM1(string string_2, string string_3, bool bool_1, DateTime dateTime_0, bool bool_2 = false, DateTime? nullable_0 = null)
	{
		if (IsReadonly)
		{
			return;
		}
		if (dateTime_0.Kind == DateTimeKind.Utc)
		{
			dateTime_0 = DateTime.SpecifyKind(dateTime_0, DateTimeKind.Local);
		}
		ProfileDataEntity param = new ProfileDataEntity
		{
			Id = string_2,
			Data = string_3,
			DeleteTimeUtc = nullable_0,
			IsDeleted = bool_2,
			LastUpdateTimeUtc = dateTime_0,
			SyncState = ItemSyncState.None,
			SyncErrorMessage = string.Empty
		};
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute("INSERT INTO Profiles(Id, Data, LastUpdateTimeUtc, IsDeleted, DeleteTimeUtc, SyncState, SyncErrorMessage) \r\n                                VALUES(@Id, @Data, @LastUpdateTimeUtc, @IsDeleted, @DeleteTimeUtc, @SyncState, @SyncErrorMessage)\r\n                                ON CONFLICT(Id) DO UPDATE \r\n                SET Data=excluded.Data,LastUpdateTimeUtc=excluded.LastUpdateTimeUtc,IsDeleted=excluded.IsDeleted,DeleteTimeUtc=excluded.DeleteTimeUtc,SyncState=excluded.SyncState,SyncErrorMessage=excluded.SyncErrorMessage ;\r\n", param);
	}

	internal void mCXtxlXbkjx(string string_2)
	{
		if (IsReadonly)
		{
			return;
		}
		using SQLiteConnection cnn = uqDtxMWNJPB();
		DateTime utcNowForDb = AppHelper.GetUtcNowForDb();
		cnn.Execute("UPDATE Profiles SET IsDeleted=@IsDeleted,DeleteTimeUtc=@DeleteTimeUtc,LastUpdateTimeUtc=@LastUpdateTimeUtc,SyncState=@SyncState WHERE Id=@Id", new _003C_003Ef__AnonymousType30<string, bool, DateTime, DateTime, ItemSyncState>(string_2, true, utcNowForDb, utcNowForDb, ItemSyncState.None));
	}

	internal IList<ActionProfile> dx6txigpN25()
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.Query<ProfileDataEntity>("SELECT * FROM Profiles WHERE IsDeleted=@IsDeleted", new _003C_003Ef__AnonymousType31<bool>(false)).Select(_003C_003Ec.Kpiv5Wd1HfO ?? (_003C_003Ec.Kpiv5Wd1HfO = _003C_003Ec.unYv5IXYNaS.Hmav5YZET42)).ToList();
	}

	internal ProfileDataEntity GqStx3pjsFN(string string_2)
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.QueryFirst<ProfileDataEntity>("SELECT * FROM Profiles Where Id=@Id", new _003C_003Ef__AnonymousType32<string>(string_2));
	}

	internal IList<ProfileDataEntity> OYBtxfsIXs3()
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.Query<ProfileDataEntity>("SELECT * FROM Profiles").ToList();
	}

	internal void SaveCommonDataObjectFromLocal(string id, object dataObject, bool localOnly)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.Qrpv5G2Gqtj = this;
		if (!IsReadonly)
		{
			_003C_003Ec__DisplayClass34_.a32v5ssADww = new CommonDataEntity
			{
				Id = id,
				Data = JsonConvert.SerializeObject(dataObject),
				LastUpdateTimeUtc = AppHelper.GetUtcNowForDb(),
				SyncState = ItemSyncState.None,
				SyncErrorMessage = string.Empty,
				LocalOnly = true,
				IsDeleted = false,
				DeleteTimeUtc = null
			};
			OmgtxzBlvOK(3, _003C_003Ec__DisplayClass34_.MvKv5kqUdXH, "SaveCommonDataObjectFromLocal");
		}
	}

	private void OmgtxzBlvOK(int int_0, Action action_0, string string_2)
	{
		Exception lastError = null;
		for (int i = 0; i < int_0; i++)
		{
		    try { action_0(); return; }
		    catch (Exception error) { lastError = error; }
		}
		throw new IOException(string_2 + " 写入本地数据库失败。", lastError);
	}

	internal void qektrwnCtKy(string string_2)
	{
		string sql = "UPDATE CommonData SET IsDeleted=@IsDeleted,DeleteTimeUtc=@DeleteTimeUtc, LastUpdateTimeUtc=@LastUpdateTimeUtc,SyncState=@SyncState WHERE Id=@Id";
		using SQLiteConnection cnn = uqDtxMWNJPB();
		DateTime utcNowForDb = AppHelper.GetUtcNowForDb();
		cnn.Execute(sql, new _003C_003Ef__AnonymousType33<string, bool, DateTime, DateTime, ItemSyncState>(string_2, true, utcNowForDb, utcNowForDb, ItemSyncState.None));
	}

	internal gmAFwIX1XYIwDN5tuXW PP6trtaO3SY<gmAFwIX1XYIwDN5tuXW>(string string_2) where gmAFwIX1XYIwDN5tuXW : class
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		CommonDataEntity commonDataEntity = cnn.QueryFirstOrDefault<CommonDataEntity>("SELECT * FROM CommonData WHERE Id=@Id AND IsDeleted=0", new _003C_003Ef__AnonymousType32<string>(string_2));
		if (commonDataEntity == null)
		{
			return null;
		}
		return JsonConvert.DeserializeObject<gmAFwIX1XYIwDN5tuXW>(commonDataEntity.Data);
	}

	private yIUGCgXcZXAXZmdeq2w gBqtrgkYgcp<yIUGCgXcZXAXZmdeq2w>(IList<CommonDataEntity> ilist_0, string string_2) where yIUGCgXcZXAXZmdeq2w : class
	{
		_003C_003Ec__DisplayClass38_0<yIUGCgXcZXAXZmdeq2w> _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0<yIUGCgXcZXAXZmdeq2w>();
		_003C_003Ec__DisplayClass38_.id = string_2;
		CommonDataEntity commonDataEntity = ilist_0.FirstOrDefault(_003C_003Ec__DisplayClass38_.go3v5HnSsMG);
		if (commonDataEntity == null)
		{
			return null;
		}
		return JsonConvert.DeserializeObject<yIUGCgXcZXAXZmdeq2w>(commonDataEntity.Data);
	}

	public TextFloatPanelState GetTextFloatPanelState()
	{
		return PP6trtaO3SY<TextFloatPanelState>("user_txtFloatPanelState");
	}

	public TextFloatPanelState GetTextFloatPanelState(IList<CommonDataEntity> commonDataEntities)
	{
		foreach (CommonDataEntity commonDataEntity in commonDataEntities)
		{
			if (commonDataEntity.Id.Equals("user_txtFloatPanelState", StringComparison.OrdinalIgnoreCase))
			{
				return JsonConvert.DeserializeObject<TextFloatPanelState>(commonDataEntity.Data);
			}
		}
		return null;
	}

	public void SaveTextFloatPanelState(TextFloatPanelState state)
	{
		SaveCommonDataObjectFromLocal("user_txtFloatPanelState", state, true);
	}

	internal void wcDtrLXGlFA(UsageSession usageSession_0)
	{
		if (!IsReadonly && usageSession_0 != null)
		{
			SaveCommonDataObjectFromLocal("user_usageSesion", usageSession_0, true);
		}
	}

	internal UsageSession Q5DtrvtDtLD()
	{
		return PP6trtaO3SY<UsageSession>("user_usageSesion");
	}

	internal void joVtrSyM3yO(string string_2, UserInfo userInfo_0)
	{
		if (!IsReadonly)
		{
			SaveCommonDataObjectFromLocal("secret_info", string_2, true);
			SaveCommonDataObjectFromLocal("user_info", userInfo_0, true);
		}
	}

	internal UserInfo YyAtr2ZVT13(IList<CommonDataEntity> ilist_0)
	{
		string text = gBqtrgkYgcp<string>(ilist_0, "secret_info");
		if (!string.IsNullOrEmpty(text))
		{
			return text.JJCtVt442Ip();
		}
		return gBqtrgkYgcp<UserInfo>(ilist_0, "user_info");
	}

	internal void oYetrup9mBq(UserSettings userSettings_0)
	{
		if (!IsReadonly)
		{
			SaveCommonDataObjectFromLocal("user_settings", userSettings_0, false);
		}
	}

	internal void CXxtrNobmuJ(IDictionary<int, PowerKey> idictionary_0)
	{
		if (!IsReadonly)
		{
			SaveCommonDataObjectFromLocal("user_powerKeys", idictionary_0, false);
		}
	}

	internal void Pf5trJnWTLt(IList<Gesture> ilist_0)
	{
		SaveCommonDataObjectFromLocal("user_gestures", ilist_0, false);
	}

	internal void Cu6tr09HBtk(IList<string> ilist_0)
	{
		SaveCommonDataObjectFromLocal("user_favorBlocks", ilist_0, false);
	}

	internal void gBCtrCXUYyB(UserPreference userPreference_0)
	{
		SaveCommonDataObjectFromLocal("user_preferences", userPreference_0 ?? new UserPreference(), false);
	}

	internal void ddLtrPPbm0D(IList<MouseAction> ilist_0)
	{
		if (!IsReadonly)
		{
			SaveCommonDataObjectFromLocal("user_mouseActions", ilist_0, false);
		}
	}

	internal void kfctrEcsj8x(IList<TextCommand> ilist_0)
	{
		if (!IsReadonly)
		{
			SaveCommonDataObjectFromLocal("user_textCommands", ilist_0, true);
		}
	}

	internal UserSettings K7Qtryaqck9(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<UserSettings>(ilist_0, "user_settings");
	}

	private IList<CommonDataEntity> nh4tr87rrTJ()
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.Query<CommonDataEntity>("SELECT * FROM CommonData WHERE IsDeleted=0 ORDER BY LastUpdateTimeUtc DESC").ToList();
	}

	internal (bool isSuccess, UserInfo userInfo, UserSettings userSettings, IList<ActionProfile> profiles, IDictionary<string, ExeSettings> exeSettings, TextFloatPanelState txtFloatpanelState, IDictionary<int, PowerKey> powerKeys, IList<TextCommand> textCommands, IList<MouseAction> mouseActions, IList<Gesture> gestures, IList<string> favorBlocks, IList<SubProgram> globalSubPrograms, UserPreference userPreference) jiDtra7gJVt()
	{
		IList<CommonDataEntity> list = nh4tr87rrTJ();
		UserInfo userInfo = LoadLocalWorkspace().ToLegacyView();
		UserSettings userSettings = K7Qtryaqck9(list);
		if (userSettings == null)
		{
			userSettings = new UserSettings();
		}
		IDictionary<string, ExeSettings> dictionary = F1jtrYJfaji(list);
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, ExeSettings>();
		}
		IList<ActionProfile> list2 = dx6txigpN25();
		foreach (ActionProfile item8 in list2)
		{
			item8.FixExeName();
		}
		TextFloatPanelState textFloatPanelState = GetTextFloatPanelState(list);
		IDictionary<int, PowerKey> item = DH3trVmZaVB(list) ?? new Dictionary<int, PowerKey>();
		IList<TextCommand> item2 = UXstr9IOTmk(list) ?? new List<TextCommand>();
		IList<MouseAction> item3 = CW0trZ4h1Xl(list) ?? new List<MouseAction>();
		IList<Gesture> item4 = NfrtrRYLPKf(list) ?? new List<Gesture>();
		IList<string> item5 = cDAtrqeJnPM(list) ?? new List<string>();
		UserPreference item6 = x8btrcqHy1j(list) ?? new UserPreference();
		IList<SubProgram> item7 = IPXtr7UZGKX(list) ?? new List<SubProgram>();
		return (isSuccess: true, userInfo: userInfo, userSettings: userSettings, profiles: list2, exeSettings: dictionary, txtFloatpanelState: textFloatPanelState, powerKeys: item, textCommands: item2, mouseActions: item3, gestures: item4, favorBlocks: item5, globalSubPrograms: item7, userPreference: item6);
	}

	private IList<SubProgram> IPXtr7UZGKX(IList<CommonDataEntity> ilist_0)
	{
		IList<SubProgram> list = new List<SubProgram>();
		foreach (CommonDataEntity item in ilist_0)
		{
			if (item.Id.StartsWith("shared_subprogram:"))
			{
				item.Id.Substring("shared_subprogram:".Length);
				list.Add(JsonConvert.DeserializeObject<SubProgram>(item.Data));
			}
		}
		return list;
	}

	private IList<Gesture> NfrtrRYLPKf(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<IList<Gesture>>(ilist_0, "user_gestures");
	}

	private IList<string> cDAtrqeJnPM(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<IList<string>>(ilist_0, "user_favorBlocks");
	}

	private UserPreference x8btrcqHy1j(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<UserPreference>(ilist_0, "user_preferences");
	}

	private IDictionary<int, PowerKey> DH3trVmZaVB(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<IDictionary<int, PowerKey>>(ilist_0, "user_powerKeys");
	}

	private IList<MouseAction> CW0trZ4h1Xl(IList<CommonDataEntity> ilist_0)
	{
		return gBqtrgkYgcp<IList<MouseAction>>(ilist_0, "user_mouseActions");
	}

	internal IList<TextCommand> UXstr9IOTmk(IList<CommonDataEntity> ilist_0)
	{
		IList<TextCommand> list = gBqtrgkYgcp<IList<TextCommand>>(ilist_0, "user_textCommands");
		return list ?? new List<TextCommand>();
	}

	internal IList<CommonDataEntity> bGGtrhbtBm3()
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.Query<CommonDataEntity>("SELECT * FROM CommonData WHERE LocalOnly=@LocalOnly", new _003C_003Ef__AnonymousType34<bool>(false)).ToList();
	}

	internal CommonDataEntity daWtreA8JCY(string string_2)
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.QueryFirst<CommonDataEntity>("SELECT * FROM CommonData WHERE Id=@ItemId", new _003C_003Ef__AnonymousType35<string>(string_2));
	}

	internal static IDictionary<string, ExeSettings> F1jtrYJfaji(IList<CommonDataEntity> ilist_0)
	{
		IDictionary<string, ExeSettings> dictionary = new Dictionary<string, ExeSettings>();
		foreach (CommonDataEntity item in ilist_0)
		{
			if (item.Id.StartsWith("exe:", StringComparison.OrdinalIgnoreCase))
			{
				ExeSettings value = JsonConvert.DeserializeObject<ExeSettings>(item.Data);
				dictionary.Add(item.Id.Substring("exe:".Length), value);
			}
		}
		return dictionary;
	}

	internal void LiZtrIojbbm(bool bool_1, string string_2, SyncVm3 syncVm3_0, SyncResult3 syncResult3_0)
	{
		string sql = "INSERT INTO SyncLog (SyncTimeUtc, IsSuccess, Message, Vm, Result) VALUES(@SyncTimeUtc, @IsSuccess, @Message, @Vm, @Result)";
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute(sql, new SyncLogItem
		{
			SyncTimeUtc = AppHelper.GetUtcNowForDb(),
			IsSuccess = bool_1,
			Message = string_2,
			Vm = ((syncVm3_0 != null) ? JsonConvert.SerializeObject(syncVm3_0) : string.Empty),
			Result = ((syncResult3_0 == null) ? string.Empty : JsonConvert.SerializeObject(syncResult3_0))
		});
	}

	internal IList<SyncLogItem> UKZtrWJeIVY()
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Query<SyncLogItem>("SELECT  * FROM SyncLog ORDER BY rowid desc LIMIT 60").ToList();
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("获取最新同步数据出错：" + ex.Message, ex);
			AppHelper.ShowWarning("读写数据库出错，请稍后重试。错误信息：" + ex.Message);
			return new List<SyncLogItem>();
		}
	}

	public void BackupAction(ActionHistoryItem item)
	{
		if (IsReadonly)
		{
			return;
		}
		string sql = "INSERT INTO ActionHistory (ActionId, BackupTimeUtc, ExpireTimeUtc, BackupType, Note, Data) VALUES(@ActionId, @BackupTimeUtc, @ExpireTimeUtc, @BackupType, @Note, @Data)";
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute(sql, item);
	}

	public void BackupAction(ActionItem action, ActionBackupType backupType, DateTime? expireTime = null, string note = "")
	{
		if (IsReadonly)
		{
			return;
		}
		ActionHistoryItem actionHistoryItem = new ActionHistoryItem
		{
			ActionId = action.Id,
			BackupTimeUtc = AppHelper.GetUtcNowForDb(),
			Note = note,
			BackupType = backupType,
			Data = JsonConvert.SerializeObject(action)
		};
		if (expireTime.HasValue)
		{
			actionHistoryItem.ExpireTimeUtc = expireTime.Value;
		}
		else
		{
			actionHistoryItem.ExpireTimeUtc = DateTime.MaxValue;
		}
		BackupAction(actionHistoryItem);
		if (backupType != ActionBackupType.Deleting)
		{
			return;
		}
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute("UPDATE ActionHistory SET ExpireTimeUtc=@ExpireTime WHERE ActionId=@ActionId AND ExpireTimeUtc > @ToLongTime", new _003C_003Ef__AnonymousType36<string, DateTime, DateTime>(action.Id, AppHelper.GetUtcNowForDb().AddDays(3.0), AppHelper.GetUtcNowForDb().AddDays(32.0)));
	}

	public IList<ActionHistoryItem> GetDeletedActionBackupItems()
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Query<ActionHistoryItem>("SELECT * FROM ActionHistory WHERE BackupType=@BackupType ORDER BY BackupTimeUtc DESC", new _003C_003Ef__AnonymousType37<ActionBackupType>(ActionBackupType.Deleting)).ToList();
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return new List<ActionHistoryItem>();
		}
	}

	internal void okttrkaoQGM(string string_2, DateTime dateTime_0)
	{
		if (dateTime_0.Kind == DateTimeKind.Utc)
		{
			dateTime_0 = DateTime.SpecifyKind(dateTime_0, DateTimeKind.Local);
		}
		string sql = "DELETE FROM ActionHistory WHERE ActionId=@ActionId and BackupTimeUtc=@BackupTimeUtc";
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			cnn.Execute(sql, new _003C_003Ef__AnonymousType38<string, DateTime>(string_2, dateTime_0));
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("更新数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("更新数据库出错，请重试。" + ex.Message);
		}
	}

	public IList<ActionHistoryItem> GetActionHistoryItems(string actionId)
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Query<ActionHistoryItem>("SELECT rowid,* FROM ActionHistory WHERE ActionId=@ActionId ORDER BY BackupTimeUtc DESC", new _003C_003Ef__AnonymousType39<string>(actionId)).ToList();
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return new List<ActionHistoryItem>();
		}
	}

	public IList<ActionHistoryItem> GetActionHistoryItemList(string actionId)
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Query<ActionHistoryItem>("SELECT rowid,ActionId,BackupTimeUtc,ExpireTimeUtc,BackupType,Note FROM ActionHistory WHERE ActionId=@ActionId ORDER BY BackupTimeUtc DESC", new _003C_003Ef__AnonymousType39<string>(actionId)).ToList();
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return new List<ActionHistoryItem>();
		}
	}

	public ActionHistoryItem GetActionHistoryItem(string rowId)
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.QueryFirst<ActionHistoryItem>("SELECT rowid,* FROM ActionHistory WHERE rowid=@rowid ORDER BY BackupTimeUtc DESC", new _003C_003Ef__AnonymousType40<string>(rowId));
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return null;
		}
	}

	public int DeleteActionHistory(IList<string> rowIdList)
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Execute("Delete FROM ActionHistory WHERE rowid in @rowIdList", new _003C_003Ef__AnonymousType41<IList<string>>(rowIdList));
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return 0;
		}
	}

	public int DeleteActionHistoryAll(string actionId)
	{
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			return cnn.Execute("Delete FROM ActionHistory WHERE ActionId = @ActionId", new _003C_003Ef__AnonymousType39<string>(actionId));
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
			return 0;
		}
	}

	public void CountActionClick(string actionId)
	{
		if (IsReadonly)
		{
			return;
		}
		string sql = "\r\nINSERT OR REPLACE INTO LocalActionInfo (ActionId, ClickCount, LastClickTimeUtc, SyncState)\r\nVALUES (@ActionId, \r\nCOALESCE(\r\n    (Select ClickCount FROM LocalActionInfo WHERE ActionId=@ActionId),\r\n    0) + 1,\r\n@LastClickTimeUtc,\r\n@SyncState)\r\n";
		try
		{
			using SQLiteConnection cnn = uqDtxMWNJPB();
			cnn.Execute(sql, new _003C_003Ef__AnonymousType42<string, DateTime, QuickerSyncState>(actionId, AppHelper.GetUtcNowForDb(), QuickerSyncState.Pending));
		}
		catch (Exception ex)
		{
			pIytrmrRhkp.Warn("打开数据库出错：" + ex.Message, ex);
			AppHelper.ShowWarning("打开数据库出错，请重试。" + ex.Message);
		}
	}

	public int GetPendingSyncItemCount()
	{
		return 0;
	}

	public void SaveLastSyncInfo(LastSyncInfo syncInfo)
	{
		SaveCommonDataObjectFromLocal("local_last_sync_info", syncInfo, true);
	}

	public LastSyncInfo GetLastSyncInfo()
	{
		return PP6trtaO3SY<LastSyncInfo>("local_last_sync_info");
	}

	public void UpdateItemSyncResult(SyncItemResult4 syncItemResult, SyncItem4 syncItem, out bool changedWhenSync)
	{
		changedWhenSync = false;
		ItemSyncState4 syncState = syncItemResult.SyncState;
		string text = null;
		switch (syncItemResult.ItemType)
		{
		case SyncItemType.Profile:
			text = "UPDATE Profiles SET Revision=@Revision,SyncState=@SyncState WHERE Id=@Id AND (LastUpdateTimeUtc<=@LastUpdateTimeUtc OR LastUpdateTimeUtc = @LastUpdateTimeUtcAlternative)";
			break;
		case SyncItemType.CommonData:
			text = "UPDATE CommonData SET Revision=@Revision,SyncState=@SyncState WHERE Id=@Id AND (LastUpdateTimeUtc<=@LastUpdateTimeUtc OR LastUpdateTimeUtc = @LastUpdateTimeUtcAlternative)";
			break;
		}
		if (!string.IsNullOrEmpty(text))
		{
			using (SQLiteConnection cnn = uqDtxMWNJPB())
			{
				if (cnn.Execute(text, new _003C_003Ef__AnonymousType43<string, int?, ItemSyncState, DateTime, DateTime>(syncItemResult.ItemId, syncItemResult.BaseRevision, ItemSyncState.None, syncItem.LastUpdateTimeUtc, DateTime.SpecifyKind(syncItem.LastUpdateTimeUtc, DateTimeKind.Utc))) == 0)
				{
					switch (syncItemResult.ItemType)
					{
					case SyncItemType.Profile:
					{
						text = "UPDATE Profiles SET Revision=@Revision  WHERE Id=@Id  ";
						int num = 0;
						if (mO2qlFQNkCTaGoZ50ts5 != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						}
						break;
					}
					case SyncItemType.CommonData:
						text = "UPDATE CommonData SET Revision=@Revision  WHERE Id=@Id  ";
						break;
					}
					cnn.Execute(text, new _003C_003Ef__AnonymousType44<string, int?>(syncItemResult.ItemId, syncItemResult.BaseRevision));
					pIytrmrRhkp.Warn("未能更新面板数据状态，本地数据在同步时可能已有新的修改。id=" + syncItemResult.ItemId);
					changedWhenSync = true;
				}
				return;
			}
		}
		AppHelper.ShowWarning("更新数据对象：SQL未空。可能您使用的quicker版本太老了。");
		int num3 = 0;
		if (!t3UhyJQNaODjxokEXDJs())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		}
	}

	public void SetResendItems(IList<RequestResendItem> requestResendItems)
	{
		if (IsReadonly)
		{
			return;
		}
		string sql = "UPDATE Profiles SET SyncState=@SyncState WHERE Id=@Id";
		string sql2 = "UPDATE CommonData SET SyncState=@SyncState WHERE Id=@Id";
		using SQLiteConnection cnn = uqDtxMWNJPB();
		foreach (RequestResendItem requestResendItem in requestResendItems)
		{
			switch (requestResendItem.ItemType)
			{
			case SyncItemType.Profile:
				cnn.Execute(sql, new _003C_003Ef__AnonymousType45<string, ItemSyncState>(requestResendItem.ItemId, ItemSyncState.None));
				break;
			case SyncItemType.CommonData:
				cnn.Execute(sql2, new _003C_003Ef__AnonymousType45<string, ItemSyncState>(requestResendItem.ItemId, ItemSyncState.None));
				break;
			}
		}
	}

	public void SaveProfileDataFromServer(SyncItem4 syncItem)
	{
		if (syncItem.ItemType != SyncItemType.Profile)
		{
			throw new InvalidOperationException("不是动作页数据类型！");
		}
		if (IsReadonly)
		{
			return;
		}
		DateTime dateTime = syncItem.LastUpdateTimeUtc;
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
		}
		ProfileDataEntity param = new ProfileDataEntity
		{
			Id = syncItem.ItemId,
			Data = syncItem.Data,
			DeleteTimeUtc = syncItem.DeleteTimeUtc,
			IsDeleted = syncItem.IsDeleted,
			LastUpdateTimeUtc = dateTime,
			SyncState = ItemSyncState.None,
			SyncErrorMessage = string.Empty,
			Revision = (syncItem.BaseRevision ?? (-1))
		};
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute("REPLACE INTO Profiles(Id, Data, LastUpdateTimeUtc, IsDeleted, DeleteTimeUtc, SyncState, SyncErrorMessage, Revision) \r\n                                                VALUES(@Id, @Data, @LastUpdateTimeUtc, @IsDeleted, @DeleteTimeUtc, @SyncState, @SyncErrorMessage, @Revision)", param);
	}

	public void SaveCommonDataFromServer(CommonDataEntity entity)
	{
		if (IsReadonly)
		{
			return;
		}
		string sql = "\r\nINSERT OR REPLACE INTO CommonData \r\n(Id, Data, LastUpdateTimeUtc, SyncState, SyncErrorMessage, LocalOnly, IsDeleted, DeleteTimeUtc, Revision) \r\nVALUES(@Id, @Data, @LastUpdateTimeUtc, @SyncState, @SyncErrorMessage, @LocalOnly, @IsDeleted, @DeleteTimeUtc, @Revision)\r\n";
		using SQLiteConnection cnn = uqDtxMWNJPB();
		cnn.Execute(sql, entity);
	}

	public void SaveSharedAction(SharedActionDto sharedAction, bool overwrite = true)
	{
		string sql = "INSERT OR " + (overwrite ? "REPLACE" : "IGNORE") + " INTO LocalSharedAction (SharedActionId, Revision, Data, InstallTimeUtc) VALUES (@SharedActionId, @Revision, @Data, @InstallTimeUtc);";
		for (int i = 0; i < 3; i++)
		{
			try
			{
				using SQLiteConnection cnn = uqDtxMWNJPB();
				cnn.Execute(sql, new LocalSharedActionItem(sharedAction));
				break;
			}
			catch (Exception exception)
			{
				pIytrmrRhkp.Warn($"写入数据库出错！try {i} " + exception.GetMessageWithInner(), exception);
				if (i == 2) throw;
			}
		}
	}

	internal SharedActionDto p02trGElaNv(string string_2, int int_0)
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		LocalSharedActionItem localSharedActionItem = cnn.QueryFirstOrDefault<LocalSharedActionItem>("SELECT * FROM LocalSharedAction WHERE SharedActionId=@SharedActionId AND Revision=@Revision", new _003C_003Ef__AnonymousType46<string, int>(string_2, int_0));
		if (localSharedActionItem == null)
		{
			return null;
		}
		string text = localSharedActionItem.Data;
		if (text.StartsWith("READONLY{"))
		{
			text = text.Substring(9);
		}
		return JsonConvert.DeserializeObject<SharedActionDto>(text);
	}

	internal IList<SharedActionLocalRevisionItem> EHLtrsqXGsM(string string_2)
	{
		using SQLiteConnection cnn = uqDtxMWNJPB();
		return cnn.Query<SharedActionLocalRevisionItem>("SELECT * FROM LocalSharedAction WHERE SharedActionId=@SharedActionId", new _003C_003Ef__AnonymousType47<string>(string_2)).ToList();
	}

	internal void uNftrHPi9Ww(SubProgram subProgram_0)
	{
		SaveCommonDataObjectFromLocal(GBOtr1XncTr(subProgram_0), subProgram_0, false);
	}

	private static string GBOtr1XncTr(SubProgram subProgram_0)
	{
		return "shared_subprogram:" + subProgram_0.Id;
	}

	internal void C2RtrbDCkyo(SubProgram subProgram_0)
	{
		qektrwnCtKy(GBOtr1XncTr(subProgram_0));
	}

	static SQLDataMgr()
	{
		pIytrmrRhkp = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool t3UhyJQNaODjxokEXDJs()
	{
		return mO2qlFQNkCTaGoZ50ts5 == null;
	}
    internal LocalWorkspaceInfo LoadLocalWorkspace()
    {
        var workspace = PP6trtaO3SY<LocalWorkspaceInfo>("local_workspace");
        if (workspace != null) return workspace;
        workspace = new LocalWorkspaceInfo();
        SaveCommonDataObjectFromLocal("local_workspace", workspace, true);
        return workspace;
    }

}
