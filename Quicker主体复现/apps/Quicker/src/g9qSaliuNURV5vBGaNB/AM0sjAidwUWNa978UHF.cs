using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using qcrGlGMkgcYtX0leyxF;

namespace g9qSaliuNURV5vBGaNB;

internal class AM0sjAidwUWNa978UHF
{
	private static readonly ILog cEsvtQlnIbE;

	private readonly BlockingCollection<Action> m9mvtjm4tON = new BlockingCollection<Action>();

	private readonly Thread Hu3vtn8lONC;

	private AutoResetEvent bQFvt4fthCE = new AutoResetEvent(false);

	private readonly Task ih5vt5ieihL;

	private static AM0sjAidwUWNa978UHF NqV8R1FCpcgqbghIi0ED;

	public AM0sjAidwUWNa978UHF()
	{
		ih5vt5ieihL = GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(Execute, "mouse_action");
	}

	public bool xiKvtrfpJVF()
	{
		return m9mvtjm4tON.Count > 0;
	}

	public void GfIvtpmojfh(Action action_0)
	{
		m9mvtjm4tON.Add(action_0);
	}

	private void qknvtBNTjBY()
	{
		Execute();
	}

	private void Execute()
	{
		cEsvtQlnIbE.Info("高级鼠标触发队列线程启动了。");
		while (true)
		{
			Action action = m9mvtjm4tON.Take();
			cEsvtQlnIbE.Info("Execute task");
			try
			{
				action();
			}
			catch (Exception ex)
			{
				cEsvtQlnIbE.Warn("执行操作出错：" + ex.Message, ex);
			}
		}
	}

	static AM0sjAidwUWNa978UHF()
	{
		cEsvtQlnIbE = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool hO1dLWFCXLLO9c9J043V()
	{
		return NqV8R1FCpcgqbghIi0ED == null;
	}

	internal static void e0lkUcFCnVNfcgPLVqXi()
	{
	}
}
