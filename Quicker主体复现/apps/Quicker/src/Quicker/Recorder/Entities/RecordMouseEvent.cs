using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Quicker.Recorder.Entities;

public class RecordMouseEvent : RecordItemBase
{
	[CompilerGenerated]
	private MouseButtons MMc6XEBI0d;

	[CompilerGenerated]
	private int FHG6mDU4tv;

	[CompilerGenerated]
	private int zpW6KDvJmt;

	[CompilerGenerated]
	private int bpO6x7I7wv;

	private static RecordMouseEvent AGWMYbg9pe50HEaNHMR;

	public MouseButtons Button
	{
		[CompilerGenerated]
		get
		{
			return MMc6XEBI0d;
		}
		[CompilerGenerated]
		set
		{
			MMc6XEBI0d = value;
		}
	}

	public int X
	{
		[CompilerGenerated]
		get
		{
			return FHG6mDU4tv;
		}
		[CompilerGenerated]
		set
		{
			FHG6mDU4tv = value;
		}
	}

	public int Y
	{
		[CompilerGenerated]
		get
		{
			return zpW6KDvJmt;
		}
		[CompilerGenerated]
		set
		{
			zpW6KDvJmt = value;
		}
	}

	public int Delta
	{
		[CompilerGenerated]
		get
		{
			return bpO6x7I7wv;
		}
		[CompilerGenerated]
		set
		{
			bpO6x7I7wv = value;
		}
	}

	protected override string SerializeLocalData()
	{
		return $"{Button},{X},{Y},{Delta}";
	}

	public override bool ParseData(string data)
	{
		string[] array = data.Split(',');
		if (array.Length >= 4)
		{
			Button = ((!string.IsNullOrWhiteSpace(array[0])) ? ((MouseButtons)Enum.Parse(typeof(MouseButtons), array[0].Trim(), true)) : MouseButtons.None);
			X = ((!string.IsNullOrWhiteSpace(array[1])) ? Convert.ToInt32(array[1].Trim()) : (-99999));
			Y = (string.IsNullOrWhiteSpace(array[2]) ? (-99999) : Convert.ToInt32(array[2].Trim()));
			Delta = Convert.ToInt32(array[3]);
			return true;
		}
		return false;
	}

	internal static bool sCrCTegLSfL1jLIBQuq()
	{
		return AGWMYbg9pe50HEaNHMR == null;
	}
}
