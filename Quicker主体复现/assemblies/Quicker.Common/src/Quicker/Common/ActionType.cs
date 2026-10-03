namespace Quicker.Common;

public enum ActionType
{
	Empty = 0,
	Folder = 1,
	OpenUrl = 2,
	OpenFile = 4,
	SendText = 6,
	SendKeys = 7,
	LinkAction = 8,
	GoParent = 9,
	OpenProfile = 10,
	RunProgram = 11,
	OpenFolder = 12,
	SubProgram = 13,
	MouseInput = 14,
	RunScriptFile = 15,
	Composite = 21,
	Select = 22,
	WaitTime = 23,
	XAction = 24,
	XSubProgram = 25,
	NotSupported = 101,
	PreDefined = 200,
	TempRunSoftware = 300,
	TempAction = 999,
	TempRpaFlowAction = 1001
}
