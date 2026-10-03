using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using log4net;
using LPAgent.Domain;
using NamedPipeWrapper;
using Newtonsoft.Json;
using Quicker.Utilities;

namespace bO46JfWAenppOQ94A2q;

internal class y2RHWHW5SANm8yApQAU
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public string pvEvWHLGM6k;

		public AutoResetEvent uGtvW1PnHcL;

		internal static _003C_003Ec__DisplayClass10_0 MAgJvwc52JfmL6omaA44;

		internal void QKCvWGJ2RYX(NamedPipeConnection<string, string> connection, string message)
		{
			pvEvWHLGM6k = message;
			uGtvW1PnHcL.Set();
		}

		internal void T1xvWsW4eBQ(NamedPipeConnection<string, string> connection)
		{
			uGtvW1PnHcL.Set();
		}

		internal static bool oY2gNRc5AaEy9FVZuK3S()
		{
			return MAgJvwc52JfmL6omaA44 == null;
		}
	}

	private static readonly ILog FjXtg443rEj;

	private static y2RHWHW5SANm8yApQAU JxQtg5H2Rx9;

	private int MUDtgDNrpp4;

	private IDictionary<int, Response> E1RtgdYloEw = new ConcurrentDictionary<int, Response>();

	private Process SdgtgofE93U;

	internal static y2RHWHW5SANm8yApQAU Uf7M98QWrDO1dbO5Zuin;

	[SpecialName]
	public static y2RHWHW5SANm8yApQAU PeBtgjCTonj()
	{
		if (JxQtg5H2Rx9 == null)
		{
			JxQtg5H2Rx9 = new y2RHWHW5SANm8yApQAU();
		}
		return JxQtg5H2Rx9;
	}

	private y2RHWHW5SANm8yApQAU()
	{
	}

	private bool uKOtgBkd0kj()
	{
		if (SdgtgofE93U != null && !SdgtgofE93U.HasExited)
		{
			return false;
		}
		SdgtgofE93U = Process.Start(Path.Combine(AppHelper.GetAppFolder(), "LPAgent.exe"));
		return true;
	}

	public Response PFotgQdV5Ru(Command command_0)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		bool flag = uKOtgBkd0kj();
		command_0.Serial = MUDtgDNrpp4++;
		NamedPipeClient<string> namedPipeClient = new NamedPipeClient<string>("QUICKER_LPAGENT_CHANNEL")
		{
			MaxConnectRetryCount = 5,
			AutoReconnect = false
		};
		if (Uf7M98QWrDO1dbO5Zuin != null)
		{
			switch (0)
			{
			}
		}
		_003C_003Ec__DisplayClass10_.pvEvWHLGM6k = string.Empty;
		bool flag2 = false;
		try
		{
			_003C_003Ec__DisplayClass10_.uGtvW1PnHcL = new AutoResetEvent(false);
			namedPipeClient.ServerMessage += _003C_003Ec__DisplayClass10_.QKCvWGJ2RYX;
			namedPipeClient.Disconnected += _003C_003Ec__DisplayClass10_.T1xvWsW4eBQ;
			namedPipeClient.Start();
			namedPipeClient.WaitForConnection(flag ? 5000 : 3000);
			if (!namedPipeClient.IsConnected())
			{
				if (Uf7M98QWrDO1dbO5Zuin != null)
				{
					switch (0)
					{
					}
				}
				throw new Exception("无法连接到低权限进程。");
			}
			namedPipeClient.PushMessage(JsonConvert.SerializeObject(command_0));
			int num = (command_0.WaitResp ? command_0.MaxWaitMs : 2000);
			if (num <= 0)
			{
				num = 10000;
			}
			flag2 = _003C_003Ec__DisplayClass10_.uGtvW1PnHcL.WaitOne(num);
		}
		finally
		{
			namedPipeClient.Stop();
		}
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass10_.pvEvWHLGM6k))
		{
			return JsonConvert.DeserializeObject<Response>(_003C_003Ec__DisplayClass10_.pvEvWHLGM6k);
		}
		if (flag2 && SdgtgofE93U.HasExited)
		{
			throw new Exception("低权限进程已退出，可能遇到了意外问题。");
		}
		return null;
	}

	static y2RHWHW5SANm8yApQAU()
	{
		FjXtg443rEj = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool FIQlaGQWN6yvj9ku1245()
	{
		return Uf7M98QWrDO1dbO5Zuin == null;
	}
}
