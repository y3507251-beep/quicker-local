using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities.Pinyin;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Utilities.UI.Behaviors;

public static class TextBlockRangeHighlighter
{
	public static readonly DependencyProperty MatchPositionsProperty;

	public static readonly DependencyProperty FilterProperty;

	private static SolidColorBrush Dv0vNSoHc8P;

	public static readonly DependencyProperty BoldProperty;

	internal static object ukPON4cVdGgif8E5Uwhk;

	private static void GpGvNtG2VkM(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 == null)
		{
			return;
		}
		if (!(dependencyObject_0 is TextBlock { Text: var text } textBlock))
		{
			throw new InvalidOperationException("Only valid for TextBlock");
		}
		if (!string.IsNullOrEmpty(text))
		{
			IList<int> matchPositions = GetMatchPositions(dependencyObject_0);
			if (matchPositions.HasData())
			{
				fMJvNLkXlGa(textBlock, text, matchPositions);
			}
		}
	}

	public static void SetMatchPositions(DependencyObject element, IList<int> value)
	{
		element.SetValue(MatchPositionsProperty, value);
	}

	public static IList<int> GetMatchPositions(DependencyObject element)
	{
		return (IList<int>)element.GetValue(MatchPositionsProperty);
	}

	private static void n98vNgPsiQ1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 == null)
		{
			return;
		}
		if (!(dependencyObject_0 is TextBlock { Text: var text } textBlock))
		{
			throw new InvalidOperationException("Only valid for TextBlock");
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string filter = GetFilter(dependencyObject_0);
		if (string.IsNullOrEmpty(filter))
		{
			return;
		}
		IMatchResult matchResult = tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(text, filter);
		if (matchResult != null)
		{
			int num = 0;
			if (ukPON4cVdGgif8E5Uwhk != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			fMJvNLkXlGa(textBlock, text, matchResult.GetMatchPositions());
		}
	}

	private static void fMJvNLkXlGa(TextBlock textBlock_0, string string_0, IList<int> ilist_0)
	{
		textBlock_0.Inlines.Clear();
		IList<Run> list = new List<Run>();
		try
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Run run = null;
				run = ((i >= 64 || !ilist_0.Contains(i)) ? new Run(string_0.Substring(i, 1)) : new Run(string_0[i].ToString())
				{
					FontWeight = FontWeights.Bold
				});
				list.Add(run);
			}
			textBlock_0.Inlines.AddRange(list);
		}
		catch (Exception)
		{
			textBlock_0.Inlines.Add(string_0);
		}
	}

	public static void SetFilter(DependencyObject element, string value)
	{
		element.SetValue(FilterProperty, value);
	}

	public static string GetFilter(DependencyObject element)
	{
		return (string)element.GetValue(FilterProperty);
	}

	public static void SetBold(DependencyObject element, bool value)
	{
		element.SetValue(BoldProperty, value);
	}

	public static bool GetBold(DependencyObject element)
	{
		return (bool)element.GetValue(BoldProperty);
	}

	private static void Xt1vNvLn2jo(TextBlock textBlock_0, string string_0, IList<MatchRange> ilist_0, bool bool_0)
	{
		if (!ilist_0.HasData())
		{
			textBlock_0.Text = string_0;
			return;
		}
		textBlock_0.Inlines.Clear();
		int num = 0;
		IList<Run> list = new List<Run>();
		try
		{
			foreach (MatchRange item2 in ilist_0)
			{
				if (num < item2.Start)
				{
					list.Add(new Run(string_0.Substring(num, item2.Start - num)));
				}
				Run item = new Run(string_0.Substring(item2.Start, item2.Length))
				{
					FontWeight = FontWeights.Bold
				};
				list.Add(item);
				num = item2.End + 1;
			}
			if (num < string_0.Length)
			{
				list.Add(new Run(string_0.Substring(num, string_0.Length - num)));
			}
			textBlock_0.Inlines.AddRange(list);
		}
		catch (Exception)
		{
			textBlock_0.Inlines.Add(string_0);
		}
	}

	static TextBlockRangeHighlighter()
	{
		MatchPositionsProperty = DependencyProperty.RegisterAttached("MatchPositions", typeof(IList<int>), typeof(TextBlockRangeHighlighter), new PropertyMetadata(null, GpGvNtG2VkM));
		FilterProperty = DependencyProperty.RegisterAttached("Filter", typeof(string), typeof(global::Quicker.Utilities.UI.Behaviors.TextBlockRangeHighlighter), new PropertyMetadata(null, n98vNgPsiQ1));
		Dv0vNSoHc8P = new SolidColorBrush(Color.FromRgb(1, 136, 251));
		BoldProperty = DependencyProperty.RegisterAttached("Bold", typeof(bool), typeof(TextBlockRangeHighlighter), new PropertyMetadata(true));
	}

	internal static bool wi6ZdPcVOm5LSRHThfCE()
	{
		return ukPON4cVdGgif8E5Uwhk == null;
	}
}
