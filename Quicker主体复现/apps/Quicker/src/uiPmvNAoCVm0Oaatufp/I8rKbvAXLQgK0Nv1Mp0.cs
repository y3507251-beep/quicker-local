using System;
using System.Collections.Generic;
using IOn6RhAJdTUbfGy6gwn;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Public.Extensions;
using Quicker.Public.Interfaces.Api;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities.Pinyin;

namespace uiPmvNAoCVm0Oaatufp;

internal class I8rKbvAXLQgK0Nv1Mp0 : ITextApi
{
	private static I8rKbvAXLQgK0Nv1Mp0 HFtDnBSFbt6jfZ9gxod;

	public bool IsCnChar(char char_0)
	{
		return XRlL56iKFaTMc4ji9eS.EQHvNr1vadg(char_0);
	}

	public bool IsMatch(string text, string pattern, bool ignoreWordOrder = false)
	{
		return tkxn6HAKAgMT8gvXbyh.IsMatch(text, pattern);
	}

	public bool IsAnyTextMatch(string string_0, params string[] textList)
	{
		return tkxn6HAKAgMT8gvXbyh.hSHinCpnSJ(string_0, textList);
	}

	public IMatchResult TryMatch(string string_0, string string_1, StringCharInfo stringCharInfo_0 = null)
	{
		return tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(string_0, string_1, stringCharInfo_0);
	}

	public MultiFieldMatchResult TryMatchMultiField(string string_0, double double_0, string string_1, double double_1, bool bool_0, string string_2, StringCharInfo stringCharInfo_0 = null)
	{
		string[] string_3 = string_2.SplitToList(' ');
		return tkxn6HAKAgMT8gvXbyh.mRJior6F4v(string_0, double_0, string_1, double_1, bool_0, string_3);
	}

	public MultiFieldMatchResult TryMatchMultiField(string string_0, double double_0, string string_1, double double_1, bool bool_0, QueryContext queryContext_0)
	{
		return tkxn6HAKAgMT8gvXbyh.KwUidyksAU(string_0, double_0, string_1, double_1, bool_0, queryContext_0);
	}

	public IList<string> FilterStringList(IList<string> ilist_0, string string_0, bool bool_0)
	{
		return tkxn6HAKAgMT8gvXbyh.tRUijipiSD(ilist_0, string_0, bool_0);
	}

	public IList<i8T06pAYBk1W2e2BZIP> FilterList<i8T06pAYBk1W2e2BZIP>(IEnumerable<i8T06pAYBk1W2e2BZIP> ienumerable_0, Func<i8T06pAYBk1W2e2BZIP, string> func_0, string string_0, bool bool_0)
	{
		return tkxn6HAKAgMT8gvXbyh.xt6iAs4lHo(ienumerable_0, func_0, string_0, bool_0);
	}

	public IList<KeyValuePair<F56RijAMDpJdNFXbL2P, IMatchResult>> FilterListWithScore<F56RijAMDpJdNFXbL2P>(IEnumerable<F56RijAMDpJdNFXbL2P> ienumerable_0, Func<F56RijAMDpJdNFXbL2P, string> func_0, string string_0, bool bool_0)
	{
		return tkxn6HAKAgMT8gvXbyh.gEkiOMWGXw(ienumerable_0, func_0, string_0, bool_0);
	}

	public IList<R0qGm9AfX8egaQ8CUE9> FilterListMultiField<R0qGm9AfX8egaQ8CUE9>(IEnumerable<R0qGm9AfX8egaQ8CUE9> ienumerable_0, Func<R0qGm9AfX8egaQ8CUE9, string> func_0, double double_0, Func<R0qGm9AfX8egaQ8CUE9, string> func_1, double double_1, bool bool_0, string string_0, bool bool_1)
	{
		return tkxn6HAKAgMT8gvXbyh.E5FiUUSTVG(ienumerable_0, func_0, double_0, func_1, double_1, bool_0, string_0, bool_1);
	}

	public IList<KeyValuePair<Y2ekjtA6pkfHhWxuqym, MultiFieldMatchResult>> FilterListMultiFieldWithScore<Y2ekjtA6pkfHhWxuqym>(IEnumerable<Y2ekjtA6pkfHhWxuqym> ienumerable_0, Func<Y2ekjtA6pkfHhWxuqym, string> func_0, double double_0, Func<Y2ekjtA6pkfHhWxuqym, string> func_1, double double_1, bool bool_0, string string_0, bool bool_1)
	{
		return tkxn6HAKAgMT8gvXbyh.tgCilB1s6R(ienumerable_0, func_0, double_0, func_1, double_1, bool_0, string_0, bool_1);
	}

	static I8rKbvAXLQgK0Nv1Mp0()
	{
	}

	internal static bool xhybFlScg4W546SB0Gk()
	{
		return HFtDnBSFbt6jfZ9gxod == null;
	}

	internal static void zZSWJtSp2GpoWMP4HiO()
	{
	}
}
