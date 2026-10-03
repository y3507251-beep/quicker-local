using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using dkbgyyMixGueocCf9RC;
using IgQBbvXMVdsN7GVNUxX;
using JTIh7V5l65QV75A93Ly;
using log4net;
using Newtonsoft.Json;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Annotations;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Skin;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Entities;
using Quicker.Domain.Extensions;
using Quicker.Domain.Messages;
using Quicker.Domain.Profiles;
using Quicker.Domain.Push;
using Quicker.Domain.Services;
using Quicker.Properties;
using Quicker.Public.Entities;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using SWBMfZYGyc6L9yHIvKQ;
using WindowsInput;
using WindowsInput.Native;
using Yf8A0Tj55ce1jngb1h3;

namespace Quicker.Domain;

public class AppServer : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec p2PvXZl6bAr;

		public static Action hNWvX9vIoId;

		public static Func<ImageViewerWindow, bool> IPpvXhVG1WB;

		private static _003C_003Ec VnAccVc6aSWfZTp48Q84;

		static _003C_003Ec()
		{
			p2PvXZl6bAr = new _003C_003Ec();
		}

		internal void sgSvXcSFvAk()
		{
			AppState.HS2taepcAbc().TogglePause();
		}

		internal bool swAvXVtskVE(ImageViewerWindow x)
		{
			return !x.IsVisible;
		}

		internal static bool KXTlcKc6rGrgB3u3wHOd()
		{
			return VnAccVc6aSWfZTp48Q84 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public bool iYgvXIdVebT;

		public AppServer oYKvXWHuU69;

		public ActionItem sJdvXkt6o2g;

		public PointTargetInfo T94vXGN0HRP;

		public ActionTrigger g3hvXsXra8c;

		public ActionExtraContextData sZCvXHj9bTO;

		public string YO9vX14XhM7;

		public int ejIvXb0UwkO;

		public ActionExecuteContext PB0vX6FBICo;

		public Action adivXX9322w;

		internal static _003C_003Ec__DisplayClass29_0 oA1qubc69wCXQTqGNBjG;

		internal void AbevXe1ORWu()
		{
			if (!iYgvXIdVebT)
			{
				oYKvXWHuU69.RoQtRAXrU3b.CountActionClick(sJdvXkt6o2g);
				ruWtR5o9n6j.Info("执行动作：" + sJdvXkt6o2g.Title + " id=" + sJdvXkt6o2g.Id);
				int num = 0;
				if (oA1qubc69wCXQTqGNBjG != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			if (T94vXGN0HRP == null)
			{
				if (g3hvXsXra8c.IsEither(ActionTrigger.SearchInput, ActionTrigger.SearchCallback, ActionTrigger.SearchContextMenu))
				{
					T94vXGN0HRP = new PointTargetInfo();
				}
				else
				{
					T94vXGN0HRP = AppHelper.GetPointTargetInfo(null);
				}
			}
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			using ActionExecuteContext actionExecuteContext = new ActionExecuteContext(null, sJdvXkt6o2g, T94vXGN0HRP, oYKvXWHuU69, iYgvXIdVebT, 0, sZCvXHj9bTO, cancellationTokenSource.Token)
			{
				ActiveWindowHwnd = oYKvXWHuU69.K03tRMdjDH5.ForegroundWindowHwnd,
				InputParam = (YO9vX14XhM7 ?? string.Empty),
				ActionTrigger = g3hvXsXra8c,
				IsRootContext = true,
				Cts = cancellationTokenSource
			};
			if (iYgvXIdVebT)
			{
				actionExecuteContext.ActionLogger.BeginFile();
				actionExecuteContext.ActionLogger.LogInfo($"Win-{Environment.OSVersion.Version}  Quicker-{AppHelper.GetSoftVersion()} 动作ID:{sJdvXkt6o2g.Id}  来源动作:{sJdvXkt6o2g.TemplateId} v{sJdvXkt6o2g.TemplateRevision}");
				actionExecuteContext.ActionLogger.LogFileName();
				int num3 = 1;
				if (oA1qubc69wCXQTqGNBjG != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				case 1:
					break;
				default:
					goto IL_02f2;
				}
			}
			oYKvXWHuU69.fajtRFXAueR.Add(actionExecuteContext);
			try
			{
				ActionItem actionItem = sJdvXkt6o2g;
				int num5 = 0;
				if (!hA0TCNc6LtI7yLtmJPSE())
				{
					int num6 = default(int);
					num5 = num6;
				}
				switch (num5)
				{
				default:
					if (sJdvXkt6o2g.UseTemplate && !string.IsNullOrEmpty(sJdvXkt6o2g.TemplateId))
					{
						actionItem = sJdvXkt6o2g.Clone(false);
						SharedActionDto result = oYKvXWHuU69.eGptRUyJGfy.Wott6D3Yp9F(Guid.Parse(sJdvXkt6o2g.TemplateId), sJdvXkt6o2g.TemplateRevision).GetAwaiter().GetResult();
						actionItem.Data = result.Data;
						actionItem.Data2 = result.Data2;
						actionItem.Data3 = result.Data3;
						actionItem.Children = result.Children;
					}
					ActionTypeManager.RunAction(actionItem, ejIvXb0UwkO, oYKvXWHuU69, actionExecuteContext);
					break;
				}
			}
			catch (Exception ex)
			{
				ruWtR5o9n6j.Warn("执行动作出错：" + ex.Message, ex);
				AppHelper.ShowWarning("执行动作出错。" + ex.Message);
			}
			goto IL_02f2;
			IL_02f2:
			PB0vX6FBICo = actionExecuteContext;
			oYKvXWHuU69.fajtRFXAueR.Remove(actionExecuteContext);
			if (actionExecuteContext.IsStoppedByUser && !actionExecuteContext.SkipStopWarning)
			{
				AppHelper.ShowWarning("已中止动作：" + sJdvXkt6o2g.Title);
			}
			if (iYgvXIdVebT)
			{
				actionExecuteContext.ActionLogger.EndFile();
				actionExecuteContext.ActionLogger.OpenLogFile();
			}
			if (sJdvXkt6o2g.ActionType != ActionType.Folder && sJdvXkt6o2g.ActionType != ActionType.GoParent)
			{
				ActionType actionType = sJdvXkt6o2g.ActionType;
			}
			actionExecuteContext.TryDisposeObjects();
			adivXX9322w?.Invoke();
		}

		internal void UehvXY0BBUV()
		{
			try
			{
				AppState.P7gt7BYmHZ0.RecordLastAction(sJdvXkt6o2g.Id, YO9vX14XhM7);
				gIh8AyjqAySmmxFMtv4.snVtexogTaa(sJdvXkt6o2g);
			}
			catch (Exception ex)
			{
				ruWtR5o9n6j.Warn("记录最近动作出错：" + ex.Message, ex);
			}
		}

		internal static bool hA0TCNc6LtI7yLtmJPSE()
		{
			return oA1qubc69wCXQTqGNBjG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public (ActionItem action, string message) GRMvXKpxcdA;

		private static _003C_003Ec__DisplayClass30_0 h1RHlyc6YdXI5V6Ja92B;

		internal void kKOvXm09cvD()
		{
			System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu
			{
				PlacementTarget = AppState.v5FtaQ4hQfg().eVuvLfVCnT6
			};
			(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(GRMvXKpxcdA.action.Id);
			AppState.lWutartRfUY().CreateContextMenuForActionButton(contextMenu, GRMvXKpxcdA.action, actionById.Item2, actionById.Item1.Row, actionById.Item1.Col, AppState.v5FtaQ4hQfg().eVuvLfVCnT6, ActionTrigger.CircleMenu, true, false);
			contextMenu.IsOpen = true;
			AppState.RegisterContextMenu(contextMenu);
		}

		internal static bool byWVVdc680kXbOYrT1UZ()
		{
			return h1RHlyc6YdXI5V6Ja92B == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public AppServer WDOvXrDnVEn;

		public string YmavXprSHnJ;

		public string alLvXBjq9PD;

		private static _003C_003Ec__DisplayClass45_0 TlS1buc6g2o9YCWMVFPx;

		internal void c4UvXxQOCQj()
		{
			if (WDOvXrDnVEn.wE3tRTpIAYG.IsShouldShowCreateProfileButton())
			{
				try
				{
					string exeFilePath = WDOvXrDnVEn.K03tRMdjDH5.ExeFilePath;
					if (string.IsNullOrEmpty(exeFilePath))
					{
						ruWtR5o9n6j.Warn("显示创建面板文字出错：未获得程序路径。");
					}
					else
					{
						if (string.IsNullOrEmpty(YmavXprSHnJ))
						{
							System.Diagnostics.FileVersionInfo versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(exeFilePath);
							YmavXprSHnJ = versionInfo.FileDescription;
							if (string.IsNullOrEmpty(YmavXprSHnJ))
							{
								YmavXprSHnJ = Path.GetFileName(exeFilePath);
								int num = 0;
								if (!WuoW4Jc6P8Y6by7iX9Ni())
								{
									int num2 = default(int);
									num = num2;
								}
								switch (num)
								{
								}
							}
						}
						AppState.HS2taepcAbc().ShowCreateProfileLink(alLvXBjq9PD, WDOvXrDnVEn.K03tRMdjDH5.ExeFilePath, YmavXprSHnJ);
					}
					return;
				}
				catch (Exception ex)
				{
					ruWtR5o9n6j.Warn("显示创建面板文字出错：" + ex.Message, ex);
					return;
				}
			}
			AppState.HS2taepcAbc().HideCreateProfileLink();
		}

		internal static void sXgaj6c6UgG11jZB3Aoi()
		{
		}

		internal static bool WuoW4Jc6P8Y6by7iX9Ni()
		{
			return TlS1buc6g2o9YCWMVFPx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public AppServer tWKvXjNUBUO;

		public string MHTvXnAw1hp;

		public bool V3pvX4Qe4Jd;

		public bool we7vX5dery2;

		internal static _003C_003Ec__DisplayClass49_0 LMPgQ4c66HsDFKrOUK8F;

		internal void LGYvXQVe8Wy()
		{
			tWKvXjNUBUO.wE3tRTpIAYG.ChangeExe(MHTvXnAw1hp, true);
			if (V3pvX4Qe4Jd)
			{
				tWKvXjNUBUO.wE3tRTpIAYG.ContextGoToPage(0);
			}
			if (we7vX5dery2)
			{
				tWKvXjNUBUO.DkKtRo833jV.LockContextPanel = true;
				tWKvXjNUBUO.WoctRdmx0xX.NotifyStateChange(tWKvXjNUBUO, ChangedStateType.LockPanel, tWKvXjNUBUO.DkKtRo833jV.LockContextPanel);
			}
		}

		internal static bool YdXMqbc6tJnR3Vs4jjHF()
		{
			return LMPgQ4c66HsDFKrOUK8F == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public bool OmTvXd5566Q;

		public string RI2vXostHIY;

		internal static _003C_003Ec__DisplayClass56_0 cekSFUc6TVidRaUCA5Zd;

		internal void IDXvXDL1fRZ()
		{
			if (OmTvXd5566Q && AppState.HHxtaMaoqJr().SearchSettings.AutoFillClipTextSeconds > 0.1)
			{
				try
				{
					if ((double)(AppHelper.fLiLTj0x4QY() - AppState.LastClipboardChangeTime) < AppState.HHxtaMaoqJr().SearchSettings.AutoFillClipTextSeconds * 1000.0 && System.Windows.Clipboard.ContainsText())
					{
						string text = System.Windows.Clipboard.GetText();
						if (!string.IsNullOrEmpty(text) && text.Length <= AppState.HHxtaMaoqJr().SearchSettings.AutoFillMaxLength)
						{
							RI2vXostHIY += text;
						}
					}
				}
				catch (Exception)
				{
					AppHelper.ShowWarning("获得剪贴板内容失败。");
				}
			}
			AppState.HS2taepcAbc().ShowSearch(null, RI2vXostHIY);
		}

		internal static bool LL67n9c6mjVIjK9rtOWo()
		{
			return cekSFUc6TVidRaUCA5Zd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		public AppServer qn1vXMs7qrv;

		public ActionTrigger U62vXA0yWSM;

		internal static _003C_003Ec__DisplayClass67_0 CUtDFPc64497U7kEiLOX;

		internal void QxCvXTs3KyZ()
		{
			while (System.Windows.Forms.Control.ModifierKeys != Keys.None)
			{
				Thread.Sleep(10);
			}
			qn1vXMs7qrv.WoctRdmx0xX.NotifyRunAction(qn1vXMs7qrv, AppState.P7gt7BYmHZ0.GetLastActionId(), false, false, U62vXA0yWSM, false, null, AppState.P7gt7BYmHZ0.LastActionParam);
		}

		internal static bool VZ1HGTc6h6y5M5x6OPwO()
		{
			return CUtDFPc64497U7kEiLOX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass71_0
	{
		public string lAVvXFHTSyl;

		private static _003C_003Ec__DisplayClass71_0 LnjkZRc6z90Y2BZ3kNL9;

		internal void xsmvXO55ynr()
		{
			AppState.HS2taepcAbc().ShowDashboardWindow(lAVvXFHTSyl);
		}

		internal static bool da0x28ctVCgX6Amrmklq()
		{
			return LnjkZRc6z90Y2BZ3kNL9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_0
	{
		public string JM6vXlnaW90;

		private static _003C_003Ec__DisplayClass73_0 KVtYCVctFtrTdmoqcKV2;

		internal void tGnvXUnj8gp()
		{
			AppState.HS2taepcAbc().ShowExeSettingsWindow(JM6vXlnaW90);
		}

		internal static bool wslyP5ctcq3G13XGpd6l()
		{
			return KVtYCVctFtrTdmoqcKV2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass75_0
	{
		public string IBavX3qaM6B;

		private static _003C_003Ec__DisplayClass75_0 Eh6rR2ctyroJJboEfL8c;

		internal void LeEvXiV7rY8()
		{
			AppState.lWutartRfUY().EditActionById(IBavX3qaM6B);
		}

		internal static bool Se5FLJctppedDqAcJlx1()
		{
			return Eh6rR2ctyroJJboEfL8c == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass85_0
	{
		public bool? mojvXzLOAUm;

		private static _003C_003Ec__DisplayClass85_0 LcZHgEct2A2iYF1fojAx;

		internal void WeuvXfDh8et()
		{
			List<ImageViewerWindow> list = AppHelper.FindRootWindows<ImageViewerWindow>().ToList();
			if (!list.Any())
			{
				int num = 0;
				if (!nECiSqctAdn3T2DFoJds())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				AppHelper.ShowInformation("没有要隐藏或显示的图片窗口。");
				return;
			}
			if (!mojvXzLOAUm.HasValue)
			{
				if (list.Any(_003C_003Ec.IPpvXhVG1WB ?? (_003C_003Ec.IPpvXhVG1WB = _003C_003Ec.p2PvXZl6bAr.swAvXVtskVE)))
				{
					mojvXzLOAUm = true;
				}
				else
				{
					mojvXzLOAUm = false;
				}
			}
			foreach (ImageViewerWindow item in list)
			{
				if (mojvXzLOAUm.Value)
				{
					item.Show();
				}
				else
				{
					item.Hide();
				}
			}
		}

		internal static void FPSpqyctecFDqLr3jZeK()
		{
		}

		internal static bool nECiSqctAdn3T2DFoJds()
		{
			return LcZHgEct2A2iYF1fojAx == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetExeIconUrl_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public AppServer _003C_003E4__this;

		public string exePathName;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object wq8e0HctDlUQx8gPVJ1I;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AppServer appServer = _003C_003E4__this;
			string result;
			try
			{
				ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = appServer.z8StRO0Ygs6.GetFileOrFolderIconAsync(exePathName).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (wq8e0HctDlUQx8gPVJ1I != null)
						{
							switch (0)
							{
							}
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
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

		internal static bool MjBcaKct3GGGhSqgcYG0()
		{
			return wq8e0HctDlUQx8gPVJ1I == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveFileVersionInfo_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ExeFileVersionDto> _003C_003Et__builder;

		public string exePath;

		public AppServer _003C_003E4__this;

		private ExeFileVersionVm _003Cinfo_003E5__2;

		private ExeFileVersionVm _003C_003E7__wrap2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<ApiResult<ExeFileVersionDto>>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private static object Etq6ZtctG1iuCICSYyvX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AppServer appServer = _003C_003E4__this;
			ExeFileVersionDto result3;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_016a;
					}
					_003Cinfo_003E5__2 = new ExeFileVersionVm
					{
						ExeFileName = Path.GetFileName(exePath),
						FilePath = exePath
					};
					FileInfo fileInfo = new FileInfo(exePath);
					_003Cinfo_003E5__2.FileSize = (int)fileInfo.Length;
					if (!dvCipPct0qGsTrR9Wrv0())
					{
						switch (0)
						{
						}
					}
				}
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						_003C_003E7__wrap2 = _003Cinfo_003E5__2;
						int num2 = 0;
						if (Etq6ZtctG1iuCICSYyvX != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = appServer.z8StRO0Ygs6.GetFileOrFolderIconAsync(exePath).ConfigureAwait(false).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result = awaiter.GetResult();
					_003C_003E7__wrap2.FileIconUrl = result;
					_003C_003E7__wrap2 = null;
				}
				catch (Exception)
				{
					_003Cinfo_003E5__2.FileIconUrl = "";
				}
				_003Cinfo_003E5__2.Platform = "NA";
				_003Cinfo_003E5__2.FileVersionInfo = new Quicker.Common.Vm.FileVersionInfo(System.Diagnostics.FileVersionInfo.GetVersionInfo(exePath));
				goto IL_016a;
				IL_016a:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<ExeFileVersionDto>>.ConfiguredTaskAwaiter awaiter2;
					if (num != 1)
					{
						awaiter2 = aFIptTXYsUoTUF4v33R.DSUt1OgOGK3(_003Cinfo_003E5__2).ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__2;
						int num4 = 0;
						if (Etq6ZtctG1iuCICSYyvX != null)
						{
							int num5 = default(int);
							num4 = num5;
						}
						switch (num4)
						{
						}
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<ApiResult<ExeFileVersionDto>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<ExeFileVersionDto> result2 = awaiter2.GetResult();
					if (!result2.IsSuccess)
					{
						goto end_IL_016a;
					}
					result3 = result2.Data;
					goto end_IL_000e;
					end_IL_016a:;
				}
				catch (Exception)
				{
				}
				result3 = null;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cinfo_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cinfo_003E5__2 = null;
			_003C_003Et__builder.SetResult(result3);
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

		static _003CSaveFileVersionInfo_003Ed__37()
		{
		}

		internal static bool dvCipPct0qGsTrR9Wrv0()
		{
			return Etq6ZtctG1iuCICSYyvX == null;
		}

		internal static void V3K0s9ctB6NoKAe0HZmB()
		{
		}
	}

	private static readonly ILog ruWtR5o9n6j;

	private readonly ClientManager Kk6tRDTKDW3;

	private readonly ITinyMessengerHub WoctRdmx0xX;

	private readonly PanelState DkKtRo833jV;

	private readonly ProfileSwitcher wE3tRTpIAYG;

	private readonly ActiveWindowHook K03tRMdjDH5;

	private readonly UsageCounter RoQtRAXrU3b;

	private readonly IconManager z8StRO0Ygs6;

	private readonly RunningActionMgr fajtRFXAueR;

	private readonly DataService eGptRUyJGfy;

	private readonly PopupState xAStRlnsigL;

	private readonly TextFloatPanelMgr oxMtRimBX1K;

	private readonly PushClient yCQtR3MM1fT;

	private readonly ProfileManager sxJtRfJwBTQ;

	private long yxdtRzsG7OZ;

	private IList<Guid> qqVtqwLBvth = new List<Guid>();

	internal static AppServer iecNXTQGWP5ob7dtni4P;

	public AppServer(ProfileManager profileManager, ClientManager clientManger, ITinyMessengerHub hub, PanelState panelState, ProfileSwitcher profileSwitcher, ActiveWindowHook activeWindowWatcher, UsageCounter usageCounter, IconManager iconManager, RunningActionMgr runningActionMgr, DataService dataService, PopupState popupState, TextFloatPanelMgr textFloatPanelMgr, PushClient pushClient)
	{
		AppState.AppServer = this;
		sxJtRfJwBTQ = profileManager;
		Kk6tRDTKDW3 = clientManger;
		WoctRdmx0xX = hub;
		DkKtRo833jV = panelState;
		wE3tRTpIAYG = profileSwitcher;
		K03tRMdjDH5 = activeWindowWatcher;
		RoQtRAXrU3b = usageCounter;
		z8StRO0Ygs6 = iconManager;
		fajtRFXAueR = runningActionMgr;
		eGptRUyJGfy = dataService;
		xAStRlnsigL = popupState;
		oxMtRimBX1K = textFloatPanelMgr;
		yCQtR3MM1fT = pushClient;
		K03tRMdjDH5.ForegroundWindowChanged += OnActiveWindowChanged;
		WoctRdmx0xX.Subscribe<ButtonClickMessage>(ELrtRmU9xDx);
		WoctRdmx0xX.Subscribe<SyncCompletedMessage>(FMftRXF5hFZ);
		WoctRdmx0xX.Subscribe<RunActionMessage>(tFItR6ZbUJ6);
		WoctRdmx0xX.Subscribe<StopRunningActionMessage>(wLbtRbjuWkO);
		WoctRdmx0xX.Subscribe<ToggleLockPanelMessage>(VwvtR1vN5vO);
	}

	private void VwvtR1vN5vO(ToggleLockPanelMessage toggleLockPanelMessage_0)
	{
		ToggleLockPanel(null);
	}

	private void wLbtRbjuWkO(StopRunningActionMessage stopRunningActionMessage_0)
	{
		fajtRFXAueR.StopAll();
	}

	private void tFItR6ZbUJ6(RunActionMessage runActionMessage_0)
	{
		string text = runActionMessage_0.ActionId?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			AppHelper.ShowWarning("要运行的动作ID或名称为空。");
			int num = 0;
			if (iecNXTQGWP5ob7dtni4P != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			string text2 = text;
			string param = "";
			if (!string.IsNullOrEmpty(runActionMessage_0.Param))
			{
				param = runActionMessage_0.Param;
			}
			else
			{
				text2 = TryExtractActionAndParam(text2, ref param);
			}
			ExecuteActionByIdOrName(text2, runActionMessage_0.PointTargetInfo, runActionMessage_0.EnableDebugging, false, runActionMessage_0.IsSubAction, param, runActionMessage_0.ActionTrigger);
		}
	}

	public static string TryExtractActionAndParam(string actionIdOrNamePossibleWithParam, ref string param)
	{
		if ((actionIdOrNamePossibleWithParam.Contains(" ") || actionIdOrNamePossibleWithParam.Contains("?")) && AppState.DataService.S0KtXvrNDeP(actionIdOrNamePossibleWithParam).Count == 0)
		{
			(actionIdOrNamePossibleWithParam, param) = AppHelper.ParseActionIdNameAndParam(actionIdOrNamePossibleWithParam);
		}
		return actionIdOrNamePossibleWithParam;
	}

	private void FMftRXF5hFZ(SyncCompletedMessage syncCompletedMessage_0)
	{
		wE3tRTpIAYG.OnSyncComplete();
	}

	public void OnBrowserUrlChanged(string browserProcessName, string url)
	{
		wE3tRTpIAYG.ReloadOnUrlChange(browserProcessName, url);
	}

	private void ELrtRmU9xDx(ButtonClickMessage buttonClickMessage_0)
	{
		try
		{
			int buttonIndex = buttonClickMessage_0.ButtonIndex;
			ActionItem action = DkKtRo833jV.GetAction(buttonIndex);
			if (action == null)
			{
				return;
			}
			bool debug = buttonClickMessage_0.Debug;
			ExecuteAction(action, buttonIndex, buttonClickMessage_0.TargetInfo, debug, false, false, string.Empty, buttonClickMessage_0.ActionTrigger);
			if (action.ActionType == ActionType.OpenProfile || action.DoNotClosePanel == true)
			{
				return;
			}
			if (iecNXTQGWP5ob7dtni4P == null)
			{
				switch (0)
				{
				}
			}
			D3vtRKJwZMa(buttonIndex);
		}
		catch (Exception ex)
		{
			ruWtR5o9n6j.Error("点击按钮执行动作出错：" + ex.Message, ex);
			AppHelper.ShowWarning("执行动作出错：" + ex.GetMessageWithInner());
		}
	}

	private void D3vtRKJwZMa(int int_0)
	{
		if (DkKtRo833jV.LockContextPanel)
		{
			return;
		}
		if (!AppHelper.IsGlobalButton(int_0))
		{
			ExeSettings exeSettings = eGptRUyJGfy.yQWt6ownR4Z(wE3tRTpIAYG.CurrentExe);
			if (exeSettings != null)
			{
				if (exeSettings.ReturnToFirstPage)
				{
					wE3tRTpIAYG.ContextGoToPage(0);
				}
				return;
			}
			exeSettings = eGptRUyJGfy.yQWt6ownR4Z("common");
			if (exeSettings == null || !exeSettings.ReturnToFirstPage)
			{
				return;
			}
			if (iecNXTQGWP5ob7dtni4P != null)
			{
				switch (0)
				{
				}
			}
			wE3tRTpIAYG.ContextGoToPage(0);
		}
		else
		{
			ExeSettings exeSettings2 = eGptRUyJGfy.yQWt6ownR4Z("_global");
			if (exeSettings2 != null && exeSettings2.ReturnToFirstPage)
			{
				wE3tRTpIAYG.GlobalGoToPage(0);
			}
		}
	}

	public void SaveProfile(ActionProfile profile, bool reloadPanelProfiles)
	{
		sxJtRfJwBTQ.SaveProfile(profile);
		if (reloadPanelProfiles)
		{
			wE3tRTpIAYG.ReloadProfilesIfNeeded(profile.ExeFile);
		}
	}

	private ActionItem GetAction(int buttonIndex)
	{
		return DkKtRo833jV.GetAction(buttonIndex);
	}

	public ActionProfile GetCurrentContextProfile()
	{
		return DkKtRo833jV.CurrentContextProfile;
	}

	public ActionProfile GetCurrentGlobalProfile()
	{
		return DkKtRo833jV.CurrentGlobalProfile;
	}

	public ActionProfile GetProfileByButtonIndex(int btnIndex)
	{
		return DkKtRo833jV.GetProfileByButtonIndex(btnIndex);
	}

	internal ActionItem VuctRxC7icX(ActionItem actionItem_0)
	{
		if (actionItem_0 == null)
		{
			return null;
		}
		if (actionItem_0.ActionType == ActionType.LinkAction)
		{
			(ActionItem, ActionProfile) actionById = AppState.DataService.GetActionById(actionItem_0.Data);
			if (actionById.Item1 == null)
			{
				AppHelper.ShowWarning("未找到链接动作的原始动作，无法执行。");
				return null;
			}
			(actionItem_0, _) = actionById;
		}
		return actionItem_0;
	}

	public ActionExecuteContext ExecuteAction(ActionItem action, int btnIndex, PointTargetInfo targetInfo, bool enableDebugging, bool isWaitComplete, bool isSubAction, string inputParam, ActionTrigger actionTrigger, Action funcAfterExecute = null, ActionExtraContextData actionExtraContextData = null, CancellationToken? cts = null)
	{
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
		_003C_003Ec__DisplayClass29_.iYgvXIdVebT = enableDebugging;
		_003C_003Ec__DisplayClass29_.oYKvXWHuU69 = this;
		_003C_003Ec__DisplayClass29_.sJdvXkt6o2g = action;
		_003C_003Ec__DisplayClass29_.T94vXGN0HRP = targetInfo;
		_003C_003Ec__DisplayClass29_.g3hvXsXra8c = actionTrigger;
		_003C_003Ec__DisplayClass29_.sZCvXHj9bTO = actionExtraContextData;
		_003C_003Ec__DisplayClass29_.YO9vX14XhM7 = inputParam;
		_003C_003Ec__DisplayClass29_.ejIvXb0UwkO = btnIndex;
		_003C_003Ec__DisplayClass29_.adivXX9322w = funcAfterExecute;
		_003C_003Ec__DisplayClass29_.sJdvXkt6o2g = VuctRxC7icX(_003C_003Ec__DisplayClass29_.sJdvXkt6o2g);
		if (_003C_003Ec__DisplayClass29_.sJdvXkt6o2g == null)
		{
			return null;
		}
		if (_003C_003Ec__DisplayClass29_.T94vXGN0HRP != null && _003C_003Ec__DisplayClass29_.T94vXGN0HRP.IsOnQuicker && !_003C_003Ec__DisplayClass29_.T94vXGN0HRP.IsOnNonTriggerWindow && _003C_003Ec__DisplayClass29_.T94vXGN0HRP.HWnd != IntPtr.Zero && _003C_003Ec__DisplayClass29_.g3hvXsXra8c == ActionTrigger.Panel)
		{
			NativeMethods.SetForegroundWindow(_003C_003Ec__DisplayClass29_.T94vXGN0HRP.HWnd);
			Thread.Sleep(50);
		}
		else if (_003C_003Ec__DisplayClass29_.T94vXGN0HRP == null && _003C_003Ec__DisplayClass29_.g3hvXsXra8c.IsEither(ActionTrigger.FloatButton, ActionTrigger.FloatPanel) && string.Equals(AppState.CurrentProcessName, "quicker", StringComparison.OrdinalIgnoreCase) && NativeMethods.GetWindowProcessId(AppState.AppServer.GetLastForegroundWindow()) == AppState.QuickerProcessId)
		{
			NativeMethods.SetForegroundWindow(AppState.AppServer.GetLastForegroundWindow());
			Thread.Sleep(50);
		}
		if (!string.IsNullOrEmpty(AppState.AlwaysDebugActionId) && string.Equals(AppState.AlwaysDebugActionId, _003C_003Ec__DisplayClass29_.sJdvXkt6o2g.Id))
		{
			_003C_003Ec__DisplayClass29_.iYgvXIdVebT = true;
		}
		_003C_003Ec__DisplayClass29_.PB0vX6FBICo = null;
		Task task = GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(_003C_003Ec__DisplayClass29_.AbevXe1ORWu, "action:" + _003C_003Ec__DisplayClass29_.sJdvXkt6o2g.Title);
		if (!isSubAction && _003C_003Ec__DisplayClass29_.g3hvXsXra8c != ActionTrigger.EventTrigger)
		{
			Task.Run((Action)_003C_003Ec__DisplayClass29_.UehvXY0BBUV);
		}
		if (isWaitComplete)
		{
			task.Wait();
			return _003C_003Ec__DisplayClass29_.PB0vX6FBICo;
		}
		return null;
	}

	public (ActionItem actionItem, ActionExecuteContext context, string errorMessage) ExecuteActionByIdOrName(string actionIdOrNameOrTempplateId, PointTargetInfo targetInfo, bool enableDebugging, bool isWaitComplete, bool isSubAction, string inputParam, ActionTrigger actionTrigger, ActionExtraContextData actionExtraContextData = null, CancellationToken? cts = null)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.GRMvXKpxcdA = eGptRUyJGfy.QHmtXwg81eY(actionIdOrNameOrTempplateId);
		if (_003C_003Ec__DisplayClass30_.GRMvXKpxcdA.action == null)
		{
			_003C_003Ec__DisplayClass30_.GRMvXKpxcdA = eGptRUyJGfy.QHmtXwg81eY(HttpUtility.UrlDecode(actionIdOrNameOrTempplateId));
		}
		if (_003C_003Ec__DisplayClass30_.GRMvXKpxcdA.action != null)
		{
			if (actionTrigger == ActionTrigger.CircleMenu && KeyboardHelper.IsKeyDown(VirtualKeyCode.LSHIFT))
			{
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass30_.kKOvXm09cvD);
				return (actionItem: _003C_003Ec__DisplayClass30_.GRMvXKpxcdA.action, context: null, errorMessage: "");
			}
			return (actionItem: _003C_003Ec__DisplayClass30_.GRMvXKpxcdA.action, context: ExecuteAction(_003C_003Ec__DisplayClass30_.GRMvXKpxcdA.action, -1, targetInfo, enableDebugging, isWaitComplete, isSubAction, inputParam, actionTrigger, null, actionExtraContextData, cts), errorMessage: "");
		}
		if (isSubAction)
		{
			string stackTrace = Environment.StackTrace;
			if (!stackTrace.Contains("IntelliTools") && !stackTrace.Contains("CeaQuickerTools"))
			{
				throw new InvalidDataException(_003C_003Ec__DisplayClass30_.GRMvXKpxcdA.message);
			}
			AppHelper.ShowWarning("未找到动作：" + actionIdOrNameOrTempplateId);
			return (actionItem: null, context: null, errorMessage: "未找到动作：" + actionIdOrNameOrTempplateId);
		}
		string text = $"未能成功运行动作 {actionIdOrNameOrTempplateId} ({actionTrigger})。\r\n错误：" + _003C_003Ec__DisplayClass30_.GRMvXKpxcdA.message;
		ruWtR5o9n6j.Warn(text + Environment.StackTrace);
		AppHelper.ShowWarning(text);
		return (actionItem: null, context: null, errorMessage: text);
	}

	public IDictionary<string, object> ExecuteActionSubProgram(string actionIdOrNameOrTempplateId, string spName, IDictionary<string, object> inputParams, ActionExtraContextData actionExtraContextData = null, CancellationToken? cts = null)
	{
		bool isDebugging = false;
		(ActionItem, string) tuple = eGptRUyJGfy.QHmtXwg81eY(actionIdOrNameOrTempplateId);
		if (tuple.Item1 == null)
		{
			tuple = eGptRUyJGfy.QHmtXwg81eY(HttpUtility.UrlDecode(actionIdOrNameOrTempplateId));
		}
		if (tuple.Item1 != null)
		{
			var (actionItem, _) = tuple;
			using ActionExecuteContext actionExecuteContext = new ActionExecuteContext(null, actionItem, new PointTargetInfo(), this, isDebugging, 0, actionExtraContextData, cts)
			{
				ActiveWindowHwnd = K03tRMdjDH5.ForegroundWindowHwnd,
				InputParam = string.Empty,
				ActionTrigger = ActionTrigger.NA,
				IsRootContext = true
			};
			ActionItem actionItem2 = actionItem;
			if (actionItem.UseTemplate && !string.IsNullOrEmpty(actionItem.TemplateId))
			{
				actionItem2 = actionItem.Clone(false);
				SharedActionDto result = eGptRUyJGfy.Wott6D3Yp9F(Guid.Parse(actionItem.TemplateId), actionItem.TemplateRevision).GetAwaiter().GetResult();
				actionItem2.Data = result.Data;
				actionItem2.Data2 = result.Data2;
				actionItem2.Data3 = result.Data3;
				actionItem2.Children = result.Children;
			}
			if (actionItem2.ActionType != ActionType.XAction)
			{
				throw new InvalidDataException("不是一个组合动作");
			}
			XAction xAction = JsonConvert.DeserializeObject<XAction>(actionItem2.Data);
			if (xAction == null)
			{
				throw new InvalidDataException("组合动作数据为空");
			}
			actionExecuteContext.XProgram = xAction;
			return actionExecuteContext.RunSp(spName, inputParams);
		}
		string message = "未能成功运行动作的子程序，找不到动作：" + actionIdOrNameOrTempplateId + " 。错误：" + tuple.Item2;
		ruWtR5o9n6j.Warn(message);
		AppHelper.ShowWarning(message);
		return null;
	}

	private static bool ihStRrSd931(params int[] buttons)
	{
		int num = 0;
		while (true)
		{
			if (num < buttons.Length)
			{
				if (AppHelper.IsGlobalButton(buttons[num]))
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

	private static bool FjFtRpAnuQv(params int[] buttons)
	{
		int num = 0;
		while (true)
		{
			if (num < buttons.Length)
			{
				if (!AppHelper.IsGlobalButton(buttons[num]))
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

	public void RequestSwitchProfile(string profileId, bool isEditing)
	{
		wE3tRTpIAYG.RequestSwitchProfile(profileId, isEditing);
	}

	public bool IsDefaultProfile(ActionProfile profile)
	{
		return profile == sxJtRfJwBTQ.GetDefaultProfile();
	}

	public ActionProfile AddProfile(CreateProfileDto dto)
	{
		ActionProfile actionProfile = sxJtRfJwBTQ.CreateProfile(dto);
		if (actionProfile.IsGlobalProfile())
		{
			wE3tRTpIAYG.LoadGlobalProfiles();
		}
		return actionProfile;
	}

	[AsyncStateMachine(typeof(_003CSaveFileVersionInfo_003Ed__37))]
	public Task<ExeFileVersionDto> SaveFileVersionInfo(string exePath)
	{
		_003CSaveFileVersionInfo_003Ed__37 stateMachine = default(_003CSaveFileVersionInfo_003Ed__37);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ExeFileVersionDto>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.exePath = exePath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void RemoveProfile(ActionProfile profile)
	{
		if (!sxJtRfJwBTQ.CanDeleteProfile(profile))
		{
			AppHelper.ShowWarning("此动作页无法删除。它可能是系统默认的或被其他面板链接。");
			return;
		}
		if (profile == GetCurrentContextProfile())
		{
			wE3tRTpIAYG.ChangeExe("");
		}
		sxJtRfJwBTQ.RemoveProfile(profile);
		if (profile.IsGlobalProfile())
		{
			wE3tRTpIAYG.LoadGlobalProfiles();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public bool StartVoiceInput()
	{
		if (xAStRlnsigL.IsEnabled)
		{
			if (Kk6tRDTKDW3.GetClientCount() < 1)
			{
				AppHelper.ShowWarning("手机客户端尚未连接。");
				return false;
			}
			Kk6tRDTKDW3.StartVoiceInput();
			return true;
		}
		AppHelper.ShowWarning("Quicker未启用");
		return false;
	}

	public bool IsActionExists(string id)
	{
		return sxJtRfJwBTQ.IsActionExists(id);
	}

	public bool IsQuickerFocused()
	{
		return K03tRMdjDH5.ForegroundProcessId == AppState.QuickerProcessId;
	}

	public void OnActiveWindowChanged(object sender, object args)
	{
		if (K03tRMdjDH5.ForegroundProcessId == 0)
		{
			ruWtR5o9n6j.Info("当前活动ProcessId=0，Idle");
			return;
		}
		AppState.HZUt7RIVqKK().VpEtkCw9yBh(K03tRMdjDH5.ForegroundWindowHwnd, K03tRMdjDH5.ForegroundProcessId);
		int num = 0;
		if (!Mk0XnjQGyvCk7w7dGZ8e())
		{
			int num2 = default(int);
			num = num2;
		}
		do
		{
			switch (num)
			{
			default:
				goto IL_0050;
			case 1:
				break;
			}
			break;
			IL_0050:
			string.Equals(AppState.CurrentProcessName, K03tRMdjDH5.ForegroundProcessName, StringComparison.OrdinalIgnoreCase);
			AppState.CurrentProcessName = K03tRMdjDH5.ForegroundProcessName;
			num = 1;
		}
		while (Mk0XnjQGyvCk7w7dGZ8e());
		AppState.CurrentProcessId = K03tRMdjDH5.ForegroundProcessId;
		string text = "";
		text = ((!string.Equals(AppState.CurrentProcessName, "explorer", StringComparison.OrdinalIgnoreCase)) ? K03tRMdjDH5.ForegroundExeName : (K03tRMdjDH5.IsDesktop ? (AppState.CurrentProcessName = "desktop") : ((!K03tRMdjDH5.IsTaskbar) ? "explorer.exe" : (AppState.CurrentProcessName = "taskbar"))));
		AppState.CurrentExeName = text;
		AppState.CurrentExePath = K03tRMdjDH5.ExeFilePath;
		WoctRdmx0xX.NotifyActiveProcessChanged(this, AppState.CurrentProcessName);
		if (AppState.HS2taepcAbc().CanSwitchProfileByActiveProcess())
		{
			UpdateContextPanel();
		}
	}

	public void UpdateContextPanel()
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_;
		while (true)
		{
			_003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
			if (iecNXTQGWP5ob7dtni4P != null)
			{
				switch (0)
				{
				case 2:
					break;
				case 1:
					goto IL_002a;
				default:
					goto IL_00af;
				}
				continue;
			}
			goto IL_002a;
			IL_00af:
			_003C_003Ec__DisplayClass45_.YmavXprSHnJ = "资源管理器";
			break;
			IL_002a:
			_003C_003Ec__DisplayClass45_.WDOvXrDnVEn = this;
			_003C_003Ec__DisplayClass45_.alLvXBjq9PD = K03tRMdjDH5.ForegroundExeName;
			_003C_003Ec__DisplayClass45_.YmavXprSHnJ = "";
			if (!string.Equals(K03tRMdjDH5.ForegroundProcessName, "explorer", StringComparison.OrdinalIgnoreCase))
			{
				break;
			}
			if (K03tRMdjDH5.IsDesktop)
			{
				_003C_003Ec__DisplayClass45_.alLvXBjq9PD = "desktop";
				_003C_003Ec__DisplayClass45_.YmavXprSHnJ = CommonStrings.CommonExeInfo_Desktop_Name;
				break;
			}
			if (K03tRMdjDH5.IsTaskbar)
			{
				_003C_003Ec__DisplayClass45_.alLvXBjq9PD = "taskbar";
				_003C_003Ec__DisplayClass45_.YmavXprSHnJ = "Windows任务栏";
				break;
			}
			goto IL_00af;
		}
		if (wE3tRTpIAYG.ChangeExe(_003C_003Ec__DisplayClass45_.alLvXBjq9PD, true))
		{
			System.Windows.Application.Current.Dispatcher?.InvokeAsync(_003C_003Ec__DisplayClass45_.c4UvXxQOCQj);
		}
	}

	public void Start()
	{
		wE3tRTpIAYG.StartUp();
		K03tRMdjDH5.RaiseOne(false);
	}

	public void ShutDown()
	{
		K03tRMdjDH5.Unhook();
	}

	public void ToggleLockPanel(bool? lockSwitch = null)
	{
		DkKtRo833jV.LockContextPanel = lockSwitch ?? (!DkKtRo833jV.LockContextPanel);
		WoctRdmx0xX.NotifyStateChange(this, ChangedStateType.LockPanel, DkKtRo833jV.LockContextPanel);
		if (!DkKtRo833jV.LockContextPanel)
		{
			UpdateContextPanel();
		}
	}

	public void LoadExeProfilesAndLock(string exeName, bool lockPanel, bool gotoFirst = false)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.tWKvXjNUBUO = this;
		_003C_003Ec__DisplayClass49_.MHTvXnAw1hp = exeName;
		_003C_003Ec__DisplayClass49_.V3pvX4Qe4Jd = gotoFirst;
		_003C_003Ec__DisplayClass49_.we7vX5dery2 = lockPanel;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass49_.LGYvXQVe8Wy);
	}

	public void FeedbackAction(ActionItem action, bool addToPendingListIfCancel)
	{
		if (!AppState.DataService.BV9tm7kpqII() && !AppState.DataService.JTftmqIPFYx())
		{
			ActionFeedbackWindow actionFeedbackWindow = new ActionFeedbackWindow(action, addToPendingListIfCancel);
			actionFeedbackWindow.Owner = null;
			actionFeedbackWindow.Show();
		}
		else
		{
			AppHelper.ShowInformation("体验帐号不支持此功能。");
		}
	}

	public static void ShowActionInfo(ActionItem action, Window ownerWindow)
	{
		ActionInfoWindow actionInfoWindow = new ActionInfoWindow(action);
		actionInfoWindow.Owner = ownerWindow;
		actionInfoWindow.ShowDialog();
	}

	[AsyncStateMachine(typeof(_003CGetExeIconUrl_003Ed__52))]
	public Task<string> GetExeIconUrl(string exePathName)
	{
		_003CGetExeIconUrl_003Ed__52 stateMachine = default(_003CGetExeIconUrl_003Ed__52);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.exePathName = exePathName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void SaveExeSettings(ExeSettings exeSettings)
	{
		eGptRUyJGfy.a65t6APblky(exeSettings);
		wE3tRTpIAYG.ReloadProfilesIfNeeded(exeSettings.Exe);
	}

	public static string GetExeForSearchActions(string exe)
	{
		if (!string.IsNullOrEmpty(exe) && !(exe == "_global") && !(exe == "taskbar") && !exe.StartsWith("#"))
		{
			if (exe == "desktop")
			{
				exe = "explorer.exe";
			}
		}
		else
		{
			exe = "common";
		}
		return exe;
	}

	public static void OpenShareBase(string origininExe)
	{
		try
		{
			string exeForSearchActions = GetExeForSearchActions(origininExe);
			Process.Start("https://getquicker.net/Share/Exe/" + exeForSearchActions);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法打开网址。" + ex.Message);
		}
	}

	public void ShowSearchWindow(string searchText, bool checkClipboard)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.OmTvXd5566Q = checkClipboard;
		_003C_003Ec__DisplayClass56_.RI2vXostHIY = searchText;
		_003C_003Ec__DisplayClass56_.RI2vXostHIY = _003C_003Ec__DisplayClass56_.RI2vXostHIY ?? "";
		if (JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Alt)
		{
			J8BtRBUwMwU();
		}
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass56_.IDXvXDL1fRZ);
	}

	private static void J8BtRBUwMwU()
	{
		if (string.Equals(AppState.CurrentProcessName, "quicker", StringComparison.OrdinalIgnoreCase))
		{
			try
			{
				InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.LMENU);
				InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.LMENU);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("重置alt按键出错：" + ex.Message);
			}
		}
	}

	public void CloseSearch()
	{
		AppState.HS2taepcAbc().CloseSearch();
	}

	public void ShowConfigWindow()
	{
		AppWindowManager.ShowSettingsWindow(null);
	}

	public bool IsActionRunning(string actionId)
	{
		return fajtRFXAueR.IsActionRunning(actionId);
	}

	public bool IsCurrentActionRunning(string actionId)
	{
		return fajtRFXAueR.IsCurrentActionRunning(actionId);
	}

	public int GetActionRunningCount(string actionId)
	{
		return fajtRFXAueR.GetActionRunningCount(actionId);
	}

	public void RequestShowPanel()
	{
		WoctRdmx0xX.NotifyRequestShowPanel(this, PopupSource.Action);
	}

	public void RequestShowPanel(bool activatePointingWindow, PopupSource popupSource, bool followMouse)
	{
		AppState.v5FtaQ4hQfg().Fa9vLYN4IuJ(activatePointingWindow, popupSource, followMouse);
	}

	public void TogglePause()
	{
		AppHelper.RunOnUiThread(false, _003C_003Ec.hNWvX9vIoId ?? (_003C_003Ec.hNWvX9vIoId = _003C_003Ec.p2PvXZl6bAr.sgSvXcSFvAk));
	}

	public void RunLastAction(ActionTrigger actionTrigger)
	{
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
		_003C_003Ec__DisplayClass67_.qn1vXMs7qrv = this;
		_003C_003Ec__DisplayClass67_.U62vXA0yWSM = actionTrigger;
		if (AppHelper.fLiLTj0x4QY() - yxdtRzsG7OZ < 30L)
		{
			AppHelper.ShowWarning("重复太快了，可能是动作中模拟了执行最后动作的快捷键，已中止操作。");
			return;
		}
		yxdtRzsG7OZ = AppHelper.fLiLTj0x4QY();
		if (string.IsNullOrEmpty(AppState.P7gt7BYmHZ0.GetLastActionId()))
		{
			AppHelper.ShowWarning("未找到最后使用的动作。");
			return;
		}
		Task.Run((Action)_003C_003Ec__DisplayClass67_.QxCvXTs3KyZ);
		int num = 0;
		if (iecNXTQGWP5ob7dtni4P != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public void StopAllRunningAction()
	{
		AppHelper.RunOnUiThread(false, KpqtRjTvaUD);
	}

	public string GetRunningActionsInfo()
	{
		return fajtRFXAueR.GetAllRunningActions();
	}

	public void RequestReinstallHook()
	{
		WoctRdmx0xX.RequestReinstallHook(this);
	}

	public void ShowDashboardWindow([Quicker.Annotations.CanBeNull] string exe = null)
	{
		_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
		_003C_003Ec__DisplayClass71_.lAVvXFHTSyl = exe;
		if (xAStRlnsigL.IsEnabled)
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass71_.xsmvXO55ynr);
		}
	}

	public void ToggleTextFloatWindow()
	{
		oxMtRimBX1K.Toggle();
	}

	public void ShowExeSettingsWindow(string exe = null)
	{
		_003C_003Ec__DisplayClass73_0 _003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_0();
		_003C_003Ec__DisplayClass73_.JM6vXlnaW90 = exe;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass73_.tGnvXUnj8gp);
	}

	public void CloseAllFloatWindow()
	{
		AppHelper.RunOnUiThread(false, gPctRnhWCgi);
	}

	public void EditActionById(string actionId)
	{
		_003C_003Ec__DisplayClass75_0 _003C_003Ec__DisplayClass75_ = new _003C_003Ec__DisplayClass75_0();
		_003C_003Ec__DisplayClass75_.IBavX3qaM6B = actionId;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass75_.LeEvXiV7rY8);
	}

	public void UpdatePushConnection()
	{
        yCQtR3MM1fT.Stop();
    }

	public void NotifyOtherMachineSync()
	{
        // 工作区保存在本机，不通知原厂服务器或其它账号设备。
    }

	public IntPtr GetLastForegroundWindowNotOfQuicker()
	{
		return K03tRMdjDH5.LastNotQuickerForegroundWindow;
	}

	public IntPtr GetLastForegroundWindow()
	{
		return K03tRMdjDH5.LastForegroundWindow;
	}

	public int StopActionByIdOrName(string idOrName, int currentContextId, bool skipStopWarning)
	{
		return fajtRFXAueR.StopActionByIdOrName(idOrName, currentContextId, skipStopWarning);
	}

	public bool IsPanelOnCustomProfile()
	{
		return wE3tRTpIAYG.CurrentExe?.StartsWith("#_") ?? false;
	}

	internal string LoadSkin(Guid id, bool keepSize = true, bool confirm = true, bool showPanel = true)
	{
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			throw new NotSupportedException("需要专业版");
		}
		bool bool_ = false;
		int num;
		if (!qqVtqwLBvth.Contains(id))
		{
			qqVtqwLBvth.Add(id);
			num = 2;
			if (!Mk0XnjQGyvCk7w7dGZ8e())
			{
				goto IL_00a0;
			}
			goto IL_00a4;
		}
		bool_ = true;
		goto IL_00b7;
		IL_00d7:
		ApiResult<GetSkinDto> result = default(ApiResult<GetSkinDto>);
		UiSettings uiSettings = JsonConvert.DeserializeObject<UiSettings>(result.Data.UiSettingsDataJson);
		bool flag = default(bool);
		UiSettings uiSettings2 = default(UiSettings);
		if (uiSettings != null)
		{
			uiSettings.RestoreCircleMenuSettings(flag ? eGptRUyJGfy.CpItmVISR7P().DarkUiSettings.CircleMenu : eGptRUyJGfy.CpItmVISR7P().UiSettings.CircleMenu);
			if (keepSize)
			{
				uiSettings.FontSize = uiSettings2.FontSize;
				uiSettings.ButtonSize = uiSettings2.ButtonSize;
				uiSettings.ButtonSpace = uiSettings2.ButtonSpace;
				uiSettings.FrameBorderWidth = uiSettings2.FrameBorderWidth;
				uiSettings.RoundCornerMode = uiSettings2.RoundCornerMode;
				uiSettings.ButtonCornerRadius = uiSettings2.ButtonCornerRadius;
			}
			if (flag)
			{
				eGptRUyJGfy.CpItmVISR7P().DarkUiSettings = uiSettings;
			}
			else
			{
				eGptRUyJGfy.CpItmVISR7P().UiSettings = uiSettings;
			}
			eGptRUyJGfy.ydot6rVZAkW();
			WoctRdmx0xX.NotifyUserSettingsChange(this);
			if (showPanel)
			{
				WoctRdmx0xX.NotifyRequestShowPanel(this, PopupSource.Keyboard);
			}
			return result.Data.Name;
		}
		throw new InvalidOperationException("获取的外观数据为空！");
		IL_00b7:
		result = aFIptTXYsUoTUF4v33R.wTHtbCar8f3(id, bool_).Result;
		UiSettings uiSettings3;
		if (result.IsSuccess)
		{
			if (!(flag = FMP9ONqzXcgZ6r3WmZZ.D80HY8PEx7()))
			{
				num = 0;
				if (!Mk0XnjQGyvCk7w7dGZ8e())
				{
					goto IL_00a0;
				}
				goto IL_00a4;
			}
			uiSettings3 = eGptRUyJGfy.CpItmVISR7P().DarkUiSettings;
			goto IL_0071;
		}
		throw new InvalidOperationException("获取外观失败！" + result.Message);
		IL_0071:
		uiSettings2 = uiSettings3;
		AppState.K7At7EG7JcB(JsonConvert.SerializeObject(uiSettings2));
		num = 1;
		if (!Mk0XnjQGyvCk7w7dGZ8e())
		{
			goto IL_00a0;
		}
		goto IL_00a4;
		IL_00a0:
		int num2 = default(int);
		num = num2;
		goto IL_00a4;
		IL_00a4:
		switch (num)
		{
		case 2:
			goto IL_00b7;
		case 1:
			goto IL_00d7;
		}
		uiSettings3 = eGptRUyJGfy.CpItmVISR7P().UiSettings;
		goto IL_0071;
	}

	internal void sAstRQZr0uL()
	{
		if (!string.IsNullOrEmpty(AppState.VyZt7PZDFO1()))
		{
			UiSettings uiSettings = JsonConvert.DeserializeObject<UiSettings>(AppState.VyZt7PZDFO1());
			if (FMP9ONqzXcgZ6r3WmZZ.D80HY8PEx7())
			{
				eGptRUyJGfy.CpItmVISR7P().DarkUiSettings = uiSettings;
			}
			else
			{
				eGptRUyJGfy.CpItmVISR7P().UiSettings = uiSettings;
			}
			eGptRUyJGfy.ydot6rVZAkW();
			WoctRdmx0xX.NotifyUserSettingsChange(this);
			WoctRdmx0xX.NotifyRequestShowPanel(this, PopupSource.Keyboard);
			if (!Mk0XnjQGyvCk7w7dGZ8e())
			{
				switch (0)
				{
				}
			}
			AppState.K7At7EG7JcB(null);
		}
		else
		{
			AppHelper.ShowWarning("没有备份的外观数据！\r\n请在安装外观以后使用此功能。");
		}
	}

	public void ShowOrHideAllImageWindows(bool? show)
	{
		_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_0();
		_003C_003Ec__DisplayClass85_.mojvXzLOAUm = show;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass85_.WeuvXfDh8et);
	}

	static AppServer()
	{
		ruWtR5o9n6j = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void KpqtRjTvaUD()
	{
		AppState.HS2taepcAbc()?.ClearMessages();
		fajtRFXAueR?.StopAll();
	}

	[CompilerGenerated]
	private void gPctRnhWCgi()
	{
		WoctRdmx0xX.CloseFloatingButtons(this);
	}

	[CompilerGenerated]
	private void jnMtR42Kkiu()
	{
		if (AO7eLUM7kJyEdiOQu2O.EnableConnection)
		{
			try
			{
				yCQtR3MM1fT.Start();
				return;
			}
			catch (Exception ex)
			{
				string message = "启动长连接服务出错。" + ex.Message;
				ruWtR5o9n6j.Warn(message, ex);
				AppHelper.ShowWarning(message);
				return;
			}
		}
		try
		{
			yCQtR3MM1fT.Stop();
		}
		catch (Exception ex2)
		{
			ruWtR5o9n6j.Warn("停止长连接服务出错。" + ex2.Message, ex2);
		}
	}

	internal static bool Mk0XnjQGyvCk7w7dGZ8e()
	{
		return iecNXTQGWP5ob7dtni4P == null;
	}
}
