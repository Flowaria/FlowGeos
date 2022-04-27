using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace FlowGeos
{
    [BepInPlugin("FlowGeos", "FlowGeos", "1.0.0")]
    public class EntryPoint : BasePlugin
    {
        // The method that gets called when BepInEx tries to load our plugin
        public override void Load()
        {
            // Creates a new harmony instance to allow for patching into methods
            m_Harmony = new Harmony("FlowGeos");
            // Apply all patches in the current assembly
            m_Harmony.PatchAll();

            // Log to the console that we have applied all patches
            FlowGeosLogger.Verbose($"Applied all patches!");
        }

        private Harmony m_Harmony;
    }
}
