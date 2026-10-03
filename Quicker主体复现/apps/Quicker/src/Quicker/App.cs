using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using AeNud9jpLbfIkkEIprl;
using Ci3RULiH5a8Cgg0fIS5;
using CommunityToolkit.Mvvm.Messaging;
using dkbgyyMixGueocCf9RC;
using eV7UJbXOdrPLKxjLbli;
using gki5O35wRvaQC3aK8iB;
using HandyControl.Data;
using HandyControl.Tools;
using HMdjedXPwaug8yh9mEq;
using j8ojdX2D2B58EaImI2T;
using JTIh7V5l65QV75A93Ly;
using kQya3FXgcklGlgx1NYl;
using log4net;
using log4net.Config;
using mkNPXD55jdUOwoyJpya;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ninject;
using Ninject.Parameters;
using Quicker.Api;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Floating;
using Quicker.Domain.Interfaces;
using Quicker.Domain.Messages;
using Quicker.Domain.Network;
using Quicker.Domain.PowerKeys;
using Quicker.Domain.Profiles;
using Quicker.Domain.Push;
using Quicker.Domain.Services;
using Quicker.Modules.Tables;
using Quicker.Properties;
using Quicker.Public;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Public.Interfaces;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using t7wokwYFlDgjUncgQNA;
using t8SGKhhgLWTgeqjGcrq;
using WcdJQYXW9E2moeWW9Np;
using wO0UogXeWxgnePQOF3R;
using Yf8A0Tj55ce1jngb1h3;
using Z.Expressions;

namespace Quicker;

