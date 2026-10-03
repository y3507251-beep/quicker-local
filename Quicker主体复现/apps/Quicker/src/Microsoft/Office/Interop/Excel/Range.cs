using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[TypeIdentifier]
[InterfaceType(2)]
[CompilerGenerated]
[Guid("00020846-0000-0000-C000-000000000046")]
public interface Range : IEnumerable
{
	[DispId(148)]
	Application Application
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(148)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(304)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Activate();

	void _VtblGap2_2();

	[DispId(236)]
	string Address
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(236)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap3_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(876)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AdvancedFilter([In] XlFilterAction Action, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CriteriaRange, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CopyToRange, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Unique);

	void _VtblGap4_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(448)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ApplyOutlineStyles();

	void _VtblGap5_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(449)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AutoFill([In][MarshalAs(UnmanagedType.Interface)] Range Destination, [In] [Optional][DefaultParameterValue(XlAutoFillType.xlFillDefault)] XlAutoFillType Type);

	void _VtblGap6_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(237)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AutoFit();

	void _VtblGap7_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1036)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object AutoOutline();

	void _VtblGap8_1();

	[DispId(435)]
	Borders Borders
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(435)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(279)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Calculate();

	void _VtblGap9_3();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(111)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Clear();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(113)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ClearContents();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(112)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ClearFormats();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(239)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ClearNotes();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1037)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ClearOutline();

	[DispId(240)]
	int Column
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(240)]
		get;
	}

	void _VtblGap10_1();

	[DispId(241)]
	Range Columns
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(242)]
	object ColumnWidth
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(242)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(242)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(482)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Consolidate([Optional][In][MarshalAs(UnmanagedType.Struct)] object Sources, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Function, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TopRow, [Optional][In][MarshalAs(UnmanagedType.Struct)] object LeftColumn, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CreateLinks);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(551)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Copy([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	void _VtblGap11_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(213)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object CopyPicture([In] [Optional][DefaultParameterValue(XlPictureAppearance.xlScreen)] XlPictureAppearance Appearance, [In] [Optional][DefaultParameterValue(XlCopyPictureFormat.xlPicture)] XlCopyPictureFormat Format);

	[DispId(118)]
	int Count
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	void _VtblGap12_4();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(565)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Cut([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(464)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object DataSeries([Optional][In][MarshalAs(UnmanagedType.Struct)] object Rowcol, [In] [Optional][DefaultParameterValue(XlDataSeriesType.xlDataSeriesLinear)] XlDataSeriesType Type, [In] [Optional][DefaultParameterValue(XlDataSeriesDate.xlDay)] XlDataSeriesDate Date, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Step, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Stop, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Trend);

	[IndexerName("_Default")]
	[DispId(0)]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(117)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Delete([Optional][In][MarshalAs(UnmanagedType.Struct)] object Shift);

	void _VtblGap13_6();

	[DispId(246)]
	Range EntireColumn
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(246)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(247)]
	Range EntireRow
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(247)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(248)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object FillDown();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(249)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object FillLeft();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(250)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object FillRight();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(251)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object FillUp();

	void _VtblGap14_3();

	[DispId(146)]
	Font Font
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(146)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(261)]
	object Formula
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(261)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(261)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap15_12();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(571)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object FunctionWizard();

	void _VtblGap16_7();

	[DispId(136)]
	object HorizontalAlignment
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(136)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(136)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap17_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1381)]
	void InsertIndent([In] int InsertAmount);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(252)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Insert([Optional][In][MarshalAs(UnmanagedType.Struct)] object Shift, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CopyOrigin);

	[DispId(129)]
	Interior Interior
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(129)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(170)]
	object Item
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(495)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Justify();

	void _VtblGap18_6();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(564)]
	void Merge([Optional][In][MarshalAs(UnmanagedType.Struct)] object Across);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1384)]
	void UnMerge();

	void _VtblGap19_9();

	[DispId(193)]
	object NumberFormat
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap20_3();

	[DispId(134)]
	object Orientation
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(134)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(134)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap21_4();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(477)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Parse([Optional][In][MarshalAs(UnmanagedType.Struct)] object ParseLine, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	void _VtblGap22_8();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(281)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object PrintPreview([Optional][In][MarshalAs(UnmanagedType.Struct)] object EnableChanges);

	void _VtblGap23_1();

	[DispId(197)]
	Range Range
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(197)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(883)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object RemoveSubtotal();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(226)]
	bool Replace([In][MarshalAs(UnmanagedType.Struct)] object What, [In][MarshalAs(UnmanagedType.Struct)] object Replacement, [Optional][In][MarshalAs(UnmanagedType.Struct)] object LookAt, [Optional][In][MarshalAs(UnmanagedType.Struct)] object SearchOrder, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MatchCase, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MatchByte, [Optional][In][MarshalAs(UnmanagedType.Struct)] object SearchFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReplaceFormat);

	void _VtblGap24_1();

	[DispId(257)]
	int Row
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(257)]
		get;
	}

	void _VtblGap25_1();

	[DispId(272)]
	object RowHeight
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(272)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(272)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(258)]
	Range Rows
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(258)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap26_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(235)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Select();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(496)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Show();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(877)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ShowDependents([Optional][In][MarshalAs(UnmanagedType.Struct)] object Remove);

	void _VtblGap27_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(878)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ShowErrors();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(879)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ShowPrecedents([Optional][In][MarshalAs(UnmanagedType.Struct)] object Remove);

	[DispId(209)]
	object ShrinkToFit
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap28_4();

	[DispId(260)]
	object Style
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(260)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(260)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap29_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(882)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Subtotal([In] int GroupBy, [In] XlConsolidationFunction Function, [In][MarshalAs(UnmanagedType.Struct)] object TotalList, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Replace, [Optional][In][MarshalAs(UnmanagedType.Struct)] object PageBreaks, [In] [Optional][DefaultParameterValue(XlSummaryRow.xlSummaryBelow)] XlSummaryRow SummaryBelowData);

	void _VtblGap30_2();

	[DispId(138)]
	object Text
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	void _VtblGap31_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(244)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Ungroup();

	[DispId(274)]
	object UseStandardHeight
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(274)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(274)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(275)]
	object UseStandardWidth
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(275)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(275)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap32_1();

	[DispId(6)]
	object Value
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap33_2();

	[DispId(137)]
	object VerticalAlignment
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(137)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(137)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap34_1();

	[DispId(348)]
	Worksheet Worksheet
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(348)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(276)]
	object WrapText
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(276)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(276)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1389)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Comment AddComment([Optional][In][MarshalAs(UnmanagedType.Struct)] object Text);

	void _VtblGap35_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1390)]
	void ClearComments();

	void _VtblGap36_6();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1812)]
	void SetPhonetic();

	void _VtblGap37_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1772)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object PrintOut([Optional][In][MarshalAs(UnmanagedType.Struct)] object From, [Optional][In][MarshalAs(UnmanagedType.Struct)] object To, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Copies, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Preview, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ActivePrinter, [Optional][In][MarshalAs(UnmanagedType.Struct)] object PrintToFile, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Collate, [Optional][In][MarshalAs(UnmanagedType.Struct)] object PrToFileName);

	void _VtblGap38_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2014)]
	void Dirty();

	void _VtblGap39_3();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1928)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object PasteSpecial([In] [Optional][DefaultParameterValue(XlPasteType.xlPasteAll)] XlPasteType Paste, [In] [Optional][DefaultParameterValue(XlPasteSpecialOperation.xlPasteSpecialOperationNone)] XlPasteSpecialOperation Operation, [Optional][In][MarshalAs(UnmanagedType.Struct)] object SkipBlanks, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Transpose);

	void _VtblGap40_4();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2492)]
	void RemoveDuplicates([Optional][In][MarshalAs(UnmanagedType.Struct)] object Columns, [In] [Optional][DefaultParameterValue(XlYesNoGuess.xlNo)] XlYesNoGuess Header);

	void _VtblGap41_2();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2493)]
	void ExportAsFixedFormat([In] XlFixedFormatType Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Quality, [Optional][In][MarshalAs(UnmanagedType.Struct)] object IncludeDocProperties, [Optional][In][MarshalAs(UnmanagedType.Struct)] object IgnorePrintAreas, [Optional][In][MarshalAs(UnmanagedType.Struct)] object From, [Optional][In][MarshalAs(UnmanagedType.Struct)] object To, [Optional][In][MarshalAs(UnmanagedType.Struct)] object OpenAfterPublish, [Optional][In][MarshalAs(UnmanagedType.Struct)] object FixedFormatExtClassPtr);

	void _VtblGap42_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2364)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object CalculateRowMajorOrder();

	void _VtblGap43_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2854)]
	void ClearHyperlinks();
}
