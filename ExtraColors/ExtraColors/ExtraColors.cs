using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using BepInEx.Logging;
using Reactor;
using Reactor.Patches;

namespace ExtraColors
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class ExtraColors : BasePlugin
    {
        public const string Id = "boss.gamer.yt";

        public Harmony Harmony { get; } = new Harmony(Id);
        public static ManualLogSource log;


        public override void Load()
        {
            log = Log;
            
            log.LogMessage("Extra Colors Mod loaded");
            log.LogMessage("BossAPI is suggested for less bugs");

            ReactorVersionShower.TextUpdated += (text) =>
            {
                int index = text.text.LastIndexOf('\n');
                text.text = text.text.Insert(index == -1 ? text.text.Length - 1 : index, 
				// Main Menu Credits
                    "\n \n \n \n \n \n \n<color=#39db23>Extra-Colors by Boss_GamerYT#0097</color> \n<color=#a34198>Version: v1.7.3</color> <color=#2ddb12>Release</color> \n<color=#2294E6FF>Colors: 40</color>");
            };
            
            Harmony.PatchAll();
        }
    }
}