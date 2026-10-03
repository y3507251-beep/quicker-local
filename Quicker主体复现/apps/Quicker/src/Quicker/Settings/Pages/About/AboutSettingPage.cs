using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Quicker.Common.Entities;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Settings.Pages.About;

public class AboutSettingPage : SettingPage
{
    private readonly TextBlock versionLabel = new TextBlock();

    public override bool ShowSaveButton => false;

    public AboutSettingPage()
    {
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock
        {
            Text = "Quicker Local",
            FontSize = 26,
            FontWeight = FontWeights.Bold,
            Margin = new Thickness(0, 0, 0, 12)
        });
        panel.Children.Add(versionLabel);
        panel.Children.Add(new TextBlock
        {
            Text = "本地版：无账号、无会员、无到期限制。\n动作、设置和资源保存在本机。用户主动导入动作及自配网络服务仍可使用。",
            TextWrapping = TextWrapping.Wrap,
            Margin = new Thickness(0, 16, 0, 16)
        });
        panel.Children.Add(new TextBlock { Text = "本项目由 Codex 计划与执行" });
        var projectButton = new Button
        {
            Content = "项目源码与版本下载",
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(0, 16, 0, 8),
            Padding = new Thickness(12, 5, 12, 5)
        };
        projectButton.Click += (_, _) => AppHelper.TryOpenUrlOrFile("https://github.com/y3507251-beep/quicker-local");
        panel.Children.Add(projectButton);
        var licensesButton = new Button
        {
            Content = "查看组件许可",
            HorizontalAlignment = HorizontalAlignment.Left,
            Padding = new Thickness(12, 5, 12, 5)
        };
        licensesButton.Click += (_, _) => AppHelper.TryOpenUrlOrFile(Path.Combine(NativeMethods.GetAppBasePath(), "ComponentLicenses.txt"));
        panel.Children.Add(licensesButton);
        panel.Children.Add(new TextBlock
        {
            Text = "基于 Quicker 1.44.10 恢复源码修改；原版及第三方组件保留各自版权与许可。详见项目 NOTICE。",
            TextWrapping = TextWrapping.Wrap,
            Margin = new Thickness(0, 16, 0, 0)
        });
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
    }

    protected override void LoadDataToUi(UserSettings settings)
    {
        versionLabel.Text = "版本 " + AppHelper.GetCurrAppShortVersion();
    }

    protected override bool SaveDataFromUi(UserSettings settings) => true;
}
