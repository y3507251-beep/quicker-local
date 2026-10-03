using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Baidu.Aip.Ocr;

public class Ocr : AipServiceBase
{
	private const string CUSTOM = "https://aip.baidubce.com/rest/2.0/solution/v1/iocr/recognise";

	private static Ocr Xe0tc3AGAjcK0La7QjG;

	public Ocr(string apiKey, string secretKey)
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

	public JObject Common(string interfaceOrUri, byte[] image, Dictionary<string, object> options = null)
	{
		string uri = (interfaceOrUri.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? interfaceOrUri : ("https://aip.baidubce.com/rest/2.0/ocr/v1/" + interfaceOrUri.Trim()));
		AipHttpRequest aipHttpRequest = DefaultRequest(uri);
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject GeneralBasic(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general_basic");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject GeneralBasicUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general_basic");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject AccurateBasic(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/accurate_basic");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject General(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject GeneralUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject Accurate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/accurate");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject GeneralEnhanced(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general_enhanced");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject GeneralEnhancedUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/general_enhanced");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject WebImage(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/webimage");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject WebImageUrl(string url, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/webimage");
		aipHttpRequest.Bodys["url"] = url;
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

	public JObject Idcard(byte[] image, string idCardSide, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/idcard");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
		aipHttpRequest.Bodys["id_card_side"] = idCardSide;
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

	public JObject Bankcard(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/bankcard");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject DrivingLicense(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/driving_license");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject VehicleLicense(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/vehicle_license");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject LicensePlate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/license_plate");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject BusinessLicense(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/business_license");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Receipt(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/receipt");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TrainTicket(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/train_ticket");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TaxiReceipt(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/taxi_receipt");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Form(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/form");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TableRecognitionRequest(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/form_ocr/request");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TableRecognitionGetResult(string requestId, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/form_ocr/get_request_result");
		aipHttpRequest.Bodys["request_id"] = requestId;
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

	public JObject VinCode(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/vin_code");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject QuotaInvoice(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/quota_invoice");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject HouseholdRegister(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/household_register");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject HkMacauExitentrypermit(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/HK_Macau_exitentrypermit");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TaiwanExitentrypermit(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/taiwan_exitentrypermit");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject BirthCertificate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/birth_certificate");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject VehicleInvoice(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/vehicle_invoice");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject VehicleCertificate(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/vehicle_certificate");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Invoice(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/invoice");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject AirTicket(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/air_ticket");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject InsuranceDocuments(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/insurance_documents");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject VatInvoice(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/vat_invoice");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Qrcode(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/qrcode");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Numbers(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/numbers");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Lottery(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/lottery");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Passport(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/passport");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject BusinessCard(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/business_card");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Handwriting(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/ocr/v1/handwriting");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject Custom(byte[] image, Dictionary<string, object> options = null)
	{
		AipHttpRequest aipHttpRequest = DefaultRequest("https://aip.baidubce.com/rest/2.0/solution/v1/iocr/recognise");
		CheckNotNull(image, "image");
		aipHttpRequest.Bodys["image"] = Convert.ToBase64String(image);
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

	public JObject TableRecognition(byte[] image, long timeoutMiliseconds = 20000L, Dictionary<string, object> options = null)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		JObject jObject = TableRecognitionRequest(image);
		if (jObject["result"] is JArray && ((JArray)jObject["result"]).Count == 1)
		{
			string requestId = jObject["result"][0]["request_id"].ToString();
			Log("Table recognize: wait for result...");
			JObject jObject2;
			while (true)
			{
				if (stopwatch.ElapsedMilliseconds < timeoutMiliseconds)
				{
					jObject2 = TableRecognitionGetResult(requestId, options);
					if (!jObject2.TryGetValue("error_code", out JToken value))
					{
						if ((int)jObject2["result"]["ret_code"] == 3)
						{
							break;
						}
						Log("Table recognize: not ready yet, wait 1s..." + jObject2);
						Thread.Sleep(1000);
						continue;
					}
					Log("Table recognize: fail!");
					return jObject2;
				}
				Log("Timeout!");
				throw new AipException("SDK Error: Timeout for form recognition");
			}
			Log("Table recognize: success!");
			return jObject2;
		}
		return jObject;
	}

	public JObject TableRecognitionToJson(byte[] image, long timeoutMiliseconds = 20000L, Dictionary<string, object> options = null)
	{
		if (options == null)
		{
			options = new Dictionary<string, object>();
		}
		options["result_type"] = "json";
		return TableRecognition(image, timeoutMiliseconds, options);
	}

	public JObject TableRecognitionToExcel(byte[] image, long timeoutMiliseconds = 20000L, Dictionary<string, object> options = null)
	{
		if (options == null)
		{
			options = new Dictionary<string, object>();
		}
		options["result_type"] = "excel";
		return TableRecognition(image, timeoutMiliseconds, options);
	}

	internal static bool TMxdgJA0H8Aj40oUxs6()
	{
		return Xe0tc3AGAjcK0La7QjG == null;
	}
}
