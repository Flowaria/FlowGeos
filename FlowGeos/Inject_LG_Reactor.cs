using GTFO.API;
using HarmonyLib;
using LevelGeneration;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FlowGeos
{
    [HarmonyPatch(typeof(LG_WardenObjective_Reactor), nameof(LG_WardenObjective_Reactor.GenericObjectiveSetup))]
    static class Inject_LG_Reactor
    {
        const string TERMINAL_PREFAB = "ASSETS/ASSETPREFABS/COMPLEX/GENERIC/FUNCTIONMARKERS/TERMINAL_FLOOR.PREFAB";

        static void Prefix(LG_WardenObjective_Reactor __instance)
        {
            if (__instance.m_terminalPrefab == null)
            {
                var ter = AssetAPI.GetLoadedAsset<GameObject>(TERMINAL_PREFAB);
                __instance.m_terminalPrefab = ter;
                FlowGeosLogger.Info("Terminal Prefab Resolved!");
            }
        }
    }
}
