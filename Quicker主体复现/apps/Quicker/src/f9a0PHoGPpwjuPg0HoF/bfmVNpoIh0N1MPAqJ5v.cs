using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using NamedPipeWrapper;
using Newtonsoft.Json;
using Quicker.Actions.XActions.BuildinRunners.Network;
using Quicker.Modules.OCR;
using Quicker.Public.Extensions;
using QuickerOcrAgent.Vm;
using WcdJQYXW9E2moeWW9Np;

namespace f9a0PHoGPpwjuPg0HoF;

internal static class bfmVNpoIh0N1MPAqJ5v
{
	internal class v3lj0GuJWgwiBbYyrZ0 : IDisposable
	{
		private NamedPipeClient<string> be1S66g5hIj;

		private AutoResetEvent A8GS6Xnkide = new AutoResetEvent(false);

		private string o6FS6m7fCyl = string.Empty;

		private static v3lj0GuJWgwiBbYyrZ0 wj3lcSWl0YOT5inV3V4H;

		public v3lj0GuJWgwiBbYyrZ0()
		{
			be1S66g5hIj = new NamedPipeClient<string>("QUICKER_OCR_CHANNEL")
			{
				MaxConnectRetryCount = 10,
				AutoReconnect = false
			};
			be1S66g5hIj.ServerMessage += dtoS61vAGFB;
			be1S66g5hIj.Disconnected += yMiS6H1JQQ2;
		}

		private void yMiS6H1JQQ2(NamedPipeConnection<string, string> namedPipeConnection_0)
		{
			A8GS6Xnkide.Set();
		}

		private void dtoS61vAGFB(NamedPipeConnection<string, string> namedPipeConnection_0, string string_1)
		{
			o6FS6m7fCyl = string_1;
			A8GS6Xnkide.Set();
		}

		public OcrResult MakS6b1EtWx(OcrRequest ocrRequest_0)
		{
			be1S66g5hIj.Start();
			be1S66g5hIj.WaitForConnection(1000);
			if (!be1S66g5hIj.IsConnected())
			{
				throw new Exception("无法成功连接Ocr引擎");
			}
			be1S66g5hIj.PushMessage(JsonConvert.SerializeObject(ocrRequest_0));
			A8GS6Xnkide.WaitOne(15000);
			try
			{
				be1S66g5hIj.Stop();
			}
			catch
			{
			}
			if (!string.IsNullOrEmpty(o6FS6m7fCyl))
			{
				return JsonConvert.DeserializeObject<OcrResult>(o6FS6m7fCyl);
			}
			return null;
		}

		public void Dispose()
		{
			be1S66g5hIj.ServerMessage -= dtoS61vAGFB;
			be1S66g5hIj.Disconnected -= yMiS6H1JQQ2;
			A8GS6Xnkide?.Dispose();
			try
			{
				be1S66g5hIj.Stop();
			}
			catch (Exception ex)
			{
				xdqgQvkd90M.Warn("LocalOCRRequestWrapper Dispose error: " + ex.Message, ex);
			}
		}

