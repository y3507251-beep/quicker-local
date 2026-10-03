using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace Quicker.Utilities.Images;

public static class ExifStuff
{
	public enum ExifOrientations : byte
	{
		Unknown,
		TopLeft,
		TopRight,
		BottomRight,
		BottomLeft,
		LeftTop,
		RightTop,
		RightBottom,
		LeftBottom
	}

	public enum ExifPropertyTypes
	{
		Exif_Image_ImageID = 32781,
		Exif_Image_CFARepeatPatternDim = 33421,
		Exif_Image_CFAPattern = 33422,
		Exif_Image_BatteryLevel = 33423,
		Copyright = 33432,
		ExifExposureTime = 33434,
		ExifFNumber = 33437,
		Exif_Image_IPTCNAA = 33723,
		Exif_Image_ImageResources = 34377,
		ExifIFD = 34665,
		ICCProfile = 34675,
		ExifExposureProg = 34850,
		ExifSpectralSense = 34852,
		GpsIFD = 34853,
		ExifISOSpeed = 34855,
		ExifOECF = 34856,
		Exif_Image_Interlace = 34857,
		Exif_Image_TimeZoneOffset = 34858,
		Exif_Image_SelfTimerMode = 34859,
		Exif_Photo_SensitivityType = 34864,
		Exif_Photo_StandardOutputSensitivity = 34865,
		Exif_Photo_RecommendedExposureIndex = 34866,
		Exif_Photo_ISOSpeed = 34867,
		Exif_Photo_ISOSpeedLatitudeyyy = 34868,
		Exif_Photo_ISOSpeedLatitudezzz = 34869,
		ExifVer = 36864,
		ExifDTOrig = 36867,
		ExifDTDigitized = 36868,
		ExifCompConfig = 37121,
		ExifCompBPP = 37122,
		ExifShutterSpeed = 37377,
		ExifAperture = 37378,
		ExifBrightness = 37379,
		ExifExposureBias = 37380,
		ExifMaxAperture = 37381,
		ExifSubjectDist = 37382,
		ExifMeteringMode = 37383,
		ExifLightSource = 37384,
		ExifFlash = 37385,
		ExifFocalLength = 37386,
		Exif_Image_FlashEnergy = 37387,
		Exif_Image_SpatialFrequencyResponse = 37388,
		Exif_Image_Noise = 37389,
		Exif_Image_FocalPlaneXResolution = 37390,
		Exif_Image_FocalPlaneYResolution = 37391,
		Exif_Image_FocalPlaneResolutionUnit = 37392,
		Exif_Image_ImageNumber = 37393,
		Exif_Image_SecurityClassification = 37394,
		Exif_Image_ImageHistory = 37395,
		SubjectArea = 37396,
		Exif_Image_ExposureIndex = 37397,
		Exif_Image_TIFFEPStandardID = 37398,
		Exif_Image_SensingMethod = 37399,
		ExifMakerNote = 37500,
		ExifUserComment = 37510,
		ExifDTSubsec = 37520,
		ExifDTOrigSS = 37521,
		ExifDTDigSS = 37522,
		Exif_Image_XPTitle = 40091,
		Exif_Image_XPComment = 40092,
		Exif_Image_XPAuthor = 40093,
		Exif_Image_XPKeywords = 40094,
		Exif_Image_XPSubject = 40095,
		ExifFPXVer = 40960,
		ExifColorSpace = 40961,
		ExifPixXDim = 40962,
		ExifPixYDim = 40963,
		ExifRelatedWav = 40964,
		ExifInterop = 40965,
		ExifFlashEnergy = 41483,
		ExifSpatialFR = 41484,
		ExifFocalXRes = 41486,
		ExifFocalYRes = 41487,
		ExifFocalResUnit = 41488,
		ExifSubjectLoc = 41492,
		ExifExposureIndex = 41493,
		ExifSensingMethod = 41495,
		ExifFileSource = 41728,
		ExifSceneType = 41729,
		ExifCfaPattern = 41730,
		CustomRendered = 41985,
		ExposureMode = 41986,
		WhiteBalance = 41987,
		DigitalZoomRatio = 41988,
		FocalLengthIn35mmFilm = 41989,
		SceneCaptureType = 41990,
		GainControl = 41991,
		Contrast = 41992,
		Saturation = 41993,
		Sharpness = 41994,
		DeviceSettingDescription = 41995,
		SubjectDistanceRange = 41996,
		ImageUniqueID = 42016,
		Exif_Photo_CameraOwnerName = 42032,
		Exif_Photo_BodySerialNumber = 42033,
		Exif_Photo_LensSpecification = 42034,
		Exif_Photo_LensMake = 42035,
		Exif_Photo_LensModel = 42036,
		Exif_Photo_LensSerialNumber = 42037,
		Exif_Image_PrintImageMatching = 50341,
		Exif_Image_DNGVersion = 50706,
		Exif_Image_DNGBackwardVersion = 50707,
		Exif_Image_UniqueCameraModel = 50708,
		Exif_Image_LocalizedCameraModel = 50709,
		Exif_Image_CFAPlaneColor = 50710,
		Exif_Image_CFALayout = 50711,
		Exif_Image_LinearizationTable = 50712,
		Exif_Image_BlackLevelRepeatDim = 50713,
		Exif_Image_BlackLevel = 50714,
		Exif_Image_BlackLevelDeltaH = 50715,
		Exif_Image_BlackLevelDeltaV = 50716,
		Exif_Image_WhiteLevel = 50717,
		Exif_Image_DefaultScale = 50718,
		Exif_Image_DefaultCropOrigin = 50719,
		Exif_Image_DefaultCropSize = 50720,
		Exif_Image_ColorMatrix1 = 50721,
		Exif_Image_ColorMatrix2 = 50722,
		Exif_Image_CameraCalibration1 = 50723,
		Exif_Image_CameraCalibration2 = 50724,
		Exif_Image_ReductionMatrix1 = 50725,
		Exif_Image_ReductionMatrix2 = 50726,
		Exif_Image_AnalogBalance = 50727,
		Exif_Image_AsShotNeutral = 50728,
		Exif_Image_AsShotWhiteXY = 50729,
		Exif_Image_BaselineExposure = 50730,
		Exif_Image_BaselineNoise = 50731,
		Exif_Image_BaselineSharpness = 50732,
		Exif_Image_BayerGreenSplit = 50733,
		Exif_Image_LinearResponseLimit = 50734,
		Exif_Image_CameraSerialNumber = 50735,
		Exif_Image_LensInfo = 50736,
		Exif_Image_ChromaBlurRadius = 50737,
		Exif_Image_AntiAliasStrength = 50738,
		Exif_Image_ShadowScale = 50739,
		Exif_Image_DNGPrivateData = 50740,
		Exif_Image_MakerNoteSafety = 50741,
		Exif_Image_CalibrationIlluminant1 = 50778,
		Exif_Image_CalibrationIlluminant2 = 50779,
		Exif_Image_BestQualityScale = 50780,
		Exif_Image_RawDataUniqueID = 50781,
		Exif_Image_OriginalRawFileName = 50827,
		Exif_Image_OriginalRawFileData = 50828,
		Exif_Image_ActiveArea = 50829,
		Exif_Image_MaskedAreas = 50830,
		Exif_Image_AsShotICCProfile = 50831,
		Exif_Image_AsShotPreProfileMatrix = 50832,
		Exif_Image_CurrentICCProfile = 50833,
		Exif_Image_CurrentPreProfileMatrix = 50834,
		Exif_Image_ColorimetricReference = 50879,
		Exif_Image_CameraCalibrationSignature = 50931,
		Exif_Image_ProfileCalibrationSignature = 50932,
		Exif_Image_AsShotProfileName = 50934,
		Exif_Image_NoiseReductionApplied = 50935,
		Exif_Image_ProfileName = 50936,
		Exif_Image_ProfileHueSatMapDims = 50937,
		Exif_Image_ProfileHueSatMapData1 = 50938,
		Exif_Image_ProfileHueSatMapData2 = 50939,
		Exif_Image_ProfileToneCurve = 50940,
		Exif_Image_ProfileEmbedPolicy = 50941,
		Exif_Image_ProfileCopyright = 50942,
		Exif_Image_ForwardMatrix1 = 50964,
		Exif_Image_ForwardMatrix2 = 50965,
		Exif_Image_PreviewApplicationName = 50966,
		Exif_Image_PreviewApplicationVersion = 50967,
		Exif_Image_PreviewSettingsName = 50968,
		Exif_Image_PreviewSettingsDigest = 50969,
		Exif_Image_PreviewColorSpace = 50970,
		Exif_Image_PreviewDateTime = 50971,
		Exif_Image_RawImageDigest = 50972,
		Exif_Image_OriginalRawFileDigest = 50973,
		Exif_Image_SubTileBlockSize = 50974,
		Exif_Image_RowInterleaveFactor = 50975,
		Exif_Image_ProfileLookTableDims = 50981,
		Exif_Image_ProfileLookTableData = 50982,
		Exif_Image_OpcodeList1 = 51008,
		Exif_Image_OpcodeList2 = 51009,
		Exif_Image_OpcodeList3 = 51022,
		Exif_Image_NoiseProfile = 51041,
		GpsVer = 0,
		GpsLatitudeRef = 1,
		GpsLatitude = 2,
		GpsLongitudeRef = 3,
		GpsLongitude = 4,
		GpsAltitudeRef = 5,
		GpsAltitude = 6,
		GpsGpsTime = 7,
		GpsGpsSatellites = 8,
		GpsGpsStatus = 9,
		GpsGpsMeasureMode = 10,
		GpsGpsDop = 11,
		GpsSpeedRef = 12,
		GpsSpeed = 13,
		GpsTrackRef = 14,
		GpsTrack = 15,
		GpsImgDirRef = 16,
		GpsImgDir = 17,
		GpsMapDatum = 18,
		GpsDestLatRef = 19,
		GpsDestLat = 20,
		GpsDestLongRef = 21,
		GpsDestLong = 22,
		GpsDestBearRef = 23,
		GpsDestBear = 24,
		GpsDestDistRef = 25,
		GpsDestDist = 26,
		Exif_GPSInfo_GPSProcessingMethod = 27,
		Exif_GPSInfo_GPSAreaInformation = 28,
		Exif_GPSInfo_GPSDateStamp = 29,
		Exif_GPSInfo_GPSDifferential = 30,
		NewSubfileType = 254,
		SubfileType = 255,
		ImageWidth = 256,
		ImageHeight = 257,
		BitsPerSample = 258,
		Compression = 259,
		PhotometricInterp = 262,
		ThreshHolding = 263,
		CellWidth = 264,
		CellHeight = 265,
		FillOrder = 266,
		DocumentName = 269,
		ImageDescription = 270,
		EquipMake = 271,
		EquipModel = 272,
		StripOffsets = 273,
		Orientation = 274,
		SamplesPerPixel = 277,
		RowsPerStrip = 278,
		StripBytesCount = 279,
		MinSampleValue = 280,
		MaxSampleValue = 281,
		XResolution = 282,
		YResolution = 283,
		PlanarConfig = 284,
		PageName = 285,
		XPosition = 286,
		YPosition = 287,
		FreeOffset = 288,
		FreeByteCounts = 289,
		GrayResponseUnit = 290,
		GrayResponseCurve = 291,
		T4Option = 292,
		T6Option = 293,
		ResolutionUnit = 296,
		PageNumber = 297,
		TransferFunction = 301,
		SoftwareUsed = 305,
		DateTime = 306,
		Artist = 315,
		HostComputer = 316,
		Predictor = 317,
		WhitePoint = 318,
		PrimaryChromaticities = 319,
		ColorMap = 320,
		HalftoneHints = 321,
		TileWidth = 322,
		TileLength = 323,
		TileOffset = 324,
		TileByteCounts = 325,
		Exif_Image_SubIFDs = 330,
		InkSet = 332,
		InkNames = 333,
		NumberOfInks = 334,
		DotRange = 336,
		TargetPrinter = 337,
		ExtraSamples = 338,
		SampleFormat = 339,
		SMinSampleValue = 340,
		SMaxSampleValue = 341,
		TransferRange = 342,
		Exif_Image_ClipPath = 343,
		Exif_Image_XClipPathUnits = 344,
		Exif_Image_YClipPathUnits = 345,
		Exif_Image_Indexed = 346,
		Exif_Image_JPEGTables = 347,
		Exif_Image_OPIProxy = 351,
		JPEGProc = 512,
		JPEGInterFormat = 513,
		JPEGInterLength = 514,
		JPEGRestartInterval = 515,
		JPEGLosslessPredictors = 517,
		JPEGPointTransforms = 518,
		JPEGQTables = 519,
		JPEGDCTables = 520,
		JPEGACTables = 521,
		YCbCrCoefficients = 529,
		YCbCrSubsampling = 530,
		YCbCrPositioning = 531,
		REFBlackWhite = 532,
		Exif_Image_XMLPacket = 700,
		Gamma = 769,
		ICCProfileDescriptor = 770,
		SRGBRenderingIntent = 771,
		ImageTitle = 800,
		Exif_Iop_RelatedImageFileFormat = 4096,
		Exif_Iop_RelatedImageWidth = 4097,
		Exif_Iop_RelatedImageLength = 4098,
		Exif_Image_Rating = 18246,
		Exif_Image_RatingPercent = 18249,
		ResolutionXUnit = 20481,
		ResolutionYUnit = 20482,
		ResolutionXLengthUnit = 20483,
		ResolutionYLengthUnit = 20484,
		PrintFlags = 20485,
		PrintFlagsVersion = 20486,
		PrintFlagsCrop = 20487,
		PrintFlagsBleedWidth = 20488,
		PrintFlagsBleedWidthScale = 20489,
		HalftoneLPI = 20490,
		HalftoneLPIUnit = 20491,
		HalftoneDegree = 20492,
		HalftoneShape = 20493,
		HalftoneMisc = 20494,
		HalftoneScreen = 20495,
		JPEGQuality = 20496,
		GridSize = 20497,
		ThumbnailFormat = 20498,
		ThumbnailWidth = 20499,
		ThumbnailHeight = 20500,
		ThumbnailColorDepth = 20501,
		ThumbnailPlanes = 20502,
		ThumbnailRawBytes = 20503,
		ThumbnailSize = 20504,
		ThumbnailCompressedSize = 20505,
		ColorTransferFunction = 20506,
		ThumbnailData = 20507,
		ThumbnailImageWidth = 20512,
		ThumbnailImageHeight = 20513,
		ThumbnailBitsPerSample = 20514,
		ThumbnailCompression = 20515,
		ThumbnailPhotometricInterp = 20516,
		ThumbnailImageDescription = 20517,
		ThumbnailEquipMake = 20518,
		ThumbnailEquipModel = 20519,
		ThumbnailStripOffsets = 20520,
		ThumbnailOrientation = 20521,
		ThumbnailSamplesPerPixel = 20522,
		ThumbnailRowsPerStrip = 20523,
		ThumbnailStripBytesCount = 20524,
		ThumbnailResolutionX = 20525,
		ThumbnailResolutionY = 20526,
		ThumbnailPlanarConfig = 20527,
		ThumbnailResolutionUnit = 20528,
		ThumbnailTransferFunction = 20529,
		ThumbnailSoftwareUsed = 20530,
		ThumbnailDateTime = 20531,
		ThumbnailArtist = 20532,
		ThumbnailWhitePoint = 20533,
		ThumbnailPrimaryChromaticities = 20534,
		ThumbnailYCbCrCoefficients = 20535,
		ThumbnailYCbCrSubsampling = 20536,
		ThumbnailYCbCrPositioning = 20537,
		ThumbnailRefBlackWhite = 20538,
		ThumbnailCopyRight = 20539,
		LuminanceTable = 20624,
		ChrominanceTable = 20625,
		FrameDelay = 20736,
		LoopCount = 20737,
		GlobalPalette = 20738,
		IndexBackground = 20739,
		IndexTransparent = 20740,
		PixelUnit = 20752,
		PixelPerUnitX = 20753,
		PixelPerUnitY = 20754,
		PaletteHistogram = 20755
	}

