using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Recv;

public class PhotoMessage : MessageBase
{
	public const int MSG_TYPE = 105;

	[CompilerGenerated]
	private string pWstcIYG831;

	[CompilerGenerated]
	private string dX7tcWLyCgc;

	private static PhotoMessage NQvAw7Q09Yw1wkF7VKHn;

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return pWstcIYG831;
		}
		[CompilerGenerated]
		set
		{
			pWstcIYG831 = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return dX7tcWLyCgc;
		}
		[CompilerGenerated]
		set
		{
			dX7tcWLyCgc = value;
		}
	}

	public override int MessageType => 105;

	internal static bool vOACNJQ0LGyEWHJHmnDF()
	{
		return NQvAw7Q09Yw1wkF7VKHn == null;
	}

	internal static void iuYaqtQ0o856bEDSEGh4()
	{
	}
}
