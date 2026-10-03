using System.Runtime.CompilerServices;
using Quicker.Domain;
using Quicker.Utilities;

namespace eGw6fHYzCMTEO3Dvtqx;

internal class HohpaZYaB62F359dDI0
{
	private readonly int fpnLDk1a5TA;

	private readonly int y8TLDGRllTA;

	private readonly int a4qLDsPxXCH;

	private readonly int HNsLDH3Q6V4;

	private long n3XLD1nJloA;

	private int k4JLDbJQ0Ke;

	internal static HohpaZYaB62F359dDI0 aoGkGTFl7km7hQ50j8CV;

	public HohpaZYaB62F359dDI0(int int_5, int int_6, int int_7, int int_8)
	{
		fpnLDk1a5TA = int_5;
		y8TLDGRllTA = int_6;
		a4qLDsPxXCH = int_7;
		HNsLDH3Q6V4 = int_8;
	}

	[SpecialName]
	private int T5hLDeAKflY()
	{
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			return fpnLDk1a5TA;
		}
		return y8TLDGRllTA;
	}

	[SpecialName]
	private int T5OLDIhop7G()
	{
		if (!AppState.DataService.Hb9tmk3OsJ7())
		{
			return a4qLDsPxXCH;
		}
		return HNsLDH3Q6V4;
	}

	public (bool success, string message) dNvLD9NJjcG()
	{
		if (AppHelper.fLiLTj0x4QY() - n3XLD1nJloA < T5hLDeAKflY() * 1000)
		{
			return (success: false, message: $"请求频率过高，请稍后再试。\r\n免费版：{fpnLDk1a5TA}s/次 专业版：{y8TLDGRllTA}s/次");
		}
		if (k4JLDbJQ0Ke > T5OLDIhop7G())
		{
			return (success: false, message: $"今日额度已用完({T5OLDIhop7G()})。免费版：{a4qLDsPxXCH} 专业版：{HNsLDH3Q6V4}");
		}
		n3XLD1nJloA = AppHelper.fLiLTj0x4QY();
		k4JLDbJQ0Ke++;
		return (success: true, message: "");
	}

	public (bool success, string message) Br5LDhbmE9x()
	{
		bool flag;
		int num = ((flag = AppState.DataService.Hb9tmk3OsJ7()) ? 10 : 600);
		double num2 = (double)(AppHelper.fLiLTj0x4QY() - n3XLD1nJloA) / 1000.0;
		if (num2 > 0.0 && num2 < (double)num)
		{
			return (success: false, message: $"请求频率过高，请{(double)num - num2}秒后再试。\r\n频率限制：免费版10分钟1次，专业版10秒钟1次。(IsPro:{flag})");
		}
		if (k4JLDbJQ0Ke > T5OLDIhop7G())
		{
			return (success: false, message: $"今日额度已用完({T5OLDIhop7G()})。");
		}
		n3XLD1nJloA = AppHelper.fLiLTj0x4QY();
		k4JLDbJQ0Ke++;
		return (success: true, message: "");
	}

	internal static bool iok9LOFl4kBdr71egpKR()
	{
		return aoGkGTFl7km7hQ50j8CV == null;
	}
}
