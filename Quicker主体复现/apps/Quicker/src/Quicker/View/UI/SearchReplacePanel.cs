using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Search;
using jP9eLNYkQPso3EI6Xbd;
using KsKQKDYDnyRDpdFryrh;
using log4net;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.UI;

public class SearchReplacePanel : Control
{
	private class TqGqhVDWl2mutbnfsRi : TextAreaInputHandler
	{
		private readonly SearchReplacePanel PkUS5H7KSX0;

		private static TqGqhVDWl2mutbnfsRi y4xOWTWwmdO2NKdhvkLx;

		internal TqGqhVDWl2mutbnfsRi(TextArea textArea_0, SearchReplacePanel searchReplacePanel_1)
			: base(textArea_0)
		{
			Y7eS5coT6xU();
			PkUS5H7KSX0 = searchReplacePanel_1;
		}

		private void Y7eS5coT6xU()
		{
			base.CommandBindings.Add(new CommandBinding(ApplicationCommands.Find, OQGS5VmnZRH));
			base.CommandBindings.Add(new CommandBinding(ApplicationCommands.Replace, LnrS5ZAAciI));
			base.CommandBindings.Add(new CommandBinding(SearchCommands.FindNext, Q31S5euh55o, qOTS5hdU6vZ));
			base.CommandBindings.Add(new CommandBinding(SearchCommands.FindPrevious, OTDS5YFjK0j, qOTS5hdU6vZ));
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ReplaceNext, VIIS5IPNbGk, qOTS5hdU6vZ));
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ReplaceAll, lQJS5W6ZAK9, qOTS5hdU6vZ));
			base.CommandBindings.Add(new CommandBinding(SearchCommands.CloseSearchPanel, VTuS5k9m4L0, qOTS5hdU6vZ));
		}

		private void OQGS5VmnZRH(object sender, ExecutedRoutedEventArgs e)
		{
			UplS599smCf(false);
		}

		private void LnrS5ZAAciI(object sender, ExecutedRoutedEventArgs e)
		{
			UplS599smCf(true);
		}

		private void UplS599smCf(bool bool_0)
		{
			PkUS5H7KSX0.IsReplaceMode = bool_0;
			if (!base.TextArea.Selection.IsEmpty && !base.TextArea.Selection.IsMultiline)
			{
				PkUS5H7KSX0.SearchPattern = base.TextArea.Selection.GetText();
			}
			PkUS5H7KSX0.Open();
			base.TextArea.Dispatcher.InvokeAsync(sI4S5sQDPq0, DispatcherPriority.Input);
		}

		private void qOTS5hdU6vZ(object sender, CanExecuteRoutedEventArgs e)
		{
			if (PkUS5H7KSX0.IsClosed)
			{
				e.CanExecute = false;
				e.ContinueRouting = true;
			}
			else
			{
				e.CanExecute = true;
				e.Handled = true;
			}
		}

		private void Q31S5euh55o(object sender, ExecutedRoutedEventArgs e)
		{
			if (!PkUS5H7KSX0.IsClosed)
			{
				PkUS5H7KSX0.FindNext();
				e.Handled = true;
			}
		}

		private void OTDS5YFjK0j(object sender, ExecutedRoutedEventArgs e)
		{
			if (!PkUS5H7KSX0.IsClosed)
			{
				PkUS5H7KSX0.FindPrevious();
				e.Handled = true;
			}
		}

		private void VIIS5IPNbGk(object sender, ExecutedRoutedEventArgs e)
		{
			if (!PkUS5H7KSX0.IsClosed)
			{
				PkUS5H7KSX0.ReplaceNext();
				e.Handled = true;
			}
		}

		private void lQJS5W6ZAK9(object sender, ExecutedRoutedEventArgs e)
		{
			if (!PkUS5H7KSX0.IsClosed)
			{
				PkUS5H7KSX0.ReplaceAll();
				e.Handled = true;
			}
		}

		private void VTuS5k9m4L0(object sender, ExecutedRoutedEventArgs e)
		{
			if (!PkUS5H7KSX0.IsClosed)
			{
				PkUS5H7KSX0.Close();
				e.Handled = true;
			}
		}

		internal void Q9wS5G67v17(CommandBindingCollection commandBindingCollection_0)
		{
			commandBindingCollection_0.Add(new CommandBinding(ApplicationCommands.Find, OQGS5VmnZRH));
			commandBindingCollection_0.Add(new CommandBinding(SearchCommands.FindNext, Q31S5euh55o, qOTS5hdU6vZ));
			commandBindingCollection_0.Add(new CommandBinding(SearchCommands.FindPrevious, OTDS5YFjK0j, qOTS5hdU6vZ));
		}

		[CompilerGenerated]
		private void sI4S5sQDPq0()
		{
			PkUS5H7KSX0.Reactivate();
		}

		internal static bool z7mgsyWws8ao3KPgGMsv()
		{
			return y4xOWTWwmdO2NKdhvkLx == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ORhS5mrtoK1;

		public static CanExecuteRoutedEventHandler tVDS5K3BtGu;

		public static CanExecuteRoutedEventHandler jnUS5xPLTuK;

		public static CanExecuteRoutedEventHandler uO8S5rS64M6;

		public static Func<ISearchResult, int> qweS5pyc3k9;

		private static _003C_003Ec DpkmXnWwHyRosT4iSeDY;

		static _003C_003Ec()
		{
			ORhS5mrtoK1 = new _003C_003Ec();
		}

		internal void j59S51xSakR(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		internal void boaS5bsBCKQ(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		internal void jNMS56JFCAY(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		internal int fGxS5XpJ0Sj(ISearchResult x)
		{
			return x.EndOffset;
		}

		internal static bool kjlgOBWwzMrnwpe5d4Ud()
		{
			return DpkmXnWwHyRosT4iSeDY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public SearchReplacePanel c9WS5QvJeoo;

		public ISearchResult APwS5j7vG0c;

		internal static _003C_003Ec__DisplayClass53_0 Go0a5fWTQdhy0SlOwJmd;

		internal bool CivS5Bkx5QK(ISearchResult r)
		{
			if (r.Offset >= c9WS5QvJeoo.OyjLytY0eiN.Caret.Offset)
			{
				return r != APwS5j7vG0c;
			}
			return false;
		}

		internal static bool nEVGy2WTFbT0mhSs4Bhu()
		{
			return Go0a5fWTQdhy0SlOwJmd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public SearchReplacePanel H9uS54Pj61q;

		public ISearchResult xfiS55lAfh9;

		private static _003C_003Ec__DisplayClass54_0 HWJKocWTWb23ZfDWTqLe;

		internal bool FdvS5nbog7R(ISearchResult r)
		{
			if (r.EndOffset <= H9uS54Pj61q.OyjLytY0eiN.Caret.Offset)
			{
				return r != xfiS55lAfh9;
			}
			return false;
		}

		internal static bool nRIcsNWTyTN4o7GW2c2n()
		{
			return HWJKocWTWb23ZfDWTqLe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass83_0
	{
		public int wDQS5dW3rV4;

		public int aGHS5o8rMlp;

		internal static _003C_003Ec__DisplayClass83_0 aIBiioWTXRwUdoDK0chk;

		internal bool U2GS5Dov5b9(ISearchResult r)
		{
			if (r.Offset == wDQS5dW3rV4)
			{
				return r.Length == aGHS5o8rMlp;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass83_0()
		{
		}

		internal static bool z2dO8mWT2u7yjnaJH8SZ()
		{
			return aIBiioWTXRwUdoDK0chk == null;
		}

		internal static void Em7Ya5WTn86l6Nqas6BJ()
		{
		}
	}

	private TextArea OyjLytY0eiN;

	private TqGqhVDWl2mutbnfsRi vIYLygskSpB;

	private TextDocument lasLyLt6SbX;

	private HBo1sHYHV6mQfeeD9Mu lXVLyv0gGgW;

	private TextBox? IT9LySZpWmG;

	private TextBox? eZGLy2uLACW;

	private hbxhvJYugdojNUIhcED tJfLyuW7m28;

	private ISearchStrategy H0ILyN2pCoL;

	private readonly ToolTip vTbLyJv1Jsk = new ToolTip
	{
		Placement = PlacementMode.Bottom,
		StaysOpen = false,
		Focusable = false
	};

	private static readonly ILog nkJLy0nkgB8;

	public static readonly DependencyProperty UseRegexProperty;

	public static readonly DependencyProperty MatchCaseProperty;

	public static readonly DependencyProperty WholeWordsProperty;

	public static readonly DependencyProperty SearchPatternProperty;

	public static readonly DependencyProperty MarkerBrushProperty;

	public static readonly DependencyProperty LocalizationProperty;

	public static readonly DependencyProperty SearchResultInfoProperty;

	[CompilerGenerated]
	private bool XCMLyCEbm9j;

	[CompilerGenerated]
	private EventHandler<SearchOptionsChangedEventArgs> IkWLyPePPQB;

	public static readonly DependencyProperty IsReplaceModeProperty;

	public static readonly DependencyProperty ReplacePatternProperty;

	private TextEditor Fu5LyE5oGYF;

	private static SearchReplacePanel qTlHfoFGXtvut9quWWJn;

	public bool UseRegex
	{
		get
		{
			return (bool)GetValue(UseRegexProperty);
		}
		set
		{
			SetValue(UseRegexProperty, value);
		}
	}

	public bool MatchCase
	{
		get
		{
			return (bool)GetValue(MatchCaseProperty);
		}
		set
		{
			SetValue(MatchCaseProperty, value);
		}
	}

	public bool WholeWords
	{
		get
		{
			return (bool)GetValue(WholeWordsProperty);
		}
		set
		{
			SetValue(WholeWordsProperty, value);
		}
	}

	public string SearchPattern
	{
		get
		{
			return (string)GetValue(SearchPatternProperty);
		}
		set
		{
			SetValue(SearchPatternProperty, value);
		}
	}

	public Brush MarkerBrush
	{
		get
		{
			return (Brush)GetValue(MarkerBrushProperty);
		}
		set
		{
			SetValue(MarkerBrushProperty, value);
		}
	}

	public ICSharpCode.AvalonEdit.Search.Localization Localization
	{
		get
		{
			return (ICSharpCode.AvalonEdit.Search.Localization)GetValue(LocalizationProperty);
		}
		set
		{
			SetValue(LocalizationProperty, value);
		}
	}

	public string SearchResultInfo
	{
		get
		{
			return (string)GetValue(SearchResultInfoProperty);
		}
		set
		{
			SetValue(SearchResultInfoProperty, value);
		}
	}

	public bool IsClosed
	{
		[CompilerGenerated]
		get
		{
			return XCMLyCEbm9j;
		}
		[CompilerGenerated]
		private set
		{
			XCMLyCEbm9j = value;
		}
	}

	public bool IsReplaceMode
	{
		get
		{
			return (bool)GetValue(IsReplaceModeProperty);
		}
		set
		{
			SetValue(IsReplaceModeProperty, value);
		}
	}

	public string ReplacePattern
	{
		get
		{
			return (string)GetValue(ReplacePatternProperty);
		}
		set
		{
			SetValue(ReplacePatternProperty, value);
		}
	}

	public event EventHandler<SearchOptionsChangedEventArgs> SearchOptionsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<SearchOptionsChangedEventArgs> eventHandler = IkWLyPePPQB;
			EventHandler<SearchOptionsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SearchOptionsChangedEventArgs> value2 = (EventHandler<SearchOptionsChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IkWLyPePPQB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<SearchOptionsChangedEventArgs> eventHandler = IkWLyPePPQB;
			EventHandler<SearchOptionsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<SearchOptionsChangedEventArgs> value2 = (EventHandler<SearchOptionsChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IkWLyPePPQB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private static void KKlLE1pGsRL(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is SearchReplacePanel { lXVLyv0gGgW: not null } searchReplacePanel)
		{
			searchReplacePanel.lXVLyv0gGgW.MarkerBrush = (Brush)dependencyPropertyChangedEventArgs_0.NewValue;
		}
	}

	static SearchReplacePanel()
	{
		nkJLy0nkgB8 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		UseRegexProperty = DependencyProperty.Register("UseRegex", typeof(bool), typeof(SearchReplacePanel), new FrameworkPropertyMetadata(false, PL1LEbOibva));
		MatchCaseProperty = DependencyProperty.Register("MatchCase", typeof(bool), typeof(SearchReplacePanel), new FrameworkPropertyMetadata(false, PL1LEbOibva));
		WholeWordsProperty = DependencyProperty.Register("WholeWords", typeof(bool), typeof(SearchReplacePanel), new FrameworkPropertyMetadata(false, PL1LEbOibva));
		SearchPatternProperty = DependencyProperty.Register("SearchPattern", typeof(string), typeof(SearchReplacePanel), new FrameworkPropertyMetadata("", PL1LEbOibva));
		MarkerBrushProperty = DependencyProperty.Register("MarkerBrush", typeof(Brush), typeof(SearchReplacePanel), new FrameworkPropertyMetadata(Brushes.LightGreen, KKlLE1pGsRL));
		LocalizationProperty = DependencyProperty.Register("Localization", typeof(ICSharpCode.AvalonEdit.Search.Localization), typeof(SearchReplacePanel), new FrameworkPropertyMetadata(new ICSharpCode.AvalonEdit.Search.Localization()));
		SearchResultInfoProperty = DependencyProperty.Register("SearchResultInfo", typeof(string), typeof(SearchReplacePanel), new PropertyMetadata((object)null));
		IsReplaceModeProperty = DependencyProperty.Register("IsReplaceMode", typeof(bool), typeof(SearchReplacePanel), new FrameworkPropertyMetadata());
		ReplacePatternProperty = DependencyProperty.Register("ReplacePattern", typeof(string), typeof(SearchReplacePanel), new FrameworkPropertyMetadata());
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchReplacePanel), new FrameworkPropertyMetadata(typeof(SearchReplacePanel)));
	}

	private static void PL1LEbOibva(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is SearchReplacePanel searchReplacePanel && searchReplacePanel.abwLEpl8C7Q())
		{
			try
			{
				searchReplacePanel.jeZLEXh3E90();
			}
			catch (Exception ex)
			{
				searchReplacePanel.psKLE6Mq8yb(ex.Message);
			}
		}
	}

	private void psKLE6Mq8yb(string string_0)
	{
		vTbLyJv1Jsk.Content = string_0;
		vTbLyJv1Jsk.IsOpen = true;
	}

	private void jeZLEXh3E90()
	{
		try
		{
			if (lXVLyv0gGgW.gCpLy947FEV().Any())
			{
				vTbLyJv1Jsk.IsOpen = false;
			}
			string searchPattern = SearchPattern ?? "";
			H0ILyN2pCoL = SearchStrategyFactory.Create(searchPattern, !MatchCase, WholeWords, UseRegex ? SearchMode.RegEx : SearchMode.Normal);
			OnSearchOptionsChanged(new SearchOptionsChangedEventArgs(searchPattern, MatchCase, UseRegex, WholeWords));
			l4tLEBIA9V0(true);
		}
		catch (Exception ex)
		{
			psKLE6Mq8yb(ex.Message);
		}
	}

	private SearchReplacePanel()
	{
	}

	public void RegisterCommands(CommandBindingCollection commandBindings)
	{
		vIYLygskSpB.Q9wS5G67v17(commandBindings);
	}

	public void Uninstall()
	{
		BbhLE496Sw5();
		OyjLytY0eiN.DefaultInputHandler.NestedInputHandlers.Remove(vIYLygskSpB);
	}

	private void L5ULEmghWTO(TextArea textArea_1)
	{
		OyjLytY0eiN = textArea_1;
		tJfLyuW7m28 = new hbxhvJYugdojNUIhcED(textArea_1, this);
		base.DataContext = this;
		lXVLyv0gGgW = new HBo1sHYHV6mQfeeD9Mu();
		lXVLyv0gGgW.MarkerBrush = MarkerBrush;
		lasLyLt6SbX = textArea_1.Document;
		if (lasLyLt6SbX != null)
		{
			lasLyLt6SbX.TextChanged += KqxLExNqJyM;
		}
		textArea_1.DocumentChanged += pITLEKCtL5c;
		base.KeyDown += TpCLEnwQyKi;
		base.CommandBindings.Add(new CommandBinding(SearchCommands.FindNext, Qi7LEoVGHcU));
		base.CommandBindings.Add(new CommandBinding(SearchCommands.FindPrevious, opLLETZDyeB));
		base.CommandBindings.Add(new CommandBinding(SearchCommands.CloseSearchPanel, drsLEMeck6W));
		base.CommandBindings.Add(new CommandBinding(ApplicationCommands.Find, sqcLEAnOYva));
		base.CommandBindings.Add(new CommandBinding(ApplicationCommands.Replace, crVLEOj2y10));
		base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ReplaceNext, y6YLEFb2Aea, tkhLEU3IMYr));
		int num = 0;
		if (!b41DiaFG25A1vXoqmH2Y())
		{
			goto IL_0278;
		}
		goto IL_027c;
		IL_027c:
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ReplaceAll, pR2LElfTnjb, U3dLEi7nnYm));
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ToggleMatchCase, ej1LE3t3etx, _003C_003Ec.tVDS5K3BtGu ?? (_003C_003Ec.tVDS5K3BtGu = _003C_003Ec.ORhS5mrtoK1.j59S51xSakR)));
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ToggleWholeWords, XrjLEfrBNJs, _003C_003Ec.jnUS5xPLTuK ?? (_003C_003Ec.jnUS5xPLTuK = _003C_003Ec.ORhS5mrtoK1.boaS5bsBCKQ)));
			base.CommandBindings.Add(new CommandBinding(SearchCommandsEx.ToggleUseRegex, enmLEzvXGYp, _003C_003Ec.uO8S5rS64M6 ?? (_003C_003Ec.uO8S5rS64M6 = _003C_003Ec.ORhS5mrtoK1.jNMS56JFCAY)));
			IsClosed = true;
			num = 1;
			if (b41DiaFG25A1vXoqmH2Y())
			{
				continue;
			}
			break;
		}
		goto IL_0278;
		IL_0278:
		int num2 = default(int);
		num = num2;
		goto IL_027c;
	}

	private void pITLEKCtL5c(object? sender, EventArgs e)
	{
		if (lasLyLt6SbX != null)
		{
			lasLyLt6SbX.TextChanged -= KqxLExNqJyM;
		}
		lasLyLt6SbX = OyjLytY0eiN.Document;
		if (lasLyLt6SbX != null)
		{
			lasLyLt6SbX.TextChanged += KqxLExNqJyM;
			l4tLEBIA9V0(false);
		}
	}

	private void KqxLExNqJyM(object? sender, EventArgs e)
	{
		l4tLEBIA9V0(false);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		IT9LySZpWmG = base.Template.FindName("PART_searchTextBox", this) as TextBox;
		IT9LySZpWmG.PreviewKeyDown += v23LEr28xWk;
		eZGLy2uLACW = base.Template.FindName("ReplaceBox", this) as TextBox;
		eZGLy2uLACW.PreviewKeyDown += v23LEr28xWk;
	}

	private void v23LEr28xWk(object sender, KeyEventArgs e)
	{
		if (e.Key != Key.Return)
		{
			return;
		}
		if (Keyboard.Modifiers == ModifierKeys.Control)
		{
			if (!(sender is TextBox textBox))
			{
				return;
			}
			if (b41DiaFG25A1vXoqmH2Y())
			{
				switch (0)
				{
				}
			}
			textBox.AppendText("\r\n");
			textBox.CaretIndex += 2;
		}
		else
		{
			e.Handled = true;
			if (IsReplaceMode)
			{
				ReplaceNext();
			}
			else
			{
				FindNext();
			}
		}
	}

	private bool abwLEpl8C7Q()
	{
		if (IT9LySZpWmG == null)
		{
			return false;
		}
		BindingExpression bindingExpression = IT9LySZpWmG.GetBindingExpression(TextBox.TextProperty);
		try
		{
			Validation.ClearInvalid(bindingExpression);
			jeZLEXh3E90();
			return true;
		}
		catch (SearchPatternException ex)
		{
			ValidationError validationError = new ValidationError(bindingExpression.ParentBinding.ValidationRules.FirstOrDefault() ?? new NotifyDataErrorValidationRule(), bindingExpression, ex.Message, ex);
			Validation.MarkInvalid(bindingExpression, validationError);
			vTbLyJv1Jsk.Content = ex.Message;
			vTbLyJv1Jsk.IsOpen = true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public void Reactivate()
	{
		if (IT9LySZpWmG != null)
		{
			IT9LySZpWmG.Focus();
			IT9LySZpWmG.SelectAll();
		}
	}

	public void FindNext()
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		_003C_003Ec__DisplayClass53_.c9WS5QvJeoo = this;
		_003C_003Ec__DisplayClass53_.APwS5j7vG0c = hxVLEdC15vu();
		ISearchResult searchResult = lXVLyv0gGgW.gCpLy947FEV().FirstOrDefault(_003C_003Ec__DisplayClass53_.CivS5Bkx5QK) ?? lXVLyv0gGgW.gCpLy947FEV().FirstOrDefault();
		if (searchResult != null)
		{
			xrVLEQ3xk61(searchResult);
		}
	}

	public void FindPrevious()
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.H9uS54Pj61q = this;
		_003C_003Ec__DisplayClass54_.xfiS55lAfh9 = hxVLEdC15vu();
		ISearchResult searchResult = lXVLyv0gGgW.gCpLy947FEV().LastOrDefault(_003C_003Ec__DisplayClass54_.FdvS5nbog7R) ?? lXVLyv0gGgW.gCpLy947FEV().LastOrDefault();
		if (searchResult != null)
		{
			xrVLEQ3xk61(searchResult);
		}
	}

	private void l4tLEBIA9V0(bool bool_1)
	{
		if (IsClosed)
		{
			return;
		}
		try
		{
        ISearchResult isearchResult_ = default;
			lXVLyv0gGgW.gCpLy947FEV().Clear();
			SearchResultInfo = "";
			int offset;
			int num;
			if (!string.IsNullOrEmpty(SearchPattern))
			{
				offset = OyjLytY0eiN.Caret.Offset;
				if (!bool_1)
				{
					goto IL_0072;
				}
				num = 1;
				if (qTlHfoFGXtvut9quWWJn == null)
				{
					goto IL_0058;
				}
				goto IL_0081;
			}
			vTbLyJv1Jsk.IsOpen = false;
			goto IL_01ad;
			IL_0072:
			isearchResult_ = null;
			num = 0;
			if (b41DiaFG25A1vXoqmH2Y())
			{
				goto IL_0058;
			}
			goto IL_0081;
			IL_01ad:
			OyjLytY0eiN.TextView.InvalidateLayer(KnownLayer.Selection);
			return;
			IL_0084:
			foreach (ISearchResult item in H0ILyN2pCoL.FindAll(OyjLytY0eiN.Document, 0, OyjLytY0eiN.Document.TextLength))
			{
				if (bool_1 && item.Offset >= offset)
				{
					xrVLEQ3xk61(item);
					isearchResult_ = item;
					bool_1 = false;
				}
				lXVLyv0gGgW.gCpLy947FEV().Add(item);
			}
			if (!lXVLyv0gGgW.gCpLy947FEV().Any())
			{
				vTbLyJv1Jsk.IsOpen = true;
				vTbLyJv1Jsk.Content = Localization.NoMatchesFoundText;
				vTbLyJv1Jsk.PlacementTarget = IT9LySZpWmG;
			}
			else
			{
				vTbLyJv1Jsk.IsOpen = true;
				vTbLyJv1Jsk.Content = $"共找到 {lXVLyv0gGgW.gCpLy947FEV().Count} 项";
				vTbLyJv1Jsk.PlacementTarget = IT9LySZpWmG;
				vTbLyJv1Jsk.Placement = PlacementMode.Top;
			}
			fM7LEjPZOpg(isearchResult_);
			goto IL_01ad;
			IL_0081:
			int num2 = default(int);
			num = num2;
			goto IL_0058;
			IL_0058:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0084;
			}
			OyjLytY0eiN.ClearSelection();
			goto IL_0072;
		}
		catch (Exception ex)
		{
			nkJLy0nkgB8.Warn("查找替换出错：" + ex.Message, ex);
			AppHelper.ShowWarning("发生了内部错误。" + ex.Message);
		}
	}

	private void xrVLEQ3xk61(ISearchResult isearchResult_0)
	{
		OyjLytY0eiN.Caret.Offset = isearchResult_0.Offset;
		OyjLytY0eiN.Selection = Selection.Create(OyjLytY0eiN, isearchResult_0.Offset, isearchResult_0.EndOffset);
		TextLocation location = OyjLytY0eiN.Document.GetLocation(isearchResult_0.Offset);
		Fu5LyE5oGYF.ScrollTo(location.Line, location.Column);
		OyjLytY0eiN.Caret.Show();
		fM7LEjPZOpg(isearchResult_0);
	}

	private void fM7LEjPZOpg(ISearchResult isearchResult_0)
	{
		if (isearchResult_0 == null)
		{
			SearchResultInfo = "";
			return;
		}
		try
		{
			int num = lXVLyv0gGgW.gCpLy947FEV().IndexOf(isearchResult_0);
			SearchResultInfo = $"{num + 1}/{lXVLyv0gGgW.gCpLy947FEV().Count}";
		}
		catch
		{
		}
	}

	private void TpCLEnwQyKi(object sender, KeyEventArgs e)
	{
		switch (e.Key)
		{
		case Key.Escape:
			e.Handled = true;
			Close();
			break;
		case Key.Return:
		{
			e.Handled = true;
			if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
			{
				FindPrevious();
			}
			else
			{
				FindNext();
			}
			if (IT9LySZpWmG == null)
			{
				break;
			}
			ValidationError validationError = Validation.GetErrors(IT9LySZpWmG).FirstOrDefault();
			if (validationError == null)
			{
				int num = 0;
				if (qTlHfoFGXtvut9quWWJn != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				vTbLyJv1Jsk.Content = Localization.ErrorText + " " + validationError.ErrorContent;
				vTbLyJv1Jsk.PlacementTarget = IT9LySZpWmG;
				vTbLyJv1Jsk.IsOpen = true;
			}
			break;
		}
		}
	}

	public void Close()
	{
		bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
		AdornerLayer.GetAdornerLayer(OyjLytY0eiN)?.Remove(tJfLyuW7m28);
		vTbLyJv1Jsk.IsOpen = false;
		OyjLytY0eiN.TextView.BackgroundRenderers.Remove(lXVLyv0gGgW);
		if (isKeyboardFocusWithin)
		{
			OyjLytY0eiN.Focus();
		}
		IsClosed = true;
		lXVLyv0gGgW.gCpLy947FEV().Clear();
	}

	private void BbhLE496Sw5()
	{
		Close();
		OyjLytY0eiN.DocumentChanged -= pITLEKCtL5c;
		if (lasLyLt6SbX != null)
		{
			lasLyLt6SbX.TextChanged -= KqxLExNqJyM;
		}
	}

	public void Open()
	{
		if (IsClosed)
		{
			AdornerLayer.GetAdornerLayer(OyjLytY0eiN)?.Add(tJfLyuW7m28);
			OyjLytY0eiN.TextView.BackgroundRenderers.Add(lXVLyv0gGgW);
			IsClosed = false;
			jeZLEXh3E90();
		}
	}

	protected virtual void OnSearchOptionsChanged(SearchOptionsChangedEventArgs e)
	{
		IkWLyPePPQB?.Invoke(this, e);
	}

	public static SearchReplacePanel Install(TextEditor editor)
	{
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		TextArea textArea = editor.TextArea;
		if (textArea == null)
		{
			throw new ArgumentNullException("textArea");
		}
		SearchReplacePanel searchReplacePanel = new SearchReplacePanel
		{
			OyjLytY0eiN = textArea,
			Fu5LyE5oGYF = editor
		};
		searchReplacePanel.L5ULEmghWTO(textArea);
		searchReplacePanel.vIYLygskSpB = new TqGqhVDWl2mutbnfsRi(textArea, searchReplacePanel);
		textArea.DefaultInputHandler.NestedInputHandlers.Add(searchReplacePanel.vIYLygskSpB);
		return searchReplacePanel;
	}

	private string e4jLE5TdmGc()
	{
		if (string.IsNullOrEmpty(ReplacePattern))
		{
			return ReplacePattern;
		}
		if (UseRegex)
		{
			return Regex.Unescape(ReplacePattern);
		}
		return ReplacePattern;
	}

	private string mI4LEDiD5qI(ISearchResult isearchResult_0)
	{
		if (string.IsNullOrEmpty(ReplacePattern))
		{
			return string.Empty;
		}
		if (UseRegex)
		{
			string text = Regex.Unescape(ReplacePattern);
			return isearchResult_0.ReplaceWith(text ?? string.Empty).Or(string.Empty);
		}
		return ReplacePattern ?? string.Empty;
	}

	public void ReplaceNext()
	{
		if (!IsReplaceMode)
		{
			return;
		}
		try
		{
			ISearchResult searchResult = hxVLEdC15vu();
			if (searchResult != null)
			{
				OyjLytY0eiN.Selection.ReplaceSelectionWithText(mI4LEDiD5qI(searchResult) ?? string.Empty);
			}
			FindNext();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("替换出错：" + ex.Message);
		}
	}

	private ISearchResult? hxVLEdC15vu()
	{
		_003C_003Ec__DisplayClass83_0 _003C_003Ec__DisplayClass83_ = new _003C_003Ec__DisplayClass83_0();
		if (OyjLytY0eiN.Selection.IsEmpty)
		{
			return null;
		}
		_003C_003Ec__DisplayClass83_.wDQS5dW3rV4 = OyjLytY0eiN.Document.GetOffset(OyjLytY0eiN.Selection.StartPosition.Location);
		_003C_003Ec__DisplayClass83_.aGHS5o8rMlp = OyjLytY0eiN.Selection.Length;
		return lXVLyv0gGgW.gCpLy947FEV().FirstOrDefault(_003C_003Ec__DisplayClass83_.U2GS5Dov5b9);
	}

	public void ReplaceAll()
	{
		if (!IsReplaceMode)
		{
			return;
		}
		try
		{
			TextDocument document = OyjLytY0eiN.Document;
			using (document.RunUpdate())
			{
				ISearchResult[] array = lXVLyv0gGgW.gCpLy947FEV().OrderByDescending(_003C_003Ec.qweS5pyc3k9 ?? (_003C_003Ec.qweS5pyc3k9 = _003C_003Ec.ORhS5mrtoK1.fGxS5XpJ0Sj)).ToArray();
				foreach (ISearchResult searchResult in array)
				{
					document.Replace(searchResult.Offset, searchResult.Length, new StringTextSource(mI4LEDiD5qI(searchResult) ?? string.Empty));
				}
			}
		}
		catch (Exception ex)
		{
			nkJLy0nkgB8.Warn("替换全部出错：" + ex.Message, ex);
			AppHelper.ShowWarning("发生了内部错：" + ex.Message);
		}
	}

	[CompilerGenerated]
	private void Qi7LEoVGHcU(object sender, ExecutedRoutedEventArgs e)
	{
		FindNext();
	}

	[CompilerGenerated]
	private void opLLETZDyeB(object sender, ExecutedRoutedEventArgs e)
	{
		FindPrevious();
	}

	[CompilerGenerated]
	private void drsLEMeck6W(object sender, ExecutedRoutedEventArgs e)
	{
		Close();
	}

	[CompilerGenerated]
	private void sqcLEAnOYva(object sender, ExecutedRoutedEventArgs e)
	{
		IsReplaceMode = false;
		Reactivate();
	}

	[CompilerGenerated]
	private void crVLEOj2y10(object sender, ExecutedRoutedEventArgs e)
	{
		IsReplaceMode = true;
	}

	[CompilerGenerated]
	private void y6YLEFb2Aea(object sender, ExecutedRoutedEventArgs e)
	{
		ReplaceNext();
	}

	[CompilerGenerated]
	private void tkhLEU3IMYr(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = IsReplaceMode;
	}

	[CompilerGenerated]
	private void pR2LElfTnjb(object sender, ExecutedRoutedEventArgs e)
	{
		ReplaceAll();
	}

	[CompilerGenerated]
	private void U3dLEi7nnYm(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = IsReplaceMode;
	}

	[CompilerGenerated]
	private void ej1LE3t3etx(object sender, ExecutedRoutedEventArgs e)
	{
		MatchCase = !MatchCase;
	}

	[CompilerGenerated]
	private void XrjLEfrBNJs(object sender, ExecutedRoutedEventArgs e)
	{
		WholeWords = !WholeWords;
	}

	[CompilerGenerated]
	private void enmLEzvXGYp(object sender, ExecutedRoutedEventArgs e)
	{
		UseRegex = !UseRegex;
	}

	internal static bool b41DiaFG25A1vXoqmH2Y()
	{
		return qTlHfoFGXtvut9quWWJn == null;
	}
}
