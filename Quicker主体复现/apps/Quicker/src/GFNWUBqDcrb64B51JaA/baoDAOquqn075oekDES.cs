namespace GFNWUBqDcrb64B51JaA;

internal sealed class baoDAOquqn075oekDES
{
	private static readonly string[] SuV7bTtIV2;

	private static readonly string[] Vyn763xFBP;

	private static readonly int[] BHh7XHfXXH;

	private static readonly int[] sYK7mZRwoA;

	public static readonly baoDAOquqn075oekDES KD87K8jk8S;

	public static readonly baoDAOquqn075oekDES Vfd7xO8SSM;

	public static readonly baoDAOquqn075oekDES RL07r5DtNH;

	public static readonly baoDAOquqn075oekDES Xp37pX2Jeo;

	public static readonly baoDAOquqn075oekDES QTg7BdFJ0W;

	public static readonly baoDAOquqn075oekDES LTU7Q6bsUP;

	public readonly string Name;

	public readonly int fIs7jDR3FN;

	public readonly int SMS7nqVeCd;

	public readonly int[] MMj74A29g9;

	public readonly bool zqF75xRmGP;

	public readonly long E8A7Dp1h8d;

	private static baoDAOquqn075oekDES Ymflegd4ZlW9UVxEtQ3;

	static baoDAOquqn075oekDES()
	{
		SuV7bTtIV2 = new string[13]
		{
			null, "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP",
			"OCT", "NOV", "DEC"
		};
		Vyn763xFBP = new string[8] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
		BHh7XHfXXH = new int[SuV7bTtIV2.Length];
		sYK7mZRwoA = new int[Vyn763xFBP.Length];
		KD87K8jk8S = new baoDAOquqn075oekDES("Days of week", 0, 7, sYK7mZRwoA, false);
		Vfd7xO8SSM = new baoDAOquqn075oekDES("Months", 1, 12, BHh7XHfXXH, false);
		RL07r5DtNH = new baoDAOquqn075oekDES("Days of month", 1, 31, null, false);
		Xp37pX2Jeo = new baoDAOquqn075oekDES("Hours", 0, 23, null, true);
		QTg7BdFJ0W = new baoDAOquqn075oekDES("Minutes", 0, 59, null, true);
		LTU7Q6bsUP = new baoDAOquqn075oekDES("Seconds", 0, 59, null, true);
		for (int i = 1; i < SuV7bTtIV2.Length; i++)
		{
			string text = SuV7bTtIV2[i].ToUpperInvariant();
			char[] array = new char[3]
			{
				text[0],
				text[1],
				text[2]
			};
			int num = (int)(text[0] | ((uint)text[1] << 8) | ((uint)text[2] << 16));
			BHh7XHfXXH[i] = num;
		}
		for (int j = 0; j < Vyn763xFBP.Length; j++)
		{
			string text2 = Vyn763xFBP[j].ToUpperInvariant();
			char[] array2 = new char[3]
			{
				text2[0],
				text2[1],
				text2[2]
			};
			int num2 = (int)(text2[0] | ((uint)text2[1] << 8) | ((uint)text2[2] << 16));
			sYK7mZRwoA[j] = num2;
		}
	}

	private baoDAOquqn075oekDES(string string_2, int int_5, int int_6, int[] int_7, bool bool_1)
	{
		Name = string_2;
		fIs7jDR3FN = int_5;
		SMS7nqVeCd = int_6;
		MMj74A29g9 = int_7;
		zqF75xRmGP = bool_1;
		for (int i = fIs7jDR3FN; i <= SMS7nqVeCd; i++)
		{
			E8A7Dp1h8d |= 1L << i;
		}
	}

	public override string ToString()
	{
		return Name;
	}

	internal static void wdjnwVdzMDJ2W5knOTK()
	{
	}

	internal static bool mRAi5odhmdv8ENNwXSG()
	{
		return Ymflegd4ZlW9UVxEtQ3 == null;
	}
}
