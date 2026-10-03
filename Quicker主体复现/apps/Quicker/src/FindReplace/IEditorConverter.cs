using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using ICSharpCode.AvalonEdit;

namespace FindReplace;

public class IEditorConverter : IValueConverter
{
	private static IEditorConverter SJtMIiXsEfc1nphJVtv;

	object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is TextEditor)
		{
			return new TextEditorAdapter(value as TextEditor);
		}
		if (value is TextBox)
		{
			return new TextBoxAdapter(value as TextBox);
		}
		if (!(value is RichTextBox))
		{
			return null;
		}
		return new RichTextBoxAdapter(value as RichTextBox);
	}

	object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool y7RPvdXC1B3WfCana40()
	{
		return SJtMIiXsEfc1nphJVtv == null;
	}
}
