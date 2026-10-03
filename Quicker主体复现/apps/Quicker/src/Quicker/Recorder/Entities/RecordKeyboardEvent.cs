using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Recorder.Entities;

public class RecordKeyboardEvent : RecordItemBase
{
	[CompilerGenerated]
	private Keys dcj664tZJg;

	internal static RecordKeyboardEvent AgI1Y6gkk22a8ELSNia;

	public Keys Key
	{
		[CompilerGenerated]
		get
		{
			return dcj664tZJg;
		}
		[CompilerGenerated]
		set
		{
			dcj664tZJg = value;
		}
	}

	protected override string SerializeLocalData()
	{
		return $"{Key}";
	}

	public override bool ParseData(string data)
	{
		Key = (Keys)Enum.Parse(typeof(global::System.Windows.Forms.Keys), data, true);
		return true;
	}

	internal static bool oSG47bgaUhjh2yKLIRW()
	{
		return AgI1Y6gkk22a8ELSNia == null;
	}
}
