using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using IgQBbvXMVdsN7GVNUxX;
using QRCodeDecoderLibrary;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using ZXing;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class ReadQRcodeStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec tv7SqFq07LB;

		public static Func<Result, string> NOPSqUorYMb;

		internal static _003C_003Ec M3Ig9nWaIgKIMNBSRNf9;

		static _003C_003Ec()
		{
			tv7SqFq07LB = new _003C_003Ec();
		}

		internal string eCvSqOObGF2(Result r)
		{
			return r.Text;
		}

		internal static bool JKq19JWa6FMGl5CpP3tN()
		{
			return M3Ig9nWaIgKIMNBSRNf9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionStep I5hSqiuJEVu;

		public ActionExecuteContext JwPSq3OwmH9;

		public XAction qdYSqfbWXCj;

		public ReadQRcodeStep TDpSqzoiXNU;

		internal static _003C_003Ec__DisplayClass40_0 ElW7ZEWaSoyR7wRRLRWt;

		internal (bool isSuccess, string message, ActionStopFlag failReason) UeHSqlYq0Q7()
		{
			_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_1
			{
				bW7ScLJu5jX = this
			};
			string imgFilePath;
			object imageParamValue = XActionHelper.GetImageParamValue(bZXgRthQjaT, I5hSqiuJEVu, JwPSq3OwmH9, out imgFilePath);
			if (!(imageParamValue is Image))
			{
				return (isSuccess: false, message: "变量不是图片", failReason: ActionStopFlag.OperationFailed);
			}
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(EvvgRgiTPOR, I5hSqiuJEVu, JwPSq3OwmH9);
			_003C_003Ec__DisplayClass40_.OMKSctR8CQs = new BarcodeReader();
			_003C_003Ec__DisplayClass40_.OMKSctR8CQs.Options.CharacterSet = "UTF-8";
			if (imageParamValue is Bitmap)
			{
				_003C_003Ec__DisplayClass40_.S82ScgO8iBF = (Bitmap)imageParamValue;
			}
			else
			{
				_003C_003Ec__DisplayClass40_.S82ScgO8iBF = new Bitmap(imageParamValue as Image);
			}
			Result result = _003C_003Ec__DisplayClass40_.OMKSctR8CQs.Decode(_003C_003Ec__DisplayClass40_.S82ScgO8iBF);
			string text = "";
			if (result != null && !string.IsNullOrEmpty(result.Text))
			{
				JwPSq3OwmH9.ActionLogger.LogWarning("ZXing识别成功。");
				text = result.Text;
				XActionHelper.OutputResultIfNeeded(QQxgRu1arrc, _003C_003Ec__DisplayClass40_.D4LScwdN1B2, I5hSqiuJEVu, JwPSq3OwmH9, qdYSqfbWXCj);
			}
			else
			{
				_003C_003Ec__DisplayClass40_2 _003C_003Ec__DisplayClass40_2 = new _003C_003Ec__DisplayClass40_2();
				JwPSq3OwmH9.ActionLogger.LogWarning("BarcodeReader识别失败，尝试QRDecoder识别...");
				byte[][] byte_ = new QRDecoder().ImageDecoder(_003C_003Ec__DisplayClass40_.S82ScgO8iBF);
				_003C_003Ec__DisplayClass40_2.CvuScSss2B4 = rpog7UUUWih(byte_);
				text = (_003C_003Ec__DisplayClass40_2.CvuScSss2B4.HasData() ? _003C_003Ec__DisplayClass40_2.CvuScSss2B4[0] : "");
				XActionHelper.OutputResultIfNeeded(QQxgRu1arrc, _003C_003Ec__DisplayClass40_2.PCHScvYvO2D, I5hSqiuJEVu, JwPSq3OwmH9, qdYSqfbWXCj);
			}
			XActionHelper.OutputResult(sH7gR2EIDpG, I5hSqiuJEVu, JwPSq3OwmH9, text ?? "", qdYSqfbWXCj);
			if (string.IsNullOrEmpty(text))
			{
				return (isSuccess: false, message: "识别到的内容为空。", failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		static _003C_003Ec__DisplayClass40_0()
		{
		}

		internal static bool A4P1dpWawEtZiOrs6vN0()
		{
			return ElW7ZEWaSoyR7wRRLRWt == null;
		}

		internal static void BU9C6EWamav5cknbdOLW()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_1
	{
		public BarcodeReader OMKSctR8CQs;

		public Bitmap S82ScgO8iBF;

		public _003C_003Ec__DisplayClass40_0 bW7ScLJu5jX;

		private static _003C_003Ec__DisplayClass40_1 Pak3vbWasVI6MkCsnNae;

		internal object D4LScwdN1B2()
		{
			try
			{
				Result[] array = OMKSctR8CQs.DecodeMultiple(S82ScgO8iBF);
				return array.HasData() ? array.Select(_003C_003Ec.NOPSqUorYMb ?? (_003C_003Ec.NOPSqUorYMb = _003C_003Ec.tv7SqFq07LB.eCvSqOObGF2)).ToList() : new List<string>();
			}
			catch (Exception ex)
			{
				bW7ScLJu5jX.JwPSq3OwmH9.ActionLogger.LogWarning("ZXing识别多个二维码失败。" + ex.Message);
			}
			return new List<string>();
		}

		static _003C_003Ec__DisplayClass40_1()
		{
		}

		internal static bool g9dEC7WaCEtCDlvNj0PZ()
		{
			return Pak3vbWasVI6MkCsnNae == null;
		}

		internal static void CUlOwVWahs0fFsLFUNr8()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_2
	{
		public IList<string> CvuScSss2B4;

		private static _003C_003Ec__DisplayClass40_2 MeedRLWaHAJbB3GOl3ce;

		internal object PCHScvYvO2D()
		{
			return CvuScSss2B4;
		}

		internal static bool xfnChQWazpFhFG0tnfY9()
		{
			return MeedRLWaHAJbB3GOl3ce == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> NYDg7iZiX3t;

	[CompilerGenerated]
	private readonly string Eaog73dl4NV = $"fa:{EFontAwesomeIcon.Light_Qrcode}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> rhfg7fLeFyK;

	[CompilerGenerated]
	private readonly string ME1g7zDl3pg = "https://getquicker.net/KC/Help/Doc/readqrcode";

	[CompilerGenerated]
	private readonly bool rtbgRwdh8A9;

	private static readonly StepInParamDef bZXgRthQjaT;

	private static readonly StepInParamDef EvvgRgiTPOR;

	private static readonly StepInParamDef jfqgRLEUvZV;

	private static readonly StepOutParamDef dKGgRvTH954;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> fVtgRSbUSwD = new StepInParamDef[3] { bZXgRthQjaT, EvvgRgiTPOR, jfqgRLEUvZV };

	private static readonly StepOutParamDef sH7gR2EIDpG;

	private static readonly StepOutParamDef QQxgRu1arrc;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> VClgRNlnhjG = new StepOutParamDef[3] { dKGgRvTH954, sH7gR2EIDpG, QQxgRu1arrc };

	private static DateTime? soJgRJ79Iof;

	internal static ReadQRcodeStep vXjadvQ6kLukkOBkOdNl;

	public string Key => "sys:readQrCode";

	public string Name => "识别二维码";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return NYDg7iZiX3t;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Eaog73dl4NV;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return rhfg7fLeFyK;
		}
	}

	public string Description => "识别图片中的二维码";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ME1g7zDl3pg;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return rtbgRwdh8A9;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return fVtgRSbUSwD;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return VClgRNlnhjG;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.I5hSqiuJEVu = step;
		_003C_003Ec__DisplayClass40_.JwPSq3OwmH9 = context;
		_003C_003Ec__DisplayClass40_.qdYSqfbWXCj = action;
		_003C_003Ec__DisplayClass40_.TDpSqzoiXNU = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.JwPSq3OwmH9, _003C_003Ec__DisplayClass40_.I5hSqiuJEVu, _003C_003Ec__DisplayClass40_.qdYSqfbWXCj, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.UeHSqlYq0Q7, (Action)null, (Action)null, jfqgRLEUvZV, dKGgRvTH954);
	}


	private static IList<string> rpog7UUUWih(byte[][] byte_0)
	{
		if (byte_0 == null)
		{
			return new List<string>();
		}
		List<string> list = new List<string>();
		if (byte_0.Length == 1)
		{
			list.Add(QRDecoder.ByteArrayToStr(byte_0[0]));
			return list;
		}
		for (int i = 0; i < byte_0.Length; i++)
		{
			list.Add(QRDecoder.ByteArrayToStr(byte_0[i]));
		}
		return list;
	}

	private static string A3fg7lNsXxm(string string_2)
	{
        StringBuilder stringBuilder = default;
		int i;
		for (i = 0; i < string_2.Length && ((string_2[i] >= ' ' && string_2[i] <= '~') || string_2[i] >= '\u00a0'); i++)
		{
		}
		if (i == string_2.Length)
		{
			int num = 0;
			if (vXjadvQ6kLukkOBkOdNl != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				return string_2;
			case 1:
				break;
			case 2:
				goto IL_00b0;
			}
			goto IL_007f;
		}
		stringBuilder = new StringBuilder(string_2.Substring(0, i));
		goto IL_0107;
		IL_007f:
		char c = string_2[i];
		if ((c >= ' ' && c <= '~') || c >= '\u00a0')
		{
			stringBuilder.Append(c);
		}
		else
		{
			if (c == '\r')
			{
				goto IL_00b0;
			}
			if (c == '\n')
			{
				stringBuilder.Append("\r\n");
			}
			else
			{
				stringBuilder.Append('¿');
			}
		}
		goto IL_0101;
		IL_00b0:
		stringBuilder.Append("\r\n");
		if (i + 1 < string_2.Length && string_2[i + 1] == '\n')
		{
			i++;
		}
		goto IL_0101;
		IL_0107:
		if (i >= string_2.Length)
		{
			return stringBuilder.ToString();
		}
		goto IL_007f;
		IL_0101:
		i++;
		goto IL_0107;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(bZXgRthQjaT, step) + " => " + XActionHelper.GetOutputParamDisplayString(sH7gR2EIDpG, step);
	}

	static ReadQRcodeStep()
	{
		bZXgRthQjaT = new StepInParamDef
		{
			Key = "img",
			Name = "输入图片",
			Description = "要识别二维码的图片",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar
		};
		EvvgRgiTPOR = new StepInParamDef
		{
			Key = "tryNetwork",
			Name = "本地识别失败后尝试在线识别服务",
			DefaultValue = false,
			Description = "在线服务拥有更强识别能力（频率限制2秒/次，仅专业版提供）。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		jfqgRLEUvZV = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		dKGgRvTH954 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		sH7gR2EIDpG = new StepOutParamDef
		{
			Key = "code",
			Name = "值",
			Description = "识别出的二维码内容",
			Type = VarType.Text
		};
		QQxgRu1arrc = new StepOutParamDef
		{
			Key = "codeList",
			Name = "全部二维码值",
			Description = "当一个图片含有多个二维码，且需要返回所有结果时使用。",
			Type = VarType.List
		};
		soJgRJ79Iof = null;
	}

	internal static bool NTXXaqQ6a05irOZwO19J()
	{
		return vXjadvQ6kLukkOBkOdNl == null;
	}
}
