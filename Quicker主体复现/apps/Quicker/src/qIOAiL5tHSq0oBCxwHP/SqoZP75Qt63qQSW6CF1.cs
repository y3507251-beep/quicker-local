using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using log4net;
using NxArkNAjDilsy3A01yI;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.Sys;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using XIhlRTAWcPOLc2pSp5w;

namespace qIOAiL5tHSq0oBCxwHP;

internal class SqoZP75Qt63qQSW6CF1
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public string qxavcHnrr0b;

		public Action WFGvc1ch1la;

		internal static _003C_003Ec__DisplayClass1_0 Dk060wcrTWu2vakaVBAT;

		internal void Y6AvceCqF2o(object sender, RoutedEventArgs e)
		{
			AppHelper.TryOpenUrlOrFile(qxavcHnrr0b);
		}

		internal void Ol3vcYPbwsI(object sender, RoutedEventArgs e)
		{
			AppHelper.G6sLTlBUsTs(qxavcHnrr0b, true, null);
		}

		internal void a6mvcIcViBY(object sender, RoutedEventArgs e)
		{
			AppHelper.TryOpenUrlOrFile(qxavcHnrr0b);
		}

		internal void x7NvcWP0o6Q(object sender, RoutedEventArgs e)
		{
			DebugHelper.LogExecuteTime(WFGvc1ch1la ?? (WFGvc1ch1la = mp8vckEJJkR), "打开所在位置");
		}

		internal void mp8vckEJJkR()
		{
			AppHelper.SelectFileInExplorer(qxavcHnrr0b, false);
		}

		internal void BfYvcGaU5eK(object sender, RoutedEventArgs e)
		{
			try
			{
				UiAutomationStep.sW9gVXkNnxW(qxavcHnrr0b);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}

		internal void Jtrvcs2gEhH(object sender, RoutedEventArgs e)
		{
			try
			{
				UiAutomationStep.sW9gVXkNnxW(Path.GetDirectoryName(qxavcHnrr0b));
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}

		internal static bool SOvUMTcrmqj7M1HwNuVG()
		{
			return Dk060wcrTWu2vakaVBAT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct daYqQVHy2Je60jc0bwO : IAsyncStateMachine
		{
			public int M3A2awIvRE9;

			public AsyncVoidMethodBuilder ljf2at8mLtk;

			public _003C_003Ec__DisplayClass2_0 JTy2agmAZIO;

			private TaskAwaiter<bool> F8g2aLRkrNG;

			private static object LLpLYSy9PCrd9QJOoGxD;

			private void MoveNext()
			{
				int num = M3A2awIvRE9;
				_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = JTy2agmAZIO;
				try
				{
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = AppState.lWutartRfUY().CreateAndCopyActionForPath(_003C_003Ec__DisplayClass2_.CTYvcXu683G, _003C_003Ec__DisplayClass2_.ixwvcmIJt36, false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								if (!qrM3Hgy9MrKHrlErteGK())
								{
									int num3 = default(int);
									num2 = num3;
								}
								switch (num2)
								{
								}
								num = 0;
								M3A2awIvRE9 = 0;
								F8g2aLRkrNG = awaiter;
								ljf2at8mLtk.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = F8g2aLRkrNG;
							F8g2aLRkrNG = default(TaskAwaiter<bool>);
							num = -1;
							M3A2awIvRE9 = -1;
						}
						awaiter.GetResult();
						AppHelper.ShowSuccess("已复制动作，请在面板上空白位置粘贴。");
					}
					catch (Exception ex)
					{
						tIEB6VM8ih.Warn("创建动作失败：" + ex.Message, ex);
						AppHelper.ShowWarning("创建动作失败：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					M3A2awIvRE9 = -2;
					ljf2at8mLtk.SetException(exception);
					return;
				}
				M3A2awIvRE9 = -2;
				ljf2at8mLtk.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				ljf2at8mLtk.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool qrM3Hgy9MrKHrlErteGK()
			{
				return LLpLYSy9PCrd9QJOoGxD == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct SsWbs8H4Hpqc5m2cC2w : IAsyncStateMachine
		{
			public int FK62ava87MZ;

			public AsyncVoidMethodBuilder mLO2aSS8GZN;

			public _003C_003Ec__DisplayClass2_0 Q502a2M1Eax;

			private TaskAwaiter<bool> XMh2auqWGr4;

			internal static object uf8XbNy9I3cUZrKZHUmP;

			private void MoveNext()
			{
				int num = FK62ava87MZ;
				_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = Q502a2M1Eax;
				try
				{
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = AppState.lWutartRfUY().CreateAndCopyActionForPath(_003C_003Ec__DisplayClass2_.CTYvcXu683G, _003C_003Ec__DisplayClass2_.ixwvcmIJt36, true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								FK62ava87MZ = 0;
								XMh2auqWGr4 = awaiter;
								mLO2aSS8GZN.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = XMh2auqWGr4;
							if (uf8XbNy9I3cUZrKZHUmP == null)
							{
								switch (0)
								{
								}
							}
							XMh2auqWGr4 = default(TaskAwaiter<bool>);
							num = -1;
							FK62ava87MZ = -1;
						}
						awaiter.GetResult();
						AppHelper.ShowSuccess("已复制动作，请在面板上空白位置粘贴。");
					}
					catch (Exception ex)
					{
						tIEB6VM8ih.Warn("创建动作失败：" + ex.Message, ex);
						AppHelper.ShowWarning("创建动作失败：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					FK62ava87MZ = -2;
					mLO2aSS8GZN.SetException(exception);
					return;
				}
				FK62ava87MZ = -2;
				mLO2aSS8GZN.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				mLO2aSS8GZN.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool lufKefy96FX3hOeaarR2()
			{
				return uf8XbNy9I3cUZrKZHUmP == null;
			}
		}

		public string CTYvcXu683G;

		public string ixwvcmIJt36;

		private static _003C_003Ec__DisplayClass2_0 DHg0t4crCxDJHEcWnUGN;

		[AsyncStateMachine(typeof(daYqQVHy2Je60jc0bwO))]
		internal void oHQvcbkGuMv(object sender, RoutedEventArgs e)
		{
			daYqQVHy2Je60jc0bwO stateMachine = default(daYqQVHy2Je60jc0bwO);
			stateMachine.ljf2at8mLtk = AsyncVoidMethodBuilder.Create();
			stateMachine.JTy2agmAZIO = this;
			stateMachine.M3A2awIvRE9 = -1;
			stateMachine.ljf2at8mLtk.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(SsWbs8H4Hpqc5m2cC2w))]
		internal void zbEvc6YZkrM(object sender, RoutedEventArgs e)
		{
			SsWbs8H4Hpqc5m2cC2w stateMachine = default(SsWbs8H4Hpqc5m2cC2w);
			stateMachine.mLO2aSS8GZN = AsyncVoidMethodBuilder.Create();
			stateMachine.Q502a2M1Eax = this;
			stateMachine.FK62ava87MZ = -1;
			stateMachine.mLO2aSS8GZN.Start(ref stateMachine);
		}

		internal static bool APQIWLcr7Jrvk8RAd12g()
		{
			return DHg0t4crCxDJHEcWnUGN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string bdivcrbeFxU;

		public ContextMenu jSjvcpkKDmj;

		public ItemCollection FSwvcBB1ypr;

		public Action pKSvcQp9riM;

		public EventHandler<uTX3b0A2Kw0VvQl1fb6> xFsvcjQorYy;

		internal static _003C_003Ec__DisplayClass3_0 mWB3oscrhEbxDSEryrQJ;

		internal void m8SvcKnqoJv()
		{
			try
			{
				_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_1
				{
					deVvc4E66Rq = new zj8rqIAw38dI180QGip(bdivcrbeFxU, AppState.MainWinHandle)
				};
				jSjvcpkKDmj.Closed += _003C_003Ec__DisplayClass3_.aQkvcnn39dW;
				_003C_003Ec__DisplayClass3_.deVvc4E66Rq.IAyQ7lTDg5(jSjvcpkKDmj, FSwvcBB1ypr);
				zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip = _003C_003Ec__DisplayClass3_.deVvc4E66Rq;
				zj8rqIAw38dI180QGip.SY1QQ0V5H8 = (EventHandler<uTX3b0A2Kw0VvQl1fb6>)Delegate.Combine(zj8rqIAw38dI180QGip.SY1QQ0V5H8, xFsvcjQorYy ?? (xFsvcjQorYy = CqAvcx2QPl0));
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}

		internal void CqAvcx2QPl0(object o, uTX3b0A2Kw0VvQl1fb6 eventArgs)
		{
			if (!eventArgs.IsSuccess)
			{
				AppHelper.ShowWarning($"调用菜单[{eventArgs.eJoQjlPktO().Title}({eventArgs.eJoQjlPktO().Command})]失败：{eventArgs.n2uQd6uYSD()}, {eventArgs.ErrorMessage}");
			}
			pKSvcQp9riM?.Invoke();
		}

		internal static bool hxOeFBcrHxZh7UmxEgj8()
		{
			return mWB3oscrhEbxDSEryrQJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_1
	{
		public zj8rqIAw38dI180QGip deVvc4E66Rq;

		private static _003C_003Ec__DisplayClass3_1 KZusHycNQAJwOJyAP8Us;

		internal void aQkvcnn39dW(object sender, RoutedEventArgs e)
		{
			deVvc4E66Rq.Dispose();
		}

		internal static bool MaRAZOcNFml2mZVqR5I2()
		{
			return KZusHycNQAJwOJyAP8Us == null;
		}
	}

	private static readonly ILog tIEB6VM8ih;

	internal static SqoZP75Qt63qQSW6CF1 PkN1eRt3ivxnvkDpZNg;

	internal static void LZjBkbQjRm(string string_0, ItemCollection itemCollection_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.qxavcHnrr0b = string_0;
		if (_003C_003Ec__DisplayClass1_.qxavcHnrr0b.EndsWith(".exe"))
		{
			AppHelper.AddMenuItem(itemCollection_0, "运行", "运行此程序", "fa:Light_FolderOpen", _003C_003Ec__DisplayClass1_.Y6AvceCqF2o);
			int num = 0;
			if (!Dxm1detEixuT4FZU4Ti())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.AddMenuItem(itemCollection_0, "以管理员身份运行", "以管理员身份运行此程序", "fa:Light_Shield", _003C_003Ec__DisplayClass1_.Ol3vcYPbwsI);
		}
		else
		{
			AppHelper.AddMenuItem(itemCollection_0, "打开", "打开文件或文件夹", "fa:Light_FolderOpen", _003C_003Ec__DisplayClass1_.a6mvcIcViBY);
		}
		AppHelper.AddMenuItem(itemCollection_0, "打开所在位置", "资源管理器中定位文件或文件夹", "fa:Light_FolderOpen", _003C_003Ec__DisplayClass1_.x7NvcWP0o6Q);
		if (_003C_003Ec__DisplayClass1_.qxavcHnrr0b.StartsWith("shell:"))
		{
			return;
		}
		IntPtr intPtr = OpenWindowGetter.FindAllWindowsWithClassName("#32770", StringComparison.Ordinal).FirstOrDefault();
		if (intPtr != IntPtr.Zero)
		{
			string windowText = NativeMethods.GetWindowText(intPtr);
			AppHelper.AddMenuItem(itemCollection_0, "填写到 " + windowText + " 对话框", "将当前路径发送到“另存为”或“打开”对话框。", "fa:Light_Share", _003C_003Ec__DisplayClass1_.BfYvcGaU5eK);
			if (File.Exists(_003C_003Ec__DisplayClass1_.qxavcHnrr0b))
			{
				AppHelper.AddMenuItem(itemCollection_0, "所在目录填写到 " + windowText + " 对话框", "将文件所在目录的路径径发送到“另存为”或“打开”对话框。", "fa:Light_Share", _003C_003Ec__DisplayClass1_.Jtrvcs2gEhH);
			}
		}
	}

	internal static void gJjBGR977Q(string string_0, string string_1, ItemCollection itemCollection_0)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.CTYvcXu683G = string_0;
		_003C_003Ec__DisplayClass2_.ixwvcmIJt36 = string_1;
		AppHelper.AddMenuItem(itemCollection_0, "复制为动作", "创建一个动作并复制到剪贴板，可以在面板上空白位置粘贴。", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass2_.oHQvcbkGuMv);
		if (_003C_003Ec__DisplayClass2_.CTYvcXu683G.EndsWith(".lnk") && File.Exists(_003C_003Ec__DisplayClass2_.CTYvcXu683G))
		{
			AppHelper.AddMenuItem(itemCollection_0, "复制为动作：快捷方式的目标", "创建一个动作并复制到剪贴板，直接打开此快捷方式文件所指向的目标程序或文件。", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass2_.zbEvc6YZkrM);
		}
	}

	internal static void TITBsl183p(string string_0, ItemCollection itemCollection_0, ContextMenu contextMenu_0, Action action_0 = null)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.bdivcrbeFxU = string_0;
		_003C_003Ec__DisplayClass3_.jSjvcpkKDmj = contextMenu_0;
		_003C_003Ec__DisplayClass3_.pKSvcQp9riM = action_0;
		MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, "资源管理器菜单", "显示Windows系统资源管理器菜单项", "fa:Brands_Windows", null);
		_003C_003Ec__DisplayClass3_.FSwvcBB1ypr = menuItem.Items;
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().z1EtktydB9E(_003C_003Ec__DisplayClass3_.m8SvcKnqoJv);
	}

	private static void hOfBHJkQiQ(object sender, RoutedEventArgs e)
	{
		throw new NotImplementedException();
	}

	public static IntPtr eEIB1gOW52(string string_0, string string_1)
	{
		return irdBb4eHn3(IntPtr.Zero, string_1, string_0, "", Path.GetDirectoryName(string_0), 1);
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "ShellExecute", SetLastError = true)]
	private static extern IntPtr irdBb4eHn3(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, int int_0);

	static SqoZP75Qt63qQSW6CF1()
	{
		tIEB6VM8ih = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool Dxm1detEixuT4FZU4Ti()
	{
		return PkN1eRt3ivxnvkDpZNg == null;
	}

	internal static void ouby8mt08T9PoI9p8bV()
	{
	}
}
