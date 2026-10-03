using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using lUCjKTMbZVPP5v56los;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Recorder.Entities;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Hooks;
using Quicker.Utilities.Win32;

namespace Quicker.Recorder;

public class OperationRecorder
{
	private lPxZYOM8ws3NP42wph0 gyibUXtuLC = new lPxZYOM8ws3NP42wph0();

	private KeyboardHook WYEblwqKuq = new KeyboardHook();

	private int v8ibiV7pf1;

	private Stopwatch yeQb3Tlyvt = new Stopwatch();

	private double vukbfOE7wn;

	private int JEgbzvoZqL;

	private int Hkg6wYpnu3;

	[CompilerGenerated]
	private bool pC06tvwoiq;

	[CompilerGenerated]
	private bool ENQ6gBT0WB = true;

	[CompilerGenerated]
	private bool SRK6L3mKMO;

	private IList<RecordItemBase> hHP6vUiu1C = new List<RecordItemBase>(100);

	internal static OperationRecorder Rxgb55RmLAeAVxD8Q4T;

	public bool RecordMouseMove
	{
		[CompilerGenerated]
		get
		{
			return pC06tvwoiq;
		}
		[CompilerGenerated]
		set
		{
			pC06tvwoiq = value;
		}
	}

	public bool MergeEvents
	{
		[CompilerGenerated]
		get
		{
			return ENQ6gBT0WB;
		}
		[CompilerGenerated]
		set
		{
			ENQ6gBT0WB = value;
		}
	}

	public bool IsRecording
	{
		[CompilerGenerated]
		get
		{
			return SRK6L3mKMO;
		}
		[CompilerGenerated]
		private set
		{
			SRK6L3mKMO = value;
		}
	}

	public IList<RecordItemBase> Records => hHP6vUiu1C;

	public OperationRecorder()
	{
		gyibUXtuLC.xCULAKutXGc(dyQbMaVOr8);
		gyibUXtuLC.Q9JLApsvECB(LPObTkF6IM);
		gyibUXtuLC.MouseWheel += tAbboN3i7Z;
		gyibUXtuLC.NyCLAjrMddj(TBZbdOU3Wu);
		gyibUXtuLC.unGLAd66cNd(ri7bDVf8ox);
		WYEblwqKuq.KeyDown += nvebnUiX5J;
		WYEblwqKuq.KeyUp += hcSbjCXv5q;
	}

	private int rmqbQ1P50r()
	{
		v8ibiV7pf1++;
		return v8ibiV7pf1;
	}

	private void hcSbjCXv5q(object sender, KeyEventArgs e)
	{
		if ((e as HookKeyEventArgs).IsInjected)
		{
			return;
		}
		if (MergeEvents && !e.KeyCode.IsEither(Keys.LControlKey, Keys.RControlKey, Keys.LShiftKey, Keys.RShiftKey, Keys.LMenu, Keys.RMenu, Keys.LWin, Keys.RWin) && hHP6vUiu1C.Count > 0)
		{
			RecordItemBase recordItemBase = hHP6vUiu1C.Last();
			if (recordItemBase.EventType == RecordEventType.KeyDown)
			{
				if (JdOTgFRsJEVZZOF0g0h())
				{
					switch (0)
					{
					}
				}
				if ((recordItemBase as RecordKeyboardEvent).Key == e.KeyCode && (double)yeQb3Tlyvt.ElapsedMilliseconds < vukbfOE7wn + 200.0)
				{
					recordItemBase.EventType = RecordEventType.KeyPress;
					return;
				}
			}
			if (hHP6vUiu1C.Count > 1 && hHP6vUiu1C[hHP6vUiu1C.Count - 2].EventType == RecordEventType.KeyDown)
			{
				RecordKeyboardEvent recordKeyboardEvent = hHP6vUiu1C[hHP6vUiu1C.Count - 2] as RecordKeyboardEvent;
				if (recordKeyboardEvent.Key == e.KeyCode && (double)yeQb3Tlyvt.ElapsedMilliseconds < vukbfOE7wn + 200.0 - (double)recordItemBase.DelayMs)
				{
					recordKeyboardEvent.EventType = RecordEventType.KeyPress;
					return;
				}
			}
		}
		gqyb4TX8K9(RecordEventType.KeyUp, e.KeyCode);
	}

