using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Newtonsoft.Json;
using O5blBdM6bCRI1gbI3U2;
using qIOAiL5tHSq0oBCxwHP;
using Quicker.Domain.ContextMenus;
using Quicker.Modules.Searching.Builtin;
using Quicker.Modules.Shell;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using X3h8BDAS3nlSpisoOkf;

namespace u0v4xm29tYkLqOhtv67;

internal class iRSgYZ2cfBf2EeB2RM1 : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct oT2WMaHZthrB5YcHgMd : IAsyncStateMachine
		{
			public int GIh272OoDuw;

			public AsyncTaskMethodBuilder dF527uHb6s9;

			private TaskAwaiter SNo27Nripcv;

			private static object L9wE7ZyLMSCeyww01DaV;

			private void MoveNext()
			{
				int num = GIh272OoDuw;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = iah68iMf4KvhT7ULCsJ.jFoLodGY501().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								GIh272OoDuw = 0;
								SNo27Nripcv = awaiter;
								dF527uHb6s9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								if (!pHwFT7yLUC67gkrdZqAT())
								{
									switch (0)
									{
									}
								}
								return;
							}
						}
						else
						{
							awaiter = SNo27Nripcv;
							SNo27Nripcv = default(TaskAwaiter);
							num = -1;
							GIh272OoDuw = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						GI3tClnKPK2.Warn("初始化UWP图标失败：" + ex.Message, ex);
					}
				}
				catch (Exception exception)
				{
					GIh272OoDuw = -2;
					dF527uHb6s9.SetException(exception);
					return;
				}
				GIh272OoDuw = -2;
				dF527uHb6s9.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				dF527uHb6s9.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool pHwFT7yLUC67gkrdZqAT()
			{
				return L9wE7ZyLMSCeyww01DaV == null;
			}
		}

		public static readonly _003C_003Ec s9RvbZRno9B;

		public static Func<SearchResultItem, double> Rr3vb9qZoIj;

		public static Func<string, string> Obyvbhrqa1B;

		public static Func<Task> GMNvbe4pHoa;

		public static Func<string, bool> KARvbYHPMH5;

		public static Func<string, string> vMBvbIFrt6b;

		public static Func<string, bool> oYVvbWfp3JW;

		public static Func<string, string> pZcvbkSZj3P;

		private static _003C_003Ec tucwZjcMCUQuOAvAi9Q9;

		static _003C_003Ec()
		{
			s9RvbZRno9B = new _003C_003Ec();
		}

		internal double M3Gvb89YTtG(SearchResultItem x)
		{
			return x.Score;
		}

		internal string k7Ovbacd9k2(string x)
		{
			return x;
		}

		[AsyncStateMachine(typeof(oT2WMaHZthrB5YcHgMd))]
		internal Task tyrvb7yKrbu()
		{
			oT2WMaHZthrB5YcHgMd stateMachine = default(oT2WMaHZthrB5YcHgMd);
			stateMachine.dF527uHb6s9 = AsyncTaskMethodBuilder.Create();
			stateMachine.GIh272OoDuw = -1;
			stateMachine.dF527uHb6s9.Start(ref stateMachine);
			return stateMachine.dF527uHb6s9.Task;
		}

		internal bool MtyvbR9OUKs(string x)
		{
			return x.StartsWith("t:", StringComparison.OrdinalIgnoreCase);
		}

		internal string xXEvbqyL8Ah(string x)
		{
			return x.Substring(2);
		}

		internal bool nM7vbcIFoOi(string x)
		{
			return x.StartsWith("f:", StringComparison.OrdinalIgnoreCase);
		}

		internal string yfZvbVbbDf7(string x)
		{
			return x.Substring(2);
		}

		internal static bool hN2A7OcM7Am2X8sel34v()
		{
			return tucwZjcMCUQuOAvAi9Q9 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass35_0
	{
		public AppInfo HqovbGJrnA7;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public iRSgYZ2cfBf2EeB2RM1 XOovbHFVCWf;

		public SearchPluginSettings hVovb1CqbcZ;

		private static _003C_003Ec__DisplayClass56_0 sBOZOwcUQmVfbpkN6Y85;

		internal void EXrvbspmoSu()
		{
			XOovbHFVCWf.zANtCBWU1w9(hVovb1CqbcZ);
			XOovbHFVCWf.SNXtC6MBCx2();
		}

		internal static bool F1cBNMcUFSfJDtgbKM6w()
		{
			return sBOZOwcUQmVfbpkN6Y85 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public string xArvb6LekaX;

		private static _003C_003Ec__DisplayClass59_0 aeDncqcUWnOAxPHLyOAo;

		internal bool WbhvbbMoixT(AppInfo x)
		{
			return x.FilePath == xArvb6LekaX;
		}

		internal static bool a4NCQkcUygEggCAdjdmn()
		{
			return aeDncqcUWnOAxPHLyOAo == null;
		}
	}

	[CompilerGenerated]
	private readonly SearchPluginSettings MNMtCdEQfeI = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "#"
			}
		},
		PluginId = "search.sys.windows.apps",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo OEOtCoML3FF = new PluginInfo
	{
		Name = "Windows应用程序",
		Description = "搜索Windows应用程序",
		SearchContentName = "程序",
		Icon = "fa:Brands_Windows"
	};

	[CompilerGenerated]
	private readonly string RBXtCTakKeb = "fa:Brands_Windows";

	[CompilerGenerated]
	private readonly SearchResultOperationType cYbtCM4GhYt = SearchResultOperationType.Open;

	[CompilerGenerated]
	private readonly SearchResultOperationType zECtCAEDjFD = SearchResultOperationType.OpenFolder;

	[CompilerGenerated]
	private readonly SearchResultOperationType Q8CtCOCmwcH = SearchResultOperationType.ExecWithAdmin;

	[CompilerGenerated]
	private readonly bool RFDtCFdr7ni = true;

	private IList<AppInfo> cC1tCU9FSc4;

	private static readonly ILog GI3tClnKPK2;

	private IList<FileSystemWatcher> hLktCiyXPlY = new List<FileSystemWatcher>();

	private DebounceTimer t5atC36uI24 = new DebounceTimer();

	private static bool OD7tCf1PFUW;

	private static long CIBtCzIn6BW;

	private bool uEvtPwtycSh = true;

	private IList<string> txLtPtwxAtt;

	private IList<string> M9atPgWtu68;

	private IList<string> sKhtPLFFhKj;

	private bool TZmtPvCcC2K = true;

	private static iRSgYZ2cfBf2EeB2RM1 s7ZbmkQe6WQCYcjYB3Ip;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return MNMtCdEQfeI;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return OEOtCoML3FF;
		}
	}

	public override string Id => "search.sys.windows.apps";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return RBXtCTakKeb;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return cYbtCM4GhYt;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return zECtCAEDjFD;
		}
	}

	public override SearchResultOperationType ShiftEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return Q8CtCOCmwcH;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return RFDtCFdr7ni;
		}
	}

	private string pKjtCHqJSU9()
	{
		return Path.Combine(AppHelper.GetUserDataDir("data"), "app_search_cache.json");
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		AppHelper.ShowWarning("不支持此功能");
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		if (cC1tCU9FSc4 == null)
		{
			GI3tClnKPK2.Warn("程序搜索：没有数据。");
			list.Add(SearchPlugin.CreateWarningResult("暂无数据。" + (OD7tCf1PFUW ? "正在索引中，请稍等。" : ""), ""));
			return list;
		}
		J5OtC1JS9tg();
		if (string.IsNullOrEmpty(queryContext_0.Search))
		{
			return list;
		}
		string string_ = "fa:Solid_PaperPlane:#0086ff";
		foreach (AppInfo item in cC1tCU9FSc4)
		{
			MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(item.Name, 1.0, item.ExeName, 0.7, true, queryContext_0);
			if (multiFieldMatchResult.Score > 0)
			{
				list.Add(UQhtCbrT9q8(item, string_, multiFieldMatchResult));
			}
		}
		if (list.Count > 100)
		{
			return list.OrderByDescending(_003C_003Ec.Rr3vb9qZoIj ?? (_003C_003Ec.Rr3vb9qZoIj = _003C_003Ec.s9RvbZRno9B.M3Gvb89YTtG)).Take(100).ToList();
		}
		return list;
	}

	private void J5OtC1JS9tg()
	{
		if (!OD7tCf1PFUW && AppHelper.fLiLTj0x4QY() - CIBtCzIn6BW > 600000L)
		{
			Task.Run((Action)yaUtCnISKP0);
		}
	}

	private static SearchResultItem UQhtCbrT9q8(AppInfo appInfo_0, string string_1, MultiFieldMatchResult multiFieldMatchResult_0)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_0_ = default(_003C_003Ec__DisplayClass35_0);
		_003C_003Ec__DisplayClass35_0_.HqovbGJrnA7 = appInfo_0;
		return new SearchResultItem
		{
			Title = _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7.Name,
			Description = nWWtC4EwEhT(ref _003C_003Ec__DisplayClass35_0_),
			Icon = "shellicon:" + _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7.FilePath,
			SecondaryIcon = string_1,
			Tag = _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7,
			Score = (multiFieldMatchResult_0?.Score ?? 0) + _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7.ScoreDelta,
			TitleMatchPositions = multiFieldMatchResult_0?.Result1?.GetMatchPositions(),
			TextData = _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7.FilePath,
			HistoryData = _003C_003Ec__DisplayClass35_0_.HqovbGJrnA7.FilePath
		};
	}

	private void SNXtC6MBCx2()
	{
		z5BtCm8Liwd();
		IList<string> list = new List<string>();
		if (txLtPtwxAtt.HasData())
		{
			int num = 0;
			if (s7ZbmkQe6WQCYcjYB3Ip != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			foreach (string item2 in txLtPtwxAtt)
			{
				string item = xR8ZbBATYd8hUwqhaPF.p70ixwBlhq(item2).path;
				if (Directory.Exists(item))
				{
					list.Add(item);
				}
			}
		}
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
		list = LXctCX0eWrT(list);
		int num4 = default(int);
		foreach (string item3 in list)
		{
			FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(item3);
			fileSystemWatcher.IncludeSubdirectories = true;
			fileSystemWatcher.NotifyFilter = NotifyFilters.FileName;
			fileSystemWatcher.Created += SQmtCrhe2O4;
			fileSystemWatcher.Deleted += JKFtCxDp0Ny;
			int num3 = 0;
			if (!XWthRMQetTvCJ9SvU2oG())
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			fileSystemWatcher.Renamed += HjwtCKqXL8m;
			fileSystemWatcher.EnableRaisingEvents = true;
			hLktCiyXPlY.Add(fileSystemWatcher);
		}
	}

	private IList<string> LXctCX0eWrT(IList<string> ilist_5)
	{
		ilist_5 = ilist_5.Distinct().OrderBy(_003C_003Ec.Obyvbhrqa1B ?? (_003C_003Ec.Obyvbhrqa1B = _003C_003Ec.s9RvbZRno9B.k7Ovbacd9k2)).ToList();
		for (int num = ilist_5.Count - 1; num >= 0; num--)
		{
			string text = ilist_5[num];
			for (int i = 0; i < num; i++)
			{
				if (text.StartsWith(ilist_5[i], StringComparison.OrdinalIgnoreCase))
				{
					ilist_5.RemoveAt(num);
					break;
				}
			}
		}
		return ilist_5;
	}

	private void z5BtCm8Liwd()
	{
		if (!hLktCiyXPlY.HasData())
		{
			return;
		}
		foreach (FileSystemWatcher item in hLktCiyXPlY)
		{
			try
			{
				item.EnableRaisingEvents = false;
				item.Dispose();
			}
			catch (Exception ex)
			{
				GI3tClnKPK2.Warn("释放FileSystemWatcher失败。" + ex.Message, ex);
			}
		}
		hLktCiyXPlY.Clear();
	}

	private void HjwtCKqXL8m(object sender, RenamedEventArgs e)
	{
		VQxtCpsugDL();
	}

	private void JKFtCxDp0Ny(object sender, FileSystemEventArgs e)
	{
		VQxtCpsugDL();
	}

	private void SQmtCrhe2O4(object sender, FileSystemEventArgs e)
	{
		VQxtCpsugDL();
	}

	private void VQxtCpsugDL()
	{
		t5atC36uI24.Debounce(5000, r3XtC56j0g2);
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		Task.Run(_003C_003Ec.GMNvbe4pHoa ?? (_003C_003Ec.GMNvbe4pHoa = _003C_003Ec.s9RvbZRno9B.tyrvb7yKrbu));
		base.Init(searchPluginInitContext_0);
		WWXtCjD2JcF();
		if (!_settings.IsEnabled)
		{
			int num = 0;
			if (s7ZbmkQe6WQCYcjYB3Ip != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			z5BtCm8Liwd();
			return;
		}
		try
		{
			string path = pKjtCHqJSU9();
			if (File.Exists(path))
			{
				string value = File.ReadAllText(path);
				cC1tCU9FSc4 = JsonConvert.DeserializeObject<IList<AppInfo>>(value);
			}
		}
		catch (Exception ex)
		{
			GI3tClnKPK2.Warn("读取应用程序搜索缓存文件失败:" + ex.Message, ex);
		}
		try
		{
			zANtCBWU1w9(searchPluginInitContext_0.Settings);
			SNXtC6MBCx2();
		}
		catch (Exception ex2)
		{
			GI3tClnKPK2.Warn("初始化应用程序搜索插件失败:" + ex2.Message, ex2);
		}
	}

	private void zANtCBWU1w9(SearchPluginSettings searchPluginSettings_1)
	{
		if (OD7tCf1PFUW)
		{
			return;
		}
		try
		{
			OD7tCf1PFUW = true;
			Stopwatch stopwatch = Stopwatch.StartNew();
			int num = 0;
			if (!XWthRMQetTvCJ9SvU2oG())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			IList<AppInfo> list = xR8ZbBATYd8hUwqhaPF.jkaiH66qNp(false, txLtPtwxAtt, uEvtPwtycSh, TZmtPvCcC2K);
			if (M9atPgWtu68.HasData() || sKhtPLFFhKj.HasData())
			{
				list = list.Where(OxmtCDmbRie).ToList();
			}
			GI3tClnKPK2.Info($"索引应用程序耗时：{stopwatch.ElapsedMilliseconds}ms 条目数：{list.Count}");
			CIBtCzIn6BW = AppHelper.fLiLTj0x4QY();
			File.WriteAllText(pKjtCHqJSU9(), list.ToJson());
			cC1tCU9FSc4 = list;
		}
		catch (Exception ex)
		{
			GI3tClnKPK2.Error("索引应用程序出错：" + ex.Message, ex);
		}
		finally
		{
			OD7tCf1PFUW = false;
		}
	}

	private bool mrltCQc23ZJ(AppInfo appInfo_0)
	{
		if (M9atPgWtu68.HasData() && !string.IsNullOrEmpty(appInfo_0.Name))
		{
			int num = 0;
			int num2 = 1;
			if (s7ZbmkQe6WQCYcjYB3Ip != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num >= M9atPgWtu68.Count)
					{
						break;
					}
					num2 = 0;
					if (s7ZbmkQe6WQCYcjYB3Ip != null)
					{
						continue;
					}
					goto default;
				default:
					if (M9atPgWtu68[num].StartsWith("=", StringComparison.OrdinalIgnoreCase))
					{
						if (appInfo_0.Name.Length == M9atPgWtu68[num].Length - 1 && appInfo_0.Name.Equals(M9atPgWtu68[num].Substring(1), StringComparison.OrdinalIgnoreCase))
						{
							return true;
						}
					}
					else if (appInfo_0.Name.IndexOf(M9atPgWtu68[num], StringComparison.OrdinalIgnoreCase) >= 0)
					{
						return true;
					}
					num++;
					goto case 1;
				}
				break;
			}
		}
		if (sKhtPLFFhKj.HasData() && !string.IsNullOrEmpty(appInfo_0.FilePath))
		{
			for (int i = 0; i < sKhtPLFFhKj.Count; i++)
			{
				string fileName = Path.GetFileName(appInfo_0.FilePath);
				if (sKhtPLFFhKj[i].StartsWith("=", StringComparison.OrdinalIgnoreCase))
				{
					if (fileName.Length == sKhtPLFFhKj[i].Length - 1 && fileName.Equals(sKhtPLFFhKj[i].Substring(1), StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
				else if (fileName.IndexOf(sKhtPLFFhKj[i], StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public override void UpdateSettings(SearchPluginSettings settings)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.XOovbHFVCWf = this;
		_003C_003Ec__DisplayClass56_.hVovb1CqbcZ = settings;
		base.UpdateSettings(_003C_003Ec__DisplayClass56_.hVovb1CqbcZ);
		WWXtCjD2JcF();
		if (!_003C_003Ec__DisplayClass56_.hVovb1CqbcZ.IsEnabled)
		{
			z5BtCm8Liwd();
		}
		else
		{
			Task.Run((Action)_003C_003Ec__DisplayClass56_.EXrvbspmoSu);
		}
	}

	private void WWXtCjD2JcF()
	{
		int num = 1;
		while (true)
		{
			IDictionary<string, string> customSettings = _settings.CustomSettings;
			int num2;
			if (customSettings == null)
			{
				num2 = 0;
				if (s7ZbmkQe6WQCYcjYB3Ip != null)
				{
					goto IL_00b7;
				}
				goto IL_00bb;
			}
			if (customSettings.ContainsKey("INDEX_ENVIROMENT_PATH"))
			{
				uEvtPwtycSh = _settings.CustomSettings["INDEX_ENVIROMENT_PATH"] == "1";
			}
			goto IL_0058;
			IL_012e:
			txLtPtwxAtt = new string[0];
			break;
			IL_00b7:
			num2 = num;
			goto IL_00bb;
			IL_0127:
			object obj;
			txLtPtwxAtt = (IList<string>)obj;
			break;
			IL_0058:
			IDictionary<string, string> customSettings2 = _settings.CustomSettings;
			if (customSettings2 != null && customSettings2.ContainsKey("INDEX_SYSTEM_FOLDER"))
			{
				TZmtPvCcC2K = _settings.CustomSettings["INDEX_SYSTEM_FOLDER"] == "1";
			}
			IDictionary<string, string> customSettings3 = _settings.CustomSettings;
			if (customSettings3 == null)
			{
				num2 = 2;
				if (s7ZbmkQe6WQCYcjYB3Ip != null)
				{
					goto IL_00b7;
				}
				goto IL_00bb;
			}
			if (customSettings3.ContainsKey("EXTRA_PATH_LIST"))
			{
				IDictionary<string, string> customSettings4 = _settings.CustomSettings;
				if (customSettings4 != null)
				{
					string text = customSettings4["EXTRA_PATH_LIST"];
					if (text == null)
					{
						obj = null;
					}
					else
					{
						obj = text.SplitToList();
						if (obj != null)
						{
							goto IL_0127;
						}
					}
				}
				else
				{
					obj = null;
				}
				obj = new string[0];
				goto IL_0127;
			}
			goto IL_012e;
			IL_00bb:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_0058;
			case 2:
				goto IL_012e;
			}
		}
		IDictionary<string, string> customSettings5 = _settings.CustomSettings;
		object obj2;
		if (customSettings5 != null && customSettings5.ContainsKey("EXTRA_BLACKLIST"))
		{
			IDictionary<string, string> customSettings6 = _settings.CustomSettings;
			if (customSettings6 != null)
			{
				string text2 = customSettings6["EXTRA_BLACKLIST"];
				if (text2 == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = text2.SplitToList();
					if (obj2 != null)
					{
						goto IL_0192;
					}
				}
			}
			else
			{
				obj2 = null;
			}
			obj2 = new string[0];
			goto IL_0192;
		}
		M9atPgWtu68 = Array.Empty<string>();
		sKhtPLFFhKj = Array.Empty<string>();
		return;
		IL_0192:
		string[] source = (string[])obj2;
		M9atPgWtu68 = source.Where(_003C_003Ec.KARvbYHPMH5 ?? (_003C_003Ec.KARvbYHPMH5 = _003C_003Ec.s9RvbZRno9B.MtyvbR9OUKs)).Select(_003C_003Ec.vMBvbIFrt6b ?? (_003C_003Ec.vMBvbIFrt6b = _003C_003Ec.s9RvbZRno9B.xXEvbqyL8Ah)).ToList();
		sKhtPLFFhKj = source.Where(_003C_003Ec.oYVvbWfp3JW ?? (_003C_003Ec.oYVvbWfp3JW = _003C_003Ec.s9RvbZRno9B.nM7vbcIFoOi)).Select(_003C_003Ec.pZcvbkSZj3P ?? (_003C_003Ec.pZcvbkSZj3P = _003C_003Ec.s9RvbZRno9B.yfZvbVbbDf7)).ToList();
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		string text = searchResultItem_0.TextData;
		AppInfo appInfo = (AppInfo)searchResultItem_0.Tag;
		if (!XWthRMQetTvCJ9SvU2oG())
		{
			switch (0)
			{
			}
		}
		if (appInfo != null && !string.IsNullOrEmpty(appInfo.TargetParsingPath) && File.Exists(appInfo.TargetParsingPath) && string.IsNullOrEmpty(appInfo.TargetArguments))
		{
			text = appInfo.TargetParsingPath;
		}
		if (text == null)
		{
			return false;
		}
		SqoZP75Qt63qQSW6CF1.LZjBkbQjRm(text, contextMenu_0.Items);
		SqoZP75Qt63qQSW6CF1.TITBsl183p(text, contextMenu_0.Items, contextMenu_0);
		ContentContextMenuService.KXCteJAL0Uj(contextMenu_0.Items, new List<string> { text }, true, searchResultItem_0.Title);
		return true;
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem searchHistoryItem_0)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.xArvb6LekaX = searchHistoryItem_0.HistoryData;
		if (cC1tCU9FSc4.HasData())
		{
			AppInfo appInfo = cC1tCU9FSc4.FirstOrDefault(_003C_003Ec__DisplayClass59_.WbhvbbMoixT);
			if (appInfo != null)
			{
				return UQhtCbrT9q8(appInfo, "", null);
			}
		}
		return null;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new WindowsAppSearchPluginSettingsControl();
	}

	static iRSgYZ2cfBf2EeB2RM1()
	{
		GI3tClnKPK2 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		OD7tCf1PFUW = false;
		CIBtCzIn6BW = 0L;
	}

	[CompilerGenerated]
	private void yaUtCnISKP0()
	{
		zANtCBWU1w9(_settings);
	}

	[CompilerGenerated]
	internal static string nWWtC4EwEhT(ref _003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_0_0)
	{
		int num = 1;
		while (true)
		{
			string text = "";
			int num2 = 0;
			if (!XWthRMQetTvCJ9SvU2oG())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			switch (_003C_003Ec__DisplayClass35_0_0.HqovbGJrnA7.AppType)
			{
			case WindowsAppType.AppsFolderApp:
				text = "应用程序";
				break;
			case WindowsAppType.KnownFolder:
				text = "系统";
				break;
			case WindowsAppType.ControlPanel:
				text = "控制面板";
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				return "【" + text + "】" + _003C_003Ec__DisplayClass35_0_0.HqovbGJrnA7.FilePath;
			}
			return _003C_003Ec__DisplayClass35_0_0.HqovbGJrnA7.FilePath;
		}
	}

	[CompilerGenerated]
	private void r3XtC56j0g2(object object_0)
	{
		zANtCBWU1w9(_settings);
	}

	[CompilerGenerated]
	private bool OxmtCDmbRie(AppInfo appInfo_0)
	{
		return !mrltCQc23ZJ(appInfo_0);
	}

	internal static bool XWthRMQetTvCJ9SvU2oG()
	{
		return s7ZbmkQe6WQCYcjYB3Ip == null;
	}
}
