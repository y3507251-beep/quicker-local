using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using ntFLI7iwvZZfgRBvVis;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Ext;
using Shell32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class CheckFileExistsStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec XfbStI6yUSr;

		public static Func<object> GLlStWlDC11;

		internal static _003C_003Ec el1c5tWETsuI4a0qT2Zt;

		static _003C_003Ec()
		{
			XfbStI6yUSr = new _003C_003Ec();
		}

		internal object VL3StY66TDi()
		{
			return "";
		}

		internal static bool Nu7EtOWEmUnocaIyjsFN()
		{
			return el1c5tWETsuI4a0qT2Zt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public ActionStep Pe5StGd4q2b;

		public ActionExecuteContext nQgStsOvuNh;

		public XAction Vf2StHfZu2a;

		private static _003C_003Ec__DisplayClass51_0 as06M4WECxgyAr9pTNj9;

		internal (bool isSuccess, string message, ActionStopFlag failReason) rY3StkdvM0P()
		{
			string text = XActionHelper.GetTextParamValue(Nowtl35nY8W, Pe5StGd4q2b, nQgStsOvuNh);
			if (text.Contains("%"))
			{
				text = Environment.ExpandEnvironmentVariables(text);
			}
			bool flag = false;
			try
			{
				flag = !string.IsNullOrEmpty(text) && (System.IO.File.Exists(text) || Directory.Exists(text));
			}
			catch (Exception exception)
			{
				nQgStsOvuNh.ActionLogger.LogWarning(exception.GetMessageWithInner());
			}
			XActionHelper.OutputResult(acbtlzGBiZE, Pe5StGd4q2b, nQgStsOvuNh, flag, Vf2StHfZu2a);
			if (flag)
			{
				XActionHelper.OutputResult(wQ3tiwp3pfr, Pe5StGd4q2b, nQgStsOvuNh, System.IO.File.Exists(text), Vf2StHfZu2a);
				XActionHelper.OutputResult(fHDtitvOCM1, Pe5StGd4q2b, nQgStsOvuNh, Directory.Exists(text), Vf2StHfZu2a);
				if (System.IO.File.Exists(text))
				{
					_003C_003Ec__DisplayClass51_1 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_1
					{
						APuStXrBJEN = new FileInfo(text)
					};
					XActionHelper.OutputResult(qnTtiSQCcKm, Pe5StGd4q2b, nQgStsOvuNh, _003C_003Ec__DisplayClass51_.APuStXrBJEN.Length, Vf2StHfZu2a);
					XActionHelper.OutputResult(VVktiNMlqOw, Pe5StGd4q2b, nQgStsOvuNh, _003C_003Ec__DisplayClass51_.APuStXrBJEN.CreationTime, Vf2StHfZu2a);
					XActionHelper.OutputResult(P8itiJlhgDb, Pe5StGd4q2b, nQgStsOvuNh, _003C_003Ec__DisplayClass51_.APuStXrBJEN.LastWriteTime, Vf2StHfZu2a);
					XActionHelper.OutputResult(K1yti2RySTu, Pe5StGd4q2b, nQgStsOvuNh, 0, Vf2StHfZu2a);
					XActionHelper.OutputResult(aTZtiupmJ37, Pe5StGd4q2b, nQgStsOvuNh, 0, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(Fo8tigPnMne, _003C_003Ec__DisplayClass51_.KdVSt1gCwmy, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(UoptiLvwZL8, _003C_003Ec__DisplayClass51_.BUVStby9095, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(IB9tiv8yfZM, _003C_003Ec__DisplayClass51_.p7ESt675a1r, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
				}
				if (Directory.Exists(text))
				{
					_003C_003Ec__DisplayClass51_2 _003C_003Ec__DisplayClass51_2 = new _003C_003Ec__DisplayClass51_2
					{
						U1UStr2xqy6 = new DirectoryInfo(text)
					};
					XActionHelper.OutputResult(qnTtiSQCcKm, Pe5StGd4q2b, nQgStsOvuNh, -1, Vf2StHfZu2a);
					XActionHelper.OutputResult(VVktiNMlqOw, Pe5StGd4q2b, nQgStsOvuNh, _003C_003Ec__DisplayClass51_2.U1UStr2xqy6.CreationTime, Vf2StHfZu2a);
					XActionHelper.OutputResult(P8itiJlhgDb, Pe5StGd4q2b, nQgStsOvuNh, _003C_003Ec__DisplayClass51_2.U1UStr2xqy6.LastWriteTime, Vf2StHfZu2a);
					if (XActionHelper.IsOutputParamSetted(K1yti2RySTu.Key, Pe5StGd4q2b) || XActionHelper.IsOutputParamSetted(aTZtiupmJ37.Key, Pe5StGd4q2b))
					{
						(int, long) tuple = NSQtlOoSMMT(text);
						XActionHelper.OutputResult(K1yti2RySTu, Pe5StGd4q2b, nQgStsOvuNh, tuple.Item1, Vf2StHfZu2a);
						XActionHelper.OutputResult(aTZtiupmJ37, Pe5StGd4q2b, nQgStsOvuNh, tuple.Item2, Vf2StHfZu2a);
					}
					XActionHelper.OutputResultIfNeeded(Fo8tigPnMne, _003C_003Ec__DisplayClass51_2.oRIStmcLWNC, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(UoptiLvwZL8, _003C_003Ec__DisplayClass51_2.ehSStKZo7qV, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(IB9tiv8yfZM, _003C_003Ec__DisplayClass51_2.wBRStxVcbGp, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
				}
			}
			else
			{
				XActionHelper.OutputResult(wQ3tiwp3pfr, Pe5StGd4q2b, nQgStsOvuNh, false, Vf2StHfZu2a);
				XActionHelper.OutputResult(fHDtitvOCM1, Pe5StGd4q2b, nQgStsOvuNh, false, Vf2StHfZu2a);
			}
			IDictionary<string, object> dictionary = null;
			if (XActionHelper.IsOutputParamSetted(SEmti0do8pf.Key, Pe5StGd4q2b) && (System.IO.File.Exists(text) || Directory.Exists(text)))
			{
				dictionary = GetExtendedProperties1(text);
				XActionHelper.OutputResult(SEmti0do8pf, Pe5StGd4q2b, nQgStsOvuNh, dictionary, Vf2StHfZu2a);
			}
			if (System.IO.File.Exists(text) && text.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
			{
				_003C_003Ec__DisplayClass51_3 _003C_003Ec__DisplayClass51_3 = new _003C_003Ec__DisplayClass51_3
				{
					oudStQqFV6Y = ShellObject.FromParsingName(text)
				};
				try
				{
					XActionHelper.OutputResultIfNeeded(PLKtiCESTtr, _003C_003Ec__DisplayClass51_3.FrrStp6FJyN, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
					XActionHelper.OutputResultIfNeeded(UUdtiPbQfxE, _003C_003Ec__DisplayClass51_3.m2uStBDUIK5, Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
				}
				finally
				{
					if ((object)_003C_003Ec__DisplayClass51_3.oudStQqFV6Y != null)
					{
						((IDisposable)_003C_003Ec__DisplayClass51_3.oudStQqFV6Y).Dispose();
					}
				}
			}
			else
			{
				XActionHelper.OutputResult(PLKtiCESTtr, Pe5StGd4q2b, nQgStsOvuNh, "", Vf2StHfZu2a);
				XActionHelper.OutputResultIfNeeded(UUdtiPbQfxE, _003C_003Ec.GLlStWlDC11 ?? (_003C_003Ec.GLlStWlDC11 = _003C_003Ec.XfbStI6yUSr.VL3StY66TDi), Pe5StGd4q2b, nQgStsOvuNh, Vf2StHfZu2a);
			}
			if (System.IO.File.Exists(text) && (XActionHelper.IsOutputParamSetted(R79tiyFwoEB.Key, Pe5StGd4q2b) || XActionHelper.IsOutputParamSetted(GVItiE3csxf.Key, Pe5StGd4q2b) || XActionHelper.IsOutputParamSetted(rIRti8GsZ0u.Key, Pe5StGd4q2b) || XActionHelper.IsOutputParamSetted(Y3Wtialc0MI.Key, Pe5StGd4q2b)))
			{
				(string, string, string, string) tuple2 = eXCKbmiAn2aWIr09iBV.ObIvwbMjsBM(text);
				XActionHelper.OutputResult(GVItiE3csxf, Pe5StGd4q2b, nQgStsOvuNh, tuple2.Item1, Vf2StHfZu2a);
				XActionHelper.OutputResult(R79tiyFwoEB, Pe5StGd4q2b, nQgStsOvuNh, tuple2.Item2, Vf2StHfZu2a);
				XActionHelper.OutputResult(rIRti8GsZ0u, Pe5StGd4q2b, nQgStsOvuNh, tuple2.Item3, Vf2StHfZu2a);
				XActionHelper.OutputResult(Y3Wtialc0MI, Pe5StGd4q2b, nQgStsOvuNh, tuple2.Item4, Vf2StHfZu2a);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool IgUxvYWE7FSM3b1G1jQ3()
		{
			return as06M4WECxgyAr9pTNj9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_1
	{
		public FileInfo APuStXrBJEN;

		internal static _003C_003Ec__DisplayClass51_1 RA2gZCWEhkavsQXOGrrS;

		internal object KdVSt1gCwmy()
		{
			return APuStXrBJEN.Attributes.HasFlag(FileAttributes.ReadOnly);
		}

		internal object BUVStby9095()
		{
			return APuStXrBJEN.Attributes.HasFlag(FileAttributes.Hidden);
		}

		internal object p7ESt675a1r()
		{
			return APuStXrBJEN.Attributes.HasFlag(FileAttributes.System);
		}

		internal static bool EtXMiSWEH4mlJ2c0F5qq()
		{
			return RA2gZCWEhkavsQXOGrrS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_2
	{
		public DirectoryInfo U1UStr2xqy6;

		private static _003C_003Ec__DisplayClass51_2 opVErlWGV0hZsbJpBByt;

		internal object oRIStmcLWNC()
		{
			return U1UStr2xqy6.Attributes.HasFlag(FileAttributes.ReadOnly);
		}

		internal object ehSStKZo7qV()
		{
			return U1UStr2xqy6.Attributes.HasFlag(FileAttributes.Hidden);
		}

		internal object wBRStxVcbGp()
		{
			return U1UStr2xqy6.Attributes.HasFlag(FileAttributes.System);
		}

		static _003C_003Ec__DisplayClass51_2()
		{
		}

		internal static bool WHmeMNWGQhAJBtK4lTE6()
		{
			return opVErlWGV0hZsbJpBByt == null;
		}

		internal static void AmJttlWGcp8n0pRLVO04()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_3
	{
		public ShellObject oudStQqFV6Y;

		private static _003C_003Ec__DisplayClass51_3 wdpKcaWGWqQFF9RPkXwp;

		internal object FrrStp6FJyN()
		{
			ShellProperty<string> targetParsingPath = oudStQqFV6Y.Properties.System.Link.TargetParsingPath;
			object obj;
			if (targetParsingPath == null)
			{
				obj = null;
			}
			else
			{
				obj = targetParsingPath.Value;
				if (obj != null)
				{
					goto IL_002f;
				}
			}
			obj = "";
			goto IL_002f;
			IL_002f:
			return obj;
		}

		internal object m2uStBDUIK5()
		{
			ShellProperty<string> arguments = oudStQqFV6Y.Properties.System.Link.Arguments;
			object obj;
			if (arguments == null)
			{
				obj = null;
			}
			else
			{
				obj = arguments.Value;
				if (obj != null)
				{
					goto IL_002f;
				}
			}
			obj = "";
			goto IL_002f;
			IL_002f:
			return obj;
		}

		internal static bool FvjNncWGyqEVGe8YuXGn()
		{
			return wdpKcaWGWqQFF9RPkXwp == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> CSJtlFAiaHF = new string[6] { "文件", "路径", "是否存", "获取文件信息", "Exif", "mp4" };

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> YUptlUGkluy;

	[CompilerGenerated]
	private readonly string tI7tll7hQKt = "https://getquicker.net/KC/Help/Doc/checkPathExists";

	[CompilerGenerated]
	private readonly bool ioAtlinCDo9;

	private static readonly StepInParamDef Nowtl35nY8W;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> JWKtlf7geFE = new List<StepInParamDef> { Nowtl35nY8W };

	private static readonly StepOutParamDef acbtlzGBiZE;

	private static readonly StepOutParamDef wQ3tiwp3pfr;

	private static readonly StepOutParamDef fHDtitvOCM1;

	private static readonly StepOutParamDef Fo8tigPnMne;

	private static readonly StepOutParamDef UoptiLvwZL8;

	private static readonly StepOutParamDef IB9tiv8yfZM;

	private static readonly StepOutParamDef qnTtiSQCcKm;

	private static readonly StepOutParamDef K1yti2RySTu;

	private static readonly StepOutParamDef aTZtiupmJ37;

	private static readonly StepOutParamDef VVktiNMlqOw;

	private static readonly StepOutParamDef P8itiJlhgDb;

	private static readonly StepOutParamDef SEmti0do8pf;

	private static readonly StepOutParamDef PLKtiCESTtr;

	private static readonly StepOutParamDef UUdtiPbQfxE;

	private static readonly StepOutParamDef GVItiE3csxf;

	private static readonly StepOutParamDef R79tiyFwoEB;

	private static readonly StepOutParamDef rIRti8GsZ0u;

	private static readonly StepOutParamDef Y3Wtialc0MI;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> srQti7uPZg9 = new StepOutParamDef[18]
	{
		acbtlzGBiZE, wQ3tiwp3pfr, qnTtiSQCcKm, fHDtitvOCM1, Fo8tigPnMne, UoptiLvwZL8, IB9tiv8yfZM, K1yti2RySTu, aTZtiupmJ37, VVktiNMlqOw,
		P8itiJlhgDb, SEmti0do8pf, PLKtiCESTtr, UUdtiPbQfxE, GVItiE3csxf, R79tiyFwoEB, rIRti8GsZ0u, Y3Wtialc0MI
	};

	private static CheckFileExistsStep SDpCLJQ5kBOT2UYGKbJP;

	public string Key => "sys:checkPathExists";

	public string Name => "检查路径/获取文件信息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return CSJtlFAiaHF;
		}
	}

	public string Icon => "windows.png";

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return YUptlUGkluy;
		}
	}

	public string Description => "检查指定的文件或文件夹是否存在。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return tI7tll7hQKt;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return ioAtlinCDo9;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return JWKtlf7geFE;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return srQti7uPZg9;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.Pe5StGd4q2b = step;
		_003C_003Ec__DisplayClass51_.nQgStsOvuNh = context;
		_003C_003Ec__DisplayClass51_.Vf2StHfZu2a = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass51_.nQgStsOvuNh, _003C_003Ec__DisplayClass51_.Pe5StGd4q2b, _003C_003Ec__DisplayClass51_.Vf2StHfZu2a, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass51_.rY3StkdvM0P, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(Nowtl35nY8W, step);
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public static Dictionary<string, string> GetExtendedProperties(string filePath)
	{
		string directoryName = Path.GetDirectoryName(filePath);
		Shell shell = (Shell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
		Folder folder = shell.NameSpace(directoryName);
		string fileName = Path.GetFileName(filePath);
		FolderItem vItem = folder.ParseName(fileName);
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		int num = -1;
		while (++num < 320)
		{
			string detailsOf = folder.GetDetailsOf(null, num);
			if (!string.IsNullOrEmpty(detailsOf))
			{
				string detailsOf2 = folder.GetDetailsOf(vItem, num);
				if (!dictionary.ContainsKey(detailsOf))
				{
					dictionary.Add(detailsOf, detailsOf2);
				}
			}
		}
		Marshal.ReleaseComObject(shell);
		Marshal.ReleaseComObject(folder);
		return dictionary;
	}

	public static Dictionary<string, object> GetExtendedProperties1(string filePath)
	{
		using ShellObject shellObject = ShellObject.FromParsingName(filePath);
		using ShellProperties shellProperties = shellObject.Properties;
		using ShellPropertyCollection shellPropertyCollection = shellProperties.DefaultPropertyCollection;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		int num = 0;
		foreach (IShellProperty item in shellPropertyCollection)
		{
			string text = (item.CanonicalName ?? ("unnamed-[" + num + "]")).Replace("System.", string.Empty);
			if ((object)Nullable.GetUnderlyingType(item.ValueType) == null)
			{
				Type valueType = item.ValueType;
			}
			object value = item.ValueAsObject ?? string.Empty;
			string displayName = item.Description.DisplayName;
			num++;
			if (!dictionary.ContainsKey(text))
			{
				dictionary.Add(text, value);
				dictionary.Add(text + "_FriendlyName", displayName);
			}
		}
		return dictionary;
	}

	public static (string targetPath, string arguments) GetLnkTarget(string lnkFile)
	{
		using ShellObject shellObject = ShellObject.FromParsingName(lnkFile);
		using ShellProperties shellProperties = shellObject.Properties;
		string value = shellProperties.System.Link.TargetParsingPath.Value;
		ShellProperty<string> arguments = shellProperties.System.Link.Arguments;
		object obj;
		if (arguments == null)
		{
			obj = null;
		}
		else
		{
			obj = arguments.Value;
			if (obj != null)
			{
				goto IL_0048;
			}
		}
		obj = "";
		goto IL_0048;
		IL_0048:
		string item = (string)obj;
		return (targetPath: value, arguments: item);
	}

	internal static (int fileCount, long totalSize) NSQtlOoSMMT(string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			return (fileCount: 0, totalSize: 0L);
		}
		IEnumerable<FileInfo> enumerable = new DirectoryInfo(string_1).EnumerateFiles("*", SearchOption.AllDirectories);
		int num = 0;
		long num2 = 0L;
		foreach (FileInfo item in enumerable)
		{
			num++;
			num2 += item.Length;
		}
		return (fileCount: num, totalSize: num2);
	}

	static CheckFileExistsStep()
	{
		Nowtl35nY8W = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			DefaultValue = "",
			Description = "文件或文件夹的完整路径。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		acbtlzGBiZE = new StepOutParamDef
		{
			Key = "isExists",
			Name = "路径是否存在",
			Description = "",
			Type = VarType.Boolean
		};
		wQ3tiwp3pfr = new StepOutParamDef
		{
			Key = "isFile",
			Name = "是否为文件",
			Description = "",
			Type = VarType.Boolean
		};
		fHDtitvOCM1 = new StepOutParamDef
		{
			Key = "isFolder",
			Name = "是否为文件夹",
			Description = "",
			Type = VarType.Boolean
		};
		Fo8tigPnMne = new StepOutParamDef
		{
			Key = "isReadonly",
			Name = "是否只读",
			Description = "",
			Type = VarType.Boolean
		};
		UoptiLvwZL8 = new StepOutParamDef
		{
			Key = "isHidden",
			Name = "是否隐藏",
			Description = "",
			Type = VarType.Boolean
		};
		IB9tiv8yfZM = new StepOutParamDef
		{
			Key = "isSystem",
			Name = "是否为系统文件",
			Description = "",
			Type = VarType.Boolean
		};
		qnTtiSQCcKm = new StepOutParamDef
		{
			Key = "fileLength",
			Name = "文件长度",
			Description = "",
			Type = VarType.Integer
		};
		K1yti2RySTu = new StepOutParamDef
		{
			Key = "fileCount",
			Name = "文件夹内文件个数",
			Description = "仅对文件夹路径有效，输出时需要耗费一定时间扫描文件夹",
			Type = VarType.Integer
		};
		aTZtiupmJ37 = new StepOutParamDef
		{
			Key = "totalLength",
			Name = "文件夹大小",
			Description = "仅对文件夹路径有效，输出时需要耗费一定时间扫描文件夹",
			Type = VarType.Integer
		};
		VVktiNMlqOw = new StepOutParamDef
		{
			Key = "createTime",
			Name = "创建时间",
			Description = "",
			Type = VarType.DateTime
		};
		P8itiJlhgDb = new StepOutParamDef
		{
			Key = "editTime",
			Name = "更新时间",
			Description = "",
			Type = VarType.DateTime
		};
		SEmti0do8pf = new StepOutParamDef
		{
			Key = "metaData",
			Name = "文件扩展信息",
			Description = "获取文件的扩展信息，值为词典类型。",
			Type = VarType.Dict
		};
		PLKtiCESTtr = new StepOutParamDef
		{
			Key = "lnkTarget",
			Name = "lnk目标路径",
			Description = "快捷方式文件的目标文件",
			Type = VarType.Text
		};
		UUdtiPbQfxE = new StepOutParamDef
		{
			Key = "lnkArguments",
			Name = "lnk命令行参数",
			Description = "快捷方式中的命令行参数",
			Type = VarType.Text
		};
		GVItiE3csxf = new StepOutParamDef
		{
			Key = "md5hash",
			Name = "MD5 哈希值",
			Description = "获取文件的MD5哈希值。仅对文件有效，大文件需要一些时间扫描。",
			Type = VarType.Text
		};
		R79tiyFwoEB = new StepOutParamDef
		{
			Key = "sha1hash",
			Name = "SHA1 哈希值",
			Description = "获取文件的SHA1哈希值。仅对文件有效，大文件需要一些时间扫描。",
			Type = VarType.Text
		};
		rIRti8GsZ0u = new StepOutParamDef
		{
			Key = "sha256hash",
			Name = "SHA256 哈希值",
			Description = "获取文件的SHA256哈希值。仅对文件有效，大文件需要一些时间扫描。",
			Type = VarType.Text
		};
		Y3Wtialc0MI = new StepOutParamDef
		{
			Key = "crc32hash",
			Name = "CRC32 哈希值",
			Description = "获取文件的CRC32哈希值。仅对文件有效，大文件需要一些时间扫描。",
			Type = VarType.Text
		};
	}

	internal static bool pPVtVbQ5aRfSiEZrtLRa()
	{
		return SDpCLJQ5kBOT2UYGKbJP == null;
	}

	internal static void ssjs8AQ5N8dikdc8Zc5T()
	{
	}
}
