using System.Runtime.CompilerServices;
using Quicker.Common;

namespace Quicker.View.Controls;

public class ProfileConfigItem
{
	[CompilerGenerated]
	private string tTXLn3H3cc3;

	[CompilerGenerated]
	private string gM6Lnfh8T5w;

	[CompilerGenerated]
	private string Lg3Lnz79ClH;

	[CompilerGenerated]
	private string V3hL4wu5px0;

	[CompilerGenerated]
	private string t4tL4topGHH;

	[CompilerGenerated]
	private string zeyL4gFIpQ5;

	[CompilerGenerated]
	private string tmqL4Lkgrry;

	[CompilerGenerated]
	private int esIL4vpXv1N;

	[CompilerGenerated]
	private string Eq8L4SnTyps;

	private static ProfileConfigItem x6iVdFFioi49iyGpX6JQ;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return tTXLn3H3cc3;
		}
		[CompilerGenerated]
		set
		{
			tTXLn3H3cc3 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return gM6Lnfh8T5w;
		}
		[CompilerGenerated]
		set
		{
			gM6Lnfh8T5w = value;
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return Lg3Lnz79ClH;
		}
		[CompilerGenerated]
		set
		{
			Lg3Lnz79ClH = value;
		}
	}

	public string AliasOfProfile
	{
		[CompilerGenerated]
		get
		{
			return V3hL4wu5px0;
		}
		[CompilerGenerated]
		set
		{
			V3hL4wu5px0 = value;
		}
	}

	public string ExeFile
	{
		[CompilerGenerated]
		get
		{
			return t4tL4topGHH;
		}
		[CompilerGenerated]
		set
		{
			t4tL4topGHH = value;
		}
	}

	public string ExeFullpath
	{
		[CompilerGenerated]
		get
		{
			return zeyL4gFIpQ5;
		}
		[CompilerGenerated]
		set
		{
			zeyL4gFIpQ5 = value;
		}
	}

	public string ExeDisplayName
	{
		[CompilerGenerated]
		get
		{
			return tmqL4Lkgrry;
		}
		[CompilerGenerated]
		set
		{
			tmqL4Lkgrry = value;
		}
	}

	public int ListOrder
	{
		[CompilerGenerated]
		get
		{
			return esIL4vpXv1N;
		}
		[CompilerGenerated]
		set
		{
			esIL4vpXv1N = value;
		}
	}

	public string ValidForMachines
	{
		[CompilerGenerated]
		get
		{
			return Eq8L4SnTyps;
		}
		[CompilerGenerated]
		set
		{
			Eq8L4SnTyps = value;
		}
	}

	public ProfileConfigItem()
	{
	}

	public ProfileConfigItem(ActionProfile profile)
	{
		Id = profile.Id;
		Name = profile.Name;
		DisplayName = profile.DisplayName;
		AliasOfProfile = profile.AliasOfProfile;
		ExeFile = profile.ExeFile;
		ExeDisplayName = profile.ExeDisplayName;
		ListOrder = profile.ListOrder;
		ValidForMachines = profile.ValidForMachines;
		ExeFullpath = profile.ExeFullpath;
	}

	internal static bool n8I1LTFife9jAwsR9cI9()
	{
		return x6iVdFFioi49iyGpX6JQ == null;
	}
}
