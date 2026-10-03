using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using EOqy55MyMeuU2apYyog;
using FontAwesome5;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using SCyJThYoNMQE7IHLXbA;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class UserInputStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public ActionStep y0qvzoL2FXC;

		public ActionExecuteContext CaXvzTXwOfs;

		public XAction QMmvzMHMGy4;

		internal static _003C_003Ec__DisplayClass56_0 hDikZcW37ojvMiWSErpA;

		internal (bool isSuccess, string message, ActionStopFlag failReason) HyjvzdRXRsX()
		{
			_003C_003Ec__DisplayClass56_1 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_1
			{
				uW7SwPdpUNy = this,
				pK8vzA71kO1 = XActionHelper.GetTextParamValue(MFLtFivwHSI, y0qvzoL2FXC, CaXvzTXwOfs),
				s9CvzOAMo2w = XActionHelper.GetTextParamValue(sCKtF3awKuC, y0qvzoL2FXC, CaXvzTXwOfs),
				DVySwLv34uj = XActionHelper.GetTextParamValue(OuutFfai92V, y0qvzoL2FXC, CaXvzTXwOfs),
				vLgSwvTVTwg = XActionHelper.GetTextParamValue(EF6tFzDbMng, y0qvzoL2FXC, CaXvzTXwOfs),
				zCCSwSTtUGM = XActionHelper.GetTextParamValue(k1ttUwXVosO, y0qvzoL2FXC, CaXvzTXwOfs),
				j2LvzFVQQmS = XActionHelper.GetTextParamValue(GhLtUtqttMN, y0qvzoL2FXC, CaXvzTXwOfs),
				ziySwt0cMPg = XActionHelper.GetBooleanParamValue(qHitUv83oBy, y0qvzoL2FXC, CaXvzTXwOfs),
				d6kvziqW38Q = XActionHelper.GetBooleanParamValue(n57tUgXeEIS, y0qvzoL2FXC, CaXvzTXwOfs),
				thxSwNR42ZZ = XActionHelper.GetTextParamValue(oAOtUu18Pnx, y0qvzoL2FXC, CaXvzTXwOfs),
				MBfSwJPVWCG = XActionHelper.GetNumberParamValue(rN3tUNVe1JY, y0qvzoL2FXC, CaXvzTXwOfs)
			};
			string textParamValue = XActionHelper.GetTextParamValue(KOqtULpr6MO, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.zjcSw2j5jy6 = XActionHelper.GetBooleanParamValue(C7YtU21igSY, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.o5bvzUsHQNV = XActionHelper.GetBooleanParamValue(q4OtUSYnqdw, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.aNKSwuGQp5V = XActionHelper.GetTextParamValue(n3TtUJwUYHn, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.OyNvz3E1gOG = XActionHelper.GetTextParamValue(XwytU0lejsY, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.jltvzf3DMNx = XActionHelper.GetBooleanParamValue(IQItUCc0kfF, y0qvzoL2FXC, CaXvzTXwOfs);
			_003C_003Ec__DisplayClass56_.ktGvzzh5947 = false;
			_003C_003Ec__DisplayClass56_.zqISw0v7uLk = 0.0;
			_003C_003Ec__DisplayClass56_.iKhSwCBfWwR = "";
			_003C_003Ec__DisplayClass56_.ztXSwghkPxR = NativeMethods.GetForegroundWindow();
			_003C_003Ec__DisplayClass56_.Rs5Sww7yH3l = null;
			_003C_003Ec__DisplayClass56_.IIbvzl1kcPC = ShowWindowLocation.Auto;
			if (!string.IsNullOrEmpty(textParamValue))
			{
				_003C_003Ec__DisplayClass56_.IIbvzl1kcPC = (ShowWindowLocation)Enum.Parse(typeof(ShowWindowLocation), textParamValue);
			}
			if (_003C_003Ec__DisplayClass56_.pK8vzA71kO1 == "date_time")
			{
				_003C_003Ec__DisplayClass56_2 _003C_003Ec__DisplayClass56_2 = new _003C_003Ec__DisplayClass56_2
				{
					tCtSwaGOl7W = _003C_003Ec__DisplayClass56_,
					N3TSw8KSwMf = new ManualResetEvent(false),
					O3wSwyrDeB9 = null
				};
				if (XActionHelper.GetParamValue(OuutFfai92V, y0qvzoL2FXC, CaXvzTXwOfs, false, true) is DateTime value)
				{
					_003C_003Ec__DisplayClass56_2.O3wSwyrDeB9 = value;
				}
				else if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.DVySwLv34uj))
				{
					try
					{
						_003C_003Ec__DisplayClass56_2.O3wSwyrDeB9 = DateTime.Parse(_003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.DVySwLv34uj);
					}
					catch (Exception)
					{
						return (isSuccess: false, message: "无法将字符串转换为时间值：" + _003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.DVySwLv34uj, failReason: ActionStopFlag.OperationFailed);
					}
				}
				if (!_003C_003Ec__DisplayClass56_2.O3wSwyrDeB9.HasValue)
				{
					_003C_003Ec__DisplayClass56_2.O3wSwyrDeB9 = DateTime.Now;
				}
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_2.Q9wSwECVr48);
				_003C_003Ec__DisplayClass56_2.N3TSw8KSwMf.WaitOne();
				if (_003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.ktGvzzh5947 == true)
				{
					XActionHelper.OutputResult(GortUarK07s, y0qvzoL2FXC, CaXvzTXwOfs, _003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.Rs5Sww7yH3l, QMmvzMHMGy4);
					XActionHelper.OutputResult(JIdtUyNwpVO, y0qvzoL2FXC, CaXvzTXwOfs, _003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.Rs5Sww7yH3l?.ToString("yyyy-MM-dd HH:mm:ss"), QMmvzMHMGy4);
					XActionHelper.OutputResult(tDUtU7jR4rW, y0qvzoL2FXC, CaXvzTXwOfs, string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_2.tCtSwaGOl7W.iKhSwCBfWwR), QMmvzMHMGy4);
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				CaXvzTXwOfs.ActionLogger.LogWarning("用户取消输入");
				return (isSuccess: false, message: "", failReason: ActionStopFlag.UserCancel);
			}
			_003C_003Ec__DisplayClass56_3 _003C_003Ec__DisplayClass56_3 = new _003C_003Ec__DisplayClass56_3
			{
				PtkSwqgyXEA = _003C_003Ec__DisplayClass56_,
				NsRSwRvMjwU = new ManualResetEvent(false)
			};
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_3.I9GSw7yhfXE);
			_003C_003Ec__DisplayClass56_3.NsRSwRvMjwU.WaitOne();
			if (_003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.ktGvzzh5947 == true)
			{
				if (_003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.pK8vzA71kO1 == "number")
				{
					XActionHelper.OutputResult(ql7tU8u4uys, y0qvzoL2FXC, CaXvzTXwOfs, _003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.zqISw0v7uLk, QMmvzMHMGy4);
				}
				XActionHelper.OutputResult(JIdtUyNwpVO, y0qvzoL2FXC, CaXvzTXwOfs, _003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.iKhSwCBfWwR, QMmvzMHMGy4);
				XActionHelper.OutputResult(tDUtU7jR4rW, y0qvzoL2FXC, CaXvzTXwOfs, string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.iKhSwCBfWwR), QMmvzMHMGy4);
				if (_003C_003Ec__DisplayClass56_3.PtkSwqgyXEA.ziySwt0cMPg)
				{
					Thread.Sleep(100);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			CaXvzTXwOfs.ActionLogger.LogWarning("用户取消输入");
			return (isSuccess: false, message: "", failReason: ActionStopFlag.UserCancel);
		}

		static _003C_003Ec__DisplayClass56_0()
		{
		}

		internal static bool vtry49W34yFkRRi1L5nX()
		{
			return hDikZcW37ojvMiWSErpA == null;
		}

		internal static void x6nm1XW3H1RivkixqobC()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_1
	{
		public string pK8vzA71kO1;

		public string s9CvzOAMo2w;

		public string j2LvzFVQQmS;

		public bool o5bvzUsHQNV;

		public ShowWindowLocation IIbvzl1kcPC;

		public bool d6kvziqW38Q;

		public string OyNvz3E1gOG;

		public bool jltvzf3DMNx;

		public bool? ktGvzzh5947;

		public DateTime? Rs5Sww7yH3l;

		public bool ziySwt0cMPg;

		public IntPtr ztXSwghkPxR;

		public string DVySwLv34uj;

		public string vLgSwvTVTwg;

		public string zCCSwSTtUGM;

		public bool zjcSw2j5jy6;

		public string aNKSwuGQp5V;

		public string thxSwNR42ZZ;

		public double MBfSwJPVWCG;

		public double zqISw0v7uLk;

		public string iKhSwCBfWwR;

		public _003C_003Ec__DisplayClass56_0 uW7SwPdpUNy;

		private static _003C_003Ec__DisplayClass56_1 pHpSsNW3zRYRpPsqoLdG;

		internal static bool DtAsjoWEVCe9931menWy()
		{
			return pHpSsNW3zRYRpPsqoLdG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct k8Sv6vkyylArdsE8gui : IAsyncStateMachine
		{
			public int JMr2cSS5Xnq;

			public AsyncVoidMethodBuilder r7s2c2XhWtP;

			public _003C_003Ec__DisplayClass56_2 wCd2cur0jCE;

			private DateTimeInputWindow AwQ2cNCihuZ;

			private ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter IIr2cJxknJ2;

			private static object VGnbSJyfuSZ625lvu6Qs;

			private void MoveNext()
			{
				int num = JMr2cSS5Xnq;
				_003C_003Ec__DisplayClass56_2 _003C_003Ec__DisplayClass56_ = wCd2cur0jCE;
				try
				{
					ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter);
					if (num != 0)
					{
						int num3 = default(int);
						while (true)
						{
							AwQ2cNCihuZ = new DateTimeInputWindow(_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.pK8vzA71kO1, _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.s9CvzOAMo2w, _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.j2LvzFVQQmS, _003C_003Ec__DisplayClass56_.O3wSwyrDeB9);
							AwQ2cNCihuZ.CloseOnDeactivated = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.o5bvzUsHQNV;
							AwQ2cNCihuZ.ShowLocation = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.IIbvzl1kcPC;
							AwQ2cNCihuZ.Title = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.ActionTitle;
							AwQ2cNCihuZ.IsRequired = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.d6kvziqW38Q;
							int num2 = 0;
							if (VGnbSJyfuSZ625lvu6Qs != null)
							{
								num2 = num3;
							}
							while (true)
							{
								IL_011f:
								switch (num2)
								{
								case 2:
									goto end_IL_011f;
								case 1:
									num = 0;
									JMr2cSS5Xnq = 0;
									IIr2cJxknJ2 = awaiter;
									r7s2c2XhWtP.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								while (true)
								{
									AwQ2cNCihuZ.HelpText = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.OyNvz3E1gOG;
									AwQ2cNCihuZ.Topmost = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.jltvzf3DMNx;
									AwQ2cNCihuZ.V6hgjEnp8ZH(_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.CancellationToken);
									AppHelper.SetWindowIcon(AwQ2cNCihuZ, _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs?.Action?.Icon, true);
									if (_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.ParentWindow.zmGvuiv40H0())
									{
										AwQ2cNCihuZ.Owner = _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.ParentWindow;
									}
									awaiter = AwQ2cNCihuZ.MjdLOXIjD10(true).ConfigureAwait(true).GetAwaiter();
									if (awaiter.IsCompleted)
									{
										break;
									}
									num2 = 1;
									if (!nOb4pSyfo2tHs38jMNeK())
									{
										continue;
									}
									goto IL_011f;
								}
								goto end_IL_0135;
								continue;
								end_IL_011f:
								break;
							}
							continue;
							end_IL_0135:
							break;
						}
					}
					else
					{
						awaiter = IIr2cJxknJ2;
						IIr2cJxknJ2 = default(ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter);
						num = -1;
						JMr2cSS5Xnq = -1;
					}
					if (awaiter.GetResult() == true)
					{
						_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.ktGvzzh5947 = true;
						_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.Rs5Sww7yH3l = AwQ2cNCihuZ.Value;
					}
					_003C_003Ec__DisplayClass56_.N3TSw8KSwMf.Set();
					if (_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.ziySwt0cMPg && _003C_003Ec__DisplayClass56_.tCtSwaGOl7W.ztXSwghkPxR != IntPtr.Zero)
					{
						if (_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.IsDebugging)
						{
							_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.uW7SwPdpUNy.CaXvzTXwOfs.ActionLogger?.LogInfo($"恢复焦点窗口到：{_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.ztXSwghkPxR}");
						}
						AppHelper.SetForegroundWindow(_003C_003Ec__DisplayClass56_.tCtSwaGOl7W.ztXSwghkPxR);
					}
				}
				catch (Exception exception)
				{
					JMr2cSS5Xnq = -2;
					AwQ2cNCihuZ = null;
					r7s2c2XhWtP.SetException(exception);
					return;
				}
				JMr2cSS5Xnq = -2;
				AwQ2cNCihuZ = null;
				r7s2c2XhWtP.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				r7s2c2XhWtP.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool nOb4pSyfo2tHs38jMNeK()
			{
				return VGnbSJyfuSZ625lvu6Qs == null;
			}
		}

		public DateTime? O3wSwyrDeB9;

		public ManualResetEvent N3TSw8KSwMf;

		public _003C_003Ec__DisplayClass56_1 tCtSwaGOl7W;

		private static _003C_003Ec__DisplayClass56_2 RF1kJXWEF3lsiGTY8PQn;

		[AsyncStateMachine(typeof(k8Sv6vkyylArdsE8gui))]
		internal void Q9wSwECVr48()
		{
			k8Sv6vkyylArdsE8gui stateMachine = default(k8Sv6vkyylArdsE8gui);
			stateMachine.r7s2c2XhWtP = AsyncVoidMethodBuilder.Create();
			stateMachine.wCd2cur0jCE = this;
			stateMachine.JMr2cSS5Xnq = -1;
			stateMachine.r7s2c2XhWtP.Start(ref stateMachine);
		}

		internal static bool HQqSecWEcjlTKlov7UFg()
		{
			return RF1kJXWEF3lsiGTY8PQn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_3
	{
		[StructLayout(LayoutKind.Auto)]
		private struct zNDh9Ik4WewJJgeScb1 : IAsyncStateMachine
		{
			public int iXr2c0rSpme;

			public AsyncVoidMethodBuilder R7S2cClFbHN;

			public _003C_003Ec__DisplayClass56_3 su82cPTt14F;

			private UserInputWindow BYo2cEcutjd;

			private ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter cFP2cyMxme0;

			private static object Jruvlsyfii6ZNl0F7kSA;

			private void MoveNext()
			{
				int num = iXr2c0rSpme;
				_003C_003Ec__DisplayClass56_3 _003C_003Ec__DisplayClass56_ = su82cPTt14F;
				try
				{
					int num2;
					if (num != 0)
					{
						BYo2cEcutjd = new UserInputWindow(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.pK8vzA71kO1, _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.s9CvzOAMo2w, _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.j2LvzFVQQmS, _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.DVySwLv34uj);
						BYo2cEcutjd.CloseOnDeactivated = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.o5bvzUsHQNV;
						BYo2cEcutjd.ShowLocation = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.IIbvzl1kcPC;
						BYo2cEcutjd.Title = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs.ActionTitle;
						num2 = 0;
						if (Jruvlsyfii6ZNl0F7kSA != null)
						{
							goto IL_00eb;
						}
						goto IL_02ae;
					}
					ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter awaiter = cFP2cyMxme0;
					cFP2cyMxme0 = default(ConfiguredTaskAwaitable<bool?>.ConfiguredTaskAwaiter);
					num = -1;
					iXr2c0rSpme = -1;
					goto IL_02c9;
					IL_02c9:
					if (awaiter.GetResult() == true)
					{
						num2 = 1;
						if (Jruvlsyfii6ZNl0F7kSA != null)
						{
							goto IL_00eb;
						}
						goto IL_02ae;
					}
					goto IL_0327;
					IL_03e5:
					IntPtr lastForegroundWindow = default(IntPtr);
					AppHelper.SetForegroundWindow(lastForegroundWindow);
					goto end_IL_0010;
					IL_00eb:
					int num3 = default(int);
					num2 = num3;
					goto IL_02ae;
					IL_02ae:
					while (true)
					{
						IL_02ae_2:
						switch (num2)
						{
						case 2:
							while (true)
							{
								BYo2cEcutjd.ExtraSettingsStr = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.zCCSwSTtUGM;
								BYo2cEcutjd.SubmitWithReturn = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.zjcSw2j5jy6;
								BYo2cEcutjd.ActionExecuteContext = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs;
								BYo2cEcutjd.HelpText = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.OyNvz3E1gOG;
								BYo2cEcutjd.Topmost = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.jltvzf3DMNx;
								BYo2cEcutjd.V6hgjEnp8ZH(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs.CancellationToken);
								AppHelper.SetWindowIcon(BYo2cEcutjd, _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs?.Action?.Icon, true);
								AppImeHelper.SetImeState(BYo2cEcutjd, _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.aNKSwuGQp5V);
								if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.thxSwNR42ZZ))
								{
									BYo2cEcutjd.SetFontFamily(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.thxSwNR42ZZ);
								}
								BYo2cEcutjd.SetFontSize(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.MBfSwJPVWCG);
								awaiter = BYo2cEcutjd.MjdLOXIjD10(true).ConfigureAwait(false).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									break;
								}
								num = 0;
								iXr2c0rSpme = 0;
								cFP2cyMxme0 = awaiter;
								R7S2cClFbHN.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num2 = 3;
								if (!OlelGDyflBwtvZKuqVfv())
								{
									continue;
								}
								goto IL_02ae_2;
							}
							goto IL_02c9;
						default:
							BYo2cEcutjd.IsRequired = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.d6kvziqW38Q;
							BYo2cEcutjd.TextToolsStr = _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.vLgSwvTVTwg;
							goto case 2;
						case 1:
							break;
						case 3:
							return;
						case 4:
							goto IL_03e5;
						}
						break;
					}
					_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.zqISw0v7uLk = BYo2cEcutjd.NumberValue;
					_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.iKhSwCBfWwR = BYo2cEcutjd.TextValue;
					_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.ktGvzzh5947 = true;
					goto IL_0327;
					IL_0327:
					_003C_003Ec__DisplayClass56_.NsRSwRvMjwU.Set();
					if (_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.ziySwt0cMPg && _003C_003Ec__DisplayClass56_.PtkSwqgyXEA.ztXSwghkPxR != IntPtr.Zero)
					{
						if (_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs.IsDebugging)
						{
							_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.uW7SwPdpUNy.CaXvzTXwOfs.ActionLogger?.LogInfo($"恢复焦点窗口到：{_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.ztXSwghkPxR}");
						}
						AppHelper.SetForegroundWindow(_003C_003Ec__DisplayClass56_.PtkSwqgyXEA.ztXSwghkPxR);
					}
					else
					{
						lastForegroundWindow = AppState.AppServer.GetLastForegroundWindow();
						if (lastForegroundWindow != BYo2cEcutjd.HWnd)
						{
							goto IL_03e5;
						}
						AppHelper.SetForegroundWindow(AppState.AppServer.GetLastForegroundWindowNotOfQuicker());
					}
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					iXr2c0rSpme = -2;
					BYo2cEcutjd = null;
					R7S2cClFbHN.SetException(exception);
					return;
				}
				iXr2c0rSpme = -2;
				BYo2cEcutjd = null;
				R7S2cClFbHN.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				R7S2cClFbHN.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool OlelGDyflBwtvZKuqVfv()
			{
				return Jruvlsyfii6ZNl0F7kSA == null;
			}
		}

		public ManualResetEvent NsRSwRvMjwU;

		public _003C_003Ec__DisplayClass56_1 PtkSwqgyXEA;

		internal static _003C_003Ec__DisplayClass56_3 NMQi8PWEyK1UpFsndgsS;

		[AsyncStateMachine(typeof(zNDh9Ik4WewJJgeScb1))]
		internal void I9GSw7yhfXE()
		{
			zNDh9Ik4WewJJgeScb1 stateMachine = default(zNDh9Ik4WewJJgeScb1);
			stateMachine.R7S2cClFbHN = AsyncVoidMethodBuilder.Create();
			stateMachine.su82cPTt14F = this;
			stateMachine.iXr2c0rSpme = -1;
			stateMachine.R7S2cClFbHN.Start(ref stateMachine);
		}

		internal static bool BSUbfcWEphrjisG7b4Co()
		{
			return NMQi8PWEyK1UpFsndgsS == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> owTtFAaxRO4 = new string[3] { "输入框", "输入", "input" };

	[CompilerGenerated]
	private readonly string NTUtFO9nOS0 = $"fa:{EFontAwesomeIcon.Light_UserEdit}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> zChtFFvvUFS = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string Ju4tFU3OqPw = "https://getquicker.net/KC/Help/Doc/userInput";

	[CompilerGenerated]
	private readonly bool cZftFlQSGwp;

	private static readonly StepInParamDef MFLtFivwHSI;

	private static readonly StepInParamDef sCKtF3awKuC;

	private static readonly StepInParamDef OuutFfai92V;

	private static readonly StepInParamDef EF6tFzDbMng;

	private static readonly StepInParamDef k1ttUwXVosO;

	private static readonly StepInParamDef GhLtUtqttMN;

	private static readonly StepInParamDef n57tUgXeEIS;

	private static readonly StepInParamDef KOqtULpr6MO;

	private static readonly StepInParamDef qHitUv83oBy;

	private static readonly StepInParamDef q4OtUSYnqdw;

	private static readonly StepInParamDef C7YtU21igSY;

	private static readonly StepInParamDef oAOtUu18Pnx;

	private static readonly StepInParamDef rN3tUNVe1JY;

	private static readonly StepInParamDef n3TtUJwUYHn;

	private static readonly StepInParamDef XwytU0lejsY;

	private static readonly StepInParamDef IQItUCc0kfF;

	private static readonly StepInParamDef PGBtUP3MyD5;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> AEvtUExtHZa = new StepInParamDef[17]
	{
		MFLtFivwHSI, sCKtF3awKuC, OuutFfai92V, EF6tFzDbMng, k1ttUwXVosO, GhLtUtqttMN, n57tUgXeEIS, oAOtUu18Pnx, rN3tUNVe1JY, KOqtULpr6MO,
		n3TtUJwUYHn, C7YtU21igSY, qHitUv83oBy, q4OtUSYnqdw, XwytU0lejsY, IQItUCc0kfF, PGBtUP3MyD5
	};

	private static readonly StepOutParamDef JIdtUyNwpVO;

	private static readonly StepOutParamDef ql7tU8u4uys;

	private static readonly StepOutParamDef GortUarK07s;

	private static readonly StepOutParamDef tDUtU7jR4rW;

	private static readonly StepOutParamDef q2GtURbZOUa;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> iNYtUqjCNJP = new StepOutParamDef[5] { q2GtURbZOUa, JIdtUyNwpVO, ql7tU8u4uys, GortUarK07s, tDUtU7jR4rW };

	internal static UserInputStep DRuf3fQZJUvomG4hARfh;

	public string Key => "sys:userInput";

	public string Name => "用户输入";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return owTtFAaxRO4;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NTUtFO9nOS0;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return zChtFFvvUFS;
		}
	}

	public string Description => "请用户输入内容。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Ju4tFU3OqPw;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return cZftFlQSGwp;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return AEvtUExtHZa;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return iNYtUqjCNJP;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.y0qvzoL2FXC = step;
		_003C_003Ec__DisplayClass56_.CaXvzTXwOfs = context;
		_003C_003Ec__DisplayClass56_.QMmvzMHMGy4 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass56_.CaXvzTXwOfs, _003C_003Ec__DisplayClass56_.y0qvzoL2FXC, _003C_003Ec__DisplayClass56_.QMmvzMHMGy4, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass56_.HyjvzdRXRsX, (Action)null, (Action)null, PGBtUP3MyD5, q2GtURbZOUa);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(MFLtFivwHSI, step) ?? "";
	}

	static UserInputStep()
	{
		MFLtFivwHSI = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "输入内容的类型",
			DefaultValue = "text",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("text", "单行文本"),
				new SelectionItem("multiline", "多行文本"),
				new SelectionItem("number", "数字"),
				new SelectionItem("date_time", "日期时间")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		sCKtF3awKuC = new StepInParamDef
		{
			Key = "prompt",
			Name = "提示文字",
			Description = "提示用户输入什么内容。显示在输入框上方。",
			DefaultValue = "请输入内容",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		OuutFfai92V = new StepInParamDef
		{
			Key = "defaultValue",
			Name = "默认值",
			Description = "默认填写到输入框中的内容",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		EF6tFzDbMng = new StepInParamDef
		{
			Key = "texttools",
			Name = "文本选择工具",
			Description = "鼠标悬浮在文本框上时显示的小工具",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new List<string> { "text", "multiline" }
		};
		k1ttUwXVosO = new StepInParamDef
		{
			Key = "extraSettings",
			Name = "扩展设置",
			Description = "可用于自定义文本选择工具，详情请参考文档。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			IsAdvanced = true,
			ValidForList = new List<string> { "text", "multiline" }
		};
		GhLtUtqttMN = new StepInParamDef
		{
			Key = "pattern",
			Name = "验证表达式",
			Description = "正则验证表达式",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "text", "multiline", "number" }
		};
		n57tUgXeEIS = new StepInParamDef
		{
			Key = "isRequired",
			Name = "必填",
			Description = "是否必须填写内容",
			DefaultValue = false,
			Type = VarType.Boolean,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		KOqtULpr6MO = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[11]
			{
				new SelectionItem(ShowWindowLocation.WithMouse1.ToString(), "跟随鼠标（指针周围）"),
				new SelectionItem(ShowWindowLocation.WithMouse2.ToString(), "跟随鼠标（指针右下）"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下")
			},
			IsAdvanced = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		qHitUv83oBy = new StepInParamDef
		{
			Key = "restoreFocus",
			Name = "恢复活动窗口",
			Description = "用户输入后，是否将焦点还原到之前的活动窗口",
			DefaultValue = true,
			Type = VarType.Boolean,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		q4OtUSYnqdw = new StepInParamDef
		{
			Key = "closeOnDeactivated",
			Name = "失去焦点后关闭窗口",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		C7YtU21igSY = new StepInParamDef
		{
			Key = "submitWithReturn",
			Name = "回车提交结果（Shift+回车换行）",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "multiline" }
		};
		oAOtUu18Pnx = new StepInParamDef
		{
			Key = "fontfamily",
			Name = "字体名称",
			DefaultValue = "",
			Description = "可选。设置字体名称。如有2个字体，使用逗号分隔。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "text", "multiline", "number" },
			IsAdvanced = true
		};
		rN3tUNVe1JY = new StepInParamDef
		{
			Key = "fontsize",
			Name = "字体大小",
			DefaultValue = 14,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "text", "multiline", "number" },
			IsAdvanced = true
		};
		n3TtUJwUYHn = new StepInParamDef
		{
			Key = "imeState",
			Name = "输入法状态",
			DefaultValue = "NO_CONTROL",
			Description = "",
			IsRequired = false,
			IsAdvanced = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("NO_CONTROL", "不控制"),
				new SelectionItem("ON", "开启"),
				new SelectionItem("OFF", "关闭")
			},
			ValidForList = new List<string> { "text", "multiline" }
		};
		XwytU0lejsY = new StepInParamDef
		{
			Key = "help",
			Name = "帮助按钮内容",
			Description = "点击弹出显示帮助内容，MarkDown格式",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			DefaultHighlightType = "MarkDown"
		};
		IQItUCc0kfF = new StepInParamDef
		{
			Key = "topMost",
			Name = "置顶显示",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		PGBtUP3MyD5 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "用户取消后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		JIdtUyNwpVO = new StepOutParamDef
		{
			Key = "textValue",
			Name = "文本值",
			Description = "文本类型的输入值",
			Type = VarType.Text
		};
		ql7tU8u4uys = new StepOutParamDef
		{
			Key = "numberValue",
			Name = "数字值",
			Description = "数字类型的输入值",
			Type = VarType.Number,
			ValidForList = new List<string> { "number" }
		};
		GortUarK07s = new StepOutParamDef
		{
			Key = "datetimeValue",
			Name = "日期时间值",
			Description = "",
			Type = VarType.DateTime,
			ValidForList = new List<string> { "date_time" }
		};
		tDUtU7jR4rW = new StepOutParamDef
		{
			Key = "isEmpty",
			Name = "是否为空",
			Description = "用户是否没有输入内容",
			Type = VarType.Boolean
		};
		q2GtURbZOUa = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool OVHnueQZknxp5KxkSqjs()
	{
		return DRuf3fQZJUvomG4hARfh == null;
	}
}
