# exe 从原始到开源的修改过程

这份文档持续记录 Quicker 主 EXE 从原版反编译、运行时恢复、修复构建，到后续免费开源版本改造的过程。每次实际修改都要留下原因、位置、修改前后行为和完成状态，供用户与后续接手的助手查阅。

**后续修改前先读本文，修改后在同一轮追加记录。不能只依赖聊天记忆，也不能把计划写成已经完成。** 此要求已写入项目根目录 [AGENTS.md](../../../AGENTS.md)。

## 1. 当前状态与边界

以下为 2026-10-03 建立本文时的状态；后续以最新追加的记录为准。

| 项目 | 已知状态 |
|---|---|
| 原版基线 | Quicker `1.44.10.0`，x64 |
| 方法体恢复 | 从加载后解密的方法缓存恢复了 45,421 个 IL 方法体 |
| 工作源码 | 已导出 C# 并修复到能够编译生成 EXE；仍有混淆名称、编译器生成的状态机等结构 |
| 首轮构建 | .NET Framework 4.7.2 / x64；最后一次已记录构建为 0 个错误、6,001 个警告 |
| 运行状态 | 本次恢复出的 EXE 尚未运行或替换测试；全部功能与原版的一致性尚未确认 |
| 免登录、本地化 | 尚未完成 |
| 原厂同步、权限请求、版本检查与更新 | 尚未完成移除或本地替代 |
| 界面资源 | 当前继续嵌入恢复出的 `.resources` / BAML；不代表全部界面已经恢复成可编辑的 XAML |
| 依赖 | 仍引用工作副本中的原版依赖 DLL；不是所有 DLL 均已恢复并接入 |
| 发布 | 尚未制作完成可发布的独立软件包，尚未发布 GitHub 开源版本 |

“恢复了方法体”“能够编译”“实际运行正常”“完成本地化”“可以发布”是不同状态，每条修改记录必须按实际情况填写。早前用户对“原 EXE + 恢复版 Common DLL”的使用反馈，不能当作当前恢复版 EXE 的运行结果。

本项目遵循主项目已声明的免费开源与自由修改原则：本项目自行创作及有权授权的代码采用 MIT，允许使用、修改、扩展和再分发；原版恢复内容和第三方依赖保留原有权利与许可范围。参见 [LICENSE](../../LICENSE)、[OPEN_SOURCE.md](../../OPEN_SOURCE.md)、[NOTICE.md](../../NOTICE.md)。

## 2. 源码、构建与留档位置

本 EXE 项目目录：`D:\ProjectsPycharm\MultiProjects\quicker\Quicker主体复现\apps\Quicker`。

