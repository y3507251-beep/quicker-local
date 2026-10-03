using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using O5blBdM6bCRI1gbI3U2;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Modules.Images;
using Quicker.Utilities;
using yyXIB9Yxgd6ACb7T4ig;

namespace jUHfG42nmbml7b5l5N7;

internal static class JZry4r2NiosU3b6650j
{
	internal class G6xaNXuNoIvdUuVSmAb
	{
		[CompilerGenerated]
		private readonly gu1E6xunl3Kn9EPKXTs eYRv6BTuBWe;

		[CompilerGenerated]
		private readonly ImageSource qxcv6QgVGm2;

		private static G6xaNXuNoIvdUuVSmAb LQ3XjicIWDuNkvywhL5Y;

		public ImageSource ImageSource
		{
			[CompilerGenerated]
			get
			{
				return qxcv6QgVGm2;
			}
		}

		public G6xaNXuNoIvdUuVSmAb(ImageSource imageSource_1, gu1E6xunl3Kn9EPKXTs gu1E6xunl3Kn9EPKXTs_1)
		{
			qxcv6QgVGm2 = imageSource_1;
			eYRv6BTuBWe = gu1E6xunl3Kn9EPKXTs_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public gu1E6xunl3Kn9EPKXTs tk6v6xOeKaG()
		{
			return eYRv6BTuBWe;
		}

		internal static bool pUsDCkcIySA4CJ5U0KdM()
		{
			return LQ3XjicIWDuNkvywhL5Y == null;
		}
	}

	internal enum gu1E6xunl3Kn9EPKXTs
	{
		Data = 2
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public string Dadv6nJaPfW;

		public bool l78v64gmjKm;

		private static _003C_003Ec__DisplayClass9_0 uCOqvocInPHoSAFwZFrD;

		internal G6xaNXuNoIvdUuVSmAb UOEv6jqJecb()
		{
			return eQytyapifUr(ref Dadv6nJaPfW, l78v64gmjKm);
		}

		internal static bool xvAni3cIe7Mp8BO55son()
		{
			return uCOqvocInPHoSAFwZFrD == null;
		}
	}




	private static readonly ILog Sybtyqx5vXT;

	private static readonly IconImageCache AmHtyc8jqFv;

	private static readonly string[] QBXtyVXfRSO;

	private static object FREvBUQ3AcPlJaPApPbu;

	[Obsolete("请使用异步接口")]
	public static ImageSource Load(string path, bool loadFullImage = false)
	{
		G6xaNXuNoIvdUuVSmAb g6xaNXuNoIvdUuVSmAb = JGMtyEj8UtJ(path, loadFullImage);
		if (g6xaNXuNoIvdUuVSmAb != null && g6xaNXuNoIvdUuVSmAb.ImageSource != null)
		{
			ImageSource imageSource = g6xaNXuNoIvdUuVSmAb.ImageSource;
			if (g6xaNXuNoIvdUuVSmAb.tk6v6xOeKaG() != (gu1E6xunl3Kn9EPKXTs)5 && g6xaNXuNoIvdUuVSmAb.tk6v6xOeKaG() != (gu1E6xunl3Kn9EPKXTs)6 && !loadFullImage)
			{
				AmHtyc8jqFv[path] = imageSource;
			}
			return imageSource;
		}
		return null;
	}

	public static async ValueTask<ImageSource> LoKtyPkWI7s(string string_1, bool bool_0 = false)
	{
		var result = await hnptyyBZ0wG(string_1, bool_0).ConfigureAwait(false);
		return result?.ImageSource;
	}

