using BepInEx;
using BepInEx.IL2CPP;
using UnityEngine;
using HarmonyLib;
using UnhollowerBaseLib;

namespace ExtraColors {
	[BepInPlugin("en.bossgamer.excolors", "ExtraColors", "1.3")]
	public class ExtraColors : BasePlugin {
		public override void Load() {
			var array = new[] {
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
			};
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
				new Color32(73, 96, 34, byte.MaxValue)
			};
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
				new Color32(73, 96, 34, byte.MaxValue),
				new Color32(97, 145, 23, byte.MaxValue),
				new Color32(25, 23, 145, byte.MaxValue),
				new Color32(61, 255, 181, byte.MaxValue)
			};
			Palette.ColorNames = array;
			Palette.PlayerColors = array2;
			Palette.ShadowColors = array3;
		}
	}

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
			}
		return true;
		}
	}

	[HarmonyPatch]
        public static class CustomColorPatches {
		public static uint pickableColors = 22;
            [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString), new[] {
                typeof(StringNames),
                typeof(Il2CppReferenceArray<Il2CppSystem.Object>)
            })]

            [HarmonyPatch(typeof(PlayerTab), nameof(PlayerTab.OnEnable))]
            private static class PlayerTabEnablePatch {
                public static void Postfix(PlayerTab __instance) { 
                    Il2CppArrayBase<ColorChip> chips = __instance.ColorChips.ToArray();
                    int cols = 4; 
                    for (int i = 0; i < chips.Length; i++) {
                        ColorChip chip = chips[i];
                        int row = i / cols, col = i % cols; 
                        chip.transform.localPosition = new Vector3(1.46f + (col * 0.6f), -0.43f - (row * 0.55f), chip.transform.localPosition.z);
                        chip.transform.localScale *= 0.9f;

                        if (i >= pickableColors) 
                            chip.transform.localScale *= 0f; 
                    }
                }
            }
            [HarmonyPatch(typeof(SaveManager), nameof(SaveManager.LoadPlayerPrefs))]
            private static class LoadPlayerPrefsPatch { 
                private static bool needsPatch = false;
                public static void Prefix([HarmonyArgument(0)] bool overrideLoad) {
                    if (!SaveManager.loaded || overrideLoad)
                        needsPatch = true;
                }
                public static void Postfix() {
                    if (!needsPatch) return;
                    SaveManager.colorConfig %= pickableColors;
                    needsPatch = false;
                }
            }
            [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CheckColor))]
            private static class PlayerControlCheckColorPatch {
                private static bool isTaken(PlayerControl player, uint color) {
                    foreach (GameData.PlayerInfo p in GameData.Instance.AllPlayers)
                        if (!p.Disconnected && p.PlayerId != player.PlayerId && p.ColorId == color)
                            return true;
                    return false;
                }
                public static bool Prefix(PlayerControl __instance, [HarmonyArgument(0)] byte bodyColor) { 
                    uint color = (uint)bodyColor;
                   if (isTaken(__instance, color) || color >= Palette.PlayerColors.Length) {
                        int num = 0;
                        while (num++ < 50 && (color >= pickableColors || isTaken(__instance, color))) {
                            color = (color + 1) % pickableColors;
                        }
                    }
                    __instance.RpcSetColor((byte)color);
                    return false;
                }
            }
        }
}
