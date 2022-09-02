using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State {
    private void Start() { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Think() { }

    public StateMachine owner;
}
