using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class AppCommandMessage : TinyMessageBase
{
	[CompilerGenerated]
	private AppCommand tr3thDXi2uo;

	[CompilerGenerated]
	private string c22thdQhgs5;

	internal static AppCommandMessage yPrwBNQv9UImcL1sanQs;

	public AppCommand Command
	{
		[CompilerGenerated]
		get
		{
			return tr3thDXi2uo;
		}
		[CompilerGenerated]
		set
		{
			tr3thDXi2uo = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return c22thdQhgs5;
		}
		[CompilerGenerated]
		set
		{
			c22thdQhgs5 = value;
		}
	}

	public AppCommandMessage(object sender, AppCommand command, string data)
		: base(sender)
	{
		Command = command;
		Data = data;
	}

	static AppCommandMessage()
	{
	}

	internal static bool h2clnrQvLdr036JtuQWd()
	{
		return yPrwBNQv9UImcL1sanQs == null;
	}

	internal static void LwWpQvQvoURbhUsikuq9()
	{
	}
}
