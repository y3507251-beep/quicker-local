using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using c9950xo6nwXY2kSPq6l;
using cyQvObokd4nyG7fqnfB;
using DteyAGXxRTw4WY0S75h;
using EMu6sFoissmin2fOAST;
using gfyhcHXZ8WFEUmvG2Br;
using Jlr1ujXFFaeKpmreNmQ;
using kdYE4iocjIn6rpkyuGS;
using log4net;
using LPXkJxoo8BnxcREeFLt;
using piDsMpo8qwHUK1c200X;
using plg1kho04k380EAlDXh;
using PtKu3CoDZRKU2gJOhGP;
using Quicker.Actions.XActions.BuildinRunners;
using Quicker.Actions.XActions.BuildinRunners.Sys;
using Quicker.Actions.XActions.BuiltinRunners;
using Quicker.Actions.XActions.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Common;
using Quicker.Domain.Actions.X.BuiltinRunners.Compute;
using Quicker.Domain.Actions.X.BuiltinRunners.Dict;
using Quicker.Domain.Actions.X.BuiltinRunners.File;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.Actions.X.BuiltinRunners.List;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.BuiltinRunners.Network;
using Quicker.Domain.Actions.X.BuiltinRunners.Notifyer;
using Quicker.Domain.Actions.X.BuiltinRunners.Num;
using Quicker.Domain.Actions.X.BuiltinRunners.Office;
using Quicker.Domain.Actions.X.BuiltinRunners.Other;
using Quicker.Domain.Actions.X.BuiltinRunners.Sys;
using Quicker.Domain.Actions.X.BuiltinRunners.Text;
using Quicker.Utilities;
using S9WVjBXQtWpDOdmdIWW;
using sRKxvLoO2f5yntWNjFh;
using ubfEZRXG3mwdPioTfrb;
using Wc5pWrorOjb6k1eByFk;
using XPsRKmoMKOckGvOl4ux;
using zkDBafo3nCg7Ay6vnkx;

namespace Quicker.Domain.Actions.X.StepRunners;

public static class StepRunnerRegistry
{
	private static readonly ILog PuctDD505UR;

	[CompilerGenerated]
	private static IDictionary<string, IStepRunner> y7atDdMgGR7;

	internal static object S6TnkIQbwcOuoGedeY7c;

	public static IDictionary<string, IStepRunner> Runners
	{
		[CompilerGenerated]
		get
		{
			return y7atDdMgGR7;
		}
		[CompilerGenerated]
		private set
		{
			y7atDdMgGR7 = value;
		}
	}

	static StepRunnerRegistry()
	{
		PuctDD505UR = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		y7atDdMgGR7 = new ConcurrentDictionary<string, IStepRunner>();
		bjdtD4RvTYe();
	}

	public static void Register(IStepRunner runner)
	{
		if (y7atDdMgGR7.ContainsKey(runner.Key))
		{
			throw new InvalidDataException("已经存在相同的步骤类型键值：" + runner.Key);
		}
		y7atDdMgGR7.Add(runner.Key, runner);
	}