	private static G6xaNXuNoIvdUuVSmAb JGMtyEj8UtJ(string string_1, bool bool_0 = false)
	{
		gu1E6xunl3Kn9EPKXTs gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)5;
		ImageSource image;
		try
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return null;
			}
			int num2 = default(int);
			while (true)
			{
				if (!AmHtyc8jqFv.TryGetImage(string_1, out image))
				{
					int num;
					if (!string_1.StartsWith("::") && !Directory.Exists(string_1))
					{
						if (!File.Exists(string_1) && !string_1.StartsWith("shell:", StringComparison.OrdinalIgnoreCase))
						{
							return null;
						}
						string value = Path.GetExtension(string_1).ToLower(CultureInfo.InvariantCulture);
						if (!QBXtyVXfRSO.Contains(value))
						{
							gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)0;
							image = WindowsThumbnailProvider.GetThumbnail(string_1, 64, 64, ThumbnailOptions.None);
							break;
						}
						gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)3;
						if (!bool_0)
						{
							image = WindowsThumbnailProvider.GetThumbnail(string_1, 64, 64, ThumbnailOptions.ThumbnailOnly);
							break;
						}
						image = NeTtyRrbGkP(string_1);
						num = 2;
						if (FREvBUQ3AcPlJaPApPbu != null)
						{
							num = num2;
						}
					}
					else
					{
						gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)1;
						image = WindowsThumbnailProvider.GetThumbnail(string_1, 64, 64, ThumbnailOptions.IconOnly);
						num = 1;
						if (!m8nT1VQ3naGt5KhQ9fKH())
						{
							continue;
						}
					}
					switch (num)
					{
					default:
						continue;
					case 1:
					case 2:
						break;
					}
					break;
				}
				return new G6xaNXuNoIvdUuVSmAb(image, (gu1E6xunl3Kn9EPKXTs)6);
			}
			if (gu1E6xunl3Kn9EPKXTs != (gu1E6xunl3Kn9EPKXTs)5)
			{
				image?.Freeze();
			}
		}
		catch (Exception ex)
		{
			Sybtyqx5vXT.Warn("Failed to get thumbnail for " + string_1 + " " + ex.Message, ex);
			return null;
		}
		return new G6xaNXuNoIvdUuVSmAb(image, gu1E6xunl3Kn9EPKXTs);
	}

	private static async ValueTask<G6xaNXuNoIvdUuVSmAb> hnptyyBZ0wG(string string_1, bool bool_0 = false)
	{
		if (string.IsNullOrWhiteSpace(string_1)) return null;
		if (AmHtyc8jqFv.TryGetImage(string_1, out var cached))
		    return new G6xaNXuNoIvdUuVSmAb(cached, (gu1E6xunl3Kn9EPKXTs)6);
		string path = string_1;
		ImageSource image = null;
		if (Uri.TryCreate(path, UriKind.Absolute, out var uri) && (uri.Scheme == "http" || uri.Scheme == "https"))
		{
		    // 旧网址仅作为缓存键，不再下载面板资源。
		    path = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(path);
		    image = ImageCache.CreateBitmapImageFromLocalFile(path, bool_0 ? (int?)null : 64);
		}
		else if (path.StartsWith("data:", StringComparison.OrdinalIgnoreCase))
		    image = ImageCache.CreateImageFromBase64(path);
		else
		{
		    if (path.LastIndexOf('!') > path.LastIndexOf('.'))
		    {
		        var appIcon = iah68iMf4KvhT7ULCsJ.DpvLoo2xNQd(path.StartsWith("shell:AppsFolder\\", StringComparison.OrdinalIgnoreCase) ? path.Substring("shell:AppsFolder\\".Length) : path);
		        if (!string.IsNullOrEmpty(appIcon)) path = appIcon;
		    }
		    var result = await Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().GNGtkLxOIk7(() => eQytyapifUr(ref path, bool_0)).ConfigureAwait(false);
		    image = result?.ImageSource;
		}
		if (image != null && !bool_0) AmHtyc8jqFv[string_1] = image;
		return new G6xaNXuNoIvdUuVSmAb(image, (gu1E6xunl3Kn9EPKXTs)3);
	}


	private static G6xaNXuNoIvdUuVSmAb eQytyapifUr(ref string string_1, bool bool_0 = false)
	{
		gu1E6xunl3Kn9EPKXTs gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)5;
		ImageSource imageSource;
		if (!string_1.StartsWith("::") && !string_1.StartsWith("shell:", StringComparison.OrdinalIgnoreCase) && !Directory.Exists(string_1))
		{
			if (!string_1.StartsWith("shell:", StringComparison.OrdinalIgnoreCase) && !File.Exists(string_1))
			{
				return null;
			}
			string value = Path.GetExtension(string_1).ToLower();
			if (QBXtyVXfRSO.Contains(value))
			{
				gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)3;
				if (bool_0)
				{
					imageSource = NeTtyRrbGkP(string_1);
					gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)4;
					int num = 0;
					if (FREvBUQ3AcPlJaPApPbu != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 1:
						goto IL_00de;
					}
				}
				else
				{
					imageSource = DGJty7egqBw(string_1);
				}
			}
			else
			{
				gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)0;
				imageSource = DGJty7egqBw(string_1, ThumbnailOptions.None);
			}
		}
		else
		{
			gu1E6xunl3Kn9EPKXTs = (gu1E6xunl3Kn9EPKXTs)1;
			imageSource = DGJty7egqBw(string_1, ThumbnailOptions.IconOnly);
		}
		if (imageSource == null || !imageSource.CanFreeze)
		{
			goto IL_00de;
		}
		imageSource.Freeze();
		goto IL_00f4;
		IL_00f4:
		return new G6xaNXuNoIvdUuVSmAb(imageSource, gu1E6xunl3Kn9EPKXTs);
		IL_00de:
		Sybtyqx5vXT.Warn("获取文件图标为null：" + string_1);
		goto IL_00f4;
	}

	private static BitmapSource DGJty7egqBw(string string_1, ThumbnailOptions thumbnailOptions_0 = ThumbnailOptions.ThumbnailOnly, int int_0 = 64)
	{
		return WindowsThumbnailProvider.GetThumbnail(string_1, int_0, int_0, thumbnailOptions_0);
	}

	private static BitmapImage NeTtyRrbGkP(string string_1)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
		bitmapImage.UriSource = new Uri(string_1);
		bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
		bitmapImage.EndInit();
		if (bitmapImage.PixelWidth > 320)
		{
			BitmapImage bitmapImage2 = new BitmapImage();
			bitmapImage2.BeginInit();
			bitmapImage2.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage2.UriSource = new Uri(string_1);
			bitmapImage2.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
			bitmapImage2.DecodePixelWidth = 320;
			bitmapImage2.EndInit();
			if (bitmapImage2.PixelHeight <= 320)
			{
				if (m8nT1VQ3naGt5KhQ9fKH())
				{
					switch (0)
					{
					}
				}
				return bitmapImage2;
			}
			BitmapImage bitmapImage3 = new BitmapImage();
			bitmapImage3.BeginInit();
			bitmapImage3.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage3.UriSource = new Uri(string_1);
			bitmapImage3.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
			bitmapImage3.DecodePixelHeight = 320;
			bitmapImage3.EndInit();
			return bitmapImage3;
		}
		return bitmapImage;
	}

	static JZry4r2NiosU3b6650j()
	{
		Sybtyqx5vXT = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		AmHtyc8jqFv = new IconImageCache();
		QBXtyVXfRSO = new string[7] { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".tiff", ".ico" };
	}

	internal static bool m8nT1VQ3naGt5KhQ9fKH()
	{
		return FREvBUQ3AcPlJaPApPbu == null;
	}
}
