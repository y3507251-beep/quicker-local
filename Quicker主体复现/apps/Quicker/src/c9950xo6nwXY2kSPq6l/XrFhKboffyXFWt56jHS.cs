using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FontAwesome5;
using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.Streaming;
using NPOI.XSSF.UserModel;
using Quicker.Actions.XActions.BuildinRunners;
using Quicker.Actions.XActions.BuildinRunners.Office;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace c9950xo6nwXY2kSPq6l;

internal class XrFhKboffyXFWt56jHS : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Wg4SY038S6m;

		public static Func<string, int> IDISYCjbulq;

		public static Func<IName, NameWrapper> WmbSYPf7br9;

		internal static _003C_003Ec UaHRbiWuBG2ngQwgD66u;

		static _003C_003Ec()
		{
			Wg4SY038S6m = new _003C_003Ec();
		}

		internal int BcnSYNJ5kLo(string x)
		{
			return int.Parse(x);
		}

		internal NameWrapper ViQSYJAmYmQ(IName x)
		{
			return new NameWrapper
			{
				NameName = x.NameName,
				SheetIndex = x.SheetIndex,
				RefersToFormula = x.RefersToFormula,
				Comment = x.Comment,
				IsFunctionName = x.IsFunctionName
			};
		}

		internal static bool A4apaGWuvZJWDVQSHexm()
		{
			return UaHRbiWuBG2ngQwgD66u == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass106_0
	{
		public IDictionary<string, object> mOsSYyOSyyQ;

		private static _003C_003Ec__DisplayClass106_0 ea4NwHWuOLMXvrvT4Vmg;

		internal object PmTSYE1qbKd()
		{
			return mOsSYyOSyyQ;
		}

		internal static bool o1l2bpWuJ9qggILZdrHY()
		{
			return ea4NwHWuOLMXvrvT4Vmg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass112_0
	{
		public ICell ia1SY77B7Gr;

		internal static _003C_003Ec__DisplayClass112_0 biLbapWuaBeZGbCCdajM;

		internal object NrnSY87lZpK()
		{
			return ia1SY77B7Gr.CellFormula;
		}

		internal object W0OSYaB8fjh()
		{
			return ia1SY77B7Gr.CellStyle.GetDataFormatString();
		}

		internal static bool iPxBCDWurYexM6GtGec6()
		{
			return biLbapWuaBeZGbCCdajM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass114_0
	{
		public IWorkbook xq6SYRb9nC3;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass124_0
	{
		public IWorkbook eZfSYVwmBEp;

		internal static _003C_003Ec__DisplayClass124_0 Pn7j6fWuoRfiOuKsbYiV;

		internal object op7SYqd8qMN()
		{
			return eZfSYVwmBEp.GetSheetList();
		}

		internal object hmgSYciHLaH()
		{
			return JsonConvert.SerializeObject(eZfSYVwmBEp.GetAllNames().Select(_003C_003Ec.WmbSYPf7br9 ?? (_003C_003Ec.WmbSYPf7br9 = _003C_003Ec.Wg4SY038S6m.ViQSYJAmYmQ)));
		}

		internal static bool HZWT7fWuftrJet3NBngP()
		{
			return Pn7j6fWuoRfiOuKsbYiV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass97_0
	{
		public ActionStep RDwSY9GEgZl;

		public ActionExecuteContext K1aSYhbQ8At;

		public XrFhKboffyXFWt56jHS eYgSYenyaW7;

		public XAction p3mSYYQBmdw;

		private static _003C_003Ec__DisplayClass97_0 oXnJx6WuqaqVTL4wrbRa;

		internal (bool isSuccess, string message, ActionStopFlag failReason) angSYZ4TsOK()
		{
			string textParamValue = XActionHelper.GetTextParamValue(nLhgsEXZ60y, RDwSY9GEgZl, K1aSYhbQ8At);
			switch (textParamValue)
			{
			case "save":
				return eYgSYenyaW7.ohngGlYmpHi(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "load":
				return eYgSYenyaW7.FAggsS9ho8f(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "getRow":
				return eYgSYenyaW7.KlBgstSoxpi(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "setCell":
				return eYgSYenyaW7.fTWgGfXpbGh(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "getCell":
				return eYgSYenyaW7.xcSgG3NZggc(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "addNames":
				return eYgSYenyaW7.z5xgG4HDmOy(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "setStyle":
				return eYgSYenyaW7.IiagGox5RdP(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "readData":
				return eYgSYenyaW7.HmbgGAXRgoS(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "writeData":
				return eYgSYenyaW7.YrZgGUtQ6Vx(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "mergeCells":
				return eYgSYenyaW7.rAbgGTiBUkg(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "freezePane":
				return eYgSYenyaW7.XdrgGdp5VAl(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "autoFilter":
				return eYgSYenyaW7.rRHgGDmJNpQ(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "newWorkbook":
				return eYgSYenyaW7.gchgG5eMNIG(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "createSheet":
				return eYgSYenyaW7.qgFgsLwrnwL(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "batchReplace":
				return eYgSYenyaW7.ihYgGil3ouu(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "getCellByValue":
				return eYgSYenyaW7.N0hgGnX1VO3(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			case "getSheet":
			case "getSheetByName":
			case "getSheetByIndex":
				return eYgSYenyaW7.hpOgsgZwxgc(textParamValue, RDwSY9GEgZl, K1aSYhbQ8At, p3mSYYQBmdw);
			default:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool l5abZHWuixAh6kj0ts63()
		{
			return oXnJx6WuqaqVTL4wrbRa == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> Ktqgsu5bJKR;

	[CompilerGenerated]
	private readonly string GF2gsN4nbih = $"fa:{EFontAwesomeIcon.Light_FileExcel}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> gYEgsJP8rvw;

	[CompilerGenerated]
	private readonly string MIlgs0jg5GE = "读取Excel文件内容或写入Excel文件";

	[CompilerGenerated]
	private readonly StepType Jf8gsCuYM8o;

	[CompilerGenerated]
	private readonly string GvAgsP0tSZH = "https://getquicker.net/KC/Help/Doc/excelreadwrite";

	public static StepInParamDef nLhgsEXZ60y;

	public static StepInParamDef c8Mgsy0ko7A;

	public static StepInParamDef w02gs8n5FFT;

	public static StepInParamDef mkYgsa3c4yI;

	public static StepInParamDef zHPgs7UoK42;

	public static StepInParamDef ybZgsRwIpCa;

	public static StepInParamDef DVOgsqwANDg;

	[Obsolete]
	private static readonly StepInParamDef XOCgsci2cdb;

	private static readonly StepInParamDef GhmgsVKWUwD;

	private static readonly StepInParamDef QP0gsZOkPGe;

	private static readonly StepInParamDef uGrgs9anyer;

	private static readonly StepInParamDef edDgshB7yhs;

	public static StepInParamDef s8PgseJf90s;

	public static StepInParamDef zdfgsYs9mRu;

	public static StepInParamDef IfqgsIIxRAP;

	public static StepInParamDef cxagsWBYWwS;

	public static StepInParamDef ANtgskyCbl5;

	public static StepInParamDef vU1gsGUY0TE;

	public static StepInParamDef xOUgssvWeOl;

	public static StepInParamDef kBRgsH89rvX;

	public static StepInParamDef FMags1s38AV;

	public static StepInParamDef EgKgsbqX8bw;

	private static StepInParamDef N5Ags67wDZp;

	private static StepInParamDef VkmgsX6DE7C;

	private static readonly StepInParamDef uSSgsm4VZbv;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> G9NgsKXnd14 = new List<StepInParamDef>
	{
		nLhgsEXZ60y, c8Mgsy0ko7A, w02gs8n5FFT, zHPgs7UoK42, mkYgsa3c4yI, ybZgsRwIpCa, DVOgsqwANDg, XOCgsci2cdb, GhmgsVKWUwD, QP0gsZOkPGe,
		uGrgs9anyer, s8PgseJf90s, zdfgsYs9mRu, IfqgsIIxRAP, cxagsWBYWwS, ANtgskyCbl5, edDgshB7yhs, vU1gsGUY0TE, xOUgssvWeOl, kBRgsH89rvX,
		FMags1s38AV, EgKgsbqX8bw, N5Ags67wDZp, VkmgsX6DE7C, uSSgsm4VZbv
	};

	private static readonly StepOutParamDef dc9gsxNN33P;

	public static readonly StepOutParamDef QoOgsriweNY;

	public static readonly StepOutParamDef lJ3gspTXB4I;

	public static readonly StepOutParamDef EupgsBcYPCU;

	public static readonly StepOutParamDef HolgsQ81GG1;

	public static readonly StepOutParamDef WT8gsjBy30F;

	public static readonly StepOutParamDef WElgsnfkv1q;

	public static readonly StepOutParamDef FgDgs49FbUM;

	public static readonly StepOutParamDef XZ1gs5LllIF;

	public static readonly StepOutParamDef g4HgsDdm41i;

	public static readonly StepOutParamDef dFxgsdShoSa;

	public static readonly StepOutParamDef v7pgsoYGTa4;

	public static readonly StepOutParamDef mavgsTZhCQH;

	public static readonly StepOutParamDef dy1gsMg9WHQ;

	public static readonly StepOutParamDef QQlgsAnkwaT;

	public static readonly StepOutParamDef aJLgsOYYPL2;

	public static readonly StepOutParamDef sYigsFsS2ZE;

	public static readonly StepOutParamDef oMXgsU4Mqyb;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> EwRgslEoTlK = new List<StepOutParamDef>
	{
		dc9gsxNN33P, QoOgsriweNY, EupgsBcYPCU, lJ3gspTXB4I, HolgsQ81GG1, WT8gsjBy30F, WElgsnfkv1q, XZ1gs5LllIF, g4HgsDdm41i, FgDgs49FbUM,
		dFxgsdShoSa, v7pgsoYGTa4, mavgsTZhCQH, dy1gsMg9WHQ, QQlgsAnkwaT, sYigsFsS2ZE, aJLgsOYYPL2, oMXgsU4Mqyb
	};

	private static XrFhKboffyXFWt56jHS ITMGkDQmwG8BIwhnL7iJ;

	public string Key => "sys:excelreadwrite";

	public string Name => "Excel文件读写";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Ktqgsu5bJKR;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GF2gsN4nbih;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.SoftInteraction;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return gYEgsJP8rvw;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return MIlgs0jg5GE;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return Jf8gsCuYM8o;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return GvAgsP0tSZH;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return G9NgsKXnd14;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return EwRgslEoTlK;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass97_0 _003C_003Ec__DisplayClass97_ = new _003C_003Ec__DisplayClass97_0();
		_003C_003Ec__DisplayClass97_.RDwSY9GEgZl = step;
		_003C_003Ec__DisplayClass97_.K1aSYhbQ8At = context;
		_003C_003Ec__DisplayClass97_.eYgSYenyaW7 = this;
		_003C_003Ec__DisplayClass97_.p3mSYYQBmdw = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass97_.K1aSYhbQ8At, _003C_003Ec__DisplayClass97_.RDwSY9GEgZl, _003C_003Ec__DisplayClass97_.p3mSYYQBmdw, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass97_.angSYZ4TsOK, (Action)null, (Action)null, uSSgsm4VZbv, dc9gsxNN33P);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) N0hgGnX1VO3(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet isheet_ = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(kBRgsH89rvX, actionStep_0, actionExecuteContext_0);
		CellAddress cellAddress = NPOIHelper.IjDgBG0tAtX(isheet_, textParamValue);
		if (cellAddress == null)
		{
			return (isSuccess: false, message: "未找到值为" + textParamValue + "的单元格", failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResult(oMXgsU4Mqyb, actionStep_0, actionExecuteContext_0, cellAddress.ToString(), xaction_0);
		XActionHelper.OutputResult(WT8gsjBy30F, actionStep_0, actionExecuteContext_0, cellAddress.Row, xaction_0);
		XActionHelper.OutputResult(XZ1gs5LllIF, actionStep_0, actionExecuteContext_0, cellAddress.Column, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) z5xgG4HDmOy(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		object paramVariableObject = XActionHelper.GetParamVariableObject(zHPgs7UoK42, actionStep_0, actionExecuteContext_0);
		IWorkbook workbook = paramVariableObject as IWorkbook;
		if (workbook == null)
		{
			if (!(paramVariableObject is string path) || !File.Exists(path))
			{
				return (isSuccess: false, message: "传入的参数不是工作簿对象类型。", failReason: ActionStopFlag.OperationFailed);
			}
			workbook = NPOIHelper.LoadWorkbook(path);
		}
		string textParamValue = XActionHelper.GetTextParamValue(uGrgs9anyer, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue))
		{
			return (isSuccess: false, message: "名称数据为空。", failReason: ActionStopFlag.OperationFailed);
		}
		List<NameWrapper> list = JsonConvert.DeserializeObject<List<NameWrapper>>(textParamValue);
		if (!list.HasData())
		{
			return (isSuccess: false, message: "名称数据为空(json)。", failReason: ActionStopFlag.OperationFailed);
		}
		foreach (NameWrapper item in list)
		{
			IName name = workbook.CreateName();
			name.NameName = item.NameName;
			name.RefersToFormula = item.RefersToFormula;
			name.Comment = item.Comment;
			name.SetFunction(item.IsFunctionName);
			name.SheetIndex = item.SheetIndex;
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) gchgG5eMNIG(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		IWorkbook workbook = null;
		string textParamValue = XActionHelper.GetTextParamValue(c8Mgsy0ko7A, actionStep_0, actionExecuteContext_0);
		if (textParamValue != null && textParamValue.Length == 0)
		{
			goto IL_0064;
		}
		switch (textParamValue)
		{
		default:
			return (isSuccess: false, message: "不支持的工作簿类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
		case "SXSSF":
			break;
		case "HSSF":
			goto IL_005c;
		case "XSSF":
			goto IL_0064;
		}
		workbook = new SXSSFWorkbook();
		goto IL_006a;
		IL_005c:
		workbook = new HSSFWorkbook();
		goto IL_006a;
		IL_0064:
		workbook = new XSSFWorkbook();
		goto IL_006a;
		IL_006a:
		XActionHelper.OutputResult(QoOgsriweNY, actionStep_0, actionExecuteContext_0, workbook, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) rRHgGDmJNpQ(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet sheet = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		CellRangeAddress autoFilter = dKTgGMwlMP9(actionStep_0, actionExecuteContext_0);
		sheet.SetAutoFilter(autoFilter);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) XdrgGdp5VAl(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet sheet = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		int rowSplit = (int)XActionHelper.GetIntegerParamValue(ANtgskyCbl5, actionStep_0, actionExecuteContext_0);
		int colSplit = (int)XActionHelper.GetIntegerParamValue(vU1gsGUY0TE, actionStep_0, actionExecuteContext_0);
		sheet.CreateFreezePane(colSplit, rowSplit);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) IiagGox5RdP(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet sheet = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		CellRangeAddress range = dKTgGMwlMP9(actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(cxagsWBYWwS, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			return (isSuccess: false, message: "格式数据为空", failReason: ActionStopFlag.OperationFailed);
		}
		NPOIHelper.ApplyStyle((sheet as XSSFSheet) ?? throw new NotSupportedException("仅对xlsx格式文档支持设置风格。"), range, textParamValue);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) rAbgGTiBUkg(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet sheet = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		CellRangeAddress region = dKTgGMwlMP9(actionStep_0, actionExecuteContext_0);
		sheet.AddMergedRegion(region);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static CellRangeAddress dKTgGMwlMP9(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(IfqgsIIxRAP, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			throw new InvalidDataException("未指定单元格区域范围。");
		}
		textParamValue = textParamValue.Trim();
		if (textParamValue.Contains(','))
		{
			List<int> list = textParamValue.SplitToList(',', '，').Select(_003C_003Ec.IDISYCjbulq ?? (_003C_003Ec.IDISYCjbulq = _003C_003Ec.Wg4SY038S6m.BcnSYNJ5kLo)).ToList();
			if (list.Count == 4)
			{
				return new CellRangeAddress(list[0], list[1], list[2], list[3]);
			}
			if (list.Count == 2)
			{
				return new CellRangeAddress(list[0], list[0], list[1], list[1]);
			}
			throw new InvalidDataException("单元格区域范围格式不正确，当前值：" + textParamValue + "。");
		}
		return CellRangeAddress.ValueOf(textParamValue);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) HmbgGAXRgoS(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass106_0 _003C_003Ec__DisplayClass106_ = new _003C_003Ec__DisplayClass106_0();
		object paramVariableObject = XActionHelper.GetParamVariableObject(zHPgs7UoK42, actionStep_0, actionExecuteContext_0);
		IWorkbook workbook = paramVariableObject as IWorkbook;
		if (workbook == null)
		{
			if (!(paramVariableObject is string path) || !File.Exists(path))
			{
				return (isSuccess: false, message: "传入的参数不是工作簿对象类型。", failReason: ActionStopFlag.OperationFailed);
			}
			workbook = NPOIHelper.LoadWorkbook(path);
		}
		string textParamValue = XActionHelper.GetTextParamValue(mkYgsa3c4yI, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			return (isSuccess: false, message: "未定义要提取的数据", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass106_.mOsSYyOSyyQ = new Dictionary<string, object>();
		string[] array = textParamValue.SplitToList();
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = array[num];
				if (!string.IsNullOrWhiteSpace(text) && !text.StartsWith("//"))
				{
					string[] array2 = text.Split(new char[1] { ':' }, 2);
					if (array2.Length != 2)
					{
						return (isSuccess: false, message: "提取数据定义格式不正确，当前值：" + text + "。", failReason: ActionStopFlag.OperationFailed);
					}
					string key = array2[0];
					string text2 = array2[1].Trim();
					ISheet sheet = null;
					string text3 = null;
					if (!text2.StartsWith("["))
					{
						sheet = workbook.GetSheetAt(0);
						text3 = text2;
					}
					else
					{
						int num2 = text2.IndexOf(']');
						string text4 = text2.Substring(1, num2 - 1);
						sheet = xXsgGOV2aHr(workbook, text4);
						if (sheet == null)
						{
							return (isSuccess: false, message: "未找到工作表：" + text4, failReason: ActionStopFlag.OperationFailed);
						}
						text3 = text2.Substring(num2 + 1);
					}
					if (string.IsNullOrWhiteSpace(text3))
					{
						break;
					}
					if (text3.Contains(":"))
					{
						CellRangeAddress range = CellRangeAddress.ValueOf(text3);
						DataTable value = sheet.ReadTable(range);
						_003C_003Ec__DisplayClass106_.mOsSYyOSyyQ.Add(key, value);
					}
					else
					{
						CellAddress cellAddress = new CellAddress(text3);
						(object, string) cellValue = NPOIHelper.GetCellValue(sheet, cellAddress.Row, cellAddress.Column);
						_003C_003Ec__DisplayClass106_.mOsSYyOSyyQ.Add(key, cellValue.Item2 ?? "");
					}
				}
				num++;
				continue;
			}
			XActionHelper.OutputResultIfNeeded(aJLgsOYYPL2, _003C_003Ec__DisplayClass106_.PmTSYE1qbKd, actionStep_0, actionExecuteContext_0, xaction_0);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "未指定单元格(" + text + ")。", failReason: ActionStopFlag.OperationFailed);
	}

	private static ISheet xXsgGOV2aHr(IWorkbook iworkbook_0, string string_3)
	{
		ISheet sheet = null;
		if (string_3.StartsWith(":"))
		{
			sheet = iworkbook_0.GetSheet(string_3.Substring(1));
		}
		else
		{
			if (int.TryParse(string_3, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) && result < iworkbook_0.NumberOfSheets)
			{
				sheet = iworkbook_0.GetSheetAt(result);
			}
			if (sheet == null)
			{
				sheet = iworkbook_0.GetSheet(string_3);
			}
		}
		return sheet;
	}

	private static ISheet ucugGFQhaac(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		return (XActionHelper.GetParamVariableObject(s8PgseJf90s, actionStep_0, actionExecuteContext_0) as ISheet) ?? throw new InvalidDataException("传入的工作表对象为空。");
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) YrZgGUtQ6Vx(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		ISheet sheet = ucugGFQhaac(actionStep_0, actionExecuteContext_0);
		object paramValue = XActionHelper.GetParamValue(GhmgsVKWUwD, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(QP0gsZOkPGe, actionStep_0, actionExecuteContext_0);
		int rowIndex = (int)XActionHelper.GetIntegerParamValue(ANtgskyCbl5, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(edDgshB7yhs, actionStep_0, actionExecuteContext_0);
		if (paramValue is ISheet sourceSheet)
		{
			NPOIHelper.CopySheet(sourceSheet, 0, sheet, rowIndex, textParamValue, booleanParamValue);
		}
		else
		{
			if (!(paramValue is DataTable table))
			{
				return (isSuccess: false, message: "不支持此类型的源数据，请使用表格或工作表对象。", failReason: ActionStopFlag.OperationFailed);
			}
			NPOIHelper.WriteDataFromTable(table, sheet, rowIndex, textParamValue, booleanParamValue);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) ohngGlYmpHi(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(zHPgs7UoK42, actionStep_0, actionExecuteContext_0) is IWorkbook workbook))
		{
			return (isSuccess: false, message: "传入的参数不是工作簿对象类型。", failReason: ActionStopFlag.OperationFailed);
		}
		try
		{
			if (workbook is XSSFWorkbook)
			{
				BaseFormulaEvaluator.EvaluateAllFormulaCells(workbook);
			}
			else if (workbook is HSSFWorkbook)
			{
				HSSFFormulaEvaluator.EvaluateAllFormulaCells(workbook);
			}
			else if (workbook is SXSSFWorkbook)
			{
				BaseFormulaEvaluator.EvaluateAllFormulaCells(workbook);
			}
		}
		catch (Exception ex)
		{
			actionExecuteContext_0.ActionLogger.LogWarning("更新Workbook公式结果时发生异常：" + ex.Message);
		}
		string text = XActionHelper.GetTextParamValue(w02gs8n5FFT, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(text) && actionExecuteContext_0.CustomData.ContainsKey("__temp_excel_file_path"))
		{
			text = actionExecuteContext_0.GetVarValue("__temp_excel_file_path") as string;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			return (isSuccess: false, message: "未指定要保存的文件路径。", failReason: ActionStopFlag.OperationFailed);
		}
		using (FileStream stream = new FileStream(text, FileMode.Create, FileAccess.Write))
		{
			if ((!text.EndsWithAny(StringComparison.OrdinalIgnoreCase, ".xlsx", ".xlsm") || (!(workbook is XSSFWorkbook) && !(workbook is SXSSFWorkbook))) && (!text.EndsWith(".xls") || !(workbook is HSSFWorkbook)))
			{
				return (isSuccess: false, message: "文件名后缀和内部格式不匹配。", failReason: ActionStopFlag.OperationFailed);
			}
			workbook.Write(stream);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) ihYgGil3ouu(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(s8PgseJf90s, actionStep_0, actionExecuteContext_0) is ISheet sheet))
		{
			return (isSuccess: false, message: "传入的工作表对象为空。", failReason: ActionStopFlag.OperationFailed);
		}
		IDictionary<string, object> dictParamValue = XActionHelper.GetDictParamValue(N5Ags67wDZp, actionStep_0, actionExecuteContext_0);
		if (dictParamValue != null && dictParamValue.Keys.Count != 0)
		{
			string[] array = XActionHelper.GetTextParamValue(VkmgsX6DE7C, actionStep_0, actionExecuteContext_0).SplitToList();
			string text = string.Empty;
			string text2 = string.Empty;
			if (array.HasData())
			{
				text = array[0].Trim();
				text2 = ((array.Length > 1) ? array[1].Trim() : text);
			}
			IEnumerator rowEnumerator = sheet.GetRowEnumerator();
			while (rowEnumerator.MoveNext())
			{
				IRow row = (IRow)rowEnumerator.Current;
				if (row == null)
				{
					continue;
				}
				for (int i = row.FirstCellNum; i <= row.LastCellNum; i++)
				{
					ICell cell = row.GetCell(i, MissingCellPolicy.RETURN_BLANK_AS_NULL);
					if (cell == null || cell.CellType != CellType.String)
					{
						continue;
					}
					string text3 = cell.StringCellValue;
					string b = text3;
					if (string.IsNullOrEmpty(text3))
					{
						continue;
					}
					using (IEnumerator<string> enumerator = dictParamValue.Keys.GetEnumerator())
					{
						string text4;
						string oldValue;
						object obj2;
						for (; enumerator.MoveNext(); text3 = text4.Replace(oldValue, (string)obj2))
						{
							string current = enumerator.Current;
							text4 = text3;
							oldValue = text + current + text2;
							object obj = dictParamValue[current];
							if (obj == null)
							{
								obj2 = null;
							}
							else
							{
								obj2 = obj.ToString();
								if (obj2 != null)
								{
									continue;
								}
							}
							obj2 = "";
						}
					}
					if (!string.Equals(text3, b))
					{
						cell.SetCellValue(text3);
					}
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "传入的替换词典为空。", failReason: ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) xcSgG3NZggc(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass112_0 _003C_003Ec__DisplayClass112_ = new _003C_003Ec__DisplayClass112_0();
		if (!(XActionHelper.GetParamVariableObject(s8PgseJf90s, actionStep_0, actionExecuteContext_0) is ISheet sheet))
		{
			return (isSuccess: false, message: "传入的工作表对象为空。", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(zdfgsYs9mRu, actionStep_0, actionExecuteContext_0);
		int rownum;
		int cellnum;
		if (!string.IsNullOrWhiteSpace(textParamValue))
		{
			CellReference cellReference = new CellReference(textParamValue);
			rownum = cellReference.Row;
			cellnum = cellReference.Col;
		}
		else
		{
			rownum = (int)XActionHelper.GetIntegerParamValue(ANtgskyCbl5, actionStep_0, actionExecuteContext_0);
			cellnum = (int)XActionHelper.GetIntegerParamValue(vU1gsGUY0TE, actionStep_0, actionExecuteContext_0);
		}
		_003C_003Ec__DisplayClass112_.ia1SY77B7Gr = sheet.GetRow(rownum)?.GetCell(cellnum, MissingCellPolicy.RETURN_BLANK_AS_NULL);
		if (_003C_003Ec__DisplayClass112_.ia1SY77B7Gr == null)
		{
			XActionHelper.OutputResult(dFxgsdShoSa, actionStep_0, actionExecuteContext_0, false, xaction_0);
			XActionHelper.OutputResult(v7pgsoYGTa4, actionStep_0, actionExecuteContext_0, "", xaction_0);
		}
		else
		{
			XActionHelper.OutputResult(dFxgsdShoSa, actionStep_0, actionExecuteContext_0, true, xaction_0);
			object obj = null;
			string text = "";
			(obj, text) = NPOIHelper.GetCellValue(_003C_003Ec__DisplayClass112_.ia1SY77B7Gr);
			XActionHelper.OutputResult(v7pgsoYGTa4, actionStep_0, actionExecuteContext_0, obj, xaction_0);
			XActionHelper.OutputResult(mavgsTZhCQH, actionStep_0, actionExecuteContext_0, text, xaction_0);
			XActionHelper.OutputResult(dy1gsMg9WHQ, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass112_.ia1SY77B7Gr.CellType.ToString(), xaction_0);
			if (_003C_003Ec__DisplayClass112_.ia1SY77B7Gr.CellType == CellType.Formula)
			{
				XActionHelper.OutputResultIfNeeded(QQlgsAnkwaT, _003C_003Ec__DisplayClass112_.NrnSY87lZpK, actionStep_0, actionExecuteContext_0, xaction_0);
			}
			XActionHelper.OutputResultIfNeeded(sYigsFsS2ZE, _003C_003Ec__DisplayClass112_.W0OSYaB8fjh, actionStep_0, actionExecuteContext_0, xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) fTWgGfXpbGh(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(s8PgseJf90s, actionStep_0, actionExecuteContext_0) is ISheet sheet))
		{
			return (isSuccess: false, message: "传入的工作表对象为空。", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(zdfgsYs9mRu, actionStep_0, actionExecuteContext_0);
		int rowIndex;
		int cellIndex;
		if (!string.IsNullOrWhiteSpace(textParamValue))
		{
			CellReference cellReference = new CellReference(textParamValue);
			rowIndex = cellReference.Row;
			cellIndex = cellReference.Col;
		}
		else
		{
			rowIndex = (int)XActionHelper.GetIntegerParamValue(ANtgskyCbl5, actionStep_0, actionExecuteContext_0);
			cellIndex = (int)XActionHelper.GetIntegerParamValue(vU1gsGUY0TE, actionStep_0, actionExecuteContext_0);
		}
		ICell orCreateCell = sheet.GetOrCreateRow(rowIndex).GetOrCreateCell(cellIndex);
		string textParamValue2 = XActionHelper.GetTextParamValue(xOUgssvWeOl, actionStep_0, actionExecuteContext_0);
		object paramValue = XActionHelper.GetParamValue(kBRgsH89rvX, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(FMags1s38AV, actionStep_0, actionExecuteContext_0);
		string textParamValue4 = XActionHelper.GetTextParamValue(EgKgsbqX8bw, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(textParamValue2))
		{
			if (paramValue is DateTime cellValue)
			{
				orCreateCell.SetCellValue(cellValue);
			}
			else if (paramValue is bool cellValue2)
			{
				orCreateCell.SetCellValue(cellValue2);
			}
			else if (paramValue is double cellValue3)
			{
				orCreateCell.SetCellValue(cellValue3);
			}
			else
			{
				orCreateCell.SetCellValue(paramValue.ToString());
			}
		}
		else
		{
			if (!Enum.TryParse<CellType>(textParamValue2, out var result))
			{
				return (isSuccess: false, message: "不支持的单元格类型：" + textParamValue2, failReason: ActionStopFlag.OperationFailed);
			}
			orCreateCell.SetCellType(result);
			switch (result)
			{
			case CellType.Numeric:
			{
				string s = paramValue.ToString();
				if (double.TryParse(s, out var result2))
				{
					orCreateCell.SetCellValue(result2);
					break;
				}
				if (DateTime.TryParse(s, out var result3))
				{
					orCreateCell.SetCellValue(result3);
					break;
				}
				return (isSuccess: false, message: $"无法将内容{paramValue}转换为数值。", failReason: ActionStopFlag.OperationFailed);
			}
			case CellType.String:
				orCreateCell.SetCellValue(paramValue.ToString());
				break;
			case CellType.Formula:
				orCreateCell.SetCellFormula(paramValue.ToString().TrimStart('='));
				break;
			case CellType.Blank:
				orCreateCell.SetBlank();
				break;
			case CellType.Boolean:
				orCreateCell.SetCellValue(VariableHelper.ConvertToBoolean(paramValue) == true);
				break;
			}
		}
		if (!string.IsNullOrWhiteSpace(textParamValue4))
		{
			eImgGzTdEYW(orCreateCell, textParamValue4, sheet.Workbook);
		}
		if (!string.IsNullOrWhiteSpace(textParamValue3))
		{
			short format = sheet.Workbook.CreateDataFormat().GetFormat(textParamValue3);
			CellUtil.SetCellStyleProperty(orCreateCell, "dataFormat", format);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private void eImgGzTdEYW(ICell icell_0, string string_3, IWorkbook iworkbook_0)
	{
		_003C_003Ec__DisplayClass114_0 _003C_003Ec__DisplayClass114_0_ = default(_003C_003Ec__DisplayClass114_0);
		_003C_003Ec__DisplayClass114_0_.xq6SYRb9nC3 = iworkbook_0;
		IHyperlink hyperlink = null;
		int num;
		if (string_3.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase))
		{
			hyperlink = gKfgs2WISKR(HyperlinkType.Email, ref _003C_003Ec__DisplayClass114_0_);
			num = 0;
			if (BTexqGQmTMHtNepd8RUH())
			{
				goto IL_00de;
			}
			goto IL_0139;
		}
		if (_003C_003Ec__DisplayClass114_0_.xq6SYRb9nC3.GetSheetIndex(string_3) >= 0)
		{
			hyperlink = gKfgs2WISKR(HyperlinkType.Document, ref _003C_003Ec__DisplayClass114_0_);
			hyperlink.Address = "'" + string_3 + "'!A1";
		}
		else if (!string_3.StartsWith("http", StringComparison.OrdinalIgnoreCase) && !Uri.IsWellFormedUriString(string_3, UriKind.Absolute))
		{
			if (string_3.StartsWith("file:", StringComparison.OrdinalIgnoreCase))
			{
				hyperlink = gKfgs2WISKR(HyperlinkType.File, ref _003C_003Ec__DisplayClass114_0_);
				hyperlink.Address = string_3.Substring("file:".Length);
			}
			else
			{
				hyperlink = gKfgs2WISKR(HyperlinkType.Document, ref _003C_003Ec__DisplayClass114_0_);
				hyperlink.Address = string_3;
			}
		}
		else
		{
			hyperlink = gKfgs2WISKR(HyperlinkType.Url, ref _003C_003Ec__DisplayClass114_0_);
			hyperlink.Address = string_3;
		}
		goto IL_00f3;
		IL_0139:
		int num2 = default(int);
		num = num2;
		goto IL_00de;
		IL_00de:
		switch (num)
		{
		case 1:
			return;
		}
		hyperlink.Address = string_3;
		goto IL_00f3;
		IL_00f3:
		icell_0.Hyperlink = hyperlink;
		Dictionary<string, object> properties = new Dictionary<string, object> { 
		{
			"font",
			luxgsws7JB8(_003C_003Ec__DisplayClass114_0_.xq6SYRb9nC3).Index
		} };
		CellUtil.SetCellStyleProperties(icell_0, properties);
		num = 1;
		if (ITMGkDQmwG8BIwhnL7iJ == null)
		{
			goto IL_00de;
		}
		goto IL_0139;
	}

	private IFont luxgsws7JB8(IWorkbook iworkbook_0)
	{
		short numberOfFonts = iworkbook_0.NumberOfFonts;
		for (short num = 0; num <= numberOfFonts; num++)
		{
			try
			{
				IFont fontAt = iworkbook_0.GetFontAt(num);
				if (fontAt.Underline == FontUnderlineType.Single && fontAt.Color == IndexedColors.Blue.Index)
				{
					return fontAt;
				}
			}
			catch
			{
			}
		}
		IFont font = iworkbook_0.CreateFont();
		font.Underline = FontUnderlineType.Single;
		font.Color = IndexedColors.Blue.Index;
		return font;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) KlBgstSoxpi(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(s8PgseJf90s, actionStep_0, actionExecuteContext_0) is ISheet sheet))
		{
			return (isSuccess: false, message: "传入的工作表对象为空。", failReason: ActionStopFlag.OperationFailed);
		}
		int num = (int)XActionHelper.GetIntegerParamValue(ANtgskyCbl5, actionStep_0, actionExecuteContext_0);
		IRow row = sheet.GetRow(num);
		if (row == null)
		{
			return (isSuccess: false, message: $"序号为{num}的行不存在。", failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResult(XZ1gs5LllIF, actionStep_0, actionExecuteContext_0, row.FirstCellNum, xaction_0);
		XActionHelper.OutputResult(g4HgsDdm41i, actionStep_0, actionExecuteContext_0, row.LastCellNum, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) hpOgsgZwxgc(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(zHPgs7UoK42, actionStep_0, actionExecuteContext_0) is IWorkbook workbook))
		{
			return (isSuccess: false, message: "传入的参数不是工作簿对象类型。", failReason: ActionStopFlag.OperationFailed);
		}
		ISheet sheet = null;
		if (!(string_3 == "getSheetByIndex") && !(string_3 == "getSheet"))
		{
			string textParamValue = XActionHelper.GetTextParamValue(DVOgsqwANDg, actionStep_0, actionExecuteContext_0);
			sheet = workbook.GetSheet(textParamValue);
			if (sheet == null && XActionHelper.GetBooleanParamValue(XOCgsci2cdb, actionStep_0, actionExecuteContext_0))
			{
				sheet = workbook.CreateSheet(textParamValue);
			}
		}
		else
		{
			string text = XActionHelper.GetTextParamValue(ybZgsRwIpCa, actionStep_0, actionExecuteContext_0).Trim();
			sheet = xXsgGOV2aHr(workbook, text);
			if (sheet == null)
			{
				return (isSuccess: false, message: "未找到工作表 " + text + " ", failReason: ActionStopFlag.OperationFailed);
			}
		}
		if (sheet == null)
		{
			return (isSuccess: false, message: "未找到工作表", failReason: ActionStopFlag.OperationFailed);
		}
		QP4gsv4DXcu(actionStep_0, actionExecuteContext_0, xaction_0, sheet);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) qgFgsLwrnwL(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		if (!(XActionHelper.GetParamVariableObject(zHPgs7UoK42, actionStep_0, actionExecuteContext_0) is IWorkbook workbook))
		{
			return (isSuccess: false, message: "传入的参数不是工作簿对象类型。", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(DVOgsqwANDg, actionStep_0, actionExecuteContext_0);
		ISheet isheet_ = workbook.CreateSheet(textParamValue);
		QP4gsv4DXcu(actionStep_0, actionExecuteContext_0, xaction_0, isheet_);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static void QP4gsv4DXcu(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, ISheet isheet_0)
	{
		XActionHelper.OutputResult(HolgsQ81GG1, actionStep_0, actionExecuteContext_0, isheet_0, xaction_0);
		XActionHelper.OutputResult(WT8gsjBy30F, actionStep_0, actionExecuteContext_0, isheet_0.FirstRowNum, xaction_0);
		XActionHelper.OutputResult(WElgsnfkv1q, actionStep_0, actionExecuteContext_0, isheet_0.LastRowNum, xaction_0);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) FAggsS9ho8f(string string_3, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass124_0 _003C_003Ec__DisplayClass124_ = new _003C_003Ec__DisplayClass124_0();
		string textParamValue = XActionHelper.GetTextParamValue(w02gs8n5FFT, actionStep_0, actionExecuteContext_0);
		if (!File.Exists(textParamValue))
		{
			return (isSuccess: false, message: "文件" + textParamValue + "不存在。", failReason: ActionStopFlag.OperationFailed);
		}
		actionExecuteContext_0.SetVarValueWithoutConvert("__temp_excel_file_path", textParamValue);
		_003C_003Ec__DisplayClass124_.eZfSYVwmBEp = NPOIHelper.LoadWorkbook(textParamValue);
		XActionHelper.OutputResult(QoOgsriweNY, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass124_.eZfSYVwmBEp, xaction_0);
		XActionHelper.OutputResult(EupgsBcYPCU, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass124_.eZfSYVwmBEp.NumberOfSheets, xaction_0);
		XActionHelper.OutputResultIfNeeded(lJ3gspTXB4I, _003C_003Ec__DisplayClass124_.op7SYqd8qMN, actionStep_0, actionExecuteContext_0, xaction_0);
		QP4gsv4DXcu(actionStep_0, actionExecuteContext_0, xaction_0, _003C_003Ec__DisplayClass124_.eZfSYVwmBEp.GetSheetAt(0));
		XActionHelper.OutputResultIfNeeded(FgDgs49FbUM, _003C_003Ec__DisplayClass124_.hmgSYciHLaH, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		string paramDirectValue = XActionHelper.GetParamDirectValue(nLhgsEXZ60y, step, false);
		string text = "";
		int num = 2;
		char c = default(char);
		while (paramDirectValue != null)
		{
			int num2;
			switch (paramDirectValue.Length)
			{
			case 7:
				c = paramDirectValue[0];
				if (c == 'g')
				{
					goto IL_02e9;
				}
				if (c != 's')
				{
					break;
				}
				if (!(paramDirectValue == "setCell"))
				{
					num2 = 1;
					if (BTexqGQmTMHtNepd8RUH())
					{
						break;
					}
					goto IL_00e2;
				}
				goto IL_02fa;
			case 9:
				if (!(paramDirectValue == "writeData"))
				{
					num2 = 7;
					if (ITMGkDQmwG8BIwhnL7iJ != null)
					{
						goto IL_00de;
					}
					goto IL_00e2;
				}
				text = XActionHelper.GetParamDisplayString(GhmgsVKWUwD, step) + "->" + XActionHelper.GetParamDisplayString(s8PgseJf90s, step);
				break;
			case 10:
				c = paramDirectValue[0];
				if (c != 'a')
				{
					num2 = 3;
					if (!BTexqGQmTMHtNepd8RUH())
					{
						goto IL_00de;
					}
					goto IL_00e2;
				}
				if (!(paramDirectValue == "autoFilter"))
				{
					break;
				}
				goto IL_0351;
			case 4:
				switch (paramDirectValue[0])
				{
				case 's':
					if (paramDirectValue == "save")
					{
						text = XActionHelper.GetParamDisplayString(zHPgs7UoK42, step) + "->" + XActionHelper.GetParamDisplayString(w02gs8n5FFT, step);
					}
					break;
				case 'l':
					if (paramDirectValue == "load")
					{
						text = XActionHelper.GetParamDisplayString(w02gs8n5FFT, step);
					}
					break;
				}
				break;
			case 6:
				if (paramDirectValue == "getRow")
				{
					text = XActionHelper.GetParamDisplayString(ANtgskyCbl5, step);
				}
				break;
			case 8:
				c = paramDirectValue[0];
				if (c != 'g')
				{
					if (c != 'r')
					{
						if (c != 's' || !(paramDirectValue == "setStyle"))
						{
							break;
						}
						goto IL_0351;
					}
					if (paramDirectValue == "readData")
					{
						text = XActionHelper.GetParamDisplayString(zHPgs7UoK42, step) + "->" + XActionHelper.GetParamDisplayString(mkYgsa3c4yI, step);
					}
					break;
				}
				if (paramDirectValue == "getSheet")
				{
					text = XActionHelper.GetParamDisplayString(ybZgsRwIpCa, step);
				}
				break;
			case 11:
				goto IL_0365;
			case 12:
				{
					if (paramDirectValue == "batchReplace")
					{
						text = XActionHelper.GetParamDisplayString(s8PgseJf90s, step) + " " + XActionHelper.GetParamDisplayString(N5Ags67wDZp, step);
					}
					break;
				}
				IL_0365:
				switch (paramDirectValue[0])
				{
				case 'n':
					if (paramDirectValue == "newWorkbook")
					{
						text = XActionHelper.GetParamDisplayString(c8Mgsy0ko7A, step);
					}
					break;
				case 'c':
					if (paramDirectValue == "createSheet")
					{
						text = XActionHelper.GetParamDisplayString(DVOgsqwANDg, step);
					}
					break;
				}
				break;
				IL_00de:
				num2 = num;
				goto IL_00e2;
				IL_0309:
				if (string.IsNullOrEmpty(text))
				{
					text = XActionHelper.GetParamDisplayString(ANtgskyCbl5, step) + "," + XActionHelper.GetParamDisplayString(vU1gsGUY0TE, step);
				}
				break;
				IL_02fa:
				text = XActionHelper.GetParamDisplayString(zdfgsYs9mRu, step);
				goto IL_0309;
				IL_0286:
				if (c != 'f')
				{
					if (c != 'm' || !(paramDirectValue == "mergeCells"))
					{
						break;
					}
					goto IL_0351;
				}
				if (paramDirectValue == "freezePane")
				{
					text = XActionHelper.GetParamDisplayString(ANtgskyCbl5, step) + "," + XActionHelper.GetParamDisplayString(vU1gsGUY0TE, step);
				}
				break;
				IL_0351:
				text = XActionHelper.GetParamDisplayString(IfqgsIIxRAP, step);
				break;
				IL_02e9:
				if (!(paramDirectValue == "getCell"))
				{
					break;
				}
				goto IL_02fa;
				IL_00e2:
				switch (num2)
				{
				case 2:
					break;
				case 3:
					goto IL_0286;
				case 5:
					goto IL_02e9;
				default:
					goto IL_02fa;
				case 4:
					goto IL_0309;
				case 6:
					goto IL_0365;
				case 1:
				case 7:
				case 8:
					goto end_IL_0030;
				}
				continue;
				end_IL_0030:
				break;
			}
			break;
		}
		return "【" + XActionHelper.GetParamDisplayString(nLhgsEXZ60y, step) + "】" + text;
	}

	static XrFhKboffyXFWt56jHS()
	{
		nLhgsEXZ60y = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Type = VarType.Enum,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("load", "打开Workbook"),
				new SelectionItem("newWorkbook", "创建Workbook"),
				new SelectionItem("save", "保存Workbook"),
				new SelectionItem("getSheet", "获取Sheet"),
				new SelectionItem("createSheet", "创建Sheet"),
				new SelectionItem("getRow", "获取行"),
				new SelectionItem("getCellByValue", "查找单元格（根据值）"),
				new SelectionItem("getCell", "读取单元格"),
				new SelectionItem("setCell", "写入单元格"),
				new SelectionItem("writeData", "写入多行数据"),
				new SelectionItem("mergeCells", "合并单元格"),
				new SelectionItem("freezePane", "冻结窗格"),
				new SelectionItem("autoFilter", "自动筛选"),
				new SelectionItem("setStyle", "设置区域单元格样式"),
				new SelectionItem("readData", "批量提取数据"),
				new SelectionItem("batchReplace", "批量模板替换")
			},
			IsControlField = true
		};
		c8Mgsy0ko7A = new StepInParamDef
		{
			Key = "fileType",
			Name = "工作簿类型",
			Type = VarType.Enum,
			DefaultValue = "XSSF",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("XSSF", "XSSF(.xlsx 2007版Excel)"),
				new SelectionItem("HSSF", "HSSF(.xls  2003版Excel)")
			},
			ValidForList = new string[1] { "newWorkbook" },
			VariableMode = ParamVariableMode.Input
		};
		w02gs8n5FFT = new StepInParamDef
		{
			Key = "filePath",
			Name = "文件路径",
			Description = "要打开或写入的Excel文件路径",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFile },
			ValidForList = new string[2] { "load", "save" }
		};
		mkYgsa3c4yI = new StepInParamDef
		{
			Key = "readDataMap",
			Name = "提取数据定义",
			Description = "每行一条规则：“字段:[工作表序号或名称]单元格地址”，详情请参考模块文档。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = true,
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFile },
			ValidForList = new string[1] { "readData" }
		};
		zHPgs7UoK42 = new StepInParamDef
		{
			Key = "workbook",
			Name = "工作簿对象",
			Description = "需要操作的工作簿对象",
			Type = VarType.Object,
			VariableMode = ParamVariableMode.UseVarOnly,
			ValidForList = new string[7] { "getSheetByIndex", "getSheetByName", "getSheet", "createSheet", "save", "readData", "addNames" },
			ObjectType = typeof(IWorkbook)
		};
		ybZgsRwIpCa = new StepInParamDef
		{
			Key = "sheetIndex",
			Name = "工作表序号或名称",
			Description = "以0开始计算的序号或名称",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "getSheetByIndex", "getSheet" }
		};
		DVOgsqwANDg = new StepInParamDef
		{
			Key = "sheetName",
			Name = "工作表名称",
			Description = "要打开的工作表名称",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "getSheetByName", "createSheet" }
		};
		XOCgsci2cdb = new StepInParamDef
		{
			Key = "createSheetIfNotExist",
			Name = "如果工作表不存在则创建一个",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "getSheetByName" }
		};
		GhmgsVKWUwD = new StepInParamDef
		{
			Key = "sourceData",
			Name = "源数据",
			Description = "可以为工作表对象、表格变量或对象列表",
			Type = VarType.Object,
			VariableMode = ParamVariableMode.UseVarOnly,
			ValidForList = new string[1] { "writeData" }
		};
		QP0gsZOkPGe = new StepInParamDef
		{
			Key = "columnMapping",
			Name = "字段映射",
			Description = "复制哪些字段信息到目标工作表。请参考文档了解使用方法。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "writeData" }
		};
		uGrgs9anyer = new StepInParamDef
		{
			Key = "names",
			Name = "名称数据",
			Description = "JSON格式的名称数据定义，详细请参考文档。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "addNames" }
		};
		edDgshB7yhs = new StepInParamDef
		{
			Key = "writeTitleRow",
			Name = "写入标题行",
			Description = "是否输出标题行",
			Type = VarType.Boolean,
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "writeData" }
		};
		s8PgseJf90s = new StepInParamDef
		{
			Key = "worksheet",
			Name = "工作表对象",
			Description = "需要操作或读写的工作表对象",
			Type = VarType.Object,
			VariableMode = ParamVariableMode.UseVarOnly,
			ValidForList = new string[10] { "getRow", "getCell", "batchReplace", "setCell", "writeData", "mergeCells", "setStyle", "freezePane", "autoFilter", "getCellByValue" }
		};
		zdfgsYs9mRu = new StepInParamDef
		{
			Key = "cellAddress",
			Name = "单元格地址",
			Description = "类似于“D5”这样的单元格位置名称。或在下方使用行序号和单元格序号指定（两种二选一）。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "getCell", "setCell" }
		};
		IfqgsIIxRAP = new StepInParamDef
		{
			Key = "cellRange",
			Name = "单元格范围",
			Description = "类似于“A1:B5”格式，或“开始行号,结束行号,开始列号,结束列号”方式(从0开始的序号)。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "mergeCells", "setStyle", "autoFilter" }
		};
		cxagsWBYWwS = new StepInParamDef
		{
			Key = "styleData",
			Name = "样式设置",
			Description = "请参考模块文档。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "setStyle" }
		};
		ANtgskyCbl5 = new StepInParamDef
		{
			Key = "rowIndex",
			Name = "行序号",
			Description = "以0开始计算的序号",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[5] { "getRow", "getCell", "setCell", "writeData", "freezePane" }
		};
		vU1gsGUY0TE = new StepInParamDef
		{
			Key = "cellIndex",
			Name = "列序号",
			Description = "单元格在所在行里的序号，从0开始",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "getCell", "setCell", "freezePane" }
		};
		xOUgssvWeOl = new StepInParamDef
		{
			Key = "cellType",
			Name = "单元格类型",
			Description = "设置单元格类型",
			Type = VarType.Text,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("", "自动（根据值的类型判断）"),
				new SelectionItem(CellType.String.ToString(), "String（文本）"),
				new SelectionItem(CellType.Numeric.ToString(), "Numeric（数字或日期）"),
				new SelectionItem(CellType.Boolean.ToString(), "Boolean（布尔）"),
				new SelectionItem(CellType.Formula.ToString(), "Formula（公式）"),
				new SelectionItem(CellType.Blank.ToString(), "Blank（空白）")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "setCell" }
		};
		kBRgsH89rvX = new StepInParamDef
		{
			Key = "cellValue",
			Name = "值",
			Description = "设置单元格的值",
			Type = VarType.Any,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "setCell", "getCellByValue" }
		};
		FMags1s38AV = new StepInParamDef
		{
			Key = "dataFormat",
			Name = "数据格式",
			Description = "设置单元格的DataFormat",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "setCell" }
		};
		EgKgsbqX8bw = new StepInParamDef
		{
			Key = "cellLink",
			Name = "链接",
			Description = "可以为网址、邮件地址(mailto:who@domain.com)、工作表名称、文件路径",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "setCell" }
		};
		N5Ags67wDZp = new StepInParamDef
		{
			Key = "replaceDict",
			Name = "替换数据词典",
			Description = "词典格式数据。键为要查找的字段，值为要填充的内容。",
			Type = VarType.Dict,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[1] { "batchReplace" }
		};
		VkmgsX6DE7C = new StepInParamDef
		{
			Key = "replacePrefixSuffix",
			Name = "占位符前后缀",
			DefaultValue = "{{\r\n}}",
			Description = "第一行写前缀，第二行写后缀。“前缀+字段名+后缀”组成要查找和替换的目标，如“{{姓名}}”。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[1] { "batchReplace" }
		};
		uSSgsm4VZbv = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		dc9gsxNN33P = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		QoOgsriweNY = new StepOutParamDef
		{
			Key = "workbook",
			Name = "工作簿对象",
			Description = "用于在后续步骤中继续操作工作簿。",
			Type = VarType.Object,
			ValidForList = new string[2] { "load", "newWorkbook" },
			CustomTypeName = typeof(IWorkbook).FullName
		};
		lJ3gspTXB4I = new StepOutParamDef
		{
			Key = "worksheetNameList",
			Name = "工作表名称列表",
			Description = "工作簿中的工作表名列表。",
			Type = VarType.List,
			ValidForList = new string[1] { "load" }
		};
		EupgsBcYPCU = new StepOutParamDef
		{
			Key = "numberOfSheets",
			Name = "工作表个数",
			Description = "工作簿中的工作表个数。",
			Type = VarType.Integer,
			ValidForList = new string[1] { "load" }
		};
		HolgsQ81GG1 = new StepOutParamDef
		{
			Key = "sheet",
			Name = "工作表对象",
			Description = "返回指定的工作表。加载文件时返回工作簿中的第一个工作表对象",
			Type = VarType.Object,
			ValidForList = new string[5] { "load", "getSheetByIndex", "getSheetByName", "getSheet", "createSheet" },
			CustomTypeName = typeof(ISheet).FullName
		};
		WT8gsjBy30F = new StepOutParamDef
		{
			Key = "firstRow",
			Name = "首行序号",
			Description = "工作表首行序号。",
			Type = VarType.Integer,
			ValidForList = new string[5] { "load", "getSheetByIndex", "getSheetByName", "getSheet", "getCellByValue" }
		};
		WElgsnfkv1q = new StepOutParamDef
		{
			Key = "lastRow",
			Name = "末行序号",
			Description = "工作表有内容的最后一行序号。",
			Type = VarType.Integer,
			ValidForList = new string[4] { "load", "getSheetByIndex", "getSheetByName", "getSheet" }
		};
		FgDgs49FbUM = new StepOutParamDef
		{
			Key = "names",
			Name = "名称数据",
			Description = "工作簿中定义的名称数据，返回json格式",
			Type = VarType.Text,
			ValidForList = new string[1] { "load" }
		};
		XZ1gs5LllIF = new StepOutParamDef
		{
			Key = "firstCellNum",
			Name = "首个单元格序号",
			Description = "一行的首列序号。",
			Type = VarType.Integer,
			ValidForList = new string[2] { "getRow", "getCellByValue" }
		};
		g4HgsDdm41i = new StepOutParamDef
		{
			Key = "lastCellNum",
			Name = "末个单元格序号",
			Description = "一行的最后一个单元格的序号。",
			Type = VarType.Integer,
			ValidForList = new string[1] { "getRow" }
		};
		dFxgsdShoSa = new StepOutParamDef
		{
			Key = "hasValue",
			Name = "是否有值",
			Description = "单元格是否有值",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "getCell" }
		};
		v7pgsoYGTa4 = new StepOutParamDef
		{
			Key = "cellValue",
			Name = "值",
			Description = "单元格的值",
			Type = VarType.Any,
			ValidForList = new string[1] { "getCell" }
		};
		mavgsTZhCQH = new StepOutParamDef
		{
			Key = "cellTextValue",
			Name = "文本值",
			Description = "文本格式的单元格内容",
			Type = VarType.Text,
			ValidForList = new string[1] { "getCell" }
		};
		dy1gsMg9WHQ = new StepOutParamDef
		{
			Key = "cellType",
			Name = "类型",
			Description = "单元格的类型",
			Type = VarType.Text,
			ValidForList = new string[1] { "getCell" }
		};
		QQlgsAnkwaT = new StepOutParamDef
		{
			Key = "cellFormula",
			Name = "公式",
			Description = "单元格的公式值",
			Type = VarType.Text,
			ValidForList = new string[1] { "getCell" }
		};
		aJLgsOYYPL2 = new StepOutParamDef
		{
			Key = "dictData",
			Name = "数据词典",
			Description = "从工作簿加载的数据",
			Type = VarType.Dict,
			ValidForList = new string[1] { "readData" }
		};
		sYigsFsS2ZE = new StepOutParamDef
		{
			Key = "cellDataFormatString",
			Name = "数据格式字符串",
			Description = "数据格式的字符串表示",
			Type = VarType.Text,
			ValidForList = new string[1] { "getCell" }
		};
		oMXgsU4Mqyb = new StepOutParamDef
		{
			Key = "cellAddress",
			Name = "单元格地址",
			Description = "查找到的单元格地址",
			Type = VarType.Object,
			ValidForList = new string[1] { "getCellByValue" }
		};
	}

	[CompilerGenerated]
	internal static IHyperlink gKfgs2WISKR(HyperlinkType hyperlinkType_0, ref _003C_003Ec__DisplayClass114_0 _003C_003Ec__DisplayClass114_0_0)
	{
		if (!(_003C_003Ec__DisplayClass114_0_0.xq6SYRb9nC3 is XSSFWorkbook) && !(_003C_003Ec__DisplayClass114_0_0.xq6SYRb9nC3 is SXSSFWorkbook))
		{
			return new HSSFHyperlink(hyperlinkType_0);
		}
		return new XSSFHyperlink(hyperlinkType_0);
	}

	internal static bool BTexqGQmTMHtNepd8RUH()
	{
		return ITMGkDQmwG8BIwhnL7iJ == null;
	}
}
