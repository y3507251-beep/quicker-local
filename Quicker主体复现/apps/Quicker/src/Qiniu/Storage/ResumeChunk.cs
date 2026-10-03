namespace Qiniu.Storage;

public class ResumeChunk
{
	private static int pNoeUTxNXL;

	internal static ResumeChunk Ih0EniuNxyKMw8Jj3fY;

	public static int GetChunkSize(ChunkUnit cu)
	{
		return (int)cu * pNoeUTxNXL;
	}

	public static ChunkUnit GetChunkUnit(int chunkSize)
	{
		int result = default(int);
		int num2;
		if (chunkSize >= 131072)
		{
			if (chunkSize <= 4194304)
			{
				int num = chunkSize / pNoeUTxNXL;
				if (num == 1)
				{
					result = 1;
				}
				else if (num >= 4)
				{
					result = ((num < 8) ? 4 : ((num < 16) ? 8 : ((num >= 32) ? 32 : 16)));
				}
				else
				{
					result = 2;
					num2 = 0;
					if (!IG1ZnHu95gGErjmgphe())
					{
						goto IL_0044;
					}
				}
				goto IL_0071;
			}
			num2 = 1;
			if (!IG1ZnHu95gGErjmgphe())
			{
				goto IL_0044;
			}
		}
		goto IL_0073;
		IL_0073:
		return ChunkUnit.U2048K;
		IL_0044:
		switch (num2)
		{
		case 1:
			goto IL_0073;
		}
		goto IL_0071;
		IL_0071:
		return (ChunkUnit)result;
	}

	static ResumeChunk()
	{
		pNoeUTxNXL = 131072;
	}

	internal static bool IG1ZnHu95gGErjmgphe()
	{
		return Ih0EniuNxyKMw8Jj3fY == null;
	}
}
