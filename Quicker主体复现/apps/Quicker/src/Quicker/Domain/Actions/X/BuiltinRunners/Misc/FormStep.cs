using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using GuvA3OiyFyyWpKJlb8c;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Forms;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using Quicker.View.Forms;
using SCyJThYoNMQE7IHLXbA;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class FormStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public ActionStep lfFS7tbh1G6;

		public ActionExecuteContext SUBS7gScNuo;

		public FormStep dMNS7LXJYO6;

		public XAction s4YS7vb9Iv6;

		internal static _003C_003Ec__DisplayClass62_0 kFkeJqWJmEq8G1uU7PdA;

		internal (bool isSuccess, string message, ActionStopFlag failReason) RgsS7wji5Eh()
		{
			_003C_003Ec__DisplayClass62_1 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_1
			{
				sbkS7Wmup1O = this,
				upNS7CPTTmI = XActionHelper.GetTextParamValue(qeRgEtII4kk, lfFS7tbh1G6, SUBS7gScNuo),
				nNXS7JSLr7w = SUBS7gScNuo
			};
			IDictionary<string, object> dictionary = null;
			_003C_003Ec__DisplayClass62_.NiQS7NThV8o = null;
			if (_003C_003Ec__DisplayClass62_.upNS7CPTTmI.IsEither("dict", "dict_dynamic"))
			{
				dictionary = XActionHelper.GetParamVariableObject(njdgEgpc3iO, lfFS7tbh1G6, SUBS7gScNuo) as IDictionary<string, object>;
				if (dictionary == null)
				{
					throw new InvalidDataException("提供的变量不是词典类型变量。");
				}
				_003C_003Ec__DisplayClass62_.nNXS7JSLr7w = new ActionExecuteContext(SUBS7gScNuo, SUBS7gScNuo.Action, null, null, false, 0);
				foreach (KeyValuePair<string, object> item in dictionary)
				{
					_003C_003Ec__DisplayClass62_.nNXS7JSLr7w.SetVarValueWithoutConvert(item.Key, item.Value);
				}
				if (_003C_003Ec__DisplayClass62_.upNS7CPTTmI == "dict")
				{
					string textParamValue = XActionHelper.GetTextParamValue(FormForDictDefParam, lfFS7tbh1G6, SUBS7gScNuo);
					_003C_003Ec__DisplayClass62_.NiQS7NThV8o = JsonConvert.DeserializeObject<Form>(textParamValue);
				}
				else
				{
					List<FormField> fields = JsonConvert.DeserializeObject<List<FormField>>(XActionHelper.GetTextParamValue(FormForDynamicDictParam, lfFS7tbh1G6, SUBS7gScNuo));
					_003C_003Ec__DisplayClass62_.NiQS7NThV8o = new Form
					{
						Fields = fields
					};
				}
				if (_003C_003Ec__DisplayClass62_.NiQS7NThV8o == null || !_003C_003Ec__DisplayClass62_.NiQS7NThV8o.Fields.HasData())
				{
					return (isSuccess: false, message: "表单未定义字段", failReason: ActionStopFlag.OperationFailed);
				}
				dMNS7LXJYO6.Gy9gPlWBtaY(_003C_003Ec__DisplayClass62_.NiQS7NThV8o);
			}
			else
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(FormDefParam, lfFS7tbh1G6, SUBS7gScNuo);
				_003C_003Ec__DisplayClass62_.NiQS7NThV8o = JsonConvert.DeserializeObject<Form>(textParamValue2);
				if (_003C_003Ec__DisplayClass62_.NiQS7NThV8o == null || !_003C_003Ec__DisplayClass62_.NiQS7NThV8o.Fields.HasData())
				{
					return (isSuccess: false, message: "表单未定义字段", failReason: ActionStopFlag.OperationFailed);
				}
			}
			_003C_003Ec__DisplayClass62_.YRwS7ul7xuN = XActionHelper.GetTextParamValue(owHgELKDoDm, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.HHWS7PTeVV8 = XActionHelper.GetTextParamValue(c8ygEvDLVIj, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.vJyS7qEFjUB = XActionHelper.GetTextParamValue(ceFgECt8DEh, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.UkbS7I8ghKb = XActionHelper.GetBooleanParamValue(DW2gE08N7Cw, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.pUcS70OI8m1 = XActionHelper.GetNumberParamValue(NA6gESZvouZ, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.SIXS7cowrtY = XActionHelper.GetNumberParamValue(ogqgE24Xt3l, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.j66S7EAO8su = XActionHelper.GetNumberParamValue(oaQgEu1TQrM, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.CcwS7VpcXmr = XActionHelper.GetNumberParamValue(wdHgENVKUfI, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.eKOS79N9ypn = XActionHelper.GetBooleanParamValue(qMxgEJUm2SU, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.lx9S77KGYa6 = XActionHelper.GetTextParamValue(NvRgEPtTxMj, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.o2hS7RubXxy = XActionHelper.GetTextParamValue(q3RgEEN3OEY, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.lpKS7ZjqCZT = XActionHelper.GetBooleanParamValue(VYUgE8eHohk, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.CG1S7aJ3wHX = XActionHelper.GetTextParamValue(DKpgEygYlnp, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.D9CS7YxTEck = false;
			_003C_003Ec__DisplayClass62_.NhmS7heeaaA = null;
			_003C_003Ec__DisplayClass62_.VkvS7eANv0S = "";
			string textParamValue3 = XActionHelper.GetTextParamValue(yPXgE7GVcmu, lfFS7tbh1G6, SUBS7gScNuo);
			_003C_003Ec__DisplayClass62_.YBhS7ytjcmI = ShowWindowLocation.CenterScreen;
			if (!Enum.TryParse<ShowWindowLocation>(textParamValue3, out _003C_003Ec__DisplayClass62_.YBhS7ytjcmI))
			{
				_003C_003Ec__DisplayClass62_.YBhS7ytjcmI = ShowWindowLocation.CenterScreen;
			}
			_003C_003Ec__DisplayClass62_.fF3S78NbvlU = XActionHelper.GetTextParamValue(PeFgERvFRVV, lfFS7tbh1G6, SUBS7gScNuo);
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass62_.h33S7Sc5fDJ);
			while (!_003C_003Ec__DisplayClass62_.D9CS7YxTEck)
			{
				Thread.Sleep(50);
			}
			if (_003C_003Ec__DisplayClass62_.NhmS7heeaaA == null)
			{
				XActionHelper.OutputResult(nwZgEVBH9TB, lfFS7tbh1G6, SUBS7gScNuo, "Cancel", s4YS7vb9Iv6);
				return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
			}
			XActionHelper.OutputResult(nwZgEVBH9TB, lfFS7tbh1G6, SUBS7gScNuo, _003C_003Ec__DisplayClass62_.VkvS7eANv0S, s4YS7vb9Iv6);
			if (dictionary != null)
			{
				foreach (string key in _003C_003Ec__DisplayClass62_.NhmS7heeaaA.Keys)
				{
					dictionary[key] = _003C_003Ec__DisplayClass62_.NhmS7heeaaA[key];
				}
				SUBS7gScNuo.ActionLogger.LogOutput(new StepOutParamDef(), lfFS7tbh1G6.InputParams[njdgEgpc3iO.Key].VarKey, dictionary);
			}
			else
			{
				foreach (string key2 in _003C_003Ec__DisplayClass62_.NhmS7heeaaA.Keys)
				{
					XActionHelper.OutputResultToVariable(key2, _003C_003Ec__DisplayClass62_.NhmS7heeaaA[key2], SUBS7gScNuo, s4YS7vb9Iv6);
				}
			}
			XActionHelper.OutputResultIfNeeded(f8NgEZsMRln, _003C_003Ec__DisplayClass62_.kG8S726pjAg, lfFS7tbh1G6, SUBS7gScNuo, s4YS7vb9Iv6);
			if (_003C_003Ec__DisplayClass62_.UkbS7I8ghKb)
			{
				Thread.Sleep(100);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool T8ikl7WJsKkfmJYsITgh()
		{
			return kFkeJqWJmEq8G1uU7PdA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_1
	{
		public string YRwS7ul7xuN;

		public Form NiQS7NThV8o;

		public ActionExecuteContext nNXS7JSLr7w;

		public double pUcS70OI8m1;

		public string upNS7CPTTmI;

		public string HHWS7PTeVV8;

		public double j66S7EAO8su;

		public ShowWindowLocation YBhS7ytjcmI;

		public string fF3S78NbvlU;

		public string CG1S7aJ3wHX;

		public string lx9S77KGYa6;

		public string o2hS7RubXxy;

		public string vJyS7qEFjUB;

		public double SIXS7cowrtY;

		public double CcwS7VpcXmr;

		public bool lpKS7ZjqCZT;

		public bool eKOS79N9ypn;

		public IDictionary<string, object> NhmS7heeaaA;

		public string VkvS7eANv0S;

		public bool D9CS7YxTEck;

		public bool UkbS7I8ghKb;

		public _003C_003Ec__DisplayClass62_0 sbkS7Wmup1O;

		internal static _003C_003Ec__DisplayClass62_1 hm3urHWJ76vwvugnq1om;

		internal void h33S7Sc5fDJ()
		{
			_003C_003Ec__DisplayClass62_2 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_2
			{
				jA0S7H4084O = this,
				aCoS7sxAqGI = NativeMethods.GetForegroundWindow(),
				pTvS7GJfcaK = new FormWindow(YRwS7ul7xuN, NiQS7NThV8o, nNXS7JSLr7w, sbkS7Wmup1O.s4YS7vb9Iv6, pUcS70OI8m1, upNS7CPTTmI.IsEither("dict", "dict_dynamic"), HHWS7PTeVV8, j66S7EAO8su)
				{
					Location = YBhS7ytjcmI,
					WindowSizeStr = fF3S78NbvlU
				}
			};
			int num = 0;
			if (hm3urHWJ76vwvugnq1om != null)
			{
				goto IL_00d7;
			}
			goto IL_01a2;
			IL_00d7:
			int num2 = default(int);
			num = num2;
			goto IL_01a2;
			IL_01a2:
			do
			{
				switch (num)
				{
				case 2:
					if (!(CcwS7VpcXmr > 100.0))
					{
						break;
					}
					goto IL_00b5;
				default:
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.V6hgjEnp8ZH(sbkS7Wmup1O.SUBS7gScNuo.CancellationToken);
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.PreSelectedGroup = CG1S7aJ3wHX;
					if (!string.IsNullOrEmpty(lx9S77KGYa6))
					{
						_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.SetConfirmButtonTitle(lx9S77KGYa6);
					}
					if (!string.IsNullOrEmpty(o2hS7RubXxy))
					{
						_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.SetCustomButtons(o2hS7RubXxy);
					}
					if (!string.IsNullOrEmpty(vJyS7qEFjUB))
					{
						_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.MarkdownHelp = vJyS7qEFjUB;
					}
					if (SIXS7cowrtY <= 0.0)
					{
						SIXS7cowrtY = 400.0;
					}
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Width = SIXS7cowrtY;
					goto case 2;
				case 1:
					break;
				}
				if (lpKS7ZjqCZT)
				{
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.EnableEnterSubmit = false;
				}
				if (sbkS7Wmup1O.SUBS7gScNuo.ParentWindow.zmGvuiv40H0())
				{
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Owner = sbkS7Wmup1O.SUBS7gScNuo.ParentWindow;
				}
				if (eKOS79N9ypn)
				{
					_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Topmost = true;
				}
				AppHelper.SetWindowIcon(_003C_003Ec__DisplayClass62_.pTvS7GJfcaK, sbkS7Wmup1O.SUBS7gScNuo?.Action?.Icon, true);
				_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Show();
				_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Activate();
				_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.Closed += _003C_003Ec__DisplayClass62_.kgMS7krEw4X;
				return;
				IL_00b5:
				_003C_003Ec__DisplayClass62_.pTvS7GJfcaK.MaxHeight = CcwS7VpcXmr;
				num = 1;
			}
			while (JTURBCWJ4IDglewRphIx());
			goto IL_00d7;
		}

		internal object kG8S726pjAg()
		{
			return CG1S7aJ3wHX;
		}

		internal static bool JTURBCWJ4IDglewRphIx()
		{
			return hm3urHWJ76vwvugnq1om == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_2
	{
		public FormWindow pTvS7GJfcaK;

		public IntPtr aCoS7sxAqGI;

		public _003C_003Ec__DisplayClass62_1 jA0S7H4084O;

		internal static _003C_003Ec__DisplayClass62_2 JUuJDsWkVnk6P4uDnoZ9;

		internal void kgMS7krEw4X(object sender, EventArgs e)
		{
			if (pTvS7GJfcaK.IsSuccess)
			{
				jA0S7H4084O.NhmS7heeaaA = pTvS7GJfcaK.Values;
				jA0S7H4084O.VkvS7eANv0S = pTvS7GJfcaK.ClickedConfirmButtonValue;
				jA0S7H4084O.CG1S7aJ3wHX = pTvS7GJfcaK.SelectedGroup;
			}
			pTvS7GJfcaK = null;
			jA0S7H4084O.D9CS7YxTEck = true;
			if (!jA0S7H4084O.UkbS7I8ghKb)
			{
				return;
			}
			int num = 0;
			if (JUuJDsWkVnk6P4uDnoZ9 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (aCoS7sxAqGI != IntPtr.Zero)
			{
				if (jA0S7H4084O.sbkS7Wmup1O.SUBS7gScNuo.IsDebugging)
				{
					jA0S7H4084O.sbkS7Wmup1O.SUBS7gScNuo.ActionLogger?.LogInfo($"恢复焦点窗口到：{aCoS7sxAqGI}");
				}
				AppHelper.SetForegroundWindow(aCoS7sxAqGI);
			}
		}

		internal static bool j8ukPUWkQW9CKNwhP9lu()
		{
			return JUuJDsWkVnk6P4uDnoZ9 == null;
		}
	}

	public const string StepRunnerKey = "sys:form";

	[CompilerGenerated]
	private readonly IEnumerable<string> DdjgPib2Bjn;

	[CompilerGenerated]
	private readonly string IpHgP3mOVY7 = $"fa:{EFontAwesomeIcon.Light_Window}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> OT3gPfQ0t90;

	[CompilerGenerated]
	private readonly string QgrgPzoI6lT = "https://getquicker.net/KC/Help/Doc/form";

	[CompilerGenerated]
	private readonly bool qgJgEwZXEq9;

	private static readonly StepInParamDef qeRgEtII4kk;

	private static readonly StepInParamDef njdgEgpc3iO;

	private static readonly StepInParamDef owHgELKDoDm;

	public static StepInParamDef FormDefParam;

	public static StepInParamDef FormForDictDefParam;

	public static StepInParamDef FormForDynamicDictParam;

	private static readonly StepInParamDef c8ygEvDLVIj;

	private static readonly StepInParamDef NA6gESZvouZ;

	private static readonly StepInParamDef ogqgE24Xt3l;

	private static readonly StepInParamDef oaQgEu1TQrM;

	private static readonly StepInParamDef wdHgENVKUfI;

	private static readonly StepInParamDef qMxgEJUm2SU;

	private static readonly StepInParamDef DW2gE08N7Cw;

	private static readonly StepInParamDef ceFgECt8DEh;

	private static readonly StepInParamDef NvRgEPtTxMj;

	private static readonly StepInParamDef q3RgEEN3OEY;

	private static readonly StepInParamDef DKpgEygYlnp;

	private static readonly StepInParamDef VYUgE8eHohk;

	private static readonly StepInParamDef Au6gEaWYloR;

	private static readonly StepInParamDef yPXgE7GVcmu;

	private static readonly StepInParamDef PeFgERvFRVV;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> nYQgEqJKG6H = new List<StepInParamDef>
	{
		qeRgEtII4kk, njdgEgpc3iO, owHgELKDoDm, FormDefParam, FormForDictDefParam, FormForDynamicDictParam, c8ygEvDLVIj, ceFgECt8DEh, NA6gESZvouZ, ogqgE24Xt3l,
		oaQgEu1TQrM, wdHgENVKUfI, DW2gE08N7Cw, qMxgEJUm2SU, NvRgEPtTxMj, q3RgEEN3OEY, DKpgEygYlnp, yPXgE7GVcmu, PeFgERvFRVV, VYUgE8eHohk,
		Au6gEaWYloR
	};

	private static readonly StepOutParamDef Ql5gEcY0Qeo;

	private static readonly StepOutParamDef nwZgEVBH9TB;

	private static readonly StepOutParamDef f8NgEZsMRln;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qprgE9QnL3L = new List<StepOutParamDef> { Ql5gEcY0Qeo, nwZgEVBH9TB, f8NgEZsMRln };

	private static FormStep uFDAbdQxWIwWUxhO3VDK;

	public string Key => "sys:form";

	public string Name => "多字段表单";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return DdjgPib2Bjn;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return IpHgP3mOVY7;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return OT3gPfQ0t90;
		}
	}

	public string Description => "使用表单窗口编辑多个变量的值。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return QgrgPzoI6lT;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return qgJgEwZXEq9;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return nYQgEqJKG6H;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qprgE9QnL3L;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
		_003C_003Ec__DisplayClass62_.lfFS7tbh1G6 = step;
		_003C_003Ec__DisplayClass62_.SUBS7gScNuo = context;
		_003C_003Ec__DisplayClass62_.dMNS7LXJYO6 = this;
		_003C_003Ec__DisplayClass62_.s4YS7vb9Iv6 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass62_.SUBS7gScNuo, _003C_003Ec__DisplayClass62_.lfFS7tbh1G6, _003C_003Ec__DisplayClass62_.s4YS7vb9Iv6, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass62_.RgsS7wji5Eh, (Action)null, (Action)null, Au6gEaWYloR, Ql5gEcY0Qeo);
	}

	private void Gy9gPlWBtaY(Form form_0)
	{
		if (form_0 != null && form_0.Fields.HasData())
		{
			IList<string> list = new List<string>();
			int num = -1;
			int num3 = default(int);
			foreach (FormField field in form_0.Fields)
			{
				num++;
				if (field.InputMethod == InputMethod.None)
				{
					list.Add($"字段{num}：输入方式未设定。");
				}
				else
				{
					if (field.InputMethod == InputMethod.Separator)
					{
						continue;
					}
					if (string.IsNullOrEmpty(field.FieldKey))
					{
						list.Add($"字段{num}：未设定FieldKey。");
					}
					if (string.IsNullOrEmpty(field.Label))
					{
						list.Add($"字段{num}：未设定Label。");
						int num2 = 0;
						if (!SJplMVQxy05EJ6EQM8xj())
						{
							num2 = num3;
						}
						switch (num2)
						{
						}
					}
				}
			}
			if (list.Any())
			{
				throw new InvalidOperationException("表单定义不合法：" + string.Join("; ", list));
			}
			return;
		}
		throw new ArgumentException("表单数据为空或不合法。");
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(qeRgEtII4kk, step) + " " + XActionHelper.GetParamDisplayString(owHgELKDoDm, step) + " " + XActionHelper.GetParamDisplayString(c8ygEvDLVIj, step);
	}

	static FormStep()
	{
		qeRgEtII4kk = new StepInParamDef
		{
			Key = "operation",
			Name = "工作模式",
			Description = "工作模式：编辑某个词典的值，或编辑一些变量的值",
			DefaultValue = "variables",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("variables", "编辑动作变量的值"),
				new SelectionItem("dict", "编辑词典数据"),
				new SelectionItem("dict_dynamic", "编辑词典数据（动态）")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		njdgEgpc3iO = new StepInParamDef
		{
			Key = "dictVar",
			Name = "词典变量",
			Description = "表单需要编辑的词典变量",
			Type = VarType.Dict,
			VariableMode = ParamVariableMode.UseVarOnly,
			ValidForList = new string[2] { "dict", "dict_dynamic" }
		};
		owHgELKDoDm = new StepInParamDef
		{
			Key = "title",
			Name = "窗口标题",
			Description = "表单窗口标题文字",
			DefaultValue = "填写表单",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		FormDefParam = new StepInParamDef
		{
			Key = "formDef",
			Name = "表单定义",
			IsRequired = true,
			Type = VarType.Form,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			ValidForList = new string[1] { "variables" }
		};
		FormForDictDefParam = new StepInParamDef
		{
			Key = "formForDictDef",
			Name = "表单定义(词典)",
			IsRequired = true,
			Type = VarType.FormForDict,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			ValidForList = new string[1] { "dict" }
		};
		FormForDynamicDictParam = new StepInParamDef
		{
			Key = "dynamicFormForDictDef",
			Name = "表单定义(词典)",
			IsRequired = true,
			Description = "JSON格式的表单定义数据。格式说明请参考模块文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[1] { "dict_dynamic" }
		};
		c8ygEvDLVIj = new StepInParamDef
		{
			Key = "help",
			Name = "提示文字",
			Description = "帮助用户填写表单的提示文字。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		NA6gESZvouZ = new StepInParamDef
		{
			Key = "titleColumnWidth",
			Name = "标题列宽度",
			Description = "左侧字段标题区域的宽度(逻辑像素)。负值，如-200表示自适应列宽且最大宽度为200。",
			DefaultValue = 100,
			Type = VarType.Number,
			IsRequired = false,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ogqgE24Xt3l = new StepInParamDef
		{
			Key = "windowWidth",
			Name = "窗口宽度",
			Description = "逻辑像素，最小400。",
			DefaultValue = 500,
			Type = VarType.Number,
			IsRequired = true,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		oaQgEu1TQrM = new StepInParamDef
		{
			Key = "defaultInputWidth",
			Name = "输入框默认宽度",
			Description = "逻辑像素，0表示自动宽度。",
			DefaultValue = 0,
			Type = VarType.Number,
			IsRequired = true,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		wdHgENVKUfI = new StepInParamDef
		{
			Key = "windowHeight",
			Name = "窗口最大高度",
			Description = "逻辑像素，0表示默认。设置时请填写大于100的值。",
			DefaultValue = "0",
			Type = VarType.Number,
			IsRequired = true,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		qMxgEJUm2SU = new StepInParamDef
		{
			Key = "topMost",
			Name = "置顶显示",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		DW2gE08N7Cw = new StepInParamDef
		{
			Key = "restoreFocus",
			Name = "恢复活动窗口",
			Description = "用户输入后，是否将焦点还原到之前的活动窗口",
			DefaultValue = false,
			Type = VarType.Boolean,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		ceFgECt8DEh = new StepInParamDef
		{
			Key = "markdownhelp",
			Name = "帮助按钮内容",
			Description = "点击弹出显示帮助内容，MarkDown格式。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			DefaultHighlightType = "MarkDown"
		};
		NvRgEPtTxMj = new StepInParamDef
		{
			Key = "confirm",
			Name = "自定义“确定”按钮标题",
			Description = "仅在需要时填写。使用\"_字符\"的形式定义触发字符,如\"_S\"表示Alt+S可直接触发按钮",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input
		};
		q3RgEEN3OEY = new StepInParamDef
		{
			Key = "customButtons",
			Name = "自定义按钮",
			Description = "使用\"标题|返回值\"的形式定义按钮，多个按钮用换行分隔。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input
		};
		DKpgEygYlnp = new StepInParamDef
		{
			Key = "selectedGroup",
			Name = "选择的分组",
			Description = "使用分组标签页时，默认选择的分组。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = false,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input
		};
		VYUgE8eHohk = new StepInParamDef
		{
			Key = "disableEnterSubmit",
			Name = "关闭Enter提交表单功能",
			Description = "",
			DefaultValue = false,
			Type = VarType.Boolean,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		Au6gEaWYloR = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "取消后停止",
			DefaultValue = true,
			Description = "取消后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		yPXgE7GVcmu = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置类型",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[12]
			{
				new SelectionItem(ShowWindowLocation.WithMouse1.ToString(), "跟随鼠标（指针周围）"),
				new SelectionItem(ShowWindowLocation.WithMouse2.ToString(), "跟随鼠标（指针右下）"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		PeFgERvFRVV = new StepInParamDef
		{
			Key = "winSize",
			Name = "位置",
			Description = "当 “窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		Ql5gEcY0Qeo = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		nwZgEVBH9TB = new StepOutParamDef
		{
			Key = "button",
			Name = "点击的按钮",
			Description = "默认的确认按钮返回值为空，自定义按钮返回值为自定义的值。",
			Type = VarType.Text
		};
		f8NgEZsMRln = new StepOutParamDef
		{
			Key = "selectedGroup",
			Name = "选择的分组",
			Description = "关闭时所选择的标签页分组。",
			Type = VarType.Text
		};
	}

	internal static bool SJplMVQxy05EJ6EQM8xj()
	{
		return uFDAbdQxWIwWUxhO3VDK == null;
	}
}
