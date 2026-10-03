using qgnh0JiJCUj4XCaowwH;

namespace Quicker.Utilities.Pinyin.CnChar;

public class CnCharProvider
{
	public class CnCharCache
	{
		private CnChar[] nsk28YvRmi8;

		internal static CnCharCache o4dtpZyaa1qGLGC0cHgx;

		public CnCharCache()
		{
			nsk28YvRmi8 = new CnChar[27558];
		}

		public CnChar TryGetValue(char ch)
		{
			if (ch >= '㐀' && ch <= '龥')
			{
				int num = ch - 13312;
				return nsk28YvRmi8[num];
			}
			return null;
		}

		public void SetValue(char ch, CnChar cnChar)
		{
			if (ch >= '㐀' && ch <= '龥')
			{
				int num = ch - 13312;
				nsk28YvRmi8[num] = cnChar;
			}
		}

		static CnCharCache()
		{
		}

		internal static bool nf2pbSyarWVB97GVCNA1()
		{
			return o4dtpZyaa1qGLGC0cHgx == null;
		}

		internal static void rGdTZCya9A1mGOgpOdUv()
		{
		}
	}

	private static readonly CnCharCache thPvJ5SbLir;

	internal static CnCharProvider BQmuPJcF0ci6CVd12M1N;

	public static CnChar GetCnChar(char ch)
	{
		CnChar cnChar = thPvJ5SbLir.TryGetValue(ch);
		if (cnChar == null)
		{
			cnChar = new CnChar(ch, XRlL56iKFaTMc4ji9eS.qX1vN4saiJ7(ch), XRlL56iKFaTMc4ji9eS.GmHvNpLOZ3b(ch));
			thPvJ5SbLir.SetValue(ch, cnChar);
		}
		return cnChar;
	}

	static CnCharProvider()
	{
		thPvJ5SbLir = new CnCharCache();
	}

	internal static bool FInwZHcF12X2klMl19AF()
	{
		return BQmuPJcF0ci6CVd12M1N == null;
	}
}
