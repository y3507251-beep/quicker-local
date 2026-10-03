using NAudio.CoreAudioApi;

namespace AudioDeviceCmdlets;

public class AudioDevice
{
	public int Index;

	public bool Default;

	public string Type;

	public string Name;

	public string ID;

	public MMDevice Device;

	internal static AudioDevice COkfynONMwhdAD9MGL0;

	public AudioDevice(int Index, MMDevice BaseDevice, bool Default = false)
	{
		this.Index = Index;
		this.Default = Default;
		if (BaseDevice.DataFlow == DataFlow.Render)
		{
			Type = "Playback";
		}
		else if (BaseDevice.DataFlow == DataFlow.Capture)
		{
			Type = "Recording";
		}
		Name = BaseDevice.FriendlyName;
		Device = BaseDevice;
		ID = BaseDevice.ID;
	}

	internal static bool adtAh3O9Q2s0asE5nM4()
	{
		return COkfynONMwhdAD9MGL0 == null;
	}
}
