using System;
using System.Collections.Generic;
using System.Reflection;
using CSScriptLibrary;
using eV7UJbXOdrPLKxjLbli;
using Quicker.Domain.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace C2upcwoPZZhs1EfA15V;

internal class KpQc1Fo9vVSbWFx7GcL
{
	internal static KpQc1Fo9vVSbWFx7GcL oETDdCQ7d69dIAjd9XTD;

	internal static Assembly sR3gm03BPA4(string string_0, string string_1, bool bool_0, ActionExecuteContext actionExecuteContext_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		Assembly assembly = null;
		IList<Assembly> list = new List<Assembly>();
		if (bool_0)
		{
			string text = doH059XnuXRn8NRZyFk.uO7gZckltxx(string_0);
			if (!string.IsNullOrWhiteSpace(text))
			{
				try
				{
					actionExecuteContext_0?.ActionLogger.LogInfo("使用缓存的程序集");
					if (!string.IsNullOrEmpty(string_1))
					{
						string[] array = string_1.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
						if (DrdNGFQ7OQaakIKKCNGK())
						{
							switch (0)
							{
							}
						}
						foreach (string text2 in array)
						{
							list.Add(Assembly.LoadFrom(text2.Trim()));
						}
					}
					assembly = Assembly.LoadFrom(text);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("加载Assembly出错：" + exception.GetMessageWithInner());
				}
			}
		}
		int num2 = default(int);
		while (assembly == null)
		{
			CSScript.CacheEnabled = true;
			CSScript.EnableScriptLocationReflection = true;
			CSScript.EvaluatorConfig.Engine = EvaluatorEngine.CodeDom;
			IEvaluator evaluator = CSScript.Evaluator;
			int num = 0;
			if (oETDdCQ7d69dIAjd9XTD != null)
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			evaluator.ReferenceAssembly(Assembly.GetExecutingAssembly()).ReferenceAssemblyOf<string>().ReferenceAssemblyByName("System.Runtime")
				.ReferenceAssembliesFromCode(string_0);
			if (!string.IsNullOrEmpty(string_1))
			{
				string[] array = string_1.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text3 in array)
				{
					evaluator.ReferenceAssembly(Assembly.LoadFrom(text3.Trim()));
				}
			}
			assembly = evaluator.CompileMethod(string_0);
			if (bool_0)
			{
				string originalLocation = assembly.GetOriginalLocation();
				doH059XnuXRn8NRZyFk.rMEgZV7dwv2(string_0, originalLocation);
			}
			break;
		}
		return assembly;
	}

	static KpQc1Fo9vVSbWFx7GcL()
	{
	}

	internal static bool DrdNGFQ7OQaakIKKCNGK()
	{
		return oETDdCQ7d69dIAjd9XTD == null;
	}

	internal static void nFnifcQ79yyH4EZAEBKj()
	{
	}
}
