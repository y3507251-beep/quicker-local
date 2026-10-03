using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using j9PVNbXS3U4MP7j5Ps6;
using Newtonsoft.Json;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Text;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Actions.X.SubPrograms;

public static class SubProgramHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec AxwvUNH73Bg;

		public static Func<ActionVariable, bool> OYDvUJqcoYk;

		internal static _003C_003Ec WDEgvDWAW5ieHXX78mj9;

		static _003C_003Ec()
		{
			AxwvUNH73Bg = new _003C_003Ec();
		}

		internal bool AyLvUuaOxqe(ActionVariable x)
		{
			return x.IsOutput;
		}

		internal static bool u9l2WlWAyfB3hpM2FFJN()
		{
			return WDEgvDWAW5ieHXX78mj9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public string kP2vUPqI8q4;

		public string JOMvUEy1is3;

		public Action<ActionStep> sJHvUyInNNt;

		internal static _003C_003Ec__DisplayClass12_0 xfPRBpWAXEKTRGikZqE1;

		internal void DrhvU0H1IE3(ActionStep step)
		{
			iMhtdaRyJcB(step, kP2vUPqI8q4, JOMvUEy1is3);
		}

		internal void fDdvUCR1Bqu(ActionStep step)
		{
			iMhtdaRyJcB(step, kP2vUPqI8q4, JOMvUEy1is3);
		}

		internal static bool ITN20PWA2One22NAHRy8()
		{
			return xfPRBpWAXEKTRGikZqE1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public SubProgram TgNvUaA0BdG;

		public string XxuvU76qbWO;

		internal static _003C_003Ec__DisplayClass15_0 G7FyQiWAng9pA4dL9r44;

		internal bool qklvU86jAIS(ActionStep step)
		{
			if (step.StepRunnerKey == "sys:subprogram")
			{
				return string.Equals(SubProgramStep.GetSubProgramIdentifier(step), TgNvUaA0BdG.Name, StringComparison.OrdinalIgnoreCase);
			}
			if (step.StepRunnerKey == "sys:showText" && step.InputParams.ContainsKey(ShowTextStep.OperationInputParam.Key))
			{
				string value = step.InputParams[ShowTextStep.OperationInputParam.Key].Value;
				if (string.IsNullOrEmpty(value))
				{
					return false;
				}
				return value.IndexOf(XxuvU76qbWO, StringComparison.OrdinalIgnoreCase) >= 0;
			}
			return false;
		}

		internal static bool MDPr3qWAehjmW9IH2tGD()
		{
			return G7FyQiWAng9pA4dL9r44 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public ActionExecuteContext RIFvUque5ym;

		public Window yaTvUc4Y9VV;

		public SubProgram mSQvUVZkIXO;

		public IDictionary<string, object> koKvUZr20DL;

		public IDictionary<string, object> E3jvU9pP63U;

		public bool X38vUhrntja;

		public bool Cp7vUeK9m0v;

		internal static _003C_003Ec__DisplayClass18_0 E78WgEWA3Pf3nPYDNbgO;

		internal void SqUvURV4Al7()
		{
			using ActionExecuteContext actionExecuteContext = new ActionExecuteContext(RIFvUque5ym, RIFvUque5ym.Action, RIFvUque5ym.TargetInfo, RIFvUque5ym.AppServer, RIFvUque5ym.IsDebugging, RIFvUque5ym.Id, null, RIFvUque5ym.CancellationToken);
			actionExecuteContext.ParentWindow = yaTvUc4Y9VV;
			RIFvUque5ym.ChildContext = actionExecuteContext;
			try
			{
				XAction action = (XAction)(actionExecuteContext.XProgram = new XAction
				{
					Steps = mSQvUVZkIXO.Steps,
					Variables = mSQvUVZkIXO.Variables,
					SubPrograms = RIFvUque5ym.XProgram?.SubPrograms
				});
				actionExecuteContext.ActionLogger = RIFvUque5ym.ActionLogger;
				actionExecuteContext.SetVarValueWithoutConvert("quicker_in_param", actionExecuteContext.RootContext.InputParam ?? string.Empty);
				int num = 1;
				if (E78WgEWA3Pf3nPYDNbgO != null)
				{
					goto IL_00fc;
				}
				goto IL_027b;
				IL_00fc:
				if (mSQvUVZkIXO.Variables.HasData())
				{
					foreach (ActionVariable variable in mSQvUVZkIXO.Variables)
					{
						try
						{
							ajQtdRtJ19o(variable, actionExecuteContext, koKvUZr20DL, RIFvUque5ym);
						}
						catch (Exception ex)
						{
							throw new SubProgramFailedException("初始化变量失败：" + variable.Key + "，" + ex.Message, actionExecuteContext);
						}
					}
				}
				XActionRunner.RunChildSteps(mSQvUVZkIXO.Steps, 0, actionExecuteContext, action, "");
				if (!actionExecuteContext.ReturnError)
				{
					foreach (ActionVariable item in mSQvUVZkIXO.Variables.Where(_003C_003Ec.OYDvUJqcoYk ?? (_003C_003Ec.OYDvUJqcoYk = _003C_003Ec.AxwvUNH73Bg.AyLvUuaOxqe)))
					{
						E3jvU9pP63U.Add(item.Key, actionExecuteContext.GetVarValue(item.Key));
					}
					if ((!X38vUhrntja || actionExecuteContext.StopFlag != ActionStopFlag.UserCancel) && Cp7vUeK9m0v)
					{
						if (!actionExecuteContext.StopFlag.IsEither(ActionStopFlag.ForceStop))
						{
							if (actionExecuteContext.StopFlag != ActionStopFlag.NoStop)
							{
								num = 0;
								if (!PHrwijWAEqUbTYJgtH5t())
								{
									int num2 = default(int);
									num = num2;
								}
								goto IL_027b;
							}
							return;
						}
						throw new SubProgramFailedException("子程序(" + mSQvUVZkIXO.Name + ")已返回失败。" + actionExecuteContext.ErrorMessage, actionExecuteContext);
					}
					return;
				}
				throw new Exception("子程序 " + mSQvUVZkIXO.Name + " 运行失败：" + actionExecuteContext.ReturnResult);
				IL_027b:
				switch (num)
				{
				case 1:
					break;
				default:
					if (actionExecuteContext.StopFlag != ActionStopFlag.StopFromCode)
					{
						throw new SubProgramFailedException("子程序(" + mSQvUVZkIXO.Name + ")返回中止。" + actionExecuteContext.ErrorMessage, actionExecuteContext);
					}
					return;
				}
				goto IL_00fc;
			}
			catch (Exception)
			{
				if (Cp7vUeK9m0v)
				{
					throw;
				}
			}
			finally
			{
				RIFvUque5ym.ChildContext = null;
			}
		}

		internal static bool PHrwijWAEqUbTYJgtH5t()
		{
			return E78WgEWA3Pf3nPYDNbgO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string PdJvUWXuDo8;

		private static _003C_003Ec__DisplayClass3_0 nq1IXjWABreUZJL3d21M;

		internal bool GxevUYLDxrd(SubProgram x)
		{
			return x.Name == PdJvUWXuDo8;
		}

		internal bool NFqvUI3QQgt(SubProgram x)
		{
			return x.Name == PdJvUWXuDo8;
		}

		internal static bool IbdglSWAv9F3ecNK3Jav()
		{
			return nq1IXjWABreUZJL3d21M == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public SubProgram kr3vUG8griE;

		internal static _003C_003Ec__DisplayClass9_0 D8Z9mvWAOe9puEarQBJs;

		internal bool iPIvUkygLAm(ActionStep step)
		{
			if (step.StepRunnerKey == "sys:subprogram")
			{
				_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1
				{
					CHyvUHpqYZW = SubProgramStep.GetSubProgramIdentifier(step)
				};
				if (SubProgramStep.IsInternalSubProgram(step) && kr3vUG8griE.SubPrograms.HasData() && !kr3vUG8griE.SubPrograms.Any(_003C_003Ec__DisplayClass9_.IvZvUsGJHd6))
				{
					return true;
				}
			}
			return false;
		}

		internal static bool zmUgCGWAJSFprCoRu9W0()
		{
			return D8Z9mvWAOe9puEarQBJs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_1
	{
		public string CHyvUHpqYZW;

		private static _003C_003Ec__DisplayClass9_1 TdhECTWAaW9rEUCcUK5H;

		internal bool IvZvUsGJHd6(SubProgram x)
		{
			return x.Name == CHyvUHpqYZW;
		}

		internal static bool kHTyNwWArRBB2FqlJ3CZ()
		{
			return TdhECTWAaW9rEUCcUK5H == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunStandaloneSubprogram_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

		public ActionExecuteContext context;

		public Window parentWindow;

		public IDictionary<string, object> inputParams;

		public bool skipUserCancel;

		public bool throwIfFail;

		public string subProgramName;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object uOum5GWA9b2t8duWCA6F;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IDictionary<string, object> result;
			try
			{
				int num2;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass18_0();
					_003C_003E8__1.RIFvUque5ym = context;
					_003C_003E8__1.yaTvUc4Y9VV = parentWindow;
					_003C_003E8__1.koKvUZr20DL = inputParams;
					num2 = 1;
					if (!tUamrKWALkwNcdPLoCYB())
					{
						int num3 = default(int);
						num2 = num3;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					num2 = 0;
					if (!tUamrKWALkwNcdPLoCYB())
					{
						goto IL_0198;
					}
				}
				switch (num2)
				{
				case 1:
					_003C_003E8__1.X38vUhrntja = skipUserCancel;
					_003C_003E8__1.Cp7vUeK9m0v = throwIfFail;
					_003C_003E8__1.E3jvU9pP63U = new Dictionary<string, object>();
					_003C_003E8__1.mSQvUVZkIXO = SubProgramStep.GetSubProgram(_003C_003E8__1.RIFvUque5ym, subProgramName);
					if (_003C_003E8__1.mSQvUVZkIXO == null)
					{
						throw new InvalidOperationException("无法找到子程序：" + subProgramName);
					}
					awaiter = GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(_003C_003E8__1.SqUvURV4Al7, "sp:" + subProgramName + "@" + _003C_003E8__1.RIFvUque5ym?.Action.Title).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				}
				goto IL_0198;
				IL_0198:
				awaiter.GetResult();
				result = _003C_003E8__1.E3jvU9pP63U;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool tUamrKWALkwNcdPLoCYB()
		{
			return uOum5GWA9b2t8duWCA6F == null;
		}
	}

	internal static object nDwaQ7QqEJ1ZrrgJqF3L;

	public static ActionItem CreateWrapperAction(SubProgram globalSubProgram)
	{
		XAction value = new XAction
		{
			Variables = globalSubProgram.Variables,
			SubPrograms = globalSubProgram.SubPrograms,
			Steps = globalSubProgram.Steps,
			SummaryExpression = globalSubProgram.SummaryExpression
		};
		return new ActionItem
		{
			ActionType = ActionType.XAction,
			Id = globalSubProgram.Id,
			Title = globalSubProgram.Name,
			Description = globalSubProgram.Description,
			CreateTimeUtc = globalSubProgram.CreateTimeUtc,
			LastEditTimeUtc = globalSubProgram.LastEditTimeUtc,
			TemplateId = globalSubProgram.TemplateId,
			TemplateRevision = globalSubProgram.TemplateRevision,
			SharedActionId = globalSubProgram.SharedId,
			ShareTimeUtc = globalSubProgram.ShareTimeUtc,
			Data = JsonConvert.SerializeObject(value)
		};
	}

	public static SubProgram GetGlobalSubProgramFromWrapperAction(ActionItem action)
	{
		if (action == null)
		{
			return null;
		}
		SubProgram obj = new SubProgram
		{
			Id = action.Id,
			Name = action.Title,
			Description = action.Description,
			CreateTimeUtc = (action.CreateTimeUtc ?? DateTime.UtcNow),
			LastEditTimeUtc = action.LastEditTimeUtc,
			TemplateId = action.TemplateId,
			TemplateRevision = action.TemplateRevision,
			SharedId = action.SharedActionId,
			ShareTimeUtc = action.ShareTimeUtc
		};
		XAction xAction = JsonConvert.DeserializeObject<XAction>(action.Data);
		obj.SummaryExpression = xAction.SummaryExpression;
		obj.Variables = xAction.Variables;
		obj.SubPrograms = xAction.SubPrograms;
		obj.Steps = xAction.Steps;
		return obj;
	}

	public static SubProgram GetSubProgramFromSharedAction(SharedActionDto action)
	{
		if (action == null)
		{
			return null;
		}
		SubProgram obj = new SubProgram
		{
			Id = action.Id.ToString(),
			Name = action.Title,
			Description = action.Description,
			CreateTimeUtc = action.CreateTimeUtc,
			LastEditTimeUtc = null,
			TemplateId = action.Id.ToString(),
			TemplateRevision = action.Revision,
			SharedId = null,
			ShareTimeUtc = null
		};
		XAction xAction = JsonConvert.DeserializeObject<XAction>(action.Data);
		obj.Variables = xAction.Variables;
		obj.SubPrograms = xAction.SubPrograms;
		obj.Steps = xAction.Steps;
		obj.SummaryExpression = xAction.SummaryExpression;
		return obj;
	}

	public static SubProgram GetSubProgramByIdentifier(string identifier, IEnumerable<SubProgram> actionSubPrograms)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.PdJvUWXuDo8 = identifier;
		if (actionSubPrograms != null && _003C_003Ec__DisplayClass3_.PdJvUWXuDo8 != null)
		{
			if (_003C_003Ec__DisplayClass3_.PdJvUWXuDo8.StartsWith("%%", StringComparison.Ordinal))
			{
				return AppState.DataService.GetGlobalSubProgram(_003C_003Ec__DisplayClass3_.PdJvUWXuDo8.Substring(2));
			}
			if (_003C_003Ec__DisplayClass3_.PdJvUWXuDo8.StartsWith("@@", StringComparison.Ordinal))
			{
				string[] array = _003C_003Ec__DisplayClass3_.PdJvUWXuDo8.Substring(2).Split(new char[1] { '@' }, 3);
				if (array.Length != 3)
				{
					return actionSubPrograms?.FirstOrDefault(_003C_003Ec__DisplayClass3_.GxevUYLDxrd);
				}
				return AppState.DataService.GetSharedSubProgram(array[0], array[1]);
			}
			return actionSubPrograms?.FirstOrDefault(_003C_003Ec__DisplayClass3_.NFqvUI3QQgt);
		}
		return null;
	}

	public static (string id, string version, string title) ExtractNetworkShareSpInfo(string identifier)
	{
		if (!identifier.StartsWith("@@", StringComparison.Ordinal))
		{
			AppHelper.ShowWarning("不是一个合法的网络子程序标识.");
			return (id: null, version: null, title: null);
		}
		string[] array = identifier.Substring(2).Split(new char[1] { '@' }, 3);
		return (id: array[0], version: array[1], title: array[2]);
	}

	public static (Guid id, int version, string title) ParseNetSharedSpIdentifier(string identifier)
	{
		string[] array = identifier.Substring(2).Split(new char[1] { '@' }, 3);
		if (array.Length != 3)
		{
			return (id: Guid.Empty, version: 0, title: "");
		}
		return (id: Guid.Parse(array[0]), version: int.Parse(array[1]), title: array[2]);
	}

	public static string GetNetSharedSpIdentifier(Guid id, int version, string title)
	{
		return $"@@{id}@{version}@{title}";
	}

	public static string GetNetSharedSubProgramLink(string identifier)
	{
		if (!identifier.StartsWith("@@"))
		{
			return "";
		}
		string[] array = identifier.Substring(2).Split(new char[1] { '@' }, 3);
		return "https://getquicker.net/subprogram?id=" + array[0] + "&version=" + array[1];
	}

	public static string GetGlobalSubProgramIdentifier(SubProgram subProgram)
	{
		return "%%" + subProgram.Id;
	}

	public static bool CanInternalSubProgramBeConvertedToGlobal(SubProgram subProgram)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.kr3vUG8griE = subProgram;
		return !XActionHelper.IsStepExists(_003C_003Ec__DisplayClass9_.kr3vUG8griE.Steps, _003C_003Ec__DisplayClass9_.iPIvUkygLAm);
	}

	public static void ConvertInternalSubProgramToGlobal(XAction action, SubProgram internalSubProgram, SubProgram globalSubProgram)
	{
		string name = internalSubProgram.Name;
		string globalSubProgramIdentifier = GetGlobalSubProgramIdentifier(globalSubProgram);
		ReplaceActionSubProgramIdentifier(action, name, globalSubProgramIdentifier);
	}

	public static void ReplaceInternalSubProgramName(XAction action, string oldName, string newName)
	{
		ReplaceActionSubProgramIdentifier(action, oldName, newName);
	}

	public static void ReplaceActionSubProgramIdentifier(XAction action, string oldIdentifier, string newIdentifier)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.kP2vUPqI8q4 = oldIdentifier;
		_003C_003Ec__DisplayClass12_.JOMvUEy1is3 = newIdentifier;
		XActionHelper.TravelSteps(action.Steps, _003C_003Ec__DisplayClass12_.DrhvU0H1IE3);
		if (!action.SubPrograms.HasData())
		{
			return;
		}
		foreach (SubProgram subProgram in action.SubPrograms)
		{
			XActionHelper.TravelSteps(subProgram.Steps, _003C_003Ec__DisplayClass12_.sJHvUyInNNt ?? (_003C_003Ec__DisplayClass12_.sJHvUyInNNt = _003C_003Ec__DisplayClass12_.fDdvUCR1Bqu));
		}
	}

	private static void iMhtdaRyJcB(ActionStep actionStep_0, string string_0, string string_1)
	{
		if (actionStep_0 == null)
		{
			return;
		}
		if (!(actionStep_0.StepRunnerKey == "sys:subprogram"))
		{
			if (actionStep_0.StepRunnerKey == "sys:showText")
			{
				lI7td7gDMoD(actionStep_0, string_0, string_1);
			}
		}
		else if (actionStep_0.InputParams.ContainsKey(SubProgramStep.SubProgramNameParam.Key) && string.Equals(actionStep_0.InputParams[SubProgramStep.SubProgramNameParam.Key].Value, string_0, StringComparison.OrdinalIgnoreCase))
		{
			actionStep_0.InputParams[SubProgramStep.SubProgramNameParam.Key].Value = string_1;
		}
	}

	private static void lI7td7gDMoD(ActionStep actionStep_0, string string_0, string string_1)
	{
		if (!(actionStep_0.StepRunnerKey == "sys:showText"))
		{
			return;
		}
		string oldValue = "$sp$" + string_0;
		string newValue = "$sp$" + string_1;
		try
		{
			if (actionStep_0.InputParams.ContainsKey(ShowTextStep.OperationInputParam.Key))
			{
				string value = actionStep_0.InputParams[ShowTextStep.OperationInputParam.Key].Value;
				if (!string.IsNullOrEmpty(value))
				{
					value = value.Replace(oldValue, newValue);
					actionStep_0.InputParams[ShowTextStep.OperationInputParam.Key].Value = value;
				}
			}
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static bool IsInternalSubProgramUsedInAction(SubProgram subProgram, XAction action)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.TgNvUaA0BdG = subProgram;
		_003C_003Ec__DisplayClass15_.XxuvU76qbWO = "$sp$" + _003C_003Ec__DisplayClass15_.TgNvUaA0BdG.Name;
		Func<ActionStep, bool> predictFunc = _003C_003Ec__DisplayClass15_.qklvU86jAIS;
		if (XActionHelper.IsStepExists(action.Steps, predictFunc))
		{
			return true;
		}
		if (action.SubPrograms.HasData())
		{
			foreach (SubProgram subProgram2 in action.SubPrograms)
			{
				if (XActionHelper.IsStepExists(subProgram2.Steps, predictFunc))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool IsValidSubProgramName(string subProgramName)
	{
		if (!subProgramName.ContainsAny("@", "%", ",", "$", " ", "?", "&"))
		{
			return true;
		}
		return false;
	}

	public static bool IsInternalSubProgramName(string identifier)
	{
		if (string.IsNullOrEmpty(identifier))
		{
			return true;
		}
		if (identifier.StartsWith("@@", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		return !identifier.StartsWith("%%", StringComparison.OrdinalIgnoreCase);
	}

	[AsyncStateMachine(typeof(_003CRunStandaloneSubprogram_003Ed__18))]
	public static Task<IDictionary<string, object>> RunStandaloneSubprogram(string subProgramName, IDictionary<string, object> inputParams, ActionExecuteContext context, Window parentWindow, bool skipUserCancel = false, bool throwIfFail = false)
	{
		_003CRunStandaloneSubprogram_003Ed__18 stateMachine = default(_003CRunStandaloneSubprogram_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDictionary<string, object>>.Create();
		stateMachine.subProgramName = subProgramName;
		stateMachine.inputParams = inputParams;
		stateMachine.context = context;
		stateMachine.parentWindow = parentWindow;
		stateMachine.skipUserCancel = skipUserCancel;
		stateMachine.throwIfFail = throwIfFail;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static void ajQtdRtJ19o(ActionVariable actionVariable_0, ActionExecuteContext actionExecuteContext_0, IDictionary<string, object> idictionary_0, ActionExecuteContext actionExecuteContext_1)
	{
		if (actionVariable_0.Type == VarType.Table)
		{
			DataTable dataTable = new DataTable();
			if (actionVariable_0.TableDef != null)
			{
				zsVr57XToYMFTdxtZho.aNOghYZ7hRs(dataTable, actionVariable_0.TableDef);
			}
			if (actionVariable_0.IsInput)
			{
				if (idictionary_0.ContainsKey(actionVariable_0.Key))
				{
					actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertToType(VarType.Table, idictionary_0[actionVariable_0.Key]));
					return;
				}
				string defaultValue = actionVariable_0.DefaultValue;
				if (!string.IsNullOrEmpty(defaultValue))
				{
					dataTable.mFighIebWbm(defaultValue);
				}
				actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, dataTable);
			}
			else
			{
				string defaultValue2 = actionVariable_0.DefaultValue;
				if (!string.IsNullOrEmpty(defaultValue2))
				{
					dataTable.mFighIebWbm(defaultValue2);
				}
				actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, dataTable);
			}
		}
		else if (actionVariable_0.IsInput && idictionary_0 != null && idictionary_0.ContainsKey(actionVariable_0.Key))
		{
			actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertToType(actionVariable_0.Type, idictionary_0[actionVariable_0.Key]));
		}
		else
		{
			actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertVarDefaultValue(actionVariable_0.Type, actionVariable_0.DefaultValue));
		}
	}

	internal static bool KqwDkmQqGjaB2JHKMg4C()
	{
		return nDwaQ7QqEJ1ZrrgJqF3L == null;
	}
}
