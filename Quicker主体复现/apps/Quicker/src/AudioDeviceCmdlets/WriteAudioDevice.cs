using System;
using NAudio.CoreAudioApi;

namespace AudioDeviceCmdlets;

public class WriteAudioDevice
{
	internal static WriteAudioDevice X7VofnOP6ra3lCTRSfl;

	public static int GetPlaybackProgress()
	{
		return Convert.ToInt32(new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioMeterInformation.MasterPeakValue * 100f);
	}

	public static int GetStreamProgress()
	{
		return Convert.ToInt32(new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioMeterInformation.MasterPeakValue * 100f);
	}

	public static int GetRecordingMeter()
	{
		return Convert.ToInt32(new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioMeterInformation.MasterPeakValue * 100f);
	}

	public static int GetRecordingStream()
	{
		return Convert.ToInt32(new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioMeterInformation.MasterPeakValue * 100f);
	}

	internal static bool pUgBYxOMva6BnqtELA1()
	{
		return X7VofnOP6ra3lCTRSfl == null;
	}
}
