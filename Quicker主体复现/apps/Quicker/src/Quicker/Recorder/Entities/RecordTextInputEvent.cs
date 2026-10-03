using System.Runtime.CompilerServices;

namespace Quicker.Recorder.Entities;

public class RecordTextInputEvent : RecordItemBase
{
	[CompilerGenerated]
	private string xXP6rORqck;

	private static RecordTextInputEvent imdtkCgolWhY94qAR42;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return xXP6rORqck;
		}
		[CompilerGenerated]
		set
		{
			xXP6rORqck = value;
		}
	}

	protected override string SerializeLocalData()
	{
		return Text;
	}

	public override bool ParseData(string data)
	{
		Text = data;
		return true;
	}

	internal static bool qhgb3pgfIPswHyPkMR9()
	{
		return imdtkCgolWhY94qAR42 == null;
	}
}
