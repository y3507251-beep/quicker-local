# Quicker Local：本地工作区源码恢复与功能改造

本项目在旧版 Quicker 1.44.10 的恢复源码上推进本地运行、功能修复与扩展。当前是开发中的源码快照，已有可构建的主 EXE 和 Quicker.Common 工程；其余依赖尚未全部恢复为源码，不能视为完整、自包含、所有功能已通过测试的发行版。

## 本版行为

- 启动使用本地工作区，不通过账号登录加载整套云配置。
- 已有动作、设置和缓存从 `%LOCALAPPDATA%\Quicker` 读取和保存。
- 用户主动从网站导入时，下载动作正文、静态引用的共享子程序和图标，保存本地后使用；不会用云端工作区批量覆盖本地配置。
- 已缓存的同版本正文和图标保留。动作信息窗口只读本地，新导入动作不开启自动更新。
- 应用和动作的后台更新保持移除；软件版本由用户手动下载。

网站导入默认匿名请求。官方接口返回 401 时，仅该次主动下载可以使用用户本机此前正常登录保存的令牌；没有可用权限则明确报错，不恢复软件登录、令牌刷新或云同步。凭据不包含在仓库中。用户动作自身访问网站或自配服务仍属于动作功能。

## 主体源码与构建

| 内容 | 源码目录 | 固定构建入口 |
|---|---|---|
| 主 EXE | `Quicker主体复现/apps/Quicker/src` | `Quicker主体复现/apps/Quicker/build.cmd` |
| Common DLL | `Quicker主体复现/assemblies/Quicker.Common/src` | `Quicker主体复现/assemblies/Quicker.Common/build.cmd` |

在 Windows x64 上安装支持 C# 12 的 .NET SDK、.NET Framework 4.7.2 开发工具包及工程引用的 Windows SDK 10.0.22621.0。构建入口仅调用 `dotnet build`，不附带测试或修改后需要同步维护的源码清单。

此快照不附带原版安装程序、其它依赖 DLL 或构建产物。现有工程仍需要本机自行准备并有权使用的依赖：

1. 在仓库根目录建立 `Quicker` 文件夹，按 `Quicker.csproj` 的 `Reference/HintPath` 和 `Content` 项准备兼容 1.44.10 的运行依赖，包括 SQLite 原生库和 ChromeAgent 配套文件。
2. 将 Common 所需的 `Newtonsoft.Json.dll`、`Quicker.Public.dll` 分别放入 `Quicker主体复现/assemblies/Newtonsoft.Json/original`、`Quicker主体复现/assemblies/Quicker.Public/original`。
3. 双击对应 `build.cmd`。主 EXE 输出到 `Quicker主体复现/apps/Quicker/artifacts/bin/Release/net472/Quicker.exe`。

目录名 `original` 是现有工程的依赖路径约定，不表示仓库已附带这些文件。第三方组件的获取和再分发遵循其自身许可。

## 当前边界

本次主 EXE 构建为 **0 个错误、5,954 个警告**。此次网站导入修改尚未实际运行验证；构建成功不表示全部动作或界面正确。静态下载不能补齐动态计算的依赖或用户私有全局子程序；图标获取失败会提示。此前尚未完成的表格/公式 OCR、部分云功能的本地替代等仍未完成。

代码变化记录见 [exe 从原始到开源的修改过程](<Quicker主体复现/apps/Quicker/exe 从原始到开源的修改过程.md>)。

## 免费分享与许可范围

项目自行创作且有权许可的贡献按 [MIT](Quicker主体复现/LICENSE) 开放，允许使用、修改、扩展、复制和再分发，包括商用；本项目计划免费分享。分发 MIT 内容须保留相应版权及许可声明。

从原版恢复的代码、原版资源及第三方内容不因重新编译或此仓库公开而自动转为 MIT；保留各自权利与来源。详见 [NOTICE](Quicker主体复现/NOTICE.md) 与 [开源原则](Quicker主体复现/OPEN_SOURCE.md)。本项目不是原厂官方发行版。
