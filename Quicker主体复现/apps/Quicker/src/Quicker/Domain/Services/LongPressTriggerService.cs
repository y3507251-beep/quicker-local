using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quicker.Domain.Services;

public static class LongPressTriggerService
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static TimerCallback Wurv4ljdPgK;
	}

	private static Timer KKItKpyvGGA;

	private static object anvtKB8Pa3N;

	internal static object JiiTZbQrPvhVC70i4ZSD;

	public static void Start(Action action)
	{
		Cancel();
		int dueTime = AppState.DataService.CpItmVISR7P().ContextMenuSettings?.TriggerIntervalMs ?? 200;
		KKItKpyvGGA = new Timer(_003C_003EO.Wurv4ljdPgK ?? (_003C_003EO.Wurv4ljdPgK = GaltKrne3Na), action, dueTime, -1);
	}

	private static void GaltKrne3Na(object object_1)
	{
		Cancel();
		if (object_1 is Action action)
		{
			action();
		}
	}

	public static void Cancel()
	{
		if (KKItKpyvGGA != null)
		{
			lock (anvtKB8Pa3N)
			{
				KKItKpyvGGA.Dispose();
				KKItKpyvGGA = null;
			}
		}
	}

	static LongPressTriggerService()
	{
		KKItKpyvGGA = null;
		anvtKB8Pa3N = new object();
	}

	internal static bool IkD1vLQrMcFFD25PFtHQ()
	{
		return JiiTZbQrPvhVC70i4ZSD == null;
	}
}