	public enum ExifPropertyDataTypes : short
	{
		ByteArray = 1,
		String = 2,
		UShortArray = 3,
		ULongArray = 4,
		ULongFractionArray = 5,
		UByteArray = 6,
		LongArray = 7,
		LongFractionArray = 10
	}

	public struct ExifPropertyData
	{
		public int Id;

		public ExifPropertyTypes PropertyType;

		public ExifPropertyDataTypes DataType;

		public byte[] DataBuffer;

		public int DataLength;

		public string DataString;
	}

	internal static object ISBV22cVPJlOJdYtRfFd;

	public static ExifOrientations ImageOrientation(Image img)
	{
		if (Array.IndexOf(img.PropertyIdList, 274) < 0)
		{
			return ExifOrientations.Unknown;
		}
		return (ExifOrientations)img.GetPropertyItem(274).Value[0];
	}

	public static void OrientImage(Image img)
	{
		switch (ImageOrientation(img))
		{
		case ExifOrientations.TopRight:
			img.RotateFlip(RotateFlipType.RotateNoneFlipX);
			break;
		case ExifOrientations.BottomRight:
			img.RotateFlip(RotateFlipType.Rotate180FlipNone);
			break;
		case ExifOrientations.BottomLeft:
			img.RotateFlip(RotateFlipType.Rotate180FlipX);
			break;
		case ExifOrientations.LeftTop:
			img.RotateFlip(RotateFlipType.Rotate90FlipX);
			break;
		case ExifOrientations.RightTop:
			img.RotateFlip(RotateFlipType.Rotate90FlipNone);
			break;
		case ExifOrientations.RightBottom:
			img.RotateFlip(RotateFlipType.Rotate270FlipX);
			break;
		case ExifOrientations.LeftBottom:
			img.RotateFlip(RotateFlipType.Rotate270FlipNone);
			break;
		}
		SetImageOrientation(img, ExifOrientations.TopLeft);
	}

