namespace Baidu.Aip.ContentCensor;

public class Base : AipServiceBase
{
	private static Base daeRfTAt8GXshbs35QD;

	public Base(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Formed
		};
	}

	internal static bool gv2TisASvKon5Vy6Z6x()
	{
		return daeRfTAt8GXshbs35QD == null;
	}
}
