# Quicker Local：本地工作区源码恢复与功能改造

本项目由 Codex 计划与执行

## 项目说明

本项目在旧版 Quicker 1.44.10 的恢复源码上推进本地运行、功能修复与扩展。当前是开发中的源码快照，已有可构建的主 EXE 和 Quicker.Common 工程；其余依赖尚未全部恢复为源码，不能视为完整、自包含、所有功能已通过测试的发行版。

## 本版行为

- 启动使用本地工作区，不通过账号登录加载整套云配置。
- 已有动作、设置和缓存从 `%LOCALAPPDATA%\Quicker` 读取和保存。
- 用户主动从网站导入时，下载动作正文、静态引用的共享子程序和图标，保存本地后使用；不会用云端工作区批量覆盖本地配置。
- 已缓存的同版本正文和图标保留。动作信息窗口只读本地，新导入动作不开启自动更新。
- 用户可以手动检查、选择并下载动作更新；应用和动作的后台自动更新保持移除，软件版本由用户手动下载。

网站导入和手动动作更新默认匿名请求。官方接口返回 401 时，仅该次主动业务请求可以使用用户本机此前正常登录保存的令牌；没有可用权限则明确报错，不恢复软件登录、令牌刷新或云同步。凭据不包含在仓库中。用户动作自身访问网站或自配服务仍属于动作功能。

## 2026-10-04：修复拖入动作模块时的公共编辑器错误

拖入“激活进程主窗口”等模块时，参数窗口报“未将对象引用设置到对象的实例”。日志定位到共用的参数编辑器：恢复源码中的跳转标签把已经创建的说明容器重新置空。这一问题会影响多个模块，不是模块执行时无法找到目标进程。

- `Quicker/View/X/Nodes/InputParamEditorControl.cs`：重写 `bcYLHrp0jV6` 的界面初始化，保留输入控件、说明文字和工具提示的原有功能，确保始终使用已创建的容器。
- `Quicker/View/X/Nodes/StepListControl.cs`：修复步骤右键菜单 `CEgL1CNT5vH` 的同类问题，填充“放入...”子菜单时保留父菜单对象及闭包状态。

