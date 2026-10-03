using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;
using FontAwesome5;
using NAudio.Wave;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class PlaySoundStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public ActionStep v05vfQelRom;

		public ActionExecuteContext lfEvfjNYVUO;

		public PlaySoundStep uqUvfnJA0JX;

		internal static _003C_003Ec__DisplayClass45_0 tUDT0gW3J5kbPby4cxLG;

		internal (bool isSuccess, string message, ActionStopFlag failReason) LLcvfB1BuOd()
		{
			string textParamValue = XActionHelper.GetTextParamValue(u79tOTE5HDd, v05vfQelRom, lfEvfjNYVUO);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(XGNtOF6NK3f, v05vfQelRom, lfEvfjNYVUO);
			if (textParamValue == "TTS")
			{
				_003C_003Ec__DisplayClass45_1 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_1
				{
					L1Bvf5wdheJ = XActionHelper.GetTextParamValue(i86tOOmUapZ, v05vfQelRom, lfEvfjNYVUO)
				};
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass45_.L1Bvf5wdheJ))
				{
					return (isSuccess: false, message: "文本内容不能为空", failReason: ActionStopFlag.OperationFailed);
				}
				if (booleanParamValue)
				{
					QF2tOjZXWIB(_003C_003Ec__DisplayClass45_.L1Bvf5wdheJ);
				}
				else
				{
					Task.Run((Action)_003C_003Ec__DisplayClass45_.JQUvf4JJuDE);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			_003C_003Ec__DisplayClass45_2 _003C_003Ec__DisplayClass45_2 = new _003C_003Ec__DisplayClass45_2
			{
				iMavfoqnyVw = this,
				Eylvfd3ImpP = string.Empty
			};
			if (textParamValue == "LOCAL")
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(QbJtOM8sAKx, v05vfQelRom, lfEvfjNYVUO);
				string text = (string.IsNullOrEmpty(textParamValue2) ? "info" : textParamValue2);
				_003C_003Ec__DisplayClass45_2.Eylvfd3ImpP = Path.Combine(AppHelper.GetAppFolder(), "Sounds", text + ".mp3");
				if (!System.IO.File.Exists(_003C_003Ec__DisplayClass45_2.Eylvfd3ImpP))
				{
					return (isSuccess: false, message: "音频文件不存在", failReason: ActionStopFlag.OperationFailed);
				}
			}
			else if (textParamValue == "EXTERN")
			{
				_003C_003Ec__DisplayClass45_2.Eylvfd3ImpP = XActionHelper.GetTextParamValue(fkUtOAZ3oKm, v05vfQelRom, lfEvfjNYVUO).Trim();
			}
			if (string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass45_2.Eylvfd3ImpP))
			{
				return (isSuccess: false, message: "未指定要播放的音频网址或文件路径。", failReason: ActionStopFlag.OperationFailed);
			}
			if (booleanParamValue)
			{
				uqUvfnJA0JX.SV4tOnCPD72(_003C_003Ec__DisplayClass45_2.Eylvfd3ImpP, lfEvfjNYVUO);
			}
			else
			{
				Task.Run((Action)_003C_003Ec__DisplayClass45_2.Y2BvfDxEfZv);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Ij5ZgQW3kVrRmTwAbiuu()
		{
			return tUDT0gW3J5kbPby4cxLG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_1
	{
		public string L1Bvf5wdheJ;

		internal static _003C_003Ec__DisplayClass45_1 jKSFjBW3rHuSP85bKEwS;

		internal void JQUvf4JJuDE()
		{
			QF2tOjZXWIB(L1Bvf5wdheJ);
		}

		internal static void m9bGSKW3LrIJXUt93PwO()
		{
		}

		internal static bool ClkngEW3N8OnLRYjEjgu()
		{
			return jKSFjBW3rHuSP85bKEwS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_2
	{
		public string Eylvfd3ImpP;

		public _003C_003Ec__DisplayClass45_0 iMavfoqnyVw;

		private static _003C_003Ec__DisplayClass45_2 zRenmsW3uWWGFir1iD4Z;

		internal void Y2BvfDxEfZv()
		{
			try
			{
				iMavfoqnyVw.uqUvfnJA0JX.SV4tOnCPD72(Eylvfd3ImpP, iMavfoqnyVw.lfEvfjNYVUO);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message ?? "");
			}
		}

		internal static bool AZHUEdW3o4nd1oYqRvhj()
		{
			return zRenmsW3uWWGFir1iD4Z == null;
		}
	}

	private static List<string> tHAtO4K4JVH;

	[CompilerGenerated]
	private readonly string RRBtO5o1mXZ = $"fa:{EFontAwesomeIcon.Light_Music}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> c46tOD0QTEa;

	[CompilerGenerated]
	private readonly string l9ctOdFFEC0 = "https://getquicker.net/KC/Help/Doc/playsound";

	[CompilerGenerated]
	private readonly bool nS3tOomL03K;

	private static readonly StepInParamDef u79tOTE5HDd;

	private static readonly StepInParamDef QbJtOM8sAKx;

	private static readonly StepInParamDef fkUtOAZ3oKm;

	private static readonly StepInParamDef i86tOOmUapZ;

	private static readonly StepInParamDef XGNtOF6NK3f;

	private static readonly StepInParamDef FnNtOUenMlN;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> XdCtOlCjWFj = new StepInParamDef[6] { u79tOTE5HDd, QbJtOM8sAKx, fkUtOAZ3oKm, i86tOOmUapZ, XGNtOF6NK3f, FnNtOUenMlN };

	private static readonly StepOutParamDef UTotOiCKcnu;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> IhjtO3uslwM = new List<StepOutParamDef> { UTotOiCKcnu };

	internal static PlaySoundStep hmUCLOQlCZ8UGY4QLWIJ;

	public string Key => "sys:playSound";

	public string Name => "播放声音";

	public IEnumerable<string> KeyWords => tHAtO4K4JVH;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return RRBtO5o1mXZ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return c46tOD0QTEa;
		}
	}

	public string Description => "播放声音提示或声音文件。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return l9ctOdFFEC0;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return nS3tOomL03K;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return XdCtOlCjWFj;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return IhjtO3uslwM;
		}
	}

	static PlaySoundStep()
	{
		tHAtO4K4JVH = new List<string>();
		u79tOTE5HDd = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "LOCAL",
			SelectionItems = new SelectionItem[3]
			{
				new SelectionItem("LOCAL", "内置声音提示"),
				new SelectionItem("EXTERN", "电脑文件或网络文件"),
				new SelectionItem("TTS", "朗读文本（系统TTS）")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		QbJtOM8sAKx = new StepInParamDef
		{
			Key = "localSound",
			Name = "提示音类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "info",
			SelectionItems = new SelectionItem[5]
			{
				new SelectionItem("info", "信息"),
				new SelectionItem("snip", "截图"),
				new SelectionItem("succeed", "成功"),
				new SelectionItem("warning", "警告"),
				new SelectionItem("wrong", "错误")
			},
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "LOCAL" },
			IsControlField = false
		};
		fkUtOAZ3oKm = new StepInParamDef
		{
			Key = "uri",
			Name = "路径或URL",
			Description = "音乐文件的本地路径或网址。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "EXTERN" }
		};
		i86tOOmUapZ = new StepInParamDef
		{
			Key = "text",
			Name = "文本内容",
			Description = "需要朗读的文本。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "TTS" },
			IsMultiLine = true
		};
		XGNtOF6NK3f = new StepInParamDef
		{
			Key = "wait",
			Name = "等待播放完成",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		FnNtOUenMlN = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		UTotOiCKcnu = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		foreach (SelectionItem selectionItem in u79tOTE5HDd.SelectionItems)
		{
			tHAtO4K4JVH.Add(selectionItem.Name);
			tHAtO4K4JVH.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.v05vfQelRom = step;
		_003C_003Ec__DisplayClass45_.lfEvfjNYVUO = context;
		_003C_003Ec__DisplayClass45_.uqUvfnJA0JX = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass45_.lfEvfjNYVUO, _003C_003Ec__DisplayClass45_.v05vfQelRom, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass45_.LLcvfB1BuOd, (Action)null, (Action)null, FnNtOUenMlN, UTotOiCKcnu);
	}

	private static void QF2tOjZXWIB(string string_2)
	{
		using SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
		speechSynthesizer.SetOutputToDefaultAudioDevice();
		speechSynthesizer.Speak(string_2);
	}

	private void SV4tOnCPD72(string string_2, ActionExecuteContext actionExecuteContext_0)
	{
		using MediaFoundationReader waveProvider = new MediaFoundationReader(string_2);
		using WaveOutEvent waveOutEvent = new WaveOutEvent();
		try
		{
			waveOutEvent.Init(waveProvider);
			waveOutEvent.Play();
			while (waveOutEvent.PlaybackState == PlaybackState.Playing && (actionExecuteContext_0 == null || !actionExecuteContext_0.IsShouldStopAction()))
			{
				if (actionExecuteContext_0 != null)
				{
					if (actionExecuteContext_0.IsShouldStopAction())
					{
						break;
					}
					CancellationToken? cancellationToken = actionExecuteContext_0.CancellationToken;
					if (cancellationToken.HasValue && cancellationToken.GetValueOrDefault().IsCancellationRequested)
					{
						break;
					}
				}
				Thread.Sleep(20);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("播放音频出错：" + ex.Message);
		}
	}

	public static void PlayFile(string path)
	{
		using Mp3FileReader waveProvider = new Mp3FileReader(path);
		using WaveOut waveOut = new WaveOut();
		waveOut.Init(waveProvider);
		waveOut.Play();
		while (waveOut.PlaybackState != PlaybackState.Stopped)
		{
			Thread.Sleep(20);
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(u79tOTE5HDd, step) + " " + XActionHelper.GetParamDisplayString(QbJtOM8sAKx, step);
	}

	internal static bool wmZD3hQl7BUalboqXxN5()
	{
		return hmUCLOQlCZ8UGY4QLWIJ == null;
	}
}
