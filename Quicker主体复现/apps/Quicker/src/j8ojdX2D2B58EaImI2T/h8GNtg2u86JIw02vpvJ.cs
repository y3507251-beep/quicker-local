using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using IOn6RhAJdTUbfGy6gwn;
using JwWHiN2bDQfq7cLF2NK;
using log4net;
using qIOAiL5tHSq0oBCxwHP;
using Quicker.Domain.ContextMenus;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;
using rlluYPmoa97LQl8MR84;

namespace j8ojdX2D2B58EaImI2T;

internal class h8GNtg2u86JIw02vpvJ : SearchPlugin, IContextMenuBuilder, ICreateSettingUI
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yAuv14DPLDe;

		public static Func<string, string> G1wv15AlT0I;

		public static Func<string, bool> Gigv1D1vgXf;

		public static Func<FileSystemInfo, DateTime> uT1v1dVjC8R;

		public static Func<SearchResultItem, double> GG3v1o3xZq7;

		internal static _003C_003Ec eFVWiCcMDJ4vWlNHuD1A;

		static _003C_003Ec()
		{
			yAuv14DPLDe = new _003C_003Ec();
		}

		internal string iuMv1BwBvMo(string x)
		{
			return Environment.ExpandEnvironmentVariables(x);
		}

		internal bool KV4v1QmC9dC(string x)
		{
			return auTt0pxTyLr(x, 1500);
		}

		internal DateTime Wtqv1jxw7nY(FileSystemInfo x)
		{
			return x.SafeGetLastWriteTimeUtc();
		}

		internal double db2v1n4he8c(SearchResultItem x)
		{
			return x.Score;
		}

		internal static bool Id3lLrcM3MaTpYlMTZxw()
		{
			return eFVWiCcMDJ4vWlNHuD1A == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public h8GNtg2u86JIw02vpvJ Mhev1AfaNm4;

		public SearchPluginInitContext rR5v1OOUZtM;

		private static _003C_003Ec__DisplayClass41_0 xsCtorcMG03Vd6UqCwZI;

		internal void WuBv1TXDiri()
		{
			Mhev1AfaNm4.cKWt0B0VZp5();
		}

		internal void w8Hv1MXWRo5()
		{
			Mhev1AfaNm4.C7bt0QVgKH2(rR5v1OOUZtM.Settings);
			Mhev1AfaNm4.rRpt01IKjM4();
		}

		internal static bool veVXs4cM082XvdcXGMWM()
		{
			return xsCtorcMG03Vd6UqCwZI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public h8GNtg2u86JIw02vpvJ LU0v1Ua8sI9;

		public SearchPluginSettings Jduv1lwHak0;

		private static _003C_003Ec__DisplayClass42_0 c9v6UYcMKP02RESyKY4C;

		internal void o4Qv1FvgD83()
		{
			LU0v1Ua8sI9.C7bt0QVgKH2(Jduv1lwHak0);
		}

		internal static bool fC7sqAcMBHUp7XCghkKb()
		{
			return c9v6UYcMKP02RESyKY4C == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public string GqBv13VBpoJ;

		internal static _003C_003Ec__DisplayClass53_0 LlrPZEcMdf8KhB1Fq3U2;

		internal bool Xkdv1i7pN3M()
		{
			return Directory.Exists(GqBv13VBpoJ);
		}

		static _003C_003Ec__DisplayClass53_0()
		{
		}

		internal static void BHpPsIcMk9yKf17Q05Dh()
		{
		}

		internal static bool ykM9flcMOpbaH3GQhLoV()
		{
			return LlrPZEcMdf8KhB1Fq3U2 == null;
		}

		internal static void A56FxfcMaIcvp49vEbsF()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public double D1Dv1zxkscr;

		public Func<KeyValuePair<string, IMatchResult>, bool> YoJvbwr41Ur;

		internal static _003C_003Ec__DisplayClass58_0 RdyUtMcMrl7h8iPlXbPN;

		internal bool Psvv1ft9fWq(KeyValuePair<string, IMatchResult> x)
		{
			return (double)x.Value.Score >= D1Dv1zxkscr;
		}

		internal static bool EKwPglcMNw9e22ro2Iuv()
		{
			return RdyUtMcMrl7h8iPlXbPN == null;
		}
	}

	private static readonly ILog mfIt05ma6Or;

	[CompilerGenerated]
	private readonly SearchPluginSettings Abjt0DCwFv9 = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "ff "
			}
		},
		PluginId = "search.sys.windows.filesearch",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo GOTt0d8qCBI = new PluginInfo
	{
		Name = "文件(指定位置和文件类型)",
		Description = "支持拼音模糊匹配，适合对常用工作文件快速查找。",
		SearchContentName = "文件",
		Icon = "fa:Light_Search",
		ConditionNote = "“folder” 搜索文件夹\r\n“file” 搜索文件\r\n“ext:.docx;.doc;.xslx;” 搜索指定文件类型"
	};

	[CompilerGenerated]
	private readonly string isOt0oMBWKo = "fa:Light_File";

	[CompilerGenerated]
	private readonly SearchResultOperationType WHmt0T3X9fE = SearchResultOperationType.Open;

	[CompilerGenerated]
	private readonly SearchResultOperationType BDEt0MW8Pnv = SearchResultOperationType.OpenFolder;

	[CompilerGenerated]
	private readonly SearchResultOperationType Cd8t0AKwGBk;

	[CompilerGenerated]
	private readonly bool cGlt0O5VKyL = true;

	[CompilerGenerated]
	private readonly bool tl0t0Fuf0Ef = true;

	private bool AfJt0UiogQ0;

	private IList<FileSystemWatcher> q6Ot0lFZ6RM = new List<FileSystemWatcher>();

	private IList<string> M1ht0iXOcdD = new List<string>();

	private IList<string> TNht03CBGun = new List<string>();

	private IList<string> yUZt0flCK4D = new List<string> { "node_modules", ".git", ".svn" };

	private bool ddZt0zFikxr = true;

	private IDictionary<string, string> IgWtCwxRaki = new ConcurrentDictionary<string, string>();

	private DebounceTimer bxptCtT033x = new DebounceTimer();

	private static h8GNtg2u86JIw02vpvJ eROochQn4Gwg43NR1UP6;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return Abjt0DCwFv9;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return GOTt0d8qCBI;
		}
	}

	public override string Id => "search.sys.windows.filesearch";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return isOt0oMBWKo;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return WHmt0T3X9fE;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return BDEt0MW8Pnv;
		}
	}

	public override SearchResultOperationType ShiftEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return Cd8t0AKwGBk;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return cGlt0O5VKyL;
		}
	}

	public override bool IsSupportCondition
	{
		[CompilerGenerated]
		get
		{
			return tl0t0Fuf0Ef;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		throw new NotImplementedException();
	}

	private string jJGt0sG8ZR7()
	{
		return Path.Combine(AppHelper.GetUserDataDir("data"), "local_search_files.txt");
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.Mhev1AfaNm4 = this;
		_003C_003Ec__DisplayClass41_.rR5v1OOUZtM = searchPluginInitContext_0;
		base.Init(_003C_003Ec__DisplayClass41_.rR5v1OOUZtM);
		DebugHelper.LogExecuteTime(_003C_003Ec__DisplayClass41_.WuBv1TXDiri, "读取设置耗时", 10);
		if (!_settings.IsEnabled)
		{
			JUbt0bJKLLZ();
		}
		else
		{
			Task.Run((Action)_003C_003Ec__DisplayClass41_.w8Hv1MXWRo5);
		}
	}

	public override void UpdateSettings(SearchPluginSettings settings)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.LU0v1Ua8sI9 = this;
		_003C_003Ec__DisplayClass42_.Jduv1lwHak0 = settings;
		base.UpdateSettings(_003C_003Ec__DisplayClass42_.Jduv1lwHak0);
		cKWt0B0VZp5();
		if (!_003C_003Ec__DisplayClass42_.Jduv1lwHak0.IsEnabled)
		{
			JUbt0bJKLLZ();
			return;
		}
		if (_003C_003Ec__DisplayClass42_.Jduv1lwHak0.CustomSettings != null && _003C_003Ec__DisplayClass42_.Jduv1lwHak0.CustomSettings.ContainsKey("PATH_LIST") && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass42_.Jduv1lwHak0.CustomSettings["PATH_LIST"]))
		{
			Task.Run((Action)_003C_003Ec__DisplayClass42_.o4Qv1FvgD83);
		}
		rRpt01IKjM4();
		int num = 0;
		if (!PKnWffQnhjDi2mAmEnnB())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private bool UgVt0HE3cA9(string string_1)
	{
		foreach (string item in yUZt0flCK4D)
		{
			if (!string_1.EndsWith("\\" + item, StringComparison.OrdinalIgnoreCase))
			{
				if (string_1.Contains("\\" + item + "\\"))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	private void rRpt01IKjM4()
	{
		JUbt0bJKLLZ();
		foreach (string item in M1ht0iXOcdD)
		{
			FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(item);
			if (PKnWffQnhjDi2mAmEnnB())
			{
				switch (0)
				{
				}
			}
			fileSystemWatcher.IncludeSubdirectories = true;
			fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
			fileSystemWatcher.Created += y5ht0mOhne6;
			fileSystemWatcher.Deleted += PjTt0XMekBf;
			fileSystemWatcher.Renamed += Hpbt06X3wRt;
			fileSystemWatcher.EnableRaisingEvents = true;
			q6Ot0lFZ6RM.Add(fileSystemWatcher);
		}
	}

	private void JUbt0bJKLLZ()
	{
		if (!q6Ot0lFZ6RM.HasData())
		{
			return;
		}
		foreach (FileSystemWatcher item in q6Ot0lFZ6RM)
		{
			try
			{
				item.EnableRaisingEvents = false;
				item.Dispose();
			}
			catch (Exception ex)
			{
				mfIt05ma6Or.Warn("释放FileSystemWatcher失败。" + ex.Message, ex);
			}
		}
		q6Ot0lFZ6RM.Clear();
	}

	private void Hpbt06X3wRt(object sender, RenamedEventArgs e)
	{
		if (IgWtCwxRaki.ContainsKey(e.FullPath))
		{
			IgWtCwxRaki.Remove(e.FullPath);
		}
		if (T3bt0xjhb4G(e.FullPath))
		{
			gcGt0KKI5Cl();
			Gwvt0rZ4Ige(e.FullPath);
		}
	}

	private void PjTt0XMekBf(object sender, FileSystemEventArgs e)
	{
		if (IgWtCwxRaki.ContainsKey(e.FullPath))
		{
			IgWtCwxRaki.Remove(e.FullPath);
		}
		if (T3bt0xjhb4G(e.FullPath))
		{
			gcGt0KKI5Cl();
		}
	}

	private void y5ht0mOhne6(object sender, FileSystemEventArgs e)
	{
		if (T3bt0xjhb4G(e.FullPath))
		{
			gcGt0KKI5Cl();
			Gwvt0rZ4Ige(e.FullPath);
		}
	}

	private void gcGt0KKI5Cl()
	{
		bxptCtT033x.Debounce(10000, Pkst046Xk9l);
	}

	private bool T3bt0xjhb4G(string string_1)
	{
		if (UgVt0HE3cA9(string_1))
		{
			return false;
		}
		if (string_1.EndsWithAny(true, TNht03CBGun.ToArray()))
		{
			return true;
		}
		return false;
	}

	private void Gwvt0rZ4Ige(string string_1)
	{
		try
		{
			if (File.Exists(string_1))
			{
				IgWtCwxRaki.Add(string_1, peht0jaHXYZ(new FileInfo(string_1)));
			}
			else if (Directory.Exists(string_1))
			{
				IgWtCwxRaki.Add(string_1, yfCt0nHYj3H(new DirectoryInfo(string_1)));
			}
		}
		catch (Exception ex)
		{
			mfIt05ma6Or.Warn("获取路径信息失败。" + ex.Message, ex);
		}
	}

	public static bool auTt0pxTyLr(string string_1, int int_0)
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		_003C_003Ec__DisplayClass53_.GqBv13VBpoJ = string_1;
		if (_003C_003Ec__DisplayClass53_.GqBv13VBpoJ.StartsWith("\\\\"))
		{
			Task<bool> task = new Task<bool>(_003C_003Ec__DisplayClass53_.Xkdv1i7pN3M);
			task.Start();
			if (task.Wait(int_0))
			{
				return task.Result;
			}
			return false;
		}
		return Directory.Exists(_003C_003Ec__DisplayClass53_.GqBv13VBpoJ);
	}

	private void cKWt0B0VZp5()
	{
		IDictionary<string, string> customSettings = _settings.CustomSettings;
		object obj;
		if (customSettings != null && customSettings.ContainsKey("PATH_LIST"))
		{
			IDictionary<string, string> customSettings2 = _settings.CustomSettings;
			if (customSettings2 == null)
			{
				obj = null;
			}
			else
			{
				string text = customSettings2["PATH_LIST"];
				if (text == null)
				{
					obj = null;
				}
				else
				{
					obj = text.SplitToList();
					if (obj != null)
					{
						goto IL_0058;
					}
				}
			}
			obj = new string[0];
			goto IL_0058;
		}
		M1ht0iXOcdD = new List<string>();
		int num = 0;
		if (eROochQn4Gwg43NR1UP6 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0215;
		IL_01b9:
		object obj2;
		yUZt0flCK4D = (IList<string>)obj2;
		goto IL_01e4;
		IL_00e2:
		IDictionary<string, string> customSettings3 = _settings.CustomSettings;
		object obj3;
		if (customSettings3 != null && customSettings3.ContainsKey("EXT_LIST"))
		{
			IDictionary<string, string> customSettings4 = _settings.CustomSettings;
			if (customSettings4 == null)
			{
				obj3 = null;
			}
			else
			{
				string text2 = customSettings4["EXT_LIST"];
				if (text2 == null)
				{
					obj3 = null;
				}
				else
				{
					obj3 = text2.SplitToList('\r', '\n', ';', '|');
					if (obj3 != null)
					{
						goto IL_0144;
					}
				}
			}
			obj3 = new string[0];
			goto IL_0144;
		}
		TNht03CBGun = new string[0];
		goto IL_0157;
		IL_0058:
		IList<string> source = (IList<string>)obj;
		source = source.Select(_003C_003Ec.G1wv15AlT0I ?? (_003C_003Ec.G1wv15AlT0I = _003C_003Ec.yAuv14DPLDe.iuMv1BwBvMo)).ToList();
		source = source.Where(_003C_003Ec.Gigv1D1vgXf ?? (_003C_003Ec.Gigv1D1vgXf = _003C_003Ec.yAuv14DPLDe.KV4v1QmC9dC)).ToList();
		M1ht0iXOcdD = source;
		goto IL_00e2;
		IL_0215:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_00e2;
		IL_01e4:
		IDictionary<string, string> customSettings5 = _settings.CustomSettings;
		if (customSettings5 == null || !customSettings5.ContainsKey("INDEX_FOLDER"))
		{
			ddZt0zFikxr = true;
			num = 0;
			if (eROochQn4Gwg43NR1UP6 == null)
			{
				return;
			}
			goto IL_0215;
		}
		ddZt0zFikxr = _settings.CustomSettings?["INDEX_FOLDER"] == "1";
		return;
		IL_0144:
		TNht03CBGun = (IList<string>)obj3;
		goto IL_0157;
		IL_0157:
		IDictionary<string, string> customSettings6 = _settings.CustomSettings;
		if (customSettings6 != null && customSettings6.ContainsKey("BLACK_LIST"))
		{
			IDictionary<string, string> customSettings7 = _settings.CustomSettings;
			if (customSettings7 == null)
			{
				obj2 = null;
			}
			else
			{
				string text3 = customSettings7["BLACK_LIST"];
				if (text3 == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = text3.SplitToList('\r', '\n', ';', '|');
					if (obj2 != null)
					{
						goto IL_01b9;
					}
				}
			}
			obj2 = new string[0];
			goto IL_01b9;
		}
		yUZt0flCK4D = new string[3] { "node_modules", ".git", ".svn" };
		goto IL_01e4;
	}

	private void C7bt0QVgKH2(SearchPluginSettings searchPluginSettings_1)
	{
		bxptCtT033x.Clear();
		if (AfJt0UiogQ0)
		{
			return;
		}
		try
		{
			mfIt05ma6Or.Info("开始文件名索引，目录：" + string.Join(";", M1ht0iXOcdD) + "  扩展名：" + string.Join(",", TNht03CBGun));
			AfJt0UiogQ0 = true;
			Stopwatch stopwatch = Stopwatch.StartNew();
			int num = 0;
			int num2 = 0;
			try
			{
				List<FileSystemInfo> list = new List<FileSystemInfo>();
				foreach (string item in M1ht0iXOcdD)
				{
					try
					{
						string text = item;
						if (text.Contains("%"))
						{
							text = Environment.ExpandEnvironmentVariables(text);
						}
						DirectoryInfo directoryInfo = new DirectoryInfo(text);
						if (!directoryInfo.Exists)
						{
							continue;
						}
						foreach (FileSystemInfo item2 in new STMVA028LKncse7UYeB(directoryInfo, null, TNht03CBGun, yUZt0flCK4D, true, false))
						{
							list.Add(item2);
						}
					}
					catch (Exception ex)
					{
						mfIt05ma6Or.Warn("索引文件夹" + item + " 出错：" + ex.Message);
					}
				}
				string text2 = jJGt0sG8ZR7() + ".tmp";
				using FileStream fileStream = File.Open(text2, FileMode.Create);
				using StreamWriter streamWriter = new StreamWriter(fileStream);
				int num4 = default(int);
				foreach (FileSystemInfo item3 in list.OrderByDescending(_003C_003Ec.uT1v1dVjC8R ?? (_003C_003Ec.uT1v1dVjC8R = _003C_003Ec.yAuv14DPLDe.Wtqv1jxw7nY)))
				{
					if (item3.Attributes.HasFlag(FileAttributes.Directory))
					{
						if (ddZt0zFikxr)
						{
							streamWriter.WriteLine(yfCt0nHYj3H(item3));
							num2++;
							int num3 = 0;
							if (!PKnWffQnhjDi2mAmEnnB())
							{
								num3 = num4;
							}
							switch (num3)
							{
							}
						}
					}
					else
					{
						streamWriter.WriteLine(peht0jaHXYZ(item3 as FileInfo));
						num++;
					}
				}
				streamWriter.Flush();
				int num5 = 0;
				if (eROochQn4Gwg43NR1UP6 != null)
				{
					int num6 = default(int);
					num5 = num6;
				}
				switch (num5)
				{
				default:
				{
					streamWriter.Close();
					fileStream.Close();
					for (int num7 = 0; num7 < 5; num7++)
					{
						try
						{
							if (File.Exists(jJGt0sG8ZR7()))
							{
								File.Delete(jJGt0sG8ZR7());
							}
							File.Move(text2, jJGt0sG8ZR7());
						}
						catch (Exception ex2)
						{
							mfIt05ma6Or.Warn($"删除索引文件失败,第{num7}次：" + ex2.Message);
							Thread.Sleep(100 * (num7 + 1));
							goto IL_02b0;
						}
						break;
						IL_02b0:
						if (num7 == 4)
						{
							mfIt05ma6Or.Warn("删除索引文件经过5次尝试后失败了。");
						}
					}
					break;
				}
				}
			}
			catch (Exception ex3)
			{
				mfIt05ma6Or.Warn("索引文件出错：" + ex3.Message, ex3);
			}
			finally
			{
				AfJt0UiogQ0 = false;
			}
			IgWtCwxRaki.Clear();
			mfIt05ma6Or.Info($"索引文件耗时：{stopwatch.ElapsedMilliseconds}ms 文件数：{num}, 目录数：{num2}");
		}
		catch (Exception ex4)
		{
			mfIt05ma6Or.Error("索引文件出错：" + ex4.Message, ex4);
		}
	}

	private static string peht0jaHXYZ(FileInfo fileInfo_0)
	{
		return $"{fileInfo_0.Name}|f|{fileInfo_0.Length}|{fileInfo_0.SafeGetCreationTimeUtc().Ticks}|{fileInfo_0.SafeGetLastWriteTimeUtc().Ticks}|{fileInfo_0.SafeGetLastAccessTimeUtc().Ticks}|{fileInfo_0.FullName}";
	}

	private static string yfCt0nHYj3H(FileSystemInfo fileSystemInfo_0)
	{
		return $"{fileSystemInfo_0.Name}|d|-1|{fileSystemInfo_0.SafeGetCreationTimeUtc().Ticks}|{fileSystemInfo_0.SafeGetLastWriteTimeUtc().Ticks}|{fileSystemInfo_0.SafeGetLastAccessTimeUtc().Ticks}|{fileSystemInfo_0.FullName}";
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		if (queryContext_0.IsEmptySearch)
		{
			return new List<SearchResultItem>();
		}
		if (queryContext_0.IsGlobalSearch && queryContext_0.Search.Length < queryContext_0.PluginItem.MinTriggerLength)
		{
			return new List<SearchResultItem>();
		}
		if (!queryContext_0.IsGlobalSearch && !M1ht0iXOcdD.HasData())
		{
			return new List<SearchResultItem>
			{
				new SearchResultItem
				{
					Title = "要搜索的文件夹数量为0，请检查搜索设置。",
					Description = "问题信息",
					Icon = "fa:Light_QuestionCircle:#FF0000"
				}
			};
		}
		if (AfJt0UiogQ0 && !File.Exists(jJGt0sG8ZR7()))
		{
			return new List<SearchResultItem>
			{
				new SearchResultItem
				{
					Title = "正在索引中，请稍候...",
					Icon = "fa:Light_Clock"
				}
			};
		}
		if (!File.Exists(jJGt0sG8ZR7()))
		{
			return new List<SearchResultItem>
			{
				new SearchResultItem
				{
					Title = "索引文件不存在，请检查设置。",
					Icon = "fa:Light_QuestionCircle:#FF0000"
				}
			};
		}
		bool flag = true;
		bool flag2 = true;
		string[] array = null;
		if (!string.IsNullOrEmpty(queryContext_0.PluginItem.Condition))
		{
			if (string.Equals(queryContext_0.PluginItem.Condition, "folder", StringComparison.OrdinalIgnoreCase))
			{
				flag = false;
			}
			else if (string.Equals(queryContext_0.PluginItem.Condition, "file", StringComparison.OrdinalIgnoreCase))
			{
				flag2 = false;
			}
			else if (queryContext_0.PluginItem.Condition.StartsWith("ext:", StringComparison.OrdinalIgnoreCase))
			{
				flag2 = false;
				array = queryContext_0.PluginItem.Condition.Substring(4).SplitToList(',', ';');
			}
		}
		try
		{
			_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
			IEnumerable<string> second = File.ReadLines(jJGt0sG8ZR7());
			IList<KeyValuePair<string, IMatchResult>> list = new List<KeyValuePair<string, IMatchResult>>(100);
			List<SearchResultItem> list2 = new List<SearchResultItem>();
			DateTime utcNow = DateTime.UtcNow;
			long num = 0L;
			int num2 = 0;
			string text = queryContext_0.Search.Trim();
			if (text.Contains(' '))
			{
				int num3 = text.LastIndexOf(' ');
				new StringCharInfo(text.Substring(num3 + 1));
				string text2 = text.Substring(0, num3);
				new StringCharInfo(text2);
				text2.SplitToList(' ');
			}
			else
			{
				(new string[1])[0] = text;
			}
			foreach (string item in IgWtCwxRaki.Values.Concat(second))
			{
				if (!cancellationToken_0.IsCancellationRequested)
				{
					if (string.IsNullOrEmpty(item))
					{
						continue;
					}
					int num4 = item.IndexOf('|');
					string text3 = item.Substring(0, num4);
					bool flag3;
					if (((flag3 = item[num4 + 1] == 'd') && !flag2) || (!flag3 && !flag) || (array != null && !text3.EndsWithAny(true, array)))
					{
						continue;
					}
					IMatchResult matchResult = null;
					if (text.Length == 1)
					{
						matchResult = JgbqhZmXYZ38IYyT8kD.NrSv0WXIyvf(text3, queryContext_0.Search);
						if (matchResult == null)
						{
							continue;
						}
					}
					else
					{
						matchResult = tkxn6HAKAgMT8gvXbyh.Xafi4HAJ87(text3, queryContext_0);
						if (matchResult == null)
						{
							continue;
						}
					}
					if (matchResult != null)
					{
						matchResult.Score = (matchResult.Score + 60) / 100 * 100;
						list.Add(new KeyValuePair<string, IMatchResult>(item, matchResult));
						num += matchResult.Score;
						num2 = ((matchResult.Score > num2) ? matchResult.Score : num2);
					}
					if (queryContext_0.Search.Length < 2 && list.Count > 200)
					{
						break;
					}
					continue;
				}
				return SearchPlugin.EmptyResults;
			}
			if (cancellationToken_0.IsCancellationRequested)
			{
				return new List<SearchResultItem>();
			}
			string secondaryIcon = (queryContext_0.IsGlobalSearch ? "fa:Light_Search:#0086ff" : string.Empty);
			_003C_003Ec__DisplayClass58_.D1Dv1zxkscr = ((list.Count > 100) ? 150 : 0);
			foreach (KeyValuePair<string, IMatchResult> item2 in list.Where(_003C_003Ec__DisplayClass58_.YoJvbwr41Ur ?? (_003C_003Ec__DisplayClass58_.YoJvbwr41Ur = _003C_003Ec__DisplayClass58_.Psvv1ft9fWq)))
			{
				string[] array2 = item2.Key.Split('|');
				string title = array2[0];
				long fileLength = Convert.ToInt64(array2[2]);
				DateTime dateTime = new DateTime(Convert.ToInt64(array2[4]), DateTimeKind.Utc);
				string text4 = array2[array2.Length - (1)];
				double score = (double)item2.Value.Score - Math.Sqrt((utcNow - dateTime).TotalDays);
				list2.Add(new SearchResultItem
				{
					Title = title,
					SecondaryTitle = $"{fileLength.GetBytesReadable()}  {dateTime.ToLocalTime()}",
					Description = text4,
					SecondaryIcon = secondaryIcon,
					Icon = EverythingSearchPlugin.GetPathIcon(text4),
					Score = score,
					TextData = text4,
					TitleMatchPositions = item2.Value.GetMatchPositions(),
					HistoryData = text4
				});
			}
			return list2.OrderByDescending(_003C_003Ec.GG3v1o3xZq7 ?? (_003C_003Ec.GG3v1o3xZq7 = _003C_003Ec.yAuv14DPLDe.db2v1n4he8c)).Take(100).ToList();
		}
		catch (Exception ex)
		{
			mfIt05ma6Or.Warn("查询文件出错：" + ex.Message, ex);
			return new List<SearchResultItem>
			{
				new SearchResultItem
				{
					Title = "查询文件出错，请稍后重试。",
					Icon = "fa:Light_QuestionCircle:#FF0000"
				}
			};
		}
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		string textData = searchResultItem_0.TextData;
		if (string.IsNullOrEmpty(textData))
		{
			return false;
		}
		SqoZP75Qt63qQSW6CF1.LZjBkbQjRm(textData, contextMenu_0.Items);
		SqoZP75Qt63qQSW6CF1.TITBsl183p(textData, contextMenu_0.Items, contextMenu_0);
		ContentContextMenuService.KXCteJAL0Uj(contextMenu_0.Items, new List<string> { textData }, true);
		return true;
	}

	public IPluginSettingsControl CreateSettingsControl()
	{
		return new LocalFileSearchPluginSettingsControl();
	}

	public override IEnumerable<SearchResultItem> GetResultsForEmptySearch(QueryContext queryContext_0, IList<SearchHistoryItem> ilist_4, CancellationToken cancellationToken_0, bool bool_4)
	{
		if (string.IsNullOrEmpty(queryContext_0.PluginItem.Condition))
		{
			return base.GetResultsForEmptySearch(queryContext_0, ilist_4, cancellationToken_0, bool_4);
		}
		return DoSearch(queryContext_0, cancellationToken_0);
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem searchHistoryItem_0)
	{
		string historyData = searchHistoryItem_0.HistoryData;
		FileSystemInfo fileSystemInfo = null;
		if (File.Exists(historyData))
		{
			fileSystemInfo = new FileInfo(historyData);
		}
		else
		{
			if (!Directory.Exists(historyData))
			{
				return null;
			}
			fileSystemInfo = new DirectoryInfo(historyData);
		}
		return new SearchResultItem
		{
			Title = Path.GetFileName(historyData),
			SecondaryTitle = $"{(fileSystemInfo as FileInfo)?.Length.GetBytesReadable()}  {fileSystemInfo.LastWriteTime}",
			Description = historyData,
			SecondaryIcon = "fa:Solid_Search:#0086ff",
			Icon = EverythingSearchPlugin.GetPathIcon(historyData),
			Score = 0.0,
			TextData = historyData,
			TextDataType = "path",
			TitleMatchPositions = null,
			HistoryData = historyData
		};
	}

	static h8GNtg2u86JIw02vpvJ()
	{
		mfIt05ma6Or = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void Pkst046Xk9l(object object_0)
	{
		C7bt0QVgKH2(_settings);
	}

	internal static bool PKnWffQnhjDi2mAmEnnB()
	{
		return eROochQn4Gwg43NR1UP6 == null;
	}
}
