using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Network;

public class DownloadStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ovrSEXv5QQD;

		public static RemoteCertificateValidationCallback c8pSEmFjxEQ;

		private static _003C_003Ec f94mphWd8xdKC7x0Gm6m;

		static _003C_003Ec()
		{
			ovrSEXv5QQD = new _003C_003Ec();
		}

		internal bool o67SE6UTDsC(object httpRequestMessage, X509Certificate cert, X509Chain cetChain, SslPolicyErrors policyErrors)
		{
			return true;
		}

		internal static bool l4HaGvWdRoQ4MHL5n7Ks()
		{
			return f94mphWd8xdKC7x0Gm6m == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public ActionStep acSSExbT6s2;

		public ActionExecuteContext Ha7SErPBmLH;

		public XAction QYqSEpJYCNh;

		private static _003C_003Ec__DisplayClass51_0 DCe5LFWdP5bHLDPx3Ws8;

		internal (bool isSuccess, string message, ActionStopFlag failReason) xEcSEKc9BRE()
		{
			_003C_003Ec__DisplayClass51_1 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_1
			{
				hxISEDKai0w = this
			};
			string textParamValue = XActionHelper.GetTextParamValue(xSFgJmHyoKQ, acSSExbT6s2, Ha7SErPBmLH);
			string text = XActionHelper.GetTextParamValue(HGKgJKMqKah, acSSExbT6s2, Ha7SErPBmLH);
			string textParamValue2 = XActionHelper.GetTextParamValue(PEbgJxYWp0W, acSSExbT6s2, Ha7SErPBmLH);
			string textParamValue3 = XActionHelper.GetTextParamValue(WEigJr1dGq6, acSSExbT6s2, Ha7SErPBmLH);
			string textParamValue4 = XActionHelper.GetTextParamValue(dmLgJpieguk, acSSExbT6s2, Ha7SErPBmLH);
			string textParamValue5 = XActionHelper.GetTextParamValue(Rn9gJBWel8O, acSSExbT6s2, Ha7SErPBmLH);
			double num = XActionHelper.GetNumberParamValue(ATigJQ93Hd3, acSSExbT6s2, Ha7SErPBmLH);
			_003C_003Ec__DisplayClass51_.DikSEQW9Go1 = XActionHelper.GetBooleanParamValue(liDgJjxFVP5, acSSExbT6s2, Ha7SErPBmLH);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(LncgJ4aqDSW, acSSExbT6s2, Ha7SErPBmLH);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(M3VgJnj6w7j, acSSExbT6s2, Ha7SErPBmLH);
			WebRequestHandler webRequestHandler = new WebRequestHandler
			{
				UseCookies = false
			};
			if (booleanParamValue2)
			{
				webRequestHandler.ServerCertificateValidationCallback = _003C_003Ec.c8pSEmFjxEQ ?? (_003C_003Ec.c8pSEmFjxEQ = _003C_003Ec.ovrSEXv5QQD.o67SE6UTDsC);
			}
			if (!string.IsNullOrEmpty(text))
			{
				FileSystemHelper.EnsureFolderExists(text);
			}
			else
			{
				text = KnownFolders.GetPath(KnownFolder.Downloads);
			}
			if (num <= 1E-07)
			{
				num = 2147483647.0;
			}
			_003C_003Ec__DisplayClass51_.iYpSEjBu0IX = new CancellationTokenSource();
			_003C_003Ec__DisplayClass51_.biXSEnRuYV9 = new HttpClientWithProgress(textParamValue, text, textParamValue2, null, webRequestHandler, Ha7SErPBmLH, (int)(num * 1000.0), _003C_003Ec__DisplayClass51_.iYpSEjBu0IX, booleanParamValue);
			try
			{
				_003C_003Ec__DisplayClass51_.biXSEnRuYV9.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
				{
					NoCache = true
				};
				if (!string.IsNullOrEmpty(textParamValue3))
				{
					_003C_003Ec__DisplayClass51_.biXSEnRuYV9.DefaultRequestHeaders.Add("User-Agent", textParamValue3);
				}
				if (!string.IsNullOrEmpty(textParamValue4))
				{
					string[] array = textParamValue4.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string text2 in array)
					{
						int num2 = text2.IndexOf(':');
						if (num2 >= 0)
						{
							_003C_003Ec__DisplayClass51_.biXSEnRuYV9.DefaultRequestHeaders.Add(text2.Substring(0, num2), (text2.Length > num2 + 1) ? text2.Substring(num2 + 1) : string.Empty);
						}
					}
				}
				if (!string.IsNullOrEmpty(textParamValue5))
				{
					_003C_003Ec__DisplayClass51_.biXSEnRuYV9.DefaultRequestHeaders.Add("Cookie", textParamValue5);
				}
				_003C_003Ec__DisplayClass51_.JdDSE51gHZ1 = ProgressReportMgr.RequestProgressId();
				_003C_003Ec__DisplayClass51_.hWRSE4mbqVC = AppHelper.fLiLTj0x4QY();
				try
				{
					if (_003C_003Ec__DisplayClass51_.DikSEQW9Go1)
					{
						ProgressReportMgr.UpdateProgress(_003C_003Ec__DisplayClass51_.JdDSE51gHZ1, "", _003C_003Ec__DisplayClass51_.biXSEnRuYV9.SaveFileName, 0.0, "准备下载", Ha7SErPBmLH.Id, _003C_003Ec__DisplayClass51_.iYpSEjBu0IX);
					}
					_003C_003Ec__DisplayClass51_.biXSEnRuYV9.ProgressChanged += _003C_003Ec__DisplayClass51_.L4qSEBpYNnW;
					_003C_003Ec__DisplayClass51_.biXSEnRuYV9.StartDownload().GetAwaiter().GetResult();
					XActionHelper.OutputResult(IVygJMskoKl, acSSExbT6s2, Ha7SErPBmLH, _003C_003Ec__DisplayClass51_.biXSEnRuYV9.DownloadedSize, QYqSEpJYCNh);
				}
				catch (TaskCanceledException)
				{
					return (isSuccess: false, message: "下载已超时或取消", failReason: ActionStopFlag.OperationFailed);
				}
				catch (Exception ex2)
				{
					GMigJsj7F5A.Warn("下载出错：" + ex2.Message, ex2);
					return (isSuccess: false, message: "下载出错：" + ex2.Message, failReason: ActionStopFlag.OperationFailed);
				}
				finally
				{
					if (_003C_003Ec__DisplayClass51_.DikSEQW9Go1)
					{
						ProgressReportMgr.RemoveProgress(_003C_003Ec__DisplayClass51_.JdDSE51gHZ1);
					}
				}
				XActionHelper.OutputResult(jBIgJo8ojUJ, acSSExbT6s2, Ha7SErPBmLH, _003C_003Ec__DisplayClass51_.biXSEnRuYV9.FullPathName, QYqSEpJYCNh);
				XActionHelper.OutputResult(Iu8gJTIEI6e, acSSExbT6s2, Ha7SErPBmLH, _003C_003Ec__DisplayClass51_.biXSEnRuYV9.ContentMD5 ?? "", QYqSEpJYCNh);
				XActionHelper.OutputResult(qcugJAAKgxr, acSSExbT6s2, Ha7SErPBmLH, _003C_003Ec__DisplayClass51_.biXSEnRuYV9.ETag ?? "", QYqSEpJYCNh);
			}
			finally
			{
				if (_003C_003Ec__DisplayClass51_.biXSEnRuYV9 != null)
				{
					((IDisposable)_003C_003Ec__DisplayClass51_.biXSEnRuYV9).Dispose();
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool qnti9EWdMdE0ucTOxrcl()
		{
			return DCe5LFWdP5bHLDPx3Ws8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_1
	{
		public bool DikSEQW9Go1;

		public CancellationTokenSource iYpSEjBu0IX;

		public HttpClientWithProgress biXSEnRuYV9;

		public long hWRSE4mbqVC;

		public int JdDSE51gHZ1;

		public _003C_003Ec__DisplayClass51_0 hxISEDKai0w;

		private static _003C_003Ec__DisplayClass51_1 VyPUiXWdxmqdDfm7KaJR;

		internal void L4qSEBpYNnW(long? size, long downloaded, double? percentage)
		{
			double num = 50.0;
			if (percentage.HasValue)
			{
				num = percentage.Value;
			}
			if (!DikSEQW9Go1)
			{
				return;
			}
			long len = (long)((double)downloaded * 1000.0 / (double)(AppHelper.fLiLTj0x4QY() - hWRSE4mbqVC));
			int id = JdDSE51gHZ1;
			string saveFileName = biXSEnRuYV9.SaveFileName;
			double percentage2 = num;
			string[] obj = new string[5]
			{
				len.ToReadableSize(),
				"/S  ",
				downloaded.ToReadableSize(),
				"/",
				null
			};
			object obj2;
			if (!size.HasValue)
			{
				obj2 = null;
			}
			else
			{
				obj2 = size.GetValueOrDefault().ToReadableSize();
				if (obj2 != null)
				{
					goto IL_00a4;
				}
			}
			obj2 = "-";
			goto IL_00a4;
			IL_00a4:
			obj[4] = (string)obj2;
			ProgressReportMgr.UpdateProgress(id, "", saveFileName, percentage2, string.Concat(obj), hxISEDKai0w.Ha7SErPBmLH.Id, iYpSEjBu0IX);
		}

		internal static bool HlqX0IWdIQ3iKPv1rMZc()
		{
			return VyPUiXWdxmqdDfm7KaJR == null;
		}
	}

	private static readonly ILog GMigJsj7F5A;

	[CompilerGenerated]
	private readonly IEnumerable<string> fsrgJHjocFf;

	[CompilerGenerated]
	private readonly string k4XgJ1FeLUW = $"fa:{EFontAwesomeIcon.Light_Download}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> o5mgJbXqWYj;

	[CompilerGenerated]
	private readonly string taqgJ6LeFid = "https://getquicker.net/KC/Help/Doc/download";

	[CompilerGenerated]
	private readonly bool TjegJXnBIGb;

	private static readonly StepInParamDef xSFgJmHyoKQ;

	private static readonly StepInParamDef HGKgJKMqKah;

	private static readonly StepInParamDef PEbgJxYWp0W;

	private static readonly StepInParamDef WEigJr1dGq6;

	private static readonly StepInParamDef dmLgJpieguk;

	private static readonly StepInParamDef Rn9gJBWel8O;

	private static readonly StepInParamDef ATigJQ93Hd3;

	private static readonly StepInParamDef liDgJjxFVP5;

	private static readonly StepInParamDef M3VgJnj6w7j;

	private static readonly StepInParamDef LncgJ4aqDSW;

	private static readonly StepInParamDef dbIgJ5fXeAN;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> osIgJDQHMrx = new List<StepInParamDef>
	{
		xSFgJmHyoKQ, HGKgJKMqKah, PEbgJxYWp0W, WEigJr1dGq6, dmLgJpieguk, Rn9gJBWel8O, ATigJQ93Hd3, M3VgJnj6w7j, liDgJjxFVP5, LncgJ4aqDSW,
		dbIgJ5fXeAN
	};

	private static readonly StepOutParamDef GAJgJdd4veI;

	private static readonly StepOutParamDef jBIgJo8ojUJ;

	private static readonly StepOutParamDef Iu8gJTIEI6e;

	private static readonly StepOutParamDef IVygJMskoKl;

	private static readonly StepOutParamDef qcugJAAKgxr;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> liSgJOv8DSM = new List<StepOutParamDef> { GAJgJdd4veI, jBIgJo8ojUJ, Iu8gJTIEI6e, qcugJAAKgxr, IVygJMskoKl };

	internal static DownloadStep KoTEVlQM8bONp7IVcDUC;

	public string Key => "sys:download";

	public string Name => "下载文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return fsrgJHjocFf;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return k4XgJ1FeLUW;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return o5mgJbXqWYj;
		}
	}

	public string Description => "下载网络文件(请勿用于下载大文件)";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return taqgJ6LeFid;
		}
	}

	public bool IsRisky => true;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return TjegJXnBIGb;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return osIgJDQHMrx;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return liSgJOv8DSM;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.acSSExbT6s2 = step;
		_003C_003Ec__DisplayClass51_.Ha7SErPBmLH = context;
		_003C_003Ec__DisplayClass51_.QYqSEpJYCNh = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass51_.Ha7SErPBmLH, _003C_003Ec__DisplayClass51_.acSSExbT6s2, _003C_003Ec__DisplayClass51_.QYqSEpJYCNh, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass51_.xEcSEKc9BRE, (Action)null, (Action)null, dbIgJ5fXeAN, GAJgJdd4veI);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(xSFgJmHyoKQ, step);
	}

	static DownloadStep()
	{
		GMigJsj7F5A = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		xSFgJmHyoKQ = new StepInParamDef
		{
			Key = "url",
			Name = "网址",
			DefaultValue = "https://",
			Description = "要下载的文件网址",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		HGKgJKMqKah = new StepInParamDef
		{
			Key = "savePath",
			Name = "保存文件夹",
			DefaultValue = "",
			Description = "下载文件的保存位置（文件夹的路径）",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		PEbgJxYWp0W = new StepInParamDef
		{
			Key = "saveName",
			Name = "保存文件名",
			DefaultValue = "",
			Description = "可选。为空时自动判断文件名。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		WEigJr1dGq6 = new StepInParamDef
		{
			Key = "ua",
			Name = "UserAgent",
			DefaultValue = "",
			Description = "可选。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.Input
		};
		dmLgJpieguk = new StepInParamDef
		{
			Key = "header",
			Name = "请求头",
			DefaultValue = "",
			Description = "发送的HttpHeader。每行一个header，格式为Name:Value",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		Rn9gJBWel8O = new StepInParamDef
		{
			Key = "cookie",
			Name = "Cookie",
			DefaultValue = "",
			Description = "请求的cookie内容",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		ATigJQ93Hd3 = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时秒数",
			Description = "长时间未接收到数据时，中止下载。",
			DefaultValue = 10,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Number
		};
		liDgJjxFVP5 = new StepInParamDef
		{
			Key = "showProgress",
			Name = "显示进度条",
			DefaultValue = false,
			Description = "是否显示下载进度条",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		M3VgJnj6w7j = new StepInParamDef
		{
			Key = "skipCertVerify",
			Name = "忽略HTTPS证书验证",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		LncgJ4aqDSW = new StepInParamDef
		{
			Key = "autoRename",
			Name = "如果文件已存在，自动重命名下载的文件",
			DefaultValue = false,
			Description = "在文件名后面增加“_序号”避免重复。否则将会覆盖已有文件。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		dbIgJ5fXeAN = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		GAJgJdd4veI = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功下载了文件",
			Type = VarType.Boolean
		};
		jBIgJo8ojUJ = new StepOutParamDef
		{
			Key = "savedPath",
			Name = "文件路径",
			Description = "文件的完整保存路径",
			Type = VarType.Text
		};
		Iu8gJTIEI6e = new StepOutParamDef
		{
			Key = "contentMd5",
			Name = "内容MD5",
			Description = "内容MD5值，不是所有请求都会返回此内容。",
			Type = VarType.Text
		};
		IVygJMskoKl = new StepOutParamDef
		{
			Key = "downloadSize",
			Name = "下载大小",
			Description = "下载文件的大小（字节数）",
			Type = VarType.Text
		};
		qcugJAAKgxr = new StepOutParamDef
		{
			Key = "eTag",
			Name = "ETag",
			Description = "响应头Etag值，不是所有请求都会返回此内容。",
			Type = VarType.Text
		};
	}

	internal static bool PP8JLFQMRAW7UIPKx1Di()
	{
		return KoTEVlQM8bONp7IVcDUC == null;
	}
}
