using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {
    private void Start() { }

    private void OnEnable() {
        StartCoroutine(Think());
    }

    public void ChangeStateDelay(State state, float delay) {
        coroutine = ChangeStateCoroutine(state, delay);
        StartCoroutine(coroutine);
    }

    public void ChangeState(State state) {
        if (currentState != null) {
            currentState.Exit();
        }
        if (previousState == null) {
            this.previousState = currentState;
        }

        currentState = state;
        currentState.owner = this;
        currentState.Enter();
    }

    public void SetGlobalState(State state) {
        if (globalState != null) {
            globalState.Exit();
        }

        globalState = state;

        if (globalState != null) {
            globalState.owner = this;
            globalState.Enter();
        }
    }

    public void CancelDelayedStateChange() {
        if (coroutine != null) {
            StopCoroutine(coroutine);
        }
    }

    public void RevertToPreviousState() {
        ChangeState(previousState);
    }

    private IEnumerator ChangeStateCoroutine(State state, float delay) {
        yield return new WaitForSeconds(delay);
        ChangeState(state);
    }

    private IEnumerator Think() {
        yield return new WaitForSeconds(Random.Range(0, 0.5f));
        while (true) {
            if (globalState != null) {
                globalState.Think();
            }
            if (currentState != null) {
                currentState.Think();
            }

            yield return new WaitForSeconds(1.0f / (float)updatesPerSecond);
        }
    }

    public State currentState;
    public State globalState;
    public State previousState;
    private IEnumerator coroutine;
    public int updatesPerSecond = 5;
}
