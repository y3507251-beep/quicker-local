using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using JdrL5PYdCwFnh8Pp1dR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Utilities;

namespace Quicker.View.UI;

[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class QuickerWebViewBridge
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec WHGS4An5fCv;

		public static Func<object, string> Lf5S4O30FdX;

		internal static _003C_003Ec CdHgp4WwejaskR6oMEbZ;

		static _003C_003Ec()
		{
			WHGS4An5fCv = new _003C_003Ec();
		}

		internal string ObKS4MZ7KhG(object x)
		{
			return x.ToString();
		}

		internal static void q8pKJvWw3FtL44Uy0vT5()
		{
		}

		internal static bool rbGgSeWwjn4kSWxLtRMq()
		{
			return CdHgp4WwejaskR6oMEbZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public fVXe4cYmZ7rS3HY091N.buimrRDlg8S4sGJ7OFu ENNS4loKwCc;

		public string dPtS4iHF43X;

		public string n92S43QEDhv;

		public QuickerWebViewBridge BCeS4fKd2qM;

		private static _003C_003Ec__DisplayClass13_0 XxMkLxWwEl1pEJR3VbRe;

		internal void A1WS4Fv0WsU(bool success, string result)
		{
			if (ENNS4loKwCc != null)
			{
				ENNS4loKwCc.QtALEZ6wMnT(null, success, result);
			}
		}

		internal void y29S4Uk77BR()
		{
			try
			{
				IDictionary<string, object> dictionary;
				if (!string.IsNullOrEmpty(dPtS4iHF43X))
				{
					dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(dPtS4iHF43X);
				}
				else
				{
					IDictionary<string, object> dictionary2 = new Dictionary<string, object>();
					dictionary = dictionary2;
				}
				IDictionary<string, object> inputParams = dictionary;
				IDictionary<string, object> result = SubProgramHelper.RunStandaloneSubprogram(n92S43QEDhv, inputParams, BCeS4fKd2qM.sayLECuwdBu, BCeS4fKd2qM.HPxLEE2dkrJ).GetAwaiter().GetResult();
				A1WS4Fv0WsU(true, JsonConvert.SerializeObject(result));
			}
			catch (Exception ex)
			{
				A1WS4Fv0WsU(false, ex.Message);
			}
		}

		internal static void G8fGxhWw1seYmmmGE9SH()
		{
		}

		internal static bool uPTWGZWwGaZBuI7ASKdF()
		{
			return XxMkLxWwEl1pEJR3VbRe == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteSubProgram_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string jsonData;

		public string subprogramName;

		public QuickerWebViewBridge _003C_003E4__this;

		private ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object j8frEhWwKNhD9U3SnWl4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			QuickerWebViewBridge quickerWebViewBridge = _003C_003E4__this;
			string result;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						IDictionary<string, object> dictionary;
						if (!string.IsNullOrEmpty(jsonData))
						{
							dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(jsonData);
						}
						else
						{
							IDictionary<string, object> dictionary2 = new Dictionary<string, object>();
							dictionary = dictionary2;
						}
						IDictionary<string, object> inputParams = dictionary;
						awaiter = SubProgramHelper.RunStandaloneSubprogram(subprogramName, inputParams, quickerWebViewBridge.sayLECuwdBu, quickerWebViewBridge.HPxLEE2dkrJ).ConfigureAwait(false).GetAwaiter();
						int num2 = 0;
						if (j8frEhWwKNhD9U3SnWl4 != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					result = JsonConvert.SerializeObject(awaiter.GetResult());
				}
				catch (Exception ex)
				{
					result = JsonConvert.SerializeObject(new _003C_003Ef__AnonymousType50<string>(ex.Message));
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool IoA9YOWwBlvxuBgOrvIU()
		{
			return j8frEhWwKNhD9U3SnWl4 == null;
		}
	}

	private readonly ActionExecuteContext sayLECuwdBu;

	private readonly XAction EsXLEPpPT8A;

	private readonly Window HPxLEE2dkrJ;

	private static QuickerWebViewBridge amrIcCFET64ODWpmB0bl;

	public QuickerWebViewBridge(ActionExecuteContext context, XAction action, Window window)
	{
		sayLECuwdBu = context;
		EsXLEPpPT8A = action;
		HPxLEE2dkrJ = window;
	}

	public object GetVar(string varName)
	{
		return NPDLEJ0j9Hp(sayLECuwdBu.GetVarValue(varName));
	}

	public object GetContext()
	{
		return sayLECuwdBu;
	}

	public void SetVar(string varName, object value)
	{
		LogWarningIfVarNotExists(varName);
		object result = value;
		if (value == null)
		{
			result = string.Empty;
			if (amrIcCFET64ODWpmB0bl != null)
			{
				switch (0)
				{
				}
			}
		}
		else if (value is object[] source)
		{
			result = source.Select(_003C_003Ec.Lf5S4O30FdX ?? (_003C_003Ec.Lf5S4O30FdX = _003C_003Ec.WHGS4An5fCv.ObKS4MZ7KhG)).ToList();
		}
		else if (value.GetType().Name == "__ComObject")
		{
			sayLECuwdBu.ActionLogger.LogError("不支持变量值类型(__ComObject)，变量名：" + varName);
			result = "NotSupported(__ComObject)";
		}
		XActionHelper.OutputResultToVariable(varName, result, sayLECuwdBu, EsXLEPpPT8A);
	}

	public void SetDictByJson(string varName, string json)
	{
		LogWarningIfVarNotExists(varName);
		IDictionary<string, object> result = new Dictionary<string, object>();
		if (!string.IsNullOrEmpty(json))
		{
			result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
		}
		XActionHelper.OutputResultToVariable(varName, result, sayLECuwdBu, EsXLEPpPT8A);
	}

	public void SetDictItemValue(string varName, string key, object value)
	{
		LogWarningIfVarNotExists(varName);
		Dictionary<string, object> dictionary = null;
		int num = 0;
		if (!d0sjbLFEmajRvBY64ql3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (sayLECuwdBu.IsVarExists(varName))
		{
			dictionary = sayLECuwdBu.GetVarValue(varName) as Dictionary<string, object>;
		}
		if (dictionary == null)
		{
			sayLECuwdBu.ActionLogger.LogWarning("词典变量 " + varName + " 未找到或类型不正确，将生成新的对象。");
			dictionary = new Dictionary<string, object>();
			dictionary[key] = value;
			XActionHelper.OutputResultToVariable(varName, dictionary, sayLECuwdBu, EsXLEPpPT8A);
		}
		else
		{
			dictionary[key] = value;
			sayLECuwdBu.ActionLogger.LogInfo($"词典{varName} 设置键值 key={key} value={value}");
		}
	}

	public object GetDictItemValue(string varName, string key)
	{
		Dictionary<string, object> dictionary = null;
		if (sayLECuwdBu.IsVarExists(varName))
		{
			dictionary = sayLECuwdBu.GetVarValue(varName) as Dictionary<string, object>;
		}
		if (dictionary == null)
		{
			sayLECuwdBu.ActionLogger.LogWarning("取值失败，词典变量 " + varName + " 不存在。");
			return null;
		}
		if (dictionary.ContainsKey(key))
		{
			return dictionary[key];
		}
		sayLECuwdBu.ActionLogger.LogWarning("取值失败，词典 " + varName + " 不存在key：" + key + " 已返回null。");
		return null;
	}

	public void LogWarningIfVarNotExists(string varName)
	{
		if (!sayLECuwdBu.IsVarExists(varName))
		{
			sayLECuwdBu.ActionLogger.LogWarning("变量不存在：" + varName);
		}
	}

	private static object NPDLEJ0j9Hp(object object_0)
	{
		if (object_0 is IList<string> source)
		{
			return source.ToArray();
		}
		if (object_0.IsDictionary())
		{
			return JsonConvert.SerializeObject(object_0);
		}
		if (!(object_0 is JToken))
		{
			return object_0;
		}
		return JsonConvert.SerializeObject(object_0);
	}

	public void SetWindowNoActivate(bool noActivate)
	{
		(HPxLEE2dkrJ as WebView2Window)?.SetNoActivate(noActivate);
	}

	public string Subprogram(string subprogramName, string jsonData, bool skipError = false, object callback = null)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.ENNS4loKwCc = (fVXe4cYmZ7rS3HY091N.buimrRDlg8S4sGJ7OFu)callback;
		_003C_003Ec__DisplayClass13_.dPtS4iHF43X = jsonData;
		_003C_003Ec__DisplayClass13_.n92S43QEDhv = subprogramName;
		_003C_003Ec__DisplayClass13_.BCeS4fKd2qM = this;
		try
		{
			Task.Run((Action)_003C_003Ec__DisplayClass13_.y29S4Uk77BR);
			return "";
		}
		catch (Exception ex)
		{
			return JsonConvert.SerializeObject(new _003C_003Ef__AnonymousType50<string>(ex.Message));
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteSubProgram_003Ed__14))]
	private Task<string> pJ5LE0mZZiR(string string_0, string string_1, bool bool_0)
	{
		_003CExecuteSubProgram_003Ed__14 stateMachine = default(_003CExecuteSubProgram_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.subprogramName = string_0;
		stateMachine.jsonData = string_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static QuickerWebViewBridge()
	{
	}

	internal static bool d0sjbLFEmajRvBY64ql3()
	{
		return amrIcCFET64ODWpmB0bl == null;
	}

	internal static void VgNQGqFE46BetDE2AfCg()
	{
	}
}
