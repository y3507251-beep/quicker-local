using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace SnipInsight.ImageCapture;

public class ImageCaptureManager : IDisposable, IImageCaptureManager
{
	private ImageCaptureWindow ad4gb9IY9c;

	private ImageCaptureCursor c76g6wIaPk;

	private readonly AreaSelection fpYgXPpWNc;

	private bool TqYgmJBAb5;

	[CompilerGenerated]
	private EventHandler<ImageCaptureEventArgs> vkIgKnfGmQ;

	internal static ImageCaptureManager sQNQpaylAXAg61fbMcL;

	public event EventHandler<ImageCaptureEventArgs> CaptureCompleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ImageCaptureEventArgs> eventHandler = vkIgKnfGmQ;
			EventHandler<ImageCaptureEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ImageCaptureEventArgs> value2 = (EventHandler<ImageCaptureEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vkIgKnfGmQ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ImageCaptureEventArgs> eventHandler = vkIgKnfGmQ;
			EventHandler<ImageCaptureEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ImageCaptureEventArgs> value2 = (EventHandler<ImageCaptureEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vkIgKnfGmQ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ImageCaptureManager()
	{
		fpYgXPpWNc = new AreaSelection();
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (ad4gb9IY9c != null)
			{
				ad4gb9IY9c.Close();
				ad4gb9IY9c = null;
			}
			if (c76g6wIaPk != null)
			{
				c76g6wIaPk.Dispose();
				c76g6wIaPk = null;
			}
		}
	}

	~ImageCaptureManager()
	{
		Dispose(false);
	}

	public void StartCapture()
	{
		Rectangle desktopBounds = SmartBoundaryDetection.GetDesktopBounds();
		c76g6wIaPk = new ImageCaptureCursor();
		int num = 0;
		if (!qjX3CQyZsItOl7dYTNG())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Cursor cursor = c76g6wIaPk.GetCursor();
		ad4gb9IY9c = new ImageCaptureWindow(desktopBounds, fpYgXPpWNc);
		ad4gb9IY9c.Cursor = cursor;
		ad4gb9IY9c.NotifyCapturingDone += BHHgHOnWi9;
		ad4gb9IY9c.NotifyCapturingCancel += yhTg1sTkOJ;
		ad4gb9IY9c.Show();
		ad4gb9IY9c.Activate();
	}

	public void CapturingDone()
	{
		ad4gb9IY9c.uObg5GhLIV(ad4gb9IY9c, null);
	}

	public void CapturingCancel()
	{
		ad4gb9IY9c.l3mgDi1BMc(ad4gb9IY9c, null);
	}

	private void BHHgHOnWi9(object sender, EventArgs e)
	{
		if (ad4gb9IY9c != null)
		{
			ad4gb9IY9c.Close();
			ad4gb9IY9c = null;
		}
		vkIgKnfGmQ?.Invoke(this, (ImageCaptureEventArgs)e);
	}

	private void yhTg1sTkOJ(object sender, EventArgs e)
	{
		if (ad4gb9IY9c != null)
		{
			ad4gb9IY9c.Close();
			ad4gb9IY9c = null;
		}
		vkIgKnfGmQ?.Invoke(this, new ImageCaptureEventArgs(null, Rectangle.Empty));
	}

	internal static bool qjX3CQyZsItOl7dYTNG()
	{
		return sQNQpaylAXAg61fbMcL == null;
	}
}
