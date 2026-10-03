using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace mkNPXD55jdUOwoyJpya;

internal static class jvZjO55qkHGVjeDfEnG
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class miRXWgdsZCNgkytwZ9A
	{
		public uint HURvRqMggLi;

		public uint YkZvRc6iLWm;

		public ulong WAHvRVe40FC;

		public ulong kF3vRZcoQho;

		public ulong UqOvR9Fw86f;

		public ulong UBJvRhH6Ose;

		public ulong Ip4vReiur94;

		public ulong FCXvRYVTOTW;

		public ulong vRNvRIdOxda;

		private static miRXWgdsZCNgkytwZ9A Ir6B4vcOtqP4VDOC53DH;

		public miRXWgdsZCNgkytwZ9A()
		{
			HURvRqMggLi = (uint)Marshal.SizeOf(typeof(miRXWgdsZCNgkytwZ9A));
		}

		internal static bool qhiJPscOSFVqDUp7fGLI()
		{
			return Ir6B4vcOtqP4VDOC53DH == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static UnhandledExceptionEventHandler QlivRWjsOd1;

		public static DispatcherUnhandledExceptionEventHandler iFXvRki5SQ2;

		public static EventHandler<UnobservedTaskExceptionEventArgs> GvqvRGE5VOt;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec UQ3vR6KwEmG;

		public static Func<Assembly, bool> mw6vRXGUfVw;

		public static Func<Assembly, AssemblyName> SlSvRmUZ0mu;

		public static Func<AssemblyName, string> CblvRKp57yg;

		public static Func<AssemblyName, string> b3lvRxAR9TQ;

		internal static _003C_003Ec gEr3w6cOCOZUsnL7NMST;

		static _003C_003Ec()
		{
			UQ3vR6KwEmG = new _003C_003Ec();
		}

		internal bool kcpvRspv1Kg(Assembly ass)
		{
			return !ass.IsDynamic;
		}

		internal AssemblyName jFQvRHLE0PT(Assembly ass)
		{
			return ass.GetName();
		}

		internal string PIGvR1mkrYV(AssemblyName x)
		{
			return x.Name;
		}

		internal string lwuvRbpKXL3(AssemblyName x)
		{
			return $"{x.Name} v{x.Version}";
		}

		internal static bool bPv3bHcO7AsxYMYXHa9C()
		{
			return gEr3w6cOCOZUsnL7NMST == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct M9GhYwH9nZ3kZPjwkTq : IAsyncStateMachine
		{
			public int Hqj28OjRgh8;

			public AsyncTaskMethodBuilder HTn28FfS285;

			public _003C_003Ec__DisplayClass4_0 TVS28UskeH9;

			private TaskAwaiter tgT28llE6ZH;

			private static object mDmhtSy9qHlQ3xLKqJ3R;

			private void MoveNext()
			{
				int num = Hqj28OjRgh8;
				_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = TVS28UskeH9;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = wpIHHGKLK5(_003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception, "DispatcherUnhandledException", (!_003C_003Ec__DisplayClass4_.t1EvRBYgtnB) ? FeedbackType.ExceptionReport : FeedbackType.FilteredException).GetAwaiter();
						if (!zyJKhpy9iNW0eTr0iMUo())
						{
							switch (0)
							{
							}
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							Hqj28OjRgh8 = 0;
							tgT28llE6ZH = awaiter;
							HTn28FfS285.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = tgT28llE6ZH;
						tgT28llE6ZH = default(TaskAwaiter);
						num = -1;
						Hqj28OjRgh8 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					Hqj28OjRgh8 = -2;
					HTn28FfS285.SetException(exception);
					return;
				}
				Hqj28OjRgh8 = -2;
				HTn28FfS285.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				HTn28FfS285.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static M9GhYwH9nZ3kZPjwkTq()
			{
			}

			internal static bool zyJKhpy9iNW0eTr0iMUo()
			{
				return mDmhtSy9qHlQ3xLKqJ3R == null;
			}

			internal static void aIVHr5y95bgN2hJu9xOl()
			{
			}
		}

		public DispatcherUnhandledExceptionEventArgs WjKvRpoIquw;

		public bool t1EvRBYgtnB;

		private static _003C_003Ec__DisplayClass4_0 JonvuPcOHsjkaefCy3VX;

		[AsyncStateMachine(typeof(M9GhYwH9nZ3kZPjwkTq))]
		internal Task aKnvRrf0Mb2()
		{
			M9GhYwH9nZ3kZPjwkTq stateMachine = default(M9GhYwH9nZ3kZPjwkTq);
			stateMachine.HTn28FfS285 = AsyncTaskMethodBuilder.Create();
			stateMachine.TVS28UskeH9 = this;
			stateMachine.Hqj28OjRgh8 = -1;
			stateMachine.HTn28FfS285.Start(ref stateMachine);
			return stateMachine.HTn28FfS285.Task;
		}

		internal static bool jWSIkLcOzV8B0ARxLOYs()
		{
			return JonvuPcOHsjkaefCy3VX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct XFEpZLHPpS9nsaWcgBs : IAsyncStateMachine
		{
			public int lOa28iAVHQJ;

			public AsyncTaskMethodBuilder ayn283EgVVi;

			public _003C_003Ec__DisplayClass5_0 gWx28fa7IKb;

			private TaskAwaiter Edb28zOcq0V;

			private static object aTBt45y9YTgr4WKmJIBC;

			private void MoveNext()
			{
				int num = lOa28iAVHQJ;
				_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = gWx28fa7IKb;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = wpIHHGKLK5(_003C_003Ec__DisplayClass5_.csJvRjjOFLu, "CurrentDomainOnUnhandledException", FeedbackType.ExceptionReport).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							lOa28iAVHQJ = 0;
							Edb28zOcq0V = awaiter;
							ayn283EgVVi.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Edb28zOcq0V;
						if (aTBt45y9YTgr4WKmJIBC == null)
						{
							switch (0)
							{
							}
						}
						Edb28zOcq0V = default(TaskAwaiter);
						num = -1;
						lOa28iAVHQJ = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					lOa28iAVHQJ = -2;
					ayn283EgVVi.SetException(exception);
					return;
				}
				lOa28iAVHQJ = -2;
				ayn283EgVVi.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				ayn283EgVVi.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static XFEpZLHPpS9nsaWcgBs()
			{
			}

			internal static bool M7XTcCy98YiH43Pu79cb()
			{
				return aTBt45y9YTgr4WKmJIBC == null;
			}

			internal static void q9ymMVy9gH1voivxneYV()
			{
			}
		}

		public Exception csJvRjjOFLu;

		internal static _003C_003Ec__DisplayClass5_0 V8ecGLcJQsd5lMR7Yx5u;

		[AsyncStateMachine(typeof(XFEpZLHPpS9nsaWcgBs))]
		internal Task ENxvRQmGiQO()
		{
			XFEpZLHPpS9nsaWcgBs stateMachine = default(XFEpZLHPpS9nsaWcgBs);
			stateMachine.ayn283EgVVi = AsyncTaskMethodBuilder.Create();
			stateMachine.gWx28fa7IKb = this;
			stateMachine.lOa28iAVHQJ = -1;
			stateMachine.ayn283EgVVi.Start(ref stateMachine);
			return stateMachine.ayn283EgVVi.Task;
		}

		internal static bool fJIrHGcJFpPo20gIpGl6()
		{
			return V8ecGLcJQsd5lMR7Yx5u == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendExceptionFeedback_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Exception ex;

		public string description;

		public FeedbackType feedbackType;

		private ConfiguredTaskAwaitable<ApiResult<FeedbackDto>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Ux1qTicJygYRSK2Sq3K2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num == 0)
				{
					goto IL_00d1;
				}
				if (!(yiXHnowRWn == ex.GetType()) || !(L8kHj8Z6xP == ex.Message) || !((DateTime.Now - sF3H4sDjEc).TotalMinutes < 5.0))
				{
					yiXHnowRWn = ex.GetType();
					L8kHj8Z6xP = ex.Message;
					sF3H4sDjEc = DateTime.Now;
					goto IL_00d1;
				}
				MqPHpxA7Hi.Warn("5分钟内已发送过相同的异常反馈(" + yiXHnowRWn.Name + ", " + L8kHj8Z6xP + ")，忽略此次异常。");
				goto end_IL_0007;
				IL_00d1:
				if (Ux1qTicJygYRSK2Sq3K2 == null)
				{
					switch (0)
					{
					}
				}
				try
				{
					object obj;
					if (num != 0)
					{
						AppServer appServer = AppState.AppServer;
						if (appServer != null)
						{
							obj = appServer.GetRunningActionsInfo();
							if (obj != null)
							{
								goto IL_010a;
							}
						}
						else
						{
							obj = null;
						}
						obj = "";
						goto IL_010a;
					}
					ConfiguredTaskAwaitable<ApiResult<FeedbackDto>>.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<FeedbackDto>>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_02ba;
					IL_010a:
					string text = (string)obj;
					hKsHxuS1xZ(out var long_);
					string text2 = Bl3HbFfxAQ();
					FeedBackVm feedBackVm = new FeedBackVm();
					int num2 = 1;
					if (rj5IWScJpIY95uVhqKF1())
					{
						int num3 = default(int);
						while (true)
						{
							switch (num2)
							{
							case 1:
								feedBackVm.Description = description;
								feedBackVm.Title = "Exception:" + ex.GetMessageWithInner();
								feedBackVm.ExceptionStackTrace = RaVHKFoAmQ(ex);
								num2 = 0;
								if (!rj5IWScJpIY95uVhqKF1())
								{
									num2 = num3;
								}
								continue;
							case 2:
								goto IL_01da;
							}
							break;
						}
					}
					feedBackVm.FeedbackType = feedbackType;
					feedBackVm.ExeVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
					feedBackVm.OsVersion = Environment.OSVersion.VersionString ?? "";
					feedBackVm.Is64Bit = Environment.Is64BitOperatingSystem;
					goto IL_01da;
					IL_02ba:
					ApiResult<FeedbackDto> result = awaiter.GetResult();
					if (!result.IsSuccess)
					{
						MqPHpxA7Hi.Warn("发送异常反馈,服务器返回错误：" + result.Message);
					}
					goto end_IL_00ea;
					IL_01da:
					feedBackVm.UsingMemory = Process.GetCurrentProcess().WorkingSet64;
					feedBackVm.TotalMemory = long_;
					feedBackVm.ProcessList = TFFHmc3UCp() + "\r\n运行中的动作：" + text + "\r\n程序集版本：" + text2;
					FeedBackVm feedBackVm2 = feedBackVm;
					if (feedBackVm2.ExceptionStackTrace.Contains("DUCE.Channel.SyncFlush"))
					{
						feedBackVm2.ProcessList = feedBackVm2.ProcessList + "\r\n" + aAsH1Jd1of();
					}
					awaiter = aFIptTXYsUoTUF4v33R.rMlt1MFvU16(feedBackVm2).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02ba;
					end_IL_00ea:;
				}
				catch (Exception exception)
				{
					MqPHpxA7Hi.Warn("发送异常反馈出错：" + ex.Message, exception);
				}
				end_IL_0007:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
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

		static _003CSendExceptionFeedback_003Ed__11()
		{
		}

		internal static bool rj5IWScJpIY95uVhqKF1()
		{
			return Ux1qTicJygYRSK2Sq3K2 == null;
		}

		internal static void pU58MicJelydjMRIo4fw()
		{
		}
	}

	private static readonly ILog MqPHpxA7Hi;

	private static App DqeHBeXe31;

	private static bool rbXHQ44xmY;

	private static string L8kHj8Z6xP;

	private static Type yiXHnowRWn;

	private static DateTime sF3H4sDjEc;

	private static object AcgyMCZdj95bxKGKK3e;

	public static void DVjHIcFfCT(App app_1)
	{
		DqeHBeXe31 = app_1;
		AppDomain.CurrentDomain.UnhandledException += _003C_003EO.QlivRWjsOd1 ?? (_003C_003EO.QlivRWjsOd1 = hIRHGyHX0a);
		app_1.DispatcherUnhandledException += _003C_003EO.iFXvRki5SQ2 ?? (_003C_003EO.iFXvRki5SQ2 = BR7HkZj1Hj);
		TaskScheduler.UnobservedTaskException += _003C_003EO.GvqvRGE5VOt ?? (_003C_003EO.GvqvRGE5VOt = fA1HWX8kgd);
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private static void fA1HWX8kgd(object sender, UnobservedTaskExceptionEventArgs e)
	{
		MqPHpxA7Hi.Warn("未观察到任务的异常", e.Exception);
		e.SetObserved();
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private static void BR7HkZj1Hj(object sender, DispatcherUnhandledExceptionEventArgs e)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.WjKvRpoIquw = e;
		MqPHpxA7Hi.Error("遇到了未捕获的异常。" + _003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception.Message, _003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception);
		_003C_003Ec__DisplayClass4_.t1EvRBYgtnB = NDaHs4bJkX(_003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception);
		if (_003C_003Ec__DisplayClass4_.t1EvRBYgtnB && _003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception.StackTrace.Contains("AutomationPeer"))
		{
			MessageBox.Show("您使用的Windows有错误的系统组件，造成Quicker无法正常运行。\r\n请尝试：\r\n\t1) 更新Windows，安装所有最新补丁。\r\n\t2) 如果未解决，卸载近期安装的Windows更新。\r\n如果未能解决，请到Quicker网站寻求支持。\r\n错误：" + _003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception.Message, "系统问题", MessageBoxButton.OK, MessageBoxImage.Hand);
			return;
		}
		Task.Run((Func<Task>)_003C_003Ec__DisplayClass4_.aKnvRrf0Mb2);
		int num = 0;
		if (AcgyMCZdj95bxKGKK3e != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (_003C_003Ec__DisplayClass4_.t1EvRBYgtnB)
		{
			_003C_003Ec__DisplayClass4_.WjKvRpoIquw.Handled = true;
			MqPHpxA7Hi.Info("忽略此异常。", _003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception);
		}
		else if (DqeHBeXe31.cWC1L4fgG8(_003C_003Ec__DisplayClass4_.WjKvRpoIquw.Exception, "Application.Current.DispatcherUnhandledException", true))
		{
			_003C_003Ec__DisplayClass4_.WjKvRpoIquw.Handled = true;
		}
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private static void hIRHGyHX0a(object sender, UnhandledExceptionEventArgs e)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.csJvRjjOFLu = (Exception)e.ExceptionObject;
		MqPHpxA7Hi.Warn("AppDomain.CurrentDomain.UnhandledException：" + _003C_003Ec__DisplayClass5_.csJvRjjOFLu?.Message, _003C_003Ec__DisplayClass5_.csJvRjjOFLu);
		Task.Run((Func<Task>)_003C_003Ec__DisplayClass5_.ENxvRQmGiQO);
		DqeHBeXe31.cWC1L4fgG8(_003C_003Ec__DisplayClass5_.csJvRjjOFLu, "AppDomain.CurrentDomain.UnhandledException", false);
	}

	private static bool NDaHs4bJkX(Exception exception_0)
	{
		while (true)
		{
			if (exception_0 != null)
			{
				if (exception_0 is TypeInitializationException && exception_0.Message.Contains("GetSelection"))
				{
					goto IL_0402;
				}
				if (!(exception_0 is TypeLoadException) || !exception_0.Message.Contains("UIAutomationTypes"))
				{
					if (!(exception_0 is XamlParseException ex) || !ex.Message.Contains("StaticResourceHolder"))
					{
						if (!exception_0.StackTrace.Contains("DynamicClass."))
						{
							if (!exception_0.StackTrace.Contains("DUCE.Channel.SyncFlush"))
							{
								if (!(exception_0 is KeyNotFoundException) || !exception_0.StackTrace.Contains("GetDpiAwarenessCompatibleNotificationWindow"))
								{
									if (!(exception_0 is OutOfMemoryException))
									{
										if (!exception_0.StackTrace.Contains("AutomationPeer"))
										{
											if (!(exception_0 is COMException) || !exception_0.StackTrace.Contains("DoDragSourceMove"))
											{
												if (!(exception_0 is COMException) || !exception_0.Message.Contains("OpenClipboard"))
												{
													if (exception_0.StackTrace.Contains("Standard.NativeMethods.DwmExtendFrameIntoClientArea"))
													{
														break;
													}
													if (!exception_0.StackTrace.Contains("System.Security.Permissions.FileIOPermission.EmulateFileIOPermissionChecks"))
													{
														if (exception_0 is InvalidOperationException)
														{
															if (exception_0.StackTrace.Contains("System.Windows.Window.DragMove()"))
															{
																AppHelper.ShowWarning("拖放操作失败，只能在按下鼠标左键时启用拖动。");
																return true;
															}
															if (exception_0.StackTrace.Contains("VerifyNotClosing()"))
															{
																MqPHpxA7Hi.Warn("忽略再次关闭已经关闭的窗口。", exception_0);
																return true;
															}
														}
														if (!(exception_0 is ArgumentException) || !exception_0.StackTrace.Contains("MS.Win32.UnsafeNativeMethods.DoDragDrop"))
														{
															if (exception_0 is COMException && exception_0.StackTrace.Contains("MS.Internal.TextFormatting.TextMetrics.FullTextLine.FormatLine"))
															{
																goto IL_041f;
															}
															if (!exception_0.StackTrace.Contains("Microsoft.Web.WebView2.Core.CoreWebView2Controller.set_IsVisible") && !exception_0.StackTrace.Contains("CoreWebView2Controller.MoveFocus") && !exception_0.StackTrace.Contains("after the WebView2 control is disposed"))
															{
																if (!exception_0.StackTrace.Contains("TextInterface") && !exception_0.StackTrace.Contains("TextFormatting") && !exception_0.StackTrace.Contains("MS.Internal.Text.TextInterface.Native.Util.ConvertHresultToException"))
																{
																	string stackTrace = exception_0.StackTrace;
																	if (stackTrace == null || !stackTrace.Contains("SendKeysHookProc"))
																	{
																		if (exception_0 is InvalidOperationException)
																		{
																			string stackTrace2 = exception_0.StackTrace;
																			if (stackTrace2 == null)
																			{
																				if (AcgyMCZdj95bxKGKK3e == null)
																				{
																					switch (1)
																					{
																					case 3:
																						break;
																					case 2:
																						goto IL_03fe;
																					case 4:
																						goto IL_0400;
																					case 5:
																						goto IL_0402;
																					case 6:
																						goto IL_041f;
																					case 7:
																						goto IL_042c;
																					case 1:
																						goto IL_0457;
																					default:
																						goto end_IL_0281;
																					}
																					continue;
																				}
																			}
																			else if (stackTrace2.Contains("Media.Animation.Storyboard"))
																			{
																				MqPHpxA7Hi.Warn("忽略错误:" + exception_0.Message, exception_0);
																				return true;
																			}
																		}
																		goto IL_0457;
																	}
																	MqPHpxA7Hi.Warn("忽略SendKeys错误。" + exception_0.Message, exception_0);
																	return true;
																}
																AppHelper.ShowWarning("字体错误，请修复windows中已损坏的字体。");
																return true;
															}
															MqPHpxA7Hi.Warn("忽略的WebView异常：" + exception_0.Message, exception_0);
															return true;
														}
														AppHelper.ShowWarning("拖放操作失败。目标位置不支持此数据。");
														return true;
													}
													AppHelper.ShowWarning("Windows系统错误:" + exception_0.Message + "。请尝试恢复Windows默认主题。");
													return true;
												}
												AppHelper.ShowWarning("剪贴板操作失败，可能被其它程序锁定了，请重试。" + exception_0.Message);
												return true;
											}
											AppHelper.ShowWarning("拖放操作失败，Windows处于一种异常的拖放状态（重启Windows可解决）。");
											goto IL_042c;
										}
										return true;
									}
									if (!rbXHQ44xmY)
									{
										AppState.AppServer.StopAllRunningAction();
										rbXHQ44xmY = true;
										AppHelper.ShowError("可用内存不足或内存碎片过多，请重启Quicker或Windows。");
									}
									else
									{
										AppHelper.ShowError("可用内存不足或内存碎片过多，请重启Quicker或Windows。", false);
									}
									goto IL_0400;
								}
								MqPHpxA7Hi.Warn("忽略的异常：" + exception_0.Message, exception_0);
								return true;
							}
							MqPHpxA7Hi.Warn("忽略的异常：" + exception_0.Message, exception_0);
							return true;
						}
						MqPHpxA7Hi.Warn("C#脚本发生未捕捉到的异常(已忽略)。" + exception_0.GetMessageWithInner(), exception_0);
						AppHelper.ShowWarning("C#脚本模块出错。" + exception_0.GetMessageWithInner());
						return true;
					}
					MqPHpxA7Hi.Warn("忽略的异常：" + exception_0.Message, exception_0);
					return true;
				}
				MqPHpxA7Hi.Warn("忽略的异常：" + exception_0.GetMessageWithInner(), exception_0);
				return true;
			}
			goto IL_03fe;
			IL_0457:
			if (exception_0 is InvalidCastException && exception_0.Message.Contains("ICoreWebView2Controller"))
			{
				MqPHpxA7Hi.Warn(exception_0.Message, exception_0);
				AppHelper.ShowWarning(exception_0.Message);
				return true;
			}
			if (exception_0.StackTrace.Contains("IntelliTools"))
			{
				AppHelper.ShowWarning("动作中出现了未处理的异常：" + exception_0.Message);
			}
			return false;
			IL_0400:
			return true;
			IL_042c:
			return true;
			IL_0402:
			MqPHpxA7Hi.Warn("忽略的异常：" + exception_0.GetMessageWithInner(), exception_0);
			return true;
			IL_041f:
			AppHelper.ShowWarning("您的电脑系统字体有问题，请在Windows设置中修复字体后再使用Quicker。");
			return true;
			IL_03fe:
			return false;
			continue;
			end_IL_0281:
			break;
		}
		AppHelper.ShowWarning("Windows错误，请尝试重启Windows：" + exception_0.Message);
		return true;
	}

	[AsyncStateMachine(typeof(_003CSendExceptionFeedback_003Ed__11))]
	public static Task wpIHHGKLK5(Exception exception_0, string string_1, FeedbackType feedbackType_0)
	{
		_003CSendExceptionFeedback_003Ed__11 stateMachine = default(_003CSendExceptionFeedback_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.ex = exception_0;
		stateMachine.description = string_1;
		stateMachine.feedbackType = feedbackType_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static string aAsH1Jd1of()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(300);
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
			{
				foreach (ManagementObject item in managementObjectSearcher.Get())
				{
					stringBuilder.AppendLine(string.Format("GPU:{0} version:{1}", item["Name"], item["DriverVersion"]));
				}
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			return "获取显卡信息出错：" + ex.Message;
		}
	}

	private static string Bl3HbFfxAQ()
	{
		try
		{
			return string.Join("\r\n", AppDomain.CurrentDomain.GetAssemblies().Where(_003C_003Ec.mw6vRXGUfVw ?? (_003C_003Ec.mw6vRXGUfVw = _003C_003Ec.UQ3vR6KwEmG.kcpvRspv1Kg)).Select(_003C_003Ec.SlSvRmUZ0mu ?? (_003C_003Ec.SlSvRmUZ0mu = _003C_003Ec.UQ3vR6KwEmG.jFQvRHLE0PT))
				.OrderBy(_003C_003Ec.CblvRKp57yg ?? (_003C_003Ec.CblvRKp57yg = _003C_003Ec.UQ3vR6KwEmG.PIGvR1mkrYV))
				.Select(_003C_003Ec.b3lvRxAR9TQ ?? (_003C_003Ec.b3lvRxAR9TQ = _003C_003Ec.UQ3vR6KwEmG.lwuvRbpKXL3)));
		}
		catch (Exception ex)
		{
			return "获取出错：" + ex.Message;
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetGuiResources")]
	public static extern uint omFH6Laao6(IntPtr intptr_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GlobalMemoryStatusEx", SetLastError = true)]
	public static extern bool U5XHX8jClL([In][Out] miRXWgdsZCNgkytwZ9A miRXWgdsZCNgkytwZ9A_0);

	internal static string TFFHmc3UCp()
	{
		Process currentProcess = Process.GetCurrentProcess();
		int handleCount = currentProcess.HandleCount;
		uint num = omFH6Laao6(currentProcess.Handle, 0u);
		uint num2 = omFH6Laao6(currentProcess.Handle, 1u);
		miRXWgdsZCNgkytwZ9A miRXWgdsZCNgkytwZ9A = new miRXWgdsZCNgkytwZ9A();
		U5XHX8jClL(miRXWgdsZCNgkytwZ9A);
		return $"句柄:{handleCount} GDI对象:{num} 用户对象:{num2} 线程数:{currentProcess.Threads.Count} Exiting:{AppState.sD1t7gME9aw()}\r\n" + $"剩余内存:{miRXWgdsZCNgkytwZ9A.kF3vRZcoQho / 1024L / 1024L}MB 总内存:{miRXWgdsZCNgkytwZ9A.WAHvRVe40FC / 1048576L}MB\r\n" + $"当前进程: WorkingSet:{currentProcess.WorkingSet64 / 1048576L}MB  " + $"PrivateMemory:{currentProcess.PrivateMemorySize64 / 1048576L}MB " + $"VirtualMemorySize:{currentProcess.VirtualMemorySize64 / 1048576L}MB \r\n" + $"路径：{currentProcess.MainModule?.FileName}  启动时间：{DateTime.Now - currentProcess.StartTime:c}";
	}

	internal static string RaVHKFoAmQ(Exception exception_0)
	{
		if (exception_0 == null)
		{
			return "";
		}
		return exception_0.GetType().Name + ": " + exception_0.Message + "\r\n" + eOZHrsyoFI(exception_0) + "StackTrace:\r\n" + exception_0.StackTrace + "\r\n\r\n" + RaVHKFoAmQ(exception_0.InnerException);
	}

	[DllImport("kernel32.dll", EntryPoint = "GetPhysicallyInstalledSystemMemory")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool hKsHxuS1xZ(out long long_0);

	internal static string eOZHrsyoFI(Exception exception_0)
	{
		if (exception_0.GetType() == typeof(Exception))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(1024);
		PropertyInfo[] properties = exception_0.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			try
			{
				object value = propertyInfo.GetValue(exception_0);
				if (value != null && !value.ToString().IsNullOrEmpty())
				{
					stringBuilder.AppendLine($"--{propertyInfo.Name}: {value}");
				}
			}
			catch
			{
			}
		}
		return stringBuilder.ToString();
	}

	static jvZjO55qkHGVjeDfEnG()
	{
		MqPHpxA7Hi = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		rbXHQ44xmY = false;
		L8kHj8Z6xP = "";
		yiXHnowRWn = null;
		sF3H4sDjEc = DateTime.MinValue;
	}

	internal static bool l3iAkmZOk9o4o7ObMoa()
	{
		return AcgyMCZdj95bxKGKK3e == null;
	}
}
