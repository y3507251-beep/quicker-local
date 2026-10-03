using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class SelectFileStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public SelectFileStep eqNScB0icIi;

		public ActionStep mTpScQJ3HF6;

		public ActionExecuteContext oxFScj4xNK1;

		public XAction iYfScnl2PDy;

		internal static _003C_003Ec__DisplayClass47_0 aC8Dd0WrLKfBWTYE8mdR;

		internal (bool isSuccess, string message, ActionStopFlag failReason) P5qScp8hgDV()
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1
			{
				xBpSc5C9PiZ = XActionHelper.GetTextParamValue(eqNScB0icIi.nSggqSOC61y, mTpScQJ3HF6, oxFScj4xNK1),
				hhmScDQM3Tw = XActionHelper.GetTextParamValue(eqNScB0icIi.rtUgq2myw9P, mTpScQJ3HF6, oxFScj4xNK1),
				w9cScdhhgJx = XActionHelper.GetTextParamValue(eqNScB0icIi.KyEgqutbLQJ, mTpScQJ3HF6, oxFScj4xNK1),
				JIVScTiC8P8 = XActionHelper.GetTextParamValue(eqNScB0icIi.LPbgqJtRmRH, mTpScQJ3HF6, oxFScj4xNK1),
				ngIScoUBhYG = XActionHelper.GetTextParamValue(eqNScB0icIi.LCngqNjfaou, mTpScQJ3HF6, oxFScj4xNK1),
				NtPScM2s7Bh = XActionHelper.GetTextParamValue(eqNScB0icIi.MSPgq0TSvnE, mTpScQJ3HF6, oxFScj4xNK1),
				zqhScOu3Vhh = XActionHelper.GetBooleanParamValue(eqNScB0icIi.TxhgqC8SqXd, mTpScQJ3HF6, oxFScj4xNK1),
				HLrScFEuVlP = false,
				gLlScUL6ZxJ = "",
				HT4Scl7hhNp = null,
				HLfScAnYbgn = 1
			};
			string[] array = _003C_003Ec__DisplayClass47_.hhmScDQM3Tw.Split('|');
			if (array.Length > 3 && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.w9cScdhhgJx))
			{
				if (array.Length % 2 == 0)
				{
					for (int i = 0; i < array.Length / 2; i++)
					{
						if (array[i * 2 + 1].EndsWith(_003C_003Ec__DisplayClass47_.w9cScdhhgJx, StringComparison.OrdinalIgnoreCase))
						{
							_003C_003Ec__DisplayClass47_.HLfScAnYbgn = i + 1;
							break;
						}
					}
				}
				_003C_003Ec__DisplayClass47_.w9cScdhhgJx = _003C_003Ec__DisplayClass47_.w9cScdhhgJx.TrimStart('.');
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass47_.FRcSc4y8CwV);
			if (!_003C_003Ec__DisplayClass47_.HLrScFEuVlP)
			{
				return (isSuccess: false, message: "已取消选择文件。", failReason: ActionStopFlag.UserCancel);
			}
			XActionHelper.OutputResult(gB5gqy8pkLl, mTpScQJ3HF6, oxFScj4xNK1, _003C_003Ec__DisplayClass47_.gLlScUL6ZxJ, iYfScnl2PDy);
			XActionHelper.OutputResult(x4fgq8VtXC1, mTpScQJ3HF6, oxFScj4xNK1, (_003C_003Ec__DisplayClass47_.HT4Scl7hhNp == null) ? new List<string>() : _003C_003Ec__DisplayClass47_.HT4Scl7hhNp.ToList(), iYfScnl2PDy);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool d9CJkkWruYkKOZJpHu6O()
		{
			return aC8Dd0WrLKfBWTYE8mdR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public string xBpSc5C9PiZ;

		public string hhmScDQM3Tw;

		public string w9cScdhhgJx;

		public string ngIScoUBhYG;

		public string JIVScTiC8P8;

		public string NtPScM2s7Bh;

		public int HLfScAnYbgn;

		public bool zqhScOu3Vhh;

		public bool HLrScFEuVlP;

		public string gLlScUL6ZxJ;

		public string[] HT4Scl7hhNp;

		internal static _003C_003Ec__DisplayClass47_1 deMQcOWrfv1byDTaxjDL;

		internal void FRcSc4y8CwV()
		{
			if (xBpSc5C9PiZ == nJSgqgOXxYE)
			{
				(HLrScFEuVlP, gLlScUL6ZxJ) = AppHelper.ShowSaveFileDialog(hhmScDQM3Tw, w9cScdhhgJx, ngIScoUBhYG, JIVScTiC8P8, NtPScM2s7Bh, HLfScAnYbgn, zqhScOu3Vhh);
			}
			else if (xBpSc5C9PiZ == XwKgqLvf6Bt)
			{
				(bool, string) tuple2 = AppHelper.ShowSelectFileDialog(hhmScDQM3Tw, w9cScdhhgJx, ngIScoUBhYG, JIVScTiC8P8, NtPScM2s7Bh, HLfScAnYbgn, zqhScOu3Vhh);
				HLrScFEuVlP = tuple2.Item1;
				gLlScUL6ZxJ = tuple2.Item2;
				if (deMQcOWrfv1byDTaxjDL == null)
				{
					switch (0)
					{
					}
				}
			}
			else if (xBpSc5C9PiZ == I6pgqvlOVki)
			{
				(HLrScFEuVlP, HT4Scl7hhNp) = AppHelper.ShowSelectMultiFileDialog(hhmScDQM3Tw, w9cScdhhgJx, ngIScoUBhYG, JIVScTiC8P8, NtPScM2s7Bh, HLfScAnYbgn, zqhScOu3Vhh);
			}
		}

		internal static bool Jwy0nFWrbS6ftaN4Ohwk()
		{
			return deMQcOWrfv1byDTaxjDL == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> xkWgR3ZK5NZ = new string[3] { "保存文件", "打开单个文件", "打开多个文件" };

	[CompilerGenerated]
	private readonly string qM7gRfUx43Q = $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> IPvgRzZo4Jp;

	[CompilerGenerated]
	private readonly string bFTgqw4rVjZ = "https://getquicker.net/KC/Help/Doc/selectfile";

	[CompilerGenerated]
	private readonly bool DhYgqt70WKc;

	private static readonly string nJSgqgOXxYE;

	private static readonly string XwKgqLvf6Bt;

	private static readonly string I6pgqvlOVki;

	private readonly StepInParamDef nSggqSOC61y = new StepInParamDef
	{
		Key = "type",
		Name = "操作类型",
		Description = "打开文件：选择一个已存在的文件。保存文件：选择文件要保存的目标位置。",
		DefaultValue = XwKgqLvf6Bt,
		IsRequired = true,
		Type = VarType.Enum,
		VariableMode = ParamVariableMode.Input,
		SelectionItems = new List<SelectionItem>
		{
			new SelectionItem(XwKgqLvf6Bt, "打开单个文件"),
			new SelectionItem(I6pgqvlOVki, "打开多个文件"),
			new SelectionItem(nJSgqgOXxYE, "保存文件")
		},
		IsControlField = true
	};

	private readonly StepInParamDef rtUgq2myw9P = new StepInParamDef
	{
		Key = "filter",
		Name = "文件类型筛选器",
		Description = "文件类型筛选器，格式为：类型1|扩展名1|类型2|扩展名2。如：文本文件(*.txt)|*.txt|C#文件|*.cs|所有文件|*.*",
		DefaultValue = "文本文件|*.txt|所有文件|*.*",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private readonly StepInParamDef KyEgqutbLQJ = new StepInParamDef
	{
		Key = "defaultExt",
		Name = "默认扩展名",
		Description = "默认的文件扩展名，应该是筛选器里的一种",
		DefaultValue = ".txt",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private readonly StepInParamDef LCngqNjfaou = new StepInParamDef
	{
		Key = "initFileName",
		Name = "初始文件名",
		Description = "预选选择或设置的文件名",
		DefaultValue = "",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private readonly StepInParamDef LPbgqJtRmRH = new StepInParamDef
	{
		Key = "initDir",
		Name = "初始路径",
		Description = "初始文件夹路径",
		DefaultValue = "",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private readonly StepInParamDef MSPgq0TSvnE = new StepInParamDef
	{
		Key = "title",
		Name = "对话框标题",
		Description = "选择窗口的标题",
		DefaultValue = "",
		Type = VarType.Text,
		IsRequired = false,
		VariableMode = ParamVariableMode.UseVarOrInput
	};

	private StepInParamDef TxhgqC8SqXd = new StepInParamDef
	{
		Key = "topMost",
		Name = "置顶显示",
		Description = "是否置置顶显示窗口。",
		DefaultValue = true,
		Type = VarType.Boolean,
		IsRequired = false,
		VariableMode = ParamVariableMode.Input
	};

	private static readonly StepInParamDef tDfgqPJ0YH9;

	private static readonly StepOutParamDef gY9gqEyOyvF;

	private static readonly StepOutParamDef gB5gqy8pkLl;

	private static readonly StepOutParamDef x4fgq8VtXC1;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> rhTgqadFFu2 = new StepOutParamDef[3] { gY9gqEyOyvF, gB5gqy8pkLl, x4fgq8VtXC1 };

	internal static SelectFileStep kjqkb3Q6mu9D0umk226i;

	public string Key => "sys:selectFile";

	public string Name => "选择文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return xkWgR3ZK5NZ;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return qM7gRfUx43Q;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return IPvgRzZo4Jp;
		}
	}

	public string Description => "用文件选择对话框选择要打开或保存的文件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bFTgqw4rVjZ;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return DhYgqt70WKc;
		}
	}

	public IList<StepInParamDef> InputParams => new StepInParamDef[8] { nSggqSOC61y, rtUgq2myw9P, KyEgqutbLQJ, LPbgqJtRmRH, LCngqNjfaou, MSPgq0TSvnE, TxhgqC8SqXd, tDfgqPJ0YH9 };

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return rhTgqadFFu2;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.eqNScB0icIi = this;
		_003C_003Ec__DisplayClass47_.mTpScQJ3HF6 = step;
		_003C_003Ec__DisplayClass47_.oxFScj4xNK1 = context;
		_003C_003Ec__DisplayClass47_.iYfScnl2PDy = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.oxFScj4xNK1, _003C_003Ec__DisplayClass47_.mTpScQJ3HF6, _003C_003Ec__DisplayClass47_.iYfScnl2PDy, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.P5qScp8hgDV, (Action)null, (Action)null, tDfgqPJ0YH9, gY9gqEyOyvF);
	}

	public string GetSummary(ActionStep step)
	{
		return "-> " + XActionHelper.GetOutputParamDisplayString(gB5gqy8pkLl, step) + " " + XActionHelper.GetOutputParamDisplayString(x4fgq8VtXC1, step);
	}

	static SelectFileStep()
	{
		nJSgqgOXxYE = "saveFile";
		XwKgqLvf6Bt = "openFile";
		I6pgqvlOVki = "openMultiFile";
		tDfgqPJ0YH9 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "取消后停止",
			DefaultValue = true,
			Description = "取消后是否停止动作运行",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		gY9gqEyOyvF = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功选择了路径。",
			Type = VarType.Boolean
		};
		gB5gqy8pkLl = new StepOutParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "选择的文件路径。",
			Type = VarType.Text,
			ValidForList = new List<string> { XwKgqLvf6Bt, nJSgqgOXxYE }
		};
		x4fgq8VtXC1 = new StepOutParamDef
		{
			Key = "pathList",
			Name = "路径列表",
			Description = "选择的文件路径列表。",
			Type = VarType.List,
			ValidForList = new List<string> { I6pgqvlOVki }
		};
	}

	internal static bool EHWHjbQ6sd07ocJdJfVU()
	{
		return kjqkb3Q6mu9D0umk226i == null;
	}
}
