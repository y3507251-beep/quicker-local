using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Qiniu.Storage;

public class PutExtra
{
	[CompilerGenerated]
	private string RNHYcvoULv;

	public Dictionary<string, string> Params;

	[CompilerGenerated]
	private string gtoYVobSyw;

	[CompilerGenerated]
	private UploadProgressHandler h7VYZ5SOwy;

	[CompilerGenerated]
	private UploadController EHNY9Z7Vxh;

	[CompilerGenerated]
	private int eNuYhLS9NM;

	[CompilerGenerated]
	private int KmwYesWolg;

	public string Version = "v1";

	public int PartSize = 4194304;

	internal static PutExtra HWvIPCofXfZkUQ5GlMT;

	public string ResumeRecordFile
	{
		[CompilerGenerated]
		get
		{
			return RNHYcvoULv;
		}
		[CompilerGenerated]
		set
		{
			RNHYcvoULv = value;
		}
	}

	public string MimeType
	{
		[CompilerGenerated]
		get
		{
			return gtoYVobSyw;
		}
		[CompilerGenerated]
		set
		{
			gtoYVobSyw = value;
		}
	}

	public UploadProgressHandler ProgressHandler
	{
		[CompilerGenerated]
		get
		{
			return h7VYZ5SOwy;
		}
		[CompilerGenerated]
		set
		{
			h7VYZ5SOwy = value;
		}
	}

	public UploadController UploadController
	{
		[CompilerGenerated]
		get
		{
			return EHNY9Z7Vxh;
		}
		[CompilerGenerated]
		set
		{
			EHNY9Z7Vxh = value;
		}
	}

	public int MaxRetryTimes
	{
		[CompilerGenerated]
		get
		{
			return eNuYhLS9NM;
		}
		[CompilerGenerated]
		set
		{
			eNuYhLS9NM = value;
		}
	}

	public int BlockUploadThreads
	{
		[CompilerGenerated]
		get
		{
			return KmwYesWolg;
		}
		[CompilerGenerated]
		set
		{
			KmwYesWolg = value;
		}
	}

	internal static bool MYxpLwob9rZlSPZWURc()
	{
		return HWvIPCofXfZkUQ5GlMT == null;
	}
}
