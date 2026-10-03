using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using FontAwesome5;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class ZipStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec PeCScIOmc7T;

		public static FileFailureHandler rG4ScWiOWxm;

		public static Func<string, string> ANZSckXs9iT;

		public static Func<string, long> L5yScGUvy7O;

		public static Func<string, long> HLwScsRAiQw;

		internal static _003C_003Ec w1hx5MWr1jq0BUxUESIu;

		static _003C_003Ec()
		{
			PeCScIOmc7T = new _003C_003Ec();
		}

		internal void DMDSc9ZM4K0(object sender, ScanFailureEventArgs e)
		{
			P4fgRXk22fw.Warn("解压缩文件 “" + e.Name + "” 出错：" + e.Exception?.Message);
			e.ContinueRunning = true;
		}

		internal string bdqSchaEJq9(string line)
		{
			return Path.GetDirectoryName(line).ToLowerInvariant();
		}

		internal long sJWSce6JgG0(string x)
		{
			if (!Directory.Exists(x))
			{
				return new FileInfo(x).Length;
			}
			return Directory.EnumerateFiles(x, "*", SearchOption.AllDirectories).Sum(L5yScGUvy7O ?? (L5yScGUvy7O = PeCScIOmc7T.qjfScYDc1MH));
		}

		internal long qjfScYDc1MH(string y)
		{
			return new FileInfo(y).Length;
		}

		internal static bool gtc1WMWrKhQVcMf8Jynm()
		{
			return w1hx5MWr1jq0BUxUESIu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass52_0
	{
		public ActionStep nrlSc19DCIR;

		public ActionExecuteContext HHwScb00Muj;

		public ZipStep I1YSc6wAK5r;

		public XAction bNEScX4oZ7N;

		internal static _003C_003Ec__DisplayClass52_0 BhXnqCWrdp4TgKuKPVVX;

		internal (bool isSuccess, string message, ActionStopFlag failReason) yLpScHnk9Nx()
		{
			string textParamValue = XActionHelper.GetTextParamValue(TIZgRpIMcOR, nrlSc19DCIR, HHwScb00Muj);
			string textParamValue2 = XActionHelper.GetTextParamValue(zhEgR5G4Zih, nrlSc19DCIR, HHwScb00Muj);
			if (!(textParamValue == "Zip"))
			{
				if (!(textParamValue == "Unzip"))
				{
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				return I1YSc6wAK5r.YMNgRbYSqt1(HHwScb00Muj, nrlSc19DCIR, bNEScX4oZ7N, textParamValue2);
			}
			return I1YSc6wAK5r.Zip(HHwScb00Muj, nrlSc19DCIR, bNEScX4oZ7N, textParamValue2);
		}

		static _003C_003Ec__DisplayClass52_0()
		{
		}

		internal static bool yqtXRwWrOv8gUxVkldVj()
		{
			return BhXnqCWrdp4TgKuKPVVX == null;
		}

		internal static void mxrSi3WrkGOHGg589Yca()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public int mR4ScKH0AwQ;

		public string Gv6ScxgQD86;

		public ActionExecuteContext WvlScrFyjw8;

		private static _003C_003Ec__DisplayClass53_0 cuU2wfWra8EsFKeDoM5e;

		internal void Hf4ScmPOpZt(object sender, ProgressEventArgs e)
		{
			ProgressReportMgr.UpdateProgress(mR4ScKH0AwQ, "", e.Name, e.PercentComplete, "解压缩 " + Path.GetFileName(Gv6ScxgQD86) + "...", WvlScrFyjw8.Id);
		}

		internal static bool asV8MsWrry8mXj9V2blr()
		{
			return cuU2wfWra8EsFKeDoM5e == null;
		}
	}

	private static readonly ILog P4fgRXk22fw;

	[CompilerGenerated]
	private readonly IEnumerable<string> W8OgRmEBawB = new List<string> { "压缩文件", "zip", "打包" };

	[CompilerGenerated]
	private readonly string rG9gRKwLlO4 = $"fa:{EFontAwesomeIcon.Light_FileArchive}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> omBgRxwGgPP;

	[CompilerGenerated]
	private readonly string s66gRrLK7O9 = "https://getquicker.net/KC/Help/Doc/zip";

	private static readonly StepInParamDef TIZgRpIMcOR;

	private static readonly StepInParamDef q0MgRBc7V7W;

	private static readonly StepInParamDef cgagRQxucHO;

	private static readonly StepInParamDef CgPgRjP0eN6;

	private static readonly StepInParamDef d8CgRnwx5Zc;

	private static readonly StepInParamDef RSkgR4vATyl;

	private static readonly StepInParamDef zhEgR5G4Zih;

	private static readonly StepInParamDef CvigRDx538l;

	private static readonly StepInParamDef QJWgRd0OQ2E;

	private static readonly StepInParamDef UJTgRoiK8iN;

	private static readonly StepInParamDef PLLgRTdV2gC;

	private static readonly StepInParamDef EfKgRM3QAXC;

	private static readonly StepInParamDef tNcgRAi576I;

	private static readonly StepInParamDef ccCgRO112s0;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> DcIgRFidniA = new List<StepInParamDef>
	{
		TIZgRpIMcOR, q0MgRBc7V7W, CgPgRjP0eN6, d8CgRnwx5Zc, cgagRQxucHO, RSkgR4vATyl, zhEgR5G4Zih, CvigRDx538l, QJWgRd0OQ2E, UJTgRoiK8iN,
		PLLgRTdV2gC, EfKgRM3QAXC, ccCgRO112s0
	};

	private static readonly StepOutParamDef GDLgRUneBA1;

	private static readonly StepOutParamDef CJpgRlDxkKs;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> R6NgRikdoT4 = new List<StepOutParamDef> { GDLgRUneBA1, CJpgRlDxkKs };

	private static ZipStep VIqhKlQ6PCfFASu6VwSY;

	public string Key => "sys:zip";

	public string Name => "Zip压缩打包";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return W8OgRmEBawB;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rG9gRKwLlO4;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return omBgRxwGgPP;
		}
	}

	public string Description => "Zip压缩或解压缩";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return s66gRrLK7O9;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return DcIgRFidniA;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return R6NgRikdoT4;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
		_003C_003Ec__DisplayClass52_.nrlSc19DCIR = step;
		_003C_003Ec__DisplayClass52_.HHwScb00Muj = context;
		_003C_003Ec__DisplayClass52_.I1YSc6wAK5r = this;
		_003C_003Ec__DisplayClass52_.bNEScX4oZ7N = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass52_.HHwScb00Muj, _003C_003Ec__DisplayClass52_.nrlSc19DCIR, _003C_003Ec__DisplayClass52_.bNEScX4oZ7N, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass52_.yLpScHnk9Nx, (Action)null, (Action)null, ccCgRO112s0, GDLgRUneBA1);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) YMNgRbYSqt1(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		_003C_003Ec__DisplayClass53_.WvlScrFyjw8 = actionExecuteContext_0;
		_003C_003Ec__DisplayClass53_.Gv6ScxgQD86 = XActionHelper.GetTextParamValue(d8CgRnwx5Zc, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8);
		string textParamValue = XActionHelper.GetTextParamValue(RSkgR4vATyl, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(UJTgRoiK8iN, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(PLLgRTdV2gC, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8);
		bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(EfKgRM3QAXC, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8);
		string text = ((textParamValue == ".") ? Path.GetDirectoryName(_003C_003Ec__DisplayClass53_.Gv6ScxgQD86) : ((textParamValue == "*") ? Path.Combine(Path.GetDirectoryName(_003C_003Ec__DisplayClass53_.Gv6ScxgQD86), Path.GetFileNameWithoutExtension(_003C_003Ec__DisplayClass53_.Gv6ScxgQD86)) : textParamValue));
		if (string.IsNullOrEmpty(text))
		{
			return (isSuccess: false, message: "未指定解压缩目标位置", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass53_.mR4ScKH0AwQ = -1;
		try
		{
			FastZipEvents fastZipEvents = new FastZipEvents();
			if (booleanParamValue2)
			{
				fastZipEvents.FileFailure = (FileFailureHandler)Delegate.Combine(fastZipEvents.FileFailure, _003C_003Ec.rG4ScWiOWxm ?? (_003C_003Ec.rG4ScWiOWxm = _003C_003Ec.PeCScIOmc7T.DMDSc9ZM4K0));
			}
			if (booleanParamValue3)
			{
				fastZipEvents.ProgressInterval = TimeSpan.FromSeconds(1.0);
				_003C_003Ec__DisplayClass53_.mR4ScKH0AwQ = ProgressReportMgr.RequestProgressId();
				fastZipEvents.Progress = (ProgressHandler)Delegate.Combine(fastZipEvents.Progress, new ProgressHandler(_003C_003Ec__DisplayClass53_.Hf4ScmPOpZt));
			}
			FastZip fastZip = new FastZip(fastZipEvents);
			fastZip.RestoreAttributesOnExtract = true;
			fastZip.RestoreDateTimeOnExtract = true;
			if (!string.IsNullOrEmpty(string_2))
			{
				fastZip.Password = string_2;
			}
			fastZip.ExtractZip(_003C_003Ec__DisplayClass53_.Gv6ScxgQD86, text, booleanParamValue ? FastZip.Overwrite.Always : FastZip.Overwrite.Prompt, AXNgR6Y8rNU, string.Empty, string.Empty, true);
			using ZipInputStream zipInputStream = new ZipInputStream(System.IO.File.OpenRead(_003C_003Ec__DisplayClass53_.Gv6ScxgQD86));
			ZipEntry nextEntry;
			while ((nextEntry = zipInputStream.GetNextEntry()) != null)
			{
				if (nextEntry.IsDirectory)
				{
					string path = Path.Combine(text, nextEntry.Name).TrimEnd('/', '\\');
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
				}
			}
		}
		finally
		{
			if (_003C_003Ec__DisplayClass53_.mR4ScKH0AwQ >= 0)
			{
				ProgressReportMgr.RemoveProgress(_003C_003Ec__DisplayClass53_.mR4ScKH0AwQ);
			}
		}
		XActionHelper.OutputResult(CJpgRlDxkKs, actionStep_0, _003C_003Ec__DisplayClass53_.WvlScrFyjw8, text, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private bool AXNgR6Y8rNU(string string_2)
	{
		throw new InvalidOperationException(string_2 + "文件已存在。");
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Zip(ActionExecuteContext context, ActionStep step, XAction action, string password)
	{
		string textParamValue = XActionHelper.GetTextParamValue(q0MgRBc7V7W, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(CgPgRjP0eN6, step, context);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(EfKgRM3QAXC, step, context);
		int val = (int)XActionHelper.GetIntegerParamValue(QJWgRd0OQ2E, step, context);
		val = Math.Min(9, Math.Max(val, 0));
		string textParamValue3 = XActionHelper.GetTextParamValue(CvigRDx538l, step, context);
		string[] array = textParamValue.Split(new string[3] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			return (isSuccess: false, message: "没有需要压缩的文件", failReason: ActionStopFlag.OperationFailed);
		}
		if (array.Length == 1)
		{
			string text = array[0];
			if (Directory.Exists(text))
			{
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(cgagRQxucHO, step, context);
				string text2 = (string.IsNullOrEmpty(textParamValue2) ? Path.Combine(Path.GetTempPath(), $"quicker_{DateTime.Now:yyyyMMdd_HHmmss_fff}.zip") : ((textParamValue2 == ".") ? Path.Combine(Path.GetDirectoryName(text), Path.GetFileName(text) + $"_{DateTime.Now:yyyyMMdd_hhmmss}.zip") : textParamValue2));
				if (booleanParamValue2)
				{
					ZipMultipleFiles(new List<string> { text }, text2, Path.GetDirectoryName(text), password, val, textParamValue3, booleanParamValue);
				}
				else
				{
					ZipSingleDirectory(text, text2, password, val, textParamValue3, booleanParamValue);
				}
				XActionHelper.OutputResult(CJpgRlDxkKs, step, context, text2, action);
			}
			else
			{
				if (!System.IO.File.Exists(text))
				{
					return (isSuccess: false, message: "源文件或文件夹不存在：" + text, failReason: ActionStopFlag.OperationFailed);
				}
				string text3 = (string.IsNullOrEmpty(textParamValue2) ? Path.Combine(Path.GetTempPath(), $"quicker_{DateTime.Now:yyyyMMdd_HHmmss_fff}.zip") : ((textParamValue2 == ".") ? Path.Combine(Path.GetDirectoryName(text), Path.GetFileNameWithoutExtension(text) + $"_{DateTime.Now:yyyyMMdd_hhmmss}.zip") : textParamValue2));
				ZipSingleFile(text, text3, password, val, textParamValue3, booleanParamValue);
				XActionHelper.OutputResult(CJpgRlDxkKs, step, context, text3, action);
			}
		}
		else
		{
			if (array.Select(_003C_003Ec.ANZSckXs9iT ?? (_003C_003Ec.ANZSckXs9iT = _003C_003Ec.PeCScIOmc7T.bdqSchaEJq9)).Distinct().Count() > 1)
			{
				return (isSuccess: false, message: "仅支持将相同文件夹下的文件压缩", failReason: ActionStopFlag.OperationFailed);
			}
			string text4 = FindBaseFolder(array);
			string directoryName = Path.GetDirectoryName(array[0]);
			string text5 = (string.IsNullOrEmpty(textParamValue2) ? Path.Combine(Path.GetTempPath(), $"quicker_{DateTime.Now:yyyyMMdd_HHmmss_fff}.zip") : ((textParamValue2 == ".") ? Path.Combine(text4, Path.GetFileNameWithoutExtension(directoryName) + $"_{DateTime.Now:yyyyMMdd_hhmmss}.zip") : textParamValue2));
			ZipMultipleFiles(array, text5, text4, password, val, textParamValue3, booleanParamValue);
			XActionHelper.OutputResult(CJpgRlDxkKs, step, context, text5, action);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public static void ZipSingleFile(string file, string outputFile, string password, int level, string comment, bool showProgress)
	{
		ZipMultipleFiles(new List<string> { file }, outputFile, Path.GetDirectoryName(file), password, level, comment, showProgress);
	}

	public static void ZipSingleDirectory(string dirPath, string outputFilePath, string password, int level, string comment, bool showProgress)
	{
		ZipMultipleFiles(Directory.GetFileSystemEntries(dirPath), outputFilePath, dirPath, password, level, comment, showProgress);
	}

	public static void ZipMultipleFiles(IList<string> files, string outputFilePath, string baseFolder, string password, int level, string comment, bool showProgress)
	{
		int num = -1;
		long num2 = 0L;
		long num3 = 0L;
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		if (showProgress)
		{
			num = ProgressReportMgr.RequestProgressId();
			num2 = files.Sum(_003C_003Ec.HLwScsRAiQw ?? (_003C_003Ec.HLwScsRAiQw = _003C_003Ec.PeCScIOmc7T.sJWSce6JgG0));
		}
		try
		{
			using ZipOutputStream zipOutputStream = new ZipOutputStream(System.IO.File.Create(outputFilePath));
			zipOutputStream.Password = password;
			zipOutputStream.SetLevel(level);
			if (!string.IsNullOrWhiteSpace(comment))
			{
				zipOutputStream.SetComment(comment);
			}
			byte[] array = new byte[40960];
			foreach (string file in files)
			{
				if (!cancellationTokenSource.IsCancellationRequested)
				{
					if (System.IO.File.Exists(file))
					{
						ZipEntry zipEntry = new ZipEntry(file.Substring(baseFolder.Length + 1));
						zipEntry.DateTime = System.IO.File.GetLastWriteTime(file);
						zipOutputStream.PutNextEntry(zipEntry);
						using FileStream fileStream = System.IO.File.OpenRead(file);
						int num4;
						do
						{
							if (!cancellationTokenSource.IsCancellationRequested)
							{
								num4 = fileStream.Read(array, 0, array.Length);
								zipOutputStream.Write(array, 0, num4);
								if (showProgress)
								{
									num3 += num4;
									ProgressReportMgr.UpdateProgress(num, "", file, (double)num3 * 100.0 / (double)num2, "压缩 " + Path.GetFileName(file) + "...", num, cancellationTokenSource);
								}
								continue;
							}
							throw new TaskCanceledException();
						}
						while (num4 > 0);
					}
					else
					{
						if (!Directory.Exists(file))
						{
							continue;
						}
						string[] fileSystemEntries = Directory.GetFileSystemEntries(file, "*", SearchOption.AllDirectories);
						if (!fileSystemEntries.HasData())
						{
							ZipEntry entry = new ZipEntry(file.Substring(baseFolder.Length + 1) + "/");
							zipOutputStream.PutNextEntry(entry);
						}
						string[] array2 = fileSystemEntries;
						foreach (string text in array2)
						{
							if (!cancellationTokenSource.IsCancellationRequested)
							{
								if (Directory.Exists(text))
								{
									ZipEntry entry2 = new ZipEntry(text.Substring(baseFolder.Length + 1) + "/");
									zipOutputStream.PutNextEntry(entry2);
									continue;
								}
								ZipEntry zipEntry2 = new ZipEntry(text.Substring(baseFolder.Length + 1));
								zipEntry2.DateTime = System.IO.File.GetLastWriteTime(text);
								zipOutputStream.PutNextEntry(zipEntry2);
								using (FileStream fileStream2 = System.IO.File.OpenRead(text))
								{
									int num5;
									do
									{
										if (!cancellationTokenSource.IsCancellationRequested)
										{
											num5 = fileStream2.Read(array, 0, array.Length);
											zipOutputStream.Write(array, 0, num5);
											if (showProgress)
											{
												num3 += num5;
												ProgressReportMgr.UpdateProgress(num, "", file, (double)num3 * 100.0 / (double)num2, "压缩 " + Path.GetFileName(file) + "...", num, cancellationTokenSource);
											}
											continue;
										}
										throw new TaskCanceledException();
									}
									while (num5 > 0);
								}
								continue;
							}
							throw new TaskCanceledException();
						}
					}
					continue;
				}
				throw new TaskCanceledException();
			}
			zipOutputStream.Finish();
			zipOutputStream.Close();
		}
		catch (TaskCanceledException)
		{
			if (System.IO.File.Exists(outputFilePath))
			{
				try
				{
					System.IO.File.Delete(outputFilePath);
				}
				catch (Exception exception)
				{
					P4fgRXk22fw.Error("删除压缩文件出错", exception);
				}
			}
			throw new Exception("压缩任务已取消");
		}
		catch (Exception ex2)
		{
			P4fgRXk22fw.Error("压缩文件出错", ex2);
			throw ex2;
		}
		finally
		{
			if (num >= 0)
			{
				ProgressReportMgr.RemoveProgress(num);
			}
		}
	}

	public static string FindBaseFolder(IList<string> fileOrDirList)
	{
		if (!fileOrDirList.HasData())
		{
			throw new InvalidDataException("输入的文件个数为0");
		}
		return Path.GetDirectoryName(fileOrDirList[0]);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(TIZgRpIMcOR, step) + " " + XActionHelper.GetParamDisplayString(q0MgRBc7V7W, step) + XActionHelper.GetParamDisplayString(d8CgRnwx5Zc, step);
	}

	static ZipStep()
	{
		P4fgRXk22fw = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		TIZgRpIMcOR = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "Zip",
			SelectionItems = new SelectionItem[2]
			{
				new SelectionItem("Zip", "创建Zip文件"),
				new SelectionItem("Unzip", "解压缩Zip文件")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		q0MgRBc7V7W = new StepInParamDef
		{
			Key = "sourcePath",
			Name = "源路径",
			Description = "待压缩的文件夹或文件路径。多个文件时每个文件一行。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "Zip" }
		};
		cgagRQxucHO = new StepInParamDef
		{
			Key = "keepBaseFolder",
			Name = "源路径为单个文件夹时，压缩整个文件夹（保留文件夹名称）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Zip" }
		};
		CgPgRjP0eN6 = new StepInParamDef
		{
			Key = "targetZipFile",
			Name = "Zip文件路径",
			Description = "压缩时：目标文件的路径。留空时自动生成临时文件。点(.)表示待压缩的文件夹或文件所在位置。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "Zip" }
		};
		d8CgRnwx5Zc = new StepInParamDef
		{
			Key = "sourceZipFile",
			Name = "Zip文件路径",
			Description = "待解压的文件路径。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "Unzip" }
		};
		RSkgR4vATyl = new StepInParamDef
		{
			Key = "outputPath",
			Name = "目标路径",
			Description = "解压缩的目标路径, 点(.)表示zip文件所在的文件夹, 星(*)表示以zip文件名创建的子文件夹。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "Unzip" }
		};
		zhEgR5G4Zih = new StepInParamDef
		{
			Key = "password",
			Name = "密码",
			Description = "压缩文件密码",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		CvigRDx538l = new StepInParamDef
		{
			Key = "comment",
			Name = "备注",
			Description = "压缩文件注释内容",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "Zip" }
		};
		QJWgRd0OQ2E = new StepInParamDef
		{
			Key = "level",
			Name = "级别",
			Description = "压缩级别，0-9。0表示不压缩（速度快），9表示压缩到最小（速度慢）",
			DefaultValue = 1,
			IsRequired = false,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "Zip" }
		};
		UJTgRoiK8iN = new StepInParamDef
		{
			Key = "overwrite",
			Name = "自动覆盖文件",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Unzip" }
		};
		PLLgRTdV2gC = new StepInParamDef
		{
			Key = "skipOverwriteError",
			Name = "覆盖失败时忽略",
			Description = "忽略掉无法覆盖的情况",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Unzip" }
		};
		EfKgRM3QAXC = new StepInParamDef
		{
			Key = "showProgress",
			Name = "显示进度条",
			Description = "仅支持解压缩或压缩单个文件夹。",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Unzip", "Zip" }
		};
		tNcgRAi576I = new StepInParamDef
		{
			Key = "autoCopy",
			Name = "将目标文件自动复制到剪贴板（方便后续的粘贴操作）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ccCgRO112s0 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		GDLgRUneBA1 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		CJpgRlDxkKs = new StepOutParamDef
		{
			Key = "resultPath",
			Name = "结果路径",
			Description = "生成的zip文件完整路径，或解压缩后的完整路径",
			Type = VarType.Text
		};
	}

	internal static bool IsTIawQ6MBQXaXHJuZ9x()
	{
		return VIqhKlQ6PCfFASu6VwSY == null;
	}
}
