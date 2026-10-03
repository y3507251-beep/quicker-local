using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cuiliang.AliyunOssSdk.Api.Object.Get;

public class ObjectRange
{
	[CompilerGenerated]
	private long IAwu4QilCH;

	[CompilerGenerated]
	private long Fcdu5W1U8u;

	[CompilerGenerated]
	private long HV1uDYlKat;

	private static ObjectRange ipvmVrjlw46r79ffW34;

	public long Start
	{
		[CompilerGenerated]
		get
		{
			return IAwu4QilCH;
		}
		[CompilerGenerated]
		set
		{
			IAwu4QilCH = value;
		}
	}

	public long End
	{
		[CompilerGenerated]
		get
		{
			return Fcdu5W1U8u;
		}
		[CompilerGenerated]
		set
		{
			Fcdu5W1U8u = value;
		}
	}

	public long Total
	{
		[CompilerGenerated]
		get
		{
			return HV1uDYlKat;
		}
		[CompilerGenerated]
		set
		{
			HV1uDYlKat = value;
		}
	}

	public bool IsValid()
	{
		if (Start < 0L)
		{
			return End >= 0L;
		}
		return true;
	}

	public void AddToHeader(IDictionary<string, string> headers)
	{
		if (IsValid())
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("bytes=");
			if (Start >= 0L)
			{
				stringBuilder.Append(Start.ToString(CultureInfo.InvariantCulture));
			}
			stringBuilder.Append("-");
			if (End >= 0L)
			{
				stringBuilder.Append(End.ToString(CultureInfo.InvariantCulture));
			}
			headers.Add("Range", stringBuilder.ToString());
		}
	}

	internal static bool EUe7GjjZZYuvUqUAtLO()
	{
		return ipvmVrjlw46r79ffW34 == null;
	}
}
