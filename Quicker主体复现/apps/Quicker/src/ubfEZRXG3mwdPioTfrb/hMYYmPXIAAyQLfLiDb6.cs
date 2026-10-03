using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using cF2s4eoj0xhjQv4UVon;
using FontAwesome5;
using Fuy7DkoWhCdS5kI9xhV;
using MimeTypes;
using PpIbF8XpCC7OtfHsoeg;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using rBdUDxoADYdh8U3Jh4m;
using tRxT3LXrvotDPiLvstr;
using zYELLMoqxbWOGNUaiSw;

namespace ubfEZRXG3mwdPioTfrb;

internal class hMYYmPXIAAyQLfLiDb6 : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xFOSeDkbXcG;

		public static Func<KeyValuePair<string, object>, string> NhjSedZXcCL;

		public static Func<KeyValuePair<string, object>, string> ghTSeoFZbIi;

		private static _003C_003Ec cEVu1oWuV1EhXSm8bU7x;

		static _003C_003Ec()
		{
			xFOSeDkbXcG = new _003C_003Ec();
		}

		internal string wwTSe4arP6G(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal string LfpSe5NRx6c(KeyValuePair<string, object> x)
		{
			object value = x.Value;
			object obj;
			if (value == null)
			{
				obj = null;
			}
			else
			{
				obj = value.ToString();
				if (obj != null)
				{
					goto IL_001c;
				}
			}
			obj = "";
			goto IL_001c;
			IL_001c:
			return (string)obj;
		}

		internal static void U46bPXWucCHkyHT4GDpb()
		{
		}

		internal static bool HuaHQjWuQGaOslyQnHqi()
		{
			return cEVu1oWuV1EhXSm8bU7x == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public ActionStep H2GSeMAujqx;

		public ActionExecuteContext uj0SeA1uyDa;

		public XAction XOnSeOq8XX9;

		private static _003C_003Ec__DisplayClass55_0 YO0Ml3WuWjtfMmkiALa1;

		internal (bool isSuccess, string message, ActionStopFlag failReason) uDnSeTbPe9N()
		{
			string textParamValue = XActionHelper.GetTextParamValue(zbbgWyLmZ2J, H2GSeMAujqx, uj0SeA1uyDa);
			string textParamValue2 = XActionHelper.GetTextParamValue(eEZgW8P6CBt, H2GSeMAujqx, uj0SeA1uyDa);
			string textParamValue3 = XActionHelper.GetTextParamValue(kUGgWEkROar, H2GSeMAujqx, uj0SeA1uyDa);
			eco6AkXLfyZjRmP4RfT eco6AkXLfyZjRmP4RfT = UqUgW2Db6ht(textParamValue);
			Dictionary<string, string> idictionary_ = rdBgWSOEBU1(textParamValue2);
			eco6AkXLfyZjRmP4RfT.wGfMjLU4H76(idictionary_);
			if (textParamValue3 == "Upload")
			{
				using dqs3ZWowtqiy3yIfw7B request = zMHgWLuFmDH(H2GSeMAujqx, uj0SeA1uyDa);
				lKRt6fo20yPnP2ZloBB lKRt6fo20yPnP2ZloBB = eco6AkXLfyZjRmP4RfT.Upload(request);
				if (!lKRt6fo20yPnP2ZloBB.IsSuccess)
				{
					return (isSuccess: false, message: lKRt6fo20yPnP2ZloBB.ErrorMessage, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(XltgWhRWvSL, H2GSeMAujqx, uj0SeA1uyDa, lKRt6fo20yPnP2ZloBB.Url, XOnSeOq8XX9);
				string textParamValue4 = XActionHelper.GetTextParamValue(n9dgWRyJhgm, H2GSeMAujqx, uj0SeA1uyDa);
				if (!string.IsNullOrEmpty(textParamValue4))
				{
					string text = "";
					text = ((textParamValue4.IndexOf("%KEY%", StringComparison.OrdinalIgnoreCase) < 0) ? (textParamValue4.TrimEnd('/') + "/" + lKRt6fo20yPnP2ZloBB.cnDgk4kbtlU()) : textParamValue4.Replace("%KEY%", lKRt6fo20yPnP2ZloBB.cnDgk4kbtlU()));
					XActionHelper.OutputResult(nNPgWeda1b6, H2GSeMAujqx, uj0SeA1uyDa, text, XOnSeOq8XX9);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool wkg6sGWuyJhgKN9EQuLv()
		{
			return YO0Ml3WuWjtfMmkiALa1 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> pHagWuDRISE = new string[4] { "图床", "tuchuang", "oss", "cos" };

	[CompilerGenerated]
	private readonly string ktRgWNMIAyV = $"fa:{EFontAwesomeIcon.Light_Cloud}:#32a852";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> tf2gWJ0gPxw;

	[CompilerGenerated]
	private readonly string BROgW0F1gJB = "https://getquicker.net/KC/Help/Doc/cloud_oss";

	[CompilerGenerated]
	private readonly bool PiIgWCWlXvP;

	[CompilerGenerated]
	private readonly bool wmXgWPXkn5R;

	public static readonly StepInParamDef kUGgWEkROar;

	public static readonly StepInParamDef zbbgWyLmZ2J;

	public static readonly StepInParamDef eEZgW8P6CBt;

	private static readonly StepInParamDef JK6gWa7S5ub;

	private static readonly StepInParamDef bFmgW7v2Doq;

	private static readonly StepInParamDef n9dgWRyJhgm;

	public static readonly StepInParamDef z77gWqWJ7t2;

	private static readonly StepInParamDef kOZgWcf8HSS;

	private static readonly StepInParamDef FmbgWVxAn2x;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> OdWgWZeuRhG = new List<StepInParamDef> { kUGgWEkROar, zbbgWyLmZ2J, eEZgW8P6CBt, JK6gWa7S5ub, bFmgW7v2Doq, n9dgWRyJhgm, z77gWqWJ7t2, kOZgWcf8HSS, FmbgWVxAn2x };

	private static readonly StepOutParamDef n9LgW91gIsW;

	private static readonly StepOutParamDef XltgWhRWvSL;

	private static readonly StepOutParamDef nNPgWeda1b6;

	private static readonly StepOutParamDef KprgWYtF4HQ;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> urOgWI28Ud3 = new List<StepOutParamDef> { n9LgW91gIsW, XltgWhRWvSL, nNPgWeda1b6, KprgWYtF4HQ };

	internal static hMYYmPXIAAyQLfLiDb6 WRDgebQT7CptDrkFkIh9;

	public string Key => "sys:cloud_oss";

	public string Name => "第三方云存储/图床";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return pHagWuDRISE;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ktRgWNMIAyV;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return tf2gWJ0gPxw;
		}
	}

	public string Description => "使用第三方云服务上传文件。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return BROgW0F1gJB;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return PiIgWCWlXvP;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return wmXgWPXkn5R;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return OdWgWZeuRhG;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return urOgWI28Ud3;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.H2GSeMAujqx = step;
		_003C_003Ec__DisplayClass55_.uj0SeA1uyDa = context;
		_003C_003Ec__DisplayClass55_.XOnSeOq8XX9 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass55_.uj0SeA1uyDa, _003C_003Ec__DisplayClass55_.H2GSeMAujqx, _003C_003Ec__DisplayClass55_.XOnSeOq8XX9, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass55_.uDnSeTbPe9N, (Action)null, (Action)null, FmbgWVxAn2x, n9LgW91gIsW);
	}

	private static dqs3ZWowtqiy3yIfw7B zMHgWLuFmDH(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
        StringBuilder stringBuilder = default;
		dqs3ZWowtqiy3yIfw7B dqs3ZWowtqiy3yIfw7B = new dqs3ZWowtqiy3yIfw7B();
		dqs3ZWowtqiy3yIfw7B.Key = XActionHelper.GetTextParamValue(JK6gWa7S5ub, actionStep_0, actionExecuteContext_0);
		dqs3ZWowtqiy3yIfw7B.ExpireSeconds = XActionHelper.GetNumberParamValue(kOZgWcf8HSS, actionStep_0, actionExecuteContext_0);
		dqs3ZWowtqiy3yIfw7B.c93gkZXSi72(XActionHelper.GetDictParamValue(z77gWqWJ7t2, actionStep_0, actionExecuteContext_0).ToDictionary(_003C_003Ec.NhjSedZXcCL ?? (_003C_003Ec.NhjSedZXcCL = _003C_003Ec.xFOSeDkbXcG.wwTSe4arP6G), _003C_003Ec.ghTSeoFZbIi ?? (_003C_003Ec.ghTSeoFZbIi = _003C_003Ec.xFOSeDkbXcG.LfpSe5NRx6c)));
		object paramValue = XActionHelper.GetParamValue(bFmgW7v2Doq, actionStep_0, actionExecuteContext_0);
		int num = 0;
		if (WRDgebQT7CptDrkFkIh9 == null)
		{
			goto IL_00ec;
		}
		goto IL_01fe;
		IL_01fe:
		switch (num)
		{
		case 3:
			break;
		case 1:
			goto IL_00ec;
		case 2:
			goto IL_0230;
		default:
			goto IL_0291;
		}
		goto IL_00a2;
		IL_0291:
		return dqs3ZWowtqiy3yIfw7B;
		IL_00a2:
		if (!string.IsNullOrWhiteSpace(dqs3ZWowtqiy3yIfw7B.Key) && !dqs3ZWowtqiy3yIfw7B.Key.Trim().EndsWith("/"))
		{
			dqs3ZWowtqiy3yIfw7B.rPWgky5wfmc(dqs3ZWowtqiy3yIfw7B.Key);
			num = 0;
			if (A1eLPvQT46xUm0CWVTvn())
			{
				goto IL_01fe;
			}
			goto IL_0291;
		}
		stringBuilder = new StringBuilder(128);
		if (string.IsNullOrEmpty(dqs3ZWowtqiy3yIfw7B.Key))
		{
			goto IL_0230;
		}
		stringBuilder.Append(dqs3ZWowtqiy3yIfw7B.Key.Trim());
		goto IL_025e;
		IL_025e:
		stringBuilder.Append(Guid.NewGuid().ToString("N"));
		stringBuilder.Append(dqs3ZWowtqiy3yIfw7B.MVHgkR3O29e());
		dqs3ZWowtqiy3yIfw7B.rPWgky5wfmc(stringBuilder.ToString());
		goto IL_0291;
		IL_00ec:
		if (!(paramValue is Image image))
		{
			if (paramValue is string text)
			{
				if (Path.IsPathRooted(text) && File.Exists(text))
				{
					dqs3ZWowtqiy3yIfw7B.ga2gku6u8J1(Path.GetFileName(text));
					dqs3ZWowtqiy3yIfw7B.ContentType = MimeTypeMap.GetMimeType(dqs3ZWowtqiy3yIfw7B.fGQgk2d6sZO());
					dqs3ZWowtqiy3yIfw7B.wbvgkecjIfI(new FileStream(text, FileMode.Open, FileAccess.Read));
					dqs3ZWowtqiy3yIfw7B.wvXgkq0D7P8(Path.GetExtension(text));
				}
				else
				{
					OnxgWvPToFF(dqs3ZWowtqiy3yIfw7B, text);
				}
			}
			else
			{
				string string_ = VariableHelper.LcfghRCibTg(paramValue);
				OnxgWvPToFF(dqs3ZWowtqiy3yIfw7B, string_);
			}
		}
		else
		{
			ImageFormat imageFormat = image.GetImageFormat();
			if (imageFormat != null && !object.Equals(imageFormat, ImageFormat.MemoryBmp))
			{
				dqs3ZWowtqiy3yIfw7B.wvXgkq0D7P8("." + imageFormat.ToString().ToLower());
				dqs3ZWowtqiy3yIfw7B.ContentType = "image/" + imageFormat.ToString().ToLower();
				dqs3ZWowtqiy3yIfw7B.wbvgkecjIfI(image.ToStream(imageFormat));
			}
			else
			{
				dqs3ZWowtqiy3yIfw7B.ContentType = "image/png";
				dqs3ZWowtqiy3yIfw7B.wbvgkecjIfI(image.ToStream(ImageFormat.Png));
				dqs3ZWowtqiy3yIfw7B.wvXgkq0D7P8(".png");
			}
		}
		goto IL_00a2;
		IL_0230:
		stringBuilder.Append(DateTime.Now.ToString("yyyy/MM/dd/"));
		goto IL_025e;
	}

	private static void OnxgWvPToFF(dqs3ZWowtqiy3yIfw7B dqs3ZWowtqiy3yIfw7B_0, string string_2)
	{
		dqs3ZWowtqiy3yIfw7B_0.ContentType = "text/plain";
		dqs3ZWowtqiy3yIfw7B_0.FSmgkWFmOcV("utf-8");
		dqs3ZWowtqiy3yIfw7B_0.wbvgkecjIfI(new MemoryStream(Encoding.UTF8.GetBytes(string_2)));
		dqs3ZWowtqiy3yIfw7B_0.wvXgkq0D7P8(".txt");
	}

	private static Dictionary<string, string> rdBgWSOEBU1(string string_2)
	{
		IDictionary<string, object> dictionary = VariableHelper.ConvertToDict(string_2);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			dictionary2.Add(item.Key, item.Value.ToString());
		}
		return dictionary2;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(kUGgWEkROar, step) + "(" + XActionHelper.GetParamDisplayString(zbbgWyLmZ2J, step) + ")";
	}

	private static eco6AkXLfyZjRmP4RfT UqUgW2Db6ht(string string_2)
	{
		return string_2 switch
		{
			"Tencent" => new o5j4uZo574Per2QiPGE(), 
			"Qiniu" => new wjVL4jolHMjGL6WrcoQ(), 
			"Aliyun" => new lN7WWAXCZo63YVPHOu5(), 
			_ => throw new Exception("不支持的厂商类型：" + string_2 + "，可能您使用的Quicker版本过旧。"), 
		};
	}

	static hMYYmPXIAAyQLfLiDb6()
	{
		kUGgWEkROar = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			DefaultValue = "Upload",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Upload", "上传")
			},
			IsControlField = true
		};
		zbbgWyLmZ2J = new StepInParamDef
		{
			Key = "vendor",
			Name = "服务商",
			Description = "",
			DefaultValue = "Aliyun",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Aliyun", "阿里云 OSS"),
				new SelectionItem("Tencent", "腾讯云 COS"),
				new SelectionItem("Qiniu", "七牛云")
			},
			IsControlField = false
		};
		eEZgW8P6CBt = new StepInParamDef
		{
			Key = "vendorSettings",
			Name = "服务商参数",
			Description = "设置相关",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input
		};
		JK6gWa7S5ub = new StepInParamDef
		{
			Key = "key",
			Name = "对象名",
			Description = "可选。留空时自动生成对象名。如果以'/'结尾，则在此基础上自动生成对象名。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "Upload" }
		};
		bFmgW7v2Doq = new StepInParamDef
		{
			Key = "content",
			Name = "上传内容",
			Description = "要上传的文件路径、其它文本内容或图片变量。",
			DefaultValue = "",
			Type = VarType.Any,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "Upload" }
		};
		n9dgWRyJhgm = new StepInParamDef
		{
			Key = "customDomain",
			Name = "自定义域名",
			Description = "如“https://files.example.com”。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "Upload" }
		};
		z77gWqWJ7t2 = new StepInParamDef
		{
			Key = "extraHeaders",
			Name = "额外的请求头",
			Description = "可选。设置厂商相关的特定http头。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input
		};
		kOZgWcf8HSS = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时时间",
			Description = "请求超时时间（秒数）",
			Type = VarType.Number,
			DefaultValue = 180,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		FmbgWVxAn2x = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		n9LgW91gIsW = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		XltgWhRWvSL = new StepOutParamDef
		{
			Key = "vendorUrl",
			Name = "服务商网址",
			Description = "",
			Type = VarType.Any,
			ValidForList = new string[1] { "Upload" }
		};
		nNPgWeda1b6 = new StepOutParamDef
		{
			Key = "customUrl",
			Name = "自定义域名网址",
			Description = "设置了自定义域名时会生成此网址。",
			Type = VarType.Any,
			ValidForList = new string[1] { "Upload" }
		};
		KprgWYtF4HQ = new StepOutParamDef
		{
			Key = "err",
			Name = "错误信息",
			Description = "出错时输出的错误信息。",
			Type = VarType.Text
		};
	}

	internal static bool A1eLPvQT46xUm0CWVTvn()
	{
		return WRDgebQT7CptDrkFkIh9 == null;
	}

	internal static void wDaPWJQmWGpvje8o1OrB()
	{
	}
}
