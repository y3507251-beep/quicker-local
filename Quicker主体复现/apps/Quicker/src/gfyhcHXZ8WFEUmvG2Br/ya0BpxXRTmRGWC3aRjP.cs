using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using FontAwesome5;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace gfyhcHXZ8WFEUmvG2Br;

internal class ya0BpxXRTmRGWC3aRjP : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_0
	{
		public ActionStep p2rSh6t9soR;

		public ActionExecuteContext bqxShXaEERy;

		public ya0BpxXRTmRGWC3aRjP NmdShmxpFno;

		public XAction CEyShKDk3Et;

		private static _003C_003Ec__DisplayClass72_0 TA3cCAWLXhrlU34DhURD;

		internal (bool isSuccess, string message, ActionStopFlag failReason) HuXShboyoh7()
		{
			_003C_003Ec__DisplayClass72_1 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_1();
			string textParamValue = XActionHelper.GetTextParamValue(Ay2gYc5PDY8, p2rSh6t9soR, bqxShXaEERy);
			string textParamValue2 = XActionHelper.GetTextParamValue(JETgYZfPn8V, p2rSh6t9soR, bqxShXaEERy);
			string textParamValue3 = XActionHelper.GetTextParamValue(nGKgY9qwVti, p2rSh6t9soR, bqxShXaEERy);
			if (string.IsNullOrEmpty(textParamValue3))
			{
				return (isSuccess: false, message: "输入为空", failReason: ActionStopFlag.OperationFailed);
			}
			CipherMode result = CipherMode.CBC;
			PaddingMode result2 = PaddingMode.PKCS7;
			if (textParamValue.EqualsAny(false, "dec_des", "dec_aes", "enc_aes", "enc_des"))
			{
				if (!Enum.TryParse<CipherMode>(XActionHelper.GetTextParamValue(OJ5gYsGpOp7, p2rSh6t9soR, bqxShXaEERy), out result))
				{
					result = CipherMode.CBC;
				}
				if (!Enum.TryParse<PaddingMode>(XActionHelper.GetTextParamValue(VS0gYHyCsZr, p2rSh6t9soR, bqxShXaEERy), out result2))
				{
					result2 = PaddingMode.PKCS7;
				}
			}
			byte[] array = NmdShmxpFno.C8rgYvSrLuT(textParamValue3, textParamValue2);
			_003C_003Ec__DisplayClass72_.ANZShjuwwAF = null;
			if (textParamValue != null)
			{
				int length = textParamValue.Length;
				if (length != 4)
				{
					if (length == 7)
					{
						char c = textParamValue[4];
						if (c != 'a')
						{
							if (c != 'd')
							{
								if (c != 'r')
								{
									goto IL_07bd;
								}
								if (!(textParamValue == "enc_rsa"))
								{
									if (!(textParamValue == "dec_rsa"))
									{
										goto IL_07bd;
									}
									string text = XActionHelper.GetTextParamValue(AqfgYWuOBRr, p2rSh6t9soR, bqxShXaEERy).Trim();
									if (string.IsNullOrEmpty(text))
									{
										return (isSuccess: false, message: "未提供公钥/私钥", failReason: ActionStopFlag.OperationFailed);
									}
									using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
{
									if (text.StartsWith("<RSAKey"))
									{
										rSACryptoServiceProvider.FromXmlString(text);
									}
									else
									{
										rSACryptoServiceProvider.ImportParameters(new RSAParameters
										{
											Modulus = Convert.FromBase64String(text.Replace("\r\n", "").Replace("\n", "")),
											Exponent = new byte[3] { 1, 0, 1 }
										});
									}
									_003C_003Ec__DisplayClass72_.ANZShjuwwAF = rSACryptoServiceProvider.Decrypt(array, true);
								}
}
								else
								{
									string text2 = XActionHelper.GetTextParamValue(AqfgYWuOBRr, p2rSh6t9soR, bqxShXaEERy).Trim();
									if (string.IsNullOrEmpty(text2))
									{
										return (isSuccess: false, message: "未提供公钥/私钥", failReason: ActionStopFlag.OperationFailed);
									}
									using (RSACryptoServiceProvider rSACryptoServiceProvider2 = new RSACryptoServiceProvider())
{
									if (text2.StartsWith("<RSAKey"))
									{
										rSACryptoServiceProvider2.FromXmlString(text2);
									}
									else
									{
										rSACryptoServiceProvider2.ImportParameters(new RSAParameters
										{
											Modulus = Convert.FromBase64String(text2.Replace("\r\n", "").Replace("\n", "")),
											Exponent = new byte[3] { 1, 0, 1 }
										});
									}
									_003C_003Ec__DisplayClass72_.ANZShjuwwAF = rSACryptoServiceProvider2.Encrypt(array, true);
								}
}
							}
							else if (!(textParamValue == "enc_des"))
							{
								if (!(textParamValue == "dec_des"))
								{
									goto IL_07bd;
								}
								var (key, array2) = NmdShmxpFno.gVPgYLjuQEu(p2rSh6t9soR, bqxShXaEERy, result);
								using (DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider())
{
								dESCryptoServiceProvider.Key = key;
								if (array2.HasData())
								{
									dESCryptoServiceProvider.IV = array2;
								}
								dESCryptoServiceProvider.Mode = result;
								dESCryptoServiceProvider.Padding = result2;
								_003C_003Ec__DisplayClass72_.ANZShjuwwAF = te7gYNBF3rC(array, dESCryptoServiceProvider);
							}
}
							else
							{
								var (key2, array3) = NmdShmxpFno.gVPgYLjuQEu(p2rSh6t9soR, bqxShXaEERy, result);
								using (DESCryptoServiceProvider dESCryptoServiceProvider2 = new DESCryptoServiceProvider())
{
								dESCryptoServiceProvider2.Key = key2;
								if (array3.HasData())
								{
									dESCryptoServiceProvider2.IV = array3;
								}
								dESCryptoServiceProvider2.Mode = result;
								dESCryptoServiceProvider2.Padding = result2;
								_003C_003Ec__DisplayClass72_.ANZShjuwwAF = qocgYuOGBiu(array, dESCryptoServiceProvider2);
							}
}
						}
						else if (!(textParamValue == "enc_aes"))
						{
							if (!(textParamValue == "dec_aes"))
							{
								goto IL_07bd;
							}
							var (key3, array4) = NmdShmxpFno.gVPgYLjuQEu(p2rSh6t9soR, bqxShXaEERy, result);
							using (Aes aes = Aes.Create())
{
							aes.Mode = result;
							aes.Key = key3;
							if (array4.HasData())
							{
								aes.IV = array4;
							}
							aes.Padding = result2;
							_003C_003Ec__DisplayClass72_.ANZShjuwwAF = te7gYNBF3rC(array, aes);
						}
}
						else
						{
							var (key4, array5) = NmdShmxpFno.gVPgYLjuQEu(p2rSh6t9soR, bqxShXaEERy, result);
							using (Aes aes2 = Aes.Create())
{
							aes2.Mode = result;
							aes2.Key = key4;
							if (array5.HasData())
							{
								aes2.IV = array5;
							}
							aes2.Padding = result2;
							_003C_003Ec__DisplayClass72_.ANZShjuwwAF = qocgYuOGBiu(array, aes2);
						}
}
						goto IL_06e7;
					}
					if (length == 9)
					{
						char c = textParamValue[6];
						if (c != 'd')
						{
							if (c != 'e')
							{
								if (c == 'm' && textParamValue == "hash_hmac")
								{
									string textParamValue4 = XActionHelper.GetTextParamValue(OU7gYG1mAD5, p2rSh6t9soR, bqxShXaEERy);
									byte[] key5 = NmdShmxpFno.jkagYgeEtnO(p2rSh6t9soR, bqxShXaEERy);
									using (HMAC hMAC = HMAC.Create(textParamValue4))
									{
										hMAC.Key = key5;
										_003C_003Ec__DisplayClass72_.ANZShjuwwAF = hMAC.ComputeHash(array);
									}
									goto IL_06e7;
								}
							}
							else if (textParamValue == "local_enc")
							{
								byte[] key6 = NmdShmxpFno.MLcgYt34yvh();
								using (Aes aes3 = Aes.Create())
								{
									aes3.Key = key6;
									aes3.IV = "IEjHDYASEFGJLQ#A"u8.ToArray();
									_003C_003Ec__DisplayClass72_.ANZShjuwwAF = qocgYuOGBiu(array, aes3);
								}
								goto IL_06e7;
							}
						}
						else if (textParamValue == "local_dec")
						{
							byte[] key7 = NmdShmxpFno.MLcgYt34yvh();
							using (Aes aes4 = Aes.Create())
							{
								aes4.Key = key7;
								aes4.IV = "IEjHDYASEFGJLQ#A"u8.ToArray();
								_003C_003Ec__DisplayClass72_.ANZShjuwwAF = te7gYNBF3rC(array, aes4);
							}
							goto IL_06e7;
						}
					}
				}
				else if (textParamValue == "hash")
				{
					string textParamValue5 = XActionHelper.GetTextParamValue(n9xgYkVZ5Gl, p2rSh6t9soR, bqxShXaEERy);
					using (HashAlgorithm hashAlgorithm = HashAlgorithm.Create(textParamValue5))
					{
						if (hashAlgorithm == null)
						{
							return (isSuccess: false, message: "不支持的哈希算法：" + textParamValue5, failReason: ActionStopFlag.OperationFailed);
						}
						_003C_003Ec__DisplayClass72_.ANZShjuwwAF = hashAlgorithm.ComputeHash(array);
					}
					goto IL_06e7;
				}
			}
			goto IL_07bd;
			IL_06e7:
			if (_003C_003Ec__DisplayClass72_.ANZShjuwwAF == null)
			{
				return (isSuccess: false, message: "加解密结果为空。", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass72_.KxvShQrfRSO = Convert.ToBase64String(_003C_003Ec__DisplayClass72_.ANZShjuwwAF);
			XActionHelper.OutputResultIfNeeded(Sx2gYxfOftR, _003C_003Ec__DisplayClass72_.v35ShxlpwEJ, p2rSh6t9soR, bqxShXaEERy, CEyShKDk3Et);
			XActionHelper.OutputResultIfNeeded(R7MgYmUhR7o, _003C_003Ec__DisplayClass72_.BPKShrmYv2q, p2rSh6t9soR, bqxShXaEERy, CEyShKDk3Et);
			XActionHelper.OutputResultIfNeeded(nSigYKuBYU9, _003C_003Ec__DisplayClass72_.zPYShp1SZbe, p2rSh6t9soR, bqxShXaEERy, CEyShKDk3Et);
			XActionHelper.OutputResultIfNeeded(KyxgYXasVHj, _003C_003Ec__DisplayClass72_.gwYShB3Seu4, p2rSh6t9soR, bqxShXaEERy, CEyShKDk3Et);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			IL_07bd:
			return (isSuccess: false, message: "不支持的操作类型：" + textParamValue + "，请升级Quicker。", failReason: ActionStopFlag.OperationFailed);
		}

		internal static bool RPrSBVWL2Hiu43S4JUDn()
		{
			return TA3cCAWLXhrlU34DhURD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_1
	{
		public string KxvShQrfRSO;

		public byte[] ANZShjuwwAF;

		internal static _003C_003Ec__DisplayClass72_1 mG7V9GWLn5XOv6YSjR4b;

		internal object v35ShxlpwEJ()
		{
			return KxvShQrfRSO;
		}

		internal object BPKShrmYv2q()
		{
			return gr1gY2c7Qav(ANZShjuwwAF);
		}

		internal object zPYShp1SZbe()
		{
			return gr1gY2c7Qav(ANZShjuwwAF).ToLowerInvariant();
		}

		internal object gwYShB3Seu4()
		{
			return Encoding.UTF8.GetString(ANZShjuwwAF);
		}

		internal static bool HF7GW6WLeQdjcrUq8rJ3()
		{
			return mG7V9GWLn5XOv6YSjR4b == null;
		}
	}

	[CompilerGenerated]
	private readonly string IxZgYJ3sV3A = "sys:enc";

	[CompilerGenerated]
	private readonly string a6BgY0NLHSk = "加密/解密/哈希";

	[CompilerGenerated]
	private readonly IEnumerable<string> uLcgYCTSHS0 = new string[4] { "AES", "DES", "RSA", "crypto" };

	[CompilerGenerated]
	private readonly string BeSgYPK8O7c = $"fa:{EFontAwesomeIcon.Light_UserSecret}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory k1AgYES1RhW = StepRunnerCategory.Text;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> DqggYyJVPq5;

	[CompilerGenerated]
	private readonly string TYegY8ZYvql = "加密、解密，以及哈希计算";

	[CompilerGenerated]
	private readonly StepType EX4gYaIRxS8;

	[CompilerGenerated]
	private readonly string YBigY7DRxmL = "https://getquicker.net/KC/Help/Doc/enc";

	[CompilerGenerated]
	private readonly bool vJEgYRYGdTm;

	[CompilerGenerated]
	private readonly bool CvwgYqj6Q92;

	private static readonly StepInParamDef Ay2gYc5PDY8;

	private static List<SelectionItem> y0GgYVytPfw;

	public static StepInParamDef JETgYZfPn8V;

	public static StepInParamDef nGKgY9qwVti;

	public static StepInParamDef ApTgYh7WCu6;

	public static StepInParamDef uxYgYeNALtn;

	public static StepInParamDef sCBgYYHmbEn;

	public static StepInParamDef RG2gYITt1K4;

	public static StepInParamDef AqfgYWuOBRr;

	public static StepInParamDef n9xgYkVZ5Gl;

	public static StepInParamDef OU7gYG1mAD5;

	public static StepInParamDef OJ5gYsGpOp7;

	public static StepInParamDef VS0gYHyCsZr;

	private static readonly StepInParamDef e6pgY1p2SVe;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> eL4gYbrEvhU = new List<StepInParamDef>
	{
		Ay2gYc5PDY8, n9xgYkVZ5Gl, OU7gYG1mAD5, OJ5gYsGpOp7, VS0gYHyCsZr, JETgYZfPn8V, nGKgY9qwVti, AqfgYWuOBRr, ApTgYh7WCu6, uxYgYeNALtn,
		sCBgYYHmbEn, RG2gYITt1K4, e6pgY1p2SVe
	};

	private static readonly StepOutParamDef eLlgY6Qjjnw;

	private static readonly StepOutParamDef KyxgYXasVHj;

	private static readonly StepOutParamDef R7MgYmUhR7o;

	private static readonly StepOutParamDef nSigYKuBYU9;

	private static readonly StepOutParamDef Sx2gYxfOftR;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> jJwgYrEQxPO = new List<StepOutParamDef> { eLlgY6Qjjnw, Sx2gYxfOftR, R7MgYmUhR7o, nSigYKuBYU9, KyxgYXasVHj };

	internal static ya0BpxXRTmRGWC3aRjP EHcWgiQTG25YFxQBBoKV;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return IxZgYJ3sV3A;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return a6BgY0NLHSk;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return uLcgYCTSHS0;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return BeSgYPK8O7c;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return k1AgYES1RhW;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return DqggYyJVPq5;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return TYegY8ZYvql;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return EX4gYaIRxS8;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return YBigY7DRxmL;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return vJEgYRYGdTm;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return CvwgYqj6Q92;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return eL4gYbrEvhU;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return jJwgYrEQxPO;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass72_0 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_0();
		_003C_003Ec__DisplayClass72_.p2rSh6t9soR = step;
		_003C_003Ec__DisplayClass72_.bqxShXaEERy = context;
		_003C_003Ec__DisplayClass72_.NmdShmxpFno = this;
		_003C_003Ec__DisplayClass72_.CEyShKDk3Et = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass72_.bqxShXaEERy, _003C_003Ec__DisplayClass72_.p2rSh6t9soR, _003C_003Ec__DisplayClass72_.CEyShKDk3Et, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass72_.HuXShboyoh7, (Action)null, (Action)null, e6pgY1p2SVe, eLlgY6Qjjnw);
	}

	private byte[] MLcgYt34yvh()
	{
		string s = AppState.DataService.PZTtmCY0ah7().Replace("-", "") + "_31415926";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		using (SHA1 sHA = SHA1.Create())
{
		return sHA.ComputeHash(bytes).Take(16).ToArray();
	}
}

	private byte[] jkagYgeEtnO(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(ApTgYh7WCu6, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(uxYgYeNALtn, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue2))
		{
			throw new ArgumentNullException("密钥参数为空。");
		}
		return C8rgYvSrLuT(textParamValue2, textParamValue);
	}

	private (byte[] keyData, byte[] ivData) gVPgYLjuQEu(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, CipherMode cipherMode_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(ApTgYh7WCu6, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(uxYgYeNALtn, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue2))
		{
			throw new ArgumentNullException("密钥参数为空。");
		}
		string textParamValue3 = XActionHelper.GetTextParamValue(sCBgYYHmbEn, actionStep_0, actionExecuteContext_0);
		string textParamValue4 = XActionHelper.GetTextParamValue(RG2gYITt1K4, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue4) && cipherMode_0 != CipherMode.ECB)
		{
			throw new ArgumentNullException("IV参数为空。");
		}
		byte[] item = C8rgYvSrLuT(textParamValue2, textParamValue);
		byte[] item2 = C8rgYvSrLuT(textParamValue4, textParamValue3);
		return (keyData: item, ivData: item2);
	}

	private byte[] C8rgYvSrLuT(string string_5, string string_6)
	{
		return string_6 switch
		{
			"hex" => r2CgYS1ArUO(string_5), 
			"base64" => Convert.FromBase64String(string_5), 
			"text" => Encoding.UTF8.GetBytes(string_5), 
			_ => throw new InvalidDataException(""), 
		};
	}

	private static byte[] r2CgYS1ArUO(string string_5)
	{
		if (string_5.Length % 2 != 0)
		{
			throw new ArgumentException("Invalid length of hex string");
		}
		byte[] array = new byte[string_5.Length / 2];
		for (int i = 0; i < string_5.Length; i += 2)
		{
			array[i / 2] = Convert.ToByte(string_5.Substring(i, 2), 16);
		}
		return array;
	}

	private static string gr1gY2c7Qav(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		string text = "0123456789ABCDEF";
		int num = 0;
		int num3 = default(int);
		while (num < byte_0.Length)
		{
			byte b = byte_0[num];
			stringBuilder.Append(text[b >> 4]);
			stringBuilder.Append(text[b & 0xF]);
			num++;
			int num2 = 0;
			if (!v3AuoPQT0CMNO9lPaLHJ())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return stringBuilder.ToString();
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(Ay2gYc5PDY8, step) ?? "";
	}

	private static byte[] qocgYuOGBiu(byte[] byte_0, SymmetricAlgorithm symmetricAlgorithm_0)
	{
		using (MemoryStream memoryStream = new MemoryStream())
{
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm_0.CreateEncryptor(), CryptoStreamMode.Write))
{
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}
}
}

	private static byte[] te7gYNBF3rC(byte[] byte_0, SymmetricAlgorithm symmetricAlgorithm_0)
	{
		using (MemoryStream memoryStream = new MemoryStream())
{
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm_0.CreateDecryptor(), CryptoStreamMode.Write))
{
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}
}
}

	static ya0BpxXRTmRGWC3aRjP()
	{
		Ay2gYc5PDY8 = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "hash_hmac",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("enc_des", "DES 加密"),
				new SelectionItem("dec_des", "DES 解密"),
				new SelectionItem("enc_aes", "AES 加密"),
				new SelectionItem("dec_aes", "AES 解密"),
				new SelectionItem("enc_rsa", "RSA 加密"),
				new SelectionItem("dec_rsa", "RSA 解密"),
				new SelectionItem("hash_hmac", "键控哈希 HMAC"),
				new SelectionItem("hash", "哈希（MD5、SHA1等）"),
				new SelectionItem("local_enc", "自用加密"),
				new SelectionItem("local_dec", "自用解密")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		y0GgYVytPfw = new List<SelectionItem>
		{
			new SelectionItem("text", "文本"),
			new SelectionItem("base64", "Base64编码"),
			new SelectionItem("hex", "十六进制编码")
		};
		JETgYZfPn8V = new StepInParamDef
		{
			Key = "inputContentType",
			Name = "输入内容类型",
			Type = VarType.Enum,
			DefaultValue = "text",
			SelectionItems = y0GgYVytPfw,
			VariableMode = ParamVariableMode.Input
		};
		nGKgY9qwVti = new StepInParamDef
		{
			Key = "input",
			Name = "输入",
			Description = "待加密或解密的内容",
			Type = VarType.Text,
			IsMultiLine = true,
			IsRequired = true
		};
		ApTgYh7WCu6 = new StepInParamDef
		{
			Key = "keyContentType",
			Name = "密钥内容类型",
			Type = VarType.Enum,
			DefaultValue = "text",
			SelectionItems = y0GgYVytPfw,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[5] { "dec_des", "dec_aes", "enc_aes", "enc_des", "hash_hmac" }
		};
		uxYgYeNALtn = new StepInParamDef
		{
			Key = "key",
			Name = "密钥",
			Description = "",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[5] { "dec_des", "dec_aes", "enc_aes", "enc_des", "hash_hmac" }
		};
		sCBgYYHmbEn = new StepInParamDef
		{
			Key = "ivContentType",
			Name = "初始化向量IV内容类型",
			Type = VarType.Enum,
			DefaultValue = "text",
			SelectionItems = y0GgYVytPfw,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[4] { "dec_des", "dec_aes", "enc_aes", "enc_des" }
		};
		RG2gYITt1K4 = new StepInParamDef
		{
			Key = "iv",
			Name = "初始化向量",
			Description = "",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[4] { "dec_des", "dec_aes", "enc_aes", "enc_des" }
		};
		AqfgYWuOBRr = new StepInParamDef
		{
			Key = "pairKey",
			Name = "公钥/私钥",
			Description = "XML格式的公钥（加密用）或私钥（解密用）",
			Type = VarType.Text,
			IsMultiLine = true,
			IsRequired = true,
			ValidForList = new string[2] { "enc_rsa", "dec_rsa" }
		};
		n9xgYkVZ5Gl = new StepInParamDef
		{
			Key = "hashType",
			Name = "算法",
			Description = "",
			DefaultValue = "MD5",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[1] { "hash" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("MD5", "MD5"),
				new SelectionItem("SHA1", "SHA1"),
				new SelectionItem("SHA256", "SHA256"),
				new SelectionItem("SHA384", "SHA384"),
				new SelectionItem("SHA512", "SHA512")
			}
		};
		OU7gYG1mAD5 = new StepInParamDef
		{
			Key = "hmacAlgorithm",
			Name = "算法",
			Description = "",
			DefaultValue = "HMACSHA1",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[1] { "hash_hmac" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("HMACSHA1", "HMACSHA1"),
				new SelectionItem("HMACSHA256", "HMACSHA256"),
				new SelectionItem("HMACSHA384", "HMACSHA384"),
				new SelectionItem("HMACSHA512", "HMACSHA512"),
				new SelectionItem("MACTripleDES", "MACTripleDES"),
				new SelectionItem("HMACMD5", "HMACMD5")
			}
		};
		OJ5gYsGpOp7 = new StepInParamDef
		{
			Key = "cipherMode",
			Name = "运算模式",
			Description = "",
			DefaultValue = CipherMode.CBC.ToString(),
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[4] { "dec_aes", "enc_aes", "dec_des", "enc_des" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(CipherMode.CBC.ToString(), CipherMode.CBC.ToString() + "(密码块链，默认)"),
				new SelectionItem(CipherMode.CFB.ToString(), CipherMode.CFB.ToString() + "(加密反馈)"),
				new SelectionItem(CipherMode.CTS.ToString(), CipherMode.CTS.ToString() + "(密文窃取)"),
				new SelectionItem(CipherMode.ECB.ToString(), CipherMode.ECB.ToString() + "(电子密码本)"),
				new SelectionItem(CipherMode.OFB.ToString(), CipherMode.OFB.ToString() + "(输出反馈)")
			}
		};
		VS0gYHyCsZr = new StepInParamDef
		{
			Key = "paddingMode",
			Name = "填充模式",
			Description = "",
			DefaultValue = PaddingMode.PKCS7.ToString(),
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			ValidForList = new string[4] { "dec_aes", "enc_aes", "dec_des", "enc_des" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(PaddingMode.PKCS7.ToString(), PaddingMode.PKCS7.ToString()),
				new SelectionItem(PaddingMode.None.ToString(), PaddingMode.None.ToString()),
				new SelectionItem(PaddingMode.ANSIX923.ToString(), PaddingMode.ANSIX923.ToString()),
				new SelectionItem(PaddingMode.ISO10126.ToString(), PaddingMode.ISO10126.ToString()),
				new SelectionItem(PaddingMode.Zeros.ToString(), PaddingMode.Zeros.ToString())
			}
		};
		e6pgY1p2SVe = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		eLlgY6Qjjnw = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		KyxgYXasVHj = new StepOutParamDef
		{
			Key = "resultText",
			Name = "文本结果",
			Type = VarType.Text,
			ValidForList = new string[4] { "dec_aes", "dec_des", "dec_rsa", "local_dec" }
		};
		R7MgYmUhR7o = new StepOutParamDef
		{
			Key = "resultHex",
			Name = "十六进制编码(大写)",
			Type = VarType.Text
		};
		nSigYKuBYU9 = new StepOutParamDef
		{
			Key = "resultLowerHex",
			Name = "十六进制编码(小写)",
			Type = VarType.Text
		};
		Sx2gYxfOftR = new StepOutParamDef
		{
			Key = "resultBase64",
			Name = "Base64编码结果",
			Type = VarType.Text
		};
	}

	internal static bool v3AuoPQT0CMNO9lPaLHJ()
	{
		return EHcWgiQTG25YFxQBBoKV == null;
	}
}
