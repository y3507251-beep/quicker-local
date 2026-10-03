using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using W33wbKA34cSsSUeCj5U;
using WebSocketSharp;

namespace FLmRJQA0Ow1lyfNCYme;

internal class bhYOYKAENE6X2KBY1Du
{
	private static readonly ILog KBFi8QDFeC;

	private readonly bool avGia6KYrX;

	[CompilerGenerated]
	private string Xq6i79UmyC;

	[CompilerGenerated]
	private WebSocket e8ciRqKefJ;

	[CompilerGenerated]
	private string wjpiqIVMIk;

	[CompilerGenerated]
	private string j3sicIIhwc;

	internal static bhYOYKAENE6X2KBY1Du gXmROuQV4ByrhA91inJi;

	public WebSocket Websocket
	{
		[CompilerGenerated]
		get
		{
			return e8ciRqKefJ;
		}
		[CompilerGenerated]
		set
		{
			e8ciRqKefJ = value;
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return wjpiqIVMIk;
		}
		[CompilerGenerated]
		set
		{
			wjpiqIVMIk = value;
		}
	}

	public string SpName
	{
		[CompilerGenerated]
		get
		{
			return j3sicIIhwc;
		}
		[CompilerGenerated]
		set
		{
			j3sicIIhwc = value;
		}
	}

	public bhYOYKAENE6X2KBY1Du(string string_3, WebSocket webSocket_1, string string_4, string string_5, bool bool_1)
	{
		avGia6KYrX = bool_1;
		yrXiuNksRa(string_3);
		Websocket = webSocket_1;
		ActionId = string_4;
		SpName = string_5;
		webSocket_1.OnMessage += CQdiSTkDmU;
		webSocket_1.OnError += XNEivAkRs5;
		webSocket_1.OnClose += I7riL9alpc;
	}

	private void I7riL9alpc(object sender, CloseEventArgs e)
	{
		CgCbcpAs57A5JADwgZR.ROVlz9sJkA().nfxl3cktgi(FGQi2ntV9R());
		if (avGia6KYrX)
		{
			AppState.AppServer.ExecuteActionByIdOrName(ActionId, null, false, false, false, "websocket_closed", ActionTrigger.NA);
		}
	}

	private void XNEivAkRs5(object sender, ErrorEventArgs e)
	{
		KBFi8QDFeC.Warn("OnError：" + e.Message, e.Exception);
	}

	private void CQdiSTkDmU(object sender, MessageEventArgs e)
	{
		if (!e.IsText)
		{
			return;
		}
		string data = e.Data;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["Data"] = data;
		try
		{
			if (AppState.AppServer.ExecuteActionSubProgram(ActionId, SpName, dictionary).TryGetValue("Response", out var value) && value is string text && !string.IsNullOrEmpty(text))
			{
				Websocket.Send(text);
			}
		}
		catch (Exception ex)
		{
			KBFi8QDFeC.Warn("处理Websocket消息出错：" + ex.Message, ex);
			Websocket.Close();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string FGQi2ntV9R()
	{
		return Xq6i79UmyC;
	}

	[SpecialName]
	[CompilerGenerated]
	public void yrXiuNksRa(string string_3)
	{
		Xq6i79UmyC = string_3;
	}

	static bhYOYKAENE6X2KBY1Du()
	{
		KBFi8QDFeC = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool oQVSLAQVhBLfRYDWAD0H()
	{
		return gXmROuQV4ByrhA91inJi == null;
	}
}
