using System.Runtime.CompilerServices;

namespace Quicker.Utilities._3rd;

public class GenericTinyMessage<TContent> : TinyMessageBase
{
	[CompilerGenerated]
	private TContent txiLzYlGqJ0;

	public TContent Content
	{
		[CompilerGenerated]
		get
		{
			return txiLzYlGqJ0;
		}
		[CompilerGenerated]
		protected set
		{
			txiLzYlGqJ0 = value;
		}
	}

	public GenericTinyMessage(object sender, TContent content)
		: base(sender)
	{
		Content = content;
	}
}
