using System;
using System.Collections.Generic;
using System.IO;
using CoreAudioApi;
using NAudio.CoreAudioApi;

namespace Quicker.Open.Windows.Audio;

public static class AudioHelper
{
	internal static object Ct16pxxosWTw2xmNtek;

	public static (IList<string> deviceInfoList, IList<MMDevice> deviceList) GetDeviceList(DataFlow dataFlow = DataFlow.Render, DeviceState state = DeviceState.Active)
	{
		using MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		MMDeviceCollection mMDeviceCollection = mMDeviceEnumerator.EnumerateAudioEndPoints(dataFlow, state);
		List<string> list = new List<string>();
		List<MMDevice> list2 = new List<MMDevice>();
		foreach (MMDevice item2 in mMDeviceCollection)
		{
			try
			{
				string item = A54XZHlEUv(item2);
				list.Add(item);
				list2.Add(item2);
			}
			catch (Exception)
			{
			}
		}
		return (deviceInfoList: list, deviceList: list2);
	}

	public static MMDevice GetDefaultDevice(DataFlow flow = DataFlow.Render, Role role = Role.Multimedia)
	{
		using MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		return mMDeviceEnumerator.GetDefaultAudioEndpoint(flow, role);
	}

	public static MMDevice GetDeviceById(string id)
	{
		using MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		foreach (MMDevice item in mMDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.All))
		{
			if (string.Equals(item.ID, id, StringComparison.OrdinalIgnoreCase))
			{
				return item;
			}
		}
		return null;
	}

	public static bool SetDefaultDevice(string id)
	{
		using MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		foreach (MMDevice item in mMDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active))
		{
			if (string.Equals(item.ID, id, StringComparison.OrdinalIgnoreCase))
			{
				PolicyConfigClient policyConfigClient = new PolicyConfigClient();
				policyConfigClient.SetDefaultEndpoint(item.ID, Role.Communications);
				policyConfigClient.SetDefaultEndpoint(item.ID, Role.Multimedia);
				policyConfigClient.SetDefaultEndpoint(item.ID, Role.Console);
				return true;
			}
		}
		return false;
	}

	private static string A54XZHlEUv(MMDevice mmdevice_0)
	{
		if (mmdevice_0 == null)
		{
			return "";
		}
		return $"[icon:{mmdevice_0.IconPath}]{mmdevice_0.FriendlyName}(状态: {mmdevice_0.State}, ID: {mmdevice_0.ID})|{mmdevice_0.ID}";
	}

	public static (bool isMuted, double volume) GetDeviceVolume(string deviceId)
	{
		using MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		MMDevice mMDevice = null;
		mMDevice = ((!string.IsNullOrEmpty(deviceId)) ? mMDeviceEnumerator.GetDevice(deviceId) : mMDeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia));
		if (mMDevice == null)
		{
			throw new InvalidDataException("未找到设备：" + deviceId);
		}
		return (isMuted: mMDevice.AudioEndpointVolume.Mute, volume: mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar);
	}

	public static void SetMute(string deviceId, bool? mute)
	{
		MMDevice deviceById = GetDeviceById(deviceId);
		if (deviceById != null)
		{
			deviceById.AudioEndpointVolume.Mute = (mute.HasValue ? mute.Value : (!deviceById.AudioEndpointVolume.Mute));
		}
	}

	public static void SetVolume(string deviceId, float value)
	{
		MMDevice deviceById = GetDeviceById(deviceId);
		if (deviceById != null)
		{
			deviceById.AudioEndpointVolume.MasterVolumeLevelScalar = value;
		}
	}

	public static void VolumeStep(string deviceId, bool up)
	{
		MMDevice deviceById = GetDeviceById(deviceId);
		if (deviceById != null)
		{
			if (up)
			{
				deviceById.AudioEndpointVolume.VolumeStepUp();
			}
			else
			{
				deviceById.AudioEndpointVolume.VolumeStepDown();
			}
		}
	}

	internal static bool CWKIDJxfK6ZAJyI4oYN()
	{
		return Ct16pxxosWTw2xmNtek == null;
	}
}