| 路径 | 用途 |
|---|---|
| [src/](src/) | 日常修改的主体源码、资源和工程 |
| [src/Quicker/App.cs](src/Quicker/App.cs) | 程序入口及启动相关实现 |
| [src/Quicker.csproj](src/Quicker.csproj) | SDK 工程、目标框架及依赖配置 |
| [build.cmd](build.cmd) | 固定构建入口，只调用构建工具并保留窗口 |
| [artifacts/bin/Release/net472/Quicker.exe](artifacts/bin/Release/net472/Quicker.exe) | 当前工程生成的 EXE；运行还需要相应依赖和资源 |
| [artifacts/build.log](artifacts/build.log) | 已执行构建的日志，后续构建可能覆盖它；本文保留当次实际结论 |
| `artifacts/recovery/` | 首轮运行时恢复与去混淆的中间产物，保留作来源参考 |
| `D:\ProjectsPycharm\MultiProjects\quicker\Quicker\` | 本轮读取的原版工作副本及当前依赖来源 |

`Quicker原始备份` 不访问、不修改；HAPP 的构建方式不变。本文记录本 EXE 的变化，Common 等 DLL 的变化只有实际涉及 EXE 引用或行为时才在此说明，不能混记成 EXE 已完成的功能。

日常操作：修改 `src` → 双击 `build.cmd` → 追加本次修改记录。新增 `.cs` 使用 SDK 默认包含规则，不登记源码文件清单。不因业务源码修改而改写构建脚本，不自动运行测试、验证、接口对比、哈希比较或替换测试。

## 3. 每次怎样记录

1. 开始前阅读当前状态、最新记录和相关历史条目，确认这次工作的起点。
2. 每次有实际修改，就在本文末尾追加一个递增编号的条目；同一目的的一批修改可记为一条。
3. 列出本次全部涉及的源码、资源、工程或依赖配置文件，并写清关键方法或配置项。小改只需写“文件 / 方法：旧行为或旧值 → 新行为或新值”，不用粘贴整份源码。
4. 区分原始逻辑恢复、编译兼容修复、功能改造和仅文档修改。根据原始 IL 恢复的内容与自行推导或新写的内容分别说明；推导尚未确认的部分明确标注。
5. 只填写实际做过的构建、运行和用户反馈。没运行就写“未运行”，没构建就写“未构建”；写记录本身不触发任何额外检查。
6. 影响数据格式、存储路径、依赖、启动流程或功能行为的，说明影响与遗留事项。临时方案要标明，避免后续误以为已完成。
7. 修正或回退既有改动时，追加条目并引用原编号；保留旧记录。发现历史记录有误，追加更正原因。
8. 如果用户手动修改了源码，后续读到时能确认什么就记录什么；无法确认的旧值、原因和日期不编造。

只维护这份持续记录；不为记录新增脚本、文档生成器、映射清单或验证框架，不重复统计文件数。若某次有 Git 提交，可附真实提交号；没有提交时无需生成或编造编号之外的标识。

## 4. 首轮恢复历史补录

以下 EXE-001 至 EXE-005 于 2026-10-03 根据本次会话和现存工程补录。早期没有逐次留下独立修改日志，因此这里记录已知阶段、实际改动类别与关键文件，不冒充完整的逐行差异或逐次提交历史。从 EXE-006 起按本文约定持续追加。

### EXE-001｜运行时恢复受保护的方法体

- **原因：**直接静态反编译受保护 EXE 时出现空壳或不完整方法体，需要恢复实际运行逻辑。
- **实际操作：**在独立的 .NET Framework 宿主中加载工作副本，调用保护初始化方法 `yRXWpuh65Sx1ogxZDUl.hSyLc5hfTVew2vLP28M.bvG29OXc6EI`，读取其 `L8l2hndofpl` 方法缓存；未通过正常应用入口登录或启动主程序。
- **恢复内容：**取得 45,422 条缓存记录，其中键为 0 的一条不是实际方法；把其余 45,421 个 IL 方法体连同需要的局部变量、堆栈和异常处理信息恢复到程序集，并处理不可达的无效指令。
- **使用工具：**本机 ILSpy、dnlib、de4dot 与 .NET 工具；恢复产物中含有前期尝试文件，不应把每一个中间 EXE 都当作最终结果。
- **主要产物：**`artifacts/recovery/runtime-methods.bin`、`Quicker.runtime-image.exe`、`Quicker.restored-il.exe`。
- **边界：**本次提取的是加载后解密的方法缓存，不是导出用户进程的全部内存。没有修改原版工作副本、原始备份、安装目录或用户账号数据库。方法体恢复数量不代表行为已经完全确认。

### EXE-002｜导出 C# 并建立固定构建工程

- **原因：**需要把恢复出的实现放入可编辑、可直接构建的源码工程。
- **源码与产物：**最终选用 `artifacts/recovery/Quicker.source-normalized.exe` 导出 `src/`；保留 `Quicker.source-input.exe`、`Quicker.proxy-cleaned.exe`、`Quicker.csharp-ready.exe` 等过程文件。
- **恢复处理：**解除已展开方法对保护初始化的依赖，移除已确认的空辅助调用，整理代理调用和混淆元数据；没有把业务方法批量替换为返回默认值的空实现。
- **反编译形式：**为避免反编译器在部分异步方法上失败，保留异步及迭代器状态机形式；因此源码中可见 `_003C...` 等编译器生成名称。
- **工程变更：**建立 `src/Quicker.csproj`，目标 `net472`、x64，启用 WPF、Windows Forms、C# 12 和 unsafe；使用默认 C# 源码包含规则。移除重复的程序集生成设置和不适用的显式资源项，保持输出在本 EXE 自己的 `artifacts` 目录。
- **资源与依赖：**从原程序集恢复 `.resources` 并以原逻辑名称嵌入，嵌入 `Quicker.Assets.scripts.pick.js`，复制配置为 `src/app.config`；当前依赖通过 `HintPath` 指向工作副本，Windows Runtime 类型引用本机 Windows SDK 的 `Windows.winmd`。按编译需要补齐依赖引用，去除与联合 WinMD 重复的单独契约引用。
- **构建入口：**新增固定 `build.cmd`，执行 `dotnet build "%~dp0src\Quicker.csproj" -c Release --nologo`。日常构建不再需要运行恢复工具。
- **整理：**失败导出留下的空 `Quicker.restored-il.csproj` 已送入回收站，未永久删除。
- **遗留：**工程仍使用原版依赖和部分编译后的界面资源；尚未切换为完全独立的开源发布结构。

### EXE-003｜把恢复结果修复为合法、可构建的 C#

**目的：**处理反编译与去混淆产生的语法、类型和控制流表达问题。以下是实际做过的恢复修复，不代表新增了免登录或离线功能。跨文件批量修复发生在建立本文之前，下面保留已知类别及关键位置。

| 涉及源码或范围 | 修改前 → 修改后 / 依据 |
|---|---|
| `src/` 中涉及混淆跳转的多处方法 | C# 不能确认局部变量已赋值 → 将相关局部变量声明移到所在代码块开头并初始化，原赋值仍留在原位置，用 C# 表达原 IL 的局部变量初始化和跳转 |
| 多处嵌套辅助类型、COM 接口和回调 | 类型可访问性不匹配、参数类型被去混淆工具过度收窄、可选参数属性不合法 → 修复访问级别，按原 IL 签名恢复相关回调参数，调整 COM 参数属性 |
| 多处 WinRT 调用 | 显式调用底层事件访问器、属性访问器 → 用 C# 的 `+=`、`-=`、属性读取与赋值表达同一调用 |
| 多处反编译语法 | 无效的 `base._002Ector()`、重复形参名、异常对象表达式、目标框架不适用的倒数索引 → 转为合法 C# 的构造、形参、异常和索引写法 |
| `src/Properties/AssemblyInfo.cs` | 显式 `RefSafetyRules` 与编译器生成内容重复 → 移除重复项 |
| `src/Quicker/Modules/Searching/Builtin/WebSearchEngine.cs` | `TaskNotifier` 的接口实现未被正确还原 → 根据实际后备字段补回显式接口实现 |
| `src/Linearstar/Windows/RawInput/Native/RawHid.cs`、`Native/User32.cs`、`RawInputData.cs` | 不合法的数组固定写法 → 固定字节指针，保留缓冲区与原操作 |
| `src/Cronos/CronExpression.cs` | 不合法的字符串固定/偏移表达式 → 使用固定的 `char*` 指针 |
| `src/DFK6LN7Z1wFZUIPV1pL/dq4x8l7K0ljN23sem9d.cs` | 索引器参数名不一致、直接读取事件不合法 → 统一参数名，通过实际后备字段触发事件 |
| `src/Quicker/Utilities/Images/ImageConverter.cs` 及 `MouseInputStep.cs`、`SearchBmpStep.cs` 调用处 | `ToBitmap` 参数被错误收窄为 `Bitmap` → 按原始签名恢复为 `object`，保留各图像类型分支，并移除调用方多余的前置强制转换 |
| `src/Jitbit/Utils/CsvExport.cs` | CSV 值参数被错误收窄为 `INullable` → 按原始签名恢复为 `object`，保留数据库空值判断，移除调用方多余的转换 |
| `src/Quicker/Domain/Actions/X/Variables/VariableHelper.cs` | 不合法的 `is long?`、`is double?` 模式 → 使用装箱后实际的 `long`、`double` 模式并读取数值 |
| `src/Quicker/Domain/Actions/X/BuiltinRunners/WriteClipboardStep.cs` | `Clipboard` 类型名称歧义 → 明确使用 WinRT 剪贴板的 `ClearHistory` |
| `src/Quicker/Settings/Pages/Triggers/TextCommand/TextCommandBatchEditWindow.cs` | 可空按键枚举直接赋给可空整数 → 补显式转换 |
| `src/-PrivateImplementationDetails-.cs` | 字符串分支使用的 `ComputeStringHash` 缺失 → 根据恢复出的 IL 补齐原哈希算法，保留空值结果、初值和乘数 |
| `src/HRsUaFqi0vlCpe3W5OE/yoSTsVq770v3KF5xolx.cs` | 混淆分支使 `out int_5` 的赋值无法被编译器确认 → 将原有小时计算提前赋值 |
| `src/SnipInsight/ImageCapture/ImageCaptureWindow.cs` 的 `ws1glYVwRP` | 混淆分支使两个 DPI 比例输出无法确认赋值 → 将原有显示器及 DPI 比例计算移到分支之前 |
| `src/gfyhcHXZ8WFEUmvG2Br/ya0BpxXRTmRGWC3aRjP.cs` | `goto` 跨越 `using` 声明作用域 → 改为传统 `using (...) { ... }`，保留资源释放 |
| `src/Qiniu/Storage/ResumableUploader.cs` | 异常日志循环含 C# 不可跳转到的标签 → 改为逐个遍历 `InnerException` 并追加消息的循环；后面的错误处理保留 |
| `src/ExCR1awPdHblsSJeByB/a1eYQTw9GUIJbjdDTW5.cs`、`src/Quicker/Utilities/AppHelper.cs`、`src/u8oQ2EwZU09ckNFKKpC/dRyrhtwRWUqEAEUvLhs.cs` | 蓝牙、通知、网络状态相关的 WinRT 底层访问器 → 普通 C# 属性和事件语法 |
| `src/Quicker/Domain/Actions/X/BuiltinRunners/Office/ExcelRangeOperationStep.cs` | 嵌入的 COM 类型不能正确表达部分带参数属性 → 使用动态 COM 属性访问保留传入参数；Excel 运行行为尚未确认 |

这些改动已参与成功构建，但尚未逐项确认运行行为。不得因编译通过就将上述修复全部标记为“功能已验证”。

### EXE-004｜修复依赖原程序集编号的类型引用并生成 EXE

- **原因：**原混淆代码用固定元数据编号取得类型；重新编译或中间处理会改变编号，可能使代码编译通过但运行时找到错误类型。
- **修改范围：**`src/` 下 39 个涉及此类引用的文件，包括 `Quicker/App.cs`、`Quicker/View/Controls/RadialMenuItem.cs`、`Quicker/Domain/Actions/X/BuiltinRunners/Office/ExcelRangeOperationStep.cs` 等。
- **最终修改：**依据原版工作副本 EXE 的类型表，将 `UaEyQyhUMYjm0XLhW1O.rrGSnsWNy2FhW(编号)` 等调用改为普通 `typeof(...)` 或 `.TypeHandle` 引用。
- **过程中的纠正：**曾使用中间程序集重排后的类型表，导致部分类型解析错误；随后按原版类型表重新恢复。后续处理原编号时必须使用对应的原始类型表。
- **实际构建：**`dotnet build src/Quicker.csproj -c Release --nologo -v:q` 成功，日志记录 0 个错误、6,001 个警告；输出 `artifacts/bin/Release/net472/Quicker.exe`。
- **运行情况：**未启动新生成的 EXE，未替换工作副本或安装目录，未运行测试。
- **完成范围：**取得一套能够编译生成 EXE 的源码工程；没有据此认定所有功能已完整恢复。

### EXE-005｜说明编译警告与实际完成范围

- **原因：**用户询问 6,001 个警告是否表示完全没有问题、软件是否全部完成。
- **实际操作：**读取现存构建日志及部分相关源码，没有修改业务代码，没有重新运行程序或新增测试。
- **已知警告：**主要包含字段未赋值、空 `switch`、不可达代码、未使用变量/字段、过时接口；另有可能影响逻辑的引用比较和 `Equals` / `GetHashCode` 一致性警告。仅检查了部分样例，未逐条判定无害。
- **具体待处理点：**`src/Quicker/View/ProfileManagement/ExeSettingControls/ExeGesturesSettingsControl.cs` 的 `cFhLJwQPdtE` 中，`MenuItem.Tag == "EDIT_ACTION"` 使用对象引用比较；`src/Quicker/View/Hotkeys/Hotkey.cs` 重写了 `Equals` 而没有重写 `GetHashCode`。两处目前均未在本次警告说明中修改。
- **结论：**编译通过已确认；完整性、运行行为与发布可用性尚未确认。警告数量是当次构建快照，不要求每次小改重新统计或维护警告清单。

## 5. 开源版本的后续实现目标

以下均为要求或待办，不能作为已经修改代码的记录。落地时必须在末尾追加对应条目。

- [ ] 启动直接进入本地使用流程，移除对原厂登录和账号的依赖。
- [ ] 动作页、动作、图标、设置、触发器、偏好及全局子程序完整接入本地读写。
- [ ] 原厂云同步、远程权限和远程配置逐项替换为本地实现；依赖服务端的功能有明确本地替代。
- [ ] 迁移、恢复与分享通过本地导入、导出及备份完成。
- [ ] 移除软件和动作的联网版本检查、自动更新、提示、下载及强制更新；用户主动到 GitHub Releases 更新，不轮询 GitHub API。
- [ ] 保留用户动作主动访问网站或用户配置服务的能力；不通过全局断网实现本地化。
- [ ] 按实际需求逐项处理恢复遗留问题、依赖接入和资源源码化，记录新增功能与行为变化。
- [ ] 由用户明确要求运行或测试时执行，并记录实际结果；满足发布条件后再制作和发布软件包。

## 6. 持续追加记录

### EXE-006｜2026-10-03｜建立持续修改记录

- **原因：**用户要求把主 EXE 从反编译原始代码到开源版本的修改全过程持续记录，并指定本文名称。
- **本次文件：**
  - 新增本文件 `exe 从原始到开源的修改过程.md`：补录已知恢复步骤，明确当前边界、后续目标与追加格式。
  - 更新本目录 `README.md`：加入修改记录入口、源码/构建位置，并更正“尚无可构建工程”的旧状态。
  - 更新 `../../README.md`：链接本记录，更正主 EXE 进度，明确持续记录是用户要求的日常文档例外。
  - 更新项目根目录 `../../../AGENTS.md`：要求后续修改 EXE 前阅读本文、修改后当轮追加，并更正主 EXE 构建状态。
- **行为变化：**后续工作的记录规则发生变化；本次没有修改 EXE / DLL 源码、工程、资源或构建脚本。
- **构建与运行：**本次为文档修改，未重新构建、未运行程序、未测试。
- **遗留：**首轮构建警告、运行完整性及第 5 节的开源版本改造仍待处理。

后续条目从 **EXE-007** 开始，追加到本文末尾，沿用以下格式；小改可合并为几行，重要信息不得省略。

```markdown
### EXE-007｜YYYY-MM-DD｜本次修改标题

