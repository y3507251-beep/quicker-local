using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using IflySdk.Model.Common;
using IgQBbvXMVdsN7GVNUxX;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Quicker.Actions.XActions.BuildinRunners.Sys;
using Quicker.Actions.XActions.BuildinRunners.Sys.Sound;
using Quicker.Common.Services.Speech;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace EMu6sFoissmin2fOAST;

internal class KJ2KZno7dbEJwGDRv9u : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public ActionStep DZxSYWFpN03;

		public ActionExecuteContext WRpSYk2thyH;

		public KJ2KZno7dbEJwGDRv9u JZFSYGwd7ro;

		public XAction T6CSYsglC94;

		internal static _003C_003Ec__DisplayClass55_0 JookwrWuZRePYpwQWpxQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) GlISYIMSJuC()
		{
			switch (XActionHelper.GetTextParamValue(vOdgH7DmGAd, DZxSYWFpN03, WRpSYk2thyH))
			{
			default:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			case "short_voice_input":
				try
				{
					(bool, string, ActionStopFlag) result = JZFSYGwd7ro.rWwgHtm5tbi(DZxSYWFpN03, WRpSYk2thyH, T6CSYsglC94);
					if (!result.Item1)
					{
						XActionHelper.OutputResult(qmYgHkQUxTB, DZxSYWFpN03, WRpSYk2thyH, result.Item2, T6CSYsglC94);
					}
					return result;
				}
				catch (Exception ex)
				{
					XActionHelper.OutputResult(qmYgHkQUxTB, DZxSYWFpN03, WRpSYk2thyH, ex.Message, T6CSYsglC94);
					throw;
				}
			case "record_internal":
				return JZFSYGwd7ro.xD8gHgtlmtW(DZxSYWFpN03, WRpSYk2thyH, T6CSYsglC94);
			case "record":
				return JZFSYGwd7ro.RwXgHLxqgT9(DZxSYWFpN03, WRpSYk2thyH, T6CSYsglC94);
			}
		}

		internal static bool OT3pHwWu50HBN6BgZn9Q()
		{
			return JookwrWuZRePYpwQWpxQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public string e5cSY1v56Nd;

		public double pQOSYbZsUss;

		public AppSettings TFtSY6wBwTf;

		public bool bDcSYXWSsBf;

		public string WmCSYmkIBtN;

		public string GMXSYKXFSYV;

		public ManualResetEvent K4TSYxpv9r6;

		private static _003C_003Ec__DisplayClass56_0 WUEvUXWu8wo5qsy38lH3;

		internal void vCdSYHbtD8L()
		{
			_003C_003Ec__DisplayClass56_1 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_1();
			_003C_003Ec__DisplayClass56_.LqGSYBysqjd = this;
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs = new VoiceInputWindow();
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs.HelpText = e5cSY1v56Nd;
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs.SilentStopSeconds = pQOSYbZsUss;
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs.VendorSettings = TFtSY6wBwTf;
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs.Closed += _003C_003Ec__DisplayClass56_.WUnSYrugQ7e;
			_003C_003Ec__DisplayClass56_.ed7SYpAuKYs.Show();
		}

		internal static bool Wc23UWWuRLrtSgryv96C()
		{
			return WUEvUXWu8wo5qsy38lH3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_1
	{
		public VoiceInputWindow ed7SYpAuKYs;

		public _003C_003Ec__DisplayClass56_0 LqGSYBysqjd;

		internal static _003C_003Ec__DisplayClass56_1 ztvdIeWuMlqZ6AOtgemF;

		internal void WUnSYrugQ7e(object sender, EventArgs e)
		{
			LqGSYBysqjd.bDcSYXWSsBf = ed7SYpAuKYs.Result == true;
			LqGSYBysqjd.WmCSYmkIBtN = ed7SYpAuKYs.ResultText;
			LqGSYBysqjd.GMXSYKXFSYV = ed7SYpAuKYs.ErrorMessage;
			LqGSYBysqjd.K4TSYxpv9r6.Set();
		}

		internal static bool VGpsUlWuUZDHqS9VJ3YU()
		{
			return ztvdIeWuMlqZ6AOtgemF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass57_0
	{
		public bool b1vSY4C3lB0;

		public long nJtSY5CLqRE;

		public double XLgSYDR5iEj;

		public WasapiLoopbackCapture CyISYdUU6nT;

		public WaveFileWriter hDhSYoe8dl9;

		public ManualResetEvent CGASYTLnLJS;

		public ManualResetEvent CxrSYMIbTdV;

		public string ytXSYAsp1aA;

		internal static _003C_003Ec__DisplayClass57_0 mWoDYYWuIrtx7F9lZxdX;

		internal void P1HSYQ2IiEF(object sender, WaveInEventArgs e)
		{
			float num = 0f;
			int num2 = 0;
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num3;
				if (num2 < e.BytesRecorded)
				{
					float value = (float)BitConverter.ToInt16(e.Buffer, num2) / 32768f;
					num = Math.Max(num, Math.Abs(value));
					num2 += 2;
					num3 = 1;
					if (mWoDYYWuIrtx7F9lZxdX == null)
					{
						continue;
					}
				}
				else
				{
					flag = (double)num > 0.001;
					num3 = 0;
					if (!kKTAQcWu6KNxuDY77ZC7())
					{
						num3 = num4;
					}
				}
				switch (num3)
				{
				case 1:
					continue;
				}
				if (!b1vSY4C3lB0)
				{
					if (!flag)
					{
						return;
					}
					b1vSY4C3lB0 = true;
				}
				else if (flag)
				{
					nJtSY5CLqRE = AppHelper.fLiLTj0x4QY();
				}
				else if ((double)((AppHelper.fLiLTj0x4QY() - nJtSY5CLqRE) / 1000L) >= XLgSYDR5iEj)
				{
					CyISYdUU6nT.StopRecording();
					return;
				}
				hDhSYoe8dl9.Write(e.Buffer, 0, e.BytesRecorded);
				CGASYTLnLJS.Set();
				return;
			}
		}

		internal void iIfSYjdkx3Q(object sender, StoppedEventArgs e)
		{
			hDhSYoe8dl9?.Dispose();
			CyISYdUU6nT?.Dispose();
			CxrSYMIbTdV.Set();
		}

		internal object abDSYn0rKX0()
		{
			return ytXSYAsp1aA;
		}

		internal static bool kKTAQcWu6KNxuDY77ZC7()
		{
			return mWoDYYWuIrtx7F9lZxdX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_0
	{
		public int CKtSYUUK6hU;

		public int VSFSYlG5o1H;

		public string LpSSYif3f8V;

		public double awoSY3eEhbV;

		public double kSVSYf1w0gb;

		public string AA5SYz5vBLS;

		public bool vTZSIweh0sS;

		public string S8ESItNb9RI;

		public string fwNSIgMiEsD;

		public AutoResetEvent c0JSILTTcwR;

		private static _003C_003Ec__DisplayClass58_0 JZPQ66WuwB1gnkhtL7iK;

		internal void VvxSYOI5I2h()
		{
			_003C_003Ec__DisplayClass58_1 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_1();
			_003C_003Ec__DisplayClass58_.LGDSI2m2u3C = this;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST = new RecordSoundWindow();
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.SampleRate = CKtSYUUK6hU;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.Channels = VSFSYlG5o1H;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.SavePath = LpSSYif3f8V;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.AutoStartSeconds = awoSY3eEhbV;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.SilentStopSeconds = kSVSYf1w0gb;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.HelpText = AA5SYz5vBLS;
			int num = 0;
			if (!bxwLhAWuTdLuI9NJuLQf())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.Closed += _003C_003Ec__DisplayClass58_.tPDSIvvcdNv;
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.Show();
			_003C_003Ec__DisplayClass58_.Ji4SISDXVST.Activate();
		}

		internal object TptSYFwQhMP()
		{
			return S8ESItNb9RI;
		}

		internal static void CheJR4WusTd3vaNFj4XB()
		{
		}

		internal static bool bxwLhAWuTdLuI9NJuLQf()
		{
			return JZPQ66WuwB1gnkhtL7iK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass58_1
	{
		public RecordSoundWindow Ji4SISDXVST;

		public _003C_003Ec__DisplayClass58_0 LGDSI2m2u3C;

		internal static _003C_003Ec__DisplayClass58_1 yrR9tLWuCF5ua5pHI72P;

		internal void tPDSIvvcdNv(object sender, EventArgs e)
		{
			LGDSI2m2u3C.vTZSIweh0sS = Ji4SISDXVST.IsSuccess;
			LGDSI2m2u3C.S8ESItNb9RI = Ji4SISDXVST.OutputPath;
			LGDSI2m2u3C.fwNSIgMiEsD = Ji4SISDXVST.ErrorMessage;
			LGDSI2m2u3C.c0JSILTTcwR.Set();
		}

		internal static bool UbfmTSWu7r9hUC8Ki1Jc()
		{
			return yrR9tLWuCF5ua5pHI72P == null;
		}
	}

	[CompilerGenerated]
	private readonly string rtagH29f4Fj = "sys:recordSound";

	[CompilerGenerated]
	private readonly string FScgHuK5jT9 = "录制声音/语音识别";

	[CompilerGenerated]
	private readonly IEnumerable<string> t3rgHN42k1p = new string[4] { "sound", "recorder", "mp3", "wav" };

	[CompilerGenerated]
	private readonly string CAZgHJ8JbAS = $"fa:{EFontAwesomeIcon.Light_Microphone}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory Ni6gH04LyXR = StepRunnerCategory.System;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ChVgHCXZ1ho;

	[CompilerGenerated]
	private readonly string ki1gHPtqGsU = "录制音频到文件或识别语音";

	[CompilerGenerated]
	private readonly StepType famgHEOVuEV;

	[CompilerGenerated]
	private readonly string J1IgHyRiLJ6 = "https://getquicker.net/KC/Help/Doc/recordsound";

	[CompilerGenerated]
	private readonly bool XSNgH8IOBh8;

	[CompilerGenerated]
	private readonly bool dbtgHaEWehI;

	private static readonly StepInParamDef vOdgH7DmGAd;

	private static readonly StepInParamDef AkpgHRgHkFV;

	private static readonly StepInParamDef S37gHqyKgAi;

	private static readonly StepInParamDef JLLgHcgHdJK;

	private static readonly StepInParamDef KqbgHV4sOqV;

	private static readonly StepInParamDef DqOgHZGMrgp;

	private static readonly StepInParamDef hDJgH9iicNW;

	private static readonly StepInParamDef NoZgHh4Wn2s;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> OeogHe5TwO7 = new List<StepInParamDef> { vOdgH7DmGAd, AkpgHRgHkFV, S37gHqyKgAi, JLLgHcgHdJK, KqbgHV4sOqV, DqOgHZGMrgp, hDJgH9iicNW, NoZgHh4Wn2s };

	private static readonly StepOutParamDef o2ngHY2prrL;

	private static StepOutParamDef ib3gHIcEuPM;

	private static StepOutParamDef bjBgHWo6rtg;

	private static StepOutParamDef qmYgHkQUxTB;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> iwIgHG974LF = new List<StepOutParamDef> { o2ngHY2prrL, ib3gHIcEuPM, bjBgHWo6rtg, qmYgHkQUxTB };

	private static KJ2KZno7dbEJwGDRv9u WpQ8h5QsAQ7TJv5Jgo3d;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return rtagH29f4Fj;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return FScgHuK5jT9;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return t3rgHN42k1p;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return CAZgHJ8JbAS;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return Ni6gH04LyXR;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ChVgHCXZ1ho;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return ki1gHPtqGsU;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return famgHEOVuEV;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return J1IgHyRiLJ6;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return XSNgH8IOBh8;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return dbtgHaEWehI;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return OeogHe5TwO7;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return iwIgHG974LF;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.DZxSYWFpN03 = step;
		_003C_003Ec__DisplayClass55_.WRpSYk2thyH = context;
		_003C_003Ec__DisplayClass55_.JZFSYGwd7ro = this;
		_003C_003Ec__DisplayClass55_.T6CSYsglC94 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass55_.WRpSYk2thyH, _003C_003Ec__DisplayClass55_.DZxSYWFpN03, _003C_003Ec__DisplayClass55_.T6CSYsglC94, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass55_.GlISYIMSJuC, (Action)null, (Action)null, NoZgHh4Wn2s, o2ngHY2prrL);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) rWwgHtm5tbi(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		if (!G5QgHSw0xNN())
		{
			return (isSuccess: false, message: "当前无可用的音频输入设备。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass56_.e5cSY1v56Nd = XActionHelper.GetTextParamValue(DqOgHZGMrgp, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass56_.pQOSYbZsUss = XActionHelper.GetNumberParamValue(KqbgHV4sOqV, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(hDJgH9iicNW, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass56_.TFtSY6wBwTf = new AppSettings();
		if (string.IsNullOrEmpty(textParamValue))
		{
			return (isSuccess: false, message: "请填写所选语音服务商的账号配置。本地版不提供原厂语音授权。", failReason: ActionStopFlag.OperationFailed);
		}
		else
		{
			IDictionary<string, object> dictionary = VariableHelper.ConvertToDict(textParamValue).ToIgnoreCase();
			if (!dictionary.ContainsKey("appid") || string.IsNullOrEmpty(dictionary["appid"].ToString()))
			{
				return (isSuccess: false, message: "服务商账号格式错误，缺少appid", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass56_.TFtSY6wBwTf.AppID = dictionary["appid"].ToString();
			if (!dictionary.ContainsKey("apikey") || string.IsNullOrEmpty(dictionary["apikey"].ToString()))
			{
				return (isSuccess: false, message: "服务商账号格式错误，缺少apikey", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass56_.TFtSY6wBwTf.ApiKey = dictionary["apikey"].ToString();
			if (!dictionary.ContainsKey("apisecret") || string.IsNullOrEmpty(dictionary["apisecret"].ToString()))
			{
				return (isSuccess: false, message: "服务商账号格式错误，缺少apisecret", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass56_.TFtSY6wBwTf.ApiSecret = dictionary["apisecret"].ToString();
		}
		_003C_003Ec__DisplayClass56_.K4TSYxpv9r6 = new ManualResetEvent(false);
		_003C_003Ec__DisplayClass56_.bDcSYXWSsBf = false;
		_003C_003Ec__DisplayClass56_.WmCSYmkIBtN = "";
		_003C_003Ec__DisplayClass56_.GMXSYKXFSYV = "";
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_.vCdSYHbtD8L);
		_003C_003Ec__DisplayClass56_.K4TSYxpv9r6.WaitOne();
		if (_003C_003Ec__DisplayClass56_.bDcSYXWSsBf)
		{
			XActionHelper.OutputResult(bjBgHWo6rtg, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass56_.WmCSYmkIBtN, xaction_0);
			XActionHelper.OutputResult(qmYgHkQUxTB, actionStep_0, actionExecuteContext_0, "", xaction_0);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_.GMXSYKXFSYV))
		{
			return (isSuccess: false, message: _003C_003Ec__DisplayClass56_.GMXSYKXFSYV, failReason: ActionStopFlag.UserCancel);
		}
		return (isSuccess: false, message: _003C_003Ec__DisplayClass56_.GMXSYKXFSYV, failReason: ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) xD8gHgtlmtW(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
		_003C_003Ec__DisplayClass57_.ytXSYAsp1aA = XActionHelper.GetTextParamValue(S37gHqyKgAi, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass57_.ytXSYAsp1aA = s2CgHvOLR3o(_003C_003Ec__DisplayClass57_.ytXSYAsp1aA);
		_003C_003Ec__DisplayClass57_.XLgSYDR5iEj = XActionHelper.GetNumberParamValue(KqbgHV4sOqV, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass57_.CyISYdUU6nT = new WasapiLoopbackCapture();
		_003C_003Ec__DisplayClass57_.hDhSYoe8dl9 = new WaveFileWriter(_003C_003Ec__DisplayClass57_.ytXSYAsp1aA, _003C_003Ec__DisplayClass57_.CyISYdUU6nT.WaveFormat);
		_003C_003Ec__DisplayClass57_.CGASYTLnLJS = new ManualResetEvent(false);
		_003C_003Ec__DisplayClass57_.CxrSYMIbTdV = new ManualResetEvent(false);
		_003C_003Ec__DisplayClass57_.b1vSY4C3lB0 = false;
		_003C_003Ec__DisplayClass57_.nJtSY5CLqRE = 0L;
		_003C_003Ec__DisplayClass57_.CyISYdUU6nT.DataAvailable += _003C_003Ec__DisplayClass57_.P1HSYQ2IiEF;
		_003C_003Ec__DisplayClass57_.CyISYdUU6nT.RecordingStopped += _003C_003Ec__DisplayClass57_.iIfSYjdkx3Q;
		_003C_003Ec__DisplayClass57_.CyISYdUU6nT.StartRecording();
		if (WaitHandle.WaitAny(new WaitHandle[2]
		{
			_003C_003Ec__DisplayClass57_.CGASYTLnLJS,
			actionExecuteContext_0.CancellationToken.Value.WaitHandle
		}) == 1)
		{
			_003C_003Ec__DisplayClass57_.CyISYdUU6nT.StopRecording();
			return (isSuccess: false, message: "录制已取消(未开始)", failReason: ActionStopFlag.UserCancel);
		}
		if (WaitHandle.WaitAny(new WaitHandle[2]
		{
			_003C_003Ec__DisplayClass57_.CxrSYMIbTdV,
			actionExecuteContext_0.CancellationToken.Value.WaitHandle
		}) == 1)
		{
			_003C_003Ec__DisplayClass57_.CyISYdUU6nT.StopRecording();
			return (isSuccess: false, message: "录制已取消(已开始)", failReason: ActionStopFlag.UserCancel);
		}
		while (_003C_003Ec__DisplayClass57_.CyISYdUU6nT.CaptureState != CaptureState.Stopped)
		{
			Thread.Sleep(500);
		}
		XActionHelper.OutputResultIfNeeded(ib3gHIcEuPM, _003C_003Ec__DisplayClass57_.abDSYn0rKX0, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) RwXgHLxqgT9(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
		string textParamValue = XActionHelper.GetTextParamValue(AkpgHRgHkFV, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass58_.LpSSYif3f8V = XActionHelper.GetTextParamValue(S37gHqyKgAi, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass58_.awoSY3eEhbV = XActionHelper.GetNumberParamValue(JLLgHcgHdJK, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass58_.kSVSYf1w0gb = XActionHelper.GetNumberParamValue(KqbgHV4sOqV, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass58_.AA5SYz5vBLS = XActionHelper.GetTextParamValue(DqOgHZGMrgp, actionStep_0, actionExecuteContext_0);
		string[] array = textParamValue.Trim().Split('|');
		_003C_003Ec__DisplayClass58_.CKtSYUUK6hU = int.Parse(array[0]);
		_003C_003Ec__DisplayClass58_.VSFSYlG5o1H = int.Parse(array[1]);
		if (!G5QgHSw0xNN())
		{
			return (isSuccess: false, message: "当前无可用的音频输入设备。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass58_.LpSSYif3f8V = s2CgHvOLR3o(_003C_003Ec__DisplayClass58_.LpSSYif3f8V);
		_003C_003Ec__DisplayClass58_.vTZSIweh0sS = false;
		_003C_003Ec__DisplayClass58_.S8ESItNb9RI = "";
		_003C_003Ec__DisplayClass58_.fwNSIgMiEsD = "";
		_003C_003Ec__DisplayClass58_.c0JSILTTcwR = new AutoResetEvent(false);
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass58_.VvxSYOI5I2h);
		_003C_003Ec__DisplayClass58_.c0JSILTTcwR.WaitOne();
		if (!_003C_003Ec__DisplayClass58_.vTZSIweh0sS)
		{
			return (isSuccess: false, message: _003C_003Ec__DisplayClass58_.fwNSIgMiEsD, failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResultIfNeeded(ib3gHIcEuPM, _003C_003Ec__DisplayClass58_.TptSYFwQhMP, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private string s2CgHvOLR3o(string string_5)
	{
		if (string.IsNullOrEmpty(string_5))
		{
			string_5 = Path.Combine(AppHelper.GetTempPath(), DateTime.Now.ToString("yyyyMMdd_hhmmss_fff") + ".wav");
			if (WpQ8h5QsAQ7TJv5Jgo3d == null)
			{
				switch (0)
				{
				}
			}
		}
		else if (Directory.Exists(string_5))
		{
			string_5 = Path.Combine(string_5, DateTime.Now.ToString("yyyyMMdd_hhmmss_fff") + ".wav");
		}
		else if (!Path.GetExtension(string_5).EqualsAny(true, ".wav"))
		{
			string_5 = Path.Combine(string_5, DateTime.Now.ToString("yyyyMMdd_hhmmss_fff") + ".wav");
		}
		FileSystemHelper.EnsureFileFolderExists(string_5);
		return string_5;
	}

	private bool G5QgHSw0xNN()
	{
		using (new WaveInEvent())
		{
			if (WaveIn.DeviceCount > 0)
			{
				return true;
			}
			return false;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(vOdgH7DmGAd, step) ?? "";
	}

	static KJ2KZno7dbEJwGDRv9u()
	{
		vOdgH7DmGAd = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "record",
			SelectionItems = new SelectionItem[3]
			{
				new SelectionItem("record", "录制外部声音"),
				new SelectionItem("record_internal", "录制正在播放的声音"),
				new SelectionItem("short_voice_input", "短语音输入")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		AkpgHRgHkFV = new StepInParamDef
		{
			Key = "waveFormat",
			Name = "采样率和声道",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "16000|1",
			SelectionItems = new SelectionItem[10]
			{
				new SelectionItem("8000|1", "单声道，8 kHz"),
				new SelectionItem("16000|1", "单声道，16 kHz"),
				new SelectionItem("22050|1", "单声道，22.05 kHz"),
				new SelectionItem("32000|1", "单声道，32 kHz"),
				new SelectionItem("44100|1", "单声道，44.1 kHz"),
				new SelectionItem("8000|2", "双声道，8 kHz"),
				new SelectionItem("16000|2", "双声道，16 kHz"),
				new SelectionItem("22050|2", "双声道，22.05 kHz"),
				new SelectionItem("32000|2", "双声道，32 kHz"),
				new SelectionItem("44100|2", "双声道，44.1 kHz")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = false,
			ValidForList = new string[1] { "record" }
		};
		S37gHqyKgAi = new StepInParamDef
		{
			Key = "filePath",
			Name = "文件保存路径",
			Description = "可选。可以为：1）留空(自动保存到TEMP目录中)。2）完整的文件路径。3）保存目录(自动生成文件名)。",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			IsControlField = false,
			ValidForList = new string[2] { "record", "record_internal" }
		};
		JLLgHcgHdJK = new StepInParamDef
		{
			Key = "autoStartSeconds",
			Name = "自动开始录音",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Number,
			DefaultValue = 0,
			Description = "倒计时几秒开始录音，0：立即开始，-1：不自动开始；",
			ValidForList = new string[1] { "record" }
		};
		KqbgHV4sOqV = new StepInParamDef
		{
			Key = "silentStopSeconds",
			Name = "静音停止秒数",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Number,
			DefaultValue = 3,
			Description = "检测到音量较低多长时间后自动停止录音，<1 表示不检测。",
			ValidForList = new string[3] { "record", "record_internal", "short_voice_input" }
		};
		DqOgHZGMrgp = new StepInParamDef
		{
			Key = "helpText",
			Name = "提示文字",
			Description = "",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			IsControlField = false,
			ValidForList = new string[2] { "record", "short_voice_input" }
		};
		hDJgH9iicNW = new StepInParamDef
		{
			Key = "vendorAccount",
			Name = "服务商账号",
			Description = "填写用户自行配置的服务商账号；格式要求请参考模块文档",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			IsControlField = false,
			IsMultiLine = true,
			ValidForList = new string[1] { "short_voice_input" }
		};
		NoZgHh4Wn2s = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		o2ngHY2prrL = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		ib3gHIcEuPM = new StepOutParamDef
		{
			Key = "outputFilePath",
			Name = "文件保存路径",
			Description = "音频文件的完整路径。",
			Type = VarType.Text,
			ValidForList = new string[2] { "record", "record_internal" }
		};
		bjBgHWo6rtg = new StepOutParamDef
		{
			Key = "speechContent",
			Name = "语音文字内容",
			Description = "获得的语音输入内容",
			Type = VarType.Text,
			ValidForList = new string[1] { "short_voice_input" }
		};
		qmYgHkQUxTB = new StepOutParamDef
		{
			Key = "error",
			Name = "错误",
			Description = "失败原因提示消息",
			Type = VarType.Text,
			ValidForList = new string[1] { "short_voice_input" }
		};
	}

	internal static bool rqenCuQsnP3B19QZ0kZw()
	{
		return WpQ8h5QsAQ7TJv5Jgo3d == null;
	}
}