public class App : System.Windows.Application
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec jeuvRMekbGk;

		public static Func<JsonSerializerSettings> vE9vRARTcXP;

		public static Func<KeyValuePair<string, double>, string> fQivROyvgsH;

		public static Func<ProcessModule, bool> UtovRFBcIUV;

		public static Action mDQvRUy1Ayq;

		public static Action Dc1vRl6DivK;

		public static Func<Process, bool> DH1vRi2fvy3;

		public static Func<Process, bool> FeGvR3DFhLG;

		private static _003C_003Ec amWnB7cJ1lCTywyRu1oo;

		static _003C_003Ec()
		{
			jeuvRMekbGk = new _003C_003Ec();
		}

		internal JsonSerializerSettings zZrvRnvuSlC()
		{
			return new JsonSerializerSettings
			{
				Converters = new List<JsonConverter>
				{
					new DataRowConverter()
				}
			};
		}

		internal string AgtvR47wYkI(KeyValuePair<string, double> x)
		{
			return $"{x.Key}:{x.Value}";
		}

		internal bool SyHvR5P1Qwc(ProcessModule m)
		{
			return m.FileName.EndsWith("YunShellExtV164.dll", StringComparison.OrdinalIgnoreCase);
		}

		internal void Cw1vRDjwK3n()
		{
			AppHelper.OpenHelpRedirectLink(27, "百度网盘导致卡死问题");
		}

		internal void xxnvRdMEW4G()
		{
			try
			{
				doH059XnuXRn8NRZyFk.MhagZZtDHep();
			}
			catch (Exception exception)
			{
				PoF17Zov9T.Warn("删除c#缓存出错。" + exception.GetMessageWithInner());
			}
		}

		internal bool Cx1vRoCvYdj(Process x)
		{
			return x.Id != Process.GetCurrentProcess().Id;
		}

		internal bool KqMvRTFG4RE(Process p)
		{
			return p.Id != Process.GetCurrentProcess().Id;
		}

		internal static void KtFiYJcJvp5DLYypVePR()
		{
		}

		internal static bool npw9cIcJKHE6iWXkRvWl()
		{
			return amWnB7cJ1lCTywyRu1oo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public string R5KvRzSYtA3;

		internal static _003C_003Ec__DisplayClass12_0 WGMf1ocJJVa9VMl1aihS;

		internal bool ORHvRfIx1Kt(Assembly x)
		{
			return x.GetName().Name.Equals(R5KvRzSYtA3, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool Kb6snJcJk3lrI1VoA11F()
		{
			return WGMf1ocJJVa9VMl1aihS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public DataService jDwvqt8UKG8;

		public App mKSvqg5WU7I;

		internal static _003C_003Ec__DisplayClass17_0 eXrOxycJrJSSpF83LEis;

		internal void BAjvqwhl2d7()
		{
			if (jDwvqt8UKG8.CpItmVISR7P().LoadFloatButtonState)
			{
				mKSvqg5WU7I.ylH1RlKQtr.Get<FloatButtonAndPanelManager>(Array.Empty<IParameter>()).xBetWZRU6Fr();
			}
			gIh8AyjqAySmmxFMtv4.nh5teW3nHJ7();
			mKSvqg5WU7I.Yl9HlPsjTW();
			jDwvqt8UKG8.LoadActionBlockListAsync();
		}

		internal static bool GEQJbkcJNUDUW6iHw29I()
		{
			return eXrOxycJrJSSpF83LEis == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public Exception wLYvqviuMlB;

		public bool S5TvqSuiP8N;

		public App FPHvq2QJ6K0;

		public bool Teevquu17qY;

		private static _003C_003Ec__DisplayClass28_0 HGCRNCcJLtfl5lQiPseA;

		internal void w70vqLnNfJj()
		{
			UnhandledExceptionWindow unhandledExceptionWindow = new UnhandledExceptionWindow(wLYvqviuMlB, S5TvqSuiP8N);
			if (System.Windows.Application.Current.MainWindow != null)
			{
				try
				{
					unhandledExceptionWindow.Owner = System.Windows.Application.Current.MainWindow;
				}
				catch
				{
				}
			}
			unhandledExceptionWindow.ShowDialog();
			if (unhandledExceptionWindow.IgnoreError)
			{
				Teevquu17qY = true;
				int num = 0;
				if (HGCRNCcJLtfl5lQiPseA != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				FPHvq2QJ6K0.TRE19eOUOf = false;
				try
				{
					FPHvq2QJ6K0.ODD1ZRho5I.FRAvgShyCwg();
					return;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("重新加载挂钩出错：" + ex.Message);
					return;
				}
			}
			FPHvq2QJ6K0.ODD1ZRho5I.End();
			FPHvq2QJ6K0.sX51g2Rk9m();
			if (unhandledExceptionWindow.AutoRestart)
			{
				AppHelper.RestartQuicker();
			}
			Environment.Exit(-1);
		}

		internal static bool uEBnAMcJui4eQc0f8Bd9()
		{
			return HGCRNCcJLtfl5lQiPseA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CApplicationStart_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public App _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object c8m4KFcJfy4XRNq7oMHI;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			App app = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
					{
						DefaultValue = System.Windows.Application.Current.FindResource(typeof(Window))
					});
					app.xGWHOWmiYP("启动位置A0：");
					awaiter = app.nlHHUSV45X().GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				app.xGWHOWmiYP("启动位置A1：");
				System.Windows.Forms.Application.EnableVisualStyles();
				if (NativeMethods.IsOnWindows10OrLater())
				{
					EventManager.RegisterClassHandler(typeof(Window), FrameworkElement.LoadedEvent, new RoutedEventHandler(app.kGj1NBkULE));
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
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

		internal static bool d5F8kCcJbjTa0Lg5HKCp()
		{
			return c8m4KFcJfy4XRNq7oMHI == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSessionEnding_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SessionEndingCancelEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__2;

		internal static object HaslyacJlWJ9hsjDnwCF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				int num3 = default(int);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					while (num == 1)
					{
						while (true)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							int num2 = 1;
							if (HaslyacJlWJ9hsjDnwCF != null)
							{
								num2 = num3;
							}
							switch (num2)
							{
							case 3:
								goto end_IL_002f;
							case 2:
								goto IL_00fe;
							case 1:
								goto IL_012d;
							}
							continue;
							end_IL_002f:
							break;
						}
					}
					if (AppState.DataService.SyncState != QuickerSyncState.Pending)
					{
						goto IL_0161;
					}
					PoF17Zov9T.Info("关机前发起了同步。");
					AppState.DataService.xdNt6mQNakh(true);
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				awaiter.GetResult();
				num3 = 2;
				goto IL_00fe;
				IL_00fe:
				_003Ci_003E5__2 = 0;
				goto IL_0146;
				IL_0161:
				if (AppHelper.NIXLTne5eZt() && MessageBoxHelper.Show("当前还有未关闭的Quicker动作编辑或文本窗口，您确定要关闭Windows么？", "尚未关闭Quicker窗口", MessageBoxButton.YesNo) == MessageBoxResult.No)
				{
					e.Cancel = true;
				}
				goto end_IL_0008;
				IL_0146:
				if (_003Ci_003E5__2 < 20)
				{
					if (AppState.DataService.SyncState == QuickerSyncState.Syncing)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_012d;
					}
					PoF17Zov9T.Info("同步完成。");
				}
				goto IL_0161;
				IL_012d:
				awaiter.GetResult();
				_003Ci_003E5__2++;
				goto IL_0146;
				end_IL_0008:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
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

		internal static bool tPYo3jcJZ3nMQj77hvM0()
		{
			return HaslyacJlWJ9hsjDnwCF == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartupApplicationAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public App _003C_003E4__this;

		private static object lUp4LtcJ8Q6hcAaoy4rS;

		private void MoveNext()
		{
			App app = _003C_003E4__this;
			try
			{
        AppServer appServer = default;
				_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0
				{
					mKSvqg5WU7I = _003C_003E4__this
				};
				AppState.UiThreadId = Thread.CurrentThread.ManagedThreadId;
				app.xGWHOWmiYP("启动位置0：");
				if (!Environment.Is64BitOperatingSystem)
				{
					goto IL_0057;
				}
				int num = 0;
				int num2 = default(int);
				if (!v5tKQ6cJRdmqdD1b2V9q())
				{
					num = num2;
				}
				goto IL_041c;
				IL_0243:
				_003C_003Ec__DisplayClass17_.jDwvqt8UKG8 = app.ylH1RlKQtr.Get<DataService>(Array.Empty<IParameter>());
				AppState.DataService = _003C_003Ec__DisplayClass17_.jDwvqt8UKG8;
				app.xGWHOWmiYP("启动位置5_1：");
				if (_003C_003Ec__DisplayClass17_.jDwvqt8UKG8.pNct6b5ah9E())
				{
					app.xGWHOWmiYP("启动位置6：");
					DateTime? dateTime = dDh7g7Xw7JyQPUTbYwJ.LastStartupTime;
					AppState.IsFirstStartInSameDay = !dateTime.HasValue || dateTime.Value.Date != DateTime.Now.Date;
					dDh7g7Xw7JyQPUTbYwJ.LastStartupTime = DateTime.Now;
					if (_003C_003Ec__DisplayClass17_.jDwvqt8UKG8.Hb9tmk3OsJ7())
					{
						FMP9ONqzXcgZ6r3WmZZ.sXXH7ZuLTN();
					}
					app.xGWHOWmiYP("启动位置6_1：");
					app.mUwHi44RYr();
					app.xGWHOWmiYP("启动位置6_2：");
					num = 0;
					if (v5tKQ6cJRdmqdD1b2V9q())
					{
						goto IL_031d;
					}
					goto IL_041c;
				}
				PoF17Zov9T.Error("数据服务启动失败。");
				System.Windows.Application.Current.Shutdown(1);
				goto end_IL_0008;
				IL_031d:
				app.ODD1ZRho5I = app.ylH1RlKQtr.Get<UIy1pYiDsLcf2l4joSP>(Array.Empty<IParameter>());
				app.ODD1ZRho5I.Tb6vtznNGgv();
				app.xGWHOWmiYP("启动位置6_3：");
				app.xGWHOWmiYP("启动位置6_4：");
				appServer = app.ylH1RlKQtr.Get<AppServer>(Array.Empty<IParameter>());
				num = 1;
				if (lUp4LtcJ8Q6hcAaoy4rS != null)
				{
					goto IL_037c;
				}
				goto IL_041c;
				IL_041c:
				while (true)
				{
					switch (num)
					{
					case 3:
						break;
					case 2:
						goto IL_031d;
					case 1:
						goto IL_037c;
					default:
						goto IL_03f1;
					case 4:
						goto IL_0462;
					case 5:
						AppHelper.ExitApplication();
						goto end_IL_0008;
					case 6:
						goto end_IL_0008;
					}
					break;
					IL_03f1:
					if (Environment.Is64BitProcess)
					{
						goto IL_0057;
					}
					AppHelper.ShowWarning(CommonStrings.App_ApplicationStart_WrongVersion);
					AppHelper.ShowWarning("请到本项目 GitHub Releases 下载适合当前系统的版本。");
					num = 5;
					if (lUp4LtcJ8Q6hcAaoy4rS == null)
					{
						continue;
					}
					goto IL_0462;
				}
				goto IL_0243;
				IL_0462:
				app.ylH1RlKQtr.Get<brgW8EX9ZVfZExh7q9t>(Array.Empty<IParameter>()).c8ptp8hF7GY();
				app.xGWHOWmiYP("启动位置8：");
				if (app.ylH1RlKQtr.Get<DataService>(Array.Empty<IParameter>()).CpItmVISR7P().ShowStartupTip)
				{
					AppHelper.ShowInformation(CommonStrings.App_ApplicationStart_StartUpCompleteMessage);
				}
				app.xGWHOWmiYP("启动位置9：");
				AppState.IsAppLoaded = true;
				_003C_003Ec__DisplayClass17_.jDwvqt8UKG8.sAXtXN0S6sN(false);
				AppHelper.FixMenuAlignProblem();
				appServer.UpdatePushConnection();
				app.ylH1RlKQtr.Get<S4xmQLXUpuXTfeUvpKh>(Array.Empty<IParameter>()).Tg3tjuRLwyW();
				Task.Run((Action)_003C_003Ec__DisplayClass17_.BAjvqwhl2d7);
				app.xGWHOWmiYP("启动位置10：");
				AppState.startupWatch.Stop();
				string text = string.Join("\r\n", app.xjw1VFq1iS.Select(_003C_003Ec.fQivROyvgsH ?? (_003C_003Ec.fQivROyvgsH = _003C_003Ec.jeuvRMekbGk.AgtvR47wYkI)));
				PoF17Zov9T.Info("启动耗时记录：" + text);
				goto end_IL_0008;
				IL_037c:
				appServer.Start();
				app.xGWHOWmiYP("启动位置6_5：");
				ActiveWindowHook activeWindowHook = app.ylH1RlKQtr.Get<ActiveWindowHook>(Array.Empty<IParameter>());
				AppState.Iqptak9JseT(activeWindowHook);
				activeWindowHook.Hook();
				app.xGWHOWmiYP("启动位置7：");
				app.ylH1RlKQtr.Get<ClientManager>(Array.Empty<IParameter>()).StartListening();
				app.ylH1RlKQtr.Get<IpcServer>(Array.Empty<IParameter>()).la4tpfLtwhe();
				num = 1;
				if (!v5tKQ6cJRdmqdD1b2V9q())
				{
					goto IL_041c;
				}
				goto IL_0462;
				IL_0057:
				app.xGWHOWmiYP("启动位置1：");
				jvZjO55qkHGVjeDfEnG.DVjHIcFfCT(app);
				app.xGWHOWmiYP("启动位置2：");
				try
				{
					SSrHfihiWP();
					try
					{
						AppHelper.UpdateProxySettings();
					}
					catch (Exception exception)
					{
						PoF17Zov9T.Warn("配置系统异常！" + exception.GetMessageWithInner(), exception);
					}
				}
				catch (Exception ex)
				{
					PoF17Zov9T.Error("初始化配置文件异常！" + ex.Message, ex);
					try
					{
						ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
					}
					catch (ConfigurationErrorsException ex2)
					{
						int num3 = 0;
						if (lUp4LtcJ8Q6hcAaoy4rS != null)
						{
							int num4 = default(int);
							num3 = num4;
						}
						switch (num3)
						{
						default:
						{
							string filename = ex2.Filename;
							PoF17Zov9T.Error("获取配置文件出错：" + ex.GetMessageWithInner(), ex2);
							if (File.Exists(filename))
							{
								PoF17Zov9T.Error("Config file " + filename + " content:\n" + File.ReadAllText(filename));
								File.Delete(filename);
								PoF17Zov9T.Error("Config file deleted");
								Quicker.Properties.Settings.Default.Upgrade();
							}
							else
							{
								PoF17Zov9T.Error("Config file " + filename + " does not exist");
							}
							break;
						}
						}
					}
					AppHelper.ShowWarning("本地配置文件(user.config)已损坏，请重启Quicker！", true);
					app.Shutdown(-1);
					goto end_IL_0008;
				}
				LiHHTKh4Ee();
				app.xGWHOWmiYP("启动位置3：");
				app.cfTH3CGrmo();
				app.xGWHOWmiYP("启动位置4：");
				SQLDataMgr sQLDataMgr = app.ylH1RlKQtr.Get<SQLDataMgr>(Array.Empty<IParameter>());
				try
				{
					sQLDataMgr.PrepareDb();
				}
				catch (Exception exception2)
				{
					PoF17Zov9T.Error("准备本地数据文件失败。", exception2);
					string dbFilePath = sQLDataMgr.GetDbFilePath();
					NativeMethods.OpenFolderAndSelectItem(Path.GetDirectoryName(dbFilePath), Path.GetFileName(dbFilePath));
					AppHelper.ShowWarning(CommonStrings.App_ApplicationStart_DbError + exception2.GetMessageWithInner(), true);
					System.Windows.Application.Current.Shutdown(1);
					goto end_IL_0008;
				}
				app.xGWHOWmiYP("启动位置5：");
				num2 = 3;
				goto IL_0243;
				end_IL_0008:;
			}
			catch (Exception exception3)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception3);
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

		internal static bool v5tKQ6cJRdmqdD1b2V9q()
		{
			return lUp4LtcJ8Q6hcAaoy4rS == null;
		}
	}

	private static readonly Mutex RAE1aNE0Jm;

	private static readonly ILog PoF17Zov9T;

	private IKernel ylH1RlKQtr;

	[CompilerGenerated]
	private static App Sh31qC3wQC;

	private IList<string> Jvr1cAUUid = new List<string>();

	private IList<KeyValuePair<string, double>> xjw1VFq1iS = new List<KeyValuePair<string, double>>();

	private UIy1pYiDsLcf2l4joSP ODD1ZRho5I;

	private bool TRE19eOUOf;

	[CompilerGenerated]
	private SkinType? sBx1hme5lN;

	private bool vLM1evbqaq;

	private static App dtqNYoZ56skv3dfgli6;

	internal new static App Current
	{
		[CompilerGenerated]
		get
		{
			return Sh31qC3wQC;
		}
		[CompilerGenerated]
		set
		{
			Sh31qC3wQC = value;
		}
	}

	protected override void OnStartup(StartupEventArgs e)
	{
		Current = this;
		HSrHzBlgrX();
		string path = "c:\\qk_disable_gpu.txt";
		try
		{
			if (File.Exists(path))
			{
				RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
				AppState.IsGpuDisabled = true;
				PoF17Zov9T.Warn("已禁用GPU加速");
			}
		}
		catch (Exception exception)
		{
			PoF17Zov9T.Warn("禁用GPU加速失败：" + exception.GetMessageWithInner());
		}
		if (e.Args.Length != 0)
		{
			PoF17Zov9T.Info("启动参数：" + e.Args.JoinToString(" "));
			if (e.Args[0] == "-autorun")
			{
				AppState.IsAutoRun = true;
			}
		}
		JsonConvert.DefaultSettings = _003C_003Ec.vE9vRARTcXP ?? (_003C_003Ec.vE9vRARTcXP = _003C_003Ec.jeuvRMekbGk.zZrvRnvuSlC);
		if (rXKOjBZYRgbIleHWP9s())
		{
			switch (0)
			{
			case 1:
				return;
			}
		}
		try
		{
			iOpt6F5A2XxAL2TeTuc.tl4HoSXTKn("Quicker");
		}
		catch (Exception exception2)
		{
			PoF17Zov9T.Warn("SetCurrentProcessExplicitAppUserModelID失败：" + exception2.GetMessageWithInner());
		}
		if (Environment.OSVersion.Version >= new Version(6, 3, 0))
		{
			if (!(Environment.OSVersion.Version >= new Version(10, 0, 15063)))
			{
				iOpt6F5A2XxAL2TeTuc.CXmHDbLfNt((iOpt6F5A2XxAL2TeTuc.DTDHiQd3de7SRfZVpHa)2);
			}
			else
			{
				iOpt6F5A2XxAL2TeTuc.BeyH5nSm7k(34);
			}
		}
		else
		{
			iOpt6F5A2XxAL2TeTuc.gqlHdxNjYW();
		}
		if (vIO1wrOgck())
		{
			AppDomain.CurrentDomain.AssemblyResolve += nT9HAZCI7a;
			base.OnStartup(e);
		}
	}

	private static void LiHHTKh4Ee()
	{
		EvalManager.AddLicense("4590;500-CuiLiang", "327d5618-1a40-610f-8553-a10d642dd0bc");
		if (!EvalManager.ValidateLicense(out var errorMessage))
		{
			System.Windows.MessageBox.Show("表达式引擎遇组件遇到问题：" + errorMessage);
		}
		EvalManager.DefaultContext.RegisterType(typeof(Regex), typeof(Path), typeof(Enumerable), typeof(JsonConvert), typeof(JArray), typeof(JObject), typeof(JProperty), typeof(JToken), typeof(JValue), typeof(DateTime), typeof(IDictionary<, >), typeof(IList<>), typeof(CommonExtensions), typeof(IActionContext), typeof(CommonOperationItem), typeof(CustomSearchResultItem), typeof(CustomSearchResult));
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(UriKind).Assembly);
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(JsonConvert).Assembly);
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(IDictionary<string, object>).Assembly);
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(Screen).Assembly);
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(Bitmap).Assembly);
		int num = 0;
		if (dtqNYoZ56skv3dfgli6 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(DataRowCollection).Assembly);
		EvalManager.DefaultContext.RegisterAutoAddMissingTypeAssembly(typeof(Global).Assembly);
		EvalManager.DefaultContext.RegisterGlobalVariable("_qk", QuickerApi.Instance);
		EvalManager.DefaultContext.AutoAddMissingTypes = true;
	}

	private void NteHMa6oLL()
	{
		h8GNtg2u86JIw02vpvJ h8GNtg2u86JIw02vpvJ = new h8GNtg2u86JIw02vpvJ();
		QueryContext queryContext = new QueryContext();
		int num = 0;
		if (dtqNYoZ56skv3dfgli6 != null)
		{
			goto IL_0069;
		}
		goto IL_006d;
		IL_0069:
		int num2 = default(int);
		num = num2;
		goto IL_006d;
		IL_006d:
		CancellationToken cancellationToken = default(CancellationToken);
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		IList<double> source = default(IList<double>);
		do
		{
			switch (num)
			{
			case 1:
			{
				IList<double> list = new List<double>();
				for (int i = 0; i < 10; i++)
				{
					Stopwatch stopwatch = Stopwatch.StartNew();
					IList<SearchResultItem> list2 = h8GNtg2u86JIw02vpvJ.DoSearch(queryContext, cancellationToken);
					long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
					num3 = list2.Count;
					list.Add(elapsedMilliseconds);
				}
				stringBuilder.AppendLine(string.Format("测试2搜索耗时：{0} 结果：{1} 每次：{2}", list.Sum(), num3, string.Join(",", list)));
				stringBuilder.AppendLine($"总：{source.Sum() + list.Sum()}");
				MessageBoxHelper.Show(stringBuilder.ToString());
				return;
			}
			}
			queryContext.PluginItem = new SearchPluginItem();
			cancellationToken = default(CancellationToken);
			source = new List<double>();
			stringBuilder = new StringBuilder();
			queryContext.SetSearch("qkdocx", true);
			num3 = 0;
			queryContext.SetSearch("qk docx", true);
			num = 1;
		}
		while (rXKOjBZYRgbIleHWP9s());
		goto IL_0069;
	}

	private Assembly nT9HAZCI7a(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Jvr1cAUUid.Contains(resolveEventArgs_0.Name))
		{
			return null;
		}
		Jvr1cAUUid.Add(resolveEventArgs_0.Name);
		Assembly result;
		try
		{
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			_003C_003Ec__DisplayClass12_.R5KvRzSYtA3 = new Regex(",.*").Replace(resolveEventArgs_0.Name, string.Empty);
			if (_003C_003Ec__DisplayClass12_.R5KvRzSYtA3.EndsWith(".resources"))
			{
				result = null;
			}
			else
			{
				Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(_003C_003Ec__DisplayClass12_.ORHvRfIx1Kt);
				if (assembly != null)
				{
					result = assembly;
				}
				else
				{
					result = Assembly.Load(_003C_003Ec__DisplayClass12_.R5KvRzSYtA3);
					int num = 0;
					if (!rXKOjBZYRgbIleHWP9s())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
		}
		catch (Exception ex)
		{
			PoF17Zov9T.Error("加载程序集" + resolveEventArgs_0.Name + "出错：(" + ex.GetType().Name + ") " + ex.Message, ex);
			if (ex is FileNotFoundException ex2)
			{
				PoF17Zov9T.Error("缺少文件：" + ex2.FileName + " " + ex2.FusionLog);
			}
			goto IL_0150;
		}
		return result;
		IL_0150:
		return null;
	}

	private void xGWHOWmiYP(string string_0)
	{
		xjw1VFq1iS.Add(new KeyValuePair<string, double>(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff") + " " + string_0, AppState.startupWatch.ElapsedMilliseconds));
	}

	[AsyncStateMachine(typeof(_003CApplicationStart_003Ed__15))]
	private void iPZHF6uMhh(object sender, StartupEventArgs e)
	{
		_003CApplicationStart_003Ed__15 stateMachine = default(_003CApplicationStart_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CStartupApplicationAsync_003Ed__17))]
	private Task nlHHUSV45X()
	{
		_003CStartupApplicationAsync_003Ed__17 stateMachine = default(_003CStartupApplicationAsync_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void Yl9HlPsjTW()
	{
		try
		{
			using Process process = Process.GetCurrentProcess();
			if (process.Modules.Cast<ProcessModule>().Any(_003C_003Ec.UtovRFBcIUV ?? (_003C_003Ec.UtovRFBcIUV = _003C_003Ec.jeuvRMekbGk.SyHvR5P1Qwc)))
			{
				AppHelper.ShowInformation("百度网盘YunShellExtV164.dll注入到了您的Quicker进程中，\r\n它可能导致Quicker卡死。\r\n点击此消息了解详情...", false, _003C_003Ec.mDQvRUy1Ayq ?? (_003C_003Ec.mDQvRUy1Ayq = _003C_003Ec.jeuvRMekbGk.Cw1vRDjwK3n));
			}
		}
		catch (Exception ex)
		{
			PoF17Zov9T.Warn("检查百度DLL注入出错：" + ex.Message, ex);
		}
	}

	private PopupWindow mUwHi44RYr()
	{
		xGWHOWmiYP("启动位置6A_1：");
		PopupWindow popupWindow = ylH1RlKQtr.Get<PopupWindow>(Array.Empty<IParameter>());
		if (!rXKOjBZYRgbIleHWP9s())
		{
			switch (0)
			{
			}
		}
		xGWHOWmiYP("启动位置6A_2：");
		popupWindow.Top = -2000.0;
		xGWHOWmiYP("启动位置6A_3：");
		popupWindow.Show();
		xGWHOWmiYP("启动位置6A_4：");
		base.MainWindow = popupWindow;
		xGWHOWmiYP("启动位置6A_5：");
		popupWindow.Hide();
		xGWHOWmiYP("启动位置6A_6：");
		return popupWindow;
	}

	private void cfTH3CGrmo()
	{
		ylH1RlKQtr = new StandardKernel();
		AppState.VV8ta6eYDoe(ylH1RlKQtr);
		ylH1RlKQtr.Bind<IAppPathProvider>().To<AppPathProvider>().InSingletonScope();
		ylH1RlKQtr.Bind<SQLDataMgr>().ToSelf().InSingletonScope();
		int num = 1;
		if (!rXKOjBZYRgbIleHWP9s())
		{
			goto IL_0095;
		}
		goto IL_025b;
		IL_0095:
		int num2 = default(int);
		num = num2;
		goto IL_025b;
		IL_025b:
		do
		{
			IL_025b_2:
			switch (num)
			{
			case 2:
				break;
			case 1:
			{
				ylH1RlKQtr.Bind<DataService>().ToSelf().InSingletonScope();
				TinyMessengerHub value = new TinyMessengerHub(new AppSubscriberErrorHandler());
				ylH1RlKQtr.Bind<ITinyMessengerHub>().ToConstant(value).InSingletonScope();
				ylH1RlKQtr.Get<DataService>(Array.Empty<IParameter>());
				ylH1RlKQtr.Bind<ProfileManager>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<ClientManager>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<PanelState>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<ProfileSwitcher>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<ActiveWindowHook>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<AppServer>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<UsageCounter>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<UIy1pYiDsLcf2l4joSP>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<PopupState>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<IconManager>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<IpcServer>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<ActionEditMgr>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<RunningActionMgr>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<brgW8EX9ZVfZExh7q9t>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<FloatButtonAndPanelManager>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<TextFloatPanelMgr>().ToSelf().InSingletonScope();
				num = 2;
				if (dtqNYoZ56skv3dfgli6 != null)
				{
					goto IL_025b_2;
				}
				break;
			}
			default:
				ylH1RlKQtr.Bind<F58U3QjL5trN9txFOH0>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<PopupWindow>().ToSelf().InSingletonScope();
				ylH1RlKQtr.Bind<AutoRunService>().ToSelf();
				ylH1RlKQtr.Bind<PushClient>().ToSelf().InSingletonScope();
				return;
			}
			ylH1RlKQtr.Bind<we8kb6Xb9dOkNdooDpA>().ToSelf().InSingletonScope();
			ylH1RlKQtr.Bind<PowerKeysService>().ToSelf().InSingletonScope();
			num = 0;
		}
		while (rXKOjBZYRgbIleHWP9s());
		goto IL_0095;
	}

	private static void SSrHfihiWP()
	{
		try
		{
			AO7eLUM7kJyEdiOQu2O.IU7LML773eo();
		}
		catch (Exception ex)
		{
			PoF17Zov9T.Warn("从旧版本升级配置失败：" + ex.Message);
		}
		AO7eLUM7kJyEdiOQu2O.yULLMvpPECk(PoF17Zov9T);
		if (!string.IsNullOrEmpty(Quicker.Properties.Settings.Default.PrevVersion))
		{
			if (!string.Equals(Quicker.Properties.Settings.Default.PrevVersion, AppHelper.GetSoftVersion()))
			{
				BrowserExtensionHelper.InstallChromeMessageHost(false);
				AppHelper.OpenVersionInfoPage(Quicker.Properties.Settings.Default.PrevVersion, AppHelper.GetSoftVersion());
				Task.Run(_003C_003Ec.Dc1vRl6DivK ?? (_003C_003Ec.Dc1vRl6DivK = _003C_003Ec.jeuvRMekbGk.xxnvRdMEW4G));
				if (dtqNYoZ56skv3dfgli6 != null)
				{
					switch (0)
					{
					}
				}
			}
			Quicker.Properties.Settings.Default.PrevVersion = AppHelper.GetSoftVersion();
			Quicker.Properties.Settings.Default.Save();
		}
		else
		{
			Quicker.Properties.Settings.Default.PrevVersion = AppHelper.GetSoftVersion();
			Quicker.Properties.Settings.Default.Save();
			BrowserExtensionHelper.InstallChromeMessageHost(false);
		}
	}

	private static void HSrHzBlgrX()
	{
		try
		{
			XmlConfigurator.Configure();
			PoF17Zov9T.Info("        =============  Started Logging  =============        ");
			PoF17Zov9T.Info("Quicker:" + AppHelper.GetCurrAppVersion() + "  Windows:" + Environment.OSVersion.VersionString);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("准备Log异常：" + ex.Message, true);
		}
	}

	private bool vIO1wrOgck()
	{
		bool result;
		try
		{
			if (Process.GetProcessesByName("quicker").Any(_003C_003Ec.DH1vRi2fvy3 ?? (_003C_003Ec.DH1vRi2fvy3 = _003C_003Ec.jeuvRMekbGk.Cx1vRoCvYdj)))
			{
				if (!RAE1aNE0Jm.WaitOne(300, false))
				{
					MessageBoxHelper.Show(CommonStrings.App_EnsureSingleton_AlreadyRunning, "Quicker");
					Shutdown();
					result = false;
					if (dtqNYoZ56skv3dfgli6 != null)
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
		}
		catch (AbandonedMutexException)
		{
			goto IL_0086;
		}
		return result;
		IL_0086:
		return true;
	}

	protected override void OnExit(ExitEventArgs e)
	{
		base.OnExit(e);
	}

	private static void HE21thHcrp()
	{
		using List<Process>.Enumerator enumerator = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Where(_003C_003Ec.FeGvR3DFhLG ?? (_003C_003Ec.FeGvR3DFhLG = _003C_003Ec.jeuvRMekbGk.KqMvRTFG4RE)).ToList()
			.GetEnumerator();
		if (enumerator.MoveNext())
		{
			Process current = enumerator.Current;
			AppHelper.SetForegroundWindow(current.MainWindowHandle);
			NativeMethods.ShowWindow(current.MainWindowHandle, 1);
		}
	}

	private void sX51g2Rk9m()
	{
		try
		{
			RAE1aNE0Jm.ReleaseMutex();
		}
		catch (Exception)
		{
		}
	}

	internal bool cWC1L4fgG8(Exception exception_0, string string_0, bool bool_2)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.wLYvqviuMlB = exception_0;
		_003C_003Ec__DisplayClass28_.S5TvqSuiP8N = bool_2;
		_003C_003Ec__DisplayClass28_.FPHvq2QJ6K0 = this;
		try
		{
			AppState.AppServer?.StopAllRunningAction();
		}
		catch (Exception)
		{
		}
		try
		{
			ActionStateWriter.Flush();
		}
		catch (Exception)
		{
		}
		int num;
		if (TRE19eOUOf)
		{
			num = 1;
			if (rXKOjBZYRgbIleHWP9s())
			{
				goto IL_00bb;
			}
			goto IL_00ca;
		}
		TRE19eOUOf = true;
		try
		{
			ODD1ZRho5I.Stop();
		}
		catch
		{
		}
		if (_003C_003Ec__DisplayClass28_.wLYvqviuMlB != null)
		{
			if (_003C_003Ec__DisplayClass28_.wLYvqviuMlB.GetMessageWithInner().Contains("DBROverlayIcon"))
			{
				MessageBoxHelper.Show("Dell Backup And Recovery造成了Quicker无法正常运行，请卸载后再使用Quicker。", "Quicker", MessageBoxButton.OK, MessageBoxImage.Hand);
				Environment.Exit(-1);
				num = 0;
				if (!rXKOjBZYRgbIleHWP9s())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00bb;
			}
		}
		else
		{
			_003C_003Ec__DisplayClass28_.wLYvqviuMlB = new Exception("捕捉到了空异常！");
		}
		goto IL_00dd;
		IL_00ca:
		return false;
		IL_00bb:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00dd;
		}
		goto IL_00ca;
		IL_00dd:
		string message = "Unhandled exception (" + string_0 + ")";
		try
		{
			AssemblyName name = Assembly.GetExecutingAssembly().GetName();
			message = $"Unhandled exception in {name.Name} v{name.Version}";
		}
		catch (Exception exception)
		{
			PoF17Zov9T.Error("Exception in LogUnhandledException", exception);
		}
		finally
		{
			PoF17Zov9T.Error(message, _003C_003Ec__DisplayClass28_.wLYvqviuMlB);
		}
		try
		{
			_003C_003Ec__DisplayClass28_.Teevquu17qY = false;
			System.Windows.Application.Current.Dispatcher?.Invoke(DispatcherPriority.Normal, new Action(_003C_003Ec__DisplayClass28_.w70vqLnNfJj));
			return _003C_003Ec__DisplayClass28_.Teevquu17qY;
		}
		catch
		{
		}
		return false;
	}

	private void BoG1vjPO7E(object sender, ExitEventArgs e)
	{
		try
		{
			ActionStateWriter.Flush();
		}
		catch (Exception)
		{
		}
		ylH1RlKQtr?.Get<FloatButtonAndPanelManager>(Array.Empty<IParameter>())?.Exit();
		ODD1ZRho5I?.End();
		sX51g2Rk9m();
	}

	[AsyncStateMachine(typeof(_003COnSessionEnding_003Ed__30))]
	private void uRE1SM579G(object sender, SessionEndingCancelEventArgs e)
	{
		_003COnSessionEnding_003Ed__30 stateMachine = default(_003COnSessionEnding_003Ed__30);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[SpecialName]
	[CompilerGenerated]
	internal SkinType? Brm1CjxFTF()
	{
		return sBx1hme5lN;
	}

	[SpecialName]
	[CompilerGenerated]
	private void b6y1PDhohU(SkinType? value)
	{
		sBx1hme5lN = value;
	}

	[SpecialName]
	internal bool n991yfUy4r()
	{
		return Brm1CjxFTF() == SkinType.Dark;
	}

	internal void DKC12DNm22(SkinType skinType_0)
	{
		DataService dataService = AppState.DataService;
		if (dataService != null && !dataService.Hb9tmk3OsJ7())
		{
			PoF17Zov9T.Warn("切换主题为专业版功能，当前不可用。");
			return;
		}
		SkinType? skinType = Brm1CjxFTF();
		if (skinType == skinType_0)
		{
			return;
		}
		b6y1PDhohU(skinType_0);
		int num = 0;
		if (dtqNYoZ56skv3dfgli6 != null)
		{
			goto IL_0063;
		}
		goto IL_0111;
		IL_0111:
		switch (num)
		{
		case 1:
		{
			bool bool_ = skinType == SkinType.Dark;
			foreach (Window window in Sh31qC3wQC.Windows)
			{
				if (window.IsLoaded)
				{
					FMP9ONqzXcgZ6r3WmZZ.Y6sH9w6XPI(window, bool_);
				}
			}
			UGNZKrYVGqgfWZbLcQj.hP3LxEbr7j3(bool_);
			if (AppState.DataService.CpItmVISR7P().SwitchUiSettingsBasedOnTheme && AppState.DataService.CpItmVISR7P().DarkUiSettings != null && AppState.IsAppLoaded && AppState.HS2taepcAbc() != null && AppState.HS2taepcAbc().IsLoaded)
			{
				AppState.Y2RtaqSv0AQ().NotifyUserSettingsChange(this);
			}
			WeakReferenceMessenger.Default.Send(new ThemeChangedMessage(skinType_0));
			AppState.NotifyIconWrapper?.UpdateIconAfterThemeChange();
			return;
		}
		}
		goto IL_0063;
		IL_0063:
		ResourceDictionary resourceDictionary = System.Windows.Application.Current.Resources.MergedDictionaries[0];
		resourceDictionary.MergedDictionaries.Clear();
		resourceDictionary.MergedDictionaries.Add(ResourceHelper.GetSkin(skinType_0));
		resourceDictionary.MergedDictionaries.Add(ResourceHelper.GetSkin(typeof(global::Quicker.App).Assembly, "Themes/Skin", skinType_0));
		ResourceDictionary resourceDictionary2 = base.Resources.MergedDictionaries[1];
		resourceDictionary2.MergedDictionaries.Clear();
		resourceDictionary2.MergedDictionaries.Add(new ResourceDictionary
		{
			Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
		});
		skinType = Brm1CjxFTF();
		num = 1;
		if (dtqNYoZ56skv3dfgli6 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0111;
	}

	internal void scE1uhLPsV()
	{
		SkinType? skinType = Brm1CjxFTF();
		DKC12DNm22(((skinType.GetValueOrDefault() == SkinType.Default) & skinType.HasValue) ? SkinType.Dark : SkinType.Default);
		AppHelper.ShowSuccess($"{Brm1CjxFTF()}");
	}

	private void kGj1NBkULE(object sender, RoutedEventArgs e)
	{
		if (Brm1CjxFTF() == SkinType.Dark)
		{
			FMP9ONqzXcgZ6r3WmZZ.Y6sH9w6XPI(sender as Window);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!vLM1evbqaq)
		{
			vLM1evbqaq = true;
			base.Exit += BoG1vjPO7E;
			base.SessionEnding += uRE1SM579G;
			base.Startup += iPZHF6uMhh;
			Uri resourceLocator = new Uri("/Quicker;component/app.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		try
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
		catch (Exception exception)
		{
			string details = exception.GetBaseException().Message;
			try
			{
				string logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QuickerOpenSource", "logs");
				Directory.CreateDirectory(logDirectory);
				string logPath = Path.Combine(logDirectory, "startup-error.log");
				File.AppendAllText(logPath, DateTimeOffset.Now.ToString("O") + Environment.NewLine + exception + Environment.NewLine + Environment.NewLine, Encoding.UTF8);
				details += "\n\n详细日志：" + logPath;
			}
			catch (Exception logException)
			{
				details += "\n\n无法写入错误日志：" + logException.Message;
			}
			System.Windows.MessageBox.Show("Quicker 启动或运行失败。\n\n" + details, "Quicker", MessageBoxButton.OK, MessageBoxImage.Error);
			Environment.ExitCode = 1;
		}
	}

	static App()
	{
		RAE1aNE0Jm = new Mutex(true, "Local\\{0404C3F2-0A51-4AC5-9E1F-1EAE33379725}");
		PoF17Zov9T = LogManager.GetLogger(typeof(App));
	}

	internal static bool rXKOjBZYRgbIleHWP9s()
	{
		return dtqNYoZ56skv3dfgli6 == null;
	}
}
