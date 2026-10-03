using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities.Texting;
using Wsfly.Framework.Handler.Math;
using Z.Expressions;

namespace Quicker.Modules.Searching.Builtin;

public class ComputePlugin : SearchPlugin, IDisposable
{
	private EvalContext XOItPKainh1;

	[CompilerGenerated]
	private readonly SearchPluginSettings cHwtPxdRatD = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "="
			}
		},
		PluginId = "search.sys.other.compute",
		GlobalSearchWeight = 1.0,
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo Uf6tPrHVtRK = new PluginInfo
	{
		Name = "计算器",
		Description = "计算公式，如66*3/2.1",
		SearchContentName = "计算结果",
		Icon = "fa:Light_Calculator"
	};

	[CompilerGenerated]
	private readonly string R2itPpdEJps = "Light_Calculator";

	[CompilerGenerated]
	private readonly SearchResultOperationType PfLtPB5qjF5 = SearchResultOperationType.Copy;

	[CompilerGenerated]
	private readonly SearchResultOperationType ma9tPQmyPhm = SearchResultOperationType.PasteTo;

	internal static ComputePlugin uf8xHpQj1RXN3TdqUgPP;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return cHwtPxdRatD;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return Uf6tPrHVtRK;
		}
	}

	public override string Id => "search.sys.other.compute";

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return R2itPpdEJps;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return PfLtPB5qjF5;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return ma9tPQmyPhm;
		}
	}

	private EvalContext CEatP1YqEtS()
	{
		if (XOItPKainh1 == null)
		{
			XOItPKainh1 = new EvalContext();
			XOItPKainh1.SafeMode = true;
			XOItPKainh1.UnregisterAll();
			XOItPKainh1.RegisterDefaultAliasSafe();
			XOItPKainh1.DefaultNumberType = DefaultNumberType.Double;
			XOItPKainh1.RegisterStaticMember(typeof(Math));
			XOItPKainh1.UseCache = false;
			int num = 0;
			if (!RM1kt1QjK9NjLYA3psVy())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			XOItPKainh1.UseLocalCache = false;
		}
		return XOItPKainh1;
	}

	private object yUdtPbm34sf(string string_1)
	{
		try
		{
			object obj = CEatP1YqEtS().Execute(string_1);
			if (obj is double double_)
			{
				obj = pWRtP67lV01(double_);
			}
			return obj;
		}
		catch (Exception)
		{
			throw;
		}
	}

	private double pWRtP67lV01(double double_0)
	{
		return double.Parse(double_0.ToString("N6"));
	}

	public override void ProcessResult(SearchResultItem resultItem, QueryContext context)
	{
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext, CancellationToken cancellationToken)
	{
		IList<SearchResultItem> list = new List<SearchResultItem>();
		if (!string.IsNullOrEmpty(queryContext.Search) && !queryContext.Search.EndsWithAny(false, ".", "("))
		{
			try
			{
				object obj = null;
				int int_ = 950;
				if (queryContext.Search.Equals("0x", StringComparison.OrdinalIgnoreCase))
				{
					return list;
				}
				if (double.TryParse(queryContext.Search, out var result))
				{
					if (long.TryParse(queryContext.Search, out var result2))
					{
						lN5tPm8ICgq(result2, list, ref int_);
						if (Regex.IsMatch(queryContext.Search, "^[01]+$"))
						{
							result2 = Convert.ToInt64(queryContext.Search, 2);
							int_ -= 10;
							list.Add(new SearchResultItem
							{
								Title = result2.ToString(),
								Description = "二进制转换为十进制",
								Icon = "fa:Light_Calculator:#0099AA",
								Score = int_--,
								Tag = result2,
								TextData = result2.ToString(),
								TextDataType = "text"
							});
							string text = "0x" + result2.ToString("X");
							list.Add(new SearchResultItem
							{
								Title = text,
								Description = "二进制转换为十六进制",
								Icon = "fa:Light_Calculator:#0099AA",
								Score = int_--,
								TextData = text,
								TextDataType = "text"
							});
						}
					}
					YQYtPXkIO2u(result, ref int_, list);
					return list;
				}
				if (obj == null)
				{
					obj = yUdtPbm34sf(queryContext.Search);
				}
				if (obj != null)
				{
					list.Add(new SearchResultItem
					{
						Title = obj.ToString(),
						Description = obj.GetType().ToString(),
						Icon = "fa:Light_Calculator:#0099AA",
						Score = int_--,
						Tag = obj,
						TextData = obj.ToString(),
						TextDataType = "text"
					});
					if (obj is double num)
					{
						if (!queryContext.Search.Contains("."))
						{
							lN5tPm8ICgq((long)num, list, ref int_);
						}
						YQYtPXkIO2u(num, ref int_, list);
					}
				}
			}
			catch
			{
				return list;
			}
			return list;
		}
		return list;
	}

	private static void YQYtPXkIO2u(double double_0, ref int int_0, IList<SearchResultItem> ilist_0)
	{
		int_0 -= 10;
		string text = NumberConventer.ArabToChn(Convert.ToDecimal(double_0), out var msg);
		ilist_0.Add(new SearchResultItem
		{
			Title = text,
			Description = "大写",
			Icon = "fa:Light_Calculator:#0099AA",
			Score = int_0--,
			TextData = text,
			TextDataType = "text"
		});
		text = InternalTextProcessor.LItLOPdR3bN(double_0);
		ilist_0.Add(new SearchResultItem
		{
			Title = text,
			Description = "金额",
			Icon = "fa:Light_Calculator:#0099AA",
			Score = int_0--,
			TextData = text,
			TextDataType = "text"
		});
	}

	private static void lN5tPm8ICgq(long long_0, IList<SearchResultItem> ilist_0, ref int int_0)
	{
		string text = "0x" + long_0.ToString("X");
		ilist_0.Add(new SearchResultItem
		{
			Title = text,
			Description = "16进制",
			Icon = "fa:Light_Calculator:#0099AA",
			Score = int_0--,
			TextData = text,
			TextDataType = "text"
		});
		string text2 = Convert.ToString(long_0, 2);
		ilist_0.Add(new SearchResultItem
		{
			Title = text2,
			Description = "二进制",
			Icon = "fa:Light_Calculator:#0099AA",
			Score = int_0--,
			TextData = text2,
			TextDataType = "text"
		});
	}

	public void Dispose()
	{
		XOItPKainh1?.Dispose();
	}

	internal static bool RM1kt1QjK9NjLYA3psVy()
	{
		return uf8xHpQj1RXN3TdqUgPP == null;
	}
}
