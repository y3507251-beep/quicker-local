using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using iPl4WNAGGAsnX3Qcaq4;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;

namespace pEvh96AzTBdjpSVb1d0;

internal class Ul3JYWAa0WqW9EBQbgu
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec tu6vYUp6BLI;

		public static Func<string, string> GklvYlnyEZD;

		public static Func<string, string> aMLvYiC1W9B;

		public static Func<string, bool> YfcvY39EoYp;

		private static _003C_003Ec dwmA5HclLEcGi0cftdNN;

		static _003C_003Ec()
		{
			tu6vYUp6BLI = new _003C_003Ec();
		}

		internal string tgxvYARnP8x(string x)
		{
			return Path.GetFileName(x);
		}

		internal string v4VvYONSSea(string x)
		{
			return Path.GetFileName(x);
		}

		internal bool nHyvYFEsQ8m(string x)
		{
			return jp63QXoRPx(x);
		}

		internal static bool TcRkrGclu1jG363K93UX()
		{
			return dwmA5HclLEcGi0cftdNN == null;
		}
	}

	private readonly string onP34Yp4ve;

	private readonly neOcDPAIpvKxjVetnhh Bfx35Y3JwD;

	private readonly bool aWV3DbKmU9;

	private readonly bool GBa3dCDk5l;

	private readonly bool r593oEIRlM;

	private string xQq3TZA5tf = "\r\n<html lang='zh-CN'>\r\n<head>\r\n    <meta charset='utf-8' />\r\n    <meta name='viewport' content='width=device-width, initial-scale=1, user-scalable=no'>\r\n    <title>%FOLDER_NAME%</title>\r\n    \r\n    \r\n    \r\n    <style>\r\n        a {text-decoration: none;}\r\n\r\n        .file-list{\r\n            border-top: 1px solid #F0F0F0;\r\n        }\r\n\r\n        .file-item{\r\n            padding:3px 0;\r\n            border-bottom: 1px solid #F0F0F0;\r\n            min-height: 42px;\r\n        }\r\n        .text-note{\r\n            color:#A0A0A0;\r\n            font-size:12px;\r\n        }\r\n\r\n        .file-icon-wrapper{\r\n            width: 50px;\r\n            text-align:center;\r\n        }\r\n\r\n        .file-icon-img{\r\n            max-width: 40px;\r\n            max-height: 40px;\r\n            border-radius: 3px;\r\n        }\r\n\r\n        .file-title{\r\n            word-break: break-all;\r\n            font-size:15px;\r\n        }\r\n\r\n        a.disabled { \r\n            pointer-events: none;\r\n            cursor: default;\r\n        }     \r\n    </style>\r\n    <!--HEAD-CODE-->\r\n<style>\nbody{font-family:system-ui,sans-serif;max-width:960px;margin:auto;padding:20px}\n.file-item{display:flex;align-items:center;gap:12px}.d-flex{display:flex}.flex-grow-1{flex:1}\n.d-none{display:none!important}.offcanvas{border:1px solid #ccc;padding:16px;margin-top:24px}\nbutton{padding:8px 16px;cursor:pointer}a{color:#087ec4}.container{margin:16px 0}.row{display:flex;gap:12px;flex-wrap:wrap}\n</style></head>\r\n<body>\r\n    \r\n    <div class='container mt-3'>\r\n        %BODY%\r\n    </div>    \r\n\r\n    <div class='position-fixed bottom-0 end-0 me-3 mb-3 '>\r\n        <span id='btnsForDownload' class='d-none'>\r\n            <button id='btnSelectAll' class='btn btn-secondary   rounded-pill'>全选</button>\r\n            <button id='btnBatchDownload' class='btn btn-success  rounded-pill'>下载</button>\r\n        </span>\r\n        <button class='btn btn-primary  rounded-pill' id='btnShowUpload' type='button' title='上传文件' data-bs-toggle='offcanvas' data-bs-target='#offcanvasBottom' aria-controls='offcanvasBottom'>+</button>\r\n    </div>\r\n    \r\n    <div class='container mt-2 bm-5  text-black-50 small' id='footer'>\r\n    - 点击文件大小可下载文件。<br/>\r\n    - 点击文件缩略图可浏览图片。<br/>\r\n    </div>\r\n\r\n    <div class='w-100 mb-5'></div>\r\n\r\n    <div class='offcanvas offcanvas-bottom' tabindex='-1' id='offcanvasBottom' aria-labelledby='offcanvasBottomLabel'>\r\n        <div class='offcanvas-header'>\r\n          <h5 class='offcanvas-title' id='offcanvasBottomLabel'>上传文件</h5>\r\n          <button type='button' class='btn-close text-reset' data-bs-dismiss='offcanvas' aria-label='Close'></button>\r\n        </div>\r\n        <div class='offcanvas-body small'>\r\n            <div class=''>\r\n                <form action='.' method='post' enctype='multipart/form-data' id='fileForm'>\r\n                     <input type='file'  class='form-control' id='file1' name='file1' multiple/>\r\n                     <div class='mt-2 text-end'>        \r\n                        <button type='submit' id='btnUpload' class='btn btn-primary' disabled>上传</button>\r\n                     </div>   \r\n                </form>\r\n            </div>\r\n        </div>\r\n      </div>\r\n\r\n    \r\n        \r\n    \r\n    \r\n    \r\n    \r\n    <!--BODY-CODE-->\r\n<script>\nconst fileInput=document.querySelector('input[type=file]');\nif(fileInput) fileInput.addEventListener('change',()=>{document.getElementById('btnUpload').disabled=!fileInput.files.length;});\ndocument.querySelectorAll('img[data-src]').forEach(img=>{img.loading='lazy';img.src=img.dataset.src;});\nconst refresh=()=>{const selected=!!document.querySelector('input[type=checkbox]:checked');document.getElementById('btnsForDownload').classList.toggle('d-none',!selected);document.getElementById('btnShowUpload').classList.toggle('d-none',selected);};\ndocument.querySelectorAll('input[type=checkbox]').forEach(x=>x.addEventListener('change',refresh));\ndocument.getElementById('btnBatchDownload').addEventListener('click',()=>document.getElementById('list-form').submit());\ndocument.getElementById('btnSelectAll').addEventListener('click',()=>{const boxes=[...document.querySelectorAll('input[type=checkbox]')];const check=boxes.some(x=>!x.checked);boxes.forEach(x=>x.checked=check);refresh();});\ndocument.getElementById('btnShowUpload').addEventListener('click',()=>document.getElementById('offcanvasBottom').scrollIntoView());\n</script></body>\r\n</html>\r\n";

	private static Ul3JYWAa0WqW9EBQbgu EPptW3QQ9T8bKQRehx3d;

	public Ul3JYWAa0WqW9EBQbgu(neOcDPAIpvKxjVetnhh neOcDPAIpvKxjVetnhh_1, bool bool_3, bool bool_4, bool bool_5)
	{
		Bfx35Y3JwD = neOcDPAIpvKxjVetnhh_1;
		onP34Yp4ve = neOcDPAIpvKxjVetnhh_1.KLa3N1bE9M();
		aWV3DbKmU9 = bool_3;
		GBa3dCDk5l = bool_4;
		r593oEIRlM = bool_5;
	}

	public string uwy3pZ7aDB()
	{
		int num = 4;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			List<string> list = Directory.GetDirectories(onP34Yp4ve).Select(_003C_003Ec.GklvYlnyEZD ?? (_003C_003Ec.GklvYlnyEZD = _003C_003Ec.tu6vYUp6BLI.tgxvYARnP8x)).ToList();
			while (true)
			{
				IL_002b:
				list = list.OrderByLogical();
				List<string> strList = Directory.GetFiles(onP34Yp4ve).Select(_003C_003Ec.aMLvYiC1W9B ?? (_003C_003Ec.aMLvYiC1W9B = _003C_003Ec.tu6vYUp6BLI.v4VvYONSSea)).Where(_003C_003Ec.YfcvY39EoYp ?? (_003C_003Ec.YfcvY39EoYp = _003C_003Ec.tu6vYUp6BLI.nHyvYFEsQ8m))
					.ToList();
				strList = strList.OrderByLogical();
				num = 5;
				while (true)
				{
					string text = xQq3TZA5tf.Replace("%FOLDER_NAME%", Path.GetFileName(onP34Yp4ve));
					int num2;
					if (!string.IsNullOrEmpty(Bfx35Y3JwD.UkY3aSxYom()))
					{
						num2 = 1;
						if (EPptW3QQ9T8bKQRehx3d != null)
						{
							goto IL_02bc;
						}
						goto IL_030f;
					}
					goto IL_0348;
					IL_02f0:
					stringBuilder.AppendLine("</div>");
					if (!Bfx35Y3JwD.Rt330XF1ay())
					{
						stringBuilder.AppendLine("<h3 class='mt-2 ml-3'>");
						stringBuilder.Append("<a href='../' class='d-inline-block float-left mr-2' >");
						stringBuilder.Append("<svg fill='#00a6ed' width='1em' height='1em' xmlns='http://www.w3.org/2000/svg' viewBox='0 0 384 512'><path d='M374.6 246.6C368.4 252.9 360.2 256 352 256s-16.38-3.125-22.62-9.375L224 141.3V448c0 17.69-14.33 31.1-31.1 31.1S160 465.7 160 448V141.3L54.63 246.6c-12.5 12.5-32.75 12.5-45.25 0s-12.5-32.75 0-45.25l160-160c12.5-12.5 32.75-12.5 45.25 0l160 160C387.1 213.9 387.1 234.1 374.6 246.6z'/></svg>");
						stringBuilder.AppendLine("");
						stringBuilder.AppendLine("<span class='text-body'>" + Path.GetFileName(onP34Yp4ve).HtmlEncode() + "</span></a></h3>");
					}
					else
					{
						stringBuilder.AppendLine("<h3 class='mt-2  ml-3'>[根]</h3>");
					}
					stringBuilder.AppendLine("<div class='row mt-3'><div class='col'>");
					stringBuilder.Append("<form method='get' id='list-form' target='_blank'>");
					stringBuilder.AppendLine("<div class='file-list'>");
					foreach (string item in list)
					{
						XPZ3B7O08A(stringBuilder, true, item);
					}
					stringBuilder.AppendLine("<div class='w-100' style='height:1px; background-color:#F0F0F0'></div>");
					num2 = 0;
					if (!E7MDvEQQLe392cFnwjTf())
					{
						num2 = num;
					}
					goto IL_02bc;
					IL_0348:
					if (!string.IsNullOrEmpty(Bfx35Y3JwD.mwG3qo7XCM()))
					{
						text = text.Replace("<!--BODY-CODE-->", Bfx35Y3JwD.mwG3qo7XCM());
					}
					stringBuilder = new StringBuilder();
					stringBuilder.Append("<div class='text-secondary current_path'>");
					stringBuilder.Append("<a href='/' class='text-secondary'>" + Bfx35Y3JwD.O7S327VeT6().HtmlEncode() + "\\</a>");
					string text2 = Bfx35Y3JwD.O7S327VeT6().TrimEnd('/', '\\');
					if (!string.Equals(text2, onP34Yp4ve))
					{
						IList<KeyValuePair<string, string>> list2 = new List<KeyValuePair<string, string>>();
						string text3 = Path.GetDirectoryName(onP34Yp4ve);
						string text4 = "";
						while (!string.Equals(text3, text2, StringComparison.OrdinalIgnoreCase))
						{
							string fileName = Path.GetFileName(text3);
							string directoryName = Path.GetDirectoryName(text3);
							text4 += "../";
							list2.Insert(0, new KeyValuePair<string, string>(fileName, text4));
							text3 = directoryName;
						}
						foreach (KeyValuePair<string, string> item2 in list2)
						{
							stringBuilder.Append("<a href='" + item2.Value + "'>" + item2.Key.HtmlEncode() + "\\</a>");
						}
					}
					goto IL_02f0;
					IL_030f:
					text = text.Replace("<!--HEAD-CODE-->", Bfx35Y3JwD.UkY3aSxYom());
					goto IL_0348;
					IL_02bc:
					switch (num2)
					{
					case 4:
						break;
					case 3:
						goto IL_002b;
					case 2:
						goto IL_02f0;
					case 1:
						goto IL_030f;
					case 5:
						continue;
					default:
						foreach (string item3 in strList)
						{
							XPZ3B7O08A(stringBuilder, false, item3);
						}
						if (!list.HasData() && !strList.HasData())
						{
							stringBuilder.Append("<div class='p-5 text-muted fst-italic'>文件夹内容为空。</div>");
						}
						stringBuilder.AppendLine("</div>");
						stringBuilder.AppendLine("</form>");
						stringBuilder.AppendLine("</div></div>");
						return text.Replace("%BODY%", stringBuilder.ToString());
					}
					break;
				}
				break;
			}
		}
	}

	private void XPZ3B7O08A(StringBuilder stringBuilder_0, bool bool_3, string string_2)
	{
		string text = string_2.HtmlEncode();
		string text2 = Path.Combine(onP34Yp4ve, string_2);
		string text4 = default(string);
		while (true)
		{
			string text3 = "./" + string_2.EscapeUriDataString() + ((!bool_3) ? "" : "/");
			stringBuilder_0.AppendLine("<div class='file-item d-flex align-items-center'>");
			stringBuilder_0.AppendLine("<div class='file-icon-wrapper align-middle flex-shrink-0'>");
			int num = 1;
			if (EPptW3QQ9T8bKQRehx3d == null)
			{
				goto IL_0156;
			}
			goto IL_0312;
			IL_0095:
			stringBuilder_0.AppendLine("</div>");
			stringBuilder_0.AppendLine("</div>");
			stringBuilder_0.AppendLine("</div>");
			num = 0;
			if (EPptW3QQ9T8bKQRehx3d == null)
			{
				break;
			}
			goto IL_0312;
			IL_02ab:
			stringBuilder_0.AppendLine("</a>");
			stringBuilder_0.AppendLine("</div>");
			stringBuilder_0.AppendLine("<div class='flex-grow-1'>");
			stringBuilder_0.AppendLine("<div class='file-title d-flex'><div  class='flex-grow-1 '><a  href='" + text3 + "'>" + text + "</a></div><div class='ps-2 flex-shrink-0'><input type='checkbox' name='downitem' class='form-check-input' value='" + text + "'></div></div>");
			goto IL_00cd;
			IL_005d:
			stringBuilder_0.AppendLine("<span class='text-end mr-2'><a href='" + text3.HtmlEncode() + "?download=true' class='text-note file-size'>" + text4 + "</a></span>");
			goto IL_0095;
			IL_0312:
			switch (num)
			{
			case 3:
				break;
			case 4:
				goto IL_005d;
			case 2:
				goto IL_00cd;
			case 1:
				goto IL_0156;
			default:
				return;
			case 0:
				return;
			}
			continue;
			IL_0156:
			string text5 = string.Empty;
			string value = string.Empty;
			if (!bool_3)
			{
				text5 = (Bcs3ncuaqP(text2) ? " class='glightbox'  " : string.Empty);
				if (Kpf3jAYmBy(text2))
				{
					value = text3 + "?thumb=true";
				}
			}
			stringBuilder_0.Append("<a " + text5 + "  data-glightbox='title:" + text + "' href='" + text3 + "'>");
			if (bool_3)
			{
				stringBuilder_0.AppendLine("<img loading='lazy' src='/__fileicon?ext=" + text2.UrlEncode() + "' class='file-icon-img' />");
			}
			else if (!string.IsNullOrEmpty(value))
			{
				value = text3.HtmlEncode() + "?thumb=true";
				string userAgent = Bfx35Y3JwD.mNo3gumtVl().UserAgent;
				if (userAgent == null || userAgent.IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) <= 0)
				{
					string userAgent2 = Bfx35Y3JwD.mNo3gumtVl().UserAgent;
					if (userAgent2 == null || userAgent2.IndexOf("iPad", StringComparison.OrdinalIgnoreCase) <= 0)
					{
						stringBuilder_0.AppendLine("<img loading='lazy'  src='" + value + "' class='file-icon-img' />");
						goto IL_02ab;
					}
				}
				stringBuilder_0.AppendLine("<img loading='lazy'  data-src='" + value + "' class='lozad file-icon-img' />");
			}
			else
			{
				stringBuilder_0.AppendLine("<img loading='lazy'  src='/__fileicon?ext=" + Path.GetExtension(text2) + "' class='file-icon-img' />");
			}
			goto IL_02ab;
			IL_00cd:
			string text6 = (string.IsNullOrWhiteSpace(text2) ? "" : (bool_3 ? Directory.GetLastWriteTime(text2).ToString("yyyy-MM-dd HH:mm:ss") : File.GetLastWriteTime(text2).ToString("yyyy-MM-dd HH:mm:ss")));
			text4 = (bool_3 ? "" : new FileInfo(text2).Length.ToReadableSize());
			stringBuilder_0.AppendLine("<div class='small text-note d-flex justify-content-between'>");
			stringBuilder_0.AppendLine("<span class='text-end'>" + text6 + "</span>");
			if (!bool_3)
			{
				goto IL_005d;
			}
			goto IL_0095;
		}
	}

	private static bool jp63QXoRPx(string string_2)
	{
		return !string_2.EndsWithAny(true, ".lnk");
	}

	internal static bool Kpf3jAYmBy(string string_2)
	{
		return string_2.EndsWithAny(true, ".jpg", ".jpeg", ".gif", ".bmp", ".png", ".tiff", ".jfif", ".ico", ".webp", ".mp4", ".mov", ".avi", ".wmv");
	}

	private static bool Bcs3ncuaqP(string string_2)
	{
		return string_2.EndsWithAny(true, ".gif", ".jpg", ".jpeg", ".jfif", ".pjpeg", ".pjp", ".svg", ".ico", ".tif", ".tiff", ".webp", ".png", ".bmp", ".apng", ".avif", ".mp4", ".mov", ".wmv", ".avi", ".webm", ".mkv");
	}

	internal static bool E7MDvEQQLe392cFnwjTf()
	{
		return EPptW3QQ9T8bKQRehx3d == null;
	}
}
