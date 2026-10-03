using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Ci16jh2IrdW1EGWcrNE;
using EqtDrcM1X3kj7ZaMpIC;
using FfRbOxjQBTfIswDNnrx;
using log4net;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Hooks;
using Quicker.Utilities.Win32;

namespace lUCjKTMbZVPP5v56los;

internal class lPxZYOM8ws3NP42wph0 : GlobalHook
{
	public delegate void UZrkOqDfLEjYx3uixBU(object? sender, AppMouseEventArgs e);

	private enum HrsXocD69oKZMelvN0f
	{
		None = 0,
		MouseWheel = 4
	}

	private static readonly ILog zLsLAiChYRT;

	private oweR8e2rZD7t5GSlLo4 YbELA3XVpse = new oweR8e2rZD7t5GSlLo4("Hook", false);

	private oweR8e2rZD7t5GSlLo4 W8PLAfe63Bp = new oweR8e2rZD7t5GSlLo4("RealState", true);

	private S8HaJMMe4vmgx2af2iD G3CLAz2v3Wc = new S8HaJMMe4vmgx2af2iD();

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU zmQLOwSjmFx;

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU SQKLOtEiuIq;

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU GimLOgG979g;

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU m_MouseWheel;

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU esNLOLDHI23;

	[CompilerGenerated]
	private EventHandler MyPLOv28fLA;

	[CompilerGenerated]
	private UZrkOqDfLEjYx3uixBU jYFLOS0vnHD;

	private static lPxZYOM8ws3NP42wph0 SdLqhGFg89pr7pAZr0A2;

	public oweR8e2rZD7t5GSlLo4 RealState => W8PLAfe63Bp;

