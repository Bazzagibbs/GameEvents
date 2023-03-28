using UnityEngine;

namespace BazzaGibbs.GameEvents {
    [CreateAssetMenu(menuName = "Game Event/MonoBehaviour Event", fileName = "NewMonoBehaviourEvent", order = 2)]
    public class TestSpec : BaseGameEvent<MonoBehaviour> { } 

}