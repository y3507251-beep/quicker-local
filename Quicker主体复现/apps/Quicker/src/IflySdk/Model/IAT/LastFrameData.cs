using System.Runtime.CompilerServices;
using IflySdk.Enum;

namespace IflySdk.Model.IAT;

public class LastFrameData
{
	[CompilerGenerated]
	private DataParams XoPhu3V4ka;

	internal static LastFrameData hI0GvMNL1BBcIIXec4q;

	public DataParams data
	{
		[CompilerGenerated]
		get
		{
			return XoPhu3V4ka;
		}
		[CompilerGenerated]
		set
		{
			XoPhu3V4ka = value;
		}
	}

	public LastFrameData()
	{
		data = new DataParams();
		data.status = FrameState.Last;
	}

	internal static bool VFJOR7NuQ6dbKJOTfCf()
	{
		return hI0GvMNL1BBcIIXec4q == null;
	}
}
