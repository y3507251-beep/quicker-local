using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Baidu.Aip.Ocr;
using f9a0PHoGPpwjuPg0HoF;
using FontAwesome5;
using jtYKvI2ve9aDjyxS5gf;
using log4net;
using Newtonsoft.Json.Linq;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.OCR;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using QuickerOcrAgent.Vm;
using tQy5b4MZR11HLf8vRkW;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Network;

public class OcrStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LQUSEMlnpT6;

		public static Func<JToken, string> VNVSEApCUem;

		public static Func<JToken, string> L9eSEOidyjo;

		public static Func<string, int> JiySEFgIVEt;

		internal static _003C_003Ec nBhA1JWdtvTWRy82YiAg;

		static _003C_003Ec()
		{
			LQUSEMlnpT6 = new _003C_003Ec();
		}

		internal string lANSEdMv37m(JToken x)
		{
			return x["words"].ToString();
		}

		internal string YMUSEojG5yb(JToken x)
		{
			return x["words"].ToString();
		}

		internal int PkASET8koZe(string x)
		{
			return x.Length;
		}

		internal static bool GJX2XMWdSy2ZD1uZNJ7X()
		{
			return nBhA1JWdtvTWRy82YiAg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass65_0
	{
		public ActionStep icUSEl2ZSeo;

		public ActionExecuteContext oI3SEichF81;

		public OcrStep WHQSE3x2urZ;

		public XAction xPASEfL4p0K;

		private static _003C_003Ec__DisplayClass65_0 v8O1B9WdT292VkgnLNMt;

		internal (bool isSuccess, string message, ActionStopFlag failReason) uYiSEUWiGFr()
		{
			string text = XActionHelper.GetTextParamValue(kMbg0uICChf, icUSEl2ZSeo, oI3SEichF81);
			string text2 = XActionHelper.GetTextParamValue(koFg0NZhPNr, icUSEl2ZSeo, oI3SEichF81);
			string string_ = XActionHelper.GetTextParamValue(uHRg0JM8mAF, icUSEl2ZSeo, oI3SEichF81);
			string imgFilePath;
			Image imageParamValue = XActionHelper.GetImageParamValue(rTMg003hJbx, icUSEl2ZSeo, oI3SEichF81, out imgFilePath);
			if (imageParamValue == null)
			{
				return (isSuccess: false, message: "图片变量为空", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue = XActionHelper.GetTextParamValue(ohXg0Cqbwix, icUSEl2ZSeo, oI3SEichF81);
			string textParamValue2 = XActionHelper.GetTextParamValue(kBAg0PlWNkM, icUSEl2ZSeo, oI3SEichF81);
			if (!string.IsNullOrEmpty(AppState.HHxtaMaoqJr().BasicOcrSettings?.BaiduApiKey) && (string.IsNullOrEmpty(text2) || AppState.HHxtaMaoqJr().BasicOcrSettings.AlwaysUseOwnKey))
			{
				text2 = AppState.HHxtaMaoqJr().BasicOcrSettings?.BaiduApiKey;
				string_ = AppState.HHxtaMaoqJr().BasicOcrSettings?.BaiduSecretKey;
				oI3SEichF81.ActionLogger.LogInfo("已使用全局百度ApiKey。");
			}
			if (!string.IsNullOrEmpty(text2))
			{
				BasicOcrSettings basicOcrSettings = AppState.HHxtaMaoqJr().BasicOcrSettings;
				if (basicOcrSettings != null && basicOcrSettings.AlwaysUseOwnKey && text == "baidu-quicker")
				{
					oI3SEichF81.ActionLogger.LogInfo("已改为使用自有Key进行OCR操作。");
					text = "baidu-basic";
				}
			}
			if ((text == "baidu-basic" || text == "baidu-custom") && string.IsNullOrEmpty(text2))
			{
				return (isSuccess: false, message: "未提供百度OCR APIKey参数", failReason: ActionStopFlag.OperationFailed);
			}
			switch (text)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + text, failReason: ActionStopFlag.OperationFailed);
			case "table_quicker":
				try
				{
					return WHQSE3x2urZ.ACmgJi6nIXu(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, imageParamValue);
				}
				catch (Exception ex3)
				{
					C9ng0tJRAiA.Warn("表格识别异常:" + ex3.Message, ex3);
					return (isSuccess: false, message: ex3.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
			case "QuickerServerOcr":
				try
				{
					return WHQSE3x2urZ.QuickerServerOcr(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, imageParamValue, textParamValue, textParamValue2);
				}
				catch (Exception ex4)
				{
					C9ng0tJRAiA.Warn("Quicker服务文字识别异常:" + ex4.Message, ex4);
					return (isSuccess: false, message: ex4.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
			case "WindowsOcr":
				try
				{
					return WHQSE3x2urZ.WindowsOcr(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, imageParamValue, textParamValue, textParamValue2);
				}
				catch (Exception ex5)
				{
					C9ng0tJRAiA.Warn("WindowsOCR识别异常:" + ex5.Message, ex5);
					return (isSuccess: false, message: ex5.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
			case "baidu-quicker":
				oI3SEichF81.ActionLogger.LogInfo($"免费额度耗尽后使用Q豆:{AppState.HHxtaMaoqJr().BasicOcrSettings?.AllowUseQBean}");
				try
				{
					return WHQSE3x2urZ.fewgJzA6Nt0(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, imageParamValue, textParamValue, textParamValue2);
				}
				catch (Exception ex2)
				{
					C9ng0tJRAiA.Warn("OCR识别异常(Quicker账号）:" + ex2.Message, ex2);
					return (isSuccess: false, message: ex2.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
			case "baidu-custom":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(nxJg0E62NZo, icUSEl2ZSeo, oI3SEichF81);
				IDictionary<string, object> dictParamValue = XActionHelper.GetDictParamValue(Jpmg0ydP2Bj, icUSEl2ZSeo, oI3SEichF81);
				return WHQSE3x2urZ.mabgJ3nax8T(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, text2, string_, imageParamValue, textParamValue3, dictParamValue);
			}
			case "baidu-basic":
				try
				{
					return WHQSE3x2urZ.IIrgJfI6hfC(icUSEl2ZSeo, oI3SEichF81, xPASEfL4p0K, text2, string_, imageParamValue, textParamValue, textParamValue2);
				}
				catch (Exception ex)
				{
					C9ng0tJRAiA.Warn("OCR识别异常(百度账号）:" + ex.Message, ex);
					return (isSuccess: false, message: ex.GetMessageWithInner(), failReason: ActionStopFlag.OperationFailed);
				}
			}
		}

		internal static void hpAWHgWdCRDdlDngP3RG()
		{
		}

		internal static bool kY9DRTWdmNtWnrpojZpq()
		{
			return v8O1B9WdT292VkgnLNMt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass66_0
	{
		public ApiResult<TableOcrResult> jWwSywDPV3J;

		private static _003C_003Ec__DisplayClass66_0 d2gk46Wd7spHqNJTbNq5;

		internal object DuKSEzRpLSm()
		{
			return jWwSywDPV3J.ToJson();
		}

		internal static bool vLrrklWd4Ov1wO0GYMsI()
		{
			return d2gk46Wd7spHqNJTbNq5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass69_0
	{
		public PaddleOcrResult OwDSygHA2oe;

		internal static _003C_003Ec__DisplayClass69_0 Stpmf5WdHtFrM2eqfRNd;

		internal object m4pSytPlRUT()
		{
			return OwDSygHA2oe.ToJson();
		}

		internal static bool KMCuuuWdzW7rUkmedVmT()
		{
			return Stpmf5WdHtFrM2eqfRNd == null;
		}
	}

	private static readonly ILog C9ng0tJRAiA;

	[CompilerGenerated]
	private readonly IEnumerable<string> rW5g0gqN6Zb = new string[1] { "图片转换为文本" };

	[CompilerGenerated]
	private readonly string C1wg0LfhapY = $"fa:{EFontAwesomeIcon.Light_ExpandWide}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> p0Sg0vWjJh5 = new List<StepRunnerCategory> { StepRunnerCategory.Image };

	[CompilerGenerated]
	private readonly string eSBg0Sap2mJ = "https://getquicker.net/KC/Help/Doc/basic-ocr";

	[CompilerGenerated]
	private readonly bool gOog02NTX1g;

	private static readonly StepInParamDef kMbg0uICChf;

	private static readonly StepInParamDef koFg0NZhPNr;

	private static readonly StepInParamDef uHRg0JM8mAF;

	private static readonly StepInParamDef rTMg003hJbx;

	private static readonly StepInParamDef ohXg0Cqbwix;

	private static readonly StepInParamDef kBAg0PlWNkM;

	private static readonly StepInParamDef nxJg0E62NZo;

	private static readonly StepInParamDef Jpmg0ydP2Bj;

	private static readonly StepInParamDef zPyg08RQFb8;

	public const string OFFLINE_MODE_AUTO = "Auto";

	public const string OFFLINE_MODE_ONLINE = "OnlineOnly";

	public const string OFFLINE_MODE_OFFLINE = "OfflineOnly";

	private static readonly StepInParamDef wrDg0aeLyXU;

	private static readonly StepInParamDef BrJg07h4ntg;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Q4eg0RGCybT = new List<StepInParamDef>
	{
		kMbg0uICChf, koFg0NZhPNr, uHRg0JM8mAF, rTMg003hJbx, ohXg0Cqbwix, kBAg0PlWNkM, nxJg0E62NZo, Jpmg0ydP2Bj, zPyg08RQFb8, wrDg0aeLyXU,
		BrJg07h4ntg
	};

	private static readonly StepOutParamDef T00g0qJ7msQ;

	private static readonly StepOutParamDef j8fg0c6aNgQ;

	private static readonly StepOutParamDef IRlg0VCFOUB;

	private static readonly StepOutParamDef Se0g0ZTokmF;

	private static readonly StepOutParamDef AM4g09lAxbf;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> uGGg0hAIncB = new List<StepOutParamDef> { T00g0qJ7msQ, IRlg0VCFOUB, j8fg0c6aNgQ, Se0g0ZTokmF, AM4g09lAxbf };

	internal static OcrStep zZagFVQMmCrX9UCxfhlj;

	public string Key => "sys:basic-ocr";

	public string Name => "基础OCR";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return rW5g0gqN6Zb;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return C1wg0LfhapY;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return p0Sg0vWjJh5;
		}
	}

	public string Description => "获取图片中的文字";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return eSBg0Sap2mJ;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return gOog02NTX1g;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Q4eg0RGCybT;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return uGGg0hAIncB;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass65_0 _003C_003Ec__DisplayClass65_ = new _003C_003Ec__DisplayClass65_0();
		_003C_003Ec__DisplayClass65_.icUSEl2ZSeo = step;
		_003C_003Ec__DisplayClass65_.oI3SEichF81 = context;
		_003C_003Ec__DisplayClass65_.WHQSE3x2urZ = this;
		_003C_003Ec__DisplayClass65_.xPASEfL4p0K = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass65_.oI3SEichF81, _003C_003Ec__DisplayClass65_.icUSEl2ZSeo, _003C_003Ec__DisplayClass65_.xPASEfL4p0K, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass65_.uYiSEUWiGFr, (Action)null, (Action)null, BrJg07h4ntg, T00g0qJ7msQ);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) ACmgJi6nIXu(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, Image image_0)
	{
		_003C_003Ec__DisplayClass66_0 _003C_003Ec__DisplayClass66_ = new _003C_003Ec__DisplayClass66_0();
		string string_ = image_0.ToBase64String(ImageFormat.Png);
		XActionHelper.GetTextParamValue(zPyg08RQFb8, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass66_.jWwSywDPV3J = IIQBbr2FgGR5ONc4nck.R8TtyvnIAjG(string_).GetAwaiter().GetResult();
		if (!_003C_003Ec__DisplayClass66_.jWwSywDPV3J.IsSuccess)
		{
			return (isSuccess: false, message: "服务器返回错误：" + _003C_003Ec__DisplayClass66_.jWwSywDPV3J.Message, failReason: ActionStopFlag.OperationFailed);
		}
		if (_003C_003Ec__DisplayClass66_.jWwSywDPV3J.Data == null)
		{
			return (isSuccess: false, message: "服务器返回错误：返回结果Data为NULL", failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResult(IRlg0VCFOUB, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass66_.jWwSywDPV3J.Data.Html, xaction_0);
		XActionHelper.OutputResultIfNeeded(Se0g0ZTokmF, _003C_003Ec__DisplayClass66_.DuKSEzRpLSm, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) mabgJ3nax8T(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, string string_3, Image image_0, string string_4, IDictionary<string, object> idictionary_0)
	{
		Ocr ocr = new Ocr(string_2, string_3);
		ocr.Timeout = 6000;
		byte[] image = image_0.ImageToByteArray();
		JObject jObject = ocr.Common(string_4, image, idictionary_0 as Dictionary<string, object>);
		XActionHelper.OutputResult(Se0g0ZTokmF, actionStep_0, actionExecuteContext_0, ocr.RawResult, xaction_0);
		XActionHelper.OutputResult(AM4g09lAxbf, actionStep_0, actionExecuteContext_0, jObject, xaction_0);
		if (jObject.ContainsKey("error_code"))
		{
			string text = string.Format("错误：{0} {1}", jObject["error_code"].ToString(), jObject["error_msg"]);
			return (isSuccess: false, message: "API返回错误：" + text, failReason: ActionStopFlag.OperationFailed);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) WindowsOcr(ActionStep step, ActionExecuteContext context, XAction action, Image img, string punctuationType, string mergeChapter)
	{
		IList<string> result = KJPvclMRZwxyLnfknnp.e0qLF4C5gse(img).GetAwaiter().GetResult();
		XActionHelper.OutputResult(j8fg0c6aNgQ, step, context, result, action);
		XActionHelper.OutputResult(Se0g0ZTokmF, step, context, result, action);
		string result2 = niEg0ww50dD(result, punctuationType, mergeChapter);
		XActionHelper.OutputResult(IRlg0VCFOUB, step, context, result2, action);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) QuickerServerOcr(ActionStep step, ActionExecuteContext context, XAction action, Image img, string punctuationType, string mergeChapter)
	{
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
		string textParamValue = XActionHelper.GetTextParamValue(zPyg08RQFb8, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(wrDg0aeLyXU, step, context);
		bool flag = false;
		bool flag2 = false;
		switch (textParamValue2)
		{
		case "OfflineOnly":
			flag2 = false;
			flag = true;
			break;
		case "OnlineOnly":
			flag2 = true;
			flag = false;
			break;
		default:
			flag2 = true;
			flag = true;
			break;
		}
		_003C_003Ec__DisplayClass69_.OwDSygHA2oe = null;
		if (flag && bfmVNpoIh0N1MPAqJ5v.LprgBF823Fu())
		{
			context.ActionLogger.LogInfo("使用离线OCR引擎。");
			try
			{
				string @base = img.ToBase64String(ImageFormat.Png);
				Stopwatch stopwatch = Stopwatch.StartNew();
				OcrResult ocrResult = bfmVNpoIh0N1MPAqJ5v.MaNgBlS1Zcv(new OcrRequest
				{
					Base64 = @base,
					Command = "text",
					Lang = textParamValue
				});
				if (ocrResult == null || !ocrResult.IsSuccess || ocrResult.Data.IsNullOrEmpty())
				{
					return (isSuccess: false, message: "离线OCR失败。" + ocrResult?.Error, failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass69_.OwDSygHA2oe = bfmVNpoIh0N1MPAqJ5v.HwrgQwck4JH(ocrResult.Data);
				long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			}
			catch (Exception ex)
			{
				C9ng0tJRAiA.Warn("离线OCR出错：" + ex.Message, ex);
				context.ActionLogger.LogWarning("离线OCR出错：" + ex.Message);
				return (isSuccess: false, message: "离线OCR出错:" + ex.Message, failReason: ActionStopFlag.OperationFailed);
			}
		}
		else
		{
			context.ActionLogger.LogInfo("使用在线OCR引擎。");
		}
		if (_003C_003Ec__DisplayClass69_.OwDSygHA2oe == null)
		{
			if (!flag2)
			{
				context.ActionLogger.LogWarning("");
				return (isSuccess: false, message: "离线OCR引擎不存在或未能识别内容（当前仅允许离线模式）。", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass69_.OwDSygHA2oe = IIQBbr2FgGR5ONc4nck.tEttyL66DUb(img, textParamValue).GetAwaiter().GetResult();
		}
		if (!_003C_003Ec__DisplayClass69_.OwDSygHA2oe.IsSuccess)
		{
			context.ActionLogger.LogWarning("OCR识别失败：" + _003C_003Ec__DisplayClass69_.OwDSygHA2oe.Message);
		}
		string[] array = _003C_003Ec__DisplayClass69_.OwDSygHA2oe.Result.Lines.TrimEnd().SplitToList(false);
		XActionHelper.OutputResult(j8fg0c6aNgQ, step, context, array, action);
		string result = niEg0ww50dD(array, punctuationType, mergeChapter);
		XActionHelper.OutputResult(IRlg0VCFOUB, step, context, result, action);
		XActionHelper.OutputResultIfNeeded(Se0g0ZTokmF, _003C_003Ec__DisplayClass69_.m4pSytPlRUT, step, context, action);
		return (isSuccess: _003C_003Ec__DisplayClass69_.OwDSygHA2oe.IsSuccess, message: _003C_003Ec__DisplayClass69_.OwDSygHA2oe.Message?.Trim('*'), failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) IIrgJfI6hfC(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, string string_3, Image image_0, string string_4, string string_5)
	{
		Ocr ocr = new Ocr(string_2, string_3);
		ocr.Timeout = 6000;
		byte[] image = image_0.ImageToByteArray();
		JObject jObject = ocr.GeneralBasic(image);
		XActionHelper.OutputResult(Se0g0ZTokmF, actionStep_0, actionExecuteContext_0, ocr.RawResult, xaction_0);
		XActionHelper.OutputResult(AM4g09lAxbf, actionStep_0, actionExecuteContext_0, jObject, xaction_0);
		if (jObject.ContainsKey("error_code"))
		{
			string text = string.Format("错误：{0} {1}", jObject["error_code"].ToString(), jObject["error_msg"]);
			XActionHelper.OutputResult(IRlg0VCFOUB, actionStep_0, actionExecuteContext_0, text, xaction_0);
			return (isSuccess: false, message: "API返回错误：" + text, failReason: ActionStopFlag.OperationFailed);
		}
		List<string> list = ((JArray)jObject["words_result"]).Select<JToken, string>(_003C_003Ec.VNVSEApCUem ?? (_003C_003Ec.VNVSEApCUem = _003C_003Ec.LQUSEMlnpT6.lANSEdMv37m)).ToList();
		XActionHelper.OutputResult(j8fg0c6aNgQ, actionStep_0, actionExecuteContext_0, list, xaction_0);
		string result = niEg0ww50dD(list, string_4, string_5);
		XActionHelper.OutputResult(IRlg0VCFOUB, actionStep_0, actionExecuteContext_0, result, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) fewgJzA6Nt0(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, Image image_0, string string_2, string string_3)
	{
		Ocr ocr = new Ocr("", "");
		ocr.UserServerAuth = true;
		ocr.Timeout = 6000;
		byte[] image = image_0.ImageToByteArray();
		JObject jObject = ocr.GeneralBasic(image);
		XActionHelper.OutputResult(Se0g0ZTokmF, actionStep_0, actionExecuteContext_0, ocr.RawResult, xaction_0);
		XActionHelper.OutputResult(AM4g09lAxbf, actionStep_0, actionExecuteContext_0, jObject, xaction_0);
		if (jObject.ContainsKey("error_code"))
		{
			string text = string.Format("错误：{0} {1}", jObject["error_code"].ToString(), jObject["error_msg"]);
			XActionHelper.OutputResult(IRlg0VCFOUB, actionStep_0, actionExecuteContext_0, text, xaction_0);
			return (isSuccess: false, message: "API返回错误:" + text, failReason: ActionStopFlag.OperationFailed);
		}
		List<string> list = ((JArray)jObject["words_result"]).Select<JToken, string>(_003C_003Ec.L9eSEOidyjo ?? (_003C_003Ec.L9eSEOidyjo = _003C_003Ec.LQUSEMlnpT6.YMUSEojG5yb)).ToList();
		XActionHelper.OutputResult(j8fg0c6aNgQ, actionStep_0, actionExecuteContext_0, list, xaction_0);
		string result = niEg0ww50dD(list, string_2, string_3);
		XActionHelper.OutputResult(IRlg0VCFOUB, actionStep_0, actionExecuteContext_0, result, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private string niEg0ww50dD(IList<string> ilist_2, string string_2, string string_3)
	{
		StringBuilder stringBuilder = new StringBuilder(ilist_2.Sum(_003C_003Ec.JiySEFgIVEt ?? (_003C_003Ec.JiySEFgIVEt = _003C_003Ec.LQUSEMlnpT6.PkASET8koZe)) + 10);
		string text = null;
		foreach (string item in ilist_2)
		{
			string text2 = item;
			switch (string_2)
			{
			case "sbc":
				text2 = item.ToSBC();
				break;
			case "dbc":
				text2 = item.ToDBC();
				break;
			}
			if (text == null)
			{
				stringBuilder.Append(text2);
			}
			else if (string_3 == "merge")
			{
				if (!text.IsNullOrEmpty() && !text.Last().ContainedIn('.', '。', '?', '？', '.', '!', '！', '“', '"', '》', '\'') && !item.StartsWith(" "))
				{
					stringBuilder.Append(text2);
				}
				else
				{
					stringBuilder.Append("\r\n");
					stringBuilder.Append(text2);
				}
			}
			else
			{
				stringBuilder.Append("\r\n");
				stringBuilder.Append(text2);
			}
			text = text2;
		}
		return stringBuilder.ToString();
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(kMbg0uICChf, step) + " " + XActionHelper.GetParamDisplayString(rTMg003hJbx, step);
	}

	static OcrStep()
	{
		C9ng0tJRAiA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		kMbg0uICChf = new StepInParamDef
		{
			Key = "operation",
			Name = "接口/引擎",
			Description = "OCR接口或引擎。离线引擎安装方式请参考模块文档。",
			DefaultValue = "QuickerServerOcr",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("QuickerServerOcr", "Quicker OCR引擎"),
				new SelectionItem("WindowsOcr", "Windows10/11 内置OCR引擎"),
				new SelectionItem("baidu-basic", "百度通用文字识别（自定义帐号）"),
				new SelectionItem("baidu-quicker", "百度通用文字识别（Quicker帐号）"),
				new SelectionItem("baidu-custom", "百度自定义接口识别（自定义帐号）"),
				new SelectionItem("table_quicker", "表格识别（Quicker服务）")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		koFg0NZhPNr = new StepInParamDef
		{
			Key = "apiKey",
			Name = "ApiKey",
			DefaultValue = "",
			Description = "请填写OCR帐号的ApiKey",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "baidu-basic", "baidu-custom" }
		};
		uHRg0JM8mAF = new StepInParamDef
		{
			Key = "secretKey",
			Name = "SecretKey",
			DefaultValue = "",
			Description = "请填写OCR帐号的SecretKey",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "baidu-basic", "baidu-custom" }
		};
		rTMg003hJbx = new StepInParamDef
		{
			Key = "imgVar",
			Name = "图片变量",
			Description = "从指定变量中加载图片",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar
		};
		ohXg0Cqbwix = new StepInParamDef
		{
			Key = "punctuationType",
			Name = "转换标点符号",
			Description = "合并文本时，是否转换标点符号",
			DefaultValue = "no",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("no", "不转换"),
				new SelectionItem("sbc", "全角符号"),
				new SelectionItem("dbc", "半角符号")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false,
			ValidForList = new List<string> { "baidu-basic", "baidu-quicker", "QuickerServerOcr" }
		};
		kBAg0PlWNkM = new StepInParamDef
		{
			Key = "mergeChapter",
			Name = "合并段落",
			Description = "是否智能合并段落。",
			DefaultValue = "no",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("no", "不合并"),
				new SelectionItem("merge", "合并")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsControlField = false,
			ValidForList = new List<string> { "baidu-basic", "baidu-quicker", "QuickerServerOcr" }
		};
		nxJg0E62NZo = new StepInParamDef
		{
			Key = "interface",
			Name = "接口名称或网址",
			Description = "接口的完整网址，或 https://aip.baidubce.com/rest/2.0/ocr/v1/ 后面的部分",
			Type = VarType.Text,
			IsMultiLine = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("general_basic", "通用文字识别（标准版）"),
				new SelectionItem("general", "通用文字识别（标准含位置版）"),
				new SelectionItem("accurate_basic", "通用文字识别（高精度版）"),
				new SelectionItem("accurate", "通用文字识别（高精度含位置版）"),
				new SelectionItem("handwriting", "手写文字识别"),
				new SelectionItem("numbers", "数字识别"),
				new SelectionItem("doc_analysis_office", "办公文档识别"),
				new SelectionItem("form", "表格文字识别(同步接口)"),
				new SelectionItem("qrcode", "二维码识别")
			},
			ValidForList = new List<string> { "baidu-custom" }
		};
		Jpmg0ydP2Bj = new StepInParamDef
		{
			Key = "options",
			Name = "附加参数",
			Description = "请参考百度官方/Quicker服务接口说明。每行一个参数，使用option:value的格式。",
			Type = VarType.Dict,
			IsMultiLine = true,
			ValidForList = new List<string> { "baidu-custom" }
		};
		zPyg08RQFb8 = new StepInParamDef
		{
			Key = "lang",
			Name = "语言",
			Description = "待识别内容的语言。表格识别仅支持中英混合和英文。",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CHN_ENG", "中英混合"),
				new SelectionItem("ENG", "英语"),
				new SelectionItem("KOR", "韩语"),
				new SelectionItem("JAP", "日语"),
				new SelectionItem("CHT", "繁体中文"),
				new SelectionItem("LAT", "拉丁语"),
				new SelectionItem("ARA", "阿拉伯语")
			},
			ValidForList = new List<string> { "QuickerServerOcr", "table_quicker" }
		};
		wrDg0aeLyXU = new StepInParamDef
		{
			Key = "offlineMode",
			Name = "离线模式",
			Description = "是否使用离线引擎。自动：安装离线引擎时使用离线，否则使用在线。",
			Type = VarType.Enum,
			DefaultValue = "Auto",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Auto", "自动"),
				new SelectionItem("OnlineOnly", "仅使用在线服务"),
				new SelectionItem("OfflineOnly", "仅使用离线引擎")
			},
			ValidForList = new List<string> { "QuickerServerOcr" }
		};
		BrJg07h4ntg = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		T00g0qJ7msQ = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		j8fg0c6aNgQ = new StepOutParamDef
		{
			Key = "textList",
			Name = "行列表",
			Description = "OCR识别结果，列表格式，每行一项。",
			Type = VarType.List,
			ValidForList = new List<string> { "baidu-basic", "baidu-quicker", "QuickerServerOcr", "WindowsOcr" }
		};
		IRlg0VCFOUB = new StepOutParamDef
		{
			Key = "content",
			Name = "合并后结果",
			Description = "合并在一起的的文本内容",
			Type = VarType.Text,
			ValidForList = new List<string> { "baidu-basic", "baidu-quicker", "QuickerServerOcr", "WindowsOcr", "table_quicker" }
		};
		Se0g0ZTokmF = new StepOutParamDef
		{
			Key = "rawData",
			Name = "原始结果",
			Description = "API接口返回的完整内容",
			Type = VarType.Text
		};
		AM4g09lAxbf = new StepOutParamDef
		{
			Key = "rawObject",
			Name = "原始结果JObject对象",
			Description = "返回结果的JObject对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "baidu-basic", "baidu-quicker", "baidu-custom" }
		};
	}

	internal static bool jFHCOVQMssTeMbZDK6XV()
	{
		return zZagFVQMmCrX9UCxfhlj == null;
	}
}
