using System.Runtime.InteropServices;
using eVDEsgqetG0gdMf5sTK;
using NAudio.CoreAudioApi;
using oTrYHRq8879dB4mPv1l;
using QW0VR5qc16gurgFfUYs;

namespace CoreAudioApi;

public class PolicyConfigClient
{
	private readonly dVhaZcqheKqtP7Zih8Z FFV7leyNsZ;

	private readonly UU4tTwq1i7Vbl7yqKCR QyB7ibnsDU;

	private readonly uXeMr7qbGUsEP3aXstD Wj373rGHgW;

	internal static PolicyConfigClient rInyWKODsEQ0DwMGMnA;

	public PolicyConfigClient()
	{
		FFV7leyNsZ = new _PolicyConfigClient() as dVhaZcqheKqtP7Zih8Z;
		if (FFV7leyNsZ == null)
		{
			QyB7ibnsDU = new _PolicyConfigClient() as UU4tTwq1i7Vbl7yqKCR;
			if (QyB7ibnsDU == null)
			{
				Wj373rGHgW = new _PolicyConfigClient() as uXeMr7qbGUsEP3aXstD;
			}
		}
	}

	public void SetDefaultEndpoint(string devID, Role eRole)
	{
		if (FFV7leyNsZ != null)
		{
			Marshal.ThrowExceptionForHR(FFV7leyNsZ.NIYM2grkgdW(devID, eRole));
		}
		else if (QyB7ibnsDU != null)
		{
			Marshal.ThrowExceptionForHR(QyB7ibnsDU.NIYM2grkgdW(devID, eRole));
		}
		else if (Wj373rGHgW != null)
		{
			Marshal.ThrowExceptionForHR(Wj373rGHgW.NIYM2grkgdW(devID, eRole));
		}
	}

	internal static bool yshSpFO310DkB5GXgb7()
	{
		return rInyWKODsEQ0DwMGMnA == null;
	}
}
