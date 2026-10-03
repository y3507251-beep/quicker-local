using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace alprRj9melNgp4LYWm;

internal class Edpy6EcmpciOx2fkye
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public TaskCompletionSource<BitmapImage> M3rvPK0hDNS;

		public BitmapImage tAwvPxbLBjJ;

		internal static _003C_003Ec__DisplayClass0_0 oqtxOXcnDo5TwE3D0X9Y;

		internal void r3HvPXy61kF(object sender, EventArgs e)
		{
			M3rvPK0hDNS.TrySetResult(tAwvPxbLBjJ);
		}

		internal void cunvPmTcr2l(object sender, ExceptionEventArgs e)
		{
			M3rvPK0hDNS.TrySetException(e.ErrorException);
		}

		internal static bool FbJodNcn3ADdhNG1YIhP()
		{
			return oqtxOXcnDo5TwE3D0X9Y == null;
		}
	}

	internal static Edpy6EcmpciOx2fkye KOqCP6yxeMw7wEv9dMZ;

	public static Task<BitmapImage> FcrLCVqrIJ(Uri uri_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.M3rvPK0hDNS = new TaskCompletionSource<BitmapImage>();
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ = new BitmapImage();
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.DownloadCompleted += _003C_003Ec__DisplayClass0_.r3HvPXy61kF;
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.DownloadFailed += _003C_003Ec__DisplayClass0_.cunvPmTcr2l;
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.BeginInit();
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.UriSource = uri_0;
		_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.EndInit();
		if (!_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ.IsDownloading)
		{
			_003C_003Ec__DisplayClass0_.M3rvPK0hDNS.TrySetResult(_003C_003Ec__DisplayClass0_.tAwvPxbLBjJ);
		}
		return _003C_003Ec__DisplayClass0_.M3rvPK0hDNS.Task;
	}

	internal static bool Yqyj6wyIHMFlpNHRI5q()
	{
		return KOqCP6yxeMw7wEv9dMZ == null;
	}
}
