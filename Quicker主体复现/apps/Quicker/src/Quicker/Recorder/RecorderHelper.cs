using System.IO;
using Quicker.Recorder.Entities;

namespace Quicker.Recorder;

public static class RecorderHelper
{
	internal static object cy3i2LgQvb02LNrEKaJ;

	public static string ToEventTypeKey(this RecordEventType typeEnum)
	{
		return typeEnum switch
		{
			RecordEventType.WindowChange => "WD", 
			RecordEventType.MouseDown => "MD", 
			RecordEventType.MouseUp => "MU", 
			RecordEventType.MouseWheel => "MW", 
			RecordEventType.MouseHWheel => "MH", 
			RecordEventType.MouseMove => "MV", 
			RecordEventType.MouseClick => "MC", 
			RecordEventType.Delay => "DL", 
			RecordEventType.KeyDown => "KD", 
			RecordEventType.KeyUp => "KU", 
			RecordEventType.KeyPress => "KP", 
			RecordEventType.TextInput => "TI", 
			_ => throw new InvalidDataException("不支持的类型"), 
		};
	}

	public static RecordItemBase CreateItemFromKey(string recordTypeKey)
	{
		return recordTypeKey switch
		{
			"MVD" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseMoveDelta
			}, 
			"DL" => new RecordItemBase
			{
				EventType = RecordEventType.Delay
			}, 
			"MC" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseClick
			}, 
			"MH" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseHWheel
			}, 
			"KD" => new RecordKeyboardEvent
			{
				EventType = RecordEventType.KeyDown
			}, 
			"MD" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseDown
			}, 
			"TI" => new RecordTextInputEvent
			{
				EventType = RecordEventType.TextInput
			}, 
			"MU" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseUp
			}, 
			"MV" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseMove
			}, 
			"MW" => new RecordMouseEvent
			{
				EventType = RecordEventType.MouseWheel
			}, 
			"KP" => new RecordKeyboardEvent
			{
				EventType = RecordEventType.KeyPress
			}, 
			_ => throw new InvalidDataException("暂不支持"), 
		};
	}

	internal static bool AcgYITgFiKPkCJva8f3()
	{
		return cy3i2LgQvb02LNrEKaJ == null;
	}
}
