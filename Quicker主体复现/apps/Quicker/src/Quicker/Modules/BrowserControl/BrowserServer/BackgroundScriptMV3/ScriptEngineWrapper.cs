using System;
using System.Runtime.CompilerServices;
using Jint;
using Jint.Native;
using Jint.Runtime.Interop;

namespace Quicker.Modules.BrowserControl.BrowserServer.BackgroundScriptMV3;

public class ScriptEngineWrapper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec V2bv6i3Ark8;

		public static Action<Options> Qtmv63qttZX;

		private static _003C_003Ec e1sQDCcI8OeD1Mg5UXTw;

		static _003C_003Ec()
		{
			V2bv6i3Ark8 = new _003C_003Ec();
		}

		internal void oLWv6lgLWRU(Options cfg)
		{
			cfg.AllowClr();
		}

		internal static bool z4E2qxcIRwQqMUGh5F55()
		{
			return e1sQDCcI8OeD1Mg5UXTw == null;
		}
	}

	private readonly Engine udGt8vst23g;

	private static ScriptEngineWrapper xEm4ftQ3ssyeZnJxIdDJ;

	public ScriptEngineWrapper()
	{
		udGt8vst23g = new Engine(_003C_003Ec.Qtmv63qttZX ?? (_003C_003Ec.Qtmv63qttZX = _003C_003Ec.V2bv6i3Ark8.oLWv6lgLWRU));
	}

	public void InjectObject(string name, object obj)
	{
		udGt8vst23g.SetValue(name, obj);
	}

	public void InjectStaticClass(string name, Type type)
	{
		if (type.IsAbstract && type.IsSealed)
		{
			Console.WriteLine("Warning: Type '" + type.Name + "' is not a static class. Injecting type reference.");
			udGt8vst23g.SetValue(name, TypeReference.CreateTypeReference(udGt8vst23g, type));
		}
		else
		{
			udGt8vst23g.SetValue(name, TypeReference.CreateTypeReference(udGt8vst23g, type));
		}
	}

	public void InjectFunction(string name, Delegate func)
	{
		udGt8vst23g.SetValue(name, func);
	}

	public JsValue Execute(string script)
	{
		try
		{
			return udGt8vst23g.Evaluate(script);
		}
		catch (Exception)
		{
			throw;
		}
	}

	public T? Execute<T>(string script)
	{
		try
		{
			JsValue jsValue = udGt8vst23g.Evaluate(script);
			if (!jsValue.IsUndefined() && !jsValue.IsNull())
			{
				object obj = jsValue.ToObject();
				if (obj is T result)
				{
					return result;
				}
				try
				{
					return (T)Convert.ChangeType(obj, typeof(T));
				}
				catch (InvalidCastException ex)
				{
					Console.WriteLine($"JavaScript Error: Could not convert result to type {typeof(T)}. Details: {ex.Message}");
					return default(T);
				}
			}
			return default(T);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("JavaScript Error: " + ex2.Message);
			return default(T);
		}
	}

	internal static bool JHC9jdQ3Ctu5VxabaKcm()
	{
		return xEm4ftQ3ssyeZnJxIdDJ == null;
	}
}
