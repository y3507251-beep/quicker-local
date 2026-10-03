using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Clifton.Core.Pipes;
using log4net;
using Quicker.Utilities;

namespace Quicker.Domain.Services;

public class PipeServer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bRevQWYYR3H;

		public static Action<BasicPipe> qIAvQkBX4AZ;

		private static _003C_003Ec FplBAfcs2u98aLSj6h79;

		static _003C_003Ec()
		{
			bRevQWYYR3H = new _003C_003Ec();
		}

		internal void YoJvQIGhCqj(BasicPipe p)
		{
			p.StartStringReaderAsync();
		}

		internal static bool yaWsfrcsAmeigKu8JsKk()
		{
			return FplBAfcs2u98aLSj6h79 == null;
		}
	}

	public EventHandler<PipeEventArgs> MessageReceivedEvent;

	private readonly string uWGtGNByVvl;

	private static readonly ILog ONrtGJnR2rI;

	private IDictionary<ServerPipe, string> naYtG02f2JQ = new ConcurrentDictionary<ServerPipe, string>();

	internal static PipeServer hf9FWbQkL43gvb9I9vSq;

	public PipeServer(string pipeName)
	{
		uWGtGNByVvl = pipeName;
	}

	public void Start()
	{
		ABxtGv9GWON();
	}

	private ServerPipe ABxtGv9GWON()
	{
		try
		{
			ServerPipe serverPipe = new ServerPipe(uWGtGNByVvl, _003C_003Ec.qIAvQkBX4AZ ?? (_003C_003Ec.qIAvQkBX4AZ = _003C_003Ec.bRevQWYYR3H.YoJvQIGhCqj), IpcServer.RrFtBgpaG2C());
			naYtG02f2JQ.Add(serverPipe, string.Empty);
			serverPipe.DataReceived += QVAtGu9gbJf;
			serverPipe.Connected += nQHtG2nyKkW;
			serverPipe.PipeClosed += wkEtGS1ymKJ;
			return serverPipe;
		}
		catch (Exception ex)
		{
			ONrtGJnR2rI.Warn("创建ServerPipe出错：" + ex.Message, ex);
			AppHelper.ShowWarning("创建命名管道失败，" + ex.Message + "。");
		}
		return null;
	}

	private void wkEtGS1ymKJ(object sender, EventArgs e)
	{
		ServerPipe serverPipe = sender as ServerPipe;
		ClosePipe(serverPipe);
	}

	public void ClosePipe(ServerPipe serverPipe)
	{
		if (naYtG02f2JQ.ContainsKey(serverPipe))
		{
			naYtG02f2JQ.Remove(serverPipe);
			try
			{
				serverPipe.DataReceived -= QVAtGu9gbJf;
				serverPipe.Connected -= nQHtG2nyKkW;
				serverPipe.PipeClosed -= wkEtGS1ymKJ;
				serverPipe.Close();
			}
			catch (Exception)
			{
			}
		}
	}

	private void nQHtG2nyKkW(object sender, EventArgs e)
	{
		ABxtGv9GWON();
	}

	private void QVAtGu9gbJf(object sender, PipeEventArgs e)
	{
		MessageReceivedEvent?.Invoke(sender, e);
	}

	static PipeServer()
	{
		ONrtGJnR2rI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool E6K5BmQku9GqPyBCdjIG()
	{
		return hf9FWbQkL43gvb9I9vSq == null;
	}
}
