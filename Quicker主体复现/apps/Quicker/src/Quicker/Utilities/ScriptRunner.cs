using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using l9W6KWifMfNKrInJR4l;
using log4net;
using Quicker.Domain;
using Quicker.Public.Extensions;

namespace Quicker.Utilities;

public class ScriptRunner
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public StringBuilder S0g2wlhnZaI;

		public StringBuilder SwP2wi31X6b;

		public StringBuilder PvF2w3K0GI1;

		internal static _003C_003Ec__DisplayClass28_0 LQAuLyyeB8TCWPWV9aab;

		internal void QhR2wFioV9L(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				S0g2wlhnZaI.AppendLine(e.Data);
				SwP2wi31X6b.AppendLine(e.Data);
			}
		}

		internal void X352wUhsEKq(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				PvF2w3K0GI1.AppendLine(e.Data);
				SwP2wi31X6b.AppendLine(e.Data);
			}
		}

		internal static bool fL7f3hyevT4eXBGmPuUk()
		{
			return LQAuLyyeB8TCWPWV9aab == null;
		}
	}

	private static readonly ILog WbfLTqN3mtm;

	private readonly string wW1LTcXTnfN;

	private readonly string RbCLTVgjGvr;

	private readonly string YdhLTZUsu6n;

	private readonly string CHMLT9f31GW;

	private readonly bool CdELTh3rftk;

	private readonly bool WbhLTeCvDpB;

	private readonly bool tmsLTYjZP66;

	private readonly Encoding CyOLTIiFFS3;

	private readonly string HPRLTWDgdB2;

	private readonly string nLBLTkBJp5a;

	private readonly string bNOLTGMovxk;

	private readonly int xUnLTsN1C4r;

	private readonly string QJ9LTH0BLiC;

	public const string CMD_K = "CMD_K";

	public const string CMD_C = "CMD_C";

	public const string CMD_H = "CMD_H";

	public const string BAT_FILE = "BAT";

	public const string CMD_FILE = "CMD_F";

	public const string POWERSHELL = "PS";

	public const string AHK_FILE = "AHK";

	public const string CUSTOM_FILE = "CUSTOM";

	public const string OUTPUT_ENCODING_UTF8 = "utf8";

	public const string OUTPUT_ENCODING_OEM = "oem";

	public const string OUTPUT_ENCODING_DEFAULT = "";

	[CompilerGenerated]
	private string s3GLT1alQKN;

	internal static ScriptRunner uBkVvUF8F6DiLW53osqY;

	public string ScriptFile
	{
		[CompilerGenerated]
		get
		{
			return s3GLT1alQKN;
		}
		[CompilerGenerated]
		set
		{
			s3GLT1alQKN = value;
		}
	}

	public ScriptRunner(string script, string scriptType, string ext, string runner, bool asAdmin, bool waitToExit, bool clearTempFile, Encoding fileEncoding, string workingDir, string outputEncoding, string template = "%FILE%", int timeout = 36000000, string actionName = "")
	{
		wW1LTcXTnfN = script;
		RbCLTVgjGvr = scriptType;
		YdhLTZUsu6n = ext;
		CHMLT9f31GW = runner;
		CdELTh3rftk = asAdmin;
		WbhLTeCvDpB = waitToExit;
		tmsLTYjZP66 = clearTempFile;
		CyOLTIiFFS3 = fileEncoding;
		HPRLTWDgdB2 = workingDir;
		nLBLTkBJp5a = outputEncoding;
		bNOLTGMovxk = template;
		xUnLTsN1C4r = timeout;
		QJ9LTH0BLiC = actionName;
	}

	public ProcessResult Execute(bool captureStdOut)
	{
		if (!RbCLTVgjGvr.Equals("CMD_C", StringComparison.OrdinalIgnoreCase) && !RbCLTVgjGvr.Equals("CMD_K", StringComparison.OrdinalIgnoreCase) && !RbCLTVgjGvr.Equals("CMD_H", StringComparison.OrdinalIgnoreCase))
		{
			return WfVLTyZR7dO(captureStdOut);
		}
		return XWKLTCj2qYM(captureStdOut);
	}

	private ProcessResult XWKLTCj2qYM(bool bool_3)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		if (CdELTh3rftk)
		{
			processStartInfo.Verb = "runas";
		}
		processStartInfo.WorkingDirectory = GetWorkingDir();
		int num;
		if (RbCLTVgjGvr.Equals("CMD_H", StringComparison.OrdinalIgnoreCase) || bool_3)
		{
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			if (wW1LTcXTnfN.Contains("\n"))
			{
				goto IL_00a9;
			}
			num = 1;
			if (uBkVvUF8F6DiLW53osqY == null)
			{
				goto IL_0085;
			}
			goto IL_00d2;
		}
		if (!wW1LTcXTnfN.Contains("\n") && wW1LTcXTnfN.StartsWith("\""))
		{
			processStartInfo.Arguments = "/S " + (RbCLTVgjGvr.Equals("CMD_C", StringComparison.OrdinalIgnoreCase) ? "/C " : "/K ") + " \"" + wW1LTcXTnfN + "\"";
		}
		else
		{
			processStartInfo.Arguments = (RbCLTVgjGvr.Equals("CMD_C", StringComparison.OrdinalIgnoreCase) ? "/C " : "/K  ") + V6eLT839vUp(wW1LTcXTnfN);
		}
		goto IL_01aa;
		IL_01aa:
		return fLJLTP0sc14(bool_3, processStartInfo);
		IL_00d2:
		int num2 = default(int);
		num = num2;
		goto IL_0085;
		IL_0085:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_01aa;
		}
		if (!wW1LTcXTnfN.StartsWith("\""))
		{
			goto IL_00a9;
		}
		processStartInfo.Arguments = "/S /C \"" + wW1LTcXTnfN + "\"";
		goto IL_01aa;
		IL_00a9:
		processStartInfo.Arguments = "/C " + V6eLT839vUp(wW1LTcXTnfN);
		num = 0;
		if (uBkVvUF8F6DiLW53osqY == null)
		{
			goto IL_0085;
		}
		goto IL_00d2;
	}

	private ProcessResult fLJLTP0sc14(bool bool_3, ProcessStartInfo processStartInfo_0)
	{
		ProcessResult result;
		if (!bool_3)
		{
			using Process process = new Process();
			try
			{
				process.StartInfo = processStartInfo_0;
				process.Start();
				int exitCode = 0;
				if (WbhLTeCvDpB)
				{
					process.WaitForExit();
					if (!KPRZutF8cdDcgUAjSmVl())
					{
						switch (0)
						{
						}
					}
					exitCode = process?.ExitCode ?? 0;
				}
				result = new ProcessResult
				{
					Pid = process.Id,
					ExitCode = exitCode,
					StdOut = "",
					StdError = ""
				};
			}
			catch (Exception ex)
			{
				WbfLTqN3mtm.Warn("执行进程出错,FileName=" + processStartInfo_0.FileName + " Arguments=" + processStartInfo_0.Arguments + " 错误：" + ex.Message, ex);
				throw;
			}
		}
		else
		{
			_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
			processStartInfo_0.UseShellExecute = false;
			processStartInfo_0.CreateNoWindow = true;
			int num = 0;
			if (uBkVvUF8F6DiLW53osqY != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			fZBLTEb63Cg(processStartInfo_0);
			processStartInfo_0.RedirectStandardError = true;
			processStartInfo_0.RedirectStandardOutput = true;
			fZBLTEb63Cg(processStartInfo_0);
			_003C_003Ec__DisplayClass28_.S0g2wlhnZaI = new StringBuilder();
			_003C_003Ec__DisplayClass28_.PvF2w3K0GI1 = new StringBuilder();
			_003C_003Ec__DisplayClass28_.SwP2wi31X6b = new StringBuilder();
			using Process process2 = new Process();
			process2.StartInfo = processStartInfo_0;
			ProcessResult processResult = new ProcessResult();
			try
			{
				process2.OutputDataReceived += _003C_003Ec__DisplayClass28_.QhR2wFioV9L;
				process2.ErrorDataReceived += _003C_003Ec__DisplayClass28_.X352wUhsEKq;
				process2.Start();
				process2.BeginOutputReadLine();
				process2.BeginErrorReadLine();
				if (process2.WaitForExit(xUnLTsN1C4r))
				{
					Thread.Sleep(10);
					if (uBkVvUF8F6DiLW53osqY == null)
					{
						switch (0)
						{
						}
					}
					processResult.ExitCode = process2.ExitCode;
				}
				else
				{
					WbfLTqN3mtm.Warn("执行进程出错超时了,FileName=" + processStartInfo_0.FileName + " Arguments=" + processStartInfo_0.Arguments + " ");
				}
			}
			catch (Exception ex2)
			{
				WbfLTqN3mtm.Warn("执行进程出错,FileName=" + processStartInfo_0.FileName + " Arguments=" + processStartInfo_0.Arguments + " 错误：" + ex2.Message, ex2);
				throw;
			}
			finally
			{
				process2.OutputDataReceived -= _003C_003Ec__DisplayClass28_.QhR2wFioV9L;
				process2.ErrorDataReceived -= _003C_003Ec__DisplayClass28_.X352wUhsEKq;
			}
			processResult.Pid = process2.Id;
			processResult.StdOut = _003C_003Ec__DisplayClass28_.S0g2wlhnZaI.ToString();
			processResult.StdError = _003C_003Ec__DisplayClass28_.PvF2w3K0GI1.ToString();
			processResult.StdOutMerged = processResult.StdOut.Or(processResult.StdError);
			processResult.ExitCode = process2.ExitCode;
			result = processResult;
			int num3 = 0;
			if (!KPRZutF8cdDcgUAjSmVl())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		return result;
	}

	private void fZBLTEb63Cg(ProcessStartInfo processStartInfo_0)
	{
		if (nLBLTkBJp5a == "utf8")
		{
			processStartInfo_0.StandardOutputEncoding = Encoding.UTF8;
			processStartInfo_0.StandardErrorEncoding = Encoding.UTF8;
		}
		else
		{
			processStartInfo_0.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
			processStartInfo_0.StandardErrorEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
		}
	}

	private ProcessResult WfVLTyZR7dO(bool bool_3)
	{
		string text = (ScriptFile = hxXLTRpxfHL(wW1LTcXTnfN, CyOLTIiFFS3, cCgLTajZE06(), QJ9LTH0BLiC));
		if (!File.Exists(text))
		{
			File.WriteAllText(text, wW1LTcXTnfN, CyOLTIiFFS3);
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		if (CdELTh3rftk)
		{
			processStartInfo.Verb = "runas";
		}
		processStartInfo.WorkingDirectory = GetWorkingDir();
		int num;
		if (text.EndsWith(".ps1", StringComparison.OrdinalIgnoreCase) && string.IsNullOrWhiteSpace(CHMLT9f31GW))
		{
			num = 0;
			if (!KPRZutF8cdDcgUAjSmVl())
			{
				goto IL_00e5;
			}
		}
		else
		{
			if (!string.IsNullOrEmpty(CHMLT9f31GW))
			{
				processStartInfo.FileName = CHMLT9f31GW;
				string arguments = bNOLTGMovxk.Replace("%FILE%", text);
				processStartInfo.Arguments = arguments;
				goto IL_014e;
			}
			processStartInfo.FileName = text;
			num = 1;
			if (!KPRZutF8cdDcgUAjSmVl())
			{
				goto IL_00e5;
			}
		}
		goto IL_00e9;
		IL_00e5:
		int num2 = default(int);
		num = num2;
		goto IL_00e9;
		IL_00e9:
		switch (num)
		{
		default:
		{
			string text3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "powershell", "7", "pwsh.exe");
			if (!File.Exists(text3))
			{
				text3 = "powershell.exe";
			}
			processStartInfo.FileName = text3;
			processStartInfo.Arguments = "-NoProfile -ExecutionPolicy Unrestricted  -File \"" + text + "\" ";
			return fLJLTP0sc14(bool_3, processStartInfo);
		}
		case 1:
			break;
		}
		goto IL_014e;
		IL_014e:
		return fLJLTP0sc14(bool_3, processStartInfo);
	}

	private static string V6eLT839vUp(string string_9)
	{
		StringBuilder stringBuilder = new StringBuilder(string_9.Length + 10);
		bool flag;
		if (flag = !string_9.Contains("\""))
		{
			stringBuilder.Append('"');
		}
		string[] array = string_9.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
		string[] array2 = array;
		int num3 = default(int);
		foreach (string text in array2)
		{
			string text2 = text.Trim();
			if (text2.StartsWith("::", StringComparison.OrdinalIgnoreCase) || text2.StartsWith("rem ", StringComparison.OrdinalIgnoreCase) || text2 == "rem")
			{
				continue;
			}
			int num = text.LastIndexOf("::", StringComparison.OrdinalIgnoreCase);
			int num2 = 1;
			if (uBkVvUF8F6DiLW53osqY != null)
			{
				goto IL_0101;
			}
			goto IL_0105;
			IL_0105:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num < 0)
					{
						num = text.LastIndexOf(" rem ", StringComparison.OrdinalIgnoreCase);
					}
					if (num > 0)
					{
						text2 = text.Substring(0, num);
					}
					stringBuilder.Append(text2);
					if (!(text != array[array.Length - (1)]))
					{
						break;
					}
					goto IL_00f4;
				default:
					stringBuilder.Append(" && ");
					break;
				}
				break;
				IL_00f4:
				num2 = 0;
				if (uBkVvUF8F6DiLW53osqY == null)
				{
					continue;
				}
				goto IL_0101;
			}
			continue;
			IL_0101:
			num2 = num3;
			goto IL_0105;
		}
		if (flag)
		{
			stringBuilder.Append('"');
		}
		return stringBuilder.ToString();
	}

	private string cCgLTajZE06()
	{
		switch (RbCLTVgjGvr.ToUpperInvariant())
		{
		default:
			return YdhLTZUsu6n;
		case "CUSTOM":
			if (!YdhLTZUsu6n.StartsWith("."))
			{
				return "." + YdhLTZUsu6n;
			}
			return YdhLTZUsu6n;
		case "PS":
			return ".ps1";
		case "AHK":
			return ".ahk";
		case "BAT":
			return ".bat";
		case "CMD_F":
			return ".cmd";
		}
	}

	private static string Pf6LT7HsfPj(string string_9)
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		return BitConverter.ToString(sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(string_9))).Replace("-", "").ToUpperInvariant();
	}

	private static string hxXLTRpxfHL(string string_9, Encoding encoding_1, string string_10, string string_11)
	{
		string text = Pf6LT7HsfPj(string_9 + encoding_1.EncodingName);
		string path = "quicker-" + AppHelper.RemoveInvalidCharsFromFileName(string_11).Replace(" ", "").Replace("\t", "") + "-" + text + string_10;
		return Path.Combine(Path.GetTempPath(), path);
	}

	public string GetWorkingDir()
	{
		if (!string.IsNullOrEmpty(HPRLTWDgdB2))
		{
			if (Directory.Exists(HPRLTWDgdB2))
			{
				return HPRLTWDgdB2;
			}
			AppHelper.ShowWarning("指定的工作目录不存在。" + HPRLTWDgdB2);
		}
		try
		{
			return ytnqhyiMNhGmytDmEj7.GvXvtJLyniF(AppState.r4itaWBnyVQ().ForegroundWindowHwnd);
		}
		catch (Exception)
		{
		}
		return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
	}

	static ScriptRunner()
	{
		WbfLTqN3mtm = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static void jea65qF8yDTl4b9XjgUr()
	{
	}

	internal static bool KPRZutF8cdDcgUAjSmVl()
	{
		return uBkVvUF8F6DiLW53osqY == null;
	}
}
