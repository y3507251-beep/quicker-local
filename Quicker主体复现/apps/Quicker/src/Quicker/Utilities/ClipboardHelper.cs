using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using gNDpGkYZYbhLdMnAyKv;
using log4net;
using Quicker.Utilities._3rd;

namespace Quicker.Utilities;

public static class ClipboardHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec tqt2wGLoejA;

		public static Func<FileSystemInfo, string> VJw2wsM4Km5;

		private static _003C_003Ec psD88byn70emWO96iMm4;

		static _003C_003Ec()
		{
			tqt2wGLoejA = new _003C_003Ec();
		}

		internal string Xkq2wkk354O(FileSystemInfo x)
		{
			return x.FullName;
		}

		internal static bool mIQTEpyn4dT5pfhokA1W()
		{
			return psD88byn70emWO96iMm4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public string MhT2w1qMK4Z;

		public string XGy2wbl4jVy;

		public Action qGV2w6lvnWs;

		private static _003C_003Ec__DisplayClass12_0 HH4JqLynHaLhm9N8guKy;

		internal void TM02wHW64Q5()
		{
			HtmlClipboardHelper.CopyToClipboard(MhT2w1qMK4Z, XGy2wbl4jVy);
		}

		internal static bool e24DBWynzQS2j3lxCYjG()
		{
			return HH4JqLynHaLhm9N8guKy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public object aUQ2wm1cNgV;

		public bool fPu2wKTN8na;

		public Action rEW2wxgv4pN;

		private static _003C_003Ec__DisplayClass13_0 uecnpnyeQ2KfPi0WXjcj;

		internal void aiL2wXKhXKg()
		{
			System.Windows.Clipboard.SetDataObject(aUQ2wm1cNgV, fPu2wKTN8na);
		}

		internal static bool rLEoHryeFF7NXCNBYJgi()
		{
			return uecnpnyeQ2KfPi0WXjcj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public bool dKi2wpUNpVH;

		public StringCollection fJp2wBCPAP3;

		public System.Windows.DragDropEffects fCr2wQLd68F;

		public Action mQy2wj6MLR6;

		internal static _003C_003Ec__DisplayClass24_0 V241v0yeWTjv15qgSanj;

		internal void BaT2wrppDHu()
		{
			if (!dKi2wpUNpVH)
			{
				System.Windows.Forms.Clipboard.SetFileDropList(fJp2wBCPAP3);
				return;
			}
			System.Windows.DataObject dataObject = new System.Windows.DataObject();
			dataObject.SetFileDropList(fJp2wBCPAP3);
			dataObject.SetData("Preferred Dropeffect", new MemoryStream(BitConverter.GetBytes((int)fCr2wQLd68F)));
			System.Windows.Clipboard.SetDataObject(dataObject);
		}

		internal static bool Syo4u7yey33hr0TMIbm0()
		{
			return V241v0yeWTjv15qgSanj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public System.Windows.DataObject Twf2w4ViDrH;

		internal static _003C_003Ec__DisplayClass26_0 o51FkDye2NxiL0Qru5ys;

		internal void Qvq2wnBM69K()
		{
			System.Windows.Clipboard.SetDataObject(Twf2w4ViDrH);
		}

		internal static bool xQL9vSyeAVnWrarmA42b()
		{
			return o51FkDye2NxiL0Qru5ys == null;
		}
	}

	private static readonly ILog mv4LTwh6SGa;

	internal static object tsQ6MmFYldj6ogRsIBig;

	public static string TryGetClipboardText(System.Windows.TextDataFormat format = System.Windows.TextDataFormat.UnicodeText)
	{
		try
		{
			return kWsP1bYRVsfaicfjr67.pSTL51fVKXT(format);
		}
		catch (Exception ex)
		{
			LogHoldingClipboardProcess();
			mv4LTwh6SGa.Info("获取剪贴板文本失败：" + ex.Message, ex);
			return string.Empty;
		}
	}

	public static void LogHoldingClipboardProcess()
	{
		try
		{
			Process process = ProcessHoldingClipboard();
			if (process == null)
			{
				mv4LTwh6SGa.Warn("剪贴板被锁定，而且没有获得进程信息。 ");
			}
			else
			{
				mv4LTwh6SGa.Warn($"剪贴板被锁定：pid:{process.Id} " + process.ProcessName);
			}
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Warn("获取剪贴板锁定进程失败 " + ex.Message);
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow")]
	private static extern IntPtr tAQLo3VKMTE();

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	private static extern uint tybLofI23lx(IntPtr intptr_0, out uint uint_0);

	public static Process ProcessHoldingClipboard()
	{
		Process result = null;
		IntPtr intPtr = tAQLo3VKMTE();
		if (intPtr != IntPtr.Zero)
		{
			if (!ctwhfNFYZD24HTZr3w79())
			{
				switch (0)
				{
				}
			}
			tybLofI23lx(intPtr, out var uint_);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowHandle == intPtr)
				{
					result = process;
				}
				else if (uint_ == process.Id)
				{
					result = process;
				}
			}
		}
		return result;
	}

	public static bool IsClipboardHasIconFile()
	{
		try
		{
			if (!kWsP1bYRVsfaicfjr67.A6vL5VlPSBT())
			{
				return false;
			}
			StringCollection stringCollection = kWsP1bYRVsfaicfjr67.yrAL5GvMK5S();
			if (stringCollection.Count > 1)
			{
				return false;
			}
			return AppHelper.IsValidIconFile(stringCollection[0]);
		}
		catch
		{
			return false;
		}
	}

	public static bool IsClipboardHasIconUrl()
	{
		bool result;
		try
		{
			if (!kWsP1bYRVsfaicfjr67.UcRL59pCHNZ())
			{
				result = false;
			}
			else
			{
				string text = kWsP1bYRVsfaicfjr67.n78L5HxDVZd();
				if ((!string.IsNullOrEmpty(text) && (text.StartsWith("https://deskpad.oss-cn-shanghai.aliyuncs.com/_icons/", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://files.getquicker.net/_icons/", StringComparison.OrdinalIgnoreCase))) || text.StartsWith("fa:"))
				{
					result = true;
				}
				else
				{
					result = false;
					if (!ctwhfNFYZD24HTZr3w79())
					{
						switch (0)
						{
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Info("检查剪贴板有无图标网址失败：" + ex.Message, ex);
			result = false;
		}
		return result;
	}

	public static bool SetImage(BitmapSource image, bool throwException)
	{
		try
		{
			ImageClipboardHelper.SetImage(AppHelper.ImageWpfToGDI(image));
			return true;
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Info("复制图片到剪贴板出错，剪贴板可能被占用了。" + ex.Message, ex);
			if (throwException)
			{
				throw;
			}
		}
		return false;
	}

	public static bool SetImage(Image img)
	{
		if (img == null)
		{
			throw new InvalidDataException("要写入到剪贴板的图片为空。");
		}
		kWsP1bYRVsfaicfjr67.P2nL5xQT1T2(img);
		return true;
	}

	public static bool SetText(string text, bool? hideHistory = null)
	{
		if (string.IsNullOrEmpty(text))
		{
			AppHelper.ShowWarning("要写入剪贴板的内容为空。");
			return false;
		}
		bool valueOrDefault = hideHistory == true;
		try
		{
			if (valueOrDefault)
			{
				try
				{
					System.Windows.DataObject dataObject = new System.Windows.DataObject();
					dataObject.SetText(text);
					dataObject.SetData("ExcludeClipboardContentFromMonitorProcessing", "-");
					kWsP1bYRVsfaicfjr67.SjNL56IGE3Y(dataObject);
				}
				catch (Exception ex)
				{
					mv4LTwh6SGa.Warn("写入剪贴板内容出错：" + ex.Message);
					AppHelper.ShowWarning("写入剪贴板出错：" + ex.Message);
				}
			}
			else
			{
				kWsP1bYRVsfaicfjr67.RsqL5rdQFty(text);
			}
			return true;
		}
		catch (Exception)
		{
			LogHoldingClipboardProcess();
		}
		mv4LTwh6SGa.Error("写入剪贴板失败，剪贴板可能被占用了。");
		return false;
	}

	public static bool SetHtml(string html, string text)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.MhT2w1qMK4Z = html;
		int num = 0;
		if (tsQ6MmFYldj6ogRsIBig != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			_003C_003Ec__DisplayClass12_.XGy2wbl4jVy = text;
			for (int i = 0; i < 10; i++)
			{
				try
				{
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass12_.qGV2w6lvnWs ?? (_003C_003Ec__DisplayClass12_.qGV2w6lvnWs = _003C_003Ec__DisplayClass12_.TM02wHW64Q5));
					return true;
				}
				catch
				{
				}
				Thread.Sleep(20);
			}
			return false;
		}
		}
	}

	public static bool SetDataObject(object data, bool copy)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.aUQ2wm1cNgV = data;
		int num = 0;
		if (!ctwhfNFYZD24HTZr3w79())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			_003C_003Ec__DisplayClass13_.fPu2wKTN8na = copy;
			for (int i = 0; i < 10; i++)
			{
				try
				{
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass13_.rEW2wxgv4pN ?? (_003C_003Ec__DisplayClass13_.rEW2wxgv4pN = _003C_003Ec__DisplayClass13_.aiL2wXKhXKg));
					return true;
				}
				catch
				{
				}
				Thread.Sleep(50);
			}
			mv4LTwh6SGa.Info("写入剪贴板失败，剪贴板可能被占用了。");
			return false;
		}
		}
	}

	public static BitmapSource GetImage()
	{
		for (int i = 0; i < 10; i++)
		{
			try
			{
				BitmapSource image = System.Windows.Clipboard.GetImage();
				if (image is InteropBitmap)
				{
					BitmapImage bitmapImage = IconHelper.ImageToImageSource(System.Windows.Forms.Clipboard.GetImage());
					if (bitmapImage.CanFreeze)
					{
						bitmapImage.Freeze();
					}
					return bitmapImage;
				}
				return image;
			}
			catch
			{
			}
			Thread.Sleep(30);
		}
		mv4LTwh6SGa.Warn("获取剪贴板图片失败。");
		return null;
	}

	public static bool ContainsFileDropList()
	{
		return kWsP1bYRVsfaicfjr67.A6vL5VlPSBT();
	}

	public static StringCollection GetFileDropList()
	{
		try
		{
			return kWsP1bYRVsfaicfjr67.yrAL5GvMK5S();
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Warn("获取剪贴板文件列表失败：" + ex.Message);
		}
		return new StringCollection();
	}

	internal static void E5uLoz3712g(string string_0, System.Windows.Forms.TextDataFormat textDataFormat_0)
	{
		kWsP1bYRVsfaicfjr67.SveL5pC3Cij(string_0, textDataFormat_0);
	}

	public static bool ContainsImage()
	{
		return kWsP1bYRVsfaicfjr67.sVUL5ZT60dm();
	}

	public static bool SetData(string format, object data)
	{
		try
		{
			kWsP1bYRVsfaicfjr67.F12L5bNlTL1(format, data);
			return true;
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Warn("写入剪贴板出错： " + ex.Message);
		}
		return false;
	}

	public static bool ContainsData(string format)
	{
		return kWsP1bYRVsfaicfjr67.fxRL5cZYrUS(format);
	}

	public static object GetData(string format)
	{
		try
		{
			return kWsP1bYRVsfaicfjr67.rjwL5IECtxV(format);
		}
		catch (Exception ex)
		{
			mv4LTwh6SGa.Warn("获取剪贴板内容失败：" + ex.Message);
		}
		return null;
	}

	public static bool SetFile(string path, bool moveFilesOnPaste = false)
	{
		StringCollection stringCollection = new StringCollection { path };
		System.Windows.DragDropEffects value = ((!moveFilesOnPaste) ? System.Windows.DragDropEffects.Copy : System.Windows.DragDropEffects.Move);
		try
		{
			if (!moveFilesOnPaste)
			{
				kWsP1bYRVsfaicfjr67.jLxL5KAxPKn(stringCollection);
			}
			else
			{
				System.Windows.DataObject dataObject = new System.Windows.DataObject();
				dataObject.SetFileDropList(stringCollection);
				dataObject.SetData("Preferred Dropeffect", new MemoryStream(BitConverter.GetBytes((int)value)));
				kWsP1bYRVsfaicfjr67.SjNL56IGE3Y(dataObject);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static void PutFilesOnClipboard(this IEnumerable<FileSystemInfo> filesAndFolders, bool moveFilesOnPaste = false)
	{
		System.Windows.DragDropEffects value = ((!moveFilesOnPaste) ? System.Windows.DragDropEffects.Copy : System.Windows.DragDropEffects.Move);
		StringCollection stringCollection = new StringCollection();
		stringCollection.AddRange(filesAndFolders.Select(_003C_003Ec.VJw2wsM4Km5 ?? (_003C_003Ec.VJw2wsM4Km5 = _003C_003Ec.tqt2wGLoejA.Xkq2wkk354O)).ToArray());
		System.Windows.DataObject dataObject = new System.Windows.DataObject();
		dataObject.SetFileDropList(stringCollection);
		dataObject.SetData("Preferred Dropeffect", new MemoryStream(BitConverter.GetBytes((int)value)));
		System.Windows.Clipboard.SetDataObject(dataObject);
	}

	public static bool SetFile(IList<string> fileList, bool moveFilesOnPaste = false)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.dKi2wpUNpVH = moveFilesOnPaste;
		if (fileList.Count == 0)
		{
			return false;
		}
		_003C_003Ec__DisplayClass24_.fCr2wQLd68F = ((!_003C_003Ec__DisplayClass24_.dKi2wpUNpVH) ? System.Windows.DragDropEffects.Copy : System.Windows.DragDropEffects.Move);
		_003C_003Ec__DisplayClass24_.fJp2wBCPAP3 = new StringCollection();
		_003C_003Ec__DisplayClass24_.fJp2wBCPAP3.AddRange(fileList.ToArray());
		for (int i = 0; i < 10; i++)
		{
			try
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass24_.mQy2wj6MLR6 ?? (_003C_003Ec__DisplayClass24_.mQy2wj6MLR6 = _003C_003Ec__DisplayClass24_.BaT2wrppDHu));
				return true;
			}
			catch
			{
			}
			Thread.Sleep(20);
		}
		return false;
	}

	public static void Clear()
	{
		try
		{
			kWsP1bYRVsfaicfjr67.cVVL5R4yN4X();
		}
		catch (Exception)
		{
			LogHoldingClipboardProcess();
		}
	}

	public static void SetMultipleData(IDictionary<string, object> data)
	{
		try
		{
			_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
			_003C_003Ec__DisplayClass26_.Twf2w4ViDrH = new System.Windows.DataObject();
			foreach (KeyValuePair<string, object> datum in data)
			{
				_003C_003Ec__DisplayClass26_.Twf2w4ViDrH.SetData(datum.Key, datum.Value);
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass26_.Qvq2wnBM69K);
		}
		catch (Exception)
		{
			LogHoldingClipboardProcess();
		}
	}

	public static string GetClipboardUrl()
	{
		string result = "";
		string text = kWsP1bYRVsfaicfjr67.pSTL51fVKXT(System.Windows.TextDataFormat.Html);
		if (!string.IsNullOrEmpty(text))
		{
			using StringReader stringReader = new StringReader(text);
			string text2;
			while ((text2 = stringReader.ReadLine()) != null)
			{
				if (!text2.StartsWith("SourceURL:"))
				{
					if (text2.StartsWith("<html>", StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					continue;
				}
				result = text2.Substring(10);
				break;
			}
		}
		return result;
	}

	static ClipboardHelper()
	{
		mv4LTwh6SGa = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool ctwhfNFYZD24HTZr3w79()
	{
		return tsQ6MmFYldj6ogRsIBig == null;
	}
}
