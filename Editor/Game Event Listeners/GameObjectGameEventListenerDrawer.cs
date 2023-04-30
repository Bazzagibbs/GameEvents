
using UnityEditor;
using BazzaGibbs.GameEvents;

namespace BazzaGibbs.GameEvents {
    [CustomPropertyDrawer(typeof(GameObjectGameEventListenerProp))]
    class GameObjectGameEventListenerPropDrawer : GameEventListenerDrawer {}
}
