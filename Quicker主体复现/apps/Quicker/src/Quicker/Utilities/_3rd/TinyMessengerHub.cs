using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities._3rd;

public sealed class TinyMessengerHub : ITinyMessengerHub
{
	private class qLJbLFHjh1heQGgOdoF<hKI2W5HXp77D7KtUI1T> : ITinyMessageSubscription where hKI2W5HXp77D7KtUI1T : class, ITinyMessage
	{
		protected readonly TinyMessageSubscriptionToken pQJ2NhGZ52s;

		protected readonly WeakReference sHZ2NemHedI;

		protected readonly WeakReference sHs2NYmwv4n;

		internal static object rfwlqFyB0xX1Ym0RRAyp;

		public TinyMessageSubscriptionToken SubscriptionToken => pQJ2NhGZ52s;

		public bool ShouldAttemptDelivery(ITinyMessage message)
		{
			if (message == null)
			{
				return false;
			}
			if (!typeof(hKI2W5HXp77D7KtUI1T).IsAssignableFrom(message.GetType()))
			{
				return false;
			}
			if (!sHZ2NemHedI.IsAlive)
			{
				return false;
			}
			if (!sHs2NYmwv4n.IsAlive)
			{
				return false;
			}
			return ((Func<hKI2W5HXp77D7KtUI1T, bool>)sHs2NYmwv4n.Target)(message as hKI2W5HXp77D7KtUI1T);
		}

		public void Deliver(ITinyMessage message)
		{
			if (message is hKI2W5HXp77D7KtUI1T)
			{
				if (sHZ2NemHedI.IsAlive)
				{
					((Action<hKI2W5HXp77D7KtUI1T>)sHZ2NemHedI.Target)(message as hKI2W5HXp77D7KtUI1T);
				}
				return;
			}
			throw new ArgumentException("Message is not the correct type");
		}

		public qLJbLFHjh1heQGgOdoF(TinyMessageSubscriptionToken tinyMessageSubscriptionToken_1, Action<hKI2W5HXp77D7KtUI1T> action_0, Func<hKI2W5HXp77D7KtUI1T, bool> func_0)
		{
			if (tinyMessageSubscriptionToken_1 == null)
			{
				throw new ArgumentNullException("subscriptionToken");
			}
			if (action_0 == null)
			{
				throw new ArgumentNullException("deliveryAction");
			}
			if (func_0 == null)
			{
				throw new ArgumentNullException("messageFilter");
			}
			pQJ2NhGZ52s = tinyMessageSubscriptionToken_1;
			sHZ2NemHedI = new WeakReference(action_0);
			sHs2NYmwv4n = new WeakReference(func_0);
		}

		internal static bool gSfYGnyB1daS3kIp8N1N()
		{
			return rfwlqFyB0xX1Ym0RRAyp == null;
		}
	}

	private class uIaWFvHoo5BYINRSMew<P6uqoJHY8jefBqHAsZa> : ITinyMessageSubscription where P6uqoJHY8jefBqHAsZa : class, ITinyMessage
	{
		protected readonly TinyMessageSubscriptionToken VW42NIV2DIE;

		protected readonly Action<P6uqoJHY8jefBqHAsZa> dVV2NW8dfpl;

		protected readonly Func<P6uqoJHY8jefBqHAsZa, bool> yry2NkVCxAP;

		private static object r5UP9tyBBWRLJb0fNTTi;

		public TinyMessageSubscriptionToken SubscriptionToken => VW42NIV2DIE;

		public bool ShouldAttemptDelivery(ITinyMessage message)
		{
			if (message == null)
			{
				return false;
			}
			if (!typeof(P6uqoJHY8jefBqHAsZa).IsAssignableFrom(message.GetType()))
			{
				return false;
			}
			return yry2NkVCxAP(message as P6uqoJHY8jefBqHAsZa);
		}

		public void Deliver(ITinyMessage message)
		{
			if (!(message is P6uqoJHY8jefBqHAsZa))
			{
				throw new ArgumentException("Message is not the correct type");
			}
			dVV2NW8dfpl(message as P6uqoJHY8jefBqHAsZa);
		}

		public uIaWFvHoo5BYINRSMew(TinyMessageSubscriptionToken tinyMessageSubscriptionToken_1, Action<P6uqoJHY8jefBqHAsZa> action_1, Func<P6uqoJHY8jefBqHAsZa, bool> func_1)
		{
			if (tinyMessageSubscriptionToken_1 == null)
			{
				throw new ArgumentNullException("subscriptionToken");
			}
			if (action_1 == null)
			{
				throw new ArgumentNullException("deliveryAction");
			}
			if (func_1 == null)
			{
				throw new ArgumentNullException("messageFilter");
			}
			VW42NIV2DIE = tinyMessageSubscriptionToken_1;
			dVV2NW8dfpl = action_1;
			yry2NkVCxAP = func_1;
		}

