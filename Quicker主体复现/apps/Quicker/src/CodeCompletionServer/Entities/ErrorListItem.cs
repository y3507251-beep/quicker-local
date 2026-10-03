using System.Runtime.CompilerServices;

namespace CodeCompletionServer.Entities;

public class ErrorListItem
{
	[CompilerGenerated]
	private readonly ErrorSeverity MMbvCtd2t2R;

	[CompilerGenerated]
	private readonly string mKRvCglEYW8;

	[CompilerGenerated]
	private readonly int EHJvCLtIN9f;

	[CompilerGenerated]
	private readonly int OnXvCvMKw8Q;

	[CompilerGenerated]
	private readonly int ti6vCSDrjA8;

	[CompilerGenerated]
	private readonly int PlTvC28pILM;

	private static ErrorListItem Lrb6Lscc9F9x7bOIc5Lb;

	public ErrorSeverity ErrorSeverity
	{
		[CompilerGenerated]
		get
		{
			return MMbvCtd2t2R;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return mKRvCglEYW8;
		}
	}

	public int StartLine
	{
		[CompilerGenerated]
		get
		{
			return EHJvCLtIN9f;
		}
	}

	public int StartColumn
	{
		[CompilerGenerated]
		get
		{
			return OnXvCvMKw8Q;
		}
	}

	public int EndLine
	{
		[CompilerGenerated]
		get
		{
			return ti6vCSDrjA8;
		}
	}

	public int EndColumn
	{
		[CompilerGenerated]
		get
		{
			return PlTvC28pILM;
		}
	}

	public ErrorListItem(ErrorSeverity errorSeverity, string description, int startLine, int startColumn, int endLine, int endColumn)
	{
		MMbvCtd2t2R = errorSeverity;
		mKRvCglEYW8 = description;
		EHJvCLtIN9f = startLine;
		OnXvCvMKw8Q = startColumn;
		ti6vCSDrjA8 = endLine;
		PlTvC28pILM = endColumn;
	}

	internal static bool iKVO0eccLGVOHyHVjpYo()
	{
		return Lrb6Lscc9F9x7bOIc5Lb == null;
	}
}
