
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(Collider2DGameEventListenerProp))]
    class Collider2DGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
