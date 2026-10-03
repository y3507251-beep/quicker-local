using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using bcybYUMWiG3W9kCqUoJ;
using f9a0PHoGPpwjuPg0HoF;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Actions.XActions.BuildinRunners.Network;
using Quicker.Domain.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using tQy5b4MZR11HLf8vRkW;
using Windows.Media.Ocr;

namespace vJ31iUYJvlh2KmJJn6Y;

internal class dfsuXeYKgS8Je0MVxhj
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<char, bool> p3CS3X6rI8B;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec vHIS34xDoEl;

		public static Func<Point, int> w2WS35fLptk;

		public static Func<Point, int> muwS3D8vblX;

		public static Func<LocalOcrTextBlock, bool> pNWS3dsYnHb;

		public static Func<LocalOcrTextBlock, double> M5cS3ogRVK8;

		public static Func<LocalOcrTextBlock, int> knOS3TRR8XF;

		public static Func<string, bool> hDDS3MxZvEW;

		public static Func<LocalOcrTextBlock, bool> WDKS3AleOYG;

		public static Func<LocalOcrTextBlock, double> KmgS3O3iaOH;

		public static Func<LocalOcrTextBlock, int> mfpS3FnTb8O;

		private static _003C_003Ec W8Y057y2ecVLMH8o70KQ;

		static _003C_003Ec()
		{
			vHIS34xDoEl = new _003C_003Ec();
		}

		internal int QLlS3mLRA0N(Point pt)
		{
			return pt.Y;
		}

		internal int hfCS3K31KJL(Point pt)
		{
			return pt.X;
		}

		internal bool loaS3x6LhWG(LocalOcrTextBlock x)
		{
			return !string.IsNullOrEmpty(x.Text);
		}

		internal double rJoS3rYpwtm(LocalOcrTextBlock x)
		{
			return (double)(x.Rect.Top + x.Rect.Bottom) / 2.0;
		}

		internal int NsWS3pSMbp0(LocalOcrTextBlock x)
		{
			return x.Rect.Left;
		}

		internal bool Lk9S3BHv5Tc(string x)
		{
			return x.Any(_003C_003EO.p3CS3X6rI8B ?? (_003C_003EO.p3CS3X6rI8B = XRlL56iKFaTMc4ji9eS.EQHvNr1vadg));
		}

		internal bool MmoS3QlQI44(LocalOcrTextBlock x)
		{
			return !string.IsNullOrEmpty(x.Text);
		}

		internal double FxtS3jQ8me0(LocalOcrTextBlock x)
		{
			return (double)(x.Rect.Top + x.Rect.Bottom) / 2.0;
		}

		internal int r2US3nr5uXM(LocalOcrTextBlock x)
		{
			return x.Rect.Left;
		}

		internal static bool auIisOy2jYTbyWbxcVfA()
		{
			return W8Y057y2ecVLMH8o70KQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public Rectangle rfFS3lm6ySU;

		public int aNES3ivxcQJ;

		public int EbCS33fgAvT;

		internal static _003C_003Ec__DisplayClass0_0 oAog6Jy2Ei1A5JFIVCH0;

		internal Point CHgS3Uc3VSU(Point point)
		{
			return new Point(point.X + rfFS3lm6ySU.Left + aNES3ivxcQJ, point.Y + rfFS3lm6ySU.Top + EbCS33fgAvT);
		}

		internal static bool u8dKgny2GSB4HnQW5lyG()
		{
			return oAog6Jy2Ei1A5JFIVCH0 == null;
		}
	}

	private static dfsuXeYKgS8Je0MVxhj bf1WOvFlnAOVk09fT4m8;

	internal static IList<Point> wcOL5uQLUMe(string string_0, IList<string> ilist_0, maP9bQMwejOq3FEOUur maP9bQMwejOq3FEOUur_0, Rectangle rectangle_0, ActionExecuteContext actionExecuteContext_0, int int_0, int int_1, bool bool_0, out string string_1)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.aNES3ivxcQJ = int_0;
		_003C_003Ec__DisplayClass0_.EbCS33fgAvT = int_1;
		StringBuilder stringBuilder = new StringBuilder();
		IList<Point> list = new List<Point>();
		if (maP9bQMwejOq3FEOUur_0 == maP9bQMwejOq3FEOUur.AllScreens)
		{
			string_1 = "";
			Screen[] allScreens = Screen.AllScreens;
			foreach (Screen screen in allScreens)
			{
				string string_2;
				IList<Point> items = wcOL5uQLUMe(string_0, ilist_0, maP9bQMwejOq3FEOUur.Rect, screen.Bounds, actionExecuteContext_0, _003C_003Ec__DisplayClass0_.aNES3ivxcQJ, _003C_003Ec__DisplayClass0_.EbCS33fgAvT, bool_0, out string_2);
				stringBuilder.Append(string_2);
				list.AddRange(items);
			}
			if (list.Count == 0)
			{
				string_1 = "未在多个屏幕中找到文字。" + stringBuilder.ToString();
			}
			else
			{
				string_1 = stringBuilder.ToString();
			}
			return list;
		}
		_003C_003Ec__DisplayClass0_.rfFS3lm6ySU = Rectangle.Empty;
		switch (maP9bQMwejOq3FEOUur_0)
		{
		case maP9bQMwejOq3FEOUur.MainScreen:
			_003C_003Ec__DisplayClass0_.rfFS3lm6ySU = Screen.PrimaryScreen.Bounds;
			break;
		case maP9bQMwejOq3FEOUur.CurrentWindow:
		{
			IntPtr intPtr = actionExecuteContext_0.ActiveWindowHwnd;
			if (intPtr == IntPtr.Zero)
			{
				intPtr = NativeMethods.GetForegroundWindow();
			}
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
			_003C_003Ec__DisplayClass0_.rfFS3lm6ySU = new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top);
			break;
		}
		case maP9bQMwejOq3FEOUur.Rect:
			_003C_003Ec__DisplayClass0_.rfFS3lm6ySU = rectangle_0;
			break;
		}
		if (_003C_003Ec__DisplayClass0_.rfFS3lm6ySU.IsEmpty)
		{
			string_1 = "查找范围为空。";
			return list;
		}
		using Bitmap bitmap_ = BmpFinder.CopyScreen(_003C_003Ec__DisplayClass0_.rfFS3lm6ySU);
		(IList<Point> pointsInBmp, string log) tuple = JH4L5NYMgRj(bitmap_, string_0, ilist_0, bool_0);
		IList<Point> item = tuple.pointsInBmp;
		string item2 = tuple.log;
		string_1 = item2;
		return item.Select(_003C_003Ec__DisplayClass0_.CHgS3Uc3VSU).OrderBy(_003C_003Ec.w2WS35fLptk ?? (_003C_003Ec.w2WS35fLptk = _003C_003Ec.vHIS34xDoEl.QLlS3mLRA0N)).ThenBy(_003C_003Ec.muwS3D8vblX ?? (_003C_003Ec.muwS3D8vblX = _003C_003Ec.vHIS34xDoEl.hfCS3K31KJL))
			.ToList();
	}

	private static (IList<Point> pointsInBmp, string log) JH4L5NYMgRj(Bitmap bitmap_0, string string_0, IList<string> ilist_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = string_0.Any(_003C_003EO.p3CS3X6rI8B ?? (_003C_003EO.p3CS3X6rI8B = XRlL56iKFaTMc4ji9eS.EQHvNr1vadg));
		stringBuilder.Append($"查找内容({string_0}),中文:{flag}。");
		if (bool_0)
		{
			try
			{
				IList<Point> list = AiKL50isg1E(bitmap_0, string_0, ilist_0, flag, stringBuilder);
				if (list.HasData())
				{
					return (pointsInBmp: list, log: stringBuilder.ToString() + " Windows OCR找到文字");
				}
			}
			catch (Exception ex)
			{
				stringBuilder.Append("Windows OCR失败：" + ex.Message);
			}
		}
		else
		{
			stringBuilder.Append("已禁止WindowsOCR引擎。");
		}
		if (bfmVNpoIh0N1MPAqJ5v.LprgBF823Fu())
		{
			try
			{
				IList<Point> list2 = r9ZL5JTEt4Q(bitmap_0, string_0, ilist_0, flag, stringBuilder, 0);
				if (list2.HasData())
				{
					return (pointsInBmp: list2, log: stringBuilder.ToString() + " 离线OCR引擎找到文字。");
				}
				stringBuilder.Append("离线OCR引擎未能找到文字。");
			}
			catch (Exception ex2)
			{
				stringBuilder.Append("离线识别失败：" + ex2.Message);
			}
		}
		else
		{
			stringBuilder.Append("离线OCR引擎:不支持或未安装。");
		}
		return (pointsInBmp: Array.Empty<Point>(), log: stringBuilder.ToString());
	}

	private static IList<Point> r9ZL5JTEt4Q(Bitmap bitmap_0, string string_0, IList<string> ilist_0, bool bool_0, StringBuilder stringBuilder_0, int int_0)
	{
		IList<Point> list = new List<Point>();
		string string_1 = (bool_0 ? "" : "ENG");
		List<LocalOcrTextBlock> list2 = bfmVNpoIh0N1MPAqJ5v.YcGgBzsjlhg(bitmap_0, string_1)?.Where(_003C_003Ec.pNWS3dsYnHb ?? (_003C_003Ec.pNWS3dsYnHb = _003C_003Ec.vHIS34xDoEl.loaS3x6LhWG)).OrderBy(_003C_003Ec.M5cS3ogRVK8 ?? (_003C_003Ec.M5cS3ogRVK8 = _003C_003Ec.vHIS34xDoEl.rJoS3rYpwtm)).ThenBy(_003C_003Ec.knOS3TRR8XF ?? (_003C_003Ec.knOS3TRR8XF = _003C_003Ec.vHIS34xDoEl.NsWS3pSMbp0))
			.ToList();
		if (!list2.HasData())
		{
			throw new Exception("未能识别到文字");
		}
		IList<LocalOcrTextBlock> list3 = new List<LocalOcrTextBlock>();
		foreach (LocalOcrTextBlock item2 in list2)
		{
			if (item2.Text.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0 && item2.Text.Length < string_0.Length * 5)
			{
				list3.Add(item2);
			}
		}
		if (list3.Count == 0)
		{
			string value = string_0.Replace(" ", "");
			foreach (LocalOcrTextBlock item3 in list2)
			{
				if (item3.Text.Replace(" ", "").IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					list3.Add(item3);
				}
			}
		}
		if (list3.HasData())
		{
			foreach (LocalOcrTextBlock item4 in list3)
			{
				bool flag = false;
				if (item4.Text.Length > string_0.Length && int_0 == 0)
				{
					try
					{
						float num = 2f;
						using Bitmap bitmap_1 = n67L5aKRUIU(bitmap_0, item4.Rect);
						using Bitmap bitmap_2 = zBCL57onKpH(bitmap_1, num);
						(Point?, string, int) tuple = LihL5PXxKtd(bitmap_2, new string[1] { string_0 }, false, 1);
						if (tuple.Item1.HasValue)
						{
							Point item = new Point(item4.Rect.Left + (int)((float)tuple.Item1.Value.X / num), item4.Rect.Top + (int)((float)tuple.Item1.Value.Y / num));
							flag = true;
							list.Add(item);
						}
						else
						{
							stringBuilder_0.Append("放大后二次定位没有找到文字。");
						}
					}
					catch (Exception ex)
					{
						stringBuilder_0.Append("放大目标区域再次定位失败了:" + ex.Message + "。");
					}
				}
				int num2 = item4.Text.IndexOf(string_0, StringComparison.OrdinalIgnoreCase);
				if (!flag)
				{
					stringBuilder_0.Append("根据文字序号");
					list.Add(CNWL58omc9S(item4.Rect, ((double)num2 + (double)string_0.Length / 2.0) / (double)item4.Text.Length));
				}
			}
		}
		return list;
	}

	private static IList<Point> AiKL50isg1E(Bitmap bitmap_0, string string_0, IList<string> ilist_0, bool bool_0, StringBuilder stringBuilder_0)
	{
		IList<Point> list = new List<Point>();
		string string_1 = (bool_0 ? "zh-CN" : "en-US");
		OcrResult result = KJPvclMRZwxyLnfknnp.HuwLFF3cvkN(bitmap_0, string_1).GetAwaiter().GetResult();
		if (result.Text.IsNullOrEmpty())
		{
			throw new Exception("Windows内置OCR未能识别到文字");
		}
		string_0 = string_0.Replace(" ", "");
		foreach (OcrLine line in result.Lines)
		{
			string text = line.Text;
			if (text.Replace(" ", "").IndexOf(string_0, StringComparison.OrdinalIgnoreCase) < 0)
			{
				continue;
			}
			bool flag = false;
			foreach (OcrWord word in line.Words)
			{
				if (word.Text.Length >= string_0.Length && word.Text.Replace(" ", "").IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					Rectangle rectangle_ = new Rectangle((int)word.BoundingRect.Left, (int)word.BoundingRect.Top, (int)word.BoundingRect.Width, (int)word.BoundingRect.Height);
					int num = word.Text.Replace(" ", "").IndexOf(string_0, StringComparison.OrdinalIgnoreCase);
					list.Add(CNWL58omc9S(rectangle_, ((double)num + (double)string_0.Length / 2.0) / (double)word.Text.Length));
					flag = true;
				}
			}
			if (flag)
			{
				continue;
			}
			int num2 = text.Replace(" ", "").IndexOf(string_0, StringComparison.OrdinalIgnoreCase);
			int num3 = 0;
			OcrWord val = line.Words[0];
			OcrWord val2 = line.Words[0];
			foreach (OcrWord word2 in line.Words)
			{
				num3 += word2.Text.Replace(" ", "").Length;
				if (num3 <= num2)
				{
					val = word2;
				}
				if (num3 <= num2 + string_0.Length)
				{
					val2 = word2;
					continue;
				}
				break;
			}
			list.Add(new Point
			{
				X = (int)(val.BoundingRect.Left + val2.BoundingRect.Right) / 2,
				Y = (int)(val.BoundingRect.Top + val.BoundingRect.Bottom) / 2
			});
		}
		return list;
	}

	internal static (Point? point, int index) FxmL5CoOUgu(IList<string> ilist_0, maP9bQMwejOq3FEOUur maP9bQMwejOq3FEOUur_0, Rectangle rectangle_0, ActionExecuteContext actionExecuteContext_0, int int_0, int int_1, int int_2, bool bool_0, out string string_0)
	{
		if (maP9bQMwejOq3FEOUur_0 == maP9bQMwejOq3FEOUur.AllScreens)
		{
			string_0 = "";
			Screen[] allScreens = Screen.AllScreens;
			int num = 0;
			(Point?, int) result;
			while (true)
			{
				if (num < allScreens.Length)
				{
					Screen screen = allScreens[num];
					result = FxmL5CoOUgu(ilist_0, maP9bQMwejOq3FEOUur.Rect, screen.Bounds, actionExecuteContext_0, int_0, int_1, int_2, bool_0, out var string_1);
					if (result.Item1.HasValue)
					{
						break;
					}
					string_0 = string_0 + "屏幕" + screen.DeviceName + "未找到文字(" + string_1 + ")。";
					num++;
					continue;
				}
				return (point: null, index: -1);
			}
			return result;
		}
		Rectangle rect = Screen.PrimaryScreen.Bounds;
		switch (maP9bQMwejOq3FEOUur_0)
		{
		case maP9bQMwejOq3FEOUur.CurrentWindow:
		{
			IntPtr intPtr = actionExecuteContext_0.ActiveWindowHwnd;
			if (intPtr == IntPtr.Zero)
			{
				intPtr = NativeMethods.GetForegroundWindow();
			}
			NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
			rect = new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top);
			break;
		}
		case maP9bQMwejOq3FEOUur.Rect:
			rect = rectangle_0;
			break;
		}
		using Bitmap bitmap_ = BmpFinder.CopyScreen(rect);
		Point? point = null;
		(Point? point, string log, int index) tuple = LihL5PXxKtd(bitmap_, ilist_0, bool_0);
		point = tuple.point;
		string item = tuple.log;
		int item2 = tuple.index;
		string_0 = item;
		if (point.HasValue)
		{
			actionExecuteContext_0.ActionLogger.LogInfo(item);
			return (point: new Point(point.Value.X + rect.Left + int_1, point.Value.Y + rect.Top + int_2), index: item2);
		}
		return (point: null, index: -1);
	}

	private static (Point? point, string log, int index) LihL5PXxKtd(Bitmap bitmap_0, IList<string> ilist_0, bool bool_0, int int_0 = 0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool bool_1 = ilist_0.Any(_003C_003Ec.hDDS3MxZvEW ?? (_003C_003Ec.hDDS3MxZvEW = _003C_003Ec.vHIS34xDoEl.Lk9S3BHv5Tc));
		if (bool_0)
		{
			try
			{
				(Point?, int) tuple = VScL5yycBfj(bitmap_0, ilist_0, bool_1, stringBuilder);
				if (tuple.Item1.HasValue)
				{
					return (point: tuple.Item1, log: stringBuilder.ToString() + " Windows OCR找到文字", index: tuple.Item2);
				}
			}
			catch (Exception ex)
			{
				stringBuilder.Append("Windows OCR失败：" + ex.Message);
			}
		}
		else
		{
			stringBuilder.Append("已禁止WindowsOCR引擎");
		}
		if (bfmVNpoIh0N1MPAqJ5v.LprgBF823Fu())
		{
			try
			{
				(Point?, int) tuple2 = LOaL5EaH9U3(bitmap_0, ilist_0, bool_1, stringBuilder, int_0);
				if (tuple2.Item1.HasValue)
				{
					return (point: tuple2.Item1, log: stringBuilder.ToString() + "离线OCR引擎找到文字", index: tuple2.Item2);
				}
				stringBuilder.Append("离线OCR引擎未能找到文字。");
			}
			catch (Exception ex2)
			{
				stringBuilder.Append("离线识别失败：" + ex2.Message);
			}
		}
		else
		{
			stringBuilder.Append("离线OCR引擎:不支持或未安装。");
		}
		return (point: null, log: stringBuilder.ToString(), index: -1);
	}

	private static (Point? point, int index) LOaL5EaH9U3(Bitmap bitmap_0, IList<string> ilist_0, bool bool_0, StringBuilder stringBuilder_0, int int_0)
	{
		string string_ = (bool_0 ? "" : "ENG");
		List<LocalOcrTextBlock> list = bfmVNpoIh0N1MPAqJ5v.YcGgBzsjlhg(bitmap_0, string_)?.Where(_003C_003Ec.WDKS3AleOYG ?? (_003C_003Ec.WDKS3AleOYG = _003C_003Ec.vHIS34xDoEl.MmoS3QlQI44)).OrderBy(_003C_003Ec.KmgS3O3iaOH ?? (_003C_003Ec.KmgS3O3iaOH = _003C_003Ec.vHIS34xDoEl.FxtS3jQ8me0)).ThenBy(_003C_003Ec.mfpS3FnTb8O ?? (_003C_003Ec.mfpS3FnTb8O = _003C_003Ec.vHIS34xDoEl.r2US3nr5uXM))
			.ToList();
		if (!list.HasData())
		{
			throw new Exception("未能识别到文字");
		}
		int num = 0;
		string text;
		IList<LocalOcrTextBlock> list2;
		while (true)
		{
			if (num < ilist_0.Count)
			{
				text = ilist_0[num];
				list2 = new List<LocalOcrTextBlock>();
				foreach (LocalOcrTextBlock item in list)
				{
					if (item.Text.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0 && item.Text.Length < text.Length * 5)
					{
						list2.Add(item);
					}
				}
				if (list2.Count == 0)
				{
					string value = text.Replace(" ", "");
					foreach (LocalOcrTextBlock item2 in list)
					{
						if (item2.Text.Replace(" ", "").IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
						{
							list2.Add(item2);
						}
					}
				}
				if (list2.HasData())
				{
					break;
				}
				num++;
				continue;
			}
			return (point: null, index: -1);
		}
		LocalOcrTextBlock localOcrTextBlock = list2.First();
		if (localOcrTextBlock.Text.Length > text.Length && int_0 == 0)
		{
			try
			{
				float num2 = 2f;
				using Bitmap bitmap_1 = n67L5aKRUIU(bitmap_0, localOcrTextBlock.Rect);
				using Bitmap bitmap_2 = zBCL57onKpH(bitmap_1, num2);
				(Point?, string, int) tuple = LihL5PXxKtd(bitmap_2, new string[1] { text }, false, 1);
				if (tuple.Item1.HasValue)
				{
					Point value2 = new Point(localOcrTextBlock.Rect.Left + (int)((float)tuple.Item1.Value.X / num2), localOcrTextBlock.Rect.Top + (int)((float)tuple.Item1.Value.Y / num2));
					stringBuilder_0.Append(" 经过放大后二次定位成功。");
					return (point: value2, index: num);
				}
				stringBuilder_0.Append("放大后二次定位没有找到文字。");
			}
			catch (Exception ex)
			{
				stringBuilder_0.Append("放大目标区域再次定位失败了:" + ex.Message + "。");
			}
		}
		int num3 = localOcrTextBlock.Text.IndexOf(text, StringComparison.OrdinalIgnoreCase);
		return (point: CNWL58omc9S(localOcrTextBlock.Rect, ((double)num3 + (double)text.Length / 2.0) / (double)localOcrTextBlock.Text.Length), index: num);
	}

	private static (Point? point, int index) VScL5yycBfj(Bitmap bitmap_0, IList<string> ilist_0, bool bool_0, StringBuilder stringBuilder_0)
	{
		string string_ = (bool_0 ? "zh-CN" : "en-US");
		OcrResult result = KJPvclMRZwxyLnfknnp.HuwLFF3cvkN(bitmap_0, string_).GetAwaiter().GetResult();
		if (result.Text.IsNullOrEmpty())
		{
			throw new Exception("Windows内置OCR未能识别到文字");
		}
		for (int i = 0; i < ilist_0.Count; i++)
		{
			string text = ilist_0[i];
			text = text.Replace(" ", "");
			foreach (OcrLine line in result.Lines)
			{
				if (line.Text.Replace(" ", "").IndexOf(text, StringComparison.OrdinalIgnoreCase) < 0)
				{
					continue;
				}
				foreach (OcrWord word in line.Words)
				{
					if (word.Text.Length >= text.Length && word.Text.Replace(" ", "").IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						Rectangle rectangle_ = new Rectangle((int)word.BoundingRect.Left, (int)word.BoundingRect.Top, (int)word.BoundingRect.Width, (int)word.BoundingRect.Height);
						int num = word.Text.Replace(" ", "").IndexOf(text, StringComparison.OrdinalIgnoreCase);
						return (point: CNWL58omc9S(rectangle_, ((double)num + (double)text.Length / 2.0) / (double)word.Text.Length), index: i);
					}
				}
				int num2 = line.Text.Replace(" ", "").IndexOf(text, StringComparison.OrdinalIgnoreCase);
				int num3 = 0;
				OcrWord val = line.Words[0];
				OcrWord val2 = line.Words[0];
				foreach (OcrWord word2 in line.Words)
				{
					num3 += word2.Text.Replace(" ", "").Length;
					if (num3 <= num2)
					{
						val = word2;
					}
					if (num3 <= num2 + text.Length)
					{
						val2 = word2;
						continue;
					}
					break;
				}
				return (point: new Point
				{
					X = (int)(val.BoundingRect.Left + val2.BoundingRect.Right) / 2,
					Y = (int)(val.BoundingRect.Top + val.BoundingRect.Bottom) / 2
				}, index: i);
			}
		}
		stringBuilder_0.Append("Windows OCR未能找到文字。");
		return (point: null, index: -1);
	}

	private static Point CNWL58omc9S(Rectangle rectangle_0, double double_0)
	{
		return new Point((int)((double)rectangle_0.Left + (double)rectangle_0.Width * double_0), (int)((double)rectangle_0.Top + (double)rectangle_0.Height / 2.0));
	}

	private static Bitmap n67L5aKRUIU(Bitmap bitmap_0, Rectangle rectangle_0)
	{
		if (rectangle_0.Left >= 0 && rectangle_0.Top >= 0 && rectangle_0.Right <= bitmap_0.Width && rectangle_0.Bottom <= bitmap_0.Height)
		{
			Bitmap bitmap = new Bitmap(rectangle_0.Width, rectangle_0.Height);
			using Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(bitmap_0, new Rectangle(0, 0, rectangle_0.Width, rectangle_0.Height), rectangle_0, GraphicsUnit.Pixel);
			return bitmap;
		}
		throw new ArgumentOutOfRangeException("矩形超出了源图像的范围。");
	}

	private static Bitmap zBCL57onKpH(Bitmap bitmap_0, float float_0)
	{
		int width = (int)((float)bitmap_0.Width * float_0);
		int height = (int)((float)bitmap_0.Height * float_0);
		Bitmap bitmap = new Bitmap(width, height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.DrawImage(bitmap_0, new Rectangle(0, 0, width, height), new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), GraphicsUnit.Pixel);
		return bitmap;
	}

	internal static bool XMlR5PFle8uGniGZ7nGn()
	{
		return bf1WOvFlnAOVk09fT4m8 == null;
	}
}
