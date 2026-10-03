using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using log4net;
using QRCoder;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using ZXing;

namespace Quicker.Domain.Actions.SubPrograms;

public static class OldSubProgramMgr
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<ActionExecuteContext, string, bool> pvevAjyCQUY;

		public static Func<ActionExecuteContext, string, bool> oZovAnq8VX1;

		public static Func<ActionExecuteContext, string, bool> wpovA4rgOpW;

		public static Func<ActionExecuteContext, string, bool> IRMvA5ST0JD;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec b5nvOhphCd8;

		public static Func<string, (bool, string)> Tg9vOeN75Y5;

		public static Func<ActionExecuteContext, string, bool> WSTvOY92jB7;

		public static Func<ActionExecuteContext, string, bool> Iu5vOIXGwIJ;

		public static Func<ActionExecuteContext, string, bool> p6dvOWwZGfk;

		public static Func<ActionExecuteContext, string, bool> nLNvOk4qqAx;

		public static Func<ActionExecuteContext, string, bool> es7vOGRRyP5;

		public static Func<ActionExecuteContext, string, bool> QiCvOsMWFnA;

		public static Func<ActionExecuteContext, string, bool> Gu0vOH2xbCu;

		public static Func<ActionExecuteContext, string, bool> qifvO10gQ4K;

		public static Func<string, string> vJIvOb7VLTX;

		public static Func<ActionExecuteContext, string, bool> kLNvO6SBH1V;

		public static Func<ActionExecuteContext, string, bool> dmtvOXxEqwA;

		public static Func<ActionExecuteContext, string, bool> qpFvOmcaQhT;

		public static Func<ActionExecuteContext, string, bool> FnWvOKcpUyU;

		public static Func<ActionExecuteContext, string, bool> pX4vOxxiE80;

		public static Func<ActionExecuteContext, string, bool> EVDvOr35r4n;

		public static Func<ActionExecuteContext, string, bool> JuivOp19rPE;

		public static Func<ActionExecuteContext, string, bool> MoKvOBDtt3Z;

		public static Func<ActionExecuteContext, string, bool> sAIvOQCRFOK;

		public static Func<ActionExecuteContext, string, bool> YebvOj44Msw;

		public static Func<ActionExecuteContext, string, bool> KuPvOnYYRh4;

		public static Func<ActionExecuteContext, string, bool> RIlvO4ODK0X;

		public static Func<ActionExecuteContext, string, bool> oQbvO5KRamg;

		public static Func<ActionExecuteContext, string, bool> TTCvODUS1Jg;

		public static Func<ActionExecuteContext, string, bool> xfcvOd4o9D1;

		public static Func<ActionExecuteContext, string, bool> AaivOoBS9A9;

		public static Func<ActionExecuteContext, string, bool> odovOTX0EPi;

		public static Func<ActionExecuteContext, string, bool> HZNvOMReJMC;

		public static Func<string, (bool, string)> ViivOA6HLJe;

		public static Func<ActionExecuteContext, string, bool> EThvOORZ0yj;

		public static Func<ActionExecuteContext, string, bool> dh8vOFLvkZs;

		public static Func<ActionExecuteContext, string, bool> J19vOUtRIST;

		public static Func<ActionExecuteContext, string, bool> bvNvOlKkM7d;

		public static Func<ActionExecuteContext, string, bool> PEPvOiGIT1m;

		public static Func<ActionExecuteContext, string, bool> a4svO3unWaZ;

		public static Func<ActionExecuteContext, string, bool> GvxvOfkmwxZ;

		public static Func<ActionExecuteContext, string, bool> FxOvOz6qNX6;

		public static Func<ActionExecuteContext, string, bool> uXDvFwooCjX;

		private static _003C_003Ec KjMYG0WXZcs0nVkJfKG1;

		static _003C_003Ec()
		{
			b5nvOhphCd8 = new _003C_003Ec();
		}

		internal (bool, string) aQLvADHkP80(string s)
		{
			if (!string.IsNullOrEmpty(s) && double.TryParse(s, out var result) && result > 0.0 && result <= 1.0)
			{
				return (true, "");
			}
			return (false, "请输入一个0-1之间的数字");
		}

		internal bool roHvAdyeNo2(ActionExecuteContext context, string paramData)
		{
			if (context.ImageData == null)
			{
				throw new InvalidOperationException("没有得到图片输入。");
			}
			if (!double.TryParse(paramData, out var result))
			{
				throw new InvalidOperationException("参数不正确，需要是一个0-1之间的数字。");
			}
			context.ImageData = ResizeImage(context.ImageData, Convert.ToInt32((double)context.ImageData.Width * result), Convert.ToInt32((double)context.ImageData.Height * result));
			return true;
		}

		internal bool QnMvAowrdNZ(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidOperationException("输入的字符串为空。");
			}
			context.TextData = Regex.Replace(context.TextData, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1 ");
			return true;
		}

		internal bool jyYvATNutuU(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidOperationException("输入的字符串为空。");
			}
			context.TextData = context.TextData.Trim();
			return true;
		}

		internal bool bBKvAMacm9G(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidOperationException("输入的字符串为空。");
			}
			if (string.IsNullOrEmpty(paramData))
			{
				throw new InvalidOperationException("正则替换动作参数不合法。");
			}
			string[] array = paramData.Split('\n');
			if (array.Length < 2)
			{
				throw new InvalidOperationException("正则替换动作参数不合法。至少需要2行文字。");
			}
			string replacement = array[1].TrimEnd('\r').Replace("\\r", "\r").Replace("\\n", "\n")
				.Replace("\\t", "\t");
			context.TextData = Regex.Replace(context.TextData, array[0].TrimEnd('\r'), replacement, RegexOptions.Multiline);
			return true;
		}

		internal bool SC3vAAan9m2(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(paramData))
			{
				throw new InvalidOperationException("要被替换的内容为空。");
			}
			context.TextData = sQnt4BXEYfH(paramData, context);
			return true;
		}

		internal bool xU9vAOxNfuS(ActionExecuteContext context, string paramData)
		{
			if (!string.IsNullOrEmpty(context.TextData))
			{
				if (string.IsNullOrEmpty(paramData))
				{
					throw new InvalidOperationException("正则提取动作参数不合法。");
				}
				string[] array = paramData.Split('\n');
				Match match = new Regex(array[0].TrimEnd('\r', '\n')).Match(context.TextData);
				if (match.Success)
				{
					if (array.Length > 1 && !string.IsNullOrWhiteSpace(array[1]))
					{
						context.CustomData[array[1].Trim()] = match.Value;
						int num = 0;
						if (KjMYG0WXZcs0nVkJfKG1 != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						}
					}
					else
					{
						context.TextData = match.Value;
					}
					return true;
				}
				throw new InvalidOperationException("没有找到正则匹配项。");
			}
			throw new InvalidOperationException("输入的字符串为空。");
		}

		internal bool QDxvAFREDi9(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidOperationException("输入的字符串为空。");
			}
			Bitmap graphic = new QRCode(new QRCodeGenerator().CreateQrCode(context.TextData, QRCodeGenerator.ECCLevel.Q)).GetGraphic(4);
			context.ImageData = graphic;
			return true;
		}

		internal bool DcMvAUbc0v4(ActionExecuteContext context, string paramData)
		{
			Process[] processesByName = Process.GetProcessesByName(paramData);
			if (processesByName.Length == 0)
			{
				throw new Exception("进程 " + paramData + " 尚未运行。请先运行后再执行本操作。");
			}
			if (processesByName[0].MainWindowHandle == IntPtr.Zero)
			{
				throw new Exception("进程 " + paramData + " 的主窗口无法找到并激活，可能已隐藏到系统托盘。");
			}
			NativeMethods.BringProcessMainWindowToFront(processesByName[0].MainWindowHandle);
			return true;
		}

		internal bool W2LvAlcfDWg(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidOperationException("要排序的字符串为空。");
			}
			string[] source = context.TextData.Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
			context.TextData = string.Join("\n", source.OrderBy(vJIvOb7VLTX ?? (vJIvOb7VLTX = b5nvOhphCd8.XUvvAicXUtH)));
			return true;
		}

		internal string XUvvAicXUtH(string x)
		{
			return x.Trim();
		}

		internal bool fxXvA3cdmOq(ActionExecuteContext context, string paramData)
		{
			if (Process.GetProcessesByName(paramData).Length == 0)
			{
				throw new Exception("进程 " + paramData + " 尚未运行。请先运行后再执行本操作。");
			}
			return true;
		}

		internal bool enlvAfD8uiD(ActionExecuteContext context, string paramData)
		{
			string text = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException("[保存剪贴板文字到临时文件]剪贴板中没有数据。");
			}
			string text2 = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + ".txt");
			File.WriteAllText(text2, text);
			context.TextData = text2;
			return true;
		}

		internal bool oGpvAzIUVEt(ActionExecuteContext context, string paramData)
		{
			if (context.ImageData == null)
			{
				throw new InvalidDataException("[识别图片中的二维码]输入的不是图片。");
			}
			BarcodeReader barcodeReader = new BarcodeReader
			{
				Options = 
				{
					CharacterSet = "UTF-8"
				}
			};
			try
			{
				Result result = barcodeReader.Decode(context.ImageData as Bitmap);
				if (result == null)
				{
					throw new InvalidDataException("识别二维码失败！");
				}
				context.TextData = result.Text;
				return true;
			}
			catch (Exception ex)
			{
				throw new InvalidDataException("识别二维码失败！" + ex.Message);
			}
		}

		internal bool wQHvOwTDDBc(ActionExecuteContext context, string paramData)
		{
			context.TextData = IconHelper.WriteClipboardImageToTempFile();
			return true;
		}

		internal bool BTBvOtEdsZn(ActionExecuteContext context, string paramData)
		{
			string path = sQnt4BXEYfH(paramData, context);
			try
			{
				File.WriteAllText(path, context.TextData);
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception("写入文件错误:" + ex.Message);
			}
		}

		internal bool fMYvOgpTp3u(ActionExecuteContext context, string paramData)
		{
			MessageBoxHelper.Show(context.TextData, "Quicker");
			return true;
		}

		internal bool mF7vOL1GdEr(ActionExecuteContext context, string paramData)
		{
			if (!string.IsNullOrEmpty(context.TextData))
			{
				string textData = context.TextData;
				int num = 1;
				int num2 = 0;
				int num3 = 0;
				string text = textData;
				foreach (char c in text)
				{
					num2++;
					if (c == '\n')
					{
						num++;
					}
					if (!char.IsControl(c) && !char.IsWhiteSpace(c))
					{
						num3++;
					}
				}
				if (KjMYG0WXZcs0nVkJfKG1 != null)
				{
					switch (0)
					{
					}
				}
				MessageBoxHelper.Show($"共{num}行,{num2}个字符,{num3}个非空白字符.", "Quicker");
				return true;
			}
			throw new InvalidOperationException("要统计长度的内容为空。");
		}

		internal bool PiTvOvhoAbJ(ActionExecuteContext context, string paramData)
		{
			context.TextData = string.Format(CultureInfo.CurrentCulture, paramData, context.TextData);
			return true;
		}

		internal bool IqWvOSUorQ5(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidDataException("要转换小写的字符串为空。");
			}
			context.TextData = context.TextData.ToLowerInvariant();
			return true;
		}

		internal bool QSXvO2xklFQ(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidDataException("要转换大写的字符串为空。");
			}
			context.TextData = context.TextData.ToUpperInvariant();
			return true;
		}

		internal bool nxXvOuERHcb(ActionExecuteContext context, string paramData)
		{
			BitmapSource bitmapSource = h8Xt5NlggX6();
			int num2 = default(int);
			for (int i = 0; i < 20; i++)
			{
				if (bitmapSource != null)
				{
					break;
				}
				Thread.Sleep(50);
				bitmapSource = h8Xt5NlggX6();
				int num = 0;
				if (!Dk5S7IWX5SvOs8iwrpkF())
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
			if (bitmapSource == null)
			{
				throw new InvalidDataException("剪贴板中没有图片。");
			}
			context.ImageData = pAXt5P7HcwK(bitmapSource);
			return true;
		}

		internal bool IUgvONuI9hJ(ActionExecuteContext context, string paramData)
		{
			context.TextData = Guid.NewGuid().ToString();
			return true;
		}

		internal bool E4IvOJYhw7t(ActionExecuteContext context, string paramData)
		{
			string text = paramData ?? "yyyy-MM-dd HH:mm:ss";
			context.TextData = DateTime.Now.ToString(text, CultureInfo.CurrentCulture);
			return true;
		}

		internal bool lFovO0GirFR(ActionExecuteContext context, string paramData)
		{
			string text = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
			for (int i = 0; i < 20; i++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					break;
				}
				Thread.Sleep(50);
				text = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidDataException("获得的剪贴板文字为空。");
			}
			context.TextData = text;
			return true;
		}

		internal bool JXuvOCs2qKv(ActionExecuteContext context, string paramData)
		{
			long clipboardSequenceNumber = NativeMethods.GetClipboardSequenceNumber();
			AppHelper.SendCopyKeys();
			int num = 1;
			if (KjMYG0WXZcs0nVkJfKG1 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					num3 = 0;
					break;
				}
				do
				{
					if (num3 < 10 && NativeMethods.GetClipboardSequenceNumber() == clipboardSequenceNumber)
					{
						Thread.Sleep(50);
						num3++;
						num = 0;
						continue;
					}
					if (NativeMethods.GetClipboardSequenceNumber() == clipboardSequenceNumber)
					{
						throw new InvalidOperationException("无法获取选中的文本。");
					}
					string text = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
					for (int i = 0; i < 20; i++)
					{
						if (!string.IsNullOrEmpty(text))
						{
							break;
						}
						Thread.Sleep(50);
						text = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
					}
					if (string.IsNullOrWhiteSpace(text))
					{
						throw new InvalidOperationException("获得的剪贴板文本为空。");
					}
					context.TextData = text;
					return true;
				}
				while (Dk5S7IWX5SvOs8iwrpkF());
			}
		}

		internal bool EeZvOPWSmGY(ActionExecuteContext context, string paramData)
		{
			long clipboardSequenceNumber = NativeMethods.GetClipboardSequenceNumber();
			long num = clipboardSequenceNumber;
			int num2 = 50;
			int num3 = 100;
			if (!string.IsNullOrEmpty(paramData))
			{
				if (!int.TryParse(paramData, out var result) || result <= 0)
				{
					throw new InvalidDataException("等待时间参数不合法。");
				}
				num3 = result * 1000 / num2;
			}
			int num4 = 0;
			int num6 = default(int);
			while (num4 < num3)
			{
				num = NativeMethods.GetClipboardSequenceNumber();
				int num5 = 0;
				if (KjMYG0WXZcs0nVkJfKG1 != null)
				{
					goto IL_007b;
				}
				goto IL_007f;
				IL_009c:
				Thread.Sleep(20);
				break;
				IL_007f:
				while (true)
				{
					switch (num5)
					{
					case 1:
						goto end_IL_007f;
					}
					if (num != clipboardSequenceNumber)
					{
						goto IL_009c;
					}
					Thread.Sleep(num2);
					num5 = 1;
					if (Dk5S7IWX5SvOs8iwrpkF())
					{
						continue;
					}
					goto IL_007b;
					continue;
					end_IL_007f:
					break;
				}
				num4++;
				continue;
				IL_007b:
				num5 = num6;
				goto IL_007f;
			}
			if (num == clipboardSequenceNumber)
			{
				throw new InvalidOperationException("剪切板到时间未改变。");
			}
			return true;
		}

		internal bool nBRvOE8wx1R(ActionExecuteContext context, string paramData)
		{
			int result = 0;
			if (!int.TryParse(paramData, out result) || result <= 0)
			{
				throw new InvalidDataException("子程序“等待”的参数不合法，需要指定等待的毫秒数字。");
			}
			Thread.Sleep(result);
			return true;
		}

		internal (bool, string) FoJvOycxFpO(string paramData)
		{
			int result = 0;
			if (int.TryParse(paramData, out result))
			{
				return (true, "");
			}
			return (false, "参数不合法，请输入整数数字。");
		}

		internal bool axBvO8AiXss(ActionExecuteContext context, string paramData)
		{
			if (string.IsNullOrEmpty(context.TextData))
			{
				throw new InvalidDataException("没有要打开的路径。");
			}
			if (Directory.Exists(context.TextData))
			{
				return true;
			}
			context.TextData = Path.GetDirectoryName(context.TextData);
			return true;
		}

		internal bool CigvOaq1iY7(ActionExecuteContext context, string paramData)
		{
			context.CustomData[paramData] = context.TextData;
			return true;
		}

		internal bool JmHvO7fVarb(ActionExecuteContext context, string paramData)
		{
			if (!context.CustomData.ContainsKey(paramData))
			{
				throw new InvalidDataException("变量 " + paramData + " 不存在。");
			}
			context.TextData = context.CustomData[paramData] as string;
			return true;
		}

		internal bool BQCvORLU8JN(ActionExecuteContext context, string paramData)
		{
			if (context.LastDataType == ActionDataType.Text)
			{
				return HKqt4lHWOgf(context, paramData);
			}
			if (context.LastDataType != ActionDataType.Image)
			{
				throw new InvalidOperationException("没有要写入剪切板的数据！");
			}
			return ocut43Qir5H(context, paramData);
		}

		internal bool xcVvOqxADH2(ActionExecuteContext context, string paramData)
		{
			if (context.LastDataType == ActionDataType.Text)
			{
				return GUtt4AEPSiZ(context, paramData);
			}
			if (context.LastDataType != ActionDataType.Image)
			{
				throw new InvalidOperationException("没有要写入剪切板的数据！");
			}
			return YQnt4Fao7pK(context, paramData);
		}

		internal bool JkSvOcyMlbL(ActionExecuteContext context, string paramData)
		{
			HKqt4lHWOgf(context, paramData);
			Thread.Sleep(50);
			SendKeys.SendWait("^v");
			return true;
		}

		internal bool QVEvOVYBi3D(ActionExecuteContext context, string paramData)
		{
			try
			{
				IList<string> selectedFiles = NativeMethods.GetSelectedFiles();
				if (selectedFiles.Count < 1)
				{
					throw new InvalidOperationException("获得的文件数量为0。");
				}
				context.TextData = string.Join("\n", selectedFiles);
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("无法获取选中的文件。" + ex.Message);
			}
			return true;
		}

		internal bool D2ivOZQTRwy(ActionExecuteContext context, string paramData)
		{
			try
			{
				string currentFolder = NativeMethods.GetCurrentFolder(null);
				if (string.IsNullOrEmpty(currentFolder))
				{
					throw new InvalidOperationException("请在资源管理器中执行本操作。");
				}
				context.TextData = currentFolder;
			}
			catch (Exception ex)
			{
				Puft5Vno67v.Warn("获取当前路径异常," + ex.Message, ex);
				throw new InvalidOperationException("无法获取路径。" + ex.Message);
			}
			return true;
		}

		internal bool GIBvO91ZHly(ActionExecuteContext context, string paramData)
		{
			try
			{
				string activeWindowTitle = NativeMethods.GetActiveWindowTitle();
				if (string.IsNullOrEmpty(activeWindowTitle))
				{
					throw new InvalidOperationException("获得的窗口标题为空。");
				}
				context.TextData = activeWindowTitle;
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("无法获得窗口标题。" + ex.Message);
			}
			return true;
		}

		internal static bool Dk5S7IWX5SvOs8iwrpkF()
		{
			return KjMYG0WXZcs0nVkJfKG1 == null;
		}
	}

	private static readonly ILog Puft5Vno67v;

	private static readonly ConcurrentDictionary<string, OldSubProgram> qblt5Z54Hv0;

	[CompilerGenerated]
	private static readonly IList<OldSubProgram> oC1t59W33yj;

	private static object xJPp5BQoV0tPXF89Sl0t;

	public static IList<OldSubProgram> AllSubPrograms
	{
		[CompilerGenerated]
		get
		{
			return oC1t59W33yj;
		}
	}

	static OldSubProgramMgr()
	{
		Puft5Vno67v = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		qblt5Z54Hv0 = new ConcurrentDictionary<string, OldSubProgram>();
		oC1t59W33yj = new List<OldSubProgram>();
		Tk3t4X5UKgK();
	}

	public static void Add(OldSubProgram subProgram)
	{
		if (qblt5Z54Hv0.ContainsKey(subProgram.Key))
		{
			throw new InvalidOperationException("已经有相同键值的子程序：" + subProgram.Key);
		}
		qblt5Z54Hv0.TryAdd(subProgram.Key, subProgram);
		oC1t59W33yj.Add(subProgram);
	}

	public static void Run(string key, string paramData, ActionExecuteContext context)
	{
		OldSubProgram oldSubProgram = qblt5Z54Hv0[key];
		if (oldSubProgram == null)
		{
			throw new InvalidDataException("找不到子程序：" + key);
		}
		oldSubProgram.ProcessDataFunc(context, paramData);
	}

	public static OldSubProgram GetSubProgram(string key)
	{
		if (qblt5Z54Hv0.ContainsKey(key))
		{
			return qblt5Z54Hv0[key];
		}
		return null;
	}

	public static bool ContainsAction(string key)
	{
		return qblt5Z54Hv0.ContainsKey(key);
	}

	private static void Tk3t4X5UKgK()
	{
		AxRt506m9Iw();
		nvqt5JxNS25();
		CmGt4nEIGM2();
		MqMt459hTmK();
		AxRt5up8qK7();
		int num = 1;
		if (!LwrmSYQoQnXihLwQaKea())
		{
			goto IL_0026;
		}
		goto IL_0064;
		IL_0026:
		CwLt52eP72H();
		dBTt5LHcJZw();
		Smut5SWw7bp();
		jrnt5vFxWWA();
		vMXt4DXY3fO();
		E3st4oPjuHj();
		TiYt5ylPjtP();
		Ablt5RCG6lx();
		jJFt5qtn7MS();
		num = 0;
		if (!LwrmSYQoQnXihLwQaKea())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0064;
		IL_0064:
		switch (num)
		{
		case 1:
			break;
		default:
			e1kt5cPIKqw();
			Semt5gDnuT1();
			DuWt5to4ysI();
			gxVt4xJP0Qb();
			plct4Qso8EP();
			jdLt4rBYERE();
			Ubyt4pKJV4i();
			swvt5wFPn9t();
			FeOt4K8qaRZ();
			pD5t44yRIFS();
			v34t5CxhUbH();
			goto case 2;
		case 2:
		{
			qoSt4dVTMqd();
			int num2 = 3;
			goto case 3;
		}
		case 3:
			pbHt4jCnpHb();
			w0Nt4m7gXbh();
			iTot4zJr73v();
			ooyt4fpHwR1();
			EABt4UnUuSy();
			fuMt4iHCN6q();
			Thmt4TwOlyR();
			JImt4Mici0F();
			Hmtt4OrEUUo();
			MtPt5EaccKl();
			F7Et5a5lGTk();
			dtBt584C4YZ();
			WOwt57RhgWv();
			return;
		}
		goto IL_0026;
	}

	private static void w0Nt4m7gXbh()
	{
		Add(new OldSubProgram
		{
			Key = "sys:resizeImageByRatio",
			Name = "[处理]按比例缩小图片",
			Description = "将图片按比例缩放",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "缩小比例",
			ParamDescription = "位图边长的缩小比例。0-1之间的小数。比如0.5将把位图每边缩小一半。",
			InputDescription = "图片：要缩放的位图",
			OutputDescription = "图片：缩放后的位图",
			DefaultParamData = "0.5",
			ValidateParamFunc = (_003C_003Ec.Tg9vOeN75Y5 ?? (_003C_003Ec.Tg9vOeN75Y5 = _003C_003Ec.b5nvOhphCd8.aQLvADHkP80)),
			ProcessDataFunc = (_003C_003Ec.WSTvOY92jB7 ?? (_003C_003Ec.WSTvOY92jB7 = _003C_003Ec.b5nvOhphCd8.roHvAdyeNo2))
		});
	}

	public static Bitmap ResizeImage(Image image, int width, int height)
	{
		Rectangle destRect = new Rectangle(0, 0, width, height);
		Bitmap bitmap = new Bitmap(width, height);
		bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CompositingMode = CompositingMode.SourceCopy;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		using ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
		graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
		return bitmap;
	}

	private static void FeOt4K8qaRZ()
	{
		Add(new OldSubProgram
		{
			Key = "sys:intercappedToSentence",
			Name = "[处理]组合词拆分成句子",
			Description = "将PascalCase或camelCase单词拆分成句子。可以方便的用于翻译查词。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：组合词，如isWorkDone",
			OutputDescription = "文本：拆分后的句子，如is Work Done",
			ProcessDataFunc = (_003C_003Ec.Iu5vOIXGwIJ ?? (_003C_003Ec.Iu5vOIXGwIJ = _003C_003Ec.b5nvOhphCd8.QnMvAowrdNZ))
		});
	}

	private static void gxVt4xJP0Qb()
	{
		Add(new OldSubProgram
		{
			Key = "sys:trimString",
			Name = "[处理]去除首尾空白字符",
			Description = "将字符串前后的空白字符去掉。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：首尾可能带有空白字符的字串",
			OutputDescription = "文本：去除首尾空白字符的字串",
			ProcessDataFunc = (_003C_003Ec.p6dvOWwZGfk ?? (_003C_003Ec.p6dvOWwZGfk = _003C_003Ec.b5nvOhphCd8.jyYvATNutuU))
		});
	}

	private static void jdLt4rBYERE()
	{
		Add(new OldSubProgram
		{
			Key = "sys:regexReplace",
			Name = "[处理]用正则表达式替换",
			Description = "将字符串前后的空白字符去掉。",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			InputDescription = "文本：需要处理的字符串",
			OutputDescription = "文本：正则替换后的字符串",
			ParamName = "替换参数",
			ParamDescription = "第一行写要替换内容的正则表达式，第二行写要替换的内容",
			ProcessDataFunc = (_003C_003Ec.nLNvOk4qqAx ?? (_003C_003Ec.nLNvOk4qqAx = _003C_003Ec.b5nvOhphCd8.bBKvAMacm9G))
		});
	}

	private static void Ubyt4pKJV4i()
	{
		Add(new OldSubProgram
		{
			Key = "sys:variableReplace",
			Name = "[处理]替换变量",
			Description = "替换指定内容中的变量",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			InputDescription = "文本：需要处理的文字，里面",
			OutputDescription = "文本：替换后的字符串",
			ParamName = "内容",
			ParamDescription = "内容中包含的{变量名}将会被替换成变量的值。",
			ProcessDataFunc = (_003C_003Ec.es7vOGRRyP5 ?? (_003C_003Ec.es7vOGRRyP5 = _003C_003Ec.b5nvOhphCd8.SC3vAAan9m2))
		});
	}

	private static string sQnt4BXEYfH(string string_0, ActionExecuteContext actionExecuteContext_0)
	{
		string text = string_0.Replace("{context}", actionExecuteContext_0.TextData);
		foreach (KeyValuePair<string, object> customDatum in actionExecuteContext_0.CustomData)
		{
			if (customDatum.Value is string)
			{
				text = text.Replace("{" + customDatum.Key + "}", customDatum.Value as string);
			}
		}
		return text;
	}

	private static void plct4Qso8EP()
	{
		Add(new OldSubProgram
		{
			Key = "sys:regexExtract",
			Name = "[处理]用正则表达式提取",
			Description = "使用正则表达式提取指定内容。只提取第一个匹配项。",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			InputDescription = "文本：需要处理的字符串",
			OutputDescription = "文本：提取到的字符串",
			ParamName = "正则表达式",
			ParamDescription = "第一行写要匹配的正则。第二行如果不为空，则表示要将取出的内容放入的变量名。",
			ProcessDataFunc = (_003C_003Ec.QiCvOsMWFnA ?? (_003C_003Ec.QiCvOsMWFnA = _003C_003Ec.b5nvOhphCd8.xU9vAOxNfuS))
		});
	}

	private static void pbHt4jCnpHb()
	{
		Add(new OldSubProgram
		{
			Key = "sys:createQrcodeImage",
			Name = "[处理]生成二维码图片",
			Description = "根据输入的字符串，生成二维码图片。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要生成二维码图片的文字内容",
			OutputDescription = "图片：生成的二维码图片",
			ProcessDataFunc = (_003C_003Ec.Gu0vOH2xbCu ?? (_003C_003Ec.Gu0vOH2xbCu = _003C_003Ec.b5nvOhphCd8.QDxvAFREDi9))
		});
	}

	private static void CmGt4nEIGM2()
	{
		Add(new OldSubProgram
		{
			Key = "sys:activateProcessMainWindow",
			Name = "[系统]激活进程主窗口",
			Description = "找到指定进程的主窗口并使其显示在前台。",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "进程名称",
			ParamDescription = "请输入要验证的进程名称。通常是exe的文件名去掉后缀，比如记事本程序的进程名称为notepad。",
			InputDescription = "-",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.qifvO10gQ4K ?? (_003C_003Ec.qifvO10gQ4K = _003C_003Ec.b5nvOhphCd8.DcMvAUbc0v4))
		});
	}

	private static void pD5t44yRIFS()
	{
		Add(new OldSubProgram
		{
			Key = "sys:sortStringsAsc",
			Name = "[处理]排序字符串行A-Z",
			Description = "对多行字符串重新排序，按字母顺序A-Z，忽略前面的空格。忽略空行",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：需要排序的多行字符串",
			OutputDescription = "文本：排序后的字符串",
			ProcessDataFunc = (_003C_003Ec.kLNvO6SBH1V ?? (_003C_003Ec.kLNvO6SBH1V = _003C_003Ec.b5nvOhphCd8.W2LvAlcfDWg))
		});
	}

	private static void MqMt459hTmK()
	{
		Add(new OldSubProgram
		{
			Key = "sys:checkProcessExists",
			Name = "[系统]检查程序已启动",
			Description = "检查指定的应用程序已经启动，否则不继续执行操作。",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "进程名称",
			ParamDescription = "请输入要验证的进程名称。通常是exe的文件名去掉后缀，比如记事本程序的进程名称为notepad。",
			InputDescription = "-",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.dmtvOXxEqwA ?? (_003C_003Ec.dmtvOXxEqwA = _003C_003Ec.b5nvOhphCd8.fxXvA3cdmOq))
		});
	}

	private static void vMXt4DXY3fO()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeClipTxt2TempFile",
			Name = "[输入]保存剪贴板文字到临时文件",
			Description = "将剪贴板中的文字保存到文件，输出文件路径。",
			InputDescription = "-",
			OutputDescription = "文本：临时文件的路径",
			Icon = "",
			ShowParamInput = false,
			ProcessDataFunc = (_003C_003Ec.qpFvOmcaQhT ?? (_003C_003Ec.qpFvOmcaQhT = _003C_003Ec.b5nvOhphCd8.enlvAfD8uiD))
		});
	}

	private static void qoSt4dVTMqd()
	{
		Add(new OldSubProgram
		{
			Key = "sys:readQrCode",
			Name = "[处理]识别图片中的二维码",
			Description = "识别图片中的二维码。输入图片，输出识别出的文字",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "图片：要识别二维码的图片",
			OutputDescription = "文本：识别出的二维码",
			ProcessDataFunc = (_003C_003Ec.FnWvOKcpUyU ?? (_003C_003Ec.FnWvOKcpUyU = _003C_003Ec.b5nvOhphCd8.oGpvAzIUVEt))
		});
	}

	private static void E3st4oPjuHj()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeClipImg2TempFile",
			Name = "[输入]保存剪贴板图片到临时文件",
			Description = "将剪贴板中的图片保存到文件，输出文件路径。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "-",
			OutputDescription = "文本：生成的临时文件路径",
			ProcessDataFunc = (_003C_003Ec.pX4vOxxiE80 ?? (_003C_003Ec.pX4vOxxiE80 = _003C_003Ec.b5nvOhphCd8.wQHvOwTDDBc))
		});
	}

	private static void Thmt4TwOlyR()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeText2TempFile",
			Name = "[输出]将文本写入临时文件",
			Description = "将文本内容写入临时文件。返回文件路径。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要写入临时文件的文本",
			OutputDescription = "文本：生成的临时文件路径",
			ProcessDataFunc = (_003C_003EO.pvevAjyCQUY ?? (_003C_003EO.pvevAjyCQUY = GUtt4AEPSiZ))
		});
	}

	private static void JImt4Mici0F()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeText2File",
			Name = "[输出]将文本写入文件",
			Description = "将上下文文本内容写入文件",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			InputDescription = "",
			OutputDescription = "",
			ParamName = "文件名",
			ParamDescription = "要写入的完整文件路径。其中包含的{变量名}将会被替换成变量的值。",
			ProcessDataFunc = (_003C_003Ec.EVDvOr35r4n ?? (_003C_003Ec.EVDvOr35r4n = _003C_003Ec.b5nvOhphCd8.BTBvOtEdsZn))
		});
	}

	private static bool GUtt4AEPSiZ(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		if (string.IsNullOrEmpty(actionExecuteContext_0.TextData))
		{
			throw new InvalidDataException("[写入临时文件]子程序：输入为空。");
		}
		string text = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + ".txt");
		try
		{
			File.WriteAllText(text, actionExecuteContext_0.TextData);
			actionExecuteContext_0.TextData = text;
			return true;
		}
		catch (Exception ex)
		{
			throw new InvalidDataException("[写入临时文件]子程序：" + ex.Message);
		}
	}

	private static void Hmtt4OrEUUo()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeImage2TempFile",
			Name = "[输出]将图片写入临时文件",
			Description = "将图片内容写入临时文件。返回文件路径。",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "图片：要写入临时文件的图片",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003EO.oZovAnq8VX1 ?? (_003C_003EO.oZovAnq8VX1 = YQnt4Fao7pK))
		});
	}

	private static bool YQnt4Fao7pK(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		if (actionExecuteContext_0.ImageData == null)
		{
			throw new InvalidDataException("要写入临时文件的图片内容为空。");
		}
		string text = Path.Combine(Path.GetTempPath(), "quicker_" + Guid.NewGuid().ToString() + ".png");
		try
		{
			actionExecuteContext_0.ImageData.Save(text);
			actionExecuteContext_0.TextData = text;
			return true;
		}
		catch (Exception ex)
		{
			throw new InvalidDataException("[写入临时文件]子程序：" + ex.Message);
		}
	}

	private static void EABt4UnUuSy()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeText2Clipboard",
			Name = "[输出]将文本存入剪贴板",
			Description = "将输入文本内容写入剪贴板",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要写入剪贴板的文字内容",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003EO.wpovA4rgOpW ?? (_003C_003EO.wpovA4rgOpW = HKqt4lHWOgf))
		});
	}

	private static bool HKqt4lHWOgf(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		if (string.IsNullOrWhiteSpace(actionExecuteContext_0.TextData))
		{
			throw new InvalidDataException("[写入剪贴板]子程序：输入为空。");
		}
		ClipboardHelper.SetText(actionExecuteContext_0.TextData);
		return true;
	}

	private static void fuMt4iHCN6q()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeImage2Clipboard",
			Name = "[输出]将图片写入剪贴板",
			Description = "将输入图片内容写入剪贴板",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "图片：要写入剪贴板的图片内容",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003EO.IRMvA5ST0JD ?? (_003C_003EO.IRMvA5ST0JD = ocut43Qir5H))
		});
	}

	private static bool ocut43Qir5H(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		if (actionExecuteContext_0.ImageData == null)
		{
			throw new InvalidDataException("要写入剪贴板的图片为空");
		}
		System.Windows.Forms.DataObject dataObject = new System.Windows.Forms.DataObject();
		((System.Windows.Forms.IDataObject)dataObject).SetData(System.Windows.Forms.DataFormats.Bitmap, true, (object)actionExecuteContext_0.ImageData);
		ClipboardHelper.SetDataObject(dataObject, true);
		return true;
	}

	private static void ooyt4fpHwR1()
	{
		Add(new OldSubProgram
		{
			Key = "sys:showMessage",
			Name = "[输出]弹窗显示",
			Description = "弹窗显示字符串内容",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要弹窗显示的内容",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.JuivOp19rPE ?? (_003C_003Ec.JuivOp19rPE = _003C_003Ec.b5nvOhphCd8.fMYvOgpTp3u))
		});
	}

	private static void iTot4zJr73v()
	{
		Add(new OldSubProgram
		{
			Key = "sys:countLine",
			Name = "[处理]显示行数和字数统计",
			Description = "统计输入字符串内容的行数、字符总数、非空字符数，并弹窗显示",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要统计长度的内容",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.MoKvOBDtt3Z ?? (_003C_003Ec.MoKvOBDtt3Z = _003C_003Ec.b5nvOhphCd8.mF7vOL1GdEr))
		});
	}

	private static void swvt5wFPn9t()
	{
		Add(new OldSubProgram
		{
			Key = "sys:formatString",
			Name = "[处理]格式化输出",
			Description = "将输入按设定的格式输出为字符串",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "格式化字符串",
			ParamDescription = "使用c#语言String.Format函数将输入对象格式化输出。详细用法请参考c#语言资料。",
			DefaultParamData = "{0}",
			InputDescription = "文本：要格式化的内容",
			OutputDescription = "文本：格式化后的输出内容",
			ProcessDataFunc = (_003C_003Ec.sAIvOQCRFOK ?? (_003C_003Ec.sAIvOQCRFOK = _003C_003Ec.b5nvOhphCd8.PiTvOvhoAbJ))
		});
	}

	private static void DuWt5to4ysI()
	{
		Add(new OldSubProgram
		{
			Key = "sys:toLower",
			Name = "[处理]转换为小写",
			Description = "将字符串转换为小写",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要转换为小写的字符串",
			OutputDescription = "文本：转换后的输出字符串",
			ProcessDataFunc = (_003C_003Ec.YebvOj44Msw ?? (_003C_003Ec.YebvOj44Msw = _003C_003Ec.b5nvOhphCd8.IqWvOSUorQ5))
		});
	}

	private static void Semt5gDnuT1()
	{
		Add(new OldSubProgram
		{
			Key = "sys:toUpper",
			Name = "[处理]转换为大写",
			Description = "将字符串转换为大写",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "文本：要转换为大写的字符串",
			OutputDescription = "文本：转换后的输出字符串",
			ProcessDataFunc = (_003C_003Ec.KuPvOnYYRh4 ?? (_003C_003Ec.KuPvOnYYRh4 = _003C_003Ec.b5nvOhphCd8.QSXvO2xklFQ))
		});
	}

	private static void dBTt5LHcJZw()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getClipboardImage",
			Name = "[输入]获取剪贴板图片",
			Description = "读取剪贴板中的图片内容",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "-",
			OutputDescription = "图片：从剪贴板中读取的图片",
			ProcessDataFunc = (_003C_003Ec.RIlvO4ODK0X ?? (_003C_003Ec.RIlvO4ODK0X = _003C_003Ec.b5nvOhphCd8.nxXvOuERHcb))
		});
	}

	private static void jrnt5vFxWWA()
	{
		Add(new OldSubProgram
		{
			Key = "sys:newGuid",
			Name = "[输入]生成Guid",
			Description = "生成一个新的Guid",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = false,
			ParamName = "格式",
			ParamDescription = "留空使用默认格式。其他格式(N/D/B/P/X)请参考Guid.ToString()方法的文档。",
			InputDescription = "-",
			OutputDescription = "文本：生成的GUID字符串",
			ProcessDataFunc = (_003C_003Ec.oQbvO5KRamg ?? (_003C_003Ec.oQbvO5KRamg = _003C_003Ec.b5nvOhphCd8.IUgvONuI9hJ))
		});
	}

	private static void Smut5SWw7bp()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getCurrentTime",
			Name = "[输入]获取当前时间",
			Description = "读取系统当前时间",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = false,
			ParamName = "格式",
			DefaultParamData = "yyyy-MM-dd HH:mm:ss",
			ParamDescription = "请参考DateTime.ToString()方法的文档。",
			InputDescription = "-",
			OutputDescription = "文本：生成的时间字符串",
			ProcessDataFunc = (_003C_003Ec.TTCvODUS1Jg ?? (_003C_003Ec.TTCvODUS1Jg = _003C_003Ec.b5nvOhphCd8.E4IvOJYhw7t))
		});
	}

	private static void CwLt52eP72H()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getClipboardText",
			Name = "[输入]获取剪贴板文本",
			Description = "读取剪贴板中的文本内容",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "-",
			OutputDescription = "文本：从剪贴板获取的文字。",
			ProcessDataFunc = (_003C_003Ec.xfcvOd4o9D1 ?? (_003C_003Ec.xfcvOd4o9D1 = _003C_003Ec.b5nvOhphCd8.lFovO0GirFR))
		});
	}

	private static void AxRt5up8qK7()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getSelectedText",
			Name = "[输入]获取选中文本",
			Description = "读取活动窗口中选中的文本内容（发送Ctrl+C复制文本到剪贴板，然后读取剪贴板内容）",
			Icon = "",
			ShowParamInput = false,
			InputDescription = "-",
			OutputDescription = "文本：获取的文本。",
			ProcessDataFunc = (_003C_003Ec.AaivOoBS9A9 ?? (_003C_003Ec.AaivOoBS9A9 = _003C_003Ec.b5nvOhphCd8.JXuvOCs2qKv))
		});
	}

	private static BitmapSource h8Xt5NlggX6()
	{
		try
		{
			return ClipboardHelper.GetImage();
		}
		catch (Exception exception)
		{
			Puft5Vno67v.Warn("获取剪贴板图片失败。", exception);
			return null;
		}
	}

	private static void nvqt5JxNS25()
	{
		Add(new OldSubProgram
		{
			Key = "sys:waitClipboardChange",
			Name = "[系统]等待剪贴板内容改变",
			Description = "等待剪贴板的内容发生改变。比如有新的截图。",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "最长等待时间s",
			ParamDescription = "最长等待的时间秒数",
			DefaultParamData = "10",
			InputDescription = "-",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.odovOTX0EPi ?? (_003C_003Ec.odovOTX0EPi = _003C_003Ec.b5nvOhphCd8.EeZvOPWSmGY))
		});
	}

	private static void AxRt506m9Iw()
	{
		Add(new OldSubProgram
		{
			Key = "sys:delay",
			Name = "[系统]等待",
			Description = "等待指定的时间（ms）",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "等待时间(ms)",
			ParamDescription = "需要等待的时间毫秒数",
			DefaultParamData = "50",
			ProcessDataFunc = (_003C_003Ec.HZNvOMReJMC ?? (_003C_003Ec.HZNvOMReJMC = _003C_003Ec.b5nvOhphCd8.nBRvOE8wx1R)),
			ValidateParamFunc = (_003C_003Ec.ViivOA6HLJe ?? (_003C_003Ec.ViivOA6HLJe = _003C_003Ec.b5nvOhphCd8.FoJvOycxFpO))
		});
	}

	private static void v34t5CxhUbH()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getFileFolder",
			Name = "[处理]获取文件所在目录",
			Description = "根据文件的完整路径获取其所在的目录",
			Icon = "",
			ShowParamInput = false,
			ParamIsRequried = false,
			ParamName = "",
			ParamDescription = "",
			DefaultParamData = "",
			ProcessDataFunc = (_003C_003Ec.EThvOORZ0yj ?? (_003C_003Ec.EThvOORZ0yj = _003C_003Ec.b5nvOhphCd8.axBvO8AiXss)),
			ValidateParamFunc = null
		});
	}

	private static Image pAXt5P7HcwK(ImageSource imageSource_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BmpBitmapEncoder bmpBitmapEncoder = new BmpBitmapEncoder();
		bmpBitmapEncoder.Frames.Add(BitmapFrame.Create(imageSource_0 as BitmapSource));
		bmpBitmapEncoder.Save(memoryStream);
		memoryStream.Flush();
		return Image.FromStream(memoryStream);
	}

	private static void MtPt5EaccKl()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeTextToVar",
			Name = "[输出]将文本暂存到变量",
			Description = "将文本暂存到变量，可以在后续操作中读取后使用",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "变量名",
			ParamDescription = "指定暂存文本到的变量名，建议使用英文单词、字母、数字的组合，不要有特殊字符",
			InputDescription = "文本：要暂存的文字内容",
			OutputDescription = "-",
			ProcessDataFunc = (_003C_003Ec.dh8vOFLvkZs ?? (_003C_003Ec.dh8vOFLvkZs = _003C_003Ec.b5nvOhphCd8.CigvOaq1iY7))
		});
	}

	private static void TiYt5ylPjtP()
	{
		Add(new OldSubProgram
		{
			Key = "sys:readTextFromVar",
			Name = "[输入]读取变量中暂存的文本",
			Description = "从变量中读取暂存的文本",
			Icon = "",
			ShowParamInput = true,
			ParamIsRequried = true,
			ParamName = "变量名",
			ParamDescription = "指定暂存文本到的变量名，建议使用英文单词、字母、数字的组合，不要有特殊字符",
			InputDescription = "-",
			OutputDescription = "文本：从变量中获取的文字。",
			ProcessDataFunc = (_003C_003Ec.J19vOUtRIST ?? (_003C_003Ec.J19vOUtRIST = _003C_003Ec.b5nvOhphCd8.JmHvO7fVarb))
		});
	}

	private static void dtBt584C4YZ()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeClipboard",
			Name = "[输出]存入剪贴板",
			Description = "将输入内容（仅支持文字或图片）写入剪贴板",
			Icon = "",
			ShowParamInput = false,
			HideInList = true,
			ProcessDataFunc = (_003C_003Ec.bvNvOlKkM7d ?? (_003C_003Ec.bvNvOlKkM7d = _003C_003Ec.b5nvOhphCd8.BQCvORLU8JN))
		});
	}

	private static void F7Et5a5lGTk()
	{
		Add(new OldSubProgram
		{
			Key = "sys:writeTempFile",
			Name = "[输出]写入临时文件",
			Description = "将输入内容（仅支持文字或图片）写入临时文件。返回文件路径。",
			Icon = "",
			ShowParamInput = false,
			HideInList = true,
			ProcessDataFunc = (_003C_003Ec.PEPvOiGIT1m ?? (_003C_003Ec.PEPvOiGIT1m = _003C_003Ec.b5nvOhphCd8.xcVvOqxADH2))
		});
	}

	private static void WOwt57RhgWv()
	{
		Add(new OldSubProgram
		{
			Key = "sys:pasteText",
			Name = "[输出]粘贴文本",
			Description = "将文本内容复制到剪贴板后，发送Ctrl+V粘贴到当前输入焦点。",
			Icon = "",
			ShowParamInput = false,
			ProcessDataFunc = (_003C_003Ec.a4svO3unWaZ ?? (_003C_003Ec.a4svO3unWaZ = _003C_003Ec.b5nvOhphCd8.JkSvOcyMlbL))
		});
	}

	private static void Ablt5RCG6lx()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getSelectedFiles",
			Name = "[输入]获取选择的文件",
			Description = "获取资源管理器中选择的文件。",
			Icon = "",
			ShowParamInput = false,
			ProcessDataFunc = (_003C_003Ec.GvxvOfkmwxZ ?? (_003C_003Ec.GvxvOfkmwxZ = _003C_003Ec.b5nvOhphCd8.QVEvOVYBi3D))
		});
	}

	private static void jJFt5qtn7MS()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getExplorerPath",
			Name = "[输入]获取当前路径",
			Description = "获取资源管理器的当前文件夹路径。",
			Icon = "",
			ShowParamInput = false,
			ProcessDataFunc = (_003C_003Ec.FxOvOz6qNX6 ?? (_003C_003Ec.FxOvOz6qNX6 = _003C_003Ec.b5nvOhphCd8.D2ivOZQTRwy))
		});
	}

	private static void e1kt5cPIKqw()
	{
		Add(new OldSubProgram
		{
			Key = "sys:getWindowTitle",
			Name = "[输入]获取窗口标题",
			Description = "获取当前活动窗口的标题。",
			Icon = "",
			ShowParamInput = false,
			ProcessDataFunc = (_003C_003Ec.uXDvFwooCjX ?? (_003C_003Ec.uXDvFwooCjX = _003C_003Ec.b5nvOhphCd8.GIBvO91ZHly))
		});
	}

	internal static bool LwrmSYQoQnXihLwQaKea()
	{
		return xJPp5BQoV0tPXF89Sl0t == null;
	}
}
