using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using ICSharpCode.AvalonEdit;
using Quicker.Utilities;
using t8SGKhhgLWTgeqjGcrq;

namespace FindReplace;

public class FindReplaceMgr : DependencyObject
{
	public enum SearchScope
	{
		CurrentDocument,
		AllDocuments
	}

	private FindReplaceDialog QMQSSMa9eW;

	public static readonly DependencyProperty EditorsProperty;

	public static readonly DependencyProperty CurrentEditorProperty;

	public static readonly DependencyProperty InterfaceConverterProperty;

	public static readonly DependencyProperty TextToFindProperty;

	public static readonly DependencyProperty ReplacementTextProperty;

	public static readonly DependencyProperty UseWildcardsProperty;

	public static readonly DependencyProperty SearchUpProperty;

	public static readonly DependencyProperty CaseSensitiveProperty;

	public static readonly DependencyProperty UseRegExProperty;

	public static readonly DependencyProperty WholeWordProperty;

	public static readonly DependencyProperty AcceptsReturnProperty;

	public static readonly DependencyProperty SearchInProperty;

	public static readonly DependencyProperty WindowLeftProperty;

	public static readonly DependencyProperty WindowTopProperty;

	public static readonly DependencyProperty ShowSearchInProperty;

	public static readonly DependencyProperty AllowReplaceProperty;

	public static readonly DependencyProperty OwnerWindowProperty;

	internal static FindReplaceMgr vk4HNeX4IaOKgUJi1Cw;

	public CommandBinding FindBinding => new CommandBinding(ApplicationCommands.Find, qnFSwe9RLI);

	public CommandBinding FindNextBinding => new CommandBinding(NavigationCommands.Search, sOVStPdAsf);

	public CommandBinding ReplaceBinding => new CommandBinding(ApplicationCommands.Replace, rPmSg9N0Jw);

	public IEnumerable Editors
	{
		get
		{
			return (IEnumerable)GetValue(EditorsProperty);
		}
		set
		{
			SetValue(EditorsProperty, value);
		}
	}

	public object CurrentEditor
	{
		get
		{
			return GetValue(CurrentEditorProperty);
		}
		set
		{
			SetValue(CurrentEditorProperty, value);
		}
	}

	public IValueConverter InterfaceConverter
	{
		get
		{
			return (IValueConverter)GetValue(InterfaceConverterProperty);
		}
		set
		{
			SetValue(InterfaceConverterProperty, value);
		}
	}

	public string TextToFind
	{
		get
		{
			return (string)GetValue(TextToFindProperty);
		}
		set
		{
			SetValue(TextToFindProperty, value);
		}
	}

	public string ReplacementText
	{
		get
		{
			return (string)GetValue(ReplacementTextProperty);
		}
		set
		{
			SetValue(ReplacementTextProperty, value);
		}
	}

	public bool UseWildcards
	{
		get
		{
			return (bool)GetValue(UseWildcardsProperty);
		}
		set
		{
			SetValue(UseWildcardsProperty, value);
		}
	}

	public bool SearchUp
	{
		get
		{
			return (bool)GetValue(SearchUpProperty);
		}
		set
		{
			SetValue(SearchUpProperty, value);
		}
	}

	public bool CaseSensitive
	{
		get
		{
			return (bool)GetValue(CaseSensitiveProperty);
		}
		set
		{
			SetValue(CaseSensitiveProperty, value);
		}
	}

	public bool UseRegEx
	{
		get
		{
			return (bool)GetValue(UseRegExProperty);
		}
		set
		{
			SetValue(UseRegExProperty, value);
		}
	}

	public bool WholeWord
	{
		get
		{
			return (bool)GetValue(WholeWordProperty);
		}
		set
		{
			SetValue(WholeWordProperty, value);
		}
	}

	public bool AcceptsReturn
	{
		get
		{
			return (bool)GetValue(AcceptsReturnProperty);
		}
		set
		{
			SetValue(AcceptsReturnProperty, value);
		}
	}