	private void nvebnUiX5J(object sender, KeyEventArgs e)
	{
		if (!(e as HookKeyEventArgs).IsInjected)
		{
			gqyb4TX8K9(RecordEventType.KeyDown, e.KeyCode);
		}
	}

	private void gqyb4TX8K9(RecordEventType recordEventType_0, Keys keys_0)
	{
		double num = (double)yeQb3Tlyvt.ElapsedMilliseconds - vukbfOE7wn;
		vukbfOE7wn = yeQb3Tlyvt.ElapsedMilliseconds;
		RecordKeyboardEvent item = new RecordKeyboardEvent
		{
			Seq = rmqbQ1P50r(),
			DelayMs = (int)num,
			EventType = recordEventType_0,
			Key = keys_0
		};
		hHP6vUiu1C.Add(item);
	}

	private void eadb5qWVwm(RecordEventType recordEventType_0, MouseEventArgs mouseEventArgs_0)
	{
		double num = (double)yeQb3Tlyvt.ElapsedMilliseconds - vukbfOE7wn;
		vukbfOE7wn = yeQb3Tlyvt.ElapsedMilliseconds;
		RecordMouseEvent item = new RecordMouseEvent
		{
			Seq = rmqbQ1P50r(),
			DelayMs = (int)num,
			EventType = recordEventType_0,
			Button = mouseEventArgs_0.Button,
			X = mouseEventArgs_0.X,
			Y = mouseEventArgs_0.Y,
			Delta = mouseEventArgs_0.Delta
		};
		hHP6vUiu1C.Add(item);
	}

	private void ri7bDVf8ox(object sender, MouseEventArgs e)
	{
		if (!(e as AppMouseEventArgs).IsInjected)
		{
			if (hHP6vUiu1C.Count == 0 || hHP6vUiu1C.Last().EventType != RecordEventType.MouseHWheel)
			{
				eadb5qWVwm(RecordEventType.MouseMove, new MouseEventArgs(MouseButtons.None, 0, JEgbzvoZqL, Hkg6wYpnu3, 0));
			}
			eadb5qWVwm(RecordEventType.MouseHWheel, e);
		}
	}

