using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Quicker.Utilities._3rd;

namespace Quicker.Utilities;

public class DispatcherTinyMessageProxy : ITinyMessageProxy
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ITinyMessageSubscription Vqq2wc0sEXf;

		public ITinyMessage SQs2wVMtfaM;

		internal static _003C_003Ec__DisplayClass2_0 sWnsxuynZZ9RF1JAax1l;

		internal void gHW2wq4mX6U()
		{
			Vqq2wc0sEXf.Deliver(SQs2wVMtfaM);
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}

		internal static bool F2ZMlUyn5hPLwFWpwMTg()
		{
			return sWnsxuynZZ9RF1JAax1l == null;
		}

		internal static void Ujlyj7yn8HVFxsGD3642()
		{
		}
	}

	private readonly Dispatcher PUKLo4o9Vpa;

	private static DispatcherTinyMessageProxy qPQiLMFYWgtJes4RowKg;

	public DispatcherTinyMessageProxy(Dispatcher dispatcher)
	{
		PUKLo4o9Vpa = dispatcher;
	}

	public void Deliver(ITinyMessage message, ITinyMessageSubscription subscription)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.Vqq2wc0sEXf = subscription;
		_003C_003Ec__DisplayClass2_.SQs2wVMtfaM = message;
		PUKLo4o9Vpa.Invoke(_003C_003Ec__DisplayClass2_.gHW2wq4mX6U);
	}

	static DispatcherTinyMessageProxy()
	{
	}

	internal static void ijNJjcFYXQrqE2KBAfTE()
	{
	}

	internal static bool TBeo9BFYy70cjRCL3YIq()
	{
		return qPQiLMFYWgtJes4RowKg == null;
	}

	internal static void bk36daFY2NeHdoAN43OW()
	{
	}
}
