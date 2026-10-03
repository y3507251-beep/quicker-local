using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AeNud9jpLbfIkkEIprl;
using b1cqfYwMXvNpZCY2I0h;
using GEs2Jejr6IXgOTY0tM8;
using J7BsCmjJgKtd6cIAc1p;
using log4net;
using O2cJaejzKucHfiZGXB0;
using Quicker.Domain.Messages;
using Quicker.Utilities._3rd;

namespace kQya3FXgcklGlgx1NYl;

internal class S4xmQLXUpuXTfeUvpKh
{
	private readonly ITinyMessengerHub bV1tj00uG4S;

	private IList<F58U3QjL5trN9txFOH0> pHNtjCPmlKe = new List<F58U3QjL5trN9txFOH0>();

	private static readonly ILog Y4etjPOhxYw;

	internal static S4xmQLXUpuXTfeUvpKh GfWPGSQLM3VlGWkebF4e;

	public S4xmQLXUpuXTfeUvpKh(ITinyMessengerHub itinyMessengerHub_1)
	{
		bV1tj00uG4S = itinyMessengerHub_1;
		bV1tj00uG4S.Subscribe<UserSettingsChangedMessage>(a8ftjSJa7Gs);
		CL2tj2JFoLH();
	}

	private void a8ftjSJa7Gs(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		jVrtjNxmGVF();
	}

	public void CL2tj2JFoLH()
	{
		pHNtjCPmlKe.Add(new GjEIhFja8p2K53Rulg4());
		pHNtjCPmlKe.Add(new WsnAlhjCfHjoVZXu241());
		pHNtjCPmlKe.Add(new hCyEQ4wY2DjoFMCBvTM());
		pHNtjCPmlKe.Add(OeTcebjK6vK0y2ZOMOQ.pUhtkmFk1ed());
	}

	public void Tg3tjuRLwyW()
	{
		Task.Run((Action)siutjJcJxq4);
	}

	public void Stop()
	{
		foreach (F58U3QjL5trN9txFOH0 item in pHNtjCPmlKe)
		{
			try
			{
				item.Stop();
			}
			catch (Exception ex)
			{
				Y4etjPOhxYw.Warn("关闭后台服务 " + item.GetType().Name + " 出错：" + ex.Message, ex);
			}
		}
	}

	public void jVrtjNxmGVF()
	{
		foreach (F58U3QjL5trN9txFOH0 item in pHNtjCPmlKe)
		{
			try
			{
				item.woFM2c60JjB();
			}
			catch (Exception ex)
			{
				Y4etjPOhxYw.Warn("关闭后台服务 " + item.GetType().Name + " 出错：" + ex.Message, ex);
			}
		}
	}

	static S4xmQLXUpuXTfeUvpKh()
	{
		Y4etjPOhxYw = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void siutjJcJxq4()
	{
		foreach (F58U3QjL5trN9txFOH0 item in pHNtjCPmlKe)
		{
			try
			{
				item.QYLM2voUeQh();
			}
			catch (Exception ex)
			{
				Y4etjPOhxYw.Warn("启动后台服务 " + item.GetType().Name + " 出错：" + ex.Message, ex);
			}
		}
	}

	internal static bool H2oWDWQLURFkkfZJwIiC()
	{
		return GfWPGSQLM3VlGWkebF4e == null;
	}
}
