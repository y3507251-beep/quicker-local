using System;
using Quicker.Utilities;

namespace Quicker.Domain.Push;

// 供现有界面读取本地模式状态。原厂 WebSocket、设备账号认证和重连代码已移除。
public class PushClient
{
    public EventHandler<ConnectionStatusChangedEventArgs> StatusChanged;
    public bool IsStarted => false;
    public DateTime? LastTryConnectTime => null;
    public DateTime? LastConnectedTime => null;
    public PushConnectionState State => PushConnectionState.NotEnabled;
    public string StateDesc => "本地模式";
    public string ErrorMessage => "";

    public PushClient() { AppState.PushClient = this; }
    public bool IsConnected() => false;
    public void Start() => TryUpdateConnectState();
    public void Stop() => TryUpdateConnectState();
    public void ConnectNow() => TryUpdateConnectState();
    public void TryUpdateConnectState() => StatusChanged?.Invoke(this, new ConnectionStatusChangedEventArgs(State));
    public void NotifyOtherMachineSync() { }
    public void RequestActive() => AppHelper.ShowInformation("当前使用本地工作区，无需选择账号活动设备。");
}