using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace RCIndicator.Patches
{
    [HarmonyPatch]
    internal class GUIManagerPatch
    {
        [HarmonyPatch(typeof(Item))]
        [HarmonyPostfix]

        private static void RCPatch(ref Color ___reticleColorHighlight)
        {
            
        }

    }
}