- 原因 / 目标：为什么改。
- 文件与关键位置：逐个列出本次涉及文件、方法或配置项。
- 实际改动：修改前 → 修改后；恢复原逻辑还是新写实现，依据是什么。
- 构建与运行：只填写实际执行及结果；未构建 / 未运行 / 未测试须如实写明。
- 影响与遗留：已完成范围、数据或依赖影响、仍未完成的部分；有回退时关联旧编号。
```

### EXE-007｜2026-10-03｜第一批本地化：启动、核心数据保存、推送与更新入口

- **目标：**按用户批准的步骤接通本地启动和常用保存入口，沿用 SQLite 数据格式；不延长演示账号期限，不伪造登录成功或会员有效期。
- **全部涉及文件与关键修改（路径相对本目录）：**
  - `src/Quicker/Domain/Services/AppPathProvider.cs`：新增 `LocalDataRoot`，工作区改为 `%LOCALAPPDATA%\QuickerOpenSource`。
  - `src/Quicker/Domain/Services/LocalWorkspaceInfo.cs`（新增业务源码）：保存本地 ID、显示名、创建时间和初始化标记；`ToLegacyView` 仅兼容旧界面结构，不生成 Token 或服务器身份。
  - `src/Quicker/Domain/Services/SQLDataMgr.cs`：`PrepareDb` 不再自动删除异常数据库；新增 `LoadLocalWorkspace`；`jiDtra7gJVt` 不再要求账号记录或非空动作页。动作页、通用对象、删除标记和点击统计写入后不排队上传；本地对象标记 `LocalOnly`；读取排除已删除记录；`OmgtxzBlvOK` 最终写入失败时抛出错误；`GetPendingSyncItemCount` 不再查询云同步队列。
  - `src/Quicker/Domain/Services/DataService.cs`：重写 `pNct6b5ah9E`，直接加载本地动作页、程序设置、用户设置、手势、鼠标动作、文本指令、扩展热键、偏好、收藏块、全局子程序、悬浮文本状态及动作装饰。首次创建工作区时建立空白全局页和通用页。`xHZt6K2LJ8p`、`hC1t6xmuLdZ` 先写数据库再更新缓存；`ydot6rVZAkW` 直接提交本地设置；`xdNt6mQNakh` 不再安排上传；`CbQt6821R73` 改为本地保存。文本指令、动作黑名单和配置改读本地；取消动作版本抓取和更新提示。网络恢复只重启用户配置的相关触发器，不触发云同步。
  - 同一 `DataService.cs` 中，`ryktm9SXvqd` 直接读取 `UserLimitation.Free`；按钮锁定、悬浮按钮、动作快捷键、动作历史、启动器、每程序页数和程序数量的相关判断改用本地配置。去掉相关判断里的云账号优先覆盖和原写死的程序数量限制。**其它分散的会员判断仍未全部改造。**
  - `src/Quicker/Domain/Services/LocalDataStore.cs`（新增业务源码）：实现文本指令增删改、分组与批量编辑、图标库、程序信息、动作备注和备份的本地读写。PNG 图标存为内容字符串，SVG 复制到工作区 `icons`；备份返回实际本地记录。
  - `src/IgQBbvXMVdsN7GVNUxX/aFIptTXYsUoTUF4v33R.cs`：图标、程序信息、文本指令、备注、备份接口改接 `LocalDataStore`；动作页保存/删除、设置保存、统计和黑名单改接本地数据库。登录、注册、同步、远程覆盖以及软件/动作版本检查入口返回明确的本地版说明，不执行这些请求。移除这些被替换方法的原网络状态机。**该文件中的其它云接口仍有遗留，不代表整个 API 文件已完成本地化。**
  - `src/Quicker/Utilities/AppHelper.cs`：`GetUserDataDir`、`GetUserDataDirWithoutCheck`、`IsDataFolderExists` 统一指向独立目录；注销删除另见 EXE-008。
  - `src/Quicker/Domain/AppServer.cs`：`UpdatePushConnection` 停止原厂推送；`NotifyOtherMachineSync` 不再通知其它账号设备。本机面板协调和 IPC 保留。
  - `src/Quicker/Domain/Push/PushClient.cs`：移除原厂 WebSocket 地址、认证、连接、心跳、设备消息、重连实现；只保留旧界面读取本地模式状态所需的适配，不宣称远程连接成功。
  - `src/Quicker/Domain/UsageCounter.cs`：`s4xt8Us8O49` 改为本地保存；`loDt8lkCi0B`、`rP3t83dAmG2` 不再上传以前会话；删除旧上传状态机。
  - `src/Quicker/Modules/VersionUpdate/SoftVersionHelper.cs`：首次同步后的软件版本检查取消；更新窗口入口只说明到项目 GitHub Releases 手动下载安装，不轮询 GitHub API。
  - `src/Quicker/View/PopupWindow.cs`：用户中心改为本地数据目录入口；同步菜单和按钮改为本地保存；更新菜单显示手动更新说明；移除启动时原写死的免费版数量警告。注销菜单删除另见 EXE-008。
  - `src/Quicker.csproj`：Common 从原 DLL 引用改为 `ProjectReference`，直接编译用户修改的 Common 源码；加入 SQLite x64、WebView2、Everything、AutoIt 和日志配置的固定运行依赖复制。未更改 `build.cmd`，没有新增源码清单或辅助验证脚本。
- **数据与权限影响：**本次没有读取、迁移、覆盖或清空原厂账号数据库。新目录首次启动为空白工作区。Common 的用户配置值没有被改动，`MaxPagePerExe = 2` 通过项目引用参与 EXE 构建，相关翻页判断不再取远程账号值。用户动作的网络访问能力仍保留。
- **构建与运行：**只执行工程的 `dotnet build ... -c Release --nologo -v:q`。过程中修正可空时间参数、只读集合赋值和注销删除后的一处混淆跳转。最终构建成功：**0 个错误、5,981 个警告**，输出 `artifacts/bin/Release/net472/Quicker.exe`。没有运行程序、测试或验证脚本，没有替换 `C:\Program Files\Quicker`，没有制作发布包。
- **遗留：**第一批改造不等于完整离线版。共享动作/子程序的远程获取与发布、皮肤和表达式库、云数据动作、原厂 OCR/语音等其它接口及界面仍需逐项替换；完整工作区导入导出、旧数据迁移、分散的账号/会员/更新界面、其它程序集本地化和整包发布仍未完成。已有动作文件导入导出保留，但不能当作完整工作区备份。运行行为及兼容性尚未确认。

### EXE-008｜2026-10-03｜删除退出账号功能及注销清库链路

- **目标：**用户明确要求免账号版本直接删除退出账号代码，不保留同名空方法或把原注销入口改成普通退出。
- **全部涉及文件：**
  - `src/Quicker/Utilities/AppHelper.cs`：删除 `QuitAndExit`。
  - `src/Quicker/Domain/Services/DataService.cs`：删除 `Mxtt656xWDf`、账号设备锁定回调 `HhnvjXoT0fM`、远程停用判断 `Wgnt69SPqeu` 及对应调用分支。
  - `src/Quicker/Domain/Services/SQLDataMgr.cs`：删除直接删除数据库的 `saitxOW7458`。
  - `src/Quicker/Domain/AppState.cs`：删除注销字段 `NvWtRCXIx93` 和访问器 `XgStazVUOF5`、`pZat7wc5vpc`。
  - `src/Quicker/View/PopupWindow.cs`：删除 `MenuQuitAndExit` 字段、`DFogoYjWyJP` 事件、可见性赋值、组件连接分支及对应跳转。
  - `src/Quicker/View/Account/MachineLockWindow.cs`：整个源码文件送入 Windows 回收站，未永久删除。
  - `src/Quicker.g.resources`：用本机 ILSpy 的 BAML 读写器，实际移除 `view/main/popupwindow.baml` 中“从此电脑退出登录”菜单元素，并移除 `view/account/machinelockwindow.baml` 资源。不是运行时隐藏菜单；其它连接编号保留；没有新增资源生成脚本。
- **修改前后：**原来可注销并清除本地数据库；现在没有注销菜单、注销事件或注销清库方法。普通“退出软件”和 `ExitApplication` 保留。
- **构建与运行：**与 EXE-007 同批最终构建成功，0 个错误；未启动、未替换测试。
- **遗留：**其它旧账号界面和未本地化的云功能仍按 EXE-007 所列继续处理，不能把注销删除视作全软件离线完成。

### EXE-009｜2026-10-03｜按用户要求替换安装目录，交由用户测试

- **授权与目标：**用户明确要求把本次构建好的 EXE 替换到当前使用的安装目录，由用户自行测试。
- **实际替换文件：**将 `artifacts/bin/Release/net472/Quicker.exe` 和同目录配套的 `Quicker.Common.dll` 复制到 `C:\Program Files\Quicker`，覆盖这两个同名文件。Common 与本次 EXE 的源码工程引用配套，不能继续混用安装目录旧版本。
- **回退副本：**替换前将安装目录当时的两个文件保存到 `artifacts/replacement-backups/20261003-before-local-exe-6e446cf0/`。未访问或修改 `Quicker原始备份`，未修改原厂账号数据。
- **实际过程：**替换前没有 Quicker 进程运行。普通权限写入被 Windows 拒绝，随后通过 Windows UAC 启动管理员权限的复制操作；复制进程返回成功，结果保存在该回退目录的 `replacement-result.json`。未更改权限或安全设置。
- **构建与测试：**本轮没有重新构建、修改业务源码、运行测试、比对哈希或启动软件；仅替换已有构建产物，等待用户实际运行反馈。
- **使用边界：**新版使用独立目录 `%LOCALAPPDATA%\QuickerOpenSource`，不会自动导入原账号动作。首次运行可能显示空白工作区；完整离线改造仍有 EXE-007 所列遗留项。

### EXE-010｜2026-10-03｜修正 UIAccess 启动声明并再次替换 EXE

- **触发：**用户从任务栏快捷方式和安装目录直接启动时，Windows 均提示“从服务器返回了一个参照”。快捷方式实际指向 `C:\Program Files\Quicker\Quicker.exe`，未附加参数。读取发现重建 EXE 没有 Authenticode 签名，而源码清单保留了 `uiAccess="true"`；该配置要求程序具备签名，见 [Microsoft UIAccess 要求](https://learn.microsoft.com/en-us/windows/win32/winauto/uiauto-securityoverview)。
- **涉及文件与修改：**
  - `src/app.manifest`：将有效的启动声明改为 `level="asInvoker" uiAccess="false"`，按调用者权限正常启动；不更改 Windows 安全策略、证书信任或快捷方式。
  - `src/Quicker/Domain/Services/SQLDataMgr.cs`：本次构建发现当前文件缺少 `LoadLocalWorkspace`，且仍为旧账号加载分支，与 EXE-007/008 记录不一致；原因未查明。恢复已授权的本地工作区方法及 `jiDtra7gJVt` 免账号加载、空工作区成功返回；恢复 `PrepareDb` 保留异常文件、`OmgtxzBlvOK` 失败抛出、本地提交不排队上传、通用对象本地标记、排除已删除对象、无待同步队列等改动；再次移除旧注销清库方法 `saitxOW7458`。没有整文件回退或重新反编译。
- **构建：**首次构建因缺失工作区方法报 1 个错误；修复后现有构建命令成功，0 个错误、5,981 个警告。未修改构建脚本或新增验证代码。
- **安装替换：**通过 Windows UAC 复制本次生成的 `artifacts/bin/Release/net472/Quicker.exe` 到 `C:\Program Files\Quicker\Quicker.exe`，复制操作返回成功。本次只替换 EXE，保留上次已部署的 Common DLL。
- **回退文件：**替换前的 EXE 保存在 `artifacts/replacement-backups/20261003-before-uiaccess-fix-583e5c67/Quicker.exe`；同目录 `replacement-result.json` 记录复制结果。
- **运行与限制：**本轮未代用户启动或运行测试，等待用户再次启动反馈。普通权限进程操作管理员权限窗口仍受 Windows 权限限制，需要时由用户以管理员身份运行。此处只修正已发现的启动配置和构建接口问题，不表示其它功能已确认可用。

### EXE-011｜2026-10-03｜修正界面资源中的原程序集身份引用，记录早期启动异常

- **触发与依据：**用户反馈安装目录 EXE 点击后没有反应。读取本机 Application 事件日志，发现用户启动时在 `App.InitializeComponent` 加载 BAML 资源阶段发生 `FileLoadException`，外层为 `XamlParseException`，进程随即退出。该日志未给出具体程序集名称；进一步读取 `app.baml` 和重建 EXE 的元数据，发现资源要求 `Quicker, Version=1.44.10.0, Culture=neutral, PublicKeyToken=93dcfca1bd14948b`，而当前 EXE 的 `PublicKeyToken=null`。本次针对这一实际存在的身份不匹配修复，运行结果仍须实际启动确认。
- **全部涉及文件与关键修改：**
  - `src/Quicker.g.resources`：通过现有本机 ILSpy BAML 读写器，将 308 个 BAML 资源中指向主程序集的 `AssemblyInfo` 从原签名完整身份改成简单名称 `Quicker`，使界面解析引用当前主 EXE；未修改其它程序集的引用，保留 EXE-008 已删除注销菜单的结果。属于一次性资源修正，未添加生成器或修改构建脚本。
  - `src/Quicker/App.cs`：`Main` 包围创建应用、`InitializeComponent` 和 `Run` 的异常处理，遇到未处理异常时，把完整异常链追加到 `%LOCALAPPDATA%\QuickerOpenSource\logs\startup-error.log`，并显示错误消息与日志位置；写日志失败时直接提示写入原因，不再无提示地退出。进程以失败退出码结束，不掩盖异常。
  - 本修改记录：追加 EXE-011，记录本次诊断、修复和部署范围。
- **构建与安装替换：**现有 `dotnet build` 构建成功，0 个错误、5,981 个警告；仅将新 EXE 通过 Windows UAC 复制到 `C:\Program Files\Quicker\Quicker.exe`，复制结果为成功。配套 Common DLL 保持 EXE-009 的已部署版本。
- **回退副本：**替换前 EXE 保存于 `artifacts/replacement-backups/20261003-before-baml-fix-4926288c/Quicker.exe`，同目录 `replacement-result.json` 保存复制结果。
- **运行与边界：**本轮读取了用户启动留下的崩溃日志并完成静态故障诊断、修复、构建及已授权的安装替换；未代用户启动、执行自动测试或哈希对比。后续界面初始化、主流程与本地读写能否正常运行仍待用户启动反馈，不能把本次构建和复制成功当作整体软件运行通过。

### EXE-012｜2026-10-03｜原版 EXE 局部修改试验，随后按用户要求停止此路线

- **原因与范围：**用户曾要求参考 HAPP 的方式，在原版工作副本 EXE 上修改指定方法并试运行；随后明确要求回到完整源码工程修复。本条保留这段试验记录，当前主工程和 `build.cmd` 没有切换到补丁生成方式。
- **试验文件（均在 `原版EXE局部修改/` 下）：**`src/LocalMode/Quicker.LocalMode.csproj`、`src/LocalMode/ReplaceMethodAttribute.cs`、`src/LocalMode/LocalWorkspace.cs`、`src/Patcher/Quicker.LocalPatcher.csproj`、`src/Patcher/Program.cs`、`build.cmd`。LocalWorkspace 曾实现试验用的本地启动、路径、配置适配；Patcher 使用 dnlib 保留原方法及资源，对指定方法写入转调逻辑。试验工作区为 `%LOCALAPPDATA%\QuickerOpenSourcePatch`，与完整源码版分开。
- **实际结果：**试验工程曾生成 `原版EXE局部修改/artifacts/app/Quicker.exe`，但直接运行仍发生异常，未确认运行成功。没有生成后续提议的“只修改翻页”版本。用户恢复安装目录后，要求放弃此路线，继续修复由 `src/Quicker.csproj` 构建的 EXE。
- **遗留与边界：**试验文件保留作为历史记录；未访问 `Quicker原始备份`，未改动 HAPP 构建方式；本条的局部修改代码不参与下条记录中实际启动的源码版 EXE。

### EXE-013｜2026-10-03｜修复源码版启动空引用并补齐浏览器运行依赖

- **原因：**源码版启动后，日志报告键盘钩子 `HookCallbackProcedure` 和外观更新 `UpdateUIAppearence` 的空引用；修复后用户又反馈缺失 `ChromeAgent.exe`，以及面板显示灰色空白格子。
- **全部涉及文件与关键修改：**
  - `src/Quicker/Utilities/Hooks/KeyboardHook.cs`，`HookCallbackProcedure`：把 `flag`、`e`、`flag3`、`flag4` 的局部变量初始化放到方法入口，去掉 `IL_033c` 处重复初始化。原恢复源码在已经创建事件参数后跳回这里，又把 `e` 清空，随即解引用；恢复的原 IL 没有对应的 `ldnull`，本次修正该 C# 控制流恢复错误。
  - `src/Quicker/View/PopupWindow.cs`，`UpdateUIAppearence`：删除 `IL_017d` 下对 `uiSettings` 的再次置空，保留方法入口声明及 `IL_0162` 取得实际配置的赋值。原恢复源码跳转后把已取得的外观配置清空；恢复的原 IL 没有对应的 `ldnull`。
  - `src/Quicker.csproj`：加入 `ChromeAgent.exe`、`ChromeAgent.exe.config`、`ChromeAgent.log4net.config` 三项固定运行依赖，以 `CopyToOutputDirectory="PreserveNewest"` 从允许使用的 `quicker/Quicker` 工作副本复制。此前浏览器原生消息模块初始化需要这些文件，构建输出却缺少它们；本次保留该功能，修正依赖打包。没有增加辅助脚本，`build.cmd` 不变。
  - 本修改记录：追加 EXE-012、EXE-013，区分已停止的二进制试验和当前源码版修复。
- **实际构建与启动：**原有 `dotnet build src/Quicker.csproj -c Release --nologo -v:q` 成功，0 个错误、5,981 个警告。用户明确退出原实例并授权启动检查后，实际运行了 `artifacts/bin/Release/net472/Quicker.exe`；用户截图确认设置页能打开并显示“本地用户”。补齐依赖后于 21:34 再次启动同一路径的修正版，进程 27076；日志记录启动完成，检查时未出现上述缺文件、键盘钩子和外观更新空引用报错。没有替换用户已恢复的安装目录。
- **灰色空白面板的检查：**源码中的默认底色为灰色；用现有 SQLite 程序集以只读连接检查 `%LOCALAPPDATA%\QuickerOpenSource\data\quicker.db`，得到 `_global` 与 `_default` 两个未删除页面，两者动作数均为 0。这与 EXE-007 首次建立独立空白工作区的行为一致。没有读取、迁移或删除原版账号数据库；空白不表示原版动作丢失。已请用户确认空白格子右键能否弹出创建菜单，交互及动作保存/运行结果仍待确认。
- **遗留：**本次确认启动及设置页显示取得进展，不等于全部功能通过。仍有编译警告、其它恢复代码的潜在控制流错误、完整本地迁移与 EXE-007 所列本地化待办；关于页仍有旧账号版本文案。浏览器扩展的实际通信尚未测试。

### EXE-014｜2026-10-03｜按用户要求直接读取原本地目录，暂停账号清理与迁移

- **用户最新要求：**先不修改本地配置、不处理账号清理，直接重新生成 EXE，读取 `C:\Users\admin\AppData\Local\Quicker`，检查已有动作能否加载。此前提出的账号过滤迁移没有实施，也没有新增迁移代码。
- **涉及文件：**`src/Quicker/Domain/Services/AppPathProvider.cs` 的 `LocalDataRoot` 及注释，把 `%LOCALAPPDATA%\QuickerOpenSource` 改为 `%LOCALAPPDATA%\Quicker`。现有数据库路径和 `AppHelper.GetUserDataDir` 共用此入口，因此动作、设置、图标缓存及状态读取切回原目录。本修改记录追加本条；构建脚本不变。
- **已查明的数据：**只读查询原目录的 `data/quicker.db`，确认有 14 个未删除动作页、104 个动作；`CommonData` 存在 `secret_info`、`user_info` 账号记录。原登录界面另使用用户级 `user.config` 的 `username` 设置；没有输出账号、密码或令牌内容，也没有清理这些记录。此前独立工作区随后已有用户新建的 1 个动作，仍留在 `QuickerOpenSource`，本次未合并到旧目录。
- **构建与启动：**用户确认退出占用中的修正版后，原构建命令成功，0 个错误、5,981 个警告。21:43:56 启动 `artifacts/bin/Release/net472/Quicker.exe`，进程 26888；日志记录主流程和搜索初始化完成，检查时进程仍响应，没有再次出现前述启动空引用或缺失 ChromeAgent 的错误。没有替换 `C:\Program Files\Quicker`。
- **本机回退副本：**启动前将旧数据库复制到 `%LOCALAPPDATA%\QuickerOpenSource\backups\before-existing-data-20261003-214356\quicker.db`，仅存在本机用户数据目录，没有放入项目或发布产物。原数据库没有被迁移、清空或手工改写账号。
- **运行检查边界：**用户用物理 Escape 键停止了 Computer Use，随即停止界面自动操作；原动作在面板中的完整显示及逐项执行结果尚未确认。该路径切换不是只读模式，程序正常运行仍可能保存日志、缓存、本地工作区标记和用户之后的编辑，不能表述为原目录全部文件保持字节不变。源码版启动仍使用本地用户身份，不恢复原厂登录或云同步。

### EXE-015｜2026-10-03｜删除遗留原厂请求实现，修复图标返回值，接通更多本地存储

- **触发与证据：**用户反馈动作执行出现“发生一个或多个错误”、图标空白，并明确再次要求直接删除原厂服务器请求代码。现有日志的异常链指向 `DownloadSharedActionAsync → GetSharedActionAsync → AppServer`，原厂返回 Unauthorized。只读读取现有数据库：104 个动作中有 77 个带 TemplateId，其中 64 个实际启用 UseTemplate 且没有本地正文；40 个未启用 UseTemplate 且有本地数据。LocalSharedAction、ActionHistory、ProfileBackupItems 均没有记录。EXE-014 启动前保存的数据库副本也有相同缺失情况，不能把缺失归因于本次删除请求。未输出账号、密码或令牌。
- **核心接口及动作数据（以下均相对本目录）：**
  - `src/IgQBbvXMVdsN7GVNUxX/aFIptTXYsUoTUF4v33R.cs`：删除原厂 API 地址、网络请求状态机、上传下载实现及 Bearer 凭据维护。已有本地文本指令、图标、设置、备注和备份接口继续保留；动作正文读取改为本地精确版本；表达式改为本地保存和查询；库列表改读本地记录。未实现本地替代的云发布、服务授权等入口返回明确错误，不伪造发布成功或远程结果。通用 HttpClient 仅保留给用户动作及用户配置的服务，不附带原厂账号凭据。
  - `src/Quicker/Domain/Services/LocalDataStore.cs`：增加 `GetSharedAction`、`ImportSharedAction`、`BackupAction`、本地表达式保存查询和使用计数。缺失指定动作版本时报告动作 ID/版本，绝不下载。JSON 导入要求本地文件；动作备份先补齐本地模板正文，缺失时报告失败。
  - `src/Quicker/Domain/Services/DataService.cs`：删除共享动作下载状态机，`Wott6D3Yp9F` 只读内存和本地数据库。
  - `src/Quicker/Domain/AppServer.cs`、`src/Quicker/Domain/Services/ActionEditMgr.cs` 及同一 `DataService.cs`：同步等待动作正文时改用 `GetAwaiter().GetResult()`，直接显示实际缺失原因，避免 `.Result` 再包装成 AggregateException。
  - `src/Quicker/Domain/Services/SQLDataMgr.cs`：本轮构建两次发现当前文件重新出现旧账号加载、待同步标记和注销删库实现，且缺少 `LoadLocalWorkspace`；原因尚未确认，已询问用户是否有其它编辑任务。恢复本地工作区身份、空工作区可加载、本地保存不排队上传、排除已删除通用对象、最终写入失败抛错及不删除异常数据库；再次删除注销清库方法。没有改写已有账号记录。
- **图标与网页资源：**
  - `src/jUHfG42nmbml7b5l5N7/JZry4r2NiosU3b6650j.cs`：原异步图片加载在取得图片后又把结果赋成 default/null，导致图标为空。改为直接的 async 源码，保留本地图片、程序缩略图、UWP 图标及 data 图片；旧 HTTP 地址只用作 ImageCache 的缓存键，删除远程下载状态机。
  - `src/Quicker/Utilities/ImageCache.cs`：删除 BitmapImage 联网下载及下载完成后写缓存的实现，图片只读本地、已有缓存或内嵌数据。
  - `src/CpRmjmYrY5NIYQiiVIA/tApqttYCLpKNRcDCrWi.cs`：SVG 只读本地文件及已有缓存，删除 WebClient 下载分支。
  - `src/Quicker/Utilities/AppHelper.cs`：移除自动登录 URL 状态机和账号跳转；用户中心入口打开本地目录。系统图标、网站图标、程序图标地址改为已有缓存路径；SVG 使用本地渲染，不调用原厂 SVG 转 PNG 服务。为兼容旧缓存，部分原 URL 字符串仍作为哈希键存在，不用于请求。
  - `src/FdaTBA2jtlaSbaTAl7V/kJRDjH226hXeo1HfxgN.cs`、`src/uqYElb2WVkpP0FWdV1D/HOvYIX2wovhtMxBUwgX.cs`：浏览记录和收藏的图标使用本地缓存路径。
  - `src/Quicker/Modules/BrowserControl/Message/ActionItemToWeb.cs`：发送给浏览器的动作图标在本机渲染成 PNG data URI，不再提供原厂图标服务 URL。
  - `src/Quicker/Utilities/WebSiteInfoHelper.cs`：删除读取用户指定网站失败后向原厂图标服务发送域名的兜底。
  - `src/Quicker/Domain/Actions/Debugging/HtmlActionLogger.cs`：删除原厂 CSS/JS/CDN 引用，保留内嵌样式，折叠及动作步骤跳转改为原生 JavaScript。
  - `src/pEvh96AzTBdjpSVb1d0/Ul3JYWAa0WqW9EBQbgu.cs`：局域网文件页面的样式、表单、批量下载按钮和缩略图加载改为内嵌实现，删除原厂 CDN 脚本和样式。文件上传表单仍指向用户自己的本机服务。
  - `src/Quicker.g.resources`、`src/settings/pages/about/aboutsettingpage.baml`、`src/view/account/followweixin.baml`：使用现有本机 ILSpy BAML 读写器删除两处 `weixin.jpg` 远程图片来源属性，避免打开设置页时直接请求原厂图片。没有修改构建脚本或增加资源生成器。
- **账号、更新及用户网络动作的边界：**
  - `src/bpNbEZj0vTDod37Z02B/uT4WJujEfNmOl8aWJJC.cs`：删除给通用客户端设置原厂 Token 的调用。
  - `src/Quicker/Domain/Actions/X/BuiltinRunners/HttpStep.cs`：删除识别原厂域名后自动附加账号 Token 的分支；用户指定 HTTP 请求仍保留。
  - `src/DteyAGXxRTw4WY0S75h/H4rLbTXtxuZjM4Su8vo.cs`：删除内置 AI 代理地址和自动 Token，旧 quicker/p1 代理选项提示用户改用自己配置的服务。
  - `src/Quicker/View/Account/ExternalLoginWindow.cs`：删除浏览器登录页初始化，旧窗口被调用时只显示无需账号的说明。
  - `src/Quicker/Modules/VersionUpdate/UpdateNotifierWindow.cs`：删除下载状态机、安装器下载/执行及更新页面地址；按钮说明到项目 GitHub Releases 手动更新。
  - `src/Quicker/App.cs`：系统位数不匹配时不再打开原厂下载页，改为项目手动更新说明。
  - `src/mhan9VA4t36nUXE7ZEi/N3fyKuAyxGkZEcSSS2n.cs`：删除默认原厂代码补全服务器；仅在用户自行配置补全服务时使用该服务，未配置时明确报告。
- **本地服务及原云功能：**
  - `src/Quicker/Modules/Searching/Builtin/QuickerDocSearchPlugin.cs`：删除启动下载文档索引及在线搜索，只查询本地索引。
  - `src/f8ogFZ2dBqt6qJtMhHZ/OcfjAK2mDoFrkKoG0ga.cs`：词典搜索只查询本地词典记录。
  - `src/jtYKvI2ve9aDjyxS5gf/IIQBbr2FgGR5ONc4nck.cs`：删除原厂普通/表格 OCR 请求；普通识别调用已有 Windows 本机 OCR，返回实际文本和坐标。Windows 不提供置信度，使用 NaN 表示不可用。表格识别目前明确不支持。
  - `src/tQy5b4MZR11HLf8vRkW/KJPvclMRZwxyLnfknnp.cs`：OCR 中文字符间空格合并改为本地正则处理，不再上传识别文本。
  - `src/Quicker/Domain/Actions/X/BuiltinRunners/Images/ReadQRcodeStep.cs`：保留 ZXing、QRDecoder 两种本地识别，删除失败后的在线兜底。
  - `src/Quicker/Actions/XActions/BuildinRunners/MathOcrStep.cs`、`src/piDsMpo8qwHUK1c200X/rVFHuDohYFJjqSXkusO.cs`：删除原厂公式 OCR、翻译和词典代理，返回不支持及本地/自配服务的说明，没有伪造识别或翻译结果。
  - `src/Quicker/Utilities/Texting/WebTextProcessor.cs`：删除原厂云文本处理地址及状态机；用户自己指定的 URL 文本处理保留。
  - `src/soLGR8XA95f82ljopSU/oHyR5LX5l5qeapYlxI6.cs`：删除原厂 OSS 凭据、桶、上传下载状态机。原 CloudState 数据接口改存本地 SQLite；删除键使用本地记录移除。临时文本、图片和文件保存到本地 `exports`，返回 file URI，不能再当作其它电脑可访问的公共网址。
  - `src/Quicker/Domain/Actions/X/BuiltinRunners/Images/TempImageBedStep.cs`、`src/Quicker/Utilities/NetworkHelper.cs`：删除原厂图床和百度 BOS 临时桶上传，改成本地临时文件导出。
  - `src/Quicker/Domain/Actions/X/BuiltinRunners/CloudDataStep.cs`、`src/Quicker/Domain/Actions/X/BuiltinRunners/TempCloudStoreStep.cs`：调整为本地数据/本地临时存储文案，保留旧动作键以兼容已有动作。
  - `src/O2cJaejzKucHfiZGXB0/GjEIhFja8p2K53Rulg4.cs`：删除内置原厂私钥证书和远程证书下载，用户启用本机 HTTPS 时读取本地 `certificates/websocket.pfx`；缺失、过期或没有私钥时报告原因，不改变系统信任设置。
  - `src/LPXkJxoo8BnxcREeFLt/afTGWWoXytUImX5ZUwY.cs`：局域网地址直接使用本机 IP，不再依赖原厂 lan.quicker.cc 域名。
- **实际构建：**修复本批改动的命名空间引用及删除下载方法后遗留的闭包引用；恢复 SQL 本地实现后，现有 `dotnet build src/Quicker.csproj -c Release --nologo -v:q` 成功，**0 个错误、5,954 个警告**，输出 `artifacts/bin/Release/net472/Quicker.exe`。没有新增构建脚本、测试、对比清单或验证框架。
- **运行与数据边界：**本轮只诊断用户现有日志/本地数据、修改源码与资源、构建；没有运行或替换安装目录，没有清理账号配置，没有访问原始备份。用户当前运行的进程先前显示路径为 `C:\Program Files\Quicker\Quicker.exe`，不会因本次构建自动更新。图标显示、本地 OCR、文件页面和各动作的实际交互均尚未运行确认。
- **明确遗留：**这次删除原厂后台请求实现，不等于全部功能复现完成。本地缺失的 64 个模板动作必须从完整动作文件/备份补入；表格/公式 OCR、翻译、语音及云发布功能尚无完整本地替代；本地库、词典、文档索引的导入界面仍未补齐。原厂帮助、介绍等手动网页链接和旧界面文案尚有保留；其它未复现 DLL 的内部行为未检查。本轮没有抓包，不能宣称整个运行软件零网络流量。上述 SQL 源文件被重新写回的问题仍需查明，避免后续编辑覆盖本地化改动。
- **用户补充与压缩包目录：**用户说明经常解压 `%LOCALAPPDATA%\Quicker登入账号的各种配置.rar`。本轮只用本机 UnRAR 列出文件目录，确认其中有 `Quicker/data/quicker.db`、搜索历史数据库和 ImageCache；目录中未发现 C# 源码/工程或单独动作导出包。没有解压、覆盖或打开其中的账号数据，因此尚不能判断该包数据库是否含完整模板正文。恢复这个数据包可以恢复旧账号和动作配置，但不能据此解释 D 盘源码被改回。最终构建后的 SQL 源文件仍含本地工作区方法，未将回退原因归咎于用户。

### EXE-016｜2026-10-03｜恢复安装目录原版供用户登录，并导出账号工作区数据

- **用户要求：**将 `C:\Program Files\Quicker\Quicker.exe` 恢复原版，用户自行登录原账号后下载账号数据。
- **实际恢复：**使用允许访问的工作副本 `D:\ProjectsPycharm\MultiProjects\quicker\Quicker\Quicker.exe`（1.44.10.0，原厂签名有效），通过 Windows UAC 复制回安装目录。安装目录 Common DLL 的原程序集身份与该版本匹配，未替换 Common；未访问 `Quicker原始备份`，未修改复现工程源码、资源或构建方式。
- **恢复前副本：**当前 EXE 和登录前数据库保存到 `%LOCALAPPDATA%\QuickerAccountExport\20261003-224808-f6bf023f\before-login`。恢复复制操作成功后启动原版 EXE，进程 50564；用户明确回复已登录。
- **下载与保存：**使用当前账号的正常接口读取云端工作区，保存 14 个动作页、105 条动作配置、18 项同步配置；64 条模板引用对应的 63 份不同编号/版本正文全部下载成功，继续取得 23 份共享子程序、111 个引用图标及账号图标库、备注等接口返回的数据。动作历史备份列表未返回记录。认证信息未输出到对话，也未写入项目源码。
- **独立数据副本：**通过 SQLite 备份接口保存一致的数据库副本到上述导出目录的 `local-workspace/data/quicker.db`，在这个副本中加入 86 份下载正文，以及从已下载动作中提取的 4 份完整全局子程序定义；保留原动作内嵌内容。复制本机状态、缓存、辅助文件和日志。未手工覆盖当前运行目录的数据库或清理登录信息；原版自身的正常登录、同步和缓存写入仍可能改变当前用户目录。
- **交付文件：**上述目录中的 `Quicker账号本地数据备份_20261003.zip` 与 `export-result.json`。压缩包是用户个人恢复资料，含本机账号配置，未放入 GitHub 或公开发布目录。
- **边界：**云状态存储拒绝列出全部对象（AccessDenied）；从动作中识别的 5 个固定状态键返回不存在，动态状态键无法据此完整枚举。2 个无法取得定义的旧全局子程序引用位于禁用步骤中，保持原状。没有执行下载的动作或测试离线运行，不能宣称服务器上的全部账户资料均已导出，也不能把下载成功等同于复现软件所有功能正常。
- **缓存机制补充：**恢复的原 `DataService.GetSharedActionAsync` 依次读内存、本地 `LocalSharedAction`、服务器；下载成功调用 `Gn9t6dsn2Bp`，同时保存内存和数据库。登录同步并不等于预下载全部共享动作正文。旧数据库及用户 RAR 中缓存表为空，不能据此断言正常退出会清空缓存。

### EXE-017｜2026-10-03｜换回最新源码构建版，补入已下载的本地动作缓存供用户测试

- **用户要求：**将 `C:\Program Files\Quicker\Quicker.exe` 换回最新源码生成的版本，由用户再次测试。
- **实际替换：**替换前没有 Quicker 进程运行。通过 Windows UAC，将 `artifacts/bin/Release/net472/Quicker.exe`（EXE-015 的最新构建产物）及同目录配套 `Quicker.Common.dll` 复制到安装目录；复制结果成功。未修改源码、资源、工程或构建脚本，未重新构建。
- **替换前备份：**安装目录原版 EXE、Common DLL 和当前数据库保存在 `%LOCALAPPDATA%\QuickerReplacementBackups\20261003-source-test-232054-3696a687`，同目录保存替换及缓存补入操作结果。未访问 `Quicker原始备份`。
- **本地数据准备：**当前实际使用的数据库 `LocalSharedAction` 仍为 0 条，直接换程序会继续缺少正文。已向用户说明后，将 EXE-016 下载的 63 份动作正文、23 份共享子程序，以及从正文提取的 4 份全局子程序定义补入 `%LOCALAPPDATA%\Quicker\data\quicker.db`；使用事务和 `INSERT OR IGNORE`，不覆盖既有记录。向 `ImageCache` 补入原来缺少的 7 个文件；已有图标文件保留。
- **数据边界：**没有整体覆盖数据库，没有清理账号记录或改变原有动作页布局、设置；只加入上述缺失正文及依赖记录。原私人导出包继续保留。
- **运行与遗留：**未启动软件、运行自动测试或执行用户动作；交由用户启动安装目录 EXE 测试。EXE-015 的未完成本地替代功能及 EXE-016 记载的云状态导出限制仍存在，本次替换不代表全部功能已经确认正常。

### EXE-018｜2026-10-03｜恢复用户主动从网站导入动作，保留本地启动和运行

- **用户澄清：**删除的是启动、后台同步和自动更新对服务器的依赖；用户主动点击导入时，应允许下载该动作、保存本地。EXE-015 把网站导入也禁止了，范围过大，本次修正。
- **全部涉及源码：**
  - `src/Quicker/Domain/Services/SharedActionImportService.cs`：新增业务下载入口 `ImportAsync`。网站动作使用原 `GetSharedActionByLink` 接口，子程序使用原 `SharedAction/Download` 接口；沿静态 `@@编号@版本@名称` 和子动作 `UseTemplate` 引用递归补齐指定版本，去重并处理循环引用，跳过禁用步骤。已有同版本正文保留，缺失正文才新增到 `LocalSharedAction`；不导入整套账号、动作页或设置。图标在主动导入时写入现有 `ImageCache`，已有图标保留，缺图给出说明。文件导入仍只读本地，不隐式联网。下载只读响应，不执行动作。
  - `src/Quicker/Domain/Services/LocalDataStore.cs`：原 `ImportSharedAction` 改为 `ReadSharedActionFile`，只解析本地完整动作文件；统一由主动导入服务保存，删除“已删除网络动作导入”的错误文案。
  - `src/IgQBbvXMVdsN7GVNUxX/aFIptTXYsUoTUF4v33R.cs`：`ewCt1dE0NmP`、`zWGtbRbRnCk` 分别接入主动动作、子程序导入。其它本地正文读取、登录、同步及更新接口保持本地化处理。
  - `src/Quicker/Domain/Services/SQLDataMgr.cs`：`SaveSharedAction` 增加 `overwrite` 参数，主动导入使用 `INSERT OR IGNORE` 保留已有版本；写入重试最终失败时抛错，避免未保存却提示成功。其它既有调用保留原默认行为。
  - `src/Quicker/View/ActionInfoWindow.cs`：详情页加载从主动下载入口切换为本地指定版本读取，避免打开详情触发联网或版本查询。
  - `src/Quicker/Domain/Services/ActionEditMgr.cs`：导入时显示缺图说明，新安装动作的 `AutoUpdate` 固定为 false。保留用户选择目标格子及原有替换确认流程，不批量覆盖本地动作。
  - `src/Quicker/View/SharedActionInfoWindow.cs`：导入确认窗口关闭并隐藏自动更新选项；属性固定返回 false。
  - `src/Quicker/View/X/Controls/InternalSubProgramListControl.cs`：主动导入子程序时显示缺图说明。
- **网站认证边界：**默认匿名下载。仅在用户主动导入、固定官方 HTTPS API 返回 401 时，允许单次请求使用本机 `user_info` 中此前正常登录保存的 Token；不登录、不刷新令牌、不启动同步，不输出凭据，不写入源码。下载客户端禁止重定向，图片请求不附带 Token。网站要求权限且现有凭据不可用时明确报错，不绕过网站权限。本地启动、详情查看及已有动作执行不依赖此凭据。
- **构建：**现有构建命令成功，0 个错误、5,954 个警告，产物仍为 `artifacts/bin/Release/net472/Quicker.exe`。没有增加构建辅助脚本、自动测试或接口对比。本轮尚未替换安装目录或实际执行网站导入，不能把编译成功表述为下载和交互测试已通过。
- **边界：**动态计算的依赖、用户私有 `%%` 全局子程序、动作自身访问外部服务的行为，不由本次静态共享依赖下载解决。文件缺少共享依赖时报告缺失；缺图不会触发启动后的后台补下载。现有本地数据及原始备份未修改。
- **发布请求：**用户要求将本版源码公开到 GitHub。已识别 Codex 连接账号 `y3507251-beep`；当前连接器没有创建仓库工具，本机 Git 凭据返回 401，浏览器控制超时，Windows Computer Use 因无法可靠识别网址停止。尚未创建远程仓库或上传代码。后续发布需继续完成源码发布范围、依赖说明及有效 GitHub 写入登录的准备；根 MIT 的范围仍以 `NOTICE.md` 为准。

- **本地发布准备：**本版主体源码、所需项目文件和资源已整理到工作区 GitHub发布/quicker-local，建立独立 Git 仓库并提交；不包含安装依赖二进制、构建结果、原始留样、账号数据库和个人导出包。发布 README 已写明依赖准备方式、构建状态及 MIT/NOTICE 范围。代码中的资源字符串匹配疑似凭据，经检查是序列化的 CultureInfo 语言资源编码误报。GitHub 远程发布仍待有效写入授权，尚未创建仓库。


### EXE-019｜2026-10-03｜按用户要求公开发布本版源码

- **授权与结果：**用户明确要求创建公开 GitHub 仓库并上传本版代码，随后通过正常设备授权流程完成 Git Credential Manager 登录。已创建公开仓库 https://github.com/y3507251-beep/quicker-local ，主分支 `main` 的源码上传成功。未创建或发送第三方消息。
- **发布目录：**工作区 `GitHub发布/quicker-local` 是独立的源码发布仓库。包含主 EXE、Common 的主体源码、项目文件及必要资源、固定 `build.cmd`、公开公钥、许可范围说明和本修改记录。发布根 `README.md` 描述当前行为、依赖准备、构建方法和未完成边界；`.gitignore` 排除构建产物、原版依赖留样、数据库、私人备份及凭据文件。公开版 `OPEN_SOURCE.md` 使用相对许可链接。
- **来源与范围：**保留原有 MIT/NOTICE 的范围说明，没有把从原版恢复的内容和第三方资源统一宣称为本项目原创 MIT 内容。没有上传用户运行目录、私人账号导出包、原始备份或安装依赖二进制；发布仓库不是自包含安装包，尚未恢复的 DLL 仍需按 README 在本机准备。
- **构建与运行：**发布的是 EXE-018 本轮构建对应的源码，0 个错误、5,954 个警告。发布准备没有改变业务源码或构建方式，没有新增测试、验证框架或文档生成器；没有实际运行网站导入，也没有替换当前安装目录。GitHub 源码发布成功不表示此前列出的运行问题或本地替代功能均已完成。