		internal static bool fl2gkGyBvoSQ79puwPgi()
		{
			return r5UP9tyBBWRLJb0fNTTi == null;
		}
	}

	internal class AXiwAXHMksyaEEVXKCS
	{
		[CompilerGenerated]
		private ITinyMessageProxy UER2N6qnrc1;

		[CompilerGenerated]
		private ITinyMessageSubscription C5D2NXTeXtl;

		private static AXiwAXHMksyaEEVXKCS MmfcZayBOlbboMLFuZDY;

		public ITinyMessageProxy Proxy
		{
			[CompilerGenerated]
			get
			{
				return UER2N6qnrc1;
			}
			[CompilerGenerated]
			private set
			{
				UER2N6qnrc1 = value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public ITinyMessageSubscription Kyc2NHsSG9O()
		{
			return C5D2NXTeXtl;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Jrh2N1bBugg(ITinyMessageSubscription itinyMessageSubscription_1)
		{
			C5D2NXTeXtl = itinyMessageSubscription_1;
		}

		public AXiwAXHMksyaEEVXKCS(ITinyMessageProxy itinyMessageProxy_1, ITinyMessageSubscription itinyMessageSubscription_1)
		{
			Proxy = itinyMessageProxy_1;
			Jrh2N1bBugg(itinyMessageSubscription_1);
		}

		internal static bool iludOKyBJCC2wU04sO4j()
		{
			return MmfcZayBOlbboMLFuZDY == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__10<TMessage> where TMessage : class, ITinyMessage
	{
		public static readonly _003C_003Ec__10<TMessage> _003C_003E9;

		public static Func<TMessage, bool> _003C_003E9__10_0;

		internal static object j2nCt6yBaJNYxjryUPfn;

		static _003C_003Ec__10()
		{
			_003C_003E9 = new _003C_003Ec__10<TMessage>();
		}

		internal bool kCT2NmGncuH(TMessage m)
		{
			return true;
		}

		internal static bool SNmC96yBr97W1VPBQVT6()
		{
			return j2nCt6yBaJNYxjryUPfn == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__11<TMessage> where TMessage : class, ITinyMessage
	{
		public static readonly _003C_003Ec__11<TMessage> _003C_003E9;

		public static Func<TMessage, bool> _003C_003E9__11_0;

		private static object KqrtkMyB9wXyRMatk9WK;

		static _003C_003Ec__11()
		{
			_003C_003E9 = new _003C_003Ec__11<TMessage>();
		}

		internal bool lqj2NKjaIWe(TMessage m)
		{
			return true;
		}

		internal static bool rc5032yBL0wysBet9k2e()
		{
			return KqrtkMyB9wXyRMatk9WK == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__8<TMessage> where TMessage : class, ITinyMessage
	{
		public static readonly _003C_003Ec__8<TMessage> _003C_003E9;

		public static Func<TMessage, bool> _003C_003E9__8_0;

		internal static object AGepCuyBowjGbtpZeECa;

		static _003C_003Ec__8()
		{
			_003C_003E9 = new _003C_003Ec__8<TMessage>();
		}

		internal bool l5P2Nx53jl2(TMessage m)
		{
			return true;
		}

		internal static bool OmleFCyBf9WHdFkBAfOB()
		{
			return AGepCuyBowjGbtpZeECa == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec__9<TMessage> where TMessage : class, ITinyMessage
	{
		public static readonly _003C_003Ec__9<TMessage> _003C_003E9;

		public static Func<TMessage, bool> _003C_003E9__9_0;

		private static object aVcIPmyBq4nIxAOTWSIU;

		static _003C_003Ec__9()
		{
			_003C_003E9 = new _003C_003Ec__9<TMessage>();
		}

		internal bool bXP2NreQni1(TMessage m)
		{
			return true;
		}

		internal static bool ovV8aRyBisIwBDjHCoPY()
		{
			return aVcIPmyBq4nIxAOTWSIU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0<TMessage> where TMessage : class, ITinyMessage
	{
		public TinyMessageSubscriptionToken subscriptionToken;

		public TinyMessengerHub _003C_003E4__this;

		internal static object ssGFE0yBZKOZcJd3XeRK;

		internal bool xTP2NpmI2kd(AXiwAXHMksyaEEVXKCS sub)
		{
			return sub.Kyc2NHsSG9O().SubscriptionToken == subscriptionToken;
		}

		internal void oBW2NBmmUSE(AXiwAXHMksyaEEVXKCS sub)
		{
			_003C_003E4__this.dVgLzKvcydX.Remove(sub);
		}

		internal static bool HcMar4yB51y1qqfyCnuS()
		{
			return ssGFE0yBZKOZcJd3XeRK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0<TMessage> where TMessage : class, ITinyMessage
	{
		public TMessage message;

		public TinyMessengerHub _003C_003E4__this;

		internal static object BhxiAfyB8VWjBl4wB6qn;

		internal bool NCY2NQqfCrB(AXiwAXHMksyaEEVXKCS sub)
		{
			return sub.Kyc2NHsSG9O().ShouldAttemptDelivery(message);
		}

		internal void EDH2NjZgDsg(AXiwAXHMksyaEEVXKCS sub)
		{
			try
			{
				sub.Proxy.Deliver(message, sub.Kyc2NHsSG9O());
			}
			catch (Exception exception)
			{
				_003C_003E4__this.Q9ALzX4tcfW.Handle(message, exception);
			}
		}

		internal static bool edSyUQyBRl0smKyvfO9M()
		{
			return BhxiAfyB8VWjBl4wB6qn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0<TMessage> where TMessage : class, ITinyMessage
	{
		public TinyMessengerHub _003C_003E4__this;

		public TMessage message;

		internal static object W7Im6PyBPNFKCiwMFrTE;

		internal void Lv02NnP7rSv()
		{
			_003C_003E4__this.IBbLzbBkGN4(message);
		}

		internal static bool csO0NjyBMiO0O1AiMhjP()
		{
			return W7Im6PyBPNFKCiwMFrTE == null;
		}
	}

	private readonly ISubscriberErrorHandler Q9ALzX4tcfW;

	private readonly object PsrLzm0CLrF = new object();

	private readonly List<AXiwAXHMksyaEEVXKCS> dVgLzKvcydX = new List<AXiwAXHMksyaEEVXKCS>();

	private static TinyMessengerHub UCq46jFm3OIJyBkJiK9E;

	public TinyMessengerHub()
	{
		Q9ALzX4tcfW = new DefaultSubscriberErrorHandler();
	}

	public TinyMessengerHub(ISubscriberErrorHandler subscriberErrorHandler)
	{
		Q9ALzX4tcfW = subscriberErrorHandler;
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, _003C_003Ec__8<TMessage>._003C_003E9__8_0 ?? (_003C_003Ec__8<TMessage>._003C_003E9__8_0 = _003C_003Ec__8<TMessage>._003C_003E9.l5P2Nx53jl2), true, DefaultTinyMessageProxy.Instance);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, _003C_003Ec__9<TMessage>._003C_003E9__9_0 ?? (_003C_003Ec__9<TMessage>._003C_003E9__9_0 = _003C_003Ec__9<TMessage>._003C_003E9.bXP2NreQni1), true, proxy);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, bool useStrongReferences) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, _003C_003Ec__10<TMessage>._003C_003E9__10_0 ?? (_003C_003Ec__10<TMessage>._003C_003E9__10_0 = _003C_003Ec__10<TMessage>._003C_003E9.kCT2NmGncuH), useStrongReferences, DefaultTinyMessageProxy.Instance);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, bool useStrongReferences, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, _003C_003Ec__11<TMessage>._003C_003E9__11_0 ?? (_003C_003Ec__11<TMessage>._003C_003E9__11_0 = _003C_003Ec__11<TMessage>._003C_003E9.lqj2NKjaIWe), useStrongReferences, proxy);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, messageFilter, true, DefaultTinyMessageProxy.Instance);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, messageFilter, true, proxy);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, bool useStrongReferences) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, messageFilter, useStrongReferences, DefaultTinyMessageProxy.Instance);
	}

	public TinyMessageSubscriptionToken Subscribe<TMessage>(Action<TMessage> deliveryAction, Func<TMessage, bool> messageFilter, bool useStrongReferences, ITinyMessageProxy proxy) where TMessage : class, ITinyMessage
	{
		return yfKLzHpL9Yu(deliveryAction, messageFilter, useStrongReferences, proxy);
	}

	public void Unsubscribe<TMessage>(TinyMessageSubscriptionToken subscriptionToken) where TMessage : class, ITinyMessage
	{
		ufJLz1el0c8<TMessage>(subscriptionToken);
	}

	public void Unsubscribe(TinyMessageSubscriptionToken subscriptionToken)
	{
		ufJLz1el0c8<ITinyMessage>(subscriptionToken);
	}

	public void Publish<TMessage>(TMessage message) where TMessage : class, ITinyMessage
	{
		IBbLzbBkGN4(message);
	}

	public void PublishAsync<TMessage>(TMessage message) where TMessage : class, ITinyMessage
	{
		rdCLz6YxAJY(message, null);
	}

	public void PublishAsync<TMessage>(TMessage message, AsyncCallback callback) where TMessage : class, ITinyMessage
	{
		rdCLz6YxAJY(message, callback);
	}

	private TinyMessageSubscriptionToken yfKLzHpL9Yu<o31rID7GWPIVbS3Anf4>(Action<o31rID7GWPIVbS3Anf4> action_0, Func<o31rID7GWPIVbS3Anf4, bool> func_0, bool bool_0, ITinyMessageProxy itinyMessageProxy_0) where o31rID7GWPIVbS3Anf4 : class, ITinyMessage
	{
		if (action_0 == null)
		{
			throw new ArgumentNullException("deliveryAction");
		}
		if (func_0 == null)
		{
			throw new ArgumentNullException("messageFilter");
		}
		if (itinyMessageProxy_0 == null)
		{
			throw new ArgumentNullException("proxy");
		}
		lock (PsrLzm0CLrF)
		{
			TinyMessageSubscriptionToken tinyMessageSubscriptionToken = new TinyMessageSubscriptionToken(this, typeof(o31rID7GWPIVbS3Anf4));
			ITinyMessageSubscription itinyMessageSubscription_ = ((!bool_0) ? ((ITinyMessageSubscription)new qLJbLFHjh1heQGgOdoF<o31rID7GWPIVbS3Anf4>(tinyMessageSubscriptionToken, action_0, func_0)) : ((ITinyMessageSubscription)new uIaWFvHoo5BYINRSMew<o31rID7GWPIVbS3Anf4>(tinyMessageSubscriptionToken, action_0, func_0)));
			dVgLzKvcydX.Add(new AXiwAXHMksyaEEVXKCS(itinyMessageProxy_0, itinyMessageSubscription_));
			return tinyMessageSubscriptionToken;
		}
	}

	private void ufJLz1el0c8<J5BRVX7LplODUvkfVxR>(TinyMessageSubscriptionToken tinyMessageSubscriptionToken_0) where J5BRVX7LplODUvkfVxR : class, ITinyMessage
	{
		_003C_003Ec__DisplayClass22_0<J5BRVX7LplODUvkfVxR> _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0<J5BRVX7LplODUvkfVxR>();
		_003C_003Ec__DisplayClass22_.subscriptionToken = tinyMessageSubscriptionToken_0;
		_003C_003Ec__DisplayClass22_._003C_003E4__this = this;
		if (_003C_003Ec__DisplayClass22_.subscriptionToken == null)
		{
			throw new ArgumentNullException("subscriptionToken");
		}
		lock (PsrLzm0CLrF)
		{
			dVgLzKvcydX.Where(_003C_003Ec__DisplayClass22_.xTP2NpmI2kd).ToList().ForEach(_003C_003Ec__DisplayClass22_.oBW2NBmmUSE);
		}
	}

	private void IBbLzbBkGN4<N7puRv7pQPvTXj21GYM>(N7puRv7pQPvTXj21GYM eLCdJC7aCR2hwr35wMj) where N7puRv7pQPvTXj21GYM : class, ITinyMessage
	{
		_003C_003Ec__DisplayClass23_0<N7puRv7pQPvTXj21GYM> _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0<N7puRv7pQPvTXj21GYM>();
		_003C_003Ec__DisplayClass23_.message = eLCdJC7aCR2hwr35wMj;
		_003C_003Ec__DisplayClass23_._003C_003E4__this = this;
		if (_003C_003Ec__DisplayClass23_.message == null)
		{
			throw new ArgumentNullException("message");
		}
		List<AXiwAXHMksyaEEVXKCS> list;
		lock (PsrLzm0CLrF)
		{
			list = dVgLzKvcydX.Where(_003C_003Ec__DisplayClass23_.NCY2NQqfCrB).ToList();
		}
		list.ForEach(_003C_003Ec__DisplayClass23_.EDH2NjZgDsg);
	}

	private void rdCLz6YxAJY<ANsshb7zidA3ZDMcbnQ>(ANsshb7zidA3ZDMcbnQ do3IgdilY2F5HrEbGKa, AsyncCallback asyncCallback_0) where ANsshb7zidA3ZDMcbnQ : class, ITinyMessage
	{
		_003C_003Ec__DisplayClass24_0<ANsshb7zidA3ZDMcbnQ> _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0<ANsshb7zidA3ZDMcbnQ>();
		_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass24_.message = do3IgdilY2F5HrEbGKa;
		new Action(_003C_003Ec__DisplayClass24_.Lv02NnP7rSv).BeginInvoke(asyncCallback_0, null);
	}

	internal static bool Ejjn6ZFmEN3SBjQPPlnP()
	{
		return UCq46jFm3OIJyBkJiK9E == null;
	}
}
