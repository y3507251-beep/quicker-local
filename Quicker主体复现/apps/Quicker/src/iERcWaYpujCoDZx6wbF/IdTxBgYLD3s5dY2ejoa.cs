using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using log4net;
using Microsoft.CodeAnalysis;
using Quicker.Domain.Actions;
using Quicker.Public;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Texting;
using Quicker.Utilities.Win32;
using Westwind.Scripting;

namespace iERcWaYpujCoDZx6wbF;

internal class IdTxBgYLD3s5dY2ejoa
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec q5hSzSEk2Mn;

		public static Func<PortableExecutableReference, string> XuvSz2UbwkZ;

		public static Func<PortableExecutableReference, string> o0nSzuMWenN;

		private static _003C_003Ec neVafRyA8QO0UuPRjg2i;

		static _003C_003Ec()
		{
			q5hSzSEk2Mn = new _003C_003Ec();
		}

		internal string qd9SzLYRdAr(PortableExecutableReference x)
		{
			return x.FilePath;
		}

		internal string LuhSzvORe9N(PortableExecutableReference x)
		{
			return x.FilePath;
		}

		internal static bool Ydf6GCyARweGVe4kG3oq()
		{
			return neVafRyA8QO0UuPRjg2i == null;
		}
	}

	private static readonly ILog qrqLDRy19Qn;

	internal static IdTxBgYLD3s5dY2ejoa PmhhrlFlYJU6jU44jMeb;

	internal static Assembly iR5LD03dxXY(string string_0, string string_1, ActionExecuteContext actionExecuteContext_0)
	{
		string text = QM3LD8lkDO6(string_0, string_1, true);
		uD4LDPjZaOX(string_1);
		if (File.Exists(text))
		{
			actionExecuteContext_0?.ActionLogger.LogInfo("使用缓存的程序集:" + text);
			try
			{
				return hFELDCVVkIV(text);
			}
			catch (Exception)
			{
				File.Delete(text);
			}
		}
		return h2KLDEXTK5f(string_0, string_1, text);
	}

	private static Assembly hFELDCVVkIV(string string_0)
	{
		try
		{
			return Assembly.LoadFrom(string_0);
		}
		catch
		{
			return Assembly.Load(string_0);
		}
	}

	private static void uD4LDPjZaOX(string string_0)
	{
		int num = 1;
		while (string.IsNullOrEmpty(string_0))
		{
			int num2 = 0;
			if (!sfkoalFl8eYVP91UchE6())
			{
				num2 = num;
			}
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
		}
		string[] array = string_0.SplitToList();
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim(' ', ';');
			if (File.Exists(text))
			{
				try
				{
					hFELDCVVkIV(text);
				}
				catch (Exception ex)
				{
					qrqLDRy19Qn.Warn("加载" + text + "出错：" + ex.Message);
				}
			}
		}
	}

	private static Assembly h2KLDEXTK5f(string string_0, string string_1, string string_2)
	{
		CSharpScriptExecution cSharpScriptExecution = new CSharpScriptExecution
		{
			SaveGeneratedCode = true
		};
		cSharpScriptExecution.AddDefaultReferencesAndNamespaces();
		cSharpScriptExecution.AddLoadedReferences();
		cSharpScriptExecution.AddAssembly(typeof(StepContext));
		int num = 1;
		string[] array = default(string[]);
		int i = default(int);
		if (PmhhrlFlYJU6jU44jMeb == null)
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					array = string_1.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
					i = 0;
					num = 0;
					if (PmhhrlFlYJU6jU44jMeb != null)
					{
						num = num2;
					}
					continue;
				}
				break;
			}
		}
		for (; i < array.Length; i++)
		{
			string text = array[i];
			if (!text.StartsWith("//"))
			{
				if (!File.Exists(text) && File.Exists(Path.Combine(AppHelper.GetAppFolder(), text)))
				{
					cSharpScriptExecution.AddAssembly(Path.Combine(AppHelper.GetAppFolder(), text));
				}
				else
				{
					cSharpScriptExecution.AddAssembly(text.Trim());
				}
			}
		}
		cSharpScriptExecution.OutputAssembly = string_2;
		FileSystemHelper.EnsureFileFolderExists(string_2);
		if (!cSharpScriptExecution.CompileAssemblyForExecuteMethod(string_0))
		{
			try
			{
				if (File.Exists(string_2))
				{
					File.Delete(string_2);
				}
			}
			catch (Exception)
			{
			}
			throw new Exception(string.Format("编译失败, {0}, {1} \r\n代码：{2}\r\n当前引用：{3}", cSharpScriptExecution.ErrorType, cSharpScriptExecution.ErrorMessage, cSharpScriptExecution.GeneratedClassCodeWithLineNumbers, string.Join("\r\n", cSharpScriptExecution.References.OrderBy(_003C_003Ec.XuvSz2UbwkZ ?? (_003C_003Ec.XuvSz2UbwkZ = _003C_003Ec.q5hSzSEk2Mn.qd9SzLYRdAr)).Select(_003C_003Ec.o0nSzuMWenN ?? (_003C_003Ec.o0nSzuMWenN = _003C_003Ec.q5hSzSEk2Mn.LuhSzvORe9N)))));
		}
		return Assembly.LoadFrom(string_2);
	}

	private static string cHnLDynMNUt(CSharpScriptExecution csharpScriptExecution_0)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".txt");
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"错误类型：{csharpScriptExecution_0.ErrorType}");
		if (!sfkoalFl8eYVP91UchE6())
		{
			switch (0)
			{
			}
		}
		stringBuilder.AppendLine("错误消息：" + csharpScriptExecution_0.ErrorMessage);
		stringBuilder.AppendLine("当前引用程序集：");
		foreach (PortableExecutableReference reference in csharpScriptExecution_0.References)
		{
			stringBuilder.AppendLine("  " + reference.FilePath);
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("代码：");
		stringBuilder.AppendLine(csharpScriptExecution_0.GeneratedClassCodeWithLineNumbers);
		File.WriteAllText(text, stringBuilder.ToString());
		return text;
	}

	private static string QM3LD8lkDO6(string string_0, string string_1, bool bool_0)
	{
		string path = InternalTextProcessor.ComputeMd5Hash(string_0 + string_1 + (bool_0 ? yL5LDayIB1m() : "")) + ".dll";
		return Path.Combine(Path.GetTempPath(), "quicker_cs", (!bool_0) ? "0" : yL5LDayIB1m(), path);
	}

	private static string yL5LDayIB1m()
	{
		return Assembly.GetExecutingAssembly().GetName().Version.ToString();
	}

	internal static Assembly EOeLD73MEQN(string string_0, string string_1, bool bool_0)
	{
		string text = QM3LD8lkDO6(string_0, string_1, bool_0);
		if (File.Exists(text))
		{
			try
			{
				return Assembly.LoadFrom(text);
			}
			catch (Exception)
			{
				File.Delete(text);
			}
		}
		int num2 = default(int);
		while (true)
		{
			CSharpScriptExecution cSharpScriptExecution = new CSharpScriptExecution
			{
				SaveGeneratedCode = true
			};
			cSharpScriptExecution.AddDefaultReferencesAndNamespaces();
			if (bool_0)
			{
				cSharpScriptExecution.AddLoadedReferences();
			}
			string[] array = string_1.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text2 in array)
			{
				if (!text2.StartsWith("//"))
				{
					if (!File.Exists(text2) && File.Exists(Path.Combine(AppHelper.GetAppFolder(), text2)))
					{
						cSharpScriptExecution.AddAssembly(Path.Combine(AppHelper.GetAppFolder(), text2));
					}
					else
					{
						cSharpScriptExecution.AddAssembly(text2.Trim());
					}
				}
			}
			cSharpScriptExecution.OutputAssembly = text;
			FileSystemHelper.EnsureFileFolderExists(text);
			int num = 0;
			if (!sfkoalFl8eYVP91UchE6())
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			if (!cSharpScriptExecution.CompileAssembly(string_0, true))
			{
				try
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
				}
				catch (Exception ex2)
				{
					qrqLDRy19Qn.Warn("加载：" + text + " 出错：" + ex2.Message);
				}
				throw new Exception(string.Format("编译失败, {0}, {1} \r\n代码：{2}\r\n当前引用：{3}", cSharpScriptExecution.ErrorType, cSharpScriptExecution.ErrorMessage, cSharpScriptExecution.GeneratedClassCodeWithLineNumbers, string.Join("\r\n", cSharpScriptExecution.References)));
			}
			return Assembly.LoadFrom(text);
		}
	}

	static IdTxBgYLD3s5dY2ejoa()
	{
		qrqLDRy19Qn = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool sfkoalFl8eYVP91UchE6()
	{
		return PmhhrlFlYJU6jU44jMeb == null;
	}
}
