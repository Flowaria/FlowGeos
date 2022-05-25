using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace FlowGeos
{
    [BepInPlugin("FlowGeos", "FlowGeos", "1.0.0")]
    public class EntryPoint : BasePlugin
    {
        public override void Load()
        {
            m_Harmony = new Harmony("FlowGeos");
            m_Harmony.PatchAll();
        }

        private Harmony m_Harmony;
    }
}
