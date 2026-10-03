using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using Quicker.Public.Actions;
using Quicker.Utilities.UI;

namespace Quicker.Utilities.Ext;

public class VariableCompletionData : ICompletionData
{
	private readonly VarType wypLiGyPAF0;

	[CompilerGenerated]
	private readonly string Kq3LisRhWek;

	[CompilerGenerated]
	private readonly object fVgLiHjB8uR;

	[CompilerGenerated]
	private readonly string TuMLi14LZ71;

	internal static VariableCompletionData ryOrt9FIF4JR90arjvi3;

	public ImageSource Image => AppHelper.GetVarTypeIcon(wypLiGyPAF0);

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return Kq3LisRhWek;
		}
	}

	public object Content
	{
		get
		{
			TextBlock textBlock = new TextBlock();
			textBlock.Inlines.Add(new Run(Text));
			if (!string.IsNullOrEmpty(Group))
			{
				Run run = new Run("  " + Group);
				run.Foreground = (Quicker.App.Current.TryFindResource("TextWarningBrush") as Brush) ?? Color.FromRgb(byte.MaxValue, 215, 0).GetBrush();
				textBlock.Inlines.Add(run);
			}
			return textBlock;
		}
	}

	public object Description
	{
		[CompilerGenerated]
		get
		{
			return fVgLiHjB8uR;
		}
	}

	public double Priority => 1.0;

	public string Group
	{
		[CompilerGenerated]
		get
		{
			return TuMLi14LZ71;
		}
	}

	public VariableCompletionData(string text, string desc, VarType varType, string group)
	{
		wypLiGyPAF0 = varType;
		Kq3LisRhWek = text;
		fVgLiHjB8uR = ((desc == "") ? null : desc);
		TuMLi14LZ71 = group;
	}

	public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
	{
		textArea.Document.Replace(completionSegment, Text + "}");
	}

	internal static bool eqxwQUFIcefEfDjPqlaM()
	{
		return ryOrt9FIF4JR90arjvi3 == null;
	}
}
