using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Network.Messages.Send;

public class UpdateButtonsMessage : MessageBase
{
	public const int MSG_TYPE = 1;

	[CompilerGenerated]
	private string VeRtcum29Vy;

	[CompilerGenerated]
	private IList<ButtonItem> TFDtcNpOgVW;

	[CompilerGenerated]
	private int d63tcJuBprh;

	[CompilerGenerated]
	private int zS5tc09eHrF;

	[CompilerGenerated]
	private int EfvtcCYd36M;

	[CompilerGenerated]
	private int kYitcPeHrpV;

	[CompilerGenerated]
	private bool Au9tcERI4TB;

	internal static UpdateButtonsMessage rdfBqHQ0nP3sVqk5pARK;

	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return VeRtcum29Vy;
		}
		[CompilerGenerated]
		set
		{
			VeRtcum29Vy = value;
		}
	}

	public IList<ButtonItem> Buttons
	{
		[CompilerGenerated]
		get
		{
			return TFDtcNpOgVW;
		}
		[CompilerGenerated]
		set
		{
			TFDtcNpOgVW = value;
		}
	}

	public int GlobalPageCount
	{
		[CompilerGenerated]
		get
		{
			return d63tcJuBprh;
		}
		[CompilerGenerated]
		set
		{
			d63tcJuBprh = value;
		}
	}

	public int GlobalPageIndex
	{
		[CompilerGenerated]
		get
		{
			return zS5tc09eHrF;
		}
		[CompilerGenerated]
		set
		{
			zS5tc09eHrF = value;
		}
	}

	public int ContextPageCount
	{
		[CompilerGenerated]
		get
		{
			return EfvtcCYd36M;
		}
		[CompilerGenerated]
		set
		{
			EfvtcCYd36M = value;
		}
	}

	public int ContextPageIndex
	{
		[CompilerGenerated]
		get
		{
			return kYitcPeHrpV;
		}
		[CompilerGenerated]
		set
		{
			kYitcPeHrpV = value;
		}
	}

	public bool IsContextPanelLocked
	{
		[CompilerGenerated]
		get
		{
			return Au9tcERI4TB;
		}
		[CompilerGenerated]
		set
		{
			Au9tcERI4TB = value;
		}
	}

	public override int MessageType => 1;

	internal static bool mbMjNAQ0ed47mg9Wpngo()
	{
		return rdfBqHQ0nP3sVqk5pARK == null;
	}
}
