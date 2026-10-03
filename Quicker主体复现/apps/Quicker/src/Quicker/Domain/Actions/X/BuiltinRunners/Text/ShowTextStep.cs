using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using FontAwesome5;
using HandyControl.Tools;
using ICSharpCode.AvalonEdit.Highlighting;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View;
using SCyJThYoNMQE7IHLXbA;
using t7wokwYFlDgjUncgQNA;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class ShowTextStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec CvAS2laQlvl;

		public static Func<SimpleOperationItem, bool> PDnS2i2pON3;

		private static _003C_003Ec Fl5H6yWKsonv6nkUfMvP;

		static _003C_003Ec()
		{
			CvAS2laQlvl = new _003C_003Ec();
		}

		internal bool oMZS2U9JNJs(SimpleOperationItem x)
		{
			if (!string.IsNullOrEmpty(x.Key))
			{
				if (x.Key.IndexOf("call:", StringComparison.OrdinalIgnoreCase) != 0)
				{
					return x.Name.StartsWith("[+]");
				}
				return true;
			}
			return false;
		}

		internal static bool de9dSGWKCBPtrHWoC9tL()
		{
			return Fl5H6yWKsonv6nkUfMvP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass77_0
	{
		public ActionStep zwnS2flJSSV;

		public ActionExecuteContext UdsS2z5UOk8;

		public XAction K8ASuw0gPXD;

		public ShowTextStep oqeSutWW4SX;

		internal static _003C_003Ec__DisplayClass77_0 igCGkTWK4Ed9Lhtug7sb;

		internal (bool isSuccess, string message, ActionStopFlag failReason) b9pS23ngob1()
		{
			string textParamValue = XActionHelper.GetTextParamValue(ttvgSKETTbc, zwnS2flJSSV, UdsS2z5UOk8);
			string text = XActionHelper.GetTextParamValue(zmagSpCQeIp, zwnS2flJSSV, UdsS2z5UOk8);
			if (text == "=")
			{
				text = UdsS2z5UOk8.ActionId;
			}
			switch (textParamValue)
			{
			case "GET_ACTION_WINDOWS":
				return oqeSutWW4SX.euggSZT9Pbw(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD);
			case "GET_ALL_WINDOWS":
				return oqeSutWW4SX.v4OgS931aDL(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD);
			case "ACTIVATE_WINDOW":
				return K8agSs80v1k(text);
			case "WAIT":
			case "NO_WAIT":
				return PNCgSkF5ePm(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD, textParamValue, text);
			case "WAIT_CLOSE":
				return oqeSutWW4SX.U1ogShfxmj8(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD, text);
			case "APPEND_TEXT":
				return oqeSutWW4SX.vakgSIwdMI0(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD, text);
			case "GET_WIN_INFO":
				return oqeSutWW4SX.HsagSYyhD5I(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD, text);
			case "CLOSE_WINDOW":
				return g19gSHJUWpF(zwnS2flJSSV, UdsS2z5UOk8, K8ASuw0gPXD, text);
			default:
				return (isSuccess: false, message: "未知的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			}
		}

		internal static bool qRMK7jWKhSx2RfGibB0f()
		{
			return igCGkTWK4Ed9Lhtug7sb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_0
	{
		public ActionExecuteContext p1gSuLQnRc4;

		public Dictionary<string, string> OigSuvSY6vW;

		private static _003C_003Ec__DisplayClass78_0 W5CiRRWKzZ6ZG0FqXLH9;

		internal void SbSSughSyLC()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (item.IsLoaded && item.ActionId == p1gSuLQnRc4.ActionId)
				{
					OigSuvSY6vW.Add(item.GetHandle().ToString(), item.AutoCloseKey);
				}
			}
		}

		internal static bool Ph2VpDWBVaIrPJCGXAdj()
		{
			return W5CiRRWKzZ6ZG0FqXLH9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass79_0
	{
		public Dictionary<string, string> UhOSu2yfOjd;

		internal static _003C_003Ec__DisplayClass79_0 TRgVHZWBc5tnhkQTKGTs;

		internal void caLSuScIAV9()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (item.IsLoaded)
				{
					UhOSu2yfOjd.Add(item.GetHandle().ToString(), item.AutoCloseKey);
				}
			}
		}

		internal static bool Wob1PnWBW6tXhyRnq95o()
		{
			return TRgVHZWBc5tnhkQTKGTs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass80_0
	{
		public TextWindow WJySuNkcNl1;

		public ShowTextStep mePSuJ4ClS0;

		public string axdSu01gKD9;

		internal static _003C_003Ec__DisplayClass80_0 EkAEfZWBpt2QU2PGjRQH;

		internal void evOSuujunWE()
		{
			WJySuNkcNl1 = mePSuJ4ClS0.NbZgSGJI4uB(axdSu01gKD9);
		}

		static _003C_003Ec__DisplayClass80_0()
		{
		}

		internal static bool gd8s79WBX4olRaj3fDOd()
		{
			return EkAEfZWBpt2QU2PGjRQH == null;
		}

		internal static void k7umaEWBAAxEBUM66gvT()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_0
	{
		public string Ai7SuPcGkwj;

		public ActionStep GkFSuEInpVO;

		public ActionExecuteContext cfpSuyi62wy;

		public XAction uORSu857UDF;

		public bool UBYSuaGftXw;

		private static _003C_003Ec__DisplayClass82_0 eQ0gX6WBnXr3JId57sCS;

		internal void o5rSuCI2O7d()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (!(item.AutoCloseKey == Ai7SuPcGkwj) || !item.IsLoaded)
				{
					continue;
				}
				XActionHelper.OutputResult(uKRg2tSHQxv, GkFSuEInpVO, cfpSuyi62wy, item.ResultText ?? "", uORSu857UDF);
				XActionHelper.OutputResult(kaPg2LJTUR6, GkFSuEInpVO, cfpSuyi62wy, item.SelectedText ?? "", uORSu857UDF);
				if (E1LCEQWBebnGtbDnnFxr())
				{
					switch (0)
					{
					}
				}
				XActionHelper.OutputResult(zTfg2vN7aWC, GkFSuEInpVO, cfpSuyi62wy, item.LastWindowLocation, uORSu857UDF);
				XActionHelper.OutputResult(B4Xg2gC8GPK, GkFSuEInpVO, cfpSuyi62wy, item.GetHandle(), uORSu857UDF);
				UBYSuaGftXw = true;
				break;
			}
		}

		internal static bool E1LCEQWBebnGtbDnnFxr()
		{
			return eQ0gX6WBnXr3JId57sCS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass83_0
	{
		public string TOrSuRlRJ2j;

		public string FjsSuqlYIPN;

		public bool kiGSucJfnVJ;

		internal static _003C_003Ec__DisplayClass83_0 it9oepWBEp4fitmK5P12;

		internal void bWySu76mM3i()
		{
			int num2 = default(int);
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				int num = 0;
				if (!QnaaiYWBGqXCT8QB3CxO())
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (item.AutoCloseKey == TOrSuRlRJ2j && item.IsLoaded)
				{
					item.FWqgU6u114f(FjsSuqlYIPN);
					kiGSucJfnVJ = true;
					return;
				}
			}
		}

		static _003C_003Ec__DisplayClass83_0()
		{
		}

		internal static bool QnaaiYWBGqXCT8QB3CxO()
		{
			return it9oepWBEp4fitmK5P12 == null;
		}

		internal static void SGHBh6WB17Ef6uccoVB5()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass85_0
	{
		public string DRYSu9NVv6M;

		public string qULSuhffPIa;

		public bool yJZSue9cOli;

		public ActionExecuteContext kftSuY3EWFs;

		public bool f4uSuIyVLkC;

		public string l09SuWWCriU;

		public string sXqSukRA60P;

		public bool F8JSuGG29Q1;

		public string gkPSusjbSIF;

		public long GNGSuHRbdIZ;

		public string g4NSu1NBNmj;

		public string hnfSub9bTc7;

		public string ppLSu65tmSg;

		public string nGtSuXWfTHO;

		public ShowWindowLocation pXvSumMecKg;

		public string DbqSuKW7ywG;

		public double vWZSux0sIZl;

		public bool fGYSurFXZqo;

		public bool RKpSups6VP8;

		public bool XXjSuBQCGxd;

		public ActionStep vuvSuQfqZE9;

		public bool cwaSujjTdxi;

		public string UIcSunfFb7r;

		public bool Tx6Su4H5tht;

		public string en5Su5oafTA;

		public string z4OSuDLXsor;

		public string NYsSudu4OvT;

		public string CUkSuol1mWx;

		public XAction nrESuTLsgP1;

		internal static _003C_003Ec__DisplayClass85_0 BnVKACWBK6yCgd8p2ye7;

		internal bool UHWSuVuifuk(string x)
		{
			return x != DRYSu9NVv6M;
		}

		internal void ixSSuZINZe6()
		{
			int num = 3;
			bool flag2 = default(bool);
			while (true)
			{
				_003C_003Ec__DisplayClass85_1 _003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_1();
				while (true)
				{
					IL_000d:
					_003C_003Ec__DisplayClass85_.xbmSuFhllam = this;
					Rect? rect = null;
					bool flag = false;
					int num2 = 4;
					if (BnVKACWBK6yCgd8p2ye7 != null)
					{
						goto IL_002f;
					}
					goto IL_0059;
					IL_0059:
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT = null;
					flag2 = false;
					if (string.IsNullOrEmpty(qULSuhffPIa))
					{
						goto IL_0083;
					}
					num2 = 4;
					if (BnVKACWBK6yCgd8p2ye7 == null)
					{
						goto IL_002f;
					}
					goto IL_01dd;
					IL_04d8:
					string textParamValue = XActionHelper.GetTextParamValue(OperationInputParam, vuvSuQfqZE9, kftSuY3EWFs);
					if (!string.IsNullOrEmpty(textParamValue))
					{
						List<SimpleOperationItem> list = AppHelper.StringToOperationItems(textParamValue, false, true);
						if (!f4uSuIyVLkC)
						{
							list = list.Where(_003C_003Ec.PDnS2i2pON3 ?? (_003C_003Ec.PDnS2i2pON3 = _003C_003Ec.CvAS2laQlvl.oMZS2U9JNJs)).ToList();
						}
						_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Operations = list;
					}
					try
					{
						if (f4uSuIyVLkC)
						{
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Show();
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Activate();
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Closed += _003C_003Ec__DisplayClass85_.Qn3SuMmM08a;
							return;
						}
						if (!flag2)
						{
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Show();
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Activate();
						}
						XActionHelper.OutputResultIfNeeded(B4Xg2gC8GPK, _003C_003Ec__DisplayClass85_.qH3SuAWtdk3, vuvSuQfqZE9, kftSuY3EWFs, nrESuTLsgP1);
						if (!wYuxCwWBB2hVefr4OY8n())
						{
							switch (0)
							{
							}
						}
						return;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("无法初始化文本窗口。您的电脑可能缺少文字转语音组件。" + ex.Message);
						return;
					}
					IL_0083:
					if (_003C_003Ec__DisplayClass85_.OdGSuO3GquT == null)
					{
						_003C_003Ec__DisplayClass85_.OdGSuO3GquT = new TextWindow();
						if (f4uSuIyVLkC)
						{
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.V6hgjEnp8ZH(kftSuY3EWFs.CancellationToken);
						}
						_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SpWhenWindowLoaded = l09SuWWCriU;
						_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SpWhenWindowClosing = sXqSukRA60P;
					}
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.AutoCloseKey = qULSuhffPIa;
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.DisableCloseByEsc = F8JSuGG29Q1;
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.ActionId = kftSuY3EWFs.ActionId;
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.ActionContext = kftSuY3EWFs;
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetText(gkPSusjbSIF, (int)GNGSuHRbdIZ);
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Title = AppHelper.NormalizeWindowTitle(g4NSu1NBNmj);
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.ShowActivated = true;
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetBackgroundColor(hnfSub9bTc7);
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetTextColor(ppLSu65tmSg);
					_003C_003Ec__DisplayClass85_.OdGSuO3GquT.AutoSaveStateKey = nGtSuXWfTHO;
					AppHelper.SetWindowIcon(_003C_003Ec__DisplayClass85_.OdGSuO3GquT, kftSuY3EWFs?.Action?.Icon, true);
					if (!flag2)
					{
						num2 = 0;
						if (wYuxCwWBB2hVefr4OY8n())
						{
							goto IL_002f;
						}
						goto IL_01dd;
					}
					goto IL_04d8;
					IL_002f:
					while (true)
					{
						switch (num2)
						{
						case 3:
							break;
						case 2:
							goto IL_000d;
						case 7:
							goto IL_0059;
						case 6:
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.ShowBuildInToolbar = cwaSujjTdxi;
							num2 = 1;
							if (BnVKACWBK6yCgd8p2ye7 == null)
							{
								continue;
							}
							goto IL_01dd;
						case 4:
							goto IL_0207;
						default:
							if (rect.HasValue)
							{
								_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Location = ShowWindowLocation.Manual;
								_003C_003Ec__DisplayClass85_.OdGSuO3GquT.WindowSizeStr = $"{(int)rect.Value.Left},{(int)rect.Value.Top},{(int)rect.Value.Right},{(int)rect.Value.Bottom}";
								if (flag)
								{
									_003C_003Ec__DisplayClass85_.OdGSuO3GquT.WindowState = WindowState.Maximized;
								}
							}
							else
							{
								_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Location = pXvSumMecKg;
								_003C_003Ec__DisplayClass85_.OdGSuO3GquT.WindowSizeStr = DbqSuKW7ywG;
							}
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.TextFontSize = vWZSux0sIZl;
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.ShowLineNum = fGYSurFXZqo;
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.WordWrap = RKpSups6VP8;
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.CopyWholeLine = XXjSuBQCGxd;
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.Topmost = XActionHelper.GetBooleanParamValue(CdXgSjdcRqF, vuvSuQfqZE9, kftSuY3EWFs);
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.CloseWhenLostFocus = XActionHelper.GetBooleanParamValue(PKugSOGcFaS, vuvSuQfqZE9, kftSuY3EWFs);
							goto case 6;
						case 1:
							if (!string.IsNullOrEmpty(DRYSu9NVv6M))
							{
								if (UGNZKrYVGqgfWZbLcQj.HighlightingDefinitionNames.Contains(DRYSu9NVv6M))
								{
									_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetSyntaxHighlighting(DRYSu9NVv6M);
								}
								else
								{
									try
									{
										IHighlightingDefinition syntaxHighlighting = UGNZKrYVGqgfWZbLcQj.nZcLxPqL9DV(DRYSu9NVv6M);
										_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetSyntaxHighlighting(syntaxHighlighting);
									}
									catch (Exception ex2)
									{
										AppHelper.ShowWarning("加载语法高亮规则失败：" + ex2.Message);
									}
								}
							}
							if (!string.IsNullOrEmpty(UIcSunfFb7r))
							{
								goto case 5;
							}
							goto IL_04d8;
						case 5:
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT.SetFontFamily(UIcSunfFb7r);
							goto IL_04d8;
						}
						break;
					}
					break;
					IL_01dd:
					num2 = num;
					goto IL_002f;
					IL_0207:
					foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
					{
						if (!(item.AutoCloseKey == qULSuhffPIa) || !item.IsLoaded || item.IsClosed)
						{
							continue;
						}
						try
						{
							flag = item.WindowState == WindowState.Maximized;
							if (!yJZSue9cOli)
							{
								item.Close();
								continue;
							}
							_003C_003Ec__DisplayClass85_.OdGSuO3GquT = item;
							flag2 = true;
						}
						catch (Exception exception)
						{
							AppHelper.ShowWarning("关闭前序窗口出错：" + exception.GetMessageWithInner());
							continue;
						}
						break;
					}
					if (!rect.HasValue)
					{
						rect = kftSuY3EWFs.GetTextWindowLocation(qULSuhffPIa);
						flag = kftSuY3EWFs.GetTextWindowState(qULSuhffPIa) == WindowState.Maximized;
					}
					goto IL_0083;
				}
			}
		}

		internal static bool wYuxCwWBB2hVefr4OY8n()
		{
			return BnVKACWBK6yCgd8p2ye7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass85_1
	{
		public TextWindow OdGSuO3GquT;

		public _003C_003Ec__DisplayClass85_0 xbmSuFhllam;

		internal static _003C_003Ec__DisplayClass85_1 hiOgdvWBNJSD25tRpCbA;

		internal void Qn3SuMmM08a(object sender, EventArgs e)
		{
			xbmSuFhllam.Tx6Su4H5tht = true;
			xbmSuFhllam.en5Su5oafTA = OdGSuO3GquT.ResultText;
			xbmSuFhllam.z4OSuDLXsor = OdGSuO3GquT.SelectedOperation;
			xbmSuFhllam.NYsSudu4OvT = OdGSuO3GquT.SelectedText;
			xbmSuFhllam.CUkSuol1mWx = OdGSuO3GquT.LastWindowLocation;
		}

		internal object qH3SuAWtdk3()
		{
			return new WindowInteropHelper(OdGSuO3GquT).Handle;
		}

		static _003C_003Ec__DisplayClass85_1()
		{
		}

		internal static bool vRQS2uWB9qVqpY7pKZ0O()
		{
			return hiOgdvWBNJSD25tRpCbA == null;
		}

		internal static void SDQDX1WBud7GM82uqrpV()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass87_0
	{
		public string Dn0SulWND2O;

		public bool FmKSuiPrPrB;

		private static _003C_003Ec__DisplayClass87_0 KSitDpWBoVKyy0lsP1mG;

		internal void vUQSuUwyvtG()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (!(item.AutoCloseKey == Dn0SulWND2O))
				{
					continue;
				}
				if (KSitDpWBoVKyy0lsP1mG != null)
				{
					switch (0)
					{
					}
				}
				if (item.IsLoaded)
				{
					if (item.WindowState == WindowState.Minimized)
					{
						item.WindowState = WindowState.Normal;
					}
					item.Show();
					item.Activate();
					FmKSuiPrPrB = true;
					break;
				}
			}
		}

		internal static bool tvXnSLWBfT3qVm9LNDSe()
		{
			return KSitDpWBoVKyy0lsP1mG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass88_0
	{
		public string t0oSufxZyIw;

		public ActionStep w2gSuzXQPvv;

		public ActionExecuteContext AxOSNwXJhPU;

		public XAction MH2SNtlQRJf;

		public bool p5GSNgiJ5Sq;

		internal static _003C_003Ec__DisplayClass88_0 lllFN2WBqbHURkVdZs8r;

		internal void vlBSu3qfstp()
		{
			int num2 = default(int);
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (!(item.AutoCloseKey == t0oSufxZyIw) || !item.IsLoaded)
				{
					continue;
				}
				XActionHelper.OutputResult(uKRg2tSHQxv, w2gSuzXQPvv, AxOSNwXJhPU, item.ResultText ?? "", MH2SNtlQRJf);
				XActionHelper.OutputResult(kaPg2LJTUR6, w2gSuzXQPvv, AxOSNwXJhPU, item.SelectedText ?? "", MH2SNtlQRJf);
				XActionHelper.OutputResult(zTfg2vN7aWC, w2gSuzXQPvv, AxOSNwXJhPU, item.LastWindowLocation, MH2SNtlQRJf);
				int num = 0;
				if (lllFN2WBqbHURkVdZs8r != null)
				{
					num = num2;
				}
				switch (num)
				{
				default:
					try
					{
						item.Close();
					}
					catch (Exception exception)
					{
						AppHelper.ShowWarning("关闭前序窗口出错：" + exception.GetMessageWithInner());
					}
					p5GSNgiJ5Sq = true;
					break;
				}
				break;
			}
		}

		internal static bool IJ0CCsWBioqdxrIcdccD()
		{
			return lllFN2WBqbHURkVdZs8r == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> aiJgS1d1JHI = new string[9] { "窗口", "显示文本", "编辑文本", "text", "txt", "edit", "xswb", "显示或编辑文本", "xshbjwb" };

	[CompilerGenerated]
	private readonly string QTwgSbC4p7d = $"fa:{EFontAwesomeIcon.Light_WindowAlt}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> yDggS6AL0l1 = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string CwigSXF7Tuq = "https://getquicker.net/KC/Help/Doc/showText";

	[CompilerGenerated]
	private readonly bool TMBgSmi6K7y;

	public const string StepKey = "sys:showText";

	private static readonly StepInParamDef ttvgSKETTbc;

	private static readonly StepInParamDef Hg7gSxTWIDC;

	private static readonly StepInParamDef CrXgSrVKBVO;

	public static readonly StepInParamDef OperationInputParam;

	private static readonly StepInParamDef zmagSpCQeIp;

	private static readonly StepInParamDef TPpgSBLiSop;

	private static readonly StepInParamDef GShgSQPW1Eq;

	private static readonly StepInParamDef CdXgSjdcRqF;

	private static readonly StepInParamDef HuEgSnx0r5k;

	private static readonly StepInParamDef qgxgS477L0T;

	private static readonly StepInParamDef m0UgS5deUC8;

	private static readonly StepInParamDef xnagSDLU0md;

	private static readonly StepInParamDef C0OgSdilQwu;

	private static readonly StepInParamDef HQvgSofPlhN;

	private static readonly StepInParamDef eNBgSTwQRyg;

	private static readonly StepInParamDef vsJgSMchytk;

	private static readonly StepInParamDef lGWgSAJCPkl;

	private static readonly StepInParamDef PKugSOGcFaS;

	private static readonly StepInParamDef ImXgSFFmYuY;

	private static readonly StepInParamDef U18gSUph1p9;

	private static readonly StepInParamDef h1FgSlLkmIx;

	private static readonly StepInParamDef goxgSiKXB9S;

	private static readonly StepInParamDef yi3gS3uCBfJ;

	private static readonly StepInParamDef sLXgSflNEmK;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> HHLgSzesSAf = new StepInParamDef[24]
	{
		ttvgSKETTbc, Hg7gSxTWIDC, CrXgSrVKBVO, OperationInputParam, zmagSpCQeIp, TPpgSBLiSop, GShgSQPW1Eq, HuEgSnx0r5k, qgxgS477L0T, m0UgS5deUC8,
		xnagSDLU0md, C0OgSdilQwu, HQvgSofPlhN, CdXgSjdcRqF, ImXgSFFmYuY, PKugSOGcFaS, eNBgSTwQRyg, vsJgSMchytk, h1FgSlLkmIx, lGWgSAJCPkl,
		goxgSiKXB9S, yi3gS3uCBfJ, U18gSUph1p9, sLXgSflNEmK
	};

	private static readonly StepOutParamDef VBNg2w5ACvE;

	private static readonly StepOutParamDef uKRg2tSHQxv;

	private static readonly StepOutParamDef B4Xg2gC8GPK;

	private static readonly StepOutParamDef kaPg2LJTUR6;

	private static readonly StepOutParamDef zTfg2vN7aWC;

	private static readonly StepOutParamDef v2pg2SImLrV;

	private static readonly StepOutParamDef NnDg229xqFU;

	private static readonly StepOutParamDef vDqg2uC7aI1;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> kDUg2NO7Y2W = new StepOutParamDef[8] { v2pg2SImLrV, NnDg229xqFU, VBNg2w5ACvE, uKRg2tSHQxv, kaPg2LJTUR6, B4Xg2gC8GPK, zTfg2vN7aWC, vDqg2uC7aI1 };

	internal static ShowTextStep GRqkWQQgSOFiFrc0nhIo;

	public string Key => "sys:showText";

	public string Name => "文本窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return aiJgS1d1JHI;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return QTwgSbC4p7d;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Text;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return yDggS6AL0l1;
		}
	}

	public string Description => "在独立的窗口中显示文本。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return CwigSXF7Tuq;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return TMBgSmi6K7y;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return HHLgSzesSAf;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return kDUg2NO7Y2W;
		}
	}

	public ShowTextStep()
	{
		if (C0OgSdilQwu.SelectionItems.Count != 0)
		{
			return;
		}
		C0OgSdilQwu.SelectionItems.Add(new SelectionItem("", "无"));
		foreach (string item in UGNZKrYVGqgfWZbLcQj.HighlightingDefinitionNames)
		{
			if (!item.StartsWith("custom", StringComparison.OrdinalIgnoreCase))
			{
				C0OgSdilQwu.SelectionItems.Add(new SelectionItem
				{
					Value = item,
					Name = item
				});
			}
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass77_0 _003C_003Ec__DisplayClass77_ = new _003C_003Ec__DisplayClass77_0();
		_003C_003Ec__DisplayClass77_.zwnS2flJSSV = step;
		_003C_003Ec__DisplayClass77_.UdsS2z5UOk8 = context;
		_003C_003Ec__DisplayClass77_.K8ASuw0gPXD = action;
		_003C_003Ec__DisplayClass77_.oqeSutWW4SX = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass77_.UdsS2z5UOk8, _003C_003Ec__DisplayClass77_.zwnS2flJSSV, _003C_003Ec__DisplayClass77_.K8ASuw0gPXD, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass77_.b9pS23ngob1, (Action)null, (Action)null, sLXgSflNEmK, v2pg2SImLrV);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) euggSZT9Pbw(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
		_003C_003Ec__DisplayClass78_.p1gSuLQnRc4 = actionExecuteContext_0;
		_003C_003Ec__DisplayClass78_.OigSuvSY6vW = new Dictionary<string, string>();
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass78_.SbSSughSyLC);
		XActionHelper.OutputResult(vDqg2uC7aI1, actionStep_0, _003C_003Ec__DisplayClass78_.p1gSuLQnRc4, _003C_003Ec__DisplayClass78_.OigSuvSY6vW, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) v4OgS931aDL(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
		if (!string.IsNullOrEmpty(actionExecuteContext_0.Action.TemplateId))
		{
			return (isSuccess: false, message: "安全考虑，不支持在动作库安装的动作中使用获取所有文本窗口的操作。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass79_.UhOSu2yfOjd = new Dictionary<string, string>();
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass79_.caLSuScIAV9);
		XActionHelper.OutputResult(vDqg2uC7aI1, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass79_.UhOSu2yfOjd, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) U1ogShfxmj8(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
		_003C_003Ec__DisplayClass80_.mePSuJ4ClS0 = this;
		_003C_003Ec__DisplayClass80_.axdSu01gKD9 = string_2;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass80_.axdSu01gKD9))
		{
			return (isSuccess: false, message: "未指定“唯一性标识”，无法找到窗口！", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass80_.WJySuNkcNl1 = null;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass80_.evOSuujunWE);
		if (_003C_003Ec__DisplayClass80_.WJySuNkcNl1 == null)
		{
			return (isSuccess: true, message: "未找到窗口", failReason: ActionStopFlag.NoStop);
		}
		while (!actionExecuteContext_0.IsShouldStopAction() && !_003C_003Ec__DisplayClass80_.WJySuNkcNl1.IsClosed)
		{
			Thread.Sleep(100);
		}
		if (_003C_003Ec__DisplayClass80_.WJySuNkcNl1.IsClosed)
		{
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
	}

	private void gqJgSeZoExx(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) HsagSYyhD5I(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
		_003C_003Ec__DisplayClass82_.Ai7SuPcGkwj = string_2;
		_003C_003Ec__DisplayClass82_.GkFSuEInpVO = actionStep_0;
		_003C_003Ec__DisplayClass82_.cfpSuyi62wy = actionExecuteContext_0;
		_003C_003Ec__DisplayClass82_.uORSu857UDF = xaction_0;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_.Ai7SuPcGkwj))
		{
			return (isSuccess: false, message: "未指定“唯一性标识”，无法找到窗口！", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass82_.UBYSuaGftXw = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass82_.o5rSuCI2O7d);
		XActionHelper.OutputResult(NnDg229xqFU, _003C_003Ec__DisplayClass82_.GkFSuEInpVO, _003C_003Ec__DisplayClass82_.cfpSuyi62wy, _003C_003Ec__DisplayClass82_.UBYSuaGftXw, _003C_003Ec__DisplayClass82_.uORSu857UDF);
		if (!_003C_003Ec__DisplayClass82_.UBYSuaGftXw)
		{
			XActionHelper.OutputResult(uKRg2tSHQxv, _003C_003Ec__DisplayClass82_.GkFSuEInpVO, _003C_003Ec__DisplayClass82_.cfpSuyi62wy, "", _003C_003Ec__DisplayClass82_.uORSu857UDF);
			XActionHelper.OutputResult(kaPg2LJTUR6, _003C_003Ec__DisplayClass82_.GkFSuEInpVO, _003C_003Ec__DisplayClass82_.cfpSuyi62wy, "", _003C_003Ec__DisplayClass82_.uORSu857UDF);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) vakgSIwdMI0(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass83_0 _003C_003Ec__DisplayClass83_ = new _003C_003Ec__DisplayClass83_0();
		_003C_003Ec__DisplayClass83_.TOrSuRlRJ2j = string_2;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass83_.TOrSuRlRJ2j))
		{
			return (isSuccess: false, message: "未指定“唯一性标识”，无法找到窗口！", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass83_.FjsSuqlYIPN = XActionHelper.GetTextParamValue(Hg7gSxTWIDC, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass83_.kiGSucJfnVJ = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass83_.bWySu76mM3i);
		if (!_003C_003Ec__DisplayClass83_.kiGSucJfnVJ)
		{
			return (isSuccess: false, message: "未找到文本窗口：" + _003C_003Ec__DisplayClass83_.TOrSuRlRJ2j, failReason: ActionStopFlag.OperationFailed);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static bool vwrgSWjVuPV(string string_2, ActionExecuteContext actionExecuteContext_0)
	{
		return SubProgramStep.GetSubProgram(actionExecuteContext_0, string_2) != null;
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) PNCgSkF5ePm(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2, string string_3)
	{
		_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_0();
		_003C_003Ec__DisplayClass85_.qULSuhffPIa = string_3;
		_003C_003Ec__DisplayClass85_.kftSuY3EWFs = actionExecuteContext_0;
		_003C_003Ec__DisplayClass85_.vuvSuQfqZE9 = actionStep_0;
		_003C_003Ec__DisplayClass85_.nrESuTLsgP1 = xaction_0;
		_003C_003Ec__DisplayClass85_.f4uSuIyVLkC = string.Equals(string_2, "WAIT", StringComparison.OrdinalIgnoreCase);
		string textParamValue = XActionHelper.GetTextParamValue(TPpgSBLiSop, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.DbqSuKW7ywG = XActionHelper.GetTextParamValue(GShgSQPW1Eq, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.pXvSumMecKg = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(textParamValue, out _003C_003Ec__DisplayClass85_.pXvSumMecKg))
		{
			_003C_003Ec__DisplayClass85_.pXvSumMecKg = ShowWindowLocation.CenterScreen;
		}
		_003C_003Ec__DisplayClass85_.Tx6Su4H5tht = false;
		_003C_003Ec__DisplayClass85_.en5Su5oafTA = "";
		_003C_003Ec__DisplayClass85_.z4OSuDLXsor = "";
		_003C_003Ec__DisplayClass85_.NYsSudu4OvT = "";
		_003C_003Ec__DisplayClass85_.CUkSuol1mWx = "";
		_003C_003Ec__DisplayClass85_.gkPSusjbSIF = XActionHelper.GetTextParamValue(Hg7gSxTWIDC, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.g4NSu1NBNmj = XActionHelper.GetTextParamValue(CrXgSrVKBVO, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.vWZSux0sIZl = Convert.ToDouble(XActionHelper.GetNumberParamValue(HuEgSnx0r5k, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs));
		_003C_003Ec__DisplayClass85_.UIcSunfFb7r = XActionHelper.GetTextParamValue(qgxgS477L0T, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.ppLSu65tmSg = XActionHelper.GetTextParamValue(xnagSDLU0md, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.hnfSub9bTc7 = XActionHelper.GetTextParamValue(m0UgS5deUC8, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.fGYSurFXZqo = XActionHelper.GetBooleanParamValue(eNBgSTwQRyg, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.RKpSups6VP8 = XActionHelper.GetBooleanParamValue(vsJgSMchytk, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.XXjSuBQCGxd = XActionHelper.GetBooleanParamValue(lGWgSAJCPkl, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.cwaSujjTdxi = XActionHelper.GetBooleanParamValue(h1FgSlLkmIx, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.nGtSuXWfTHO = XActionHelper.GetTextParamValue(HQvgSofPlhN, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.GNGSuHRbdIZ = XActionHelper.GetIntegerParamValue(goxgSiKXB9S, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.DRYSu9NVv6M = XActionHelper.GetTextParamValue(C0OgSdilQwu, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass85_.DRYSu9NVv6M) && UGNZKrYVGqgfWZbLcQj.HighlightingDefinitionNames.All(_003C_003Ec__DisplayClass85_.UHWSuVuifuk) && !_003C_003Ec__DisplayClass85_.DRYSu9NVv6M.StartsWith("<") && !_003C_003Ec__DisplayClass85_.DRYSu9NVv6M.IsPathExists())
		{
			return (isSuccess: false, message: "不支持的高亮语法类型：" + _003C_003Ec__DisplayClass85_.DRYSu9NVv6M, failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue2 = XActionHelper.GetTextParamValue(yi3gS3uCBfJ, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		_003C_003Ec__DisplayClass85_.l09SuWWCriU = null;
		_003C_003Ec__DisplayClass85_.sXqSukRA60P = null;
		_003C_003Ec__DisplayClass85_.F8JSuGG29Q1 = false;
		if (!XActionHelper.GetBooleanParamValue(ImXgSFFmYuY, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs))
		{
			_003C_003Ec__DisplayClass85_.F8JSuGG29Q1 = true;
		}
		if (!string.IsNullOrWhiteSpace(textParamValue2))
		{
			string[] array = textParamValue2.SplitToList();
			foreach (string text in array)
			{
				if (text.StartsWith("//"))
				{
					continue;
				}
				if (text.StartsWith("loaded_sp:", StringComparison.OrdinalIgnoreCase))
				{
					_003C_003Ec__DisplayClass85_.l09SuWWCriU = text.Substring("loaded_sp:".Length);
					if (!vwrgSWjVuPV(_003C_003Ec__DisplayClass85_.l09SuWWCriU, _003C_003Ec__DisplayClass85_.kftSuY3EWFs))
					{
						return (isSuccess: false, message: "子程序不存在：" + _003C_003Ec__DisplayClass85_.l09SuWWCriU, failReason: ActionStopFlag.OperationFailed);
					}
				}
				else if (text.StartsWith("closing_sp:", StringComparison.OrdinalIgnoreCase))
				{
					_003C_003Ec__DisplayClass85_.sXqSukRA60P = text.Substring("closing_sp:".Length);
					if (!vwrgSWjVuPV(_003C_003Ec__DisplayClass85_.sXqSukRA60P, _003C_003Ec__DisplayClass85_.kftSuY3EWFs))
					{
						return (isSuccess: false, message: "子程序不存在：" + _003C_003Ec__DisplayClass85_.sXqSukRA60P, failReason: ActionStopFlag.OperationFailed);
					}
				}
				else if (text.StartsWith("disable_esc_close"))
				{
					_003C_003Ec__DisplayClass85_.F8JSuGG29Q1 = true;
				}
				else
				{
					_003C_003Ec__DisplayClass85_.kftSuY3EWFs.ActionLogger.LogWarning("不支持的高级设置内容：" + text);
				}
			}
		}
		_003C_003Ec__DisplayClass85_.yJZSue9cOli = string_2 == "NO_WAIT" && XActionHelper.GetBooleanParamValue(U18gSUph1p9, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs);
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass85_.ixSSuZINZe6);
		if (_003C_003Ec__DisplayClass85_.f4uSuIyVLkC)
		{
			while (!_003C_003Ec__DisplayClass85_.Tx6Su4H5tht)
			{
				Thread.Sleep(50);
			}
			XActionHelper.OutputResult(VBNg2w5ACvE, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs, _003C_003Ec__DisplayClass85_.z4OSuDLXsor ?? string.Empty, _003C_003Ec__DisplayClass85_.nrESuTLsgP1);
			XActionHelper.OutputResult(uKRg2tSHQxv, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs, _003C_003Ec__DisplayClass85_.en5Su5oafTA ?? string.Empty, _003C_003Ec__DisplayClass85_.nrESuTLsgP1);
			XActionHelper.OutputResult(kaPg2LJTUR6, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs, _003C_003Ec__DisplayClass85_.NYsSudu4OvT, _003C_003Ec__DisplayClass85_.nrESuTLsgP1);
			XActionHelper.OutputResult(zTfg2vN7aWC, _003C_003Ec__DisplayClass85_.vuvSuQfqZE9, _003C_003Ec__DisplayClass85_.kftSuY3EWFs, _003C_003Ec__DisplayClass85_.CUkSuol1mWx, _003C_003Ec__DisplayClass85_.nrESuTLsgP1);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private TextWindow NbZgSGJI4uB(string string_2)
	{
		foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
		{
			if (item.AutoCloseKey == string_2 && item.IsLoaded)
			{
				return item;
			}
		}
		return null;
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) K8agSs80v1k(string string_2)
	{
		_003C_003Ec__DisplayClass87_0 _003C_003Ec__DisplayClass87_ = new _003C_003Ec__DisplayClass87_0();
		_003C_003Ec__DisplayClass87_.Dn0SulWND2O = string_2;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass87_.Dn0SulWND2O))
		{
			return (isSuccess: false, message: "未指定“唯一性标识”，无法找到窗口！", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass87_.FmKSuiPrPrB = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass87_.vUQSuUwyvtG);
		if (!_003C_003Ec__DisplayClass87_.FmKSuiPrPrB)
		{
			return (isSuccess: false, message: "未找到文本窗口：" + _003C_003Ec__DisplayClass87_.Dn0SulWND2O, failReason: ActionStopFlag.OperationFailed);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) g19gSHJUWpF(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass88_0 _003C_003Ec__DisplayClass88_ = new _003C_003Ec__DisplayClass88_0();
		_003C_003Ec__DisplayClass88_.t0oSufxZyIw = string_2;
		_003C_003Ec__DisplayClass88_.w2gSuzXQPvv = actionStep_0;
		_003C_003Ec__DisplayClass88_.AxOSNwXJhPU = actionExecuteContext_0;
		_003C_003Ec__DisplayClass88_.MH2SNtlQRJf = xaction_0;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass88_.t0oSufxZyIw))
		{
			return (isSuccess: false, message: "未指定“唯一性标识”，无法找到窗口！", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass88_.p5GSNgiJ5Sq = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass88_.vlBSu3qfstp);
		if (!_003C_003Ec__DisplayClass88_.p5GSNgiJ5Sq)
		{
			_003C_003Ec__DisplayClass88_.AxOSNwXJhPU.ActionLogger.LogWarning("未找到文本窗口：" + _003C_003Ec__DisplayClass88_.t0oSufxZyIw);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ttvgSKETTbc, step) + " " + XActionHelper.GetParamDisplayString(Hg7gSxTWIDC, step);
	}

	static ShowTextStep()
	{
		ttvgSKETTbc = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "是否等待窗口关闭后继续",
			Type = VarType.Enum,
			DefaultValue = "NO_WAIT",
			SelectionItems = new SelectionItem[9]
			{
				new SelectionItem("NO_WAIT", "显示窗口，不等待关闭（立即开始执行后续的步骤）"),
				new SelectionItem("WAIT", "显示窗口，等待关闭"),
				new SelectionItem("CLOSE_WINDOW", "关闭窗口"),
				new SelectionItem("GET_WIN_INFO", "获取窗口信息"),
				new SelectionItem("APPEND_TEXT", "追加内容"),
				new SelectionItem("ACTIVATE_WINDOW", "显示和激活窗口"),
				new SelectionItem("WAIT_CLOSE", "等待窗口关闭"),
				new SelectionItem("GET_ALL_WINDOWS", "获取所有文本窗口"),
				new SelectionItem("GET_ACTION_WINDOWS", "获取当前动作创建的所有文本窗口")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		Hg7gSxTWIDC = new StepInParamDef
		{
			Key = "text",
			Name = "文本内容",
			Description = "要显示的文本内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "WAIT", "NO_WAIT", "APPEND_TEXT" }
		};
		CrXgSrVKBVO = new StepInParamDef
		{
			Key = "title",
			Name = "窗口标题",
			Description = "窗口标题文字",
			DefaultValue = "文本窗口",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = false
		};
		OperationInputParam = new StepInParamDef
		{
			Key = "operations",
			Name = "工具栏操作",
			Description = "用于显示在窗口工具栏。每行一个选项，格式为 “文本” 或 “显示文本|值”。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			ValidForList = new string[2] { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		zmagSpCQeIp = new StepInParamDef
		{
			Key = "autoCloseKey",
			Name = "文本窗口标识",
			Description = "可选。自动更新或关闭之前打开的具有此标识的文本窗口。使用‘=’表示当前动作id。",
			DefaultValue = "=",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			IsAdvanced = false,
			InvalidForList = new string[2] { "GET_ALL_WINDOWS", "GET_ACTION_WINDOWS" }
		};
		TPpgSBLiSop = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置类型",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[14]
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
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		GShgSQPW1Eq = new StepInParamDef
		{
			Key = "winSize",
			Name = "窗口尺寸/位置",
			Description = "设置选择窗口的尺寸，格式为：宽度,高度。支持逻辑像素数值或屏幕宽高百分比，详情请参考模块文档。\n“窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		CdXgSjdcRqF = new StepInParamDef
		{
			Key = "topMost",
			Name = "置顶显示",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" }
		};
		HuEgSnx0r5k = new StepInParamDef
		{
			Key = "fontsize",
			Name = "字体大小",
			DefaultValue = 14,
			Description = "默认的字体大小",
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		qgxgS477L0T = new StepInParamDef
		{
			Key = "fontfamily",
			Name = "字体名称",
			DefaultValue = "",
			Description = "可选。设置字体名称。如有多个字体，使用逗号分隔。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		m0UgS5deUC8 = new StepInParamDef
		{
			Key = "bgColor",
			Name = "背景颜色",
			DefaultValue = "",
			Description = "可选。格式为#RRGGBB",
			IsRequired = false,
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true,
			TextTools = new List<TextToolType>
			{
				TextToolType.ColorPicker,
				TextToolType.SelectColor
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		xnagSDLU0md = new StepInParamDef
		{
			Key = "textColor",
			Name = "文字颜色",
			DefaultValue = "",
			Description = "可选。格式为#RRGGBB",
			IsRequired = false,
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true,
			TextTools = new List<TextToolType>
			{
				TextToolType.ColorPicker,
				TextToolType.SelectColor
			},
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		C0OgSdilQwu = new StepInParamDef
		{
			Key = "highlight",
			Name = "语法高亮",
			DefaultValue = "",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>(),
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		HQvgSofPlhN = new StepInParamDef
		{
			Key = "autoSaveToState",
			Name = "自动保存到状态",
			DefaultValue = "",
			Description = "指定状态Key。文本内容将自动保存到状态中。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		eNBgSTwQRyg = new StepInParamDef
		{
			Key = "showLineNum",
			Name = "显示行号",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		vsJgSMchytk = new StepInParamDef
		{
			Key = "autoWrap",
			Name = "自动换行显示",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		lGWgSAJCPkl = new StepInParamDef
		{
			Key = "copyWholeLine",
			Name = "未选择内容时，复制或剪切整行",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		PKugSOGcFaS = new StepInParamDef
		{
			Key = "closeWhenLostFocus",
			Name = "失去焦点自动关闭",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		ImXgSFFmYuY = new StepInParamDef
		{
			Key = "enableEscClose",
			Name = "Esc 键关闭窗口",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		U18gSUph1p9 = new StepInParamDef
		{
			Key = "updateIfExists",
			Name = "如果窗口存在，则直接更新窗口内容（而不是关闭后打开新窗口）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "NO_WAIT" },
			IsAdvanced = true
		};
		h1FgSlLkmIx = new StepInParamDef
		{
			Key = "showBuildInToolbar",
			Name = "显示内置工具栏",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		goxgSiKXB9S = new StepInParamDef
		{
			Key = "caretPosition",
			Name = "光标位置",
			DefaultValue = 0,
			Description = "0表示最前面，-1表示最后面，其它数字表示某个具体字符位置。",
			IsRequired = true,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "WAIT", "NO_WAIT" },
			IsAdvanced = true
		};
		yi3gS3uCBfJ = new StepInParamDef
		{
			Key = "advancedSettings",
			Name = "高级设置",
			Description = "请参考模块文档。",
			Type = VarType.Text,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input
		};
		sLXgSflNEmK = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		VBNg2w5ACvE = new StepOutParamDef
		{
			Key = "selectedOperation",
			Name = "选择的项",
			Description = "选择的后续操作项",
			Type = VarType.Text,
			ValidForList = new string[1] { "WAIT" }
		};
		uKRg2tSHQxv = new StepOutParamDef
		{
			Key = "resultText",
			Name = "结果文本",
			Description = "文本框内的所有文本",
			Type = VarType.Text,
			ValidForList = new string[3] { "WAIT", "CLOSE_WINDOW", "GET_WIN_INFO" }
		};
		B4Xg2gC8GPK = new StepOutParamDef
		{
			Key = "windowHandle",
			Name = "窗口句柄",
			Description = "",
			Type = VarType.Integer,
			ValidForList = new string[2] { "NO_WAIT", "GET_WIN_INFO" }
		};
		kaPg2LJTUR6 = new StepOutParamDef
		{
			Key = "selectedText",
			Name = "选中的文本",
			Description = "文本框内选中的文本",
			Type = VarType.Text,
			ValidForList = new string[3] { "WAIT", "CLOSE_WINDOW", "GET_WIN_INFO" }
		};
		zTfg2vN7aWC = new StepOutParamDef
		{
			Key = "windowPosition",
			Name = "窗口位置",
			Description = "窗口的最终显示位置",
			Type = VarType.Text,
			ValidForList = new string[3] { "WAIT", "CLOSE_WINDOW", "GET_WIN_INFO" }
		};
		v2pg2SImLrV = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		NnDg229xqFU = new StepOutParamDef
		{
			Key = "isWindowExists",
			Name = "窗口是否存在",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "GET_WIN_INFO" }
		};
		vDqg2uC7aI1 = new StepOutParamDef
		{
			Key = "allWindows",
			Name = "所有窗口",
			Description = "词典类型，key为窗口的句柄，value为窗口的标识。获取全部窗口时，为了安全，仅限自己开发的动作使用。",
			Type = VarType.Dict,
			ValidForList = new string[2] { "GET_ALL_WINDOWS", "GET_ACTION_WINDOWS" }
		};
	}

	internal static bool QJD4n7Qgw57A123py75J()
	{
		return GRqkWQQgSOFiFrc0nhIo == null;
	}
}
