using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Public.Interfaces;
using Quicker.Public.Interfaces.Api;
using Quicker.Utilities;
using uiPmvNAoCVm0Oaatufp;
using Z.Expressions;

namespace Quicker.Api;

public class QuickerApi : IQuickerApi
{
	private static readonly ILog Vv4QiJ0Fhk;

	[CompilerGenerated]
	private static readonly QuickerApi SdqQ3ghI1W;

	[CompilerGenerated]
	private readonly ITextApi cteQfUJ3Ul = new I8rKbvAXLQgK0Nv1Mp0();

	private static QuickerApi gsXpy1tHNfFa4Mncavy;

	public static QuickerApi Instance
	{
		[CompilerGenerated]
		get
		{
			return SdqQ3ghI1W;
		}
	}

	public ITextApi Text
	{
		[CompilerGenerated]
		get
		{
			return cteQfUJ3Ul;
		}
	}

	public string Version => AppHelper.GetSoftVersion();

	private QuickerApi()
	{
	}

	public void RegisterNamespace(EvalContext eval, Assembly assembly, string ns)
	{
		try
		{
			eval.RegisterNamespace(assembly, ns);
		}
		catch (ReflectionTypeLoadException ex)
		{
			Exception[] loaderExceptions = ex.LoaderExceptions;
			int num2 = default(int);
			foreach (Exception ex2 in loaderExceptions)
			{
				if (ex2 is FileLoadException ex3)
				{
					Vv4QiJ0Fhk.Warn("加载文件异常：" + ex2.Message + " " + ex3.FileName + " " + ex3.InnerException?.Message + " " + ex3.InnerException?.StackTrace);
				}
				else
				{
					Vv4QiJ0Fhk.Warn("未知异常：" + ex2.Message);
					int num = 0;
					if (gsXpy1tHNfFa4Mncavy != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
		}
		catch (Exception ex4)
		{
			throw ex4;
		}
	}

	static QuickerApi()
	{
		Vv4QiJ0Fhk = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		SdqQ3ghI1W = new QuickerApi();
	}

	internal static void UW0dZLSQvVnPM31F3rX()
	{
	}

	internal static bool EqYnCOtz0CsBSsoeQ3L()
	{
		return gsXpy1tHNfFa4Mncavy == null;
	}
}
