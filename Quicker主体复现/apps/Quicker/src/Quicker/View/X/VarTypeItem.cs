using System.Runtime.CompilerServices;
using System.Windows.Media;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.View.X;

public class VarTypeItem
{
	[CompilerGenerated]
	private VarType GBQLsV2dCfi;

	[CompilerGenerated]
	private string DG1LsZS8eL7;

	[CompilerGenerated]
	private string g3ELs9u2wG9;

	private static VarTypeItem iXaRUAFa15BjTZfZ46Qf;

	public ImageSource Icon => AppHelper.GetVarTypeIcon(VarType);

	public VarType VarType
	{
		[CompilerGenerated]
		get
		{
			return GBQLsV2dCfi;
		}
		[CompilerGenerated]
		set
		{
			GBQLsV2dCfi = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return DG1LsZS8eL7;
		}
		[CompilerGenerated]
		set
		{
			DG1LsZS8eL7 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return g3ELs9u2wG9;
		}
		[CompilerGenerated]
		set
		{
			g3ELs9u2wG9 = value;
		}
	}

	internal static bool HVEo8bFaKFW7f0iyBcmt()
	{
		return iXaRUAFa15BjTZfZ46Qf == null;
	}
}
