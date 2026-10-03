using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FontAwesome5;
using log4net;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Office;

public class ExcelObjectOperationsStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass52_0
	{
		public ActionStep ATFSNjVW3yH;

		public ActionExecuteContext v4FSNnHqaOl;

		public ExcelObjectOperationsStep qOYSN4RLWC8;

		public XAction QjvSN5lshTE;

		internal static _003C_003Ec__DisplayClass52_0 Tkq8eZWveothkHEyOdUQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) EdASNQjcdl4()
		{
			switch (XActionHelper.GetTextParamValue(_operationParam, ATFSNjVW3yH, v4FSNnHqaOl))
			{
			case "SelectWorksheet":
				qOYSN4RLWC8.SelectWorksheet(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			case "CreateWorkbook":
				qOYSN4RLWC8.CreateWorkbook(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			case "CloseWorkbook":
				qOYSN4RLWC8.CloseWorkbook(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			case "SaveWorkbook":
				qOYSN4RLWC8.cUWgNsJaBUW(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			case "OpenFile":
				qOYSN4RLWC8.OpenFile(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			case "ApplicationInfo":
				qOYSN4RLWC8.jqBgNbn0JiL(v4FSNnHqaOl, ATFSNjVW3yH, QjvSN5lshTE);
				break;
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool m0LSCcWvjv3A3Fuklr59()
		{
			return Tkq8eZWveothkHEyOdUQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public Workbook c8bSNoeKWKx;

		public Action<string> bsTSNT76d56;

		public Action<string> tQPSNMt8Wp1;

		private static _003C_003Ec__DisplayClass54_0 yeDdtQWv3RNRsaG5QFgv;

		internal void MagSNDP5e3a(string s)
		{
			int num = Convert.ToInt32(s);
			if (_003C_003Eo__54.fuXSJrrG7u7 == null)
			{
				_003C_003Eo__54.fuXSJrrG7u7 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Activate", null, typeof(global::Quicker.Domain.Actions.X.BuiltinRunners.Office.ExcelObjectOperationsStep), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
			}
			_003C_003Eo__54.fuXSJrrG7u7.Target(_003C_003Eo__54.fuXSJrrG7u7, c8bSNoeKWKx.Sheets[num]);
		}

		internal void hr3SNdETiln(string s)
		{
			((dynamic)c8bSNoeKWKx.Sheets[s]).Activate();
		}

		static _003C_003Ec__DisplayClass54_0()
		{
		}

		internal static bool WcNeSOWvEJDHSn7PaQpJ()
		{
			return yeDdtQWv3RNRsaG5QFgv == null;
		}

		internal static void mjBe1YWvKeFyuSfT88N9()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public List<string> E9tSNi8d15k;

		public Application dNDSN3tVZZI;

		public Workbook ywTSNfZv5Wt;

		public Action<string> W7xSNzXlgWE;

		private static _003C_003Ec__DisplayClass55_0 LYdRmjWvBxF7sKwwAW9h;

		internal void VD6SNALeSte(string s)
		{
			E9tSNi8d15k.Add(s);
		}

		internal object SWESNO2UH9H()
		{
			return dNDSN3tVZZI;
		}

		internal object oMSSNFwtFSs()
		{
			return ywTSNfZv5Wt;
		}

		internal object uROSNUHaTxS()
		{
			return ywTSNfZv5Wt.ActiveSheet;
		}

		internal object FvrSNlfoFpW()
		{
			return ywTSNfZv5Wt.Worksheets;
		}

		internal static bool QXCkYHWvvESVd6QGFMm3()
		{
			return LYdRmjWvBxF7sKwwAW9h == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public bool vT9SJSiaRvs;

		public bool VdASJ29IHZY;

		public bool y0oSJudC1L7;

		public string dkpSJNdQWmw;

		public object XciSJJVvEFm;

		public Action<string> gqxSJ0O6t55;

		public Action<string> dvJSJCGeBNX;

		public Action<string> s7MSJPEafpE;

		public Action<string> zFVSJEMy5Nt;

		public Action<string> mwDSJyp7uwW;

		internal static _003C_003Ec__DisplayClass56_0 EYqKgiWvOwZE9YotF4Lv;

		internal void yPGSJwSyI95(string s)
		{
			vT9SJSiaRvs = VariableHelper.StringToBool(s);
		}

		internal void dQ4SJt115OR(string s)
		{
			VdASJ29IHZY = VariableHelper.StringToBool(s);
		}

		internal void ebVSJg5CpxZ(string s)
		{
			y0oSJudC1L7 = VariableHelper.StringToBool(s);
		}

		internal void mOPSJLpKfVw(string s)
		{
			dkpSJNdQWmw = s;
		}

		internal void UbJSJvDOvSt(string s)
		{
			XciSJJVvEFm = AppHelper.ParseEnum<XlFileFormat>(s);
		}

		internal static bool BgvtguWvJ2nUbe89saOE()
		{
			return EYqKgiWvOwZE9YotF4Lv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public Application RfcSJh56HqQ;

		public string wxcSJe4wjWY;

		public object uwqSJYZSSw1;

		public object FjmSJIZclct;

		public Workbook YFPSJWNNO6V;

		public Action<string> HqsSJkgoYe7;

		public Action<string> PaISJGNGAbI;

		public Action<string> HFYSJsoa5Kx;

		public Action<string> YLpSJHLDhY8;

		internal static _003C_003Ec__DisplayClass58_0 JI8BlVWvakabpHdaTQ3d;

		internal void Yt0SJ8eDtXB(string s)
		{
			RfcSJh56HqQ.Visible = VariableHelper.StringToBool(s);
		}

		internal void rDjSJagKBcB(string s)
		{
			wxcSJe4wjWY = s;
		}

		internal void WoOSJ7UtyBY(string s)
		{
			uwqSJYZSSw1 = VariableHelper.StringToBool(s);
		}

		internal void os8SJRy21O1(string s)
		{
			FjmSJIZclct = Convert.ToInt32(s);
		}

		internal object C4hSJqDo0Ws()
		{
			return RfcSJh56HqQ;
		}

		internal object dmXSJcbIQhM()
		{
			return YFPSJWNNO6V;
		}

		internal object GmnSJVWR4of()
		{
			return YFPSJWNNO6V.ActiveSheet;
		}

		internal object t3gSJZFptHf()
		{
			return YFPSJWNNO6V.Worksheets;
		}

		internal object aflSJ9b4oZe()
		{
			List<string> list = new List<string>();
			foreach (Worksheet worksheet in YFPSJWNNO6V.Worksheets)
			{
				list.Add(worksheet.Name);
			}
			return list;
		}

		internal static bool SZMWCkWvrwdqG2cJxTTY()
		{
			return JI8BlVWvakabpHdaTQ3d == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_0
	{
		public Application isTSJxkwkKN;

		private static _003C_003Ec__DisplayClass60_0 vZ9BfQWv9F46JbfYnQvl;

		internal object tAdSJ1F1rlF()
		{
			return isTSJxkwkKN;
		}

		internal object uhkSJbgAGLk()
		{
			return isTSJxkwkKN.ActiveWorkbook;
		}

		internal object hdhSJ6MROhQ()
		{
			return isTSJxkwkKN.ActiveSheet;
		}

		internal object OJKSJXSLKcB()
		{
			List<string> list = new List<string>();
			foreach (Worksheet worksheet in isTSJxkwkKN.Worksheets)
			{
				list.Add(worksheet.Name);
			}
			return list;
		}

		internal object qfiSJmYCW8q()
		{
			return isTSJxkwkKN.Worksheets;
		}

		internal object xHaSJKIMMxR()
		{
			return isTSJxkwkKN.ActiveWorkbook.FullName;
		}

		internal static bool MDepjFWvLH49niiQSfAE()
		{
			return vZ9BfQWv9F46JbfYnQvl == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__54
	{
		public static CallSite<Action<CallSite, object>> fuXSJrrG7u7;

		public static CallSite<Action<CallSite, object>> prlSJproEDt;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__55
	{
		public static CallSite<Func<CallSite, Sheets, object, object>> rmqSJBUZWT4;

		public static CallSite<Func<CallSite, object, Worksheet>> XTvSJQgAg1p;

		public static CallSite<Action<CallSite, object>> D8SSJjjlNhC;

		public static CallSite<Action<CallSite, object>> uc5SJnikYJk;

		static _003C_003Eo__55()
		{
		}

		internal static void bcP8ewWvZ3jbaqsOOShA()
		{
		}
	}

	private static readonly ILog lAAgN6ZBxOM;

	[CompilerGenerated]
	private readonly IEnumerable<string> FkagNXpkI6h = new List<string> { "office" };

	[CompilerGenerated]
	private readonly string g2SgNmQk35g = $"fa:{EFontAwesomeIcon.Light_Table}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory WoigNKlZff5 = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> A51gNxlpfEG;

	[CompilerGenerated]
	private readonly string jXBgNrer4LO = "https://getquicker.net/KC/Help/Doc/excelobjects";

	public static StepInParamDef _operationParam;

	private static readonly StepInParamDef miygNphVWUI;

	private static readonly StepInParamDef SNggNBG1J2J;

	private static readonly StepInParamDef D45gNQMBR8b;

	private static readonly StepInParamDef f0agNj6vpX2;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> OODgNnpBtNJ = new List<StepInParamDef> { _operationParam, D45gNQMBR8b, miygNphVWUI, SNggNBG1J2J, f0agNj6vpX2 };

	public static StepOutParamDef _applicationObjOutputParam;

	public static StepOutParamDef _activeWorkbookOutputParam;

	public static StepOutParamDef _activeWorksheetOutputParam;

	public static StepOutParamDef _worksheetsOutputParam;

	public static StepOutParamDef _worksheetNamesOutputParam;

	public static StepOutParamDef _workbookPath;

	private static readonly StepOutParamDef iLCgN4m11sG;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> YrMgN5mxoCo = new List<StepOutParamDef> { iLCgN4m11sG, _activeWorkbookOutputParam, _activeWorksheetOutputParam, _worksheetNamesOutputParam, _worksheetsOutputParam, _workbookPath, _applicationObjOutputParam };

	internal static ExcelObjectOperationsStep s90F5VQMXC9LAX2LBt2T;

	public string Key => "sys:excelObjects";

	public string Name => "Excel对象操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return FkagNXpkI6h;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return g2SgNmQk35g;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return WoigNKlZff5;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return A51gNxlpfEG;
		}
	}

	public string Description => "操作Excel的某个对象";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return jXBgNrer4LO;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return OODgNnpBtNJ;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return YrMgN5mxoCo;
		}
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
		_003C_003Ec__DisplayClass52_.ATFSNjVW3yH = step;
		_003C_003Ec__DisplayClass52_.v4FSNnHqaOl = context;
		_003C_003Ec__DisplayClass52_.qOYSN4RLWC8 = this;
		_003C_003Ec__DisplayClass52_.QjvSN5lshTE = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass52_.v4FSNnHqaOl, _003C_003Ec__DisplayClass52_.ATFSNjVW3yH, _003C_003Ec__DisplayClass52_.QjvSN5lshTE, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass52_.EdASNQjcdl4, (Action)null, (Action)null, f0agNj6vpX2, iLCgN4m11sG);
	}

	private void CloseWorkbook(ActionExecuteContext context, ActionStep step, XAction action)
	{
		Workbook obj = o7AgNHtq3Fp(context, step) ?? throw new InvalidDataException("没有可操作的工作簿");
		Application application = obj.Application;
		obj.Close(Type.Missing, Type.Missing, Type.Missing);
		Marshal.ReleaseComObject(obj);
		if (application.Workbooks.Count == 0)
		{
			application.Quit();
			Marshal.ReleaseComObject(application);
		}
	}

	private void SelectWorksheet(ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.c8bSNoeKWKx = o7AgNHtq3Fp(context, step);
		string[] optionsLines = XActionHelper.GetOptionsLines(SNggNBG1J2J, step, context);
		if (optionsLines.Length < 1)
		{
			throw new InvalidDataException("请在参数中通过index=序号或name=工作表名设定要选择的工作表。");
		}
		string[] array = optionsLines;
		foreach (string line in array)
		{
			AppHelper.IfMatchThen(line, "index=", _003C_003Ec__DisplayClass54_.bsTSNT76d56 ?? (_003C_003Ec__DisplayClass54_.bsTSNT76d56 = _003C_003Ec__DisplayClass54_.MagSNDP5e3a));
			AppHelper.IfMatchThen(line, "name=", _003C_003Ec__DisplayClass54_.tQPSNMt8Wp1 ?? (_003C_003Ec__DisplayClass54_.tQPSNMt8Wp1 = _003C_003Ec__DisplayClass54_.hr3SNdETiln));
		}
	}

	private void CreateWorkbook(ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.dNDSN3tVZZI = m0igN1nE4VA();
		_003C_003Ec__DisplayClass55_.dNDSN3tVZZI.Visible = true;
		string textParamValue = XActionHelper.GetTextParamValue(D45gNQMBR8b, step, context);
		object obj = Type.Missing;
		int num;
		if (!string.IsNullOrWhiteSpace(textParamValue))
		{
			if (textParamValue.StartsWith("xl", StringComparison.OrdinalIgnoreCase))
			{
				obj = AppHelper.ParseEnum<XlWBATemplate>(textParamValue);
				num = 1;
				if (s90F5VQMXC9LAX2LBt2T == null)
				{
					goto IL_02e1;
				}
				goto IL_0335;
			}
			obj = textParamValue;
		}
		goto IL_033b;
		IL_02e1:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_033b;
		default:
			XActionHelper.OutputResultIfNeeded(_activeWorksheetOutputParam, _003C_003Ec__DisplayClass55_.uROSNUHaTxS, step, context, action);
			XActionHelper.OutputResultIfNeeded(_worksheetsOutputParam, _003C_003Ec__DisplayClass55_.FvrSNlfoFpW, step, context, action);
			return;
		}
		goto IL_02f4;
		IL_02f4:
		XActionHelper.OutputResultIfNeeded(_applicationObjOutputParam, _003C_003Ec__DisplayClass55_.SWESNO2UH9H, step, context, action);
		XActionHelper.OutputResultIfNeeded(_activeWorkbookOutputParam, _003C_003Ec__DisplayClass55_.oMSSNFwtFSs, step, context, action);
		num = 0;
		if (s90F5VQMXC9LAX2LBt2T == null)
		{
			goto IL_02e1;
		}
		goto IL_0335;
		IL_033b:
		string[] optionsLines = XActionHelper.GetOptionsLines(SNggNBG1J2J, step, context);
		_003C_003Ec__DisplayClass55_.E9tSNi8d15k = new List<string>();
		string[] array = optionsLines;
		for (int i = 0; i < array.Length; i++)
		{
			AppHelper.IfMatchThen(array[i], "+:", _003C_003Ec__DisplayClass55_.W7xSNzXlgWE ?? (_003C_003Ec__DisplayClass55_.W7xSNzXlgWE = _003C_003Ec__DisplayClass55_.VD6SNALeSte));
		}
		_003C_003Ec__DisplayClass55_.ywTSNfZv5Wt = _003C_003Ec__DisplayClass55_.dNDSN3tVZZI.Workbooks.Add(obj);
		if (obj != Type.Missing || _003C_003Ec__DisplayClass55_.E9tSNi8d15k.Count <= 0)
		{
			goto IL_02f4;
		}
		foreach (string item in _003C_003Ec__DisplayClass55_.E9tSNi8d15k)
		{
			dynamic val = _003C_003Ec__DisplayClass55_.ywTSNfZv5Wt.Sheets[_003C_003Ec__DisplayClass55_.ywTSNfZv5Wt.Sheets.Count];
			((Worksheet)_003C_003Ec__DisplayClass55_.ywTSNfZv5Wt.Sheets.Add(After: val)).Name = item;
		}
		((dynamic)_003C_003Ec__DisplayClass55_.ywTSNfZv5Wt.Sheets[1]).Delete();
		((dynamic)_003C_003Ec__DisplayClass55_.ywTSNfZv5Wt.Sheets[1]).Select();
		num = 2;
		if (s90F5VQMXC9LAX2LBt2T == null)
		{
			goto IL_02e1;
		}
		goto IL_0335;
		IL_0335:
		int num2 = default(int);
		num = num2;
		goto IL_02e1;
	}

	private void cUWgNsJaBUW(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		Workbook workbook = o7AgNHtq3Fp(actionExecuteContext_0, actionStep_0);
		string textParamValue = XActionHelper.GetTextParamValue(D45gNQMBR8b, actionStep_0, actionExecuteContext_0);
		string[] optionsLines = XActionHelper.GetOptionsLines(SNggNBG1J2J, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass56_.vT9SJSiaRvs = false;
		_003C_003Ec__DisplayClass56_.VdASJ29IHZY = false;
		_003C_003Ec__DisplayClass56_.y0oSJudC1L7 = false;
		_003C_003Ec__DisplayClass56_.dkpSJNdQWmw = "";
		_003C_003Ec__DisplayClass56_.XciSJJVvEFm = Type.Missing;
		string[] array = optionsLines;
		foreach (string line in array)
		{
			AppHelper.IfMatchThen(line, "SaveCopy=", _003C_003Ec__DisplayClass56_.gqxSJ0O6t55 ?? (_003C_003Ec__DisplayClass56_.gqxSJ0O6t55 = _003C_003Ec__DisplayClass56_.yPGSJwSyI95));
			AppHelper.IfMatchThen(line, "CloseWorkbook=", _003C_003Ec__DisplayClass56_.dvJSJCGeBNX ?? (_003C_003Ec__DisplayClass56_.dvJSJCGeBNX = _003C_003Ec__DisplayClass56_.dQ4SJt115OR));
			AppHelper.IfMatchThen(line, "CloseApplication=", _003C_003Ec__DisplayClass56_.s7MSJPEafpE ?? (_003C_003Ec__DisplayClass56_.s7MSJPEafpE = _003C_003Ec__DisplayClass56_.ebVSJg5CpxZ));
			AppHelper.IfMatchThen(line, "Password=", _003C_003Ec__DisplayClass56_.zFVSJEMy5Nt ?? (_003C_003Ec__DisplayClass56_.zFVSJEMy5Nt = _003C_003Ec__DisplayClass56_.mOPSJLpKfVw));
			AppHelper.IfMatchThen(line, "FileFormat=", _003C_003Ec__DisplayClass56_.mwDSJyp7uwW ?? (_003C_003Ec__DisplayClass56_.mwDSJyp7uwW = _003C_003Ec__DisplayClass56_.UbJSJvDOvSt));
		}
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			workbook.Save();
			goto IL_01d7;
		}
		goto IL_020b;
		IL_020b:
		if (!_003C_003Ec__DisplayClass56_.vT9SJSiaRvs)
		{
			object password = (string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_.dkpSJNdQWmw) ? Type.Missing : _003C_003Ec__DisplayClass56_.dkpSJNdQWmw);
			workbook.SaveAs(textParamValue, _003C_003Ec__DisplayClass56_.XciSJJVvEFm, password, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}
		else
		{
			workbook.SaveCopyAs(textParamValue);
		}
		goto IL_01d7;
		IL_01d7:
		Application application = workbook.Application;
		int num = 1;
		if (!EW7ec9QM2XEn8wTUgqS9())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			if (_003C_003Ec__DisplayClass56_.VdASJ29IHZY)
			{
				workbook.Close(Type.Missing, Type.Missing, Type.Missing);
				Marshal.ReleaseComObject(workbook);
			}
			if (_003C_003Ec__DisplayClass56_.y0oSJudC1L7)
			{
				application.Quit();
				Marshal.ReleaseComObject(application);
			}
			return;
		}
		goto IL_020b;
	}

	private static Workbook o7AgNHtq3Fp(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		object paramValue = XActionHelper.GetParamValue(miygNphVWUI, actionStep_0, actionExecuteContext_0);
		Workbook workbook;
		if (paramValue == null)
		{
			workbook = ExcelHelper.GetActiveWorkbook();
		}
		else
		{
			string text = paramValue as string;
			if (s90F5VQMXC9LAX2LBt2T == null)
			{
				switch (0)
				{
				}
			}
			workbook = ((text == null) ? (paramValue as Workbook) : ExcelHelper.GetWorkbookByName(text));
		}
		if (workbook == null)
		{
			throw new InvalidOperationException("未找到要操作的工作簿对象。");
		}
		return workbook;
	}

	private void OpenFile(ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
		string textParamValue = XActionHelper.GetTextParamValue(D45gNQMBR8b, step, context);
		if (!System.IO.File.Exists(textParamValue))
		{
			throw new InvalidOperationException("文件不存在：" + textParamValue);
		}
		string[] optionsLines = XActionHelper.GetOptionsLines(SNggNBG1J2J, step, context);
		_003C_003Ec__DisplayClass58_.RfcSJh56HqQ = m0igN1nE4VA();
		_003C_003Ec__DisplayClass58_.RfcSJh56HqQ.Visible = true;
		_003C_003Ec__DisplayClass58_.wxcSJe4wjWY = (string)Type.Missing;
		_003C_003Ec__DisplayClass58_.uwqSJYZSSw1 = Type.Missing;
		_003C_003Ec__DisplayClass58_.FjmSJIZclct = Type.Missing;
		string[] array = optionsLines;
		foreach (string line in array)
		{
			AppHelper.IfMatchThen(line, "Visible=", _003C_003Ec__DisplayClass58_.HqsSJkgoYe7 ?? (_003C_003Ec__DisplayClass58_.HqsSJkgoYe7 = _003C_003Ec__DisplayClass58_.Yt0SJ8eDtXB));
			AppHelper.IfMatchThen(line, "Password=", _003C_003Ec__DisplayClass58_.PaISJGNGAbI ?? (_003C_003Ec__DisplayClass58_.PaISJGNGAbI = _003C_003Ec__DisplayClass58_.rDjSJagKBcB));
			AppHelper.IfMatchThen(line, "Readonly=", _003C_003Ec__DisplayClass58_.HFYSJsoa5Kx ?? (_003C_003Ec__DisplayClass58_.HFYSJsoa5Kx = _003C_003Ec__DisplayClass58_.WoOSJ7UtyBY));
			AppHelper.IfMatchThen(line, "Format=", _003C_003Ec__DisplayClass58_.YLpSJHLDhY8 ?? (_003C_003Ec__DisplayClass58_.YLpSJHLDhY8 = _003C_003Ec__DisplayClass58_.os8SJRy21O1));
		}
		Workbooks workbooks = _003C_003Ec__DisplayClass58_.RfcSJh56HqQ.Workbooks;
		object password = _003C_003Ec__DisplayClass58_.wxcSJe4wjWY;
		object readOnly = _003C_003Ec__DisplayClass58_.uwqSJYZSSw1;
		object format = _003C_003Ec__DisplayClass58_.FjmSJIZclct;
		_003C_003Ec__DisplayClass58_.YFPSJWNNO6V = workbooks.Open(textParamValue, Type.Missing, readOnly, format, password, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		XActionHelper.OutputResultIfNeeded(_applicationObjOutputParam, _003C_003Ec__DisplayClass58_.C4hSJqDo0Ws, step, context, action);
		XActionHelper.OutputResultIfNeeded(_activeWorkbookOutputParam, _003C_003Ec__DisplayClass58_.dmXSJcbIQhM, step, context, action);
		XActionHelper.OutputResultIfNeeded(_activeWorksheetOutputParam, _003C_003Ec__DisplayClass58_.GmnSJVWR4of, step, context, action);
		XActionHelper.OutputResultIfNeeded(_worksheetsOutputParam, _003C_003Ec__DisplayClass58_.t3gSJZFptHf, step, context, action);
		int num = 0;
		if (!EW7ec9QM2XEn8wTUgqS9())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		XActionHelper.OutputResultIfNeeded(_worksheetNamesOutputParam, _003C_003Ec__DisplayClass58_.aflSJ9b4oZe, step, context, action);
	}

	private Application m0igN1nE4VA()
	{
		Application application = null;
		try
		{
			application = (Application)Marshal.GetActiveObject("Excel.Application");
		}
		catch (Exception exception)
		{
			lAAgN6ZBxOM.Warn("获取运行中的Excel失败：" + exception.GetMessageWithInner(), exception);
		}
		if (application == null)
		{
			application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		}
		return application;
	}

	private void jqBgNbn0JiL(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
		_003C_003Ec__DisplayClass60_.isTSJxkwkKN = (Application)Marshal.GetActiveObject("Excel.Application");
		if (_003C_003Ec__DisplayClass60_.isTSJxkwkKN != null)
		{
			XActionHelper.OutputResultIfNeeded(_applicationObjOutputParam, _003C_003Ec__DisplayClass60_.tAdSJ1F1rlF, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(_activeWorkbookOutputParam, _003C_003Ec__DisplayClass60_.uhkSJbgAGLk, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(_activeWorksheetOutputParam, _003C_003Ec__DisplayClass60_.hdhSJ6MROhQ, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(_worksheetNamesOutputParam, _003C_003Ec__DisplayClass60_.OJKSJXSLKcB, actionStep_0, actionExecuteContext_0, xaction_0);
			if (EW7ec9QM2XEn8wTUgqS9())
			{
				switch (0)
				{
				}
			}
			XActionHelper.OutputResultIfNeeded(_worksheetsOutputParam, _003C_003Ec__DisplayClass60_.qfiSJmYCW8q, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(_workbookPath, _003C_003Ec__DisplayClass60_.xHaSJKIMMxR, actionStep_0, actionExecuteContext_0, xaction_0);
			return;
		}
		throw new InvalidDataException("无法获得当前Excel应用程序对象。");
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(_operationParam, step) ?? "";
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	static ExcelObjectOperationsStep()
	{
		lAAgN6ZBxOM = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		_operationParam = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("ApplicationInfo", "获取当前Excel应用信息"),
				new SelectionItem("OpenFile", "工作簿: 打开工作簿"),
				new SelectionItem("SaveWorkbook", "工作簿: 保存工作簿"),
				new SelectionItem("CloseWorkbook", "工作簿: 关闭工作簿"),
				new SelectionItem("CreateWorkbook", "工作簿: 创建工作簿"),
				new SelectionItem("SelectWorksheet", "工作表：选择工作表")
			},
			IsControlField = true
		};
		miygNphVWUI = new StepInParamDef
		{
			Key = "workbook",
			Name = "工作簿对象",
			DefaultValue = "",
			IsMultiLine = false,
			Description = "根据具体操作，可用参数不同。请参考文档。",
			Type = VarType.Object,
			ValidForList = new List<string> { "SaveWorkbook", "CloseWorkbook", "SelectWorksheet" }
		};
		SNggNBG1J2J = new StepInParamDef
		{
			Key = "params",
			Name = "参数",
			DefaultValue = "",
			IsMultiLine = true,
			Description = "根据具体操作，可用参数不同。请参考文档。",
			Type = VarType.Text
		};
		D45gNQMBR8b = new StepInParamDef
		{
			Key = "path",
			Name = "文件/模板路径",
			DefaultValue = "",
			IsMultiLine = false,
			Description = "完整路径。创建工作簿时，用于指定模板文件。",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenFile", "SaveWorkbook", "CreateWorkbook" }
		};
		f0agNj6vpX2 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		_applicationObjOutputParam = new StepOutParamDef
		{
			Key = "application",
			Name = "Application对象",
			Description = "Application对象的引用",
			Type = VarType.Object,
			ValidForList = new List<string> { "ApplicationInfo", "OpenFile", "CreateWorkbook" }
		};
		_activeWorkbookOutputParam = new StepOutParamDef
		{
			Key = "activeWorkbook",
			Name = "活动工作簿",
			Description = "ActiveWorkbook",
			Type = VarType.Object,
			ValidForList = new List<string> { "ApplicationInfo", "OpenFile", "CreateWorkbook" }
		};
		_activeWorksheetOutputParam = new StepOutParamDef
		{
			Key = "activeSheet",
			Name = "活动工作表",
			Description = "ActiveSheet",
			Type = VarType.Object,
			ValidForList = new List<string> { "ApplicationInfo", "OpenFile", "CreateWorkbook" }
		};
		_worksheetsOutputParam = new StepOutParamDef
		{
			Key = "worksheets",
			Name = "工作表对象列表",
			Description = "Worksheets",
			Type = VarType.Object,
			ValidForList = new List<string> { "ApplicationInfo", "OpenFile", "CreateWorkbook" }
		};
		_worksheetNamesOutputParam = new StepOutParamDef
		{
			Key = "worksheetNames",
			Name = "工作表名称的列表",
			Description = "Worksheets",
			Type = VarType.List,
			ValidForList = new List<string> { "ApplicationInfo", "OpenFile" }
		};
		_workbookPath = new StepOutParamDef
		{
			Key = "workbookPath",
			Name = "工作簿路径",
			Description = "Worksheets",
			Type = VarType.Text,
			ValidForList = new List<string> { "ApplicationInfo" }
		};
		iLCgN4m11sG = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool EW7ec9QM2XEn8wTUgqS9()
	{
		return s90F5VQMXC9LAX2LBt2T == null;
	}
}