		internal static bool LrJumTWl1yXobCnaP8jO()
		{
			return wj3lcSWl0YOT5inV3V4H == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec A71S6Ds9QCc;

		public static Func<LocalOcrTextBlock, int> NYvS6dADqiB;

		public static Func<List<LocalOcrTextBlock>, bool> PgAS6ongZkM;

		public static Func<List<LocalOcrTextBlock>, int> wI9S6TtHfN2;

		public static Func<LocalOcrTextBlock, int> bc1S6MEX5vC;

		public static Func<LocalOcrTextBlock, int> FBES6AOMFEr;

		public static Func<LocalOcrTextBlock, int> jmtS6OVQGQi;

		public static Func<LocalOcrTextBlock, int> xTRS6FxUk6G;

		public static Func<LocalOcrTextBlock, int> l3gS6UAAiVV;

		public static Func<LocalOcrTextBlock, int> QjdS6lbeCrp;

		public static Comparison<LocalOcrTextBlock> FZFS6ipegPM;

		internal static _003C_003Ec OOMjFlWlvZ9UhSbrxaXb;

		static _003C_003Ec()
		{
			A71S6Ds9QCc = new _003C_003Ec();
		}

		internal int WaDS6KCRf5A(LocalOcrTextBlock x)
		{
			return x.Core.Y;
		}

		internal bool lQeS6xKgPd8(List<LocalOcrTextBlock> x)
		{
			return x.Count > 0;
		}

		internal int ocAS6r9b5q7(List<LocalOcrTextBlock> x)
		{
			return x.First().Rect.Left;
		}

		internal int DYES6pKValy(LocalOcrTextBlock x)
		{
			return x.Rect.Top;
		}

		internal int n01S6BTO7ng(LocalOcrTextBlock x)
		{
			return x.Rect.Bottom;
		}

		internal int PpIS6Q6TqNV(LocalOcrTextBlock x)
		{
			return x.Height;
		}

		internal int OdXS6jKSOSq(LocalOcrTextBlock x)
		{
			return x.Height;
		}

		internal int sZHS6nbaKW4(LocalOcrTextBlock x)
		{
			return x.Rect.Top;
		}

		internal int UpvS641m5yZ(LocalOcrTextBlock x)
		{
			return x.Rect.Bottom;
		}

		internal int z58S65ShTZJ(LocalOcrTextBlock x1, LocalOcrTextBlock x2)
		{
			return x1.Core.X.CompareTo(x2.Core.X);
		}

		internal static void Yus0okWlJhRuxeGcKNpR()
		{
		}

		internal static bool JHGgl5WldSZ7bkRxX7WX()
		{
			return OOMjFlWlvZ9UhSbrxaXb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public Image WBAS6ffs2BG;

		private static _003C_003Ec__DisplayClass11_0 yFgX55WlaBdkqaDACxQP;

		internal (bool success, string result) mEPS63G0T6d()
		{
			return kL1gB3rjR4g(WBAS6ffs2BG);
		}

		internal static bool SYqcAUWlruKT1Gy7ALCM()
		{
			return yFgX55WlaBdkqaDACxQP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetTextFromImageAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool success, string result)> _003C_003Et__builder;

		public Image img;

		private TaskAwaiter<(bool success, string result)> _003C_003Eu__1;

		internal static object dYRlULWl9OP6odcG2HLJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				TaskAwaiter<(bool, string)> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run((Func<(bool, string)>)new _003C_003Ec__DisplayClass11_0
					{
						WBAS6ffs2BG = img
					}.mEPS63G0T6d).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					if (!de0P2wWlL1ycDbsxBa64())
					{
						switch (0)
						{
						}
					}
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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

		internal static bool de0P2wWlL1ycDbsxBa64()
		{
			return dYRlULWl9OP6odcG2HLJ == null;
		}
	}

	private static readonly ILog xdqgQvkd90M;

	private static object NePgQSZZgbg;

	internal static object eD4fx1QHgHfXEyOSB9a5;

	private static string NvngBOLvs6i()
	{
		string text = "";
		if (!text.IsNullOrEmpty() && Directory.Exists(text))
		{
			return text;
		}
		text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_ocr");
		if (!Directory.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static bool LprgBF823Fu()
	{
		if (Environment.Is64BitOperatingSystem && Environment.Is64BitProcess && !string.IsNullOrEmpty(NvngBOLvs6i()))
		{
			return true;
		}
		return false;
	}

	private static bool L5vgBUMBd3S()
	{
		try
		{
			Process process = Process.GetProcessesByName("QuickerOcrAgent").FirstOrDefault();
			int num = 0;
			if (!YyPiG6QHP4LAkMVZsGlE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (process != null && !process.HasExited)
				{
					return true;
				}
				process = Process.Start(Path.Combine(NvngBOLvs6i(), "QuickerOcrAgent.exe"), $"--keepalive:{dDh7g7Xw7JyQPUTbYwJ.LocalOcrKeepAliveSeconds}");
				if (process != null)
				{
					return true;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			xdqgQvkd90M.Warn("无法启动本地OCR程序。" + ex.Message, ex);
		}
		return false;
	}

	public static OcrResult MaNgBlS1Zcv(OcrRequest ocrRequest_0)
	{
		lock (NePgQSZZgbg)
		{
			return wK3gBi3HHiV(ocrRequest_0);
		}
	}

	private static OcrResult wK3gBi3HHiV(OcrRequest ocrRequest_0)
	{
		if (!L5vgBUMBd3S())
		{
			throw new Exception("无法启动本地OCR程序，请检查离线包是否完整。");
		}
		using v3lj0GuJWgwiBbYyrZ0 v3lj0GuJWgwiBbYyrZ = new v3lj0GuJWgwiBbYyrZ0();
		return v3lj0GuJWgwiBbYyrZ.MakS6b1EtWx(ocrRequest_0);
	}

	internal static (bool success, string result) kL1gB3rjR4g(Image image_0)
	{
		try
		{
			string @base = image_0.ToBase64String(ImageFormat.Png);
			OcrResult ocrResult = MaNgBlS1Zcv(new OcrRequest
			{
				Base64 = @base,
				Command = "text"
			});
			if (ocrResult != null && ocrResult.IsSuccess && !ocrResult.Data.IsNullOrEmpty())
			{
				PaddleOcrResult paddleOcrResult = HwrgQwck4JH(ocrResult.Data);
				return (success: true, result: paddleOcrResult.Result.Lines);
			}
			object obj;
			if (ocrResult == null)
			{
				obj = null;
			}
			else
			{
				obj = ocrResult.Error;
				if (obj != null)
				{
					goto IL_0078;
				}
			}
			obj = "未能获得识别结果";
			goto IL_0078;
			IL_0078:
			return (success: false, result: (string)obj);
		}
		catch (Exception ex)
		{
			xdqgQvkd90M.Warn("GetTextFromImage识别文字异常：" + ex.Message, ex);
			return (success: false, result: "异常：" + ex.Message);
		}
	}

	[AsyncStateMachine(typeof(_003CGetTextFromImageAsync_003Ed__11))]
	internal static Task<(bool success, string result)> YQKgBfPMkG3(Image image_0)
	{
		_003CGetTextFromImageAsync_003Ed__11 stateMachine = default(_003CGetTextFromImageAsync_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.img = image_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static IList<LocalOcrTextBlock> YcGgBzsjlhg(Image image_0, string string_0)
	{
		try
		{
			string @base = image_0.ToBase64String(ImageFormat.Png);
			OcrResult ocrResult = MaNgBlS1Zcv(new OcrRequest
			{
				Base64 = @base,
				Command = "text",
				Lang = string_0
			});
			if (ocrResult == null)
			{
				throw new Exception("未能获得识别结果");
			}
			if (!ocrResult.IsSuccess)
			{
				throw new Exception("离线识别失败：" + ocrResult.Error);
			}
			if (ocrResult.Data.IsNullOrEmpty())
			{
				throw new Exception("识别结果为空");
			}
			IList<LocalOcrTextBlock>? list = JsonConvert.DeserializeObject<IList<LocalOcrTextBlock>>(ocrResult.Data);
			if (!list.HasData())
			{
				throw new Exception("识别结果为空");
			}
			return list;
		}
		catch (Exception ex)
		{
			xdqgQvkd90M.Warn("GetTextBlocksFromImage识别文字异常：" + ex.Message, ex);
			throw;
		}
	}

	internal static PaddleOcrResult HwrgQwck4JH(string string_0)
	{
		IList<LocalOcrTextBlock> list = JsonConvert.DeserializeObject<IList<LocalOcrTextBlock>>(string_0);
		if (list != null && list.Count != 0)
		{
			list = list.OrderBy(_003C_003Ec.NYvS6dADqiB ?? (_003C_003Ec.NYvS6dADqiB = _003C_003Ec.A71S6Ds9QCc.WaDS6KCRf5A)).ToList();
			List<List<LocalOcrTextBlock>> list2 = kFfgQgyYSHb(list);
			PaddleOcrResult paddleOcrResult = new PaddleOcrResult();
			paddleOcrResult.Result = new PaddleOcrResult.ResultItem();
			try
			{
				string lines = UAegQtxexAc(list2);
				paddleOcrResult.Result.Lines = lines;
			}
			catch (Exception ex)
			{
				xdqgQvkd90M.Info("转换为文本出错：" + ex.Message + "\r\n" + list2.ToJson(true) + "\r\n原始json：" + string_0);
				throw;
			}
			IList<PaddleOcrResult.Region> list3 = new List<PaddleOcrResult.Region>();
			int num = 0;
			if (!YyPiG6QHP4LAkMVZsGlE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				foreach (List<LocalOcrTextBlock> item in list2)
				{
					foreach (LocalOcrTextBlock item2 in item)
					{
						list3.Add(new PaddleOcrResult.Region
						{
							Text = item2.Text,
							Confidence = item2.Score,
							Rect = new PaddleOcrResult.Rect(item2.Rect)
						});
					}
				}
				paddleOcrResult.Result.Regions = list3;
				return paddleOcrResult;
			}
		}
		xdqgQvkd90M.Warn("未能成功解析本地OCR数据：" + string_0);
		throw new Exception("未能成功解析本地OCR数据：" + string_0);
	}

	private static string UAegQtxexAc(List<List<LocalOcrTextBlock>> list_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (list_0.Count == 0)
		{
			return "";
		}
		if (list_0.Count == 1)
		{
			jP3gQLE9DYw(stringBuilder, list_0.First());
			return stringBuilder.ToString();
		}
		int num = list_0.Where(_003C_003Ec.PgAS6ongZkM ?? (_003C_003Ec.PgAS6ongZkM = _003C_003Ec.A71S6Ds9QCc.lQeS6xKgPd8)).Min(_003C_003Ec.wI9S6TtHfN2 ?? (_003C_003Ec.wI9S6TtHfN2 = _003C_003Ec.A71S6Ds9QCc.ocAS6r9b5q7));
		int num2 = 0;
		for (int i = 0; i < list_0.Count - 1; i++)
		{
			List<LocalOcrTextBlock> list = list_0[i];
			List<LocalOcrTextBlock> list2 = list_0[i + 1];
			if (list.Count != 0 && list2.Count != 0)
			{
				int num3 = list2.Min(_003C_003Ec.bc1S6MEX5vC ?? (_003C_003Ec.bc1S6MEX5vC = _003C_003Ec.A71S6Ds9QCc.DYES6pKValy)) - list.Max(_003C_003Ec.FBES6AOMFEr ?? (_003C_003Ec.FBES6AOMFEr = _003C_003Ec.A71S6Ds9QCc.n01S6BTO7ng));
				if (num3 > 0)
				{
					num2 = ((num2 != 0) ? Math.Min(num2, num3) : num3);
				}
			}
		}
		List<LocalOcrTextBlock> list3 = null;
		foreach (List<LocalOcrTextBlock> item in list_0)
		{
			if (item.Count == 0)
			{
				continue;
			}
			int repeatCount = 0;
			if (item.First().Text.Length > 0)
			{
				int left = item.First().Rect.Left;
				if (left > num + 10)
				{
					int val = Math.Min(item.Max(_003C_003Ec.jmtS6OVQGQi ?? (_003C_003Ec.jmtS6OVQGQi = _003C_003Ec.A71S6Ds9QCc.PpIS6Q6TqNV)), item.First().GetCharAvgWidth());
					int val2 = (left - num) / Math.Max(16, val);
					repeatCount = Math.Min(20, val2);
				}
			}
			if (list3 == null)
			{
				stringBuilder.Append(' ', repeatCount);
				jP3gQLE9DYw(stringBuilder, item);
			}
			else
			{
				double num4 = item.Average(_003C_003Ec.xTRS6FxUk6G ?? (_003C_003Ec.xTRS6FxUk6G = _003C_003Ec.A71S6Ds9QCc.OdXS6jKSOSq));
				int num5 = item.Min(_003C_003Ec.l3gS6UAAiVV ?? (_003C_003Ec.l3gS6UAAiVV = _003C_003Ec.A71S6Ds9QCc.sZHS6nbaKW4)) - list3.Max(_003C_003Ec.QjdS6lbeCrp ?? (_003C_003Ec.QjdS6lbeCrp = _003C_003Ec.A71S6Ds9QCc.UpvS641m5yZ));
				if (num5 > num2 + 10)
				{
					int num6 = (int)((double)num5 / (num4 + (double)num2));
					if (num6 == 0)
					{
						if ((double)num6 > num4)
						{
							stringBuilder.AppendLine();
						}
					}
					else
					{
						for (int j = 0; !((double)j >= Math.Sqrt(num6)) && j < 4; j++)
						{
							stringBuilder.AppendLine();
						}
					}
				}
				stringBuilder.Append(' ', repeatCount);
				jP3gQLE9DYw(stringBuilder, item);
			}
			list3 = item;
		}
		return stringBuilder.ToString().TrimEnd();
	}

	private static List<List<LocalOcrTextBlock>> kFfgQgyYSHb(IList<LocalOcrTextBlock> ilist_0)
	{
		List<List<LocalOcrTextBlock>> list = new List<List<LocalOcrTextBlock>>();
		LocalOcrTextBlock localOcrTextBlock = null;
		foreach (LocalOcrTextBlock item in ilist_0)
		{
			if (localOcrTextBlock != null && item.Core.Y - localOcrTextBlock.Core.Y <= 15)
			{
				if (list.Count > 0)
				{
					list.Last().Add(item);
				}
			}
			else
			{
				list.Add(new List<LocalOcrTextBlock> { item });
			}
			localOcrTextBlock = item;
		}
		foreach (List<LocalOcrTextBlock> item2 in list)
		{
			if (item2.Count > 1)
			{
				item2.Sort(_003C_003Ec.FZFS6ipegPM ?? (_003C_003Ec.FZFS6ipegPM = _003C_003Ec.A71S6Ds9QCc.z58S65ShTZJ));
			}
		}
		return list;
	}

	private static void jP3gQLE9DYw(StringBuilder stringBuilder_0, List<LocalOcrTextBlock> list_0)
	{
		LocalOcrTextBlock localOcrTextBlock = null;
		foreach (LocalOcrTextBlock item in list_0)
		{
			if (localOcrTextBlock == null)
			{
				stringBuilder_0.Append(item.Text);
			}
			else
			{
				stringBuilder_0.Append(" ");
				if (!string.IsNullOrEmpty(item.Text))
				{
					stringBuilder_0.Append(" ");
					int num = (item.Rect.Left - localOcrTextBlock.Rect.Right) / 3 / item.GetCharAvgWidth();
					if (num > 1)
					{
						stringBuilder_0.Append(' ', Math.Min(10, num - 1));
					}
				}
				stringBuilder_0.Append(item.Text);
			}
			localOcrTextBlock = item;
		}
		stringBuilder_0.AppendLine();
	}

	static bfmVNpoIh0N1MPAqJ5v()
	{
		xdqgQvkd90M = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		NePgQSZZgbg = new object();
	}

	internal static bool YyPiG6QHP4LAkMVZsGlE()
	{
		return eD4fx1QHgHfXEyOSB9a5 == null;
	}
}
