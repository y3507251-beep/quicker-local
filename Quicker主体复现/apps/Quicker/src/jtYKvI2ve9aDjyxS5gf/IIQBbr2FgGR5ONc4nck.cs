using System.Collections.Generic;
using System.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using eGw6fHYzCMTEO3Dvtqx;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Vm;
using Quicker.Modules.OCR;
using Quicker.Public.Extensions;

namespace jtYKvI2ve9aDjyxS5gf;

internal class IIQBbr2FgGR5ONc4nck
{



	private static HohpaZYaB62F359dDI0 Ib9tySk1iWO;

	private static readonly ILog eSpty2tYtHZ;

	private static IIQBbr2FgGR5ONc4nck TKawEJQDTY3EILkyW4d8;

	public static async Task<PaddleOcrResult> tEttyL66DUb(Image image_0, string string_0 = "")
	{
		var detected = await tQy5b4MZR11HLf8vRkW.KJPvclMRZwxyLnfknnp.HuwLFF3cvkN(image_0, string.IsNullOrWhiteSpace(string_0) ? null : string_0).ConfigureAwait(false);
		if (detected == null) throw new InvalidOperationException("本地 OCR 没有返回结果，请检查 Windows OCR 语言组件。");
		return new PaddleOcrResult
		{
		    IsSuccess = true,
		    Message = "使用本机 Windows OCR。",
		    Result = new PaddleOcrResult.ResultItem
		    {
		        Lines = string.Join(Environment.NewLine, detected.Lines.Select(line => line.Text)),
		        Regions = detected.Lines.SelectMany(line => line.Words).Select(word => new PaddleOcrResult.Region
		        {
		            Text = word.Text,
		            // Windows OCR 不提供置信度；NaN 表示不可用，不能伪造分数。
		            Confidence = double.NaN,
		            Rect = new PaddleOcrResult.Rect { Left = (int)word.BoundingRect.Left, Top = (int)word.BoundingRect.Top,
		                Right = (int)word.BoundingRect.Right, Bottom = (int)word.BoundingRect.Bottom }
		        }).ToList()
		    }
		};
	}

	public static Task<ApiResult<TableOcrResult>> R8TtyvnIAjG(string string_0)
	{
		return Task.FromResult(ApiResult<TableOcrResult>.Error("原厂表格 OCR 已删除，请使用本地识别工具。"));
	}

	static IIQBbr2FgGR5ONc4nck()
	{
		Ib9tySk1iWO = new HohpaZYaB62F359dDI0(10, 2, 200, 1000);
		eSpty2tYtHZ = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool HqARsDQDmmMVcoVmG6CH()
	{
		return TKawEJQDTY3EILkyW4d8 == null;
	}

	internal static void yTyFdgQDC5Hcri9wxlQS()
	{
	}
}
