using Quicker.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using log4net;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Common.Services.Speech;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Backup;
using Quicker.Common.Vm.Depd;
using Quicker.Common.Vm.ExeActions;
using Quicker.Common.Vm.Expression;
using Quicker.Common.Vm.Note;
using Quicker.Common.Vm.Services;
using Quicker.Common.Vm.Share;
using Quicker.Common.Vm.Skin;
using Quicker.Common.Vm.SubPrograms;
using Quicker.Common.Vm.Sync.V3;
using Quicker.Common.Vm.Sync.V4;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd.Aliyun;

namespace IgQBbvXMVdsN7GVNUxX;

internal static class aFIptTXYsUoTUF4v33R
{


    // 仅供用户动作访问指定服务，不再保存或附带原厂账号凭据。
    private static HttpClient pR2tb5VTWDX = KtDt1YBndA5(25000, false);
    private static HttpClient zTGtbobPV3j;

    public static HttpClient SCMt1euroaW() => pR2tb5VTWDX;

    public static HttpClient KtDt1YBndA5(int int_0, bool bool_0)
    {
        var handler = new HttpClientHandler();
        AppHelper.ApplyProxy(handler);
        handler.SslProtocols = SslProtocols.Tls12;
        if (handler.SupportsAutomaticDecompression)
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        return new HttpClient(handler) { Timeout = TimeSpan.FromMilliseconds(int_0) };
    }

    public static void NxZt1IVAPHv()
    {
        var previous = pR2tb5VTWDX;
        pR2tb5VTWDX = KtDt1YBndA5(25000, false);
        previous?.Dispose();
        zTGtbobPV3j?.Dispose();
        zTGtbobPV3j = null;
    }

    public static HttpClient edGt1WgaPmw() => zTGtbobPV3j ?? (zTGtbobPV3j = KtDt1YBndA5(120000, false));


	public static Task<ApiResult<IList<ExpressionHelpItem>>> Bt1t1PiujYn()
	{
		return LocalDataStore.Execute<IList<ExpressionHelpItem>>(() => LocalDataStore.ReadList<ExpressionHelpItem>("local_expression_help"));
	}

	public static void rNZt1EEToCr(Guid guid_0)
	{
		LocalDataStore.IncrementCount("expression:" + guid_0);
	}