上述路径相对 `Quicker主体复现/apps/Quicker/src`。沿用原构建命令成功生成：**0 个错误、5,965 个警告**。未自动运行测试或执行动作；实际拖入、编辑和运行效果仍待使用反馈。完整状态见 [EXE-024 修改记录](<Quicker主体复现/apps/Quicker/exe 从原始到开源的修改过程.md#exe-0242026-10-04修复拖入动作模块时的公共参数编辑器空引用>)。


**后续部署：**2026-10-04 02:17 已按维护者明确授权强制结束本机 Quicker，将本次修正版 EXE 和配套 Common DLL 替换到安装目录，并备份旧文件。没有自动启动软件或执行动作，交互效果尚待实际使用反馈。

## 2026-10-04：剪贴板插件、场景页、手动动作更新与帮助入口

| 文件（相对主 EXE `src`） | 修改内容 |
|---|---|
| `Quicker.csproj` | 使用 Common 工程已有公开密钥保留程序集身份。修复 IntelliTools 剪贴板窗口 BAML 引用带公钥的 Quicker、重建 EXE 却无公钥而触发的 `0x80131044`。这是开发兼容的公开签名，不是原厂私钥签名。 |
| `Quicker/View/Controls/ProfilePageControl.cs` | `RefreshUi` 改为正常的行列循环，修复反编译跳转重置闭包导致的“场景与动作”空引用；清空过期动作和计数提示。 |
| `Quicker/Domain/Services/SharedActionImportService.cs` | 新增手动动作版本查询，只发送共享动作编号；复用下载鉴权策略与既有导入服务，下载后保存本地。 |
| `Quicker/Settings/Pages/Tools/UpdateActionsPage.cs` | 原自动更新按钮改为“检查动作更新”。打开页时不联网，点击才查询；用户选择后下载替换，保留确认和忽略列表，异步完成后在 UI 线程更新列表。 |
| `Quicker/Settings/Pages/About/AboutSettingPage.cs` | 补回主页、动作库、教程、讨论区、问题反馈及原作者微博链接，点击后使用默认浏览器打开。 |
| `mmcmHlAD3xkvwaQf2Ut/krvQ8AAu3nWMBowhIM6.cs` | 入门向导直接打开公开帮助网址，移除该入口对原厂自动登录网址的调用。 |

**翻页用法：**上半区是全局动作页，每页 12 格；下半区是场景动作页。滚轮切换已有页面，不自动创建空白页。若上半区只有一页，先在“场景与动作 → 全局”中新建动作页，再把鼠标移到上半区滚动。没有总动作数或页数的会员配额。

**微信动作适配：**维护者本机的微信传输助手动作增加 Weixin 4 / Qt 窗口识别，并用搜索进入文件传输助手；旧版操作保留，搜索不覆盖剪贴板。原发送开关和热键保持用户设置。该本地动作标记忽略网站更新，防止覆盖本地修改；个人动作正文及备份不上传仓库。未自动执行动作或发送消息，实际交互仍待使用反馈。

构建成功：**0 个错误、5,966 个警告**。用户退出软件后，新 EXE 和配套 Common DLL 已替换到本机安装目录，旧文件已留存。本轮没有自动启动、测试动作或请求网站验证；插件窗口、动作更新接口和各项交互仍需实际使用确认。登录、会员权限、工作区云同步及后台自动更新不恢复。完整细节见 [EXE 修改记录](<Quicker主体复现/apps/Quicker/exe 从原始到开源的修改过程.md>)。

## 2026-10-04：修复动作参数、截图等待和右键菜单崩溃

用户实际运行安装目录里的源码版时，重命名、EVER智识、剪贴板和置顶动作出现类型转换错误，截图 OCR 取图失败，动作右键菜单出现空引用。这些是运行错误，之前的构建成功不能代表动作可用。本次针对日志及对应源码修复以下三处：

| 源码文件（相对 `Quicker主体复现/apps/Quicker/src`） | 修改内容 |
|---|---|
| `Quicker/Domain/Actions/X/XActionHelper.cs` | `GetParamValue` 使用的变量求值闭包将中间值恢复为 `object`，去掉读取变量及执行表达式时的三处强制 `string` 转换。列表、数字、字典和图片按实际类型传递，需要转换时再交给已有的参数类型转换逻辑；子程序输入也使用该公共路径。 |
| `Quicker/Domain/Services/ActionEditMgr.cs` | `CreateContextMenuForActionButton` 的菜单对象及相关局部变量只在方法入口初始化，不在跳转到子菜单填充位置时清空，修复尚未点击“删除”就因构建右键菜单而崩溃的问题。 |
| `Quicker/Domain/Actions/X/BuiltinRunners/Images/CaptureStep.cs` | 选区截图保留第三方截图等待期间的截止时间与 Esc 计数，避免立即超时；内置选区同时检查宽和高，拒绝空区域。 |

按固定构建命令生成成功：**0 个错误、5,963 个警告**。没有增加测试、验证脚本或改动构建方式。维护者随后要求编译后直接替换，已将新 EXE 与配套 Common DLL 写入本机安装目录，并保留旧文件供回退；未自动启动软件或执行动作，也未修改用户动作及本地数据库。实际效果待维护者使用反馈，不能据此宣称上述动作已全部运行通过。

截图 OCR 的旧版运行日志还包含动作自身外部 HTTP 服务拒绝连接的错误；修复取值和截图代码不代表外部服务恢复。用户主动业务联网仍保留，原厂账号、云同步及后台更新不恢复。完整过程见 [EXE-021 修改记录](<Quicker主体复现/apps/Quicker/exe 从原始到开源的修改过程.md#exe-0212026-10-04修复动作参数类型截图等待与右键菜单空引用>)。

## 2026-10-04：移除本地功能的会员分级与数量限制

本版目标是提供完整开放的本地功能：没有会员购买、续费、到期和免费/付费等级之分。本次修改直接删除 EXE 中的限制分支和判断方法，并同步修改 Common；没有把本地账号伪装成原厂付费账号。

| 范围 | 本次变化 |
|---|---|
| 翻页与右上角按钮 | 普通/通用页面翻页、关联动作页、右上角动作编辑、粘贴及拖拽不再受会员限制；循环翻页继续遵循用户设置。 |
| 场景、页面、图标及本地存储 | 删除场景数、每程序页数、图标数及本地状态内容长度配额；兼容模型中的 6 个数量/容量参数统一表示无限额。 |
| 文本指令与快捷键 | 删除文本指令 10 条、扩展热键 10 条、按键规则/监听 1 条等新增、导入和执行限制。 |
| 鼠标、手势与触发器 | 删除自定义鼠标 5 条、手势 8 条、手势子动作/事件触发 2 条等限制；自动运行和左键增强按用户配置使用。 |
| 轮盘 | 删除扩展圈 90 天试用；开放外圈 16 项设置，不再按会员降级。 |
| 编辑与本地备份 | 开放动作历史、版本保存/恢复、子程序导入导出、回收站、自动动作/状态备份；删除状态备份 1 MiB 配额。 |
| 外观与操作入口 | 开放深色主题、高级颜色、托盘样式、皮肤、悬浮按钮/面板、文本悬浮窗、仪表盘、搜索及外部启动的本地功能入口。 |
| 本地执行速度 | 删除针对免费用户的离线 OCR 和找图额外等待；删除已无调用的原厂 OCR 会员限流器。 |
| 会员界面 | 删除购买窗口、到期提醒、定价链接和付费提示；关于页改为本地版信息与项目入口。 |
| 兼容已有动作 | 旧 `IsPro` 输出键保留，但解释为“本地完整功能可用”；旧 `Free` / `MemberLevel` 等兼容模型不再决定 EXE 的本地权限。 |

### 联网业务的处理原则

账号认证、会员权限、原厂工作区云同步、远程权限配置以及自动更新继续移除。用户主动导入网站动作、下载动作正文和依赖资源、访问网站、调用自己配置的网络服务仍属于业务功能，保留已有实现；导入后写入本地，之后读取本地。此次未改动上一版已经恢复的主动网站导入链路，也不做全局断网。

去除会员门槛不等于凭空获得原厂云服务。自配语音服务仍需要服务商配置；原厂表格/公式 OCR、云发布等尚未完成本地替代的部分继续明确报告不可用。用户设置的启停、黑名单、只读动作保护、输入有效性、系统权限及依赖版本兼容检查保留；不会强行启动全部自动运行任务。

### 构建与使用状态

2026-10-04 按原有命令构建成功：**0 个错误、5,963 个警告**。本轮未运行测试、未启动软件、未替换 `C:\Program Files\Quicker`；编译通过不表示全部功能已实际运行通过。使用新版本需要使用同次构建的 `Quicker.exe` 和配套 `Quicker.Common.dll`，仍运行旧安装文件不会体现这些源码修改。固定 `build.cmd` 和工程构建配置未改动，也没有增加构建辅助脚本或验证框架。

### 本次全部源码与资源改动

以下逐项记录本轮涉及的业务源码和资源。删除项说明在右列；文件路径以仓库根目录为起点。

| 文件 | 改动 |
|---|---|
| `Quicker主体复现/apps/Quicker/src/Ci3RULiH5a8Cgg0fIS5/UIy1pYiDsLcf2l4joSP.cs` | 鼠标/手势执行：不再截取前 5 条鼠标规则；删除手势数量及到期检查。 |
| `Quicker主体复现/apps/Quicker/src/EMu6sFoissmin2fOAST/KJ2KZno7dbEJwGDRv9u.cs` | 语音输入：删除会员分支和原厂语音授权回退；自配服务商账号继续使用，缺配置明确报错。 |
| `Quicker主体复现/apps/Quicker/src/HMdjedXPwaug8yh9mEq/brgW8EX9ZVfZExh7q9t.cs` | 快捷键执行：删除 jgJtpIN0xXg 数量检查及超额阻断。 |
| `Quicker主体复现/apps/Quicker/src/Quicker.g.resources` | 移除购买窗口和旧账号关于页 BAML；删除定价链接，清理功能付费提示，备份说明改为本地。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/App.cs` | 启动主题初始化、切换主题：删除会员判断。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/CloudDataStep.cs` | 已本地化的状态存储：删除按版本区分的内容长度配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/GetSysInfoStep.cs` | 旧 IsPro 输出键兼容已有动作，显示名改为“本地完整功能可用”，恒为 true；不表示付费身份。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/Images/ReadQRcodeStep.cs` | 二维码参数说明改为当前本地识别行为，去掉专业版服务宣传。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/Network/OcrStep.cs` | 删除免费用户离线 OCR 完成后额外等待的分支。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/QuickerOperationStep.cs` | 加载外观、悬浮动作、切换悬浮按钮：删除会员拦截与选项中的专业版标记。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/BuiltinRunners/SearchBmpStep.cs` | 删除找图成功后针对免费用户额外 Sleep 的分支。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Actions/X/XActionHelper.cs` | HasProOnlyStep 不再按步骤检查会员模块；保留兼容入口并删除递归权限扫描。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/AppServer.cs` | 加载皮肤及相关动作操作不再检查本地会员/体验账号。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/IconManager.cs` | 图标处理不再因旧体验账号类型跳过。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/PowerKeys/PowerKeysService.cs` | 扩展热键运行阶段不再因规则条数拒绝执行。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Profiles/PanelState.cs` | GetAction 不再用账号固定动作覆盖右上角格子的本地动作。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Profiles/ProfileSwitcher.cs` | GoLeft、GoRight、GlobalGoLeft、GlobalGoRight 删除会员翻页限制与购买提示，保留循环翻页用户设置。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/ActionEditMgr.cs` | 编辑/粘贴右上角按钮、文本悬浮窗、动作快捷键、悬浮按钮、自动本地备份取消会员限制；菜单改称保存本地版本。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/AutoRunService.cs` | Start 不再因非会员直接退出，按用户配置启动自动运行任务。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/DataService.cs` | 删除会员等级/到期、旧账号类型、翻页、锁定按钮、文本规则、热键、皮肤、历史、启动器、轮盘试用及场景/页面配额判断方法；删除到期提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/FloatTriggerButtonHelper.cs` | ShowPanelFloatButton 直接创建面板浮标，删除购买提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/IpcServer.cs` | 外部启动动作及皮肤操作不再以免费版身份拒绝；保持现有业务实现。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/LocalDataStore.cs` | AddIcon 保留去重与保存，删除图标数量配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/LocalWorkspaceInfo.cs` | ToLegacyView 使用 Unrestricted 兼容配置，不再主动设置会员等级。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Domain/Services/SystemEventsWatcher.cs` | 恢复/解锁事件的本地处理不再按会员分级，保留对象存在检查。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Modules/Gestures/Manage/SubActionMangeControl.cs` | 删除手势子动作 2 条规则限制及购买提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Modules/TextTools/TextToolsControl.cs` | 文本工具操作删除专业版判断，继续按实际业务输入执行。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/About/AboutSettingPage.cs` | 用 C# 重写关于页：删除 Email、注册时间、会员等级、到期与购买区域；显示本地版说明、源码入口、组件许可。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Basic/ActionDesignerSettings.cs` | 动作及状态自动备份设置不再按会员禁用。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Basic/AutoRunSettings.cs` | 自动运行设置、规则粘贴删除版本禁用和 2 条限制。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Basic/EventTriggersSettingPage.cs` | 事件触发创建、导入、编辑删除 2 条限制。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Basic/UI/UiColorSettingsControl.cs` | 高级外观设置与背景图操作删除会员判断。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/BasicSettings.cs` | 托盘图标类型不再被强制重置/禁用，删除专业版工具提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Tools/PowerKeysManagementPage.cs` | 扩展热键编辑、新增不再按 10 条配额限制，清理版本提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Tools/TextCommandManagePage.cs` | 文本指令编辑、新增不再按 10 条配额限制，清理版本提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/ActionHotkeysSettingPage.cs` | 动作快捷键设置删除数量和版本拦截。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/CircleMenuSettingPage.cs` | 轮盘扩展圈 16 项选项开放；颜色主题按用户设置保存，不再按会员降回 8 项。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/HotkeyWatchersSettingPage.cs` | 热键监听规则删除 1 条配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/KeyActionsSettingPage.cs` | 按键触发规则删除 1 条配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/LeftButtonPlusSettingPage.cs` | 鼠标左键增强设置不再按版本禁用。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/Triggers/MouseActionManagePage.cs` | 新增和粘贴鼠标规则删除 5 条配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Settings/Pages/UISettingsPage.cs` | 主题切换、深色外观和现有皮肤操作移除会员/体验账号判断。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Utilities/AppHelper.cs` | 删除 ShowVersionLimitInfo、ShowHotkeyLimitInfo、GetMemberLevelName 及打开购买窗口的闭包。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/Utilities/UI/NotifyIconWrapper.cs` | 托盘菜单中的主题切换入口不再只对会员开放。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/BuyQuickerWindow.cs` | 删除会员购买窗口源码，文件送入回收站。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/CircleMenu/CircleMenuWindow.cs` | 轮盘扩展圈删除 90 天试用和会员检查，按轮盘与外观设置运行。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/Controls/ActionButton.cs` | 移除旧体验账号判断；动作更新仍由已移除的更新链路保持关闭。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/Controls/OpenProfileActionParamEditor.cs` | “某程序全部动作页”选项不再仅向会员提供。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/DashboardWindow.cs` | 仪表盘外观初始化不再要求会员。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/EditProfileWindow.cs` | 删除因页面配额为 1 而隐藏页面相关设置的分支。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ExeSettingControls/ExeCircleMenuSettingsControl.cs` | 清理轮盘扩展圈版本提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/FloatButtonWindow.cs` | 悬浮按钮可使用本地皮肤，不再读取会员权限。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/FloatPanelWindow.cs` | 悬浮面板可使用本地皮肤，不再读取会员权限。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/IconSelectorWindow.cs` | 图标操作移除会员购买拦截。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/NewExeSettingsWindow.cs` | 新建场景不再检查场景总数配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/NewProfileWindow.cs` | 新建动作页不再检查每程序页数或会员身份。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/PopupWindow.cs` | 面板新建场景、右上角编辑、拖拽悬浮、搜索、回收站及外观调用删除权限门槛。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/PowerKeys/InstallPowerKeyWindow.cs` | 安装扩展热键不再检查剩余配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ProfileManagement/ActionPagesControl.cs` | 关联页面、编辑右上角按钮删除会员判断。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ProfileManagement/ExeListControl.cs` | 新增应用程序场景删除 10 个配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ProfileManagement/ExeSettingControls/ExeGesturesSettingsControl.cs` | 创建及添加手势删除 8 条轨迹限制。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ProfileManagement/ExeSettingsWindow.cs` | 场景左键增强与动作使用信息操作删除会员拦截。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/SearchWindow.cs` | 搜索结果悬浮动作不再检查会员许可。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ShareActionWindow.cs` | 删除旧体验账号入口判断；未实现的原厂云发布仍明确报错。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/ShareSubProgramWindow.cs` | 删除旧体验账号入口判断；未实现的原厂云发布仍明确报错。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/TextCommands/InstallTextCommandWindow.cs` | 导入文本指令不再检查剩余配额。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/TextFloatPanelWindow.cs` | 文本悬浮面板按本地外观设置运行。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/X/ActionDesignerWindow.cs` | 动作版本保存、历史恢复删除会员检查与购买提示，保留动作类型和正文有效性检查。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/X/Controls/InternalSubProgramListControl.cs` | 子程序定义导入导出删除会员/体验账号限制，保留只读数据保护。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/X/SubProgramEditor.cs` | 子程序导出和历史相关操作删除版本提示。 |
| `Quicker主体复现/apps/Quicker/src/Quicker/View/X/XActionUiHelper.cs` | ExportSubProgram 不再检查会员/体验账号。 |
| `Quicker主体复现/apps/Quicker/src/eGw6fHYzCMTEO3Dvtqx/HohpaZYaB62F359dDI0.cs` | 删除原厂 OCR 遗留的按会员区分频率/日额度限流类，文件送入回收站。 |
| `Quicker主体复现/apps/Quicker/src/jtYKvI2ve9aDjyxS5gf/IIQBbr2FgGR5ONc4nck.cs` | 移除上述已废弃限流器字段、初始化及引用；现有本机 OCR 路径保持使用。 |
| `Quicker主体复现/apps/Quicker/src/mnWqVeozkVAHIg6WJW1/XJZ7kpoan1Uhg3yEL2v.cs` | 状态自动备份删除会员判断及 1 MiB 内容配额；失败信息改为本地保存。 |
| `Quicker主体复现/apps/Quicker/src/wO0UogXeWxgnePQOF3R/we8kb6Xb9dOkNdooDpA.cs` | 文本指令运行阶段删除超额拒绝执行的分支。 |
| `Quicker主体复现/assemblies/Quicker.Common/src/Quicker/Common/Vm/Account/UserLimitation.cs` | 新增 Unrestricted；全部本地功能标记开放、LockButton=false；6 个数量/容量参数为 0（无产品配额），Free 仅为旧接口兼容别名。 |

资源细节：`Quicker.g.resources` 删除 `view/account/buyquickerwindow.baml` 和 `settings/pages/about/aboutsettingpage.baml`。其余修改为轮盘、动作编辑器备份、热键监听、事件触发、场景轮盘、自动运行、功能快捷键、新建场景、鼠标规则、按键规则、新建页面、文本指令、动作快捷键、基础工具及左键增强设置中的定价链接、付费文字或本地备份说明。保留控件连接编号，关于页改用可直接编辑的 C# 界面源码。

文档同步：仓库首页 `README.md`、主 EXE README、Common README 与持续修改记录同步说明本次变化；本机主项目 README 同步说明。项目署名按维护者要求简化为“本项目由 Codex 计划与执行”。

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

最新主 EXE 构建为 **0 个错误、5,963 个警告**。用户已反馈旧安装版的动作执行和右键菜单错误，本次针对已定位原因修复源码，修正版尚未运行；网站导入与此前限制清理也尚未完成全面运行确认。构建成功不表示全部动作或界面正确。静态下载不能补齐动态计算的依赖或用户私有全局子程序；图标获取失败会提示。此前尚未完成的表格/公式 OCR、部分云功能的本地替代等仍未完成。

代码变化记录见 [exe 从原始到开源的修改过程](<Quicker主体复现/apps/Quicker/exe 从原始到开源的修改过程.md>)。

## 免费分享与许可范围

项目自行创作且有权许可的贡献按 [MIT](Quicker主体复现/LICENSE) 开放，允许使用、修改、扩展、复制和再分发，包括商用；本项目计划免费分享。分发 MIT 内容须保留相应版权及许可声明。

从原版恢复的代码、原版资源及第三方内容不因重新编译或此仓库公开而自动转为 MIT；保留各自权利与来源。详见 [NOTICE](Quicker主体复现/NOTICE.md) 与 [开源原则](Quicker主体复现/OPEN_SOURCE.md)。本项目不是原厂官方发行版。
