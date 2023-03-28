using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Transform Event", fileName = "NewTransformEvent", order = 2)]
    public class TransformGameEvent : BaseGameEvent<Transform> { } 

}