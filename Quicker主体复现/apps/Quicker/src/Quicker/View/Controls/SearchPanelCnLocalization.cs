using System.Runtime.CompilerServices;
using ICSharpCode.AvalonEdit.Search;

namespace Quicker.View.Controls;

public class SearchPanelCnLocalization : Localization
{
	[CompilerGenerated]
	private static readonly SearchPanelCnLocalization vVPLKnpik6G;

	internal static SearchPanelCnLocalization tX6VRNFu0gfTwNGVeIay;

	public static SearchPanelCnLocalization Instance
	{
		[CompilerGenerated]
		get
		{
			return vVPLKnpik6G;
		}
	}

	public override string MatchCaseText => "区分大小写(Alt+C)";

	public override string MatchWholeWordsText => "匹配整个单词(Alt+W)";

	public override string UseRegexText => "使用正则表达式(Alt+R)";

	public override string FindNextText => "下一个 (F3)";

	public override string FindPreviousText => "上一个 (Shift+F3)";

	public override string ErrorText => "错误: ";

	public override string NoMatchesFoundText => "未找到匹配项。";

	static SearchPanelCnLocalization()
	{
		vVPLKnpik6G = new SearchPanelCnLocalization();
	}

	internal static bool GFEDQ5Fu1FfiUooJC04s()
	{
		return tX6VRNFu0gfTwNGVeIay == null;
	}

	internal static void DCqSroFuBjbVlsU4fMGb()
	{
	}
}
