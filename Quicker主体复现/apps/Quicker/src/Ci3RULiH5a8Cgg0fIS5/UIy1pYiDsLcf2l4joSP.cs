using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using aWEhsXjxWyCRXOavmGf;
using B8V6Yui1nJ3jwiLJ3Bm;
using c4LBdq5YohQFUgxFYw4;
using Ci16jh2IrdW1EGWcrNE;
using f5fV1EMjxQYCEGaKlWD;
using g9qSaliuNURV5vBGaNB;
using GEs2Jejr6IXgOTY0tM8;
using GJtCMxfoaUvMZIUmiAn;
using K9HvgYjZL3faEPQWoqU;
using kZafZx2CyPXdK8fqwA7;
using log4net;
using lUCjKTMbZVPP5v56los;
using Newtonsoft.Json.Linq;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.ContextMenus;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Domain.PowerKeys;
using Quicker.Domain.PowerMouse;
using Quicker.Domain.Profiles;
using Quicker.Domain.QuickActions;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities._3rd.Chrome;
using Quicker.Utilities._3rd.Gestures;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Hooks;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.CircleMenu;
using Quicker.View.Hotkeys;
using Quicker.View.Main;
using RjUv0gj94MtT9uEZCA0;
using sBtxL6X8ZmkfRQWgUC5;
using SWBMfZYGyc6L9yHIvKQ;
using TWhxvC2aCPi6qnhlPvy;
using ue2NmJfMHp7c5FtylT2;
using ViNASxihuuLY1Gg9m6p;
using WindowsInput;
using WindowsInput.Native;
using wO0UogXeWxgnePQOF3R;
using yiPKZ1fiKeoPH7DSJd3;
using YJ7Fh9jVM9v3yLTs0Cv;

namespace Ci3RULiH5a8Cgg0fIS5;

internal class UIy1pYiDsLcf2l4joSP
{
	internal enum EbJbkSH6HfKu6ZTZtS6 : uint
	{

	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct QKLoNXh25nLNVW7svDc : IAsyncStateMachine
		{
			public int x4m29cQLGKE;

			public AsyncTaskMethodBuilder c8T29VNYmkC;

			private TaskAwaiter Jtp29ZOQPkl;

			private static object QpB2WByifsxYYbfqIGkM;

			private void MoveNext()
			{
				int num = x4m29cQLGKE;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = Jtp29ZOQPkl;
						Jtp29ZOQPkl = default(TaskAwaiter);
						num = -1;
						x4m29cQLGKE = -1;
					}
					else
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							x4m29cQLGKE = 0;
							Jtp29ZOQPkl = awaiter;
							c8T29VNYmkC.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					awaiter.GetResult();
					AppState.r4itaWBnyVQ()?.TryRefresh();
				}
				catch (Exception exception)
				{
					x4m29cQLGKE = -2;
					c8T29VNYmkC.SetException(exception);
					return;
				}
				x4m29cQLGKE = -2;
				c8T29VNYmkC.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				c8T29VNYmkC.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool RsxYXAyibo5w7qCKEdYr()
			{
				return QpB2WByifsxYYbfqIGkM == null;
			}
		}

		public static readonly _003C_003Ec Arm20RCQ7us;

		public static Action Api20q3g4km;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, bool> hje20cTeDyx;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, bool> sX520VLOQBe;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, int> cbH20ZBQZbc;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, int> VDA209ufX1g;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, bool> DMQ20hk1Bto;

		public static Func<Quicker.Domain.PowerMouse.MouseAction, bool> Apd20eqcpum;

		public static Func<Task> y6G20YH9E4D;

		public static Func<GestureAction, string> eFk20IRqg3l;

		public static Func<GestureAction, GestureAction> Vlx20WHxD4Q;

		public static Func<ExeSettings, bool> nNj20ks9XuJ;

		internal static _003C_003Ec PvZGoVydkhyHuPbul3Gj;

		static _003C_003Ec()
		{
			Arm20RCQ7us = new _003C_003Ec();
		}

		internal void vb320ufJUZa()
		{
			ContentContextMenuService.ShowClipboardContextMenu();
		}

		internal bool NLF20NyC6Pl(Quicker.Domain.PowerMouse.MouseAction x)
		{
			int num = 1;
			while (x.MouseActionType == MouseActionType.Drag)
			{
				int num2 = 0;
				if (!j11JEJyda3pLvc4HduE9())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				MouseButtons? mouseButton = x.MouseButton;
				if (!((mouseButton.GetValueOrDefault() == MouseButtons.None) & mouseButton.HasValue) && x.MouseButton.HasValue)
				{
					break;
				}
				return x.ControlKey > 0;
			}
			return false;
		}

		internal bool LGI20J9qOfF(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return x?.IsEnabled ?? false;
		}

		internal int ib3200XJoCS(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return x.Priority;
		}

		internal int BqG20CUuZ2e(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return x.Location.YgGtIk4fjI7();
		}

		internal bool bDE20Pya0FQ(Quicker.Domain.PowerMouse.MouseAction x)
		{
			if (x.IsEnabled)
			{
				return x.MouseActionType == MouseActionType.MoveToCorner;
			}
			return false;
		}

		internal bool xlR20EhZXSs(Quicker.Domain.PowerMouse.MouseAction x)
		{
			if (x.IsEnabled)
			{
				return x.MouseActionType == MouseActionType.DoubleClick;
			}
			return false;
		}

		[AsyncStateMachine(typeof(QKLoNXh25nLNVW7svDc))]
		internal Task x5U20yavIIa()
		{
			QKLoNXh25nLNVW7svDc stateMachine = default(QKLoNXh25nLNVW7svDc);
			stateMachine.c8T29VNYmkC = AsyncTaskMethodBuilder.Create();
			stateMachine.x4m29cQLGKE = -1;
			stateMachine.c8T29VNYmkC.Start(ref stateMachine);
			return stateMachine.c8T29VNYmkC.Task;
		}

		internal string GpZ20802G8o(GestureAction ga)
		{
			return ga.GestureId;
		}

		internal GestureAction sOm20aXC8yA(GestureAction ga)
		{
			return ga;
		}

		internal bool ceP207BqkPk(ExeSettings x)
		{
			return x.Exe.StartsWith("@_");
		}

