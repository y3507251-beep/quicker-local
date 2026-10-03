using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using log4net;
using Quicker.Annotations;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using SVGImage.SVG;
using whX2OqiF8ktmGdctWNN;
using yyXIB9Yxgd6ACb7T4ig;

namespace CpRmjmYrY5NIYQiiVIA;

internal static class tApqttYCLpKNRcDCrWi
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public string oRPSfMBniCM;

		public string f69SfA6owmb;

		public string imlSfONuYuW;

		public Action<Drawing, string> TRASfFaJwJa;

		internal static _003C_003Ec__DisplayClass2_0 XTDB1wyAkQoQwFch1mIp;

		internal void tbvSfTGfNSp()
		{
			_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_1
			{
				RPbSfi2405y = this,
				o5xSfluADAh = VMHL534d1cX(oRPSfMBniCM, f69SfA6owmb)
			};
			if (_003C_003Ec__DisplayClass2_.o5xSfluADAh != null)
			{
				fe1LDtPwiwr.aIXvNhlIIfs(imlSfONuYuW, _003C_003Ec__DisplayClass2_.o5xSfluADAh);
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass2_.NkMSfUwr2T3);
			}
		}

		internal static bool TpmIhEyAaqZLJXacP1ul()
		{
			return XTDB1wyAkQoQwFch1mIp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_1
	{
		public Drawing o5xSfluADAh;

		public _003C_003Ec__DisplayClass2_0 RPbSfi2405y;

		private static _003C_003Ec__DisplayClass2_1 PXbsiSyA9o6q2HjdL5oi;

		internal void NkMSfUwr2T3()
		{
			RPbSfi2405y.TRASfFaJwJa(o5xSfluADAh, RPbSfi2405y.oRPSfMBniCM);
		}

		internal static bool JnH93ByALCYTy1jtdbea()
		{
			return PXbsiSyA9o6q2HjdL5oi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string lHISffZmgy8;

		public string EiLSfzIOZYj;

		public string KNeSzwTP76s;

		internal static _003C_003Ec__DisplayClass3_0 krRORYyAo2oV2WxHVOIy;

		internal Drawing BfeSf3LKEl4()
		{
			Drawing drawing = VMHL534d1cX(lHISffZmgy8, EiLSfzIOZYj);
			fe1LDtPwiwr.aIXvNhlIIfs(KNeSzwTP76s, drawing);
			return drawing;
		}

		internal static bool vkgu4kyAfW6NSHkEerdW()
		{
			return krRORYyAo2oV2WxHVOIy == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass6_0
	{
		public string taESztY5ero;

		public string axVSzgmQLts;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSvgDrawingAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Drawing> _003C_003Et__builder;

		public string iconStr;

		public string color;

		public CancellationToken cancellationToken;

		private TaskAwaiter<Drawing> _003C_003Eu__1;

		private static object MYXaIWyAZFdOVB0flwxF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Drawing result;
			try
			{
				TaskAwaiter<Drawing> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0
					{
						lHISffZmgy8 = iconStr,
						EiLSfzIOZYj = color
					};
					int num2 = 1;
					if (MYXaIWyAZFdOVB0flwxF != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						_003C_003Ec__DisplayClass3_.KNeSzwTP76s = i9AL5U2D87Z(_003C_003Ec__DisplayClass3_.lHISffZmgy8, _003C_003Ec__DisplayClass3_.EiLSfzIOZYj);
						if (!fe1LDtPwiwr.o4AvN7xIN4x(_003C_003Ec__DisplayClass3_.KNeSzwTP76s))
						{
							goto default;
						}
						result = fe1LDtPwiwr.nCwvN99a8pK(_003C_003Ec__DisplayClass3_.KNeSzwTP76s);
						goto end_IL_0008;
					default:
						awaiter = Task.Run((Func<Drawing>)_003C_003Ec__DisplayClass3_.BfeSf3LKEl4, cancellationToken).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Drawing>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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

		internal static bool tJo3D1yA5qDvNakrCqED()
		{
			return MYXaIWyAZFdOVB0flwxF == null;
		}
	}

	private static readonly ILog sa8LDwQgeFF;

	private static VWVOHCiULfdMMMUB3rX<string, Drawing> fe1LDtPwiwr;

	private static IDictionary<string, string> s3ILDg4vLaZ;

	private static object NjruZLFlulj6hjV37ooS;

	private static string i9AL5U2D87Z(string string_0, string string_1)
	{
		return string_0 + ":" + string_1;
	}

	public static Drawing IbPL5lqARlO([NotNull] Action<Drawing, string> callBackOnUiThread, string string_0, string string_1)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.oRPSfMBniCM = string_0;
		_003C_003Ec__DisplayClass2_.f69SfA6owmb = string_1;
		_003C_003Ec__DisplayClass2_.TRASfFaJwJa = callBackOnUiThread;
		_003C_003Ec__DisplayClass2_.imlSfONuYuW = i9AL5U2D87Z(_003C_003Ec__DisplayClass2_.oRPSfMBniCM, _003C_003Ec__DisplayClass2_.f69SfA6owmb);
		if (fe1LDtPwiwr.o4AvN7xIN4x(_003C_003Ec__DisplayClass2_.imlSfONuYuW))
		{
			return fe1LDtPwiwr.nCwvN99a8pK(_003C_003Ec__DisplayClass2_.imlSfONuYuW);
		}
		Task.Run((Action)_003C_003Ec__DisplayClass2_.tbvSfTGfNSp);
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetSvgDrawingAsync_003Ed__3))]
	public static Task<Drawing> o23L5iqGYrY(string string_0, string string_1, CancellationToken cancellationToken_0)
	{
		_003CGetSvgDrawingAsync_003Ed__3 stateMachine = default(_003CGetSvgDrawingAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Drawing>.Create();
		stateMachine.iconStr = string_0;
		stateMachine.color = string_1;
		stateMachine.cancellationToken = cancellationToken_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static Drawing VMHL534d1cX(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0)) return null;
		var settings = new _003C_003Ec__DisplayClass6_0 { taESztY5ero = string_0, axVSzgmQLts = string_1 };
		var path = string_0.StartsWith("http", StringComparison.OrdinalIgnoreCase) ? j53dHOYtcRyb9edAMaZ.ercL5MLtTEv(string_0) : string_0;
		if (!System.IO.File.Exists(path)) return null;
		try { return fnUL5zf9B0m(path, ref settings); }
		catch (Exception error) { sa8LDwQgeFF.Warn("加载本地 SVG 失败：" + path, error); return null; }
	}

	static tApqttYCLpKNRcDCrWi()
	{
		sa8LDwQgeFF = LogManager.GetLogger(typeof(ImageCache));
		fe1LDtPwiwr = new VWVOHCiULfdMMMUB3rX<string, Drawing>();
		s3ILDg4vLaZ = new ConcurrentDictionary<string, string>();
	}

	[CompilerGenerated]
	internal static void oguL5fdZ4SG(Drawing drawing_0, ref _003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_0_0)
	{
		drawing_0.Freeze();
		fe1LDtPwiwr.aIXvNhlIIfs(i9AL5U2D87Z(_003C_003Ec__DisplayClass6_0_0.taESztY5ero, _003C_003Ec__DisplayClass6_0_0.axVSzgmQLts), drawing_0);
	}

	[CompilerGenerated]
	internal static Drawing fnUL5zf9B0m(string string_0, ref _003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_0_0)
	{
		DrawingGroup drawingGroup = new SVGRender
		{
			DefaultColor = ColorHelper.StringToColor(_003C_003Ec__DisplayClass6_0_0.axVSzgmQLts)
		}.LoadDrawing(string_0);
		oguL5fdZ4SG(drawingGroup, ref _003C_003Ec__DisplayClass6_0_0);
		return drawingGroup;
	}

	internal static bool PfqxOaFloesaojgiDgGQ()
	{
		return NjruZLFlulj6hjV37ooS == null;
	}
}
