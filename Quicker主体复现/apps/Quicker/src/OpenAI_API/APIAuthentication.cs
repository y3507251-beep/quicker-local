using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API;

public class APIAuthentication
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CValidateAPIKey_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public APIAuthentication _003C_003E4__this;

		public HttpClient client;

		private TaskAwaiter<List<Model>> _003C_003Eu__1;

		private static object k0EJ5qc0KdcxMwHV3L8v;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			APIAuthentication aPIAuthentication = _003C_003E4__this;
			bool result;
			try
			{
        OpenAIAPI openAIAPI = default;
				if (num == 0)
				{
					goto IL_0033;
				}
				openAIAPI = default(OpenAIAPI);
				if (!string.IsNullOrEmpty(aPIAuthentication.ApiKey))
				{
					openAIAPI = new OpenAIAPI(aPIAuthentication, client);
					goto IL_0033;
				}
				result = false;
				goto end_IL_000e;
				IL_0033:
				List<Model> result2;
				try
				{
					TaskAwaiter<List<Model>> awaiter;
					if (num != 0)
					{
						awaiter = openAIAPI.Models.GetModelsAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<List<Model>>);
						num = -1;
						_003C_003E1__state = -1;
					}
					result2 = awaiter.GetResult();
				}
				catch (Exception)
				{
					result = false;
					goto end_IL_000e;
				}
				result = result2.Count > 0;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool N3xbdIc0Beo4xydW8Nvl()
		{
			return k0EJ5qc0KdcxMwHV3L8v == null;
		}
	}

	[CompilerGenerated]
	private string GpwRxyT3da;

	[CompilerGenerated]
	private string hxnRrYOjQE;

	private static APIAuthentication C4IRpOyqLy;

	private static APIAuthentication hHmLXSJoM0fWQWlalim;

	public string ApiKey
	{
		[CompilerGenerated]
		get
		{
			return GpwRxyT3da;
		}
		[CompilerGenerated]
		set
		{
			GpwRxyT3da = value;
		}
	}

	public string OpenAIOrganization
	{
		[CompilerGenerated]
		get
		{
			return hxnRrYOjQE;
		}
		[CompilerGenerated]
		set
		{
			hxnRrYOjQE = value;
		}
	}

	public static APIAuthentication Default
	{
		get
		{
			if (C4IRpOyqLy == null)
			{
				APIAuthentication aPIAuthentication = LoadFromEnv();
				if (aPIAuthentication == null)
				{
					aPIAuthentication = LoadFromPath(null, ".openai", true);
				}
				if (aPIAuthentication == null)
				{
					aPIAuthentication = LoadFromPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
				}
				C4IRpOyqLy = aPIAuthentication;
				return aPIAuthentication;
			}
			return C4IRpOyqLy;
		}
		set
		{
			C4IRpOyqLy = value;
		}
	}

	public static implicit operator APIAuthentication(string key)
	{
		return new APIAuthentication(key);
	}

	public APIAuthentication(string apiKey)
	{
		ApiKey = apiKey;
	}

	public APIAuthentication(string apiKey, string openAIOrganization)
	{
		ApiKey = apiKey;
		OpenAIOrganization = openAIOrganization;
	}

	public static APIAuthentication LoadFromEnv()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("OPENAI_KEY");
		if (string.IsNullOrEmpty(environmentVariable))
		{
			environmentVariable = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				return null;
			}
		}
		string environmentVariable2 = Environment.GetEnvironmentVariable("OPENAI_ORGANIZATION");
		return new APIAuthentication(environmentVariable, environmentVariable2);
	}

	public static APIAuthentication LoadFromPath(string directory = null, string filename = ".openai", bool searchUp = true)
	{
		if (directory == null)
		{
			directory = Environment.CurrentDirectory;
		}
		string text = null;
		string openAIOrganization = null;
		DirectoryInfo directoryInfo = new DirectoryInfo(directory);
		string[] array = default(string[]);
		int num2 = default(int);
		string text2 = default(string);
		string[] array2 = default(string[]);
		int num3 = default(int);
		while (text == null)
		{
			int num;
			if (directoryInfo.Parent == null)
			{
				num = 2;
				if (hHmLXSJoM0fWQWlalim != null)
				{
					goto IL_00c9;
				}
				goto IL_00cd;
			}
			if (File.Exists(Path.Combine(directoryInfo.FullName, filename)))
			{
				array = File.ReadAllLines(Path.Combine(directoryInfo.FullName, filename));
				num2 = 0;
				goto IL_0127;
			}
			goto IL_0132;
			IL_0121:
			num2++;
			goto IL_0127;
			IL_00cd:
			while (true)
			{
				switch (num)
				{
				case 1:
					goto end_IL_00cd;
				case 2:
					goto end_IL_013e;
				}
				if (!(text2 == "OPENAI_KEY"))
				{
					num = 1;
					if (hHmLXSJoM0fWQWlalim == null)
					{
						continue;
					}
					goto IL_00c9;
				}
				goto IL_00e0;
				continue;
				end_IL_00cd:
				break;
			}
			if (!(text2 == "OPENAI_API_KEY"))
			{
				if (text2 == "OPENAI_ORGANIZATION")
				{
					openAIOrganization = array2[1].Trim();
				}
			}
			else
			{
				text = array2[1].Trim();
			}
			goto IL_0121;
			IL_00c9:
			num = num3;
			goto IL_00cd;
			IL_00e0:
			text = array2[1].Trim();
			goto IL_0121;
			IL_0127:
			if (num2 < array.Length)
			{
				array2 = array[num2].Split('=', ':');
				if (array2.Length == 2)
				{
					text2 = array2[0].ToUpper();
					num = 0;
					if (hHmLXSJoM0fWQWlalim != null)
					{
						goto IL_00c9;
					}
					goto IL_00cd;
				}
				goto IL_0121;
			}
			goto IL_0132;
			IL_0132:
			if (!searchUp)
			{
				break;
			}
			directoryInfo = directoryInfo.Parent;
			continue;
			end_IL_013e:
			break;
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return new APIAuthentication(text, openAIOrganization);
	}

	[AsyncStateMachine(typeof(_003CValidateAPIKey_003Ed__17))]
	public Task<bool> ValidateAPIKey(HttpClient client)
	{
		_003CValidateAPIKey_003Ed__17 stateMachine = default(_003CValidateAPIKey_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.client = client;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool w7wDaoJfPyIrXPU5WS4()
	{
		return hHmLXSJoM0fWQWlalim == null;
	}
}
