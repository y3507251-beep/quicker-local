using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using AeNud9jpLbfIkkEIprl;
using log4net;
using Quicker.Utilities;

namespace J7BsCmjJgKtd6cIAc1p;

internal class OeTcebjK6vK0y2ZOMOQ : F58U3QjL5trN9txFOH0
{
	private static readonly ILog y76tkBPrPvg;

	private static OeTcebjK6vK0y2ZOMOQ A9utkQpGgVL;

	private static readonly object F1ntkjgJGOb;

	private System.Timers.Timer M3PtknkV4hX;

	[CompilerGenerated]
	private EventHandler<long> dfhtk4CsiJG;

	internal static OeTcebjK6vK0y2ZOMOQ lQIE5kQkB9heXJiVmgvK;

	public bool IsRunning => M3PtknkV4hX.Enabled;

	private OeTcebjK6vK0y2ZOMOQ()
	{
	}

	[SpecialName]
	public static OeTcebjK6vK0y2ZOMOQ pUhtkmFk1ed()
	{
		lock (F1ntkjgJGOb)
		{
			if (A9utkQpGgVL == null)
			{
				A9utkQpGgVL = new OeTcebjK6vK0y2ZOMOQ();
			}
			return A9utkQpGgVL;
		}
	}

	public void QYLM2voUeQh()
	{
		if (M3PtknkV4hX == null)
		{
			M3PtknkV4hX = new System.Timers.Timer(1000.0);
			M3PtknkV4hX.Elapsed += lmxtkXexOMh;
		}
		M3PtknkV4hX.Start();
	}

	public void Stop()
	{
		M3PtknkV4hX.Stop();
	}

	public void woFM2c60JjB()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	public void fEBtkx60uw0(EventHandler<long> eventHandler_1)
	{
		EventHandler<long> eventHandler = dfhtk4CsiJG;
		EventHandler<long> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<long> value = (EventHandler<long>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref dfhtk4CsiJG, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void a64tkrZFVWX(EventHandler<long> eventHandler_1)
	{
		EventHandler<long> eventHandler = dfhtk4CsiJG;
		EventHandler<long> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<long> value = (EventHandler<long>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref dfhtk4CsiJG, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void lmxtkXexOMh(object sender, ElapsedEventArgs e)
	{
		if (dfhtk4CsiJG != null)
		{
			try
			{
				dfhtk4CsiJG(this, AppHelper.fLiLTj0x4QY());
			}
			catch (Exception ex)
			{
				y76tkBPrPvg.Warn("共享定时器触发事件时发生异常。" + ex.Message, ex);
			}
		}
	}

	static OeTcebjK6vK0y2ZOMOQ()
	{
		y76tkBPrPvg = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		F1ntkjgJGOb = new object();
	}

	internal static bool JT2buRQkvHITqZ7jUsJe()
	{
		return lQIE5kQkB9heXJiVmgvK == null;
	}

	internal static void yhDogIQkO4lV5tfb8yOm()
	{
	}
}
