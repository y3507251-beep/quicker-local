using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using log4net;
using Quicker.Domain;
using Quicker.Utilities;

namespace ouEd6sWQPCqARFECqJe;

internal class TkqATlWBPrB8iqNuFZQ
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct TjvubPHEvG7UttyxRwe : IAsyncStateMachine
		{
			public int dCT2aDuygVu;

			public AsyncVoidMethodBuilder sDq2adhCpfJ;

			public _003C_003Ec__DisplayClass1_0 yxd2aoYmHQE;

			private TaskAwaiter<bool> F5l2aTLvuRA;

			private static object av0Is5yLaia9YmOHThuu;

			private void MoveNext()
			{
				int num = dCT2aDuygVu;
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = yxd2aoYmHQE;
				try
				{
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = AppState.lWutartRfUY().CreateAndCopyActionForUrl(_003C_003Ec__DisplayClass1_.url, _003C_003Ec__DisplayClass1_.ngPvsTrWsMt, _003C_003Ec__DisplayClass1_.lLxvsM4Su88).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								dCT2aDuygVu = 0;
								if (av0Is5yLaia9YmOHThuu != null)
								{
									switch (0)
									{
									}
								}
								F5l2aTLvuRA = awaiter;
								sDq2adhCpfJ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = F5l2aTLvuRA;
							F5l2aTLvuRA = default(TaskAwaiter<bool>);
							num = -1;
							dCT2aDuygVu = -1;
						}
						awaiter.GetResult();
						AppHelper.ShowSuccess("已复制，请在面板空白位置粘贴动作。");
					}
					catch (Exception ex)
					{
						iLptuxdTPdx.Warn("创建网址动作出错：" + ex.Message, ex);
						AppHelper.ShowWarning("复制失败了。" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					dCT2aDuygVu = -2;
					sDq2adhCpfJ.SetException(exception);
					return;
				}
				dCT2aDuygVu = -2;
				sDq2adhCpfJ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				sDq2adhCpfJ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool uZ3bnRyLrqUNC6AWqfRC()
			{
				return av0Is5yLaia9YmOHThuu == null;
			}
		}

		public string url;

		public string ngPvsTrWsMt;

		public string lLxvsM4Su88;

		public Action l3DvsAjIOsm;

		public Action d8SvsOtpJiL;

		public Action jZpvsFgfQaM;

		public Action oMKvsUtRGrH;

		internal static _003C_003Ec__DisplayClass1_0 R3WSPjcg3xIdyqQSs2aj;

		internal void BK3vsBBSLiX(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(l3DvsAjIOsm ?? (l3DvsAjIOsm = UyvvsQSYgpN), "已复制", "复制失败，请重试。");
		}

		internal void UyvvsQSYgpN()
		{
			Clipboard.SetText(url);
		}

		internal void BXivsjD6IZt(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(d8SvsOtpJiL ?? (d8SvsOtpJiL = aj6vsneitci), "已复制。", "复制失败，请重试。");
		}

		internal void aj6vsneitci()
		{
			ClipboardHelper.SetHtml("<a href='" + url + "'>" + ngPvsTrWsMt + "</a>", url);
		}

		internal void LPpvs4AvkPl(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(jZpvsFgfQaM ?? (jZpvsFgfQaM = S8Mvs5juuBP), "已复制", "复制失败，请重试。");
		}

		internal void S8Mvs5juuBP()
		{
			Clipboard.SetText("[" + ngPvsTrWsMt + "](" + url + ")");
		}

		internal void mAVvsDZXIPf(object sender, RoutedEventArgs e)
		{
			AppHelper.Try(oMKvsUtRGrH ?? (oMKvsUtRGrH = FhpvsdyRFph), "已复制", "复制失败，请重试。");
		}

		internal void FhpvsdyRFph()
		{
			Clipboard.SetText(ngPvsTrWsMt + " " + url);
		}

		[AsyncStateMachine(typeof(TjvubPHEvG7UttyxRwe))]
		internal void IAxvsoYQ4kb(object sender, RoutedEventArgs e)
		{
			TjvubPHEvG7UttyxRwe stateMachine = default(TjvubPHEvG7UttyxRwe);
			stateMachine.sDq2adhCpfJ = AsyncVoidMethodBuilder.Create();
			stateMachine.yxd2aoYmHQE = this;
			stateMachine.dCT2aDuygVu = -1;
			stateMachine.sDq2adhCpfJ.Start(ref stateMachine);
		}

		internal static bool xvZ7M5cgEseEIrUOC5vx()
		{
			return R3WSPjcg3xIdyqQSs2aj == null;
		}
	}

	private static readonly ILog iLptuxdTPdx;

	internal static TkqATlWBPrB8iqNuFZQ u7kIEiQ2zmFAoqZgMG1J;

	public static void tGRtuKNCim6(string string_0, string string_1, string string_2, ItemCollection itemCollection_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.url = string_0;
		_003C_003Ec__DisplayClass1_.ngPvsTrWsMt = string_1;
		int num = 0;
		if (u7kIEiQ2zmFAoqZgMG1J != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass1_.lLxvsM4Su88 = string_2;
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass1_.url))
		{
			MenuItem menuItem = AppHelper.AddMenuItem(itemCollection_0, "复制", "复制链接", "fa:Light_Copy", null);
			AppHelper.AddMenuItem(menuItem.Items, "网址", "网址链接", "fa:Light_Copy", _003C_003Ec__DisplayClass1_.BK3vsBBSLiX);
			AppHelper.AddMenuItem(menuItem.Items, "HTML", "HTML格式的网址", "fa:Light_Copy", _003C_003Ec__DisplayClass1_.BXivsjD6IZt);
			AppHelper.AddMenuItem(menuItem.Items, "MarkDown", "网址链接", "fa:Light_Copy", _003C_003Ec__DisplayClass1_.LPpvs4AvkPl);
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass1_.ngPvsTrWsMt))
			{
				AppHelper.AddMenuItem(menuItem.Items, "标题 + 网址", "复制“标题 图标”格式内容", "fa:Light_Copy", _003C_003Ec__DisplayClass1_.mAVvsDZXIPf);
			}
			AppHelper.AddMenuItem(itemCollection_0, "复制为动作", "创建打开网址的动作", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass1_.IAxvsoYQ4kb);
		}
	}

	static TkqATlWBPrB8iqNuFZQ()
	{
		iLptuxdTPdx = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool TTmQl8QAVIDSCpbYAC2v()
	{
		return u7kIEiQ2zmFAoqZgMG1J == null;
	}

	internal static void igyPd3QAFvshAosG7eoq()
	{
	}
}
