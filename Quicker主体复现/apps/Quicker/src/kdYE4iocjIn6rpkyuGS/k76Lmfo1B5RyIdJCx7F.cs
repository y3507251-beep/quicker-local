using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using C2upcwoPZZhs1EfA15V;
using CSScriptLibrary;
using EOqy55MyMeuU2apYyog;
using FontAwesome5;
using HandyControl.Tools;
using kUOHHboesKGXLZGeqkc;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using Tx7JHl2LkU52UwokyCJ;
using ViNASxihuuLY1Gg9m6p;
using Z.Expressions;

namespace kdYE4iocjIn6rpkyuGS;

internal class k76Lmfo1B5RyIdJCx7F : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec YnvSGI105wx;

		public static Func<KeyValuePair<Window, string>, Window> DsaSGWRwJLv;

		public static Func<KeyValuePair<string, object>, string> aLSSGkcG3O4;

		public static Func<KeyValuePair<string, object>, object> XJnSGGhB2t2;

		public static Func<KeyValuePair<string, object>, string> nZNSGsOPYWh;

		public static Func<KeyValuePair<string, object>, object> HdTSGHAimOl;

		private static _003C_003Ec ONEXRWWbri57Fs5cALPd;

		static _003C_003Ec()
		{
			YnvSGI105wx = new _003C_003Ec();
		}

		internal Window nN0SGZK4Yk9(KeyValuePair<Window, string> x)
		{
			return x.Key;
		}

		internal string py4SG98MMEi(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object bkUSGhL1J7L(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal string nATSGe6i6pC(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object t9CSGY8dOpt(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal static void TdkkxBWbLDvOyD2yCDIC()
		{
		}

		internal static bool CIaeTwWbNOfW7vf9OhDu()
		{
			return ONEXRWWbri57Fs5cALPd == null;
		}

		internal static void f9aunYWbuQIFqcvj4qS1()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public ActionStep AafSGbAlVBc;

		public ActionExecuteContext KaXSG64TbEW;

		public XAction TorSGXXa8Iw;

		public k76Lmfo1B5RyIdJCx7F WpwSGmsbsVW;

		internal static _003C_003Ec__DisplayClass62_0 GJ5bmaWboEStH49qqH37;

		internal (bool isSuccess, string message, ActionStopFlag failReason) N3qSG1wFKmv()
		{
			_003C_003Ec__DisplayClass62_1 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_1
			{
				oRQSsLhRjdO = this
			};
			string textParamValue = XActionHelper.GetTextParamValue(PKHgXVB7BhC, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.MMASGD6wx2b = XActionHelper.GetTextParamValue(lf4gXYWKMaM, AafSGbAlVBc, KaXSG64TbEW);
			if (textParamValue == "GetWindows")
			{
				List<Window> result = RxhgX8UqrhY().Where(_003C_003Ec__DisplayClass62_.RL1SGKsBP0r).Select(_003C_003Ec.DsaSGWRwJLv ?? (_003C_003Ec.DsaSGWRwJLv = _003C_003Ec.YnvSGI105wx.nN0SGZK4Yk9)).ToList();
				XActionHelper.OutputResult(bH2gX6CETKF, AafSGbAlVBc, KaXSG64TbEW, result, TorSGXXa8Iw);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			if (textParamValue == "Close")
			{
				bool flag = false;
				using (List<KeyValuePair<Window, string>>.Enumerator enumerator = RxhgX8UqrhY().ToList().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass62_2 _003C_003Ec__DisplayClass62_2 = new _003C_003Ec__DisplayClass62_2
						{
							JdQSsClXLsI = enumerator.Current
						};
						if (string.Equals(_003C_003Ec__DisplayClass62_2.JdQSsClXLsI.Value, _003C_003Ec__DisplayClass62_.MMASGD6wx2b))
						{
							AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass62_2.CBvSs0g5Npw);
							flag = true;
							KaXSG64TbEW.ActionLogger.LogInfo("找到并关闭了窗口。");
						}
					}
				}
				if (!flag)
				{
					KaXSG64TbEW.ActionLogger.LogInfo("未找到窗口，可能之前已经关闭了。");
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			_003C_003Ec__DisplayClass62_.mGrSGAUsde2 = XActionHelper.GetTextParamValue(N9qgXZvcaI1, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.khBSGFF7hcO = XActionHelper.GetTextParamValue(QnZgXWXFP41, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.q2KSGlenj7S = XActionHelper.GetTextParamValue(xjZgX91W7gR, AafSGbAlVBc, KaXSG64TbEW);
			string textParamValue2 = XActionHelper.GetTextParamValue(mfHgXehVMso, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.GVvSGUtL3p4 = XActionHelper.GetTextParamValue(CLtgXkFf8Zv, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.cGLSGOQLgnb = XActionHelper.GetTextParamValue(oxygXs1A4y3, AafSGbAlVBc, KaXSG64TbEW);
			string textParamValue3 = XActionHelper.GetTextParamValue(oJPgXhQqEoO, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.zEESGMRP8RQ = Convert.ToInt32(1000.0 * XActionHelper.GetNumberParamValue(er1gXIofJpk, AafSGbAlVBc, KaXSG64TbEW));
			_003C_003Ec__DisplayClass62_.GVDSGiG4CqE = XActionHelper.GetBooleanParamValue(X85gXHJdxVY, AafSGbAlVBc, KaXSG64TbEW);
			_003C_003Ec__DisplayClass62_.A3uSG3urQ9w = textParamValue == "ShowAndWaitClose" && XActionHelper.IsOutputParamSetted(ak3gXKUbXqO.Key, AafSGbAlVBc);
			_003C_003Ec__DisplayClass62_.X3PSGf4vraC = "";
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass62_.mGrSGAUsde2))
			{
				return (isSuccess: false, message: "未提供窗口定义。", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass62_.FR5SGoUpnWr = new MemoryStream(Encoding.UTF8.GetBytes(_003C_003Ec__DisplayClass62_.mGrSGAUsde2));
			try
			{
				_003C_003Ec__DisplayClass62_.i01SGdY1W83 = null;
				_003C_003Ec__DisplayClass62_.IBWSGzsDL6t = textParamValue == "ShowAndWaitClose";
				XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu = new XqGiuUobZu5L8YTDYUu();
				xqGiuUobZu5L8YTDYUu.ykOg6jtSoFG(_003C_003Ec__DisplayClass62_.MMASGD6wx2b);
				xqGiuUobZu5L8YTDYUu.bgyg65HO2jc(KaXSG64TbEW);
				string[] array = textParamValue3.SplitToList();
				object obj;
				if (array == null)
				{
					obj = null;
				}
				else
				{
					obj = array.ToList();
					if (obj != null)
					{
						goto IL_033e;
					}
				}
				obj = new List<string>();
				goto IL_033e;
				IL_033e:
				xqGiuUobZu5L8YTDYUu.L1Eg6o31xm8((IList<string>)obj);
				_003C_003Ec__DisplayClass62_.d45SGTPRbhQ = xqGiuUobZu5L8YTDYUu;
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass62_.q2KSGlenj7S))
				{
					WpwSGmsbsVW.eIJgX0aJA8K(_003C_003Ec__DisplayClass62_.q2KSGlenj7S, KaXSG64TbEW, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ);
				}
				_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.NO0g6xRti1h(true);
				_003C_003Ec__DisplayClass62_.NhXSstljO93 = KpQc1Fo9vVSbWFx7GcL.sR3gm03BPA4(textParamValue2, "", true, KaXSG64TbEW);
				_003C_003Ec__DisplayClass62_.mtjSsw91fdq = null;
				_003C_003Ec__DisplayClass62_.hOpSsg8ZOIK = IntPtr.Zero;
				AppHelper.ByuLTpc7Q9J(_003C_003Ec__DisplayClass62_.MMASGxPXb4v).GetAwaiter().GetResult();
				if (_003C_003Ec__DisplayClass62_.i01SGdY1W83 == null)
				{
					return (isSuccess: false, message: "无法将窗口定义转换为窗口类型的对象。" + _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.ErrorMessage, failReason: ActionStopFlag.OperationFailed);
				}
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.ErrorMessage))
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.ErrorMessage, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResultIfNeeded(dMcgXmyyrvZ, _003C_003Ec__DisplayClass62_.ikASG4IyThi, AafSGbAlVBc, KaXSG64TbEW, TorSGXXa8Iw);
				if (_003C_003Ec__DisplayClass62_.A3uSG3urQ9w)
				{
					XActionHelper.OutputResult(ak3gXKUbXqO, AafSGbAlVBc, KaXSG64TbEW, _003C_003Ec__DisplayClass62_.X3PSGf4vraC, TorSGXXa8Iw);
				}
				XActionHelper.OutputResultIfNeeded(c0VgXbV0aR6, _003C_003Ec__DisplayClass62_.ft5SG5P15qF, AafSGbAlVBc, KaXSG64TbEW, TorSGXXa8Iw);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			finally
			{
				if (_003C_003Ec__DisplayClass62_.FR5SGoUpnWr != null)
				{
					((IDisposable)_003C_003Ec__DisplayClass62_.FR5SGoUpnWr).Dispose();
				}
			}
		}

		internal static bool per41NWbfimjXQ18ipLR()
		{
			return GJ5bmaWboEStH49qqH37 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct bAvqJykOZyR44t2XqOh : IAsyncStateMachine
		{
			public int rH92V0MA1i8;

			public AsyncTaskMethodBuilder QVu2VCsOXsu;

			public _003C_003Ec__DisplayClass62_1 ufW2VP8IuMX;

			private TaskAwaiter<bool?> H2X2VE1tT5E;

			internal static object JQBkgOybbmN2OFgYg2cs;

			private void MoveNext()
			{
				int num = rH92V0MA1i8;
				_003C_003Ec__DisplayClass62_1 _003C_003Ec__DisplayClass62_ = ufW2VP8IuMX;
				try
				{
					try
					{
						if (num == 0)
						{
							goto IL_052d;
						}
						_003C_003Ec__DisplayClass62_3 _003C_003Ec__DisplayClass62_2 = new _003C_003Ec__DisplayClass62_3
						{
							APlSs8LEF1i = _003C_003Ec__DisplayClass62_
						};
						_003C_003Ec__DisplayClass62_.i01SGdY1W83 = XamlReader.Load(_003C_003Ec__DisplayClass62_.FR5SGoUpnWr) as Window;
						TaskAwaiter<bool?> awaiter = default(TaskAwaiter<bool?>);
						if (_003C_003Ec__DisplayClass62_.i01SGdY1W83 != null)
						{
							if (_003C_003Ec__DisplayClass62_.i01SGdY1W83.Icon == null)
							{
								AppHelper.SetWindowIcon(_003C_003Ec__DisplayClass62_.i01SGdY1W83, _003C_003Ec__DisplayClass62_.oRQSsLhRjdO.KaXSG64TbEW?.Action?.Icon, true);
							}
							_003C_003Ec__DisplayClass62_.i01SGdY1W83.Tag = _003C_003Ec__DisplayClass62_.d45SGTPRbhQ;
							_003C_003Ec__DisplayClass62_.i01SGdY1W83.DataContext = _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.DataContext;
							_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.Window = _003C_003Ec__DisplayClass62_.i01SGdY1W83;
							AppHelper.AddGoToPageCommandBinding(_003C_003Ec__DisplayClass62_.i01SGdY1W83);
							AppHelper.AddCloseCommandBinding(_003C_003Ec__DisplayClass62_.i01SGdY1W83);
							_003C_003Ec__DisplayClass62_2.Gw4SsypJhXn = null;
							if (_003C_003Ec__DisplayClass62_.zEESGMRP8RQ >= 500)
							{
								_003C_003Ec__DisplayClass62_2.Gw4SsypJhXn = new DispatcherTimer(TimeSpan.FromMilliseconds(_003C_003Ec__DisplayClass62_.zEESGMRP8RQ), DispatcherPriority.ApplicationIdle, _003C_003Ec__DisplayClass62_2.SIeSsPsAh7E, Dispatcher.CurrentDispatcher);
							}
							_003C_003Ec__DisplayClass62_.i01SGdY1W83.SourceInitialized += _003C_003Ec__DisplayClass62_.nSVSsvM0Cw9 ?? (_003C_003Ec__DisplayClass62_.nSVSsvM0Cw9 = _003C_003Ec__DisplayClass62_.NawSGrXya7Q);
							if (_003C_003Ec__DisplayClass62_.GVDSGiG4CqE)
							{
								_003C_003Ec__DisplayClass62_.i01SGdY1W83.Deactivated += _003C_003Ec__DisplayClass62_.DdcSsSwZ1vX ?? (_003C_003Ec__DisplayClass62_.DdcSsSwZ1vX = _003C_003Ec__DisplayClass62_.TBXSGp776FJ);
							}
							if (_003C_003Ec__DisplayClass62_.A3uSG3urQ9w)
							{
								_003C_003Ec__DisplayClass62_.i01SGdY1W83.LocationChanged += _003C_003Ec__DisplayClass62_.lGDSs2BTweE ?? (_003C_003Ec__DisplayClass62_.lGDSs2BTweE = _003C_003Ec__DisplayClass62_.S5lSGB5qK9m);
								_003C_003Ec__DisplayClass62_.i01SGdY1W83.Closing += _003C_003Ec__DisplayClass62_.XAlSsuZx30T ?? (_003C_003Ec__DisplayClass62_.XAlSsuZx30T = _003C_003Ec__DisplayClass62_.qDmSGQcUQ1P);
							}
							if (_003C_003Ec__DisplayClass62_.IBWSGzsDL6t)
							{
								_003C_003Ec__DisplayClass62_.mtjSsw91fdq = _003C_003Ec__DisplayClass62_.oRQSsLhRjdO.KaXSG64TbEW?.CancellationToken?.Register(_003C_003Ec__DisplayClass62_.B1MSsJxQuRE ?? (_003C_003Ec__DisplayClass62_.B1MSsJxQuRE = _003C_003Ec__DisplayClass62_.e3ISGjqjNWO));
							}
							_003C_003Ec__DisplayClass62_.i01SGdY1W83.Closed += _003C_003Ec__DisplayClass62_2.l16SsEM7Go5;
							RxhgX8UqrhY()[_003C_003Ec__DisplayClass62_.i01SGdY1W83] = _003C_003Ec__DisplayClass62_.MMASGD6wx2b;
							if (_003C_003Ec__DisplayClass62_.NhXSstljO93 != null)
							{
								try
								{
									MethodDelegate staticMethod = _003C_003Ec__DisplayClass62_.NhXSstljO93.GetStaticMethod("*.OnWindowCreated", _003C_003Ec__DisplayClass62_.i01SGdY1W83, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.DataContext, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ);
									if (staticMethod != null)
									{
										try
										{
											staticMethod(_003C_003Ec__DisplayClass62_.i01SGdY1W83, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.DataContext, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ);
										}
										catch (Exception ex)
										{
											dPNgX714QNX.Warn("自定义窗口OnWindowCreated执行出错：" + ex.Message, ex);
											AppHelper.ShowWarning("自定义窗口OnWindowCreated执行出错：" + ex.Message);
										}
									}
								}
								catch (Exception ex2)
								{
									dPNgX714QNX.Warn("自定义窗口onCreate出错：" + ex2.Message, ex2);
								}
								int num2 = 0;
								if (JQBkgOybbmN2OFgYg2cs != null)
								{
									int num3 = default(int);
									num2 = num3;
								}
								switch (num2)
								{
								default:
									try
									{
										_003C_003Ec__DisplayClass62_4 _003C_003Ec__DisplayClass62_3 = new _003C_003Ec__DisplayClass62_4
										{
											XwrSsR6xZTK = _003C_003Ec__DisplayClass62_2,
											srcSs71lsrS = _003C_003Ec__DisplayClass62_.NhXSstljO93.GetStaticMethod("*.OnWindowLoaded", _003C_003Ec__DisplayClass62_.i01SGdY1W83, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ.DataContext, _003C_003Ec__DisplayClass62_.d45SGTPRbhQ)
										};
										_003C_003Ec__DisplayClass62_.i01SGdY1W83.Loaded += _003C_003Ec__DisplayClass62_3.L3GSsaJHR4C;
									}
									catch (Exception ex3)
									{
										dPNgX714QNX.Warn("自定义窗口OnWindowLoaded出错：" + ex3.Message, ex3);
									}
									try
									{
										object obj = new object();
										_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.WEYg6F7Udil(_003C_003Ec__DisplayClass62_.NhXSstljO93.GetStaticMethod<bool>("*.OnButtonClicked", new object[5]
										{
											"controlName",
											obj,
											_003C_003Ec__DisplayClass62_.i01SGdY1W83,
											_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.DataContext,
											_003C_003Ec__DisplayClass62_.d45SGTPRbhQ
										}));
									}
									catch (Exception ex4)
									{
										dPNgX714QNX.Warn("自定义窗口OnButtonClicked出错：" + ex4.Message, ex4);
									}
									break;
								case 4:
									break;
								case 3:
									goto IL_0512;
								case 2:
									goto IL_051a;
								case 1:
									goto IL_052d;
								}
							}
							if (_003C_003Ec__DisplayClass62_.IBWSGzsDL6t)
							{
								awaiter = _003C_003Ec__DisplayClass62_.i01SGdY1W83.MjdLOXIjD10(false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									rH92V0MA1i8 = 0;
									goto IL_0512;
								}
								goto IL_054b;
							}
							_003C_003Ec__DisplayClass62_.i01SGdY1W83.Show();
							_003C_003Ec__DisplayClass62_.hOpSsg8ZOIK = _003C_003Ec__DisplayClass62_.i01SGdY1W83.GetHandle();
						}
						goto end_IL_0011;
						IL_054b:
						awaiter.GetResult();
						goto end_IL_0011;
						IL_051a:
						QVu2VCsOXsu.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_052d:
						awaiter = H2X2VE1tT5E;
						H2X2VE1tT5E = default(TaskAwaiter<bool?>);
						num = -1;
						rH92V0MA1i8 = -1;
						goto IL_054b;
						IL_0512:
						H2X2VE1tT5E = awaiter;
						goto IL_051a;
						end_IL_0011:;
					}
					catch (Exception ex5)
					{
						dPNgX714QNX.Warn(ex5.Message, ex5);
						_003C_003Ec__DisplayClass62_.d45SGTPRbhQ.ErrorMessage = ex5.GetMessageWithInner();
					}
				}
				catch (Exception exception)
				{
					rH92V0MA1i8 = -2;
					QVu2VCsOXsu.SetException(exception);
					return;
				}
				rH92V0MA1i8 = -2;
				QVu2VCsOXsu.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				QVu2VCsOXsu.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Ui29n1ybqxIJPyspShJl()
			{
				return JQBkgOybbmN2OFgYg2cs == null;
			}
		}

		public string MMASGD6wx2b;

		public Window i01SGdY1W83;

		public MemoryStream FR5SGoUpnWr;

		public XqGiuUobZu5L8YTDYUu d45SGTPRbhQ;

		public int zEESGMRP8RQ;

		public string mGrSGAUsde2;

		public string cGLSGOQLgnb;

		public string khBSGFF7hcO;

		public string GVvSGUtL3p4;

		public string q2KSGlenj7S;

		public bool GVDSGiG4CqE;

		public bool A3uSG3urQ9w;

		public string X3PSGf4vraC;

		public bool IBWSGzsDL6t;

		public CancellationTokenRegistration? mtjSsw91fdq;

		public Assembly NhXSstljO93;

		public IntPtr hOpSsg8ZOIK;

		public _003C_003Ec__DisplayClass62_0 oRQSsLhRjdO;

		public EventHandler nSVSsvM0Cw9;

		public EventHandler DdcSsSwZ1vX;

		public EventHandler lGDSs2BTweE;

		public CancelEventHandler XAlSsuZx30T;

		public Action pHXSsNGswLr;

		public Action B1MSsJxQuRE;

		internal static _003C_003Ec__DisplayClass62_1 BOV5lPWbqYPi8AldNKbO;

		internal bool RL1SGKsBP0r(KeyValuePair<Window, string> x)
		{
			if (!string.IsNullOrEmpty(MMASGD6wx2b))
			{
				return x.Value == MMASGD6wx2b;
			}
			return true;
		}

		[AsyncStateMachine(typeof(bAvqJykOZyR44t2XqOh))]
		internal Task MMASGxPXb4v()
		{
			bAvqJykOZyR44t2XqOh stateMachine = default(bAvqJykOZyR44t2XqOh);
			stateMachine.QVu2VCsOXsu = AsyncTaskMethodBuilder.Create();
			stateMachine.ufW2VP8IuMX = this;
			stateMachine.rH92V0MA1i8 = -1;
			stateMachine.QVu2VCsOXsu.Start(ref stateMachine);
			return stateMachine.QVu2VCsOXsu.Task;
		}

		internal void NawSGrXya7Q(object sender, EventArgs e)
		{
			bool bool_ = mGrSGAUsde2.Contains("Topmost=");
			oRQSsLhRjdO.WpwSGmsbsVW.vDDgXPrPAly(i01SGdY1W83, cGLSGOQLgnb, khBSGFF7hcO, GVvSGUtL3p4, bool_);
			if (!string.IsNullOrEmpty(q2KSGlenj7S) && q2KSGlenj7S.Contains("//noMaximize"))
			{
				NativeMethods.SetWindowNoMaximize(i01SGdY1W83.GetHandle());
			}
		}

		internal void TBXSGp776FJ(object sender, EventArgs e)
		{
			if (i01SGdY1W83.IsLoaded)
			{
				try
				{
					i01SGdY1W83.Close();
				}
				catch
				{
				}
			}
		}

		internal void S5lSGB5qK9m(object sender, EventArgs e)
		{
			if (sender is Window { IsLoaded: not false } window)
			{
				string text = oRQSsLhRjdO.WpwSGmsbsVW.wkkgXJaoDxf(window);
				if (!string.IsNullOrEmpty(text))
				{
					X3PSGf4vraC = text;
				}
			}
		}

		internal void qDmSGQcUQ1P(object sender, CancelEventArgs e)
		{
			string text = oRQSsLhRjdO.WpwSGmsbsVW.wkkgXJaoDxf(sender as Window);
			if (!string.IsNullOrEmpty(text))
			{
				X3PSGf4vraC = text;
			}
		}

		internal void e3ISGjqjNWO()
		{
			AppHelper.RunOnUiThread(false, pHXSsNGswLr ?? (pHXSsNGswLr = t84SGnDmhU3));
		}

		internal void t84SGnDmhU3()
		{
			if (i01SGdY1W83.IsLoaded)
			{
				try
				{
					i01SGdY1W83.Close();
				}
				catch
				{
				}
			}
		}

		internal object ikASG4IyThi()
		{
			return hOpSsg8ZOIK;
		}

		internal object ft5SG5P15qF()
		{
			return d45SGTPRbhQ.Result;
		}

		internal static bool OHcEGmWbihfUl2EmDvEE()
		{
			return BOV5lPWbqYPi8AldNKbO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_2
	{
		public KeyValuePair<Window, string> JdQSsClXLsI;

		private static _003C_003Ec__DisplayClass62_2 ENfRtUWb5WwCSHJMpymY;

		internal void CBvSs0g5Npw()
		{
			JdQSsClXLsI.Key.Close();
		}

		internal static bool PLBIOnWbYtxJppVR8ru0()
		{
			return ENfRtUWb5WwCSHJMpymY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_3
	{
		public DispatcherTimer Gw4SsypJhXn;

		public _003C_003Ec__DisplayClass62_1 APlSs8LEF1i;

		private static _003C_003Ec__DisplayClass62_3 lwV7QbWbRdHrldZL8MuO;

		internal void SIeSsPsAh7E(object sender, EventArgs e)
		{
			Gw4SsypJhXn?.Stop();
			if (APlSs8LEF1i.i01SGdY1W83 != null && APlSs8LEF1i.i01SGdY1W83.IsLoaded)
			{
				try
				{
					APlSs8LEF1i.i01SGdY1W83.Close();
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("关闭窗口出错：" + ex.Message);
				}
			}
		}

		internal void l16SsEM7Go5(object sender, EventArgs e)
		{
			APlSs8LEF1i.mtjSsw91fdq?.Dispose();
			Gw4SsypJhXn?.Stop();
			Gw4SsypJhXn = null;
			if (RxhgX8UqrhY().ContainsKey(APlSs8LEF1i.i01SGdY1W83))
			{
				RxhgX8UqrhY().TryRemove(APlSs8LEF1i.i01SGdY1W83, out var value);
			}
			if (APlSs8LEF1i.d45SGTPRbhQ.EATg6XdFpbc().Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<string, string> item in APlSs8LEF1i.d45SGTPRbhQ.EATg6XdFpbc())
			{
				string key = item.Key;
				if (APlSs8LEF1i.d45SGTPRbhQ.bv0g6skIh4g().TryGetValue(key, out var value2))
				{
					object obj = APlSs8LEF1i.d45SGTPRbhQ.DataContext[key];
					if (obj is ObservableCollection<string> source)
					{
						obj = source.ToList();
					}
					try
					{
						XActionHelper.OutputResultToVariable(value2.Key, obj, APlSs8LEF1i.oRQSsLhRjdO.KaXSG64TbEW, APlSs8LEF1i.oRQSsLhRjdO.TorSGXXa8Iw);
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning($"无法保存变量{value2.Key}的值：{ex.Message}\r\nvalue：{obj}");
					}
				}
				else
				{
					dPNgX714QNX.Warn("未在FieldMapping找到key：" + key);
				}
			}
		}

		internal static bool A7lGVpWbgmIjwdSadxF2()
		{
			return lwV7QbWbRdHrldZL8MuO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_4
	{
		public MethodDelegate srcSs71lsrS;

		public _003C_003Ec__DisplayClass62_3 XwrSsR6xZTK;

		private static _003C_003Ec__DisplayClass62_4 eeVPxbWbMGOBt5SbtHti;

		internal void L3GSsaJHR4C(object sender, RoutedEventArgs e)
		{
			try
			{
				srcSs71lsrS(XwrSsR6xZTK.APlSs8LEF1i.i01SGdY1W83, XwrSsR6xZTK.APlSs8LEF1i.d45SGTPRbhQ.DataContext, XwrSsR6xZTK.APlSs8LEF1i.d45SGTPRbhQ);
			}
			catch (Exception ex)
			{
				dPNgX714QNX.Warn("自定义窗口OnWindowLoaded执行出错：" + ex.Message, ex);
				AppHelper.ShowWarning("自定义窗口OnWindowLoaded执行出错：" + ex.Message);
			}
		}

		internal static bool Cap1G1WbUV6ZhCwZcFr1()
		{
			return eeVPxbWbMGOBt5SbtHti == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		public XqGiuUobZu5L8YTDYUu iaYSsqn6t93;

		private static _003C_003Ec__DisplayClass63_0 n2rcLhWbIt5uhFJhUrAN;

		internal static bool vA65p0Wb6HOFNXB27PRL()
		{
			return n2rcLhWbIt5uhFJhUrAN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_1
	{
		public string EvMSsVCSP5U;

		internal static _003C_003Ec__DisplayClass63_1 G05FGCWbS18wD5jTiAWd;

		internal bool KiFSscjxkw4(ActionVariable x)
		{
			return x.Key == EvMSsVCSP5U;
		}

		internal static bool aQr6dHWbwl71f3DTQt9F()
		{
			return G05FGCWbS18wD5jTiAWd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_2
	{
		public KeyValuePair<string, ActionVariable> rbBSs91aFll;

		public _003C_003Ec__DisplayClass63_0 PfwSshH4Pc1;

		internal static _003C_003Ec__DisplayClass63_2 kxudB3WbmFnKNs1WciIc;

		internal void j89SsZLYWJw(object sender, NotifyCollectionChangedEventArgs e)
		{
			PfwSshH4Pc1.iaYSsqn6t93.EATg6XdFpbc()[rbBSs91aFll.Value.Key] = string.Empty;
		}

		internal static bool RsRxBCWbsm1qcsYBcnYQ()
		{
			return kxudB3WbmFnKNs1WciIc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		public string n31SsY4AP39;

		public string Yc6SsI4lLO1;

		public string FKASsWbIjxm;

		private static _003C_003Ec__DisplayClass67_0 C8IPpjWb7v3dL6qZXy4w;

		internal void bErSseI3RA9()
		{
			CxPyBB2GbLo3XslgL6G.oP6thw9VUmy(n31SsY4AP39, Yc6SsI4lLO1, FKASsWbIjxm, false);
		}

		internal static bool rfjVgjWb4ktTTEZiPgu2()
		{
			return C8IPpjWb7v3dL6qZXy4w == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CControlClickedEventHandler_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public RoutedEventArgs e;

		private XqGiuUobZu5L8YTDYUu _003CwindowContext_003E5__2;

		private IEnumerator<string> _003C_003E7__wrap2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object DPbMkPWbHnawMWZySFm0;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
        Window window = default;
        FrameworkElement frameworkElement = default;
				if (num == 0)
				{
					goto IL_00f0;
				}
				if (num == 1)
				{
					goto IL_01eb;
				}
				window = sender as Window;
				frameworkElement = e.OriginalSource as FrameworkElement;
				_003CwindowContext_003E5__2 = window.Tag as XqGiuUobZu5L8YTDYUu;
				string name;
				int num2;
				if (frameworkElement != null && window != null)
				{
					name = frameworkElement.Name;
					num2 = 1;
					if (!OybBj7WbzDIg95HDx1cN())
					{
						goto IL_00a1;
					}
					goto IL_00a5;
				}
				if (_003CwindowContext_003E5__2.W7dg64nQN4C().IsDebugging)
				{
					AppHelper.ShowWarning($"错误：按钮或窗口对象为空。win:{window} button:{frameworkElement}");
				}
				goto end_IL_0008;
				IL_00f0:
				string text = default(string);
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_01bd;
					}
					int num4 = default(int);
					while (_003C_003E7__wrap2.MoveNext())
					{
						string current = _003C_003E7__wrap2.Current;
						if (!current.StartsWith(text))
						{
							continue;
						}
						string string_ = current.Substring(text.Length);
						awaiter = YsegXyoCf1a(window, string_, _003CwindowContext_003E5__2, frameworkElement, sender, e).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							int num3 = 0;
							if (!OybBj7WbzDIg95HDx1cN())
							{
								num3 = num4;
							}
							switch (num3)
							{
							}
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01bd;
					}
					goto end_IL_00f0;
					IL_01bd:
					awaiter.GetResult();
					goto end_IL_0008;
					end_IL_00f0:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap2 != null)
					{
						_003C_003E7__wrap2.Dispose();
					}
				}
				_003C_003E7__wrap2 = null;
				goto IL_01eb;
				IL_01eb:
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						int num5 = 0;
						if (!OybBj7WbzDIg95HDx1cN())
						{
							int num6 = default(int);
							num5 = num6;
						}
						switch (num5)
						{
						}
						_003C_003Eu__1 = default(TaskAwaiter<bool>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0330;
					}
					string text2 = frameworkElement.GetValue(Att.ActionProperty) as string;
					if (!string.IsNullOrEmpty(text2))
					{
						awaiter = YsegXyoCf1a(window, text2, _003CwindowContext_003E5__2, frameworkElement, sender, e).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0330;
					}
					if (_003CwindowContext_003E5__2.UUog6OJS9Ls() != null)
					{
						try
						{
							_003CwindowContext_003E5__2.UUog6OJS9Ls()(frameworkElement.Name, frameworkElement.Tag, window, _003CwindowContext_003E5__2.DataContext, _003CwindowContext_003E5__2);
						}
						catch (Exception ex)
						{
							dPNgX714QNX.Warn("自定义窗口OnButtonClick回调出错：" + ex.Message, ex);
							AppHelper.ShowWarning("自定义窗口OnButtonClick回调出错：" + ex.Message);
						}
					}
					goto end_IL_01eb;
					IL_0330:
					awaiter.GetResult();
					end_IL_01eb:;
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning(ex2.Message ?? "");
					_003CwindowContext_003E5__2.ErrorMessage = ex2.Message;
				}
				goto end_IL_0008;
				IL_00a5:
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (_003CwindowContext_003E5__2 == null)
						{
							AppHelper.ShowWarning("错误：WindowContext为空。");
							goto end_IL_00a5;
						}
						goto IL_0070;
					}
					goto IL_00f0;
					IL_0070:
					text = name + ".click:";
					_003C_003E7__wrap2 = _003CwindowContext_003E5__2.JlMg6dBqTs1().GetEnumerator();
					num2 = 0;
					if (OybBj7WbzDIg95HDx1cN())
					{
						continue;
					}
					goto IL_00a1;
					continue;
					end_IL_00a5:
					break;
				}
				goto end_IL_0008;
				IL_00a1:
				int num7 = default(int);
				num2 = num7;
				goto IL_00a5;
				end_IL_0008:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CwindowContext_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CwindowContext_003E5__2 = null;
			_003C_003Et__builder.SetResult();
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

		internal static bool OybBj7WbzDIg95HDx1cN()
		{
			return DPbMkPWbHnawMWZySFm0 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessAction_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string actionData;

		public XqGiuUobZu5L8YTDYUu windowContext;

		public Window win;

		public object sender;

		public RoutedEventArgs e;

		public FrameworkElement control;

		private bool _003Cclose_003E5__2;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		private static object oLvJDeWqWPfofHuorFSN;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			bool result;
			try
			{
				if (num == 0)
				{
					goto IL_0082;
				}
				string text = "close:";
				int num2 = 0;
				if (oLvJDeWqWPfofHuorFSN != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (actionData.StartsWith(text))
				{
					windowContext.Result = actionData.Substring(text.Length);
					win.Close();
					result = true;
				}
				else
				{
					if (!string.IsNullOrEmpty(actionData))
					{
						goto IL_0082;
					}
					result = false;
				}
				goto end_IL_0008;
				IL_0082:
				try
				{
					TaskAwaiter<IDictionary<string, object>> awaiter = default(TaskAwaiter<IDictionary<string, object>>);
					if (num != 0)
					{
						_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
						string text3 = default(string);
						bool flag = default(bool);
						Dictionary<string, string> dictionary2 = default(Dictionary<string, string>);
						string[] allKeys = default(string[]);
						int num5 = default(int);
						Dictionary<string, object> dictionary = default(Dictionary<string, object>);
						int num6 = default(int);
						while (true)
						{
							NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(actionData);
							_003C_003Ec__DisplayClass67_.n31SsY4AP39 = string.Empty;
							_003C_003Ec__DisplayClass67_.Yc6SsI4lLO1 = string.Empty;
							_003C_003Ec__DisplayClass67_.FKASsWbIjxm = string.Empty;
							string text2 = string.Empty;
							_003Cclose_003E5__2 = false;
							int num4 = 4;
							if (oLvJDeWqWPfofHuorFSN != null)
							{
								goto IL_0203;
							}
							goto IL_0313;
							IL_0313:
							while (true)
							{
								switch (num4)
								{
								case 5:
									_003C_003Ec__DisplayClass67_.FKASsWbIjxm = nameValueCollection[text3];
									goto IL_0187;
								case 4:
									flag = false;
									dictionary2 = new Dictionary<string, string>();
									allKeys = nameValueCollection.AllKeys;
									num5 = 0;
									goto IL_0095;
								case 2:
									goto end_IL_0313;
								case 1:
									awaiter = SubProgramHelper.RunStandaloneSubprogram(text2, dictionary, windowContext.W7dg64nQN4C(), windowContext.Window).GetAwaiter();
									if (awaiter.IsCompleted)
									{
										goto end_IL_0339;
									}
									goto case 6;
								case 3:
									goto IL_03d0;
								case 6:
									{
										num = 0;
										_003C_003E1__state = 0;
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									IL_0187:
									num5++;
									goto IL_0095;
									IL_0095:
									if (num5 < allKeys.Length)
									{
										text3 = allKeys[num5];
										if (string.Equals(text3, "operation", StringComparison.OrdinalIgnoreCase))
										{
											_003C_003Ec__DisplayClass67_.n31SsY4AP39 = nameValueCollection[text3];
										}
										else if (string.Equals(text3, "data", StringComparison.OrdinalIgnoreCase))
										{
											_003C_003Ec__DisplayClass67_.Yc6SsI4lLO1 = nameValueCollection[text3];
										}
										else
										{
											if (string.Equals(text3, "action", StringComparison.OrdinalIgnoreCase))
											{
												num6 = 5;
												goto case 5;
											}
											if (string.Equals(text3, "close", StringComparison.OrdinalIgnoreCase))
											{
												_003Cclose_003E5__2 = VariableHelper.ConvertToBoolean(nameValueCollection[text3]) == true;
											}
											else if (string.Equals(text3, "compute", StringComparison.OrdinalIgnoreCase))
											{
												flag = VariableHelper.ConvertToBoolean(nameValueCollection[text3]) == true;
											}
											else if (string.Equals(text3, "spname", StringComparison.OrdinalIgnoreCase))
											{
												text2 = nameValueCollection[text3];
											}
											else
											{
												dictionary2.Add(text3, nameValueCollection[text3]);
											}
										}
										goto IL_0187;
									}
									goto IL_01ad;
								}
								if (!string.IsNullOrEmpty(text2))
								{
									dictionary = windowContext.DataContext.ToDictionary(_003C_003Ec.nZNSGsOPYWh ?? (_003C_003Ec.nZNSGsOPYWh = _003C_003Ec.YnvSGI105wx.nATSGe6i6pC), _003C_003Ec.HdTSGHAimOl ?? (_003C_003Ec.HdTSGHAimOl = _003C_003Ec.YnvSGI105wx.t9CSGY8dOpt));
									Dictionary<string, string>.Enumerator enumerator = dictionary2.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											KeyValuePair<string, string> current = enumerator.Current;
											dictionary[current.Key] = current.Value;
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
										}
									}
									dictionary.Add("__sender", sender);
									dictionary.Add("__e", e);
									dictionary.Add("__control", control);
									num4 = 1;
									if (oLvJDeWqWPfofHuorFSN == null)
									{
										continue;
									}
									goto IL_0203;
								}
								AppHelper.ShowWarning("运行子程序未指定子程序名称(spname)参数。");
								result = false;
								goto end_IL_0008;
								IL_03d0:
								Task.Run((Action)_003C_003Ec__DisplayClass67_.bErSseI3RA9);
								goto IL_0498;
								IL_01ad:
								if (flag)
								{
									MnhgXCbkiy5(windowContext, false);
								}
								if (string.Equals(_003C_003Ec__DisplayClass67_.n31SsY4AP39, "sp"))
								{
									num4 = 0;
									if (WYOW82WqyFlybyw64uyV())
									{
										continue;
									}
								}
								else
								{
									if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass67_.n31SsY4AP39))
									{
										goto IL_0498;
									}
									num4 = 3;
									if (oLvJDeWqWPfofHuorFSN == null)
									{
										continue;
									}
								}
								goto IL_0203;
								continue;
								end_IL_0313:
								break;
							}
							continue;
							IL_0203:
							num4 = num6;
							goto IL_0313;
							continue;
							end_IL_0339:
							break;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<IDictionary<string, object>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					IEnumerator<KeyValuePair<string, object>> enumerator2 = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							KeyValuePair<string, object> current2 = enumerator2.Current;
							if (windowContext.DataContext.ContainsKey(current2.Key))
							{
								windowContext.DataContext[current2.Key] = current2.Value;
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator2?.Dispose();
						}
					}
					goto IL_0498;
					IL_0498:
					if (_003Cclose_003E5__2)
					{
						win.Close();
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("执行操作出错：" + ex.Message);
				}
				result = false;
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

		static _003CProcessAction_003Ed__67()
		{
		}

		internal static bool WYOW82WqyFlybyw64uyV()
		{
			return oLvJDeWqWPfofHuorFSN == null;
		}

		internal static void FaRFgZWqeiQcWo1rniMU()
		{
		}
	}

	private static readonly ILog dPNgX714QNX;

	[CompilerGenerated]
	private readonly string esJgXRo6Plc = $"fa:{EFontAwesomeIcon.Light_WindowAlt}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> KrYgXqDG2nr;

	[CompilerGenerated]
	private readonly string n5egXcpcUdl = "https://getquicker.net/KC/Help/Doc/customwindow";

	private static readonly StepInParamDef PKHgXVB7BhC;

	private static readonly StepInParamDef N9qgXZvcaI1;

	private static readonly StepInParamDef xjZgX91W7gR;

	private static readonly StepInParamDef oJPgXhQqEoO;

	private static readonly StepInParamDef mfHgXehVMso;

	private static readonly StepInParamDef lf4gXYWKMaM;

	private static readonly StepInParamDef er1gXIofJpk;

	private static readonly StepInParamDef QnZgXWXFP41;

	private static readonly StepInParamDef CLtgXkFf8Zv;

	private static readonly StepInParamDef j8jgXGyhtG8;

	private static readonly StepInParamDef oxygXs1A4y3;

	private static readonly StepInParamDef X85gXHJdxVY;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> yMAgX1ZrNXJ = new StepInParamDef[12]
	{
		PKHgXVB7BhC, N9qgXZvcaI1, xjZgX91W7gR, mfHgXehVMso, oJPgXhQqEoO, lf4gXYWKMaM, er1gXIofJpk, oxygXs1A4y3, QnZgXWXFP41, CLtgXkFf8Zv,
		X85gXHJdxVY, j8jgXGyhtG8
	};

	private static readonly StepOutParamDef c0VgXbV0aR6;

	private static readonly StepOutParamDef bH2gX6CETKF;

	private static readonly StepOutParamDef a6NgXXBuLm9;

	private static readonly StepOutParamDef dMcgXmyyrvZ;

	private static readonly StepOutParamDef ak3gXKUbXqO;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> IyvgXxNyAF7 = new List<StepOutParamDef> { a6NgXXBuLm9, c0VgXbV0aR6, bH2gX6CETKF, dMcgXmyyrvZ, ak3gXKUbXqO };

	[CompilerGenerated]
	private static readonly ConcurrentDictionary<Window, string> rVbgXrTh7IU;

	internal static k76Lmfo1B5RyIdJCx7F udEjmbQCtQpFOEp5p2kB;

	public string Key => "sys:customwindow";

	public string Name => "自定义窗口";

	public IEnumerable<string> KeyWords => new List<string> { "Window" };

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return esJgXRo6Plc;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return KrYgXqDG2nr;
		}
	}

	public string Description => "创建和显示自定义窗口";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return n5egXcpcUdl;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return yMAgX1ZrNXJ;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return IyvgXxNyAF7;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	[SpecialName]
	[CompilerGenerated]
	private static ConcurrentDictionary<Window, string> RxhgX8UqrhY()
	{
		return rVbgXrTh7IU;
	}

	private string wkkgXJaoDxf(Window window_0)
	{
		if (window_0.WindowState == WindowState.Normal && window_0.IsLoaded)
		{
			try
			{
				NativeMethods.RECT lpRect = default(NativeMethods.RECT);
				NativeMethods.GetWindowRect(window_0.GetHandle(), out lpRect);
				if (lpRect.Top >= 0 || lpRect.Left > 0)
				{
					return $"{lpRect.Left},{lpRect.Top},{lpRect.Right},{lpRect.Bottom}";
				}
			}
			catch (Exception)
			{
			}
			return null;
		}
		return null;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
		_003C_003Ec__DisplayClass62_.AafSGbAlVBc = step;
		_003C_003Ec__DisplayClass62_.KaXSG64TbEW = context;
		_003C_003Ec__DisplayClass62_.TorSGXXa8Iw = action;
		_003C_003Ec__DisplayClass62_.WpwSGmsbsVW = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass62_.KaXSG64TbEW, _003C_003Ec__DisplayClass62_.AafSGbAlVBc, _003C_003Ec__DisplayClass62_.TorSGXXa8Iw, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass62_.N3qSG1wFKmv, (Action)null, (Action)null, j8jgXGyhtG8, a6NgXXBuLm9);
	}

	private void eIJgX0aJA8K(string string_2, ActionExecuteContext actionExecuteContext_0, XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu_0)
	{
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		_003C_003Ec__DisplayClass63_.iaYSsqn6t93 = xqGiuUobZu5L8YTDYUu_0;
		string[] array = string_2.SplitToList();
		int num = 0;
		int num4 = default(int);
		IEnumerator<KeyValuePair<string, ActionVariable>> enumerator = default(IEnumerator<KeyValuePair<string, ActionVariable>>);
		while (true)
		{
			string key;
			string text2;
			if (num < array.Length)
			{
				string text = array[num];
				if (!string.IsNullOrEmpty(text) && !text.StartsWith("//"))
				{
					int num2 = text.IndexOf(':');
					if (num2 < 1)
					{
						throw new InvalidDataException("数据映射错误,正确格式为：窗口变量:{动作变量} 或 窗口变量=根据其他窗口变量计算的表达式。");
					}
					key = text.Substring(0, num2);
					text2 = text.Substring(num2 + 1).Trim();
					int num3 = 1;
					if (!A0QEmgQCSO92HLIIXf53())
					{
						num3 = num4;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_00df;
						case 2:
							goto end_IL_0159;
						}
						if (text2[0] == '{')
						{
							goto IL_00f2;
						}
						if (text2.StartsWith("=") || text2.StartsWith("$="))
						{
							_003C_003Ec__DisplayClass63_.iaYSsqn6t93.j54g61YwXs2().Add(new KeyValuePair<string, string>(key, text2));
							num3 = 0;
							if (udEjmbQCtQpFOEp5p2kB == null)
							{
								break;
							}
							continue;
						}
						throw new InvalidDataException("数据映射错误,正确格式为：窗口变量:{动作变量} 或 窗口变量=根据其他窗口变量计算的表达式。");
						continue;
						end_IL_00df:
						break;
					}
				}
				goto IL_0153;
			}
			enumerator = _003C_003Ec__DisplayClass63_.iaYSsqn6t93.bv0g6skIh4g().GetEnumerator();
			break;
			IL_00f2:
			_003C_003Ec__DisplayClass63_1 _003C_003Ec__DisplayClass63_2 = new _003C_003Ec__DisplayClass63_1();
			_003C_003Ec__DisplayClass63_2.EvMSsVCSP5U = text2.Substring(1, text2.Length - 2);
			ActionVariable actionVariable = actionExecuteContext_0.XProgram.Variables?.FirstOrDefault(_003C_003Ec__DisplayClass63_2.KiFSscjxkw4);
			if (actionVariable != null)
			{
				_003C_003Ec__DisplayClass63_.iaYSsqn6t93.bv0g6skIh4g().Add(key, actionVariable);
				goto IL_0153;
			}
			throw new InvalidDataException("数据映射错误，变量不存在：" + _003C_003Ec__DisplayClass63_2.EvMSsVCSP5U);
			IL_0153:
			num++;
			continue;
			end_IL_0159:
			break;
		}
		try
		{
			int num6 = default(int);
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_3 = new _003C_003Ec__DisplayClass63_2();
				_003C_003Ec__DisplayClass63_3.PfwSshH4Pc1 = _003C_003Ec__DisplayClass63_;
				_003C_003Ec__DisplayClass63_3.rbBSs91aFll = enumerator.Current;
				object value = actionExecuteContext_0.GetVarValue(_003C_003Ec__DisplayClass63_3.rbBSs91aFll.Value.Key);
				if (_003C_003Ec__DisplayClass63_3.rbBSs91aFll.Value.Type == VarType.List)
				{
					int num5 = 0;
					if (!A0QEmgQCSO92HLIIXf53())
					{
						num5 = num6;
					}
					switch (num5)
					{
					default:
					{
						ObservableCollection<string> observableCollection = new ObservableCollection<string>(VariableHelper.ConvertToList(value));
						observableCollection.CollectionChanged += _003C_003Ec__DisplayClass63_3.j89SsZLYWJw;
						value = observableCollection;
						break;
					}
					}
				}
				_003C_003Ec__DisplayClass63_3.PfwSshH4Pc1.iaYSsqn6t93.DataContext[_003C_003Ec__DisplayClass63_3.rbBSs91aFll.Key] = value;
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		MnhgXCbkiy5(_003C_003Ec__DisplayClass63_.iaYSsqn6t93, true);
	}

	private static void MnhgXCbkiy5(XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu_0, bool bool_0)
	{
		int num2 = default(int);
		foreach (KeyValuePair<string, string> item in xqGiuUobZu5L8YTDYUu_0.j54g61YwXs2())
		{
			if (!bool_0 && item.Value.StartsWith("="))
			{
				continue;
			}
			string text = (item.Value.StartsWith("=") ? item.Value.Substring(1) : item.Value.Substring(2));
			Dictionary<string, object> dictionary = xqGiuUobZu5L8YTDYUu_0.DataContext.ToDictionary(_003C_003Ec.aLSSGkcG3O4 ?? (_003C_003Ec.aLSSGkcG3O4 = _003C_003Ec.YnvSGI105wx.py4SG98MMEi), _003C_003Ec.XJnSGGhB2t2 ?? (_003C_003Ec.XJnSGGhB2t2 = _003C_003Ec.YnvSGI105wx.bkUSGhL1J7L));
			if (text.StartsWith("$="))
			{
				text = text.Substring(2);
				IEnumerator<KeyValuePair<string, object>> enumerator2 = xqGiuUobZu5L8YTDYUu_0.W7dg64nQN4C().GetVariables().GetEnumerator();
				int num = 0;
				if (!A0QEmgQCSO92HLIIXf53())
				{
					num = num2;
				}
				switch (num)
				{
				}
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<string, object> current2 = enumerator2.Current;
						string text2 = "{" + current2.Key + "}";
						if (text.Contains(text2))
						{
							string text3 = "_" + current2.Key + "_";
							text = text.Replace(text2, text3);
							dictionary.Add(text3, current2.Value);
						}
					}
				}
				finally
				{
					enumerator2?.Dispose();
				}
			}
			object value = Eval.Execute(text, dictionary);
			xqGiuUobZu5L8YTDYUu_0.DataContext[item.Key] = value;
		}
	}

	private void vDDgXPrPAly(Window window_0, string string_2, string string_3, string string_4, bool bool_0)
	{
		ShowWindowLocation result = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(string_3, out result))
		{
			result = ShowWindowLocation.CenterScreen;
		}
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(window_0, result, string_4, true);
		int num;
		switch (string_2)
		{
		case "NotActivated":
			window_0.ShowActivated = false;
			break;
		case "NotActivatableMouseThrough":
			if (!bool_0)
			{
				window_0.Topmost = true;
				num = 0;
				if (A0QEmgQCSO92HLIIXf53())
				{
					goto IL_0098;
				}
			}
			goto IL_00a5;
		case "NotActivatable":
			if (!bool_0)
			{
				window_0.Topmost = true;
			}
			NativeMethods.SetWindowNoActivate(window_0);
			num = 1;
			if (!A0QEmgQCSO92HLIIXf53())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0098;
		case "AutoActivate":
			{
				window_0.ShowActivated = true;
				window_0.Activate();
				break;
			}
			IL_0098:
			switch (num)
			{
			case 1:
				goto end_IL_0027;
			}
			goto IL_00a5;
			IL_00a5:
			NativeMethods.SetWindowNoActivate(window_0);
			Quicker.Utilities.Win32.WindowHelper.SetWindowExTransparent(window_0.GetHandle());
			break;
			end_IL_0027:
			break;
		}
		window_0.AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(PnMgXECkXes));
		window_0.AddHandler(MenuItem.ClickEvent, new RoutedEventHandler(PnMgXECkXes));
	}

	[AsyncStateMachine(typeof(_003CControlClickedEventHandler_003Ed__66))]
	private static void PnMgXECkXes(object sender, RoutedEventArgs e)
	{
		_003CControlClickedEventHandler_003Ed__66 stateMachine = default(_003CControlClickedEventHandler_003Ed__66);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine.sender = sender;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CProcessAction_003Ed__67))]
	internal static Task<bool> YsegXyoCf1a(Window window_0, string string_2, XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu_0, FrameworkElement frameworkElement_0, object object_0, RoutedEventArgs routedEventArgs_0)
	{
		_003CProcessAction_003Ed__67 stateMachine = default(_003CProcessAction_003Ed__67);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.win = window_0;
		stateMachine.actionData = string_2;
		stateMachine.windowContext = xqGiuUobZu5L8YTDYUu_0;
		stateMachine.control = frameworkElement_0;
		stateMachine.sender = object_0;
		stateMachine.e = routedEventArgs_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(PKHgXVB7BhC, step) ?? "";
	}

	static k76Lmfo1B5RyIdJCx7F()
	{
		dPNgX714QNX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		PKHgXVB7BhC = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "ShowAndWaitClose",
			SelectionItems = new SelectionItem[4]
			{
				new SelectionItem("ShowAndWaitClose", "显示窗口并等待关闭"),
				new SelectionItem("Show", "显示窗口"),
				new SelectionItem("Close", "关闭窗口"),
				new SelectionItem("GetWindows", "获取窗口列表")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		N9qgXZvcaI1 = new StepInParamDef
		{
			Key = "windowMarkup",
			Name = "窗口XAML代码",
			Description = "窗口定义XAML代码",
			DefaultValue = "<Window xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n        xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"\r\n        xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n        xmlns:hc=\"https://handyorg.github.io/handycontrol\"\r\n        xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"\r\n        xmlns:qk=\"https://getquicker.net\"\r\n        Width=\"637\"\r\n        Height=\"556\"\r\n        Title=\"Test Window\"\r\n        mc:Ignorable=\"d\">\r\n  <Grid Margin=\"10\">\r\n    <StackPanel>\r\n      <TextBlock Margin=\"10,50,10,50\" Text=\"Hello World！\" FontSize=\"20\" />\r\n     \r\n      <Button Margin=\"10\" qk:Att.Action=\"close:result\" Style=\"{StaticResource ButtonPrimary}\" Width=\"50\">\r\n        关闭\r\n      </Button>\r\n    </StackPanel>\r\n  </Grid>\r\n</Window>",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" },
			DefaultHighlightType = "XML"
		};
		xjZgX91W7gR = new StepInParamDef
		{
			Key = "dataMapping",
			Name = "数据映射",
			Description = "将变量与窗口上下文数据进行映射。每行一个，格式为:“窗口数据项名称:{动作变量名}” 或 “窗口数据项:=表达式”",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ReplaceVariable = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" }
		};
		oJPgXhQqEoO = new StepInParamDef
		{
			Key = "events",
			Name = "事件",
			Description = "详细说明请参考模块文档",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" },
			IsAdvanced = true
		};
		mfHgXehVMso = new StepInParamDef
		{
			Key = "cscode",
			Name = "辅助C#代码",
			Description = "辅助处理窗口事件的代码，详见文档。",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = false,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" },
			IsAdvanced = true,
			DefaultHighlightType = "C#"
		};
		lf4gXYWKMaM = new StepInParamDef
		{
			Key = "windowId",
			Name = "窗口标识",
			Description = "如需单独的步骤关闭窗口，需使用标识查找窗口。",
			IsMultiLine = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		er1gXIofJpk = new StepInParamDef
		{
			Key = "autoCloseTime",
			Name = "自动关闭时间(S)",
			Description = "自动关闭窗口的时间（秒数）。需大于0.5秒。",
			IsMultiLine = false,
			DefaultValue = 0,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" },
			IsAdvanced = true
		};
		QnZgXWXFP41 = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[15]
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
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.FullScreen.ToString(), "全屏"),
				new SelectionItem(ShowWindowLocation.Maximized.ToString(), "最大化"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置"),
				new SelectionItem(ShowWindowLocation.Auto.ToString(), "系统默认")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" }
		};
		CLtgXkFf8Zv = new StepInParamDef
		{
			Key = "winSize",
			Name = "窗口尺寸/位置",
			Description = "设置选择窗口的最大尺寸，格式为：宽度,高度。支持像素数值或屏幕宽高百分比，详情请参考模块文档。\n“窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" }
		};
		j8jgXGyhtG8 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		oxygXs1A4y3 = new StepInParamDef
		{
			Key = "activateMode",
			Name = "激活模式",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "AutoActivate",
			SelectionItems = new SelectionItem[4]
			{
				new SelectionItem("NotActivatable", "不支持激活（不占用焦点，仅能使用鼠标操作）"),
				new SelectionItem("NotActivatableMouseThrough", "不支持激活，鼠标穿透"),
				new SelectionItem("NotActivated", "支持激活，打开时不抢占焦点"),
				new SelectionItem("AutoActivate", "支持激活，打开时抢占焦点")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" }
		};
		X85gXHJdxVY = new StepInParamDef
		{
			Key = "closeWhenDeactivate",
			Name = "失去焦点后关闭窗口",
			DefaultValue = false,
			Description = "仅在窗口支持激活（获取焦点）的情况下有效。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "Show", "ShowAndWaitClose" }
		};
		c0VgXbV0aR6 = new StepOutParamDef
		{
			Key = "result",
			Name = "窗口结果",
			Description = "通过close:result返回的结果",
			Type = VarType.Text,
			ValidForList = new List<string> { "ShowAndWaitClose", "Close" }
		};
		bH2gX6CETKF = new StepOutParamDef
		{
			Key = "windowList",
			Name = "窗口对象列表",
			Description = "IList<Window>对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetWindows" }
		};
		a6NgXXBuLm9 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		dMcgXmyyrvZ = new StepOutParamDef
		{
			Key = "windowHandle",
			Name = "窗口句柄",
			Type = VarType.Integer,
			ValidForList = new List<string> { "Show" }
		};
		ak3gXKUbXqO = new StepOutParamDef
		{
			Key = "windowLocation",
			Name = "关闭时窗口位置",
			Type = VarType.Text,
			ValidForList = new List<string> { "ShowAndWaitClose" }
		};
		rVbgXrTh7IU = new ConcurrentDictionary<Window, string>();
	}

	internal static bool A0QEmgQCSO92HLIIXf53()
	{
		return udEjmbQCtQpFOEp5p2kB == null;
	}

	internal static void i4YYkJQC41xycmH32E4B()
	{
	}
}
