using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;
using ImageProcessor.Imaging.Formats;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X.BuildinRunners.Images;

public static class ImageProcessorHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public ImageFactory ecZvUbyghqg;

		internal static _003C_003Ec__DisplayClass10_0 rC5amQWAotp5u9UYMKpm;

		internal void d7AvU1MqdMS(string s)
		{
			ecZvUbyghqg.Save(s);
		}

		internal static bool CJG1x7WAfuDOhJwR3hRf()
		{
			return rC5amQWAotp5u9UYMKpm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public ImageFactory tqLvUXfuxPV;

		private static _003C_003Ec__DisplayClass11_0 Ms3ySIWAqpNMVFkLflih;

		internal void SvBvU6DODTA(string s)
		{
			tqLvUXfuxPV.Saturation(Convert.ToInt32(s));
		}

		internal static void Dxct3kWAZfflmu3nLFsj()
		{
		}

		internal static bool iFUCcNWAiHIuDuYa7veB()
		{
			return Ms3ySIWAqpNMVFkLflih == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public ImageFactory A3xvUKQHukd;

		private static _003C_003Ec__DisplayClass12_0 Cg7gLUWA54JYVDiT0SSj;

		internal void qqbvUmhpBeB(string s)
		{
			string[] array = s.Split(',', ';');
			if (array.Length == 1)
			{
				A3xvUKQHukd.RoundedCorners(Convert.ToInt32(s));
			}
			else
			{
				A3xvUKQHukd.RoundedCorners(new RoundedCornerLayer(Convert.ToInt32(array[0]), array[1].ConvertToBoolean(), array[2].ConvertToBoolean(), array[3].ConvertToBoolean(), array[4].ConvertToBoolean()));
			}
		}

		internal static bool zx8VMSWAYpiKbFVV4O7o()
		{
			return Cg7gLUWA54JYVDiT0SSj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public ImageFactory NcNvUrOsU97;

		internal static _003C_003Ec__DisplayClass13_0 XrVIvrWARIPbNqyDe680;

		internal void xXtvUxLwaBd(string s)
		{
			NcNvUrOsU97.Rotate(Convert.ToSingle(s));
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}

		internal static bool boFeQ5WAg3npeuDAPfcK()
		{
			return XrVIvrWARIPbNqyDe680 == null;
		}

		internal static void aXWOpfWAMgnbDs9tPl2c()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public ImageFactory EYAvUBB7eb9;

		internal static _003C_003Ec__DisplayClass14_0 Pq5iLyWAUlUNr8l7HYHL;

		internal void hjwvUpCNrdQ(string s)
		{
			Point point = lBmtdf3FgOn(s);
			EYAvUBB7eb9.Resolution(point.X, point.Y);
		}

		internal static bool qiqlf4WAxbLgIoT8IhoC()
		{
			return Pq5iLyWAUlUNr8l7HYHL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public ImageFactory iGnvUjXSM2q;

		private static _003C_003Ec__DisplayClass15_0 U2tKJcWA6ahVdbtAT9Yu;

		internal void WoVvUQ1FZ25(string s)
		{
			iGnvUjXSM2q.Resize(new Size(lBmtdf3FgOn(s)));
		}

		internal static bool NQvFUrWAtWlr2gVxcwxn()
		{
			return U2tKJcWA6ahVdbtAT9Yu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public ImageFactory xa5vU4t5uWG;

		private static _003C_003Ec__DisplayClass16_0 WR3nJMWAwZb6duyeWpCU;

		internal void dlVvUnCQH0J(string s)
		{
			string[] array = s.Split(';', '；');
			if (array.Length < 4)
			{
				throw new InvalidDataException("格式不正确，需要至少4个参数。");
			}
			ResizeLayer resizeLayer = new ResizeLayer(new Size(lBmtdf3FgOn(array[0])), (ResizeMode)Enum.Parse(typeof(ResizeMode), array[1], true), (AnchorPosition)Enum.Parse(typeof(AnchorPosition), array[2], true), array[3].ConvertToBoolean());
			xa5vU4t5uWG.Resize(resizeLayer);
		}

		internal static bool FGtVYRWATCLOkIuVEy9p()
		{
			return WR3nJMWAwZb6duyeWpCU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public ImageFactory l99vUDc5KgJ;

		private static _003C_003Ec__DisplayClass17_0 qVVfftWAs1ApUibhhfJu;

		internal void ugEvU5DgZEU(string s)
		{
			if (string.IsNullOrWhiteSpace(s) || s.ConvertToBoolean())
			{
				l99vUDc5KgJ.Reset();
			}
		}

		internal static bool atLZRZWAC2RCB3dq8Rhf()
		{
			return qVVfftWAs1ApUibhhfJu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public ImageFactory zY7vUoo5pqY;

		private static _003C_003Ec__DisplayClass18_0 YoY6WLWA44JtYfmPDIGE;

		internal void LGhvUdHt1wQ(string s)
		{
			string[] array = s.Split(';', '；');
			zY7vUoo5pqY.ReplaceColor(ColorHelper.StringToWinformColor(array[0]), ColorHelper.StringToWinformColor(array[1]), (array.Length >= 3 && !string.IsNullOrWhiteSpace(array[2])) ? Convert.ToInt32(array[2]) : 0);
		}

		internal static void HUhrvkWAzs5b80uPsRyd()
		{
		}

		internal static bool w6YxIyWAhPlrqOIDMYHJ()
		{
			return YoY6WLWA44JtYfmPDIGE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public ImageFactory NTmvUMwCVhT;

		private static _003C_003Ec__DisplayClass19_0 OODkI6WnVP72gUFbT07H;

		internal void zaWvUTbvZei(string s)
		{
			string[] array = s.Split(';', '；');
			Rectangle? rectangle = ((array.Length < 2 || string.IsNullOrWhiteSpace(array[1])) ? ((Rectangle?)null) : new Rectangle?(GnQtdi6Nh30(array[1])));
			NTmvUMwCVhT.Pixelate(Convert.ToInt32(array[0]), rectangle);
		}

		internal static bool IBlX2KWnQnypFpbHqO5J()
		{
			return OODkI6WnVP72gUFbT07H == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public ImageFactory N06vUOH3Q88;

		internal static _003C_003Ec__DisplayClass20_0 w3cF2YWnWI0On5YwCagW;

		internal void bInvUA5ewBb(string s)
		{
			using ImageLayer imageLayer = RHetd3ZJfe2(s);
			N06vUOH3Q88.Overlay(imageLayer);
		}

		internal static bool Ohp2VlWnyu24imom6sh0()
		{
			return w3cF2YWnWI0On5YwCagW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public ImageFactory wVkvUUSa7Ic;

		internal static _003C_003Ec__DisplayClass24_0 fT7S25WnXovx21ant3Aa;

		internal void XuivUFKUBkS(string s)
		{
			using ImageLayer imageLayer = RHetd3ZJfe2(s);
			wVkvUUSa7Ic.Mask(imageLayer);
		}

		internal static bool bJ4Ok3Wn2a0GN5ksYxEA()
		{
			return fT7S25WnXovx21ant3Aa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_0
	{
		public ImageFactory P40vUik5OrG;

		internal static _003C_003Ec__DisplayClass25_0 FFYymiWneOXU0JNbiHkr;

		internal void YopvUlD7wAY(string s)
		{
			P40vUik5OrG.Load(s);
		}

		internal static bool dDknqvWnjhsd8Zd3bgbC()
		{
			return FFYymiWneOXU0JNbiHkr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public ImageFactory RnuvUfYs1bs;

		private static _003C_003Ec__DisplayClass26_0 H5EEaDWn3k2wyy3vnxge;

		internal void H71vU3EeHB2(string s)
		{
			RnuvUfYs1bs.Gamma(Convert.ToSingle(s));
		}

		internal static bool cukRohWnEV3Y7xW9EZaq()
		{
			return H5EEaDWn3k2wyy3vnxge == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public ImageFactory pD2vlwV60Xa;

		internal static _003C_003Ec__DisplayClass27_0 obtV54Wn0Lj1XOXcXaah;

		internal void lD8vUzvxPO2(string s)
		{
			pD2vlwV60Xa.Deskew();
		}

		internal static bool tZZZUgWn112moDbh5jWb()
		{
			return obtV54Wn0Lj1XOXcXaah == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public ImageFactory Fy1vlgj6t39;

		internal static _003C_003Ec__DisplayClass28_0 isnFS8WnBOXPPpoogie0;

		internal void ycpvltN55jA(string s)
		{
			string[] array = s.Split(',', ';');
			Fy1vlgj6t39.Hue(Convert.ToInt32(array[0]), array.Length > 1 && array[1].ConvertToBoolean());
		}

		internal static bool VbNyjVWnvQe7AvBeL8Q3()
		{
			return isnFS8WnBOXPPpoogie0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public ImageFactory vh7vlvYucXF;

		internal static _003C_003Ec__DisplayClass29_0 QCu162WnOWMED59iEEAg;

		internal void ybLvlL7skW4(string s)
		{
			vh7vlvYucXF.GaussianSharpen(Convert.ToInt32(s));
		}

		internal static bool as4W6qWnJfAX1kU3WcVY()
		{
			return QCu162WnOWMED59iEEAg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ImageFactory uWwvl2YAZij;

		internal static _003C_003Ec__DisplayClass2_0 zwYAoEWnadJeLkKZnKfp;

		internal void DJbvlSPMBRk(string s)
		{
			ISupportedImageFormat format = null;
			string text = s.ToLower();
			if (!(text == "png"))
			{
				if (text == "jpg")
				{
					goto IL_00c0;
				}
				int num = 0;
				if (!YVutcjWnrZYodYim8uSM())
				{
					int num2 = default(int);
					num = num2;
				}
				do
				{
					switch (num)
					{
					case 1:
						goto end_IL_007d;
					}
					switch (text)
					{
					case "tiff":
						break;
					default:
						throw new NotSupportedException("不支持的图片格式：" + s);
					case "gif":
						goto IL_00ab;
					case "bmp":
						goto IL_00b7;
					case "jpeg":
						goto IL_00c0;
					}
					format = new TiffFormat();
					num = 1;
					continue;
					IL_00ab:
					format = new GifFormat();
					break;
					IL_00b7:
					format = new BitmapFormat();
					break;
					continue;
					end_IL_007d:
					break;
				}
				while (!YVutcjWnrZYodYim8uSM());
			}
			else
			{
				format = new PngFormat();
			}
			goto IL_00d0;
			IL_00d0:
			uWwvl2YAZij.Format(format);
			return;
			IL_00c0:
			format = new JpegFormat();
			goto IL_00d0;
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}

		internal static bool YVutcjWnrZYodYim8uSM()
		{
			return zwYAoEWnadJeLkKZnKfp == null;
		}

		internal static void JDC3B4Wn9W35oEV1rI2M()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public ImageFactory d7gvlNpWKLt;

		private static _003C_003Ec__DisplayClass30_0 bKWYcfWnL9KG9jEq1bU8;

		internal void JPTvluMRoYl(string s)
		{
			d7gvlNpWKLt.GaussianBlur(Convert.ToInt32(s));
		}

		static _003C_003Ec__DisplayClass30_0()
		{
		}

		internal static bool yiuu2nWnuxYv2uBqxJI1()
		{
			return bKWYcfWnL9KG9jEq1bU8 == null;
		}

		internal static void KTlI4VWnfofQp9ceQoao()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass31_0
	{
		public ImageFactory iYZvl0yAMy6;

		internal static _003C_003Ec__DisplayClass31_0 sO0jqaWnbFIZZMIjGud8;

		internal void vV7vlJy1pSg(string s)
		{
			iYZvl0yAMy6.Flip(s.ConvertToBoolean());
		}

		internal static bool yd7PLCWnqX3GkM1Gmfoi()
		{
			return sO0jqaWnbFIZZMIjGud8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public ImageFactory O1wvlPVcNK7;

		private static _003C_003Ec__DisplayClass32_0 piEAJhWnlvd6obRxl0oY;

		internal void LJevlC5GCoI(string s)
		{
			O1wvlPVcNK7.Filter(k8ntowVbmsG(Convert.ToInt32(s)));
		}

		internal static bool eZCtWJWnZSpnKW8JO8VN()
		{
			return piEAJhWnlvd6obRxl0oY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public ImageFactory JSJvlydnekB;

		internal static _003C_003Ec__DisplayClass33_0 TuOnbQWn8QBU9YQnIJDs;

		internal void OiTvlESC2Q9(string s)
		{
			byte threshold = 128;
			if (!string.IsNullOrEmpty(s))
			{
				threshold = Convert.ToByte(s);
			}
			JSJvlydnekB.EntropyCrop(threshold);
		}

		internal static bool CtlUpfWnRolQdctniJmA()
		{
			return TuOnbQWn8QBU9YQnIJDs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass34_0
	{
		public ImageFactory YofvlabVovd;

		internal static _003C_003Ec__DisplayClass34_0 jDbrFbWnMTy70DNIs3jX;

		internal void y4Uvl8LZU4h(string s)
		{
			string[] array = s.Split(',', ';');
			IEdgeFilter edgeFilter = null;
			switch (Convert.ToInt32(array[0]))
			{
			default:
				edgeFilter = new KayyaliEdgeFilter();
				break;
			case 1:
				edgeFilter = new KirschEdgeFilter();
				break;
			case 3:
				edgeFilter = new Laplacian5X5EdgeFilter();
				break;
			case 4:
			{
				edgeFilter = new LaplacianOfGaussianEdgeFilter();
				int num = 0;
				if (jDbrFbWnMTy70DNIs3jX != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					goto end_IL_0028;
				}
				goto case 2;
			}
			case 2:
				edgeFilter = new Laplacian3X3EdgeFilter();
				break;
			case 5:
				edgeFilter = new PrewittEdgeFilter();
				break;
			case 6:
				edgeFilter = new RobertsCrossEdgeFilter();
				break;
			case 7:
				edgeFilter = new ScharrEdgeFilter();
				break;
			case 8:
				{
					edgeFilter = new SobelEdgeFilter();
					break;
				}
				end_IL_0028:
				break;
			}
			bool greyscale = array[1].ConvertToBoolean();
			YofvlabVovd.DetectEdges(edgeFilter, greyscale);
		}

		internal static bool EEt7s3WnUB9aSQVpcuK7()
		{
			return jDbrFbWnMTy70DNIs3jX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public string QI0vlRFUeQO;

		public ImageFactory YHIvlqMd7wM;

		internal static _003C_003Ec__DisplayClass35_0 fkfG7sWn6OgVtpRax7a5;

		internal void p94vl7OdFV7(string s)
		{
			IList<int> list = s.StringToIntList(',');
			if (list.Count != 4)
			{
				throw new InvalidDataException("参数不正确：" + QI0vlRFUeQO);
			}
			Rectangle rectangle = new Rectangle(list[0], list[1], list[2], list[3]);
			YHIvlqMd7wM.Crop(rectangle);
		}

		internal static bool TQllbEWnt9KHFSmQEk0c()
		{
			return fkfG7sWn6OgVtpRax7a5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass36_0
	{
		public bool V2CvlVh4X5a;

		public Action<string> vMTvlZb00Cb;

		public string vdqvl97HPFq;

		private static _003C_003Ec__DisplayClass36_0 NeEe06WnwWqyvE04yjIs;

		internal void TQqvlcUsIhw(string s)
		{
			if (V2CvlVh4X5a && string.IsNullOrEmpty(s))
			{
				return;
			}
			try
			{
				vMTvlZb00Cb(s);
			}
			catch (Exception exception)
			{
				throw new Exception("处理图片出错。行：" + vdqvl97HPFq + " 错误：" + exception.GetMessageWithInner());
			}
		}

		internal static bool rIytT8WnTpFAeEJF897b()
		{
			return NeEe06WnwWqyvE04yjIs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public ImageFactory tNevleY6cYl;

		internal static _003C_003Ec__DisplayClass37_0 FJfWMlWnChV4JN0qDxtb;

		internal void wXevlhYdK8G(string s)
		{
			tNevleY6cYl.Contrast(Convert.ToInt32(s));
		}

		internal static bool rpsQmxWn7PkXjL4vnrhL()
		{
			return FJfWMlWnChV4JN0qDxtb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass38_0
	{
		public ImageFactory NlpvlIg0yN8;

		private static _003C_003Ec__DisplayClass38_0 VWvDSDWnhkmF0OqYCJOV;

		internal void gMNvlYNk0OL(string s)
		{
			string[] array = s.Split(new char[2] { ',', ';' }, 2);
			NlpvlIg0yN8.Constrain(new Size(Convert.ToInt32(array[0]), Convert.ToInt32(array[1])));
		}

		internal static bool xIskUjWnH4BBtdajBNqY()
		{
			return VWvDSDWnhkmF0OqYCJOV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ImageFactory LDgvlkQTnv2;

		internal static _003C_003Ec__DisplayClass39_0 BM1jteWeVpJLG2I2PlSd;

		internal void JojvlW44OPL(string s)
		{
			LDgvlkQTnv2.Brightness(Convert.ToInt32(s));
		}

		internal static bool r8MhBhWeQYQOLBsjGyJj()
		{
			return BM1jteWeVpJLG2I2PlSd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public ImageFactory CjSvlsdjpHU;

		private static _003C_003Ec__DisplayClass3_0 rKeUGXWecnKUvOGKAwc9;

		internal void KMwvlGAHIPl(string s)
		{
			CjSvlsdjpHU.PreserveExifData = false;
		}

		static _003C_003Ec__DisplayClass3_0()
		{
		}

		internal static bool XE1NagWeWQ5ILhi06Xkn()
		{
			return rKeUGXWecnKUvOGKAwc9 == null;
		}

		internal static void nDObGtWepMcIUbrY4Mng()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ImageFactory p5kvl1CgvmG;

		internal static _003C_003Ec__DisplayClass40_0 j7OYliWeXtjTcSRP75fo;

		internal void JCivlHLEnaZ(string s)
		{
			Color color = ColorHelper.StringToWinformColor(s);
			p5kvl1CgvmG.BackgroundColor(color);
		}

		internal static bool nOcUgrWe2sJMMFoo7ICL()
		{
			return j7OYliWeXtjTcSRP75fo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass41_0
	{
		public ImageFactory GgSvl6a59wD;

		private static _003C_003Ec__DisplayClass41_0 h0fNUrWeeAqqGEYqRPwN;

		internal void evBvlbqGRcD(string s)
		{
			if (string.IsNullOrWhiteSpace(s) || s.ConvertToBoolean())
			{
				GgSvl6a59wD.AutoRotate();
			}
		}

		internal static bool rtl55sWejwGZLMnxKNfG()
		{
			return h0fNUrWeeAqqGEYqRPwN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ImageFactory GxZvlmcX7q6;

		private static _003C_003Ec__DisplayClass42_0 B4mxHIWe3xRVw3NOuh17;

		internal void lV3vlX2fNof(string s)
		{
			GxZvlmcX7q6.Alpha(Convert.ToInt32(s));
		}

		static _003C_003Ec__DisplayClass42_0()
		{
		}

		internal static bool N4v3KaWeEc3g2uAdHNyc()
		{
			return B4mxHIWe3xRVw3NOuh17 == null;
		}

		internal static void tZY938We0XohKnbF6u0i()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public ImageFactory QtovlxFOtT2;

		internal static _003C_003Ec__DisplayClass4_0 pUZ3QKWe1Y47HjC7JStD;

		internal void IVLvlK8ylNY(string s)
		{
			QtovlxFOtT2.Quality(Convert.ToInt32(s));
		}

		internal static bool M5oYYDWeKRmjY2K6tPvY()
		{
			return pUZ3QKWe1Y47HjC7JStD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ImageFactory ruSvlpj6Z7w;

		private static _003C_003Ec__DisplayClass5_0 mgBjSBWedkKtCOag86fc;

		internal void XJqvlrvxF4j(string s)
		{
			ruSvlpj6Z7w.WhiteThreshold(Convert.ToInt32(s));
		}

		internal static bool jtBMPUWeOlkLWcISuDTd()
		{
			return mgBjSBWedkKtCOag86fc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public ImageFactory T1RvlQRfleD;

		internal static _003C_003Ec__DisplayClass6_0 WnQFNrWek5v4fLIadWq2;

		internal void QTgvlBYUaCi(string s)
		{
			T1RvlQRfleD.Threshold(Convert.ToInt32(s));
		}

		internal static bool WrdlrYWeafLUdAneQOw0()
		{
			return WnQFNrWek5v4fLIadWq2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public ImageFactory nyKvlnkeJ7w;

		private static _003C_003Ec__DisplayClass7_0 emp2veWe9YhlfDBGZOvC;

		internal void elmvljC1gNh(string s)
		{
			string[] array = s.Split(new char[1] { ';' }, 10);
			TextLayer textLayer = new TextLayer();
			int num;
			if (string.IsNullOrWhiteSpace(array[0]))
			{
				num = 2;
				if (emp2veWe9YhlfDBGZOvC != null)
				{
					goto IL_00fa;
				}
				goto IL_0209;
			}
			textLayer.FontFamily = new FontFamily(array[0]);
			goto IL_0235;
			IL_0246:
			nyKvlnkeJ7w.Watermark(textLayer);
			return;
			IL_0103:
			if (!string.IsNullOrWhiteSpace(array[5]))
			{
				textLayer.Position = lBmtdf3FgOn(array[5]);
				string[] array2 = array[5].Split(',');
				if (array2.Length > 2)
				{
					textLayer.AnchorPosition = (AnchorPosition)Enum.Parse(typeof(global::ImageProcessor.Imaging.AnchorPosition), array2[2], true);
				}
				if (array2.Length > 3)
				{
					textLayer.Angle = double.Parse(array2[3]);
				}
			}
			if (!string.IsNullOrWhiteSpace(array[6]))
			{
				textLayer.DropShadow = array[6].ConvertToBoolean();
			}
			goto IL_012c;
			IL_00fa:
			int num2 = default(int);
			num = num2;
			goto IL_0209;
			IL_0209:
			switch (num)
			{
			case 1:
				break;
			case 3:
				goto IL_012c;
			case 2:
				goto IL_0235;
			default:
				goto IL_0246;
			}
			goto IL_0103;
			IL_0235:
			if (!string.IsNullOrWhiteSpace(array[1]))
			{
				textLayer.FontSize = Convert.ToInt32(array[1]);
			}
			if (!string.IsNullOrWhiteSpace(array[2]))
			{
				textLayer.FontColor = ColorHelper.StringToWinformColor(array[2]);
			}
			if (!string.IsNullOrWhiteSpace(array[3]))
			{
				FontStyle fontStyle = FontStyle.Regular;
				string[] array3 = array[3].Split(',');
				foreach (string value in array3)
				{
					fontStyle |= (FontStyle)Enum.Parse(typeof(FontStyle), value, true);
				}
				textLayer.Style = fontStyle;
			}
			if (string.IsNullOrWhiteSpace(array[4]))
			{
				goto IL_0103;
			}
			textLayer.Opacity = Convert.ToInt32(array[4]);
			num = 1;
			if (emp2veWe9YhlfDBGZOvC != null)
			{
				goto IL_00fa;
			}
			goto IL_0209;
			IL_012c:
			if (!string.IsNullOrWhiteSpace(array[7]))
			{
				textLayer.Vertical = array[7].ConvertToBoolean();
			}
			if (!string.IsNullOrWhiteSpace(array[8]))
			{
				textLayer.RightToLeft = array[8].ConvertToBoolean();
			}
			textLayer.Text = array[9].Replace("\\r\\n", "\r\n");
			num = 0;
			if (!r73MKUWeLvedGPMqDJla())
			{
				goto IL_0209;
			}
			goto IL_0246;
		}

		internal static bool r73MKUWeLvedGPMqDJla()
		{
			return emp2veWe9YhlfDBGZOvC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public ImageFactory jhHvl5QJtwJ;

		private static _003C_003Ec__DisplayClass8_0 W2cmIdWeqKjsquo5JU1e;

		internal void obfvl4V3otD(string s)
		{
			jhHvl5QJtwJ.Vignette(ColorHelper.StringToWinformColor(s));
		}

		internal static bool BvEJJMWeilexJBiRppop()
		{
			return W2cmIdWeqKjsquo5JU1e == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public ImageFactory oQuvldWKMy7;

		private static _003C_003Ec__DisplayClass9_0 GCsTNxWeZe0umFj15spq;

		internal void U9KvlDfwj1u(string s)
		{
			oQuvldWKMy7.Tint(ColorHelper.StringToWinformColor(s));
		}

		internal static bool xTmBW3We5GEO1DfIGaiB()
		{
			return GCsTNxWeZe0umFj15spq == null;
		}
	}

	internal static object TlJDt9QqxlqSXBaZ3RRu;

	public static Bitmap ProcessImage(string filterParams, Bitmap bmpSrc, bool returnResultImage, ActionExecuteContext context)
	{
		Bitmap result = null;
		using (ImageFactory imageFactory = new ImageFactory(true))
		{
			if (bmpSrc != null)
			{
				imageFactory.Load(bmpSrc);
			}
			string[] array = filterParams.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			int num = 0;
			int num3 = default(int);
			while (num < array.Length)
			{
				string text = array[num];
				if (!text.StartsWith("//"))
				{
					string string_ = text.Trim();
					if (!yRmtdlcgM1Y(imageFactory, string_))
					{
						throw new Exception("未处理的图片命令，可能您的Quicker版本较旧：" + text);
					}
				}
				num++;
				int num2 = 0;
				if (!B5rt9yQqIN6sqPtrsUrV())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			if (returnResultImage)
			{
				MemoryStream memoryStream = new MemoryStream();
				imageFactory.Save(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				result = new Bitmap(memoryStream);
			}
		}
		return result;
	}

	private static bool yRmtdlcgM1Y(ImageFactory imageFactory_0, string string_0)
	{
		int num;
		if (!Alpha(imageFactory_0, string_0) && !AutoRotate(imageFactory_0, string_0) && !BackgroundColor(imageFactory_0, string_0) && !Brightness(imageFactory_0, string_0) && !Constrain(imageFactory_0, string_0) && !Contrast(imageFactory_0, string_0) && !Crop(imageFactory_0, string_0) && !DetectEdges(imageFactory_0, string_0) && !EntropyCrop(imageFactory_0, string_0))
		{
			num = 1;
			if (TlJDt9QqxlqSXBaZ3RRu == null)
			{
				goto IL_007c;
			}
			goto IL_0195;
		}
		goto IL_01f4;
		IL_01f4:
		return true;
		IL_007c:
		if (!Filter(imageFactory_0, string_0) && !Flip(imageFactory_0, string_0) && !Format(imageFactory_0, string_0) && !GaussianBlur(imageFactory_0, string_0))
		{
			num = 0;
			if (TlJDt9QqxlqSXBaZ3RRu == null)
			{
				goto IL_00bc;
			}
			goto IL_0195;
		}
		goto IL_01f4;
		IL_0195:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				goto IL_00bc;
			default:
				if (!Saturation(imageFactory_0, string_0) && !Save(imageFactory_0, string_0))
				{
					num = 1;
					if (B5rt9yQqIN6sqPtrsUrV())
					{
						continue;
					}
					goto case 1;
				}
				goto IL_01f4;
			case 1:
				if (!Tint(imageFactory_0, string_0) && !Vignette(imageFactory_0, string_0) && !Watermark(imageFactory_0, string_0) && !Threshold(imageFactory_0, string_0) && !WhiteThreshold(imageFactory_0, string_0) && !ClearMetaData(imageFactory_0, string_0) && !Gamma(imageFactory_0, string_0))
				{
					return Deskew(imageFactory_0, string_0);
				}
				goto IL_01f4;
			}
			break;
		}
		goto IL_007c;
		IL_00bc:
		if (!GaussianSharpen(imageFactory_0, string_0) && !Hue(imageFactory_0, string_0) && !Load(imageFactory_0, string_0) && !Mask(imageFactory_0, string_0) && !Overlay(imageFactory_0, string_0) && !Pixelate(imageFactory_0, string_0) && !Quality(imageFactory_0, string_0) && !ReplaceColor(imageFactory_0, string_0) && !Reset(imageFactory_0, string_0) && !Resize(imageFactory_0, string_0) && !ResizeEx(imageFactory_0, string_0) && !Resolution(imageFactory_0, string_0) && !Rotate(imageFactory_0, string_0) && !RoundedCorners(imageFactory_0, string_0))
		{
			num = 0;
			if (!B5rt9yQqIN6sqPtrsUrV())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0195;
		}
		goto IL_01f4;
	}

	private static bool Format(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.uWwvl2YAZij = imageFactory;
		return JlQtdztJvl8(paramLine, "Format", true, _003C_003Ec__DisplayClass2_.DJbvlSPMBRk);
	}

	private static bool ClearMetaData(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.CjSvlsdjpHU = imageFactory;
		return JlQtdztJvl8(paramLine, "ClearMetaData", false, _003C_003Ec__DisplayClass3_.KMwvlGAHIPl);
	}

	private static bool Quality(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.QtovlxFOtT2 = imageFactory;
		return JlQtdztJvl8(paramLine, "Quality", true, _003C_003Ec__DisplayClass4_.IVLvlK8ylNY);
	}

	private static bool WhiteThreshold(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.ruSvlpj6Z7w = imageFactory;
		return JlQtdztJvl8(paramLine, "WhiteThreshold", true, _003C_003Ec__DisplayClass5_.XJqvlrvxF4j);
	}

	private static bool Threshold(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.T1RvlQRfleD = imageFactory;
		return JlQtdztJvl8(paramLine, "Threshold", true, _003C_003Ec__DisplayClass6_.QTgvlBYUaCi);
	}

	private static bool Watermark(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.nyKvlnkeJ7w = imageFactory;
		return JlQtdztJvl8(paramLine, "Watermark", true, _003C_003Ec__DisplayClass7_.elmvljC1gNh);
	}

	private static bool Vignette(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.jhHvl5QJtwJ = imageFactory;
		return JlQtdztJvl8(paramLine, "Vignette", true, _003C_003Ec__DisplayClass8_.obfvl4V3otD);
	}

	private static bool Tint(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.oQuvldWKMy7 = imageFactory;
		return JlQtdztJvl8(paramLine, "Tint", true, _003C_003Ec__DisplayClass9_.U9KvlDfwj1u);
	}

	private static bool Save(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.ecZvUbyghqg = imageFactory;
		return JlQtdztJvl8(paramLine, "Save", true, _003C_003Ec__DisplayClass10_.d7AvU1MqdMS);
	}

	private static bool Saturation(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.tqLvUXfuxPV = imageFactory;
		return JlQtdztJvl8(paramLine, "Saturation", true, _003C_003Ec__DisplayClass11_.SvBvU6DODTA);
	}

	private static bool RoundedCorners(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.A3xvUKQHukd = imageFactory;
		return JlQtdztJvl8(paramLine, "RoundedCorners", true, _003C_003Ec__DisplayClass12_.qqbvUmhpBeB);
	}

	private static bool Rotate(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.NcNvUrOsU97 = imageFactory;
		return JlQtdztJvl8(paramLine, "Rotate", true, _003C_003Ec__DisplayClass13_.xXtvUxLwaBd);
	}

	private static bool Resolution(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.EYAvUBB7eb9 = imageFactory;
		return JlQtdztJvl8(paramLine, "Resolution", true, _003C_003Ec__DisplayClass14_.hjwvUpCNrdQ);
	}

	private static bool Resize(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.iGnvUjXSM2q = imageFactory;
		return JlQtdztJvl8(paramLine, "Resize", true, _003C_003Ec__DisplayClass15_.WoVvUQ1FZ25);
	}

	private static bool ResizeEx(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.xa5vU4t5uWG = imageFactory;
		return JlQtdztJvl8(paramLine, "ResizeEx", true, _003C_003Ec__DisplayClass16_.dlVvUnCQH0J);
	}

	private static bool Reset(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.l99vUDc5KgJ = imageFactory;
		return JlQtdztJvl8(paramLine, "Reset", false, _003C_003Ec__DisplayClass17_.ugEvU5DgZEU);
	}

	private static bool ReplaceColor(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.zY7vUoo5pqY = imageFactory;
		return JlQtdztJvl8(paramLine, "ReplaceColor", true, _003C_003Ec__DisplayClass18_.LGhvUdHt1wQ);
	}

	private static bool Pixelate(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.NTmvUMwCVhT = imageFactory;
		return JlQtdztJvl8(paramLine, "Pixelate", true, _003C_003Ec__DisplayClass19_.zaWvUTbvZei);
	}

	private static bool Overlay(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.N06vUOH3Q88 = imageFactory;
		return JlQtdztJvl8(paramLine, "Overlay", true, _003C_003Ec__DisplayClass20_.bInvUA5ewBb);
	}

	private static Rectangle GnQtdi6Nh30(string string_0)
	{
		IList<int> list = string_0.StringToIntList(',');
		return new Rectangle(list[0], list[1], list[2], list[3]);
	}

	private static ImageLayer RHetd3ZJfe2(string string_0)
	{
		string[] array = string_0.Split(';', '；');
		ImageLayer imageLayer = new ImageLayer();
		imageLayer.Image = Image.FromFile(array[0]);
		imageLayer.Position = ((array.Length < 2) ? ((Point?)null) : (string.IsNullOrWhiteSpace(array[1]) ? ((Point?)null) : new Point?(lBmtdf3FgOn(array[1]))));
		imageLayer.Size = ((array.Length < 3 || string.IsNullOrEmpty(array[2])) ? imageLayer.Image.Size : new Size(lBmtdf3FgOn(array[2])));
		imageLayer.Opacity = ((array.Length < 4 || string.IsNullOrWhiteSpace(array[3])) ? 100 : Convert.ToInt32(array[3]));
		return imageLayer;
	}

	private static Point lBmtdf3FgOn(string string_0)
	{
		string[] array = string_0.Split(',', ';');
		return new Point(Convert.ToInt32(array[0].Trim()), Convert.ToInt32(array[1].Trim()));
	}

	private static bool Mask(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.wVkvUUSa7Ic = imageFactory;
		return JlQtdztJvl8(paramLine, "Mask", true, _003C_003Ec__DisplayClass24_.XuivUFKUBkS);
	}

	private static bool Load(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
		_003C_003Ec__DisplayClass25_.P40vUik5OrG = imageFactory;
		return JlQtdztJvl8(paramLine, "Load", true, _003C_003Ec__DisplayClass25_.YopvUlD7wAY);
	}

	public static bool Gamma(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.RnuvUfYs1bs = imageFactory;
		return JlQtdztJvl8(paramLine, "Gamma", true, _003C_003Ec__DisplayClass26_.H71vU3EeHB2);
	}

	public static bool Deskew(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.pD2vlwV60Xa = imageFactory;
		return JlQtdztJvl8(paramLine, "Deskew", false, _003C_003Ec__DisplayClass27_.lD8vUzvxPO2);
	}

	private static bool Hue(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.Fy1vlgj6t39 = imageFactory;
		return JlQtdztJvl8(paramLine, "Hue", true, _003C_003Ec__DisplayClass28_.ycpvltN55jA);
	}

	private static bool GaussianSharpen(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
		_003C_003Ec__DisplayClass29_.vh7vlvYucXF = imageFactory;
		return JlQtdztJvl8(paramLine, "GaussianSharpen", true, _003C_003Ec__DisplayClass29_.ybLvlL7skW4);
	}

	private static bool GaussianBlur(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.d7gvlNpWKLt = imageFactory;
		return JlQtdztJvl8(paramLine, "GaussianBlur", true, _003C_003Ec__DisplayClass30_.JPTvluMRoYl);
	}

	private static bool Flip(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
		_003C_003Ec__DisplayClass31_.iYZvl0yAMy6 = imageFactory;
		return JlQtdztJvl8(paramLine, "Flip", true, _003C_003Ec__DisplayClass31_.vV7vlJy1pSg);
	}

	private static bool Filter(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.O1wvlPVcNK7 = imageFactory;
		return JlQtdztJvl8(paramLine, "Filter", true, _003C_003Ec__DisplayClass32_.LJevlC5GCoI);
	}

	private static bool EntropyCrop(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.JSJvlydnekB = imageFactory;
		return JlQtdztJvl8(paramLine, "EntropyCrop", false, _003C_003Ec__DisplayClass33_.OiTvlESC2Q9);
	}

	private static bool DetectEdges(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_.YofvlabVovd = imageFactory;
		return JlQtdztJvl8(paramLine, "DetectEdges", true, _003C_003Ec__DisplayClass34_.y4Uvl8LZU4h);
	}

	private static bool Crop(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.QI0vlRFUeQO = paramLine;
		_003C_003Ec__DisplayClass35_.YHIvlqMd7wM = imageFactory;
		return JlQtdztJvl8(_003C_003Ec__DisplayClass35_.QI0vlRFUeQO, "Crop", true, _003C_003Ec__DisplayClass35_.p94vl7OdFV7);
	}

	private static bool JlQtdztJvl8(string string_0, string string_1, bool bool_0, Action<string> action_0)
	{
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
		_003C_003Ec__DisplayClass36_.V2CvlVh4X5a = bool_0;
		_003C_003Ec__DisplayClass36_.vMTvlZb00Cb = action_0;
		_003C_003Ec__DisplayClass36_.vdqvl97HPFq = string_0;
		return AppHelper.IfMatchThen(_003C_003Ec__DisplayClass36_.vdqvl97HPFq, string_1 + ":", _003C_003Ec__DisplayClass36_.TQqvlcUsIhw);
	}

	private static bool Contrast(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
		_003C_003Ec__DisplayClass37_.tNevleY6cYl = imageFactory;
		return JlQtdztJvl8(paramLine, "Contrast", true, _003C_003Ec__DisplayClass37_.wXevlhYdK8G);
	}

	private static bool Constrain(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
		_003C_003Ec__DisplayClass38_.NlpvlIg0yN8 = imageFactory;
		return JlQtdztJvl8(paramLine, "Constrain", true, _003C_003Ec__DisplayClass38_.gMNvlYNk0OL);
	}

	private static bool Brightness(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.LDgvlkQTnv2 = imageFactory;
		return JlQtdztJvl8(paramLine, "Brightness", true, _003C_003Ec__DisplayClass39_.JojvlW44OPL);
	}

	private static bool BackgroundColor(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.p5kvl1CgvmG = imageFactory;
		return JlQtdztJvl8(paramLine, "BackgroundColor", true, _003C_003Ec__DisplayClass40_.JCivlHLEnaZ);
	}

	private static bool AutoRotate(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
		_003C_003Ec__DisplayClass41_.GgSvl6a59wD = imageFactory;
		return JlQtdztJvl8(paramLine, "AutoRotate", false, _003C_003Ec__DisplayClass41_.evBvlbqGRcD);
	}

	private static bool Alpha(ImageFactory imageFactory, string paramLine)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.GxZvlmcX7q6 = imageFactory;
		return JlQtdztJvl8(paramLine, "Alpha", true, _003C_003Ec__DisplayClass42_.lV3vlX2fNof);
	}

	[CompilerGenerated]
	internal static IMatrixFilter k8ntowVbmsG(int int_0)
	{
		return int_0 switch
		{
			0 => MatrixFilters.BlackWhite, 
			1 => MatrixFilters.Comic, 
			2 => MatrixFilters.Gotham, 
			3 => MatrixFilters.GreyScale, 
			4 => MatrixFilters.HiSatch, 
			5 => MatrixFilters.Invert, 
			6 => MatrixFilters.Lomograph, 
			7 => MatrixFilters.LoSatch, 
			8 => MatrixFilters.Polaroid, 
			9 => MatrixFilters.Sepia, 
			_ => throw new Exception("Invalid filter index."), 
		};
	}

	internal static bool B5rt9yQqIN6sqPtrsUrV()
	{
		return TlJDt9QqxlqSXBaZ3RRu == null;
	}
}
