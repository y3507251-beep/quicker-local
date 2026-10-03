using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using Quicker.View;

namespace Quicker.Domain.Actions.Runner;

public class SelectActionRunner : ActionRunnerBase
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec aqSvFglvbSh;

		public static Func<ActionItem, SimpleOperationItem> iSivFLgrxsd;

		internal static _003C_003Ec LegLclWXSj0Me5R52uSq;

		static _003C_003Ec()
		{
			aqSvFglvbSh = new _003C_003Ec();
		}

		internal SimpleOperationItem xAlvFtEvH0n(ActionItem x)
		{
			return new SimpleOperationItem
			{
				Data = x,
				Description = x.Description,
				Icon = x.Icon,
				Name = x.Title
			};
		}

		internal static bool F8DAdgWXwpsmq3gZrElC()
		{
			return LegLclWXSj0Me5R52uSq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public List<SimpleOperationItem> xtXvFSoZZVo;

		public IntPtr mWQvF2VUpdt;

		public int ddQvFuNhYfp;

		public AppServer MQ6vFNMNspH;

		public ActionExecuteContext CbWvFJ5c8KM;

		internal static _003C_003Ec__DisplayClass1_0 I1sOS0WXmJGjWEInML2M;

		internal void fcbvFvmmxtU()
		{
			SelectOperationWindow selectOperationWindow = new SelectOperationWindow(xtXvFSoZZVo)
			{
				Topmost = true
			};
			bool? flag = selectOperationWindow.ShowDialog();
			if (mWQvF2VUpdt != IntPtr.Zero)
			{
				AppHelper.SetForegroundWindow(mWQvF2VUpdt);
			}
			if (flag == true)
			{
				ActionTypeManager.RunAction(selectOperationWindow.SelectedItem.Data as ActionItem, ddQvFuNhYfp, MQ6vFNMNspH, CbWvFJ5c8KM);
			}
		}

		internal static bool SG3ae8WXsZEaFGmJm2bE()
		{
			return I1sOS0WXmJGjWEInML2M == null;
		}
	}

	internal static SelectActionRunner PfUwVgQoqIhUZVqEtObY;

	public override void ExecuteAction(ActionItem action, int btnIndex, AppServer server, ActionExecuteContext actionExecuteContext)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.ddQvFuNhYfp = btnIndex;
		_003C_003Ec__DisplayClass1_.MQ6vFNMNspH = server;
		_003C_003Ec__DisplayClass1_.CbWvFJ5c8KM = actionExecuteContext;
		if (!EwciZVQoiQ4Hr5Hk7lIx())
		{
			switch (0)
			{
			}
		}
		if (!string.IsNullOrEmpty(action.Data))
		{
			IList<ActionItem> source = JsonConvert.DeserializeObject<IList<ActionItem>>(action.Data);
			_003C_003Ec__DisplayClass1_.xtXvFSoZZVo = source.Select(_003C_003Ec.iSivFLgrxsd ?? (_003C_003Ec.iSivFLgrxsd = _003C_003Ec.aqSvFglvbSh.xAlvFtEvH0n)).ToList();
			_003C_003Ec__DisplayClass1_.mWQvF2VUpdt = NativeMethods.GetForegroundWindow();
			AppState.HS2taepcAbc().Dispatcher?.Invoke(_003C_003Ec__DisplayClass1_.fcbvFvmmxtU);
		}
	}

	internal static bool EwciZVQoiQ4Hr5Hk7lIx()
	{
		return PfUwVgQoqIhUZVqEtObY == null;
	}
}
