using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/GameObject Event", fileName = "NewGameObjectEvent", order = 2)]
    public class GameObjectGameEvent : BaseGameEvent<GameObject> { } 

}