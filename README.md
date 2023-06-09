﻿# Game Events

An implementation of the Scriptable Events system described by Ryan Hipple at [Unite 2017 - Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk).
Other notable sources:
- James Lafritz, [ScriptableObject Game Events](https://blog.devgenius.io/scriptableobject-game-events-1f3401bbde72)
- Jason Weimann, [Game Events - Power & Simplicity in Unity3D](https://www.youtube.com/watch?v=lgA8KirhLEU)


## Installation

### Option A: Scoped Registry

All my public/open source packages are hosted on [my registry](https://registry.bazzagibbs.com).

1. Install a Scoped Registry: `Project Settings > Package Manager > Scoped Registries`
```
Name:       BazzaGibbs
URL:        https://registry.bazzagibbs.com
Scope(s):   com.bazzagibbs
```
2. In the Package Manager, select "Add package by name", `com.bazzagibbs.gameevents`

### Option B: Git URL

Adding packages by Git URL has the downside of not properly displaying when there is a package update available.

1. In the Package Manager, select "Add package from git URL", `https://github.com/Bazzagibbs/GameEvents.git`


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

Custom types can be passed as event data.
This package comes with an embedded [CodeGen wizard](https://github.com/bazzas-personal-stuff/codegen), which can be accessed through `Tools > Game Events > Create New GameEvent Type`.

Fill out the `TYPE` macro: The type you want to pass as event data, exactly as it would appear in code. E.g. "MyClass", "float".