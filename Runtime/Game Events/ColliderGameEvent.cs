using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/Collider Event", fileName = "NewColliderEvent", order = 2)]
    public class ColliderGameEvent : BaseGameEvent<Collider> { } 

}