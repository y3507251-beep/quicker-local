using System;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities._3rd;

public class CancellableGenericTinyMessage<TContent> : TinyMessageBase
{
	[CompilerGenerated]
	private Action EqYLzIPIWRl;

	[CompilerGenerated]
	private TContent nVqLzWjysal;

	private static object K3nnqDFTwDP1WYkyVM4J;

	public Action Cancel
	{
		[CompilerGenerated]
		get
		{
			return EqYLzIPIWRl;
		}
		[CompilerGenerated]
		protected set
		{
			EqYLzIPIWRl = value;
		}
	}

	public TContent Content
	{
		[CompilerGenerated]
		get
		{
			return nVqLzWjysal;
		}
		[CompilerGenerated]
		protected set
		{
			nVqLzWjysal = value;
		}
	}

	public CancellableGenericTinyMessage(object sender, TContent content, Action cancelAction)
		: base(sender)
	{
		if (cancelAction == null)
		{
			throw new ArgumentNullException("cancelAction");
		}
		Content = content;
		Cancel = cancelAction;
	}

	internal static bool s8EMnAFTTDJT8pVnScWo()
	{
		return K3nnqDFTwDP1WYkyVM4J == null;
	}
}