	private void TBZbdOU3Wu(object sender, MouseEventArgs e)
	{
		while (true)
		{
			if (RecordMouseMove)
			{
				if (Rxgb55RmLAeAVxD8Q4T != null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				if ((double)yeQb3Tlyvt.ElapsedMilliseconds - vukbfOE7wn > 5.0 && (Math.Abs(e.X - JEgbzvoZqL) > 5 || Math.Abs(e.Y - Hkg6wYpnu3) > 5))
				{
					eadb5qWVwm(RecordEventType.MouseMove, e);
					JEgbzvoZqL = e.X;
					Hkg6wYpnu3 = e.Y;
				}
			}
			else
			{
				JEgbzvoZqL = e.X;
				Hkg6wYpnu3 = e.Y;
			}
			break;
		}
	}

	private void tAbboN3i7Z(object sender, MouseEventArgs e)
	{
		if (hHP6vUiu1C.Count == 0 || hHP6vUiu1C.Last().EventType != RecordEventType.MouseWheel)
		{
			eadb5qWVwm(RecordEventType.MouseMove, new MouseEventArgs(MouseButtons.None, 0, JEgbzvoZqL, Hkg6wYpnu3, 0));
		}
		eadb5qWVwm(RecordEventType.MouseWheel, e);
	}

	private void LPObTkF6IM(object sender, MouseEventArgs e)
	{
		if ((e as AppMouseEventArgs).IsInjected)
		{
			return;
		}
		if (MergeEvents && hHP6vUiu1C.Count > 0)
		{
			RecordItemBase recordItemBase = hHP6vUiu1C.Last();
			if (recordItemBase.EventType == RecordEventType.MouseDown)
			{
				int num = 0;
				if (!JdOTgFRsJEVZZOF0g0h())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				RecordMouseEvent recordMouseEvent = recordItemBase as RecordMouseEvent;
				if (recordMouseEvent.X == e.X && recordMouseEvent.Y == e.Y && recordMouseEvent.Button == e.Button && (double)yeQb3Tlyvt.ElapsedMilliseconds < vukbfOE7wn + 200.0)
				{
					recordItemBase.EventType = RecordEventType.MouseClick;
					return;
				}
			}
		}
		eadb5qWVwm(RecordEventType.MouseUp, e);
	}

	private void dyQbMaVOr8(object sender, MouseEventArgs e)
	{
		if (!(e as AppMouseEventArgs).IsInjected)
		{
			eadb5qWVwm(RecordEventType.MouseDown, e);
		}
	}

	public void Start(bool mergeEvents)
	{
		AppState.Y2RtaqSv0AQ().TogglePausePopup(this);
		if (IsRecording)
		{
			AppHelper.ShowWarning("已经在录制了。");
			return;
		}
		MergeEvents = mergeEvents;
		IsRecording = true;
		v8ibiV7pf1 = 0;
		yeQb3Tlyvt.Reset();
		hHP6vUiu1C.Clear();
		Point mousePosition = NativeMethods.GetMousePosition();
		JEgbzvoZqL = mousePosition.X;
		int num = 0;
		if (!JdOTgFRsJEVZZOF0g0h())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Hkg6wYpnu3 = mousePosition.Y;
		vukbfOE7wn = 0.0;
		yeQb3Tlyvt.Start();
		WYEblwqKuq.Start();
		gyibUXtuLC.Start();
	}

	public void Stop()
	{
		DebugHelper.LogExecuteTime(PDpbOLa6as, "Stop recording", 1);
		AppState.Y2RtaqSv0AQ().TogglePausePopup(this);
	}

	public void RemoveLastClick()
	{
		if (hHP6vUiu1C.Count < 1)
		{
			return;
		}
		if (hHP6vUiu1C.Last().EventType == RecordEventType.MouseClick)
		{
			int num = 0;
			if (Rxgb55RmLAeAVxD8Q4T != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			hHP6vUiu1C.RemoveAt(hHP6vUiu1C.Count - 1);
			U4TbAUB3SO();
		}
		else if (hHP6vUiu1C.Count > 2 && hHP6vUiu1C.Last().EventType == RecordEventType.MouseUp && hHP6vUiu1C[hHP6vUiu1C.Count - 2].EventType == RecordEventType.MouseDown)
		{
			hHP6vUiu1C.RemoveAt(hHP6vUiu1C.Count - 1);
			hHP6vUiu1C.RemoveAt(hHP6vUiu1C.Count - 1);
			U4TbAUB3SO();
		}
	}

	private void U4TbAUB3SO()
	{
		int num = hHP6vUiu1C.Count - 1;
		while (num >= 0 && hHP6vUiu1C[num].EventType == RecordEventType.MouseMove)
		{
			hHP6vUiu1C.RemoveAt(num);
			num--;
		}
	}

	public string GetRecordData()
	{
		StringBuilder stringBuilder = new StringBuilder(Records.Count * 20);
		foreach (RecordItemBase record in Records)
		{
			stringBuilder.AppendLine(record.Serialize());
		}
		return stringBuilder.ToString();
	}

	[CompilerGenerated]
	private void PDpbOLa6as()
	{
		gyibUXtuLC.Stop();
		WYEblwqKuq.Stop();
		yeQb3Tlyvt.Stop();
		IsRecording = false;
	}

	internal static bool JdOTgFRsJEVZZOF0g0h()
	{
		return Rxgb55RmLAeAVxD8Q4T == null;
	}
}
