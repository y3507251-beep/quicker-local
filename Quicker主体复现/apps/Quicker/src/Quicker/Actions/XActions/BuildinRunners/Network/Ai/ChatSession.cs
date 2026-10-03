using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OpenAI_API.Chat;

namespace Quicker.Actions.XActions.BuildinRunners.Network.Ai;

public class ChatSession
{
	[CompilerGenerated]
	private Guid GDSgQP5jjD6;

	[CompilerGenerated]
	private string I0BgQEhnQaJ;

	[CompilerGenerated]
	private DateTime JBtgQy80Wqi = DateTime.Now;

	[CompilerGenerated]
	private DateTime h0GgQ8J5ZdM;

	[CompilerGenerated]
	private int lm6gQaVIW0P;

	[CompilerGenerated]
	private List<ChatMessage> g1OgQ7CKang = new List<ChatMessage>();

	private static ChatSession vksJhYQzQk7HWSTUtyhP;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return GDSgQP5jjD6;
		}
		[CompilerGenerated]
		set
		{
			GDSgQP5jjD6 = value;
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return I0BgQEhnQaJ;
		}
		[CompilerGenerated]
		set
		{
			I0BgQEhnQaJ = value;
		}
	}

	public DateTime CreateTime
	{
		[CompilerGenerated]
		get
		{
			return JBtgQy80Wqi;
		}
		[CompilerGenerated]
		set
		{
			JBtgQy80Wqi = value;
		}
	}

	public DateTime LastMessageTime
	{
		[CompilerGenerated]
		get
		{
			return h0GgQ8J5ZdM;
		}
		[CompilerGenerated]
		set
		{
			h0GgQ8J5ZdM = value;
		}
	}

	public int SendMessageCount
	{
		[CompilerGenerated]
		get
		{
			return lm6gQaVIW0P;
		}
		[CompilerGenerated]
		set
		{
			lm6gQaVIW0P = value;
		}
	}

	public List<ChatMessage> Messages
	{
		[CompilerGenerated]
		get
		{
			return g1OgQ7CKang;
		}
		[CompilerGenerated]
		set
		{
			g1OgQ7CKang = value;
		}
	}

	internal static bool fI9jUaQzFNKoKtP48l0M()
	{
		return vksJhYQzQk7HWSTUtyhP == null;
	}
}
