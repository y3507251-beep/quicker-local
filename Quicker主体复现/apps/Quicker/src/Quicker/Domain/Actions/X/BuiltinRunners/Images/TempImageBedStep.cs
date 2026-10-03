using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using FontAwesome5;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using soLGR8XA95f82ljopSU;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class TempImageBedStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep v9uSRK9NrZj;

		public ActionExecuteContext MGPSRxhl77t;

		public XAction caNSRrHujVS;

		internal static _003C_003Ec__DisplayClass42_0 y29va4WkT2jcLDyZHemY;

		internal (bool isSuccess, string message, ActionStopFlag failReason) uT2SRmuFGTJ()
		{
			if (AppHelper.fLiLTj0x4QY() - m5Zg83Y9DJf < 2000L)
			{
				return (isSuccess: false, message: $"每次调用之间需间隔{2000}ms，当前间隔{AppHelper.fLiLTj0x4QY() - m5Zg83Y9DJf}ms。", failReason: ActionStopFlag.OperationFailed);
			}
			m5Zg83Y9DJf = AppHelper.fLiLTj0x4QY();
			string textParamValue = XActionHelper.GetTextParamValue(CQeg8AdvUCW, v9uSRK9NrZj, MGPSRxhl77t);
			Image image_ = XActionHelper.GetParamValue(fIJg8O01yvs, v9uSRK9NrZj, MGPSRxhl77t) as Image;
			string result = Ps7g8j76rhb(textParamValue, image_);
			XActionHelper.OutputResult(UrlOutputParam, v9uSRK9NrZj, MGPSRxhl77t, result, caNSRrHujVS);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool TH6oTQWkmmn1wC8FwviT()
		{
			return y29va4WkT2jcLDyZHemY == null;
		}
	}

	private static readonly ILog WXDg8DAr75Y;

	[CompilerGenerated]
	private readonly IEnumerable<string> p69g8dt4maU = new string[4] { "位图", "picture", "bitmap", "图床" };

	[CompilerGenerated]
	private readonly string Iq6g8oIAQO1 = $"fa:{EFontAwesomeIcon.Light_Images}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ROcg8TjQPKn = new List<StepRunnerCategory> { StepRunnerCategory.Network };

	[CompilerGenerated]
	private readonly string lXkg8Mk2RCi = "https://getquicker.net/KC/Help/Doc/tempImgBed";

	public const long MAX_FILE_SIZE = 2000000L;

	private static readonly StepInParamDef CQeg8AdvUCW;

	private static readonly StepInParamDef fIJg8O01yvs;

	private static readonly StepInParamDef YUYg8F7wVMK;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> bdxg8UuMdEk = new StepInParamDef[2] { fIJg8O01yvs, YUYg8F7wVMK };

	private static readonly StepOutParamDef HOIg8lCKEgX;

	public static readonly StepOutParamDef UrlOutputParam;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> qnAg8iSndjf = new StepOutParamDef[2] { HOIg8lCKEgX, UrlOutputParam };

	private static long m5Zg83Y9DJf;

	private static TempImageBedStep Xe749gQIvD9K1TlsVvCT;

	public string Key => "sys:tempImgBed";

	public string Name => "本地临时图片";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return p69g8dt4maU;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Iq6g8oIAQO1;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ROcg8TjQPKn;
		}
	}

	public string Description => "将图片上传到临时（1分钟后删除）的图床，用以搜图等场景。勿上传非法内容。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return lXkg8Mk2RCi;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return bdxg8UuMdEk;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return qnAg8iSndjf;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.v9uSRK9NrZj = step;
		_003C_003Ec__DisplayClass42_.MGPSRxhl77t = context;
		_003C_003Ec__DisplayClass42_.caNSRrHujVS = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.MGPSRxhl77t, _003C_003Ec__DisplayClass42_.v9uSRK9NrZj, _003C_003Ec__DisplayClass42_.caNSRrHujVS, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.uT2SRmuFGTJ, (Action)null, (Action)null, YUYg8F7wVMK, HOIg8lCKEgX);
	}

	internal static string Ps7g8j76rhb(string string_2, Image image_0)
	{
		try
		{
			return skng84j4Jvl(string_2, image_0);
		}
		catch (Exception ex)
		{
			WXDg8DAr75Y.Warn("使用自托管本地临时图片报错：" + ex.Message, ex);
			return Kglg8nrbtP1(string_2, image_0);
		}
	}

	private static string Kglg8nrbtP1(string string_2, Image image_0)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			if (!System.IO.File.Exists(string_2))
			{
				throw new InvalidOperationException("图片文件(" + string_2 + ")不存在！");
			}
			if (!AppHelper.IsImageFile(string_2))
			{
				throw new InvalidOperationException("不支持此文件类型！");
			}
			return oHyR5LX5l5qeapYlxI6.kaBtHCjYysN(string_2, 300.0, true).GetAwaiter().GetResult();
		}
		if (image_0 == null)
		{
			throw new InvalidOperationException("图片和文件都未指定。");
		}
		return oHyR5LX5l5qeapYlxI6.xHQtH0Hp41R(image_0, 300.0).GetAwaiter().GetResult();
	}

	private static string skng84j4Jvl(string string_2, Image image_0)
	{
		return Kglg8nrbtP1(string_2, image_0);
	}


	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(CQeg8AdvUCW, step) + " " + XActionHelper.GetParamDisplayString(fIJg8O01yvs, step);
	}

	static TempImageBedStep()
	{
		WXDg8DAr75Y = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		CQeg8AdvUCW = new StepInParamDef
		{
			Key = "path",
			Name = "图片文件路径",
			Description = "图片文件的完整路径，与图片变量二选一。",
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text
		};
		fIJg8O01yvs = new StepInParamDef
		{
			Key = "imgVar",
			Name = "图片变量",
			Description = "指定要上传的图片变量。",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar
		};
		YUYg8F7wVMK = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		HOIg8lCKEgX = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		UrlOutputParam = new StepOutParamDef
		{
			Key = "url",
			Name = "网址",
			Description = "图片的临时网址",
			Type = VarType.Text
		};
		m5Zg83Y9DJf = 0L;
	}

	internal static bool cdewUMQIdqw5jAhIwjv0()
	{
		return Xe749gQIvD9K1TlsVvCT == null;
	}
}
