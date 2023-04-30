
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(BoolGameEventListenerProp))]
    class BoolGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
