using System;
using NAudio.Wave;
using Quicker.Utilities;

namespace snQ8SVoJZmpKYkXlGcy;

internal class vDPS50oKBWTdiSEguMZ
{
	private long Vh0gBP3JRek;

	private float tlDgBEijqpR = 0.01f;

	private float lmvgByqVMDL = 0.05f;

	private float xp2gB8pnXAY;

	private static vDPS50oKBWTdiSEguMZ teHi6LQhTVHnHKbk8jq7;

	public vDPS50oKBWTdiSEguMZ(float float_3 = 0.01f, float float_4 = 0.05f)
	{
		tlDgBEijqpR = float_3;
		lmvgByqVMDL = float_4;
	}

	public int RDDgB02pG2R(WaveInEventArgs waveInEventArgs_0, float float_3)
	{
		if (Vh0gBP3JRek == 0L)
		{
			Vh0gBP3JRek = AppHelper.fLiLTj0x4QY();
		}
		if (float_3 > xp2gB8pnXAY)
		{
			xp2gB8pnXAY = float_3;
		}
		if (float_3 > tlDgBEijqpR && float_3 > xp2gB8pnXAY * lmvgByqVMDL)
		{
			Vh0gBP3JRek = AppHelper.fLiLTj0x4QY();
		}
		return (int)(AppHelper.fLiLTj0x4QY() - Vh0gBP3JRek);
	}

	public static float MxbgBCJpLm2(WaveInEventArgs waveInEventArgs_0)
	{
		float num = 0f;
		for (int i = 0; i < waveInEventArgs_0.BytesRecorded; i += 2)
		{
			float value = (float)(short)((waveInEventArgs_0.Buffer[i + 1] << 8) | waveInEventArgs_0.Buffer[i]) / 32768f;
			num = Math.Max(num, Math.Abs(value));
		}
		return num;
	}

	internal static bool GbpQgWQhmMqUVH0ClrcQ()
	{
		return teHi6LQhTVHnHKbk8jq7 == null;
	}
}
