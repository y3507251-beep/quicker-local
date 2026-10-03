using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using c4LBdq5YohQFUgxFYw4;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetWindowInfoStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yhgSSS1pU4L;

		public static Func<KeyValuePair<IntPtr, string>, string> mZuSS2cYfWx;

		public static Func<KeyValuePair<IntPtr, string>, string> JroSSuOlZyr;

		public static Func<Process, int> ryfSSNmVlgE;

		private static _003C_003Ec jS0hDMW1do0WBQI3e9Yi;

		static _003C_003Ec()
		{
			yhgSSS1pU4L = new _003C_003Ec();
		}

		internal string kabSSgwKQWn(KeyValuePair<IntPtr, string> x)
		{
			return x.Key.ToString();
		}

		internal string joySSLdAErZ(KeyValuePair<IntPtr, string> x)
		{
			string value = x.Value;
			object obj;
			if (value == null)
			{
				obj = null;
			}
			else
			{
				obj = value.ToString();
				if (obj != null)
				{
					goto IL_001c;
				}
			}
			obj = "";
			goto IL_001c;
			IL_001c:
			return (string)obj;
		}

		internal int aUfSSvFWo3F(Process x)
		{
			return x.Id;
		}

		internal static void QkI3p9W1kHYCuiT4W72u()
		{
		}

		internal static bool wNNdQfW1OB07fCytCnc8()
		{
			return jS0hDMW1do0WBQI3e9Yi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass74_0
	{
		public ActionStep HDcSS0bF4En;

		public ActionExecuteContext djQSSCAvOmr;

		public XAction dM5SSPXFhfx;

		private static _003C_003Ec__DisplayClass74_0 QRoZ7uW1a9p7u9oIgqER;

		internal (bool isSuccess, string message, ActionStopFlag failReason) PC6SSJy6jnV()
		{
			try
			{
				_003C_003Ec__DisplayClass74_1 _003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_1();
				string text = XActionHelper.GetTextParamValue(AasggZ7PIPH, HDcSS0bF4En, djQSSCAvOmr);
				if (string.IsNullOrEmpty(text))
				{
					text = "foreground";
				}
				_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = IntPtr.Zero;
				switch (text)
				{
				case "pointing":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = djQSSCAvOmr.TargetInfo.HWnd;
					break;
				case "fromHwnd":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = (IntPtr)Convert.ToInt32(XActionHelper.GetIntegerParamValue(dIFgg9ueM1a, HDcSS0bF4En, djQSSCAvOmr));
					if (_003C_003Ec__DisplayClass74_.ahvSSaGS5rL == IntPtr.Zero)
					{
						_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(NativeMethods.GetForegroundWindow());
					}
					break;
				case "foreground":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(NativeMethods.GetForegroundWindow());
					break;
				case "findWindow":
				{
					string text2 = XActionHelper.GetTextParamValue(W1lgghYJdv2, HDcSS0bF4En, djQSSCAvOmr);
					string text3 = XActionHelper.GetTextParamValue(JTiggeUAZkI, HDcSS0bF4En, djQSSCAvOmr);
					string text4 = XActionHelper.GetTextParamValue(BLPggYDuLud, HDcSS0bF4En, djQSSCAvOmr);
					int[] int_2 = GTqggaHUWCj(text4);
					string textParamValue6 = XActionHelper.GetTextParamValue(UUqggIBJOXp, HDcSS0bF4En, djQSSCAvOmr);
					bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(_useRegexParam, HDcSS0bF4En, djQSSCAvOmr);
					if (string.IsNullOrEmpty(text2))
					{
						text2 = null;
					}
					if (string.IsNullOrEmpty(text3))
					{
						text3 = null;
					}
					if (string.IsNullOrEmpty(text4))
					{
						text4 = null;
					}
					if (string.IsNullOrEmpty(text4))
					{
						_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.FindWindow(text2, text3);
						if (textParamValue6 == "1" && _003C_003Ec__DisplayClass74_.ahvSSaGS5rL != IntPtr.Zero && !OpenWindowGetter.IsWindowVisible(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL))
						{
							_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = IntPtr.Zero;
						}
					}
					if (!(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL == IntPtr.Zero))
					{
						break;
					}
					foreach (KeyValuePair<IntPtr, string> openWindow in OpenWindowGetter.GetOpenWindows(textParamValue6 != "0", XActionHelper.GetBooleanParamValue(_requireTitleParam, HDcSS0bF4En, djQSSCAvOmr)))
					{
						if (WindowHelper.HP9LFBj7trn(openWindow.Key, text2, text3, int_2, booleanParamValue2))
						{
							_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = openWindow.Key;
							break;
						}
					}
					break;
				}
				case "top_windows":
				{
					string textParamValue3 = XActionHelper.GetTextParamValue(UUqggIBJOXp, HDcSS0bF4En, djQSSCAvOmr);
					string textParamValue4 = XActionHelper.GetTextParamValue(W1lgghYJdv2, HDcSS0bF4En, djQSSCAvOmr);
					string textParamValue5 = XActionHelper.GetTextParamValue(JTiggeUAZkI, HDcSS0bF4En, djQSSCAvOmr);
					int[] int_ = GTqggaHUWCj(XActionHelper.GetTextParamValue(BLPggYDuLud, HDcSS0bF4En, djQSSCAvOmr));
					bool booleanParamValue = XActionHelper.GetBooleanParamValue(_useRegexParam, HDcSS0bF4En, djQSSCAvOmr);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					foreach (KeyValuePair<IntPtr, string> openWindow2 in OpenWindowGetter.GetOpenWindows(textParamValue3 != "0", XActionHelper.GetBooleanParamValue(_requireTitleParam, HDcSS0bF4En, djQSSCAvOmr)))
					{
						if (!WindowHelper.HP9LFBj7trn(openWindow2.Key, textParamValue4, textParamValue5, int_, booleanParamValue))
						{
							continue;
						}
						string key = openWindow2.Key.ToString();
						string value = openWindow2.Value;
						object obj;
						if (value == null)
						{
							obj = null;
						}
						else
						{
							obj = value.ToString();
							if (obj != null)
							{
								goto IL_03f9;
							}
						}
						obj = "";
						goto IL_03f9;
						IL_03f9:
						dictionary.Add(key, obj);
					}
					XActionHelper.OutputResult(YbZggDwq5vB, HDcSS0bF4En, djQSSCAvOmr, dictionary, dM5SSPXFhfx);
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				case "selectWindow":
				{
					_003C_003Ec__DisplayClass74_2 _003C_003Ec__DisplayClass74_2 = new _003C_003Ec__DisplayClass74_2
					{
						ed1SSR1uqYa = null
					};
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass74_2.CnlSS7gMUb1);
					if (_003C_003Ec__DisplayClass74_2.ed1SSR1uqYa.IsSuccess)
					{
						_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = _003C_003Ec__DisplayClass74_2.ed1SSR1uqYa.VpumGqYoKI();
						break;
					}
					return (isSuccess: false, message: "未选择窗口", failReason: ActionStopFlag.UserCancel);
				}
				case "pointing_now":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition());
					break;
				case "pointing_root":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(djQSSCAvOmr.TargetInfo.HWnd);
					break;
				case "child_windows":
				{
					string textParamValue7 = XActionHelper.GetTextParamValue(W1lgghYJdv2, HDcSS0bF4En, djQSSCAvOmr);
					string textParamValue8 = XActionHelper.GetTextParamValue(JTiggeUAZkI, HDcSS0bF4En, djQSSCAvOmr);
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = (IntPtr)Convert.ToInt32(XActionHelper.GetIntegerParamValue(dIFgg9ueM1a, HDcSS0bF4En, djQSSCAvOmr));
					if (_003C_003Ec__DisplayClass74_.ahvSSaGS5rL == IntPtr.Zero)
					{
						_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(NativeMethods.GetForegroundWindow());
					}
					bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(_useRegexParam, HDcSS0bF4En, djQSSCAvOmr);
					try
					{
						Dictionary<string, string> result2 = OpenWindowGetter.FindChildWindows(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, textParamValue7, textParamValue8, booleanParamValue3).ToDictionary(_003C_003Ec.mZuSS2cYfWx ?? (_003C_003Ec.mZuSS2cYfWx = _003C_003Ec.yhgSSS1pU4L.kabSSgwKQWn), _003C_003Ec.JroSSuOlZyr ?? (_003C_003Ec.JroSSuOlZyr = _003C_003Ec.yhgSSS1pU4L.joySSLdAErZ));
						XActionHelper.OutputResult(dbAgg5BtRN6, HDcSS0bF4En, djQSSCAvOmr, result2, dM5SSPXFhfx);
					}
					catch (Exception ex)
					{
						throw ex;
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				case "findChildWindow":
				{
					string textParamValue = XActionHelper.GetTextParamValue(W1lgghYJdv2, HDcSS0bF4En, djQSSCAvOmr);
					string textParamValue2 = XActionHelper.GetTextParamValue(JTiggeUAZkI, HDcSS0bF4En, djQSSCAvOmr);
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = (IntPtr)Convert.ToInt32(XActionHelper.GetIntegerParamValue(dIFgg9ueM1a, HDcSS0bF4En, djQSSCAvOmr));
					if (_003C_003Ec__DisplayClass74_.ahvSSaGS5rL == IntPtr.Zero)
					{
						_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(NativeMethods.GetForegroundWindow());
					}
					IntPtr intPtr = OpenWindowGetter.FindChildWindow(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, textParamValue, textParamValue2);
					XActionHelper.OutputResult(ONFgg1FiGvS, HDcSS0bF4En, djQSSCAvOmr, intPtr, dM5SSPXFhfx);
					if (intPtr == IntPtr.Zero)
					{
						return (isSuccess: false, message: "未找到子窗口", failReason: ActionStopFlag.OperationFailed);
					}
					NativeMethods.GetWindowRect(intPtr, out var lpRect);
					if (XActionHelper.IsOutputParamSetted(grnggp5qLPb.Key, HDcSS0bF4En))
					{
						XActionHelper.OutputResult(grnggp5qLPb, HDcSS0bF4En, djQSSCAvOmr, $"{lpRect.Left},{lpRect.Top},{lpRect.Right},{lpRect.Bottom}", dM5SSPXFhfx);
					}
					if (XActionHelper.IsOutputParamSetted(s0qggBqo6ji.Key, HDcSS0bF4En))
					{
						Dictionary<string, object> result = new Dictionary<string, object>
						{
							["Left"] = lpRect.Left,
							["Top"] = lpRect.Top,
							["Right"] = lpRect.Right,
							["Bottom"] = lpRect.Bottom,
							["Width"] = lpRect.Right - lpRect.Left,
							["Height"] = lpRect.Bottom - lpRect.Top
						};
						XActionHelper.OutputResult(s0qggBqo6ji, HDcSS0bF4En, djQSSCAvOmr, result, dM5SSPXFhfx);
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				case "pointing_now_root":
					_003C_003Ec__DisplayClass74_.ahvSSaGS5rL = NativeMethods.GetRootWindow(NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition()));
					break;
				}
				if (_003C_003Ec__DisplayClass74_.ahvSSaGS5rL == IntPtr.Zero)
				{
					string item = "未找到窗口。";
					return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
				}
				if (!NativeMethods.IsWindow(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL))
				{
					return (isSuccess: false, message: "窗口不存在", failReason: ActionStopFlag.OperationFailed);
				}
				if (XActionHelper.IsOutputParamSetted(PpqggsiFotJ.Key, HDcSS0bF4En))
				{
					try
					{
						string windowTitle = NativeMethods.GetWindowTitle(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL);
						XActionHelper.OutputResult(PpqggsiFotJ, HDcSS0bF4En, djQSSCAvOmr, windowTitle, dM5SSPXFhfx);
					}
					catch (Exception ex2)
					{
						djQSSCAvOmr.ActionLogger.LogWarning("无法获取窗口标题：" + ex2.Message);
						XActionHelper.OutputResult(PpqggsiFotJ, HDcSS0bF4En, djQSSCAvOmr, "", dM5SSPXFhfx);
					}
				}
				if (XActionHelper.IsOutputParamSetted(ztMggHjvxCL.Key, HDcSS0bF4En))
				{
					try
					{
						string windowClass = NativeMethods.GetWindowClass(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL);
						XActionHelper.OutputResult(ztMggHjvxCL, HDcSS0bF4En, djQSSCAvOmr, windowClass, dM5SSPXFhfx);
					}
					catch (Exception ex3)
					{
						djQSSCAvOmr.ActionLogger.LogWarning("无法获取窗口类名：" + ex3.Message);
						XActionHelper.OutputResult(ztMggHjvxCL, HDcSS0bF4En, djQSSCAvOmr, "", dM5SSPXFhfx);
					}
				}
				if (XActionHelper.IsOutputParamSetted(ONFgg1FiGvS.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(ONFgg1FiGvS, HDcSS0bF4En, djQSSCAvOmr, _003C_003Ec__DisplayClass74_.ahvSSaGS5rL, dM5SSPXFhfx);
				}
				if (XActionHelper.IsOutputParamSetted(fmVggm94ike.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(fmVggm94ike, HDcSS0bF4En, djQSSCAvOmr, NativeMethods.GetAncestor(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, NativeMethods.GetAncestorFlags.GetParent), dM5SSPXFhfx);
				}
				if (XActionHelper.IsOutputParamSetted(HyxggKwSEZy.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(HyxggKwSEZy, HDcSS0bF4En, djQSSCAvOmr, NativeMethods.GetAncestor(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, NativeMethods.GetAncestorFlags.GetRoot), dM5SSPXFhfx);
				}
				if (XActionHelper.IsOutputParamSetted(pKTggx5exvt.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(pKTggx5exvt, HDcSS0bF4En, djQSSCAvOmr, NativeMethods.GetAncestor(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, NativeMethods.GetAncestorFlags.GetRootOwner), dM5SSPXFhfx);
				}
				int windowProcessId = NativeMethods.GetWindowProcessId(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL);
				if (XActionHelper.IsOutputParamSetted(pP0ggb6f1OL.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(pP0ggb6f1OL, HDcSS0bF4En, djQSSCAvOmr, windowProcessId, dM5SSPXFhfx);
				}
				bool booleanParamValue4 = XActionHelper.GetBooleanParamValue(LD1ggW7yNJN, HDcSS0bF4En, djQSSCAvOmr);
				NativeMethods.RECT lpRect2 = default(NativeMethods.RECT);
				if (booleanParamValue4)
				{
					NativeMethods.GetWindowRect(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL, out lpRect2);
				}
				else
				{
					lpRect2 = NativeMethods.GetWindowRectangle(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL);
				}
				if (XActionHelper.IsOutputParamSetted(fQQggrS2hVj.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(fQQggrS2hVj, HDcSS0bF4En, djQSSCAvOmr, $"{lpRect2.Left},{lpRect2.Top},{lpRect2.Right},{lpRect2.Bottom},{lpRect2.Right - lpRect2.Left},{lpRect2.Bottom - lpRect2.Top}", dM5SSPXFhfx);
				}
				if (XActionHelper.IsOutputParamSetted(grnggp5qLPb.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(grnggp5qLPb, HDcSS0bF4En, djQSSCAvOmr, $"{lpRect2.Left},{lpRect2.Top},{lpRect2.Right},{lpRect2.Bottom}", dM5SSPXFhfx);
				}
				if (XActionHelper.IsOutputParamSetted(s0qggBqo6ji.Key, HDcSS0bF4En))
				{
					Dictionary<string, object> result3 = new Dictionary<string, object>
					{
						["Left"] = lpRect2.Left,
						["Top"] = lpRect2.Top,
						["Right"] = lpRect2.Right,
						["Bottom"] = lpRect2.Bottom,
						["Width"] = lpRect2.Right - lpRect2.Left,
						["Height"] = lpRect2.Bottom - lpRect2.Top
					};
					XActionHelper.OutputResult(s0qggBqo6ji, HDcSS0bF4En, djQSSCAvOmr, result3, dM5SSPXFhfx);
				}
				XActionHelper.OutputResultIfNeeded(UKxggjGnVqk, _003C_003Ec__DisplayClass74_.vjcSSEObLfk, HDcSS0bF4En, djQSSCAvOmr, dM5SSPXFhfx);
				if (XActionHelper.IsOutputParamSetted(LJpggnOQKEC.Key, HDcSS0bF4En))
				{
					XActionHelper.OutputResult(LJpggnOQKEC, HDcSS0bF4En, djQSSCAvOmr, WindowHelper.GetWindowState(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL), dM5SSPXFhfx);
				}
				XActionHelper.OutputResultIfNeeded(c8Pgg4dy3I8, _003C_003Ec__DisplayClass74_.SuXSSygCCqx, HDcSS0bF4En, djQSSCAvOmr, dM5SSPXFhfx);
				if (XActionHelper.IsOutputParamSetted(dbAgg5BtRN6.Key, HDcSS0bF4En))
				{
					Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
					foreach (KeyValuePair<IntPtr, string> allChildHandle in OpenWindowGetter.GetAllChildHandles(_003C_003Ec__DisplayClass74_.ahvSSaGS5rL))
					{
						dictionary2.Add(allChildHandle.Key.ToString(), allChildHandle.Value);
					}
					XActionHelper.OutputResult(dbAgg5BtRN6, HDcSS0bF4En, djQSSCAvOmr, dictionary2, dM5SSPXFhfx);
				}
				XActionHelper.OutputResultIfNeeded(Bv4ggQNJLGu, _003C_003Ec__DisplayClass74_.mbcSS8xxFaN, HDcSS0bF4En, djQSSCAvOmr, dM5SSPXFhfx);
				if (XActionHelper.IsOutputParamSetted(mwngg6qdgXI.Key, HDcSS0bF4En) || XActionHelper.IsOutputParamSetted(T3pggXNmlom.Key, HDcSS0bF4En))
				{
					try
					{
						using Process process = Process.GetProcessById(windowProcessId);
						ProcessModule mainModule = process.MainModule;
						object obj2;
						if (mainModule == null)
						{
							obj2 = null;
						}
						else
						{
							obj2 = mainModule.FileName;
							if (obj2 != null)
							{
								goto IL_0f86;
							}
						}
						obj2 = string.Empty;
						goto IL_0f86;
						IL_0f86:
						string result4 = (string)obj2;
						string processName = process.ProcessName;
						try
						{
							if (HostedProcessHelper.IsHostProcess(process.ProcessName))
							{
								using Process process2 = HostedProcessHelper.GetRealProcess(process);
								object obj3;
								if (process2 != null)
								{
									ProcessModule mainModule2 = process2.MainModule;
									if (mainModule2 == null)
									{
										obj3 = null;
									}
									else
									{
										obj3 = mainModule2.FileName;
										if (obj3 != null)
										{
											goto IL_0fc8;
										}
									}
									obj3 = string.Empty;
									goto IL_0fc8;
								}
								goto end_IL_0fa8;
								IL_0fc8:
								result4 = (string)obj3;
								processName = process2.ProcessName;
								end_IL_0fa8:;
							}
						}
						catch (Exception ex4)
						{
							djQSSCAvOmr.ActionLogger.LogWarning("获取UWP进程信息失败。" + ex4.Message);
						}
						XActionHelper.OutputResult(mwngg6qdgXI, HDcSS0bF4En, djQSSCAvOmr, processName, dM5SSPXFhfx);
						XActionHelper.OutputResult(T3pggXNmlom, HDcSS0bF4En, djQSSCAvOmr, result4, dM5SSPXFhfx);
					}
					catch (Exception ex5)
					{
						djQSSCAvOmr.ActionLogger.LogWarning("获取窗口进程信息失败：" + ex5.Message);
						XActionHelper.OutputResult(mwngg6qdgXI, HDcSS0bF4En, djQSSCAvOmr, "", dM5SSPXFhfx);
						XActionHelper.OutputResult(T3pggXNmlom, HDcSS0bF4En, djQSSCAvOmr, "", dM5SSPXFhfx);
					}
				}
			}
			catch (Exception ex6)
			{
				string item2 = "获取窗口信息失败。" + ex6.Message;
				return (isSuccess: false, message: item2, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool wt2lxBW1r7vF9Hv1ynMO()
		{
			return QRoZ7uW1a9p7u9oIgqER == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass74_1
	{
		public IntPtr ahvSSaGS5rL;

		private static _003C_003Ec__DisplayClass74_1 CdAGgNW194IBsZS2Beor;

		internal object vjcSSEObLfk()
		{
			return NativeMethods.IsWindowVisible(ahvSSaGS5rL);
		}

		internal object SuXSSygCCqx()
		{
			return WindowHelper.LLXLF6Ttuxf(ahvSSaGS5rL);
		}

		internal object mbcSS8xxFaN()
		{
			return NativeMethods.IsWindowTopMost(ahvSSaGS5rL);
		}

		internal static bool oISrcJW1Lr4TXyTwt08o()
		{
			return CdAGgNW194IBsZS2Beor == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass74_2
	{
		public qsQtMm5MtHtoYi1dcdV ed1SSR1uqYa;

		internal static _003C_003Ec__DisplayClass74_2 naeWkcW1omoyMFJjgUlB;

		internal void CnlSS7gMUb1()
		{
			try
			{
				ed1SSR1uqYa = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Window);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning(exception.GetMessageWithInner() ?? "");
			}
		}

		internal static bool wGqDByW1f8KKQd6ry0hk()
		{
			return naeWkcW1omoyMFJjgUlB == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> vb0gg7HkL0E;

	[CompilerGenerated]
	private readonly string bKOggRhZ0k8 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> nsWggqg0mkY;

	[CompilerGenerated]
	private readonly string cIJggcfsDbR = "https://getquicker.net/KC/Help/Doc/getwindowtitle";

	[CompilerGenerated]
	private readonly bool SysggVjNDRw;

	public const string WINDOW_FOREGROUND = "foreground";

	public const string WINDOW_SELECTWINDOW = "selectWindow";

	public const string WINDOW_POINTING = "pointing";

	public const string WINDOW_POINTING_ROOT = "pointing_root";

	public const string WINDOW_BY_HWND = "fromHwnd";

	public const string FIND_WINDOW = "findWindow";

	public const string FIND_CHILD_WINDOW = "findChildWindow";

	private static readonly StepInParamDef AasggZ7PIPH;

	private static readonly StepInParamDef dIFgg9ueM1a;

	private static readonly StepInParamDef W1lgghYJdv2;

	private static readonly StepInParamDef JTiggeUAZkI;

	private static readonly StepInParamDef BLPggYDuLud;

	private static readonly StepInParamDef UUqggIBJOXp;

	public static readonly StepInParamDef _requireTitleParam;

	private static readonly StepInParamDef LD1ggW7yNJN;

	public static readonly StepInParamDef _useRegexParam;

	private static readonly StepInParamDef MmMggkqRZtS;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> MHpggGYpmJi = new StepInParamDef[10] { AasggZ7PIPH, dIFgg9ueM1a, W1lgghYJdv2, JTiggeUAZkI, BLPggYDuLud, UUqggIBJOXp, _requireTitleParam, _useRegexParam, LD1ggW7yNJN, MmMggkqRZtS };

	private static readonly StepOutParamDef PpqggsiFotJ;

	private static readonly StepOutParamDef ztMggHjvxCL;

	private static readonly StepOutParamDef ONFgg1FiGvS;

	private static readonly StepOutParamDef pP0ggb6f1OL;

	private static readonly StepOutParamDef mwngg6qdgXI;

	private static readonly StepOutParamDef T3pggXNmlom;

	private static readonly StepOutParamDef fmVggm94ike;

	private static readonly StepOutParamDef HyxggKwSEZy;

	private static readonly StepOutParamDef pKTggx5exvt;

	private static readonly StepOutParamDef fQQggrS2hVj;

	private static readonly StepOutParamDef grnggp5qLPb;

	private static readonly StepOutParamDef s0qggBqo6ji;

	private static readonly StepOutParamDef Bv4ggQNJLGu;

	private static readonly StepOutParamDef UKxggjGnVqk;

	private static readonly StepOutParamDef LJpggnOQKEC;

	private static readonly StepOutParamDef c8Pgg4dy3I8;

	private static readonly StepOutParamDef dbAgg5BtRN6;

	private static readonly StepOutParamDef YbZggDwq5vB;

	private static readonly StepOutParamDef kGLggdiYjFg;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> G27ggoaqgCo = new StepOutParamDef[19]
	{
		kGLggdiYjFg, PpqggsiFotJ, ztMggHjvxCL, ONFgg1FiGvS, pP0ggb6f1OL, mwngg6qdgXI, T3pggXNmlom, fmVggm94ike, HyxggKwSEZy, pKTggx5exvt,
		fQQggrS2hVj, grnggp5qLPb, s0qggBqo6ji, Bv4ggQNJLGu, UKxggjGnVqk, LJpggnOQKEC, c8Pgg4dy3I8, dbAgg5BtRN6, YbZggDwq5vB
	};

	internal static GetWindowInfoStep Ewj6eoQRr7XaiUSYRUcD;

	public string Key => "sys:getWindowTitle";

	public string Name => "获取窗口信息/查找窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return vb0gg7HkL0E;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return bKOggRhZ0k8;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return nsWggqg0mkY;
		}
	}

	public string Description => "获取指定窗口的标题等信息。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return cIJggcfsDbR;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return SysggVjNDRw;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return MHpggGYpmJi;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return G27ggoaqgCo;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
		_003C_003Ec__DisplayClass74_.HDcSS0bF4En = step;
		_003C_003Ec__DisplayClass74_.djQSSCAvOmr = context;
		_003C_003Ec__DisplayClass74_.dM5SSPXFhfx = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass74_.djQSSCAvOmr, _003C_003Ec__DisplayClass74_.HDcSS0bF4En, _003C_003Ec__DisplayClass74_.dM5SSPXFhfx, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass74_.PC6SSJy6jnV, (Action)null, (Action)null, MmMggkqRZtS, kGLggdiYjFg);
	}

	internal static int[] GTqggaHUWCj(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			return Array.Empty<int>();
		}
		if (int.TryParse(string_2, out var result))
		{
			return new int[1] { result };
		}
		Process[] processesByName = Process.GetProcessesByName(string_2);
		if (processesByName.Length == 0)
		{
			throw new InvalidDataException("不存在进程：" + string_2);
		}
		return processesByName.Select(_003C_003Ec.ryfSSNmVlgE ?? (_003C_003Ec.ryfSSNmVlgE = _003C_003Ec.yhgSSS1pU4L.aUfSSvFWo3F)).ToArray();
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(AasggZ7PIPH, step) ?? "";
	}

	static GetWindowInfoStep()
	{
		AasggZ7PIPH = new StepInParamDef
		{
			Key = "which",
			Name = "目标窗口",
			Description = "判断哪个窗口的信息",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "foreground",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("foreground", "前台窗口"),
				new SelectionItem("selectWindow", "选择一个窗口"),
				new SelectionItem("pointing", "弹出面板前鼠标位置的窗口（可能为子窗口）"),
				new SelectionItem("pointing_root", "弹出面板前鼠标位置窗口的根窗口"),
				new SelectionItem("pointing_now", "当前鼠标位置的窗口（可能为子窗口）"),
				new SelectionItem("pointing_now_root", "当前鼠标位置窗口的根窗口"),
				new SelectionItem("fromHwnd", "句柄指定的窗口"),
				new SelectionItem("findWindow", "查找顶层窗口 (单个窗口)"),
				new SelectionItem("top_windows", "所有顶层窗口"),
				new SelectionItem("findChildWindow", "查找子窗口/控件 (单个窗口)"),
				new SelectionItem("child_windows", "查找子窗口 (多个窗口)")
			},
			IsControlField = true
		};
		dIFgg9ueM1a = new StepInParamDef
		{
			Key = "hWnd",
			Name = "窗口句柄hWnd",
			Description = "未指定时使用前台窗口句柄",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[3] { "fromHwnd", "findChildWindow", "child_windows" }
		};
		W1lgghYJdv2 = new StepInParamDef
		{
			Key = "className",
			Name = "窗口类名",
			Description = "要查找窗口的类名（ClassName），为空时不检查此项。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[4] { "findWindow", "top_windows", "findChildWindow", "child_windows" },
			TextTools = new List<TextToolType> { TextToolType.SelectWindowClass },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		JTiggeUAZkI = new StepInParamDef
		{
			Key = "windowName",
			Name = "窗口名称",
			Description = "要查找窗口的标题，为空时不检查此项。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[4] { "findWindow", "top_windows", "findChildWindow", "child_windows" },
			TextTools = new List<TextToolType> { TextToolType.SelectWindowTitle },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		BLPggYDuLud = new StepInParamDef
		{
			Key = "procIdOrName",
			Name = "进程名/pid",
			Description = "要查找窗口所属的进程名或pid，为空时不检查此项。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[2] { "findWindow", "top_windows" },
			TextTools = new List<TextToolType> { TextToolType.SelectProcessName }
		};
		UUqggIBJOXp = new StepInParamDef
		{
			Key = "onlyVisible",
			Name = "仅可见窗口",
			Description = "",
			DefaultValue = "default",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("default", "未指定"),
				new SelectionItem("1", "仅可见窗口"),
				new SelectionItem("0", "所有窗口")
			},
			ValidForList = new string[2] { "top_windows", "findWindow" }
		};
		_requireTitleParam = new StepInParamDef
		{
			Key = "requireTitle",
			Name = "仅名称(标题)不为空的窗口",
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			ValidForList = new string[2] { "top_windows", "findWindow" }
		};
		LD1ggW7yNJN = new StepInParamDef
		{
			Key = "winRectIncludeInvisibleBorder",
			Name = "窗口位置包含不可见边框（阴影区域）",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		_useRegexParam = new StepInParamDef
		{
			Key = "useRegex",
			Name = "使用正则匹配窗口类名和标题",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "findWindow", "top_windows", "child_windows" }
		};
		MmMggkqRZtS = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		PpqggsiFotJ = new StepOutParamDef
		{
			Key = "output",
			Name = "窗口标题",
			Description = "窗口的标题文字",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		ztMggHjvxCL = new StepOutParamDef
		{
			Key = "className",
			Name = "类名",
			Description = "窗口的 Class Name",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		ONFgg1FiGvS = new StepOutParamDef
		{
			Key = "handle",
			Name = "句柄",
			Description = "窗口的句柄",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "child_windows" }
		};
		pP0ggb6f1OL = new StepOutParamDef
		{
			Key = "pid",
			Name = "进程ID",
			Description = "窗口所属进程的ID",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		mwngg6qdgXI = new StepOutParamDef
		{
			Key = "procName",
			Name = "进程名",
			Description = "进程名称",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		T3pggXNmlom = new StepOutParamDef
		{
			Key = "path",
			Name = "程序路径",
			Description = "获得的进程路径",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		fmVggm94ike = new StepOutParamDef
		{
			Key = "parent",
			Name = "父窗口句柄",
			Description = "",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		HyxggKwSEZy = new StepOutParamDef
		{
			Key = "root",
			Name = "根窗口句柄",
			Description = "",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		pKTggx5exvt = new StepOutParamDef
		{
			Key = "rootOwner",
			Name = "根所有者窗口句柄",
			Description = "",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		fQQggrS2hVj = new StepOutParamDef
		{
			Key = "rect",
			Name = "窗口位置",
			Description = "文本值，格式为:Left,Top,Right,Bottom,Width,Height。",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		grnggp5qLPb = new StepOutParamDef
		{
			Key = "rectNoSize",
			Name = "窗口位置(不含尺寸)",
			Description = "文本值，格式为:Left,Top,Right,Bottom。如:0,0,100,100",
			Type = VarType.Text,
			InvalidForList = new List<string> { "top_windows", "child_windows" }
		};
		s0qggBqo6ji = new StepOutParamDef
		{
			Key = "rectDict",
			Name = "窗口位置(词典值)",
			Description = "词典值，属性为:Left,Top,Right,Bottom,Width,Height",
			Type = VarType.Dict,
			InvalidForList = new List<string> { "top_windows", "child_windows" }
		};
		Bv4ggQNJLGu = new StepOutParamDef
		{
			Key = "isTopmost",
			Name = "是否置顶",
			Description = "",
			Type = VarType.Boolean,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		UKxggjGnVqk = new StepOutParamDef
		{
			Key = "isVisible",
			Name = "是否可见",
			Description = "",
			Type = VarType.Boolean,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		LJpggnOQKEC = new StepOutParamDef
		{
			Key = "showState",
			Name = "显示状态",
			Description = "1:普通，2:最小化，3:最大化。",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		c8Pgg4dy3I8 = new StepOutParamDef
		{
			Key = "alpha",
			Name = "不透明度",
			Description = "窗口的透明度，范围为0-255。0表示全透明",
			Type = VarType.Integer,
			InvalidForList = new List<string> { "top_windows", "findChildWindow", "child_windows" }
		};
		dbAgg5BtRN6 = new StepOutParamDef
		{
			Key = "allChildWindows",
			Name = "所有子窗口",
			Description = "词典值，Key为窗口句柄，Value为窗口标题",
			Type = VarType.Dict,
			InvalidForList = new string[2] { "top_windows", "findChildWindow" }
		};
		YbZggDwq5vB = new StepOutParamDef
		{
			Key = "topLevelWindows",
			Name = "所有顶层窗口",
			Description = "词典值，Key为窗口句柄，Value为窗口标题",
			Type = VarType.Dict,
			ValidForList = new string[1] { "top_windows" }
		};
		kGLggdiYjFg = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool BbrL7oQRNGOrErr7VI4O()
	{
		return Ewj6eoQRr7XaiUSYRUcD == null;
	}
}
