using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using j9PVNbXS3U4MP7j5Ps6;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.VersionUpdate;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.Runner;

public class XActionRunner : ActionRunnerBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass5_0
	{
		public IList<ActionStep> NddvF0TQYPj;

		public string olJvFCHrvhA;

		public int wmbvFPkNEoq;

		public ActionExecuteContext fW9vFET7gOn;

		public XAction MWnvFyE17FZ;
	}

	private static readonly ILog gSlt5XpjfUA;

	internal static XActionRunner FTZk52QfWU70mpv0ndes;

	public static string GetVarStateKey(string varKey)
	{
		return "$var:" + varKey;
	}

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		if (!string.IsNullOrEmpty(action.MinQuickerVersion) && SoftVersionHelper.IsVersionNewer(action.MinQuickerVersion, AppHelper.GetCurrAppVersion()))
		{
			AppHelper.ShowRequireVersionWindow(action.MinQuickerVersion);
			return;
		}
		if (actionExecuteContext.IsDebugging)
		{
			actionExecuteContext.ActionLogger.LogInfo("开始执行动作：" + action.Title + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		}
		if (string.IsNullOrEmpty(action.Data))
		{
			int num = 0;
			if (!xl1bafQfymmDjgfUTGR8())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.ShowWarning(CommonStrings.XActionRunner_ExecuteAction_Err_DataEmpty);
			actionExecuteContext.ActionLogger.LogError("动作数据为空！");
			return;
		}
		try
		{
        string inputParam = default;
			XAction xAction = JsonConvert.DeserializeObject<XAction>(action.Data);
			int num3;
			if (xAction == null)
			{
				num3 = 1;
				if (FTZk52QfWU70mpv0ndes == null)
				{
					goto IL_00fb;
				}
				goto IL_01d9;
			}
			if (xAction.LimitSingleInstance)
			{
				goto IL_0115;
			}
			goto IL_017c;
			IL_015c:
			actionExecuteContext.XProgram = xAction;
			inputParam = actionExecuteContext.InputParam;
			if (actionExecuteContext.IsDebugging)
			{
				actionExecuteContext.ActionLogger.BeginRepeat("动作初始化");
				if (!string.IsNullOrEmpty(inputParam))
				{
					actionExecuteContext.ActionLogger.LogInfo("动作参数：" + inputParam);
				}
			}
			if (xAction.Variables != null)
			{
				num3 = 0;
				if (FTZk52QfWU70mpv0ndes != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				goto IL_00fb;
			}
			goto IL_02de;
			IL_017c:
			int num5 = 50;
			if (server.GetActionRunningCount(action.Id) >= 50)
			{
				actionExecuteContext.ActionLogger.LogError($"动作同时运行个数已达上限({num5})。");
				AppHelper.ShowWarning("动作 " + action.Title + $" 已同时运行个数已达上限({num5})。请检查动作中是否意外产生了循环。");
				return;
			}
			goto IL_015c;
			IL_00fb:
			switch (num3)
			{
			case 2:
				break;
			case 3:
				goto IL_017c;
			default:
				goto IL_01d9;
			case 1:
				actionExecuteContext.ActionLogger.LogError("动作数据不是XAction！");
				return;
			}
			goto IL_0115;
			IL_02de:
			G6Et51oQgIC(actionExecuteContext, inputParam, xAction);
			if (actionExecuteContext.IsDebugging)
			{
				actionExecuteContext.ActionLogger.EndRepeat();
			}
			if (xAction.Steps != null && xAction.Steps.Count != 0)
			{
				RunChildSteps(xAction.Steps, 0, actionExecuteContext, xAction, "");
				if (xAction.Variables != null)
				{
					foreach (ActionVariable variable in xAction.Variables)
					{
						if (variable.SaveState)
						{
							string variableActionStateValue = XActionHelper.GetVariableActionStateValue(actionExecuteContext.GetVarValue(variable.Key));
							ActionStateWriter.WriteActionState(action.Id, GetVarStateKey(variable.Key), variableActionStateValue);
						}
					}
				}
				if (actionExecuteContext.IsDebugging)
				{
					actionExecuteContext.ActionLogger.LogInfo($"动作结束。耗时：{(DateTime.Now - actionExecuteContext.StartTime).TotalMilliseconds}ms");
				}
			}
			else
			{
				AppHelper.ShowWarning(CommonStrings.XActionRunner_ExecuteAction_Err_DataEmpty);
				actionExecuteContext.ActionLogger.LogWarning(CommonStrings.XActionRunner_ExecuteAction_Err_DataEmpty);
			}
			return;
			IL_0115:
			if (server.IsCurrentActionRunning(action.Id))
			{
				actionExecuteContext.ActionLogger.LogError("动作已在运行，退出执行。");
				AppHelper.ShowWarning("动作 " + action.Title + " 已在执行。");
				return;
			}
			goto IL_015c;
			IL_01d9:
			foreach (ActionVariable variable2 in xAction.Variables)
			{
				try
				{
					R76t5bSscon(action, actionExecuteContext, variable2);
				}
				catch (Exception exception)
				{
					gSlt5XpjfUA.Warn("动作变量 " + variable2.Key + " 初始化异常。" + exception.GetMessageWithInner(), exception);
					string message = "动作变量 " + variable2.Key + " 初始化异常。" + exception.GetMessageWithInner();
					actionExecuteContext.ActionLogger.LogError(message);
					AppHelper.ShowWarning(message);
					return;
				}
			}
			actionExecuteContext.SetVarValueWithoutConvert("quicker_in_param", inputParam ?? string.Empty);
			goto IL_02de;
		}
		catch (Exception exception2)
		{
			actionExecuteContext.ActionLogger.LogWarning("动作运行异常。" + exception2.GetMessageWithInner());
			throw;
		}
		finally
		{
			ProgressReportMgr.ClearContextProgress(actionExecuteContext.Id);
		}
	}

	private void G6Et51oQgIC(ActionExecuteContext actionExecuteContext_0, string string_0, XAction xaction_0)
	{
		if (string.IsNullOrEmpty(string_0) || !string_0.Contains("write_to_vars"))
		{
			return;
		}
		actionExecuteContext_0.ActionLogger.LogInfo("将参数传入变量中...");
		IDictionary<string, object> dictionary = null;
		string_0 = string_0.Trim();
		if (string_0.Contains("write_to_vars=true"))
		{
			dictionary = string_0.QueryStringToDict();
		}
		else
		{
			if (!string_0.StartsWith("{") || !string_0.EndsWith("}") || !string_0.Contains("write_to_vars"))
			{
				goto IL_00c9;
			}
			dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(string_0);
		}
		goto IL_0079;
		IL_00c9:
		if (string_0.StartsWith("%7b", StringComparison.OrdinalIgnoreCase) && string_0.EndsWith("%7d", StringComparison.OrdinalIgnoreCase))
		{
			dictionary = JsonConvert.DeserializeObject<IDictionary<string, object>>(string_0.UrlDecode());
		}
		goto IL_0079;
		IL_0079:
		if (dictionary == null)
		{
			actionExecuteContext_0.ActionLogger.LogWarning("参数格式不正确，无法传入变量。");
			if (!xl1bafQfymmDjgfUTGR8())
			{
				switch (0)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				goto IL_00c9;
			}
			return;
		}
		if (!dictionary.TryGetValue("write_to_vars", out var value))
		{
			actionExecuteContext_0.ActionLogger.LogWarning("参数格式不正确,缺少write_to_vars键，无法传入变量。");
			return;
		}
		if (VariableHelper.ConvertToBoolean(value) != true)
		{
			actionExecuteContext_0.ActionLogger.LogWarning("write_to_vars为false，不传入变量。");
			return;
		}
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			if (item.Key == "write_to_vars")
			{
				continue;
			}
			try
			{
				if (actionExecuteContext_0.IsVarExists(item.Key))
				{
					XActionHelper.OutputResultToVariable(item.Key, item.Value, actionExecuteContext_0, xaction_0);
				}
				else
				{
					actionExecuteContext_0.ActionLogger.LogWarning("未找到变量：" + item.Key);
				}
			}
			catch (Exception exception)
			{
				gSlt5XpjfUA.Warn("动作变量 " + item.Key + " 参数传递异常。" + exception.GetMessageWithInner(), exception);
				string message = "动作变量 " + item.Key + " 参数传递异常。" + exception.GetMessageWithInner();
				actionExecuteContext_0.ActionLogger.LogError(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	private static void R76t5bSscon(ActionItem actionItem_0, ActionExecuteContext actionExecuteContext_0, ActionVariable actionVariable_0)
	{
        (bool, string) tuple2 = default;
        string defaultValueStr = default;
		DataTable dataTable = default(DataTable);
		string text = default(string);
		int num;
		if (actionVariable_0.Type == VarType.Table)
		{
			dataTable = new DataTable();
			if (actionVariable_0.TableDef != null)
			{
				zsVr57XToYMFTdxtZho.aNOghYZ7hRs(dataTable, actionVariable_0.TableDef);
			}
			text = actionVariable_0.DefaultValue;
			if (actionVariable_0.SaveState)
			{
				(bool, string) tuple = ActionStateWriter.ReadActionStateValue(actionItem_0.Id, GetVarStateKey(actionVariable_0.Key));
				if (tuple.Item1)
				{
					text = tuple.Item2;
				}
				actionExecuteContext_0.ActionLogger.LogLoadState(actionVariable_0.Key, tuple.Item2);
				num = 0;
				if (FTZk52QfWU70mpv0ndes != null)
				{
					goto IL_00db;
				}
			}
			goto IL_0102;
		}
		defaultValueStr = actionVariable_0.DefaultValue;
		tuple2 = default((bool, string));
		if (actionVariable_0.SaveState)
		{
			tuple2 = ActionStateWriter.ReadActionStateValue(actionItem_0.Id, GetVarStateKey(actionVariable_0.Key));
			if (tuple2.Item1)
			{
				defaultValueStr = tuple2.Item2;
				num = 0;
				if (!xl1bafQfymmDjgfUTGR8())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00db;
			}
		}
		goto IL_0123;
		IL_0123:
		actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, VariableHelper.ConvertVarDefaultValue(actionVariable_0.Type, defaultValueStr));
		return;
		IL_00db:
		switch (num)
		{
		case 1:
			goto IL_0102;
		}
		actionExecuteContext_0.ActionLogger.LogLoadState(actionVariable_0.Key, tuple2.Item2);
		goto IL_0123;
		IL_0102:
		if (!string.IsNullOrEmpty(text))
		{
			dataTable.mFighIebWbm(text);
		}
		actionExecuteContext_0.SetVarValueWithoutConvert(actionVariable_0.Key, dataTable);
	}

	public static void RunChildSteps(IList<ActionStep> steps, int startIndex, ActionExecuteContext actionExecuteContext, XAction action, string parentStepId)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_0_ = default(_003C_003Ec__DisplayClass5_0);
		_003C_003Ec__DisplayClass5_0_.NddvF0TQYPj = steps;
		_003C_003Ec__DisplayClass5_0_.olJvFCHrvhA = parentStepId;
		_003C_003Ec__DisplayClass5_0_.fW9vFET7gOn = actionExecuteContext;
		_003C_003Ec__DisplayClass5_0_.MWnvFyE17FZ = action;
		_003C_003Ec__DisplayClass5_0_.wmbvFPkNEoq = startIndex;
		_003C_003Ec__DisplayClass5_0_.fW9vFET7gOn.ActionLogger.BeginStepGroup("", _003C_003Ec__DisplayClass5_0_.NddvF0TQYPj.Count);
		try
		{
			d34t56vO2ht(ref _003C_003Ec__DisplayClass5_0_);
		}
		catch (Exception ex)
		{
			_003C_003Ec__DisplayClass5_0_.fW9vFET7gOn.StopAction(ActionStopFlag.OperationFailed, "执行动作出错：" + ex.Message);
		}
		finally
		{
			_003C_003Ec__DisplayClass5_0_.fW9vFET7gOn.ActionLogger.EndStepGroup();
		}
	}

	static XActionRunner()
	{
		gSlt5XpjfUA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static void d34t56vO2ht(ref _003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_0_0)
	{
		using IEnumerator<ActionStep> enumerator = _003C_003Ec__DisplayClass5_0_0.NddvF0TQYPj.GetEnumerator();
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			if (enumerator.MoveNext())
			{
				ActionStep current = enumerator.Current;
				string stepId = _003C_003Ec__DisplayClass5_0_0.olJvFCHrvhA + (string.IsNullOrEmpty(_003C_003Ec__DisplayClass5_0_0.olJvFCHrvhA) ? string.Empty : ".") + _003C_003Ec__DisplayClass5_0_0.wmbvFPkNEoq;
				_003C_003Ec__DisplayClass5_0_0.wmbvFPkNEoq++;
				long num = 0L;
				if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
				{
					num = AppState.TickCount;
					_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.BeginStep(current, stepId);
				}
				try
				{
					if (current.Disabled)
					{
						if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
						{
							_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogInfo("已禁用，跳过");
							int num2 = 0;
							if (!xl1bafQfymmDjgfUTGR8())
							{
								num2 = num3;
							}
							switch (num2)
							{
							case 0:
								break;
							}
						}
					}
					else
					{
						IStepRunner runner = StepRunnerRegistry.GetRunner(current.StepRunnerKey);
						if (runner == null)
						{
							AppHelper.ShowWarning(string.Format(CultureInfo.InvariantCulture, CommonStrings.XActionRunner_ExecuteAction_Err_UnknownStepType, current.StepRunnerKey));
							if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
							{
								_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogError(string.Format(CultureInfo.InvariantCulture, CommonStrings.XActionRunner_ExecuteAction_Err_UnknownStepType, current.StepRunnerKey));
							}
							break;
						}
						runner.Execute(current, _003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn, _003C_003Ec__DisplayClass5_0_0.MWnvFyE17FZ, stepId);
						if (current.DelayMs > 0)
						{
							Thread.Sleep(current.DelayMs);
							if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
							{
								_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogInfo($"延迟：{current.DelayMs}ms");
							}
						}
					}
				}
				finally
				{
					if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
					{
						if (!current.Disabled && !current.IfSteps.HasData() && !current.ElseSteps.HasData())
						{
							_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogInfo($"耗时：{AppState.TickCount - num}ms");
						}
						_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.EndStep();
					}
				}
				if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsShouldStopAction())
				{
					if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
					{
						_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogWarning($"检测到了中止标志({_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.StopFlag})，停止后续步骤执行。");
					}
					break;
				}
				if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.BreakFlag)
				{
					if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
					{
						_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogWarning("检测到了Break标志，停止子程序的后续模块。");
					}
					break;
				}
			}
			else
			{
				int num4 = 0;
				if (!xl1bafQfymmDjgfUTGR8())
				{
					num4 = num5;
				}
				switch (num4)
				{
				case 1:
					break;
				default:
					return;
				case 0:
					return;
				}
			}
			if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ShouldContinue())
			{
				if (_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.IsDebugging)
				{
					_003C_003Ec__DisplayClass5_0_0.fW9vFET7gOn.ActionLogger.LogWarning("检测到了Continue标志，停止子程序的后续模块。");
				}
				break;
			}
		}
	}

	internal static bool xl1bafQfymmDjgfUTGR8()
	{
		return FTZk52QfWU70mpv0ndes == null;
	}
}
