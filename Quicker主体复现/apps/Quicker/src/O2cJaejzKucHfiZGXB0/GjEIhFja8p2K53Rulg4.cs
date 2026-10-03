using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using AeNud9jpLbfIkkEIprl;
using IgQBbvXMVdsN7GVNUxX;
using KpANinXqsG5PcsPtVpF;
using log4net;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace O2cJaejzKucHfiZGXB0;

internal class GjEIhFja8p2K53Rulg4 : F58U3QjL5trN9txFOH0
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec PakvQzCURb1;

		public static Action<LogData, string> myfvjwwxlED;

		internal static _003C_003Ec PrWDHOcsRMVEMY544WN4;

		static _003C_003Ec()
		{
			PakvQzCURb1 = new _003C_003Ec();
		}

		internal void Y2AvQfUVPRQ(LogData data, string s)
		{
			hmStsRW4ip4.Info(data.ToString());
		}

		internal static bool oQKB7vcsgf0bcnqt2wIR()
		{
			return PrWDHOcsRMVEMY544WN4 == null;
		}
	}

	private static readonly ILog hmStsRW4ip4;

	private WebsocketServerSettings E7BtsqnGQhj;

	private HttpServer zA5tscige8S;

	private static string yyEtsVMFGTA;

	private int yBftsZqG6yT = 1;

	internal static GjEIhFja8p2K53Rulg4 fF57UtQkxdhXrFdu7d2Z;

	public bool IsRunning => zA5tscige8S?.IsListening ?? false;

	public GjEIhFja8p2K53Rulg4()
	{
		AppState.m8Ot7JmPc2k(this);
	}

	public int QH6tsut5blZ()
	{
		if (!IsRunning)
		{
			return 0;
		}
		if (zA5tscige8S.WebSocketServices.TryGetServiceHost("/ws", out var host))
		{
			return host.Sessions.Count;
		}
		return 0;
	}

	[SpecialName]
	private WebSocketSessionManager iY2tsaRKHk3()
	{
		if (!IsRunning)
		{
			return null;
		}
		if (zA5tscige8S.WebSocketServices.TryGetServiceHost("/ws", out var host))
		{
			return host.Sessions;
		}
		return null;
	}

	public void QYLM2voUeQh()
	{
		WebsocketServerSettings websocketServerSettings = AppState.DataService.CpItmVISR7P().WebsocketServerSettings ?? new WebsocketServerSettings();
		if (zA5tscige8S != null)
		{
			int num = 0;
			if (!qJw1MXQkIipdtnxqK9Md())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (E7BtsqnGQhj != null && zA5tscige8S.IsListening && websocketServerSettings.IsEnabled && websocketServerSettings.Port == E7BtsqnGQhj.Port && websocketServerSettings.Password == E7BtsqnGQhj.Password && websocketServerSettings.EnableSecure == E7BtsqnGQhj.EnableSecure)
			{
				return;
			}
		}
		Stop();
		if (!websocketServerSettings.IsEnabled)
		{
			return;
		}
		try
		{
			E7BtsqnGQhj = AppHelper.Clone(websocketServerSettings);
			bool enableSecure = E7BtsqnGQhj.EnableSecure;
			zA5tscige8S = new HttpServer(E7BtsqnGQhj.Port, enableSecure);
			zA5tscige8S.KeepClean = true;
			zA5tscige8S.Log.Output = _003C_003Ec.myfvjwwxlED ?? (_003C_003Ec.myfvjwwxlED = _003C_003Ec.PakvQzCURb1.Y2AvQfUVPRQ);
			if (enableSecure)
			{
				c4ktsNLsAl0(zA5tscige8S);
			}
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_websocket");
			if (Directory.Exists(text))
			{
				if (!qJw1MXQkIipdtnxqK9Md())
				{
					switch (0)
					{
					}
				}
				zA5tscige8S.DocumentRootPath = text;
				zA5tscige8S.OnGet += P2ptsCWgAYM;
			}
			zA5tscige8S.AddWebSocketService<PKhsW5Xlli2epa94ZyO>("/ws");
			zA5tscige8S.Start();
			hmStsRW4ip4.Info("Websocket服务已启动");
		}
		catch (Exception ex)
		{
			hmStsRW4ip4.Warn("启动Websocket服务出错：" + ex.Message, ex);
			AppHelper.ShowWarning("启动Websocket服务出错：" + ex.Message);
		}
	}

	internal static void c4ktsNLsAl0(HttpServer httpServer_1)
	{
		var path = Path.Combine(Quicker.Domain.Services.AppPathProvider.LocalDataRoot, "certificates", "websocket.pfx");
		if (!File.Exists(path)) throw new FileNotFoundException("本地 HTTPS 需要你自己的 websocket.pfx 证书。请放入 certificates 目录；不会下载原厂证书。", path);
		var certificate = new X509Certificate2(path);
		if (!certificate.HasPrivateKey || certificate.NotAfter <= DateTime.Now)
		    throw new InvalidOperationException("本地 WebSocket 证书缺少私钥或已经过期。");
		httpServer_1.SslConfiguration.ServerCertificate = certificate;
		httpServer_1.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
	}



	private void P2ptsCWgAYM(object sender, HttpRequestEventArgs e)
	{
		HttpListenerRequest request = e.Request;
		HttpListenerResponse response = e.Response;
		string text = request.RawUrl;
		if (text == "/")
		{
			text += "index.html";
		}
		if (!e.TryReadFile(text, out var contents))
		{
			response.StatusCode = 404;
			if (fF57UtQkxdhXrFdu7d2Z != null)
			{
				switch (0)
				{
				}
			}
			return;
		}
		if (text.EndsWith(".html"))
		{
			response.ContentType = "text/html";
			response.ContentEncoding = Encoding.UTF8;
		}
		else if (text.EndsWith(".js"))
		{
			response.ContentType = "application/javascript";
			response.ContentEncoding = Encoding.UTF8;
		}
		response.ContentLength64 = contents.LongLength;
		response.Close(contents, true);
	}

	public void Stop()
	{
		zA5tscige8S?.Stop();
		zA5tscige8S = null;
	}

	public void woFM2c60JjB()
	{
		QYLM2voUeQh();
	}

	protected int h6ttsP6iJqc()
	{
		return yBftsZqG6yT++;
	}

	public void a29tsE8r0iN(string string_1)
	{
		if (!IsRunning)
		{
			throw new InvalidOperationException("服务未运行。");
		}
		WebSocketRequest? obj = JsonConvert.DeserializeObject<WebSocketRequest>(string_1) ?? throw new InvalidDataException("消息内容格式不正确。");
		obj.Serial = h6ttsP6iJqc();
		obj.MessageType = 2;
		string string_2 = obj.ToCamelCaseJson();
		SOetsyotFpl(string_2);
	}

	private void SOetsyotFpl(string string_1)
	{
		foreach (IWebSocketSession session in iY2tsaRKHk3().Sessions)
		{
			if (session is PKhsW5Xlli2epa94ZyO pKhsW5Xlli2epa94ZyO)
			{
				if (pKhsW5Xlli2epa94ZyO.N8XtsxJwQjk())
				{
					pKhsW5Xlli2epa94ZyO.Ij5tsW72qkf(string_1);
				}
				continue;
			}
			throw new InvalidOperationException("对象类型不正确。");
		}
	}

	private void X8Cts8upigb(object object_0)
	{
		SOetsyotFpl(object_0.ToCamelCaseJson());
	}

	public void SendFileToClient(string file, bool bool_0)
	{
		WebSocketRequest webSocketRequest = new WebSocketRequest
		{
			MessageType = 2,
			Operation = "sendfile",
			Data = Path.GetFileName(file),
			Serial = h6ttsP6iJqc()
		};
		if (bool_0)
		{
			byte[] inArray = File.ReadAllBytes(file);
			webSocketRequest.ExtData = Convert.ToBase64String(inArray);
			X8Cts8upigb(webSocketRequest);
			return;
		}
		X8Cts8upigb(webSocketRequest);
		FileInfo fileInfo_ = new FileInfo(file);
		foreach (IWebSocketSession session in iY2tsaRKHk3().Sessions)
		{
			((session as PKhsW5Xlli2epa94ZyO) ?? throw new InvalidOperationException("对象类型不正确。")).Ja3tskQojKA(fileInfo_);
		}
	}

	static GjEIhFja8p2K53Rulg4()
	{
		hmStsRW4ip4 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		yyEtsVMFGTA = null;
	}

	internal static bool qJw1MXQkIipdtnxqK9Md()
	{
		return fF57UtQkxdhXrFdu7d2Z == null;
	}

	internal static void YHWMwRQkzAZmLZ2nPYdO()
	{
	}
}
