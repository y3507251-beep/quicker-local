using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using soLGR8XA95f82ljopSU;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class TempCloudStoreStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public ActionStep M57vlTlENL3;

		public ActionExecuteContext lnPvlMBsCPc;

		public XAction loIvlAP9DNm;

		internal static _003C_003Ec__DisplayClass46_0 M5vS4MWe8jpbsXGbJgyu;

		internal (bool isSuccess, string message, ActionStopFlag failReason) hl9vloXwYLO()
		{
			string textParamValue = XActionHelper.GetTextParamValue(HUFto2gTRxq, M57vlTlENL3, lnPvlMBsCPc);
			double double_ = Convert.ToDouble(XActionHelper.GetNumberParamValue(UdBto04jqvf, M57vlTlENL3, lnPvlMBsCPc));
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(VTetoCrdIH8, M57vlTlENL3, lnPvlMBsCPc);
			string text = "";
			switch (textParamValue)
			{
			default:
				throw new InvalidDataException("");
			case "file":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(igrtoJgfpkL, M57vlTlENL3, lnPvlMBsCPc);
				if (!System.IO.File.Exists(textParamValue3))
				{
					throw new InvalidDataException("文件不存在！");
				}
				text = oHyR5LX5l5qeapYlxI6.kaBtHCjYysN(textParamValue3, double_, booleanParamValue).Result;
				break;
			}
			case "imageVar":
			{
				string imgFilePath;
				Image imageParamValue = XActionHelper.GetImageParamValue(i1htoNqd3Ze, M57vlTlENL3, lnPvlMBsCPc, out imgFilePath);
				if (imageParamValue != null)
				{
					text = oHyR5LX5l5qeapYlxI6.xHQtH0Hp41R(imageParamValue, double_).Result;
					break;
				}
				throw new InvalidDataException("图片参数不正确：不是位图对象。");
			}
			case "text":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(fZptouJOmo3, M57vlTlENL3, lnPvlMBsCPc);
				if (string.IsNullOrEmpty(textParamValue2))
				{
					throw new InvalidDataException("要保存的文本内容为空。");
				}
				text = oHyR5LX5l5qeapYlxI6.tTotHJ83KgW(textParamValue2, double_).Result;
				break;
			}
			}
			XActionHelper.OutputResult(Rjtto8EjZRP, M57vlTlENL3, lnPvlMBsCPc, text, loIvlAP9DNm);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool eBT5LsWeRAfh4oc4pvy9()
		{
			return M5vS4MWe8jpbsXGbJgyu == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> PuTtotXI4cY = new string[4] { "网络", "云", "cloud", "同步" };

	[CompilerGenerated]
	private readonly string ggrtog7OBCR = $"fa:{EFontAwesomeIcon.Light_Cloud}:#32a852";

	[CompilerGenerated]
	private readonly StepRunnerCategory TCXtoLkKHWB = StepRunnerCategory.Network;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> xZbtovZrk65;

	[CompilerGenerated]
	private readonly string E0ZtoSG02R9 = "https://getquicker.net/KC/Help/Doc/tempcloudstore";

	private static readonly StepInParamDef HUFto2gTRxq;

	private static readonly StepInParamDef fZptouJOmo3;

	private static readonly StepInParamDef i1htoNqd3Ze;

	private static readonly StepInParamDef igrtoJgfpkL;

	private static readonly StepInParamDef UdBto04jqvf;

	private static readonly StepInParamDef VTetoCrdIH8;

	private static readonly StepInParamDef SKWtoPb9Ift;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> auotoEgIyKq = new StepInParamDef[7] { HUFto2gTRxq, fZptouJOmo3, i1htoNqd3Ze, igrtoJgfpkL, UdBto04jqvf, VTetoCrdIH8, SKWtoPb9Ift };

	private static readonly StepOutParamDef LdMtoyk4lky;

	private static readonly StepOutParamDef Rjtto8EjZRP;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> kMItoavH8mx = new StepOutParamDef[2] { LdMtoyk4lky, Rjtto8EjZRP };

	internal static TempCloudStoreStep i086tnQqTFRsXHUf3QCP;

	public string Key => "sys:tempcloudstore";

	public string Name => "本地临时存储";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return PuTtotXI4cY;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ggrtog7OBCR;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return TCXtoLkKHWB;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return xZbtovZrk65;
		}
	}

	public string Description => "将文本、文件、图片临时保存到云端并得到网址。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return E0ZtoSG02R9;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return auotoEgIyKq;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return kMItoavH8mx;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.M57vlTlENL3 = step;
		_003C_003Ec__DisplayClass46_.lnPvlMBsCPc = context;
		_003C_003Ec__DisplayClass46_.loIvlAP9DNm = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass46_.lnPvlMBsCPc, _003C_003Ec__DisplayClass46_.M57vlTlENL3, _003C_003Ec__DisplayClass46_.loIvlAP9DNm, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass46_.hl9vloXwYLO, (Action)null, (Action)null, SKWtoPb9Ift, LdMtoyk4lky);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(HUFto2gTRxq, step) ?? "";
	}

	static TempCloudStoreStep()
	{
		HUFto2gTRxq = new StepInParamDef
		{
			Key = "dataType",
			Name = "数据类型",
			Description = "",
			DefaultValue = "text",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("text", "文本内容"),
				new SelectionItem("file", "文件"),
				new SelectionItem("imageVar", "图片变量")
			},
			IsControlField = true
		};
		fZptouJOmo3 = new StepInParamDef
		{
			Key = "text",
			Name = "文本内容",
			Description = "要保存的文本内容",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "text" },
			IsMultiLine = true
		};
		i1htoNqd3Ze = new StepInParamDef
		{
			Key = "imageVar",
			Name = "图片变量",
			Description = "要保存的图片变量",
			Type = VarType.Image,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new string[1] { "imageVar" },
			IsMultiLine = false
		};
		igrtoJgfpkL = new StepInParamDef
		{
			Key = "file",
			Name = "文件路径",
			Description = "要保存的文件路径",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "file" },
			IsMultiLine = false
		};
		UdBto04jqvf = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时时间",
			Description = "请求超时时间（秒数）",
			Type = VarType.Number,
			DefaultValue = 2.5,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		VTetoCrdIH8 = new StepInParamDef
		{
			Key = "useRandomFileName",
			Name = "生成随机文件名",
			DefaultValue = false,
			Description = "是否使用随机的文件名（仅适用于上传文件的情况）",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		SKWtoPb9Ift = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		LdMtoyk4lky = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		Rjtto8EjZRP = new StepOutParamDef
		{
			Key = "url",
			Name = "网址",
			Description = "生成的访问网址",
			Type = VarType.Text
		};
	}

	internal static bool V48XklQqmC1PEgFqgNYT()
	{
		return i086tnQqTFRsXHUf3QCP == null;
	}
}
