using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AeNud9jpLbfIkkEIprl;
using Cf6JJSwcQUQTyf1yfiU;
using ExCR1awPdHblsSJeByB;
using GImOAQweqmEnB5RDWmL;
using gJZH3yw0A1HYrIgeu6r;
using MtVqD1wpnJyjrXWZvDs;
using ptM0iZwQKEIEeCghbJH;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Settings.Pages.Basic.AutoTriggers;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using r3EUytwSQ9vNYu3Es8s;
using RRoR9nwgtVCq3OBJhph;
using Tx9KyNwN0mDt2JKQRKC;
using u8oQ2EwZU09ckNFKKpC;
using vM86xNwxkAjTFkKFfXq;
using wwbmqGwON3D9BxqCkYx;
using xrumSgw32Gh3YjqDtxf;
using yikmOhWqD2CnZhpxUXe;
using zNLRWkwFGSoZfhTlm4l;
using zOiWIIwJdlJ0kZHdkY2;

namespace b1cqfYwMXvNpZCY2I0h;

internal class hCyEQ4wY2DjoFMCBvTM : F58U3QjL5trN9txFOH0
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string JSZvIEZrLQw;

		private static _003C_003Ec__DisplayClass3_0 oURe6TclM33S8EOGNXJ3;

		internal bool dZivIP8eOsp(oXLGvbwTuCxD9pGrbDD x)
		{
			return x.V9HM2l6b46l().Contains(JSZvIEZrLQw);
		}

		internal static bool ES90xtclUL7bsyc6Egxf()
		{
			return oURe6TclM33S8EOGNXJ3 == null;
		}
	}

	private IList<oXLGvbwTuCxD9pGrbDD> yfhztTGFeq = new List<oXLGvbwTuCxD9pGrbDD>();

	[CompilerGenerated]
	private bool SApzgBVepP;

	private static hCyEQ4wY2DjoFMCBvTM px8TYKQFeyAxxUVRMvqV;

	public bool IsRunning
	{
		[CompilerGenerated]
		get
		{
			return SApzgBVepP;
		}
		[CompilerGenerated]
		private set
		{
			SApzgBVepP = value;
		}
	}

	public hCyEQ4wY2DjoFMCBvTM()
	{
		Wb9fivne6X();
		AppState.Xbft7VsD93B(this);
	}

	private void Wb9fivne6X()
	{
		yfhztTGFeq.Add(new sZ7Hw3WlCa6SJ2l40F1());
		yfhztTGFeq.Add(new UXtsDmwBbNNuVkh22SK());
		if (NativeMethods.IsOnWindows10OrLater())
		{
			yfhztTGFeq.Add(new dRyrhtwRWUqEAEUvLhs());
			yfhztTGFeq.Add(new XIGHJKw1eE9po2LdeSn());
			yfhztTGFeq.Add(new a1eYQTw9GUIJbjdDTW5());
		}
		yfhztTGFeq.Add(new CJaKC4wvor327sX3hhe());
		yfhztTGFeq.Add(new vRibjhwb53dP6TpCN6i());
		yfhztTGFeq.Add(new XwejR1wKkVTKEoL89HT());
		yfhztTGFeq.Add(new ovZAJ4wUJ47El63DyWm());
		yfhztTGFeq.Add(new cEquwXwn27y7jERmTG4());
		yfhztTGFeq.Add(new PH5f3QwVqH0eio5fc3A());
		yfhztTGFeq.Add(new Q8bOxkwtfNrYNxKUGE5());
		yfhztTGFeq.Add(new SrM6V3wLbEFy7idXJ4o());
		yfhztTGFeq.Add(new SXBKuXwEjqsIlBiIoyp());
		int num = 0;
		if (px8TYKQFeyAxxUVRMvqV != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		yfhztTGFeq.Add(new vCms05wsdhGGw5igDfX());
	}

	public oXLGvbwTuCxD9pGrbDD QS1f3oYkWA(string string_0)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.JSZvIEZrLQw = string_0;
		return yfhztTGFeq.FirstOrDefault(_003C_003Ec__DisplayClass3_.dZivIP8eOsp);
	}

	public void QYLM2voUeQh()
	{
		foreach (oXLGvbwTuCxD9pGrbDD item in yfhztTGFeq)
		{
			item.Reset();
		}
		if (!AppState.HHxtaMaoqJr().TriggerTasks.HasData())
		{
			return;
		}
		int num2 = default(int);
		foreach (CommonTriggerTask triggerTask in AppState.HHxtaMaoqJr().TriggerTasks)
		{
			if (!triggerTask.IsEnabled || !AppHelper.IsMachineValid(triggerTask.ValidForMachines) || triggerTask.ActionIdOrName.IsNullOrEmpty())
			{
				continue;
			}
			int num = 0;
			if (!X3QwwwQFj85fIfCaR2da())
			{
				num = num2;
			}
			switch (num)
			{
			}
			foreach (oXLGvbwTuCxD9pGrbDD item2 in yfhztTGFeq)
			{
				if (item2.V9HM2l6b46l().Contains(triggerTask.EventType) && item2.SGDMjxjBB7g(triggerTask))
				{
					break;
				}
			}
		}
		foreach (oXLGvbwTuCxD9pGrbDD item3 in yfhztTGFeq)
		{
			if (item3.JbmMjsn1vpM())
			{
				item3.QYLM2voUeQh();
			}
		}
		IsRunning = true;
	}

	public void Stop()
	{
		foreach (oXLGvbwTuCxD9pGrbDD item in yfhztTGFeq)
		{
			item.Stop();
		}
		IsRunning = false;
	}

	public void woFM2c60JjB()
	{
		QYLM2voUeQh();
	}

	public IList<string> B1WffkBICk()
	{
		List<string> list = new List<string>();
		foreach (oXLGvbwTuCxD9pGrbDD item2 in yfhztTGFeq)
		{
			string[] array = item2.V9HM2l6b46l();
			foreach (string item in array)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public IList<EventTypeInfo> yF5fza3sIW()
	{
		List<EventTypeInfo> list = new List<EventTypeInfo>();
		foreach (oXLGvbwTuCxD9pGrbDD item in yfhztTGFeq)
		{
			string[] array = item.V9HM2l6b46l();
			foreach (string text in array)
			{
				list.Add(new EventTypeInfo
				{
					EventType = text,
					Description = item.wSbM2zcwFbs(text)
				});
			}
		}
		return list;
	}

	internal static bool X3QwwwQFj85fIfCaR2da()
	{
		return px8TYKQFeyAxxUVRMvqV == null;
	}
}
