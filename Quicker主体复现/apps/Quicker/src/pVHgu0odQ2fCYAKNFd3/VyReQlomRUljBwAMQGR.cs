using System;
using System.IO;
using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using NAudio.MediaFoundation;
using NAudio.Wave;
using Quicker.Utilities;

namespace pVHgu0odQ2fCYAKNFd3;

internal static class VyReQlomRUljBwAMQGR
{
	private static object JjT6qgQs1eOpP4KnGDNZ;

	internal static bool YJZgHsLPig7(MMDevice mmdevice_0)
	{
		SessionCollection sessions = mmdevice_0.AudioSessionManager.Sessions;
		bool result = false;
		int num2 = default(int);
		for (int i = 0; i < sessions.Count; i++)
		{
			if (sessions[i].State == AudioSessionState.AudioSessionStateActive)
			{
				int num = 0;
				if (!B62e0PQsKlTkDPlZ6w25())
				{
					num = num2;
				}
				switch (num)
				{
				}
				result = true;
				break;
			}
		}
		return result;
	}

	internal static void WKhgHHcMKjg(string string_0, string string_1, bool bool_0)
	{
		try
		{
			MediaFoundationApi.Startup();
			using WaveFileReader inputProvider = new WaveFileReader(string_0);
			MediaFoundationEncoder.EncodeToMp3(inputProvider, string_1);
		}
		finally
		{
			MediaFoundationApi.Shutdown();
		}
		if (bool_0)
		{
			try
			{
				File.Delete(string_0);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("转换为Mp3出错，您的系统不支持。" + ex.Message);
			}
		}
	}

	internal static bool B62e0PQsKlTkDPlZ6w25()
	{
		return JjT6qgQs1eOpP4KnGDNZ == null;
	}
}
