
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(MonoBehaviourGameEventListenerProp))]
    class MonoBehaviourGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
