using System;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using jUHfG42nmbml7b5l5N7;
using log4net;
using Quicker.Annotations;
using Quicker.Utilities.Ext;
using whX2OqiF8ktmGdctWNN;
using yyXIB9Yxgd6ACb7T4ig;

namespace Quicker.Utilities;

public static class ImageCache
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static EventHandler<ExceptionEventArgs> tfk2gG41hCy;

		public static EventHandler<ExceptionEventArgs> lRg2gsOI9xI;
	}


	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetImageSourceAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageSource> _003C_003Et__builder;

		public string imgUrlOrPath;

		public int? decodePixelWidth;

		private ValueTaskAwaiter<ImageSource> _003C_003Eu__1;

		private static object Y3RNcryDEJ5cPUobeWaD;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ImageSource result = default(ImageSource);
			try
			{
				ValueTaskAwaiter<ImageSource> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<ImageSource>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01a0;
				}
				int num2;
				if (string.IsNullOrWhiteSpace(imgUrlOrPath))
				{
					result = null;
				}
				else
				{
					if (gSkLM43jo8t.FfTvNqMKvXd(imgUrlOrPath, out var gparam_))
					{
						result = gparam_;
						num2 = 1;
						if (Y3RNcryDEJ5cPUobeWaD != null)
						{
							goto IL_006e;
						}
						goto IL_0072;
					}
					if (imgUrlOrPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
					{
						num2 = 2;
						if (!PcZxi8yDG9LZjclwCkiQ())
						{
							goto IL_006e;
						}
						goto IL_0072;
					}
					if (imgUrlOrPath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || imgUrlOrPath.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
					{
						awaiter = JZry4r2NiosU3b6650j.LoKtyPkWI7s(imgUrlOrPath).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01a0;
					}
					BitmapSource bitmapSource = CreateBitmapImageFromLocalFile(imgUrlOrPath, decodePixelWidth);
					if (bitmapSource != null)
					{
						gSkLM43jo8t.aIXvNhlIIfs(imgUrlOrPath, bitmapSource);
					}
					result = bitmapSource;
				}
				goto end_IL_0008;
				IL_0072:
				string text = default(string);
				switch (num2)
				{
				case 1:
					goto end_IL_0008;
				case 2:
				{
					text = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(imgUrlOrPath);
					if (!j53dHOYtcRyb9edAMaZ.tpOL5AcxHf9(text))
					{
						break;
					}
					BitmapSource bitmapSource2 = CreateBitmapImageFromLocalFile(text, decodePixelWidth);
					if (bitmapSource2 != null)
					{
						gSkLM43jo8t.aIXvNhlIIfs(imgUrlOrPath, bitmapSource2);
					}
					result = bitmapSource2;
					goto end_IL_0008;
				}
				}
				result = null;
				goto end_IL_0008;
				IL_01a0:
				result = awaiter.GetResult();
				goto end_IL_0008;
				IL_006e:
				int num3 = default(int);
				num2 = num3;
				goto IL_0072;
				end_IL_0008:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003CGetImageSourceAsync_003Ed__5()
		{
		}

		internal static bool PcZxi8yDG9LZjclwCkiQ()
		{
			return Y3RNcryDEJ5cPUobeWaD == null;
		}

		internal static void LM0eGRyD1Kc38Q9XdoRT()
		{
		}
	}

	private static readonly ILog bQZLMnHnw6y;

	private static readonly VWVOHCiULfdMMMUB3rX<string, BitmapSource> gSkLM43jo8t;

	private static object qpZqLhFRTfUTyUA2SB0q;

	public static BitmapSource TryGetImage(string imgUrl)
	{
		return gSkLM43jo8t.nCwvN99a8pK(imgUrl);
	}

	public static ImageSource GetImageSource([NotNull] Action<ImageSource, string> callBackOnUiThread, [NotNull] string imgUrlOrPath, int? decodePixelWidth = null)
	{
		if (string.IsNullOrWhiteSpace(imgUrlOrPath))
		{
			return null;
		}
		if (gSkLM43jo8t.FfTvNqMKvXd(imgUrlOrPath, out var gparam_))
		{
			return gparam_;
		}
		if (imgUrlOrPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			string text = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(imgUrlOrPath);
			if (j53dHOYtcRyb9edAMaZ.tpOL5AcxHf9(text))
			{
				BitmapSource bitmapSource = CreateBitmapImageFromLocalFile(text, decodePixelWidth);
				if (bitmapSource != null)
				{
					gSkLM43jo8t.aIXvNhlIIfs(imgUrlOrPath, bitmapSource);
				}
				return bitmapSource;
			}
			return null;
		}
		if (!imgUrlOrPath.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) && !imgUrlOrPath.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
		{
			BitmapSource bitmapSource2 = CreateBitmapImageFromLocalFile(imgUrlOrPath, decodePixelWidth);
			if (bitmapSource2 != null)
			{
				gSkLM43jo8t.aIXvNhlIIfs(imgUrlOrPath, bitmapSource2);
			}
			return bitmapSource2;
		}
		return JZry4r2NiosU3b6650j.Load(imgUrlOrPath);
	}

	public static BitmapSource GetImageSource(string imgUrl, int? decodePixelWidth = null)
	{
		if (string.IsNullOrEmpty(imgUrl))
		{
			return null;
		}
		if (gSkLM43jo8t.FfTvNqMKvXd(imgUrl, out var gparam_))
		{
			return gparam_;
		}
		if (!imgUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			try
			{
				BitmapSource bitmapSource = CreateBitmapImageFromLocalFileOrUrl(imgUrl, decodePixelWidth);
				IXXLMBrwBxO(imgUrl, bitmapSource);
				return bitmapSource;
			}
			catch (Exception ex)
			{
				bQZLMnHnw6y.Warn("加载图标" + imgUrl + "失败。" + ex.Message);
				return null;
			}
		}
		string text = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(imgUrl);
		if (j53dHOYtcRyb9edAMaZ.tpOL5AcxHf9(text))
		{
			BitmapSource bitmapSource2 = null;
			try
			{
				bitmapSource2 = CreateBitmapImageFromLocalFile(text, decodePixelWidth);
				IXXLMBrwBxO(imgUrl, bitmapSource2);
				return bitmapSource2;
			}
			catch (Exception ex2)
			{
				bQZLMnHnw6y.Warn("加载图标" + imgUrl + "失败。" + ex2.Message);
				return bitmapSource2;
			}
		}
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetImageSourceAsync_003Ed__5))]
	public static Task<ImageSource> GetImageSourceAsync([NotNull] string imgUrlOrPath, int? decodePixelWidth = null)
	{
		_003CGetImageSourceAsync_003Ed__5 stateMachine = default(_003CGetImageSourceAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageSource>.Create();
		stateMachine.imgUrlOrPath = imgUrlOrPath;
		stateMachine.decodePixelWidth = decodePixelWidth;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}


	public static BitmapSource CreateBitmapImageFromLocalFile(string filepath, int? decodePixelWidth)
	{
		if (string.IsNullOrEmpty(filepath))
		{
			return null;
		}
		if (filepath.StartsWith("data:"))
		{
			if (filepath.StartsWith("data:image/png"))
			{
				return CreateImageFromBase64(filepath);
			}
			return null;
		}
		if (!File.Exists(filepath))
		{
			bQZLMnHnw6y.Warn("加载图片，文件不存在：" + filepath);
			return null;
		}
		try
		{
			FileStream fileStream = File.OpenRead(filepath);
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.DecodeFailed += _003C_003EO.tfk2gG41hCy ?? (_003C_003EO.tfk2gG41hCy = LF8LMQMXoTT);
			if (decodePixelWidth.HasValue)
			{
				bitmapImage.DecodePixelWidth = decodePixelWidth.Value;
			}
			bitmapImage.StreamSource = fileStream;
			bitmapImage.EndInit();
			bitmapImage.TryFreeze();
			fileStream.Close();
			fileStream.Dispose();
			return bitmapImage;
		}
		catch (Exception ex)
		{
			bQZLMnHnw6y.Warn("加载图片" + filepath + "失败:" + ex.Message);
			return null;
		}
	}

	public static BitmapSource CreateBitmapImageFromLocalFileOrUrl(string filepath, int? decodePixelWidth)
	{
		if (string.IsNullOrEmpty(filepath)) return null;
		if (Uri.TryCreate(filepath, UriKind.Absolute, out var uri) && (uri.Scheme == "http" || uri.Scheme == "https"))
		    filepath = j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(filepath);
		return CreateBitmapImageFromLocalFile(filepath, decodePixelWidth);
	}

	private static void IXXLMBrwBxO(string string_0, BitmapSource bitmapSource_0)
	{
		gSkLM43jo8t.aIXvNhlIIfs(string_0, bitmapSource_0);
	}

	private static void LF8LMQMXoTT(object sender, ExceptionEventArgs e)
	{
		bQZLMnHnw6y.Warn("ImgOnDecodeFailed " + e.ErrorException.Message);
	}

	private static void cLuLMjWbRtQ(object sender, ExceptionEventArgs e)
	{
		bQZLMnHnw6y.Warn("ImgOnDownloadFailed " + e.ErrorException.Message);
	}

	public static BitmapSource CreateImageFromBase64(string base64String)
	{
		using MemoryStream streamSource = new MemoryStream(Convert.FromBase64String(base64String.Split(',')[1]));
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
		bitmapImage.StreamSource = streamSource;
		bitmapImage.EndInit();
		bitmapImage.Freeze();
		return bitmapImage;
	}

	static ImageCache()
	{
		bQZLMnHnw6y = LogManager.GetLogger(typeof(ImageCache));
		gSkLM43jo8t = new VWVOHCiULfdMMMUB3rX<string, BitmapSource>();
	}

	internal static bool Y9dZmiFRmtJhmBBooYpB()
	{
		return qpZqLhFRTfUTyUA2SB0q == null;
	}

	internal static void LdyKxQFR4LtojCqAuDGR()
	{
	}
}
