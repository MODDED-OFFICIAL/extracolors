using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using BepInEx.Logging;
using Reactor;
using Reactor.Patches;

namespace ExtraColors.ColorsPatch
{


        [HarmonyPatch(typeof(PlayerTab), "OnEnable")]
        public static class PLAYERPATCH
        {

            public static void Postfix(PlayerTab __instance)
            {
                var PlayerTab = __instance;

                foreach (var colorChip in PlayerTab.ColorChips)
                    GameObject.Destroy(colorChip.gameObject);

                PlayerTab.ColorChips.Clear();

                for (var i = 0; i < Palette.PlayerColors.Length; i++)
                {

                    var _ = -0.935f + (i % 5 * 0.51f);
                    var __ = 1.65f - (i / 5 * 0.34f);

                    var ca = GameObject.Instantiate(PlayerTab.ColorTabPrefab, PlayerTab.ColorTabArea, true);
                    ca.Inner.transform.localScale *= 0.68f;
                    ca.Inner.transform.localPosition = new Vector3(_, __, -1f);

                    var j = i;
                    ca.Button.OnClick.AddListener((Action)delegate
                    {
                        PlayerTab.SelectColor(j);
                    });

                    ca.Inner.color = Palette.PlayerColors[i];
                    PlayerTab.ColorChips.Add(ca);
                }
            }
        }


        [HarmonyPatch(typeof(PlayerTab), "SelectColor")]
        public static class HATS
        {
            public static void Postfix(PlayerTab __instance, [HarmonyArgument(0)] int selectId)
            {
                var PlayerTab = __instance;
                PlayerTab.HatImage.SetColor(selectId);
            }
        }
}

