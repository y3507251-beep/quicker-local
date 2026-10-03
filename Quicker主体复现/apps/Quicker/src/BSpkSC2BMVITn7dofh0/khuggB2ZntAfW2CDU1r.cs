using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Extensions;
using Quicker.Domain.Floating;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View;

namespace BSpkSC2BMVITn7dofh0;

internal class khuggB2ZntAfW2CDU1r
{
	private bool kMctqoS51ad;

	private FloatButtonWindow fvjtqTcMq4e;

	private System.Windows.Point? q81tqMVMPD6;

	internal static khuggB2ZntAfW2CDU1r l7883UQGUV1UFkmKnfYY;

	[SpecialName]
	public bool KxCtqDqNIbU()
	{
		return kMctqoS51ad;
	}

	public static FloatButtonWindow FloatAction(ActionItem action, System.Drawing.Point position, AppServer appServer, ITinyMessengerHub hub, ActionEditMgr actionEditMgr, DataService dataService, FloatButtonAndPanelManager floatButtonAndPanelManager, FloatItemState itemState = null, string bindingProcessName = "", bool useWpfPoint = false)
	{
		int num = 2;
		FloatButtonWindow floatButtonWindow = default(FloatButtonWindow);
		while (action != null)
		{
			int num2 = 1;
			if (l7883UQGUV1UFkmKnfYY != null)
			{
				goto IL_009a;
			}
			goto IL_009e;
			IL_009a:
			num2 = num;
			goto IL_009e;
			IL_009e:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (action.XBttcfC2xjC())
					{
						floatButtonWindow = new FloatButtonWindow(action, position, appServer, hub, actionEditMgr, dataService, floatButtonAndPanelManager, useWpfPoint);
						floatButtonWindow.ResizeMode = floatButtonAndPanelManager.FloatButtonResizeMode;
						if (itemState != null)
						{
							goto IL_0055;
						}
						if (!string.Equals(bindingProcessName, "NO_BIND"))
						{
							floatButtonWindow.BindingProcessName = (string.IsNullOrEmpty(bindingProcessName) ? AppState.CurrentProcessName : bindingProcessName);
							if (!string.IsNullOrEmpty(floatButtonWindow.BindingProcessName))
							{
								floatButtonWindow.EnableProcessBinding = AppState.DataService.CpItmVISR7P().FloatButtonBindProcessByDefault;
							}
						}
						goto default;
					}
					AppHelper.ShowWarning("此动作不支持悬浮。");
					return null;
				case 2:
					break;
				default:
					floatButtonWindow.Show();
					return floatButtonWindow;
				}
				break;
				IL_0055:
				floatButtonWindow.BindingProcessName = itemState.BindProcessName;
				floatButtonWindow.EnableProcessBinding = itemState.IsBindProcess;
				floatButtonWindow.Width = itemState.Width;
				floatButtonWindow.Height = itemState.Height;
				num2 = 0;
				if (l7883UQGUV1UFkmKnfYY == null)
				{
					continue;
				}
				goto IL_009a;
			}
		}
		return null;
	}

	public void GTntqnJGe6L()
	{
		fvjtqTcMq4e?.DragMoveEnd();
		kMctqoS51ad = false;
		fvjtqTcMq4e = null;
	}

	public void ueNtq4hCqtu(Visual visual_0)
	{
		if (fvjtqTcMq4e != null)
		{
			System.Drawing.Point topLeftScreenPositionBasedOnMouseAndVisualOffset = AppHelper.GetTopLeftScreenPositionBasedOnMouseAndVisualOffset(visual_0, q81tqMVMPD6);
			fvjtqTcMq4e.Ga3gMjZnk4W(topLeftScreenPositionBasedOnMouseAndVisualOffset);
		}
	}

	public FloatButtonWindow S0utq5GWhlA(ActionItem actionItem_0, Visual visual_0, System.Windows.Point point_0, AppServer appServer_0, ITinyMessengerHub itinyMessengerHub_0, ActionEditMgr actionEditMgr_0, DataService dataService_0, FloatButtonAndPanelManager floatButtonAndPanelManager_0, string string_0 = "")
	{
		q81tqMVMPD6 = point_0;
		kMctqoS51ad = true;
		System.Drawing.Point topLeftScreenPositionBasedOnMouseAndVisualOffset = AppHelper.GetTopLeftScreenPositionBasedOnMouseAndVisualOffset(visual_0, q81tqMVMPD6);
		fvjtqTcMq4e = FloatAction(actionItem_0, topLeftScreenPositionBasedOnMouseAndVisualOffset, appServer_0, itinyMessengerHub_0, actionEditMgr_0, dataService_0, floatButtonAndPanelManager_0, null, string_0);
		return fvjtqTcMq4e;
	}

	internal static bool bNJ82vQGxeSbbI5vrvge()
	{
		return l7883UQGUV1UFkmKnfYY == null;
	}
}
