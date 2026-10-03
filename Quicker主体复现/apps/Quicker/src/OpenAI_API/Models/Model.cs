using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenAI_API.Models;

public class Model
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRetrieveModelDetailsAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Model> _003C_003Et__builder;

		public OpenAIAPI api;

		public Model _003C_003E4__this;

		private TaskAwaiter<Model> _003C_003Eu__1;

		private static object Ww6aD7c1AjkZLcqwUGa9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Model model = _003C_003E4__this;
			Model result;
			try
			{
				TaskAwaiter<Model> awaiter;
				if (num != 0)
				{
					awaiter = api.Models.RetrieveModelDetailsAsync(model.ModelID).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<Model>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (Ww6aD7c1AjkZLcqwUGa9 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
				}
				result = awaiter.GetResult();
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

		internal static bool QFbqGKc1nRxBvmb3QLQi()
		{
			return Ww6aD7c1AjkZLcqwUGa9 == null;
		}
	}

	[CompilerGenerated]
	private string JvjqDWGTlt;

	[CompilerGenerated]
	private string NPbqd0ke9B;

	[CompilerGenerated]
	private string vv1qow0Iq5;

	[CompilerGenerated]
	private long? DJVqTGoYhl;

	[CompilerGenerated]
	private List<Permissions> M9eqMfGaGR = new List<Permissions>();

	[CompilerGenerated]
	private string qWRqAwfR74;

	[CompilerGenerated]
	private string aJUqOGqFG0;

	[CompilerGenerated]
	private static Model fJxqFi47co;

	[CompilerGenerated]
	private static Model RAjqUW2dqr;

	[CompilerGenerated]
	private static Model xkCqlwEbn4;

	[CompilerGenerated]
	private static Model BG4qim5v5n;

	[CompilerGenerated]
	private static Model BgMq3OjnIa;

	private static Model zG9UlmkkNeo5L2J5Ivs;

	[JsonProperty("id")]
	public string ModelID
	{
		[CompilerGenerated]
		get
		{
			return JvjqDWGTlt;
		}
		[CompilerGenerated]
		set
		{
			JvjqDWGTlt = value;
		}
	}

	[JsonProperty("owned_by")]
	public string OwnedBy
	{
		[CompilerGenerated]
		get
		{
			return NPbqd0ke9B;
		}
		[CompilerGenerated]
		set
		{
			NPbqd0ke9B = value;
		}
	}

	[JsonProperty("object")]
	public string Object
	{
		[CompilerGenerated]
		get
		{
			return vv1qow0Iq5;
		}
		[CompilerGenerated]
		set
		{
			vv1qow0Iq5 = value;
		}
	}

	[JsonIgnore]
	public DateTime? Created
	{
		get
		{
			if (!CreatedUnixTime.HasValue)
			{
				return null;
			}
			return DateTimeOffset.FromUnixTimeSeconds(CreatedUnixTime.Value).DateTime;
		}
	}

	[JsonProperty("created")]
	public long? CreatedUnixTime
	{
		[CompilerGenerated]
		get
		{
			return DJVqTGoYhl;
		}
		[CompilerGenerated]
		set
		{
			DJVqTGoYhl = value;
		}
	}

	[JsonProperty("permission")]
	public List<Permissions> Permission
	{
		[CompilerGenerated]
		get
		{
			return M9eqMfGaGR;
		}
		[CompilerGenerated]
		set
		{
			M9eqMfGaGR = value;
		}
	}

	[JsonProperty("root")]
	public string Root
	{
		[CompilerGenerated]
		get
		{
			return qWRqAwfR74;
		}
		[CompilerGenerated]
		set
		{
			qWRqAwfR74 = value;
		}
	}

	[JsonProperty("parent")]
	public string Parent
	{
		[CompilerGenerated]
		get
		{
			return aJUqOGqFG0;
		}
		[CompilerGenerated]
		set
		{
			aJUqOGqFG0 = value;
		}
	}

	public static Model DefaultModel
	{
		[CompilerGenerated]
		get
		{
			return fJxqFi47co;
		}
		[CompilerGenerated]
		set
		{
			fJxqFi47co = value;
		}
	}

	public static Model DefaultChatModel
	{
		[CompilerGenerated]
		get
		{
			return RAjqUW2dqr;
		}
		[CompilerGenerated]
		set
		{
			RAjqUW2dqr = value;
		}
	}

	public static Model DefaultTTSModel
	{
		[CompilerGenerated]
		get
		{
			return xkCqlwEbn4;
		}
		[CompilerGenerated]
		set
		{
			xkCqlwEbn4 = value;
		}
	}

	public static Model DefaultTranscriptionModel
	{
		[CompilerGenerated]
		get
		{
			return BG4qim5v5n;
		}
		[CompilerGenerated]
		set
		{
			BG4qim5v5n = value;
		}
	}

	public static Model DefaultEmbeddingModel
	{
		[CompilerGenerated]
		get
		{
			return BgMq3OjnIa;
		}
		[CompilerGenerated]
		set
		{
			BgMq3OjnIa = value;
		}
	}

	public static Model GPT4 => new Model("gpt-4")
	{
		OwnedBy = "openai"
	};

	public static Model GPT4_32k_Context => new Model("gpt-4-32k")
	{
		OwnedBy = "openai"
	};

	public static Model GPT4_Vision => new Model("gpt-4-vision-preview")
	{
		OwnedBy = "openai"
	};

	public static Model GPT4_Turbo => new Model("gpt-4-turbo-preview")
	{
		OwnedBy = "openai"
	};

	public static Model ChatGPTTurbo => new Model("gpt-3.5-turbo")
	{
		OwnedBy = "openai"
	};

	public static Model ChatGPTTurbo_1106 => new Model("gpt-3.5-turbo-1106")
	{
		OwnedBy = "openai"
	};

	public static Model ChatGPTTurbo_16k => new Model("gpt-3.5-turbo-16k")
	{
		OwnedBy = "openai"
	};

	public static Model ChatGPTTurboInstruct => new Model("gpt-3.5-turbo-instruct")
	{
		OwnedBy = "openai"
	};

	public static Model Babbage => new Model("babbage-002")
	{
		OwnedBy = "openai"
	};

	public static Model Davinci => new Model("davinci-002")
	{
		OwnedBy = "openai"
	};

	public static Model AdaText => new Model("text-ada-001")
	{
		OwnedBy = "openai"
	};

	public static Model BabbageText => new Model("text-babbage-001")
	{
		OwnedBy = "openai"
	};

	public static Model CurieText => new Model("text-curie-001")
	{
		OwnedBy = "openai"
	};

	[Obsolete("Will be deprecated by OpenAI on Jan 4th 2024. Use Davinci (\"davinci-002\") instead")]
	public static Model DavinciText => new Model("text-davinci-003")
	{
		OwnedBy = "openai"
	};

	[Obsolete("No longer supported by OpenAI", true)]
	public static Model CushmanCode => new Model("code-cushman-001")
	{
		OwnedBy = "openai"
	};

	[Obsolete("Will be deprecated by OpenAI on Jan 4th 2024.")]
	public static Model DavinciCode => new Model("code-davinci-002")
	{
		OwnedBy = "openai"
	};

	public static Model AdaTextEmbedding => new Model("text-embedding-ada-002")
	{
		OwnedBy = "openai"
	};

	public static Model TextEmbedding3Large => new Model("text-embedding-3-large")
	{
		OwnedBy = "openai"
	};

	public static Model TextEmbedding3Small => new Model("text-embedding-3-small")
	{
		OwnedBy = "openai"
	};

	public static Model TextModerationStable => new Model("text-moderation-stable")
	{
		OwnedBy = "openai"
	};

	public static Model TextModerationLatest => new Model("text-moderation-latest")
	{
		OwnedBy = "openai"
	};

	public static Model DALLE2 => new Model("dall-e-2")
	{
		OwnedBy = "openai"
	};

	public static Model DALLE3 => new Model("dall-e-3")
	{
		OwnedBy = "openai"
	};

	public static Model TTS_Speed => new Model("tts-1")
	{
		OwnedBy = "openai"
	};

	public static Model TTS_HD => new Model("tts-1-hd")
	{
		OwnedBy = "openai"
	};

	public static Model Whisper1 => new Model("whisper-1")
	{
		OwnedBy = "openai"
	};

	public static implicit operator string(Model model)
	{
		return model?.ModelID;
	}

	public static implicit operator Model(string name)
	{
		return new Model(name);
	}

	public Model(string name)
	{
		ModelID = name;
	}

	public Model()
	{
	}

	[AsyncStateMachine(typeof(_003CRetrieveModelDetailsAsync_003Ed__54))]
	public Task<Model> RetrieveModelDetailsAsync(OpenAIAPI api)
	{
		_003CRetrieveModelDetailsAsync_003Ed__54 stateMachine = default(_003CRetrieveModelDetailsAsync_003Ed__54);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Model>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.api = api;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static Model()
	{
		fJxqFi47co = ChatGPTTurboInstruct;
		RAjqUW2dqr = ChatGPTTurbo;
		xkCqlwEbn4 = TTS_Speed;
		BG4qim5v5n = Whisper1;
		BgMq3OjnIa = AdaTextEmbedding;
	}

	internal static bool mjM39DkarIHSb7oNJOh()
	{
		return zG9UlmkkNeo5L2J5Ivs == null;
	}
}
