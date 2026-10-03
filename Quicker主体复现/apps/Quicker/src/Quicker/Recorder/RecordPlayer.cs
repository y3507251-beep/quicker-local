using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Quicker.Domain.Actions;
using Quicker.Recorder.Entities;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Recorder;

public class RecordPlayer
{
	private bool FDX6NvjsWO;

	public const int NO_MOVE_VALUE = -99999;

	[CompilerGenerated]
	private bool kXR6JnSmAE;

	internal static RecordPlayer BOUV12gynDVX4KoKJvF;

	public bool IsPlaying
	{
		[CompilerGenerated]
		get
		{
			return kXR6JnSmAE;
		}
		[CompilerGenerated]
		private set
		{
			kXR6JnSmAE = value;
		}
	}

	public void Stop()
	{
		FDX6NvjsWO = true;
	}

	public void Play(string linesData, double speedRatio, ActionExecuteContext context)
	{
		IList<RecordItemBase> list = new List<RecordItemBase>();
		string[] array = linesData.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
		int num = 0;
		string[] array2 = array;
		int num3 = default(int);
		foreach (string text in array2)
		{
			num++;
			if (string.IsNullOrWhiteSpace(text))
			{
				continue;
			}
			int num2 = 0;
			if (!tD8VnSgpQFgnbZNN8wk())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (!text.StartsWith("//"))
			{
				string[] array3 = text.Split(new char[1] { ';' }, StringSplitOptions.None);
				if (array3.Length < 3)
				{
					throw new InvalidDataException($"键鼠录制数据格式不合法：行{num}");
				}
				string recordTypeKey = array3[1].Trim();
				int delayMs = Convert.ToInt32(array3[0].Trim());
				string data = array3[2].Trim();
				RecordItemBase recordItemBase = RecorderHelper.CreateItemFromKey(recordTypeKey);
				recordItemBase.DelayMs = delayMs;
				try
				{
					recordItemBase.ParseData(data);
				}
				catch (Exception innerException)
				{
					throw new InvalidDataException($"键鼠录制数据格式不合法：行{num}", innerException);
				}
				list.Add(recordItemBase);
			}
		}
		Play(list, speedRatio, context);
	}

