using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Services;
using Quicker.Properties;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using tRpvUuYAvZDSs0CG8ap;

namespace Quicker.Domain.Actions;

public static class ActionTypeManager
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Rh6vM5Q7Qpe;

		public static Func<ActionRunnerBase> Hy0vMD38kPv;

		public static Func<ActionItem> xKivMd3LfZg;

		public static Func<BaseActionParamEditor> nYPvMoQgsxG;

		public static Func<ActionRunnerBase> I4MvMTCAOHX;

		public static Func<ActionItem> NrivMM8VLjp;

		public static Func<BaseActionParamEditor> qBavMAQyBeL;

		public static Func<ActionRunnerBase> GLbvMOqg9Je;

		public static Func<ActionItem> LOqvMF4JEZc;

		public static Func<BaseActionParamEditor> KpMvMUf4BXZ;

		public static Func<ActionRunnerBase> ECRvMlDqt6f;

		public static Func<ActionItem> cfyvMief3Lw;

		public static Func<BaseActionParamEditor> O6UvM3t6a0Q;

		public static Func<ActionRunnerBase> DtOvMfV5uXc;

		public static Func<ActionItem> b7vvMzjEbL2;

		public static Func<BaseActionParamEditor> Dv6vAwa1J46;

		public static Func<ActionRunnerBase> zngvAtvjIkG;

		public static Func<ActionItem> YhTvAgWIrjF;

		public static Func<BaseActionParamEditor> WUKvALQAmyC;

		public static Func<ActionRunnerBase> Yi1vAvXl1lN;

		public static Func<ActionItem> WKMvASgMd29;

		public static Func<BaseActionParamEditor> XyGvA2dB9Vr;

		public static Func<ActionRunnerBase> oOKvAuethFR;

		public static Func<ActionItem> F9SvANVwJpW;

		public static Func<BaseActionParamEditor> W88vAJbaCm6;

		public static Func<ActionRunnerBase> b1ivA0GA9CU;

		public static Func<ActionRunnerBase> gQUvACTCabW;

		public static Func<ActionItem> vLpvAPgc9MI;

		public static Func<ActionRunnerBase> QVsvAEkjaDP;

		public static Func<ActionItem> KvTvAy8vOqr;

		public static Func<ActionRunnerBase> XG8vA85M8C3;

		public static Func<ActionItem> wBNvAa4koqj;

		public static Func<BaseActionParamEditor> VdhvA76SdZY;

		public static Func<ActionRunnerBase> AfKvARBI7DS;

		public static Func<ActionItem> nfhvAqWL5wj;

		public static Func<BaseActionParamEditor> CkrvAcGxuQ9;

		public static Func<ActionRunnerBase> uAsvAV5K6Im;

		public static Func<ActionItem> N4AvAZ3utPw;

		public static Func<BaseActionParamEditor> KHyvA9wm7ev;

		public static Func<ActionRunnerBase> OTJvAhAqpXM;

		public static Func<ActionItem> URPvAe0bd4t;

		public static Func<BaseActionParamEditor> RBjvAYA5fFS;

		public static Func<ActionRunnerBase> csRvAIDqVVS;

		public static Func<ActionItem> OxtvAWG3d79;

		public static Func<BaseActionParamEditor> JNSvAkuhopc;

		public static Func<ActionRunnerBase> wtrvAGeDwjX;

		public static Func<ActionItem> Y8fvAsTge9c;

		public static Func<BaseActionParamEditor> LJqvAHV9EFc;

		internal static _003C_003Ec RP6IQDWXXapufE96GsqM;

		static _003C_003Ec()
		{
			Rh6vM5Q7Qpe = new _003C_003Ec();
		}

		internal ActionRunnerBase g56vMw8uTiC()
		{
			return new SendKeysActionRunner();
		}

		internal ActionItem DnkvMtIO1w9()
		{
			return new ActionItem
			{
				ActionType = ActionType.SendKeys,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("sendkeys.png")
			};
		}

		internal BaseActionParamEditor QySvMgPjokp()
		{
			return new SendKeysActionParamEditor();
		}

		internal ActionRunnerBase gMdvMLV4pk5()
		{
			return new ProcessStartActionRunner();
		}

		internal ActionItem bXevMvk0FOh()
		{
			return new ActionItem
			{
				ActionType = ActionType.RunProgram,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("run_program.png")
			};
		}

		internal BaseActionParamEditor v2RvMSnJX2a()
		{
			return new RunProgramActionParamEditor();
		}

		internal ActionRunnerBase XMvvM2rj3aK()
		{
			return new ProcessStartActionRunner();
		}

		internal ActionItem hNFvMue1QdE()
		{
			return new ActionItem
			{
				ActionType = ActionType.OpenFile,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("file.png")
			};
		}

		internal BaseActionParamEditor FKEvMNjT84i()
		{
			return new OpenFileActionParamEditor();
		}

		internal ActionRunnerBase FfEvMJKZVLA()
		{
			return new ProcessStartActionRunner();
		}

		internal ActionItem S1xvM0fX3n0()
		{
			return new ActionItem
			{
				ActionType = ActionType.OpenFolder,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("open_folder.png")
			};
		}

		internal BaseActionParamEditor j47vMChQODP()
		{
			return new OpenFolderActionParamEditor();
		}

		internal ActionRunnerBase A3hvMPClWOu()
		{
			return new UrlActionRunner();
		}

		internal ActionItem oGWvMEB57oG()
		{
			return new ActionItem
			{
				ActionType = ActionType.OpenUrl,
				Title = "",
				Data = "https://",
				Icon = AppHelper.GetSystemIconUrl("website.png")
			};
		}

		internal BaseActionParamEditor VYZvMypfN5Z()
		{
			return new UrlActionParamEditor();
		}

		internal ActionRunnerBase dZZvM8ymq10()
		{
			return new SendTextActionRunner();
		}

		internal ActionItem EQuvMaigKRD()
		{
			return new ActionItem
			{
				ActionType = ActionType.SendText,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("send_text.png")
			};
		}

		internal BaseActionParamEditor KdWvM7kjn5i()
		{
			return new SendTextActionParamEditor();
		}

		internal ActionRunnerBase wN6vMRdOn4j()
		{
			return new WOuuwRY5ykJRSxIVgu6();
		}

		internal ActionItem HZSvMq9uqsB()
		{
			return new ActionItem
			{
				ActionType = ActionType.LinkAction,
				Title = "",
				Icon = ""
			};
		}

		internal BaseActionParamEditor f9BvMca6byf()
		{
			return new LinkActionParameter();
		}

		internal ActionRunnerBase mSdvMVsdAh4()
		{
			return new WaitTimeActionRunner();
		}

		internal ActionItem DRIvMZeBCmd()
		{
			return new ActionItem
			{
				ActionType = ActionType.WaitTime,
				Title = "等待时间",
				Icon = AppHelper.GetSystemIconUrl("wait_time.png"),
				Data = "50"
			};
		}

		internal BaseActionParamEditor Ek7vM9SOJMa()
		{
			return new WaitTimeActionParamEditor();
		}

		internal ActionRunnerBase dM2vMhcucWy()
		{
			return new EmptyActionRunner();
		}

		internal ActionRunnerBase AZfvMeh3KJj()
		{
			return new FolderActionRunner();
		}

		internal ActionItem xO1vMYAyJQi()
		{
			return new ActionItem
			{
				ActionType = ActionType.Folder,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("action_folder.png"),
				Children = new List<ActionItem>
				{
					new ActionItem
					{
						ActionType = ActionType.GoParent,
						Icon = AppHelper.GetSystemIconUrl("go_parent.png"),
						Title = "返回",
						Row = 0,
						Col = 0
					}
				}
			};
		}

		internal ActionRunnerBase KD6vMIs13wo()
		{
			return new GoParentActionRunner();
		}

		internal ActionItem H0QvMW04xVD()
		{
			return new ActionItem
			{
				ActionType = ActionType.GoParent,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("go_parent.png")
			};
		}

		internal ActionRunnerBase tHrvMkeiV2W()
		{
			return new OpenProfileActionRunner();
		}

		internal ActionItem pk8vMGwx2SV()
		{
			return new ActionItem
			{
				ActionType = ActionType.OpenProfile,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("profile.png")
			};
		}

		internal BaseActionParamEditor xiOvMsxcHwy()
		{
			return new OpenProfileActionParamEditor();
		}

		internal ActionRunnerBase yKPvMHlclpB()
		{
			return new SelectActionRunner();
		}

		internal ActionItem orxvM1JcoPH()
		{
			return new ActionItem
			{
				ActionType = ActionType.Select,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("select_actiontype.png")
			};
		}

		internal BaseActionParamEditor qIKvMbRJloG()
		{
			return new SelectActionParamEditor();
		}

		internal ActionRunnerBase F2AvM6pbPKR()
		{
			return new SubProgramActionRunner();
		}

		internal ActionItem OdZvMX0LcPo()
		{
			return new ActionItem
			{
				ActionType = ActionType.SubProgram,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("sub_program.png")
			};
		}

		internal BaseActionParamEditor BpxvMmNEKAp()
		{
			return new SubProgramActionParamEditor();
		}

		internal ActionRunnerBase i5GvMK0brFw()
		{
			return new RunScriptFileActionRunner();
		}

		internal ActionItem pLOvMxTfVZa()
		{
			return new ActionItem
			{
				ActionType = ActionType.RunScriptFile,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("script.png")
			};
		}

		internal BaseActionParamEditor sSovMroCKZe()
		{
			return new RunScriptFileActionActionEditor();
		}

		internal ActionRunnerBase oU1vMpVl3sn()
		{
			return new CompositeActionRunner();
		}

		internal ActionItem cxIvMBl9FkO()
		{
			return new ActionItem
			{
				ActionType = ActionType.Composite,
				Title = "",
				Icon = AppHelper.GetSystemIconUrl("composite.png")
			};
		}

		internal BaseActionParamEditor tLNvMQuhVDg()
		{
			return new CompositeActionParamEditor();
		}

		internal ActionRunnerBase h40vMjybIEx()
		{
			return new XActionRunner();
		}

		internal ActionItem TtuvMnRi9kZ()
		{
			return new ActionItem
			{
				ActionType = ActionType.XAction,
				Title = "",
				Icon = "",
				EnableEvaluateVariable = false
			};
		}

		internal BaseActionParamEditor i3WvM4jAinW()
		{
			return new SubProgramActionParamEditor();
		}

		internal static bool LTbI6VWX2ODjDQkXBRyQ()
		{
			return RP6IQDWXXapufE96GsqM == null;
		}
	}

	[CompilerGenerated]
	private static readonly IDictionary<ActionType, ActionTypeInfo> mTptnqQG02X;

	internal static object Ev3YkIQuqOEH5llThOt1;

	public static IDictionary<ActionType, ActionTypeInfo> AllActionTypes
	{
		[CompilerGenerated]
		get
		{
			return mTptnqQG02X;
		}
	}

	static ActionTypeManager()
	{
		mTptnqQG02X = new Dictionary<ActionType, ActionTypeInfo>();
		LYltnR9Wvuw();
	}

	private static void LYltnR9Wvuw()
	{
		mTptnqQG02X.Add(ActionType.SendKeys, new ActionTypeInfo
		{
			CanBeChildAction = true,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_SendKeys,
			Description = CommonStrings.Common_ActionType_SendKeys_Desc,
			Icon = AppHelper.GetSystemIconUrl("sendkeys.png"),
			CreateRunnerFunc = (_003C_003Ec.Hy0vMD38kPv ?? (_003C_003Ec.Hy0vMD38kPv = _003C_003Ec.Rh6vM5Q7Qpe.g56vMw8uTiC)),
			CreateNewItemFunc = (_003C_003Ec.xKivMd3LfZg ?? (_003C_003Ec.xKivMd3LfZg = _003C_003Ec.Rh6vM5Q7Qpe.DnkvMtIO1w9)),
			CreateParamEditorFunc = (_003C_003Ec.nYPvMoQgsxG ?? (_003C_003Ec.nYPvMoQgsxG = _003C_003Ec.Rh6vM5Q7Qpe.QySvMgPjokp)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/keyboard-input"
		});
		mTptnqQG02X.Add(ActionType.RunProgram, new ActionTypeInfo
		{
			Name = CommonStrings.Common_ActionType_RunProgram,
			CanBeChildAction = true,
			CanBeRootAction = true,
			Description = CommonStrings.Common_ActionType_RunProgram_Desc,
			Icon = AppHelper.GetSystemIconUrl("run_program.png"),
			CreateRunnerFunc = (_003C_003Ec.I4MvMTCAOHX ?? (_003C_003Ec.I4MvMTCAOHX = _003C_003Ec.Rh6vM5Q7Qpe.gMdvMLV4pk5)),
			CreateNewItemFunc = (_003C_003Ec.NrivMM8VLjp ?? (_003C_003Ec.NrivMM8VLjp = _003C_003Ec.Rh6vM5Q7Qpe.bXevMvk0FOh)),
			CreateParamEditorFunc = (_003C_003Ec.qBavMAQyBeL ?? (_003C_003Ec.qBavMAQyBeL = _003C_003Ec.Rh6vM5Q7Qpe.v2RvMSnJX2a)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/run-or-open"
		});
		mTptnqQG02X.Add(ActionType.OpenFile, new ActionTypeInfo
		{
			CanBeRootAction = false,
			CanBeChildAction = false,
			Name = CommonStrings.Common_ActionType_OpenFile,
			Description = CommonStrings.Common_ActionType_OpenFile_Desc,
			Icon = AppHelper.GetSystemIconUrl("file.png"),
			CreateRunnerFunc = (_003C_003Ec.GLbvMOqg9Je ?? (_003C_003Ec.GLbvMOqg9Je = _003C_003Ec.Rh6vM5Q7Qpe.XMvvM2rj3aK)),
			CreateNewItemFunc = (_003C_003Ec.LOqvMF4JEZc ?? (_003C_003Ec.LOqvMF4JEZc = _003C_003Ec.Rh6vM5Q7Qpe.hNFvMue1QdE)),
			CreateParamEditorFunc = (_003C_003Ec.KpMvMUf4BXZ ?? (_003C_003Ec.KpMvMUf4BXZ = _003C_003Ec.Rh6vM5Q7Qpe.FKEvMNjT84i)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/run-or-open"
		});
		mTptnqQG02X.Add(ActionType.OpenFolder, new ActionTypeInfo
		{
			Name = CommonStrings.Common_ActionType_OpenFolder,
			CanBeChildAction = false,
			CanBeRootAction = false,
			Description = CommonStrings.Common_ActionType_OpenFolder_Desc,
			Icon = AppHelper.GetSystemIconUrl("open_folder.png"),
			CreateRunnerFunc = (_003C_003Ec.ECRvMlDqt6f ?? (_003C_003Ec.ECRvMlDqt6f = _003C_003Ec.Rh6vM5Q7Qpe.FfEvMJKZVLA)),
			CreateNewItemFunc = (_003C_003Ec.cfyvMief3Lw ?? (_003C_003Ec.cfyvMief3Lw = _003C_003Ec.Rh6vM5Q7Qpe.S1xvM0fX3n0)),
			CreateParamEditorFunc = (_003C_003Ec.O6UvM3t6a0Q ?? (_003C_003Ec.O6UvM3t6a0Q = _003C_003Ec.Rh6vM5Q7Qpe.j47vMChQODP)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/run-or-open"
		});
		mTptnqQG02X.Add(ActionType.OpenUrl, new ActionTypeInfo
		{
			Name = CommonStrings.Common_ActionType_OpenUrl,
			CanBeChildAction = true,
			CanBeRootAction = true,
			Description = CommonStrings.Common_ActionType_OpenUrl_Desc,
			Icon = AppHelper.GetSystemIconUrl("website.png"),
			CreateRunnerFunc = (_003C_003Ec.DtOvMfV5uXc ?? (_003C_003Ec.DtOvMfV5uXc = _003C_003Ec.Rh6vM5Q7Qpe.A3hvMPClWOu)),
			CreateNewItemFunc = (_003C_003Ec.b7vvMzjEbL2 ?? (_003C_003Ec.b7vvMzjEbL2 = _003C_003Ec.Rh6vM5Q7Qpe.oGWvMEB57oG)),
			CreateParamEditorFunc = (_003C_003Ec.Dv6vAwa1J46 ?? (_003C_003Ec.Dv6vAwa1J46 = _003C_003Ec.Rh6vM5Q7Qpe.VYZvMypfN5Z)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/open-url"
		});
		mTptnqQG02X.Add(ActionType.SendText, new ActionTypeInfo
		{
			CanBeChildAction = true,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_SendText,
			Description = CommonStrings.Common_ActionType_SendText_Desc,
			Icon = AppHelper.GetSystemIconUrl("send_text.png"),
			CreateRunnerFunc = (_003C_003Ec.zngvAtvjIkG ?? (_003C_003Ec.zngvAtvjIkG = _003C_003Ec.Rh6vM5Q7Qpe.dZZvM8ymq10)),
			CreateNewItemFunc = (_003C_003Ec.YhTvAgWIrjF ?? (_003C_003Ec.YhTvAgWIrjF = _003C_003Ec.Rh6vM5Q7Qpe.EQuvMaigKRD)),
			CreateParamEditorFunc = (_003C_003Ec.WUKvALQAmyC ?? (_003C_003Ec.WUKvALQAmyC = _003C_003Ec.Rh6vM5Q7Qpe.KdWvM7kjn5i)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/send-text"
		});
		mTptnqQG02X.Add(ActionType.LinkAction, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = true,
			Name = "链接动作",
			Description = "连接到其它动作的快捷方式",
			Icon = "fa:Light_Link",
			CreateRunnerFunc = (_003C_003Ec.Yi1vAvXl1lN ?? (_003C_003Ec.Yi1vAvXl1lN = _003C_003Ec.Rh6vM5Q7Qpe.wN6vMRdOn4j)),
			CreateNewItemFunc = (_003C_003Ec.WKMvASgMd29 ?? (_003C_003Ec.WKMvASgMd29 = _003C_003Ec.Rh6vM5Q7Qpe.HZSvMq9uqsB)),
			CreateParamEditorFunc = (_003C_003Ec.XyGvA2dB9Vr ?? (_003C_003Ec.XyGvA2dB9Vr = _003C_003Ec.Rh6vM5Q7Qpe.f9BvMca6byf)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/link-action"
		});
		mTptnqQG02X.Add(ActionType.WaitTime, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = false,
			Name = "等待时间",
			Description = "订单一定的时间(毫秒ms)后继续执行",
			Icon = AppHelper.GetSystemIconUrl("wait_time.png"),
			CreateRunnerFunc = (_003C_003Ec.oOKvAuethFR ?? (_003C_003Ec.oOKvAuethFR = _003C_003Ec.Rh6vM5Q7Qpe.mSdvMVsdAh4)),
			CreateNewItemFunc = (_003C_003Ec.F9SvANVwJpW ?? (_003C_003Ec.F9SvANVwJpW = _003C_003Ec.Rh6vM5Q7Qpe.DRIvMZeBCmd)),
			CreateParamEditorFunc = (_003C_003Ec.W88vAJbaCm6 ?? (_003C_003Ec.W88vAJbaCm6 = _003C_003Ec.Rh6vM5Q7Qpe.Ek7vM9SOJMa))
		});
		mTptnqQG02X.Add(ActionType.Empty, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = false,
			Name = "空",
			Description = "",
			Icon = "",
			CreateRunnerFunc = (_003C_003Ec.b1ivA0GA9CU ?? (_003C_003Ec.b1ivA0GA9CU = _003C_003Ec.Rh6vM5Q7Qpe.dM2vMhcucWy))
		});
		mTptnqQG02X.Add(ActionType.Folder, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = true,
			Name = "动作文件夹",
			Description = "创建快捷动作文件夹",
			Icon = AppHelper.GetSystemIconUrl("action_folder.png"),
			CreateRunnerFunc = (_003C_003Ec.gQUvACTCabW ?? (_003C_003Ec.gQUvACTCabW = _003C_003Ec.Rh6vM5Q7Qpe.AZfvMeh3KJj)),
			CreateNewItemFunc = (_003C_003Ec.vLpvAPgc9MI ?? (_003C_003Ec.vLpvAPgc9MI = _003C_003Ec.Rh6vM5Q7Qpe.xO1vMYAyJQi))
		});
		mTptnqQG02X.Add(ActionType.GoParent, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = false,
			Name = "返回上级",
			Description = "返回上级动作文件夹",
			Icon = AppHelper.GetSystemIconUrl("go_parent.png"),
			CreateRunnerFunc = (_003C_003Ec.QVsvAEkjaDP ?? (_003C_003Ec.QVsvAEkjaDP = _003C_003Ec.Rh6vM5Q7Qpe.KD6vMIs13wo)),
			CreateNewItemFunc = (_003C_003Ec.KvTvAy8vOqr ?? (_003C_003Ec.KvTvAy8vOqr = _003C_003Ec.Rh6vM5Q7Qpe.H0QvMW04xVD))
		});
		mTptnqQG02X.Add(ActionType.OpenProfile, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_OpenProfile,
			Description = CommonStrings.Common_ActionType_OpenProfile_Desc,
			Icon = AppHelper.GetSystemIconUrl("profile.png"),
			CreateRunnerFunc = (_003C_003Ec.XG8vA85M8C3 ?? (_003C_003Ec.XG8vA85M8C3 = _003C_003Ec.Rh6vM5Q7Qpe.tHrvMkeiV2W)),
			CreateNewItemFunc = (_003C_003Ec.wBNvAa4koqj ?? (_003C_003Ec.wBNvAa4koqj = _003C_003Ec.Rh6vM5Q7Qpe.pk8vMGwx2SV)),
			CreateParamEditorFunc = (_003C_003Ec.VdhvA76SdZY ?? (_003C_003Ec.VdhvA76SdZY = _003C_003Ec.Rh6vM5Q7Qpe.xiOvMsxcHwy)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/switch-profile"
		});
		mTptnqQG02X.Add(ActionType.Select, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = false,
			Name = "选择执行",
			Description = "从多个动作中选择一个执行",
			Icon = AppHelper.GetSystemIconUrl("select_actiontype.png"),
			CreateRunnerFunc = (_003C_003Ec.AfKvARBI7DS ?? (_003C_003Ec.AfKvARBI7DS = _003C_003Ec.Rh6vM5Q7Qpe.yKPvMHlclpB)),
			CreateNewItemFunc = (_003C_003Ec.nfhvAqWL5wj ?? (_003C_003Ec.nfhvAqWL5wj = _003C_003Ec.Rh6vM5Q7Qpe.orxvM1JcoPH)),
			CreateParamEditorFunc = (_003C_003Ec.CkrvAcGxuQ9 ?? (_003C_003Ec.CkrvAcGxuQ9 = _003C_003Ec.Rh6vM5Q7Qpe.qIKvMbRJloG))
		});
		mTptnqQG02X.Add(ActionType.SubProgram, new ActionTypeInfo
		{
			CanBeChildAction = true,
			CanBeRootAction = false,
			Name = "子程序",
			Description = "内部数据处理程序",
			Icon = AppHelper.GetSystemIconUrl("sub_program.png"),
			CreateRunnerFunc = (_003C_003Ec.uAsvAV5K6Im ?? (_003C_003Ec.uAsvAV5K6Im = _003C_003Ec.Rh6vM5Q7Qpe.F2AvM6pbPKR)),
			CreateNewItemFunc = (_003C_003Ec.N4AvAZ3utPw ?? (_003C_003Ec.N4AvAZ3utPw = _003C_003Ec.Rh6vM5Q7Qpe.OdZvMX0LcPo)),
			CreateParamEditorFunc = (_003C_003Ec.KHyvA9wm7ev ?? (_003C_003Ec.KHyvA9wm7ev = _003C_003Ec.Rh6vM5Q7Qpe.BpxvMmNEKAp))
		});
		if (!Tcl4ZyQuidnmUZtWOaRq())
		{
			switch (0)
			{
			}
		}
		mTptnqQG02X.Add(ActionType.RunScriptFile, new ActionTypeInfo
		{
			CanBeChildAction = true,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_RunScriptFile,
			Description = CommonStrings.Common_ActionType_RunScriptFile_Desc,
			Icon = AppHelper.GetSystemIconUrl("script.png"),
			CreateRunnerFunc = (_003C_003Ec.OTJvAhAqpXM ?? (_003C_003Ec.OTJvAhAqpXM = _003C_003Ec.Rh6vM5Q7Qpe.i5GvMK0brFw)),
			CreateNewItemFunc = (_003C_003Ec.URPvAe0bd4t ?? (_003C_003Ec.URPvAe0bd4t = _003C_003Ec.Rh6vM5Q7Qpe.pLOvMxTfVZa)),
			CreateParamEditorFunc = (_003C_003Ec.RBjvAYA5fFS ?? (_003C_003Ec.RBjvAYA5fFS = _003C_003Ec.Rh6vM5Q7Qpe.sSovMroCKZe)),
			HelpLink = "https://getquicker.net/KC/Manual/Doc/run-script"
		});
		mTptnqQG02X.Add(ActionType.Composite, new ActionTypeInfo
		{
			CanBeChildAction = true,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_Composite,
			Description = CommonStrings.Common_ActionType_Composite_Desc,
			Icon = AppHelper.GetSystemIconUrl("composite.png"),
			CreateRunnerFunc = (_003C_003Ec.csRvAIDqVVS ?? (_003C_003Ec.csRvAIDqVVS = _003C_003Ec.Rh6vM5Q7Qpe.oU1vMpVl3sn)),
			CreateNewItemFunc = (_003C_003Ec.OxtvAWG3d79 ?? (_003C_003Ec.OxtvAWG3d79 = _003C_003Ec.Rh6vM5Q7Qpe.cxIvMBl9FkO)),
			CreateParamEditorFunc = (_003C_003Ec.JNSvAkuhopc ?? (_003C_003Ec.JNSvAkuhopc = _003C_003Ec.Rh6vM5Q7Qpe.tLNvMQuhVDg))
		});
		mTptnqQG02X.Add(ActionType.XAction, new ActionTypeInfo
		{
			CanBeChildAction = false,
			CanBeRootAction = true,
			Name = CommonStrings.Common_ActionType_XAction,
			Description = CommonStrings.Common_ActionType_XAction_Desc,
			Icon = AppHelper.GetSystemIconUrl("composite.png"),
			CreateRunnerFunc = (_003C_003Ec.wtrvAGeDwjX ?? (_003C_003Ec.wtrvAGeDwjX = _003C_003Ec.Rh6vM5Q7Qpe.h40vMjybIEx)),
			CreateNewItemFunc = (_003C_003Ec.Y8fvAsTge9c ?? (_003C_003Ec.Y8fvAsTge9c = _003C_003Ec.Rh6vM5Q7Qpe.TtuvMnRi9kZ)),
			CreateParamEditorFunc = (_003C_003Ec.LJqvAHV9EFc ?? (_003C_003Ec.LJqvAHV9EFc = _003C_003Ec.Rh6vM5Q7Qpe.i3WvM4jAinW)),
			HelpLink = ""
		});
	}

	public static ActionTypeInfo GetActionTypeInfo(ActionType actionType)
	{
		if (!mTptnqQG02X.ContainsKey(actionType))
		{
			return mTptnqQG02X[ActionType.NotSupported];
		}
		return mTptnqQG02X[actionType];
	}

	public static ActionRunnerBase GetActionRunner(ActionItem actionItem)
	{
		return GetActionTypeInfo(actionItem.ActionType).CreateRunnerFunc();
	}

	public static ActionItem CreateActionItem(ActionType actionType)
	{
		ActionTypeInfo actionTypeInfo = GetActionTypeInfo(actionType);
		if (actionTypeInfo != null && actionTypeInfo.CreateNewItemFunc != null)
		{
			return actionTypeInfo.CreateNewItemFunc();
		}
		return null;
	}

	public static void RunAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		PointTargetInfo targetInfo = actionExecuteContext.TargetInfo;
		if (!string.IsNullOrEmpty(action.TemplateId))
		{
			DataService dataService = AppState.DataService;
			if (dataService != null && dataService.BlockedActions.Contains(action.TemplateId))
			{
				AppHelper.ShowError("此动作和当前操作系统版本不兼容，已停止运行。", false);
				return;
			}
		}
		GetActionRunner(action)?.ExecuteAction(action, btnIndex, server, actionExecuteContext);
	}

	public static BaseActionParamEditor CreateParamEditor(ActionType actionType)
	{
		if (mTptnqQG02X[actionType].CreateParamEditorFunc == null)
		{
			return null;
		}
		return mTptnqQG02X[actionType].CreateParamEditorFunc();
	}

	public static void FixActionType(ActionItem action)
	{
		if (action.ActionType == ActionType.OpenFile || action.ActionType == ActionType.OpenFolder)
		{
			action.ActionType = ActionType.RunProgram;
		}
	}

	internal static bool Tcl4ZyQuidnmUZtWOaRq()
	{
		return Ev3YkIQuqOEH5llThOt1 == null;
	}
}
