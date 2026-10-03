# Quicker.Common

本项目由 Codex 计划与执行

DLL 主体源码位于 [src](src/)，固定构建入口为 [build.cmd](build.cmd)。日常修改源码后直接构建，不需要维护文件清单或修改构建辅助代码。

2026-10-04 修改 [UserLimitation.cs](src/Quicker/Common/Vm/Account/UserLimitation.cs)：新增 `Unrestricted`，本地功能许可标记全部开放，`LockButton=false`；6 个数量/容量参数为 0，表示不设产品配额。旧 `Free` 属性保留为兼容别名，不表示有会员分级。

主 EXE 同时删除了本地限制分支，运行时使用同次构建的 EXE 和 Common DLL。仅替换本 DLL 不能消除旧 EXE 中的独立判断。配套 EXE 本轮构建 **0 错误、5,963 警告**，未启动测试或替换安装目录。

依赖准备、全部修改文件与本地/联网业务边界见[仓库首页](../../../README.md)。本项目自行创作且有权许可的贡献按 [MIT](../../LICENSE) 开放，允许自由修改、扩展与再分发；原版恢复内容及第三方组件保留各自权利，详见 [NOTICE](../../NOTICE.md)。
