using Quicker.Common;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Network;
using Quicker.Domain.Services;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using TWhxvC2aCPi6qnhlPvy;

namespace Quicker.Domain.Messages;

public static class HubExtension
{
	internal static object b3krThQvUXupoQwakhwI;

	public static void NotifyPanelUpdate(this ITinyMessengerHub hub, object sender, bool updateGlobal, bool updateContext)
	{
		PanelUpdateMessage message = new PanelUpdateMessage(sender, updateGlobal, updateContext);
		hub.Publish(message);
	}

	public static void NotifyButtonClick(this ITinyMessengerHub hub, object sender, int buttonIndex, PointTargetInfo targetInfo, ActionTrigger actionTrigger, bool debug)
	{
		ButtonClickMessage message = new ButtonClickMessage(sender, buttonIndex, targetInfo, actionTrigger, debug);
		hub.Publish(message);
	}

	public static void NotifyRequestShowPanel(this ITinyMessengerHub hub, object sender, PopupSource source = PopupSource.Others)
	{
		RequestShowPanelMessage message = new RequestShowPanelMessage(sender, source);
		hub.Publish(message);
	}

	public static void RequestReinstallHook(this ITinyMessengerHub hub, object sender)
	{
		RequireReinstallHookMessage message = new RequireReinstallHookMessage(sender);
		hub.Publish(message);
	}

	public static void UpdateSyncState(this ITinyMessengerHub hub, object sender, QuickerSyncState syncState)
	{
		SyncStateMessage message = new SyncStateMessage(sender, syncState);
		hub.Publish(message);
	}

	public static void NotifyUserSettingsChange(this ITinyMessengerHub hub, object sender)
	{
		UserSettingsChangedMessage message = new UserSettingsChangedMessage(sender);
		hub.Publish(message);
	}

	public static void RequestChangePage(this ITinyMessengerHub hub, object sender, bool isGlobal, bool goLeft)
	{
		RequestChangePageMessage message = new RequestChangePageMessage(sender, isGlobal, goLeft);
		hub.PublishAsync(message);
	}

	public static void NotifySyncComplete(this ITinyMessengerHub hub, object sender)
	{
		SyncCompletedMessage message = new SyncCompletedMessage(sender);
		hub.Publish(message);
	}

	public static void NotifyRunAction(this ITinyMessengerHub hub, object sender, string actionId, bool enableDebugging, bool isSubAction, ActionTrigger actionTrigger, bool fromFloatWindow = false, PointTargetInfo pointTargetInfo = null, string param = "")
	{
		RunActionMessage message = new RunActionMessage(sender, actionId, enableDebugging, isSubAction, fromFloatWindow, pointTargetInfo, actionTrigger, param);
		hub.PublishAsync(message);
	}

	public static void NotifyActionEditComplete(this ITinyMessengerHub hub, object sender, string actionId, ActionItem action, ActionProfile profile)
	{
		ActionEditCompletedMessage message = new ActionEditCompletedMessage(sender, actionId, action, profile);
		hub.PublishAsync(message);
	}

	public static void NotifyActionEditBegin(this ITinyMessengerHub hub, object sender, EditingActionInfo editingActionInfo)
	{
		ActionEditBeginMessage message = new ActionEditBeginMessage(sender, editingActionInfo);
		hub.PublishAsync(message);
	}

	public static void SendAppCommand(this ITinyMessengerHub hub, object sender, AppCommand command, string data = null)
	{
		AppCommandMessage message = new AppCommandMessage(sender, command, data);
		hub.PublishAsync(message);
	}

	public static void TogglePausePopup(this ITinyMessengerHub hub, object sender)
	{
		TogglePausePopupMessage message = new TogglePausePopupMessage(sender);
		hub.PublishAsync(message);
	}

	public static void CloseFloatingButtons(this ITinyMessengerHub hub, object sender)
	{
		CloseAllFloatingActions message = new CloseAllFloatingActions(sender);
		hub.Publish(message);
	}

	public static void StopRunningActions(this ITinyMessengerHub hub, object sender)
	{
		StopRunningActionMessage message = new StopRunningActionMessage(sender);
		hub.Publish(message);
	}

	public static void ToggleLockPanel(this ITinyMessengerHub hub, object sender)
	{
		ToggleLockPanelMessage message = new ToggleLockPanelMessage(sender);
		hub.Publish(message);
	}

	public static void NotifyStateChange(this ITinyMessengerHub hub, object sender, ChangedStateType stateType, object value)
	{
		StateChangedMessage message = new StateChangedMessage(sender, stateType, value);
		hub.Publish(message);
	}

	public static void NotifyActionDeleted(this ITinyMessengerHub hub, object sender, string actionId)
	{
		ActionDeletedMessage message = new ActionDeletedMessage(sender, actionId);
		hub.Publish(message);
	}

	public static void NotifyActiveProcessChanged(this ITinyMessengerHub hub, object sender, string processName)
	{
		ActiveProcessChangedMessage message = new ActiveProcessChangedMessage(sender, processName);
		hub.Publish(message);
	}

	public static void NotifyCommonDataUpdated(this ITinyMessengerHub hub, object sender, string dataItemId)
	{
		WOkyiC2pewwqUAWVaJb message = new WOkyiC2pewwqUAWVaJb(sender, dataItemId);
		hub.Publish(message);
	}

	public static void NotifyActionUpdated(this ITinyMessengerHub hub, object sender, string actionId)
	{
		ActionUpdatedMessage message = new ActionUpdatedMessage(sender, actionId);
		hub.Publish(message);
	}

	internal static bool sK4U5ZQvxrOBAYGkDHJh()
	{
		return b3krThQvUXupoQwakhwI == null;
	}
}
