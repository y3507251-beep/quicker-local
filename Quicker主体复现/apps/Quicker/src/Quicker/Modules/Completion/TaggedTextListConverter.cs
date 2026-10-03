using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using CodeCompletionServer.Entities;
using XD65lQAcTBayBMdQxcR;

namespace Quicker.Modules.Completion;

public class TaggedTextListConverter : IValueConverter
{
	internal static TaggedTextListConverter QFnBeRQVRHsvswGZ2G8Y;

	public object Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
	{
		TaggedText[] array = (TaggedText[])value;
		if (array == null)
		{
			return "...";
		}
		return skYlUS8Kqw(array);
	}

	public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
	{
		throw new NotSupportedException();
	}

	private static TextBlock skYlUS8Kqw(TaggedText[] taggedText_0)
	{
		TextBlock textBlock = new TextBlock
		{
			MaxWidth = 600.0,
			TextWrapping = TextWrapping.Wrap
		};
		foreach (TaggedText taggedText_1 in taggedText_0)
		{
			textBlock.Inlines.Add(Q1ullHGIif(taggedText_1));
		}
		return textBlock;
	}

	private static Run Q1ullHGIif(TaggedText taggedText_0)
	{
		Run run = new Run(taggedText_0.Text.ToString());
		string classificationTypeName = ClassificationTags.GetClassificationTypeName(taggedText_0.Tag);
		run.Foreground = new SolidColorBrush(tTsTGmA1Eh2rbYW36T6.UJUlugLI0M(classificationTypeName));
		return run;
	}

	internal static bool zDB6iAQVgbfptrpiwB9f()
	{
		return QFnBeRQVRHsvswGZ2G8Y == null;
	}
}
