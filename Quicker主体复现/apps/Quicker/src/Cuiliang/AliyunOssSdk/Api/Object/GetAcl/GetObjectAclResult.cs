using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Cuiliang.AliyunOssSdk.Api.Common;

namespace Cuiliang.AliyunOssSdk.Api.Object.GetAcl;

[XmlRoot("AccessControlPolicy")]
public class GetObjectAclResult
{
	[CompilerGenerated]
	private Owner w9quohAG5h;

	[CompilerGenerated]
	private List<string> v3YuTBpmWg;

	private static GetObjectAclResult RhTY3pj6hZTWgSyKeNe;

	[XmlElement("Owner")]
	public Owner Owner
	{
		[CompilerGenerated]
		get
		{
			return w9quohAG5h;
		}
		[CompilerGenerated]
		set
		{
			w9quohAG5h = value;
		}
	}

	[XmlArrayItem("Grant")]
	[XmlArray("AccessControlList")]
	public List<string> Grants
	{
		[CompilerGenerated]
		get
		{
			return v3YuTBpmWg;
		}
		[CompilerGenerated]
		set
		{
			v3YuTBpmWg = value;
		}
	}

	internal static bool C5s5fbjtPkNC181HG0l()
	{
		return RhTY3pj6hZTWgSyKeNe == null;
	}
}
