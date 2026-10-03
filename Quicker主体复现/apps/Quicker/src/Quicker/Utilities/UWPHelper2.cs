using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Quicker.Utilities.Win32;

namespace Quicker.Utilities;

public class UWPHelper2
{
	public class AppModuleItem
	{
		[CompilerGenerated]
		private string UAY2gokNXBd;

		[CompilerGenerated]
		private string qFV2gTFyxKe;

		[CompilerGenerated]
		private string p1l2gMw895U;

		[CompilerGenerated]
		private string qQj2gAuVb1B;

		[CompilerGenerated]
		private string FVt2gOgvTcG;

		[CompilerGenerated]
		private string jOZ2gFmV3XE;

		internal static AppModuleItem pl00KjyDg0F8bj6QQfc1;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return UAY2gokNXBd;
			}
			[CompilerGenerated]
			set
			{
				UAY2gokNXBd = value;
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return qFV2gTFyxKe;
			}
			[CompilerGenerated]
			set
			{
				qFV2gTFyxKe = value;
			}
		}

		public string PackageId
		{
			[CompilerGenerated]
			get
			{
				return p1l2gMw895U;
			}
			[CompilerGenerated]
			set
			{
				p1l2gMw895U = value;
			}
		}

		public string IconPath
		{
			[CompilerGenerated]
			get
			{
				return qQj2gAuVb1B;
			}
			[CompilerGenerated]
			set
			{
				qQj2gAuVb1B = value;
			}
		}

		public string BackgroundColor
		{
			[CompilerGenerated]
			get
			{
				return FVt2gOgvTcG;
			}
			[CompilerGenerated]
			set
			{
				FVt2gOgvTcG = value;
			}
		}

		public string ApplicationUserModelId
		{
			[CompilerGenerated]
			get
			{
				return jOZ2gFmV3XE;
			}
			[CompilerGenerated]
			set
			{
				jOZ2gFmV3XE = value;
			}
		}

		internal static bool Ma4O07yDPlivoXjvxyeT()
		{
			return pl00KjyDg0F8bj6QQfc1 == null;
		}
	}

	internal sealed class p5b0SKDYLf0KSYbqNSo
	{
		[CompilerGenerated]
		private string Mll2L0L3aWI;

		[CompilerGenerated]
		private string AIK2LCr8MmB;

		[CompilerGenerated]
		private string iYD2LPaOxK4;

		[CompilerGenerated]
		private string lr32LEBPR4u;

		[CompilerGenerated]
		private string bmQ2LyYw9eC;

		[CompilerGenerated]
		private Dictionary<string, string> efx2L8doCG0;

		private static p5b0SKDYLf0KSYbqNSo rjLNGAyDUe10rvvtx33m;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return AIK2LCr8MmB;
			}
			[CompilerGenerated]
			set
			{
				AIK2LCr8MmB = value;
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return iYD2LPaOxK4;
			}
			[CompilerGenerated]
			set
			{
				iYD2LPaOxK4 = value;
			}
		}

		public p5b0SKDYLf0KSYbqNSo()
		{
			MR72LNBrNc4(new Dictionary<string, string>());
		}

		[SpecialName]
		[CompilerGenerated]
		public string gLA2gUZs8KE()
		{
			return Mll2L0L3aWI;
		}

		[SpecialName]
		[CompilerGenerated]
		public void v2l2gliFtsE(string string_5)
		{
			Mll2L0L3aWI = string_5;
		}

		[SpecialName]
		[CompilerGenerated]
		public string zbL2LtoVwNr()
		{
			return lr32LEBPR4u;
		}

		[SpecialName]
		[CompilerGenerated]
		public void QnO2Lg8uF23(string string_5)
		{
			lr32LEBPR4u = string_5;
		}

		[SpecialName]
		[CompilerGenerated]
		public string kQk2LvFyLEb()
		{
			return bmQ2LyYw9eC;
		}

		[SpecialName]
		[CompilerGenerated]
		public void kuC2LSkPr8J(string string_5)
		{
			bmQ2LyYw9eC = string_5;
		}

		[SpecialName]
		[CompilerGenerated]
		public Dictionary<string, string> m8v2Luq8exr()
		{
			return efx2L8doCG0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void MR72LNBrNc4(Dictionary<string, string> dictionary_1)
		{
			efx2L8doCG0 = dictionary_1;
		}

		internal static bool SC8ayjyDxmXXm2XuqLxF()
		{
			return rjLNGAyDUe10rvvtx33m == null;
		}
	}

	public class ProtocalObject
	{
		[CompilerGenerated]
		private string UCJ2Lada8B4;

		[CompilerGenerated]
		private string zFj2L7xNodZ;

		[CompilerGenerated]
		private string m622LR2I5Wt;

		[CompilerGenerated]
		private string Bwv2LqdgKrS;

		[CompilerGenerated]
		private string LmY2LcIo4U8;

		[CompilerGenerated]
		private string GHO2LViZO8A;

		private static ProtocalObject d44059yD6cw0x8iMMQl3;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return UCJ2Lada8B4;
			}
			[CompilerGenerated]
			set
			{
				UCJ2Lada8B4 = value;
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return zFj2L7xNodZ;
			}
			[CompilerGenerated]
			set
			{
				zFj2L7xNodZ = value;
			}
		}

		public string Icon
		{
			[CompilerGenerated]
			get
			{
				return m622LR2I5Wt;
			}
			[CompilerGenerated]
			set
			{
				m622LR2I5Wt = value;
			}
		}

		public string PackageId
		{
			[CompilerGenerated]
			get
			{
				return Bwv2LqdgKrS;
			}
			[CompilerGenerated]
			set
			{
				Bwv2LqdgKrS = value;
			}
		}

		public string ClassId
		{
			[CompilerGenerated]
			get
			{
				return LmY2LcIo4U8;
			}
			[CompilerGenerated]
			set
			{
				LmY2LcIo4U8 = value;
			}
		}

		public string Protocol
		{
			[CompilerGenerated]
			get
			{
				return GHO2LViZO8A;
			}
			[CompilerGenerated]
			set
			{
				GHO2LViZO8A = value;
			}
		}

		internal static bool TBndnIyDtHyeh17CcYCR()
		{
			return d44059yD6cw0x8iMMQl3 == null;
		}
	}

	[ComImport]
	[Guid("45BA127D-10A8-46EA-8AB7-56EA9078943C")]
	private class ApplicationActivationManager
	{
	}

	private enum SNsMIODM54kFIriBhmD
	{
		None
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2e941141-7f97-4756-ba1d-9decde894a3d")]
	private interface IApplicationActivationManager
	{
		int ActivateApplication([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, [MarshalAs(UnmanagedType.LPWStr)] string arguments, SNsMIODM54kFIriBhmD options, out uint processId);

		int ActivateForFile([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, IntPtr pShelItemArray, [MarshalAs(UnmanagedType.LPWStr)] string verb, out uint processId);

		int ActivateForProtocol([MarshalAs(UnmanagedType.LPWStr)] string appUserModelId, IntPtr pShelItemArray, [MarshalAs(UnmanagedType.LPWStr)] string verb, out uint processId);
	}

	public sealed class AppxPackage
	{
		[ComImport]
		[Guid("5842a140-ff9f-4166-8f5c-62f5b7b0c781")]
		private class AppxFactory
		{
		}

		[Guid("BEB94909-E451-438B-B5A7-D79E767B75D8")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface dNCqRskzlsUE1lf6gAK
		{
			void _VtblGap0_2();

			M4PVuuhlGXPoemaD75v lVSMtdZNy5C(IStream istream_0);
		}

		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[Guid("4E1BD148-55A0-4480-A3D1-15544710637C")]
		private interface M4PVuuhlGXPoemaD75v
		{
			void _VtblGap0_1();

			UYD3VKhAqTagJ5BpdSG e3aMt0p4B6e();

			void _VtblGap1_5();

			fbmAxMhqx07gXRrZNv9 vMhMtD7aCAh();
		}

		[Guid("9EB8A55A-F04B-4D0D-808D-686185D4847A")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface fbmAxMhqx07gXRrZNv9
		{
			BylT5Mh5RHcLXQ3GA5P n8UMtmHIOHu();

			bool S2pMt5B4wZ6();

			bool MoveNext();
		}

		[Guid("5DA89BF4-3773-46BE-B650-7E744863B7E8")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		internal interface BylT5Mh5RHcLXQ3GA5P
		{
			[PreserveSig]
			int qcyMtaTSkA7([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] out string string_1);
		}

		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[Guid("03FAF64D-F26F-4B2C-AAF7-8FE7789B8BCA")]
		private interface UYD3VKhAqTagJ5BpdSG
		{
			[PreserveSig]
			int GetBoolValue([MarshalAs(UnmanagedType.LPWStr)] string name, out bool value);

			[PreserveSig]
			int qcyMtaTSkA7([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] out string string_1);
		}

		[Flags]
		public enum PackageConstants
		{
			PACKAGE_FILTER_ALL_LOADED = 0,
			PACKAGE_PROPERTY_FRAMEWORK = 1,
			PACKAGE_PROPERTY_RESOURCE = 2,
			PACKAGE_PROPERTY_BUNDLE = 4,
			PACKAGE_FILTER_HEAD = 0x10,
			PACKAGE_FILTER_DIRECT = 0x20,
			PACKAGE_FILTER_RESOURCE = 0x40,
			PACKAGE_FILTER_BUNDLE = 0x80,
			PACKAGE_INFORMATION_BASIC = 0,
			PACKAGE_INFORMATION_FULL = 0x100,
			PACKAGE_PROPERTY_DEVELOPMENT_MODE = 0x10000
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct LUlaRThwYpQ98tiJtCw
		{
			public readonly int gWt2ZFP7jft;

			public readonly int zxe2ZUJry7H;

			public readonly IntPtr Pgp2ZlWQIFJ;

			public readonly IntPtr bTs2ZiviRkv;

			public readonly IntPtr qfu2Z3SXoNp;

			public readonly UkAfIfhWLJY8ORsVsnv GFh2Zf9iFWT;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		private struct UkAfIfhWLJY8ORsVsnv
		{
			public readonly int HMC2ZzqCJb1;

			public readonly AppxPackageArchitecture nXt29wIl3M4;

			public readonly ushort NDK29tQxLyH;

			public readonly ushort eVH29goQTed;

			public readonly ushort MLP29LQsTP7;

			public readonly ushort lXp29vYlm9Q;

			public readonly IntPtr Vlv29SB2XX4;

			public readonly IntPtr U2Y292ZrM31;

			public readonly IntPtr dek29uSu2Ic;

			public readonly IntPtr ymt29NGwsau;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec YKq29yJ7kQ7;

			public static Func<FileInfo, bool> YK5298lfh5I;

			public static Func<FileInfo, bool> Luf29aoJBu9;

			public static Func<FileInfo, bool> TG8297YXlSo;

			public static Func<FileInfo, long> L1N29RIBNLM;

			public static Func<FileInfo, long> edS29qayLol;

			private static _003C_003Ec Jg6B6IyiBLhdAPRncQLd;

			static _003C_003Ec()
			{
				YKq29yJ7kQ7 = new _003C_003Ec();
			}

			internal bool jBV29JFR7sD(FileInfo x)
			{
				return x.Name.ToUpperInvariant().Contains("BLACK");
			}

			internal bool c85290poeG2(FileInfo x)
			{
				return x.Name.ToUpperInvariant().Contains("BLACK");
			}

			internal bool sFt29C9orDh(FileInfo x)
			{
				return x.Length < 1500L;
			}

			internal long YMf29POKvj3(FileInfo x)
			{
				return x.Length;
			}

			internal long yfU29EQWrcI(FileInfo x)
			{
				return x.Length;
			}

			internal static bool W2V2Ffyivae3dTme4aFm()
			{
				return Jg6B6IyiBLhdAPRncQLd == null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CQueryPackageInfo_003Ed__73 : IDisposable, IEnumerable, IEnumerator, IEnumerable<AppxPackage>, IEnumerator<AppxPackage>
		{
			private int _003C_003E1__state;

			private AppxPackage _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string fullName;

			public string _003C_003E3__fullName;

			private PackageConstants flags;

			public PackageConstants _003C_003E3__flags;

			private IntPtr _003CinfoRef_003E5__2;

			private IntPtr _003CinfoBuffer_003E5__3;

			private int _003Ccount_003E5__4;

			private dNCqRskzlsUE1lf6gAK _003Cfactory_003E5__5;

			private int _003Ci_003E5__6;

			internal static _003CQueryPackageInfo_003Ed__73 zZyyd3yiOKLadZ0ux2kD;

			AppxPackage IEnumerator<AppxPackage>.Current
			{
				[DebuggerHidden]
				get
				{
					return _003C_003E2__current;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return _003C_003E2__current;
				}
			}

			[DebuggerHidden]
			public _003CQueryPackageInfo_003Ed__73(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
				_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = _003C_003E1__state;
				if (num == -3 || num == 1)
				{
					try
					{
					}
					finally
					{
						_003C_003Em__Finally1();
					}
				}
				_003Cfactory_003E5__5 = null;
				_003C_003E1__state = -2;
			}

			private bool MoveNext()
			{
				bool result = default(bool);
				try
				{
        AppxPackage appxPackage = default;
        BylT5Mh5RHcLXQ3GA5P bylT5Mh5RHcLXQ3GA5P = default;
        IStream istream_ = default;
        AppxApp appxApp = default;
        fbmAxMhqx07gXRrZNv9 fbmAxMhqx07gXRrZNv = default;
        int int_ = default;
					int num = _003C_003E1__state;
					int num2;
					if (num == 0)
					{
						_003C_003E1__state = -1;
						tVA2LkICR2P(fullName, 0, out _003CinfoRef_003E5__2);
						if (_003CinfoRef_003E5__2 != IntPtr.Zero)
						{
							_003CinfoBuffer_003E5__3 = IntPtr.Zero;
							num2 = 0;
							if (zZyyd3yiOKLadZ0ux2kD != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							goto IL_04a0;
						}
						goto IL_0505;
					}
					if (num == 1)
					{
						_003C_003E1__state = -3;
						_003Ci_003E5__6++;
						goto IL_031f;
					}
					result = false;
					num2 = 1;
					if (!W6IhTnyiJNnNUSJyyaU5())
					{
						goto IL_04a0;
					}
					goto end_IL_0001;
					IL_04e9:
					_003C_003Em__Finally1();
					goto IL_0505;
					IL_009c:
					appxPackage = default(AppxPackage);
					LUlaRThwYpQ98tiJtCw lUlaRThwYpQ98tiJtCw = default(LUlaRThwYpQ98tiJtCw);
					appxPackage.ResourceId = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.dek29uSu2Ic);
					appxPackage.ProcessorArchitecture = lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.nXt29wIl3M4;
					appxPackage.Version = new Version(lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.lXp29vYlm9Q, lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.MLP29LQsTP7, lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.eVH29goQTed, lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.NDK29tQxLyH);
					istream_ = default(IStream);
					Lmp2LeEQNdj(System.IO.Path.Combine(appxPackage.Path, "AppXManifest.xml"), 64, 0, false, IntPtr.Zero, out istream_);
					fbmAxMhqx07gXRrZNv = default(fbmAxMhqx07gXRrZNv9);
					if (istream_ != null)
					{
						M4PVuuhlGXPoemaD75v m4PVuuhlGXPoemaD75v = _003Cfactory_003E5__5.lVSMtdZNy5C(istream_);
						appxPackage.J0j2Lo6lfoD = m4PVuuhlGXPoemaD75v.e3aMt0p4B6e();
						appxPackage.Description = appxPackage.GetPropertyStringValue("Description");
						appxPackage.DisplayName = appxPackage.GetPropertyStringValue("DisplayName");
						appxPackage.Logo = appxPackage.GetPropertyStringValue("Logo");
						appxPackage.PublisherDisplayName = appxPackage.GetPropertyStringValue("PublisherDisplayName");
						appxPackage.IsFramework = appxPackage.GetPropertyBoolValue("Framework");
						fbmAxMhqx07gXRrZNv = m4PVuuhlGXPoemaD75v.vMhMtD7aCAh();
						goto IL_01b1;
					}
					goto IL_04f1;
					IL_01bd:
					bylT5Mh5RHcLXQ3GA5P = fbmAxMhqx07gXRrZNv.n8UMtmHIOHu();
					appxApp = new AppxApp(bylT5Mh5RHcLXQ3GA5P)
					{
						Description = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Description"),
						DisplayName = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "DisplayName"),
						EntryPoint = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "EntryPoint"),
						Executable = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Executable")
					};
					goto IL_021b;
					IL_04f1:
					_003C_003E2__current = appxPackage;
					_003C_003E1__state = 1;
					result = true;
					goto end_IL_0001;
					IL_021b:
					appxApp.Id = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Id");
					appxApp.Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Logo");
					appxApp.SmallLogo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "SmallLogo");
					appxApp.StartPage = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "StartPage");
					appxApp.Square150x150Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Square150x150Logo");
					appxApp.Square30x30Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Square30x30Logo");
					appxApp.Square44x44Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Square44x44Logo");
					appxApp.BackgroundColor = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "BackgroundColor");
					appxApp.ForegroundText = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "ForegroundText");
					num2 = 3;
					if (!W6IhTnyiJNnNUSJyyaU5())
					{
						goto IL_03dc;
					}
					goto IL_04a0;
					IL_0505:
					result = false;
					goto end_IL_0001;
					IL_04a0:
					switch (num2)
					{
					case 7:
						break;
					case 6:
						goto IL_01bd;
					case 2:
						goto IL_021b;
					case 5:
						goto IL_02eb;
					case 4:
						goto IL_02f8;
					default:
						goto IL_03dc;
					case 3:
						goto IL_0413;
					case 1:
						goto end_IL_0001;
					}
					goto IL_009c;
					IL_0413:
					appxApp.WideLogo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "WideLogo");
					appxApp.Wide310x310Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Wide310x310Logo");
					appxApp.ShortName = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "ShortName");
					appxApp.Square310x310Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Square310x310Logo");
					appxApp.Square70x70Logo = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "Square70x70Logo");
					appxApp.MinWidth = Rda2L9x1Rx9(bylT5Mh5RHcLXQ3GA5P, "MinWidth");
					appxPackage.U0T2LdW5FTj.Add(appxApp);
					fbmAxMhqx07gXRrZNv.MoveNext();
					goto IL_01b1;
					IL_03dc:
					_003C_003E1__state = -3;
					int_ = 0;
					DMG2LGP4DGa(_003CinfoRef_003E5__2, flags, ref int_, IntPtr.Zero, out _003Ccount_003E5__4);
					if (int_ > 0)
					{
						_003Cfactory_003E5__5 = (dNCqRskzlsUE1lf6gAK)new AppxFactory();
						goto IL_02eb;
					}
					goto IL_04e9;
					IL_01b1:
					if (fbmAxMhqx07gXRrZNv.S2pMt5B4wZ6())
					{
						goto IL_01bd;
					}
					Marshal.ReleaseComObject(istream_);
					goto IL_04f1;
					IL_02eb:
					_003CinfoBuffer_003E5__3 = Marshal.AllocHGlobal(int_);
					goto IL_02f8;
					IL_02f8:
					DMG2LGP4DGa(_003CinfoRef_003E5__2, flags, ref int_, _003CinfoBuffer_003E5__3, out _003Ccount_003E5__4);
					_003Ci_003E5__6 = 0;
					goto IL_031f;
					IL_031f:
					if (_003Ci_003E5__6 < _003Ccount_003E5__4)
					{
						lUlaRThwYpQ98tiJtCw = (LUlaRThwYpQ98tiJtCw)Marshal.PtrToStructure(_003CinfoBuffer_003E5__3 + _003Ci_003E5__6 * Marshal.SizeOf(typeof(LUlaRThwYpQ98tiJtCw)), typeof(LUlaRThwYpQ98tiJtCw));
						appxPackage = new AppxPackage
						{
							FamilyName = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.qfu2Z3SXoNp),
							FullName = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.bTs2ZiviRkv),
							Path = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.Pgp2ZlWQIFJ),
							Publisher = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.U2Y292ZrM31),
							PublisherId = Marshal.PtrToStringUni(lUlaRThwYpQ98tiJtCw.GFh2Zf9iFWT.ymt29NGwsau)
						};
						goto IL_009c;
					}
					Marshal.ReleaseComObject(_003Cfactory_003E5__5);
					_003Cfactory_003E5__5 = null;
					goto IL_04e9;
					end_IL_0001:;
				}
				catch
				{
					//try-fault
					((IDisposable)this).Dispose();
					throw;
				}
				return result;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
				_003C_003E1__state = -1;
				if (_003CinfoBuffer_003E5__3 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(_003CinfoBuffer_003E5__3);
				}
				tHS2LsxCtqk(_003CinfoRef_003E5__2);
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			IEnumerator<AppxPackage> IEnumerable<AppxPackage>.GetEnumerator()
			{
				_003CQueryPackageInfo_003Ed__73 _003CQueryPackageInfo_003Ed__;
				if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
				{
					_003C_003E1__state = 0;
					_003CQueryPackageInfo_003Ed__ = this;
				}
				else
				{
					_003CQueryPackageInfo_003Ed__ = new _003CQueryPackageInfo_003Ed__73(0);
				}
				_003CQueryPackageInfo_003Ed__.fullName = _003C_003E3__fullName;
				_003CQueryPackageInfo_003Ed__.flags = _003C_003E3__flags;
				return _003CQueryPackageInfo_003Ed__;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<AppxPackage>)this).GetEnumerator();
			}

			internal static bool W6IhTnyiJNnNUSJyyaU5()
			{
				return zZyyd3yiOKLadZ0ux2kD == null;
			}
		}

		private readonly List<AppxApp> U0T2LdW5FTj = new List<AppxApp>();

		private UYD3VKhAqTagJ5BpdSG J0j2Lo6lfoD;

		[CompilerGenerated]
		private string tgv2LTJP2Q4;

		[CompilerGenerated]
		private string s4Q2LMyqHev;

		[CompilerGenerated]
		private string CGq2LAoskpF;

		[CompilerGenerated]
		private string XYg2LOeTAmq;

		[CompilerGenerated]
		private string ORC2LFIpu55;

		[CompilerGenerated]
		private string OR92LUGOaT5;

		[CompilerGenerated]
		private string QGP2LlGWhdG;

		[CompilerGenerated]
		private string top2LinFYiA;

		[CompilerGenerated]
		private string e1y2L3gJAZT;

		[CompilerGenerated]
		private string G0D2LfTEwOX;

		[CompilerGenerated]
		private string mTa2Lz0Kw1X;

		[CompilerGenerated]
		private bool IcQ2vwdjsek;

		[CompilerGenerated]
		private Version IFf2vtasTvu;

		[CompilerGenerated]
		private AppxPackageArchitecture lqL2vgdDcxJ;

		private static AppxPackage MlqSAyyDzcU2KYgvv5LI;

		public string FullName
		{
			[CompilerGenerated]
			get
			{
				return tgv2LTJP2Q4;
			}
			[CompilerGenerated]
			private set
			{
				tgv2LTJP2Q4 = value;
			}
		}

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return s4Q2LMyqHev;
			}
			[CompilerGenerated]
			private set
			{
				s4Q2LMyqHev = value;
			}
		}

		public string Publisher
		{
			[CompilerGenerated]
			get
			{
				return CGq2LAoskpF;
			}
			[CompilerGenerated]
			private set
			{
				CGq2LAoskpF = value;
			}
		}

		public string PublisherId
		{
			[CompilerGenerated]
			get
			{
				return XYg2LOeTAmq;
			}
			[CompilerGenerated]
			private set
			{
				XYg2LOeTAmq = value;
			}
		}

		public string ResourceId
		{
			[CompilerGenerated]
			get
			{
				return ORC2LFIpu55;
			}
			[CompilerGenerated]
			private set
			{
				ORC2LFIpu55 = value;
			}
		}

		public string FamilyName
		{
			[CompilerGenerated]
			get
			{
				return OR92LUGOaT5;
			}
			[CompilerGenerated]
			private set
			{
				OR92LUGOaT5 = value;
			}
		}

		public string ApplicationUserModelId
		{
			[CompilerGenerated]
			get
			{
				return QGP2LlGWhdG;
			}
			[CompilerGenerated]
			private set
			{
				QGP2LlGWhdG = value;
			}
		}

		public string Logo
		{
			[CompilerGenerated]
			get
			{
				return top2LinFYiA;
			}
			[CompilerGenerated]
			private set
			{
				top2LinFYiA = value;
			}
		}

		public string PublisherDisplayName
		{
			[CompilerGenerated]
			get
			{
				return e1y2L3gJAZT;
			}
			[CompilerGenerated]
			private set
			{
				e1y2L3gJAZT = value;
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return G0D2LfTEwOX;
			}
			[CompilerGenerated]
			private set
			{
				G0D2LfTEwOX = value;
			}
		}

		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return mTa2Lz0Kw1X;
			}
			[CompilerGenerated]
			private set
			{
				mTa2Lz0Kw1X = value;
			}
		}

		public bool IsFramework
		{
			[CompilerGenerated]
			get
			{
				return IcQ2vwdjsek;
			}
			[CompilerGenerated]
			private set
			{
				IcQ2vwdjsek = value;
			}
		}

		public Version Version
		{
			[CompilerGenerated]
			get
			{
				return IFf2vtasTvu;
			}
			[CompilerGenerated]
			private set
			{
				IFf2vtasTvu = value;
			}
		}

		public AppxPackageArchitecture ProcessorArchitecture
		{
			[CompilerGenerated]
			get
			{
				return lqL2vgdDcxJ;
			}
			[CompilerGenerated]
			private set
			{
				lqL2vgdDcxJ = value;
			}
		}

		public IReadOnlyList<AppxApp> Apps => U0T2LdW5FTj;

		public IEnumerable<AppxPackage> DependencyGraph => QueryPackageInfo(FullName, PackageConstants.PACKAGE_FILTER_ALL_LOADED).Where(VOZ2Lb5u7oU);

		private AppxPackage()
		{
		}

		public string FindHighestScaleQualifiedImagePath(string resourceName)
		{
			string result2;
			try
			{
				if (resourceName == null)
				{
					throw new ArgumentNullException("resourceName");
				}
				List<int> list = new List<int>();
				string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(resourceName);
				string extension = System.IO.Path.GetExtension(resourceName);
				foreach (string item in Directory.EnumerateFiles(System.IO.Path.Combine(Path, System.IO.Path.GetDirectoryName(resourceName)), fileNameWithoutExtension + ".scale-*" + extension))
				{
					string fileNameWithoutExtension2 = System.IO.Path.GetFileNameWithoutExtension(item);
					int startIndex = fileNameWithoutExtension2.IndexOf(".scale-", StringComparison.OrdinalIgnoreCase) + ".scale-".Length;
					if (int.TryParse(fileNameWithoutExtension2.Substring(startIndex), out var result))
					{
						list.Add(result);
					}
				}
				if (list.Count == 0)
				{
					result2 = null;
				}
				else
				{
					list.Sort();
					result2 = System.IO.Path.Combine(Path, System.IO.Path.GetDirectoryName(resourceName), fileNameWithoutExtension + ".scale-" + list.Last() + extension);
					int num = 0;
					if (!A28VoGy3VRutmuRuJLup())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
			catch (Exception)
			{
				result2 = "";
			}
			return result2;
		}

		public string FindListImagePath(string resourceName)
		{
			string result = default(string);
			try
			{
				if (string.IsNullOrEmpty(resourceName))
				{
					throw new ArgumentNullException("resourceName");
				}
				Path.Contains("WindowsCalculator");
				string text = System.IO.Path.Combine(Path, resourceName);
				int num = 0;
				if (!A28VoGy3VRutmuRuJLup())
				{
					goto IL_008d;
				}
				goto IL_0091;
				IL_0091:
				while (true)
				{
					switch (num)
					{
					default:
						if (!File.Exists(text))
						{
							new List<int>();
							string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(resourceName);
							string extension = System.IO.Path.GetExtension(resourceName);
							string path = System.IO.Path.Combine(Path, System.IO.Path.GetDirectoryName(resourceName));
							if (!Directory.Exists(path))
							{
								result = null;
								num = 1;
								if (A28VoGy3VRutmuRuJLup())
								{
									continue;
								}
								goto IL_008d;
							}
							FileInfo[] files = new DirectoryInfo(path).GetFiles(fileNameWithoutExtension + "*" + extension, SearchOption.AllDirectories);
							if (!files.Any())
							{
								result = null;
								break;
							}
							IEnumerable<FileInfo> source = ((!files.Any(_003C_003Ec.YK5298lfh5I ?? (_003C_003Ec.YK5298lfh5I = _003C_003Ec.YKq29yJ7kQ7.jBV29JFR7sD))) ? files : files.Where(_003C_003Ec.Luf29aoJBu9 ?? (_003C_003Ec.Luf29aoJBu9 = _003C_003Ec.YKq29yJ7kQ7.c85290poeG2)));
							result = ((!source.Any(_003C_003Ec.TG8297YXlSo ?? (_003C_003Ec.TG8297YXlSo = _003C_003Ec.YKq29yJ7kQ7.sFt29C9orDh))) ? source.OrderBy(_003C_003Ec.edS29qayLol ?? (_003C_003Ec.edS29qayLol = _003C_003Ec.YKq29yJ7kQ7.yfU29EQWrcI)).First().FullName : source.OrderByDescending(_003C_003Ec.L1N29RIBNLM ?? (_003C_003Ec.L1N29RIBNLM = _003C_003Ec.YKq29yJ7kQ7.YMf29POKvj3)).First().FullName);
							break;
						}
						result = text;
						break;
					case 1:
						break;
					}
					break;
				}
				goto end_IL_0001;
				IL_008d:
				int num2 = default(int);
				num = num2;
				goto IL_0091;
				end_IL_0001:;
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		public override string ToString()
		{
			return FullName;
		}

		public static AppxPackage FromWindow(IntPtr handle)
		{
			Cj82LYMoHkS(handle, out var int_);
			if (int_ == 0)
			{
				return null;
			}
			return FromProcess(int_);
		}

		public static AppxPackage FromProcess(Process process)
		{
			if (process == null)
			{
				process = Process.GetCurrentProcess();
			}
			try
			{
				return FromProcess(process.Handle);
			}
			catch
			{
				return null;
			}
		}

		public static AppxPackage FromProcess(int processId)
		{
			IntPtr intPtr = IY32LIHT9Ff(4096, false, processId);
			try
			{
				return FromProcess(intPtr);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					NBo2LWnVVjT(intPtr);
				}
			}
		}

		public static AppxPackage FromProcess(IntPtr hProcess)
		{
			if (hProcess == IntPtr.Zero)
			{
				return null;
			}
			int int_ = 0;
			if (A28VoGy3VRutmuRuJLup())
			{
				switch (0)
				{
				}
			}
			qIY2LHSrX32(hProcess, ref int_, null);
			if (int_ == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(int_);
			string text = ((qIY2LHSrX32(hProcess, ref int_, stringBuilder) == 0) ? stringBuilder.ToString() : null);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			AppxPackage appxPackage = QueryPackageInfo(text, PackageConstants.PACKAGE_FILTER_HEAD).First();
			int_ = 0;
			MqB2L19qXUG(hProcess, ref int_, null);
			stringBuilder = new StringBuilder(int_);
			appxPackage.ApplicationUserModelId = ((MqB2L19qXUG(hProcess, ref int_, stringBuilder) == 0) ? stringBuilder.ToString() : null);
			return appxPackage;
		}

		public string GetPropertyStringValue(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return p882LZtLC9c(J0j2Lo6lfoD, name);
		}

		public bool GetPropertyBoolValue(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return GetBoolValue(J0j2Lo6lfoD, name);
		}

		public string LoadResourceString(string resource)
		{
			return LoadResourceString(FullName, resource);
		}

		[IteratorStateMachine(typeof(_003CQueryPackageInfo_003Ed__73))]
		public static IEnumerable<AppxPackage> QueryPackageInfo(string fullName, PackageConstants flags)
		{
			return new _003CQueryPackageInfo_003Ed__73(-2)
			{
				_003C_003E3__fullName = fullName,
				_003C_003E3__flags = flags
			};
		}

		public static string LoadResourceString(string packageFullName, string resource)
		{
			if (packageFullName == null)
			{
				throw new ArgumentNullException("packageFullName");
			}
			if (string.IsNullOrWhiteSpace(resource))
			{
				return null;
			}
			if (!resource.StartsWith("ms-resource:", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			string text = resource.Substring("ms-resource:".Length);
			bool flag = false;
			string arg;
			if (text.StartsWith("///", StringComparison.OrdinalIgnoreCase))
			{
				arg = resource;
			}
			else
			{
				if (!text.StartsWith("//", StringComparison.OrdinalIgnoreCase))
				{
					goto IL_006b;
				}
				arg = resource;
			}
			goto IL_010d;
			IL_006b:
			if (!text.StartsWith("/", StringComparison.OrdinalIgnoreCase))
			{
				if (text.Contains("/"))
				{
					flag = true;
					arg = resource;
				}
				else
				{
					arg = "ms-resource:///resources/" + text;
				}
			}
			else
			{
				arg = "ms-resource://" + text;
			}
			goto IL_010d;
			IL_010d:
			string string_ = string.Format(CultureInfo.InvariantCulture, "@{{{0}? {1}}}", packageFullName, arg);
			StringBuilder stringBuilder = new StringBuilder(1024);
			if (kNN2Lhj2X3f(string_, stringBuilder, stringBuilder.Capacity, IntPtr.Zero) != 0)
			{
				if (!flag)
				{
					return null;
				}
				arg = "ms-resource:///resources/" + text;
				if (kNN2Lhj2X3f(string.Format(CultureInfo.InvariantCulture, "@{{{0}? {1}}}", packageFullName, arg), stringBuilder, stringBuilder.Capacity, IntPtr.Zero) != 0)
				{
					int num = 0;
					if (MlqSAyyDzcU2KYgvv5LI != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						return null;
					}
					goto IL_006b;
				}
			}
			return stringBuilder.ToString();
		}

		private static string p882LZtLC9c(UYD3VKhAqTagJ5BpdSG uyd3VKhAqTagJ5BpdSG_1, string string_11)
		{
			if (uyd3VKhAqTagJ5BpdSG_1 == null)
			{
				return null;
			}
			uyd3VKhAqTagJ5BpdSG_1.qcyMtaTSkA7(string_11, out var string_12);
			return string_12;
		}

		private static bool GetBoolValue(UYD3VKhAqTagJ5BpdSG props, string name)
		{
			props.GetBoolValue(name, out var value);
			return value;
		}

		internal static string Rda2L9x1Rx9(BylT5Mh5RHcLXQ3GA5P bylT5Mh5RHcLXQ3GA5P_0, string string_11)
		{
			bylT5Mh5RHcLXQ3GA5P_0.qcyMtaTSkA7(string_11, out var string_12);
			return string_12;
		}

		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, EntryPoint = "SHLoadIndirectString")]
		private static extern int kNN2Lhj2X3f(string string_11, StringBuilder stringBuilder_0, int int_0, IntPtr intptr_0);

		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, EntryPoint = "SHCreateStreamOnFileEx")]
		private static extern int Lmp2LeEQNdj(string string_11, int int_0, int int_1, bool bool_1, IntPtr intptr_0, out IStream istream_0);

		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
		private static extern int Cj82LYMoHkS(IntPtr intptr_0, out int int_0);

		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		private static extern IntPtr IY32LIHT9Ff(int int_0, bool bool_1, int int_1);

		[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
		private static extern bool NBo2LWnVVjT(IntPtr intptr_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "OpenPackageInfoByFullName")]
		private static extern int tVA2LkICR2P(string string_11, int int_0, out IntPtr intptr_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetPackageInfo")]
		private static extern int DMG2LGP4DGa(IntPtr intptr_0, PackageConstants packageConstants_0, ref int int_0, IntPtr intptr_1, out int int_1);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "ClosePackageInfo")]
		private static extern int tHS2LsxCtqk(IntPtr intptr_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetPackageFullName")]
		private static extern int qIY2LHSrX32(IntPtr intptr_0, ref int int_0, StringBuilder stringBuilder_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetApplicationUserModelId")]
		private static extern int MqB2L19qXUG(IntPtr intptr_0, ref int int_0, StringBuilder stringBuilder_0);

		[CompilerGenerated]
		private bool VOZ2Lb5u7oU(AppxPackage appxPackage_0)
		{
			return appxPackage_0.FullName != FullName;
		}

		internal static bool A28VoGy3VRutmuRuJLup()
		{
			return MlqSAyyDzcU2KYgvv5LI == null;
		}
	}

	public sealed class AppxApp
	{
		private readonly AppxPackage.BylT5Mh5RHcLXQ3GA5P yr32vZHiKaM;

		[CompilerGenerated]
		private string lVe2v9CLpek;

		[CompilerGenerated]
		private string tqP2vhFAWPb;

		[CompilerGenerated]
		private string g4I2velRYEd;

		[CompilerGenerated]
		private string d1k2vYsm4yk;

		[CompilerGenerated]
		private string Nfx2vI67rU2;

		[CompilerGenerated]
		private string fWX2vWlxtLA;

		[CompilerGenerated]
		private string stU2vkIQX8R;

		[CompilerGenerated]
		private string Win2vGbd3BM;

		[CompilerGenerated]
		private string FS72vsNIPni;

		[CompilerGenerated]
		private string Ix72vHVN5Ys;

		[CompilerGenerated]
		private string H4b2v1vFKmn;

		[CompilerGenerated]
		private string iyh2vbuM3Cx;

		[CompilerGenerated]
		private string UPP2v63iWdK;

		[CompilerGenerated]
		private string LKT2vX5msgj;

		[CompilerGenerated]
		private string lL72vmT4mYl;

		[CompilerGenerated]
		private string o5m2vKnQQEG;

		[CompilerGenerated]
		private string EfG2vxaxVoI;

		[CompilerGenerated]
		private string tVF2vr2dCQc;

		[CompilerGenerated]
		private string UUr2vpAxuNp;

		private static AppxApp KshIvry3yNL6nMkAUvPy;

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return lVe2v9CLpek;
			}
			[CompilerGenerated]
			internal set
			{
				lVe2v9CLpek = value;
			}
		}

		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return tqP2vhFAWPb;
			}
			[CompilerGenerated]
			internal set
			{
				tqP2vhFAWPb = value;
			}
		}

		public string EntryPoint
		{
			[CompilerGenerated]
			get
			{
				return g4I2velRYEd;
			}
			[CompilerGenerated]
			internal set
			{
				g4I2velRYEd = value;
			}
		}

		public string Executable
		{
			[CompilerGenerated]
			get
			{
				return d1k2vYsm4yk;
			}
			[CompilerGenerated]
			internal set
			{
				d1k2vYsm4yk = value;
			}
		}

		public string Id
		{
			[CompilerGenerated]
			get
			{
				return Nfx2vI67rU2;
			}
			[CompilerGenerated]
			internal set
			{
				Nfx2vI67rU2 = value;
			}
		}

		public string Logo
		{
			[CompilerGenerated]
			get
			{
				return fWX2vWlxtLA;
			}
			[CompilerGenerated]
			internal set
			{
				fWX2vWlxtLA = value;
			}
		}

		public string SmallLogo
		{
			[CompilerGenerated]
			get
			{
				return stU2vkIQX8R;
			}
			[CompilerGenerated]
			internal set
			{
				stU2vkIQX8R = value;
			}
		}

		public string StartPage
		{
			[CompilerGenerated]
			get
			{
				return Win2vGbd3BM;
			}
			[CompilerGenerated]
			internal set
			{
				Win2vGbd3BM = value;
			}
		}

		public string Square150x150Logo
		{
			[CompilerGenerated]
			get
			{
				return FS72vsNIPni;
			}
			[CompilerGenerated]
			internal set
			{
				FS72vsNIPni = value;
			}
		}

		public string Square30x30Logo
		{
			[CompilerGenerated]
			get
			{
				return Ix72vHVN5Ys;
			}
			[CompilerGenerated]
			internal set
			{
				Ix72vHVN5Ys = value;
			}
		}

		public string Square44x44Logo
		{
			[CompilerGenerated]
			get
			{
				return H4b2v1vFKmn;
			}
			[CompilerGenerated]
			internal set
			{
				H4b2v1vFKmn = value;
			}
		}

		public string BackgroundColor
		{
			[CompilerGenerated]
			get
			{
				return iyh2vbuM3Cx;
			}
			[CompilerGenerated]
			internal set
			{
				iyh2vbuM3Cx = value;
			}
		}

		public string ForegroundText
		{
			[CompilerGenerated]
			get
			{
				return UPP2v63iWdK;
			}
			[CompilerGenerated]
			internal set
			{
				UPP2v63iWdK = value;
			}
		}

		public string WideLogo
		{
			[CompilerGenerated]
			get
			{
				return LKT2vX5msgj;
			}
			[CompilerGenerated]
			internal set
			{
				LKT2vX5msgj = value;
			}
		}

		public string Wide310x310Logo
		{
			[CompilerGenerated]
			get
			{
				return lL72vmT4mYl;
			}
			[CompilerGenerated]
			internal set
			{
				lL72vmT4mYl = value;
			}
		}

		public string ShortName
		{
			[CompilerGenerated]
			get
			{
				return o5m2vKnQQEG;
			}
			[CompilerGenerated]
			internal set
			{
				o5m2vKnQQEG = value;
			}
		}

		public string Square310x310Logo
		{
			[CompilerGenerated]
			get
			{
				return EfG2vxaxVoI;
			}
			[CompilerGenerated]
			internal set
			{
				EfG2vxaxVoI = value;
			}
		}

		public string Square70x70Logo
		{
			[CompilerGenerated]
			get
			{
				return tVF2vr2dCQc;
			}
			[CompilerGenerated]
			internal set
			{
				tVF2vr2dCQc = value;
			}
		}

		public string MinWidth
		{
			[CompilerGenerated]
			get
			{
				return UUr2vpAxuNp;
			}
			[CompilerGenerated]
			internal set
			{
				UUr2vpAxuNp = value;
			}
		}

		internal AppxApp(AppxPackage.BylT5Mh5RHcLXQ3GA5P app)
		{
			yr32vZHiKaM = app;
		}

		public string GetStringValue(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return AppxPackage.Rda2L9x1Rx9(yr32vZHiKaM, name);
		}

		internal static bool eaKBjNy3pnM2OO9Dnv1P()
		{
			return KshIvry3yNL6nMkAUvPy == null;
		}
	}

	public enum AppxPackageArchitecture
	{
		x86 = 0,
		Arm = 5,
		x64 = 9,
		Neutral = 11,
		Arm64 = 12
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yx82vjqNZfk;

		public static Func<AppModuleItem, string> I2I2vnfpbHi;

		public static Func<IGrouping<string, AppModuleItem>, AppModuleItem> Hfu2v4L0Koo;

		private static _003C_003Ec SYrL5my3jcsHlspCaBvy;

		static _003C_003Ec()
		{
			yx82vjqNZfk = new _003C_003Ec();
		}

		internal string xkI2vBWlQ8g(AppModuleItem x)
		{
			return x.ApplicationUserModelId;
		}

		internal AppModuleItem LmY2vQal7sK(IGrouping<string, AppModuleItem> x)
		{
			return x.First();
		}

		internal static bool LNpWx1y3DR16tpPpkbMJ()
		{
			return SYrL5my3jcsHlspCaBvy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ConcurrentBag<AppModuleItem> rxl2vDYuSWv;

		private static _003C_003Ec__DisplayClass2_0 tlwaKLy3EfFWR10AUsYM;

		internal void zAP2v5uYGkI(p5b0SKDYLf0KSYbqNSo item)
		{
			using IEnumerator<AppxPackage> enumerator = AppxPackage.QueryPackageInfo(item.zbL2LtoVwNr(), AppxPackage.PackageConstants.PACKAGE_FILTER_HEAD).GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_1
				{
					yk82vTtBuuW = this,
					k6S2voexsXv = enumerator.Current
				};
				Parallel.ForEach(_003C_003Ec__DisplayClass2_.k6S2voexsXv.Apps, _003C_003Ec__DisplayClass2_.VuS2vdODmbj);
			}
		}

		internal static bool X2KvIfy3G2ZteHl5qBZG()
		{
			return tlwaKLy3EfFWR10AUsYM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_1
	{
		public AppxPackage k6S2voexsXv;

		public _003C_003Ec__DisplayClass2_0 yk82vTtBuuW;

		private static _003C_003Ec__DisplayClass2_1 OMpNdHy31d3k1Bg8c0Sb;

		internal void VuS2vdODmbj(AppxApp app)
		{
			_003C_003Ec__DisplayClass2_2 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_2
			{
				gEx2vAj97cS = k6S2voexsXv.FamilyName + "!" + app.Id
			};
			string name = (app.DisplayName.StartsWith("ms-r", StringComparison.OrdinalIgnoreCase) ? k6S2voexsXv.LoadResourceString(app.DisplayName) : app.DisplayName);
			AppModuleItem appModuleItem = new AppModuleItem
			{
				Name = name
			};
			if ((!string.IsNullOrEmpty(appModuleItem.Name) || !string.IsNullOrEmpty(appModuleItem.Name)) && !yk82vTtBuuW.rxl2vDYuSWv.Any(_003C_003Ec__DisplayClass2_.yqy2vMGxLq7))
			{
				appModuleItem.ApplicationUserModelId = _003C_003Ec__DisplayClass2_.gEx2vAj97cS;
				appModuleItem.IconPath = k6S2voexsXv.FindListImagePath(app.Square44x44Logo);
				int num = 0;
				if (!vyQa6Ry3KmZhMG02aXgY())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				appModuleItem.Description = k6S2voexsXv.LoadResourceString(app.Description);
				appModuleItem.PackageId = k6S2voexsXv.FamilyName;
				appModuleItem.BackgroundColor = app.BackgroundColor;
				yk82vTtBuuW.rxl2vDYuSWv.Add(appModuleItem);
			}
		}

		internal static bool vyQa6Ry3KmZhMG02aXgY()
		{
			return OMpNdHy31d3k1Bg8c0Sb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_2
	{
		public string gEx2vAj97cS;

		internal static _003C_003Ec__DisplayClass2_2 t3vdYWy3OuckUHNcX6UT;

		internal bool yqy2vMGxLq7(AppModuleItem x)
		{
			return x.ApplicationUserModelId == gEx2vAj97cS;
		}

		internal static bool GgJNqDy3JcwEfWV0W7AX()
		{
			return t3vdYWy3OuckUHNcX6UT == null;
		}
	}

	private static IList<AppModuleItem> oUfLASsTxvy;

	private static UWPHelper2 StiGWpFgeA3hHjZnAX8L;

	public static IList<AppModuleItem> GetAppModuels()
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		if (oUfLASsTxvy != null)
		{
			return oUfLASsTxvy;
		}
		_003C_003Ec__DisplayClass2_.rxl2vDYuSWv = new ConcurrentBag<AppModuleItem>();
		Parallel.ForEach(vROLMzAimEF(), _003C_003Ec__DisplayClass2_.zAP2v5uYGkI);
		oUfLASsTxvy = _003C_003Ec__DisplayClass2_.rxl2vDYuSWv.GroupBy(_003C_003Ec.I2I2vnfpbHi ?? (_003C_003Ec.I2I2vnfpbHi = _003C_003Ec.yx82vjqNZfk.xkI2vBWlQ8g)).Select(_003C_003Ec.Hfu2v4L0Koo ?? (_003C_003Ec.Hfu2v4L0Koo = _003C_003Ec.yx82vjqNZfk.LmY2vQal7sK)).ToList();
		return oUfLASsTxvy;
	}

	[Obsolete("请使用UWPIconHelper")]
	public static string GetAppIcon(string appUserModelId)
	{
		foreach (AppModuleItem appModuel in GetAppModuels())
		{
			if (appModuel.ApplicationUserModelId == appUserModelId)
			{
				return appModuel.IconPath;
			}
		}
		return null;
	}

	public static string GetAppIconBackgroundColor(string appUserModelId)
	{
		foreach (AppModuleItem appModuel in GetAppModuels())
		{
			if (appModuel.ApplicationUserModelId == appUserModelId)
			{
				return appModuel.BackgroundColor;
			}
		}
		return null;
	}

	public static string GetResourceString(string resString)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (NativeMethods.SHLoadIndirectString(resString, stringBuilder, (uint)stringBuilder.Capacity, IntPtr.Zero) == 0)
		{
			return stringBuilder.ToString();
		}
		return null;
	}

	private static IList<p5b0SKDYLf0KSYbqNSo> vROLMzAimEF()
	{
		List<p5b0SKDYLf0KSYbqNSo> list = new List<p5b0SKDYLf0KSYbqNSo>();
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32);
		RegistryKey registryKey2 = registryKey.OpenSubKey("Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\Repository\\Packages");
		string[] subKeyNames = registryKey2.GetSubKeyNames();
		foreach (string name in subKeyNames)
		{
			RegistryKey registryKey3 = registryKey2.OpenSubKey(name);
			if (registryKey3 == null)
			{
				continue;
			}
			if (registryKey3.SubKeyCount > 0)
			{
				string[] subKeyNames2 = registryKey3.GetSubKeyNames();
				foreach (string name2 in subKeyNames2)
				{
					RegistryKey registryKey4 = registryKey3.OpenSubKey(name2);
					if (registryKey4 == null || registryKey4.SubKeyCount <= 0)
					{
						continue;
					}
					RegistryKey registryKey5 = registryKey4.OpenSubKey("Capabilities");
					if (registryKey5 == null)
					{
						continue;
					}
					RegistryKey registryKey6 = registryKey5.OpenSubKey("URLAssociations");
					if (registryKey6 != null)
					{
						p5b0SKDYLf0KSYbqNSo p5b0SKDYLf0KSYbqNSo = new p5b0SKDYLf0KSYbqNSo();
						p5b0SKDYLf0KSYbqNSo.v2l2gliFtsE((string)registryKey5.GetValue("ApplicationName"));
						p5b0SKDYLf0KSYbqNSo.Name = (string)registryKey5.GetValue("ApplicationName");
						p5b0SKDYLf0KSYbqNSo.Description = (string)registryKey5.GetValue("ApplicationDescription");
						p5b0SKDYLf0KSYbqNSo.QnO2Lg8uF23((string)registryKey3.GetValue("PackageID"));
						p5b0SKDYLf0KSYbqNSo.kuC2LSkPr8J((string)registryKey3.GetValue("PackageRootFolder"));
						string[] valueNames = registryKey6.GetValueNames();
						foreach (string text in valueNames)
						{
							p5b0SKDYLf0KSYbqNSo.m8v2Luq8exr().Add(text, (string)registryKey6.GetValue(text));
						}
						if (p5b0SKDYLf0KSYbqNSo.Name.StartsWith("@", StringComparison.Ordinal))
						{
							p5b0SKDYLf0KSYbqNSo.Name = GetResourceString(p5b0SKDYLf0KSYbqNSo.Name);
						}
						if (p5b0SKDYLf0KSYbqNSo.Description.StartsWith("@", StringComparison.Ordinal))
						{
							p5b0SKDYLf0KSYbqNSo.Description = GetResourceString(p5b0SKDYLf0KSYbqNSo.Description);
						}
						list.Add(p5b0SKDYLf0KSYbqNSo);
					}
				}
				continue;
			}
			p5b0SKDYLf0KSYbqNSo p5b0SKDYLf0KSYbqNSo2 = new p5b0SKDYLf0KSYbqNSo();
			p5b0SKDYLf0KSYbqNSo2.v2l2gliFtsE((string)registryKey3.GetValue("DisplayName"));
			p5b0SKDYLf0KSYbqNSo2.Name = (string)registryKey3.GetValue("DisplayName");
			p5b0SKDYLf0KSYbqNSo2.Description = "";
			p5b0SKDYLf0KSYbqNSo2.QnO2Lg8uF23((string)registryKey3.GetValue("PackageID"));
			p5b0SKDYLf0KSYbqNSo2.kuC2LSkPr8J((string)registryKey3.GetValue("PackageRootFolder"));
			if (!string.IsNullOrEmpty(p5b0SKDYLf0KSYbqNSo2.Name))
			{
				if (p5b0SKDYLf0KSYbqNSo2.Name.StartsWith("@", StringComparison.Ordinal))
				{
					p5b0SKDYLf0KSYbqNSo2.Name = GetResourceString(p5b0SKDYLf0KSYbqNSo2.Name);
				}
				if (p5b0SKDYLf0KSYbqNSo2.Description.StartsWith("@", StringComparison.Ordinal))
				{
					p5b0SKDYLf0KSYbqNSo2.Description = GetResourceString(p5b0SKDYLf0KSYbqNSo2.Description);
				}
				list.Add(p5b0SKDYLf0KSYbqNSo2);
			}
		}
		return list;
	}

	private IList<ProtocalObject> jkkLAwt3v3G()
	{
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("\\Extensions\\ContractId\\Windows.Protocol\\PackageId", RegistryKeyPermissionCheck.ReadSubTree);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		List<ProtocalObject> list = new List<ProtocalObject>();
		string[] array = subKeyNames;
		foreach (string text in array)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(text + "\\ActivatableClassId");
			string[] subKeyNames2 = registryKey2.GetSubKeyNames();
			foreach (string text2 in subKeyNames2)
			{
				RegistryKey registryKey3 = registryKey2.OpenSubKey(text2);
				ProtocalObject protocalObject = new ProtocalObject();
				protocalObject.PackageId = text;
				protocalObject.Name = (string)registryKey3.GetValue("DisplayName");
				protocalObject.Description = (string)registryKey3.GetValue("Description");
				protocalObject.Icon = (string)registryKey3.GetValue("Icon");
				protocalObject.ClassId = text2;
				RegistryKey registryKey4 = registryKey3.OpenSubKey("CustomProperties");
				protocalObject.Protocol = (string)registryKey4.GetValue("Name");
				if (protocalObject.Name.StartsWith("@", StringComparison.Ordinal))
				{
					protocalObject.Name = GetResourceString(protocalObject.Name);
				}
				if (protocalObject.Description.StartsWith("@", StringComparison.Ordinal))
				{
					protocalObject.Description = GetResourceString(protocalObject.Description);
				}
				if (protocalObject.Icon.StartsWith("@", StringComparison.Ordinal))
				{
					protocalObject.Icon = GetResourceString(protocalObject.Icon);
				}
				list.Add(protocalObject);
			}
		}
		return list;
	}

	[DllImport("kernel32", EntryPoint = "OpenPackageInfoByFullName")]
	private static extern int ykrLAtFOs3L([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0, out IntPtr intptr_0);

	[DllImport("kernel32", EntryPoint = "GetPackageApplicationIds")]
	private static extern int GTFLAgAasOr(IntPtr intptr_0, ref int int_0, byte[] byte_0, out int int_1);

	[DllImport("kernel32", EntryPoint = "ClosePackageInfo")]
	private static extern int SN2LALQRGjV(IntPtr intptr_0);

	public static uint LaunchApp(string appUserModelId, string arguments = null)
	{
		uint processId;
		int num = ((IApplicationActivationManager)new ApplicationActivationManager()).ActivateApplication(appUserModelId, arguments ?? string.Empty, SNsMIODM54kFIriBhmD.None, out processId);
		if (num < 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		return processId;
	}

	private void NtsLAvtMtur(object sender, EventArgs e)
	{
		LaunchApp("Microsoft.Office.EXCEL.EXE.15");
	}

	internal static bool Oco3m6FgjKerAdAC10q0()
	{
		return StiGWpFgeA3hHjZnAX8L == null;
	}
}
