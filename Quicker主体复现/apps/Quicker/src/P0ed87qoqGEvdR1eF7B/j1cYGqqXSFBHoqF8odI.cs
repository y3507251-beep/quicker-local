using System;

namespace P0ed87qoqGEvdR1eF7B;

internal class j1cYGqqXSFBHoqF8odI
{
	internal int BcTE6fcxKT;

	internal int uTZEXSplS1;

	internal int S54EmgVu6H;

	internal double Gi2EKrGJpc;

	internal int SSbExSXL80;

	internal int xR7Ern7lm3;

	internal int jDyEp6aFXX;

	internal double orBEBkBBRg;

	internal double oaZEQyuWRM;

	internal double mu1EjRmQ7V;

	private static j1cYGqqXSFBHoqF8odI ewaxl8vwPcr0sYODqdU;

	internal j1cYGqqXSFBHoqF8odI(int int_6, int int_7, int int_8, double double_4)
	{
		BcTE6fcxKT = int_6;
		uTZEXSplS1 = int_7;
		S54EmgVu6H = int_8;
		Gi2EKrGJpc = double_4;
		oaZEQyuWRM = double.MaxValue;
	}

	internal void pUTE1JT7U2(int int_6, int int_7, int int_8, double double_4)
	{
		if (int_6 < uTZEXSplS1 || int_6 >= S54EmgVu6H || BcTE6fcxKT < int_7 || BcTE6fcxKT >= int_8 || Math.Min(Gi2EKrGJpc, double_4) < Math.Max(Gi2EKrGJpc, double_4) * 0.5)
		{
			return;
		}
		double num = (double)int_6 - 0.5 * (double)(uTZEXSplS1 + S54EmgVu6H);
		double num2 = (double)BcTE6fcxKT - 0.5 * (double)(int_7 + int_8);
		double num3 = Math.Sqrt(num * num + num2 * num2);
		if (!(num3 > 2.0) && num3 < oaZEQyuWRM)
		{
			int num4 = 0;
			if (ewaxl8vwPcr0sYODqdU != null)
			{
				int num5 = default(int);
				num4 = num5;
			}
			switch (num4)
			{
			}
			SSbExSXL80 = int_6;
			xR7Ern7lm3 = int_7;
			jDyEp6aFXX = int_8;
			orBEBkBBRg = double_4;
			mu1EjRmQ7V = 0.5 * (Gi2EKrGJpc + double_4);
			oaZEQyuWRM = num3;
		}
	}

	internal bool hXXEbCKt0d(j1cYGqqXSFBHoqF8odI j1cYGqqXSFBHoqF8odI_0)
	{
		if (j1cYGqqXSFBHoqF8odI_0.uTZEXSplS1 < S54EmgVu6H && j1cYGqqXSFBHoqF8odI_0.S54EmgVu6H >= uTZEXSplS1 && j1cYGqqXSFBHoqF8odI_0.xR7Ern7lm3 < jDyEp6aFXX)
		{
			return j1cYGqqXSFBHoqF8odI_0.jDyEp6aFXX >= xR7Ern7lm3;
		}
		return false;
	}

	public override string ToString()
	{
		if (oaZEQyuWRM == double.MaxValue)
		{
			return $"Finder: Row: {BcTE6fcxKT}, Col1: {uTZEXSplS1}, Col2: {S54EmgVu6H}, HModule: {Gi2EKrGJpc:0.00}";
		}
		return $"Finder: Row: {BcTE6fcxKT}, Col: {SSbExSXL80}, Module: {mu1EjRmQ7V:0.00}, Distance: {oaZEQyuWRM:0.00}";
	}

	internal static bool YkxM4mvTIgFk3okrV4Y()
	{
		return ewaxl8vwPcr0sYODqdU == null;
	}
}