	public void Play(IList<RecordItemBase> items, double speedRatio, ActionExecuteContext context)
	{
		FDX6NvjsWO = false;
		IsPlaying = true;
		foreach (RecordItemBase item in items)
		{
			if (!FDX6NvjsWO)
			{
				if (context == null || !context.IsShouldStopAction())
				{
					int num = ((item.DelayMs > 0) ? ((int)((double)item.DelayMs / speedRatio)) : 0);
					if (item.EventType == RecordEventType.Delay)
					{
						Ivk62dS0EY(num, context);
						continue;
					}
					if (item.EventType.IsEither(RecordEventType.KeyDown, RecordEventType.KeyUp, RecordEventType.KeyPress))
					{
						if (num > 0)
						{
							Ivk62dS0EY(num, context);
						}
						RecordKeyboardEvent recordKeyboardEvent = item as RecordKeyboardEvent;
						switch (item.EventType)
						{
						case RecordEventType.KeyDown:
							InputSimulator.Instance.Keyboard.KeyDown((VirtualKeyCode)recordKeyboardEvent.Key);
							break;
						case RecordEventType.KeyUp:
							InputSimulator.Instance.Keyboard.KeyUp((VirtualKeyCode)recordKeyboardEvent.Key);
							break;
						case RecordEventType.KeyPress:
							InputSimulator.Instance.Keyboard.KeyPress((VirtualKeyCode)recordKeyboardEvent.Key);
							break;
						}
					}
					else if (item.EventType.IsEither(RecordEventType.MouseWheel, RecordEventType.MouseHWheel, RecordEventType.MouseDown, RecordEventType.MouseUp, RecordEventType.MouseClick, RecordEventType.MouseMove, RecordEventType.MouseMoveDelta))
					{
						RecordMouseEvent recordMouseEvent = item as RecordMouseEvent;
						if (recordMouseEvent.X == -99999 && recordMouseEvent.Y == -99999)
						{
							Ivk62dS0EY(num, context);
						}
						else
						{
							Point mousePosition = NativeMethods.GetMousePosition();
							Point point = new Point(recordMouseEvent.X, recordMouseEvent.Y);
							if (item.EventType == RecordEventType.MouseMoveDelta)
							{
								point.X = mousePosition.X + recordMouseEvent.X;
								point.Y = mousePosition.Y + recordMouseEvent.Y;
							}
							if (num < 50)
							{
								Ivk62dS0EY(num, context);
								if (mousePosition.X != point.X || mousePosition.Y != point.Y)
								{
									AppHelper.ChangeCursorPosition(new Point(point.X, point.Y));
								}
							}
							else if (mousePosition.X == point.X && mousePosition.Y == point.Y)
							{
								Ivk62dS0EY(num, context);
							}
							else
							{
								X9u6SnjixH(num, mousePosition, point.X, point.Y, context);
							}
						}
						if (item.EventType.IsEither(RecordEventType.MouseHWheel, RecordEventType.MouseWheel))
						{
							if (item.EventType == RecordEventType.MouseWheel)
							{
								InputSimulator.Instance.Mouse.VerticalScrollInDelta(recordMouseEvent.Delta);
							}
							else
							{
								InputSimulator.Instance.Mouse.HorizontalScrollInDelta(recordMouseEvent.Delta);
							}
						}
						else if (recordMouseEvent.EventType == RecordEventType.MouseDown)
						{
							switch (recordMouseEvent.Button)
							{
							case MouseButtons.Right:
								InputSimulator.Instance.Mouse.RightButtonDown();
								break;
							case MouseButtons.Left:
								InputSimulator.Instance.Mouse.LeftButtonDown();
								break;
							case MouseButtons.XButton2:
								InputSimulator.Instance.Mouse.XButtonDown(2);
								break;
							case MouseButtons.XButton1:
								InputSimulator.Instance.Mouse.XButtonDown(1);
								break;
							case MouseButtons.Middle:
								InputSimulator.Instance.Mouse.MiddleButtonDown();
								break;
							}
						}
						else if (recordMouseEvent.EventType == RecordEventType.MouseUp)
						{
							switch (recordMouseEvent.Button)
							{
							case MouseButtons.Right:
								InputSimulator.Instance.Mouse.RightButtonUp();
								break;
							case MouseButtons.Left:
								InputSimulator.Instance.Mouse.LeftButtonUp();
								break;
							case MouseButtons.XButton2:
								InputSimulator.Instance.Mouse.XButtonUp(2);
								break;
							case MouseButtons.XButton1:
								InputSimulator.Instance.Mouse.XButtonUp(1);
								break;
							case MouseButtons.Middle:
								InputSimulator.Instance.Mouse.MiddleButtonUp();
								break;
							}
						}
						else if (recordMouseEvent.EventType == RecordEventType.MouseClick)
						{
							switch (recordMouseEvent.Button)
							{
							case MouseButtons.Right:
								InputSimulator.Instance.Mouse.RightButtonClick();
								break;
							case MouseButtons.Left:
								InputSimulator.Instance.Mouse.LeftButtonClick();
								break;
							case MouseButtons.XButton2:
								InputSimulator.Instance.Mouse.XButtonClick(2);
								break;
							case MouseButtons.XButton1:
								InputSimulator.Instance.Mouse.XButtonClick(1);
								break;
							case MouseButtons.Middle:
								InputSimulator.Instance.Mouse.MiddleButtonClick();
								break;
							}
						}
					}
					else if (item.EventType == RecordEventType.TextInput)
					{
						InputSimulator.Instance.Keyboard.TextEntry((item as RecordTextInputEvent).Text);
					}
					IsPlaying = false;
					continue;
				}
				IsPlaying = false;
				break;
			}
			IsPlaying = false;
			break;
		}
	}

	private void X9u6SnjixH(int int_0, Point point_0, int int_1, int int_2, ActionExecuteContext actionExecuteContext_0)
	{
		int num = 20;
		int num2 = int_0 / 20;
		int num3 = 0;
		while (true)
		{
			if (num3 < num2)
			{
				if (actionExecuteContext_0 != null && actionExecuteContext_0.IsShouldStopAction())
				{
					break;
				}
				Thread.Sleep(num);
				int x = (int)((double)point_0.X + (double)((int_1 - point_0.X) * num3) / ((double)num2 + 1.0));
				int y = (int)((double)point_0.Y + (double)((int_2 - point_0.Y) * num3) / ((double)num2 + 1.0));
				AppHelper.ChangeCursorPosition(new Point(x, y));
				if (BOUV12gynDVX4KoKJvF != null)
				{
					switch (0)
					{
					}
				}
				num3++;
				continue;
			}
			if (actionExecuteContext_0 == null || !actionExecuteContext_0.IsShouldStopAction())
			{
				Thread.Sleep(int_0 % num);
				AppHelper.ChangeCursorPosition(new Point(int_1, int_2));
			}
			break;
		}
	}

	private void Ivk62dS0EY(int int_0, ActionExecuteContext actionExecuteContext_0)
	{
		if (int_0 <= 0)
		{
			return;
		}
		if (int_0 < 100)
		{
			if (BOUV12gynDVX4KoKJvF == null)
			{
				switch (0)
				{
				}
			}
			Thread.Sleep(int_0);
		}
		else
		{
			DateTime dateTime = DateTime.Now.AddMilliseconds(int_0);
			int millisecondsTimeout = 20;
			while (DateTime.Now < dateTime && (actionExecuteContext_0 == null || !actionExecuteContext_0.IsShouldStopAction()))
			{
				Thread.Sleep(millisecondsTimeout);
			}
		}
	}

	internal static bool tD8VnSgpQFgnbZNN8wk()
	{
		return BOUV12gynDVX4KoKJvF == null;
	}
}