	public event UZrkOqDfLEjYx3uixBU MouseWheel
	{
		[CompilerGenerated]
		add
		{
			UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = this.m_MouseWheel;
			UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
			do
			{
				uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
				UZrkOqDfLEjYx3uixBU value2 = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, value);
				uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref this.m_MouseWheel, value2, uZrkOqDfLEjYx3uixBU2);
			}
			while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
		}
		[CompilerGenerated]
		remove
		{
			UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = this.m_MouseWheel;
			UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
			do
			{
				uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
				UZrkOqDfLEjYx3uixBU value2 = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, value);
				uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref this.m_MouseWheel, value2, uZrkOqDfLEjYx3uixBU2);
			}
			while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void xCULAKutXGc(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = zmQLOwSjmFx;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref zmQLOwSjmFx, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void FQQLAxsLQXZ(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = zmQLOwSjmFx;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref zmQLOwSjmFx, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Q9JLApsvECB(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = SQKLOtEiuIq;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref SQKLOtEiuIq, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void HgrLABQuWJG(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = SQKLOtEiuIq;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref SQKLOtEiuIq, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void NyCLAjrMddj(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = GimLOgG979g;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref GimLOgG979g, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void RZDLAnbujZh(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = GimLOgG979g;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref GimLOgG979g, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void unGLAd66cNd(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = esNLOLDHI23;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref esNLOLDHI23, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DPuLAonCgsE(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = esNLOLDHI23;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref esNLOLDHI23, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void sMGLAM040Zf(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = MyPLOv28fLA;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref MyPLOv28fLA, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void GiuLAAseYxm(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = MyPLOv28fLA;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref MyPLOv28fLA, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void mVfLAFLN9pp(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = jYFLOS0vnHD;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Combine(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref jYFLOS0vnHD, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ajiLAUpgXUV(UZrkOqDfLEjYx3uixBU uzrkOqDfLEjYx3uixBU_5)
	{
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = jYFLOS0vnHD;
		UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2;
		do
		{
			uZrkOqDfLEjYx3uixBU2 = uZrkOqDfLEjYx3uixBU;
			UZrkOqDfLEjYx3uixBU value = (UZrkOqDfLEjYx3uixBU)Delegate.Remove(uZrkOqDfLEjYx3uixBU2, uzrkOqDfLEjYx3uixBU_5);
			uZrkOqDfLEjYx3uixBU = Interlocked.CompareExchange(ref jYFLOS0vnHD, value, uZrkOqDfLEjYx3uixBU2);
		}
		while ((object)uZrkOqDfLEjYx3uixBU != uZrkOqDfLEjYx3uixBU2);
	}

	public lPxZYOM8ws3NP42wph0()
	{
		base.HookType = HookType.WH_MOUSE_LL;
	}

	protected override IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
	{
		bool flag = false;
		try
		{
			flag = CglLAbty2Bl(nCode, wParam, lParam);
		}
		catch (Exception exception)
		{
			zLsLAiChYRT.Error("处理鼠标回调消息出错！" + exception.GetMessageWithInner(), exception);
		}
		if (flag)
		{
			return (IntPtr)1;
		}
		return NativeMethods.CallNextHookEx(base.HandleToHook, nCode, wParam, lParam);
	}

	private bool CglLAbty2Bl(int int_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		int num = 3;
		while (true)
		{
			bool flag = false;
			while (true)
			{
				if (int_0 > -1 && (zmQLOwSjmFx != null || SQKLOtEiuIq != null || GimLOgG979g != null || this.m_MouseWheel != null || esNLOLDHI23 != null))
				{
					NativeMethods.MouseLLHookStruct mouseLLHookStruct = (NativeMethods.MouseLLHookStruct)Marshal.PtrToStructure(intptr_2, typeof(NativeMethods.MouseLLHookStruct));
					MouseButtons mouseButtons = ohCLA6uDTTd((int)intptr_1, mouseLLHookStruct.mouseData);
					HrsXocD69oKZMelvN0f hrsXocD69oKZMelvN0f = NaULAXyC4Mf((int)intptr_1);
					bool flag2 = ((uint)mouseLLHookStruct.dwExtraInfo & 0xFFFFFF00u) == 4283520768u;
					AppMouseEventArgs e = new AppMouseEventArgs(mouseButtons, (hrsXocD69oKZMelvN0f != (HrsXocD69oKZMelvN0f)3) ? 1 : 2, mouseLLHookStruct.pt.x, mouseLLHookStruct.pt.y, (hrsXocD69oKZMelvN0f == HrsXocD69oKZMelvN0f.MouseWheel || hrsXocD69oKZMelvN0f == (HrsXocD69oKZMelvN0f)6) ? ((short)((mouseLLHookStruct.mouseData >> 16) & 0xFFFF)) : 0)
					{
						IsInjected = (mouseLLHookStruct.flags != 0 && !flag2),
						IsPenOrTouch = flag2,
						IsFromQuicker = (mouseLLHookStruct.dwExtraInfo == (UIntPtr)4660uL),
						IsButtonDown = YbELA3XVpse.Kcpt9nPM6AT(mouseButtons),
						IsFromGestureSoftware = (mouseLLHookStruct.flags != 0 && !flag2 && mouseLLHookStruct.dwExtraInfo != (UIntPtr)0uL)
					};
					int num2;
					switch (hrsXocD69oKZMelvN0f)
					{
					case (HrsXocD69oKZMelvN0f)2:
					{
						if (!e.IsInjected)
						{
							e.IsDbClickUp = W8PLAfe63Bp.s98t9QV8E0b(e.Button);
						}
						UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU = SQKLOtEiuIq;
						if (uZrkOqDfLEjYx3uixBU == null)
						{
							goto IL_01c7;
						}
						uZrkOqDfLEjYx3uixBU(this, e);
						num2 = 1;
						if (!abhXatFgRhQ4RZ0oTiJw())
						{
							goto IL_0269;
						}
						goto IL_026d;
					}
					case (HrsXocD69oKZMelvN0f)1:
						if (!e.IsInjected)
						{
							W8PLAfe63Bp.jUNt9BaxGBE(e.Button);
						}
						zmQLOwSjmFx?.Invoke(this, e);
						G3CLAz2v3Wc.zCdLO2yDgGC(e.Button, e.Handled);
						if (!e.Handled)
						{
							YbELA3XVpse.jUNt9BaxGBE(e.Button);
						}
						goto IL_036c;
					case (HrsXocD69oKZMelvN0f)3:
						jYFLOS0vnHD?.Invoke(this, e);
						goto IL_036c;
					case HrsXocD69oKZMelvN0f.MouseWheel:
						this.m_MouseWheel?.Invoke(this, e);
						goto IL_0332;
					case (HrsXocD69oKZMelvN0f)5:
						GimLOgG979g?.Invoke(this, e);
						goto IL_036c;
					case (HrsXocD69oKZMelvN0f)6:
						goto IL_0358;
					default:
						goto IL_036c;
						IL_0269:
						num2 = num;
						goto IL_026d;
						IL_036c:
						flag |= e.Handled;
						goto IL_0378;
						IL_01c7:
						MyPLOv28fLA?.Invoke(this, e);
						if (!G3CLAz2v3Wc.y5DLOusfFai(e.Button) && e.Handled)
						{
							zLsLAiChYRT.Warn($"鼠标键{e.Button} 在没有捕获按下的情况下要求捕获抬起。");
							e.Handled = false;
						}
						if (!e.Handled)
						{
							YbELA3XVpse.s98t9QV8E0b(e.Button);
						}
						if (e.IsDbClickUp)
						{
							UZrkOqDfLEjYx3uixBU uZrkOqDfLEjYx3uixBU2 = jYFLOS0vnHD;
							if (uZrkOqDfLEjYx3uixBU2 != null)
							{
								uZrkOqDfLEjYx3uixBU2(this, e);
								num2 = 0;
								if (!abhXatFgRhQ4RZ0oTiJw())
								{
									goto IL_0269;
								}
								goto IL_026d;
							}
						}
						goto IL_036c;
						IL_0332:
						if (!e.IsInjected)
						{
							FqQNhnjBSUJyynWhRgo.KRCtk3Mv9Y2();
						}
						goto IL_036c;
						IL_0358:
						esNLOLDHI23?.Invoke(this, e);
						goto IL_036c;
						IL_026d:
						switch (num2)
						{
						case 1:
							break;
						case 2:
							goto end_IL_015a;
						case 3:
							goto end_IL_028f;
						case 5:
							goto IL_0332;
						case 4:
							goto IL_0358;
						default:
							goto IL_036c;
						}
						goto IL_01c7;
						end_IL_015a:
						break;
					}
					continue;
				}
				goto IL_0378;
				IL_0378:
				return flag;
				continue;
				end_IL_028f:
				break;
			}
		}
	}

	private static MouseButtons ohCLA6uDTTd(int int_0, int int_1)
	{
		switch (int_0)
		{
		case 513:
		case 514:
		case 515:
			return MouseButtons.Left;
		case 516:
		case 517:
		case 518:
			return MouseButtons.Right;
		case 519:
		case 520:
		case 521:
			return MouseButtons.Middle;
		default:
			return MouseButtons.None;
		case 523:
		case 524:
			if ((int_1 & 0x10000) > 0)
			{
				return MouseButtons.XButton1;
			}
			if ((int_1 & 0x20000) > 0)
			{
				return MouseButtons.XButton2;
			}
			return MouseButtons.XButton1;
		}
	}

	private static HrsXocD69oKZMelvN0f NaULAXyC4Mf(int int_0)
	{
		switch (int_0)
		{
		case 512:
			return (HrsXocD69oKZMelvN0f)5;
		case 515:
		case 518:
		case 521:
			return (HrsXocD69oKZMelvN0f)3;
		case 522:
			return HrsXocD69oKZMelvN0f.MouseWheel;
		case 513:
		case 516:
		case 519:
		case 523:
			return (HrsXocD69oKZMelvN0f)1;
		case 514:
		case 517:
		case 520:
		case 524:
			return (HrsXocD69oKZMelvN0f)2;
		default:
			return HrsXocD69oKZMelvN0f.None;
		case 526:
			return (HrsXocD69oKZMelvN0f)6;
		}
	}

	public override void Stop()
	{
		base.Stop();
		YbELA3XVpse.Reset();
		G3CLAz2v3Wc.Reset();
		W8PLAfe63Bp.Reset();
	}

	static lPxZYOM8ws3NP42wph0()
	{
		zLsLAiChYRT = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool abhXatFgRhQ4RZ0oTiJw()
	{
		return SdLqhGFg89pr7pAZr0A2 == null;
	}
}
