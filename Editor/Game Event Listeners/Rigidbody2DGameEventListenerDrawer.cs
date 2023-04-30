
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(Rigidbody2DGameEventListenerProp))]
    class Rigidbody2DGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