	public SearchScope SearchIn
	{
		get
		{
			return (SearchScope)GetValue(SearchInProperty);
		}
		set
		{
			SetValue(SearchInProperty, value);
		}
	}

	public double WindowLeft
	{
		get
		{
			return (double)GetValue(WindowLeftProperty);
		}
		set
		{
			SetValue(WindowLeftProperty, value);
		}
	}

	public double WindowTop
	{
		get
		{
			return (double)GetValue(WindowTopProperty);
		}
		set
		{
			SetValue(WindowTopProperty, value);
		}
	}

	public bool ShowSearchIn
	{
		get
		{
			return (bool)GetValue(ShowSearchInProperty);
		}
		set
		{
			SetValue(ShowSearchInProperty, value);
		}
	}

	public bool AllowReplace
	{
		get
		{
			return (bool)GetValue(AllowReplaceProperty);
		}
		set
		{
			SetValue(AllowReplaceProperty, value);
		}
	}

	public Window OwnerWindow
	{
		get
		{
			return (Window)GetValue(OwnerWindowProperty);
		}
		set
		{
			SetValue(OwnerWindowProperty, value);
		}
	}

	[SpecialName]
	private FindReplaceDialog uhWSLiDTym()
	{
		if (QMQSSMa9eW == null)
		{
			QMQSSMa9eW = new FindReplaceDialog(this);
			QMQSSMa9eW.Closed += FHevzAeiZt;
			if (OwnerWindow != null)
			{
				QMQSSMa9eW.Owner = OwnerWindow;
				QMQSSMa9eW.Left = OwnerWindow.Left + OwnerWindow.Width - 100.0;
				QMQSSMa9eW.Top = OwnerWindow.Top + OwnerWindow.Height - 150.0;
			}
		}
		return QMQSSMa9eW;
	}

	public FindReplaceMgr()
	{
		ReplacementText = "";
		SearchIn = SearchScope.CurrentDocument;
		ShowSearchIn = true;
	}

	private IEditor CHuviWyF9M()
	{
		if (CurrentEditor == null)
		{
			return null;
		}
		if (CurrentEditor is IEditor)
		{
			return CurrentEditor as IEditor;
		}
		if (InterfaceConverter == null)
		{
			return null;
		}
		return InterfaceConverter.Convert(CurrentEditor, typeof(IEditor), null, CultureInfo.CurrentCulture) as IEditor;
	}

	private IEditor UsDv3aX3CX(bool bool_0 = false)
	{
		if (ShowSearchIn && SearchIn != SearchScope.CurrentDocument && Editors != null)
		{
			List<object> list = new List<object>(Editors.Cast<object>());
			int num = list.IndexOf(CurrentEditor);
			if (num >= 0)
			{
				num = (num + ((!bool_0) ? 1 : (list.Count - 1))) % list.Count;
				CurrentEditor = list[num];
			}
			return CHuviWyF9M();
		}
		return CHuviWyF9M();
	}