	public static Task<ApiResult<SharedExpressionDto>> s1tt1yIFlwj(ShareExpressionVm shareExpressionVm_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.SaveExpression(shareExpressionVm_0));
	}

	public static Task<ApiResult<IList<SharedExpressionDto>>> r8Ct18kAqRj()
	{
		return LocalDataStore.Execute<IList<SharedExpressionDto>>(() => LocalDataStore.ReadList<SharedExpressionDto>("local_expressions"));
	}

	public static Task<ApiResult<IList<SharedExpressionDto>>> Y1Ut1aT9ASd(string string_2, VarType? nullable_0, VarType? nullable_1, int int_0, int int_1, CancellationToken cancellationToken_0)
	{
		cancellationToken_0.ThrowIfCancellationRequested(); return LocalDataStore.Execute(() => LocalDataStore.FindExpressions(string_2, nullable_0, nullable_1, int_0, int_1));
	}

	public static Task<ApiResult<string>> JEqt1cQCpi8(ActionItem actionItem_0, string string_2, DateTime? nullable_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.BackupAction(actionItem_0, false, null, string_2, nullable_0));
	}

	public static Task<ApiResult<IList<BackupItemListDto>>> GDXt1VN8yYU(UserObjectType userObjectType_0, string string_2)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetBackups(userObjectType_0, string_2, false)); }

	internal static Task<ApiResult<string>> tDQt1ZlBCSo(BackupItemVm backupItemVm_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveBackup(backupItemVm_0)); }

	public static Task<ApiResult<BackupItemDetailDto>> vPwt19mLrpD(UserObjectType userObjectType_0, string string_2, long long_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetBackup(userObjectType_0, string_2, long_0)); }

	public static Task<ApiResult<string>> PVFt1hn78xu(UserObjectType userObjectType_0, IList<long> ilist_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.DeleteBackups(userObjectType_0, ilist_0)); }

	public static Task<ApiResult<AuthenticateResult2>> o6jt1sruPwZ(string string_2, string string_3, string string_4)
	{ return Task.FromResult(ApiResult<AuthenticateResult2>.Error("本地版无需登录账号。")); }

	public static Task<ApiResult<AuthenticateResult2>> yG2t1HZO5SC(string string_2, string string_3, string string_4)
	{ return Task.FromResult(ApiResult<AuthenticateResult2>.Error("本地版无需登录账号。")); }

	public static Task<ApiResult<string>> k76t11Zg0Pl(ActionProfile actionProfile_0)
	{ return LocalDataStore.Execute(() => { AppState.DataService.xHZt6K2LJ8p(actionProfile_0); return "已保存到本地。"; }); }

	public static Task FuBt1bomwcp(string string_2)
	{ AppState.SQLDataMgr.mCXtxlXbkjx(string_2); return Task.CompletedTask; }

	public static Task<ApiResult<string>> kiBt16rh2I5(string string_2, Image image_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveImage(string_2, image_0)); }

	public static Task<ApiResult<string>> ihUt1XUajHY(string string_2)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveSvg(string_2)); }

	public static Task<ApiResult<string>> nOTt1mVbUaN(string string_2, Icon icon_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveIcon(string_2, icon_0)); }

	public static Task<ApiResult<IList<IconFileDto>>> ORBt1x1qGAw(string string_2 = "", int int_0 = 0, int int_1 = 20)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetIcons(string_2, int_0, int_1)); }

	public static Task<ApiResult<string>> biAt1rk3xe5(Guid guid_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.DeleteIcon(guid_0)); }

	public static Task<ApiResult<SharedActionDto>> vnvt1pYyGU6(SharedActionVm sharedActionVm_0)
	{
		return Task.FromResult(ApiResult<SharedActionDto>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<ShareObjectResult>> IX2t1Btwolg(SharePowerKeyVm sharePowerKeyVm_0)
	{
		return Task.FromResult(ApiResult<ShareObjectResult>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<SharedPowerKeyDto>> RZ5t1QF4Cjb(Guid guid_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.Require<SharedPowerKeyDto>("local_power_key:" + guid_0));
	}

	public static Task<ApiResult<IList<SharedPowerKeyDto>>> eGyt1jT4Onb()
	{
		return LocalDataStore.Execute<IList<SharedPowerKeyDto>>(() => LocalDataStore.ReadList<SharedPowerKeyDto>("local_power_keys"));
	}

	public static Task<ApiResult<ShareObjectResult>> BI2t1nSVmQC(ShareTextCommandsVm shareTextCommandsVm_0)
	{
		return Task.FromResult(ApiResult<ShareObjectResult>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<SharedTextCommandPackageDto>> G5rt149qpF2(Guid guid_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.Require<SharedTextCommandPackageDto>("local_text_package:" + guid_0));
	}

	public static Task<ApiResult<IList<SharedTextCommandPackageDto>>> wVLt15c7QDV()
	{
		return LocalDataStore.Execute<IList<SharedTextCommandPackageDto>>(() => LocalDataStore.ReadList<SharedTextCommandPackageDto>("local_text_packages"));
	}

	public static Task<ApiResult<SharedActionDto>> nGpt1D5WKDf(ActionItem actionItem_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.GetSharedAction(Guid.Parse(actionItem_0.TemplateId), actionItem_0.TemplateRevision));
	}

	public static Task<ApiResult<SharedActionDto>> ewCt1dE0NmP(string string_2)
	{
		return SharedActionImportService.ImportAsync(string_2);
	}

	public static Task<ApiResult<SharedActionDto>> rh5t1oGDq2S(Guid guid_0, int? nullable_0, bool bool_0 = false)
	{
		return LocalDataStore.Execute(() => LocalDataStore.GetSharedAction(guid_0, nullable_0));
	}

	public static Task bkbt1TZNCV9(UserSettings userSettings_0)
	{ AppState.SQLDataMgr.oYetrup9mBq(userSettings_0); return Task.CompletedTask; }

	public static Task<ApiResult<FeedbackDto>> rMlt1MFvU16(FeedBackVm feedBackVm_0)
	{
		return Task.FromResult(ApiResult<FeedbackDto>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<string>> hEMt1AjK12W(RegisterVm registerVm_0)
	{ return Task.FromResult(ApiResult<string>.Error("本地版无需注册账号。")); }

	public static Task<ApiResult<ExeFileVersionDto>> DSUt1OgOGK3(ExeFileVersionVm exeFileVersionVm_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveExeInfo(exeFileVersionVm_0)); }


	public static Task<ApiResult<string>> pJwt1U1S2b5()
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<string>> KtUt1lKVWry(Guid guid_0)
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<string>> T4Ct1iQlGVJ(ActionVerifyVm actionVerifyVm_0)
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<string>> oSvt133fSEu(string string_2)
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<IList<SharedActionListDto>>> A9pt1fnPsSY(string string_2, string string_3, string string_4, string string_5, int int_0, int int_1)
	{
		return LocalDataStore.Execute<IList<SharedActionListDto>>(() => LocalDataStore.ReadList<SharedActionListDto>("local_action_library"));
	}

	public static Task<ApiResult<SyncResult4>> UtBt1zMHveY(SyncVm4 syncVm4_0)
	{ return Task.FromResult(ApiResult<SyncResult4>.Error("工作区已保存到本地，云同步已移除。")); }

	public static Task<ApiResult<SyncOverwriteResult4>> k2NtbwZrBv6(SyncOverwriteVm4 syncOverwriteVm4_0)
	{ return Task.FromResult(ApiResult<SyncOverwriteResult4>.Error("本地版不覆盖远程数据，请使用本地导入。")); }

	public static Task<ApiResult<SyncResult3>> Rkstbvjlnfv()
	{ return Task.FromResult(ApiResult<SyncResult3>.Error("本地版从本地工作区加载数据。")); }

	public static Task<ApiResult<SyncResult4>> vlatbSqwocC()
	{ return Task.FromResult(ApiResult<SyncResult4>.Error("本地版从本地工作区加载数据。")); }

	public static Task<ApiResult<AppVersionInfo>> uWptb2LjsQe(string string_2, string string_3)
	{ return Task.FromResult(ApiResult<AppVersionInfo>.Error("本地版通过项目 GitHub Releases 手动更新。")); }

	public static Task<ApiResult<IList<ExeDto>>> qshtbuOQrk2(params string[] exeList)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetExeInfo(exeList)); }

	public static Task<ApiResult<CheckActionUpdatesDto>> jKQtbNcw92B(CheckActionUpdatesVm checkActionUpdatesVm_0, bool bool_0 = false)
	{ return Task.FromResult(ApiResult<CheckActionUpdatesDto>.Error("本地动作通过文件导入替换，不联网检查更新。")); }

	internal static Task<ApiResult<string>> GlYtbJkn8Qq(string string_2, UserFileType userFileType_0)
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	internal static Task<ApiResult<Guid>> y7itb0LejF6(ShareSkinVm shareSkinVm_0)
	{
		return Task.FromResult(ApiResult<Guid>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	internal static Task<ApiResult<GetSkinDto>> wTHtbCar8f3(Guid guid_0, bool bool_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.Require<GetSkinDto>("local_skin:" + guid_0));
	}

	internal static Task<ApiResult<BasicOcrRtn>> j18tbPua2rS(string string_2, string string_3, int int_0)
	{
		return Task.FromResult(ApiResult<BasicOcrRtn>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}


	public static Task<ApiResult<SharedActionDto>> lo0tbyRalUe(string string_2)
	{
		return LocalDataStore.Execute(() => LocalDataStore.GetSharedAction(Guid.Parse(string_2), null));
	}

	public static Task<bool> fhitb8lgfRm(string string_2, Guid? nullable_0)
	{
		return Task.FromResult(Guid.TryParse(string_2, out var id) && AppState.SQLDataMgr.EHLtrsqXGsM(id.ToString()).Count > 0);
	}

	public static Task<ApiResult<SharedActionDto>> iuttbawCkyq(SharedActionVm sharedActionVm_0, bool bool_0)
	{
		return Task.FromResult(ApiResult<SharedActionDto>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<SharedActionDto>> duVtb7RQXW3(Guid guid_0, int? nullable_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.GetSharedAction(guid_0, nullable_0));
	}

	public static Task<ApiResult<SharedActionDto>> zWGtbRbRnCk(string string_2)
	{
		return SharedActionImportService.ImportAsync(string_2, subProgram: true);
	}

	public static Task<ApiResult<IList<SharedSubProgramListItemDto>>> PEXtbqPY9Vo(string string_2)
	{
		return LocalDataStore.Execute<IList<SharedSubProgramListItemDto>>(() => LocalDataStore.ReadList<SharedSubProgramListItemDto>("local_subprogram_library"));
	}

	public static Task<ApiResult<IList<SharedSubProgramListItemDto>>> gAxtbc8K0Fo()
	{
		return LocalDataStore.Execute<IList<SharedSubProgramListItemDto>>(() => LocalDataStore.ReadList<SharedSubProgramListItemDto>("local_subprogram_library"));
	}

	internal static Task<ApiResult<AliyunCredentials>> hV2tbVZqnhs(string string_2)
	{
		return Task.FromResult(ApiResult<AliyunCredentials>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	internal static Task<ApiResult<string>> QtRtbZP2Vov(ActionItem actionItem_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.BackupAction(actionItem_0, false, null, "保存动作", null));
	}

	internal static Task<ApiResult<string>> TPptb90mf0k(ActionItem actionItem_0, string string_2, bool bool_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.BackupAction(actionItem_0, true, string_2, null, null));
	}

	internal static Task<ApiResult<string>> y4ctbha9qyZ(ActionItem actionItem_0, bool bool_0, string string_2, string string_3, DateTime? nullable_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.BackupAction(actionItem_0, bool_0, string_2, string_3, nullable_0));
	}

	internal static Task<ApiResult<string>> is6tbeLotFm(BackupItemVm backupItemVm_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveBackup(backupItemVm_0)); }

	public static Task<ApiResult<IList<BackupItemListDto>>> rA8tbYrqXcM(UserObjectType userObjectType_0, string string_2)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetBackups(userObjectType_0, string_2, true)); }

	public static Task<ApiResult<string>> qpxtbIddh6O(UserObjectType userObjectType_0, IList<long> ilist_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.DeleteBackups(userObjectType_0, ilist_0)); }

	public static Task<ApiResult<BackupItemDetailDto>> j81tbWh3YoM(UserObjectType userObjectType_0, string string_2, long long_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetBackup(userObjectType_0, string_2, long_0)); }

	internal static Task<ApiResult<string>> lyJtbkCTo4y(ActionItem actionItem_0, string string_2)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveNote(actionItem_0, string_2)); }

	internal static Task<ApiResult<UserNoteDto>> KWPtbG5YcNY(string string_2)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetNote(string_2)); }

	internal static Task<ApiResult<PackageInfoDto>> OFstbsbGTsP(string string_2, string string_3)
	{
		return LocalDataStore.Execute(() => LocalDataStore.Require<PackageInfoDto>("local_package:" + string_2 + ":" + string_3));
	}

	internal static Task<ApiResult<SearchEngineData>> slotb1VEwjF()
	{
		return LocalDataStore.Execute(() => AppState.SQLDataMgr.PP6trtaO3SY<SearchEngineData>("local_search_engine_library") ?? new SearchEngineData { SearchEngines = new List<SearchEngineDto>(), SearchEngineCategories = new List<SearchEngineCategoryDto>() });
	}

	public static Task<ApiResult<string>> vq7tbbfZDLn(Guid guid_0)
	{
		return LocalDataStore.Execute(() => LocalDataStore.IncrementCount("search_engine:" + guid_0));
	}

	public static Task<ApiResult<string>> m8stb60d2xI(WebSearchEngine webSearchEngine_0)
	{
		return Task.FromResult(ApiResult<string>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<string> VSMtbXtiReP()
	{ return Task.FromResult(string.Join(",", AppState.SQLDataMgr.PP6trtaO3SY<List<string>>("local_blocked_actions") ?? new List<string>())); }

	internal static Task<ApiResult<SpeechAuthDto>> lDstbmARhdW()
	{
		return Task.FromResult(ApiResult<SpeechAuthDto>.Error("原厂云端接口已删除。请使用本地导入/导出；OCR、语音等功能需选择本地引擎或自行配置的服务。"));
	}

	public static Task<ApiResult<IList<TextCommand>>> v6dtbKWl45S(DateTime? nullable_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.GetTextCommands()); }

	public static Task<ApiResult<TextCommand>> WWltbxr9jPf(TextCommand textCommand_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveTextCommands(new List<TextCommand> { textCommand_0 }, true)[0]); }

	public static Task<ApiResult<IList<TextCommand>>> wsitbr0iDiN(IList<TextCommand> ilist_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveTextCommands(ilist_0, true)); }

	public static Task<ApiResult<TextCommand>> sHGtbpgWm2c(TextCommand textCommand_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.SaveTextCommands(new List<TextCommand> { textCommand_0 }, false)[0]); }

	public static Task<ApiResult<string>> Bd5tbBqtBKI(Guid guid_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.DeleteTextCommands(new[] { guid_0 })); }

	public static Task<ApiResult<string>> eoPtbQoPtRc(IEnumerable<Guid> ienumerable_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.DeleteTextCommands(ienumerable_0)); }

	public static Task<ApiResult<string>> DbjtbjdQ3jY(UpdateTextCommandGroupVm updateTextCommandGroupVm_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.UpdateTextCommandGroup(updateTextCommandGroupVm_0)); }

	public static Task<ApiResult<string>> vDdtbnc4qHv(BatchUpdateTextCommandsVm batchUpdateTextCommandsVm_0)
	{ return LocalDataStore.Execute(() => LocalDataStore.BatchUpdateTextCommands(batchUpdateTextCommandsVm_0)); }
}
