using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace GImOAQweqmEnB5RDWmL;

internal class vRibjhwb53dP6TpCN6i : kWjRPcwItwkeAamARyg, IMMNotificationClient
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public string Sw9vI86oBpt;

		public Func<CommonTriggerTask, bool> GQVvIaRVreV;

		internal static _003C_003Ec__DisplayClass15_0 Nhgbg7cl6K6JEJY0WXhy;

		internal bool HA2vIyFxVgY(CommonTriggerTask x)
		{
			return x.EventType == Sw9vI86oBpt;
		}

		internal static bool k6CqCuclt5uKES50bNeD()
		{
			return Nhgbg7cl6K6JEJY0WXhy == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> HQitwtS4g6P = new Dictionary<string, string>
	{
		{ "AudioDeviceActive", "音频设备激活(插入)" },
		{ "AudioDeviceUnplugged", "音频设备断开(拔出)" }
	};

	private FormField eRgtwgT7mYe = new FormField
	{
		FieldKey = "DeviceName",
		Label = "设备",
		DictVarType = VarType.Text,
		HelpText = "可选。可填写设备名/ID/友好名称。多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。\r\n不填写时对所有设备均触发。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox
	};

	private MMDeviceEnumerator xGqtwLf2Ua3;

	internal static vRibjhwb53dP6TpCN6i YprCmHQFbT5VlSjUAtc6;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return HQitwtS4g6P;
	}

	public vRibjhwb53dP6TpCN6i()
		: base(new string[2] { "AudioDeviceActive", "AudioDeviceUnplugged" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { eRgtwgT7mYe };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "DeviceName",
				Desc = "设备名称",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "DeviceId",
				Desc = "设备Id",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "State",
				Desc = "新的状态",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "IconPath",
				Desc = "设备图标路径",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "DataFlow",
				Desc = "数据流类型。Render表示播放输出、Capture表示捕获输入，All表示同时",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "FriendlyName",
				Desc = "友好名称",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "VolumeLevel",
				Desc = "音量级别",
				Type = VarType.Number
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		qW5tww9UPBK();
		xGqtwLf2Ua3 = new MMDeviceEnumerator();
		xGqtwLf2Ua3.RegisterEndpointNotificationCallback(this);
	}

	protected override void C5rM2eDjuIN()
	{
		qW5tww9UPBK();
	}

	private void qW5tww9UPBK()
	{
		if (xGqtwLf2Ua3 != null)
		{
			xGqtwLf2Ua3.UnregisterEndpointNotificationCallback(this);
			xGqtwLf2Ua3.Dispose();
			xGqtwLf2Ua3 = null;
		}
	}

	void IMMNotificationClient.OnDeviceStateChanged(string string_1, DeviceState deviceState_0)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.Sw9vI86oBpt = "";
		switch (deviceState_0)
		{
		default:
			return;
		case DeviceState.Unplugged:
			_003C_003Ec__DisplayClass15_.Sw9vI86oBpt = "AudioDeviceUnplugged";
			break;
		case DeviceState.Active:
			_003C_003Ec__DisplayClass15_.Sw9vI86oBpt = "AudioDeviceActive";
			break;
		}
		string value = deviceState_0.ToString();
		MMDevice device = xGqtwLf2Ua3.GetDevice(string_1);
		Dictionary<string, object> idictionary_ = new Dictionary<string, object>
		{
			{ "DeviceName", device.DeviceFriendlyName },
			{ "DeviceId", device.ID },
			{ "State", value },
			{ "IconPath", device.IconPath },
			{ "DataFlow", device.DataFlow },
			{ "FriendlyName", device.FriendlyName },
			{
				"VolumeLevel",
				device.AudioEndpointVolume.MasterVolumeLevelScalar
			}
		};
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec__DisplayClass15_.GQVvIaRVreV ?? (_003C_003Ec__DisplayClass15_.GQVvIaRVreV = _003C_003Ec__DisplayClass15_.HA2vIyFxVgY)))
		{
			if (YprCmHQFbT5VlSjUAtc6 != null)
			{
				switch (0)
				{
				}
			}
			string text = item.TryGetParamValue("DeviceName", "");
			if ((string.IsNullOrEmpty(text) || GFGFgbwXKocENyrCUx4.ibMflIV9C4(text, device.ID) || GFGFgbwXKocENyrCUx4.ibMflIV9C4(text, device.DeviceFriendlyName) || GFGFgbwXKocENyrCUx4.ibMflIV9C4(text, device.FriendlyName)) && iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	void IMMNotificationClient.OnDeviceAdded(string string_1)
	{
	}

	void IMMNotificationClient.OnDeviceRemoved(string string_1)
	{
	}

	void IMMNotificationClient.OnDefaultDeviceChanged(DataFlow dataFlow_0, Role role_0, string string_1)
	{
	}

	void IMMNotificationClient.OnPropertyValueChanged(string string_1, PropertyKey propertyKey_0)
	{
	}

	internal static void CYVhwpQFlJ7PY4DRbE1Q()
	{
	}

	internal static bool Yl70hKQFqW52Pn8Nx7tp()
	{
		return YprCmHQFbT5VlSjUAtc6 == null;
	}
}
