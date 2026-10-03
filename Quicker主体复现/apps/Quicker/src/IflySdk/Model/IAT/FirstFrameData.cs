using System.Runtime.CompilerServices;
using IflySdk.Enum;

namespace IflySdk.Model.IAT;

public class FirstFrameData
{
	[CompilerGenerated]
	private DataParams dJphvuqGFN;

	[CompilerGenerated]
	private BusinessParams eGfhSS6bpG;

	[CompilerGenerated]
	private CommonParams WO0h2BLVxt;

	internal static FirstFrameData COyW1WNrwAIHQOT3sCl;

	public DataParams data
	{
		[CompilerGenerated]
		get
		{
			return dJphvuqGFN;
		}
		[CompilerGenerated]
		set
		{
			dJphvuqGFN = value;
		}
	}

	public BusinessParams business
	{
		[CompilerGenerated]
		get
		{
			return eGfhSS6bpG;
		}
		[CompilerGenerated]
		set
		{
			eGfhSS6bpG = value;
		}
	}

	public CommonParams common
	{
		[CompilerGenerated]
		get
		{
			return WO0h2BLVxt;
		}
		[CompilerGenerated]
		set
		{
			WO0h2BLVxt = value;
		}
	}

	public FirstFrameData()
	{
		data = new DataParams();
		business = new BusinessParams();
		common = new CommonParams();
		data.status = FrameState.First;
	}

	internal static bool NtkYD8NNJWQ5eEDyAXq()
	{
		return COyW1WNrwAIHQOT3sCl == null;
	}
}