		internal static bool j11JEJyda3pLvc4HduE9()
		{
			return PvZGoVydkhyHuPbul3Gj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public AppMouseEventArgs sCV201v8jB7;

		public List<Quicker.Domain.PowerMouse.MouseAction> FYn20bOfWiK;

		public UIy1pYiDsLcf2l4joSP rgi206IIK6Y;

		private static _003C_003Ec__DisplayClass0_0 twrl2cydN1uLcsCAAtnM;

		internal bool XtA20GH7PXf(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return x.MouseButton == sCV201v8jB7.Button;
		}

		internal bool AMn20sq8qZE(Quicker.Domain.PowerMouse.MouseAction x)
		{
			return x.MouseButton == sCV201v8jB7.Button;
		}

		internal void TCh20HqFLHI()
		{
			_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_1
			{
				dyE20xP41TI = this
			};
			Thread.Sleep(50);
			_003C_003Ec__DisplayClass0_.Mmd20mSVBwr = AppHelper.GetPointTargetInfo(null);
			_003C_003Ec__DisplayClass0_.hgl20KAGTcY = Screen.FromPoint(_003C_003Ec__DisplayClass0_.Mmd20mSVBwr.Point);
			List<Quicker.Domain.PowerMouse.MouseAction> list = FYn20bOfWiK.Where(_003C_003Ec__DisplayClass0_.FPj20X2bZyb).ToList();
			if (list.Count == 0)
			{
				return;
			}
			if (sCV201v8jB7.Button == MouseButtons.Right)
			{
				rgi206IIK6Y.g5IvvQPIyU4.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
			}
			List<Quicker.Domain.PowerMouse.MouseAction>.Enumerator enumerator = list.GetEnumerator();
			int num = 0;
			if (!R9Vk2syd9ymhD4LpPw1b())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				while (enumerator.MoveNext())
				{
					Quicker.Domain.PowerMouse.MouseAction current = enumerator.Current;
					try
					{
						rgi206IIK6Y.FPlvgiqIvSK(current);
						break;
					}
					catch (Exception ex)
					{
						i71vvyAPQUV.Warn("鼠标双击触发执行出错：" + ex.Message, ex);
						AppHelper.ShowWarning("鼠标双击触发执行出错：" + ex.Message);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
		}

		internal static bool R9Vk2syd9ymhD4LpPw1b()
		{
			return twrl2cydN1uLcsCAAtnM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_1
	{
		public PointTargetInfo Mmd20mSVBwr;

		public Screen hgl20KAGTcY;

		public _003C_003Ec__DisplayClass0_0 dyE20xP41TI;

		private static _003C_003Ec__DisplayClass0_1 SoiYuQyduA3RTl5XdtIe;

		internal bool FPj20X2bZyb(Quicker.Domain.PowerMouse.MouseAction item)
		{
			if (dyE20xP41TI.rgi206IIK6Y.z0wvLCcCybg(item))
			{
				return dyE20xP41TI.rgi206IIK6Y.wmjvLySs6cd(item, Mmd20mSVBwr, hgl20KAGTcY);
			}
			return false;
		}

		internal static bool myC23XydodKMbIOoHMLM()
		{
			return SoiYuQyduA3RTl5XdtIe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass100_0
	{
		public UIy1pYiDsLcf2l4joSP tp320BDZBRk;

		public AppMouseEventArgs yIo20QwhvgO;

		internal static _003C_003Ec__DisplayClass100_0 GuIFgVydbBYL3VnV2syT;

		internal void h1020rMl5dd()
		{
			tp320BDZBRk.lxZvvSlNdBX.Hide();
		}

		internal void AeA20peN04i()
		{
			tp320BDZBRk.lxZvvSlNdBX.OnLeftButtonDown(yIo20QwhvgO);
			tp320BDZBRk.v7gvL7Q0RZq(yIo20QwhvgO);
		}

		internal static bool a57UGeydqyviSq3oPEyU()
		{
			return GuIFgVydbBYL3VnV2syT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass109_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct PFrvvlhjo5QXTwlLI9G : IAsyncStateMachine
		{
			public int moF299I4waF;

			public AsyncTaskMethodBuilder E4n29hoBO6h;

			public _003C_003Ec__DisplayClass109_0 p0n29eYZJaM;

			private TaskAwaiter GRu29Y546EH;

			private static object l0rbpNyii6oiPW71FaGp;

			private void MoveNext()
			{
				int num = moF299I4waF;
				_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = p0n29eYZJaM;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(10).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							moF299I4waF = 0;
							GRu29Y546EH = awaiter;
							E4n29hoBO6h.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (l0rbpNyii6oiPW71FaGp != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter = GRu29Y546EH;
						GRu29Y546EH = default(TaskAwaiter);
						num = -1;
						moF299I4waF = -1;
					}
					awaiter.GetResult();
					_003C_003Ec__DisplayClass109_.pvb205Oc3Tn.okDvLcLnF3i(_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button);
				}
				catch (Exception exception)
				{
					moF299I4waF = -2;
					E4n29hoBO6h.SetException(exception);
					return;
				}
				moF299I4waF = -2;
				E4n29hoBO6h.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				E4n29hoBO6h.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool Sp6lXVyilMrh17CgV4i4()
			{
				return l0rbpNyii6oiPW71FaGp == null;
			}
		}

		public UIy1pYiDsLcf2l4joSP pvb205Oc3Tn;

		public AppMouseEventArgs syP20DIOMKF;

		public IList<System.Windows.Point> XEk20dtWT3Z;

		internal static _003C_003Ec__DisplayClass109_0 E96544ydZUmweAXrwmU0;

		[AsyncStateMachine(typeof(PFrvvlhjo5QXTwlLI9G))]
		internal Task FLa20jOJtJO()
		{
			PFrvvlhjo5QXTwlLI9G stateMachine = default(PFrvvlhjo5QXTwlLI9G);
			stateMachine.E4n29hoBO6h = AsyncTaskMethodBuilder.Create();
			stateMachine.p0n29eYZJaM = this;
			stateMachine.moF299I4waF = -1;
			stateMachine.E4n29hoBO6h.Start(ref stateMachine);
			return stateMachine.E4n29hoBO6h.Task;
		}

		internal void Cie20nC4ylw()
		{
			pvb205Oc3Tn.v45vvBRpIiS.End(XEk20dtWT3Z);
		}

		internal void hJT204UCwrv()
		{
			pvb205Oc3Tn.lxZvvSlNdBX.OnLeftButtonUp(syP20DIOMKF, pvb205Oc3Tn.dB6vvgTocvt.MouseDownTargetInfo);
		}

		internal static bool Qr8SsTyd5xIKbtyfFfer()
		{
			return E96544ydZUmweAXrwmU0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass111_0
	{
		public UIy1pYiDsLcf2l4joSP vtU20TLdyJ8;

		public AppMouseEventArgs P0v20MrrApa;

		private static _003C_003Ec__DisplayClass111_0 DUA08Nyd8B4HG5tDQeqj;

		internal void nxM20oZp20d()
		{
			vtU20TLdyJ8.KERvLROn6Df(P0v20MrrApa.Button);
		}

		internal static bool cPeDb1ydRSScqinua9P3()
		{
			return DUA08Nyd8B4HG5tDQeqj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass115_0
	{
		public UIy1pYiDsLcf2l4joSP oo920FrY6ZR;

		public System.Drawing.Point Kl020UOraLq;

		internal static _003C_003Ec__DisplayClass115_0 eKKQlPydPidGQiMZOHT1;

		internal void paj20Au062J()
		{
			oo920FrY6ZR.eVuvLfVCnT6.OnMouseMoveFromHook(Kl020UOraLq);
		}

		internal void FZ220OjMUKT()
		{
			oo920FrY6ZR.v45vvBRpIiS?.oIJL7QM4CSt(Kl020UOraLq.X, Kl020UOraLq.Y);
		}

		static _003C_003Ec__DisplayClass115_0()
		{
		}

		internal static bool XDiHH1ydMPMbAyHIMCDs()
		{
			return eKKQlPydPidGQiMZOHT1 == null;
		}

		internal static void nS4lVkydxPSysq5rDZV6()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass119_0
	{
		public System.Drawing.Point UvZ20iM1Yyj;

		public UIy1pYiDsLcf2l4joSP H172033ohnQ;

		internal static _003C_003Ec__DisplayClass119_0 fMhq6mydImPNlnGtGbC9;

		internal bool bgH20lp4seP(Screen x)
		{
			return x.Bounds.Contains(UvZ20iM1Yyj);
		}

		internal static bool S0Suxlyd6MdSIcT1sb67()
		{
			return fMhq6mydImPNlnGtGbC9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass119_1
	{
		public Quicker.Domain.PowerMouse.MouseAction vGa20zedqlg;

		public _003C_003Ec__DisplayClass119_0 km32CwEMbXb;

		internal static _003C_003Ec__DisplayClass119_1 G0ri06ydSnsg82OPqs2g;

		internal void N2p20fUADA0(object o)
		{
			km32CwEMbXb.H172033ohnQ.N83vvmDhU7F.Clear();
			if (km32CwEMbXb.UvZ20iM1Yyj == NativeMethods.GetMousePosition())
			{
				km32CwEMbXb.H172033ohnQ.FPlvgiqIvSK(vGa20zedqlg);
			}
		}

		internal static bool yKIr03ydw8oLDZQITj98()
		{
			return G0ri06ydSnsg82OPqs2g == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public EbJbkSH6HfKu6ZTZtS6 zNl2CL16cVN;

		public Action Msu2CvehWxQ;

		internal static _003C_003Ec__DisplayClass11_0 eheo0cydsDiy8PAT3Dv6;

		internal void jP72CttQVsy()
		{
			AppHelper.RunAndIgnoreException(Msu2CvehWxQ ?? (Msu2CvehWxQ = JDO2CgfBYek));
		}

		internal void JDO2CgfBYek()
		{
			EThvtUsh2f7(zNl2CL16cVN, InputSimulator.Instance);
		}

		internal static bool zi5GLQydCDJFl0Chtucp()
		{
			return eheo0cydsDiy8PAT3Dv6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass122_0
	{
		public UIy1pYiDsLcf2l4joSP h0m2C2SbW6D;

		public int Oo32CuwtXO9;

		internal static _003C_003Ec__DisplayClass122_0 cEqrlmyd4geLCSpwQLHv;

		internal void mk02CS8Lpal()
		{
			h0m2C2SbW6D.g5IvvQPIyU4.Mouse.VerticalScrollInDelta(Oo32CuwtXO9 * -1);
		}

		internal static bool vch5ZFydhMJZ1MwZdTyb()
		{
			return cEqrlmyd4geLCSpwQLHv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass124_0
	{
		public MouseActionType pbt2CJa6I5D;

		public UIy1pYiDsLcf2l4joSP LuW2C09nB2t;

		internal static _003C_003Ec__DisplayClass124_0 BFs9Xiydz6G5Dj8PjYTM;

		internal bool RZr2CNWdgUr(Quicker.Domain.PowerMouse.MouseAction x)
		{
			if (x.MouseActionType == pbt2CJa6I5D)
			{
				return LuW2C09nB2t.z0wvLCcCybg(x);
			}
			return false;
		}

		internal static bool xxur3MyOV9mrPx8cD6ms()
		{
			return BFs9Xiydz6G5Dj8PjYTM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass124_1
	{
		public Quicker.Domain.PowerMouse.MouseAction b6n2CPN8nAQ;

		public _003C_003Ec__DisplayClass124_0 Qn22CEJT7a8;

		internal static _003C_003Ec__DisplayClass124_1 b4sfaFyOFBTvE6B35WxV;

		internal void NEb2CC0YUfL()
		{
			Qn22CEJT7a8.LuW2C09nB2t.FPlvgiqIvSK(b6n2CPN8nAQ);
		}

		internal static bool vGnbgKyOcwT7sCJk4V2Z()
		{
			return b4sfaFyOFBTvE6B35WxV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass126_0
	{
		public MouseActionType kTt2C8NE1dD;

		public UIy1pYiDsLcf2l4joSP oGC2CaL85r2;

		internal static _003C_003Ec__DisplayClass126_0 eb7yqXyOyaDl1QOLIL5W;

		internal bool Q3a2CyljDYo(Quicker.Domain.PowerMouse.MouseAction x)
		{
			if (x.MouseActionType == kTt2C8NE1dD)
			{
				return oGC2CaL85r2.z0wvLCcCybg(x);
			}
			return false;
		}

		internal static bool WSUE4ByOpX8oEmnuNqO8()
		{
			return eb7yqXyOyaDl1QOLIL5W == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass127_0
	{
		public UIy1pYiDsLcf2l4joSP Ccy2CRZqTaC;

		public int kVP2CqAL5uP;

		private static _003C_003Ec__DisplayClass127_0 YYVZVJyO2rjBpQuiZZEn;

		internal void CE52C7merSX()
		{
			Ccy2CRZqTaC.lxZvvSlNdBX.FloatWindow.Icyg54qpBt1(kVP2CqAL5uP);
		}

		internal static bool cvcA93yOASbiJkD9VSd8()
		{
			return YYVZVJyO2rjBpQuiZZEn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass131_0
	{
		public Quicker.Domain.PowerMouse.MouseAction nFc2CY3uP8u;

		public UIy1pYiDsLcf2l4joSP hwO2CIAByJE;

		public PointTargetInfo ejW2CWmXWhR;

		public bool NAD2CkGV4Lf;

		public int AnO2CGiXw1d;

		public Action EoE2CscqoJb;

		public Action U4C2CHwOsgt;

		public Action nh82C1fFsoR;

		public Action LMW2CbcThg7;

		public Action lXH2C6e4Awc;

		internal static _003C_003Ec__DisplayClass131_0 qN2M3syOe3XT32QFgO9i;

		internal void IEu2Cc3HQ1Y()
		{
			if (nFc2CY3uP8u.ControlKey.HasValue)
			{
				int? controlKey = nFc2CY3uP8u.ControlKey;
				if (!Qn0D21yOj3OeylVYo560())
				{
					switch (0)
					{
					}
				}
				if (controlKey.Value > 6)
				{
					hwO2CIAByJE.IFVvvu5V5nH.OnMouseUsed();
				}
			}
			switch (nFc2CY3uP8u.Operation)
			{
			case MouseOperationType.ShowPanel:
				AppHelper.RunOnUiThread(false, EoE2CscqoJb ?? (EoE2CscqoJb = sS62CV4PupH));
				break;
			case MouseOperationType.ShowCircleMenu:
				AppHelper.RunOnUiThread(false, U4C2CHwOsgt ?? (U4C2CHwOsgt = b1j2CZgp99P));
				break;
			case MouseOperationType.DrawGestures:
				AppHelper.RunOnUiThread(false, LMW2CbcThg7 ?? (LMW2CbcThg7 = o2C2ChoLr1i));
				break;
			case MouseOperationType.QuickAction:
				if (NAD2CkGV4Lf && hwO2CIAByJE.btRvvsjTuR6.xiKvtrfpJVF())
				{
					i71vvyAPQUV.Info("丢弃了一个鼠标操作，因为队列里有未完成的消息。");
				}
				else
				{
					hwO2CIAByJE.btRvvsjTuR6.GfIvtpmojfh(nh82C1fFsoR ?? (nh82C1fFsoR = xkZ2C9EVAwX));
				}
				break;
			case MouseOperationType.ScreenCapture:
				AppHelper.RunOnUiThread(false, lXH2C6e4Awc ?? (lXH2C6e4Awc = liX2Ce4Pp4u));
				break;
			}
		}

		internal void sS62CV4PupH()
		{
			hwO2CIAByJE.RXYvLeUkaA9(ejW2CWmXWhR, true, PopupSource.Mouse, true);
		}

		internal void b1j2CZgp99P()
		{
			hwO2CIAByJE.d9QvtdiYSo6(ejW2CWmXWhR, false, nFc2CY3uP8u.Data);
		}

		internal void xkZ2C9EVAwX()
		{
			QuickActionRunner.RunQuickActionAsync(hwO2CIAByJE, nFc2CY3uP8u, hwO2CIAByJE.jYVvvvEEUEj, hwO2CIAByJE.UorvvNUXimI, true, ActionTrigger.AdvancedMouseAction, "", null, null, false, AnO2CGiXw1d, false);
		}

		internal void o2C2ChoLr1i()
		{
			hwO2CIAByJE.N3AvgzglrJW(ejW2CWmXWhR, nFc2CY3uP8u.Data);
		}

		internal void liX2Ce4Pp4u()
		{
			hwO2CIAByJE.ln5vgfhpvA7(ejW2CWmXWhR);
		}

		internal static void YkJpS7yO35wwjWSxtffJ()
		{
		}

		internal static bool Qn0D21yOj3OeylVYo560()
		{
			return qN2M3syOe3XT32QFgO9i == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass136_0
	{
		public UIy1pYiDsLcf2l4joSP kBw2CKpwkfR;

		public IDictionary<string, GestureAction> jUC2CxWXQrV;

		internal static _003C_003Ec__DisplayClass136_0 dGF7XfyO0SZdOT6awKCP;

		internal void OUy2CX2c085(object sender, EventArgs e)
		{
			kBw2CKpwkfR.v45vvBRpIiS = null;
		}

		internal bool lLl2CmUmHlP(Gesture x)
		{
			return jUC2CxWXQrV.Keys.Contains(x.Id);
		}

		internal static bool uRjjPayO13MxiYiWuPEk()
		{
			return dGF7XfyO0SZdOT6awKCP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass155_0
	{
		public MouseButtons j8f2CprqRL3;

		private static _003C_003Ec__DisplayClass155_0 EnX9NIyOBKqhqiSbCMCG;

		internal void Jyq2CrMKyw6()
		{
			switch (j8f2CprqRL3)
			{
			case MouseButtons.Right:
				if (string.Equals(AppState.CurrentProcessName, "qq", StringComparison.OrdinalIgnoreCase))
				{
					InputSimulator.Instance.Mouse.RightButtonDown();
					Thread.Sleep(1);
					InputSimulator.Instance.Mouse.RightButtonUp();
				}
				else
				{
					InputSimulator.Instance.Mouse.RightButtonClick();
				}
				break;
			case MouseButtons.Left:
				InputSimulator.Instance.Mouse.LeftButtonClick();
				break;
			case MouseButtons.XButton2:
			{
				InputSimulator.Instance.Mouse.XButtonClick(2);
				int num = 0;
				if (!h0yCdeyOvccbXPuoTXGF())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				break;
			}
			case MouseButtons.XButton1:
				InputSimulator.Instance.Mouse.XButtonClick(1);
				break;
			case MouseButtons.Middle:
				InputSimulator.Instance.Mouse.MiddleButtonClick();
				break;
			}
		}

		internal static bool h0yCdeyOvccbXPuoTXGF()
		{
			return EnX9NIyOBKqhqiSbCMCG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass158_0
	{
		public MouseButtons VH22CQgI1Tc;

		public UIy1pYiDsLcf2l4joSP q0e2Cj32TTR;

		internal static _003C_003Ec__DisplayClass158_0 A7ZIKyyOr4jexktKuhnE;

		internal void CjK2CB1nsdN()
		{
			MouseButtons mouseButtons = VH22CQgI1Tc;
			if (mouseButtons <= MouseButtons.Right)
			{
				switch (mouseButtons)
				{
				case MouseButtons.Right:
					q0e2Cj32TTR.g5IvvQPIyU4.Mouse.RightButtonDown();
					break;
				case MouseButtons.Left:
					q0e2Cj32TTR.g5IvvQPIyU4.Mouse.LeftButtonDown();
					break;
				}
				return;
			}
			switch (mouseButtons)
			{
			case MouseButtons.XButton2:
				q0e2Cj32TTR.g5IvvQPIyU4.Mouse.XButtonDown(2);
				return;
			case MouseButtons.XButton1:
				q0e2Cj32TTR.g5IvvQPIyU4.Mouse.XButtonDown(1);
				return;
			case MouseButtons.Middle:
				q0e2Cj32TTR.g5IvvQPIyU4.Mouse.MiddleButtonDown();
				return;
			}
			int num = 0;
			if (!E8XnMkyONS5OkPt571Ly())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}

		internal static bool E8XnMkyONS5OkPt571Ly()
		{
			return A7ZIKyyOr4jexktKuhnE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass159_0
	{
		public MouseButtons jkk2C4k7mPr;

		public UIy1pYiDsLcf2l4joSP uQH2C5V91ig;

		internal static _003C_003Ec__DisplayClass159_0 VrUGSfyOLoK82GB3af3O;

		internal void o0a2CnXvkG8()
		{
			MouseButtons mouseButtons = jkk2C4k7mPr;
			if (mouseButtons <= MouseButtons.Right)
			{
				int num = 0;
				if (!QXruyWyOuLmCi3bvbOZq())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				switch (mouseButtons)
				{
				case MouseButtons.Right:
					uQH2C5V91ig.g5IvvQPIyU4.Mouse.RightButtonUp();
					break;
				case MouseButtons.Left:
					uQH2C5V91ig.g5IvvQPIyU4.Mouse.LeftButtonUp();
					break;
				}
			}
			else
			{
				switch (mouseButtons)
				{
				case MouseButtons.XButton2:
					uQH2C5V91ig.g5IvvQPIyU4.Mouse.XButtonUp(2);
					break;
				case MouseButtons.XButton1:
					uQH2C5V91ig.g5IvvQPIyU4.Mouse.XButtonUp(1);
					break;
				case MouseButtons.Middle:
					uQH2C5V91ig.g5IvvQPIyU4.Mouse.MiddleButtonUp();
					break;
				}
			}
		}

		internal static bool QXruyWyOuLmCi3bvbOZq()
		{
			return VrUGSfyOLoK82GB3af3O == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass165_0
	{
		public UIy1pYiDsLcf2l4joSP K0w2CdgTvxK;

		public PointTargetInfo pku2CoJX4VA;

		public bool Dkw2CTDRT62;

		public PopupSource GHM2CMcWxMV;

		public bool Lat2CAP3laX;

		internal static _003C_003Ec__DisplayClass165_0 hl1YdQyObMsks8IJwv7E;

		internal void YbC2CDd9e4v()
		{
			K0w2CdgTvxK.RXYvLeUkaA9(pku2CoJX4VA, Dkw2CTDRT62, GHM2CMcWxMV, Lat2CAP3laX);
		}

		internal static bool Bn4yGuyOqYtI8l1k1Dn2()
		{
			return hl1YdQyObMsks8IJwv7E == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass166_0
	{
		public string Lkd2CUdVUu6;

		public UIy1pYiDsLcf2l4joSP hE42ClMTSxw;

		private static _003C_003Ec__DisplayClass166_0 DlC8WWyOlmoeFK8sjcCo;

		internal bool j5N2COFW0hn(ExeSettings x)
		{
			if (x.Exe.StartsWith("@_"))
			{
				return AppState.vjAt7Seco0Y()?.m8ItGmyxjPV(Lkd2CUdVUu6) ?? false;
			}
			return false;
		}

		internal void EuZ2CFdwSO0()
		{
			try
			{
				BrowserRespMessage<JToken> browserRespMessage = ChromeControl.SendMessageToBrowser(new ChromeCommandMessage<object>
				{
					Cmd = "GetTabInfo",
					TabId = null
				}, Lkd2CUdVUu6, true, 300);
				JToken? jToken = browserRespMessage.Data["url"];
				object obj;
				if (jToken == null)
				{
					obj = null;
				}
				else
				{
					obj = jToken.ToObject<string>();
					if (obj != null)
					{
						goto IL_0097;
					}
				}
				int num = 0;
				if (DlC8WWyOlmoeFK8sjcCo != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				obj = browserRespMessage.Data["pendingUrl"]?.ToObject<string>();
				goto IL_0097;
				IL_0097:
				string text = (string)obj;
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				foreach (ExeSettings item in hE42ClMTSxw.SL0vvwD6HYI.Q0ltmmbUTMB().Where(_003C_003Ec.nNj20ks9XuJ ?? (_003C_003Ec.nNj20ks9XuJ = _003C_003Ec.Arm20RCQ7us.ceP207BqkPk)))
				{
					if (WsnAlhjCfHjoVZXu241.XRmtGdDumUX(text, item.UrlPattern))
					{
						AppState.AppServer.OnBrowserUrlChanged(Lkd2CUdVUu6, text);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				i71vvyAPQUV.Warn("获取浏览器网址出错：" + ex.Message, ex);
			}
		}

		internal static bool LGhyGqyOZACfaJpWo8C6()
		{
			return DlC8WWyOlmoeFK8sjcCo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public CircleMenuWindow iqW2C3ZTQ2I;

		public GestureWindow P7N2CfbaB4j;

		private static _003C_003Ec__DisplayClass3_0 KS5WCuyOYobVXMku19si;

		internal void Km02CiAeXVn()
		{
			try
			{
				iqW2C3ZTQ2I?.Close();
			}
			catch (Exception)
			{
			}
			try
			{
				P7N2CfbaB4j?.Close();
			}
			catch (Exception)
			{
			}
		}

		internal static bool bFCeO7yO8StXgfKQS4E7()
		{
			return KS5WCuyOYobVXMku19si == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public UIy1pYiDsLcf2l4joSP nNh2PLjSGTO;

		public HookKeyEventArgs qhD2PvBAgVP;

		internal static _003C_003Ec__DisplayClass59_0 gxaLPByOggXYImdocpCC;

		internal void r502Cz3f9e6()
		{
			nNh2PLjSGTO.lxZvvSlNdBX.OnKeyDown(qhD2PvBAgVP);
		}

		internal void Vtj2Pw9uCtZ()
		{
			if (nNh2PLjSGTO.BWivLz0pfuj.OwnedWindows.Count == 0 && nNh2PLjSGTO.BWivLz0pfuj.CanCloseWindow())
			{
				nNh2PLjSGTO.BWivLz0pfuj.RequestHide();
				qhD2PvBAgVP.Handled = true;
			}
		}

		internal void D2P2PtG5VbX()
		{
			nNh2PLjSGTO.BWivLz0pfuj?.DashboardWindow?.Close();
		}

		internal void lfk2PgNCX08()
		{
			if (nNh2PLjSGTO.BWivLz0pfuj.CanCloseWindow())
			{
				_003C_003Ec__DisplayClass59_1 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_1
				{
					COc2PufdsfD = this,
					Ku32P2NZACC = (int)qhD2PvBAgVP.KeyCode
				};
				if (nNh2PLjSGTO.oZAvgaPTyJa(qhD2PvBAgVP.KeyCode))
				{
					qhD2PvBAgVP.Handled = true;
				}
				else if (nNh2PLjSGTO.SL0vvwD6HYI.CpItmVISR7P().KeyTriggers != null && nNh2PLjSGTO.SL0vvwD6HYI.CpItmVISR7P().KeyTriggers.Count > 0 && nNh2PLjSGTO.SL0vvwD6HYI.CpItmVISR7P().KeyTriggers.ContainsKey(_003C_003Ec__DisplayClass59_.Ku32P2NZACC) && JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.None)
				{
					qhD2PvBAgVP.Handled = true;
					nNh2PLjSGTO.BWivLz0pfuj.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass59_.biE2PSsoGtO);
				}
			}
		}

		internal static bool Wb9RCqyOP2bl9N78yCJu()
		{
			return gxaLPByOggXYImdocpCC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_1
	{
		public int Ku32P2NZACC;

		public _003C_003Ec__DisplayClass59_0 COc2PufdsfD;

		private static _003C_003Ec__DisplayClass59_1 SdwRmSyOIaCvX2E1l535;

		internal void biE2PSsoGtO()
		{
			COc2PufdsfD.nNh2PLjSGTO.BWivLz0pfuj.ExecuteButton(COc2PufdsfD.nNh2PLjSGTO.SL0vvwD6HYI.CpItmVISR7P().KeyTriggers[Ku32P2NZACC], ActionTrigger.TriggerKey, false);
		}

		internal static bool Gkr3rcyO6vUjD60ZtHtx()
		{
			return SdwRmSyOIaCvX2E1l535 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public UIy1pYiDsLcf2l4joSP bds2PJHJqXi;

		public System.Drawing.Point Dp42P0qjq3s;

		public bool vE52PCknZ6P;

		private static _003C_003Ec__DisplayClass5_0 SDNKXfyOSbaNZk0ehHw3;

		internal void a6V2PN6fkoW()
		{
			bds2PJHJqXi.eVuvLfVCnT6.i5FL9Sk9QEf(Dp42P0qjq3s, vE52PCknZ6P);
		}

		internal static bool DAD6YByOwutFndGuZ4ot()
		{
			return SDNKXfyOSbaNZk0ehHw3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_0
	{
		public UIy1pYiDsLcf2l4joSP J1r2P8Pxj70;

		public System.Drawing.Point LeH2PaMGZdq;

		public System.Drawing.Point RAJ2P7prLc9;

		public Action fBI2PRPJcj6;

		internal static _003C_003Ec__DisplayClass78_0 J7020AyOm1fDN9OiV3cp;

		internal void EcA2PPD2H4T()
		{
			if (J1r2P8Pxj70.BWivLz0pfuj.IsVisible && J1r2P8Pxj70.BWivLz0pfuj.IsPointOnWindow() && AppHelper.IsFarThan(LeH2PaMGZdq, RAJ2P7prLc9, 10))
			{
				J1r2P8Pxj70.KERvLROn6Df(MouseButtons.Left);
			}
		}

		internal void cc72PEf9AO4()
		{
			DirectCaptureWindow eXavvpoOBID = J1r2P8Pxj70.EXavvpoOBID;
			if (eXavvpoOBID != null && eXavvpoOBID.IsVisible)
			{
				DirectCaptureWindow eXavvpoOBID2 = J1r2P8Pxj70.EXavvpoOBID;
				if (eXavvpoOBID2 != null && !eXavvpoOBID2.IsCanceled)
				{
					System.Drawing.Point startPoint = J1r2P8Pxj70.EXavvpoOBID.StartPoint;
					System.Drawing.Point endPoint = J1r2P8Pxj70.EXavvpoOBID.EndPoint;
					AppHelper.RunOnUiThread(false, fBI2PRPJcj6 ?? (fBI2PRPJcj6 = i9Z2Pyb2pLW));
					Thread.Sleep(200);
					QuickScreenShot.CaptureAreaAndShow(startPoint, endPoint);
				}
			}
		}

		internal void i9Z2Pyb2pLW()
		{
			J1r2P8Pxj70.EXavvpoOBID.Close();
		}

		internal static bool h77jQAyOsxr6nyGoYGR2()
		{
			return J7020AyOm1fDN9OiV3cp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass99_0
	{
		public UIy1pYiDsLcf2l4joSP Tmq2Pcbe0Pu;

		public MouseButtons? WkZ2PVWJoKV;

		internal static _003C_003Ec__DisplayClass99_0 QcN1MiyO7Yqqmx6tafoo;

		internal void OQ72PqCsP23()
		{
			Tmq2Pcbe0Pu.thjvLq0npS4(WkZ2PVWJoKV.Value);
			Tmq2Pcbe0Pu.fyQvvWWWM3P.b85t9qRpcbb(null);
		}

		internal static bool pGCOnCyO41pREDDtQ30a()
		{
			return QcN1MiyO7Yqqmx6tafoo == null;
		}
	}

	public CircleMenuWindow eVuvLfVCnT6;

	private readonly PopupWindow BWivLz0pfuj;

	private readonly DataService SL0vvwD6HYI;

	private readonly ActiveWindowHook NKXvvttDgaQ;

	private readonly PopupState dB6vvgTocvt;

	private readonly ProfileSwitcher iFevvLKAVeT;

	private readonly ITinyMessengerHub jYVvvvEEUEj;

	private readonly TextFloatPanelMgr lxZvvSlNdBX;

	private readonly we8kb6Xb9dOkNdooDpA Jn8vv2lDcFZ;

	private readonly PowerKeysService IFVvvu5V5nH;

	private readonly AppServer UorvvNUXimI;

	private DispatcherTimer XFfvvJeKXVt;

	private lPxZYOM8ws3NP42wph0 Hkevv0QHEW3;

	private AhomQMieinjGJjNmmsS zAwvvCZiXYj;

	private FjS4Bdf7kOdHMojRZMv M1hvvPuUZew;

	private bool MsmvvEkLEEH;

	private static readonly ILog i71vvyAPQUV;

	private KeyboardHook cDWvv8xNu7H;

	private int UGWvvasNwK0;

	[CompilerGenerated]
	private bool HFMvv7ITvpS;

	[CompilerGenerated]
	private bool U8lvvRUqHG5;

	private DateTime? iiBvvqEgZ6T;

	private long Ow9vvcCBW94 = AppHelper.fLiLTj0x4QY() + 500000L;

	private bool fyivvVoUXZX;

	private System.Threading.Timer Va2vvZdE1RU;

	[CompilerGenerated]
	private KeyboardHook.QuickerKeyEventHandler Nekvv9Qh3SE;

	private bool erpvvh5h56q;

	private IList<Quicker.Domain.PowerMouse.MouseAction> h2svveb70E4;

	private System.Drawing.Point? U6KvvY7SfVa;

	private bool eSXvvIJsst7;

	private readonly ers66j2xyiWRSpKLFdb fyQvvWWWM3P = new ers66j2xyiWRSpKLFdb();

	private IList<Quicker.Domain.PowerMouse.MouseAction> BYhvvkjpWF1 = new List<Quicker.Domain.PowerMouse.MouseAction>();

	private IList<Quicker.Domain.PowerMouse.MouseAction> itSvvGgTnQU;

	private AM0sjAidwUWNa978UHF btRvvsjTuR6;

	private Thread QGjvvHGvJi1;

	private Dispatcher TbUvv1kROcc;

	private IList<Quicker.Domain.PowerMouse.MouseAction> Y7ivvblS7lk = new List<Quicker.Domain.PowerMouse.MouseAction>();

	private System.Drawing.Point tF1vv6GrnWV = new System.Drawing.Point(-1000, -1000);

	private AutoResetEvent qDDvvX3eLl0 = new AutoResetEvent(false);

	private DebounceTimer N83vvmDhU7F = new DebounceTimer();

	private long SWYvvKxcL13;

	private EventReducer oj1vvxof2tU = new EventReducer();

	private EventReducer WwavvrZLd82 = new EventReducer();

	private DirectCaptureWindow EXavvpoOBID;

	private GestureWindow v45vvBRpIiS;

	private InputSimulator g5IvvQPIyU4 = new InputSimulator();

	private bool DGUvvjei8X1;

	private static UIy1pYiDsLcf2l4joSP COIxMyFCeTKEhc49RX1F;

	private void MBcvtDWXIAE(object sender, AppMouseEventArgs e)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.sCV201v8jB7 = e;
		_003C_003Ec__DisplayClass0_.rgi206IIK6Y = this;
		if (!dB6vvgTocvt.IsEnabled)
		{
			int num = 0;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (itSvvGgTnQU != null && itSvvGgTnQU.Count != 0 && itSvvGgTnQU.Any(_003C_003Ec__DisplayClass0_.XtA20GH7PXf) && (_003C_003Ec__DisplayClass0_.sCV201v8jB7.Button == MouseButtons.Left || !zYwvLopdTEn().RealState.Kcpt9nPM6AT(MouseButtons.Left)))
		{
			_003C_003Ec__DisplayClass0_.FYn20bOfWiK = itSvvGgTnQU.Where(_003C_003Ec__DisplayClass0_.AMn20sq8qZE).ToList();
			Task.Run((Action)_003C_003Ec__DisplayClass0_.TCh20HqFLHI);
		}
	}

	public bool d9QvtdiYSo6(PointTargetInfo pointTargetInfo_0, bool bool_7, string string_0 = null)
	{
		ExeSettings exeSettings = null;
		bool onlyCurrentExeActions = false;
		if (string_0 == "_curr")
		{
			string_0 = null;
			onlyCurrentExeActions = true;
		}
		if (!string_0.IsNullOrEmpty())
		{
			if ((exeSettings = AppState.DataService.yQWt6ownR4Z(string_0)) == null)
			{
				AppHelper.ShowWarning("未找到场景：" + string_0 + "，请检查设置。");
			}
		}
		else
		{
			(bool canActivate, ExeSettings exeSettings) tuple = RwAvtTOBjsv(pointTargetInfo_0);
			bool item = tuple.canActivate;
			ExeSettings item2 = tuple.exeSettings;
			int num = 1;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				int num2 = default(int);
				num = num2;
			}
			do
			{
				switch (num)
				{
				case 1:
					if (item)
					{
						if (item2 != null)
						{
							if (item2.DisableCircleMenu)
							{
								return false;
							}
							break;
						}
						goto IL_007b;
					}
					return false;
				}
				break;
				IL_007b:
				num = 0;
			}
			while (COIxMyFCeTKEhc49RX1F != null);
			exeSettings = item2;
		}
		fPDvLWi28bU(pointTargetInfo_0);
		if (eVuvLfVCnT6 == null)
		{
			eVuvLfVCnT6 = new CircleMenuWindow(jYVvvvEEUEj, dB6vvgTocvt, SL0vvwD6HYI, UorvvNUXimI)
			{
				PointTargetInfo = pointTargetInfo_0
			};
			eVuvLfVCnT6.Closed += xemvLHg5X6P;
		}
		eVuvLfVCnT6.TriggerShow(pointTargetInfo_0, exeSettings, bool_7, onlyCurrentExeActions);
		return true;
	}

	internal void R8Fvtoeu87h()
	{
		if (eVuvLfVCnT6 != null || v45vvBRpIiS != null)
		{
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.iqW2C3ZTQ2I = eVuvLfVCnT6;
			eVuvLfVCnT6 = null;
			_003C_003Ec__DisplayClass3_.P7N2CfbaB4j = v45vvBRpIiS;
			v45vvBRpIiS = null;
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass3_.Km02CiAeXVn);
		}
	}

	public (bool canActivate, ExeSettings exeSettings) RwAvtTOBjsv(PointTargetInfo pointTargetInfo_0)
	{
		if (pointTargetInfo_0.IsOnNonTriggerWindow)
		{
			return (canActivate: false, exeSettings: null);
		}
		if (!pointTargetInfo_0.CanTrigger(PopupSource.Mouse))
		{
			return (canActivate: false, exeSettings: null);
		}
		if (AppState.HS2taepcAbc().IsVisible && AppHelper.IsOnQuicker())
		{
			return (canActivate: false, exeSettings: null);
		}
		string exe = pointTargetInfo_0.Exe;
		ExeSettings item = SL0vvwD6HYI.yNft6Tt604K(exe);
		return (canActivate: true, exeSettings: item);
	}

	private void guOvtMiaXe1(System.Drawing.Point point_1, bool bool_7)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.bds2PJHJqXi = this;
		_003C_003Ec__DisplayClass5_.Dp42P0qjq3s = point_1;
		_003C_003Ec__DisplayClass5_.vE52PCknZ6P = bool_7;
		CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
		if (circleMenuWindow != null && circleMenuWindow.IsWorking)
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass5_.a6V2PN6fkoW);
		}
	}

	public void G1XvtA8WXBn()
	{
		eVuvLfVCnT6?.Close();
		eVuvLfVCnT6 = null;
	}

	public void bjCvtOvHnjy()
	{
		eVuvLfVCnT6.DoHide();
	}

	public void fXrvtFE0ogm()
	{
		if (eVuvLfVCnT6 != null)
		{
			if (AppState.DataService.CpItmVISR7P().CircleMenuTrigger > 0)
			{
				eVuvLfVCnT6.UpdateUi();
				return;
			}
			eVuvLfVCnT6.Close();
			eVuvLfVCnT6 = null;
		}
	}

	private static void EThvtUsh2f7(EbJbkSH6HfKu6ZTZtS6 ebJbkSH6HfKu6ZTZtS6_0, InputSimulator inputSimulator_1)
	{
		switch (ebJbkSH6HfKu6ZTZtS6_0)
		{
		case (EbJbkSH6HfKu6ZTZtS6)1u:
			if (SystemInformation.MouseButtonsSwapped)
			{
				inputSimulator_1.Mouse.RightButtonClick();
				if (IhLjTcFCjA6MRipDUS4j())
				{
					switch (0)
					{
					}
				}
			}
			else
			{
				inputSimulator_1.Mouse.LeftButtonClick();
			}
			break;
		case (EbJbkSH6HfKu6ZTZtS6)2u:
			if (SystemInformation.MouseButtonsSwapped)
			{
				inputSimulator_1.Mouse.LeftButtonClick();
			}
			else
			{
				inputSimulator_1.Mouse.RightButtonClick();
			}
			break;
		case (EbJbkSH6HfKu6ZTZtS6)3u:
			if (!SystemInformation.MouseButtonsSwapped)
			{
				inputSimulator_1.Mouse.RightButtonDown();
			}
			else
			{
				inputSimulator_1.Mouse.LeftButtonDown();
			}
			break;
		}
	}

	private void XodvtlwgJ1n(EbJbkSH6HfKu6ZTZtS6 ebJbkSH6HfKu6ZTZtS6_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.zNl2CL16cVN = ebJbkSH6HfKu6ZTZtS6_0;
		Task.Run((Action)_003C_003Ec__DisplayClass11_.jP72CttQVsy, CancellationToken.None);
	}

	public UIy1pYiDsLcf2l4joSP(PopupWindow popupWindow_1, DataService dataService_1, ActiveWindowHook activeWindowHook_1, PopupState popupState_1, ProfileSwitcher profileSwitcher_1, ITinyMessengerHub itinyMessengerHub_1, TextFloatPanelMgr textFloatPanelMgr_1, we8kb6Xb9dOkNdooDpA we8kb6Xb9dOkNdooDpA_1, PowerKeysService powerKeysService_1, AppServer appServer_1)
	{
		BWivLz0pfuj = popupWindow_1;
		SL0vvwD6HYI = dataService_1;
		NKXvvttDgaQ = activeWindowHook_1;
		dB6vvgTocvt = popupState_1;
		iFevvLKAVeT = profileSwitcher_1;
		jYVvvvEEUEj = itinyMessengerHub_1;
		lxZvvSlNdBX = textFloatPanelMgr_1;
		Jn8vv2lDcFZ = we8kb6Xb9dOkNdooDpA_1;
		IFVvvu5V5nH = powerKeysService_1;
		UorvvNUXimI = appServer_1;
		jYVvvvEEUEj.Subscribe<RequireReinstallHookMessage>(pJsvtffrTYH);
		jYVvvvEEUEj.Subscribe<UserSettingsChangedMessage>(kZRvtiD072d);
		jYVvvvEEUEj.Subscribe<WOkyiC2pewwqUAWVaJb>(WbgvLkONQDA);
		AppState.aeDtajUpah8(this);
		zAwvvCZiXYj = new AhomQMieinjGJjNmmsS(dB6vvgTocvt, this);
		SL0vvwD6HYI.FnrtmLxNViE().CollectionChanged += qSgvL1d6vTc;
	}

	private void kZRvtiD072d(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		try
		{
			XFfvvJeKXVt.Interval = TimeSpan.FromMilliseconds(SL0vvwD6HYI.CpItmVISR7P().RightBtnPopupDelayMs);
			BlackListMgr.UpdateFullscreenWhiteList();
			N3jvgW1OKsQ();
			Kv7vt3g1lT6();
			uhcbDejgDZ3vvobZ0Nn.znHtWMAT5Vy();
			AppHelper.RunOnUiThread(false, sm8vLbEQKPJ);
		}
		catch (Exception ex)
		{
			i71vvyAPQUV.Warn("更新设置出错。" + ex.Message, ex);
			AppHelper.ShowWarning("更新设置出错。" + ex.Message);
		}
	}

	private void Kv7vt3g1lT6()
	{
		zAwvvCZiXYj.Stop();
		if (SL0vvwD6HYI.CpItmVISR7P().EnableHookDetector)
		{
			zAwvvCZiXYj.jofvS9UK1gu();
		}
	}

	private void pJsvtffrTYH(RequireReinstallHookMessage requireReinstallHookMessage_0)
	{
		FRAvgShyCwg();
	}

	public void Tb6vtznNGgv()
	{
		if (XFfvvJeKXVt != null)
		{
			throw new InvalidOperationException("PopupMgr已经初始化过了。");
		}
		TbUvv1kROcc = DispatcherBuilder.Build("HookDispatcher");
		XFfvvJeKXVt = new DispatcherTimer(DispatcherPriority.Normal, TbUvv1kROcc);
		if (COIxMyFCeTKEhc49RX1F != null)
		{
			switch (0)
			{
			}
		}
		XFfvvJeKXVt.Tick += asPvgHp9WBu;
		XFfvvJeKXVt.Interval = TimeSpan.FromMilliseconds(SL0vvwD6HYI.CpItmVISR7P().RightBtnPopupDelayMs);
		MtSvge5IU64();
		ckLvguFMesR();
		btRvvsjTuR6 = new AM0sjAidwUWNa978UHF();
		BlackListMgr.UpdateFullscreenWhiteList();
		N3jvgW1OKsQ();
		lnivgw2fIxx();
		uhcbDejgDZ3vvobZ0Nn.znHtWMAT5Vy();
	}

	private void lnivgw2fIxx()
	{
		if ((SL0vvwD6HYI.CpItmVISR7P().PenButton1Action > 0 || SL0vvwD6HYI.CpItmVISR7P().PenButton2Action > 0) && M1hvvPuUZew == null)
		{
			int num = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			M1hvvPuUZew = new FjS4Bdf7kOdHMojRZMv();
			M1hvvPuUZew.LM7LljRBOav();
			M1hvvPuUZew.eFaLldWepK7(fKKvgvLRZ1y);
			M1hvvPuUZew.hiLLlMleBB0(WWRvgLKSepG);
			M1hvvPuUZew.g8eLlFWA1Fj(x27vgtSVB3a);
			M1hvvPuUZew.j2aLli3t4Ka(TGkvggef9Vt);
		}
	}

	private void x27vgtSVB3a(object object_0, wKMdIsfXIJGqmt50epJ wKMdIsfXIJGqmt50epJ_0)
	{
		if (!MsmvvEkLEEH)
		{
			return;
		}
		try
		{
			guOvtMiaXe1(System.Windows.Forms.Cursor.Position, true);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("模拟左键出错：" + ex.Message);
		}
	}

	private void TGkvggef9Vt(object sender, EventArgs e)
	{
		if (MsmvvEkLEEH)
		{
			CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
			if (circleMenuWindow != null && circleMenuWindow.IsWorking)
			{
				eVuvLfVCnT6.OnMouseMoveFromHook(System.Windows.Forms.Cursor.Position);
			}
		}
	}

	private void WWRvgLKSepG(object object_0, wKMdIsfXIJGqmt50epJ wKMdIsfXIJGqmt50epJ_0)
	{
		if ((AppState.HHxtaMaoqJr().PenButton1Action > 0 && wKMdIsfXIJGqmt50epJ_0.oaWLlbZgwpH() == (ULeTYefYKfmAdZea18R)0) || (AppState.HHxtaMaoqJr().PenButton2Action > 0 && wKMdIsfXIJGqmt50epJ_0.oaWLlbZgwpH() == (ULeTYefYKfmAdZea18R)1))
		{
			d9QvtdiYSo6(AppHelper.GetPointTargetInfo(null), false);
			MsmvvEkLEEH = true;
		}
	}

	private void fKKvgvLRZ1y(object object_0, wKMdIsfXIJGqmt50epJ wKMdIsfXIJGqmt50epJ_0)
	{
	}

	public void FRAvgShyCwg()
	{
		i71vvyAPQUV.Info("重新加载挂钩");
		fyQvvWWWM3P.KPhtZmUAjus();
		TbUvv1kROcc.InvokeAsync(CTlvL6aOwbq);
		Kv7vt3g1lT6();
		lnivgw2fIxx();
		int num = 0;
		if (COIxMyFCeTKEhc49RX1F != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		M1hvvPuUZew?.Stop();
		M1hvvPuUZew?.LM7LljRBOav();
		RV5vLF5yh1l(false);
	}

	public void Stop()
	{
		Hkevv0QHEW3?.Stop();
		cDWvv8xNu7H?.Stop();
		M1hvvPuUZew?.Stop();
	}

	public void End()
	{
		Stop();
		TbUvv1kROcc.InvokeShutdown();
	}

	public void k01vg2nHa1p()
	{
		Kv7vt3g1lT6();
		IFVvvu5V5nH.Reset();
	}

	[SpecialName]
	[CompilerGenerated]
	private bool WlXvLjpb0vf()
	{
		return HFMvv7ITvpS;
	}

	[SpecialName]
	[CompilerGenerated]
	private void LaavLnQ0uya(bool bool_7)
	{
		HFMvv7ITvpS = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool zsIvL5h6PhP()
	{
		return U8lvvRUqHG5;
	}

	[SpecialName]
	[CompilerGenerated]
	private void V8yvLDRddBD(bool bool_7)
	{
		U8lvvRUqHG5 = bool_7;
	}

	private void ckLvguFMesR()
	{
		TbUvv1kROcc.InvokeAsync(HhTvLXjjZOF);
	}

	private void h05vgNe8mlY()
	{
		TbUvv1kROcc.Invoke(grdvLmHkiv7);
	}

	private void iCqvgJFF1tY(object sender, HookKeyEventArgs e)
	{
		ObkG8JjRVxQq4TEiAhL.uWqtkoPnKgl(e);
		int num;
		if (fyQvvWWWM3P.KIQtZjjGceP() && fyQvvWWWM3P.MouseAction != null && fyQvvWWWM3P.EvVt9JuygnX().HasValue && KeyboardHelper.fDPLMDBnLis(fyQvvWWWM3P.EvVt9JuygnX().Value, (VirtualKeyCode)e.KeyCode) && mfYvgZSL8SN((VirtualKeyCode)e.KeyCode, fyQvvWWWM3P.MouseAction))
		{
			num = 1;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				goto IL_009d;
			}
			goto IL_00ac;
		}
		goto IL_00b7;
		IL_00b7:
		if (!dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		if (e.IsFromQuicker)
		{
			num = 0;
			if (IhLjTcFCjA6MRipDUS4j())
			{
				return;
			}
			goto IL_009d;
		}
		if (AppState.HHxtaMaoqJr().PowerKeys_IgnoreAllInjectedKeys && e.IsInjected)
		{
			iiBvvqEgZ6T = null;
		}
		else
		{
			if (AppHelper.fLiLTj0x4QY() - AppState.SessionUnlockTime < 1000L)
			{
				return;
			}
			try
			{
				if (e.KeyCode == Keys.C)
				{
					fyivvVoUXZX = false;
					if (Va2vvZdE1RU != null)
					{
						Va2vvZdE1RU.Dispose();
						Va2vvZdE1RU = null;
					}
				}
				if (e.KeyCode != Keys.Packet)
				{
					try
					{
						if (IFVvvu5V5nH.ProcessKeyUp(e, out var ignoringPrimaryKey))
						{
							if (AppState.EnableDetailedLogging)
							{
								int num2 = 0;
								if (COIxMyFCeTKEhc49RX1F != null)
								{
									int num3 = default(int);
									num2 = num3;
								}
								switch (num2)
								{
								}
								i71vvyAPQUV.Info("扩展热键：按键up返回True");
							}
							if (ignoringPrimaryKey)
							{
								Jn8vv2lDcFZ.VDNtxJDE4av(e);
							}
							if (!KeyboardHelper.IsKeyDown((VirtualKeyCode)e.KeyValue))
							{
								e.Handled = true;
							}
							else
							{
								e.Handled = false;
							}
							return;
						}
					}
					catch (Exception exception)
					{
						string message = "处理扩展热键遇到了一个问题。" + exception.GetMessageWithInner();
						i71vvyAPQUV.Warn(message, exception);
						AppHelper.ShowWarning(message);
						return;
					}
				}
				if (!SL0vvwD6HYI.CpItmVISR7P().OpenPopWithCtrlClick || !WlXvLjpb0vf())
				{
					return;
				}
				bool flag = (Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left;
				int num4;
				if (!zsIvL5h6PhP())
				{
					num4 = 0;
					if (!IhLjTcFCjA6MRipDUS4j())
					{
						goto IL_02e7;
					}
					goto IL_02f6;
				}
				goto IL_032d;
				IL_022e:
				if (iiBvvqEgZ6T.HasValue && iiBvvqEgZ6T.Value.AddMilliseconds(350.0) > DateTime.UtcNow && iiBvvqEgZ6T.Value.AddMilliseconds(5.0) < DateTime.UtcNow)
				{
					if (ofOvg0CekCm())
					{
						num4 = 1;
						if (!IhLjTcFCjA6MRipDUS4j())
						{
							goto IL_02e7;
						}
						goto IL_02f6;
					}
					goto IL_0316;
				}
				goto IL_032d;
				IL_02e7:
				if (e.KeyValue != 162 || UGWvvasNwK0 != 162)
				{
					if (e.KeyValue != 163 || UGWvvasNwK0 != 163)
					{
						goto IL_032d;
					}
					num4 = 1;
					if (!IhLjTcFCjA6MRipDUS4j())
					{
						goto IL_02f6;
					}
				}
				goto IL_022e;
				IL_032d:
				V8yvLDRddBD(false);
				LaavLnQ0uya(false);
				return;
				IL_02f6:
				switch (num4)
				{
				case 2:
					break;
				default:
					goto IL_02e7;
				case 1:
					goto IL_0309;
				}
				goto IL_022e;
				IL_0309:
				if (e.KeyValue != 162)
				{
					goto IL_0316;
				}
				goto IL_032d;
				IL_0316:
				if (!flag)
				{
					iiBvvqEgZ6T = null;
					CIUvg7dqbo6(false);
				}
				goto IL_032d;
			}
			finally
			{
				if (!e.Handled)
				{
					mX7qQhjtCi2Je746unO.SSQtGP00VJO(e.KeyCode);
				}
			}
		}
		return;
		IL_009d:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		}
		goto IL_00ac;
		IL_00ac:
		fyQvvWWWM3P.KPhtZmUAjus();
		goto IL_00b7;
	}

	private bool ofOvg0CekCm()
	{
		if (!string.Equals("mstsc", AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase) && !string.Equals("mremoteng", AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		return NativeMethods.IsForegroundFullScreen();
	}

	private void zlxvgCPnKQ6(object sender, HookKeyEventArgs e)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.nNh2PLjSGTO = this;
		_003C_003Ec__DisplayClass59_.qhD2PvBAgVP = e;
		AppState.jqKtaRtl9EB(true);
		if ((ObkG8JjRVxQq4TEiAhL.FjltkDTmR89(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP) && _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled) || !dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		U6KvvY7SfVa = null;
		if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.IsFromQuicker)
		{
			return;
		}
		if (AppState.HHxtaMaoqJr().PowerKeys_IgnoreAllInjectedKeys && _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.IsInjected)
		{
			goto IL_035d;
		}
		goto IL_03dc;
		IL_032d:
		bool? obj;
		bool? flag = (bool?)obj;
		if (flag != true || !PiDvLKeR7jr())
		{
			goto IL_019d;
		}
		int num;
		if (!KeyboardHelper.IsKeyDown(VirtualKeyCode.VK_C))
		{
			fyivvVoUXZX = true;
			num = 0;
			if (IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_0287;
			}
			goto IL_0305;
		}
		_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
		return;
		IL_0305:
		Ow9vvcCBW94 = AppHelper.fLiLTj0x4QY();
		yEcvgEEPRMN();
		goto IL_019d;
		IL_019d:
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass59_.r502Cz3f9e6);
		if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.IsRestore)
		{
			goto IL_01c3;
		}
		num = 6;
		if (IhLjTcFCjA6MRipDUS4j())
		{
			goto IL_0287;
		}
		goto IL_02fb;
		IL_0557:
		if (eA0vg8Zlga6(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP) || !dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithCtrlClick)
		{
			UGWvvasNwK0 = _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue;
			if ((_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue == 162 || _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue == 163 || _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue == 17) && !WlXvLjpb0vf() && !dHavLMV7kRX().RealKeyState.IsAnyOtherKeyDown(162, 163, 17))
			{
				V8yvLDRddBD(false);
				LaavLnQ0uya(true);
				iiBvvqEgZ6T = DateTime.UtcNow;
			}
		}
		goto IL_061b;
		IL_04e4:
		_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
		return;
		IL_035d:
		if (!_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.IsRestore)
		{
			return;
		}
		goto IL_03dc;
		IL_03dc:
		if (!_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.IsRepeating || (!InputSimulator.Instance.Keyboard.IsWorking && (!fyQvvWWWM3P.KIQtZjjGceP() || !fyQvvWWWM3P.EvVt9JuygnX().HasValue || !KeyboardHelper.fDPLMDBnLis(fyQvvWWWM3P.EvVt9JuygnX().Value, (VirtualKeyCode)_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode))))
		{
			if (v45vvBRpIiS == null || !v45vvBRpIiS.IsWorking || IFVvvu5V5nH.IsKeyCaptured(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue))
			{
				if (eVuvLfVCnT6 == null || !eVuvLfVCnT6.IsWorking || IFVvvu5V5nH.IsKeyCaptured(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue))
				{
					if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode == Keys.F1)
					{
						num = 8;
						if (COIxMyFCeTKEhc49RX1F == null)
						{
							goto IL_0287;
						}
						goto IL_02fb;
					}
					goto IL_034e;
				}
				if (eVuvLfVCnT6.JMXL9glYsxj(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue))
				{
					_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
				}
				return;
			}
			if (v45vvBRpIiS.OnKeyDown(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue))
			{
				_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
			}
			return;
		}
		goto IL_04e4;
		IL_0287:
		while (true)
		{
			switch (num)
			{
			case 10:
				break;
			case 6:
				goto IL_0264;
			default:
				goto IL_0305;
			case 8:
				goto IL_033b;
			case 2:
				goto IL_035d;
			case 1:
				if (AppState.EnableDetailedLogging)
				{
					i71vvyAPQUV.Info("扩展热键：按键Down返回True。");
				}
				_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
				return;
			case 3:
				return;
			case 4:
				goto IL_04d5;
			case 7:
				goto IL_04e4;
			case 5:
				goto IL_061b;
			case 9:
				goto IL_0647;
			}
			break;
			IL_0264:
			if (!IFVvvu5V5nH.ProcessKeyDown(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP))
			{
				goto IL_01c3;
			}
			num = 1;
			if (COIxMyFCeTKEhc49RX1F == null)
			{
				continue;
			}
			goto IL_0305;
		}
		goto IL_0222;
		IL_0647:
		if (dhNvgPYVq4h(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode))
		{
			return;
		}
		goto IL_065b;
		IL_065b:
		IDictionary<int, int> keyTriggers = SL0vvwD6HYI.CpItmVISR7P().KeyTriggers;
		if ((keyTriggers != null && keyTriggers.ContainsKey((int)_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode)) || _003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode.IsEither(Keys.Left, Keys.Right, Keys.Up, Keys.Down))
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass59_.lfk2PgNCX08);
		}
		return;
		IL_033b:
		if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Control)
		{
			DebugHelper.LogMouseCaptureWindow();
		}
		goto IL_034e;
		IL_02fb:
		int num2 = default(int);
		num = num2;
		goto IL_0287;
		IL_034e:
		if (!hUhANW5oHPgw7wvDYAd.hbEm0h4K8o())
		{
			if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode == Keys.Escape)
			{
				AppState.IncreaseEscCounter();
				if (AppState.CloseAllContextMenus())
				{
					_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
					return;
				}
				if (EXavvpoOBID != null && EXavvpoOBID.IsVisible)
				{
					EXavvpoOBID.Cancel();
					_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
					num2 = 3;
					return;
				}
			}
			if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode == Keys.C)
			{
				DataService dataService = AppState.DataService;
				if (dataService != null)
				{
					UserSettings userSettings = dataService.CpItmVISR7P();
					if (userSettings == null)
					{
						obj = null;
					}
					else
					{
						ContextMenuSettings contextMenuSettings = userSettings.ContextMenuSettings;
						if (contextMenuSettings == null)
						{
							goto IL_0222;
						}
						obj = contextMenuSettings.EnableControlLongCTrigger;
					}
					goto IL_032d;
				}
			}
			goto IL_019d;
		}
		if (IFVvvu5V5nH.IsKeyCaptured(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyValue))
		{
			_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
		}
		else
		{
			eA0vg8Zlga6(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP);
		}
		return;
		IL_061b:
		if (BWivLz0pfuj.IsVisible && BWivLz0pfuj.EnableKeyTrigger)
		{
			if (AppState.HHxtaMaoqJr().OpenPopWithCtrlClick)
			{
				goto IL_0647;
			}
			goto IL_065b;
		}
		return;
		IL_0500:
		if (BWivLz0pfuj?.DashboardWindow != null)
		{
			try
			{
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass59_.D2P2PtG5VbX);
				_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled = true;
				return;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("关闭仪表盘窗口出错：" + ex.Message);
			}
		}
		goto IL_0557;
		IL_0222:
		obj = null;
		goto IL_032d;
		IL_04d5:
		if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled)
		{
			return;
		}
		goto IL_0500;
		IL_01c3:
		if (SL0vvwD6HYI.CpItmVISR7P().EnableTextCommand && !BlackListHelper.IsProcessInBlackList(AppState.CurrentProcessName, AppState.HHxtaMaoqJr().TextCommandBlackList))
		{
			Jn8vv2lDcFZ.VDNtxJDE4av(_003C_003Ec__DisplayClass59_.qhD2PvBAgVP);
			if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.Handled)
			{
				return;
			}
		}
		if (_003C_003Ec__DisplayClass59_.qhD2PvBAgVP.KeyCode == Keys.Escape)
		{
			if (BWivLz0pfuj.IsVisible)
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass59_.Vtj2Pw9uCtZ);
				num = 4;
				if (IhLjTcFCjA6MRipDUS4j())
				{
					goto IL_0287;
				}
				goto IL_02fb;
			}
			goto IL_0500;
		}
		goto IL_0557;
	}

	private bool dhNvgPYVq4h(Keys keys_0)
	{
		return keys_0.IsEither(Keys.LControlKey, Keys.RControlKey, Keys.ControlKey);
	}

	private void yEcvgEEPRMN()
	{
		if (Va2vvZdE1RU != null)
		{
			Va2vvZdE1RU.Dispose();
			Va2vvZdE1RU = null;
		}
		DataService dataService = AppState.DataService;
		int? obj;
		if (dataService == null)
		{
			obj = null;
		}
		else
		{
			UserSettings userSettings = dataService.CpItmVISR7P();
			if (userSettings != null)
			{
				obj = userSettings.ContextMenuSettings?.TriggerIntervalMs;
			}
			else
			{
				int? num = null;
				if (IhLjTcFCjA6MRipDUS4j())
				{
					switch (0)
					{
					}
				}
				obj = num;
			}
		}
		int dueTime = obj ?? 300;
		Va2vvZdE1RU = new System.Threading.Timer(hIGvgy2M689, null, dueTime, -1);
	}

	private void hIGvgy2M689(object object_0)
	{
		Va2vvZdE1RU?.Dispose();
		Va2vvZdE1RU = null;
		AppHelper.RunOnUiThread(false, _003C_003Ec.Api20q3g4km ?? (_003C_003Ec.Api20q3g4km = _003C_003Ec.Arm20RCQ7us.vb320ufJUZa));
	}

	private bool eA0vg8Zlga6(System.Windows.Forms.KeyEventArgs keyEventArgs_0)
	{
		if (keyEventArgs_0.KeyCode == Keys.Capital && keyEventArgs_0.Modifiers == Keys.None && !string.IsNullOrEmpty(SL0vvwD6HYI.CpItmVISR7P().RemapKeyCapsLock) && !JrJWiKYIEBcPm8FFZOl.Dg0LDSnOcIg(VirtualKeyCode.CAPITAL))
		{
			try
			{
				Hotkey hotkey = new Hotkey(SL0vvwD6HYI.CpItmVISR7P().RemapKeyCapsLock);
				InputSimulator.Instance.Keyboard.ModifiedKeyStroke(hotkey.GetModifierKeyCodes().ToList(), hotkey.Key, AppHelper.kPoLTdWFLA7());
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("映射按键出错：" + ex.Message);
			}
			keyEventArgs_0.Handled = true;
			return true;
		}
		if (keyEventArgs_0.KeyCode == Keys.Pause)
		{
			int num = 0;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (keyEventArgs_0.Modifiers == Keys.None && !string.IsNullOrEmpty(SL0vvwD6HYI.CpItmVISR7P().RemapKeyPauseBreak))
			{
				try
				{
					Hotkey hotkey2 = new Hotkey(SL0vvwD6HYI.CpItmVISR7P().RemapKeyPauseBreak);
					InputSimulator.Instance.Keyboard.ModifiedKeyStroke(hotkey2.GetModifierKeyCodes().ToList(), hotkey2.Key, AppHelper.kPoLTdWFLA7());
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("映射按键出错：" + ex2.Message);
				}
				keyEventArgs_0.Handled = true;
				return true;
			}
		}
		return false;
	}

	private bool oZAvgaPTyJa(Keys keys_0)
	{
		switch (keys_0)
		{
		case Keys.Left:
			if (iFevvLKAVeT.GoLeft())
			{
				return true;
			}
			break;
		case Keys.Right:
			if (iFevvLKAVeT.GoRight())
			{
				return true;
			}
			break;
		case Keys.Up:
			if (iFevvLKAVeT.GlobalGoLeft())
			{
				return true;
			}
			break;
		case Keys.Down:
			if (iFevvLKAVeT.GlobalGoRight())
			{
				return true;
			}
			break;
		}
		return false;
	}

	public void CIUvg7dqbo6(bool bool_7)
	{
		if (!dB6vvgTocvt.IsEnabled && !bool_7)
		{
			return;
		}
		PointTargetInfo pointTargetInfo = AppHelper.GetPointTargetInfo(null);
		if (!pointTargetInfo.CanTrigger(PopupSource.Keyboard))
		{
			return;
		}
		if (SL0vvwD6HYI.CpItmVISR7P().ActiveCursorPositionWindowWhenPopupWithKeyboard)
		{
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				switch (0)
				{
				}
			}
			fPDvLWi28bU(pointTargetInfo);
		}
		BWivLz0pfuj.TogglePopupWindow(PopupSource.Keyboard, pointTargetInfo);
	}

	[SpecialName]
	[CompilerGenerated]
	public void uN4vLlBPsmq(KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler_1)
	{
		KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler = Nekvv9Qh3SE;
		KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler2;
		do
		{
			quickerKeyEventHandler2 = quickerKeyEventHandler;
			KeyboardHook.QuickerKeyEventHandler value = (KeyboardHook.QuickerKeyEventHandler)Delegate.Combine(quickerKeyEventHandler2, quickerKeyEventHandler_1);
			quickerKeyEventHandler = Interlocked.CompareExchange(ref Nekvv9Qh3SE, value, quickerKeyEventHandler2);
		}
		while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bF0vLiBclyH(KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler_1)
	{
		KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler = Nekvv9Qh3SE;
		KeyboardHook.QuickerKeyEventHandler quickerKeyEventHandler2;
		do
		{
			quickerKeyEventHandler2 = quickerKeyEventHandler;
			KeyboardHook.QuickerKeyEventHandler value = (KeyboardHook.QuickerKeyEventHandler)Delegate.Remove(quickerKeyEventHandler2, quickerKeyEventHandler_1);
			quickerKeyEventHandler = Interlocked.CompareExchange(ref Nekvv9Qh3SE, value, quickerKeyEventHandler2);
		}
		while ((object)quickerKeyEventHandler != quickerKeyEventHandler2);
	}

	private void l8ovgRryABN(object sender, HookKeyEventArgs e)
	{
		Nekvv9Qh3SE?.Invoke(sender, e);
	}

	public void sVNvgq3htAy()
	{
		Jn8vv2lDcFZ?.jkntx0ksqUV();
	}

	private void l7tvgcyHZc9()
	{
		h2svveb70E4 = Y7ivvblS7lk.Where(_003C_003Ec.hje20cTeDyx ?? (_003C_003Ec.hje20cTeDyx = _003C_003Ec.Arm20RCQ7us.NLF20NyC6Pl)).ToList();
		erpvvh5h56q = h2svveb70E4.Count > 0;
	}

	private void HsTvgVhN5ue()
	{
		if (!erpvvh5h56q || fyQvvWWWM3P.KIQtZjjGceP())
		{
			return;
		}
		lPxZYOM8ws3NP42wph0 lPxZYOM8ws3NP42wph = zYwvLopdTEn();
		if (lPxZYOM8ws3NP42wph == null)
		{
			return;
		}
		oweR8e2rZD7t5GSlLo4 oweR8e2rZD7t5GSlLo = lPxZYOM8ws3NP42wph.RealState;
		bool? flag2;
		if (oweR8e2rZD7t5GSlLo == null)
		{
			bool? flag = null;
			int num = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			flag2 = flag;
		}
		else
		{
			flag2 = oweR8e2rZD7t5GSlLo.naIt9jxvaxU();
		}
		if (flag2 != false)
		{
			return;
		}
		int num4 = default(int);
		foreach (Quicker.Domain.PowerMouse.MouseAction item in h2svveb70E4)
		{
			if (!z0wvLCcCybg(item, true))
			{
				continue;
			}
			PointTargetInfo pointTargetInfo = AppHelper.GetPointTargetInfo(null);
			Screen screen = Df7vgOJUMaE(pointTargetInfo.Point);
			int num3 = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			default:
				if (wmjvLySs6cd(item, pointTargetInfo, screen))
				{
					if (!U6KvvY7SfVa.HasValue)
					{
						U6KvvY7SfVa = pointTargetInfo.Point;
						break;
					}
					goto case 1;
				}
				break;
			case 1:
				if (AppHelper.IsFarThan(U6KvvY7SfVa.Value, pointTargetInfo.Point, AppState.HHxtaMaoqJr().MoveTriggerDistance))
				{
					PointTargetInfo pointTargetInfo2 = AppHelper.GetPointTargetInfo(U6KvvY7SfVa);
					RR1vg3fMESk(pointTargetInfo2);
					fyQvvWWWM3P.WXstZXfeNVh(pointTargetInfo2, screen, (VirtualKeyCode)item.ControlKey.Value, item);
					FPlvgiqIvSK(item);
					V8yvLDRddBD(true);
					LaavLnQ0uya(false);
				}
				break;
			}
			break;
		}
	}

	private bool mfYvgZSL8SN(VirtualKeyCode virtualKeyCode_0, Quicker.Domain.PowerMouse.MouseAction mouseAction_0)
	{
		U6KvvY7SfVa = null;
		if (mouseAction_0 == null)
		{
			return false;
		}
		System.Drawing.Point mousePhysicalPosition = NativeMethods.GetMousePhysicalPosition();
		return Diovg9R8llC(mouseAction_0, mousePhysicalPosition, mousePhysicalPosition, true);
	}

	private bool Diovg9R8llC(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, System.Drawing.Point point_1, System.Drawing.Point point_2, bool bool_7)
	{
		int num = 1;
		while (true)
		{
			_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
			int num2 = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			default:
				_003C_003Ec__DisplayClass78_.J1r2P8Pxj70 = this;
				_003C_003Ec__DisplayClass78_.LeH2PaMGZdq = point_2;
				_003C_003Ec__DisplayClass78_.RAJ2P7prLc9 = point_1;
				switch (mouseAction_0.Operation)
				{
				case MouseOperationType.ShowCircleMenu:
					guOvtMiaXe1(_003C_003Ec__DisplayClass78_.RAJ2P7prLc9, false);
					goto end_IL_001c;
				case MouseOperationType.DrawGestures:
				{
					GestureWindow gestureWindow = v45vvBRpIiS;
					if (gestureWindow != null && gestureWindow.IsWorking)
					{
						v45vvBRpIiS.End(null);
					}
					goto end_IL_001c;
				}
				case MouseOperationType.ScreenCapture:
					Task.Run((Action)_003C_003Ec__DisplayClass78_.cc72PEf9AO4);
					goto end_IL_001c;
				case MouseOperationType.ShowPanel:
					break;
				default:
					goto end_IL_001c;
				}
				goto case 2;
			case 2:
				{
					if (bool_7 || SL0vvwD6HYI.CpItmVISR7P().EnableReleaseOnButtonTrigger)
					{
						Task.Run((Action)_003C_003Ec__DisplayClass78_.EcA2PPD2H4T);
					}
					break;
				}
				end_IL_001c:
				break;
			}
			break;
		}
		return true;
	}

	private void tZYvghvENti()
	{
		foreach (Quicker.Domain.PowerMouse.MouseAction item in h2svveb70E4)
		{
			if (z0wvLCcCybg(item, true))
			{
				eSXvvIJsst7 = true;
				return;
			}
		}
		eSXvvIJsst7 = false;
	}

	[SpecialName]
	public lPxZYOM8ws3NP42wph0 zYwvLopdTEn()
	{
		return Hkevv0QHEW3;
	}

	[SpecialName]
	public KeyboardHook dHavLMV7kRX()
	{
		return cDWvv8xNu7H;
	}

	private void MtSvge5IU64()
	{
		if (QGjvvHGvJi1 == null)
		{
			QGjvvHGvJi1 = new Thread(zk9vg5W6Gtb)
			{
				IsBackground = true
			};
			QGjvvHGvJi1.Start();
		}
		TbUvv1kROcc.InvokeAsync(lTivLx5KCtU);
		Kv7vt3g1lT6();
	}

	private void d3svgYZREfn()
	{
		TbUvv1kROcc.InvokeAsync(tvvvLrjHEPc);
		zAwvvCZiXYj.Stop();
	}

	private IList<Quicker.Domain.PowerMouse.MouseAction> jGavgIpP06v()
	{
		if (Y7ivvblS7lk == null)
		{
			N3jvgW1OKsQ();
		}
		return Y7ivvblS7lk;
	}

	private void N3jvgW1OKsQ()
	{
		List<Quicker.Domain.PowerMouse.MouseAction> list = REIvgkZoEs0();
		foreach (Quicker.Domain.PowerMouse.MouseAction item in list)
		{
			item.Priority = 2;
		}
		List<Quicker.Domain.PowerMouse.MouseAction> list2 = SL0vvwD6HYI.FnrtmLxNViE().Where(_003C_003Ec.sX520VLOQBe ?? (_003C_003Ec.sX520VLOQBe = _003C_003Ec.Arm20RCQ7us.LGI20J9qOfF)).ToList();
		{
			list.AddRange(list2);
		}
		Y7ivvblS7lk = list.OrderByDescending(_003C_003Ec.cbH20ZBQZbc ?? (_003C_003Ec.cbH20ZBQZbc = _003C_003Ec.Arm20RCQ7us.ib3200XJoCS)).ThenBy(_003C_003Ec.VDA209ufX1g ?? (_003C_003Ec.VDA209ufX1g = _003C_003Ec.Arm20RCQ7us.BqG20CUuZ2e)).ToList();
		BYhvvkjpWF1 = Y7ivvblS7lk.Where(_003C_003Ec.DMQ20hk1Bto ?? (_003C_003Ec.DMQ20hk1Bto = _003C_003Ec.Arm20RCQ7us.bDE20Pya0FQ)).ToList();
		itSvvGgTnQU = Y7ivvblS7lk.Where(_003C_003Ec.Apd20eqcpum ?? (_003C_003Ec.Apd20eqcpum = _003C_003Ec.Arm20RCQ7us.xlR20EhZXSs)).ToList();
		l7tvgcyHZc9();
		mX7qQhjtCi2Je746unO.Refresh();
		int num = 0;
		if (!IhLjTcFCjA6MRipDUS4j())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private List<Quicker.Domain.PowerMouse.MouseAction> REIvgkZoEs0()
	{
		ExeSettings exeSettings = SL0vvwD6HYI.yQWt6ownR4Z("_global", true);
		List<Quicker.Domain.PowerMouse.MouseAction> list = new List<Quicker.Domain.PowerMouse.MouseAction>();
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithMiddleClick)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Middle,
				MouseActionType = MouseActionType.Down,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithXButton1Click)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.XButton1,
				MouseActionType = MouseActionType.Down,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithXButton2Click)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.XButton2,
				MouseActionType = MouseActionType.Down,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithCtrlMiddleClick)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Middle,
				MouseActionType = MouseActionType.Down,
				ControlKey = 17,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithCtrlRightClick)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Right,
				MouseActionType = MouseActionType.Down,
				ControlKey = 17,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithWheelLeft)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelLeft,
				ControlKey = null,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithLongRightPress)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Right,
				MouseActionType = MouseActionType.LongPress,
				ControlKey = null,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithLongMiddlePress)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Middle,
				MouseActionType = MouseActionType.LongPress,
				ControlKey = null,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowPanel
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopWithRightPressMove)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.Right,
				MouseActionType = MouseActionType.Drag,
				ControlKey = null,
				WhiteList = null,
				BlackList = null,
				Operation = ((!SL0vvwD6HYI.CpItmVISR7P().EnableCircleMenu) ? MouseOperationType.ShowPanel : MouseOperationType.ShowCircleMenu)
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolume || SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolumeOnScreenBottom)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelDown,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.QuickerOperation,
				Data = "windows_volume_down",
				Location = (MouseActionLocation)((SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolume ? 48 : 0) | (SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolumeOnScreenBottom ? 192 : 0))
			});
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelUp,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.QuickerOperation,
				Data = "windows_volume_up",
				Location = (MouseActionLocation)((SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolume ? 48 : 0) | (SL0vvwD6HYI.CpItmVISR7P().EnableChangeVolumeOnScreenBottom ? 192 : 0))
			});
		}
		List<ExeSettings> list2 = SL0vvwD6HYI.TxrtXFmcoEV().Values.ToList();
		if (SL0vvwD6HYI.CpItmVISR7P().CircleMenuTrigger != 0)
		{
			(int?, MouseButtons) tuple = SwOvgstQ2BQ(SL0vvwD6HYI.CpItmVISR7P().CircleMenuTrigger);
			Quicker.Domain.PowerMouse.MouseAction mouseAction = new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = tuple.Item2,
				MouseActionType = MouseActionType.Drag,
				ControlKey = tuple.Item1,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.ShowCircleMenu
			};
			if (exeSettings.DisableCircleMenu)
			{
				IList<string> list3 = new List<string>();
				foreach (ExeSettings item in list2)
				{
					if (item == null || item.DisableCircleMenu)
					{
						continue;
					}
					list3.Add(item.Exe);
					if (item?.AliasExeList == null)
					{
						continue;
					}
					foreach (string aliasExe in item.AliasExeList)
					{
						list3.AddIfDistinct(aliasExe.ToLower());
					}
				}
				mouseAction.WhiteList = list3.ToArray();
			}
			else
			{
				IList<string> list4 = new List<string>();
				foreach (ExeSettings item2 in list2)
				{
					if (item2 == null || !item2.DisableCircleMenu)
					{
						continue;
					}
					list4.Add(item2.Exe);
					if (item2?.AliasExeList == null)
					{
						continue;
					}
					foreach (string aliasExe2 in item2.AliasExeList)
					{
						list4.AddIfDistinct(aliasExe2.ToLower());
					}
				}
				mouseAction.BlackList = list4.ToArray();
			}
			list.Add(mouseAction);
		}
		if (SL0vvwD6HYI.CpItmVISR7P().GestureTrigger != 0)
		{
			(int?, MouseButtons) tuple2 = SwOvgstQ2BQ(SL0vvwD6HYI.CpItmVISR7P().GestureTrigger);
			Quicker.Domain.PowerMouse.MouseAction mouseAction2 = new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = tuple2.Item2,
				MouseActionType = MouseActionType.Drag,
				ControlKey = tuple2.Item1,
				WhiteList = null,
				BlackList = null,
				Operation = MouseOperationType.DrawGestures
			};
			if (exeSettings.DisableGesture)
			{
				IList<string> list5 = new List<string>();
				foreach (ExeSettings item3 in list2)
				{
					if (item3 == null || item3.DisableGesture)
					{
						continue;
					}
					list5.Add(item3.Exe);
					if (item3.AliasExeList == null)
					{
						continue;
					}
					foreach (string aliasExe3 in item3.AliasExeList)
					{
						list5.AddIfDistinct(aliasExe3.ToLower());
					}
				}
				mouseAction2.WhiteList = list5.ToArray();
			}
			else
			{
				IList<string> list6 = new List<string>();
				foreach (ExeSettings item4 in list2)
				{
					if (item4 == null || !item4.DisableGesture)
					{
						continue;
					}
					list6.Add(item4.Exe);
					if (item4?.AliasExeList == null)
					{
						continue;
					}
					foreach (string aliasExe4 in item4.AliasExeList)
					{
						list6.AddIfDistinct(aliasExe4.ToLower());
					}
				}
				mouseAction2.BlackList = list6.ToArray();
			}
			list.Add(mouseAction2);
		}
		if (SL0vvwD6HYI.CpItmVISR7P().EnableAdjScreenBrightnessUseCtrlScroll)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelDown,
				ControlKey = 17,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.QuickerOperation,
				Data = "monitor_brightness_decrease",
				Location = MouseActionLocation.TopBorder
			});
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelUp,
				ControlKey = 17,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.QuickerOperation,
				Data = "monitor_brightness_increase",
				Location = MouseActionLocation.TopBorder
			});
		}
		if (SL0vvwD6HYI.CpItmVISR7P().EnableSwitchVirtualDeskUseX1HScroll)
		{
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelLeft,
				ControlKey = 5,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.RIGHT, ModifierKeys.Control | ModifierKeys.Windows).ToData()
			});
			list.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.WheelRight,
				ControlKey = 5,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.Keystroke,
				Data = new Hotkey(VirtualKeyCode.LEFT, ModifierKeys.Control | ModifierKeys.Windows).ToData()
			});
		}
		HUCvgGHDDi9(list, SL0vvwD6HYI.CpItmVISR7P().CornerActionTopLeft, MouseActionLocation.CornerTopLeft);
		HUCvgGHDDi9(list, SL0vvwD6HYI.CpItmVISR7P().CornerActionTopRight, MouseActionLocation.CornerTopRight);
		HUCvgGHDDi9(list, SL0vvwD6HYI.CpItmVISR7P().CornerActionBottomLeft, MouseActionLocation.CornerBottomLeft);
		HUCvgGHDDi9(list, SL0vvwD6HYI.CpItmVISR7P().CornerActionBottomRight, MouseActionLocation.CornerBottomRight);
		ScreenShotSettings screenShotSettings = SL0vvwD6HYI.CpItmVISR7P().ScreenShotSettings;
		if (screenShotSettings != null && screenShotSettings.IsEnabled)
		{
			ScreenShotSettings screenShotSettings2 = SL0vvwD6HYI.CpItmVISR7P().ScreenShotSettings;
			if (screenShotSettings2.Trigger > 0)
			{
				(int?, MouseButtons) tuple3 = SwOvgstQ2BQ(screenShotSettings2.Trigger);
				list.Add(new Quicker.Domain.PowerMouse.MouseAction
				{
					MouseButton = tuple3.Item2,
					MouseActionType = MouseActionType.Drag,
					ControlKey = screenShotSettings2.AdornKey,
					WhiteList = null,
					BlackList = null,
					Operation = MouseOperationType.ScreenCapture
				});
			}
		}
		return list;
	}

	private void HUCvgGHDDi9(List<Quicker.Domain.PowerMouse.MouseAction> list_0, string string_0, MouseActionLocation mouseActionLocation_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			list_0.Add(new Quicker.Domain.PowerMouse.MouseAction
			{
				MouseButton = MouseButtons.None,
				MouseActionType = MouseActionType.MoveToCorner,
				Operation = MouseOperationType.QuickAction,
				ActionType = QuickActionType.Keystroke,
				Data = string_0,
				Location = mouseActionLocation_0
			});
		}
	}

	private (int? controlKey, MouseButtons button) SwOvgstQ2BQ(int int_1)
	{
		return int_1 switch
		{
			0 => (controlKey: null, button: MouseButtons.None), 
			2 => (controlKey: null, button: MouseButtons.Middle), 
			4 => (controlKey: null, button: MouseButtons.Right), 
			5 => (controlKey: null, button: MouseButtons.XButton1), 
			6 => (controlKey: null, button: MouseButtons.XButton2), 
			_ => (controlKey: null, button: MouseButtons.None), 
		};
	}

	private void asPvgHp9WBu(object sender, EventArgs e)
	{
		_003C_003Ec__DisplayClass99_0 _003C_003Ec__DisplayClass99_ = new _003C_003Ec__DisplayClass99_0();
		_003C_003Ec__DisplayClass99_.Tmq2Pcbe0Pu = this;
		XFfvvJeKXVt?.Stop();
		if (fyQvvWWWM3P.MouseAction != null || (eVuvLfVCnT6 != null && eVuvLfVCnT6.IsWorking))
		{
			return;
		}
		Quicker.Domain.PowerMouse.MouseAction mouseAction = I0KvLtW1Qtj();
		int num;
		if (mouseAction != null)
		{
			fyQvvWWWM3P.MouseAction = mouseAction;
			FPlvgiqIvSK(mouseAction);
			num = 1;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_0106;
			}
		}
		else
		{
			if (!SL0vvwD6HYI.CpItmVISR7P().RestoreOriginEventIfMouseDownTimeout || fyQvvWWWM3P.BWKtZ5W0fAU() != 1)
			{
				return;
			}
			_003C_003Ec__DisplayClass99_.WkZ2PVWJoKV = fyQvvWWWM3P.tNotZDBTnmu();
			if (!_003C_003Ec__DisplayClass99_.WkZ2PVWJoKV.HasValue)
			{
				return;
			}
			fyQvvWWWM3P.OSrtZMXZ2c0(_003C_003Ec__DisplayClass99_.WkZ2PVWJoKV.Value);
			fyQvvWWWM3P.b85t9qRpcbb(_003C_003Ec__DisplayClass99_.WkZ2PVWJoKV.Value);
			num = 0;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_0106;
			}
		}
		goto IL_010a;
		IL_0106:
		int num2 = default(int);
		num = num2;
		goto IL_010a;
		IL_010a:
		switch (num)
		{
		case 1:
			return;
		}
		Task.Run((Action)_003C_003Ec__DisplayClass99_.OQ72PqCsP23);
		fyQvvWWWM3P.KPhtZmUAjus();
	}

	private void soyvg1j7vfg(object sender, AppMouseEventArgs e)
	{
		int num = 3;
		while (true)
		{
			_003C_003Ec__DisplayClass100_0 _003C_003Ec__DisplayClass100_ = new _003C_003Ec__DisplayClass100_0();
			while (true)
			{
				_003C_003Ec__DisplayClass100_.tp320BDZBRk = this;
				_003C_003Ec__DisplayClass100_.yIo20QwhvgO = e;
				AppState.jqKtaRtl9EB(false);
				AppState.LastClickMouseButton = _003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button;
				Jn8vv2lDcFZ?.jkntx0ksqUV();
				if (_003C_003Ec__DisplayClass100_.yIo20QwhvgO.IsFromQuicker || !dB6vvgTocvt.IsEnabled)
				{
					return;
				}
				int num3;
				if (fyQvvWWWM3P == null || !fyQvvWWWM3P.v1FtZoD4OuB(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button))
				{
					if (hUhANW5oHPgw7wvDYAd.hbEm0h4K8o())
					{
						return;
					}
					GestureWindow gestureWindow = v45vvBRpIiS;
					if (gestureWindow != null && gestureWindow.IsWorking)
					{
						bool num2 = v45vvBRpIiS.OnKeyDown(KeyboardHelper.GetMouseButtonKeyCode(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button));
						i71vvyAPQUV.Info($"拦截按键按下{_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button}：手势窗口正在工作");
						if (num2)
						{
							_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Handled = true;
							fyQvvWWWM3P.G5ltZd9HBRS(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button);
							return;
						}
					}
					if (AppState.IsTestingMouse)
					{
						return;
					}
					V8yvLDRddBD(true);
					if (SL0vvwD6HYI.CpItmVISR7P().EnableTextFloatingPanel)
					{
						AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass100_.h1020rMl5dd);
					}
					if (_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button == MouseButtons.Left)
					{
						AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass100_.AeA20peN04i);
						IFVvvu5V5nH.OnMouseLeftButtonDown();
						GrZJHjXh9DrUnn7CH6P.xQFtK7YexvG();
						Task.Run(_003C_003Ec.y6G20YH9E4D ?? (_003C_003Ec.y6G20YH9E4D = _003C_003Ec.Arm20RCQ7us.x5U20yavIIa));
					}
					else if (AppHelper.IsLeftBtnDown())
					{
						if (GrZJHjXh9DrUnn7CH6P.GCOtKqbAVB0() && GrZJHjXh9DrUnn7CH6P.AmgtKZQRDr7(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button))
						{
							_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Handled = true;
							fyQvvWWWM3P.p11tZxdVPnd();
							num3 = 4;
							if (COIxMyFCeTKEhc49RX1F != null)
							{
								continue;
							}
							goto IL_0256;
						}
						return;
					}
					if (!_003C_003Ec__DisplayClass100_.yIo20QwhvgO.IsInjected || !_003C_003Ec__DisplayClass100_.yIo20QwhvgO.IsFromGestureSoftware)
					{
						if (vuKvgbwjO8q(_003C_003Ec__DisplayClass100_.yIo20QwhvgO))
						{
							_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Handled = true;
							num3 = 0;
							if (!IhLjTcFCjA6MRipDUS4j())
							{
								goto IL_0252;
							}
							goto IL_0256;
						}
						return;
					}
					if (vcovgm5LvpD(_003C_003Ec__DisplayClass100_.yIo20QwhvgO))
					{
						_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Handled = true;
					}
					return;
				}
				i71vvyAPQUV.Warn($"检测到已捕获的按键再次按下：{_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button}");
				fyQvvWWWM3P.KPhtZmUAjus();
				return;
				IL_0252:
				num3 = num;
				goto IL_0256;
				IL_0256:
				while (true)
				{
					switch (num3)
					{
					case 2:
						break;
					case 4:
						goto IL_0227;
					case 3:
						goto end_IL_000e;
					default:
						fyQvvWWWM3P.G5ltZd9HBRS(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button);
						return;
					case 1:
						return;
					}
					break;
					IL_0227:
					fyQvvWWWM3P.G5ltZd9HBRS(_003C_003Ec__DisplayClass100_.yIo20QwhvgO.Button);
					RV5vLF5yh1l(true);
					num3 = 1;
					if (COIxMyFCeTKEhc49RX1F == null)
					{
						continue;
					}
					goto IL_0252;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
	}

	private bool vuKvgbwjO8q(AppMouseEventArgs appMouseEventArgs_0)
	{
		CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
		if (circleMenuWindow != null && circleMenuWindow.IsWorking && eVuvLfVCnT6.JMXL9glYsxj(KeyboardHelper.GetMouseButtonKeyCode(appMouseEventArgs_0.Button)))
		{
			return true;
		}
		Quicker.Domain.PowerMouse.MouseAction mouseAction = default(Quicker.Domain.PowerMouse.MouseAction);
		int num;
		PointTargetInfo pointTargetInfo = default(PointTargetInfo);
		(bool, bool, Quicker.Domain.PowerMouse.MouseAction) tuple = default((bool, bool, Quicker.Domain.PowerMouse.MouseAction));
		bool flag = default(bool);
		if (appMouseEventArgs_0.Button != MouseButtons.Left && fyQvvWWWM3P.KIQtZjjGceP())
		{
			mouseAction = ai3vgrJiJ7T(appMouseEventArgs_0.Button, fyQvvWWWM3P.nNvt9wrNn9A(), fyQvvWWWM3P.D4Kt9L8hbBH());
			if (mouseAction == null)
			{
				goto IL_01c7;
			}
			fyQvvWWWM3P.MouseAction = mouseAction;
			num = 1;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_019f;
			}
		}
		else
		{
			pointTargetInfo = AppHelper.GetPointTargetInfo(NativeMethods.GetMousePosition());
			Screen screen = Df7vgOJUMaE(pointTargetInfo.Point);
			if (pointTargetInfo.IsOnMainWindow)
			{
				return false;
			}
			if (appMouseEventArgs_0.Button == MouseButtons.Left)
			{
				MHEvgluYmgC(pointTargetInfo);
				CircleMenuWindow circleMenuWindow2 = eVuvLfVCnT6;
				if (circleMenuWindow2 != null && circleMenuWindow2.IsWorking)
				{
					if (fyQvvWWWM3P.KIQtZjjGceP())
					{
						bjCvtOvHnjy();
						return true;
					}
					if (!(pointTargetInfo.HWnd == eVuvLfVCnT6.hwnd))
					{
						bjCvtOvHnjy();
						return true;
					}
				}
				goto IL_0202;
			}
			if (appMouseEventArgs_0.Button == MouseButtons.Middle && pointTargetInfo.IsOnImageViewer)
			{
				return false;
			}
			tuple = t84vgxEsNbm(appMouseEventArgs_0.Button, pointTargetInfo, screen);
			flag = false;
			if (tuple.Item1)
			{
				fyQvvWWWM3P.LrEtZ6gkukf(pointTargetInfo, screen);
			}
			if (tuple.Item3 != null)
			{
				fyQvvWWWM3P.MouseAction = tuple.Item3;
				FPlvgiqIvSK(tuple.Item3);
				flag = true;
			}
			if (!tuple.Item2)
			{
				goto IL_0225;
			}
			num = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				goto IL_019f;
			}
		}
		goto IL_01a3;
		IL_01c7:
		return true;
		IL_0225:
		if (!flag)
		{
			MHEvgluYmgC(pointTargetInfo);
		}
		return tuple.Item1;
		IL_019f:
		int num2 = default(int);
		num = num2;
		goto IL_01a3;
		IL_0202:
		GestureWindow gestureWindow = v45vvBRpIiS;
		if (gestureWindow != null && gestureWindow.IsWorking)
		{
			v45vvBRpIiS.fGbL7xnwo7Y();
			return true;
		}
		return false;
		IL_01a3:
		while (true)
		{
			switch (num)
			{
			case 1:
				goto end_IL_01a3;
			case 3:
				goto IL_0202;
			case 2:
				goto IL_0225;
			}
			DispatcherTimer xFfvvJeKXVt = XFfvvJeKXVt;
			if (xFfvvJeKXVt != null)
			{
				xFfvvJeKXVt.Start();
				num = 2;
				if (IhLjTcFCjA6MRipDUS4j())
				{
					continue;
				}
				goto IL_019f;
			}
			goto IL_0225;
			continue;
			end_IL_01a3:
			break;
		}
		FPlvgiqIvSK(mouseAction);
		goto IL_01c7;
	}

	public bool zNCvg68stTv()
	{
		return fyQvvWWWM3P.KIQtZjjGceP();
	}

	public bool NIlvgXuD0A9(MouseButtons mouseButtons_0)
	{
		return fyQvvWWWM3P.tNotZDBTnmu() == mouseButtons_0;
	}

	private bool vcovgm5LvpD(AppMouseEventArgs appMouseEventArgs_0)
	{
		if (!fyQvvWWWM3P.KIQtZjjGceP())
		{
			int num2 = default(int);
			foreach (Quicker.Domain.PowerMouse.MouseAction item in jGavgIpP06v())
			{
				if (item.MouseActionType != MouseActionType.Down || item.MouseButton != appMouseEventArgs_0.Button || !z0wvLCcCybg(item))
				{
					continue;
				}
				int num = 0;
				if (COIxMyFCeTKEhc49RX1F != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				PointTargetInfo pointTargetInfo = AppHelper.GetPointTargetInfo(NativeMethods.GetMousePosition());
				Screen screen_ = Df7vgOJUMaE(pointTargetInfo.Point);
				if (wmjvLySs6cd(item, pointTargetInfo, screen_))
				{
					FPlvgiqIvSK(item);
					return true;
				}
			}
		}
		return false;
	}

	public MouseButtons? OnYvgKYBC7F()
	{
		if (!fyQvvWWWM3P.KIQtZjjGceP())
		{
			return null;
		}
		return fyQvvWWWM3P.tNotZDBTnmu();
	}

	private (bool shouldCapture, bool shouldCreateTimer, Quicker.Domain.PowerMouse.MouseAction actionToExecute) t84vgxEsNbm(MouseButtons mouseButtons_0, PointTargetInfo pointTargetInfo_0, Screen screen_0)
	{
		bool item = false;
		bool item2 = false;
		AppState.DataService.DyhtXJ0GcZv().TryGetValue(KeyboardHelper.GetMouseButtonKeyCode(mouseButtons_0), out var value);
		if (value != null && value.IsEnabled && value.KeyActions.HasData() && (!AppState.HHxtaMaoqJr().PowerKeys_EnableBlackList || !BlackListMgr.IsCurrentAppInBlackListOrDisabledByFullScreen()))
		{
			item = true;
		}
		foreach (Quicker.Domain.PowerMouse.MouseAction item3 in jGavgIpP06v())
		{
			if ((item3.MouseActionType.IsEither(MouseActionType.DoubleClick, MouseActionType.WheelDown, MouseActionType.WheelUp, MouseActionType.WheelLeft, MouseActionType.WheelRight) && item3.ControlKey != JekvL8tklpU(mouseButtons_0)) || !wmjvLySs6cd(item3, pointTargetInfo_0, screen_0))
			{
				continue;
			}
			if (item3.MouseButton == mouseButtons_0)
			{
				if (z0wvLCcCybg(item3))
				{
					if (item3.MouseActionType == MouseActionType.Down)
					{
						return (shouldCapture: true, shouldCreateTimer: false, actionToExecute: item3);
					}
					item2 = true;
					item = true;
				}
			}
			else if (item3.ControlKey == JekvL8tklpU(mouseButtons_0))
			{
				item = true;
			}
		}
		return (shouldCapture: item, shouldCreateTimer: item2, actionToExecute: null);
	}

	private Quicker.Domain.PowerMouse.MouseAction ai3vgrJiJ7T(MouseButtons mouseButtons_0, PointTargetInfo pointTargetInfo_0, Screen screen_0)
	{
		if (pointTargetInfo_0 != null && screen_0 != null)
		{
			foreach (Quicker.Domain.PowerMouse.MouseAction item in jGavgIpP06v())
			{
				if (!wmjvLySs6cd(item, pointTargetInfo_0, screen_0) || item.MouseButton != mouseButtons_0)
				{
					continue;
				}
				if (!IhLjTcFCjA6MRipDUS4j())
				{
					switch (0)
					{
					}
				}
				if (item.MouseActionType == MouseActionType.Down && item.ControlKey.HasValue && xT0vgpbZgCc((VirtualKeyCode)item.ControlKey.Value))
				{
					return item;
				}
			}
			return null;
		}
		return null;
	}

	public bool xT0vgpbZgCc(VirtualKeyCode virtualKeyCode_0)
	{
		return fyQvvWWWM3P.v1FtZoD4OuB(KxJvLa4e0ud(virtualKeyCode_0));
	}

	private void AfevgBF8RnO(object sender, AppMouseEventArgs e)
	{
		_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = new _003C_003Ec__DisplayClass109_0();
		_003C_003Ec__DisplayClass109_.pvb205Oc3Tn = this;
		int num2 = default(int);
		while (true)
		{
			_003C_003Ec__DisplayClass109_.syP20DIOMKF = e;
			if (_003C_003Ec__DisplayClass109_.syP20DIOMKF.IsFromQuicker || !dB6vvgTocvt.IsEnabled)
			{
				break;
			}
			KeyboardState keyboardState = cDWvv8xNu7H?.RealKeyState;
			System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
			XFfvvJeKXVt?.Stop();
			if (!fyQvvWWWM3P.yKut9RdyCvZ().HasValue || fyQvvWWWM3P.yKut9RdyCvZ() != _003C_003Ec__DisplayClass109_.syP20DIOMKF.Button)
			{
				bool flag = fyQvvWWWM3P?.v1FtZoD4OuB(MouseButtons.Left) ?? false;
				if (_003C_003Ec__DisplayClass109_.syP20DIOMKF.IsFromQuicker)
				{
					break;
				}
				while (true)
				{
					if (!dB6vvgTocvt.IsEnabled || (_003C_003Ec__DisplayClass109_.syP20DIOMKF.IsInjected && _003C_003Ec__DisplayClass109_.syP20DIOMKF.IsFromGestureSoftware))
					{
						return;
					}
					if (_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button == MouseButtons.Left)
					{
						RV5vLF5yh1l(false);
						GrZJHjXh9DrUnn7CH6P.fojtKR5YnP0();
						keyboardState?.SyncKeyStates();
					}
					V8yvLDRddBD(true);
					object xEk20dtWT3Z;
					if (AppState.HHxtaMaoqJr().GesturePlaybackUnknownGesture)
					{
						GestureWindow gestureWindow = v45vvBRpIiS;
						if (gestureWindow != null && gestureWindow.IsWorking && _003C_003Ec__DisplayClass109_.syP20DIOMKF.Button == MouseButtons.Right)
						{
							xEk20dtWT3Z = fyQvvWWWM3P.HM2tZ4X1XVi();
							goto IL_015d;
						}
					}
					xEk20dtWT3Z = null;
					goto IL_015d;
					IL_015d:
					_003C_003Ec__DisplayClass109_.XEk20dtWT3Z = (IList<System.Windows.Point>)xEk20dtWT3Z;
					MouseButtons? mouseButtons = fyQvvWWWM3P?.SqUt9PBisZY();
					MouseButtons button = _003C_003Ec__DisplayClass109_.syP20DIOMKF.Button;
					int num = 1;
					if (!IhLjTcFCjA6MRipDUS4j())
					{
						num = num2;
					}
					while (true)
					{
						switch (num)
						{
						case 2:
						{
							GestureWindow gestureWindow2 = v45vvBRpIiS;
							if (gestureWindow2 != null && gestureWindow2.IsWorking)
							{
								AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass109_.Cie20nC4ylw);
							}
							goto IL_01cf;
						}
						case 1:
						{
							bool num3 = mouseButtons == button;
							if (W6ovgjdynSy(_003C_003Ec__DisplayClass109_.syP20DIOMKF, mousePosition))
							{
								_003C_003Ec__DisplayClass109_.syP20DIOMKF.Handled = true;
								fyQvvWWWM3P?.OSrtZMXZ2c0(_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button);
								if (!fyQvvWWWM3P.KIQtZjjGceP())
								{
									fyQvvWWWM3P.nNvt9wrNn9A();
									fyQvvWWWM3P.KPhtZmUAjus();
								}
							}
							else if (!_003C_003Ec__DisplayClass109_.syP20DIOMKF.IsButtonDown && !Control.MouseButtons.HasFlag(_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button) && fyQvvWWWM3P.v1FtZoD4OuB(_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button))
							{
								_003C_003Ec__DisplayClass109_.syP20DIOMKF.Handled = true;
								fyQvvWWWM3P.OSrtZMXZ2c0(_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button);
							}
							if (num3)
							{
								num = 0;
								if (!IhLjTcFCjA6MRipDUS4j())
								{
									continue;
								}
								goto case 2;
							}
							goto IL_01cf;
						}
						case 4:
							break;
						case 3:
							goto end_IL_030f;
						default:
							{
								if (!flag)
								{
									AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass109_.hJT204UCwrv);
									fyQvvWWWM3P.VC6tZptEHJM();
									DirectCaptureWindow eXavvpoOBID = EXavvpoOBID;
									if (eXavvpoOBID != null && eXavvpoOBID.IsVisible)
									{
										EXavvpoOBID.Cancel();
									}
								}
								else
								{
									_003C_003Ec__DisplayClass109_.syP20DIOMKF.Handled = true;
								}
								return;
							}
							IL_01cf:
							if (_003C_003Ec__DisplayClass109_.syP20DIOMKF.Button == MouseButtons.Left)
							{
								num = 0;
								if (COIxMyFCeTKEhc49RX1F == null)
								{
									continue;
								}
								goto default;
							}
							return;
						}
						break;
					}
					continue;
					end_IL_030f:
					break;
				}
				continue;
			}
			Task.Run((Func<Task>)_003C_003Ec__DisplayClass109_.FLa20jOJtJO);
			_003C_003Ec__DisplayClass109_.syP20DIOMKF.Handled = true;
			break;
		}
	}

	public void kNjvgQBvAoG()
	{
		fyQvvWWWM3P.gEftZllp5ei(true);
		fyQvvWWWM3P.HTptZffK9K5(true);
		XFfvvJeKXVt?.Stop();
	}

	private bool W6ovgjdynSy(AppMouseEventArgs appMouseEventArgs_0, System.Drawing.Point point_1)
	{
		int num = 2;
		bool flag = default(bool);
		Quicker.Domain.PowerMouse.MouseAction mouseAction = default(Quicker.Domain.PowerMouse.MouseAction);
		while (true)
		{
			_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
			int num2 = 1;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass111_.vtU20TLdyJ8 = this;
					_003C_003Ec__DisplayClass111_.P0v20MrrApa = appMouseEventArgs_0;
					if (fyQvvWWWM3P.nNvt9wrNn9A() != null && fyQvvWWWM3P.v1FtZoD4OuB(_003C_003Ec__DisplayClass111_.P0v20MrrApa.Button))
					{
						if (fyQvvWWWM3P.MouseAction == null && !fyQvvWWWM3P.PGptZUwoapr() && !fyQvvWWWM3P.egCtZ3dlevS())
						{
							flag = true;
							mouseAction = j5mvLLVTcpv(_003C_003Ec__DisplayClass111_.P0v20MrrApa.Button);
							num2 = 0;
							if (IhLjTcFCjA6MRipDUS4j())
							{
								continue;
							}
							goto default;
						}
						if (fyQvvWWWM3P.MouseAction != null)
						{
							Quicker.Domain.PowerMouse.MouseAction mouseAction2 = fyQvvWWWM3P.MouseAction;
							PointTargetInfo pointTargetInfo = fyQvvWWWM3P.nNvt9wrNn9A();
							if (_003C_003Ec__DisplayClass111_.P0v20MrrApa.Button == mouseAction2.MouseButton)
							{
								Diovg9R8llC(mouseAction2, point_1, pointTargetInfo.Point, false);
							}
						}
						goto IL_0153;
					}
					return false;
				case 2:
					break;
				default:
					{
						if (mouseAction != null)
						{
							FPlvgiqIvSK(mouseAction);
							flag = false;
						}
						if (flag)
						{
							Task.Run((Action)_003C_003Ec__DisplayClass111_.nxM20oZp20d);
						}
						goto IL_0153;
					}
					IL_0153:
					return true;
				}
				break;
			}
		}
	}

