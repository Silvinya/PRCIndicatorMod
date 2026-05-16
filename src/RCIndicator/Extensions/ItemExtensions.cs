using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

namespace RCIndicator.Extensions
{
    public static class ItemExtensions
    {
        private static readonly ConditionalWeakTable<Item, ItemProperties> _props = new ConditionalWeakTable<Item, ItemProperties>();

        public static bool GetTargetingFriend(this Item item)
        {
            return _props.GetOrCreateValue(item).IsTargetingFriend;
        }

        public static void SetTargetingFriend(this Item item, bool value)
        {
            _props.GetOrCreateValue(item).IsTargetingFriend = value;
        }

        private class ItemProperties
        {
            public bool IsTargetingFriend { get; set; }
        }
    }
}
