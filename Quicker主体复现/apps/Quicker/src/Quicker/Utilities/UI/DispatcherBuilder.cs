using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;
using log4net;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.UI;

public static class DispatcherBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public Dispatcher DtT2PmPjR8A;

		public ManualResetEvent LWq2PKAXsVB;

		internal static _003C_003Ec__DisplayClass1_0 rmathgyJEf2GLS1oB1gB;

		internal void SAi2PXGxCbU()
		{
			DtT2PmPjR8A = Dispatcher.CurrentDispatcher;
			SynchronizationContext.SetSynchronizationContext(new DispatcherSynchronizationContext(DtT2PmPjR8A));
			LWq2PKAXsVB.Set();
			try
			{
				Dispatcher.Run();
			}
			catch (Exception ex)
			{
				TtOvScCyMgv.Error("Dispatcher.Run() 出错：" + ex.Message, ex);
			}
		}

		internal static bool ipJJZ4yJGfy0CR0yHJy7()
		{
			return rmathgyJEf2GLS1oB1gB == null;
		}
	}

	private static readonly ILog TtOvScCyMgv;

	internal static object tkmZn1FhcxrMJNTecEld;

	public static Dispatcher Build(string threadName)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.DtT2PmPjR8A = null;
		_003C_003Ec__DisplayClass1_.LWq2PKAXsVB = new ManualResetEvent(false);
		Thread thread = new Thread(_003C_003Ec__DisplayClass1_.SAi2PXGxCbU, 1);
		thread.Priority = ThreadPriority.Normal;
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = threadName.Or("Custom Dispatcher");
		thread.Start();
		_003C_003Ec__DisplayClass1_.LWq2PKAXsVB.WaitOne();
		_003C_003Ec__DisplayClass1_.LWq2PKAXsVB.Dispose();
		return _003C_003Ec__DisplayClass1_.DtT2PmPjR8A;
	}

	static DispatcherBuilder()
	{
		TtOvScCyMgv = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool egpycSFhWwZHWCvPlPma()
	{
		return tkmZn1FhcxrMJNTecEld == null;
	}
}
