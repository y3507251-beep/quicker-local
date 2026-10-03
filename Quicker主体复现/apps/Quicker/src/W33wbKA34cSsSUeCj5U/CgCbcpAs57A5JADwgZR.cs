using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FLmRJQA0Ow1lyfNCYme;
using WebSocketSharp;

namespace W33wbKA34cSsSUeCj5U;

internal class CgCbcpAs57A5JADwgZR
{
	[CompilerGenerated]
	private static readonly CgCbcpAs57A5JADwgZR fVhit856hU;

	public IDictionary<string, bhYOYKAENE6X2KBY1Du> fU7ig9pAnA = new Dictionary<string, bhYOYKAENE6X2KBY1Du>();

	private static CgCbcpAs57A5JADwgZR ogXSCWQVsTi3go4QoSNO;

	private CgCbcpAs57A5JADwgZR()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	public static CgCbcpAs57A5JADwgZR ROVlz9sJkA()
	{
		return fVhit856hU;
	}

	public void IbRli5JPkF(string string_0, WebSocket webSocket_0, string string_1, string string_2, bool bool_0)
	{
		nfxl3cktgi(string_0);
		bhYOYKAENE6X2KBY1Du value = new bhYOYKAENE6X2KBY1Du(string_0, webSocket_0, string_1, string_2, bool_0);
		fU7ig9pAnA.Add(string_0, value);
	}

	public void nfxl3cktgi(string string_0)
	{
		if (!fU7ig9pAnA.TryGetValue(string_0, out var value))
		{
			return;
		}
		try
		{
			if (value.Websocket.IsAlive)
			{
				value.Websocket.Close();
			}
		}
		finally
		{
			fU7ig9pAnA.Remove(string_0);
		}
	}

	internal bool F4SlfgM15E(string string_0)
	{
		if (fU7ig9pAnA.ContainsKey(string_0))
		{
			return fU7ig9pAnA[string_0].Websocket.IsAlive;
		}
		return false;
	}

	public void SendMessage(string clientId, string message)
	{
		if (!fU7ig9pAnA.TryGetValue(clientId, out var value))
		{
			throw new InvalidOperationException("未找到客户端：" + clientId);
		}
		value.Websocket.Send(message);
	}

	static CgCbcpAs57A5JADwgZR()
	{
		fVhit856hU = new CgCbcpAs57A5JADwgZR();
	}

	internal static bool eaGsFrQVCL0kojeVcZ7R()
	{
		return ogXSCWQVsTi3go4QoSNO == null;
	}
}
