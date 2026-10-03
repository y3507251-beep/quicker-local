using System;
using CoreAudioApi;
using NAudio.CoreAudioApi;

namespace AudioDeviceCmdlets;

public class SetAudioDevice
{
	internal static SetAudioDevice ucakZPOZ4cslVSvCqq6;

	public static AudioDevice SetByInputObject(AudioDevice inputObject)
	{
		if (inputObject == null)
		{
			throw new ArgumentNullException("inputObject");
		}
		MMDeviceCollection item = GetAudioDevice.GetDeviceCollection().DeviceCollection;
		int num = 0;
		while (true)
		{
			if (num < item.Count)
			{
				MMDevice mMDevice = item[num];
				if (item[num].ID == inputObject.ID)
				{
					break;
				}
				num++;
				continue;
			}
			throw new ArgumentException("No such enabled AudioDevice found");
		}
		int num2 = 0;
		if (ucakZPOZ4cslVSvCqq6 != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			PolicyConfigClient policyConfigClient = new PolicyConfigClient();
			policyConfigClient.SetDefaultEndpoint(item[num].ID, Role.Communications);
			policyConfigClient.SetDefaultEndpoint(item[num].ID, Role.Multimedia);
			return new AudioDevice(num + 1, item[num], true);
		}
		}
	}

	public static AudioDevice SetById(string id)
	{
		MMDeviceCollection item = GetAudioDevice.GetDeviceCollection().DeviceCollection;
		int num = 0;
		while (true)
		{
			if (num < item.Count)
			{
				if (string.Compare(item[num].ID, id, StringComparison.CurrentCultureIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			throw new ArgumentException("No enabled AudioDevice found with that ID");
		}
		PolicyConfigClient policyConfigClient = new PolicyConfigClient();
		policyConfigClient.SetDefaultEndpoint(item[num].ID, Role.Communications);
		policyConfigClient.SetDefaultEndpoint(item[num].ID, Role.Multimedia);
		return new AudioDevice(num + 1, item[num], true);
	}

	public static AudioDevice SetByIndex(int index)
	{
		MMDeviceCollection item = GetAudioDevice.GetDeviceCollection().DeviceCollection;
		if (index < 1 || index > item.Count)
		{
			throw new ArgumentException("No enabled AudioDevice found with that Index");
		}
		PolicyConfigClient policyConfigClient = new PolicyConfigClient();
		policyConfigClient.SetDefaultEndpoint(item[index - 1].ID, Role.Communications);
		policyConfigClient.SetDefaultEndpoint(item[index - 1].ID, Role.Multimedia);
		return new AudioDevice(index, item[index - 1], true);
	}

	public static void SetPlaybackMute(bool muteState)
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.Mute = muteState;
	}

	public static void PlaybackMuteToggle()
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.Mute = !item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.Mute;
	}

	public static void SetPlaybackVolume(float volumeAsPercentage)
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.MasterVolumeLevelScalar = volumeAsPercentage / 100f;
	}

	public static void SetRecordingMute(bool muteState)
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.Mute = muteState;
	}

	public static void RecordingMuteToggle()
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.Mute = !item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.Mute;
	}

	public static void SetRecordingVolume(int volumeAsPercentage)
	{
		MMDeviceEnumerator item = GetAudioDevice.GetDeviceCollection().DevEnum;
		item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.MasterVolumeLevelScalar = (float)volumeAsPercentage / 100f;
	}

	internal static bool BH3apKO5KAukV6pGl49()
	{
		return ucakZPOZ4cslVSvCqq6 == null;
	}
}
