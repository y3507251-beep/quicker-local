using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SnipInsight.ImageCapture;

public class ImageCaptureEventArgs : EventArgs
{
	[CompilerGenerated]
	private Bitmap SRIgILx4w0;

	[CompilerGenerated]
	private Rectangle jcJgW29CVi;

	internal static ImageCaptureEventArgs ABvxESyOBgKJahdVqxU;

	public Bitmap Image
	{
		[CompilerGenerated]
		get
		{
			return SRIgILx4w0;
		}
		[CompilerGenerated]
		private set
		{
			SRIgILx4w0 = value;
		}
	}

	public Rectangle Rect
	{
		[CompilerGenerated]
		get
		{
			return jcJgW29CVi;
		}
		[CompilerGenerated]
		private set
		{
			jcJgW29CVi = value;
		}
	}

	public ImageCaptureEventArgs(Bitmap image, Rectangle rect)
	{
		Image = image;
		Rect = rect;
	}

	static ImageCaptureEventArgs()
	{
	}

	internal static bool KTjsFZyJg25KlVQZuEX()
	{
		return ABvxESyOBgKJahdVqxU == null;
	}

	internal static void JB4wM4yakOKIYVCI9eY()
	{
	}
}
