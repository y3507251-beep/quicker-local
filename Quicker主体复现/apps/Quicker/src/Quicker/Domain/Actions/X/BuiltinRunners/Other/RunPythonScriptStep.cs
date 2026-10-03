using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using FontAwesome5;
using log4net;
using Python.Runtime;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Other;

public class RunPythonScriptStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec OKDSZkujVdc;

		public static Func<string, bool> iWeSZG8D7RR;

		private static _003C_003Ec GRqdp3WNMOKquhQwMUMR;

		static _003C_003Ec()
		{
			OKDSZkujVdc = new _003C_003Ec();
		}

		internal bool yYeSZWx58yC(string x)
		{
			return !x.EndsWith("python3.dll", StringComparison.OrdinalIgnoreCase);
		}

		internal static bool PY3aL9WNUrnTpKKAeqhK()
		{
			return GRqdp3WNMOKquhQwMUMR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ActionStep n33SZHw1vYY;

		public ActionExecuteContext qbMSZ10WbQ7;

		public RunPythonScriptStep mBTSZbipTt8;

		public XAction qNUSZ6ZfqVi;

		private static _003C_003Ec__DisplayClass41_0 QDQtx7WNIDIuIYyg8aGO;

		internal (bool isSuccess, string message, ActionStopFlag failReason) dN1SZsqCJoI()
		{
			_003C_003Ec__DisplayClass41_1 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_1
			{
				BOcSZrMLiqa = this
			};
			string text = XActionHelper.GetTextParamValue(TucgZyj4txr, n33SZHw1vYY, qbMSZ10WbQ7);
			if (string.IsNullOrEmpty(text) && !dDh7g7Xw7JyQPUTbYwJ.TXntHBXc65x().IsNullOrWhiteSpace())
			{
				text = dDh7g7Xw7JyQPUTbYwJ.TXntHBXc65x();
			}
			if (string.IsNullOrEmpty(text))
			{
				text = wVagZShZkHD();
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidDataException("未找到python目录。");
			}
			text = PathHelper.RemoveZeroWidthChar(text);
			if (text.Contains("%"))
			{
				text = Environment.ExpandEnvironmentVariables(text);
			}
			_003C_003Ec__DisplayClass41_.quOSZmKdoUg = "";
			string string_ = "";
			if (System.IO.File.Exists(text))
			{
				_003C_003Ec__DisplayClass41_.quOSZmKdoUg = text;
				string_ = Path.GetDirectoryName(text);
			}
			else if (Directory.Exists(text))
			{
				string_ = text;
				_003C_003Ec__DisplayClass41_.quOSZmKdoUg = DQ2gZ2flPjh(text);
			}
			if (!System.IO.File.Exists(_003C_003Ec__DisplayClass41_.quOSZmKdoUg))
			{
				return (isSuccess: false, message: "未找到python dll文件：" + _003C_003Ec__DisplayClass41_.quOSZmKdoUg, failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass41_.u82SZKUNCnK = XActionHelper.GetTextParamValue(Xi5gZEjLrCO, n33SZHw1vYY, qbMSZ10WbQ7);
			qbMSZ10WbQ7.ActionLogger.LogInfo("PythonDll路径：" + _003C_003Ec__DisplayClass41_.quOSZmKdoUg);
			string environmentVariable = Environment.GetEnvironmentVariable("PATH");
			string environmentVariable2 = Environment.GetEnvironmentVariable("PYTHONHOME");
			string environmentVariable3 = Environment.GetEnvironmentVariable("PYTHONPATH");
			mBTSZbipTt8.whdgZvK1yu5(string_);
			try
			{
				_003C_003Ec__DisplayClass41_.GjaSZxvt8Ni = null;
				GaZT3MMHZ3eZxDOySux.x1VLMFjodna(_003C_003Ec__DisplayClass41_.QA9SZXQygMA, true, "python");
				if (_003C_003Ec__DisplayClass41_.GjaSZxvt8Ni != null)
				{
					return (isSuccess: false, message: "代码执行错误：" + _003C_003Ec__DisplayClass41_.GjaSZxvt8Ni.Message, failReason: ActionStopFlag.OperationFailed);
				}
			}
			finally
			{
				Environment.SetEnvironmentVariable("PATH", environmentVariable, EnvironmentVariableTarget.Process);
				Environment.SetEnvironmentVariable("PYTHONHOME", environmentVariable2 ?? "", EnvironmentVariableTarget.Process);
				Environment.SetEnvironmentVariable("PYTHONPATH", environmentVariable3 ?? "", EnvironmentVariableTarget.Process);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool BpaEFMWN6M2RodcNqLiM()
		{
			return QDQtx7WNIDIuIYyg8aGO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_1
	{
		public string quOSZmKdoUg;

		public string u82SZKUNCnK;

		public Exception GjaSZxvt8Ni;

		public _003C_003Ec__DisplayClass41_0 BOcSZrMLiqa;

		internal static _003C_003Ec__DisplayClass41_1 rR8539WNSWGghVxqsx9I;

		internal void QA9SZXQygMA()
		{
			if (string.IsNullOrEmpty(Python.Runtime.Runtime.PythonDLL) || !string.Equals(Python.Runtime.Runtime.PythonDLL, quOSZmKdoUg))
			{
				try
				{
					if (PythonEngine.IsInitialized)
					{
						PythonEngine.Shutdown();
					}
				}
				catch (Exception ex)
				{
					VXwgZPycAdy.Warn("关闭python引擎出错。" + ex.Message, ex);
				}
			}
			if (!PythonEngine.IsInitialized)
			{
				Python.Runtime.Runtime.PythonDLL = quOSZmKdoUg;
				PythonEngine.Initialize();
				PythonEngine.BeginAllowThreads();
			}
			global::_003C_003Ef__AnonymousType0<IStepContext> o = new global::_003C_003Ef__AnonymousType0<IStepContext>(new StepContext(BOcSZrMLiqa.n33SZHw1vYY, BOcSZrMLiqa.qNUSZ6ZfqVi, BOcSZrMLiqa.qbMSZ10WbQ7));
			if (rR8539WNSWGghVxqsx9I == null)
			{
				switch (0)
				{
				}
			}
			try
			{
				using (Py.GIL())
				{
					using PyModule pyModule = Py.CreateScope();
					PyObject value = o.ToPython();
					pyModule.Set("quicker", value);
					pyModule.Exec(u82SZKUNCnK);
				}
			}
			catch (Exception ex2)
			{
				VXwgZPycAdy.Warn("python代码执行出错：" + ex2.Message, ex2);
				GjaSZxvt8Ni = ex2;
			}
		}

		internal static bool HHSKcBWNwZEeYl99JY8g()
		{
			return rR8539WNSWGghVxqsx9I == null;
		}
	}

	public const string StepKey = "sys:pythonscript";

	[CompilerGenerated]
	private readonly IEnumerable<string> NPfgZudLLRB;

	[CompilerGenerated]
	private readonly string rdpgZNdv6UV = $"fa:{EFontAwesomeIcon.Brands_Python}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> dXIgZJPD95F;

	[CompilerGenerated]
	private readonly string E4AgZ05bWiO = "https://getquicker.net/KC/Help/Doc/pythonscript";

	[CompilerGenerated]
	private readonly bool YeZgZCe9rOO;

	private static readonly ILog VXwgZPycAdy;

	private static readonly StepInParamDef Xi5gZEjLrCO;

	private static readonly StepInParamDef TucgZyj4txr;

	private static readonly StepInParamDef UOigZ8EYrnC;

	private static readonly StepOutParamDef vOxgZafbgIN;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> l4HgZ7NoW8L = new List<StepInParamDef> { Xi5gZEjLrCO, TucgZyj4txr, UOigZ8EYrnC };

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qSCgZR69TL8 = new List<StepOutParamDef> { vOxgZafbgIN };

	internal static RunPythonScriptStep b8c68xQSeiI9960CyhlX;

	public string Key => "sys:pythonscript";

	public string Name => "运行Python代码";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return NPfgZudLLRB;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rdpgZNdv6UV;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Flow;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return dXIgZJPD95F;
		}
	}

	public string Description => "执行Python代码片段。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return E4AgZ05bWiO;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return YeZgZCe9rOO;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return l4HgZ7NoW8L;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qSCgZR69TL8;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	private void whdgZvK1yu5(string string_2)
	{
		string text = string_2 + "\\Scripts";
		string text2 = string_2 + "\\Library";
		if (!FBw9EYQSjDuf9SiSbkup())
		{
			switch (0)
			{
			}
		}
		string text3 = string_2 + "\\bin";
		string text4 = string_2 + "\\Library\\bin";
		string text5 = string_2 + "\\Library\\mingw-w64\\bin";
		string environmentVariable = Environment.GetEnvironmentVariable("PATH");
		Environment.SetEnvironmentVariable("PATH", string_2 + ";" + text + ";" + text2 + ";" + text3 + ";" + text4 + ";" + text5 + ";" + environmentVariable, EnvironmentVariableTarget.Process);
		Environment.SetEnvironmentVariable("PYTHONHOME", string_2, EnvironmentVariableTarget.Process);
		Environment.SetEnvironmentVariable("PYTHONPATH", Path.Combine(string_2, "lib"), EnvironmentVariableTarget.Process);
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.n33SZHw1vYY = step;
		_003C_003Ec__DisplayClass41_.qbMSZ10WbQ7 = context;
		_003C_003Ec__DisplayClass41_.mBTSZbipTt8 = this;
		_003C_003Ec__DisplayClass41_.qNUSZ6ZfqVi = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass41_.qbMSZ10WbQ7, _003C_003Ec__DisplayClass41_.n33SZHw1vYY, _003C_003Ec__DisplayClass41_.qNUSZ6ZfqVi, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass41_.dN1SZsqCJoI, (Action)null, (Action)null, UOigZ8EYrnC, vOxgZafbgIN);
	}

	private static string wVagZShZkHD()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("PYTHONHOME");
		if (!string.IsNullOrEmpty(environmentVariable) && Directory.Exists(environmentVariable))
		{
			string text = DQ2gZ2flPjh(environmentVariable);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		string[] array = Environment.GetEnvironmentVariable("path").Split(';');
		int num = 0;
		string text3;
		while (true)
		{
			if (num < array.Length)
			{
				string text2 = array[num];
				if (text2.ToLower().Contains("python"))
				{
					string fileName = Path.GetFileName(text2.TrimEnd('\\', '/'));
					if (fileName.StartsWith("python", StringComparison.OrdinalIgnoreCase))
					{
						if (FBw9EYQSjDuf9SiSbkup())
						{
							switch (0)
							{
							}
						}
						text3 = Path.Combine(text2, fileName + ".dll");
						if (System.IO.File.Exists(text3))
						{
							break;
						}
					}
				}
				num++;
				continue;
			}
			return string.Empty;
		}
		return text3;
	}

	private static string DQ2gZ2flPjh(string string_2)
	{
		return Directory.GetFiles(string_2, "python3*.dll", SearchOption.TopDirectoryOnly).FirstOrDefault(_003C_003Ec.iWeSZG8D7RR ?? (_003C_003Ec.iWeSZG8D7RR = _003C_003Ec.OKDSZkujVdc.yYeSZWx58yC));
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static RunPythonScriptStep()
	{
		VXwgZPycAdy = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		Xi5gZEjLrCO = new StepInParamDef
		{
			Key = "script",
			Name = "脚本内容",
			Description = "要运行的脚本内容",
			DefaultValue = "##.py \r\nquicker.context.SetVarValue('text', 'hello world')\r\n",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			DefaultHighlightType = "Python"
		};
		TucgZyj4txr = new StepInParamDef
		{
			Key = "pythonPath",
			Name = "Python环境路径",
			Description = "可选。Python环境(PythonXXX.dll)所在目录，留空时使用全局设置",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		UOigZ8EYrnC = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		vOxgZafbgIN = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool FBw9EYQSjDuf9SiSbkup()
	{
		return b8c68xQSeiI9960CyhlX == null;
	}

	internal static void QR28HaQSKMa7Eaeq4wrx()
	{
	}

	internal static void TAiJsNQSBYr7igcrTy5x()
	{
	}
}
