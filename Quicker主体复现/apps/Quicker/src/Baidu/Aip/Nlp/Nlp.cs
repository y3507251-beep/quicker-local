using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Nlp;

public class Nlp : AipServiceBase
{
	internal static Nlp fHdTTrAKCvpJ9AsSXIV;

	public Nlp(string apiKey, string secretKey)
		: base(apiKey, secretKey)
	{
	}

	protected AipHttpRequest DefaultRequest(string uri)
	{
		return new AipHttpRequest(uri)
		{
			Method = "POST",
			BodyType = AipHttpRequest.BodyFormat.Json,
			ContentEncoding = Encoding.GetEncoding("GBK")
		};
	}

	public JObject Lexer(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/lexer");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject LexerCustom(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/lexer_custom");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject DepParser(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/depparser");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject WordEmbedding(string word, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v2/word_emb_vec");
		aipHttpRequest.Bodys["word"] = word;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject DnnlmCn(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v2/dnnlm_cn");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject WordSimEmbedding(string word1, string word2, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v2/word_emb_sim");
		aipHttpRequest.Bodys["word_1"] = word1;
		aipHttpRequest.Bodys["word_2"] = word2;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject Simnet(string text1, string text2, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v2/simnet");
		aipHttpRequest.Bodys["text_1"] = text1;
		aipHttpRequest.Bodys["text_2"] = text2;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject CommentTag(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v2/comment_tag");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject SentimentClassify(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/sentiment_classify");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject Keyword(string title, string content, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/keyword");
		aipHttpRequest.Bodys["title"] = title;
		aipHttpRequest.Bodys["content"] = content;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject Topic(string title, string content, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/topic");
		aipHttpRequest.Bodys["title"] = title;
		aipHttpRequest.Bodys["content"] = content;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject Ecnet(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/ecnet");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject Emotion(string text, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/emotion");
		aipHttpRequest.Bodys["text"] = text;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	public JObject NewsSummary(string content, int maxSummaryLen, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rpc/2.0/nlp/v1/news_summary");
		aipHttpRequest.Bodys["content"] = content;
		aipHttpRequest.Bodys["max_summary_len"] = maxSummaryLen;
		PreAction();
		if (options != null)
		{
			foreach (KeyValuePair<string, object> option in options)
			{
				aipHttpRequest.Bodys[option.Key] = option.Value;
			}
		}
		return PostAction(aipHttpRequest);
	}

	internal static bool LVreBIABBVA40KPRXtc()
	{
		return fHdTTrAKCvpJ9AsSXIV == null;
	}
}
