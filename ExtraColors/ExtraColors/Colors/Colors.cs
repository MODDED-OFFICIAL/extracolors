using BepInEx;
using BepInEx.IL2CPP;
using UnityEngine;
using HarmonyLib;
using UnhollowerBaseLib;

namespace ExtraColors.Colors {
	[BepInPlugin("en.bossgamer.excolors", "ExtraColors", "1.7")]
	public class ExtraColors : BasePlugin {
		public override void Load() {
			var array = new[] {
				// Default Colours
				StringNames.VitalsRED,
			    StringNames.VitalsBLUE,
			    StringNames.VitalsGRN,
			    StringNames.VitalsPINK,
			    StringNames.VitalsORGN,
			    StringNames.VitalsYLOW,
			    StringNames.VitalsBLAK,
			    StringNames.VitalsWHTE,
			    StringNames.VitalsPURP,
			    StringNames.VitalsBRWN,
			    StringNames.VitalsCYAN,
			    StringNames.VitalsLIME,
				// Custom Colours
			    (StringNames)999991,
			    (StringNames)999992,
			    (StringNames)999993,
			    (StringNames)999994,
			    (StringNames)999995,
			    (StringNames)999996,
			    (StringNames)999997,
			    (StringNames)999998,
			    (StringNames)999999,
			    (StringNames)1000000,
			    (StringNames)1000001,
			    (StringNames)1000002,
			    (StringNames)1000003,
			    (StringNames)1000004,
			    (StringNames)1000005,
			    (StringNames)1000006,
			    (StringNames)1000007,
			    (StringNames)1000008,
			    (StringNames)1000009,
			    (StringNames)1000010,
			    (StringNames)1000011,
			    (StringNames)1000012,
			    (StringNames)1000013,
			    (StringNames)1000014,
			    (StringNames)1000015,
			    (StringNames)1000016,
			    (StringNames)1000017,
			    (StringNames)1000018,
			    (StringNames)1000019,
			    (StringNames)1000020,
			    (StringNames)1000021,
			    (StringNames)1000022,
			    (StringNames)1000023,
			    (StringNames)1000024,
			    (StringNames)1000025,
			    (StringNames)1000026,
			    (StringNames)1000027,
			    (StringNames)1000028,
			    (StringNames)1000029,
				(StringNames)1000030,
				(StringNames)1000031,
				(StringNames)1000032,
			};
			// Register Colour MAIN
			Color32[] array2 = new Color32[] {
				new Color32(198, 17, 17, byte.MaxValue),
				new Color32(19, 46, 210, byte.MaxValue),
				new Color32(17, 128, 45, byte.MaxValue),
				new Color32(238, 84, 187, byte.MaxValue),
				new Color32(240, 125, 13, byte.MaxValue),
				new Color32(246, 246, 87, byte.MaxValue),
				new Color32(63, 71, 78, byte.MaxValue),
				new Color32(215, 225, 241, byte.MaxValue),
				new Color32(107, 47, 188, byte.MaxValue),
				new Color32(113, 73, 30, byte.MaxValue),
				new Color32(56, byte.MaxValue, 221, byte.MaxValue),
				new Color32(80, 240, 57, byte.MaxValue),
				new Color32(168, 50, 62, byte.MaxValue),
				new Color32(60, 48, 44, byte.MaxValue),
				new Color32(61, 129, 255, byte.MaxValue),
				new Color32(240, 211, 165, byte.MaxValue),
				new Color32(236, 61, 255, byte.MaxValue),
				new Color32(153, 0, 0, byte.MaxValue),
				new Color32(0, 0, 0, byte.MaxValue),
				new Color32(81, 145, 131, byte.MaxValue),
				new Color32(97, 145, 23, byte.MaxValue),
				new Color32(25, 23, 145, byte.MaxValue),
				new Color32(0, 255, 255, byte.MaxValue),
				new Color32(255, 255, 0, byte.MaxValue),
				new Color32(16, 145, 16, byte.MaxValue),
				new Color32(255, 115, 0, byte.MaxValue),
				new Color32(144, 0, 255, byte.MaxValue),
				new Color32(255, 255, 255, byte.MaxValue),
				new Color32(0, 255, 0, byte.MaxValue),
				new Color32(0, 0, 255, byte.MaxValue),
				new Color32(55, 0, 55, byte.MaxValue),
				new Color32(55, 0, 0, byte.MaxValue),
				new Color32(0, 0, 55, byte.MaxValue),
				new Color32(20, 0, 100, byte.MaxValue),
				new Color32(100, 30, 10, byte.MaxValue),
				new Color32(0, 255, 0, byte.MaxValue),
				new Color32(0, 0, 255, byte.MaxValue),
				new Color32(255, 0, 0, byte.MaxValue),
				new Color32(45, 56, 194, byte.MaxValue),
				new Color32(234, 45, 43, byte.MaxValue),
				new Color32(65, 56, 193, byte.MaxValue),
				new Color32(183, 49, 60, byte.MaxValue),
				new Color32(100, 40, 100, byte.MaxValue),
				new Color32(255, 60, 255, byte.MaxValue),
				new Color32(50, 40, 50, byte.MaxValue),
				new Color32(90, 40, 50, byte.MaxValue),
				new Color32(54, 207, 89, byte.MaxValue),
				new Color32(63, 141, 145, byte.MaxValue),
				new Color32(25, 25, 25, byte.MaxValue),
				new Color32(91, 90, 92, byte.MaxValue),
				new Color32(91, 90, 255, byte.MaxValue),
				new Color32(155, 156, 145, byte.MaxValue)

			};
			// Register Colour SHADOWS
			Color32[] array3 = new Color32[] {
				new Color32(122, 8, 56, byte.MaxValue),
				new Color32(9, 21, 142, byte.MaxValue),
				new Color32(10, 77, 46, byte.MaxValue),
				new Color32(172, 43, 174, byte.MaxValue),
				new Color32(180, 62, 21, byte.MaxValue),
				new Color32(195, 136, 34, byte.MaxValue),
				new Color32(30, 31, 38, byte.MaxValue),
				new Color32(132, 149, 192, byte.MaxValue),
				new Color32(59, 23, 124, byte.MaxValue),
				new Color32(94, 38, 21, byte.MaxValue),
				new Color32(36, 169, 191, byte.MaxValue),
				new Color32(21, 168, 66, byte.MaxValue),
				new Color32(168, 50, 62, byte.MaxValue),
				new Color32(60, 48, 44, byte.MaxValue),
				new Color32(61, 129, 255, byte.MaxValue),
				new Color32(240, 211, 165, byte.MaxValue),
				new Color32(236, 61, 255, byte.MaxValue),
				new Color32(153, 0, 0, byte.MaxValue),
				new Color32(0, 0, 0, byte.MaxValue),
				new Color32(81, 145, 131, byte.MaxValue),
				new Color32(97, 145, 23, byte.MaxValue),
				new Color32(25, 23, 145, byte.MaxValue),
				new Color32(61, 255, 181, byte.MaxValue),
				new Color32(0, 255, 255, byte.MaxValue),
				new Color32(16, 145, 16, byte.MaxValue),
				new Color32(255, 115, 0, byte.MaxValue),
				new Color32(144, 0, 255, byte.MaxValue),
				new Color32(255, 255, 255, byte.MaxValue),
				new Color32(0, 255, 0, byte.MaxValue),
				new Color32(255, 0, 255, byte.MaxValue),
				new Color32(55, 0, 55, byte.MaxValue),
				new Color32(55, 0, 0, byte.MaxValue),
				new Color32(0, 0, 55, byte.MaxValue),
				new Color32(20, 0, 100, byte.MaxValue),
				new Color32(100, 30, 10, byte.MaxValue),
				new Color32(0, 255, 0, byte.MaxValue),
				new Color32(255, 0, 0, byte.MaxValue),
				new Color32(0, 0, 255, byte.MaxValue),
				new Color32(45, 56, 194, byte.MaxValue),
				new Color32(234, 45, 43, byte.MaxValue),
				new Color32(65, 56, 193, byte.MaxValue),
				new Color32(183, 49, 60, byte.MaxValue),
				new Color32(40, 100, 40, byte.MaxValue),
				new Color32(60, 255, 60, byte.MaxValue),
 				new Color32(40, 50, 40, byte.MaxValue),
				new Color32(90, 40, 90, byte.MaxValue),
				new Color32(54, 207, 89, byte.MaxValue),
				new Color32(63, 141, 145, byte.MaxValue),
				new Color32(25, 25, 25, byte.MaxValue),
				new Color32(91, 90, 92, byte.MaxValue),
				new Color32(91, 90, 255, byte.MaxValue),
				new Color32(134, 184, 145, byte.MaxValue)
			};
			// Add to lisr
			Palette.ColorNames = array;
			Palette.PlayerColors = array2;
			Palette.ShadowColors = array3;
		}
	}
	// Colour names
	[HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString),
        new[] {typeof(StringNames), typeof(Il2CppReferenceArray<Il2CppSystem.Object>)})]
    public class PatchColours {
        public static bool Prefix (ref string __result, [HarmonyArgument(0)] StringNames name) {
            switch ((int)name) {
                case 999991:
                    __result = "MELON";
                    return false;
                case 999992:
                    __result = "POOP";
                    return false;
                case 999993:
                    __result = "LTBLUE";
                    return false;
                case 999994:
                    __result = "BEIGE";
                    return false;
                case 999995:
                    __result = "LTPNK";
                    return false;
				case 999996:
                    __result = "CHELOU";
                    return false;
				case 990000:
                    __result = "SUS";
                    return false;
				case 000000:
                    __result = "JBLACK";
                    return false;
				case 519183:
                    __result = "OLIVE";
                    return false;
				case 506022:
                    __result = "SDGREEN";
                    return false;
				case 619117:
                    __result = "SDGREEN";
                    return false;
				case 191791:
                    __result = "NBLUE";
                    return false;
				case 846683:
                    __result = "BORANG";
                    return false;
				case 385648:
                    __result = "VYGJKH";
                    return false;
				case 191794:
                    __result = "VLOT";
                    return false;
				case 191594:
                    __result = "VLOTT";
                    return false;
				case 291494:
                    __result = "VLTRS";
                    return false;
				case 251464:
                    __result = "VLTES";
                    return false;
				case 457464:
                    __result = "UTJT";
                    return false;
				case 455464:
                    __result = "UTJF";
                    return false;
				case 556464:
                    __result = "UTJP";
                    return false;
				case 937584:
                    __result = "TJTJ";
                    return false;
				case 476878:
                    __result = "USJP";
                    return false;
				case 947678:
                    __result = "TJIP";
                    return false;
				case 947658:
                    __result = "TJRH";
                    return false;
				case 546778:
                    __result = "TJIT";
                    return false;
				case 545778:
                    __result = "LGHD";
                    return false;
				case 546768:
                    __result = "FIVH";
                    return false;
				case 546568:
                    __result = "DGGD";
                    return false;
				case 545478:
                    __result = "ABCG";
                    return false;
				case 123457:
                    __result = "RNAB";
                    return false;
				case 123458:
                    __result = "RNCD";
                    return false;
				case 123459:
                    __result = "RNEF";
                    return false;
				case 123460:
                    __result = "RNGH";
                    return false;
				case 185647:
                    __result = "UGVH";
                    return false;
				case 275746:
                    __result = "MINT";
                    return false;
				case 285648:
                    __result = "OCEN";
                    return false;
				case 278445:
					__result = "TEDH";
					return false;
				case 945374:
					__result = "TEDL";
					return false;
				case 757685:
					__result = "GYUS";
					return false;
				case 123765:
					__result = "GYUB";
					return false;
			}
		return true;
		}
	}
}