	public static void SetImageOrientation(Image img, ExifOrientations orientation)
	{
		if (Array.IndexOf(img.PropertyIdList, 274) >= 0)
		{
			PropertyItem propertyItem = img.GetPropertyItem(274);
			propertyItem.Value[0] = (byte)orientation;
			img.SetPropertyItem(propertyItem);
		}
	}

	private static ExifPropertyData LNvvNIvhPsX(Image image_0, int int_0)
	{
		int num = 9;
		string text = default(string);
		int num4 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		uint num8 = default(uint);
		while (true)
		{
			ExifPropertyData result = default(ExifPropertyData);
			while (true)
			{
				IL_019b:
				result.Id = image_0.PropertyIdList[int_0];
				result.PropertyType = (ExifPropertyTypes)result.Id;
				PropertyItem propertyItem = image_0.PropertyItems[int_0];
				result.DataBuffer = propertyItem.Value;
				result.DataType = (ExifPropertyDataTypes)propertyItem.Type;
				int num2 = 4;
				if (!yM5grycVMmD4v5MoFf6g())
				{
					goto IL_00b3;
				}
				goto IL_016c;
				IL_016c:
				while (true)
				{
					switch (num2)
					{
					case 7:
						break;
					case 4:
						goto IL_00b3;
					default:
						do
						{
							num4 = 4;
							num2 = 6;
						}
						while (!yM5grycVMmD4v5MoFf6g());
						continue;
					case 8:
						goto IL_019b;
					case 9:
						goto end_IL_019b;
					case 2:
						goto IL_029e;
					case 3:
						goto IL_02f7;
					case 6:
					{
						num3 = result.DataLength / num4;
						for (int i = 0; i < num3; i++)
						{
							text = text + ", " + BitConverter.ToInt32(result.DataBuffer, i * num4);
						}
						if (text.Length > 0)
						{
							text = text.Substring(2);
						}
						result.DataString = text;
						goto IL_040d;
					}
					case 1:
					case 5:
						goto IL_040d;
					}
					break;
				}
				goto IL_0027;
				IL_00b3:
				result.DataLength = propertyItem.Len;
				text = "";
				switch (result.DataType)
				{
				case ExifPropertyDataTypes.ULongFractionArray:
					break;
				case ExifPropertyDataTypes.ByteArray:
				case ExifPropertyDataTypes.UByteArray:
					goto IL_0124;
				case ExifPropertyDataTypes.LongArray:
					goto IL_0141;
				case ExifPropertyDataTypes.String:
					result.DataString = Encoding.UTF8.GetString(result.DataBuffer, 0, result.DataLength - 1);
					goto IL_040d;
				case ExifPropertyDataTypes.UShortArray:
					goto IL_0221;
				case ExifPropertyDataTypes.ULongArray:
				{
					text = "";
					num4 = 4;
					num3 = result.DataLength / 4;
					for (int k = 0; k < num3; k++)
					{
						text = text + ", " + BitConverter.ToUInt32(result.DataBuffer, k * num4);
					}
					if (text.Length > 0)
					{
						text = text.Substring(2);
					}
					result.DataString = text;
					goto IL_040d;
				}
				case ExifPropertyDataTypes.LongFractionArray:
				{
					text = "";
					num4 = 8;
					num3 = result.DataLength / 8;
					for (int j = 0; j < num3; j++)
					{
						int num5 = BitConverter.ToInt32(result.DataBuffer, j * num4);
						int num6 = BitConverter.ToInt32(result.DataBuffer, j * num4 + num4 / 2);
						text = text + ", " + num5 + "/" + num6;
					}
					if (text.Length > 0)
					{
						text = text.Substring(2);
					}
					result.DataString = text;
					goto IL_040d;
				}
				default:
					goto IL_040d;
				}
				text = "";
				num4 = 8;
				num3 = result.DataLength / 8;
				num7 = 0;
				goto IL_000e;
				IL_0221:
				text = "";
				num4 = 2;
				goto IL_029e;
				IL_0141:
				text = "";
				num2 = 0;
				if (!yM5grycVMmD4v5MoFf6g())
				{
					goto IL_00aa;
				}
				goto IL_016c;
				IL_0124:
				result.DataString = "NOT_SUPPORTED";
				num2 = 5;
				if (ISBV22cVPJlOJdYtRfFd == null)
				{
					goto IL_016c;
				}
				goto IL_029e;
				IL_029e:
				num3 = result.DataLength / num4;
				for (int l = 0; l < num3; l++)
				{
					text = text + ", " + BitConverter.ToUInt16(result.DataBuffer, l * num4);
				}
				if (text.Length > 0)
				{
					text = text.Substring(2);
				}
				goto IL_02f7;
				IL_000e:
				if (num7 < num3)
				{
					num8 = BitConverter.ToUInt32(result.DataBuffer, num7 * num4);
					goto IL_0027;
				}
				if (text.Length > 0)
				{
					text = text.Substring(2);
				}
				result.DataString = text;
				num2 = 1;
				if (!yM5grycVMmD4v5MoFf6g())
				{
					goto IL_00aa;
				}
				goto IL_016c;
				IL_0027:
				uint num9 = BitConverter.ToUInt32(result.DataBuffer, num7 * num4 + num4 / 2);
				text = text + ", " + num8 + "/" + num9;
				num7++;
				goto IL_000e;
				IL_00aa:
				num2 = num;
				goto IL_016c;
				IL_02f7:
				result.DataString = text;
				goto IL_040d;
				IL_040d:
				return result;
				continue;
				end_IL_019b:
				break;
			}
		}
	}

	public static List<ExifPropertyData> GetExifProperties(Image img)
	{
		List<ExifPropertyData> list = new List<ExifPropertyData>();
		for (int i = 0; i < img.PropertyIdList.Length; i++)
		{
			list.Add(LNvvNIvhPsX(img, i));
		}
		return list;
	}

	internal static bool yM5grycVMmD4v5MoFf6g()
	{
		return ISBV22cVPJlOJdYtRfFd == null;
	}
}
