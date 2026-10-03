using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Jint;
using Jint.Native;
using Jint.Native.Object;
using Jint.Runtime.Descriptors;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Other;

public class RunJsScriptStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec osLSZ5jlNWg;

		public static Action<string> hHqSZDcdnr0;

		public static Func<JsValue, string> wosSZdVLEPU;

		internal static _003C_003Ec ohLlLyW9VvS5LhhdF8pV;

		static _003C_003Ec()
		{
			osLSZ5jlNWg = new _003C_003Ec();
		}

		internal void hYeSZn48NnP(string str)
		{
			AppHelper.ShowInformation(str);
		}

		internal string HYVSZ4yICLM(JsValue ele)
		{
			object obj;
			if ((object)ele == null)
			{
				obj = null;
			}
			else
			{
				obj = ele.ToString();
				if (obj != null)
				{
					goto IL_0015;
				}
			}
			obj = string.Empty;
			goto IL_0015;
			IL_0015:
			return (string)obj;
		}

		internal static bool YPou93W9QyFxtghMwjoE()
		{
			return ohLlLyW9VvS5LhhdF8pV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep pkFSZA13AbH;

		public ActionExecuteContext d3gSZORoyea;

		public XAction hsLSZFdk1pm;

		public Action<string> pwHSZUonWFa;

		public Func<string, object, int> bxRSZlbPa9C;

		internal static _003C_003Ec__DisplayClass42_0 V44LGqW9cPLVC3Kb2kw9;

		internal (bool isSuccess, string message, ActionStopFlag failReason) oErSZoTixub()
		{
			string text = "Jint";
			string textParamValue = XActionHelper.GetTextParamValue(gyxgZKkgFF4, pkFSZA13AbH, d3gSZORoyea);
			if (!(text == "Jint") && !string.IsNullOrWhiteSpace(text))
			{
				throw new Exception("不支持的JS引擎：" + text);
			}
			_003C_003Ec__DisplayClass42_1 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_1();
			_003C_003Ec__DisplayClass42_.fBBS9tw4SXE = this;
			_003C_003Ec__DisplayClass42_.q9tSZzh71KI = XActionHelper.GetBooleanParamValue(FSngZx0JcwE, pkFSZA13AbH, d3gSZORoyea);
			_003C_003Ec__DisplayClass42_.XvUS9w6dxCX = new Engine(_003C_003Ec__DisplayClass42_.AO7SZihoynA);
			try
			{
				_003C_003Ec__DisplayClass42_.XvUS9w6dxCX.SetValue("log", pwHSZUonWFa ?? (pwHSZUonWFa = w7VSZTsua3J));
				_003C_003Ec__DisplayClass42_.XvUS9w6dxCX.SetValue("alert", _003C_003Ec.hHqSZDcdnr0 ?? (_003C_003Ec.hHqSZDcdnr0 = _003C_003Ec.osLSZ5jlNWg.hYeSZn48NnP));
				_003C_003Ec__DisplayClass42_.XvUS9w6dxCX.SetValue<Func<string, object>>("quickerGetVar", _003C_003Ec__DisplayClass42_.gPlSZ3AHR1J);
				_003C_003Ec__DisplayClass42_.XvUS9w6dxCX.SetValue("quickerSetVar", bxRSZlbPa9C ?? (bxRSZlbPa9C = SyoSZMq6foQ));
				_003C_003Ec__DisplayClass42_.XvUS9w6dxCX.Execute(textParamValue);
				JsValue value = _003C_003Ec__DisplayClass42_.XvUS9w6dxCX.Invoke("exec");
				int num = 0;
				if (value.IsUndefined())
				{
					num = 0;
				}
				else
				{
					if (!value.IsNumber())
					{
						throw new Exception("exec函数返回值必须是数字，0表示成功。");
					}
					num = Convert.ToInt32(value.AsNumber());
				}
				XActionHelper.OutputResult(t7pgZBjdOwi, pkFSZA13AbH, d3gSZORoyea, num, hsLSZFdk1pm);
				if (num == 0)
				{
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				return (isSuccess: false, message: "JS脚本返回错误：" + num, failReason: ActionStopFlag.OperationFailed);
			}
			finally
			{
				if (_003C_003Ec__DisplayClass42_.XvUS9w6dxCX != null)
				{
					((IDisposable)_003C_003Ec__DisplayClass42_.XvUS9w6dxCX).Dispose();
				}
			}
		}

		internal void w7VSZTsua3J(string str)
		{
			d3gSZORoyea.ActionLogger.LogInfo(str);
		}

		internal int SyoSZMq6foQ(string varName, object value)
		{
			if (d3gSZORoyea.IsDebugging)
			{
				d3gSZORoyea.ActionLogger?.LogOutput(new StepOutParamDef
				{
					Name = "脚本写入"
				}, varName, value);
			}
			if (value is JsArray)
			{
				value = (value as JsArray).Select<JsValue, string>(_003C_003Ec.wosSZdVLEPU ?? (_003C_003Ec.wosSZdVLEPU = _003C_003Ec.osLSZ5jlNWg.HYVSZ4yICLM)).ToList();
				if (V44LGqW9cPLVC3Kb2kw9 != null)
				{
					switch (0)
					{
					}
				}
			}
			else if (value is ObjectInstance)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				foreach (KeyValuePair<JsValue, PropertyDescriptor> ownProperty in (value as ObjectInstance).GetOwnProperties())
				{
					dictionary[ownProperty.Key.ToString()] = ownProperty.Value.Value.ToObject();
				}
				value = dictionary;
			}
			d3gSZORoyea.SetVarValue(varName, value);
			return 0;
		}

		internal static bool IG7B1FW9WwTcj9eyldBF()
		{
			return V44LGqW9cPLVC3Kb2kw9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_1
	{
		public bool q9tSZzh71KI;

		public Engine XvUS9w6dxCX;

		public _003C_003Ec__DisplayClass42_0 fBBS9tw4SXE;

		public Func<string, JsValue> dx9S9gvcY85;

		private static _003C_003Ec__DisplayClass42_1 Px32mFW92jBw0h1yW5VD;

		internal void AO7SZihoynA(Options options)
		{
			if (q9tSZzh71KI)
			{
				options.AllowClr();
			}
			if (fBBS9tw4SXE.d3gSZORoyea.CancellationToken.HasValue)
			{
				options.CancellationToken(fBBS9tw4SXE.d3gSZORoyea.CancellationToken.Value);
			}
		}

		internal object gPlSZ3AHR1J(string varName)
		{
			object varValue = fBBS9tw4SXE.d3gSZORoyea.GetVarValue(varName);
			if (varValue is decimal)
			{
				return Convert.ToDouble(varValue);
			}
			if (varValue is List<string> source)
			{
				return new JsArray(XvUS9w6dxCX, source.Select(dx9S9gvcY85 ?? (dx9S9gvcY85 = JXBSZfrNhKu)).ToArray());
			}
			return JsValue.FromObject(XvUS9w6dxCX, varValue);
		}

		internal JsValue JXBSZfrNhKu(string s)
		{
			return JsValue.FromObject(XvUS9w6dxCX, s);
		}

		static _003C_003Ec__DisplayClass42_1()
		{
		}

		internal static void qiMU44W9eCbh4HSLUREH()
		{
		}

		internal static bool GR1TyRW9AeDV5d9EoJ8k()
		{
			return Px32mFW92jBw0h1yW5VD == null;
		}

		internal static void E4JSbZW9jfvDVYZBonLU()
		{
		}
	}

	public const string StepKey = "sys:jsscript";

	[CompilerGenerated]
	private readonly IEnumerable<string> GXJgZ15DlXQ;

	[CompilerGenerated]
	private readonly string QdBgZbIrFLW = $"fa:{EFontAwesomeIcon.Light_Scroll}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> oJvgZ6c57iN;

	[CompilerGenerated]
	private readonly string XlIgZXt0hNf = "https://getquicker.net/KC/Help/Doc/jsscript";

	[CompilerGenerated]
	private readonly bool sfAgZmkuV5U;

	private static readonly StepInParamDef gyxgZKkgFF4;

	private static readonly StepInParamDef FSngZx0JcwE;

	private static readonly StepInParamDef xG2gZr1a2qE;

	private static readonly StepOutParamDef ja5gZpYydBc;

	private static readonly StepOutParamDef t7pgZBjdOwi;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> CaYgZQi7NyP = new List<StepInParamDef> { gyxgZKkgFF4, FSngZx0JcwE, xG2gZr1a2qE };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> C2WgZjwE7vQ = new List<StepOutParamDef> { ja5gZpYydBc, t7pgZBjdOwi };

	internal static RunJsScriptStep YBdDcUQSLd8gNaOEXdZP;

	public string Key => "sys:jsscript";

	public string Name => "运行Javascript代码";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return GXJgZ15DlXQ;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return QdBgZbIrFLW;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return oJvgZ6c57iN;
		}
	}

	public string Description => "执行Js代码片段。代码中应包含主函数exec()，请参考文档。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return XlIgZXt0hNf;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return sfAgZmkuV5U;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return CaYgZQi7NyP;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return C2WgZjwE7vQ;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.pkFSZA13AbH = step;
		_003C_003Ec__DisplayClass42_.d3gSZORoyea = context;
		_003C_003Ec__DisplayClass42_.hsLSZFdk1pm = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.d3gSZORoyea, _003C_003Ec__DisplayClass42_.pkFSZA13AbH, _003C_003Ec__DisplayClass42_.hsLSZFdk1pm, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.oErSZoTixub, (Action)null, (Action)null, xG2gZr1a2qE, ja5gZpYydBc);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static RunJsScriptStep()
	{
		gyxgZKkgFF4 = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "//.js 主函数 exec()\r\nfunction exec(){\r\n var localName = quickerGetVar('text');  // 读取text变量值, (text 是动作里的变量)\r\n quickerSetVar('text', 'Hello, ' + localName ); //输出修改后的值到text变量中。\r\n return 0; //返回0表示成功。返回其他数字表示失败。\r\n}\r\n",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			DefaultHighlightType = "JavaScript"
		};
		FSngZx0JcwE = new StepInParamDef
		{
			Key = "allClr",
			Name = "允许访问.Net程序集",
			DefaultValue = false,
			Description = "是否需要在js代码中访问.Net程序集",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		xG2gZr1a2qE = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ja5gZpYydBc = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		t7pgZBjdOwi = new StepOutParamDef
		{
			Key = "return",
			Name = "返回值",
			Description = "脚本代码返回的数字值。",
			Type = VarType.Integer
		};
	}

	internal static bool dWK3F4QSuO7P5R6xyLPe()
	{
		return YBdDcUQSLd8gNaOEXdZP == null;
	}
}
