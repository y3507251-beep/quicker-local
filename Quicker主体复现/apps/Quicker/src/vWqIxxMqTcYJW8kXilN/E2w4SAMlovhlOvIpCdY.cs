using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using eqOmvXXN5XVBTDBbWA2;
using ntFLI7iwvZZfgRBvVis;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.Progress;

namespace vWqIxxMqTcYJW8kXilN;

internal class E2w4SAMlovhlOvIpCdY
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public bool qM5SzJ6Hu9g;

		public ActionExecuteContext PJBSz0oieZ5;

		public CancellationTokenSource NVDSzCLfPtO;

		public HttpClientWithProgress S1VSzPa2034;

		public long ypDSzES05EF;

		public int vmnSzyxfJt5;

		internal static _003C_003Ec__DisplayClass0_0 qcyEFCyAP1uHdPGw2nGp;

		internal void xA1SzNFw8U9(long? size, long downloaded, double? percentage)
		{
			double num = 50.0;
			if (percentage.HasValue)
			{
				num = percentage.Value;
			}
			if (!qM5SzJ6Hu9g)
			{
				return;
			}
			long len = (long)((double)downloaded * 1000.0 / (double)(AppHelper.fLiLTj0x4QY() - ypDSzES05EF));
			int id = vmnSzyxfJt5;
			string saveFileName = S1VSzPa2034.SaveFileName;
			double percentage2 = num;
			string[] obj = new string[5]
			{
				len.ToReadableSize(),
				"/S  ",
				downloaded.ToReadableSize(),
				"/",
				null
			};
			object obj2;
			if (!size.HasValue)
			{
				obj2 = null;
			}
			else
			{
				obj2 = size.GetValueOrDefault().ToReadableSize();
				if (obj2 != null)
				{
					goto IL_00a4;
				}
			}
			obj2 = "-";
			goto IL_00a4;
			IL_00a4:
			obj[4] = (string)obj2;
			ProgressReportMgr.UpdateProgress(id, "", saveFileName, percentage2, string.Concat(obj), PJBSz0oieZ5?.Id ?? 0, NVDSzCLfPtO);
		}

		internal static bool TyvIWEyAMsfb82fgtfvF()
		{
			return qcyEFCyAP1uHdPGw2nGp == null;
		}
	}

	private static E2w4SAMlovhlOvIpCdY XZDwSwFlzcQGeeCXoZr7;

	public static string fKBLD6NAWdP(string string_0, double double_0 = 5.0, bool bool_0 = true, string string_1 = null, string string_2 = null, string string_3 = null, ActionExecuteContext actionExecuteContext_0 = null, string string_4 = null, string string_5 = null, string string_6 = null)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.qM5SzJ6Hu9g = bool_0;
		_003C_003Ec__DisplayClass0_.PJBSz0oieZ5 = actionExecuteContext_0;
		HttpClientHandler handler = new HttpClientHandler
		{
			UseCookies = false
		};
		int num = 0;
		if (XZDwSwFlzcQGeeCXoZr7 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (string.IsNullOrEmpty(string_1))
			{
				string_1 = KnownFolders.GetPath(KnownFolder.Downloads);
			}
			FileSystemHelper.EnsureFolderExists(string_1);
			if (double_0 <= 1E-07)
			{
				double_0 = 2147483647.0;
			}
			_003C_003Ec__DisplayClass0_.NVDSzCLfPtO = new CancellationTokenSource();
			_003C_003Ec__DisplayClass0_.S1VSzPa2034 = new HttpClientWithProgress(string_0, string_1, string_2, string_3, handler, _003C_003Ec__DisplayClass0_.PJBSz0oieZ5, (int)(double_0 * 1000.0), _003C_003Ec__DisplayClass0_.NVDSzCLfPtO);
			try
			{
        string[] array = default;
        int i = default;
				_003C_003Ec__DisplayClass0_.S1VSzPa2034.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
				{
					NoCache = true
				};
				int num3 = 1;
				if (!rBpaw5FZV1Eif0x0nBBk())
				{
					goto IL_00db;
				}
				goto IL_0136;
				IL_00db:
				if (!string.IsNullOrEmpty(string_4))
				{
					_003C_003Ec__DisplayClass0_.S1VSzPa2034.DefaultRequestHeaders.Add("User-Agent", string_4);
				}
				array = default(string[]);
				i = default(int);
				if (!string.IsNullOrEmpty(string_5))
				{
					array = string_5.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
					i = 0;
					num3 = 0;
					if (XZDwSwFlzcQGeeCXoZr7 != null)
					{
						int num4 = default(int);
						num3 = num4;
					}
					goto IL_0136;
				}
				goto IL_01a4;
				IL_0136:
				switch (num3)
				{
				case 1:
					break;
				default:
					goto IL_019c;
				}
				goto IL_00db;
				IL_01a4:
				if (!string.IsNullOrEmpty(string_6))
				{
					_003C_003Ec__DisplayClass0_.S1VSzPa2034.DefaultRequestHeaders.Add("Cookie", string_6);
				}
				_003C_003Ec__DisplayClass0_.vmnSzyxfJt5 = ProgressReportMgr.RequestProgressId();
				_003C_003Ec__DisplayClass0_.ypDSzES05EF = AppHelper.fLiLTj0x4QY();
				try
				{
					if (_003C_003Ec__DisplayClass0_.qM5SzJ6Hu9g)
					{
						ProgressReportMgr.UpdateProgress(_003C_003Ec__DisplayClass0_.vmnSzyxfJt5, "", _003C_003Ec__DisplayClass0_.S1VSzPa2034.SaveFileName, 0.0, "准备下载", _003C_003Ec__DisplayClass0_.PJBSz0oieZ5?.Id ?? 0, _003C_003Ec__DisplayClass0_.NVDSzCLfPtO);
					}
					_003C_003Ec__DisplayClass0_.S1VSzPa2034.ProgressChanged += _003C_003Ec__DisplayClass0_.xA1SzNFw8U9;
					_003C_003Ec__DisplayClass0_.S1VSzPa2034.StartDownload().GetAwaiter().GetResult();
				}
				catch (TaskCanceledException innerException)
				{
					throw new OperationCanceledException("下载已超时或取消", innerException);
				}
				catch (Exception ex)
				{
					throw new OperationCanceledException("下载出错：" + ex.Message, ex);
				}
				finally
				{
					if (_003C_003Ec__DisplayClass0_.qM5SzJ6Hu9g)
					{
						ProgressReportMgr.RemoveProgress(_003C_003Ec__DisplayClass0_.vmnSzyxfJt5);
					}
				}
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass0_.S1VSzPa2034.ContentMD5) && !string.Equals(eXCKbmiAn2aWIr09iBV.SAdvwX6aEsP(_003C_003Ec__DisplayClass0_.S1VSzPa2034.FullPathName), _003C_003Ec__DisplayClass0_.S1VSzPa2034.ContentMD5, StringComparison.OrdinalIgnoreCase))
				{
					throw new Exception("文件下载不完整，MD5校验失败。");
				}
				return _003C_003Ec__DisplayClass0_.S1VSzPa2034.FullPathName;
				IL_019c:
				for (; i < array.Length; i++)
				{
					string text = array[i];
					int num5 = text.IndexOf(':');
					if (num5 >= 0)
					{
						_003C_003Ec__DisplayClass0_.S1VSzPa2034.DefaultRequestHeaders.Add(text.Substring(0, num5), (text.Length > num5 + 1) ? text.Substring(num5 + 1) : string.Empty);
					}
				}
				goto IL_01a4;
			}
			finally
			{
				if (_003C_003Ec__DisplayClass0_.S1VSzPa2034 != null)
				{
					((IDisposable)_003C_003Ec__DisplayClass0_.S1VSzPa2034).Dispose();
				}
			}
		}
	}

	public static string Y9qLDXm4hQu(string string_0, bool bool_0 = true, string string_1 = null, string string_2 = null)
	{
		using N4iMQlXvFGVBcTKiGAT n4iMQlXvFGVBcTKiGAT = new N4iMQlXvFGVBcTKiGAT();
		using Stream stream = n4iMQlXvFGVBcTKiGAT.OpenRead(string_0);
		if (stream == null)
		{
			throw new InvalidOperationException("读取到的内容为空。");
		}
		string text = string.Empty;
		int num = 1;
		if (!rBpaw5FZV1Eif0x0nBBk())
		{
			goto IL_00ab;
		}
		goto IL_00af;
		IL_00af:
		string text2 = default(string);
		do
		{
			switch (num)
			{
			case 1:
				if (n4iMQlXvFGVBcTKiGAT.ResponseHeaders["Content-Length"].TryConvertToInt() > 0)
				{
					string text3 = n4iMQlXvFGVBcTKiGAT.ResponseHeaders["content-disposition"];
					if (!string.IsNullOrEmpty(text3))
					{
						text = new ContentDisposition(text3).FileName;
					}
					text = text.Trim(' ', '"');
					if (string.IsNullOrEmpty(text))
					{
						goto IL_009e;
					}
					goto IL_00ed;
				}
				throw new InvalidDataException("返回的请求长度为0");
			default:
			{
				string fileName = Path.GetFileName(n4iMQlXvFGVBcTKiGAT.CwOgJFUKW1T().LocalPath);
				if (!string.IsNullOrEmpty(fileName))
				{
					text = fileName;
				}
				goto IL_00ed;
			}
			case 2:
				break;
				IL_00ed:
				if (string.IsNullOrEmpty(text))
				{
					text = string_2.Or("quicker_download_" + string_0.ToValidFileName() + $"_{DateTime.Now:yyyyMMdd_hhmmss}.file");
				}
				text2 = "";
				if (text.Length > 0)
				{
					string path = KnownFolders.GetPath(KnownFolder.Downloads);
					try
					{
						if (!Directory.Exists(path))
						{
							Directory.CreateDirectory(path);
						}
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("下载目录(" + path + ")不存在，并且无法创建。错误：" + ex.Message);
						return "";
					}
					text2 = Path.Combine(path, text);
					while (File.Exists(text2))
					{
						text2 = Path.Combine(path, Path.GetFileNameWithoutExtension(text) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(text));
					}
					Stream stream2 = File.Create(text2);
					stream.CopyTo(stream2);
					stream2.Close();
					stream.Close();
					break;
				}
				throw new InvalidOperationException("无法确定文件名。");
			}
			return text2;
			IL_009e:
			num = 0;
		}
		while (XZDwSwFlzcQGeeCXoZr7 == null);
		goto IL_00ab;
		IL_00ab:
		int num2 = default(int);
		num = num2;
		goto IL_00af;
	}

	internal static bool rBpaw5FZV1Eif0x0nBBk()
	{
		return XZDwSwFlzcQGeeCXoZr7 == null;
	}
}
