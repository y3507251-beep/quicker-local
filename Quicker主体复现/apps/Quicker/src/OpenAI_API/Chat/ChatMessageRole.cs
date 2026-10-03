using System;
using System.Runtime.CompilerServices;

namespace OpenAI_API.Chat;

public class ChatMessageRole : IEquatable<ChatMessageRole>
{
	[CompilerGenerated]
	private readonly string PYlVZia0kf;

	[CompilerGenerated]
	private static readonly ChatMessageRole MJBV9ZaiJ5;

	[CompilerGenerated]
	private static readonly ChatMessageRole RQMVhWxe9X;

	[CompilerGenerated]
	private static readonly ChatMessageRole Ob0VedCpm4;

	internal static ChatMessageRole ujQUQnaI6HKME55yrqh;

	private string Value
	{
		[CompilerGenerated]
		get
		{
			return PYlVZia0kf;
		}
	}

	public static ChatMessageRole System
	{
		[CompilerGenerated]
		get
		{
			return MJBV9ZaiJ5;
		}
	}

	public static ChatMessageRole User
	{
		[CompilerGenerated]
		get
		{
			return RQMVhWxe9X;
		}
	}

	public static ChatMessageRole Assistant
	{
		[CompilerGenerated]
		get
		{
			return Ob0VedCpm4;
		}
	}

	private ChatMessageRole(string value)
	{
		PYlVZia0kf = value;
	}

	public static ChatMessageRole FromString(string roleName)
	{
		return roleName switch
		{
			"assistant" => Ob0VedCpm4, 
			"user" => RQMVhWxe9X, 
			"system" => MJBV9ZaiJ5, 
			_ => null, 
		};
	}

	public override string ToString()
	{
		return Value;
	}

	public override bool Equals(object obj)
	{
		return Value.Equals((obj as ChatMessageRole).Value);
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public bool Equals(ChatMessageRole other)
	{
		return Value.Equals(other.Value);
	}

	public static implicit operator string(ChatMessageRole value)
	{
		return value.Value;
	}

	static ChatMessageRole()
	{
		MJBV9ZaiJ5 = new ChatMessageRole("system");
		RQMVhWxe9X = new ChatMessageRole("user");
		Ob0VedCpm4 = new ChatMessageRole("assistant");
	}

	internal static bool k9Aq69a6tajlMovq8bu()
	{
		return ujQUQnaI6HKME55yrqh == null;
	}
}
