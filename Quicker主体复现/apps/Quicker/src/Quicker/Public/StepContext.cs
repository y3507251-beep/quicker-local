using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Entities;
using Quicker.Public.Interfaces;

namespace Quicker.Public;

public class StepContext : IActionContext, IStepContext
{
	private readonly ActionStep Wf5B0N4r87;

	private readonly XAction w8NBCv2fEJ;

	private readonly ActionExecuteContext eLaBPiMKku;

	private static StepContext A34Hf4tX71uWD7m9t3W;

	public bool IsRootContext => eLaBPiMKku.IsRootContext;

	public string ActionId => eLaBPiMKku.ActionId;

	public string ActionTitle => eLaBPiMKku.ActionTitle;

	public ActionExtraContextData ExtraData => eLaBPiMKku.ExtraData;

	public int Id => eLaBPiMKku.Id;

	public CancellationToken? CancellationToken => eLaBPiMKku.CancellationToken;

	public StepContext(ActionStep step, XAction action, ActionExecuteContext context)
	{
		Wf5B0N4r87 = step;
		w8NBCv2fEJ = action;
		eLaBPiMKku = context;
	}

	public object GetVarValue(string varName)
	{
		return eLaBPiMKku.GetVarValue(varName);
	}

	public object TryGetValue(string var, object defaultValue)
	{
		return eLaBPiMKku.TryGetValue(var, defaultValue);
	}

	public bool IsVarExists(string varName)
	{
		return eLaBPiMKku.IsVarExists(varName);
	}

	public IActionContext GetRootContext()
	{
		return eLaBPiMKku.GetRootContext();
	}

	public IActionContext GetParentContext()
	{
		return eLaBPiMKku.GetParentContext();
	}

	public IDictionary<string, object> RunSp(string spName, IDictionary<string, object> inputParams)
	{
		return eLaBPiMKku.RunSp(spName, inputParams);
	}

	public Task<IDictionary<string, object>> RunSpAsync(string spName, IDictionary<string, object> inputParams)
	{
		return eLaBPiMKku.RunSpAsync(spName, inputParams);
	}

	public Task<IDictionary<string, object>> RunSpAsync(string spName, object inputParams)
	{
		return eLaBPiMKku.RunSpAsync(spName, inputParams);
	}

	public IDictionary<string, object> RunSp(string spName, object inputParams)
	{
		return eLaBPiMKku.RunSp(spName, inputParams);
	}

	public void WriteState(string key, string value)
	{
		eLaBPiMKku.WriteState(key, value);
	}

	public string ReadState(string key, string defaultValue)
	{
		return eLaBPiMKku.ReadState(key, defaultValue);
	}

	public void WriteCache(string key, object value, int maxKeepSeconds)
	{
		eLaBPiMKku.WriteCache(key, value, maxKeepSeconds);
	}

	public T ReadCache<T>(string key, T defaultValue)
	{
		return eLaBPiMKku.ReadCache(key, defaultValue);
	}

	public object RemoveCache(string key)
	{
		return eLaBPiMKku.RemoveCache(key);
	}

	public void ClearCache()
	{
		eLaBPiMKku.ClearCache();
	}

	public void UpdateVariablesFromDict(IDictionary<string, object> dict)
	{
		eLaBPiMKku.UpdateVariablesFromDict(dict);
	}

	public void UpdateVariablesFromJson(string dictJson)
	{
		eLaBPiMKku.UpdateVariablesFromJson(dictJson);
	}

	public IDictionary<string, object> GetVariables()
	{
		return eLaBPiMKku.GetVariables();
	}

	public void SetVarValue(string varName, object value)
	{
		if (eLaBPiMKku.IsDebugging)
		{
			eLaBPiMKku.ActionLogger?.LogOutput(new StepOutParamDef
			{
				Name = "脚本写入"
			}, varName, value);
		}
		eLaBPiMKku.SetVarValue(varName, value);
	}

	public void RegisterDisposable(IDisposable disposableObject)
	{
		eLaBPiMKku.RegisterDisposable(disposableObject);
	}

	public object EvalExpression(string expression, bool onUiThread = false)
	{
		return eLaBPiMKku.EvalExpression(expression, onUiThread);
	}

	public void ExecuteCommonOperationItem(CommonOperationItem item)
	{
		eLaBPiMKku.ExecuteCommonOperationItem(item);
	}

	public bool IsShouldStopAction()
	{
		return eLaBPiMKku.IsShouldStopAction();
	}

	internal static bool yfCJ0ut2MjNYawauG7j()
	{
		return A34Hf4tX71uWD7m9t3W == null;
	}
}
