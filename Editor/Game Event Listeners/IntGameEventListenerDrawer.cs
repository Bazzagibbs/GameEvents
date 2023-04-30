
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(IntGameEventListenerProp))]
    class IntGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
