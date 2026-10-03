using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using cXuiZ7i2m2sRaR7QhhS;
using l9W6KWifMfNKrInJR4l;
using lGFWOcimK6GZKnFIeLT;
using log4net;
using nSudn7i77a3JpXIFA0G;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;
using x6MHGwiYv06PXoBFlMe;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetExplorerPathStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec oASSvqesC0X;

		public static Func<object> JQ2Svc8NBhH;

		public static Func<object> BFnSvVW2Bl3;

		public static Func<object> LSfSvZJiVmt;

		public static Func<object> uJgSv9nfKl5;

		public static Func<object> OahSvhUh30m;

		public static Func<object> AjySve43epA;

		internal static _003C_003Ec Y4cAjuW0mSAr4lvD0wop;

		static _003C_003Ec()
		{
			oASSvqesC0X = new _003C_003Ec();
		}

		internal object pfoSvEtgZZr()
		{
			throw new InvalidOperationException("OneCommander不支持获取最后访问的路径参数。");
		}

		internal object KlISvy5oCC0()
		{
			throw new InvalidOperationException("OneCommander不支持获取所有打开的路径参数。");
		}

		internal object EHbSv8EZlaP()
		{
			return NativeMethods.GetAllOpenedFolders();
		}

		internal object pQASva4DKhd()
		{
			string text = NativeMethods.BDkLUEoGYlN();
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取最后访问的路径。");
			}
			return text;
		}

		internal object wg8Sv75JSBE()
		{
			return moAa3ciiBWM25Wu8vZH.YWxvtVWhd1u();
		}

		internal object SWgSvRLWBnm()
		{
			string text = moAa3ciiBWM25Wu8vZH.rELvtcvrD4D();
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取最后访问的路径。");
			}
			return text;
		}

		internal static bool QfYbbKW0sMtiqoBO9eUP()
		{
			return Y4cAjuW0mSAr4lvD0wop == null;
		}

		internal static void KlwgpeW07FL7mDxpFFxM()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public ActionStep rYDSvImtViO;

		public ActionExecuteContext da1SvWS3n6R;

		public XAction YG5SvkoBK2H;

		public GetExplorerPathStep qwdSvG6m3qu;

		internal static _003C_003Ec__DisplayClass44_0 Ny7wOqW04mM5U6ujQsbc;

		internal (bool isSuccess, string message, ActionStopFlag failReason) kIdSvYe1ktY()
		{
			_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_1
			{
				QbMSv1L3huW = this,
				drISvH7TDKc = XActionHelper.GetTextParamValue(eJsgtDfcHmx, rYDSvImtViO, da1SvWS3n6R)
			};
			Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass44_.uCaSvsGZcVR);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool k1pC30W0hXtUGHWX1rL9()
		{
			return Ny7wOqW04mM5U6ujQsbc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_1
	{
		public string drISvH7TDKc;

		public _003C_003Ec__DisplayClass44_0 QbMSv1L3huW;

		internal static _003C_003Ec__DisplayClass44_1 MPHoNtW0z7pTICKG9jKy;

		internal void uCaSvsGZcVR()
		{
			string text = drISvH7TDKc;
			if (!(text == "getPath"))
			{
				if (text == "setPath")
				{
					QbMSv1L3huW.qwdSvG6m3qu.lcKgtrYdbNI(QbMSv1L3huW.rYDSvImtViO, QbMSv1L3huW.da1SvWS3n6R, QbMSv1L3huW.YG5SvkoBK2H);
				}
			}
			else
			{
				KmXgtpAljAk(QbMSv1L3huW.rYDSvImtViO, QbMSv1L3huW.da1SvWS3n6R, QbMSv1L3huW.YG5SvkoBK2H);
			}
		}

		internal static bool tkmMfgW1Vw9SgUiXIeDc()
		{
			return MPHoNtW0z7pTICKG9jKy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public (ExplorerSoftware explorer, IntPtr hWnd, string processName, bool isExplorerWindow) rRASvpvWpCR;

		public string DuCSvB4WHuQ;

		public Func<string> P2nSvQnliPQ;

		public Func<string> kSoSvje7tMr;

		public Func<string> jR2SvnTVdcB;

		internal static _003C_003Ec__DisplayClass46_0 IuKT9kW1FCvIVZqVo8bd;

		internal string f9rSvbsTDof()
		{
			return sDvXVkiWVWu4wUdiwlQ.oJFvwd4TOJW(rRASvpvWpCR.hWnd);
		}

		internal object ed2Sv62s0Mp()
		{
			string text = DuCSvB4WHuQ.Or(P2nSvQnliPQ ?? (P2nSvQnliPQ = OoHSvXcRx21));
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取当前路径，请在资源管理器中执行本操作。");
			}
			return text;
		}

		internal string OoHSvXcRx21()
		{
			return NativeMethods.GetCurrentFolder(rRASvpvWpCR.hWnd);
		}

		internal object Gu5Svm4B4Ql()
		{
			string text = DuCSvB4WHuQ.Or(kSoSvje7tMr ?? (kSoSvje7tMr = i3fSvKWyxNS));
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取当前路径，请在资源管理器中执行本操作。");
			}
			return text;
		}

		internal string i3fSvKWyxNS()
		{
			return d23lbji6LH2xdpIE1Qu.mB2vt0Xicgu(rRASvpvWpCR.hWnd);
		}

		internal object HmJSvxEnGnF()
		{
			string text = DuCSvB4WHuQ.Or(jR2SvnTVdcB ?? (jR2SvnTVdcB = dQ6SvrBiJVF));
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取当前路径，请在资源管理器中执行本操作。");
			}
			return text;
		}

		internal string dQ6SvrBiJVF()
		{
			return moAa3ciiBWM25Wu8vZH.jHKvtqwpORl(rRASvpvWpCR.hWnd);
		}

		internal static bool aGcTPOW1cESL4fR1fphB()
		{
			return IuKT9kW1FCvIVZqVo8bd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_1
	{
		public string oGWSv5irYfD;

		private static _003C_003Ec__DisplayClass46_1 ynkR4KW1pufBqmeFvDuM;

		internal object shKSv4HRHb2()
		{
			return oGWSv5irYfD;
		}

		internal static bool ODETXFW1XH2B6bwuDcSl()
		{
			return ynkR4KW1pufBqmeFvDuM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_2
	{
		public (string activeFolder, List<string> pathList) kDhSvT8xT6I;

		public _003C_003Ec__DisplayClass46_0 CovSvMwGftv;

		private static _003C_003Ec__DisplayClass46_2 Xybhf0W1Ahb6ARSUlCnJ;

		internal object A4wSvDLEX8E()
		{
			string text = CovSvMwGftv.DuCSvB4WHuQ.Or(kDhSvT8xT6I.activeFolder);
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取当前路径，请在资源管理器中执行本操作。");
			}
			return text;
		}

		internal object M8MSvdCKdRJ()
		{
			return kDhSvT8xT6I.pathList;
		}

		internal object LinSvoVXAAn()
		{
			string item = kDhSvT8xT6I.activeFolder;
			if (string.IsNullOrEmpty(item))
			{
				throw new InvalidOperationException("无法获取最后访问的路径。");
			}
			return item;
		}

		static _003C_003Ec__DisplayClass46_2()
		{
		}

		internal static bool dXtiYjW1noOs0PxGNbJ7()
		{
			return Xybhf0W1Ahb6ARSUlCnJ == null;
		}

		internal static void M0NBtoW1j9USiGSX7jvr()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_3
	{
		public IList<string> oeqSvFagj9B;

		private static _003C_003Ec__DisplayClass46_3 UvGlsTW1D4uOouCUBuQp;

		internal object eHDSvA8THdk()
		{
			return oeqSvFagj9B;
		}

		internal object YU6SvOKCq09()
		{
			string text = oeqSvFagj9B.FirstOrDefault();
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("无法获取最后访问的路径。");
			}
			return text;
		}

		internal static bool nNdZFIW136qSCAaT6TQN()
		{
			return UvGlsTW1D4uOouCUBuQp == null;
		}
	}

	private static readonly ILog F5AgtBndYcN;

	[CompilerGenerated]
	private readonly IEnumerable<string> UFZgtQNYixP = new string[6] { "文件", "文件夹", "dir", "explorer", "获取资源管理器当前路径", "路径" };

	[CompilerGenerated]
	private readonly string RmbgtjXre3O = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> w47gtnRyfyK;

	[CompilerGenerated]
	private readonly string jY5gt4oFcQ5 = "https://getquicker.net/KC/Help/Doc/getexplorerpath";

	[CompilerGenerated]
	private readonly bool p8Mgt5sjXsy;

	private static readonly StepInParamDef eJsgtDfcHmx;

	public static readonly StepInParamDef _pathParam;

	private static readonly StepInParamDef iiZgtdhF6EO;

	private static readonly StepOutParamDef HjhgtoisqJ1;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> iFjgtTfHvhv = new List<StepInParamDef> { eJsgtDfcHmx, _pathParam, iiZgtdhF6EO };

	private static readonly StepOutParamDef WxpgtMvDPeK;

	private static readonly StepOutParamDef YOZgtASZ2Jb;

	private static readonly StepOutParamDef GovgtOChlrO;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> fL1gtFbH3A8 = new StepOutParamDef[4] { WxpgtMvDPeK, YOZgtASZ2Jb, GovgtOChlrO, HjhgtoisqJ1 };

	internal static GetExplorerPathStep jUdQd4QRcOE3FJI1XFOq;

	public string Key => "sys:getExplorerPath";

	public string Name => "获取资源管理器路径/跳转路径";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return UFZgtQNYixP;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return RmbgtjXre3O;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return w47gtnRyfyK;
		}
	}

	public string Description => "获取资源管理器的当前文件夹路径。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return jY5gt4oFcQ5;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return p8Mgt5sjXsy;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return iFjgtTfHvhv;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return fL1gtFbH3A8;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.rYDSvImtViO = step;
		_003C_003Ec__DisplayClass44_.da1SvWS3n6R = context;
		_003C_003Ec__DisplayClass44_.YG5SvkoBK2H = action;
		_003C_003Ec__DisplayClass44_.qwdSvG6m3qu = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass44_.da1SvWS3n6R, _003C_003Ec__DisplayClass44_.rYDSvImtViO, _003C_003Ec__DisplayClass44_.YG5SvkoBK2H, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass44_.kIdSvYe1ktY, (Action)null, (Action)null, iiZgtdhF6EO, HjhgtoisqJ1);
	}

	private void lcKgtrYdbNI(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(_pathParam, actionStep_0, actionExecuteContext_0);
		NativeMethods.SetExplorerWindowPath(IntPtr.Zero, textParamValue);
	}

	private static void KmXgtpAljAk(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.rRASvpvWpCR = ytnqhyiMNhGmytDmEj7.zwDvtNYUZmk(null);
		_003C_003Ec__DisplayClass46_.DuCSvB4WHuQ = null;
		if (ProcessHelper.IsDesktopSoftware(_003C_003Ec__DisplayClass46_.rRASvpvWpCR.processName))
		{
			_003C_003Ec__DisplayClass46_.DuCSvB4WHuQ = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		try
		{
			_003C_003Ec__DisplayClass46_2 _003C_003Ec__DisplayClass46_4;
			int num;
			switch (_003C_003Ec__DisplayClass46_.rRASvpvWpCR.explorer)
			{
			default:
				XActionHelper.OutputResultIfNeeded(WxpgtMvDPeK, _003C_003Ec__DisplayClass46_.ed2Sv62s0Mp, actionStep_0, actionExecuteContext_0, xaction_0);
				XActionHelper.OutputResultIfNeeded(YOZgtASZ2Jb, _003C_003Ec.LSfSvZJiVmt ?? (_003C_003Ec.LSfSvZJiVmt = _003C_003Ec.oASSvqesC0X.EHbSv8EZlaP), actionStep_0, actionExecuteContext_0, xaction_0);
				XActionHelper.OutputResultIfNeeded(GovgtOChlrO, _003C_003Ec.uJgSv9nfKl5 ?? (_003C_003Ec.uJgSv9nfKl5 = _003C_003Ec.oASSvqesC0X.pQASva4DKhd), actionStep_0, actionExecuteContext_0, xaction_0);
				break;
			case ExplorerSoftware.DirectoryOpus:
				_003C_003Ec__DisplayClass46_4 = new _003C_003Ec__DisplayClass46_2();
				_003C_003Ec__DisplayClass46_4.CovSvMwGftv = _003C_003Ec__DisplayClass46_;
				num = 0;
				if (jUdQd4QRcOE3FJI1XFOq == null)
				{
					goto IL_0105;
				}
				goto IL_0152;
			case ExplorerSoftware.TotalCommander:
				goto IL_019c;
			case ExplorerSoftware.XYplorer:
				XActionHelper.OutputResultIfNeeded(WxpgtMvDPeK, _003C_003Ec__DisplayClass46_.HmJSvxEnGnF, actionStep_0, actionExecuteContext_0, xaction_0);
				XActionHelper.OutputResultIfNeeded(YOZgtASZ2Jb, _003C_003Ec.OahSvhUh30m ?? (_003C_003Ec.OahSvhUh30m = _003C_003Ec.oASSvqesC0X.wg8Sv75JSBE), actionStep_0, actionExecuteContext_0, xaction_0);
				XActionHelper.OutputResultIfNeeded(GovgtOChlrO, _003C_003Ec.AjySve43epA ?? (_003C_003Ec.AjySve43epA = _003C_003Ec.oASSvqesC0X.SWgSvRLWBnm), actionStep_0, actionExecuteContext_0, xaction_0);
				break;
			case ExplorerSoftware.OneCommander:
				{
					_003C_003Ec__DisplayClass46_1 _003C_003Ec__DisplayClass46_2 = new _003C_003Ec__DisplayClass46_1();
					if (!string.Equals(_003C_003Ec__DisplayClass46_.rRASvpvWpCR.processName, "onecommander", StringComparison.OrdinalIgnoreCase))
					{
						throw new InvalidOperationException("当前窗口不是OneCommander窗口（" + _003C_003Ec__DisplayClass46_.rRASvpvWpCR.processName + "）。");
					}
					_003C_003Ec__DisplayClass46_2.oGWSv5irYfD = _003C_003Ec__DisplayClass46_.DuCSvB4WHuQ.Or(_003C_003Ec__DisplayClass46_.f9rSvbsTDof);
					XActionHelper.OutputResultIfNeeded(WxpgtMvDPeK, _003C_003Ec__DisplayClass46_2.shKSv4HRHb2, actionStep_0, actionExecuteContext_0, xaction_0);
					XActionHelper.OutputResultIfNeeded(GovgtOChlrO, _003C_003Ec.JQ2Svc8NBhH ?? (_003C_003Ec.JQ2Svc8NBhH = _003C_003Ec.oASSvqesC0X.pfoSvEtgZZr), actionStep_0, actionExecuteContext_0, xaction_0);
					XActionHelper.OutputResultIfNeeded(YOZgtASZ2Jb, _003C_003Ec.BFnSvVW2Bl3 ?? (_003C_003Ec.BFnSvVW2Bl3 = _003C_003Ec.oASSvqesC0X.KlISvy5oCC0), actionStep_0, actionExecuteContext_0, xaction_0);
					break;
				}
				IL_019c:
				XActionHelper.OutputResultIfNeeded(WxpgtMvDPeK, _003C_003Ec__DisplayClass46_.Gu5Svm4B4Ql, actionStep_0, actionExecuteContext_0, xaction_0);
				if (XActionHelper.IsOutputParamSetted(YOZgtASZ2Jb.Key, actionStep_0) || XActionHelper.IsOutputParamSetted(GovgtOChlrO.Key, actionStep_0))
				{
					_003C_003Ec__DisplayClass46_3 _003C_003Ec__DisplayClass46_3 = new _003C_003Ec__DisplayClass46_3();
					_003C_003Ec__DisplayClass46_3.oeqSvFagj9B = d23lbji6LH2xdpIE1Qu.VhcvtPyGMtT();
					XActionHelper.OutputResultIfNeeded(YOZgtASZ2Jb, _003C_003Ec__DisplayClass46_3.eHDSvA8THdk, actionStep_0, actionExecuteContext_0, xaction_0);
					XActionHelper.OutputResultIfNeeded(GovgtOChlrO, _003C_003Ec__DisplayClass46_3.YU6SvOKCq09, actionStep_0, actionExecuteContext_0, xaction_0);
				}
				break;
				IL_0105:
				_003C_003Ec__DisplayClass46_4.kDhSvT8xT6I = cQCX97ioFnivYTCZNWb.Oi3vtvYuFIC(_003C_003Ec__DisplayClass46_4.CovSvMwGftv.rRASvpvWpCR.hWnd);
				XActionHelper.OutputResultIfNeeded(WxpgtMvDPeK, _003C_003Ec__DisplayClass46_4.A4wSvDLEX8E, actionStep_0, actionExecuteContext_0, xaction_0);
				num = 0;
				if (jUdQd4QRcOE3FJI1XFOq != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0152;
				IL_0152:
				switch (num)
				{
				case 1:
					break;
				default:
					XActionHelper.OutputResultIfNeeded(YOZgtASZ2Jb, _003C_003Ec__DisplayClass46_4.M8MSvdCKdRJ, actionStep_0, actionExecuteContext_0, xaction_0);
					XActionHelper.OutputResultIfNeeded(GovgtOChlrO, _003C_003Ec__DisplayClass46_4.LinSvoVXAAn, actionStep_0, actionExecuteContext_0, xaction_0);
					return;
				case 2:
					goto IL_019c;
				}
				goto IL_0105;
			}
		}
		catch (Exception ex)
		{
			F5AgtBndYcN.Warn(ex.Message, ex);
			throw new Exception(ex.Message + $"({_003C_003Ec__DisplayClass46_.rRASvpvWpCR.explorer})", ex);
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(eJsgtDfcHmx, step) + " " + XActionHelper.GetOutputParamDisplayString(WxpgtMvDPeK, step);
	}

	static GetExplorerPathStep()
	{
		F5AgtBndYcN = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		eJsgtDfcHmx = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "getPath",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("getPath", "获取路径"),
				new SelectionItem("setPath", "设置路径")
			},
			IsControlField = true
		};
		_pathParam = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			DefaultValue = "",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Text,
			ValidForList = new string[1] { "setPath" }
		};
		iiZgtdhF6EO = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		HjhgtoisqJ1 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		WxpgtMvDPeK = new StepOutParamDef
		{
			Key = "output",
			Name = "当前窗口路径",
			Description = "当前资源管理器窗口的路径",
			Type = VarType.Text,
			ValidForList = new string[1] { "getPath" }
		};
		YOZgtASZ2Jb = new StepOutParamDef
		{
			Key = "allPathList",
			Name = "所有打开的路径",
			Description = "所有资源管理器窗口中打开的路径列表",
			Type = VarType.List,
			ValidForList = new string[1] { "getPath" }
		};
		GovgtOChlrO = new StepOutParamDef
		{
			Key = "lastPath",
			Name = "最近访问的路径",
			Description = "最近访问的资源管理器窗口的路径",
			Type = VarType.Text,
			ValidForList = new string[1] { "getPath" }
		};
	}

	internal static bool w9YIBcQRWsym8IIJKLHK()
	{
		return jUdQd4QRcOE3FJI1XFOq == null;
	}
}
