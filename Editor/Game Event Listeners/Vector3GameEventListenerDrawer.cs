
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(Vector3GameEventListenerProp))]
    class Vector3GameEventListenerPropDrawer : GameEventListenerDrawer {}
}
