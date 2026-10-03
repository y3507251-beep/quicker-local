using System.Runtime.CompilerServices;

namespace Quicker.Recorder.Entities;

public class RecordItemBase
{
	[CompilerGenerated]
	private int fk66sv8C0y;

	[CompilerGenerated]
	private int cB36Hpyqr3;

	[CompilerGenerated]
	private RecordEventType zmS61sccmy;

	[CompilerGenerated]
	private string bOs6bYMXL5;

	internal static RecordItemBase lUrYgagKWgBCV9Kq8Mb;

	public int Seq
	{
		[CompilerGenerated]
		get
		{
			return fk66sv8C0y;
		}
		[CompilerGenerated]
		set
		{
			fk66sv8C0y = value;
		}
	}

	public int DelayMs
	{
		[CompilerGenerated]
		get
		{
			return cB36Hpyqr3;
		}
		[CompilerGenerated]
		set
		{
			cB36Hpyqr3 = value;
		}
	}

	public RecordEventType EventType
	{
		[CompilerGenerated]
		get
		{
			return zmS61sccmy;
		}
		[CompilerGenerated]
		set
		{
			zmS61sccmy = value;
		}
	}

	public string Note
	{
		[CompilerGenerated]
		get
		{
			return bOs6bYMXL5;
		}
		[CompilerGenerated]
		set
		{
			bOs6bYMXL5 = value;
		}
	}

	public string Serialize()
	{
		return $"{DelayMs};\t{EventType.ToEventTypeKey()};\t{SerializeLocalData()};";
	}

	protected virtual string SerializeLocalData()
	{
		return "";
	}

	public virtual bool ParseData(string data)
	{
		return true;
	}

	internal static bool jpmsxagBJcSl1ojtxxx()
	{
		return lUrYgagKWgBCV9Kq8Mb == null;
	}
}
