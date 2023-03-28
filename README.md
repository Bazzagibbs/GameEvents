# Game Events

An implementation of the Scriptable Events system described by Ryan Hipple at [Unite 2017 - Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk).
Other notable sources:
- James Lafritz, [ScriptableObject Game Events](https://blog.devgenius.io/scriptableobject-game-events-1f3401bbde72)
- Jason Weimann, [Game Events - Power & Simplicity in Unity3D](https://www.youtube.com/watch?v=lgA8KirhLEU)

## Using Game Events
### Game Event Assets
Game Event Assets are used to "trigger" all the listeners subscribed to it. On their own, they don't do anything special.

Create Game Event assets in the Assets menu:
```
Create > Game Event > [Type] Event
```
where [Type] is the data you want to send along with the event's invocation, 
or make a regular `Event` asset if you don't need to send any extra data.

### Game Event Listeners
Game Event Listeners can be added to GameObjects, and will trigger whenever the referenced Game Event Asset is invoked.
The listener needs to be of the same data type as the Game Event asset.

### Invoking Game Events
Reference the Game Event asset in the inspector and call its `.Invoke()` method, with data as the parameter if required.

```csharp
class Enemy : MonoBehaviour {
    [SerializeField] private GameEvent m_EnemyJumpedGameEvent;          // Invoked without data
    [SerializeField] private FloatGameEvent m_EnemyDamagedGameEvent;    // Invoked with float data
    
    [SerializeField] private float m_ImpactDamage;

    private void Jump(){
        m_EnemyJumpedGameEvent.Invoke();
    }

    private void OnCollisionEnter(Collision collision){
        m_EnemyDamagedGameEvent.Invoke(m_ImpactDamage);
    }
}
```

## Custom Game Event Types
Before you can pass custom objects as data with the Game Event system, you will need to make a couple of simple scripts.
Unity doesn't know how to serialize generic classes, so we need to make concrete versions with our desired data type.

```csharp
// MyCustomDataGameEvent.cs
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event/MyCustomData Event", fileName = "NewCustomDataEvent", order = 2)]
public class MyCustomDataGameEvent : BaseGameEvent<MyCustomData> { } 
//                                                 ^^^^^^^^^^^^ --- The important part
```
```csharp
// MyCustomDataGameEventListener.cs
public class MyCustomDataGameEventListener : BaseGameEventListener<MyCustomData> { } 
//                                                                 ^^^^^^^^^^^^ --- Also important
```