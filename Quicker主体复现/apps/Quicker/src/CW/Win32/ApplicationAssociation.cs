using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

namespace CW.Win32;

public static class ApplicationAssociation
{
	private static WeakReference HR60MYg1FY;

	private static readonly Guid yFa0ALwxFV;

	private static Guid vt10OljhF8;

	internal static object RvEx6DEfS8QJmq7HIjf;

	public static bool IsEnableUac
	{
		get
		{
			if (!Trd0otNslf())
			{
				return false;
			}
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\\\Windows\\CurrentVersion\\Policies\\System", false);
			return (int)registryKey.GetValue("EnableLUA", 0) > 0;
		}
	}

	public static bool IsAdministrator => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

	[SpecialName]
	private static IApplicationAssociationRegistration MBq0Ds0ICH()
	{
		object obj;
		if (HR60MYg1FY == null || (obj = HR60MYg1FY.Target) == null)
		{
			obj = new ComObject<IApplicationAssociationRegistration>((IApplicationAssociationRegistration)new ApplicationAssociationRegistration());
			HR60MYg1FY = new WeakReference(obj);
		}
		return ((ComObject<IApplicationAssociationRegistration>)obj).Interface;
	}

	[SpecialName]
	private static bool Trd0otNslf()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			return Environment.OSVersion.Version.Major >= 6;
		}
		return false;
	}

	public static string GetCurrentDefault(string extOrProto, AssociationType assocType, AssociationLevel assocLevel)
	{
		if (!Trd0otNslf())
		{
			throw new NotSupportedException();
		}
		Marshal.ThrowExceptionForHR(MBq0Ds0ICH().QueryCurrentDefault(extOrProto, assocType, assocLevel, out var ppszAssociation));
		return ppszAssociation;
	}

	public static bool IsAppDefault(string appRegisterName, string extOrProto, AssociationType assocType, AssociationLevel assocLevel)
	{
		if (Trd0otNslf())
		{
			try
			{
				Marshal.ThrowExceptionForHR(MBq0Ds0ICH().QueryAppIsDefault(extOrProto, assocType, assocLevel, appRegisterName, out var pfDefault));
				return pfDefault;
			}
			catch (FileNotFoundException)
			{
				return false;
			}
		}
		Marshal.ThrowExceptionForHR(lmx05eLDWq(yFa0ALwxFV, ref vt10OljhF8, out var object_));
		IQueryAssociations obj = (IQueryAssociations)object_;
		obj.Init(AssociationInitializeOptions.None, extOrProto, IntPtr.Zero, IntPtr.Zero);
		StringBuilder stringBuilder = null;
		obj.GetString(AssociationOptions.None, AssociationString.FriendlyApplicationName, null, null, out var length);
		stringBuilder = new StringBuilder(length);
		obj.GetString(AssociationOptions.None, AssociationString.FriendlyApplicationName, null, stringBuilder, out length);
		stringBuilder = null;
		return stringBuilder.ToString() == appRegisterName;
	}

	[DllImport("shlwapi.dll", EntryPoint = "AssocCreate")]
	private static extern int lmx05eLDWq(Guid guid_2, ref Guid guid_3, [MarshalAs(UnmanagedType.Interface)] out object object_0);

	public static bool IsAppDefaultAll(string appRegisterName, AssociationLevel assocLevel)
	{
		if (!Trd0otNslf())
		{
			throw new NotSupportedException();
		}
		Marshal.ThrowExceptionForHR(MBq0Ds0ICH().QueryAppIsDefaultAll(assocLevel, appRegisterName, out var pfDefault));
		return pfDefault;
	}

	public static void SetAppAsDefault(string appRegisterName, string extOrProto, AssociationType assocType, string progId)
	{
		if (Trd0otNslf())
		{
			Marshal.ThrowExceptionForHR(MBq0Ds0ICH().SetAppAsDefault(appRegisterName, extOrProto, assocType));
			return;
		}
		using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + extOrProto);
		registryKey.SetValue("ProgID", progId);
	}

	public static void SetAppAsDefaultAll(string appRegisterName)
	{
		if (!Trd0otNslf())
		{
			throw new NotSupportedException();
		}
		Marshal.ThrowExceptionForHR(MBq0Ds0ICH().SetAppAsDefaultAll(appRegisterName));
	}

	public static void ClearUserAssociations()
	{
		if (!Trd0otNslf())
		{
			throw new NotSupportedException();
		}
		Marshal.ThrowExceptionForHR(MBq0Ds0ICH().ClearUserAssociations());
	}

	public static void ShowAssociationRegistrationUI(string appRegisterName)
	{
		if (!Trd0otNslf())
		{
			throw new NotSupportedException();
		}
		IApplicationAssociationRegistrationUI applicationAssociationRegistrationUI = null;
		try
		{
			applicationAssociationRegistrationUI = (IApplicationAssociationRegistrationUI)new ApplicationAssociationRegistrationUI();
			Marshal.ThrowExceptionForHR(applicationAssociationRegistrationUI.LaunchAdvancedAssociationUI(appRegisterName));
		}
		finally
		{
			if (applicationAssociationRegistrationUI != null)
			{
				Marshal.ReleaseComObject(applicationAssociationRegistrationUI);
			}
		}
	}

	public static void RegisterApplication(string appName, string company, string description)
	{
		string text = (string.IsNullOrWhiteSpace(company) ? appName : (company + "\\" + appName));
		string text2 = string.Concat("Software\\" + text, "\\Capabilities");
		using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(text2))
		{
			registryKey.SetValue("ApplicationName", appName);
			registryKey.SetValue("ApplicationDescription", description);
		}
		using RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\RegisteredApplications");
		registryKey2.SetValue(appName, text2);
	}

	public static bool IsApplicationRegistered(string appName, string company, string description)
	{
		string text = (string.IsNullOrWhiteSpace(company) ? appName : (company + "\\" + appName));
		string text2 = string.Concat("Software\\" + text, "\\Capabilities");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text2);
		if (registryKey == null)
		{
			return false;
		}
		bool flag = true;
		using (registryKey)
		{
			flag = (flag &= registryKey.GetValue("ApplicationName") as string == appName) & (registryKey.GetValue("ApplicationDescription") as string == description);
		}
		if (!flag)
		{
			return false;
		}
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\RegisteredApplications");
		if (registryKey2 == null)
		{
			return false;
		}
		using (registryKey2)
		{
			return flag & (registryKey2.GetValue(appName) as string == text2);
		}
	}

	public static void RegisterFileAssociationCapability(string appName, string company, string appRegisterName, string extension, string description, string verb)
	{
		string text = ((!string.IsNullOrWhiteSpace(company)) ? (company + "\\" + appName) : appName);
		string text2 = string.Concat("Software\\" + text, "\\Capabilities");
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(text2 + "\\FileAssociations");
		registryKey.SetValue(extension, appRegisterName);
	}

	public static bool IsFileAssociationCapabilityRegistered(string appName, string company, string appRegisterName, string extension, string description, string verb)
	{
		string text = (string.IsNullOrWhiteSpace(company) ? appName : (company + "\\" + appName));
		string text2 = string.Concat("Software\\" + text, "\\Capabilities");
		RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(text2 + "\\FileAssociations");
		if (registryKey == null)
		{
			return false;
		}
		using (registryKey)
		{
			return registryKey.GetValue(extension) as string == appRegisterName;
		}
	}

	public static void RegisterUrlAssociationCapability(string appName, string company, string appRegisterName, string protocol, string description, string verb)
	{
		string text = (string.IsNullOrWhiteSpace(company) ? appName : (company + "\\" + appName));
		string text2 = string.Concat("Software\\" + text, "\\Capabilities");
		using RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(text2 + "\\URLAssociations");
		registryKey.SetValue(protocol, appRegisterName);
	}

	public static void RegisterProgId(string appName, string progId, string description, string verb)
	{
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(progId);
		registryKey.SetValue(null, description);
		using (RegistryKey registryKey2 = registryKey.CreateSubKey("shell\\open\\command"))
		{
			registryKey2.SetValue(null, verb);
		}
		using RegistryKey registryKey3 = registryKey.CreateSubKey("shell\\" + appName + "\\command");
		registryKey3.SetValue(null, verb);
	}

	public static bool IsProgIdRegistered(string appName, string progId, string description, string verb)
	{
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(progId);
		registryKey.SetValue(null, description);
		RegistryKey registryKey2 = registryKey.OpenSubKey("shell\\open\\command");
		if (registryKey2 == null)
		{
			return false;
		}
		bool flag = true;
		using (registryKey2)
		{
			flag &= registryKey2.GetValue(null) as string == verb;
		}
		RegistryKey registryKey3 = registryKey.OpenSubKey("shell\\" + appName + "\\command");
		int num = 0;
		if (!mgAeJ2EbkSGpOZZuLom())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			using (registryKey3)
			{
				flag &= registryKey3.GetValue(null) as string == verb;
			}
			return flag;
		}
	}

	public static void RegisterProgIdToCurrentUser(string appName, string progId, string description, string verb)
	{
		using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Classes\\" + progId);
		registryKey.SetValue(null, description);
		using (RegistryKey registryKey2 = registryKey.CreateSubKey("shell\\open\\command"))
		{
			registryKey2.SetValue(null, verb);
		}
		using RegistryKey registryKey3 = registryKey.CreateSubKey("shell\\" + appName + "\\command");
		registryKey3.SetValue(null, verb);
	}

	public static bool IsProgIdToCurrentUserRegistered(string appName, string progId, string description, string verb)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Classes\\" + progId);
		if (registryKey == null)
		{
			return false;
		}
		using (registryKey)
		{
			bool flag = true;
			flag = registryKey.GetValue(null) as string == description;
			RegistryKey registryKey2 = registryKey.CreateSubKey("shell\\open\\command");
			if (registryKey2 == null)
			{
				return false;
			}
			using (registryKey2)
			{
				flag &= registryKey2.GetValue(null) as string == verb;
			}
			RegistryKey registryKey3 = registryKey.CreateSubKey("shell\\" + appName + "\\command");
			if (registryKey3 == null)
			{
				return false;
			}
			using (registryKey3)
			{
				flag &= registryKey3.GetValue(null) as string == verb;
			}
			return flag;
		}
	}

	static ApplicationAssociation()
	{
		yFa0ALwxFV = new Guid("a07034fd-6caa-4954-ac3f-97a27216f98a");
		vt10OljhF8 = new Guid("c46ca590-3c3f-11d2-bee6-0000f805ca57");
	}

	internal static bool mgAeJ2EbkSGpOZZuLom()
	{
		return RvEx6DEfS8QJmq7HIjf == null;
	}
}