	public Regex GetRegEx(bool ForceLeftToRight = false)
	{
		RegexOptions regexOptions;
		while (true)
		{
			regexOptions = RegexOptions.None;
			if (oecvPhXhOU1ge1Dl4xh())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (SearchUp && !ForceLeftToRight)
		{
			regexOptions |= RegexOptions.RightToLeft;
		}
		if (!CaseSensitive)
		{
			regexOptions |= RegexOptions.IgnoreCase;
		}
		if (UseRegEx)
		{
			return new Regex(TextToFind, regexOptions);
		}
		string text = Regex.Escape(TextToFind);
		if (UseWildcards)
		{
			text = text.Replace("\\*", ".*").Replace("\\?", ".");
		}
		if (WholeWord)
		{
			text = "\\b" + text + "\\b";
		}
		return new Regex(text, regexOptions);
	}

	public void ReplaceAll(bool AskBefore = true)
	{
		IEditor editor = CHuviWyF9M();
		if (editor == null)
		{
			int num = 0;
			if (!oecvPhXhOU1ge1Dl4xh())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			if (AskBefore && MessageBoxHelper.Show("您确认要把所有的 '" + TextToFind + "' 替换为 '" + ReplacementText + "' 么?", "替换全部", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
			{
				return;
			}
			object currentEditor = CurrentEditor;
			int num5 = default(int);
			do
			{
				Regex regEx = GetRegEx(true);
				int num3 = 0;
				editor.BeginChange();
				foreach (Match item in regEx.Matches(editor.Text))
				{
					if (UseRegEx)
					{
						int num4 = 0;
						if (!oecvPhXhOU1ge1Dl4xh())
						{
							num4 = num5;
						}
						switch (num4)
						{
						}
						string text = item.Result(ReplacementText);
						editor.Replace(num3 + item.Index, item.Length, text);
						num3 += text.Length - item.Length;
					}
					else
					{
						editor.Replace(num3 + item.Index, item.Length, ReplacementText);
						num3 += ReplacementText.Length - item.Length;
					}
				}
				editor.EndChange();
				editor = UsDv3aX3CX(false);
			}
			while (CurrentEditor != currentEditor);
		}
	}

	public void ShowAsFind()
	{
		kqvvfT4QrF();
		uhWSLiDTym().tabMain.SelectedIndex = 0;
		uhWSLiDTym().Show();
		uhWSLiDTym().Activate();
		uhWSLiDTym().txtFind.Focus();
		uhWSLiDTym().txtFind.SelectAll();
	}

	private void kqvvfT4QrF()
	{
		if (string.IsNullOrEmpty(TextToFind))
		{
			TextToFind = CHuviWyF9M().SelectedText;
		}
	}

	public void ShowAsFind(TextEditor target)
	{
		CurrentEditor = target;
		ShowAsFind();
	}

	public void ShowAsReplace()
	{
		kqvvfT4QrF();
		uhWSLiDTym().tabMain.SelectedIndex = 1;
		uhWSLiDTym().Show();
		uhWSLiDTym().Activate();
		uhWSLiDTym().txtFind2.Focus();
		uhWSLiDTym().txtFind2.SelectAll();
	}

	public void ShowAsReplace(object target)
	{
		CurrentEditor = target;
		ShowAsReplace();
	}

	public void FindNext(object target, bool InvertLeftRight = false)
	{
		CurrentEditor = target;
		FindNext(InvertLeftRight);
	}

	public void FindNext(bool InvertLeftRight = false)
	{
		IEditor editor = CHuviWyF9M();
		if (editor == null)
		{
			return;
		}
		Regex regEx;
		if (InvertLeftRight)
		{
			SearchUp = !SearchUp;
			regEx = GetRegEx(false);
			SearchUp = !SearchUp;
		}
		else
		{
			regEx = GetRegEx(false);
		}
		Match match = regEx.Match(editor.Text, regEx.Options.HasFlag(RegexOptions.RightToLeft) ? editor.SelectionStart : (editor.SelectionStart + editor.SelectionLength));
		if (match.Success)
		{
			editor.Select(match.Index, match.Length);
			return;
		}
		object currentEditor = CurrentEditor;
		int num2 = default(int);
		while (true)
		{
			if (ShowSearchIn)
			{
				editor = UsDv3aX3CX(regEx.Options.HasFlag(RegexOptions.RightToLeft));
				if (editor == null)
				{
					break;
				}
			}
			int num;
			if (regEx.Options.HasFlag(RegexOptions.RightToLeft))
			{
				match = regEx.Match(editor.Text, editor.Text.Length);
				num = 0;
				if (vk4HNeX4IaOKgUJi1Cw != null)
				{
					num = num2;
				}
				goto IL_0134;
			}
			match = regEx.Match(editor.Text, 0);
			goto IL_010a;
			IL_0134:
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_010a;
			IL_010a:
			if (match.Success)
			{
				editor.Select(match.Index, match.Length);
				num = 1;
				if (oecvPhXhOU1ge1Dl4xh())
				{
					break;
				}
				goto IL_0134;
			}
			if (CurrentEditor == currentEditor)
			{
				break;
			}
		}
	}

	public void FindPrevious()
	{
		FindNext(true);
	}

	public void Replace()
	{
		int num = 1;
		while (true)
		{
			IEditor editor = CHuviWyF9M();
			int num2 = 0;
			if (!oecvPhXhOU1ge1Dl4xh())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (editor == null)
			{
				return;
			}
			Regex regEx = GetRegEx(false);
			string text = editor.Text.Substring(editor.SelectionStart, editor.SelectionLength);
			Match match = regEx.Match(text);
			if (match.Success && match.Index == 0 && match.Length == text.Length)
			{
				if (UseRegEx)
				{
					string replaceWith = match.Result(ReplacementText);
					editor.Replace(editor.SelectionStart, editor.SelectionLength, replaceWith);
				}
				else
				{
					editor.Replace(editor.SelectionStart, editor.SelectionLength, ReplacementText);
				}
			}
			FindNext(false);
			return;
		}
	}

	public void CloseWindow()
	{
		uhWSLiDTym().Close();
	}

	static FindReplaceMgr()
	{
		EditorsProperty = DependencyProperty.Register("Editors", typeof(global::System.Collections.IEnumerable), typeof(FindReplaceMgr), new PropertyMetadata(null));
		CurrentEditorProperty = DependencyProperty.Register("CurrentEditor", typeof(object), typeof(FindReplaceMgr), new PropertyMetadata(0));
		InterfaceConverterProperty = DependencyProperty.Register("InterfaceConverter", typeof(IValueConverter), typeof(FindReplaceMgr), new PropertyMetadata(null));
		TextToFindProperty = DependencyProperty.Register("TextToFind", typeof(string), typeof(FindReplaceMgr), new UIPropertyMetadata(""));
		ReplacementTextProperty = DependencyProperty.Register("ReplacementText", typeof(string), typeof(FindReplaceMgr), new UIPropertyMetadata(""));
		UseWildcardsProperty = DependencyProperty.Register("UseWildcards", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		SearchUpProperty = DependencyProperty.Register("SearchUp", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		CaseSensitiveProperty = DependencyProperty.Register("CaseSensitive", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		UseRegExProperty = DependencyProperty.Register("UseRegEx", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		WholeWordProperty = DependencyProperty.Register("WholeWord", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		AcceptsReturnProperty = DependencyProperty.Register("AcceptsReturn", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(false));
		SearchInProperty = DependencyProperty.Register("SearchIn", typeof(SearchScope), typeof(FindReplaceMgr), new UIPropertyMetadata(SearchScope.CurrentDocument));
		WindowLeftProperty = DependencyProperty.Register("WindowLeft", typeof(double), typeof(FindReplaceMgr), new UIPropertyMetadata(100.0));
		WindowTopProperty = DependencyProperty.Register("WindowTop", typeof(double), typeof(FindReplaceMgr), new UIPropertyMetadata(100.0));
		ShowSearchInProperty = DependencyProperty.Register("ShowSearchIn", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(true));
		AllowReplaceProperty = DependencyProperty.Register("AllowReplace", typeof(bool), typeof(FindReplaceMgr), new UIPropertyMetadata(true));
		OwnerWindowProperty = DependencyProperty.Register("OwnerWindow", typeof(Window), typeof(FindReplaceMgr), new UIPropertyMetadata(null));
	}

	[CompilerGenerated]
	private void FHevzAeiZt(object sender, EventArgs e)
	{
		QMQSSMa9eW = null;
	}

	[CompilerGenerated]
	private void qnFSwe9RLI(object sender, ExecutedRoutedEventArgs e)
	{
		ShowAsFind();
	}

	[CompilerGenerated]
	private void sOVStPdAsf(object sender, ExecutedRoutedEventArgs e)
	{
		FindNext(e.Parameter != null);
	}

	[CompilerGenerated]
	private void rPmSg9N0Jw(object sender, ExecutedRoutedEventArgs e)
	{
		if (AllowReplace)
		{
			ShowAsReplace();
		}
	}

	internal static bool oecvPhXhOU1ge1Dl4xh()
	{
		return vk4HNeX4IaOKgUJi1Cw == null;
	}
}
