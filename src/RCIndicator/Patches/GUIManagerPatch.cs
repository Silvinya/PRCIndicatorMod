using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace RCIndicator.Patches
{
    [HarmonyPatch(typeof(GUIManager))]
    internal class GUIManagerPatch
    {
        [HarmonyPatch(nameof(GUIManager.UpdateReticle))]
        [HarmonyTranspiler]

        private static void ReticulePatch()
        {
            
        }

    }
}