	private static void bjdtD4RvTYe()
	{
		int num = 4;
		while (true)
		{
			Register(new MessageBoxOutputRunner());
			int num2 = 3;
			if (!tB8N1kQbTbQZlbA9OdGf())
			{
				goto IL_0022;
			}
			goto IL_04a2;
			IL_04a2:
			Register(new NotifyStep());
			Register(new WaitTimeRunner());
			Register(new IfStepRunner());
			Register(new SimpleIfStepRunner());
			Register(new EachStepRunner());
			Register(new RepeatStepRunner());
			Register(new WaitClipboardChangeStep());
			Register(new ActivateProcessMainWindowStep());
			Register(new CheckProcessExistsStep());
			Register(new mdl19houn1koN1ScTOq());
			Register(new StopActionStep());
			Register(new CommentStep());
			Register(new GetSelectedTextStep());
			Register(new GetClipboardTextStep());
			Register(new GetClipboardImageStep());
			Register(new GetCurrentTime());
			Register(new CreateGuidStep());
			Register(new DependencyCheckStep());
			Register(new WriteTextFileStep());
			Register(new ZipStep());
			Register(new EverythingSearchStep());
			Register(new RunOrOpenStep());
			Register(new GenerateTempFileStep());
			num = 9;
			goto IL_03db;
			IL_03db:
			Register(new WriteImageFileStep());
			num = 13;
			goto IL_0297;
			IL_0297:
			Register(new GetImageInfoStep());
			Register(new DrawStep());
			Register(new GetSelectedFilesStep());
			Register(new GetClipboardFileListStep());
			Register(new GetExplorerPathStep());
			Register(new GetWindowInfoStep());
			Register(new GetActiveProcessInfoStep());
			Register(new StringProcessStep());
			Register(new ya0BpxXRTmRGWC3aRjP());
			Register(new NumberProcessStep());
			Register(new GetChromeUrlStep());
			num2 = 2;
			if (S6TnkIQbwcOuoGedeY7c == null)
			{
				goto IL_0022;
			}
			goto IL_028e;
			IL_0022:
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 15:
					Register(new ComputeStep());
					Register(new FileOperationStep());
					Register(new RunScriptStep());
					Register(new ShowImageStep());
					Register(new TempImageBedStep());
					Register(new ShowTextStep());
					Register(new RandomStep());
					Register(new GroupStepRunner());
					Register(new AssignValueStep());
					Register(new ListOperationRunner());
					Register(new ManageListStep());
					Register(new TableOperationStep());
					Register(new DatabaseOperationStep());
					Register(new CheckFileExistsStep());
					Register(new SelectFolderStep());
					Register(new SelectFileStep());
					Register(new ShowWaitWinStep());
					Register(new DictOperationRunner());
					Register(new GetSysInfoStep());
					Register(new StateStorageStep());
					Register(new CaptureStep());
					Register(new CharInfoStep());
					Register(new PlaySoundStep());
					Register(new KJ2KZno7dbEJwGDRv9u());
					Register(new SendMessageStep());
					Register(new WindowOperationStep());
					Register(new RunActionStep());
					Register(new SubProgramStep());
					goto case 7;
				case 10:
					Register(new RecordStep());
					Register(new FormStep());
					num2 = 11;
					if (S6TnkIQbwcOuoGedeY7c == null)
					{
						continue;
					}
					goto case 7;
				case 7:
					Register(new RunCsScriptStep());
					Register(new RunPythonScriptStep());
					Register(new RunJsScriptStep());
					Register(new WaitKeyboardStep());
					Register(new KeyOperationStep());
					Register(new PlayRecordStep());
					goto case 10;
				case 14:
					Register(new WriteClipboardStep());
					Register(new ReadFileStep());
					Register(new KeyInputStep());
					Register(new SendKeysStep());
					Register(new o0uHbAXBTF8pd3l2LyD());
					Register(new MouseInputStep());
					Register(new SearchBmpStep());
					Register(new OpenUrlStep());
					Register(new ToBase64StringStep());
					Register(new OutputTextStep());
					Register(new RestoreActiveWindowStep());
					Register(new SelectFileInExplorerStep());
					Register(new UserInputStep());
					Register(new SelectStep());
					Register(new NumCompareStep());
					num2 = 0;
					if (S6TnkIQbwcOuoGedeY7c == null)
					{
						continue;
					}
					goto IL_028e;
				case 13:
					goto IL_0297;
				case 12:
					try
					{
						Register(new FlaUiAutomationStep());
					}
					catch (Exception ex)
					{
						PuctDD505UR.Warn("初始化窗口界面控制(FlaUI)组件失败。" + ex.Message, ex);
						AppHelper.ShowError("FlaUI组件文件丢失，可能被360等安全软件误删除。\n请重新安装Quicker解决。", false);
					}
					goto case 5;
				case 5:
					Register(new WebView2Step());
					Register(new XrFhKboffyXFWt56jHS());
					Register(new ROWAp7oCqoO68Ncbqn7());
					Register(new ExcelRangeOperationStep());
					Register(new ExcelObjectOperationsStep());
					num2 = 6;
					if (S6TnkIQbwcOuoGedeY7c == null)
					{
						continue;
					}
					goto IL_028e;
				case 11:
					Register(new QuickerOperationStep());
					Register(new ComputeTimeStep());
					Register(new ComputeColorStep());
					Register(new HtmlExtractStep());
					Register(new UiAutomationStep());
					Register(new WinServiceStep());
					goto case 12;
				case 9:
					goto IL_03db;
				case 8:
					Register(new nAT2RNoYewIg5cnslWi());
					Register(new MathOcrStep());
					Register(new JoinListStep());
					Register(new SplitStringStep());
					Register(new WriteFileToClipboardStep());
					Register(new BreakStep());
					Register(new ContinueStep());
					num = 15;
					goto case 15;
				case 6:
					Register(new y79XvEXVcj9PCimSMLg());
					Register(new i2KmbQoEvmSN6KnrWAE());
					Register(new tDr6CKos9H62j34ncfZ());
					Register(new oyi2lvone7QEWdEeRuW());
					Register(new ReportProgressStep());
					Register(new AudioControlStep());
					Register(new k76Lmfo1B5RyIdJCx7F());
					num2 = 1;
					if (S6TnkIQbwcOuoGedeY7c == null)
					{
						continue;
					}
					goto IL_028e;
				case 3:
					goto IL_04a2;
				case 2:
					Register(new RegexExtractStep());
					Register(new StringReplaceStep());
					Register(new FormatStringStep());
					Register(new JsonExtractStep());
					Register(new PathExtractionStep());
					Register(new GetFolderPathStep());
					Register(new TextCounterStep());
					Register(new ReadQRcodeStep());
					Register(new ImageProcessStep());
					Register(new CreateQRCodeStep());
					goto case 14;
				default:
					Register(new StrCompareStep());
					Register(new HttpStep());
					Register(new afTGWWoXytUImX5ZUwY());
					Register(new ImeControlStep());
					Register(new SmtpStep());
					Register(new TempCloudStoreStep());
					Register(new DownloadStep());
					Register(new OcrStep());
					Register(new CloudDataStep());
					Register(new H4rLbTXtxuZjM4Su8vo());
					Register(new hMYYmPXIAAyQLfLiDb6());
					Register(new rVFHuDohYFJjqSXkusO());
					num2 = 8;
					if (tB8N1kQbTbQZlbA9OdGf())
					{
						continue;
					}
					goto IL_028e;
				case 1:
					Register(new ShellOperationStep());
					Register(new TextToolsStep());
					Register(new ShowMenuStep());
					Register(new QFB8sioH69rXvIExprT());
					return;
				}
				break;
			}
			continue;
			IL_028e:
			num2 = num;
			goto IL_0022;
		}
	}

	public static IList<IStepRunner> GetAllRunners()
	{
		return y7atDdMgGR7.Values.ToList();
	}

	public static IStepRunner GetRunner(string key)
	{
		if (!y7atDdMgGR7.ContainsKey(key))
		{
			return null;
		}
		return y7atDdMgGR7[key];
	}

	internal static bool tB8N1kQbTbQZlbA9OdGf()
	{
		return S6TnkIQbwcOuoGedeY7c == null;
	}
}
