using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using WindowsInput.Native;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class KeyInputStepData
{
	[CompilerGenerated]
	private IList<VirtualKeyCode> pt2tfcHD5HO = new List<VirtualKeyCode>();

	[CompilerGenerated]
	private IList<VirtualKeyCode> B64tfV10WyO = new List<VirtualKeyCode>();

	internal static KeyInputStepData zfF7j1QYr8SFD9NXNpEW;

	public IList<VirtualKeyCode> CtrlKeys
	{
		[CompilerGenerated]
		get
		{
			return pt2tfcHD5HO;
		}
		[CompilerGenerated]
		set
		{
			pt2tfcHD5HO = value;
		}
	}

	public IList<VirtualKeyCode> Keys
	{
		[CompilerGenerated]
		get
		{
			return B64tfV10WyO;
		}
		[CompilerGenerated]
		set
		{
			B64tfV10WyO = value;
		}
	}

	public string Serialize()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static KeyInputStepData Deserialize(string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return new KeyInputStepData();
		}
		return JsonConvert.DeserializeObject<KeyInputStepData>(data);
	}

	internal static bool nFJtQPQYNFBfGXZBWh1t()
	{
		return zfF7j1QYr8SFD9NXNpEW == null;
	}
}
