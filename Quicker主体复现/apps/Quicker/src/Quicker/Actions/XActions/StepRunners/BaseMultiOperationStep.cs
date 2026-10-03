using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace Quicker.Actions.XActions.StepRunners;

public abstract class BaseMultiOperationStep : IStepRunningInfo, IMultiOperationStep
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public BaseMultiOperationStep if2S9fHDLxE;

		public ActionStep LFPS9zpbwkK;

		public ActionExecuteContext jxGShwMkAJm;

		public XAction MY3Sht0mSs7;

		public string lr9ShgFYJvQ;

		internal static _003C_003Ec__DisplayClass14_0 S24JddW9PoP02xivBAlY;

		internal (bool isSuccess, string message, ActionStopFlag failReason) xspS93ohw04()
		{
			string textParamValue = XActionHelper.GetTextParamValue(if2S9fHDLxE.km4ghToBI2b, LFPS9zpbwkK, jxGShwMkAJm);
			StepOperation stepOperation = if2S9fHDLxE.GetStepOperation(textParamValue);
			if (stepOperation == null)
			{
				return (isSuccess: false, message: "为找到操作类型 " + textParamValue + " 的处理程序。\r\n可能是您使用的Quicker版本过旧。", failReason: ActionStopFlag.OperationFailed);
			}
			StepExecuteResult stepExecuteResult = stepOperation.Execute(LFPS9zpbwkK, jxGShwMkAJm, MY3Sht0mSs7, lr9ShgFYJvQ);
			return (isSuccess: stepExecuteResult.IsSuccess, message: stepExecuteResult.Message, failReason: stepExecuteResult.StopFlag);
		}

		internal static bool aLnJeeW9MfxA6erMZiyW()
		{
			return S24JddW9PoP02xivBAlY == null;
		}
	}

	protected IDictionary<string, StepOperation> _allOperations = new Dictionary<string, StepOperation>();

	private readonly StepInParamDef km4ghToBI2b = new StepInParamDef
	{
		Key = "operation",
		Name = "操作类型",
		Description = "",
		VariableMode = ParamVariableMode.Input,
		DefaultValue = null,
		Type = VarType.Enum,
		IsControlField = true,
		SelectionItems = new List<SelectionItem>()
	};

	internal static readonly StepInParamDef dpTghM5oQ8k;

	internal static readonly StepOutParamDef YBvghAou5MC;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> IIHghOsfXlD;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> LZVghFsxeb5;

	internal static BaseMultiOperationStep rSihh7QwPCRE6FZR8VBB;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return IIHghOsfXlD;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return LZVghFsxeb5;
		}
	}

	protected BaseMultiOperationStep()
	{
		IIHghOsfXlD = new List<StepInParamDef>();
		LZVghFsxeb5 = new List<StepOutParamDef>();
	}

	protected void SetupParams(StepInParamDef[] inParams, StepOutParamDef[] outParams)
	{
		InputParams.Add(km4ghToBI2b);
		InputParams.AddMulti(inParams);
		InputParams.Add(dpTghM5oQ8k);
		OutputParams.Add(YBvghAou5MC);
		OutputParams.AddMulti(outParams);
	}

	protected void AddOperation(StepOperation operation, bool setDefault = false)
	{
		km4ghToBI2b.SelectionItems.Add(new SelectionItem(operation.Key, operation.Title));
		_allOperations.Add(operation.Key, operation);
		if (setDefault)
		{
			km4ghToBI2b.DefaultValue = operation.Key;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.if2S9fHDLxE = this;
		_003C_003Ec__DisplayClass14_.LFPS9zpbwkK = step;
		_003C_003Ec__DisplayClass14_.jxGShwMkAJm = context;
		_003C_003Ec__DisplayClass14_.MY3Sht0mSs7 = action;
		_003C_003Ec__DisplayClass14_.lr9ShgFYJvQ = stepId;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass14_.jxGShwMkAJm, _003C_003Ec__DisplayClass14_.LFPS9zpbwkK, _003C_003Ec__DisplayClass14_.MY3Sht0mSs7, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass14_.xspS93ohw04, (Action)null, (Action)null, dpTghM5oQ8k, YBvghAou5MC);
	}

	public string GetSummary(ActionStep step)
	{
		StepOperation stepOperation = GetStepOperation(step);
		object obj;
		if (stepOperation == null)
		{
			obj = null;
		}
		else
		{
			obj = stepOperation.GetSummary(step);
			if (obj != null)
			{
				goto IL_0022;
			}
		}
		obj = "";
		goto IL_0022;
		IL_0022:
		return (string)obj;
	}

	public IList<StepInParamDef> GetValidInputParams(ActionStep step)
	{
		List<StepInParamDef> list = GetStepOperation(step).InputParams.ToList();
		list.Insert(0, km4ghToBI2b);
		list.Add(dpTghM5oQ8k);
		return list;
	}

	public IList<StepOutParamDef> GetValidOutputParams(ActionStep step)
	{
		List<StepOutParamDef> obj = GetStepOperation(step)?.OutputParams.ToList();
		obj.Insert(0, YBvghAou5MC);
		return obj;
	}

	protected StepOperation GetStepOperation(ActionStep step)
	{
		string text = null;
		object obj;
		if (step.InputParams.ContainsKey(km4ghToBI2b.Key))
		{
			ActionStepParam actionStepParam = step.InputParams[km4ghToBI2b.Key];
			if (actionStepParam == null)
			{
				obj = null;
			}
			else
			{
				obj = actionStepParam.Value;
				if (obj != null)
				{
					goto IL_007b;
				}
			}
			int num = 0;
			if (!jQeVtiQwMchbpSrU2afS())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			object defaultValue = km4ghToBI2b.DefaultValue;
			if (defaultValue == null)
			{
				obj = null;
			}
			else
			{
				obj = defaultValue.ToString();
				if (obj != null)
				{
					goto IL_007b;
				}
			}
			obj = "";
			goto IL_007b;
		}
		object defaultValue2 = km4ghToBI2b.DefaultValue;
		object obj2;
		if (defaultValue2 == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = defaultValue2.ToString();
			if (obj2 != null)
			{
				goto IL_009f;
			}
		}
		obj2 = "";
		goto IL_009f;
		IL_009f:
		text = (string)obj2;
		goto IL_00a1;
		IL_00a1:
		return GetStepOperation(text);
		IL_007b:
		text = (string)obj;
		goto IL_00a1;
	}

	public StepOperation GetStepOperation(string operation)
	{
		if (_allOperations.ContainsKey(operation))
		{
			return _allOperations[operation];
		}
		return null;
	}

	static BaseMultiOperationStep()
	{
		dpTghM5oQ8k = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止动作",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		YBvghAou5MC = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "步骤执行是否成功",
			Description = "步骤执行是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool jQeVtiQwMchbpSrU2afS()
	{
		return rSihh7QwPCRE6FZR8VBB == null;
	}
}
