using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using cuhTiBoSiWa4cURQRNv;
using FontAwesome5;
using NAudio.CoreAudioApi;
using pVHgu0odQ2fCYAKNFd3;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Open.Windows.Audio;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace Quicker.Actions.XActions.BuildinRunners.Sys;

public class AudioControlStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_0
	{
		public ActionStep exoS1G1vBRP;

		public ActionExecuteContext B6sS1siqYnc;

		public XAction oCWS1HtqciZ;

		public AudioControlStep iK3S11y6XA8;

		internal static _003C_003Ec__DisplayClass60_0 eFAw9vWiJNrIb4YEtNh0;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Uy1S1k1afp0()
		{
			string textParamValue = XActionHelper.GetTextParamValue(_operationTypeParam, exoS1G1vBRP, B6sS1siqYnc);
			switch (textParamValue)
			{
			case "GetDeviceById":
			{
				string textParamValue6 = XActionHelper.GetTextParamValue(TTWgpkxYewT, exoS1G1vBRP, B6sS1siqYnc);
				if (string.IsNullOrEmpty(textParamValue6))
				{
					return (isSuccess: false, message: "设备ID为空", failReason: ActionStopFlag.OperationFailed);
				}
				MMDevice deviceById = AudioHelper.GetDeviceById(textParamValue6);
				if (deviceById == null)
				{
					return (isSuccess: false, message: "未找到设备：" + textParamValue6, failReason: ActionStopFlag.OperationFailed);
				}
				iK3S11y6XA8.oJegphi46BD(deviceById, B6sS1siqYnc, exoS1G1vBRP, oCWS1HtqciZ);
				goto IL_056d;
			}
			case "SetDeviceMute":
			case "SetDeviceVolume":
			{
				string textParamValue4 = XActionHelper.GetTextParamValue(TTWgpkxYewT, exoS1G1vBRP, B6sS1siqYnc);
				MMDevice mMDevice = null;
				mMDevice = ((!string.IsNullOrWhiteSpace(textParamValue4)) ? AudioHelper.GetDeviceById(textParamValue4) : AudioHelper.GetDefaultDevice(DataFlow.Render, Role.Multimedia));
				if (mMDevice == null)
				{
					return (isSuccess: false, message: "未找到设备(" + textParamValue4 + ")。", failReason: ActionStopFlag.OperationFailed);
				}
				if (textParamValue == "SetDeviceMute")
				{
					string textParamValue5 = XActionHelper.GetTextParamValue(tpQgpsYuN3f, exoS1G1vBRP, B6sS1siqYnc);
					switch (textParamValue5.ToLower())
					{
					default:
						return (isSuccess: false, message: "静音参数值不正确:" + textParamValue5, failReason: ActionStopFlag.OperationFailed);
					case "toggle":
						mMDevice.AudioEndpointVolume.Mute = !mMDevice.AudioEndpointVolume.Mute;
						break;
					case "false":
						mMDevice.AudioEndpointVolume.Mute = false;
						break;
					case "true":
						mMDevice.AudioEndpointVolume.Mute = true;
						break;
					}
				}
				else if (textParamValue == "SetDeviceVolume")
				{
					double numberParamValue = XActionHelper.GetNumberParamValue(jh7gpHpmYO7, exoS1G1vBRP, B6sS1siqYnc);
					if (numberParamValue > 1.0 || !(numberParamValue >= 0.0))
					{
						return (isSuccess: false, message: "音量参数值不正确，应在0-1之间，当前值:" + numberParamValue, failReason: ActionStopFlag.OperationFailed);
					}
					mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar = (float)numberParamValue;
				}
				goto IL_056d;
			}
			case "GetInputDeviceList":
			{
				_003C_003Ec__DisplayClass60_2 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_2();
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(oYHgp1D8GHx, exoS1G1vBRP, B6sS1siqYnc);
				_003C_003Ec__DisplayClass60_.pp3S1mpSRd1 = AudioHelper.GetDeviceList(DataFlow.Capture, (!booleanParamValue) ? DeviceState.Active : DeviceState.All);
				XActionHelper.OutputResult(DeviceListOutputParam, exoS1G1vBRP, B6sS1siqYnc, _003C_003Ec__DisplayClass60_.pp3S1mpSRd1.deviceInfoList, oCWS1HtqciZ);
				XActionHelper.OutputResultIfNeeded(deviceListObjectOutputParam, _003C_003Ec__DisplayClass60_.kPlS1X6sQWY, exoS1G1vBRP, B6sS1siqYnc, oCWS1HtqciZ);
				goto IL_056d;
			}
			case "GetOutputDeviceList":
			{
				_003C_003Ec__DisplayClass60_1 _003C_003Ec__DisplayClass60_2 = new _003C_003Ec__DisplayClass60_1();
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(oYHgp1D8GHx, exoS1G1vBRP, B6sS1siqYnc);
				_003C_003Ec__DisplayClass60_2.UjwS165m9Bp = AudioHelper.GetDeviceList(DataFlow.Render, (!booleanParamValue2) ? DeviceState.Active : DeviceState.All);
				XActionHelper.OutputResult(DeviceListOutputParam, exoS1G1vBRP, B6sS1siqYnc, _003C_003Ec__DisplayClass60_2.UjwS165m9Bp.deviceInfoList, oCWS1HtqciZ);
				XActionHelper.OutputResultIfNeeded(deviceListObjectOutputParam, _003C_003Ec__DisplayClass60_2.B0eS1brHPRS, exoS1G1vBRP, B6sS1siqYnc, oCWS1HtqciZ);
				goto IL_056d;
			}
			case "SetDefaultDeviceById":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(TTWgpkxYewT, exoS1G1vBRP, B6sS1siqYnc);
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "设备ID为空", failReason: ActionStopFlag.OperationFailed);
				}
				if (!AudioHelper.SetDefaultDevice(textParamValue3))
				{
					return (isSuccess: false, message: "设置失败，可能未找到设备(" + textParamValue3 + ")或其它原因。", failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_056d;
			}
			case "GetInputDefaultDevice":
			{
				MMDevice defaultDevice2 = AudioHelper.GetDefaultDevice(DataFlow.Capture);
				if (defaultDevice2 == null)
				{
					return (isSuccess: false, message: "未找到默认的输入设备", failReason: ActionStopFlag.OperationFailed);
				}
				iK3S11y6XA8.oJegphi46BD(defaultDevice2, B6sS1siqYnc, exoS1G1vBRP, oCWS1HtqciZ);
				goto IL_056d;
			}
			case "GetOutputDefaultDevice":
			{
				MMDevice defaultDevice = AudioHelper.GetDefaultDevice(DataFlow.Render, Role.Multimedia);
				if (defaultDevice == null)
				{
					return (isSuccess: false, message: "未找到默认的输出设备", failReason: ActionStopFlag.OperationFailed);
				}
				iK3S11y6XA8.oJegphi46BD(defaultDevice, B6sS1siqYnc, exoS1G1vBRP, oCWS1HtqciZ);
				goto IL_056d;
			}
			case "ConnectBluetoothDevice":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(XNggpG9WeL4, exoS1G1vBRP, B6sS1siqYnc);
				if (textParamValue2.IsNullOrEmpty())
				{
					return (isSuccess: false, message: "未指定要连接的蓝牙设备名称", failReason: ActionStopFlag.OperationFailed);
				}
				string[] ilist_ = textParamValue2.SplitToList('|');
				try
				{
					if (!XZvMcsoT6pbwjnidHD4.QgfgpKDdaOO(ilist_, true))
					{
						return (isSuccess: false, message: "未能连接蓝牙设备", failReason: ActionStopFlag.OperationFailed);
					}
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: "未能连接蓝牙设备：" + textParamValue2 + "。" + ex.Message, failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_056d;
			}
			default:
				{
					return (isSuccess: false, message: "您可能未选择操作类型，或操作类型不被支持。" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_056d:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool k5Vhs5Wikdxga2rZRab8()
		{
			return eFAw9vWiJNrIb4YEtNh0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_1
	{
		public (IList<string> deviceInfoList, IList<MMDevice> deviceList) UjwS165m9Bp;

		internal static _003C_003Ec__DisplayClass60_1 EOIodSWirYedRrkKegE6;

		internal object B0eS1brHPRS()
		{
			return UjwS165m9Bp.deviceList;
		}

		internal static bool dpQoCrWiN8mF1wvAbtqK()
		{
			return EOIodSWirYedRrkKegE6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_2
	{
		public (IList<string> deviceInfoList, IList<MMDevice> deviceList) pp3S1mpSRd1;

		internal static _003C_003Ec__DisplayClass60_2 GAGkkiWiLJEAPYcBcrVH;

		internal object kPlS1X6sQWY()
		{
			return pp3S1mpSRd1.deviceList;
		}

		internal static bool ny3rJNWiuaO8c5KVdnbl()
		{
			return GAGkkiWiLJEAPYcBcrVH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass61_0
	{
		public MMDevice RoeS14lc3EQ;

		private static _003C_003Ec__DisplayClass61_0 VmyjHBWifSCxAh65fOWl;

		internal object siSS1Kb3QgM()
		{
			return RoeS14lc3EQ.ID;
		}

		internal object w8iS1xkEwu4()
		{
			return RoeS14lc3EQ.FriendlyName;
		}

		internal object fkyS1rnBjwd()
		{
			return RoeS14lc3EQ.State.ToString();
		}

		internal object XZJS1pElPNX()
		{
			return RoeS14lc3EQ.AudioEndpointVolume.Mute;
		}

		internal object NAjS1BZ4IAS()
		{
			return RoeS14lc3EQ.AudioEndpointVolume.MasterVolumeLevelScalar;
		}

		internal object NPOS1QgLB4B()
		{
			return RoeS14lc3EQ.AudioMeterInformation.MasterPeakValue;
		}

		internal object iSbS1jUIjPa()
		{
			return RoeS14lc3EQ;
		}

		internal object LhuS1ngs0bc()
		{
			return VyReQlomRUljBwAMQGR.YJZgHsLPig7(RoeS14lc3EQ);
		}

		internal static bool jPZdbBWibCsZNY7GDSKA()
		{
			return VmyjHBWifSCxAh65fOWl == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> D3fgpeCclEi = new string[4] { "声音", "音量", "audio", "shengyin" };

	[CompilerGenerated]
	private readonly string tIHgpYAewCL = $"fa:{EFontAwesomeIcon.Light_Volume}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Uj6gpIQ8Q8J;

	[CompilerGenerated]
	private readonly string KMjgpWDhKgE = "https://getquicker.net/KC/Help/Doc/audioControl";

	public static readonly StepInParamDef _operationTypeParam;

	private static readonly StepInParamDef TTWgpkxYewT;

	private static readonly StepInParamDef XNggpG9WeL4;

	private static readonly StepInParamDef tpQgpsYuN3f;

	private static readonly StepInParamDef jh7gpHpmYO7;

	private static readonly StepInParamDef oYHgp1D8GHx;

	private static readonly StepInParamDef MhVgpbW8kVX;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> gFigp6BYSZ9 = new List<StepInParamDef> { _operationTypeParam, TTWgpkxYewT, tpQgpsYuN3f, jh7gpHpmYO7, oYHgp1D8GHx, XNggpG9WeL4, MhVgpbW8kVX };

	private static readonly StepOutParamDef vyVgpXx0JoI;

	public static readonly StepOutParamDef DeviceListOutputParam;

	public static readonly StepOutParamDef deviceIdOutputParam;

	public static readonly StepOutParamDef deviceNameOutputParam;

	public static readonly StepOutParamDef deviceStateOutputParam;

	public static readonly StepOutParamDef deviceMuteOutputParam;

	public static readonly StepOutParamDef deviceIsPlayingOutputParam;

	public static readonly StepOutParamDef deviceVolumeOutputParam;

	public static readonly StepOutParamDef masterPeakValueOutputParam;

	public static readonly StepOutParamDef deviceObjectOutputParam;

	public static readonly StepOutParamDef deviceListObjectOutputParam;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> T9Dgpm4gOvD = new List<StepOutParamDef>
	{
		vyVgpXx0JoI, DeviceListOutputParam, deviceIdOutputParam, deviceNameOutputParam, deviceStateOutputParam, deviceMuteOutputParam, deviceIsPlayingOutputParam, deviceVolumeOutputParam, masterPeakValueOutputParam, deviceObjectOutputParam,
		deviceListObjectOutputParam
	};

	private static AudioControlStep H9qK2fQhqJCKKLrTJl5T;

	public string Key => "sys:audioControl";

	public string Name => "音频设备";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return D3fgpeCclEi;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return tIHgpYAewCL;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Uj6gpIQ8Q8J;
		}
	}

	public string Description => "获取音频设备信息，设置默认音频设备。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return KMjgpWDhKgE;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return gFigp6BYSZ9;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return T9Dgpm4gOvD;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
		_003C_003Ec__DisplayClass60_.exoS1G1vBRP = step;
		_003C_003Ec__DisplayClass60_.B6sS1siqYnc = context;
		_003C_003Ec__DisplayClass60_.oCWS1HtqciZ = action;
		_003C_003Ec__DisplayClass60_.iK3S11y6XA8 = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass60_.B6sS1siqYnc, _003C_003Ec__DisplayClass60_.exoS1G1vBRP, _003C_003Ec__DisplayClass60_.oCWS1HtqciZ, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass60_.Uy1S1k1afp0, (Action)null, (Action)null, MhVgpbW8kVX, vyVgpXx0JoI);
	}

	private void oJegphi46BD(MMDevice mmdevice_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		int num = 1;
		while (true)
		{
			_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
			int num2 = 0;
			if (!kAQvbFQhi1AoI5cG4KDl())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			_003C_003Ec__DisplayClass61_.RoeS14lc3EQ = mmdevice_0;
			XActionHelper.OutputResultIfNeeded(deviceIdOutputParam, _003C_003Ec__DisplayClass61_.siSS1Kb3QgM, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceNameOutputParam, _003C_003Ec__DisplayClass61_.w8iS1xkEwu4, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceStateOutputParam, _003C_003Ec__DisplayClass61_.fkyS1rnBjwd, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceMuteOutputParam, _003C_003Ec__DisplayClass61_.XZJS1pElPNX, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceVolumeOutputParam, _003C_003Ec__DisplayClass61_.NAjS1BZ4IAS, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(masterPeakValueOutputParam, _003C_003Ec__DisplayClass61_.NPOS1QgLB4B, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceObjectOutputParam, _003C_003Ec__DisplayClass61_.iSbS1jUIjPa, actionStep_0, actionExecuteContext_0, xaction_0);
			XActionHelper.OutputResultIfNeeded(deviceIsPlayingOutputParam, _003C_003Ec__DisplayClass61_.LhuS1ngs0bc, actionStep_0, actionExecuteContext_0, xaction_0);
			return;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(_operationTypeParam, step) + " " + XActionHelper.GetParamDisplayString(TTWgpkxYewT, step);
	}

	static AudioControlStep()
	{
		_operationTypeParam = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("GetOutputDeviceList", "获取输出设备列表"),
				new SelectionItem("GetOutputDefaultDevice", "获取默认输出设备信息"),
				new SelectionItem("GetInputDeviceList", "获取输入设备列表"),
				new SelectionItem("GetInputDefaultDevice", "获取默认输入设备信息"),
				new SelectionItem("GetDeviceById", "获取指定设备的信息"),
				new SelectionItem("SetDefaultDeviceById", "设置默认设备"),
				new SelectionItem("SetDeviceMute", "设置静音"),
				new SelectionItem("SetDeviceVolume", "设置音量")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true,
			DefaultValue = "GetOutputDeviceList"
		};
		TTWgpkxYewT = new StepInParamDef
		{
			Key = "id",
			Name = "设备ID",
			DefaultValue = "",
			Description = "要获取或更新信息的设备ID。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "GetDeviceById", "SetDefaultDeviceById", "SetDeviceMute", "SetDeviceVolume" }
		};
		XNggpG9WeL4 = new StepInParamDef
		{
			Key = "deviceName",
			Name = "蓝牙设备名称",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "ConnectBluetoothDevice" },
			TextTools = new TextToolType[1] { TextToolType.SelectBluetoothDevice }
		};
		tpQgpsYuN3f = new StepInParamDef
		{
			Key = "mute",
			Name = "静音状态",
			DefaultValue = "true",
			Description = "可选值 true/false/toggle 静音、取消静音或切换状态。",
			Type = VarType.Text,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("true", "静音"),
				new SelectionItem("false", "取消静音"),
				new SelectionItem("toggle", "切换静音状态")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "SetDeviceMute" }
		};
		jh7gpHpmYO7 = new StepInParamDef
		{
			Key = "volume",
			Name = "音量",
			DefaultValue = 0.1,
			Description = "0-1.0之间的小数数字。",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "SetDeviceVolume" }
		};
		oYHgp1D8GHx = new StepInParamDef
		{
			Key = "returnAll",
			Name = "返回所有状态的设备",
			Description = "否则只返回就绪状态 (Active) 的设备",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "GetOutputDeviceList", "GetInputDeviceList" }
		};
		MhVgpbW8kVX = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止动作",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		vyVgpXx0JoI = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		DeviceListOutputParam = new StepOutParamDef
		{
			Key = "deviceList",
			Name = "设备信息列表",
			Description = "每项的格式为:[图标]名称(注释)|设备ID",
			Type = VarType.List,
			ValidForList = new List<string> { "GetOutputDeviceList", "GetInputDeviceList" }
		};
		deviceIdOutputParam = new StepOutParamDef
		{
			Key = "deviceId",
			Name = "设备ID",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice" }
		};
		deviceNameOutputParam = new StepOutParamDef
		{
			Key = "deviceName",
			Name = "设备名称",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		deviceStateOutputParam = new StepOutParamDef
		{
			Key = "deviceState",
			Name = "设备状态",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		deviceMuteOutputParam = new StepOutParamDef
		{
			Key = "mute",
			Name = "是否静音",
			Description = "",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		deviceIsPlayingOutputParam = new StepOutParamDef
		{
			Key = "isPlaying",
			Name = "是否正在播放",
			Description = "",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		deviceVolumeOutputParam = new StepOutParamDef
		{
			Key = "volume",
			Name = "设置音量",
			Description = "",
			Type = VarType.Number,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		masterPeakValueOutputParam = new StepOutParamDef
		{
			Key = "masterPeakValue",
			Name = "实时音量",
			Description = "",
			Type = VarType.Number,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" }
		};
		deviceObjectOutputParam = new StepOutParamDef
		{
			Key = "deviceObject",
			Name = "原始对象",
			Description = "原始MMDevice对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetOutputDefaultDevice", "GetInputDefaultDevice", "GetDeviceById" },
			IsAdvanced = true
		};
		deviceListObjectOutputParam = new StepOutParamDef
		{
			Key = "deviceObjectList",
			Name = "原始对象列表",
			Description = "原始MMDevice对象的列表(IList<MMDevice>)",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetOutputDeviceList", "GetInputDeviceList" },
			IsAdvanced = true
		};
	}

	internal static bool kAQvbFQhi1AoI5cG4KDl()
	{
		return H9qK2fQhqJCKKLrTJl5T == null;
	}
}
