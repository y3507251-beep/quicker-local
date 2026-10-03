using System;

namespace SnipInsight.ImageCapture;

public interface IImageCaptureManager
{
	event EventHandler<ImageCaptureEventArgs> CaptureCompleted;

	void StartCapture();

	void CapturingDone();

	void CapturingCancel();
}
