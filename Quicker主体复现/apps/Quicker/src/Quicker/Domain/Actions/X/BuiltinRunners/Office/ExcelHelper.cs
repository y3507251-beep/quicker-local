using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Office;

public static class ExcelHelper
{
	[CompilerGenerated]
	private static class _003C_003Eo__0
	{
		public static CallSite<Func<CallSite, object, Worksheet>> U9gSNBehGhH;
	}

	internal static object e6Z4efQMcu4kb1SxeUYf;

	public static Worksheet GetActiveSheet()
	{
		Application obj = ((Application)Marshal.GetActiveObject("Excel.Application")) ?? throw new InvalidOperationException("未找到打开的Excel文档");
		obj.Visible = true;
		Workbook activeWorkbook = obj.ActiveWorkbook;
		return (Worksheet)(dynamic)activeWorkbook.ActiveSheet;
	}

	public static Workbook GetActiveWorkbook()
	{
		Application obj = ((Application)Marshal.GetActiveObject("Excel.Application")) ?? throw new InvalidOperationException("未找到打开的Excel文档");
		obj.Visible = true;
		return obj.ActiveWorkbook;
	}

	public static Workbook GetWorkbookByName(string name)
	{
		Application application = (Application)Marshal.GetActiveObject("Excel.Application");
		if (application == null)
		{
			throw new InvalidOperationException("未找到打开的Excel文档");
		}
		application.Visible = true;
		if (string.IsNullOrWhiteSpace(name))
		{
			return application.ActiveWorkbook;
		}
		return application.Workbooks[name];
	}

	public static Range GetActiveCell()
	{
		Application application = (Application)Marshal.GetActiveObject("Excel.Application");
		if (application == null)
		{
			throw new InvalidOperationException("未找到打开的Excel文档");
		}
		return application.ActiveCell;
	}

	public static Range GetActiveRange()
	{
		return (((Application)Marshal.GetActiveObject("Excel.Application")) ?? throw new InvalidOperationException("未找到打开的Excel文档")).ActiveWindow.RangeSelection;
	}

	internal static bool haGUyOQMWiuOc4vBbbMD()
	{
		return e6Z4efQMcu4kb1SxeUYf == null;
	}
}
