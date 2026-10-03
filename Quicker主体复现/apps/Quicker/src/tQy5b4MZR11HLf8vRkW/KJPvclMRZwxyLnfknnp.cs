using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities.Images;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.Win32;
using Windows.Foundation;
using Windows.Globalization;
using Windows.Graphics.Imaging;
using Windows.Media.Ocr;
using Windows.Storage.Streams;

namespace tQy5b4MZR11HLf8vRkW;

internal static class KJPvclMRZwxyLnfknnp
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec hFR220mgTEY;

		public static Func<OcrLine, string> Iiy22C8fi2f;

		public static Func<OcrWord, double> Mr622PR3CL0;

		public static Func<OcrWord, int> ysE22E7inWS;

		public static Func<Language, string> IYc22yjmWjo;

		internal static _003C_003Ec XP2Q9YyGDZOPnjENxU7c;

		static _003C_003Ec()
		{
			hFR220mgTEY = new _003C_003Ec();
		}

		internal string iPh2227DPWf(OcrLine line)
		{
			return line.Text;
		}

		internal double NlF22uURtqt(OcrWord x)
		{
			return x.BoundingRect.Width;
		}

		internal int WbI22Nr2m4G(OcrWord x)
		{
			return x.Text.Length;
		}

		internal string N3U22JUCq41(Language x)
		{
			return x.DisplayName;
		}

		internal static bool bu8l2pyG3O4Ouj0NCp6R()
		{
			return XP2Q9YyGDZOPnjENxU7c == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvertTo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SoftwareBitmap> _003C_003Et__builder;

		public Image image;

		private InMemoryRandomAccessStream _003Cstream_003E5__2;

		private TaskAwaiter<BitmapDecoder> _003C_003Eu__1;

		private TaskAwaiter<SoftwareBitmap> _003C_003Eu__2;

		internal static object YuTUchyG00cmSg4JKxwi;

		private void MoveNext()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			int num = _003C_003E1__state;
			SoftwareBitmap result;
			try
			{
				if ((uint)num > 1u)
				{
					_003Cstream_003E5__2 = new InMemoryRandomAccessStream();
				}
				try
				{
					TaskAwaiter<BitmapDecoder> awaiter = default(TaskAwaiter<BitmapDecoder>);
					TaskAwaiter<SoftwareBitmap> awaiter2 = default(TaskAwaiter<SoftwareBitmap>);
					int num2;
					if (num != 0)
					{
						if (num != 1)
						{
							image.Save(((IRandomAccessStream)(object)_003Cstream_003E5__2).AsStream(), ImageFormat.Bmp);
							awaiter = BitmapDecoder.CreateAsync((IRandomAccessStream)(object)_003Cstream_003E5__2).GetAwaiter<BitmapDecoder>();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00c4;
						}
						awaiter2 = _003C_003Eu__2;
						num2 = 1;
						if (ocZlynyG161msFvq4NYu())
						{
							goto IL_00ae;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<BitmapDecoder>);
						num2 = 0;
						if (!ocZlynyG161msFvq4NYu())
						{
							goto IL_00ae;
						}
					}
					goto IL_00bb;
					IL_00c4:
					awaiter2 = awaiter.GetResult().GetSoftwareBitmapAsync().GetAwaiter<SoftwareBitmap>();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0114;
					IL_00bb:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c4;
					IL_0114:
					result = awaiter2.GetResult();
					goto end_IL_0017;
					IL_00ae:
					switch (num2)
					{
					case 1:
						goto IL_00ff;
					}
					goto IL_00bb;
					IL_00ff:
					_003C_003Eu__2 = default(TaskAwaiter<SoftwareBitmap>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0114;
					end_IL_0017:;
				}
				finally
				{
					if (num < 0 && _003Cstream_003E5__2 != null)
					{
						((IDisposable)_003Cstream_003E5__2).Dispose();
					}
				}
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

		internal static bool ocZlynyG161msFvq4NYu()
		{
			return YuTUchyG00cmSg4JKxwi == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoOcr_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OcrResult> _003C_003Et__builder;

		public Image image;

		public string lang;

		private SoftwareBitmap _003CsoftwareBitmap_003E5__2;

		private TaskAwaiter<SoftwareBitmap> _003C_003Eu__1;

		private TaskAwaiter<OcrResult> _003C_003Eu__2;

		private static object nVKOkmyGv0D8bUlnwUok;

		private void MoveNext()
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			int num = _003C_003E1__state;
			OcrResult result2;
			try
			{
				TaskAwaiter<SoftwareBitmap> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0084;
					}
					int num2 = 0;
					if (nVKOkmyGv0D8bUlnwUok != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					if (!NativeMethods.IsOnWindows10OrLater())
					{
						throw new InvalidOperationException("本功能仅支持Windows10以上操作系统。");
					}
					awaiter = CNuLFMjU3Tx(image).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<SoftwareBitmap>);
					num = -1;
					_003C_003E1__state = -1;
				}
				SoftwareBitmap result = awaiter.GetResult();
				_003CsoftwareBitmap_003E5__2 = result;
				goto IL_0084;
				IL_0084:
				try
				{
					TaskAwaiter<OcrResult> awaiter2;
					int num4;
					if (num != 1)
					{
						OcrEngine val = null;
						if (string.IsNullOrEmpty(lang))
						{
							val = OcrEngine.TryCreateFromUserProfileLanguages();
						}
						else
						{
							Language val2 = new Language(lang);
							if (OcrEngine.IsLanguageSupported(val2))
							{
								val = OcrEngine.TryCreateFromLanguage(val2);
							}
							else
							{
								ATJLFUSW0Co.Warn("您的Windows不支持此OCR引擎：" + val2.LanguageTag + ". 当前支持的语言：" + string.Join(",", OcrEngine.AvailableRecognizerLanguages.Select(_003C_003Ec.IYc22yjmWjo ?? (_003C_003Ec.IYc22yjmWjo = _003C_003Ec.hFR220mgTEY.N3U22JUCq41))) + "。");
								val = OcrEngine.TryCreateFromUserProfileLanguages();
							}
						}
						if (val == null)
						{
							throw new InvalidOperationException("无法创建OCR引擎。");
						}
						string languageTag = val.RecognizerLanguage.LanguageTag;
						awaiter2 = val.RecognizeAsync(_003CsoftwareBitmap_003E5__2).GetAwaiter<OcrResult>();
						num4 = 0;
						if (nVKOkmyGv0D8bUlnwUok == null)
						{
							goto IL_0179;
						}
						goto IL_018e;
					}
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<OcrResult>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01df;
					IL_01df:
					result2 = awaiter2.GetResult();
					goto end_IL_0084;
					IL_018e:
					switch (num4)
					{
					case 1:
						goto IL_019e;
					}
					goto IL_0179;
					IL_019e:
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
					IL_0179:
					if (!awaiter2.IsCompleted)
					{
						num4 = 1;
						if (!o2Wy4DyGdEQcg7P8hlSu())
						{
							goto IL_018e;
						}
						goto IL_019e;
					}
					goto IL_01df;
					end_IL_0084:;
				}
				finally
				{
					if (num < 0 && _003CsoftwareBitmap_003E5__2 != null)
					{
						((IDisposable)_003CsoftwareBitmap_003E5__2).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CsoftwareBitmap_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CsoftwareBitmap_003E5__2 = null;
			_003C_003Et__builder.SetResult(result2);
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

		internal static bool o2Wy4DyGdEQcg7P8hlSu()
		{
			return nVKOkmyGv0D8bUlnwUok == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COcrImage_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IList<string>> _003C_003Et__builder;

		public Image image;

		public string lang;

		private Bitmap _003CresizedBmp_003E5__2;

		private SoftwareBitmap _003CsoftwareBitmap_003E5__3;

		private string _003ClanguageTag_003E5__4;

		private TaskAwaiter<SoftwareBitmap> _003C_003Eu__1;

		private TaskAwaiter<OcrResult> _003C_003Eu__2;

		private static object xhTZMeyGkh4oJeA8Xjw2;

		private void MoveNext()
		{
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			int num = _003C_003E1__state;
			IList<string> result3 = default(IList<string>);
			try
			{
				if ((uint)num > 1u)
				{
					if (!NativeMethods.IsOnWindows10OrLater())
					{
						throw new InvalidOperationException("本功能仅支持Windows10以上操作系统。");
					}
					double num2 = ((image.Width < 100 || image.Height < 100) ? 2.0 : 1.5);
					_003CresizedBmp_003E5__2 = ImageHelper.ResizeImage(image, (int)((double)image.Width * num2), (int)((double)image.Height * num2));
				}
				try
				{
					TaskAwaiter<SoftwareBitmap> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00eb;
						}
						awaiter = CNuLFMjU3Tx(_003CresizedBmp_003E5__2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<SoftwareBitmap>);
						int num3 = 0;
						if (!jOtvQKyGajDOSD4qE0aa())
						{
							int num4 = default(int);
							num3 = num4;
						}
						switch (num3)
						{
						}
						num = -1;
						_003C_003E1__state = -1;
					}
					SoftwareBitmap result = awaiter.GetResult();
					_003CsoftwareBitmap_003E5__3 = result;
					goto IL_00eb;
					IL_00eb:
					try
					{
						OcrEngine val = default(OcrEngine);
						int num5;
						int num6 = default(int);
						if (num != 1)
						{
							val = null;
							if (string.IsNullOrEmpty(lang))
							{
								val = OcrEngine.TryCreateFromUserProfileLanguages();
								goto IL_01e5;
							}
							Language val2 = new Language(lang);
							if (!OcrEngine.IsLanguageSupported(val2))
							{
								throw new Exception("您的Windows不支持此OCR引擎：" + val2.LanguageTag + ".");
							}
							val = OcrEngine.TryCreateFromLanguage(val2);
							num5 = 0;
							if (xhTZMeyGkh4oJeA8Xjw2 != null)
							{
								num5 = num6;
							}
							goto IL_024f;
						}
						TaskAwaiter<OcrResult> awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<OcrResult>);
						num6 = 2;
						goto IL_0178;
						IL_024f:
						switch (num5)
						{
						case 2:
							break;
						default:
							goto IL_01e5;
						case 1:
							goto end_IL_00eb;
						}
						goto IL_0178;
						IL_0181:
						OcrResult result2 = awaiter2.GetResult();
						if (!_003ClanguageTag_003E5__4.StartsWith("zh", StringComparison.OrdinalIgnoreCase) && !_003ClanguageTag_003E5__4.StartsWith("ja", StringComparison.OrdinalIgnoreCase) && !_003ClanguageTag_003E5__4.StartsWith("ko", StringComparison.OrdinalIgnoreCase))
						{
							result3 = result2.Lines.Select(_003C_003Ec.Iiy22C8fi2f ?? (_003C_003Ec.Iiy22C8fi2f = _003C_003Ec.hFR220mgTEY.iPh2227DPWf)).ToList();
							num5 = 1;
							if (xhTZMeyGkh4oJeA8Xjw2 != null)
							{
								goto IL_01e5;
							}
							goto IL_024f;
						}
						IList<OcrWord> list = new List<OcrWord>();
						Rect rect = Rect.Empty;
						IList<string> list2 = new List<string>();
						IEnumerator<OcrLine> enumerator = result2.Lines.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								OcrLine current = enumerator.Current;
								bool flag = true;
								IEnumerator<OcrWord> enumerator2 = current.Words.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										OcrWord current2 = enumerator2.Current;
										if (flag && Math.Abs(current2.BoundingRect.Top - rect.Top) > rect.Height * 0.8)
										{
											if (list.HasData())
											{
												nq3LF5x9BpY(list, list2);
												if (xhTZMeyGkh4oJeA8Xjw2 == null)
												{
													switch (0)
													{
													}
												}
											}
											list.Clear();
										}
										list.Add(current2);
										flag = false;
										rect = current2.BoundingRect;
									}
								}
								finally
								{
									if (num < 0)
									{
										enumerator2?.Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
						if (list.HasData())
						{
							nq3LF5x9BpY(list, list2);
						}
						result3 = wdeLFDWdMng(string.Join("\r\n", list2)).Split(new string[1] { "\r\n" }, StringSplitOptions.None);
						goto end_IL_00eb;
						IL_01e5:
						if (val != null)
						{
							_003ClanguageTag_003E5__4 = val.RecognizerLanguage.LanguageTag;
							awaiter2 = val.RecognizeAsync(_003CsoftwareBitmap_003E5__3).GetAwaiter<OcrResult>();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0181;
						}
						throw new InvalidOperationException("无法创建OCR引擎。");
						IL_0178:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0181;
						end_IL_00eb:;
					}
					finally
					{
						if (num < 0 && _003CsoftwareBitmap_003E5__3 != null)
						{
							((IDisposable)_003CsoftwareBitmap_003E5__3).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _003CresizedBmp_003E5__2 != null)
					{
						((IDisposable)_003CresizedBmp_003E5__2).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CresizedBmp_003E5__2 = null;
				_003CsoftwareBitmap_003E5__3 = null;
				_003ClanguageTag_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CresizedBmp_003E5__2 = null;
			_003CsoftwareBitmap_003E5__3 = null;
			_003ClanguageTag_003E5__4 = null;
			_003C_003Et__builder.SetResult(result3);
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

		internal static bool jOtvQKyGajDOSD4qE0aa()
		{
			return xhTZMeyGkh4oJeA8Xjw2 == null;
		}
	}

	private static readonly ILog ATJLFUSW0Co;

	internal static object hK8KCmFMsuEZPoPvb4Sf;

	[AsyncStateMachine(typeof(_003COcrImage_003Ed__1))]
	public static Task<IList<string>> e0qLF4C5gse(Image image_0, string string_0 = null)
	{
		_003COcrImage_003Ed__1 stateMachine = default(_003COcrImage_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IList<string>>.Create();
		stateMachine.image = image_0;
		stateMachine.lang = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static void nq3LF5x9BpY(IList<OcrWord> ilist_0, IList<string> ilist_1)
	{
		if (ilist_0.HasData())
		{
			StringBuilder stringBuilder = new StringBuilder();
			OcrWord val = null;
			double num = ilist_0.Sum(_003C_003Ec.Mr622PR3CL0 ?? (_003C_003Ec.Mr622PR3CL0 = _003C_003Ec.hFR220mgTEY.NlF22uURtqt)) / (double)ilist_0.Sum(_003C_003Ec.ysE22E7inWS ?? (_003C_003Ec.ysE22E7inWS = _003C_003Ec.hFR220mgTEY.WbI22Nr2m4G));
			for (int i = 0; i < ilist_0.Count; i++)
			{
				OcrWord val2 = ilist_0[i];
				if (i == 0)
				{
					stringBuilder.Append(val2.Text);
				}
				else
				{
					if (val != null)
					{
						char value = val.Text.Last();
						if (Math.Abs(val.BoundingRect.Right - val2.BoundingRect.Left) > num * 0.6 && "。；，？！、“”‘’（）—".IndexOf(value) < 0 && ".;,?!\\\"\"''()-".IndexOf(value) < 0)
						{
							stringBuilder.Append(' ');
						}
					}
					stringBuilder.Append(val2.Text);
				}
				val = val2;
			}
			ilist_1.Add(stringBuilder.ToString());
		}
		else
		{
			ilist_1.Add(string.Empty);
		}
	}

	private static string wdeLFDWdMng(string string_0)
	{
		return System.Text.RegularExpressions.Regex.Replace(string_0 ?? "", @"(?<=[\p{IsCJKUnifiedIdeographs}])[ \t]+(?=[\p{IsCJKUnifiedIdeographs}])", "");
	}

	private static double M5qLFdwYmSa(OcrWord ocrWord_0, double double_0)
	{
		if (ocrWord_0.Text.Length > 0)
		{
			return Math.Max(ocrWord_0.BoundingRect.Width / (double)ocrWord_0.Text.Length, 16.0 * double_0);
		}
		return 16.0;
	}

	private static bool gNpLFou7NVV(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		char c = string_0[string_0.Length - 1];
		if (!c.IsLower())
		{
			return c.IsUpper();
		}
		return true;
	}

	private static bool xv7LFTwFikp(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		char c = string_0[0];
		if (!c.IsLower())
		{
			return c.IsUpper();
		}
		return true;
	}

	[AsyncStateMachine(typeof(_003CConvertTo_003Ed__7))]
	private static Task<SoftwareBitmap> CNuLFMjU3Tx(Image image_0)
	{
		_003CConvertTo_003Ed__7 stateMachine = default(_003CConvertTo_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<SoftwareBitmap>.Create();
		stateMachine.image = image_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static string QJZLFA9lDQK(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		stringBuilder.Append(string_0[0]);
		int num2 = default(int);
		for (int i = 1; i < string_0.Length - 1; i++)
		{
			if (string_0[i] == ' ')
			{
				int num = 0;
				if (hK8KCmFMsuEZPoPvb4Sf != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (cu0LFOE86MU(string_0[i - 1]) && cu0LFOE86MU(string_0[i + 1]))
				{
					continue;
				}
			}
			stringBuilder.Append(string_0[i]);
		}
		stringBuilder.Append(string_0[string_0.Length - 1]);
		return stringBuilder.ToString();
	}

	private static bool cu0LFOE86MU(char char_0)
	{
		if (char_0 < '㐀' || char_0 > '䶵')
		{
			if (char_0 >= '一')
			{
				goto IL_0162;
			}
			goto IL_0179;
		}
		goto IL_01bd;
		IL_0187:
		if ((char_0 < 168192 || char_0 > 173791) && (char_0 < 173824 || char_0 > 177972))
		{
			if (char_0 >= 177984)
			{
				return char_0 <= 178205;
			}
			return false;
		}
		goto IL_01bd;
		IL_00f9:
		int num;
		if ((char_0 < 143616 || char_0 > 148991) && (char_0 < 148992 || char_0 > 155903) && (char_0 < 155904 || char_0 > 161279))
		{
			if (char_0 >= 161280)
			{
				num = 2;
				if (hK8KCmFMsuEZPoPvb4Sf != null)
				{
					goto IL_0147;
				}
				goto IL_014b;
			}
			goto IL_0187;
		}
		goto IL_01bd;
		IL_0162:
		if (char_0 > '拿')
		{
			goto IL_0179;
		}
		goto IL_01bd;
		IL_0179:
		if ((char_0 < '挀' || char_0 > '挀') && (char_0 < '砀' || char_0 > '賿') && (char_0 < '贀' || char_0 > '鿌') && (char_0 < '⺀' || char_0 > '⿕') && (char_0 < '㆐' || char_0 > '㆟') && (char_0 < '㐀' || char_0 > '䶿') && (char_0 < '一' || char_0 > '鿌') && (char_0 < '豈' || char_0 > '節') && (char_0 < 131072 || char_0 > 136703))
		{
			if (char_0 < 136704)
			{
				goto IL_00f9;
			}
			if (char_0 > 143615)
			{
				num = 0;
				if (!W18pf8FMCX3CUxZZguu0())
				{
					goto IL_0147;
				}
				goto IL_014b;
			}
		}
		goto IL_01bd;
		IL_01bd:
		return true;
		IL_014b:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				goto end_IL_014b;
			case 3:
				goto IL_0162;
			case 1:
				goto IL_0187;
			}
			if (char_0 > 168191)
			{
				num = 1;
				if (W18pf8FMCX3CUxZZguu0())
				{
					continue;
				}
				goto IL_0187;
			}
			goto IL_01bd;
			continue;
			end_IL_014b:
			break;
		}
		goto IL_00f9;
		IL_0147:
		int num2 = default(int);
		num = num2;
		goto IL_014b;
	}

	[AsyncStateMachine(typeof(_003CDoOcr_003Ed__10))]
	internal static Task<OcrResult> HuwLFF3cvkN(Image image_0, string string_0)
	{
		_003CDoOcr_003Ed__10 stateMachine = default(_003CDoOcr_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OcrResult>.Create();
		stateMachine.image = image_0;
		stateMachine.lang = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static KJPvclMRZwxyLnfknnp()
	{
		ATJLFUSW0Co = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool W18pf8FMCX3CUxZZguu0()
	{
		return hK8KCmFMsuEZPoPvb4Sf == null;
	}
}
