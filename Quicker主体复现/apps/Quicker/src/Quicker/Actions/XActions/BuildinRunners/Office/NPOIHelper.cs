using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Extensions;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Actions.XActions.BuildinRunners.Office;

public static class NPOIHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec hV2SbGiC0fG;

		public static Func<string, string> iR9SbsnJ9eU;

		public static Func<string, string> hhTSbHVRi4E;

		public static Func<string, string> PViSb1gAXFO;

		public static Func<string, string> G5LSbbh7eAk;

		public static Func<string, bool> Y2RSb6S5VoY;

		public static Func<string, bool> l0ESbX7l808;

		public static Func<string, string> wKMSbmAKLfa;

		internal static _003C_003Ec wyQgRBWiH2WQbiK60cgC;

		static _003C_003Ec()
		{
			hV2SbGiC0fG = new _003C_003Ec();
		}

		internal string pswSb9xApNH(string x)
		{
			return x.Trim();
		}

		internal string gSrSbhwiWRG(string x)
		{
			return x.Trim();
		}

		internal string HUVSbechw47(string x)
		{
			return x.Trim();
		}

		internal string TIYSbYfr42g(string x)
		{
			return x.Trim();
		}

		internal bool wxjSbIebq3m(string x)
		{
			return !x.StartsWith("//");
		}

		internal bool OjJSbW5AD35(string x)
		{
			return x.StartsWith("font.", StringComparison.OrdinalIgnoreCase);
		}

		internal string NnBSbkKGUo4(string x)
		{
			return x.Substring("font.".Length);
		}

		internal static bool KWUUPpWizBkfIXxeicLZ()
		{
			return wyQgRBWiH2WQbiK60cgC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public bool mx5SbxRobut;

		public Action<string> kNwSbrZhphZ;

		public string dNaSbpV4bWx;

		internal static _003C_003Ec__DisplayClass20_0 WxLtnlWlQnCdmnQx9HVO;

		internal void Q2lSbK0agP9(string s)
		{
			if (mx5SbxRobut && string.IsNullOrEmpty(s))
			{
				return;
			}
			try
			{
				kNwSbrZhphZ(s);
			}
			catch (Exception exception)
			{
				throw new Exception("处理格式出错。行：" + dNaSbpV4bWx + " 错误：" + exception.GetMessageWithInner());
			}
		}

		internal static bool OpFnaGWlFvhMHkMCsj5w()
		{
			return WxLtnlWlQnCdmnQx9HVO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public XSSFCellStyle Wg2SbOTHOUD;

		public string ADESbFF2TxW;

		public Action<string> vvpSbU2LpmK;

		public Action<string> UT9Sbl6EtvP;

		public Action<string> AmlSbiUm83W;

		public Action<string> mn9Sb3HYlXn;

		public Action<string> HBwSbfGBrbL;

		public Action<string> iKaSbzh6yoB;

		public Action<string> ec3S6wvqSEK;

		public Action<string> FbGS6tF0NLN;

		public Action<string> TCVS6giufuX;

		public Action<string> gYSS6LsP0QF;

		public Action<string> u7bS6vRQwn7;

		public Action<string> Kt9S6SNAiKk;

		private static _003C_003Ec__DisplayClass23_0 tUBaLFWlWY38fyp7jEch;

		internal void POGSbBxVp51(string s)
		{
			(BorderStyle, XSSFColor) tuple = c6jgBW836PE(s);
			XSSFCellStyle xSSFCellStyle = Wg2SbOTHOUD;
			XSSFCellStyle xSSFCellStyle2 = Wg2SbOTHOUD;
			XSSFCellStyle xSSFCellStyle3 = Wg2SbOTHOUD;
			BorderStyle borderStyle = (Wg2SbOTHOUD.BorderBottom = tuple.Item1);
			BorderStyle borderStyle2 = (xSSFCellStyle3.BorderTop = borderStyle);
			BorderStyle borderLeft = (xSSFCellStyle2.BorderRight = borderStyle2);
			xSSFCellStyle.BorderLeft = borderLeft;
			if (tuple.Item2 != null)
			{
				Wg2SbOTHOUD.SetBorderColor(BorderSide.TOP, tuple.Item2);
				Wg2SbOTHOUD.SetBorderColor(BorderSide.LEFT, tuple.Item2);
				Wg2SbOTHOUD.SetBorderColor(BorderSide.RIGHT, tuple.Item2);
				Wg2SbOTHOUD.SetBorderColor(BorderSide.BOTTOM, tuple.Item2);
			}
		}

		internal void tU9SbQopLE8(string s)
		{
			(BorderStyle, XSSFColor) tuple = c6jgBW836PE(s);
			Wg2SbOTHOUD.BorderLeft = tuple.Item1;
			if (tuple.Item2 != null)
			{
				Wg2SbOTHOUD.SetBorderColor(BorderSide.LEFT, tuple.Item2);
			}
		}

		internal void auWSbjFcqLj(string s)
		{
			(BorderStyle, XSSFColor) tuple = c6jgBW836PE(s);
			Wg2SbOTHOUD.BorderRight = tuple.Item1;
			if (tuple.Item2 != null)
			{
				Wg2SbOTHOUD.SetBorderColor(BorderSide.RIGHT, tuple.Item2);
			}
		}

		internal void LEhSbn45Z0e(string s)
		{
			(BorderStyle, XSSFColor) tuple = c6jgBW836PE(s);
			Wg2SbOTHOUD.BorderTop = tuple.Item1;
			if (tuple.Item2 != null)
			{
				Wg2SbOTHOUD.SetBorderColor(BorderSide.TOP, tuple.Item2);
			}
		}

		internal void k9qSb4CT1ha(string s)
		{
			(BorderStyle, XSSFColor) tuple = c6jgBW836PE(s);
			Wg2SbOTHOUD.BorderBottom = tuple.Item1;
			if (tuple.Item2 != null)
			{
				Wg2SbOTHOUD.SetBorderColor(BorderSide.BOTTOM, tuple.Item2);
			}
		}

		internal void pDRSb5hf1p1(string s)
		{
			ADESbFF2TxW = s;
		}

		internal void SMPSbDhUq1q(string s)
		{
			if (!Enum.TryParse<HorizontalAlignment>(s, true, out var result))
			{
				throw new InvalidDataException("不支持的水平对齐：" + s);
			}
			Wg2SbOTHOUD.Alignment = result;
		}

		internal void A9USbdZg2YO(string s)
		{
			if (!Enum.TryParse<VerticalAlignment>(s, true, out var result))
			{
				throw new InvalidDataException("不支持的垂直对齐：" + s);
			}
			Wg2SbOTHOUD.VerticalAlignment = result;
		}

		internal void d6YSboY8Qkb(string s)
		{
			Wg2SbOTHOUD.WrapText = VariableHelper.ConvertToBoolean(s) == true;
		}

		internal void TLlSbT2wR4S(string s)
		{
			if (!Enum.TryParse<FillPattern>(s, out var result))
			{
				throw new InvalidDataException("不支持的填充模式：" + s);
			}
			Wg2SbOTHOUD.FillPattern = result;
		}

		internal void SHgSbMfEKZP(string s)
		{
			Wg2SbOTHOUD.SetFillForegroundColor(YpKgBIJ5jHk(s));
		}

		internal void LwwSbArpxUn(string s)
		{
			Wg2SbOTHOUD.SetFillBackgroundColor(YpKgBIJ5jHk(s));
		}

		internal static bool MyNJogWlyV1QcCI1Xmdq()
		{
			return tUBaLFWlWY38fyp7jEch == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_1
	{
		public XSSFFont tWTS6ExJq1E;

		public Action<string> AGxS6yhsonX;

		public Action<string> zBpS68aP511;

		public Action<string> eHiS6amBKK1;

		public Action<string> qUHS67brqpf;

		public Action<string> xLeS6Rm3gSi;

		public Action<string> hEWS6qF6oJp;

		public Action<string> jGmS6cOdnUP;

		private static _003C_003Ec__DisplayClass23_1 F3ug7QWlAqVC3kMePi1n;

		internal void UBvS62Gn7Tr(string fname)
		{
			tWTS6ExJq1E.FontName = fname;
		}

		internal void FxjS6u9x1rO(string s)
		{
			tWTS6ExJq1E.FontHeightInPoints = int.Parse(s);
		}

		internal void bVmS6NcBws9(string s)
		{
			tWTS6ExJq1E.IsItalic = VariableHelper.ConvertToBoolean(s) == true;
		}

		internal void lFSS6J5AY9Q(string s)
		{
			tWTS6ExJq1E.IsBold = VariableHelper.ConvertToBoolean(s) == true;
		}

		internal void HVJS60HN8vl(string s)
		{
			tWTS6ExJq1E.IsStrikeout = VariableHelper.ConvertToBoolean(s) == true;
		}

		internal void nNnS6CbetZn(string s)
		{
			if (Enum.TryParse<FontUnderlineType>(s, true, out var result))
			{
				tWTS6ExJq1E.Underline = result;
			}
		}

		internal void YKpS6PgEcue(string s)
		{
			tWTS6ExJq1E.SetColor(YpKgBIJ5jHk(s));
		}

		internal static bool nMAlivWlnnwe00oe3C8R()
		{
			return F3ug7QWlAqVC3kMePi1n == null;
		}
	}

	private static object GMQIo7QHWfAlA3nwkR6i;

	public static IWorkbook LoadWorkbook(string path)
	{
		if (!File.Exists(path))
		{
			throw new FileNotFoundException("未找到文件 " + path);
		}
		using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		IWorkbook workbook = null;
		if (path.EndsWithAny(StringComparison.OrdinalIgnoreCase, ".xlsx", ".xlsm"))
		{
			return new XSSFWorkbook((Stream)fileStream);
		}
		return new HSSFWorkbook(fileStream);
	}

	public static IList<string> GetSheetList(this IWorkbook workbook)
	{
		int numberOfSheets = workbook.NumberOfSheets;
		List<string> list = new List<string>(numberOfSheets);
		for (int i = 0; i < numberOfSheets; i++)
		{
			list.Add(workbook.GetSheetName(i));
		}
		return list;
	}

	public static string GetCellDataDisplayString(this ICell cell)
	{
		if (DateUtil.IsCellDateFormatted(cell))
		{
			return new DataFormatter().FormatCellValue(cell).Replace("\"", "");
		}
		if (cell.CellStyle.DataFormat != 0)
		{
			return new DataFormatter().FormatCellValue(cell);
		}
		return cell.NumericCellValue.ToString();
	}

	private static void Cy3gBV9Sj3o(ICell icell_0, DataRow dataRow_0, DataTable dataTable_0, string string_0)
	{
		if (icell_0.CellType == CellType.Blank)
		{
			dataRow_0[string_0] = "";
			return;
		}
		switch (icell_0.CellType)
		{
		case CellType.Numeric:
		{
			short dataFormat = icell_0.CellStyle.DataFormat;
			if (!(dataTable_0.Columns[string_0].DataType == typeof(DateTime)) && !DateUtil.IsCellDateFormatted(icell_0))
			{
				dataRow_0[string_0] = icell_0.NumericCellValue;
				break;
			}
			if (dataRow_0.Table.Columns[string_0].DataType == typeof(DateTime))
			{
				try
				{
					dataRow_0[string_0] = icell_0.DateCellValue;
					break;
				}
				catch (Exception)
				{
					dataRow_0[string_0] = icell_0.ToString();
					break;
				}
			}
			dataRow_0[string_0] = icell_0.GetCellDataDisplayString();
			break;
		}
		case CellType.String:
			dataRow_0[string_0] = icell_0.StringCellValue;
			break;
		default:
			dataRow_0[string_0] = icell_0.ToString();
			break;
		case CellType.Blank:
			dataRow_0[string_0] = "";
			break;
		case CellType.Boolean:
			dataRow_0[string_0] = icell_0.BooleanCellValue;
			break;
		}
	}

	private static IDictionary<string, string> iePgBZu1Aii(IList<string> ilist_0, bool bool_0 = false, bool bool_1 = false)
	{
		if (!ilist_0.HasData())
		{
			return new Dictionary<string, string>();
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (string item in ilist_0)
		{
			string[] array = item.Split(new char[1] { ':' }, 2);
			if (array.Length != 2)
			{
				if (bool_0)
				{
					throw new InvalidDataException("列映射格式不正确。应该为“源标题:目标标题”的形式，当前为“" + item + "”");
				}
				dictionary.Add(array[0], array[0]);
			}
			string text = array[0];
			string text2 = array[1];
			if (bool_1)
			{
				dictionary.Add(text2, text);
			}
			else
			{
				dictionary.Add(text, text2);
			}
		}
		return dictionary;
	}

	public static void CopySheet(ISheet sourceSheet, int sourceRowIndex, ISheet sheet, int rowIndex, string columnMappingStr, bool writeTitleRow)
	{
		IRow row = sourceSheet.GetRow(sourceRowIndex);
		WriteDataFromTable(sourceSheet.ReadTable(new CellRangeAddress(sourceRowIndex, sourceSheet.LastRowNum, row.FirstCellNum, row.LastCellNum)), sheet, rowIndex, columnMappingStr, writeTitleRow);
	}

	public static void WriteDataFromTable(DataTable table, ISheet sheet, int rowIndex, string columnMappingStr, bool writeTitleRow)
	{
		int num = 0;
		IDictionary<int, string> dictionary = new Dictionary<int, string>();
		if (columnMappingStr.StartsWith("="))
		{
			num = 1;
			IDictionary<int, string> dictionary2 = JDcgBh0prir(sheet, rowIndex);
			List<string> list = columnMappingStr.SplitToList().Select(_003C_003Ec.iR9SbsnJ9eU ?? (_003C_003Ec.iR9SbsnJ9eU = _003C_003Ec.hV2SbGiC0fG.pswSb9xApNH)).ToList();
			list.Remove("=");
			IDictionary<string, string> dictionary3 = iePgBZu1Aii(list);
			int num3 = default(int);
			foreach (KeyValuePair<int, string> item in dictionary2)
			{
				string text = item.Value;
				if (dictionary3.ContainsKey(text))
				{
					text = dictionary3[text];
					int num2 = 0;
					if (!fodSDyQHyngj88ARpURM())
					{
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				if (table.Columns.Contains(text))
				{
					dictionary.Add(item.Key, text);
				}
			}
			goto IL_040b;
		}
		int num4;
		if (!columnMappingStr.StartsWith("*"))
		{
			num4 = 4;
			if (!fodSDyQHyngj88ARpURM())
			{
				goto IL_0112;
			}
			goto IL_0197;
		}
		goto IL_033f;
		IL_040b:
		foreach (DataRow row3 in table.Rows)
		{
			IRow orCreateRow = sheet.GetOrCreateRow(rowIndex + num);
			foreach (KeyValuePair<int, string> item2 in dictionary)
			{
				object value = row3[item2.Value];
				SetCellValue(orCreateRow.GetOrCreateCell(item2.Key), value);
			}
			num++;
		}
		return;
		IL_0197:
		int num5 = default(int);
		string[] array = default(string[]);
		IRow row = default(IRow);
		List<string> list2 = default(List<string>);
		string text2 = default(string);
		string text3 = default(string);
		switch (num4)
		{
		case 4:
			break;
		default:
			return;
		case 1:
			num5 = 0;
			goto IL_029d;
		case 2:
			text2 = array[0];
			goto IL_02f3;
		case 5:
			if (writeTitleRow)
			{
				row.GetOrCreateCell(num5).SetCellValue(text2);
			}
			num5++;
			goto IL_029d;
		case 3:
			goto IL_040b;
		case 0:
			return;
			IL_029d:
			if (num5 < list2.Count)
			{
				array = list2[num5].Split(new char[1] { ':' }, 2);
				text2 = "";
				text3 = "";
				if (array.Length == 1)
				{
					text3 = (text2 = array[0]);
					goto IL_02f3;
				}
				text3 = array[1];
				goto case 2;
			}
			goto IL_040b;
			IL_02f3:
			if (table.Columns.Contains(text3))
			{
				dictionary.Add(num5, text3);
				goto case 5;
			}
			throw new InvalidDataException("表中不存在列：" + text3);
		}
		goto IL_0112;
		IL_0112:
		if (string.IsNullOrWhiteSpace(columnMappingStr))
		{
			goto IL_033f;
		}
		if (!columnMappingStr.StartsWith("#"))
		{
			num = (writeTitleRow ? 1 : 0);
			list2 = columnMappingStr.SplitToList().Select(_003C_003Ec.G5LSbbh7eAk ?? (_003C_003Ec.G5LSbbh7eAk = _003C_003Ec.hV2SbGiC0fG.TIYSbYfr42g)).ToList();
			if (list2.HasData())
			{
				row = (writeTitleRow ? sheet.GetOrCreateRow(rowIndex) : null);
				num4 = 1;
				if (!fodSDyQHyngj88ARpURM())
				{
					int num6 = default(int);
					num4 = num6;
				}
				goto IL_0197;
			}
			throw new InvalidDataException("未设定要复制的列");
		}
		List<string> list3 = columnMappingStr.SplitToList().Select(_003C_003Ec.PViSb1gAXFO ?? (_003C_003Ec.PViSb1gAXFO = _003C_003Ec.hV2SbGiC0fG.HUVSbechw47)).ToList();
		list3.Remove("#");
		foreach (string item3 in list3)
		{
			string[] array2 = item3.Split(':');
			if (array2.Length == 2)
			{
				string value2 = array2[1];
				string text4 = array2[0];
				if (!int.TryParse(text4, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
				{
					result = CellReference.ConvertColStringToIndex(text4);
				}
				dictionary.Add(result, value2);
				continue;
			}
			throw new InvalidDataException("字段映射规则格式不正确，当前内容：" + item3);
		}
		goto IL_040b;
		IL_033f:
		num = (writeTitleRow ? 1 : 0);
		List<string> list4 = columnMappingStr.SplitToList().Select(_003C_003Ec.hhTSbHVRi4E ?? (_003C_003Ec.hhTSbHVRi4E = _003C_003Ec.hV2SbGiC0fG.gSrSbhwiWRG)).ToList();
		list4.Remove("*");
		IDictionary<string, string> dictionary4 = iePgBZu1Aii(list4, true, true);
		IRow row2 = ((!writeTitleRow) ? null : sheet.GetOrCreateRow(rowIndex));
		for (int i = 0; i < table.Columns.Count; i++)
		{
			DataColumn dataColumn = table.Columns[i];
			dictionary.Add(i, dataColumn.ColumnName);
			string text5 = dataColumn.ColumnName;
			if (dictionary4.ContainsKey(text5))
			{
				text5 = dictionary4[text5];
			}
			if (writeTitleRow)
			{
				row2.GetOrCreateCell(i).SetCellValue(text5);
			}
		}
		goto IL_040b;
	}

	private static void rIQgB9chpLM(ICell icell_0, ICell icell_1)
	{
		switch (icell_0.CellType)
		{
		case CellType.Numeric:
			if (DateUtil.IsCellDateFormatted(icell_0))
			{
				icell_1.SetCellValue(icell_0.DateCellValue);
			}
			else
			{
				icell_1.SetCellValue(icell_0.NumericCellValue);
			}
			break;
		case CellType.String:
			icell_1.SetCellValue(icell_0.StringCellValue);
			break;
		case CellType.Formula:
			switch (icell_0.CachedFormulaResultType)
			{
			case CellType.Numeric:
				if (DateUtil.IsCellDateFormatted(icell_0))
				{
					icell_1.SetCellValue(icell_0.DateCellValue);
					if (!fodSDyQHyngj88ARpURM())
					{
						switch (0)
						{
						}
					}
				}
				else
				{
					icell_1.SetCellValue(icell_0.NumericCellValue);
				}
				break;
			case CellType.String:
				icell_1.SetCellValue(icell_0.StringCellValue);
				break;
			case CellType.Boolean:
				icell_1.SetCellValue(icell_0.BooleanCellValue);
				break;
			case CellType.Formula:
			case CellType.Blank:
				break;
			}
			break;
		case CellType.Blank:
			break;
		case CellType.Boolean:
			icell_1.SetCellValue(icell_0.BooleanCellValue);
			break;
		}
	}

	public static ICell GetCell(this ISheet sheet, int rowIdx, int colIdx)
	{
		return sheet.GetRow(rowIdx)?.GetCell(colIdx, MissingCellPolicy.RETURN_BLANK_AS_NULL);
	}

	public static (object value, string textValue) GetCellValue(ISheet sheet, int row, int col)
	{
		ICell cell = sheet.GetCell(row, col);
		if (cell == null)
		{
			return (value: null, textValue: string.Empty);
		}
		return GetCellValue(cell);
	}

	public static (object value, string textValue) GetCellValue(ICell cell)
	{
		object obj = null;
		string item = "";
		switch (cell.CellType)
		{
		case CellType.Unknown:
			obj = (item = cell.ToString());
			break;
		case CellType.Numeric:
			obj = ((!DateUtil.IsCellDateFormatted(cell)) ? ((object)cell.NumericCellValue) : ((object)cell.DateCellValue));
			item = cell.GetCellDataDisplayString();
			break;
		case CellType.String:
			obj = (item = cell.StringCellValue);
			break;
		case CellType.Formula:
			switch (cell.CachedFormulaResultType)
			{
			case CellType.Numeric:
				obj = cell.NumericCellValue;
				item = cell.GetCellDataDisplayString();
				break;
			case CellType.String:
				obj = (item = cell.StringCellValue);
				break;
			case CellType.Boolean:
				obj = cell.BooleanCellValue;
				item = obj.ToString();
				break;
			}
			break;
		default:
			obj = (item = cell.ToString());
			break;
		case CellType.Boolean:
			obj = cell.BooleanCellValue;
			item = cell.ToString();
			break;
		}
		return (value: obj, textValue: item);
	}

	private static IDictionary<int, string> JDcgBh0prir(ISheet isheet_0, int int_0)
	{
		IRow row = isheet_0.GetRow(int_0);
		if (row == null)
		{
			throw new InvalidDataException("Header行数据为空。");
		}
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		for (int i = 0; i < row.LastCellNum; i++)
		{
			ICell cell = row.GetCell(i);
			if (cell == null || cell.CellType == CellType.Blank || string.IsNullOrWhiteSpace(cell.ToString()))
			{
				break;
			}
			dictionary.Add(i, cell.ToString().Trim());
		}
		return dictionary;
	}

	private static IDictionary<string, int> kPigBeDCvEp(ISheet isheet_0, int int_0)
	{
		IRow row = isheet_0.GetRow(int_0);
		if (row == null)
		{
			throw new InvalidDataException("Header行数据为空。");
		}
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		for (int i = 0; i < row.LastCellNum; i++)
		{
			ICell cell = row.GetCell(i);
			if (cell == null || cell.CellType == CellType.Blank || string.IsNullOrWhiteSpace(cell.ToString()))
			{
				break;
			}
			dictionary.Add(cell.ToString().Trim(), i);
		}
		return dictionary;
	}

	public static IRow GetOrCreateRow(this ISheet sheet, int rowIndex)
	{
		IRow row = sheet.GetRow(rowIndex);
		if (row == null)
		{
			row = sheet.CreateRow(rowIndex);
		}
		return row;
	}

	public static ICell GetOrCreateCell(this IRow row, int cellIndex)
	{
		ICell cell = row.GetCell(cellIndex, MissingCellPolicy.RETURN_NULL_AND_BLANK);
		if (cell == null)
		{
			cell = row.CreateCell(cellIndex);
		}
		return cell;
	}

	public static void SetCellValue(ICell cell, object value)
	{
		if (value == DBNull.Value || value == null)
		{
			return;
		}
		if (value is bool cellValue)
		{
			cell.SetCellValue(cellValue);
			return;
		}
		if (value is DateTime cellValue2)
		{
			cell.SetCellValue(cellValue2);
			return;
		}
		int num;
		if (!(value is short) && !(value is int) && !(value is long) && !(value is ushort) && !(value is uint))
		{
			num = 0;
			if (fodSDyQHyngj88ARpURM())
			{
				goto IL_007e;
			}
			goto IL_009f;
		}
		goto IL_00dd;
		IL_00dd:
		cell.SetCellValue(Convert.ToDouble(value));
		return;
		IL_007e:
		if (!(value is ulong) && !(value is byte))
		{
			num = 1;
			if (GMQIo7QHWfAlA3nwkR6i != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_009f;
		}
		goto IL_00dd;
		IL_009f:
		switch (num)
		{
		case 1:
			goto IL_00ae;
		}
		goto IL_007e;
		IL_00ae:
		if (!(value is sbyte) && !(value is double) && !(value is float))
		{
			cell.SetCellValue(value.ToString().ToShortString(32760));
			return;
		}
		goto IL_00dd;
	}

	public static ICell SetCellValue(this ISheet sheet, int rowIndex, int colIndex, object value)
	{
		ICell orCreateCell = sheet.GetOrCreateRow(rowIndex).GetOrCreateCell(colIndex);
		SetCellValue(orCreateCell, value);
		return orCreateCell;
	}

	public static void SetRowCells(this ISheet sheet, int rowIndex, params object[] values)
	{
		IRow orCreateRow = sheet.GetOrCreateRow(rowIndex);
		for (int i = 0; i < values.Length; i++)
		{
			SetCellValue(orCreateRow.GetOrCreateCell(i), values[i]);
		}
	}

	public static DataTable LoadDataTable(ISheet sheet, DataTable table, int startRow = 0)
	{
        int num3 = default;
        int num5 = default;
        IDictionary<int, string> dictionary = default;
        IRow row2 = default;
        int num2 = default;
        ICell cell = default;
        int num6 = default;
        IRow row = default;
		int lastRowNum = sheet.LastRowNum;
		int num;
		if (lastRowNum < startRow)
		{
			num = 1;
			if (!fodSDyQHyngj88ARpURM())
			{
				goto IL_01e6;
			}
			goto IL_01ea;
		}
		row = sheet.GetRow(startRow);
		if (row == null)
		{
			throw new InvalidDataException($"第{startRow + 1}行中没有内容。");
		}
		num2 = row.LastCellNum;
		num3 = -1;
		dictionary = new Dictionary<int, string>();
		if (table != null)
		{
			goto IL_0060;
		}
		goto IL_0244;
		IL_022c:
		int num4 = default(int);
		num3 = num4;
		goto IL_0230;
		IL_020e:
		DataRow dataRow = default(DataRow);
		table.Rows.Add(dataRow);
		num5 = num5 + 1;
		goto IL_0221;
		IL_0221:
		row2 = default(IRow);
		cell = default(ICell);
		num6 = default(int);
		if (num5 <= lastRowNum)
		{
			row2 = sheet.GetRow(num5);
			if (row2 != null && row2.FirstCellNum == num3)
			{
				cell = row2.GetCell(row2.FirstCellNum);
				num6 = 4;
				goto IL_0205;
			}
		}
		goto IL_0261;
		IL_0205:
		if (cell != null && !string.IsNullOrWhiteSpace(cell.ToString()))
		{
			dataRow = table.NewRow();
			for (int i = row2.FirstCellNum; i <= num2; i++)
			{
				string text = dictionary[i];
				if (text != null && table.Columns.Contains(text))
				{
					ICell cell2 = row2.GetCell(i);
					if (cell2 != null && cell2.CellType != CellType.Blank)
					{
						Cy3gBV9Sj3o(cell2, dataRow, table, text);
					}
					else
					{
						dataRow[text] = "";
					}
				}
			}
			num = 0;
			if (GMQIo7QHWfAlA3nwkR6i != null)
			{
				goto IL_01e6;
			}
			goto IL_01ea;
		}
		goto IL_0261;
		IL_01e6:
		num = num6;
		goto IL_01ea;
		IL_01ea:
		switch (num)
		{
		case 4:
			break;
		default:
			goto IL_020e;
		case 2:
			goto IL_022c;
		case 3:
			goto IL_0244;
		case 1:
			throw new InvalidDataException("表中没有数据");
		}
		goto IL_0205;
		IL_0261:
		return table;
		IL_0244:
		table = new DataTable(sheet.SheetName);
		goto IL_0060;
		IL_0060:
		num4 = row.FirstCellNum;
		goto IL_0236;
		IL_0236:
		if (num4 < num2)
		{
			ICell cell2 = row.GetCell(num4);
			if (cell2 != null && cell2.CellType != CellType.Blank)
			{
				if (!string.IsNullOrWhiteSpace(cell2.StringCellValue))
				{
					dictionary[num4] = cell2.StringCellValue.Trim();
					if (num3 < 0)
					{
						goto IL_022c;
					}
				}
				goto IL_0230;
			}
			num2 = num4;
		}
		if (table.Columns.Count == 0)
		{
			foreach (KeyValuePair<int, string> item in dictionary)
			{
				table.Columns.Add(item.Value);
			}
		}
		startRow++;
		num5 = startRow;
		goto IL_0221;
		IL_0230:
		num4++;
		goto IL_0236;
	}

	public static DataTable ReadTable(this ISheet sheet, CellRangeAddress range, bool hasHeader = true)
	{
		DataTable dataTable = new DataTable(sheet.SheetName);
		IRow row = sheet.GetRow(range.FirstRow);
		if (row == null)
		{
			throw new InvalidDataException($"第{range.FirstRow + 1}行中没有内容。");
		}
		IDictionary<int, string> dictionary = new Dictionary<int, string>();
		int lastColumn = range.LastColumn;
		int num = (hasHeader ? (-1) : range.FirstColumn);
		int num2 = range.FirstColumn;
		IEnumerator<KeyValuePair<int, string>> enumerator = default(IEnumerator<KeyValuePair<int, string>>);
		ICell cell = default(ICell);
		int num4 = default(int);
		IRow row2 = default(IRow);
		DataRow dataRow = default(DataRow);
		int num5 = default(int);
		int num6 = default(int);
		string text2 = default(string);
		while (true)
		{
			int num3;
			if (num2 > lastColumn)
			{
				if (dataTable.Columns.Count != 0)
				{
					goto IL_01cb;
				}
				enumerator = dictionary.GetEnumerator();
				num3 = 2;
				if (GMQIo7QHWfAlA3nwkR6i != null)
				{
					goto IL_00d8;
				}
			}
			else
			{
				if (!hasHeader)
				{
					dictionary[num2] = $"Column{num2}";
					goto IL_011e;
				}
				cell = row.GetCell(num2);
				num3 = 0;
				if (GMQIo7QHWfAlA3nwkR6i != null)
				{
					goto IL_008f;
				}
			}
			goto IL_00dc;
			IL_02a2:
			if (num4 > range.LastRow)
			{
				break;
			}
			row2 = sheet.GetRow(num4);
			if (row2 == null)
			{
				break;
			}
			goto IL_01ee;
			IL_01ee:
			ICell cell2 = row2.GetCell(num);
			if (cell2 == null || string.IsNullOrWhiteSpace(cell2.ToString()))
			{
				break;
			}
			dataRow = dataTable.NewRow();
			num5 = num;
			goto IL_0288;
			IL_0288:
			if (num5 <= lastColumn)
			{
				if (dictionary.ContainsKey(num5))
				{
					string text = dictionary[num5];
					if (text != null && dataTable.Columns.Contains(text))
					{
						ICell cell3 = row2.GetCell(num5);
						if (cell3 != null && cell3.CellType != CellType.Blank)
						{
							Cy3gBV9Sj3o(cell3, dataRow, dataTable, text);
						}
						else
						{
							dataRow[text] = "";
						}
					}
				}
				goto IL_0282;
			}
			dataTable.Rows.Add(dataRow);
			num4++;
			goto IL_02a2;
			IL_0282:
			num5++;
			goto IL_0288;
			IL_00d8:
			num3 = num6;
			goto IL_00dc;
			IL_00dc:
			switch (num3)
			{
			case 1:
				goto IL_00fb;
			case 2:
				goto IL_0194;
			case 5:
				goto IL_01ee;
			case 3:
				goto IL_0282;
			case 4:
				goto IL_02a2;
			}
			goto IL_008f;
			IL_0194:
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, string> current = enumerator.Current;
					dataTable.Columns.Add(current.Value);
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			goto IL_01cb;
			IL_00fb:
			dictionary[num2] = text2;
			dataTable.Columns.Add(text2);
			if (num < 0)
			{
				num = num2;
			}
			goto IL_011e;
			IL_011e:
			num2++;
			continue;
			IL_008f:
			if (cell == null || cell.CellType == CellType.Blank)
			{
				goto IL_011e;
			}
			if (cell.CellType == CellType.String)
			{
				if (string.IsNullOrWhiteSpace(cell.StringCellValue))
				{
					goto IL_011e;
				}
				text2 = cell.StringCellValue.Trim();
				num3 = 1;
				if (!fodSDyQHyngj88ARpURM())
				{
					goto IL_00d8;
				}
				goto IL_00dc;
			}
			throw new InvalidDataException($"标题行（第{range.FirstRow + 1}行，第{num2 + 1}列）不是文本类型。");
			IL_01cb:
			num4 = range.FirstRow + (hasHeader ? 1 : 0);
			goto IL_02a2;
		}
		return dataTable;
	}

	private static bool hJygBYlgwfN(string string_0, string string_1, bool bool_0, Action<string> action_0)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.mx5SbxRobut = bool_0;
		_003C_003Ec__DisplayClass20_.kNwSbrZhphZ = action_0;
		_003C_003Ec__DisplayClass20_.dNaSbpV4bWx = string_0;
		return AppHelper.IfMatchThen(_003C_003Ec__DisplayClass20_.dNaSbpV4bWx, string_1 + ":", _003C_003Ec__DisplayClass20_.Q2lSbK0agP9);
	}

	private static XSSFColor YpKgBIJ5jHk(string string_0)
	{
		Color color = ColorHelper.StringToWinformColor(string_0);
		XSSFColor xSSFColor = new XSSFColor();
		xSSFColor.SetRgb(new byte[3] { color.R, color.G, color.B });
		return xSSFColor;
	}

	private static (BorderStyle borderStyle, XSSFColor color) c6jgBW836PE(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return (borderStyle: BorderStyle.None, color: null);
		}
		string[] array = string_0.Trim().Split(',');
		BorderStyle result = BorderStyle.None;
		Enum.TryParse<BorderStyle>(array[0], true, out result);
		if (array.Length > 1)
		{
			XSSFColor item = YpKgBIJ5jHk(array[1]);
			return (borderStyle: result, color: item);
		}
		return (borderStyle: result, color: null);
	}

	public static void ApplyStyle(XSSFSheet sheet, CellRangeAddress range, string styleData)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		if (string.IsNullOrWhiteSpace(styleData))
		{
			return;
		}
		List<string> list = styleData.SplitToList().Where(_003C_003Ec.Y2RSb6S5VoY ?? (_003C_003Ec.Y2RSb6S5VoY = _003C_003Ec.hV2SbGiC0fG.wxjSbIebq3m)).ToList();
		List<string> list2 = list.Where(_003C_003Ec.l0ESbX7l808 ?? (_003C_003Ec.l0ESbX7l808 = _003C_003Ec.hV2SbGiC0fG.OjJSbW5AD35)).Select(_003C_003Ec.wKMSbmAKLfa ?? (_003C_003Ec.wKMSbmAKLfa = _003C_003Ec.hV2SbGiC0fG.NnBSbkKGUo4)).ToList();
		_003C_003Ec__DisplayClass23_.Wg2SbOTHOUD = sheet.Workbook.CreateCellStyle() as XSSFCellStyle;
		_003C_003Ec__DisplayClass23_.ADESbFF2TxW = "";
		int num = 0;
		if (!fodSDyQHyngj88ARpURM())
		{
			int num2 = default(int);
			num = num2;
		}
		_003C_003Ec__DisplayClass23_1 _003C_003Ec__DisplayClass23_2 = default(_003C_003Ec__DisplayClass23_1);
		switch (num)
		{
		default:
			if (!list2.HasData())
			{
				break;
			}
			_003C_003Ec__DisplayClass23_2 = new _003C_003Ec__DisplayClass23_1();
			_003C_003Ec__DisplayClass23_2.tWTS6ExJq1E = sheet.Workbook.CreateFont() as XSSFFont;
			goto case 2;
		case 2:
		{
			if (_003C_003Ec__DisplayClass23_2.tWTS6ExJq1E == null)
			{
				throw new InvalidDataException("未成功创建字体");
			}
			using (List<string>.Enumerator enumerator = list2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!hJygBYlgwfN(current, "name", true, _003C_003Ec__DisplayClass23_2.AGxS6yhsonX ?? (_003C_003Ec__DisplayClass23_2.AGxS6yhsonX = _003C_003Ec__DisplayClass23_2.UBvS62Gn7Tr)) && !hJygBYlgwfN(current, "height", true, _003C_003Ec__DisplayClass23_2.zBpS68aP511 ?? (_003C_003Ec__DisplayClass23_2.zBpS68aP511 = _003C_003Ec__DisplayClass23_2.FxjS6u9x1rO)) && !hJygBYlgwfN(current, "italic", true, _003C_003Ec__DisplayClass23_2.eHiS6amBKK1 ?? (_003C_003Ec__DisplayClass23_2.eHiS6amBKK1 = _003C_003Ec__DisplayClass23_2.bVmS6NcBws9)) && !hJygBYlgwfN(current, "bold", true, _003C_003Ec__DisplayClass23_2.qUHS67brqpf ?? (_003C_003Ec__DisplayClass23_2.qUHS67brqpf = _003C_003Ec__DisplayClass23_2.lFSS6J5AY9Q)) && !hJygBYlgwfN(current, "Strikeout", true, _003C_003Ec__DisplayClass23_2.xLeS6Rm3gSi ?? (_003C_003Ec__DisplayClass23_2.xLeS6Rm3gSi = _003C_003Ec__DisplayClass23_2.HVJS60HN8vl)) && !hJygBYlgwfN(current, "underline", true, _003C_003Ec__DisplayClass23_2.hEWS6qF6oJp ?? (_003C_003Ec__DisplayClass23_2.hEWS6qF6oJp = _003C_003Ec__DisplayClass23_2.nNnS6CbetZn)))
					{
						hJygBYlgwfN(current, "color", true, _003C_003Ec__DisplayClass23_2.jGmS6cOdnUP ?? (_003C_003Ec__DisplayClass23_2.jGmS6cOdnUP = _003C_003Ec__DisplayClass23_2.YKpS6PgEcue));
					}
				}
				int num3 = 0;
				if (GMQIo7QHWfAlA3nwkR6i != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			goto case 1;
		}
		case 1:
			_003C_003Ec__DisplayClass23_.Wg2SbOTHOUD.SetFont(_003C_003Ec__DisplayClass23_2.tWTS6ExJq1E);
			break;
		}
		int num6 = default(int);
		foreach (string item in list)
		{
			if (!item.StartsWith("border."))
			{
				if (item.StartsWith("font:", StringComparison.OrdinalIgnoreCase) || hJygBYlgwfN(item, "horz", true, _003C_003Ec__DisplayClass23_.ec3S6wvqSEK ?? (_003C_003Ec__DisplayClass23_.ec3S6wvqSEK = _003C_003Ec__DisplayClass23_.SMPSbDhUq1q)) || hJygBYlgwfN(item, "vert", true, _003C_003Ec__DisplayClass23_.FbGS6tF0NLN ?? (_003C_003Ec__DisplayClass23_.FbGS6tF0NLN = _003C_003Ec__DisplayClass23_.A9USbdZg2YO)) || hJygBYlgwfN(item, "wraptext", true, _003C_003Ec__DisplayClass23_.TCVS6giufuX ?? (_003C_003Ec__DisplayClass23_.TCVS6giufuX = _003C_003Ec__DisplayClass23_.d6YSboY8Qkb)) || hJygBYlgwfN(item, "fillpattern", true, _003C_003Ec__DisplayClass23_.gYSS6LsP0QF ?? (_003C_003Ec__DisplayClass23_.gYSS6LsP0QF = _003C_003Ec__DisplayClass23_.TLlSbT2wR4S)) || hJygBYlgwfN(item, "foreground", true, _003C_003Ec__DisplayClass23_.u7bS6vRQwn7 ?? (_003C_003Ec__DisplayClass23_.u7bS6vRQwn7 = _003C_003Ec__DisplayClass23_.SHgSbMfEKZP)))
				{
					continue;
				}
				hJygBYlgwfN(item, "background", true, _003C_003Ec__DisplayClass23_.Kt9S6SNAiKk ?? (_003C_003Ec__DisplayClass23_.Kt9S6SNAiKk = _003C_003Ec__DisplayClass23_.LwwSbArpxUn));
				int num5 = 0;
				if (!fodSDyQHyngj88ARpURM())
				{
					num5 = num6;
				}
				switch (num5)
				{
				case 1:
					break;
				default:
					continue;
				}
			}
			string string_ = item.Substring("border.".Length);
			if (!hJygBYlgwfN(string_, "all", true, _003C_003Ec__DisplayClass23_.vvpSbU2LpmK ?? (_003C_003Ec__DisplayClass23_.vvpSbU2LpmK = _003C_003Ec__DisplayClass23_.POGSbBxVp51)) && !hJygBYlgwfN(string_, "left", true, _003C_003Ec__DisplayClass23_.UT9Sbl6EtvP ?? (_003C_003Ec__DisplayClass23_.UT9Sbl6EtvP = _003C_003Ec__DisplayClass23_.tU9SbQopLE8)) && !hJygBYlgwfN(string_, "right", true, _003C_003Ec__DisplayClass23_.AmlSbiUm83W ?? (_003C_003Ec__DisplayClass23_.AmlSbiUm83W = _003C_003Ec__DisplayClass23_.auWSbjFcqLj)) && !hJygBYlgwfN(string_, "top", true, _003C_003Ec__DisplayClass23_.mn9Sb3HYlXn ?? (_003C_003Ec__DisplayClass23_.mn9Sb3HYlXn = _003C_003Ec__DisplayClass23_.LEhSbn45Z0e)) && !hJygBYlgwfN(string_, "bottom", true, _003C_003Ec__DisplayClass23_.HBwSbfGBrbL ?? (_003C_003Ec__DisplayClass23_.HBwSbfGBrbL = _003C_003Ec__DisplayClass23_.k9qSb4CT1ha)) && hJygBYlgwfN(string_, "outside", true, _003C_003Ec__DisplayClass23_.iKaSbzh6yoB ?? (_003C_003Ec__DisplayClass23_.iKaSbzh6yoB = _003C_003Ec__DisplayClass23_.pDRSb5hf1p1)))
			{
			}
		}
		for (int i = range.FirstRow; i <= range.LastRow; i++)
		{
			IRow orCreateRow = sheet.GetOrCreateRow(i);
			for (int j = range.FirstColumn; j <= range.LastColumn; j++)
			{
				orCreateRow.GetOrCreateCell(j).CellStyle = _003C_003Ec__DisplayClass23_.Wg2SbOTHOUD;
			}
		}
		if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass23_.ADESbFF2TxW))
		{
			apFgBkOLJiC(sheet, range, _003C_003Ec__DisplayClass23_.ADESbFF2TxW);
		}
	}

	private static void apFgBkOLJiC(XSSFSheet xssfsheet_0, CellRangeAddress cellRangeAddress_0, string string_0)
	{
        ICell orCreateCell = default;
        int num2 = default;
        XSSFCellStyle xSSFCellStyle = default;
        int num3 = default;
		(BorderStyle, XSSFColor) tuple = c6jgBW836PE(string_0);
		int num;
		if (tuple.Item2 != null)
		{
			num = 1;
			if (GMQIo7QHWfAlA3nwkR6i != null)
			{
				goto IL_00b1;
			}
			goto IL_00b5;
		}
		goto IL_01e0;
		IL_019e:
		num2 = default(int);
		orCreateCell = default(ICell);
		IRow orCreateRow = default(IRow);
		xSSFCellStyle = default(XSSFCellStyle);
		if (num2 <= cellRangeAddress_0.LastColumn)
		{
			orCreateCell = orCreateRow.GetOrCreateCell(num2);
			xSSFCellStyle = xssfsheet_0.Workbook.CreateCellStyle() as XSSFCellStyle;
			xSSFCellStyle.CloneStyleFrom(orCreateCell.CellStyle);
			if (orCreateCell.Address.Row == cellRangeAddress_0.FirstRow)
			{
				(xSSFCellStyle.BorderTop, _) = tuple;
				if (tuple.Item2 != null)
				{
					xSSFCellStyle.SetTopBorderColor(tuple.Item2);
					num = 2;
					if (!fodSDyQHyngj88ARpURM())
					{
						goto IL_00b1;
					}
					goto IL_00b5;
				}
			}
			goto IL_00cb;
		}
		num3 = num3 + 1;
		num = 0;
		if (!fodSDyQHyngj88ARpURM())
		{
			goto IL_00b5;
		}
		goto IL_01ae;
		IL_00b1:
		int num4 = default(int);
		num = num4;
		goto IL_00b5;
		IL_00b5:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_01ae;
		case 1:
			goto IL_01bd;
		}
		goto IL_00cb;
		IL_01bd:
		XSSFCellStyle obj = xssfsheet_0.Workbook.CreateCellStyle() as XSSFCellStyle;
		obj.SetBottomBorderColor(tuple.Item2);
		short bottomBorderColor = obj.BottomBorderColor;
		goto IL_01e0;
		IL_01e0:
		num3 = cellRangeAddress_0.FirstRow;
		goto IL_01ae;
		IL_01ae:
		if (num3 <= cellRangeAddress_0.LastRow)
		{
			orCreateRow = xssfsheet_0.GetOrCreateRow(num3);
			num2 = cellRangeAddress_0.FirstColumn;
			goto IL_019e;
		}
		return;
		IL_00cb:
		if (orCreateCell.Address.Row == cellRangeAddress_0.LastRow)
		{
			(xSSFCellStyle.BorderBottom, _) = tuple;
			if (tuple.Item2 != null)
			{
				xSSFCellStyle.SetBottomBorderColor(tuple.Item2);
			}
		}
		if (orCreateCell.Address.Column == cellRangeAddress_0.FirstColumn)
		{
			(xSSFCellStyle.BorderLeft, _) = tuple;
			if (tuple.Item2 != null)
			{
				xSSFCellStyle.SetLeftBorderColor(tuple.Item2);
			}
		}
		if (orCreateCell.Address.Column == cellRangeAddress_0.LastColumn)
		{
			(xSSFCellStyle.BorderRight, _) = tuple;
			if (tuple.Item2 != null)
			{
				xSSFCellStyle.SetRightBorderColor(tuple.Item2);
			}
		}
		orCreateCell.CellStyle = xSSFCellStyle;
		num2++;
		goto IL_019e;
	}

	internal static CellAddress IjDgBG0tAtX(ISheet isheet_0, string string_0)
	{
		int num = 1;
		int i;
		while (true)
		{
			i = isheet_0.FirstRowNum;
			int num2 = 0;
			if (GMQIo7QHWfAlA3nwkR6i != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			break;
		}
		for (; i <= isheet_0.LastRowNum; i++)
		{
			IRow row = isheet_0.GetRow(i);
			if (row == null)
			{
				continue;
			}
			for (int j = row.FirstCellNum; j <= row.LastCellNum; j++)
			{
				ICell cell = row.GetCell(j);
				if (cell == null)
				{
					continue;
				}
				try
				{
					if (GetCellValue(cell).textValue == string_0)
					{
						return cell.Address;
					}
				}
				catch (Exception)
				{
					throw;
				}
			}
		}
		return null;
	}

	internal static bool fodSDyQHyngj88ARpURM()
	{
		return GMQIo7QHWfAlA3nwkR6i == null;
	}
}
