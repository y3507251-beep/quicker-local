using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Cuiliang.AliyunOssSdk.Api.Common;

[XmlRoot("Owner")]
public class Owner
{
	[CompilerGenerated]
	private string UswNEs4Nkn;

	[CompilerGenerated]
	private string fbsNyEnqYA;

	private static Owner BjxgNYDrPQdYZvfMQF1;

	[XmlElement("ID")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return UswNEs4Nkn;
		}
		[CompilerGenerated]
		set
		{
			UswNEs4Nkn = value;
		}
	}

	[XmlElement("DisplayName")]
	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return fbsNyEnqYA;
		}
		[CompilerGenerated]
		set
		{
			fbsNyEnqYA = value;
		}
	}

	internal Owner()
	{
	}

	internal Owner(string id, string displayName)
	{
		Id = id;
		DisplayName = displayName;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "[Owner Id={0}, DisplayName={1}]", Id ?? string.Empty, DisplayName ?? string.Empty);
	}

	public object Clone()
	{
		return new Owner(Id, DisplayName);
	}

	internal static bool WvHAaHDNbOriHE6PWwn()
	{
		return BjxgNYDrPQdYZvfMQF1 == null;
	}
}
