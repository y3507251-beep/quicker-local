using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace Quicker.Modules.TextTools;

public abstract class BaseTextTool
{
	[CompilerGenerated]
	private TextToolContext bCOtvcshe8d;

	[CompilerGenerated]
	private CancellationToken? HhEtvVJ159v;

	[CompilerGenerated]
	private bool o4RtvZ7CcLb;

	internal static BaseTextTool PX6GssQygOGBIdTn4PIB;

	public TextToolContext Context
	{
		[CompilerGenerated]
		get
		{
			return bCOtvcshe8d;
		}
		[CompilerGenerated]
		private set
		{
			bCOtvcshe8d = value;
		}
	}

	public CancellationToken? CancellationToken
	{
		[CompilerGenerated]
		get
		{
			return HhEtvVJ159v;
		}
		[CompilerGenerated]
		set
		{
			HhEtvVJ159v = value;
		}
	}

	public bool ForStepUse
	{
		[CompilerGenerated]
		get
		{
			return o4RtvZ7CcLb;
		}
		[CompilerGenerated]
		set
		{
			o4RtvZ7CcLb = value;
		}
	}

	protected BaseTextTool(TextToolContext context)
	{
		Context = context;
	}

	public virtual void OnMouseDown(object sender)
	{
	}

	public virtual void OnMouseUp(object sender)
	{
	}

	public virtual void OnMouseMove(object sender, MouseEventArgs e)
	{
	}

	public virtual void OnUnload()
	{
	}

	public void CancelSelection(string message = "")
	{
		Context.SelectionCanceledFunc?.Invoke();
	}

	internal static bool AYSfVnQyPBmra4wTJIqD()
	{
		return PX6GssQygOGBIdTn4PIB == null;
	}
}