	private void mjMvgnimIxK(object sender, AppMouseEventArgs e)
	{
		AppState.jqKtaRtl9EB(false);
		if (!dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		zAwvvCZiXYj?.K3XvSheneoZ();
		if (e.IsFromQuicker)
		{
			return;
		}
		if (fyQvvWWWM3P.KIQtZjjGceP())
		{
			DispatcherTimer xFfvvJeKXVt = XFfvvJeKXVt;
			if (xFfvvJeKXVt == null)
			{
				if (IhLjTcFCjA6MRipDUS4j())
				{
					switch (0)
					{
					}
				}
			}
			else if (xFfvvJeKXVt.IsEnabled && (Math.Abs(e.X - fyQvvWWWM3P.StartPoint.X) > 3 || Math.Abs(e.Y - fyQvvWWWM3P.StartPoint.Y) > 3))
			{
				XFfvvJeKXVt?.Stop();
			}
		}
		qDDvvX3eLl0.Set();
	}

	private void wMIvg4nv8Cd(PointTargetInfo pointTargetInfo_0)
	{
		_003C_003Ec__DisplayClass115_0 _003C_003Ec__DisplayClass115_ = new _003C_003Ec__DisplayClass115_0();
		_003C_003Ec__DisplayClass115_.oo920FrY6ZR = this;
		int num2 = default(int);
		MouseButtons? mouseButtons = default(MouseButtons?);
		while (true)
		{
			_003C_003Ec__DisplayClass115_.Kl020UOraLq = NativeMethods.GetMousePosition();
			if (_003C_003Ec__DisplayClass115_.Kl020UOraLq == tF1vv6GrnWV)
			{
				break;
			}
			tF1vv6GrnWV = _003C_003Ec__DisplayClass115_.Kl020UOraLq;
			int num = 0;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
				{
					bool flag = false;
					CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
					if (circleMenuWindow != null && circleMenuWindow.IsWorking)
					{
						AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass115_.paj20Au062J);
					}
					else
					{
						DirectCaptureWindow eXavvpoOBID = EXavvpoOBID;
						if (eXavvpoOBID == null || !eXavvpoOBID.IsVisible)
						{
							flag = fyQvvWWWM3P.qjetZnem4NC(_003C_003Ec__DisplayClass115_.Kl020UOraLq);
						}
						else
						{
							EXavvpoOBID.OnMouseMoveFromHook(_003C_003Ec__DisplayClass115_.Kl020UOraLq);
						}
					}
					if (!((v45vvBRpIiS?.IsWorking ?? false) && flag) || fyQvvWWWM3P.MouseAction == null)
					{
						if (pointTargetInfo_0 != null)
						{
							if (XFfvvJeKXVt.IsEnabled && AppHelper.IsFarThan(pointTargetInfo_0.Point, _003C_003Ec__DisplayClass115_.Kl020UOraLq, 3))
							{
								XFfvvJeKXVt.Stop();
							}
							if (fyQvvWWWM3P.MouseAction == null && AppHelper.IsFarThan(pointTargetInfo_0.Point, _003C_003Ec__DisplayClass115_.Kl020UOraLq, SL0vvwD6HYI.CpItmVISR7P().MoveTriggerDistance))
							{
								XFfvvJeKXVt.Stop();
								Quicker.Domain.PowerMouse.MouseAction mouseAction = uWkvLvwNj9N();
								if (mouseAction == null)
								{
									if (fyQvvWWWM3P.BWKtZ5W0fAU() == 1)
									{
										mouseButtons = fyQvvWWWM3P.tNotZDBTnmu();
										num = 1;
										if (IhLjTcFCjA6MRipDUS4j())
										{
											continue;
										}
										goto case 1;
									}
									return;
								}
								fyQvvWWWM3P.MouseAction = mouseAction;
								FPlvgiqIvSK(mouseAction);
								return;
							}
							return;
						}
						return;
					}
					AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass115_.FZ220OjMUKT);
					return;
				}
				case 2:
					break;
				case 1:
					if (mouseButtons.HasValue)
					{
						fyQvvWWWM3P.OSrtZMXZ2c0(mouseButtons.Value);
						thjvLq0npS4(mouseButtons.Value);
						goto case 3;
					}
					return;
				case 3:
					if (!fyQvvWWWM3P.KIQtZjjGceP())
					{
						fyQvvWWWM3P.KPhtZmUAjus();
					}
					return;
				}
				break;
			}
		}
	}

	private void zk9vg5W6Gtb()
	{
		while (true)
		{
			qDDvvX3eLl0.WaitOne();
			AppState.LastMouseMoveTicks = AppHelper.fLiLTj0x4QY();
			if (!fyQvvWWWM3P.KIQtZjjGceP())
			{
				HsTvgVhN5ue();
				if (Control.MouseButtons == MouseButtons.None && (BYhvvkjpWF1.HasData() || AppState.HHxtaMaoqJr().OpenPopupWithCircle))
				{
					rNhvgDojDlE();
				}
				continue;
			}
			PointTargetInfo pointTargetInfo = fyQvvWWWM3P.nNvt9wrNn9A();
			if (pointTargetInfo == null)
			{
				continue;
			}
			wMIvg4nv8Cd(pointTargetInfo);
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				switch (0)
				{
				}
			}
		}
	}

	private void rNhvgDojDlE()
	{
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		if (!(mousePosition == tF1vv6GrnWV))
		{
			tF1vv6GrnWV = mousePosition;
			if (!Y2cvgdXgXh5(mousePosition) && SL0vvwD6HYI.CpItmVISR7P().OpenPopupWithCircle && Control.MouseButtons == MouseButtons.None)
			{
				PYOvgoTewmi(mousePosition);
			}
		}
	}

	private bool Y2cvgdXgXh5(System.Drawing.Point point_1)
	{
		_003C_003Ec__DisplayClass119_0 _003C_003Ec__DisplayClass119_ = new _003C_003Ec__DisplayClass119_0();
		_003C_003Ec__DisplayClass119_.UvZ20iM1Yyj = point_1;
		_003C_003Ec__DisplayClass119_.H172033ohnQ = this;
		Screen screen = Screen.AllScreens.FirstOrDefault(_003C_003Ec__DisplayClass119_.bgH20lp4seP);
		if (screen != null)
		{
			using IEnumerator<Quicker.Domain.PowerMouse.MouseAction> enumerator = BYhvvkjpWF1.GetEnumerator();
			int num2 = default(int);
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass119_1 _003C_003Ec__DisplayClass119_2 = new _003C_003Ec__DisplayClass119_1();
				_003C_003Ec__DisplayClass119_2.km32CwEMbXb = _003C_003Ec__DisplayClass119_;
				_003C_003Ec__DisplayClass119_2.vGa20zedqlg = enumerator.Current;
				int num = 1;
				if (COIxMyFCeTKEhc49RX1F == null)
				{
					goto IL_0078;
				}
				goto IL_011d;
				IL_0178:
				return true;
				IL_011d:
				switch (num)
				{
				case 1:
					break;
				default:
					goto IL_013a;
				}
				goto IL_0078;
				IL_013a:
				N83vvmDhU7F.Debounce(AppState.DataService.CpItmVISR7P().CornerActionDelay, _003C_003Ec__DisplayClass119_2.N2p20fUADA0);
				goto IL_0178;
				IL_0078:
				if (!lQkvL0dclWA(_003C_003Ec__DisplayClass119_2.vGa20zedqlg, screen, _003C_003Ec__DisplayClass119_2.km32CwEMbXb.UvZ20iM1Yyj))
				{
					continue;
				}
				if (!_003C_003Ec__DisplayClass119_2.vGa20zedqlg.LimitOnPrimaryScreen || screen.Primary)
				{
					if (!z0wvLCcCybg(_003C_003Ec__DisplayClass119_2.vGa20zedqlg) || !_003C_003Ec__DisplayClass119_2.vGa20zedqlg.IsEnabled || JELvLE2bGVd(_003C_003Ec__DisplayClass119_2.vGa20zedqlg, AppState.CurrentExeName, AppState.CurrentExePath) || uNPvL2Ykd28(_003C_003Ec__DisplayClass119_2.vGa20zedqlg, screen))
					{
						continue;
					}
					if (AppState.DataService.CpItmVISR7P().CornerActionDelay > 0)
					{
						num = 0;
						if (!IhLjTcFCjA6MRipDUS4j())
						{
							num = num2;
						}
						goto IL_011d;
					}
					FPlvgiqIvSK(_003C_003Ec__DisplayClass119_2.vGa20zedqlg);
					goto IL_0178;
				}
				return false;
			}
		}
		return false;
	}

	private void PYOvgoTewmi(System.Drawing.Point point_1)
	{
		if (SL0vvwD6HYI.CpItmVISR7P().OpenPopupWithCircle && CircleDetector.CheckMouseMove(point_1) && !BWivLz0pfuj.IsVisible)
		{
			AppHelper.RunOnUiThread(false, pCxvLpPVrcy);
		}
	}

	private void S89vgTBVTyC(object sender, AppMouseEventArgs e)
	{
		_003C_003Ec__DisplayClass122_0 _003C_003Ec__DisplayClass122_ = new _003C_003Ec__DisplayClass122_0();
		_003C_003Ec__DisplayClass122_.h0m2C2SbW6D = this;
		AppState.jqKtaRtl9EB(false);
		_003C_003Ec__DisplayClass122_.Oo32CuwtXO9 = e.Delta;
		int num2;
		if (!fyQvvWWWM3P.KIQtZjjGceP() && e.Delta > -10 && e.Delta < 10)
		{
			long num = AppHelper.fLiLTj0x4QY();
			if (num - SWYvvKxcL13 < 150L)
			{
				return;
			}
			SWYvvKxcL13 = num;
			num2 = 1;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				goto IL_016a;
			}
			goto IL_016e;
		}
		goto IL_0181;
		IL_016a:
		int num3 = default(int);
		num2 = num3;
		goto IL_016e;
		IL_016e:
		switch (num2)
		{
		case 2:
			break;
		default:
			return;
		case 1:
			goto IL_0181;
		case 0:
			return;
		}
		goto IL_0148;
		IL_0181:
		if (e.IsFromQuicker || !dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		V8yvLDRddBD(true);
		if (!caQvgUQySEn(e))
		{
			GestureWindow gestureWindow = v45vvBRpIiS;
			if (gestureWindow == null || !gestureWindow.IsWorking || !v45vvBRpIiS.OnKeyDown(KeyboardHelper.GetMouseScrollKeyCode(true, e.Delta)))
			{
				CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
				if (circleMenuWindow == null || !circleMenuWindow.IsWorking || !eVuvLfVCnT6.JMXL9glYsxj(KeyboardHelper.GetMouseScrollKeyCode(true, e.Delta)))
				{
					if (!flbvgFg0SxJ(e))
					{
						UserSettings userSettings = AppState.HHxtaMaoqJr();
						if (userSettings != null && userSettings.EnableReverseVScroll)
						{
							e.Handled = true;
							num2 = 2;
							if (!IhLjTcFCjA6MRipDUS4j())
							{
								goto IL_0148;
							}
							goto IL_016e;
						}
						return;
					}
					e.Handled = true;
					DispatcherTimer xFfvvJeKXVt = XFfvvJeKXVt;
					if (xFfvvJeKXVt != null && xFfvvJeKXVt.IsEnabled)
					{
						XFfvvJeKXVt?.Stop();
					}
					return;
				}
				e.Handled = true;
				return;
			}
			e.Handled = true;
			return;
		}
		e.Handled = true;
		return;
		IL_0148:
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass122_.mk02CS8Lpal);
		num2 = 0;
		if (!IhLjTcFCjA6MRipDUS4j())
		{
			goto IL_016a;
		}
		goto IL_016e;
	}

	private void wd4vgMWpkyx(object sender, AppMouseEventArgs e)
	{
		AppState.jqKtaRtl9EB(false);
		if (e.IsFromQuicker || !dB6vvgTocvt.IsEnabled)
		{
			return;
		}
		V8yvLDRddBD(true);
		GestureWindow gestureWindow = v45vvBRpIiS;
		if (gestureWindow != null && gestureWindow.IsWorking && v45vvBRpIiS.OnKeyDown(KeyboardHelper.GetMouseScrollKeyCode(false, e.Delta)))
		{
			e.Handled = true;
			return;
		}
		CircleMenuWindow circleMenuWindow = eVuvLfVCnT6;
		int num;
		if (circleMenuWindow != null && circleMenuWindow.IsWorking && eVuvLfVCnT6.JMXL9glYsxj(KeyboardHelper.GetMouseScrollKeyCode(false, e.Delta)))
		{
			e.Handled = true;
			num = 0;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				return;
			}
		}
		else
		{
			if (!ReGvgAmoTCI(e))
			{
				return;
			}
			e.Handled = true;
			num = 1;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
		{
			DispatcherTimer xFfvvJeKXVt = XFfvvJeKXVt;
			if (xFfvvJeKXVt != null && xFfvvJeKXVt.IsEnabled)
			{
				XFfvvJeKXVt?.Stop();
			}
			break;
		}
		}
	}

	private bool ReGvgAmoTCI(AppMouseEventArgs appMouseEventArgs_0)
	{
		int num = 2;
		while (true)
		{
			_003C_003Ec__DisplayClass124_0 _003C_003Ec__DisplayClass124_ = new _003C_003Ec__DisplayClass124_0();
			int num2 = 1;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_0020;
			}
			goto IL_0024;
			IL_0024:
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto IL_000b;
				case 2:
					break;
				default:
				{
					System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
					_003C_003Ec__DisplayClass124_.pbt2CJa6I5D = ((appMouseEventArgs_0.Delta > 0) ? MouseActionType.WheelRight : MouseActionType.WheelLeft);
					Quicker.Domain.PowerMouse.MouseAction[] array = jGavgIpP06v().Where(_003C_003Ec__DisplayClass124_.RZr2CNWdgUr).ToArray();
					if (array.Any())
					{
						Screen screen_ = Df7vgOJUMaE(mousePosition);
						PointTargetInfo pointTargetInfo = AppHelper.GetPointTargetInfo(mousePosition);
						Quicker.Domain.PowerMouse.MouseAction[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							_003C_003Ec__DisplayClass124_1 _003C_003Ec__DisplayClass124_2 = new _003C_003Ec__DisplayClass124_1();
							_003C_003Ec__DisplayClass124_2.Qn22CEJT7a8 = _003C_003Ec__DisplayClass124_;
							_003C_003Ec__DisplayClass124_2.b6n2CPN8nAQ = array2[i];
							if (wmjvLySs6cd(_003C_003Ec__DisplayClass124_2.b6n2CPN8nAQ, pointTargetInfo, screen_))
							{
								oj1vvxof2tU.DoEvent(_003C_003Ec__DisplayClass124_2.NEb2CC0YUfL, 150);
								if (fyQvvWWWM3P.KIQtZjjGceP())
								{
									fyQvvWWWM3P.MouseAction = _003C_003Ec__DisplayClass124_2.b6n2CPN8nAQ;
								}
								return true;
							}
						}
					}
					return false;
				}
				}
				break;
				IL_000b:
				_003C_003Ec__DisplayClass124_.LuW2C09nB2t = this;
				num2 = 0;
				if (COIxMyFCeTKEhc49RX1F == null)
				{
					continue;
				}
				goto IL_0020;
			}
			continue;
			IL_0020:
			num2 = num;
			goto IL_0024;
		}
	}

	internal static Screen Df7vgOJUMaE(System.Drawing.Point point_1)
	{
		Screen[] allScreens = Screen.AllScreens;
		for (int i = 0; i < allScreens.Length; i++)
		{
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				switch (0)
				{
				}
			}
			Screen screen = allScreens[i];
			if (screen.Bounds.Contains(point_1))
			{
				return screen;
			}
		}
		return Screen.FromPoint(point_1);
	}

	private bool flbvgFg0SxJ(AppMouseEventArgs appMouseEventArgs_0)
	{
		_003C_003Ec__DisplayClass126_0 _003C_003Ec__DisplayClass126_ = new _003C_003Ec__DisplayClass126_0();
		_003C_003Ec__DisplayClass126_.oGC2CaL85r2 = this;
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		_003C_003Ec__DisplayClass126_.kTt2C8NE1dD = ((appMouseEventArgs_0.Delta > 0) ? MouseActionType.WheelUp : MouseActionType.WheelDown);
		int num = 1;
		if (!IhLjTcFCjA6MRipDUS4j())
		{
			int num2 = default(int);
			num = num2;
		}
		Quicker.Domain.PowerMouse.MouseAction[] array = default(Quicker.Domain.PowerMouse.MouseAction[]);
		Screen screen_ = default(Screen);
		PointTargetInfo pointTargetInfo = default(PointTargetInfo);
		while (true)
		{
			switch (num)
			{
			case 1:
				array = jGavgIpP06v().Where(_003C_003Ec__DisplayClass126_.Q3a2CyljDYo).ToArray();
				if (!array.Any())
				{
					break;
				}
				screen_ = Df7vgOJUMaE(mousePosition);
				pointTargetInfo = AppHelper.GetPointTargetInfo(mousePosition);
				num = 0;
				if (COIxMyFCeTKEhc49RX1F == null)
				{
					continue;
				}
				goto default;
			default:
			{
				Quicker.Domain.PowerMouse.MouseAction[] array2 = array;
				foreach (Quicker.Domain.PowerMouse.MouseAction mouseAction in array2)
				{
					if (wmjvLySs6cd(mouseAction, pointTargetInfo, screen_))
					{
						FPlvgiqIvSK(mouseAction, true, 3);
						if (fyQvvWWWM3P.KIQtZjjGceP())
						{
							fyQvvWWWM3P.MouseAction = mouseAction;
						}
						return true;
					}
				}
				break;
			}
			}
			break;
		}
		return false;
	}

	private bool caQvgUQySEn(System.Windows.Forms.MouseEventArgs mouseEventArgs_0)
	{
		_003C_003Ec__DisplayClass127_0 _003C_003Ec__DisplayClass127_ = new _003C_003Ec__DisplayClass127_0();
		_003C_003Ec__DisplayClass127_.Ccy2CRZqTaC = this;
		ModifierKeys modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
		_003C_003Ec__DisplayClass127_.kVP2CqAL5uP = mouseEventArgs_0.Delta;
		UserSettings userSettings = AppState.HHxtaMaoqJr();
		if (userSettings != null && userSettings.EnableReverseVScroll)
		{
			goto IL_00c1;
		}
		goto IL_00d1;
		IL_012d:
		return true;
		IL_00d1:
		if (BWivLz0pfuj.IsVisible && BWivLz0pfuj.IsMouseOver && modifierKeys == ModifierKeys.None)
		{
			if (!BWivLz0pfuj.GlobalBtnCanvas.IsMouseOver)
			{
				if (!(DateTime.Now < BWivLz0pfuj.PopupWindowShowTime.AddMilliseconds(200.0)))
				{
					if (_003C_003Ec__DisplayClass127_.kVP2CqAL5uP > 0)
					{
						int num = 1;
						if (COIxMyFCeTKEhc49RX1F != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						case 2:
							break;
						case 1:
							goto IL_010f;
						default:
							goto IL_011f;
						}
						goto IL_00c1;
					}
					goto IL_011f;
				}
				return true;
			}
			if (_003C_003Ec__DisplayClass127_.kVP2CqAL5uP > 0)
			{
				jYVvvvEEUEj.RequestChangePage(this, true, true);
			}
			else
			{
				jYVvvvEEUEj.RequestChangePage(this, true, false);
			}
			goto IL_012d;
		}
		TextFloatPanelWindow floatWindow = lxZvvSlNdBX.FloatWindow;
		if (floatWindow != null && floatWindow.IsVisible)
		{
			TextFloatPanelWindow floatWindow2 = lxZvvSlNdBX.FloatWindow;
			if (floatWindow2 != null && floatWindow2.IsMouseOver && modifierKeys == ModifierKeys.None)
			{
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass127_.CE52C7merSX);
				return true;
			}
		}
		return false;
		IL_010f:
		jYVvvvEEUEj.RequestChangePage(this, false, true);
		goto IL_012d;
		IL_011f:
		jYVvvvEEUEj.RequestChangePage(this, false, false);
		goto IL_012d;
		IL_00c1:
		_003C_003Ec__DisplayClass127_.kVP2CqAL5uP *= -1;
		goto IL_00d1;
	}

	private void MHEvgluYmgC(PointTargetInfo pointTargetInfo_0)
	{
		if (BWivLz0pfuj.IsVisible && !pointTargetInfo_0.IsOnNonTriggerWindow && !pointTargetInfo_0.IsOnMainWindow && (!AppState.HasOpenContextMenu || (AppState.HasOpenContextMenu && !pointTargetInfo_0.IsOnQuicker)))
		{
			BWivLz0pfuj.RequestHide();
		}
	}

	private void FPlvgiqIvSK(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, bool bool_7 = false, int int_1 = 0)
	{
		_003C_003Ec__DisplayClass131_0 _003C_003Ec__DisplayClass131_ = new _003C_003Ec__DisplayClass131_0();
		_003C_003Ec__DisplayClass131_.nFc2CY3uP8u = mouseAction_0;
		_003C_003Ec__DisplayClass131_.hwO2CIAByJE = this;
		_003C_003Ec__DisplayClass131_.NAD2CkGV4Lf = bool_7;
		_003C_003Ec__DisplayClass131_.AnO2CGiXw1d = int_1;
		fyQvvWWWM3P.HTptZffK9K5(true);
		int num = 0;
		if (COIxMyFCeTKEhc49RX1F != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		_003C_003Ec__DisplayClass131_.ejW2CWmXWhR = fyQvvWWWM3P.nNvt9wrNn9A();
		if (_003C_003Ec__DisplayClass131_.ejW2CWmXWhR == null)
		{
			_003C_003Ec__DisplayClass131_.ejW2CWmXWhR = AppHelper.GetPointTargetInfo(null);
		}
		if (_003C_003Ec__DisplayClass131_.nFc2CY3uP8u.ActivatePointingWindow)
		{
			RR1vg3fMESk(_003C_003Ec__DisplayClass131_.ejW2CWmXWhR);
		}
		Task.Run((Action)_003C_003Ec__DisplayClass131_.IEu2Cc3HQ1Y);
	}

	private static void RR1vg3fMESk(PointTargetInfo pointTargetInfo_0)
	{
		IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
		IntPtr rootWindow = NativeMethods.GetRootWindow(pointTargetInfo_0.HWnd);
		if (rootWindow != foregroundWindow && pointTargetInfo_0.Pid != NativeMethods.GetWindowProcessId(foregroundWindow))
		{
			NativeMethods.SetForegroundWindow(rootWindow);
		}
	}

	private void ln5vgfhpvA7(PointTargetInfo pointTargetInfo_0)
	{
		if (pointTargetInfo_0 == null)
		{
			pointTargetInfo_0 = AppHelper.GetPointTargetInfo(null);
		}
		if (EXavvpoOBID == null)
		{
			if (IhLjTcFCjA6MRipDUS4j())
			{
				switch (0)
				{
				}
			}
			EXavvpoOBID = new DirectCaptureWindow();
			EXavvpoOBID.Closed += PWYvLBna2aJ;
		}
		IHNRIiikxBwJdYmHpM3.oc0vvlUGaGr(EXavvpoOBID.HWnd, pointTargetInfo_0.Point.X - 1, pointTargetInfo_0.Point.Y - 1, true);
		EXavvpoOBID.StartPoint = pointTargetInfo_0.Point;
		EXavvpoOBID.Show();
	}

	private bool N3AvgzglrJW(PointTargetInfo pointTargetInfo_0, string string_0 = null)
	{
        ExeSettings exeSettings = default;
        ExeSettings exeSettings2 = default;
		_003C_003Ec__DisplayClass136_0 _003C_003Ec__DisplayClass136_ = new _003C_003Ec__DisplayClass136_0();
		_003C_003Ec__DisplayClass136_.kBw2CKpwkfR = this;
		int num;
		if (pointTargetInfo_0 == null)
		{
			num = 0;
			if (COIxMyFCeTKEhc49RX1F == null)
			{
				goto IL_014d;
			}
			goto IL_0166;
		}
		goto IL_0184;
		IL_014d:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				v45vvBRpIiS.Show();
				v45vvBRpIiS.Closed += _003C_003Ec__DisplayClass136_.OUy2CX2c085;
				num = 4;
				if (!IhLjTcFCjA6MRipDUS4j())
				{
					num = num2;
				}
				continue;
			case 1:
				break;
			default:
				goto IL_0166;
			case 2:
				goto IL_01bc;
			case 4:
				goto IL_01be;
			}
			break;
		}
		goto IL_0138;
		IL_0166:
		pointTargetInfo_0 = AppHelper.GetPointTargetInfo(null);
		goto IL_0184;
		IL_0184:
		if (!AppState.HHxtaMaoqJr().ActivateGestureStartPositionWindow)
		{
			pointTargetInfo_0.Exe = AppState.CurrentExeName;
		}
		else
		{
			fPDvLWi28bU(pointTargetInfo_0);
		}
		exeSettings = SL0vvwD6HYI.yQWt6ownR4Z("_global", true);
		exeSettings2 = null;
		if (!string.IsNullOrEmpty(string_0))
		{
			if ((exeSettings2 = AppState.DataService.yQWt6ownR4Z(string_0)) == null)
			{
				exeSettings2 = exeSettings;
				AppHelper.ShowWarning("未找到场景：" + string_0 + "，请检查设置。");
			}
		}
		else
		{
			bool flag;
			(flag, exeSettings2) = RwAvtTOBjsv(pointTargetInfo_0);
			if (!flag)
			{
				goto IL_01bc;
			}
			if (exeSettings2 == null && exeSettings.DisableGesture)
			{
				return false;
			}
			if (exeSettings2 != null && exeSettings2.DisableGesture)
			{
				return false;
			}
		}
		{
			goto IL_00d8;
		}
		num = 1;
		if (IhLjTcFCjA6MRipDUS4j())
		{
			goto IL_0138;
		}
		goto IL_014d;
		IL_01bc:
		return false;
		IL_0228:
		object obj;
		_003C_003Ec__DisplayClass136_.jUC2CxWXQrV = (IDictionary<string, GestureAction>)obj;
		IList<GestureAction> list = exeSettings2?.GestureActions;
		if (list.HasData())
		{
			foreach (GestureAction item in list)
			{
				_003C_003Ec__DisplayClass136_.jUC2CxWXQrV[item.GestureId] = item;
			}
		}
		IList<Gesture> ilist_ = SL0vvwD6HYI.Y0Etm2L8Pto().Where(_003C_003Ec__DisplayClass136_.lLl2CmUmHlP).ToList();
		if (fyQvvWWWM3P.Points.Count == 0)
		{
			fyQvvWWWM3P.Points.Add(new System.Windows.Point(pointTargetInfo_0.Point.X, pointTargetInfo_0.Point.Y));
		}
		bool flag2;
		v45vvBRpIiS.hQlL7mZB1sL(fyQvvWWWM3P.HM2tZ4X1XVi(), ilist_, _003C_003Ec__DisplayClass136_.jUC2CxWXQrV, fyQvvWWWM3P, flag2, pointTargetInfo_0, exeSettings.GestureActions);
		if (flag2)
		{
			v45vvBRpIiS.BXZL76quEQh();
		}
		return true;
		IL_00d8:
		flag2 = false;
		if (v45vvBRpIiS == null)
		{
			v45vvBRpIiS = new GestureWindow();
			num = 3;
			if (IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_014d;
			}
			goto IL_01bc;
		}
		goto IL_01c1;
		IL_01be:
		flag2 = true;
		goto IL_01c1;
		IL_0138:
		goto IL_00d8;
		IL_01c1:
		v45vvBRpIiS.BXZL76quEQh();
		IList<GestureAction> gestureActions = exeSettings.GestureActions;
		if (gestureActions == null)
		{
			obj = null;
		}
		else
		{
			obj = gestureActions.ToDictionary(_003C_003Ec.eFk20IRqg3l ?? (_003C_003Ec.eFk20IRqg3l = _003C_003Ec.Arm20RCQ7us.GpZ20802G8o), _003C_003Ec.Vlx20WHxD4Q ?? (_003C_003Ec.Vlx20WHxD4Q = _003C_003Ec.Arm20RCQ7us.sOm20aXC8yA));
			if (obj != null)
			{
				goto IL_0228;
			}
		}
		obj = new Dictionary<string, GestureAction>();
		goto IL_0228;
	}

	public void HqXvLww9gVP()
	{
		v45vvBRpIiS?.hrfL7KafprL();
	}

	private Quicker.Domain.PowerMouse.MouseAction I0KvLtW1Qtj()
	{
		return IKMvLgIaAif(MouseActionType.LongPress);
	}

	private Quicker.Domain.PowerMouse.MouseAction IKMvLgIaAif(MouseActionType mouseActionType_0)
	{
		foreach (Quicker.Domain.PowerMouse.MouseAction item in jGavgIpP06v())
		{
			if (item.MouseButton.HasValue && item.MouseActionType == mouseActionType_0 && fyQvvWWWM3P.v1FtZoD4OuB(item.MouseButton.Value) && z0wvLCcCybg(item) && wmjvLySs6cd(item, fyQvvWWWM3P.nNvt9wrNn9A(), fyQvvWWWM3P.D4Kt9L8hbBH()))
			{
				return item;
			}
		}
		return null;
	}

	private Quicker.Domain.PowerMouse.MouseAction j5mvLLVTcpv(MouseButtons mouseButtons_0)
	{
		foreach (Quicker.Domain.PowerMouse.MouseAction item in jGavgIpP06v())
		{
			if (COIxMyFCeTKEhc49RX1F == null)
			{
				switch (0)
				{
				}
			}
			if (item.MouseActionType == MouseActionType.Click && item.MouseButton == mouseButtons_0 && fyQvvWWWM3P.v1FtZoD4OuB(item.MouseButton.Value) && z0wvLCcCybg(item) && wmjvLySs6cd(item, fyQvvWWWM3P.nNvt9wrNn9A(), fyQvvWWWM3P.D4Kt9L8hbBH()))
			{
				return item;
			}
		}
		return null;
	}

	private Quicker.Domain.PowerMouse.MouseAction uWkvLvwNj9N()
	{
		foreach (Quicker.Domain.PowerMouse.MouseAction item in jGavgIpP06v())
		{
			if (vTcvLSiJ3WY(item))
			{
				return item;
			}
		}
		return null;
	}

	private bool vTcvLSiJ3WY(Quicker.Domain.PowerMouse.MouseAction mouseAction_0)
	{
		MouseButtons value;
		int? controlKey;
		int num;
		if (mouseAction_0.MouseActionType == MouseActionType.Drag && mouseAction_0.MouseButton.HasValue)
		{
			MouseButtons? mouseButton = mouseAction_0.MouseButton;
			MouseButtons mouseButtons = MouseButtons.None;
			if (!((mouseButton.GetValueOrDefault() == MouseButtons.None) & mouseButton.HasValue))
			{
				value = mouseAction_0.MouseButton.Value;
				if (!fyQvvWWWM3P.v1FtZoD4OuB(value))
				{
					return false;
				}
				controlKey = mouseAction_0.ControlKey;
				num = 0;
				if (IhLjTcFCjA6MRipDUS4j())
				{
					goto IL_0072;
				}
				goto IL_008a;
			}
		}
		return false;
		IL_009e:
		if (mouseAction_0.ControlKey > 6)
		{
			goto IL_0112;
		}
		if (fyQvvWWWM3P.SqUt9PBisZY() != KxJvLa4e0ud((VirtualKeyCode)mouseAction_0.ControlKey.Value) || fyQvvWWWM3P.SqUt9PBisZY() == value)
		{
			return false;
		}
		goto IL_0138;
		IL_0112:
		if (!z0wvLCcCybg(mouseAction_0))
		{
			return false;
		}
		goto IL_0138;
		IL_0072:
		if (controlKey.HasValue)
		{
			num = 1;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_008a;
			}
			goto IL_009e;
		}
		if (!fyQvvWWWM3P.syNtZTClr27(value))
		{
			return false;
		}
		if (!z0wvLCcCybg(mouseAction_0))
		{
			return false;
		}
		goto IL_0138;
		IL_0138:
		if (wmjvLySs6cd(mouseAction_0, fyQvvWWWM3P.nNvt9wrNn9A(), fyQvvWWWM3P.D4Kt9L8hbBH()))
		{
			return true;
		}
		return false;
		IL_008a:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_009e;
		default:
			goto IL_0112;
		}
		goto IL_0072;
	}

	private bool uNPvL2Ykd28(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, Screen screen_0)
	{
		if (!mouseAction_0.DisableInFullScreen)
		{
			return false;
		}
		return BlackListMgr.IsForegroundFullScreen(NativeMethods.GetForegroundWindow(), AppState.CurrentExeName);
	}

	private bool gcvvLuQEt4X(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, Screen screen_0, PointTargetInfo pointTargetInfo_0)
	{
		if ((SL0vvwD6HYI.CpItmVISR7P().DisableOnFullscreenApp || mouseAction_0.DisableInFullScreen) && pointTargetInfo_0.IsFullscreenWindow)
		{
			if (mouseAction_0.MouseActionType != MouseActionType.WheelDown && mouseAction_0.MouseActionType != MouseActionType.WheelUp)
			{
				return true;
			}
			if (!mouseAction_0.DisableInFullScreen)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private bool UnCvLNVFmQW(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, Screen screen_0, PointTargetInfo pointTargetInfo_0)
	{
		if (mouseAction_0.Location != MouseActionLocation.NA && (mouseAction_0.Location & MouseActionLocation.FullScreen) != MouseActionLocation.FullScreen)
		{
			if (mouseAction_0.LimitOnPrimaryScreen && !screen_0.Primary)
			{
				return false;
			}
			MouseActionLocation location2 = mouseAction_0.Location;
			System.Drawing.Point point = pointTargetInfo_0.Point;
			Rectangle workingArea = screen_0.WorkingArea;
			Rectangle bounds = screen_0.Bounds;
			MouseActionLocation location = mouseAction_0.Location;
			int num;
			bool flag = default(bool);
			switch (location)
			{
			case MouseActionLocation.TopBorderLeft:
				if (bounds.IsOnTopBorder(point))
				{
					return bounds.IsOnLeftHalf(point);
				}
				return false;
			case MouseActionLocation.CornerBottomRight:
				return bounds.IsCornerBottomRight(point);
			case MouseActionLocation.CornerTopLeft:
				return bounds.IsCornerTopLeft(point);
			case MouseActionLocation.CornerTopRight:
				return bounds.IsCornerTopRight(point);
			case MouseActionLocation.CornerBottomLeft:
				return bounds.IsCornerBottomLeft(point);
			case MouseActionLocation.TaskBar:
				return NativeMethods.IsOnTaskbar(NativeMethods.WindowFromPoint(point));
			case MouseActionLocation.BottomBorder:
				return bounds.IsOnBottomBorder(point);
			case MouseActionLocation.BottomBorderRight:
				if (bounds.IsOnBottomBorder(point))
				{
					return bounds.IsOnRightHalf(point);
				}
				return false;
			case MouseActionLocation.Up:
				return workingArea.IsOnTopHalf(point);
			case MouseActionLocation.UpRight:
				if (!workingArea.IsOnLeftHalf(point))
				{
					return workingArea.IsOnTopHalf(point);
				}
				return false;
			case MouseActionLocation.UpLeft:
				if (workingArea.IsOnLeftHalf(point))
				{
					return workingArea.IsOnTopHalf(point);
				}
				return false;
			case MouseActionLocation.DownRight:
				if (!workingArea.IsOnLeftHalf(point))
				{
					return workingArea.IsOnBottomHalf(point);
				}
				return false;
			case MouseActionLocation.Left:
				return workingArea.IsOnLeftHalf(point);
			case MouseActionLocation.DownLeft:
				if (workingArea.IsOnLeftHalf(point))
				{
					return workingArea.IsOnBottomHalf(point);
				}
				return false;
			case MouseActionLocation.WorkingArea:
				return workingArea.Contains(point);
			case MouseActionLocation.Down:
				return workingArea.IsOnBottomHalf(point);
			case MouseActionLocation.Right:
				return workingArea.IsOnRightHalf(point);
			case MouseActionLocation.LeftBorder:
				return bounds.IsOnLeftBorder(point);
			case MouseActionLocation.LeftBorderDown:
				if (!bounds.IsOnLeftBorder(point))
				{
					return false;
				}
				return bounds.IsOnBottomHalf(point);
			case MouseActionLocation.LeftBorderUp:
				if (bounds.IsOnLeftBorder(point))
				{
					num = 3;
					if (COIxMyFCeTKEhc49RX1F != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_048f;
				}
				return false;
			case MouseActionLocation.RightBorderDown:
				if (bounds.IsOnRightBorder(point))
				{
					return bounds.IsOnBottomHalf(point);
				}
				return false;
			case MouseActionLocation.RightBorderUp:
				if (bounds.IsOnRightBorder(point))
				{
					return bounds.IsOnTopHalf(point);
				}
				return false;
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderLeft:
			case MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight | MouseActionLocation.TopBorderRight:
			case MouseActionLocation.TopBorder:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerBottomLeft:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.TopBorder | MouseActionLocation.CornerTopLeft | MouseActionLocation.CornerTopRight | MouseActionLocation.CornerBottomLeft | MouseActionLocation.CornerBottomRight:
			case MouseActionLocation.BottomBorderLeft:
				if (location != MouseActionLocation.TopBorderRight)
				{
					if (location == MouseActionLocation.TopBorder)
					{
						return bounds.IsOnTopBorder(point);
					}
					num = 0;
					if (COIxMyFCeTKEhc49RX1F == null)
					{
						goto IL_056d;
					}
				}
				else
				{
					if (!bounds.IsOnTopBorder(point))
					{
						return false;
					}
					num = 5;
					if (COIxMyFCeTKEhc49RX1F != null)
					{
						goto IL_0544;
					}
				}
				goto IL_048f;
			default:
				goto IL_0627;
			case MouseActionLocation.TitleBar:
				return AeavLJf2Y6U(point, pointTargetInfo_0);
			case MouseActionLocation.RightBorder:
				{
					return bounds.IsOnRightBorder(point);
				}
				IL_048f:
				switch (num)
				{
				case 8:
					break;
				default:
					goto IL_04c4;
				case 2:
					goto IL_0544;
				case 1:
					goto IL_056d;
				case 10:
					goto IL_0627;
				case 3:
					return bounds.IsOnTopHalf(point);
				case 5:
					return bounds.IsOnRightHalf(point);
				case 9:
					goto IL_066f;
				case 11:
					goto IL_0679;
				case 7:
					goto IL_06f5;
				case 4:
				case 6:
					goto IL_0777;
				}
				goto case MouseActionLocation.CornerTopLeft | MouseActionLocation.TopBorderLeft;
				IL_0544:
				flag = mouseAction_0.Location.HasFlag(MouseActionLocation.LeftBorderUp);
				goto IL_0560;
				IL_0679:
				if (!flag)
				{
					if (point.Y >= (screen_0.WorkingArea.Top + screen_0.WorkingArea.Bottom) / 2)
					{
						flag = ((point.X >= (screen_0.WorkingArea.Left + screen_0.WorkingArea.Right) / 2) ? mouseAction_0.Location.HasFlag(MouseActionLocation.DownRight) : mouseAction_0.Location.HasFlag(MouseActionLocation.DownLeft));
					}
					else
					{
						if (point.X >= (screen_0.WorkingArea.Left + screen_0.WorkingArea.Right) / 2)
						{
							goto IL_06f5;
						}
						flag = mouseAction_0.Location.HasFlag(MouseActionLocation.UpLeft);
					}
				}
				goto IL_0777;
				IL_056d:
				if (location != MouseActionLocation.BottomBorderLeft)
				{
					goto IL_0627;
				}
				if (!bounds.IsOnBottomBorder(point))
				{
					return false;
				}
				goto IL_066f;
				IL_0627:
				flag = false;
				if (point.Y == bounds.Top)
				{
					flag = ((point.X != bounds.Left) ? ((point.X != bounds.Right - 1) ? ((point.X >= (bounds.Left + bounds.Right) / 2) ? mouseAction_0.Location.HasFlag(MouseActionLocation.TopBorderRight) : mouseAction_0.Location.HasFlag(MouseActionLocation.TopBorderLeft)) : mouseAction_0.Location.HasFlag(MouseActionLocation.CornerTopRight)) : mouseAction_0.Location.HasFlag(MouseActionLocation.CornerTopLeft));
				}
				else if (point.Y == bounds.Bottom - 1)
				{
					if (point.X != bounds.Left)
					{
						goto IL_04c4;
					}
					flag = mouseAction_0.Location.HasFlag(MouseActionLocation.CornerBottomLeft);
				}
				else if (point.X == bounds.Left)
				{
					if (point.Y < (bounds.Top + bounds.Bottom) / 2)
					{
						num = 2;
						if (!IhLjTcFCjA6MRipDUS4j())
						{
							goto IL_048f;
						}
						goto IL_0544;
					}
					flag = mouseAction_0.Location.HasFlag(MouseActionLocation.LeftBorderDown);
				}
				else if (point.X == bounds.Right - 1)
				{
					flag = ((point.Y >= (bounds.Top + bounds.Bottom) / 2) ? mouseAction_0.Location.HasFlag(MouseActionLocation.RightBorderDown) : mouseAction_0.Location.HasFlag(MouseActionLocation.RightBorderUp));
				}
				goto IL_0560;
				IL_0777:
				return flag;
				IL_06f5:
				flag = mouseAction_0.Location.HasFlag(MouseActionLocation.UpRight);
				goto IL_0777;
				IL_04c4:
				flag = ((point.X == bounds.Right - 1) ? mouseAction_0.Location.HasFlag(MouseActionLocation.CornerBottomRight) : ((point.X >= (bounds.Left + bounds.Right) / 2) ? mouseAction_0.Location.HasFlag(MouseActionLocation.BottomBorderRight) : mouseAction_0.Location.HasFlag(MouseActionLocation.BottomBorderLeft)));
				goto IL_0560;
				IL_066f:
				return bounds.IsOnLeftHalf(point);
				IL_0560:
				if (!flag)
				{
					flag = mouseAction_0.Location == MouseActionLocation.TaskBar && NativeMethods.IsOnTaskbar(NativeMethods.WindowFromPoint(point));
					num = 11;
					if (!IhLjTcFCjA6MRipDUS4j())
					{
						goto case MouseActionLocation.CornerTopLeft | MouseActionLocation.TopBorderLeft;
					}
					goto IL_048f;
				}
				goto IL_0679;
			}
		}
		return true;
	}

	private bool AeavLJf2Y6U(System.Drawing.Point point_1, PointTargetInfo pointTargetInfo_0)
	{
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(pointTargetInfo_0.HWnd);
		int num = point_1.Y - windowRectangle.Top;
		int num2 = point_1.X - windowRectangle.Left;
		if (num > 0 && num <= SystemInformation.CaptionHeight + 3 && num2 > SystemInformation.CaptionHeight && num2 < windowRectangle.Width - SystemInformation.CaptionHeight * 3)
		{
			if (NativeMethods.IsOnDesktop(pointTargetInfo_0.HWnd))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private bool lQkvL0dclWA(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, Screen screen_0, System.Drawing.Point point_1)
	{
		switch (mouseAction_0.Location)
		{
		case MouseActionLocation.CornerBottomRight:
			if (point_1.X == screen_0.Bounds.Right - 1)
			{
				return point_1.Y == screen_0.Bounds.Bottom - 1;
			}
			return false;
		case MouseActionLocation.CornerTopLeft:
			if (point_1.X == screen_0.Bounds.Left)
			{
				return point_1.Y == screen_0.Bounds.Top;
			}
			return false;
		case MouseActionLocation.CornerTopRight:
			if (point_1.X == screen_0.Bounds.Right - 1)
			{
				return point_1.Y == screen_0.Bounds.Top;
			}
			return false;
		default:
			return false;
		case MouseActionLocation.CornerBottomLeft:
			if (point_1.X == screen_0.Bounds.Left)
			{
				return point_1.Y == screen_0.Bounds.Bottom - 1;
			}
			return false;
		}
	}

	private bool z0wvLCcCybg(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, bool bool_7 = false)
	{
		KeyboardState realKeyState = cDWvv8xNu7H.RealKeyState;
		if (!mouseAction_0.ControlKey.HasValue)
		{
			goto IL_018a;
		}
		int num;
		if (mouseAction_0.ControlKey.Value == 0)
		{
			num = 2;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			if (mouseAction_0.ControlKey == 261)
			{
				return true;
			}
			if (mouseAction_0.ControlKey >= 262 && CiNTbyM2WDubHspat0P.Km7LdJNNIgS((VirtualKeyCode)mouseAction_0.ControlKey.Value))
			{
				if (CiNTbyM2WDubHspat0P.iBBLdEolQUM().k1DLdPoqbpG((VirtualKeyCode)mouseAction_0.ControlKey.Value))
				{
					return !realKeyState.IsAnyKeyDown();
				}
				return false;
			}
			if (mouseAction_0.ControlKey <= 6)
			{
				if (!IFVvvu5V5nH.IsKeyCaptured() && !realKeyState.IsAnyKeyDown())
				{
					if (!xT0vgpbZgCc((VirtualKeyCode)mouseAction_0.ControlKey.Value))
					{
						return KeyboardHelper.IsKeyDown((VirtualKeyCode)mouseAction_0.ControlKey.Value);
					}
					return true;
				}
				return false;
			}
			if (fyQvvWWWM3P.PG5tZA0N5nh(mouseAction_0.MouseButton))
			{
				return false;
			}
			if (IFVvvu5V5nH.IsKeyCaptured(mouseAction_0.ControlKey.Value))
			{
				return true;
			}
			if (!KeyboardHelper.UriLMd2nUfC((Keys)mouseAction_0.ControlKey.Value))
			{
				return false;
			}
			if (realKeyState.IsTheOnlyDownKey(mouseAction_0.ControlKey.Value))
			{
				return true;
			}
			num = 1;
			if (!IhLjTcFCjA6MRipDUS4j())
			{
				goto IL_01f5;
			}
		}
		goto IL_01ab;
		IL_01f5:
		return KeyboardHelper.IsKeyDown((VirtualKeyCode)mouseAction_0.ControlKey.Value);
		IL_01ab:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_01bf;
		case 1:
			goto IL_01f5;
		}
		goto IL_018a;
		IL_018a:
		if (!IFVvvu5V5nH.IsKeyCaptured() && !realKeyState.IsCtrlDown())
		{
			num = 0;
			if (COIxMyFCeTKEhc49RX1F == null)
			{
				goto IL_01ab;
			}
			goto IL_01bf;
		}
		goto IL_0209;
		IL_01bf:
		if (!realKeyState.IsShiftDown() && !realKeyState.IsAltDown() && !fyQvvWWWM3P.PG5tZA0N5nh(mouseAction_0.MouseButton))
		{
			return !CiNTbyM2WDubHspat0P.iBBLdEolQUM().k1DLdPoqbpG(VirtualKeyCode.APP_V1);
		}
		goto IL_0209;
		IL_0209:
		return false;
	}

	private bool uPBvLPQL4jD(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, PointTargetInfo pointTargetInfo_0)
	{
		if (!string.IsNullOrEmpty(pointTargetInfo_0?.Exe))
		{
			return JELvLE2bGVd(mouseAction_0, pointTargetInfo_0.Exe, pointTargetInfo_0.ExePath);
		}
		return false;
	}

	private bool JELvLE2bGVd(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, string string_0, string string_1)
	{
		if (mouseAction_0.WhiteList.HasData())
		{
			string[] whiteList = mouseAction_0.WhiteList;
			int num = 0;
			while (true)
			{
				if (num < whiteList.Length)
				{
					if (string.Equals(whiteList[num], string_0, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		if (SL0vvwD6HYI.CpItmVISR7P().SpecialExeList.HasData() && BlackListMgr.IsInBlackList(string_0, string_1))
		{
			return true;
		}
		if (mouseAction_0.BlackList.HasData())
		{
			string[] whiteList = mouseAction_0.BlackList;
			int num = 0;
			while (true)
			{
				if (num < whiteList.Length)
				{
					if (string.Equals(whiteList[num], string_0, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private bool wmjvLySs6cd(Quicker.Domain.PowerMouse.MouseAction mouseAction_0, PointTargetInfo pointTargetInfo_0, Screen screen_0)
	{
		if (mouseAction_0 != null && pointTargetInfo_0 != null && screen_0 != null)
		{
			if (!mouseAction_0.IsEnabled)
			{
				return false;
			}
			if (gcvvLuQEt4X(mouseAction_0, screen_0, pointTargetInfo_0))
			{
				return false;
			}
			if (uPBvLPQL4jD(mouseAction_0, pointTargetInfo_0))
			{
				return false;
			}
			if (mouseAction_0.MouseActionType != MouseActionType.MoveToCorner)
			{
				if (!UnCvLNVFmQW(mouseAction_0, screen_0, pointTargetInfo_0))
				{
					return false;
				}
				if (pointTargetInfo_0.IsOnNonTriggerWindow && mouseAction_0.Operation != MouseOperationType.QuickAction)
				{
					if (IhLjTcFCjA6MRipDUS4j())
					{
						switch (0)
						{
						}
					}
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private int JekvL8tklpU(MouseButtons mouseButtons_0)
	{
		if (mouseButtons_0 > MouseButtons.Right)
		{
			switch (mouseButtons_0)
			{
			case MouseButtons.XButton2:
				return 6;
			case MouseButtons.XButton1:
				return 5;
			case MouseButtons.Middle:
				return 4;
			}
		}
		else
		{
			if (mouseButtons_0 == MouseButtons.Left)
			{
				return 1;
			}
			if (mouseButtons_0 == MouseButtons.Right)
			{
				return 2;
			}
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				switch (0)
				{
				}
			}
		}
		return 0;
	}

	private MouseButtons KxJvLa4e0ud(VirtualKeyCode virtualKeyCode_0)
	{
		return virtualKeyCode_0 switch
		{
			VirtualKeyCode.LBUTTON => MouseButtons.Left, 
			VirtualKeyCode.RBUTTON => MouseButtons.Right, 
			VirtualKeyCode.MBUTTON => MouseButtons.Middle, 
			VirtualKeyCode.XBUTTON1 => MouseButtons.XButton1, 
			VirtualKeyCode.XBUTTON2 => MouseButtons.XButton2, 
			_ => MouseButtons.None, 
		};
	}

	private void v7gvL7Q0RZq(AppMouseEventArgs appMouseEventArgs_0)
	{
		if (AppState.HasOpenContextMenu && !AppHelper.GetPointTargetInfo(null).IsOnQuicker)
		{
			AppState.CloseAllContextMenus();
		}
	}

	private void KERvLROn6Df(MouseButtons mouseButtons_0)
	{
		_003C_003Ec__DisplayClass155_0 _003C_003Ec__DisplayClass155_ = new _003C_003Ec__DisplayClass155_0();
		_003C_003Ec__DisplayClass155_.j8f2CprqRL3 = mouseButtons_0;
		AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass155_.Jyq2CrMKyw6);
	}

	private void thjvLq0npS4(MouseButtons mouseButtons_0)
	{
		_003C_003Ec__DisplayClass158_0 _003C_003Ec__DisplayClass158_ = new _003C_003Ec__DisplayClass158_0();
		_003C_003Ec__DisplayClass158_.VH22CQgI1Tc = mouseButtons_0;
		_003C_003Ec__DisplayClass158_.q0e2Cj32TTR = this;
		AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass158_.CjK2CB1nsdN);
	}

	private void okDvLcLnF3i(MouseButtons mouseButtons_0)
	{
		_003C_003Ec__DisplayClass159_0 _003C_003Ec__DisplayClass159_ = new _003C_003Ec__DisplayClass159_0();
		_003C_003Ec__DisplayClass159_.jkk2C4k7mPr = mouseButtons_0;
		_003C_003Ec__DisplayClass159_.uQH2C5V91ig = this;
		AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass159_.o0a2CnXvkG8);
	}

	[DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
	private static extern short hg9vLV4glXm(VirtualKeyCode virtualKeyCode_0);

	[DllImport("user32", EntryPoint = "GetSystemMetrics")]
	private static extern int pTVvLZDhnQn(int int_1);

	private static bool FKMvL9OSXbb()
	{
		return hg9vLV4glXm((pTVvLZDhnQn(23) > 0) ? VirtualKeyCode.LBUTTON : VirtualKeyCode.RBUTTON) != 0;
	}

	private bool fq2vLhQs94k(MouseButtons mouseButtons_0)
	{
		return (Control.MouseButtons & mouseButtons_0) == mouseButtons_0;
	}

	private bool RXYvLeUkaA9(PointTargetInfo pointTargetInfo_0, bool bool_7, PopupSource popupSource_0, bool bool_8)
	{
		if (pointTargetInfo_0.IsOnNonTriggerWindow)
		{
			return false;
		}
		if (!pointTargetInfo_0.CanTrigger(PopupSource.Mouse))
		{
			return false;
		}
		if (bool_7)
		{
			fPDvLWi28bU(pointTargetInfo_0);
		}
		dB6vvgTocvt.MouseDownTargetInfo = pointTargetInfo_0;
		BWivLz0pfuj.ShowOrMovePopupToPoint(popupSource_0, pointTargetInfo_0, bool_8);
		return true;
	}

	public void Fa9vLYN4IuJ(bool bool_7, PopupSource popupSource_0, bool bool_8)
	{
		_003C_003Ec__DisplayClass165_0 _003C_003Ec__DisplayClass165_ = new _003C_003Ec__DisplayClass165_0();
		_003C_003Ec__DisplayClass165_.K0w2CdgTvxK = this;
		_003C_003Ec__DisplayClass165_.Dkw2CTDRT62 = bool_7;
		_003C_003Ec__DisplayClass165_.GHM2CMcWxMV = popupSource_0;
		_003C_003Ec__DisplayClass165_.Lat2CAP3laX = bool_8;
		_003C_003Ec__DisplayClass165_.pku2CoJX4VA = AppHelper.GetPointTargetInfo(null);
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass165_.YbC2CDd9e4v);
	}

	private void eVbvLI1Y5f5(PointTargetInfo pointTargetInfo_0)
	{
		_003C_003Ec__DisplayClass166_0 _003C_003Ec__DisplayClass166_ = new _003C_003Ec__DisplayClass166_0();
		_003C_003Ec__DisplayClass166_.hE42ClMTSxw = this;
		_003C_003Ec__DisplayClass166_.Lkd2CUdVUu6 = Path.GetFileNameWithoutExtension(pointTargetInfo_0.Exe);
		if (SL0vvwD6HYI.Q0ltmmbUTMB().Any(_003C_003Ec__DisplayClass166_.j5N2COFW0hn))
		{
			int browserMainProcess = ProcessHelper.GetBrowserMainProcess((int)pointTargetInfo_0.Pid, _003C_003Ec__DisplayClass166_.Lkd2CUdVUu6);
			if (AppState.vjAt7Seco0Y().xSstGKB1AqB(_003C_003Ec__DisplayClass166_.Lkd2CUdVUu6, browserMainProcess))
			{
				Task.Run((Action)_003C_003Ec__DisplayClass166_.EuZ2CFdwSO0);
			}
		}
	}

	public static void fPDvLWi28bU(PointTargetInfo pointTargetInfo_0)
	{
		try
		{
			if (pointTargetInfo_0 != null && AppState.r4itaWBnyVQ() != null && !NativeMethods.IsSameOrChildWindow(AppState.r4itaWBnyVQ().ForegroundWindowHwnd, pointTargetInfo_0.HWnd))
			{
				AppHelper.SetForegroundWindow(NativeMethods.GetRootWindow(pointTargetInfo_0.HWnd));
			}
		}
		catch (Exception ex)
		{
			i71vvyAPQUV.Warn("ActivatePointingWindow出错：" + ex.Message, ex);
		}
	}

	private void WbgvLkONQDA(WOkyiC2pewwqUAWVaJb wokyiC2pewwqUAWVaJb_0)
	{
		if (wokyiC2pewwqUAWVaJb_0.mNQthXnLbQZ() == "user_mouseActions")
		{
			N3jvgW1OKsQ();
		}
	}

	public void xJ2vLGOZrLf()
	{
		zAwvvCZiXYj.Stop();
		TbUvv1kROcc.InvokeAsync(pgUvLQ8yDHR);
	}

	public void XybvLsbQWal()
	{
		FRAvgShyCwg();
	}

	[SpecialName]
	public bool EfhvLOJ9JGW()
	{
		return DGUvvjei8X1;
	}

	[SpecialName]
	public void RV5vLF5yh1l(bool bool_7)
	{
		DGUvvjei8X1 = bool_7;
	}

	static UIy1pYiDsLcf2l4joSP()
	{
		i71vvyAPQUV = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void xemvLHg5X6P(object sender, EventArgs e)
	{
		eVuvLfVCnT6 = null;
	}

	[CompilerGenerated]
	private void qSgvL1d6vTc(object sender, NotifyCollectionChangedEventArgs e)
	{
		N3jvgW1OKsQ();
	}

	[CompilerGenerated]
	private void sm8vLbEQKPJ()
	{
		if (v45vvBRpIiS != null && v45vvBRpIiS.IsLoaded)
		{
			v45vvBRpIiS.UpdateSettings();
		}
	}

	[CompilerGenerated]
	private void CTlvL6aOwbq()
	{
		Hkevv0QHEW3.Restart();
		N3jvgW1OKsQ();
		cDWvv8xNu7H.Restart();
		AppHelper.HP0LT5LCDOi();
	}

	[CompilerGenerated]
	private void HhTvLXjjZOF()
	{
		if (cDWvv8xNu7H == null)
		{
			cDWvv8xNu7H = new KeyboardHook();
			cDWvv8xNu7H.KeyDown += zlxvgCPnKQ6;
			cDWvv8xNu7H.KeyUp += iCqvgJFF1tY;
			cDWvv8xNu7H.ToggleableKeyDown += l8ovgRryABN;
			cDWvv8xNu7H.Start();
		}
	}

	[CompilerGenerated]
	private void grdvLmHkiv7()
	{
		if (cDWvv8xNu7H != null)
		{
			cDWvv8xNu7H.Stop();
			cDWvv8xNu7H.KeyDown -= zlxvgCPnKQ6;
			cDWvv8xNu7H.KeyUp -= iCqvgJFF1tY;
			cDWvv8xNu7H.ToggleableKeyDown -= l8ovgRryABN;
			cDWvv8xNu7H = null;
		}
	}

	[CompilerGenerated]
	internal static bool PiDvLKeR7jr()
	{
		return JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control;
	}

	[CompilerGenerated]
	private void lTivLx5KCtU()
	{
		Hkevv0QHEW3 = new lPxZYOM8ws3NP42wph0();
		Hkevv0QHEW3.Q9JLApsvECB(AfevgBF8RnO);
		Hkevv0QHEW3.xCULAKutXGc(soyvg1j7vfg);
		Hkevv0QHEW3.MouseWheel += S89vgTBVTyC;
		Hkevv0QHEW3.NyCLAjrMddj(mjMvgnimIxK);
		Hkevv0QHEW3.unGLAd66cNd(wd4vgMWpkyx);
		Hkevv0QHEW3.mVfLAFLN9pp(MBcvtDWXIAE);
		Hkevv0QHEW3.Start();
	}

	[CompilerGenerated]
	private void tvvvLrjHEPc()
	{
		if (Hkevv0QHEW3 != null)
		{
			Hkevv0QHEW3.Stop();
			Hkevv0QHEW3.HgrLABQuWJG(AfevgBF8RnO);
			Hkevv0QHEW3.FQQLAxsLQXZ(soyvg1j7vfg);
			Hkevv0QHEW3.RZDLAnbujZh(mjMvgnimIxK);
			Hkevv0QHEW3.MouseWheel -= S89vgTBVTyC;
			Hkevv0QHEW3.DPuLAonCgsE(wd4vgMWpkyx);
			Hkevv0QHEW3 = null;
			int num = 0;
			if (COIxMyFCeTKEhc49RX1F != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	[CompilerGenerated]
	private void pCxvLpPVrcy()
	{
		RXYvLeUkaA9(AppHelper.GetPointTargetInfo(CircleDetector.GetBasePoint()), true, PopupSource.Mouse, true);
	}

	[CompilerGenerated]
	private void PWYvLBna2aJ(object sender, EventArgs e)
	{
		EXavvpoOBID = null;
	}

	[CompilerGenerated]
	private void pgUvLQ8yDHR()
	{
		Hkevv0QHEW3.Stop();
		cDWvv8xNu7H.Stop();
	}

	internal static bool IhLjTcFCjA6MRipDUS4j()
	{
		return COIxMyFCeTKEhc49RX1F == null;
	}
}
